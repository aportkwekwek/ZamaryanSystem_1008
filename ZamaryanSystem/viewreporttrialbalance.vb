Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Public Class viewreporttrialbalance



    Dim cmd As MySqlCommand
    Dim adp As New MySqlDataAdapter
    Dim dt As New DataSet

    Dim con As New MySqlConnection(strconnection())


    Public Sub New(ByVal sTitle3 As String)
        InitializeComponent()
        Dim sql As String

        sql = "Select * from journalentry where accountid ='" & sTitle3 & "'"
        ' "Select journalentry.journaldate as Date,journalentry.source as Source,journal.journaldesc as Description,journalentry.journaldebit as Debit,journalentry.journalcredit as Credit from journal inner join journalentry on journal.journalid = journalentry.journalid inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid where chartofaccounts.accountname ='" & sTitle2 & "'"


        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "journalentry")

            Dim report As New trialbalance
            report.SetDataSource(dt)



            report.SetParameterValue("haha", frmReports.dtpFromTB.Value)
            CrystalReportViewer1.ReportSource = report

            report.SetParameterValue("to", frmReports.dtpToTB.Value)
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

    Private Sub viewreporttrialbalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub
End Class