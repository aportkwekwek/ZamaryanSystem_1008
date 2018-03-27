Imports MySql.Data.MySqlClient


Public Class frmCashReceipt
    Dim sqlcon As New MySqlConnection
    Dim sqlcmd As MySqlCommand
    Dim sqlda As MySqlDataAdapter
    Dim modepayment As Integer
    Public publicquery As String
    Dim dt As DataTable


    Public Function getmaxReceiptID()


        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim query As String

            query = "SELECT MAX(receiptID) FROM cashreceipts"
            sqlcmd = New MySqlCommand(query, sqlcon)
            Dim rid = sqlcmd.ExecuteScalar

            lblreceiptid.Text = ("CR" & If(IsDBNull(rid), "100001", Format(Mid(rid, 3, 9)) + 1))


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcon.Close()

        End Try

        Return lblreceiptid


    End Function



    Public Function getcashreciept()

        lvcashreciept.Items.Clear()


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select receiptID, date , grandTotal ,totalCWT , chartofaccounts.accountname  from cashreceipts natural join chartofaccounts where method != 'Null' group by receiptID"

            Dim dtk2 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtk2)

            Dim i As Integer

            While i <= dtk2.Rows.Count - 1
                Dim itm As ListViewItem

                itm = lvcashreciept.Items.Add(dtk2.Rows(i).Item(0))
                itm.SubItems.Add((dtk2.Rows(i).Item(1)))
                itm.SubItems.Add(FormatNumber(dtk2.Rows(i).Item(2)))
                itm.SubItems.Add(FormatNumber(dtk2.Rows(i).Item(3)))
                itm.SubItems.Add(dtk2.Rows(i).Item(4))

                'itm.SubItems.Add(dtk1.Rows(i).Item(8))
                'itm.SubItems.Add(FormatNumber(dtk1.Rows(i).Item(5)))
                ' itm.SubItems.Add(Format(dtk1.Rows(i).Item(3)))

                i += 1

            End While



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            sqlcon.Close()

        End Try

        Return lvcashreciept


    End Function
    Private Sub btnsave_Click(sender As Object, e As EventArgs)


        'Try

        '    If cbmop.selectedValue = Nothing Then

        '    End If

        'Catch ex As Exception
        '    MessageBox.Show("Please select mode of payment", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        '    Exit Sub

        'End Try

        'Dim jk As Integer

        'jk = MessageBox.Show("Are you sure you want to save this transaction?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If jk = vbNo Then
        '    Exit Sub
        'End If

        'getmaxReceiptID()

        'Try

        '    sqlcon.ConnectionString = strconnection()
        '    sqlcon.Open()

        '    Dim qry As String

        '    qry = "SELECT accountid FROM chartofaccounts WHERE accountname='" & cbmop.selectedValue & "'"

        '    sqlcmd = New MySqlCommand(qry, sqlcon)
        '    modepayment = sqlcmd.ExecuteScalar

        '    Dim cashcol2 = lblcashcollected.Text.Replace(",", "")
        '    Dim cwt2 = lbltotalcwt.Text.Replace(",", "")

        '    sqlcmd = New MySqlCommand("INSERT INTO cashreceipts (receiptID,date,grandTotal,totalCWT,method,amountinwords) VALUES ('" & lblreceiptid.Text & "','" & lbldate.Text & "','" & cashcol2 & "','" & cwt2 & "','" & modepayment & "','" & lblamountwords.Text & "')", sqlcon)
        '    sqlcmd.ExecuteNonQuery()


        '    For Each itm As DataGridViewRow In dgvsalesinvoice.Rows
        '        Try
        '            If Boolean.Parse(itm.Cells(0).Value.ToString) = True Then

        '                Dim qry1 As String

        '                qry1 = "INSERT INTO cashreceiptsinvoice (receiptid,invoiceid,CWT,amountPaid) VALUES ('" & lblreceiptid.Text & "','" & itm.Cells(1).Value.ToString() & "','" & itm.Cells(4).Value.ToString() & "','" & itm.Cells(3).Value.ToString() & "')"

        '                cmbAddReceipt.Items.Add(qry1)

        '                Dim qry2 As String

        '                qry2 = "Update salesinvoice set cashCollected ='" & itm.Cells(3).Value.ToString() & "' where invoiceid ='" & itm.Cells(1).Value.ToString() & "'"


        '                cmbUpdateReceipt.Items.Add(qry2)

        '            End If

        '        Catch ex As Exception

        '        End Try

        '    Next

        '    Dim u As Integer

        '    While u <= cmbAddReceipt.Items.Count - 1

        '        sqlcmd = New MySqlCommand(cmbAddReceipt.Items(u).ToString, sqlcon)
        '        sqlcmd.ExecuteNonQuery()
        '        u += 1

        '    End While

        '    Dim j As Integer


        '    While j <= cmbUpdateReceipt.Items.Count - 1

        '        sqlcmd = New MySqlCommand(cmbUpdateReceipt.Items(j).ToString, sqlcon)
        '        sqlcmd.ExecuteNonQuery()
        '        j += 1

        '    End While


        '    sqlcmd = New MySqlCommand("INSERT INTO journal (journaldesc) VALUES ('To record collection')", sqlcon) 'insert into journal description lang
        '    sqlcmd.ExecuteNonQuery()

        '    Dim query222 As String

        '    query222 = "SELECT max(journalid) FROM journal"
        '    sqlcmd = New MySqlCommand(query222, sqlcon)
        '    Dim maxjid = sqlcmd.ExecuteScalar

        '    Dim accountsreceivable = 4, cwt = 23, debit = Convert.ToDouble(lblcashcollected1.Text) + Convert.ToDouble(lbltotalcwt1.Text)


        '    '=======================================

        '    Dim newRunAccRec As Double
        '    sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid =" & accountsreceivable & " order by journalentryid desc limit 1 ", sqlcon)
        '    Dim val1 = sqlcmd.ExecuteScalar

        '    newRunAccRec = val1 - debit

        '    sqlcmd = New MySqlCommand("INSERT INTO journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) VALUES ('" & maxjid & "','" & lbldate.Text & "','" & accountsreceivable & "','0','" & debit & "','Cash Receipts','" & lblreceiptid.Text & "' ,'" & newRunAccRec & "')", sqlcon) 'sa journal entry insert journalid,date,accountid,journaldebit,journalcredit,source kung saan transaction
        '    sqlcmd.ExecuteNonQuery()

        '    '=========================================

        '    Dim newRuncwt As Double
        '    sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & cwt & " order by journalentryid desc limit 1 ", sqlcon)
        '    Dim val2 = sqlcmd.ExecuteScalar


        '    newRuncwt = val2 + lbltotalcwt1.Text

        '    sqlcmd = New MySqlCommand("INSERT INTO journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) VALUES ('" & maxjid & "','" & lbldate.Text & "','" & cwt & "','" & lbltotalcwt1.Text & "','0','Cash Receipts','" & lblreceiptid.Text & "','" & newRuncwt & "')", sqlcon)
        '    sqlcmd.ExecuteNonQuery()

        '    '======================================='


        '    Dim newRunMode As Double
        '    sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & modepayment & " order by journalentryid desc limit 1 ", sqlcon)
        '    Dim val3 = sqlcmd.ExecuteScalar

        '    newRunMode = val3 + lblcashcollected1.Text

        '    sqlcmd = New MySqlCommand("INSERT INTO journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) VALUES ('" & maxjid & "','" & lbldate.Text & "','" & modepayment & "','" & lblcashcollected1.Text & "','0','Cash Receipts','" & lblreceiptid.Text & "','" & newRunMode & "')", sqlcon)
        '    sqlcmd.ExecuteNonQuery()

        '    MessageBox.Show("Transaction saved.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Catch ex As Exception

        '    MessageBox.Show(ex.Message)

        'End Try

        'sqlcon.Close()
        'cmbAddReceipt.Items.Clear()
        'cmbUpdateReceipt.Items.Clear()
        'dgvsalesinvoice.DataSource = Nothing
        'dgvsalesinvoice.Rows.Clear()
        'btnCancelCustomers.PerformClick()

    End Sub

    Private Sub frmCashReceipt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        frmMain.Enabled = True
        frmMain.Focus()

    End Sub

    Private Sub frmCashReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Visible = False

        getmaxReceiptID()

        getcustomerswithbalance()

        getchartofaccounts()

        currenttimer.Start()
        getcashreciept()

    End Sub

    'Private Sub dgvsalesinvoice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    '    dgvsalesinvoice.CommitEdit(DataGridViewDataErrorContexts.Commit)

    'End Sub

    'Private Sub dgvsalesinvoice_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

    '    Try
    '        Dim totcwt As Double

    '        Dim qry1 As String

    '        sqlcon.ConnectionString = strconnection()
    '        sqlcon.Open()


    '        qry1 = "Select cwt from companies"
    '        sqlcmd = New MySqlCommand(qry1, sqlcon)
    '        lblcwt.Text = sqlcmd.ExecuteScalar


    '        Dim cwt = Convert.ToInt32(lblcwt.Text) / 100

    '        Dim cashcol As Double
    '        If dgvsalesinvoice.Rows(e.RowIndex).Cells(0).Value = True Then


    '            dgvsalesinvoice.Rows(e.RowIndex).Cells(4).Value = FormatNumber((CDbl(dgvsalesinvoice.Rows(e.RowIndex).Cells(3).Value) * cwt))

    '            dgvsalesinvoice.Rows(e.RowIndex).Cells(5).Value = dgvsalesinvoice.Rows(e.RowIndex).Cells(3).Value - (CDbl(dgvsalesinvoice.Rows(e.RowIndex).Cells(3).Value) * cwt)

    '        Else

    '            dgvsalesinvoice.Rows(e.RowIndex).Cells(4).Value = 0
    '            dgvsalesinvoice.Rows(e.RowIndex).Cells(5).Value = 0

    '        End If

    '        Dim itm As DataGridViewRow

    '        For Each itm In dgvsalesinvoice.Rows

    '            cashcol += itm.Cells(5).Value.ToString
    '            totcwt += itm.Cells(4).Value.ToString

    '        Next


    '        lbltotalcwt.Text = FormatNumber(totcwt)
    '        lblcashcollected.Text = FormatNumber(cashcol)
    '        lblamountwords.Text = AmountInWords(cashcol)

    '        lbltotalcwt1.Text = totcwt
    '        lblcashcollected1.Text = cashcol


    '    Catch ex As Exception

    '        Exit Sub

    '    Finally

    '        sqlcon.Close()


    '    End Try
    'End Sub

    Public Function getchartofaccounts()

        cbmop.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim query As String

            Dim dtable As New DataTable

            query = "SELECT accountname FROM chartofaccounts WHERE accountname LIKE '%' 'Cash' '%'"

            sqlda = New MySqlDataAdapter(query, sqlcon)
            sqlda.Fill(dtable)

            Dim i As Integer

            i = 0

            While i <= dtable.Rows.Count - 1

                cbmop.AddItem(dtable.Rows(i).Item(0))

                i += 1


            End While

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return cbmop

    End Function

    Private Sub btnCancelCustomers_Click(sender As Object, e As EventArgs)
        cbcustomername.Refresh()
        dgvsalesinvoice.Rows.Clear()
        lblcrid.Text = ""
        lblcraddress.Text = ""
        lblcrzip.Text = ""
        lblcrphone.Text = ""
        lblcrfax.Text = ""
        lblcrcontactperson.Text = ""
        lblcremail.Text = ""
        lblcrtin.Text = ""
        lblcashcollected.Text = ""
        lblamountwords.Text = ""
        lbltotalcwt.Text = ""
        lbltotalcwt.Text = ""
        getchartofaccounts()
        getcustomerswithbalance()
        getmaxReceiptID()

    End Sub


    Public Function getcustomerswithbalance()

        cbcustomername.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim query As String
            Dim dt01 As New DataTable

            query = "SELECT customername FROM salesinvoice NATURAL JOIN customers where remarks ='Approved' group by customername"

            sqlda = New MySqlDataAdapter(query, sqlcon)
            sqlda.Fill(dt01)


            For i As Integer = 0 To dt01.Rows.Count - 1

                cbcustomername.AddItem(dt01.Rows(i).Item(0))

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return cbcustomername

    End Function

    Private Sub currenttimer_Tick(sender As Object, e As EventArgs) Handles currenttimer.Tick

        lbldate.Text = Format(DateTime.Now, "yyyy/MM/dd")

    End Sub

    Private Sub cbcustomername_onItemSelected(sender As Object, e As EventArgs)


        Dim dt212 As New DataTable
        Dim dtr As DataRow

        dt212.Reset()
        dgvsalesinvoice.Rows.Clear()

        Try

            publicquery = "SELECT * FROM customers WHERE customername ='" & cbcustomername.selectedValue & "'"
            Dim customertable = New DataTable
            FillDataTable(customertable)
            lblcrid.Text = customertable.Rows(0).Item("customerid")
            lblcraddress.Text = customertable.Rows(0).Item("customeraddress")
            lblcrzip.Text = customertable.Rows(0).Item("customerzip")
            lblcrphone.Text = customertable.Rows(0).Item("customerphone")
            lblcrfax.Text = customertable.Rows(0).Item("customerfax")
            lblcrcontactperson.Text = customertable.Rows(0).Item("customercontactperson")
            lblcremail.Text = customertable.Rows(0).Item("customeremail")
            lblcrtin.Text = customertable.Rows(0).Item("customertin")


            publicquery = "SELECT salesinvoice.invoiceid,salesinvoice.datesold,salesinvoice.total FROM salesinvoice NATURAL JOIN customers WHERE customername ='" & cbcustomername.selectedValue & "' AND salesinvoice.total > salesinvoice.cashcollected"

            sqlda = New MySqlDataAdapter(publicquery, sqlcon)
            sqlda.Fill(dt212)


            For Each dtr In dt212.Rows

                Dim n As Integer

                n = dgvsalesinvoice.Rows.Add()
                dgvsalesinvoice.Rows(n).Cells(1).Value = dtr("invoiceid").ToString
                dgvsalesinvoice.Rows(n).Cells(2).Value = dtr("datesold").ToString
                dgvsalesinvoice.Rows(n).Cells(3).Value = dtr("total").ToString

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Function FillDataTable()
        dt = New DataTable
        FillDataTable(dt)
        Return dt
    End Function

    Private Sub FillDataTable(datatable As DataTable)
        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            sqlda = New MySqlDataAdapter(publicquery, sqlcon)
            sqlda.Fill(datatable)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub lvcashreciept_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lvcashreciept_MouseClick(sender As Object, e As MouseEventArgs)
        TextBox1.Text = lvcashreciept.SelectedItems.Item(0).Text
        Dim sTitle23 As String
        sTitle23 = TextBox1.Text
        Dim frm23 As New viewcashreciept(sTitle23)
        frm23.Show()
    End Sub

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            If cbmop.selectedValue = "" Then
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Please select mode of collection", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End Try

        If Len(lblamountwords.TextLength) = 0 Then
            MessageBox.Show("Please check at least 1 transaction to collect", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End If

        If txtCheckNumber.Text = Nothing Then

            MessageBox.Show("Please enter the check number", "Sytem Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtCheckNumber.Focus()

            Exit Sub

        End If

        Dim jk As Integer

        jk = MessageBox.Show("Are you sure you want to save this transaction?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If jk = vbNo Then
            Exit Sub
        End If

        getmaxReceiptID()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "SELECT accountid FROM chartofaccounts WHERE accountname='" & cbmop.selectedValue & "'"

            sqlcmd = New MySqlCommand(qry, sqlcon)
            modepayment = sqlcmd.ExecuteScalar


            Dim cashcol = lblcashcollected.Text.Replace(",", "")
            Dim totcwt1 = lbltotalcwt.Text.Replace(",", "")

            sqlcmd = New MySqlCommand("INSERT INTO cashreceipts (receiptID,date,grandTotal,totalCWT,method,amountinwords,checkNumber) VALUES ('" & lblreceiptid.Text & "','" & lbldate.Text & "','" & cashcol & "','" & totcwt1 & "','" & modepayment & "','" & lblamountwords.Text & "','" & txtCheckNumber.Text & "')", sqlcon)
            sqlcmd.ExecuteNonQuery()


            For Each itm As DataGridViewRow In dgvsalesinvoice.Rows
                Try
                    If Boolean.Parse(itm.Cells(0).Value.ToString) = True Then

                        Dim qry1 As String

                        Dim cwt1 = itm.Cells(6).Value.ToString.Replace(",", "")
                        Dim amtpaid1 = itm.Cells(7).Value.ToString().Replace(",", "")
                        qry1 = "INSERT INTO cashreceiptsinvoice (receiptid,invoiceid,CWT,amountPaid) VALUES ('" & lblreceiptid.Text & "'," & itm.Cells(1).Value.ToString() & ",'" & cwt1 & "','" & amtpaid1 & "')"

                        cmbAddReceipt.Items.Add(qry1)

                        Dim qry2 As String

                        Dim cCol = itm.Cells(3).Value.ToString.Replace(",", "")

                        qry2 = "Update salesinvoice set cashCollected =" & cCol & ", remarks = 'Done' where invoiceid = '" & itm.Cells(1).Value.ToString() & "'"
                        cmbUpdateReceipt.Items.Add(qry2)


                    End If

                Catch ex As Exception

                End Try

            Next

            Dim u As Integer

            While u <= cmbAddReceipt.Items.Count - 1

                sqlcmd = New MySqlCommand(cmbAddReceipt.Items(u).ToString, sqlcon)
                sqlcmd.ExecuteNonQuery()
                u += 1

            End While

            Dim j As Integer


            While j <= cmbUpdateReceipt.Items.Count - 1

                sqlcmd = New MySqlCommand(cmbUpdateReceipt.Items(j).ToString, sqlcon)
                sqlcmd.ExecuteNonQuery()
                j += 1

            End While


            sqlcmd = New MySqlCommand("INSERT INTO journal (journaldesc) VALUES ('To record collection')", sqlcon) 'insert into journal description lang
            sqlcmd.ExecuteNonQuery()

            Dim query222 As String

            query222 = "SELECT max(journalid) FROM journal"
            sqlcmd = New MySqlCommand(query222, sqlcon)
            Dim maxjid = sqlcmd.ExecuteScalar



            Dim accountsreceivable As Integer
            accountsreceivable = 4

            Dim cwt As Integer

            cwt = 23

            Dim arCD = CDbl(cashcol) + CDbl(totcwt1)

            'Accounts Receivable credit

            Dim newRunAccReceivable As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid ='" & accountsreceivable & "' order by journalentryid desc limit 1 ", sqlcon)
            Dim val1 = sqlcmd.ExecuteScalar

            newRunAccReceivable = val1 - arCD

            sqlcmd = New MySqlCommand("INSERT INTO journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) VALUES ('" & maxjid & "','" & lbldate.Text & "','" & accountsreceivable & "','0','" & arCD & "','Cash Receipts','" & lblreceiptid.Text & "','" & newRunAccReceivable & "')", sqlcon) 'sa journal entry insert journalid,date,accountid,journaldebit,journalcredit,source kung saan transaction
            sqlcmd.ExecuteNonQuery()

            'CWT debit 

            Dim newCWT As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid ='" & cwt & "' order by journalentryid desc limit 1 ", sqlcon)
            Dim val2 = sqlcmd.ExecuteScalar

            newCWT = val2 + CDbl(totcwt1)

            Dim tot1cwt = lbltotalcwt.Text.Replace(",", "")

            sqlcmd = New MySqlCommand("INSERT INTO journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) VALUES ('" & maxjid & "','" & lbldate.Text & "','" & cwt & "','" & tot1cwt & "','0','Cash Receipts','" & lblreceiptid.Text & "','" & newCWT & "')", sqlcon)
            sqlcmd.ExecuteNonQuery()

            Dim cashcollected = lblcashcollected.Text.Replace(",", "")

            'mode of collection last CASH

            Dim newCash As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid ='" & modepayment & "' order by journalentryid desc limit 1 ", sqlcon)
            Dim val3 = sqlcmd.ExecuteScalar

            newCash = val2 + CDbl(cashcollected)

            sqlcmd = New MySqlCommand("INSERT INTO journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) VALUES ('" & maxjid & "','" & lbldate.Text & "','" & modepayment & "','" & cashcollected & "','0','Cash Receipts','" & lblreceiptid.Text & "','" & newCash & "')", sqlcon)
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Transaction saved.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception


        End Try

        sqlcon.Close()
        cmbAddReceipt.Items.Clear()
        cmbUpdateReceipt.Items.Clear()
        dgvsalesinvoice.DataSource = Nothing
        dgvsalesinvoice.Rows.Clear()
        btnCancelCustomers.PerformClick()


        getcashreciept()

    End Sub

    Private Sub dgvsalesinvoice_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsalesinvoice.CellContentClick
        dgvsalesinvoice.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub dgvsalesinvoice_CellValueChanged1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsalesinvoice.CellValueChanged
        Try
            Dim totcwt As Double

            Dim qry1 As String

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            qry1 = "Select cwt from companies"
            sqlcmd = New MySqlCommand(qry1, sqlcon)
            lblcwt.Text = sqlcmd.ExecuteScalar


            Dim cwt = Convert.ToInt32(lblcwt.Text) / 100

            Dim cashcol As Double
            If dgvsalesinvoice.Rows(e.RowIndex).Cells(0).Value = True Then


                dgvsalesinvoice.Rows(e.RowIndex).Cells(6).Value = FormatNumber((CDbl(dgvsalesinvoice.Rows(e.RowIndex).Cells(3).Value) * cwt))

                dgvsalesinvoice.Rows(e.RowIndex).Cells(6).Value = FormatNumber(dgvsalesinvoice.Rows(e.RowIndex).Cells(6).Value)
                dgvsalesinvoice.Rows(e.RowIndex).Cells(7).Value = dgvsalesinvoice.Rows(e.RowIndex).Cells(5).Value - (CDbl(dgvsalesinvoice.Rows(e.RowIndex).Cells(6).Value))

                dgvsalesinvoice.Rows(e.RowIndex).Cells(7).Value = FormatNumber(dgvsalesinvoice.Rows(e.RowIndex).Cells(7).Value)

            Else

                dgvsalesinvoice.Rows(e.RowIndex).Cells(6).Value = FormatNumber(0)
                dgvsalesinvoice.Rows(e.RowIndex).Cells(7).Value = FormatNumber(0)

            End If

            Dim itm As DataGridViewRow

            For Each itm In dgvsalesinvoice.Rows

                cashcol += itm.Cells(7).Value.ToString
                totcwt += itm.Cells(6).Value.ToString

            Next

            lbltotalcwt.Text = FormatNumber(totcwt)
            lblcashcollected.Text = FormatNumber(cashcol)
            lblamountwords.Text = AmountInWords(cashcol)

        Catch ex As Exception

            Exit Sub

        Finally

            sqlcon.Close()


        End Try
    End Sub

    Private Sub cbcustomername_onItemSelected_1(sender As Object, e As EventArgs) Handles cbcustomername.onItemSelected

        Dim dt212 As New DataTable
        Dim dtr As DataRow

        dt212.Reset()
        dgvsalesinvoice.Rows.Clear()

        Try

            publicquery = "SELECT customers.customerid,customers.customeraddress,customers.customerzip,customers.customerphone,customers.customerfax,customers.customercontactperson, customers.customeremail,customers.customertin FROM customers inner join salesinvoice where salesinvoice.remarks ='Approved' and customers.customername ='" & cbcustomername.selectedValue & "' "
            Dim customertable = New DataTable
            FillDataTable(customertable)
            lblcrid.Text = customertable.Rows(0).Item("customerid")
            lblcraddress.Text = customertable.Rows(0).Item("customeraddress")
            lblcrzip.Text = customertable.Rows(0).Item("customerzip")
            lblcrphone.Text = customertable.Rows(0).Item("customerphone")
            lblcrfax.Text = customertable.Rows(0).Item("customerfax")
            lblcrcontactperson.Text = customertable.Rows(0).Item("customercontactperson")
            lblcremail.Text = customertable.Rows(0).Item("customeremail")
            lblcrtin.Text = customertable.Rows(0).Item("customertin")


            publicquery = "SELECT salesinvoice.invoiceid,salesinvoice.datesold,salesinvoice.total - salesinvoice.outputVat as 'Base', salesinvoice.outputVat,salesinvoice.total FROM salesinvoice NATURAL JOIN customers WHERE customername ='" & cbcustomername.selectedValue & "' AND salesinvoice.remarks='Approved'"

            sqlda = New MySqlDataAdapter(publicquery, sqlcon)
            sqlda.Fill(dt212)


            For Each dtr In dt212.Rows

                Dim n As Integer

                n = dgvsalesinvoice.Rows.Add()
                dgvsalesinvoice.Rows(n).Cells(1).Value = dtr("invoiceid").ToString
                dgvsalesinvoice.Rows(n).Cells(2).Value = dtr("datesold").ToString
                dgvsalesinvoice.Rows(n).Cells(3).Value = FormatNumber(dtr("Base").ToString)
                dgvsalesinvoice.Rows(n).Cells(4).Value = FormatNumber(dtr("outputVat").ToString)
                dgvsalesinvoice.Rows(n).Cells(5).Value = FormatNumber(dtr("total").ToString)

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click

    End Sub

    Private Sub lvcashreciept_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvcashreciept.SelectedIndexChanged

    End Sub

    Private Sub lvcashreciept_MouseClick_1(sender As Object, e As MouseEventArgs) Handles lvcashreciept.MouseClick
        TextBox2.Text = lvcashreciept.SelectedItems.Item(0).Text
        Dim sTitle23 As String
        sTitle23 = TextBox2.Text
        Dim frm7 As New viewcashreciept(sTitle23)
        frm7.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tabInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabInventory.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        viewreportprintallcashreciept.Show()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        getcashreciept()

    End Sub
End Class