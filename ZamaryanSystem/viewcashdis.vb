﻿Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Public Class viewcashdis
    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection(strconnection())


    Public Sub New(ByVal sTitle8 As String)
        InitializeComponent()
        Dim sql As String

        sql = "SELECT * from cashdisbursmentrr WHERE disbursmentid ='" & sTitle8 & "'"

        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "cashdisbursmentrr")

            Dim report As New cashdisburse





            report.SetDataSource(dt)
            ' MsgBox(sql)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
            cmd.Dispose()
            adp.Dispose()
            con.Dispose()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class