Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Public Class viewreportprintallinventorycdreport
    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection(strconnection())


    Public Sub New()

        InitializeComponent()
        Dim sql As String

        sql = "Select cashdisbursment.disbursmentID , cashdisbursment.date , cashdisbursment.grandTotal , suppliers.suppliername from cashdisbursment inner join cashdisbursmentrr on cashdisbursment.disbursmentID = cashdisbursmentrr.disbursmentid INNER JOIN receivingreport on cashdisbursmentrr.reportid = receivingreport.reportid inner join purchaseorder on receivingreport.purchaseorderid = purchaseorder.purchaseorderid inner join suppliers on purchaseorder.supplierid = suppliers.supplierid group by cashdisbursment.disbursmentID"

        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "cashdisbursmentrr")

            Dim report As New printallinventorycdreport

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