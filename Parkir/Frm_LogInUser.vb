Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Frm_LogInUser

    Private Sub Kosong()
        TxtId.Text = ""
        CboJab.Text = ""
        TxtPas.Text = ""
    End Sub

    Private Sub loadCbo()
        Mycon = New OleDbConnection(StrCon)
        Try
            Mycon.Open()
            StrSql = "select jabatan from tb_user"
            ObjCommand = New OleDbCommand(StrSql, Mycon)
            ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
            If ObjReader.HasRows Then
                While ObjReader.Read
                    CboJab.Items.Add(ObjReader("jabatan"))
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            ObjCommand.Dispose()
            ObjReader.Close()
            Mycon.Close()
            Mycon = Nothing
            ObjReader = Nothing
            ObjCommand = Nothing
        End Try
    End Sub

    Private Sub Frm_LogInUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kosong()
        Call loadCbo()
        TxtId.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Frm_Menu.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TxtId.Text = "" Or TxtPas.Text = "" Or CboJab.Text = "" Then
            MsgBox("Data Harus Di Isi dengan Lengkap")
        Else
            Mycon = New OleDbConnection(StrCon)
            Try
                Mycon.Open()
                StrSql = " select * from tb_user where id_user = '" & TxtId.Text & "' and pass = '" & TxtPas.Text & "' and jabatan ='" & CboJab.Text & "'"
                ObjCommand = New OleDbCommand(StrSql, Mycon)
                ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
                If ObjReader.HasRows Then
                    If ObjReader.Read And CboJab.SelectedItem = "OPERATOR" Then
                        MsgBox("LOG IN SUKSESS")
                        Me.Hide()
                        Call operatorr()
                    Else 'If ObjReader.Read And CboJab.SelectedItem = "ADMIN" Then
                        MsgBox("LOG IN SUKSESS")
                        Me.Hide()
                        Call Supervisor()
                        'Else
                        '    MsgBox("User Name dan Password Salah")
                    End If
                Else
                    MsgBox("User Name dan Password Salah")
                    Call Kosong()
                End If
                Call Kosong()
            Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            ObjCommand.Dispose()
            ObjReader.Close()
            Mycon.Close()
            Mycon = Nothing
            ObjReader = Nothing
            ObjCommand = Nothing
            End Try
            Try
                Mycon = New OleDbConnection(StrCon)
                Mycon.Open()
                StrSql = " select * from tb_user where id_user = '" & TxtId.Text & "'"
                ObjCommand = New OleDbCommand(StrSql, Mycon)
                ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
                If ObjReader.HasRows Then
                    ObjReader.Read()
                    idUser = ObjReader(0)
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            Frm_Menu.Show()
        End If
    End Sub
End Class