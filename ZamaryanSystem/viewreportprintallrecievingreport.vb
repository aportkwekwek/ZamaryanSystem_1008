Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Public Class viewreportprintallrecievingreport


    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection(strconnection())


    Public Sub New()

        InitializeComponent()
        Dim sql As String

        sql = "Select receivingreport.reportid, suppliers.suppliername, receivingreport.datedelivered ,receivingreport.status, receivingreport.total  from receivingreport inner join purchaseorder on receivingreport.purchaseorderid = purchaseorder.purchaseorderid INNER join suppliers on suppliers.supplierid = suppliers.supplierid where purchaseorder.remarks !='NULL' group by purchaseorder.poid"




        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "recievingreport")

            Dim report As New printallrecievingreport

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