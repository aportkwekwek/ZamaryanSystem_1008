Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Public Class viewreportincome


    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection(strconnection())


    Public Sub New(ByVal sTitle5 As String)
        InitializeComponent()
        Dim sql As String

        sql = "SELECT chartofaccounts.accountcode , chartofaccounts.accountname, chartofaccounts.accountgroup from chartofaccounts WHERE chartofaccounts.accountgroup = 'Profit' OR chartofaccounts.accountgroup = 'General & Administrative Expenses' group by chartofaccounts.accountcode , chartofaccounts.accountname"
        ' "Select journalentry.journaldate as Date,journalentry.source as Source,journal.journaldesc as Description,journalentry.journaldebit as Debit,journalentry.journalcredit as Credit from journal inner join journalentry on journal.journalid = journalentry.journalid inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid where chartofaccounts.accountname ='" & sTitle2 & "'"


        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "journalentry")

            Dim report As New incomestatement
            report.SetDataSource(dt)

            report.SetParameterValue("justin", frmReports.incomedate.Value)
            CrystalReportViewer1.ReportSource = report

            report.SetParameterValue("romel", frmReports.DateTimePicker1.Value)
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