Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Public Class viewpurchasereport
    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection("server=localhost; uid=root; password=''; database=accountingsystem;convert Zero Datetime=true")


    Public Sub New(ByVal sTitle6 As String)
        InitializeComponent()
        Dim sql As String

        sql = "SELECT * FROM purchaseorder where poid = '" & sTitle6 & "'"

        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "purchaseorder")

            Dim report As New purcahseorder
            report.SetDataSource(dt)
            'MsgBox(sql)
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