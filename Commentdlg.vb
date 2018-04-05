Public Class Commentdlg

    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
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
        Me.Visible = False
    End Sub
End Class
