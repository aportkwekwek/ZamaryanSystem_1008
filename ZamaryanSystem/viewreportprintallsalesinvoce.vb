Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Public Class viewreportprintallsalesinvoce
    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection(strconnection())


    Public Sub New()

        InitializeComponent()
        Dim sql As String

        sql = "Select sid, datesold , total , outputVat , salesperson, pono , remarks , customers.customername from salesinvoice inner Join customers on salesinvoice.customerid = customers.customerid WHERE remarks = 'Approved' or remarks = 'Decline' GROUP by salesinvoice.sid"




        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "salesinvoice")

            Dim report As New printallsalesinvoicereport

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