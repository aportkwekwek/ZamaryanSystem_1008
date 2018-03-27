Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmReports

    Dim sqlcon As New MySqlConnection
    Dim sqlda As New MySqlDataAdapter
    Dim sqlcmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim a As Integer
    Dim gross2, ga2 As Integer
    Dim prevref As String
    Dim totaldebit, totalcredit As Double



    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    ' Public Function getsalesinvoicereport()

    '    lvsalesinvoice.Items.Clear()


    '    Try

    '        sqlcon.ConnectionString = strconnection()
    '        sqlcon.Open()

    '        Dim qry As String

    '        qry = "Select * from salesinvoice"

    '        Dim dtk1 As New DataTable

    '        sqlda = New MySqlDataAdapter(qry, sqlcon)
    '        sqlda.Fill(dtk1)

    '        Dim i As Integer

    '        While i <= dtk1.Rows.Count - 1
    '            Dim itm As ListViewItem

    '            itm = lvsalesinvoice.Items.Add(dtk1.Rows(i).Item(0))
    '            itm.SubItems.Add((dtk1.Rows(i).Item(2)))
    '            itm.SubItems.Add(dtk1.Rows(i).Item(3))
    '            itm.SubItems.Add(dtk1.Rows(i).Item(4))
    '            itm.SubItems.Add(dtk1.Rows(i).Item(5))
    '            itm.SubItems.Add(dtk1.Rows(i).Item(6))
    '            itm.SubItems.Add(dtk1.Rows(i).Item(7))
    '            'itm.SubItems.Add(dtk1.Rows(i).Item(8))
    '            'itm.SubItems.Add(FormatNumber(dtk1.Rows(i).Item(5)))
    '            ' itm.SubItems.Add(Format(dtk1.Rows(i).Item(3)))

    '            i += 1

    '        End While



    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally

    '        sqlcon.Close()

    '    End Try

    '    Return lvsalesinvoice


    'End Function

    ''Get Billing Statement

    'Public Function getbillingstatement()

    '    lvbilling.Items.Clear()


    '    Try

    '        sqlcon.ConnectionString = strconnection()
    '        sqlcon.Open()

    '        Dim qry As String

    '        qry = "Select * from billings"

    '        Dim dtk4 As New DataTable

    '        sqlda = New MySqlDataAdapter(qry, sqlcon)
    '        sqlda.Fill(dtk4)

    '        Dim i As Integer

    '        While i <= dtk4.Rows.Count - 1
    '            Dim itm As ListViewItem

    '            itm = lvbilling.Items.Add(dtk4.Rows(i).Item(0))
    '            itm.SubItems.Add((dtk4.Rows(i).Item(1)))
    '            itm.SubItems.Add((dtk4.Rows(i).Item(2)))
    '            itm.SubItems.Add((dtk4.Rows(i).Item(3)))

    '            'itm.SubItems.Add(dtk1.Rows(i).Item(8))
    '            'itm.SubItems.Add(FormatNumber(dtk1.Rows(i).Item(5)))
    '            ' itm.SubItems.Add(Format(dtk1.Rows(i).Item(3)))

    '            i += 1

    '        End While



    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally

    '        sqlcon.Close()

    '    End Try

    '    Return lvbilling


    'End Function

    'Public Function getrecievingreport()

    '    dgvrecievingreport.Items.Clear()


    '    Try

    '        sqlcon.ConnectionString = strconnection()
    '        sqlcon.Open()

    '        Dim qry As String

    '        qry = "Select purchaseorder.poid , receivingreport.datedelivered , receivingreport.total , receivingreport.status from receivingreport , purchaseorder group by purchaseorder.poid"

    '        Dim dtk22 As New DataTable

    '        sqlda = New MySqlDataAdapter(qry, sqlcon)
    '        sqlda.Fill(dtk22)

    '        Dim i As Integer

    '        While i <= dtk22.Rows.Count - 1
    '            Dim itm As ListViewItem

    '            itm = dgvrecievingreport.Items.Add(dtk22.Rows(i).Item(0))
    '            itm.SubItems.Add((dtk22.Rows(i).Item(1)))
    '            itm.SubItems.Add((dtk22.Rows(i).Item(2)))
    '            itm.SubItems.Add((dtk22.Rows(i).Item(3)))

    '            'itm.SubItems.Add(dtk1.Rows(i).Item(8))
    '            'itm.SubItems.Add(FormatNumber(dtk1.Rows(i).Item(5)))
    '            ' itm.SubItems.Add(Format(dtk1.Rows(i).Item(3)))

    '            i += 1

    '        End While



    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally

    '        sqlcon.Close()

    '    End Try

    '    Return dgvrecievingreport


    'End Function

    'Public Function getpurchasereport()

    '    lvpurchase.Items.Clear()


    '    Try

    '        sqlcon.ConnectionString = strconnection()
    '        sqlcon.Open()

    '        Dim qry As String

    '        qry = "Select * from purchaseorder"

    '        Dim dtk2 As New DataTable

    '        sqlda = New MySqlDataAdapter(qry, sqlcon)
    '        sqlda.Fill(dtk2)

    '        Dim i As Integer

    '        While i <= dtk2.Rows.Count - 1
    '            Dim itm As ListViewItem

    '            itm = lvpurchase.Items.Add(dtk2.Rows(i).Item(0))
    '            itm.SubItems.Add((dtk2.Rows(i).Item(1)))
    '            itm.SubItems.Add(dtk2.Rows(i).Item(2))

    '            'itm.SubItems.Add(dtk1.Rows(i).Item(8))
    '            'itm.SubItems.Add(FormatNumber(dtk1.Rows(i).Item(5)))
    '            ' itm.SubItems.Add(Format(dtk1.Rows(i).Item(3)))

    '            i += 1

    '        End While



    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally

    '        sqlcon.Close()

    '    End Try

    '    Return lvpurchase


    'End Function

    'Public Function getcashreciept()

    '    lvcashreciept.Items.Clear()


    '    Try

    '        sqlcon.ConnectionString = strconnection()
    '        sqlcon.Open()

    '        Dim qry As String

    '        qry = "Select * from cashreceipts"

    '        Dim dtk2 As New DataTable

    '        sqlda = New MySqlDataAdapter(qry, sqlcon)
    '        sqlda.Fill(dtk2)

    '        Dim i As Integer

    '        While i <= dtk2.Rows.Count - 1
    '            Dim itm As ListViewItem

    '            itm = lvcashreciept.Items.Add(dtk2.Rows(i).Item(0))
    '            itm.SubItems.Add((dtk2.Rows(i).Item(1)))
    '            itm.SubItems.Add(dtk2.Rows(i).Item(5))

    '            'itm.SubItems.Add(dtk1.Rows(i).Item(8))
    '            'itm.SubItems.Add(FormatNumber(dtk1.Rows(i).Item(5)))
    '            ' itm.SubItems.Add(Format(dtk1.Rows(i).Item(3)))

    '            i += 1

    '        End While



    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally

    '        sqlcon.Close()

    '    End Try

    '    Return lvcashreciept


    'End Function

    Private Sub getincomestatement()

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select chartofaccounts.accountcode as 'Account Code',chartofaccounts.accountname as 'Account Name',sum(journalentry.journaldebit) - sum(journalentry.journalcredit) as Balance from chartofaccounts inner join journalentry on chartofaccounts.accountid = journalentry.accountid where YEAR(journalentry.journaldate) = YEAR(curdate()) and chartofaccounts.accountname != 'Retained Earnings' and (chartofaccounts.accountgroup = 'Profit' or chartofaccounts.accountgroup = 'General & Administrative Expenses') group by chartofaccounts.accountcode, chartofaccounts.accountname"

            'Dim dt1 As New DataTable
            sqlcmd = New MySqlCommand(qry, sqlcon)
            dr = sqlcmd.ExecuteReader
            Do While dr.Read
                dgvincomestatement.Rows.Add(dr("Account Code"), dr("Account Name"), ReportFormat(dr("Balance")))
            Loop
            'sqlda = New MySqlDataAdapter(qry, sqlcon)
            'sqlda.Fill(dt1)

            'dgvincomestatement.DataSource = dt1


        Catch ex As Exception


            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()


        End Try
    End Sub


  
    Public Function gross1()
        Try

            Dim holder = ExecuteScalar("Select Distinct(Select sum(journalentry.journaldebit) - sum(journalentry.journalcredit) as 'Profit' from journalentry inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid where chartofaccounts.accountgroup ='Profit' and journalentry.journaldate = year(curdate()) GROUP by chartofaccounts.accountgroup) as 'Profit'")
            If IsDBNull(holder) Then
                totgross.Text = 0
            Else
                totgross.Text = ReportFormat(holder)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        Return totgross

    End Function


    Public Function GA()

        Dim ga2 = ExecuteScalar("Select sum(journalentry.journaldebit) - sum(journalentry.journalcredit) as 'Expenses' from journalentry inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid where chartofaccounts.accountgroup ='General & Administrative Expenses' and journalentry.journaldate = year(curdate()) group by chartofaccounts.accountgroup")

        If IsDBNull(ga2) Then
            totga.Text = 0
        Else
            totga.Text = ga2
        End If
       
        Return totga

    End Function


    Public Function getLedgerType()

        cmbReportType.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select accountid,accountname from chartofaccounts order by accountname asc"

            Dim dt As New DataTable
            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt)

            Dim i As Integer

            While i <= dt.Rows.Count - 1

                cmbReportType.AddItem(dt.Rows(i).Item(1))

                i += 1

            End While

        Catch ex As Exception


            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return cmbReportType

    End Function


    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
        dgvLedger.Rows.Clear()
        Dim datefrom, dateto As Date

        datefrom = dtpFrom.Value
        dateto = dtpTo.Value

        If dateto < datefrom Then

            MessageBox.Show("Invalid Date", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub

        End If

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select journalentry.journaldate as Date,journalentry.source as Source,journalentry.source2 as 'Reference Number',journal.journaldesc as 'Description', journalentry.journaldebit as 'Debit', journalentry.journalcredit as 'Credit',runningBal as 'Balance' from journal inner join journalentry on journal.journalid = journalentry.journalid inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid where chartofaccounts.accountname ='" & cmbReportType.selectedValue & "'"

            'Dim dt1 As New DataTable

            sqlcmd = New MySqlCommand(qry, sqlcon)
            dr = sqlcmd.ExecuteReader
            Do While dr.Read
                dgvLedger.Rows.Add(dr("Date"), dr("Source"), dr("Reference Number"), dr("Description"), ReportFormat(dr("Debit")), ReportFormat(dr("Credit")), ReportFormat(dr("Balance")))
            Loop

            'sqlda = New MySqlDataAdapter(qry, sqlcon)
            'sqlda.Fill(dt1)

            'dgvLedger.DataSource = dt1

            dgvLedger.Columns(0).DefaultCellStyle.Format = "dd-MM-yyyy"
            'dgvLedger.Columns(3).DefaultCellStyle.Format = "###,###.##"
            'dgvLedger.Columns(4).DefaultCellStyle.Format = "###,###.##"

        Catch ex As Exception


            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()


        End Try
    End Sub

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getLedgerType()

        gross1()
        GA()
        Dim totalha As Double

        totalha = CDbl(gross2) - CDbl(ga2)

        net.Text = totalha

        dtpFrom.Value = Format(Date.Now, "yyyy-MM-dd")
        dtpTo.Value = Format(Date.Now, "yyyy-MM-dd")

        'getpurchasereport()
        'getsalesinvoicereport()
        'getbillingstatement()
        'getrecievingreport()
        'getcashreciept()

        '    getLedgerTypeid()
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click

        Try


            lvTrialBalance.Items.Clear()

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String
            Dim dt2 As New DataTable
            qry = "Select chartofaccounts.accountcode as 'Account Code',chartofaccounts.accountname as 'Account Name',sum(journalentry.journaldebit) - sum(journalentry.journalcredit) as Balance from chartofaccounts inner join journalentry on chartofaccounts.accountid = journalentry.accountid where chartofaccounts.accountname != 'Retained Earnings' and chartofaccounts.accountgroup != 'General & Administrative Expenses' and chartofaccounts.accountgroup != 'Profit' group by chartofaccounts.accountcode, chartofaccounts.accountname"

            'or chartofaccounts.accountname != 'Sales' or chartofaccounts.accountname != 'Cost of Sales'

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt2)

            Dim i As Integer


            Dim lvTrialBal As ListViewItem

            While i <= dt2.Rows.Count - 1

                lvTrialBal = lvTrialBalance.Items.Add(dt2.Rows(i).Item(0))
                lvTrialBal.SubItems.Add(dt2.Rows(i).Item(1))
                lvTrialBal.SubItems.Add(FormatNumber(dt2.Rows(i).Item(2)))
                i += 1

            End While

            ''Get expenses per year

            Dim qrystr As String

            qrystr = "Select chartofaccounts.accountcode as 'Account Code',chartofaccounts.accountname as 'Account Name',sum(journalentry.journaldebit) - sum(journalentry.journalcredit) as Balance from chartofaccounts inner join journalentry on chartofaccounts.accountid = journalentry.accountid where YEAR(journalentry.journaldate) = YEAR(curdate()) and chartofaccounts.accountname != 'Retained Earnings' and (chartofaccounts.accountgroup = 'Profit' or chartofaccounts.accountgroup = 'General & Administrative Expenses') group by chartofaccounts.accountcode, chartofaccounts.accountname"
            Dim l As Integer
            Dim dt124e As New DataTable

            sqlda = New MySqlDataAdapter(qrystr, sqlcon)
            sqlda.Fill(dt124e)

            While l <= dt124e.Rows.Count - 1

                lvTrialBal = lvTrialBalance.Items.Add(dt124e.Rows(l).Item(0))
                lvTrialBal.SubItems.Add(dt124e.Rows(l).Item(1))
                lvTrialBal.SubItems.Add(FormatNumber(dt124e.Rows(l).Item(2)))

                l += 1

            End While


            '================



            ''Retained Earnings

            Dim qry1 As String

            Dim dt12121 As New DataTable

            qry1 = "Select chartofaccounts.accountcode, chartofaccounts.accountname, ifnull(sum(journalentry.journaldebit) - sum(journalentry.journalcredit),0) as Balance from journalentry inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid where chartofaccounts.accountname = 'Retained Earnings' and year(journalentry.journaldate) < year(curdate()) group by chartofaccounts.accountcode, chartofaccounts.accountname"

            sqlda = New MySqlDataAdapter(qry1, sqlcon)
            sqlda.Fill(dt12121)

            Dim k As Integer

            Dim lvitemz As ListViewItem

            If dt12121.Rows.Count <> 0 Then

                For k = 0 To dt12121.Rows.Count

                    lvitemz = lvTrialBalance.Items.Add(dt12121.Rows(k).Item(0))
                    lvitemz.SubItems.Add(dt12121.Rows(k).Item(1))
                    lvitemz.SubItems.Add(FormatNumber(dt12121.Rows(k).Item(2)))

                    k += 1
                Next

            Else

            End If

            Dim lvitemx As ListViewItem
            Dim total As Double


            For Each lvitemx In lvTrialBalance.Items

                Dim subtot = lvitemx.SubItems(2).Text.Replace(",", "")

                total += CDbl(subtot)

            Next

            lblTotal.Text = "₱" & FormatNumber(total)


        Catch ex As Exception

            Exit Sub

        Finally

            sqlcon.Close()

        End Try
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        'Try
        TextBox1.Text = dtpFromJE.Value

        sqlcon.ConnectionString = strconnection()
        sqlcon.Open()

        Dim qry As String

        Dim dt4 As New DataTable
        '  select date, sum(total_price)  from bill  where Date BETWEEN '" &  startDate.ToString("yyyy/MM/dd") & "' AND '" & endDate.ToString("yyyy/MM/dd") & "' GROUP BY date;"
        'qry = "from journalentry inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid where  and chartofaccounts.accountname != 'Retained Earnings' order by journalentry.journaldate asc, journalentry.source"
        qry = "Select journalentry.source as Source,journalentry.source2 as 'Reference' ,journalentry.journaldate as Date,chartofaccounts.accountname as 'Account Name',journalentry.journaldebit as Debit,journalentry.journalcredit as Credit  FROM accountingsystem.journalentry journalentry INNER JOIN accountingsystem.chartofaccounts chartofaccounts ON journalentry.accountid=chartofaccounts.accountid where journalentry.journaldate BETWEEN '" & dtpFromJE.Value.ToString("yyyy-MM-dd") & "' AND '" & dtpToJE.Value.ToString("yyyy-MM-dd") & "' and chartofaccounts.accountname !='Retained Earnings' ORDER BY journalentry.source2 , journalentry.journaldate"

        'MsgBox(qry)
        sqlcmd = New MySqlCommand(qry, sqlcon)
        dr = sqlcmd.ExecuteReader
        If dr.HasRows Then
            Do While dr.Read
                If dgvJournalE.RowCount > 0 Then
                    If prevref <> dr("Reference") Then
                        dgvJournalE.Rows.Add("", "", "", "", "________________", "________________")
                        dgvJournalE.Rows.Add("", prevref, "", "", If(totaldebit <> 0, "₱" & ReportFormat(totaldebit), "-"), If(totalcredit <> 0, "₱" & ReportFormat(totalcredit), "-"))
                        dgvJournalE.Rows.Add("", "", "", "", "", "", "")
                        totaldebit = 0
                        totalcredit = 0
                        prevref = dr("Reference")
                    End If
                Else
                    totaldebit = 0
                    totalcredit = 0
                    prevref = dr("Reference")
                End If
                dgvJournalE.Rows.Add(dr("Source"), prevref, dr("Date"), dr("Account Name"), ReportFormat(dr("Debit")), ReportFormat(dr("Credit")))
                totaldebit += dr("debit")
                totalcredit += dr("credit")
            Loop
            dgvJournalE.Rows.Add("", "", "", "", "________________", "________________")
            dgvJournalE.Rows.Add("", prevref, "", "", If(totaldebit <> 0, "₱" & ReportFormat(totaldebit), "-"), If(totalcredit <> 0, "₱" & ReportFormat(totalcredit), "-"))
            dgvJournalE.Rows.Add("", "", "", "", "", "", "")
        End If
        'sqlda = New MySqlDataAdapter(qry, sqlcon)
        'sqlda.Fill(dt4)

        'dgvJournalE.DataSource = dt4

        dgvJournalE.Columns(2).DefaultCellStyle.Format = "dd-MM-yyyy"
        'dgvJournalE.Columns(4).DefaultCellStyle.Format = "###,###.##"
        'dgvJournalE.Columns(5).DefaultCellStyle.Format = "###,###.##"


        'Catch ex As Exception


        '    MessageBox.Show(ex.Message)

        'Finally

        sqlcon.Close()

        'End Try

    End Sub

    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click

        dgvLiabilitiesEq.Rows.Clear()


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            Dim qry As String
            Dim dtCur As New DataTable

            qry = "select chartofaccounts.accountcode as 'Account Code', chartofaccounts.accountname as 'Account Name', ifnull(sum(journalentry.journaldebit) - sum(journalentry.journalcredit),0) as Balance " &
                 " from chartofaccounts inner join journalentry on chartofaccounts.accountid = journalentry.accountid " &
                 " where chartofaccounts.accountgroup ='Current Assets' group by chartofaccounts.accountcode, chartofaccounts.accountname"


            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtCur)

            dgvCurrentAssets.Rows.Clear()

            For row = 0 To dtCur.Rows.Count - 1

                dgvCurrentAssets.Rows.Add(dtCur.Rows(row).Item(0), dtCur.Rows(row).Item(1), ReportFormat(dtCur.Rows(row).Item(2)))

            Next

            Dim subtot As Double

            subtot = 0

            sqlcmd = New MySqlCommand("Select ifnull(sum(journalentry.journaldebit) - sum(journalentry.journalcredit),0) from journalentry inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid where chartofaccounts.accountgroup = 'Current Assets'", sqlcon)
            subtot = sqlcmd.ExecuteScalar

            'Get Total of Current Assets


            dgvCurrentAssets.Rows.Add("", "", "__________________")
            dgvCurrentAssets.Rows.Add("", "Total Current Assets", If(subtot <> 0, "₱" & reportformat(subtot), "-"))

            dgvCurrentAssets.Rows.Add("", "", "")

            ' dgvCurrentAssets.DataSource = dtCur
            'dgvCurrentAssets.Columns(2).DefaultCellStyle.Format = "###,###.##"

            Dim qry1 As String
            Dim dtnNonCur As New DataTable

            qry1 = "select chartofaccounts.accountcode as 'Account Code', chartofaccounts.accountname as 'Account Name', ifnull(sum(journalentry.journaldebit) - sum(journalentry.journalcredit),0) as Balance " &
               " from chartofaccounts inner join journalentry on chartofaccounts.accountid = journalentry.accountid " &
               " where chartofaccounts.accountgroup ='Noncurrent Assets' group by chartofaccounts.accountcode, chartofaccounts.accountname"

            sqlda = New MySqlDataAdapter(qry1, sqlcon)
            sqlda.Fill(dtnNonCur)


            Dim noncursubtot As Double

            sqlcmd = New MySqlCommand("Select ifnull(sum(journalentry.journaldebit) - sum(journalentry.journalcredit),0) from journalentry inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid where chartofaccounts.accountgroup = 'Noncurrent Assets'", sqlcon)
            noncursubtot = sqlcmd.ExecuteScalar

            For row = 0 To dtnNonCur.Rows.Count - 1

                dgvCurrentAssets.Rows.Add(dtnNonCur.Rows(row).Item(0), dtnNonCur.Rows(row).Item(1), ReportFormat(dtnNonCur.Rows(row).Item(2)))

            Next


            dgvCurrentAssets.Rows.Add("", "", "__________________")
            dgvCurrentAssets.Rows.Add("", "Total Non Current Assets", If(noncursubtot <> 0, "₱" & reportformat(noncursubtot), "-"))


            lblTotalAssets.Text = If((subtot + noncursubtot) <> 0, "₱" & reportformat((subtot + noncursubtot)), "-")

            Dim qry2 As String
            Dim dtliabilities As New DataTable

            qry2 = "select chartofaccounts.accountcode as 'Account Code', chartofaccounts.accountname as 'Account Name', ifnull(sum(journalentry.journaldebit) - sum(journalentry.journalcredit),0) as Balance " &
              " from chartofaccounts inner join journalentry on chartofaccounts.accountid = journalentry.accountid " &
              " where chartofaccounts.accountgroup ='Liabilities'  or chartofaccounts.accountgroup ='Equity'  group by chartofaccounts.accountcode, chartofaccounts.accountname"

            ''

            sqlda = New MySqlDataAdapter(qry2, sqlcon)
            sqlda.Fill(dtliabilities)

            For row = 0 To dtliabilities.Rows.Count - 1

                dgvLiabilitiesEq.Rows.Add(dtliabilities.Rows(row).Item(0), dtliabilities.Rows(row).Item(1), ReportFormat(dtliabilities.Rows(row).Item(2).ToString()))

            Next


            Dim liab As Double

            sqlcmd = New MySqlCommand("Select ifnull(sum(journalentry.journaldebit) - sum(journalentry.journalcredit),0) from journalentry inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid where chartofaccounts.accountgroup = 'Liabilities' or chartofaccounts.accountgroup = 'Equity'", sqlcon)
            liab = sqlcmd.ExecuteScalar

            lblTotalLiab.Text = If(liab <> 0, "₱" & ReportFormat(liab), "-")


        Catch ex As Exception


            MessageBox.Show(ex.Message)

        Finally
            sqlcon.Close()


        End Try
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Dim sTitle2 As String
        sTitle2 = cmbReportType.selectedValue
        Dim frm2 As New viewreportlegder(sTitle2)
        frm2.Show()
    End Sub



    Private Sub MaterialFlatButton7_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton7.Click
       


        Dim sTitle3 As String
        sTitle3 = TextBox1.Text
        Dim frm3 As New viewreporttrialbalance(sTitle3)
        frm3.Show()

    End Sub

    Private Sub MaterialFlatButton8_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton8.Click
        Dim sTitle4 As String
        sTitle4 = TextBox1.Text
        Dim frm4 As New viewreportbalance(sTitle4)
        frm4.Show()
    End Sub

    Private Sub MaterialFlatButton9_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton9.Click

        Dim sTitle5 As String
        sTitle5 = TextBox1.Text
        Dim frm5 As New viewreportincome(sTitle5)
        frm5.Show()

    End Sub

    Private Sub frmReports_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Enabled = True
        frmMain.Focus()

    End Sub

    Private Sub MaterialFlatButton10_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton10.Click
        Dim sTitle9 As String
        sTitle9 = TextBox2.Text
        Dim frm9 As New viewreportgeneraljournal(sTitle9)
        frm9.Show()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles totgross.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub dgvincomestatement_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvincomestatement.CellContentClick

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub tabEdit_Click(sender As Object, e As EventArgs) Handles tabEdit.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getincomestatement()

    End Sub

    Private Sub dgvJournalE_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJournalE.CellContentClick

    End Sub

    Private Sub dgvJournalE_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvJournalE.CellMouseClick


        TextBox12.Text = dgvJournalE.SelectedCells(0).Value 'salesinvoice'
        TextBox8.Text = dgvJournalE.SelectedCells(0).Value 'Account payable voucher'
        TextBox3.Text = dgvJournalE.SelectedCells(0).Value 'receiving report'
        TextBox9.Text = dgvJournalE.SelectedCells(0).Value 'cash disbursment receiving report'
        TextBox11.Text = dgvJournalE.SelectedCells(0).Value 'cash disbursment apv'
        TextBox10.Text = dgvJournalE.SelectedCells(0).Value 'Cash Receipt'

        TextBox14.Text = dgvJournalE.SelectedCells(1).Value 'salesinvoice'
        TextBox17.Text = dgvJournalE.SelectedCells(1).Value 'Account payable voucher'
        TextBox15.Text = dgvJournalE.SelectedCells(1).Value 'receiving report'
        TextBox13.Text = dgvJournalE.SelectedCells(1).Value 'cash disbursment receiving report'
        TextBox18.Text = dgvJournalE.SelectedCells(1).Value 'cash disbursment apv'
        TextBox16.Text = dgvJournalE.SelectedCells(1).Value 'Cash Receipt'



        If TextBox12.Text = "Sales Invoice" Then
            TextBox11.Clear()
            TextBox9.Clear()
            TextBox3.Clear()
            TextBox8.Clear()
            TextBox10.Clear()
            TextBox16.Clear()
            TextBox17.Clear()
            TextBox15.Clear()
            TextBox13.Clear()
            TextBox18.Clear()


            Dim sTitle7 As String
            sTitle7 = TextBox14.Text
            Dim frm8 As New viewreportsales(sTitle7)
            frm8.Show()
        End If

        If TextBox8.Text = "Accounts Payable Voucher" Then
            TextBox11.Clear()
            TextBox9.Clear()
            TextBox3.Clear()
            TextBox10.Clear()
            TextBox12.Clear()
            TextBox16.Clear()
            TextBox15.Clear()
            TextBox13.Clear()
            TextBox18.Clear()
            TextBox14.Clear()

            Dim sTitle8 As String
            sTitle8 = TextBox17.Text
            Dim frm7 As New viewreportbilling(sTitle8)
            frm7.Show()
        End If


        If TextBox3.Text = "Receiving Report" Then

            TextBox11.Clear()
            TextBox9.Clear()
            TextBox3.Clear()
            TextBox10.Clear()
            TextBox12.Clear()
            TextBox16.Clear()
            TextBox13.Clear()
            TextBox18.Clear()
            TextBox8.Clear()
            TextBox14.Clear()


            Dim sTitle22 As String
            sTitle22 = TextBox15.Text
            Dim frm22 As New viewrecievingreport(sTitle22)
            frm22.Show()

        End If

        If TextBox9.Text = "Cash Disbursement Inventory" Then

            TextBox11.Clear()
            TextBox3.Clear()
            TextBox10.Clear()
            TextBox12.Clear()
            TextBox16.Clear()
            TextBox18.Clear()
            TextBox8.Clear()
            TextBox14.Clear()
            TextBox17.Clear()
            TextBox15.Clear()


            Dim sTitle8 As String
            sTitle8 = TextBox13.Text
            Dim frm8 As New viewcashdis(sTitle8)
            frm8.Show()

        End If


        If TextBox11.Text = "Cash Disbursment APV" Then

            TextBox9.Clear()
            TextBox3.Clear()
            TextBox10.Clear()
            TextBox12.Clear()
            TextBox16.Clear()
            TextBox13.Clear()
            TextBox8.Clear()
            TextBox14.Clear()
            TextBox17.Clear()
            TextBox15.Clear()


            Dim sTitle9 As String
            sTitle9 = TextBox18.Text
            Dim frm8 As New viewdisrr(sTitle9)
            frm8.Show()
        End If

        If TextBox10.Text = "Cash Receipts" Then
            TextBox9.Clear()
            TextBox3.Clear()
            TextBox11.Clear()
            TextBox12.Clear()
            TextBox18.Clear()
            TextBox13.Clear()
            TextBox8.Clear()
            TextBox14.Clear()
            TextBox17.Clear()
            TextBox15.Clear()

            Dim sTitle23 As String
            sTitle23 = TextBox16.Text
            Dim frm10 As New viewcashreciept(sTitle23)
            frm10.Show()

        End If

     

    End Sub

    Private Sub dgvLedger_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLedger.CellContentClick


        TextBox12.Text = dgvLedger.SelectedCells(1).Value 'salesinvoice'
        TextBox8.Text = dgvLedger.SelectedCells(1).Value 'Account payable voucher'
        TextBox3.Text = dgvLedger.SelectedCells(1).Value 'receiving report'
        TextBox9.Text = dgvLedger.SelectedCells(1).Value 'cash disbursment receiving report'
        TextBox11.Text = dgvLedger.SelectedCells(1).Value 'cash disbursment apv'
        TextBox10.Text = dgvLedger.SelectedCells(1).Value 'Cash Receipt'

        TextBox14.Text = dgvLedger.SelectedCells(2).Value 'salesinvoice'
        TextBox17.Text = dgvLedger.SelectedCells(2).Value 'Account payable voucher'
        TextBox15.Text = dgvLedger.SelectedCells(2).Value 'receiving report'
        TextBox13.Text = dgvLedger.SelectedCells(2).Value 'cash disbursment receiving report'
        TextBox18.Text = dgvLedger.SelectedCells(2).Value 'cash disbursment apv'
        TextBox16.Text = dgvLedger.SelectedCells(2).Value 'Cash Receipt'



        If TextBox12.Text = "Sales Invoice" Then
            TextBox11.Clear()
            TextBox9.Clear()
            TextBox3.Clear()
            TextBox8.Clear()
            TextBox10.Clear()
            TextBox16.Clear()
            TextBox17.Clear()
            TextBox15.Clear()
            TextBox13.Clear()
            TextBox18.Clear()


            Dim sTitle7 As String
            sTitle7 = TextBox14.Text
            Dim frm8 As New viewreportsales(sTitle7)
            frm8.Show()
        End If

        If TextBox8.Text = "Accounts Payable Voucher" Then
            TextBox11.Clear()
            TextBox9.Clear()
            TextBox3.Clear()
            TextBox10.Clear()
            TextBox12.Clear()
            TextBox16.Clear()
            TextBox15.Clear()
            TextBox13.Clear()
            TextBox18.Clear()
            TextBox14.Clear()

            Dim sTitle8 As String
            sTitle8 = TextBox17.Text
            Dim frm7 As New viewreportbilling(sTitle8)
            frm7.Show()
        End If


        If TextBox3.Text = "Receiving Report" Then

            TextBox11.Clear()
            TextBox9.Clear()
            TextBox3.Clear()
            TextBox10.Clear()
            TextBox12.Clear()
            TextBox16.Clear()
            TextBox13.Clear()
            TextBox18.Clear()
            TextBox8.Clear()
            TextBox14.Clear()


            Dim sTitle22 As String
            sTitle22 = TextBox15.Text
            Dim frm22 As New viewrecievingreport(sTitle22)
            frm22.Show()

        End If

        If TextBox9.Text = "Cash Disbursement Inventory" Then

            TextBox11.Clear()
            TextBox3.Clear()
            TextBox10.Clear()
            TextBox12.Clear()
            TextBox16.Clear()
            TextBox18.Clear()
            TextBox8.Clear()
            TextBox14.Clear()
            TextBox17.Clear()
            TextBox15.Clear()




            Dim sTitle9 As String
            sTitle9 = TextBox13.Text
            Dim frm200 As New viewdisrr(sTitle9)
            frm200.Show()

        End If


        If TextBox11.Text = "Cash Disbursment APV" Then

            TextBox9.Clear()
            TextBox3.Clear()
            TextBox10.Clear()
            TextBox12.Clear()
            TextBox16.Clear()
            TextBox13.Clear()
            TextBox8.Clear()
            TextBox14.Clear()
            TextBox17.Clear()
            TextBox15.Clear()


            Dim sTitle8 As String
            sTitle8 = TextBox18.Text
            Dim frm8 As New viewcashdis(sTitle8)
            frm8.Show()
        End If

        If TextBox10.Text = "Cash Receipts" Then
            TextBox9.Clear()
            TextBox3.Clear()
            TextBox11.Clear()
            TextBox12.Clear()
            TextBox18.Clear()
            TextBox13.Clear()
            TextBox8.Clear()
            TextBox14.Clear()
            TextBox17.Clear()
            TextBox15.Clear()

            Dim sTitle23 As String
            sTitle23 = TextBox16.Text
            Dim frm10 As New viewcashreciept(sTitle23)
            frm10.Show()

        End If
    End Sub
End Class