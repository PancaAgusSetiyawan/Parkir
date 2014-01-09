Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Frm_Keluar

    Private DtJam As Date
    Private DtTgl As Date
    Private IntJam1 As Integer
    Private IntJam2 As Integer
    Private IntMax As Integer

    Private Sub Kosong()
        TxtKd.Text = ""
        CboJns.Items.IndexOf(0)
        TxtPlat.Text = ""
        TxtTarif.Text = ""
        TxtJamMSK.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblJam.Text = Format(Now, "HH:mm:ss")
        LblTgl.Text = Format(Now, "yyyy/MM/dd")
    End Sub

    Private Sub Frm_Keluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtPlat.Enabled = False
        Call ListCmb()
        Call CountTarif()
        Call LoadTarif()
        Call Kosong()
        TxtKd.Focus()
    End Sub

    Private Sub LoadTarif() ' mengambil isi tarif tb_tarif
        Try
            Mycon = New OleDbConnection(StrCon)
            Mycon.Open()
            StrSql = "select jam_1, Jam_2, Tarif_max from tb_tarif  where jns_kend = '" & CboJns.Text & "'"
            ObjCommand = New OleDbCommand(StrSql, Mycon)
            ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
            If ObjReader.HasRows Then
                ObjReader.Read()
                IntJam1 = ObjReader("jam_1")
                IntJam2 = ObjReader("jam_2")
                IntMax = ObjReader("tarif_max")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub ListCmb() '  mengisi combobox dr database
        Try
            Mycon = New OleDbConnection(StrCon)
            Mycon.Open()
            StrSql = "select jns_kend from tb_tarif "
            ObjCommand = New OleDbCommand(StrSql, Mycon)
            ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
            If ObjReader.HasRows Then
                While ObjReader.Read
                    CboJns.Items.Add(ObjReader(0))
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub LoadDate()
        Try
            Mycon = New OleDbConnection(StrCon)
            Mycon.Open()
            StrSql = "select * from tb_masuk where kd_parkir = '" & TxtKd.Text & "'"
            ObjCommand = New OleDbCommand(StrSql, Mycon)
            ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
            If ObjReader.HasRows Then
                ObjReader.Read()
                DtJam = ObjReader("jam_masuk")
                DtTgl = ObjReader("tgl_mask")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            ObjReader.Close()
            ObjCommand.Dispose()
            Mycon.Close()
            ObjReader = Nothing
            ObjCommand = Nothing
            Mycon = Nothing
        End Try
    End Sub

    Private Sub CountTarif()
        Dim Selisih As Integer
        Dim Masuk As Date = TxtJamMSK.Text   ' JAM MASUK (DDKLARISAKN)
        Dim Keluar As Date = LblJam.Text
        Dim bayar As Integer

        Selisih = DateDiff(DateInterval.Hour, Masuk, Keluar)

        If Selisih >= 5 Then
            bayar = IntMax
        ElseIf Selisih > 3 And Selisih <= 4 Then ' SELISEIH 4 JAM
            bayar = IntJam1 + IntJam2 + IntJam2 + IntJam2
        ElseIf Selisih > 2 And Selisih <= 3 Then ' SELISIH 3 JAM
            bayar = IntJam1 + IntJam2 + IntJam2
        ElseIf Selisih > 1 And Selisih <= 2 Then ' SELISIH 2 JAM
            bayar = IntJam1 + IntJam2
        ElseIf Selisih > 0 And Selisih <= 1 Then ' SELISIH 1 JAM
            bayar = IntJam1
        Else
            bayar = IntJam1
        End If
        TxtTarif.Text = Format(bayar, "#,##")
    End Sub

    Private Sub TxtKd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKd.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Try
                Mycon = New OleDbConnection(StrCon)
                Mycon.Open()
                StrSql = "select * from tb_masuk where kd_parkir = '" & TxtKd.Text & "'"
                ObjCommand = New OleDbCommand(StrSql, Mycon)
                ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
                If ObjReader.HasRows Then
                    ObjCommand.Dispose()
                    StrSql = "select * from tb_keluar where kd_parkir = '" & TxtKd.Text & "'"
                    ObjCommand = New OleDbCommand(StrSql, Mycon)
                    ObjReader = ObjCommand.ExecuteReader(CommandBehavior.Default)
                    If ObjReader.HasRows Then
                        MsgBox("Kartu Parkir Dengan No '" & TxtKd.Text & "' sudah keluar")
                        TxtKd.Focus()
                        TxtKd.Text = ""
                    Else
                        Call LoadDate()
                        CboJns.Focus()
                        TxtJamMSK.Text = DtJam
                    End If
                Else
                    MsgBox("Kartu Parkir Dengan No '" & TxtKd.Text & "' Tidak Masuk")
                    TxtKd.Focus()
                    TxtKd.Text = ""
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            Finally
                ''ObjCommand.Dispose()
                'ObjReader.Close()
                'Mycon.Close()
                'Mycon = Nothing
                'ObjReader = Nothing
                'ObjCommand = Nothing
            End Try
        End If
    End Sub

    Private Sub CboJns_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboJns.KeyPress
        Call LoadTarif()
        If Asc(e.KeyChar) = Keys.Enter Then
            TxtPlat.ReadOnly = False
            TxtPlat.Enabled = True
            TxtPlat.Focus()
        End If
    End Sub

    Private Sub TxtPlat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPlat.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call CountTarif()
            BtnSave.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call Kosong()
        TxtPlat.ReadOnly = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If TxtKd.Text = "" Or TxtPlat.Text = "" Or TxtTarif.Text = "" Then
            MsgBox("Lengkapi Data ")
        Else
            Mycon = New OleDbConnection(StrCon)
            Try
                Mycon.Open()
                StrSql = "insert into tb_keluar (kd_parkir, plat_no, tgl_keluar,jam_keluar, jns_kend, biaya)values ('" & TxtKd.Text & "','" & TxtPlat.Text & "','" & CDate(LblTgl.Text) & "', '" & CDate(LblJam.Text) & "','" & CboJns.Text & "', '" & CDbl(TxtTarif.Text) & "')"
                ObjCommand = New OleDbCommand(StrSql, Mycon)
                If ObjCommand.ExecuteNonQuery Then
                    MsgBox("Data Telah Disimpan")
                Else
                    MsgBox("Data Gagal DiSimpan ")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                ObjCommand.Dispose()
                Mycon.Close()
                Mycon = Nothing
                ObjCommand = Nothing
                Call Kosong()
                TxtPlat.ReadOnly = True
                TxtKd.Focus()
            End Try
        End If

    End Sub

    Private Sub TxtKd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKd.TextChanged
        TxtKd.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub TxtPlat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPlat.TextChanged
        TxtPlat.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Dim pesan As String
        pesan = MsgBox("Anda Akan Keluar ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Parkir")
        If pesan = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub CboJns_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboJns.SelectedIndexChanged
         Call CountTarif()
    End Sub
End Class