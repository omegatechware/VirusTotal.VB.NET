Public Class Commentdlg

    Dim commentready As Boolean = False

    Function GetComment()
        txtComment.Text = ""
        Commentbtn.Enabled = False
        commentready = False
        Me.Visible = True
        While commentready = False
            Application.DoEvents()
        End While
        Return txtComment.Text
    End Function

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        commentready = True
        Me.Visible = False
    End Sub

    Private Sub txtComment_TextChanged(sender As Object, e As EventArgs) Handles txtComment.TextChanged
        If txtComment.Text = "" Then
            Commentbtn.Enabled = False
        Else
            Commentbtn.Enabled = True
        End If
    End Sub

    Private Sub Commentbtn_Click(sender As Object, e As EventArgs) Handles Commentbtn.Click
        commentready = True
        Me.Visible = False
    End Sub
End Class
