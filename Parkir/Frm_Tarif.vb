Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Frm_Tarif

    Private Sub ListGrid()
        Try
            Mycon = New OleDbConnection(StrCon)
            ObjDataTabel = New DataTable
            Mycon.Open()
            StrSql = "Select * from Tb_tarif"
            ObjCommand = New OleDbCommand(StrSql, Mycon)
            ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
            ObjDataTabel.Load(ObjReader)
            GrdTarif.DataSource = ObjDataTabel
            ObjCommand.Dispose()
            ObjReader.Close()
            ObjCommand = Nothing
            ObjReader = Nothing
            Mycon = Nothing
        Catch ex As Exception
            GrdTarif = Nothing
        End Try
    End Sub

    Private Sub LockText()
        Txtjam_1.ReadOnly = True
        TxtJam_2.ReadOnly = True
        TxtJam_Max.ReadOnly = True
        TxtJns_kend.ReadOnly = True
    End Sub

    Private Sub UnLockText()
        Txtjam_1.ReadOnly = False
        TxtJam_2.ReadOnly = False
        TxtJam_Max.ReadOnly = False
        TxtJns_kend.ReadOnly = False
    End Sub

    Private Sub Kosong()
        Txtjam_1.Text = ""
        TxtJam_2.Text = ""
        TxtJam_Max.Text = ""
        TxtJns_kend.Text = ""
    End Sub
    Private Sub Frm_Tarif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ListGrid()
        Call Kosong()
        Call LockText()
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Call Kosong()
        Call UnLockText()
        BtnSave.Enabled = True
        BtnCancel.Enabled = True
        BtnAdd.Enabled = False
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        BtnExit.Enabled = False
        TxtJns_kend.Focus()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Txtjam_1.Text = "" Then
            MsgBox("Jam pertama kosong")
            Txtjam_1.Focus()
        ElseIf TxtJam_2.Text = "" Then
            MsgBox("JAm kedua kosong ")
            TxtJam_2.Focus()
        ElseIf TxtJam_Max.Text = "" Then
            MsgBox("Jam maximal Kosong")
            TxtJam_Max.Focus()
        ElseIf TxtJns_kend.Text = "" Then
            MsgBox("Jenis Kendaraan Kosong ")
            TxtJns_kend.Focus()
        Else
            Mycon = New OleDbConnection(StrCon)
            Try
                Mycon.Open()
                StrSql = "Select * from tb_tarif where jns_kend = '" & Trim(TxtJns_kend.Text) & "'"
                ObjCommand = New OleDbCommand(StrSql, Mycon)
                ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
                If ObjReader.HasRows Then
                    MsgBox("Data Sudah Ada")
                Else
                    ObjCommand.Dispose()
                    StrSql = "Insert Into Tb_Tarif (jns_kend,jam_1, jam_2, TARIF_max) values ('" & TxtJns_kend.Text & "','" & Txtjam_1.Text & "', '" & TxtJam_2.Text & "', '" & TxtJam_Max.Text & "')"
                    ObjCommand = New OleDbCommand(StrSql, Mycon)
                    If ObjCommand.ExecuteNonQuery Then
                        MsgBox("Data Telah Disimpan")
                    Else
                        MsgBox("Penyimpanan Gagal ")
                    End If
                    ObjReader.Close()
                End If
            Catch ex As Exception
                MsgBox("error")
            Finally
                Mycon.Close()
                ObjReader = Nothing
                ObjCommand = Nothing
                Mycon = Nothing
                ListGrid()
                Call Kosong()
                BtnAdd.Enabled = True
                BtnDelete.Enabled = True
                BtnExit.Enabled = True
                BtnEdit.Enabled = False
                BtnSave.Enabled = True
                BtnCancel.Enabled = True
            End Try
        End If
    End Sub

    Private Sub GrdTarif_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdTarif.CellClick
        Dim UBAH As Integer = Nothing
        UBAH = GrdTarif.CurrentRow.Index
        With GrdTarif
            TxtJns_kend.Text = .Item(0, UBAH).Value
            Txtjam_1.Text = .Item(1, UBAH).Value
            TxtJam_2.Text = .Item(2, UBAH).Value
            TxtJam_Max.Text = .Item(3, UBAH).Value
        End With
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If Txtjam_1.Text = "" Or TxtJam_2.Text = "" Or TxtJam_2.Text = "" Or TxtJns_kend.Text = "" Then
            MsgBox("Data Harus Lengkap ")
        Else
            If BtnEdit.Text = "EDIT" Then
                BtnEdit.Text = "UPDATE"
                BtnAdd.Enabled = False
                BtnSave.Enabled = False
                BtnDelete.Enabled = False
                BtnCancel.Enabled = True
                BtnEdit.Enabled = True
                BtnExit.Enabled = False
                Call UnLockText()
            Else
                Mycon = New OleDbConnection(StrCon)
                Try
                    Mycon.Open()
                    StrSql = "Update TB_tarif set Jam_1 =  " & Txtjam_1.Text & "," & _
                                            "jam_2 = '" & TxtJam_2.Text & "'," & _
                                            "Tarif_Max = '" & TxtJam_Max.Text & "'" & _
                                            "where jns_kend = '" & TxtJns_kend.Text & "'"
                    ObjCommand = New OleDbCommand(StrSql, Mycon)
                    If ObjCommand.ExecuteNonQuery Then
                        MsgBox("Update Berhasil ")
                    Else
                        MsgBox("Update Gagal")
                    End If
                Catch ex As Exception
                    MsgBox("error")
                Finally
                    Mycon.Close()
                    Mycon = Nothing
                    ObjCommand = Nothing
                    ObjReader = Nothing
                    Call ListGrid()
                    Call Kosong()
                    Call LockText()
                    BtnAdd.Enabled = True
                    BtnDelete.Enabled = True
                    BtnExit.Enabled = True
                    BtnEdit.Enabled = True
                    BtnSave.Enabled = False
                    BtnCancel.Enabled = False
                    BtnEdit.Text = "EDIT"
                End Try
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If Txtjam_1.Text = "" Or TxtJam_2.Text = "" Or TxtJam_Max.Text = "" Or TxtJns_kend.Text = "" Then
            MsgBox("Data Belum Lengkap ")
        Else
            Mycon = New OleDbConnection(StrCon)
            Try
                Mycon.Open()
                StrSql = "Delete From TB_TArif where jns_kend = '" & Trim(TxtJns_kend.Text) & "'"
                ObjCommand = New OleDbCommand(StrSql, Mycon)
                If ObjCommand.ExecuteNonQuery Then
                    MsgBox("Data Sudah Dihapus ")
                Else
                    MsgBox("Gagal Menghapus Data")
                End If
            Catch ex As Exception
                MsgBox("Error")
            Finally
                Mycon.Close()
                Mycon = Nothing
                ObjReader = Nothing
                ObjCommand = Nothing
                Call Kosong()
                Call LockText()
                Call ListGrid()
                BtnAdd.Enabled = True
                BtnDelete.Enabled = True
                BtnExit.Enabled = True
                BtnEdit.Enabled = True
                BtnSave.Enabled = False
                BtnCancel.Enabled = False
            End Try
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call Kosong()
        Call LockText()
        BtnAdd.Enabled = True
        BtnDelete.Enabled = True
        BtnExit.Enabled = True
        BtnEdit.Enabled = True
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Dim pesan As String
        pesan = MsgBox("Keluar Program ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Parkir")
        If pesan = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
