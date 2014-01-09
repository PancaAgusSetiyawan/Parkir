Imports System
Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmLapKarcis

    Private RptDoc As ReportDocument

    Private Sub FrmLapKarcis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Mycon = New OleDbConnection(StrCon)
            Mycon.Open()
            'StrSql = "Select * from tb_Keluar " 'where tgl_keluar = '" & Tgl & "'"
            ObjAdapter = New OleDbDataAdapter(StrSql_Kw, Mycon)

            Dim HASIL_REPORT As New Ds_Karcis
            ObjAdapter.Fill(HASIL_REPORT, "Ds_Karcis")

            RptDoc = New ReportDocument
            RptDoc.Load("D:\Portofolio\Parkir\Parkir\RptKarcis.rpt")
            RptDoc.SetDataSource(HASIL_REPORT)
            CrystalReportViewer1.ReportSource = RptDoc

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Mycon = New OleDbConnection(StrCon)
    '    Mycon.Open()
    '    StrSql = "Select * from tb_masuk where kd_parkir = '" & TextBox1.Text & "'"
    '    ObjAdapter = New OleDbDataAdapter(StrSql, Mycon)

    '    Dim HASIL_REPORT As New Ds_Karcis
    '    ObjAdapter.Fill(HASIL_REPORT, "Ds_Karcis")

    '    RptDoc = New ReportDocument
    '    RptDoc.Load("D:\Portofolio\Parkir\Parkir\RptKarcis.rpt")
    '    RptDoc.SetDataSource(HASIL_REPORT)
    '    CrystalReportViewer1.ReportSource = RptDoc
    'End Sub
End Class