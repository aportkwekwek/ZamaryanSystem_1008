Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Public Class viewreportitems
    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection(strconnection())


    Public Sub New()

        InitializeComponent()
        Dim sql As String

        sql = "SELECT items.itemid, items.itemdesc, items.quantity, items.sellingPrice, items.runningBalance, items.isVatable, items.unitofmeasurement FROM accountingsystem.items items"


        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "items")

            Dim report As New items

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