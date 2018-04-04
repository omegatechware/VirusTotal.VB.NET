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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.prpMain = New System.Windows.Forms.PropertyGrid()
        Me.lblLink2 = New System.Windows.Forms.LinkLabel()
        Me.txtKey = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtFile = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cmdReport = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cmdSubmit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cmdRescan = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cmdComment = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblPage = New MaterialSkin.Controls.MaterialLabel()
        Me.lblMD51 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblMD52 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSHA2561 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSHA2562 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSHA5121 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblSHA5122 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblLink1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cmdNext = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cmdPrev = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cmdOpen = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'prpMain
        '
        Me.prpMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prpMain.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prpMain.Location = New System.Drawing.Point(12, 208)
        Me.prpMain.Name = "prpMain"
        Me.prpMain.Size = New System.Drawing.Size(663, 331)
        Me.prpMain.TabIndex = 20
        '
        'lblLink2
        '
        Me.lblLink2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblLink2.AutoSize = True
        Me.lblLink2.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.lblLink2.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLink2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.lblLink2.Location = New System.Drawing.Point(88, 182)
        Me.lblLink2.Name = "lblLink2"
        Me.lblLink2.Size = New System.Drawing.Size(13, 19)
        Me.lblLink2.TabIndex = 19
        Me.lblLink2.TabStop = True
        Me.lblLink2.Text = "-"
        Me.lblLink2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(79, Byte), Integer))
        '
        'txtKey
        '
        Me.txtKey.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKey.Depth = 0
        Me.txtKey.Hint = "API Key"
        Me.txtKey.Location = New System.Drawing.Point(12, 9)
        Me.txtKey.MaxLength = 32767
        Me.txtKey.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtKey.Name = "txtKey"
        Me.txtKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKey.SelectedText = ""
        Me.txtKey.SelectionLength = 0
        Me.txtKey.SelectionStart = 0
        Me.txtKey.Size = New System.Drawing.Size(586, 23)
        Me.txtKey.TabIndex = 22
        Me.txtKey.TabStop = False
        Me.txtKey.UseSystemPasswordChar = False
        '
        'txtFile
        '
        Me.txtFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFile.Depth = 0
        Me.txtFile.Hint = "File"
        Me.txtFile.Location = New System.Drawing.Point(12, 41)
        Me.txtFile.MaxLength = 32767
        Me.txtFile.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtFile.Name = "txtFile"
        Me.txtFile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFile.SelectedText = ""
        Me.txtFile.SelectionLength = 0
        Me.txtFile.SelectionStart = 0
        Me.txtFile.Size = New System.Drawing.Size(622, 23)
        Me.txtFile.TabIndex = 23
        Me.txtFile.TabStop = False
        Me.txtFile.UseSystemPasswordChar = False
        '
        'cmdReport
        '
        Me.cmdReport.AutoSize = True
        Me.cmdReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdReport.Depth = 0
        Me.cmdReport.Icon = Nothing
        Me.cmdReport.Location = New System.Drawing.Point(12, 65)
        Me.cmdReport.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdReport.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Primary = False
        Me.cmdReport.Size = New System.Drawing.Size(72, 36)
        Me.cmdReport.TabIndex = 25
        Me.cmdReport.Text = "Report"
        Me.cmdReport.UseVisualStyleBackColor = True
        '
        'cmdSubmit
        '
        Me.cmdSubmit.AutoSize = True
        Me.cmdSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdSubmit.Depth = 0
        Me.cmdSubmit.Icon = Nothing
        Me.cmdSubmit.Location = New System.Drawing.Point(92, 64)
        Me.cmdSubmit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdSubmit.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Primary = False
        Me.cmdSubmit.Size = New System.Drawing.Size(71, 36)
        Me.cmdSubmit.TabIndex = 26
        Me.cmdSubmit.Text = "Submit"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'cmdRescan
        '
        Me.cmdRescan.AutoSize = True
        Me.cmdRescan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdRescan.Depth = 0
        Me.cmdRescan.Icon = Nothing
        Me.cmdRescan.Location = New System.Drawing.Point(171, 64)
        Me.cmdRescan.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdRescan.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdRescan.Name = "cmdRescan"
        Me.cmdRescan.Primary = False
        Me.cmdRescan.Size = New System.Drawing.Size(73, 36)
        Me.cmdRescan.TabIndex = 27
        Me.cmdRescan.Text = "Rescan"
        Me.cmdRescan.UseVisualStyleBackColor = True
        '
        'cmdComment
        '
        Me.cmdComment.AutoSize = True
        Me.cmdComment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdComment.Depth = 0
        Me.cmdComment.Icon = Nothing
        Me.cmdComment.Location = New System.Drawing.Point(252, 65)
        Me.cmdComment.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdComment.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdComment.Name = "cmdComment"
        Me.cmdComment.Primary = False
        Me.cmdComment.Size = New System.Drawing.Size(89, 36)
        Me.cmdComment.TabIndex = 28
        Me.cmdComment.Text = "Comment"
        Me.cmdComment.UseVisualStyleBackColor = True
        '
        'lblPage
        '
        Me.lblPage.AutoSize = True
        Me.lblPage.Depth = 0
        Me.lblPage.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPage.Location = New System.Drawing.Point(397, 73)
        Me.lblPage.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(47, 19)
        Me.lblPage.TabIndex = 31
        Me.lblPage.Text = "0 of 0"
        '
        'lblMD51
        '
        Me.lblMD51.AutoSize = True
        Me.lblMD51.Depth = 0
        Me.lblMD51.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMD51.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMD51.Location = New System.Drawing.Point(39, 104)
        Me.lblMD51.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMD51.Name = "lblMD51"
        Me.lblMD51.Size = New System.Drawing.Size(44, 19)
        Me.lblMD51.TabIndex = 32
        Me.lblMD51.Text = "MD5:"
        '
        'lblMD52
        '
        Me.lblMD52.AutoSize = True
        Me.lblMD52.Depth = 0
        Me.lblMD52.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMD52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMD52.Location = New System.Drawing.Point(89, 104)
        Me.lblMD52.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMD52.Name = "lblMD52"
        Me.lblMD52.Size = New System.Drawing.Size(13, 19)
        Me.lblMD52.TabIndex = 33
        Me.lblMD52.Text = "-"
        '
        'lblSHA2561
        '
        Me.lblSHA2561.AutoSize = True
        Me.lblSHA2561.Depth = 0
        Me.lblSHA2561.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSHA2561.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSHA2561.Location = New System.Drawing.Point(12, 130)
        Me.lblSHA2561.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSHA2561.Name = "lblSHA2561"
        Me.lblSHA2561.Size = New System.Drawing.Size(71, 19)
        Me.lblSHA2561.TabIndex = 34
        Me.lblSHA2561.Text = "SHA-256:"
        '
        'lblSHA2562
        '
        Me.lblSHA2562.AutoSize = True
        Me.lblSHA2562.Depth = 0
        Me.lblSHA2562.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSHA2562.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSHA2562.Location = New System.Drawing.Point(88, 130)
        Me.lblSHA2562.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSHA2562.Name = "lblSHA2562"
        Me.lblSHA2562.Size = New System.Drawing.Size(13, 19)
        Me.lblSHA2562.TabIndex = 35
        Me.lblSHA2562.Text = "-"
        '
        'lblSHA5121
        '
        Me.lblSHA5121.AutoSize = True
        Me.lblSHA5121.Depth = 0
        Me.lblSHA5121.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSHA5121.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSHA5121.Location = New System.Drawing.Point(12, 156)
        Me.lblSHA5121.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSHA5121.Name = "lblSHA5121"
        Me.lblSHA5121.Size = New System.Drawing.Size(71, 19)
        Me.lblSHA5121.TabIndex = 36
        Me.lblSHA5121.Text = "SHA-512:"
        '
        'lblSHA5122
        '
        Me.lblSHA5122.AutoSize = True
        Me.lblSHA5122.Depth = 0
        Me.lblSHA5122.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSHA5122.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSHA5122.Location = New System.Drawing.Point(89, 156)
        Me.lblSHA5122.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSHA5122.Name = "lblSHA5122"
        Me.lblSHA5122.Size = New System.Drawing.Size(13, 19)
        Me.lblSHA5122.TabIndex = 37
        Me.lblSHA5122.Text = "-"
        '
        'lblLink1
        '
        Me.lblLink1.AutoSize = True
        Me.lblLink1.Depth = 0
        Me.lblLink1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblLink1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLink1.Location = New System.Drawing.Point(42, 182)
        Me.lblLink1.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblLink1.Name = "lblLink1"
        Me.lblLink1.Size = New System.Drawing.Size(40, 19)
        Me.lblLink1.TabIndex = 38
        Me.lblLink1.Text = "URL:"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(605, 2)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(79, 36)
        Me.MaterialFlatButton1.TabIndex = 39
        Me.MaterialFlatButton1.Text = "Default"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.AutoSize = True
        Me.cmdNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdNext.Depth = 0
        Me.cmdNext.Icon = Global.VirusTotalTestbed.My.Resources.Resources.forward
        Me.cmdNext.Location = New System.Drawing.Point(445, 65)
        Me.cmdNext.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdNext.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Primary = False
        Me.cmdNext.Size = New System.Drawing.Size(44, 36)
        Me.cmdNext.TabIndex = 30
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdPrev
        '
        Me.cmdPrev.AutoSize = True
        Me.cmdPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdPrev.Depth = 0
        Me.cmdPrev.Icon = Global.VirusTotalTestbed.My.Resources.Resources.backward
        Me.cmdPrev.Location = New System.Drawing.Point(353, 64)
        Me.cmdPrev.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdPrev.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.Primary = False
        Me.cmdPrev.Size = New System.Drawing.Size(44, 36)
        Me.cmdPrev.TabIndex = 29
        Me.cmdPrev.UseVisualStyleBackColor = True
        '
        'cmdOpen
        '
        Me.cmdOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOpen.AutoSize = True
        Me.cmdOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdOpen.Depth = 0
        Me.cmdOpen.Icon = Global.VirusTotalTestbed.My.Resources.Resources.browse
        Me.cmdOpen.Location = New System.Drawing.Point(641, 38)
        Me.cmdOpen.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cmdOpen.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Primary = False
        Me.cmdOpen.Size = New System.Drawing.Size(44, 36)
        Me.cmdOpen.TabIndex = 24
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 547)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.lblLink1)
        Me.Controls.Add(Me.lblSHA5122)
        Me.Controls.Add(Me.lblSHA5121)
        Me.Controls.Add(Me.lblSHA2562)
        Me.Controls.Add(Me.lblSHA2561)
        Me.Controls.Add(Me.lblMD52)
        Me.Controls.Add(Me.lblMD51)
        Me.Controls.Add(Me.lblPage)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdPrev)
        Me.Controls.Add(Me.cmdComment)
        Me.Controls.Add(Me.cmdRescan)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.cmdReport)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.lblLink2)
        Me.Controls.Add(Me.prpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(505, 480)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VirusTotal Interface Testbed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents prpMain As System.Windows.Forms.PropertyGrid
    Friend WithEvents lblLink2 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtKey As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtFile As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cmdOpen As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents cmdReport As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents cmdSubmit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents cmdRescan As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents cmdComment As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents cmdPrev As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents cmdNext As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblPage As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMD51 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMD52 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSHA2561 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSHA2562 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSHA5121 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSHA5122 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblLink1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
End Class
