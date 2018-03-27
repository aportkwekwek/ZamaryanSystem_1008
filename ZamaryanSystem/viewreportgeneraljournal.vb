Imports MySql.Data.MySqlClient

Public Class viewreportgeneraljournal
    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection("server=localhost; uid=root; password=''; database=accountingsystem;")


    Public Sub New(ByVal sTitle9 As String)
        InitializeComponent()
        Dim sql As String

        sql = "SELECT * FROM journalentry where journaldate BETWEEN '" & frmReports.dtpFromJE.Value.ToString("yyyy-MM-dd") & "' AND '" & frmReports.dtpToJE.Value.ToString("yyyy-MM-dd") & "'"



        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "journalentry")

            Dim report As New generaljournal
            report.SetDataSource(dt)

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