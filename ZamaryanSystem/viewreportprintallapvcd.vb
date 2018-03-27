Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Public Class viewreportprintallapvcd
    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection(strconnection())


    Public Sub New()

        InitializeComponent()
        Dim sql As String

        sql = "Select cashdisbursmentapv.disbursmentid , cashdisbursment.date , cashdisbursment.grandTotal , suppliers.suppliername from cashdisbursment inner join cashdisbursmentapv on cashdisbursment.disbursmentID = cashdisbursmentapv.disbursmentid inner join billings on cashdisbursmentapv.APVid = billings.APVid inner join suppliers on billings.supplierid = suppliers.supplierid  group by cashdisbursment.disbursmentid"

        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "cashdisbursmentapv")

            Dim report As New printallapvcdreport

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