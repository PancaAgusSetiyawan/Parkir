Public Class Frm_LogIn

    Private Sub BTNLOG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TXTID.Text = "" Then
            MsgBox("ID HARUS DIISI")
            TXTID.Focus()
        ElseIf TXTPASS.Text = "" Then
            MsgBox("PASSWORD HARUS DIISI")
            TXTPASS.Focus()
        ElseIf TXTID.Text = "ADMIN" And TXTPASS.Text = "12345" Then
            MsgBox("LOGIN SUKSESS ")
            Frm_Menu.Show()
            Me.Hide()
        ElseIf TXTID.Text = "ADMIN" Then
            MsgBox("PASSWORD SALAH")
            TXTPASS.Focus()
            TXTPASS.Focus()
        ElseIf TXTPASS.Text = "12345" Then
            MsgBox("ID USER SALAH")
            TXTID.Text = ""
            TXTID.Focus()
        Else
            MsgBox(" ID USER DAN PASSWORD SALAH ")
            TXTID.Text = ""
            TXTPASS.Text = ""
            TXTID.Focus()
        End If
    End Sub

End Class