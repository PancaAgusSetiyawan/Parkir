Public Class Frm_MENU

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub MasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterToolStripMenuItem.Click
        Frm_Tarif.Show()
    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahUserToolStripMenuItem.Click
        Frm_User.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        'Call LoadAksess()
        Dim pesan As String
        pesan = MsgBox("Log Out User ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Parkirr")
        If pesan = vbYes Then
            Call LoadAksess()
        End If
    End Sub

    Private Sub MasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasukToolStripMenuItem.Click
        Frm_Masuk.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Frm_Keluar.Show()
    End Sub

    Private Sub MasukToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasukToolStripMenuItem1.Click
        FrmLapMasuk.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem1.Click
        FrmLapKeluar.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Frm_About.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Frm_About.Show()
    End Sub

    Private Sub LogInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInToolStripMenuItem.Click
        Frm_LogInUser.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripLabel1.Text = Format(Now, " dd MMM yyyy | hh:mm:ss ")
    End Sub

    Private Sub Frm_MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadAksess()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim pesan As String
        pesan = MsgBox("Keluar Program ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Parkirr")
        If pesan = vbYes Then
            Me.Close()
        End If
    End Sub
End Class