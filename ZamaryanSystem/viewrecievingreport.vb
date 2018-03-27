
Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared

Public Class viewrecievingreport

    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection(strconnection())

    Public Sub New(ByVal sTitle22 As String)
        InitializeComponent()
        Dim sql As String

        sql = "Select * from receivingreport where reportid='" & sTitle22 & "'"

        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "receivingreport")

            Dim report As New recievingreport



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
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class