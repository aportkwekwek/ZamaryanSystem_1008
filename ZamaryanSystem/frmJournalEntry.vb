Imports MySql.Data.MySqlClient
Public Class frmJournalEntry

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim sql As String
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim dr As MySqlDataReader
    Dim cb As MySqlCommandBuilder
    Dim lvi As ListViewItem
    Dim debit As Double
    Dim credit As Double
    Dim totaldebit As Double
    Dim totalcredit As Double
    Dim journaldescription As String
    Dim accountid As String
    Dim runningbalance As Double
    Dim newrunningbalance As Double
    Dim maxgjn As String

    Private Sub frmJournalEntry_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        frmMain.Enabled = True
        frmMain.Focus()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblrunningbalance.Visible = False
        MaterialLabel1.Visible = False

        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = strconnection()
            con.Open()
        End If

        txtgenjrnlno.Text = ExecuteScalar("SELECT ifnull(MAX(source2),'GJ10000000') FROM journalentry WHERE source2 LIKE 'GJ%' ")
        'txtentrydate.Text = Date.Today.ToString("yyyy-MM-dd")
        ModifyComboBox("Select accountname from chartofaccounts order by accountcode asc", cbaccountname)

        cbaccountname.SelectedIndex = 0
        'cbdebitcredit.SelectedIndex = 0

        ModifyListView()
    End Sub

    Private Sub cmbaccountname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbaccountname.SelectedIndexChanged
        'lblaccountcode.Text = ExecuteScalar("Select accountcode from chartofaccounts where accountname='" & cbaccountname.Text & "'")
        'accountid = ExecuteScalar("Select accountid from chartofaccounts where accountname='" & cbaccountname.Text & "'")
    End Sub

    Private Sub txtgenjrnlno_TextChanged(sender As Object, e As EventArgs) Handles txtgenjrnlno.TextChanged

        ModifyListView()

    End Sub

    'Private Sub dateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dateFrom.ValueChanged
    '    ModifyListView()

    'End Sub

    'Private Sub dateTo_ValueChanged(sender As Object, e As EventArgs) Handles DateTo.ValueChanged
    '    ModifyListView()

    'End Sub

    Public Sub ModifyListView()
        dgvjournal.Rows.Clear()
        totaldebit = 0
        totalcredit = 0
        lbltotalbalance.Text = 0

        If con.State = ConnectionState.Closed Then
            con.ConnectionString = strconnection()
            con.Open()
        End If

        If txtgenjrnlno.Text <> Nothing Then
            maxgjn = ExecuteScalar("SELECT ifnull(MAX(source2),'GJ10000000') FROM journalentry WHERE source2 LIKE 'GJ%'")
            If txtgenjrnlno.Text <= maxgjn Then
                MaterialLabel1.Enabled = True
                btnadd.Enabled = False
                btndelete.Enabled = False
                btnsave.Enabled = False
            Else
                MaterialLabel1.Enabled = False
                btnadd.Enabled = True
                btndelete.Enabled = True
                btnsave.Enabled = True
            End If
        End If

        sql = "SELECT accountname as 'Account Name',journaldebit as 'Debit',journalcredit as 'Credit',journaldesc as 'Description' FROM journal inner join  journalentry on journal.journalid = journalentry.journalid inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid WHERE journalentry.source2 = '" & txtgenjrnlno.Text & "' and journalentry.source != 'Receiving Report' AND journalentry.source != 'Sales Invoice' and journalentry.source != 'Accounts Payable Voucher' and journalentry.source != 'Cash Disbursement' and journalentry.source != 'Cash Receipts' ORDER BY journalentry.journalentryid ASC"

        '"SELECT journaldate as 'Journal Date',source as 'Source',accountname as 'Account Name',journaldebit as 'Debit',journalcredit as 'Credit' FROM journal NATURAL JOIN journalentry NATURAL JOIN chartofaccounts WHERE  journalid='" & txtgenjrnlno.Text & "' AND journalentry.journaldate BETWEEN '" & dateFrom.Value.ToString("yyyy-MM-dd") & "' AND '" & DateTo.Value.ToString("yyyy-MM-dd") & "' and (journalentry.source != 'Receiving Report' or journalentry.source != 'Sales Invoice') ORDER BY journalentry.journaldate ASC"
        'da = New MySqlDataAdapter(sql, con)
        'cb = New MySqlCommandBuilder(da)
        'dt = New DataTable
        'da.Fill(dt)
        cmd = New MySqlCommand(sql, con)
        dr = cmd.ExecuteReader()
        Do While dr.Read
            debit = dr("Debit")
            credit = dr("Credit")
            dgvjournal.Rows.Add(dr("Account Name"), JournalFormat(debit), JournalFormat(credit), dr("Description"))
            totaldebit += debit
            totalcredit += credit
        Loop
        lbltotaldebit.Text = JournalFormat(totaldebit)
        lbltotalcredit.Text = JournalFormat(totalcredit)
        con.Close()
        'dgvjournal.DataSource = dt
        'da = New MySqlDataAdapter("select chartofaccounts.accountcode as 'Account Code', chartofaccounts.accountname as 'Account Name', sum(journalentry.journaldebit) - sum(journalentry.journalcredit) as 'Balance' from journalentry inner join chartofaccounts on journalentry.accountid = chartofaccounts.accountid group by chartofaccounts.accountcode, chartofaccounts.accountname", con)
        'dt = New DataTable
        'da.Fill(dt)
        'dgvcalamba.DataSource = dt
        'For Each row As DataGridViewRow In dgvcalamba.Rows
        '    lbltotalbalance.Text += row.Cells(2).Value
        '    lbltotalbalance.Text = FormatNumber(lbltotalbalance.Text)
        'Next
    End Sub

    Public Sub ModifyComboBox(query As String, combobox As ComboBox)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        combobox.Items.Clear()

        da = New MySqlDataAdapter(query, con)
        dt = New DataTable
        da.Fill(dt)
        For i As Integer = 0 To dt.Rows.Count - 1

            combobox.Items.Add(dt.Rows(i).Item(0))
        Next
        con.Close()

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If (txtdebit.Text <> String.Empty And txtcredit.Text = String.Empty) Or (txtcredit.Text <> String.Empty And txtdebit.Text = String.Empty) Then
            If isCurrencyFormat(txtdebit) = True And isCurrencyFormat(txtcredit) = True Then
                If dgvjournal.Rows.Count < 1 Then
                    journaldescription = txtjournaldesc.Text
                Else
                    txtjournaldesc.Text = journaldescription
                End If
                'If cbdebitcredit.Text = "Debit" Then
                '    debit = CDbl(txtdebitcredit.Text)
                '    credit = 0
                'ElseIf cbdebitcredit.Text = "Credit" Then
                '    credit = CDbl(txtdebitcredit.Text)
                '    debit = 0
                'End If
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                dgvjournal.Rows.Add(cbaccountname.Text, If(txtdebit.Text = "", 0, txtdebit.Text), If(txtcredit.Text = "", 0, txtcredit.Text), journaldescription)
                'dgvjournal.Rows.Add(txtentrydate.Text, txtsource.Text, accountid, debit, credit)
                'cmd.CommandText = "INSERT IGNORE INTO journal (journalid, journaldesc) VALUES ('" & txtgenjrnlno.Text & "', '" & txtjournaldesc.Text & "')"
                'cmd.ExecuteNonQuery()
                'cmd.CommandText = "INSERT INTO journalentry (journalid, journaldate, accountid, journaldebit, journalcredit,source) VALUES ('" & txtgenjrnlno.Text & "','" & txtentrydate.Text & "','" & accountid & "','" & debit & "','" & credit & "','" & txtsource.Text & "')"
                'cmd.ExecuteNonQuery()
                'ModifyListView()
                ComputeTotalDebitCredit()
                txtcredit.Text = txtdebit.Text
                txtdebit.Clear()
            End If
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtgenjrnlno.Text = "GJ" & Format(Mid(maxgjn, 3, 8)) + 1
    End Sub

    'Private Sub txtdebitcredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdebitcredit.KeyPress
    '    Select Case Asc(e.KeyChar)
    '        Case 8
    '        Case 13
    '        Case 47 To 57
    '        Case Else
    '            e.KeyChar = Nothing

    '    End Select
    'End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If totalcredit = totaldebit Then

        Else
            MessageBox.Show("The transaction is not balanced. Please revalidate", "Zamaryan Holdings", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub


        End If


        If dgvjournal.Rows.Count > 0 Then
            Dim newjid = ExecuteScalar("Select ifnull(max(journalid)+1,1) from journal")
            cmd.CommandText = "INSERT INTO journal (journalid, journaldesc) VALUES ('" & newjid & "', '" & txtjournaldesc.Text & "')"
            cmd.ExecuteNonQuery()
            For Each row As DataGridViewRow In dgvjournal.Rows
                accountid = ExecuteScalar("Select accountid from chartofaccounts where accountname='" & row.Cells(0).Value & "'")
                runningbalance = ExecuteScalar("Select ifnull(runningBal,0) from journalentry where accountid = " & accountid & "  order by journalentryid desc limit 1 ")
                If row.Cells(1).Value = 0 Then
                    newrunningbalance = runningbalance - row.Cells(2).Value
                ElseIf row.Cells(2).Value = 0 Then
                    newrunningbalance = runningbalance + row.Cells(1).Value
                End If
                cmd.CommandText = "INSERT INTO journalentry (journalid,journaldate, accountid, journaldebit, journalcredit, source, source2, runningBal) VALUES ('" & newjid & "','" & Date.Today.ToString("yyyy-MM-dd") & "','" & accountid & "','" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','Journal Entry','" & txtgenjrnlno.Text & "','" & newrunningbalance & "')"
                cmd.ExecuteNonQuery()
            Next
            ModifyListView()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try

            If dgvjournal.SelectedCells.Count > 0 Then
                For Each selectedcell As DataGridViewCell In dgvjournal.SelectedCells
                    dgvjournal.Rows.RemoveAt(selectedcell.RowIndex)
                Next
                ComputeTotalDebitCredit()
            End If
        Catch ex As Exception
            Exit Sub

        End Try

    End Sub

    Private Sub txtdebit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdebit.KeyPress
        isCurrencyFormat(e)
    End Sub

    Private Sub txtcredit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcredit.KeyPress
        isCurrencyFormat(e)
    End Sub

    Private Sub dgvjournal_SelectionChanged(sender As Object, e As EventArgs) Handles dgvjournal.SelectionChanged
        lblrunningbalance.Text = ""
        If txtgenjrnlno.Text <= maxgjn Then
            If dgvjournal.SelectedCells.Count > 0 Then
                accountid = ExecuteScalar("Select accountid from chartofaccounts where accountname='" & dgvjournal.Rows(dgvjournal.SelectedCells(0).RowIndex).Cells(0).Value & "'")
                lblrunningbalance.Text = JournalFormat(ExecuteScalar("Select ifnull(runningBal,0) from journalentry where accountid = " & accountid & "  order by journalentryid desc limit 1 "))
            End If
        End If
    End Sub


    Private Sub ComputeTotalDebitCredit()
        totaldebit = 0
        totalcredit = 0
        For Each row As DataGridViewRow In dgvjournal.Rows
            totaldebit += row.Cells(1).Value
            totalcredit += row.Cells(2).Value
        Next
        lbltotaldebit.Text = JournalFormat(totaldebit)
        lbltotalcredit.Text = JournalFormat(totalcredit)
    End Sub

    Private Sub cbaccountname_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbaccountname.SelectedValueChanged
       
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        frmChartofAccounts.ShowDialog()
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click
        
    End Sub
End Class