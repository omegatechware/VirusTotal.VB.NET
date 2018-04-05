<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Commentdlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Commentdlg))
        Me.Commentbtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtComment = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Cancelbtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'Commentbtn
        '
        Me.Commentbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Commentbtn.AutoSize = True
        Me.Commentbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Commentbtn.Depth = 0
        Me.Commentbtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Commentbtn.Enabled = False
        Me.Commentbtn.Icon = Nothing
        Me.Commentbtn.Location = New System.Drawing.Point(473, 9)
        Me.Commentbtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Commentbtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Commentbtn.Name = "Commentbtn"
        Me.Commentbtn.Primary = False
        Me.Commentbtn.Size = New System.Drawing.Size(89, 36)
        Me.Commentbtn.TabIndex = 1
        Me.Commentbtn.Text = "Comment"
        Me.Commentbtn.UseVisualStyleBackColor = True
        '
        'txtComment
        '
        Me.txtComment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComment.Depth = 0
        Me.txtComment.Hint = "Your Comment"
        Me.txtComment.Location = New System.Drawing.Point(12, 19)
        Me.txtComment.MaxLength = 32767
        Me.txtComment.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtComment.Name = "txtComment"
        Me.txtComment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComment.SelectedText = ""
        Me.txtComment.SelectionLength = 0
        Me.txtComment.SelectionStart = 0
        Me.txtComment.Size = New System.Drawing.Size(373, 23)
        Me.txtComment.TabIndex = 2
        Me.txtComment.TabStop = False
        Me.txtComment.UseSystemPasswordChar = False
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancelbtn.AutoSize = True
        Me.Cancelbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Cancelbtn.Depth = 0
        Me.Cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelbtn.Icon = Nothing
        Me.Cancelbtn.Location = New System.Drawing.Point(392, 9)
        Me.Cancelbtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Cancelbtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Primary = False
        Me.Cancelbtn.Size = New System.Drawing.Size(73, 36)
        Me.Cancelbtn.TabIndex = 3
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'Commentdlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 54)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.Commentbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Commentdlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Comment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Commentbtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtComment As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Cancelbtn As MaterialSkin.Controls.MaterialFlatButton
End Class
