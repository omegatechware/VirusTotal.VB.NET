Imports RestSharp
Imports RestSharp.Deserializers
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
''' <summary>
''' Other than removing the URL functions and converting the IEnumerable code to utilize a 
''' List(Of T) instead, the following classes and enums are pretty much a direct port of the 
''' example code provided by Genbox, which can be found at:
'''     https://github.com/Genbox/VirusTotal.NET
''' Also, as you can probably tell, I'm not really big on documentation, but the code is simple
''' enough that you should be able to to understand it with little trouble. :)
''' </summary>
Public Enum ReportResponseCode
    StillQueued = -2 'The requested item is still queued for analysis.
    [Error] = -1 'There was an error in the request
    NotPresent = 0 'The item you searched for was not present in VirusTotal's dataset.
    Present = 1 'The item was indeed present and it could be retrieved.
End Enum
Public Enum ScanResponseCode
    NotPresent = -1 'The file was not present in the store.
    [Error] = 0 'An error occured.
    Queued = 1 'The file corresponding to the given hash was successfully queued.
End Enum
Public Class VirusTotalScanner
    Private Const MaximumFileSize = 32 * (2 ^ 20) '32 MB
    Private pClient As RestClient
    Private mAPIKey As String
    Private mUseTLS As Boolean
    Private mRetryCounter As Integer
    Private mRetry As Integer
    Public Sub New(APIKey As String)
        frmMain.txtKey.Text = "006ba59175ac1efc8ed7066312eac3586ec27cf34925a937d670a165427f68a3"
        pClient = New RestClient
        pClient.BaseUrl = "http://www.virustotal.com/vtapi/v2/"
        pClient.FollowRedirects = False
        mAPIKey = APIKey
        mUseTLS = True
        mRetryCounter = 3
        mRetry = 3
    End Sub
    Public Property UseTLS() As Boolean
        Get
            Return mUseTLS
        End Get
        Set(value As Boolean)
            mUseTLS = value
            If mUseTLS Then
                pClient.BaseUrl = "https://www.virustotal.com/vtapi/v2/"
            Else
                pClient.BaseUrl = "http://www.virustotal.com/vtapi/v2/"
            End If
        End Set
    End Property
    Public Property Proxy() As IWebProxy
        Get
            Return pClient.Proxy
        End Get
        Set(value As IWebProxy)
            pClient.Proxy = value
        End Set
    End Property
    Public Property Retry() As Integer
        Get
            Return mRetry
        End Get
        Set(value As Integer)
            mRetry = value
            mRetryCounter = value
        End Set
    End Property
    Public Property Timeout() As Integer
        Get
            Return pClient.Timeout
        End Get
        Set(value As Integer)
            pClient.Timeout = value
        End Set
    End Property
    Public Function GetFileReport(Hash As String) As Report
        Dim Request As RestRequest
        Request = New RestRequest("file/report", Method.POST)
        Request.AddParameter("apikey", mAPIKey)
        Request.AddParameter("resource", Hash)
        Return GetReport(Request, True)
    End Function
    Public Function SubmitFile(Filename As String) As List(Of ScanResult)
        Dim File As FileInfo
        Dim Request As RestRequest
        File = New FileInfo(Filename)
        Request = New RestRequest("file/scan", Method.POST)
        Request.AddParameter("apikey", mAPIKey)
        If File.Length <= MaximumFileSize Then
            Request.AddFile("file", Filename)
        Else
            Throw New SizeLimitException("The filesize limit on VirusTotal is 32 MB. Your file is " & File.Length \ 1024 \ 1024 & " MB")
        End If
        Return GetScanResults(Request, True)
    End Function
    Public Function RescanFile(Hash As String) As List(Of ScanResult)
        Dim Request As RestRequest
        Request = New RestRequest("file/rescan", Method.POST)
        Request.AddParameter("apikey", mAPIKey)
        Request.AddParameter("resource", Hash)
        Return GetScanResults(Request, True)
    End Function
    Public Function CreateComment(Hash As String, Comment As String) As List(Of ScanResult)
        Dim Request As RestRequest
        Request = New RestRequest("comments/put", Method.POST)
        Request.AddParameter("apikey", mAPIKey)
        Request.AddParameter("resource", Hash)
        Request.AddParameter("comment", Comment)
        Return GetScanResults(Request, True)
    End Function
    Public Function GetPublicFileScanLink(Hash As String) As String
        Return String.Format("{0}://www.virustotal.com/file/{1}/analysis/", If(mUseTLS, "https", "http"), Hash)
    End Function
    Private Function GetReport(Request As RestRequest, Optional ApplyHack As Boolean = False) As Report
        Dim Response As RestResponse
        Dim Deserializer As IDeserializer
        Dim Report As Report
        Response = pClient.Execute(Request)
        If Response.StatusCode = HttpStatusCode.NoContent Then Throw New RateLimitException("You have reached the 5 requests pr. min. limit of VirusTotal")
        If Response.StatusCode = HttpStatusCode.Forbidden Then Throw New AccessDeniedException("You don't have access to the service. Make sure your API key is working correctly.")
        If Response.ErrorException IsNot Nothing Then Throw Response.ErrorException
        If Response.StatusCode <> HttpStatusCode.OK Then Throw New Exception("API gave error code " & Response.StatusCode)
        If String.IsNullOrEmpty(Response.Content) Then Throw New Exception("There was no content in the response.")
        If ApplyHack Then
            Response.Content = Regex.Replace(Response.Content, """([\w\d -\._]+)"": \{""detected"":", "{""name"": ""$1"", ""detected"":", RegexOptions.Compiled Or RegexOptions.CultureInvariant)
            Response.Content = Response.Content.Replace("scans"": {", "scans"": [")
            Response.Content = Response.Content.Replace("}}", "}]")
        End If
        Deserializer = New JsonDeserializer
        Try
            Report = Deserializer.Deserialize(Of Report)(Response)
        Catch generatedExceptionName As SerializationException
            Try
                mRetryCounter -= 1
                If mRetryCounter <= 0 Then
                    mRetryCounter = Retry
                    Return Nothing
                End If
                Report = GetReport(Request, ApplyHack)
            Catch ex As SerializationException
                Throw New Exception("Failed to deserialize request.", ex)
            End Try
        End Try
        mRetryCounter = Retry
        Return Report
    End Function
    Private Function GetScanResults(Request As RestRequest, Optional ApplyHack As Boolean = False) As List(Of ScanResult)
        Dim Response As RestResponse
        Dim Deserializer As IDeserializer
        Dim Result As List(Of ScanResult)
        Response = pClient.Execute(Request)
        If Response.StatusCode = HttpStatusCode.NoContent Then Throw New RateLimitException("You have reached the 5 requests pr. min. limit of VirusTotal")
        If Response.StatusCode = HttpStatusCode.Forbidden Then Throw New AccessDeniedException("You don't have access to the service. Make sure your API key is working correctly.")
        If Response.ErrorException IsNot Nothing Then Throw Response.ErrorException
        If Response.StatusCode <> HttpStatusCode.OK Then Throw New Exception("API gave error code " & Response.StatusCode)
        If String.IsNullOrEmpty(Response.Content) Then Throw New Exception("There was no content in the response.")
        If ApplyHack Then
            Response.Content = Regex.Replace(Response.Content, """([\w\d -\._]+)"": \{""detected"":", "{""name"": ""$1"", ""detected"":", RegexOptions.Compiled Or RegexOptions.CultureInvariant)
            Response.Content = Response.Content.Replace("scans"": {", "scans"": [")
            Response.Content = Response.Content.Replace("}}", "}]")
        End If
        Deserializer = New JsonDeserializer
        Try
            Result = Deserializer.Deserialize(Of List(Of ScanResult))(Response)
        Catch generatedExceptionName As SerializationException
            Try
                mRetryCounter -= 1
                If mRetryCounter <= 0 Then
                    mRetryCounter = Retry
                    Return Nothing
                End If
                Result = GetScanResults(Request, ApplyHack)
            Catch ex As SerializationException
                Throw New Exception("Failed to deserialize request.", ex)
            End Try
        End Try
        mRetryCounter = Retry
        Return Result
    End Function
End Class
Public Class FileHasher
    Public Shared Function GetSHA256(Filename As String) As String
        Dim SHA256 As SHA256CryptoServiceProvider
        Dim FileStream As FileStream
        SHA256 = New SHA256CryptoServiceProvider
        FileStream = New FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.Read Or FileShare.Write Or FileShare.Delete, 8192)
        SHA256.ComputeHash(FileStream)
        FileStream.Close()
        Return ByteArrayToString(SHA256.Hash)
    End Function
    Public Shared Function GetSHA512(Filename As String) As String
        Dim SHA512 As SHA512CryptoServiceProvider
        Dim FileStream As FileStream
        SHA512 = New SHA512CryptoServiceProvider
        FileStream = New FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.Read Or FileShare.Write Or FileShare.Delete, 8192)
        SHA512.ComputeHash(FileStream)
        FileStream.Close()
        Return ByteArrayToString(SHA512.Hash)
    End Function
    Public Shared Function GetMD5(Filename As String) As String
        Dim MD5 As MD5CryptoServiceProvider
        Dim FileStream As FileStream
        MD5 = New MD5CryptoServiceProvider
        FileStream = New FileStream(Filename, FileMode.Open, FileAccess.Read, FileShare.Read Or FileShare.Write Or FileShare.Delete, 8192)
        MD5.ComputeHash(FileStream)
        FileStream.Close()
        Return ByteArrayToString(MD5.Hash)
    End Function
    Private Shared Function ByteArrayToString(Data As Byte()) As String
        Dim Builder As StringBuilder
        Builder = New StringBuilder(Data.Length * 2)
        For Each B As Byte In Data
            Builder.AppendFormat("{0:x2}", B)
        Next
        Return Builder.ToString.ToLower
    End Function
End Class
Public Class Report
    Private mFileScanID As String
    Private mResource As String
    Private mScanID As String
    Private mMD5 As String
    Private mSHA1 As String
    Private mSHA256 As String
    Private mScanDate As DateTime
    Private mPositives As Integer
    Private mTotal As Integer
    Private mPermalink As String
    Private mScans As List(Of ScanEngine)
    Private mResponseCode As ReportResponseCode
    Private mVerboseMsg As String
    Public Property FileScanID() As String
        Get
            Return mFileScanID
        End Get
        Set(value As String)
            mFileScanID = value
        End Set
    End Property
    Public Property Resource() As String
        Get
            Return mResource
        End Get
        Set(value As String)
            mResource = value
        End Set
    End Property
    Public Property ScanID() As String
        Get
            Return mScanID
        End Get
        Set(value As String)
            mScanID = value
        End Set
    End Property
    Public Property MD5() As String
        Get
            Return mMD5
        End Get
        Set(value As String)
            mMD5 = value
        End Set
    End Property
    Public Property SHA1() As String
        Get
            Return mSHA1
        End Get
        Set(value As String)
            mSHA1 = value
        End Set
    End Property
    Public Property SHA256() As String
        Get
            Return mSHA256
        End Get
        Set(value As String)
            mSHA256 = value
        End Set
    End Property
    Public Property ScanDate() As DateTime
        Get
            Return mScanDate
        End Get
        Set(value As DateTime)
            mScanDate = value
        End Set
    End Property
    Public Property Positives() As Integer
        Get
            Return mPositives
        End Get
        Set(value As Integer)
            mPositives = value
        End Set
    End Property
    Public Property Total() As Integer
        Get
            Return mTotal
        End Get
        Set(value As Integer)
            mTotal = value
        End Set
    End Property
    Public Property Permalink() As String
        Get
            Return mPermalink
        End Get
        Set(value As String)
            mPermalink = value
        End Set
    End Property
    Public Property Scans() As List(Of ScanEngine)
        Get
            Return mScans
        End Get
        Set(value As List(Of ScanEngine))
            mScans = value
        End Set
    End Property
    Public Property ResponseCode() As ReportResponseCode
        Get
            Return mResponseCode
        End Get
        Set(value As ReportResponseCode)
            mResponseCode = value
        End Set
    End Property
    Public Property VerboseMsg() As String
        Get
            Return mVerboseMsg
        End Get
        Set(value As String)
            mVerboseMsg = value
        End Set
    End Property
End Class
Public Class ScanEngine
    Private mName As String
    Private mDetected As Boolean
    Private mVersion As String
    Private mResult As String
    Private mUpdateDate As DateTime
    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(value As String)
            mName = value
        End Set
    End Property
    Public Property Detected() As Boolean
        Get
            Return mDetected
        End Get
        Set(value As Boolean)
            mDetected = value
        End Set
    End Property
    Public Property Version() As String
        Get
            Return mVersion
        End Get
        Set(value As String)
            mVersion = value
        End Set
    End Property
    Public Property Result() As String
        Get
            Return mResult
        End Get
        Set(value As String)
            mResult = value
        End Set
    End Property
    <DeserializeAs(Name:="update")> _
    Public Property UpdateString() As String
        Get
            Return UpdateDate.ToString()
        End Get
        Set(value As String)
            Dim Result As DateTime
            If DateTime.TryParseExact(value, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, Result) Then UpdateDate = Result
        End Set
    End Property
    Public Property UpdateDate() As DateTime
        Get
            Return mUpdateDate
        End Get
        Set(value As DateTime)
            mUpdateDate = value
        End Set
    End Property
End Class
Public Class ScanResult
    Private mResponseCode As ScanResponseCode
    Private mVerboseMsg As String
    Private mResource As String
    Private mScanID As String
    Private mPermalink As String
    Private mSHA256 As String
    Public Property ResponseCode() As ScanResponseCode
        Get
            Return mResponseCode
        End Get
        Set(value As ScanResponseCode)
            mResponseCode = value
        End Set
    End Property
    Public Property VerboseMsg() As String
        Get
            Return mVerboseMsg
        End Get
        Set(value As String)
            mVerboseMsg = value
        End Set
    End Property
    Public Property Resource() As String
        Get
            Return mResource
        End Get
        Set(value As String)
            mResource = value
        End Set
    End Property
    Public Property ScanID() As String
        Get
            Return mScanID
        End Get
        Set(value As String)
            mScanID = value
        End Set
    End Property
    Public Property Permalink() As String
        Get
            Return mPermalink
        End Get
        Set(value As String)
            mPermalink = value
        End Set
    End Property
    Public Property SHA256() As String
        Get
            Return mSHA256
        End Get
        Set(value As String)
            mSHA256 = value
        End Set
    End Property
End Class
Public Class AccessDeniedException
    Inherits Exception
    Public Sub New(Message As String)
        MyBase.New(Message)
    End Sub
End Class
Public Class InvalidResourceException
    Inherits Exception
    Public Sub New(Message As String)
        MyBase.New(Message)
    End Sub
End Class
Public Class RateLimitException
    Inherits Exception
    Public Sub New(Message As String)
        MyBase.New(Message)
    End Sub
End Class
Public Class SizeLimitException
    Inherits Exception
    Public Sub New(Message As String)
        MyBase.New(Message)
    End Sub
End Class
