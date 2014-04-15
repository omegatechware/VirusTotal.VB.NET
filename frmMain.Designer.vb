<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmdReport = New System.Windows.Forms.Button()
        Me.prpMain = New System.Windows.Forms.PropertyGrid()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.lblMD51 = New System.Windows.Forms.Label()
        Me.lblMD52 = New System.Windows.Forms.Label()
        Me.lblSHA2561 = New System.Windows.Forms.Label()
        Me.lblSHA2562 = New System.Windows.Forms.Label()
        Me.lblSHA5121 = New System.Windows.Forms.Label()
        Me.lblSHA5122 = New System.Windows.Forms.Label()
        Me.cmdPrev = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.cmdRescan = New System.Windows.Forms.Button()
        Me.cmdComment = New System.Windows.Forms.Button()
        Me.lblLink1 = New System.Windows.Forms.Label()
        Me.lblLink2 = New System.Windows.Forms.LinkLabel()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(39, 41)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(29, 13)
        Me.lblFile.TabIndex = 2
        Me.lblFile.Text = "File :"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(77, 38)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ReadOnly = True
        Me.txtFile.Size = New System.Drawing.Size(543, 20)
        Me.txtFile.TabIndex = 3
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(626, 38)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(28, 20)
        Me.cmdOpen.TabIndex = 4
        Me.cmdOpen.Text = "&..."
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(47, 63)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(75, 20)
        Me.cmdReport.TabIndex = 5
        Me.cmdReport.Text = "Report"
        Me.cmdReport.UseVisualStyleBackColor = True
        '
        'prpMain
        '
        Me.prpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prpMain.Location = New System.Drawing.Point(12, 194)
        Me.prpMain.Name = "prpMain"
        Me.prpMain.Size = New System.Drawing.Size(642, 335)
        Me.prpMain.TabIndex = 20
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(128, 63)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(75, 20)
        Me.cmdSubmit.TabIndex = 6
        Me.cmdSubmit.Text = "&Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'lblMD51
        '
        Me.lblMD51.AutoSize = True
        Me.lblMD51.Location = New System.Drawing.Point(32, 93)
        Me.lblMD51.Name = "lblMD51"
        Me.lblMD51.Size = New System.Drawing.Size(36, 13)
        Me.lblMD51.TabIndex = 12
        Me.lblMD51.Text = "MD5 :"
        '
        'lblMD52
        '
        Me.lblMD52.AutoSize = True
        Me.lblMD52.Location = New System.Drawing.Point(74, 93)
        Me.lblMD52.Name = "lblMD52"
        Me.lblMD52.Size = New System.Drawing.Size(13, 13)
        Me.lblMD52.TabIndex = 13
        Me.lblMD52.Text = "--"
        '
        'lblSHA2561
        '
        Me.lblSHA2561.AutoSize = True
        Me.lblSHA2561.Location = New System.Drawing.Point(12, 119)
        Me.lblSHA2561.Name = "lblSHA2561"
        Me.lblSHA2561.Size = New System.Drawing.Size(56, 13)
        Me.lblSHA2561.TabIndex = 14
        Me.lblSHA2561.Text = "SHA-256 :"
        '
        'lblSHA2562
        '
        Me.lblSHA2562.AutoSize = True
        Me.lblSHA2562.Location = New System.Drawing.Point(74, 119)
        Me.lblSHA2562.Name = "lblSHA2562"
        Me.lblSHA2562.Size = New System.Drawing.Size(13, 13)
        Me.lblSHA2562.TabIndex = 15
        Me.lblSHA2562.Text = "--"
        '
        'lblSHA5121
        '
        Me.lblSHA5121.AutoSize = True
        Me.lblSHA5121.Location = New System.Drawing.Point(12, 145)
        Me.lblSHA5121.Name = "lblSHA5121"
        Me.lblSHA5121.Size = New System.Drawing.Size(56, 13)
        Me.lblSHA5121.TabIndex = 16
        Me.lblSHA5121.Text = "SHA-512 :"
        '
        'lblSHA5122
        '
        Me.lblSHA5122.AutoSize = True
        Me.lblSHA5122.Location = New System.Drawing.Point(74, 145)
        Me.lblSHA5122.Name = "lblSHA5122"
        Me.lblSHA5122.Size = New System.Drawing.Size(13, 13)
        Me.lblSHA5122.TabIndex = 17
        Me.lblSHA5122.Text = "--"
        '
        'cmdPrev
        '
        Me.cmdPrev.Enabled = False
        Me.cmdPrev.Location = New System.Drawing.Point(371, 63)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Size = New System.Drawing.Size(28, 20)
        Me.cmdPrev.TabIndex = 9
        Me.cmdPrev.Text = "<"
        Me.cmdPrev.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Enabled = False
        Me.cmdNext.Location = New System.Drawing.Point(460, 63)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(28, 20)
        Me.cmdNext.TabIndex = 11
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'lblPage
        '
        Me.lblPage.Location = New System.Drawing.Point(405, 63)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(49, 20)
        Me.lblPage.TabIndex = 10
        Me.lblPage.Text = "0 of 0"
        Me.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdRescan
        '
        Me.cmdRescan.Location = New System.Drawing.Point(209, 63)
        Me.cmdRescan.Name = "cmdRescan"
        Me.cmdRescan.Size = New System.Drawing.Size(75, 20)
        Me.cmdRescan.TabIndex = 7
        Me.cmdRescan.Text = "Resca&n"
        Me.cmdRescan.UseVisualStyleBackColor = True
        '
        'cmdComment
        '
        Me.cmdComment.Location = New System.Drawing.Point(290, 63)
        Me.cmdComment.Name = "cmdComment"
        Me.cmdComment.Size = New System.Drawing.Size(75, 20)
        Me.cmdComment.TabIndex = 8
        Me.cmdComment.Text = "&Comment"
        Me.cmdComment.UseVisualStyleBackColor = True
        '
        'lblLink1
        '
        Me.lblLink1.AutoSize = True
        Me.lblLink1.Location = New System.Drawing.Point(35, 171)
        Me.lblLink1.Name = "lblLink1"
        Me.lblLink1.Size = New System.Drawing.Size(33, 13)
        Me.lblLink1.TabIndex = 18
        Me.lblLink1.Text = "Link :"
        '
        'lblLink2
        '
        Me.lblLink2.AutoSize = True
        Me.lblLink2.Location = New System.Drawing.Point(74, 171)
        Me.lblLink2.Name = "lblLink2"
        Me.lblLink2.Size = New System.Drawing.Size(13, 13)
        Me.lblLink2.TabIndex = 19
        Me.lblLink2.TabStop = True
        Me.lblLink2.Text = "--"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(17, 15)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(51, 13)
        Me.lblKey.TabIndex = 0
        Me.lblKey.Text = "API Key :"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(77, 12)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(577, 20)
        Me.txtKey.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 541)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblLink2)
        Me.Controls.Add(Me.lblLink1)
        Me.Controls.Add(Me.cmdComment)
        Me.Controls.Add(Me.cmdRescan)
        Me.Controls.Add(Me.lblPage)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.lblSHA5122)
        Me.Controls.Add(Me.lblSHA5121)
        Me.Controls.Add(Me.lblSHA2562)
        Me.Controls.Add(Me.lblSHA2561)
        Me.Controls.Add(Me.lblMD52)
        Me.Controls.Add(Me.lblMD51)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.prpMain)
        Me.Controls.Add(Me.cmdReport)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.lblFile)
        Me.Name = "frmMain"
        Me.Text = "VirusTotal Interface Testbed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents cmdOpen As System.Windows.Forms.Button
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdReport As System.Windows.Forms.Button
    Friend WithEvents prpMain As System.Windows.Forms.PropertyGrid
    Friend WithEvents cmdSubmit As System.Windows.Forms.Button
    Friend WithEvents lblMD51 As System.Windows.Forms.Label
    Friend WithEvents lblMD52 As System.Windows.Forms.Label
    Friend WithEvents lblSHA2561 As System.Windows.Forms.Label
    Friend WithEvents lblSHA2562 As System.Windows.Forms.Label
    Friend WithEvents lblSHA5121 As System.Windows.Forms.Label
    Friend WithEvents lblSHA5122 As System.Windows.Forms.Label
    Friend WithEvents cmdPrev As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents lblPage As System.Windows.Forms.Label
    Friend WithEvents cmdRescan As System.Windows.Forms.Button
    Friend WithEvents cmdComment As System.Windows.Forms.Button
    Friend WithEvents lblLink1 As System.Windows.Forms.Label
    Friend WithEvents lblLink2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblKey As System.Windows.Forms.Label
    Friend WithEvents txtKey As System.Windows.Forms.TextBox

End Class
