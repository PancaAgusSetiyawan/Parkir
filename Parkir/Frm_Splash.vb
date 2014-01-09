Public Class Frm_Splash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Pb_Loading.Value < 100 Then
            Pb_Loading.Value += 2
        ElseIf Pb_Loading.Value = 100 Then
            Timer1.Stop()
            MessageBox.Show("Selamat datang di programku ", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Frm_Menu.Show()
        End If
    End Sub

    Private Sub Frm_Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class