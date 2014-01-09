Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Frm_Masuk

    Private tulisan(2) As String
    Private i, j As Integer

    Private Sub Frm_Masuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtKd_parkir.Text = auto()
        tulisan(0) = "SELAMAT DATANG...."
        tulisan(1) = "SILAHKAN TEKAN TOMBOL OK...."
        tulisan(2) = "UNTUK MENGAMBIL KARTU PARKIR...."
        tSLABEL.Text = tulisan(j)
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If i.Equals(tulisan(j).Length) Then
            Me.TsLabel.Text = ""
            If j < tulisan.Length - 1 Then
                j = j + 1
                Me.TsLabel.Text = tulisan(j)
            Else
                j = 0
            End If
            i = 0
        End If
        TsLabel.Text = tulisan(j).Substring(0, i)
        i = i + 1
    End Sub

    Function auto() As String
        Mycon = New OleDbConnection(StrCon)
        Mycon.Open()
        StrSql = "select right(kd_parkir,3) as kd_parkir from tb_masuk where left(kd_parkir,1)='P' order by right(kd_parkir,3) desc"
        ObjCommand = New OleDbCommand(StrSql, Mycon)
        ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
        If ObjReader.HasRows Then
            ObjReader.Read()
            Return "P00" + (Val(Trim(ObjReader.Item(0).ToString)) + 1).ToString
        Else
            Return "P001"
        End If
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblTanggal.Text = Format(Now, "dd/MM/yyyy")
        LblJam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Try
            Mycon = New OleDbConnection(StrCon)
            Mycon.Open()
            StrSql_Kw = "Select * from tb_masuk where kd_parkir = '" & TxtKd_parkir.Text & "'"

            StrSql = "insert into tb_masuk (kd_parkir,tgl_mask, jam_masuk,id_User)" & _
                    "values ('" & TxtKd_parkir.Text & "', '" & LblTanggal.Text & "', '" & CDate(LblJam.Text) & "', '" & Trim(idUser) & "')"
            ObjCommand = New OleDbCommand(StrSql, Mycon)
            If ObjCommand.ExecuteNonQuery Then
                MsgBox("Data Silahkan Masuk")
            Else
                MsgBox("Error ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            ObjCommand.Dispose()
            Mycon.Close()
            ObjCommand = Nothing
            Mycon = Nothing
        End Try
        '        TxtKd_parkir.Text = ""
        TxtKd_parkir.Text = auto()
        Call FrmLapKarcis.Show()
    End Sub

End Class