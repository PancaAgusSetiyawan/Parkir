Imports System
Imports System.Data
Imports System.Data.OleDb

Module Mdl_koneksi
    Public StrCon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Portofolio\Parkir\Parkir.mdb"
    Public StrSql As String
    Public ObjDataTabel As DataTable
    Public ObjReader As OleDbDataReader
    Public ObjAdapter As OleDbDataAdapter
    Public ObjCommand As OleDbCommand
    Public OleDataSet As DataSet
    Public Mycon As OleDbConnection

    Public StrSql_Kw As String '  deklarasi unt karcis
    Public idUser As String 'deklarasi unt siapa yang logIn
End Module
