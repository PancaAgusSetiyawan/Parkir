Imports System
Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmLapMasuk
    Private RptDoc As ReportDocument

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Mycon = New OleDbConnection(StrCon)
            Mycon.Open()
            StrSql = "Select * from tb_Masuk " 'where tgl_keluar = '" & Tgl & "'"
            ObjAdapter = New OleDbDataAdapter(StrSql, Mycon)

            Dim HASIL_REPORT As New Ds_Masuk
            ObjAdapter.Fill(HASIL_REPORT, "Ds_Masuk")

            RptDoc = New ReportDocument
            RptDoc.Load("D:\Portofolio\Parkir\Parkir\Rpt_Masuk.rpt")
            RptDoc.SetDataSource(HASIL_REPORT)
            CrystalReportViewer1.ReportSource = RptDoc

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
End Class