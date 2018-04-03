Public Class frmMain
    Private mScanner As VirusTotalScanner
    Private mResults As List(Of ScanResult)
    Private mResultIndex As Integer
    Private mMD5 As String
    Private mSHA256 As String
    Private mSHA512 As String

    Private Sub lblLink2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLink2.LinkClicked
        Try
            System.Diagnostics.Process.Start(lblLink2.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Property ResultIndex As Integer
        Get
            Return mResultIndex
        End Get
        Set(value As Integer)
            Try
                mResultIndex = value
                If IsNothing(mResults) Then mResults = New List(Of ScanResult)
                If mResultIndex < 1 Then mResultIndex = 1
                If mResultIndex > mResults.Count Then mResultIndex = mResults.Count
                cmdNext.Enabled = CBool(mResultIndex < mResults.Count)
                cmdPrev.Enabled = CBool(mResultIndex > 1)
                lblPage.Enabled = CBool(mResultIndex <> 0)
                lblPage.Text = String.Format("{0:0} of {1:0}", mResultIndex, mResults.Count)
                If mResultIndex = 0 Then
                    prpMain.SelectedObject = Nothing
                Else
                    prpMain.SelectedObject = mResults(mResultIndex - 1)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Set
    End Property

    Private Sub cmdOpen_Click_1(sender As Object, e As EventArgs) Handles cmdOpen.Click
        Dim Link As String
        Try
            If IsNothing(mScanner) Then
                If txtKey.Text = "" Then
                    MsgBox("You must first enter your API key.", MsgBoxStyle.Information)
                    txtKey.Focus()
                    Return
                End If
                mScanner = New VirusTotalScanner(txtKey.Text)
                mScanner.UseTLS = True
                txtKey.Enabled = False
            End If
            If dlgOpen.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                txtFile.Text = dlgOpen.FileName
                mMD5 = FileHasher.GetMD5(txtFile.Text)
                mSHA256 = FileHasher.GetSHA256(txtFile.Text)
                mSHA512 = FileHasher.GetSHA512(txtFile.Text)
                lblMD52.Text = mMD5
                lblSHA2562.Text = mSHA256
                lblSHA5122.Text = mSHA512
                Link = mScanner.GetPublicFileScanLink(mSHA256)
                lblLink2.Text = Link
                lblLink2.Links.Clear()
                lblLink2.Links.Add(0, Link.Length)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdSubmit_Click_1(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Try
            mResults = mScanner.SubmitFile(txtFile.Text)
            ResultIndex = 1
        Catch ex As Exception
            mResults = Nothing
            ResultIndex = 0
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        ResultIndex -= 1
    End Sub

    Private Sub cmdPrev_Click(sender As Object, e As EventArgs) Handles cmdPrev.Click
        ResultIndex -= 1
    End Sub

    Private Sub cmdComment_Click_1(sender As Object, e As EventArgs) Handles cmdComment.Click
        Dim Comment As String
        Try
            Comment = Commentdlg.GetComment
            If Comment = "" Then Return
            mResults = mScanner.CreateComment(mSHA256, Comment)
            ResultIndex = 1
        Catch ex As Exception
            mResults = Nothing
            ResultIndex = 0
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdRescan_Click(sender As Object, e As EventArgs) Handles cmdRescan.Click
        Try
            mResults = mScanner.RescanFile(mSHA256)
            ResultIndex = 1
        Catch ex As Exception
            mResults = Nothing
            ResultIndex = 0
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdReport_Click(sender As Object, e As EventArgs) Handles cmdReport.Click
        Dim Report As Report
        Try
            Report = mScanner.GetFileReport(mSHA256)
            prpMain.SelectedObject = Report
        Catch ex As Exception
            prpMain.SelectedObject = Nothing
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
