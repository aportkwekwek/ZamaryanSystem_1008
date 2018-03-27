Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Public Class viewreportbalance

    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection(strconnection())


    Public Sub New(ByVal sTitle4 As String)
        InitializeComponent()
        Dim sql As String

        sql = "SELECT chartofaccounts.accountgroup , chartofaccounts.accountname, sum(journalentry.journaldebit) - sum(journalentry.journalcredit) as Balance FROM accountingsystem.chartofaccounts chartofaccounts inner join journalentry on chartofaccounts.accountid = journalentry.accountid WHERE chartofaccounts.accountgroup='Current Assets' OR chartofaccounts.accountgroup='Noncurrent Assets' OR chartofaccounts.accountgroup='Equity' OR chartofaccounts.accountgroup='Liabilities' group by chartofaccounts.accountcode, chartofaccounts.accountname "
        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "chartofaccounts")

            Dim report As New balancesheet

            report.SetDataSource(dt)
            report.SetParameterValue("cenon", frmReports.dtpToBS.Value)
            CrystalReportViewer1.ReportSource = report


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