Imports System
Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmLapKeluar
    Private RptDoc As ReportDocument

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Tgl As Date = Format(DTPicker1.Value.Date, "dd-MM-yyyy")
        Try
            Mycon = New OleDbConnection(StrCon)
            Mycon.Open()
            StrSql = "Select * from tb_Keluar " 'where tgl_keluar = '" & Tgl & "'"
            ObjAdapter = New OleDbDataAdapter(StrSql, Mycon)

            Dim HASIL_REPORT As New Ds_Keluar
            ObjAdapter.Fill(HASIL_REPORT, "Ds_Keluar")

            RptDoc = New ReportDocument
            RptDoc.Load("D:\Portofolio\Parkir\Parkir\Rpt_Keluar.rpt")
            RptDoc.SetDataSource(HASIL_REPORT)
            CrystalReportViewer1.ReportSource = RptDoc

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub FrmLapKeluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class