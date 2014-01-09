Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Frm_User

    Private Sub Kosong()
        TxtId.Text = ""
        TxtJab.Text = ""
        TxtPass.Text = ""
    End Sub

    Private Sub LockText()
        TxtId.ReadOnly = True
        TxtJab.ReadOnly = True
        TxtPass.ReadOnly = True
    End Sub

    Private Sub UnLockText()
        TxtId.ReadOnly = False
        TxtJab.ReadOnly = False
        TxtPass.ReadOnly = False
    End Sub

    Private Sub ListGrid()
        Try
            Mycon = New OleDbConnection(StrCon)
            ObjDataTabel = New DataTable
            Mycon.Open()
            StrSql = "select * from tb_user "
            ObjCommand = New OleDbCommand(StrSql, Mycon)
            ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
            ObjDataTabel.Load(ObjReader)
            GrdUser.DataSource = ObjDataTabel
            ObjReader.Close()
            ObjCommand.Dispose()
            Mycon.Close()
            ObjReader = Nothing
            ObjCommand = Nothing
            Mycon = Nothing
        Catch ex As Exception
            GrdUser = Nothing
        End Try
    End Sub
    Private Sub Frm_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kosong()
        Call LockText()
        Call ListGrid()
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        BtnCancel.Enabled = False
        BtnSave.Enabled = False
        Call Kosong()
        Call UnLockText()
        TxtId.Focus()
        BtnAdd.Enabled = False
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        BtnClose.Enabled = False
        BtnSave.Enabled = True
        BtnCancel.Enabled = True
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtId.Text = "" Or TxtJab.Text = "" Or TxtPass.Text = "" Then
            MsgBox("Data Harus Di Isi Dengan Lengkap ")
        Else
            Mycon = New OleDbConnection(StrCon)
            Try
                Mycon.Open()
                StrSql = "select * from tb_user where id_user = '" & TxtId.Text & "'"
                ObjCommand = New OleDbCommand(StrSql, Mycon)
                ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
                If ObjReader.HasRows Then
                    MsgBox("Data Sudah Ada, Coba Lagi")
                Else
                    ObjCommand.Dispose()
                    StrSql = "insert into tb_user (id_user, pass, jabatan)" & _
                            "values ('" & TxtId.Text & "', '" & TxtPass.Text & "','" & TxtJab.Text & "')"
                    ObjCommand = New OleDbCommand(StrSql, Mycon)
                    If ObjCommand.ExecuteNonQuery Then
                        MsgBox("Data Sudah Disimpan")
                    Else
                        MsgBox("Penyimpanan Gagal")
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                ObjCommand.Dispose()
                ObjReader.Close()
                Mycon.Close()
                ObjCommand = Nothing
                ObjReader = Nothing
                Mycon = Nothing
                Call Kosong()
                Call LockText()
                Call ListGrid()
                BtnAdd.Enabled = True
                BtnEdit.Enabled = True
                BtnDelete.Enabled = True
                BtnClose.Enabled = True
                BtnSave.Enabled = False
                BtnCancel.Enabled = False
            End Try
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If TxtId.Text = "" Or TxtJab.Text = "" Or TxtPass.Text = "" Then
            MsgBox("Data Harus Di Isi Dengan Lengkap ")
        Else
            If BtnEdit.Text = "EDIT" Then
                BtnEdit.Text = "UPDATE"
                BtnAdd.Enabled = False
                BtnEdit.Enabled = True
                BtnDelete.Enabled = False
                BtnClose.Enabled = False
                BtnSave.Enabled = False
                BtnCancel.Enabled = False
                Call UnLockText()
            Else
                Mycon = New OleDbConnection(StrCon)
                Try
                    Mycon.Open()
                    StrSql = "UPDATE TB_USER SET PASS = '" & TxtPass.Text & "', JABATAN = '" & TxtJab.Text & "' WHERE ID_USER = '" & TxtId.Text & "'"
                    ObjCommand = New OleDbCommand(StrSql, Mycon)
                    If ObjCommand.ExecuteNonQuery Then
                        MsgBox("Data Sudah Di Update")
                    Else
                        MsgBox("Update Gagal")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                Finally
                    ObjCommand.Dispose()
                    Mycon.Close()
                    ObjCommand = Nothing
                    ObjReader = Nothing
                    Mycon = Nothing
                    Call Kosong()
                    Call LockText()
                    Call ListGrid()
                    BtnAdd.Enabled = True
                    BtnEdit.Enabled = True
                    BtnDelete.Enabled = True
                    BtnClose.Enabled = True
                    BtnSave.Enabled = False
                    BtnCancel.Enabled = False
                    BtnEdit.Text = "EDIT"
                End Try
            End If
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If TxtId.Text = "" Or TxtJab.Text = "" Or TxtPass.Text = "" Then
            MsgBox("Data Harus Di Isi Dengan Lengkap ")
        Else

            Mycon = New OleDbConnection(StrCon)
            Try
                Mycon.Open()
                StrSql = "delete from tb_user where id_user = '" & TxtId.Text & "'"
                ObjCommand = New OleDbCommand(StrSql, Mycon)
                If ObjCommand.ExecuteNonQuery Then
                    MsgBox("Data Sudah Di Hapus")
                Else
                    MsgBox("Data Gagal Dihapus")
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                ObjCommand.Dispose()
                Mycon.Close()
                ObjCommand = Nothing
                ObjReader = Nothing
                Mycon = Nothing
                Call Kosong()
                Call LockText()
                Call ListGrid()
                BtnAdd.Enabled = True
                BtnEdit.Enabled = True
                BtnDelete.Enabled = True
                BtnClose.Enabled = True
                BtnSave.Enabled = False
                BtnCancel.Enabled = False
                BtnEdit.Text = "EDIT"
            End Try
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call Kosong()
        Call LockText()
        Call ListGrid()
        BtnAdd.Enabled = True
        BtnEdit.Enabled = True
        BtnDelete.Enabled = True
        BtnClose.Enabled = True
        BtnSave.Enabled = False
        BtnCancel.Enabled = False
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Dim pesan As String
        pesan = MsgBox("Anda Akan Keluar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Parkir")
        If pesan = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub GrdUser_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdUser.CellClick
        Dim Ubah As Integer = Nothing
        Ubah = GrdUser.CurrentRow.Index
        With GrdUser
            TxtId.Text = .Item(0, Ubah).Value
            TxtPass.Text = .Item(1, Ubah).Value
            TxtJab.Text = .Item(2, Ubah).Value
        End With
    End Sub

    Private Sub TxtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtId.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtPass.Focus()
        End If
    End Sub

    Private Sub TxtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtId.TextChanged
        TxtId.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPass.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtJab.Focus()
        End If
    End Sub

    Private Sub TxtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPass.TextChanged
        TxtPass.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtJab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJab.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BtnSave.Focus()
        End If
    End Sub

    Private Sub TxtJab_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtJab.TextChanged
        TxtJab.CharacterCasing = CharacterCasing.Upper
    End Sub
End Class