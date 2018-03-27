Imports MySql.Data.MySqlClient

Public Class frmCashDisbursement
    Dim sqlcon As New MySqlConnection
    Dim sqlcmd As MySqlCommand
    Dim sqlda As MySqlDataAdapter


    Public Function getcashinven()

        lvbilling.Items.Clear()


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select cashdisbursment.disbursmentID , cashdisbursment.date , cashdisbursment.grandTotal , suppliers.suppliername from cashdisbursment inner join cashdisbursmentrr on cashdisbursment.disbursmentID = cashdisbursmentrr.disbursmentid INNER JOIN receivingreport on cashdisbursmentrr.reportid = receivingreport.reportid inner join purchaseorder on receivingreport.purchaseorderid = purchaseorder.purchaseorderid inner join suppliers on purchaseorder.supplierid = suppliers.supplierid group by cashdisbursment.disbursmentID"

            Dim dtk4 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtk4)

            Dim i As Integer

            While i <= dtk4.Rows.Count - 1
                Dim itm As ListViewItem

                itm = lvbilling.Items.Add(dtk4.Rows(i).Item(0))
                itm.SubItems.Add((dtk4.Rows(i).Item(1)))
                itm.SubItems.Add(FormatNumber(dtk4.Rows(i).Item(2)))
                itm.SubItems.Add((dtk4.Rows(i).Item(3)))
            

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

        Return lvbilling


    End Function

    Public Function getcashrr()

        lvcashrr.Items.Clear()


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry1 As String

            qry1 = "Select cashdisbursment.disbursmentid , cashdisbursment.date , cashdisbursment.grandTotal , suppliers.suppliername from cashdisbursment inner join cashdisbursmentapv on cashdisbursment.disbursmentID = cashdisbursmentapv.disbursmentid inner join billings on cashdisbursmentapv.APVid = billings.APVid inner join suppliers on billings.supplierid = suppliers.supplierid  group by cashdisbursment.disbursmentid"

            Dim dtk4 As New DataTable

            sqlda = New MySqlDataAdapter(qry1, sqlcon)
            sqlda.Fill(dtk4)

            Dim i As Integer

            While i <= dtk4.Rows.Count - 1
                Dim itm As ListViewItem

                itm = lvcashrr.Items.Add(dtk4.Rows(i).Item(0))
                itm.SubItems.Add((dtk4.Rows(i).Item(1)))
                itm.SubItems.Add(FormatNumber(dtk4.Rows(i).Item(2)))
                itm.SubItems.Add((dtk4.Rows(i).Item(3)))


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

        Return lvcashrr


    End Function



    Public Function disbursmentid()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select MAX(disbursmentid) from cashdisbursment"

            Dim dtMax As New DataTable
            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtMax)

            For i = 0 To dtMax.Rows.Count - 1

                lblDisbursmentID.Text = (If(IsDBNull(dtMax.Rows(i).Item(0)), "CD10001", "CD" & Format(Mid(dtMax.Rows(i).Item(0), 3, 9)) + 1))
                lblCashdisbursment1.Text = (If(IsDBNull(dtMax.Rows(i).Item(0)), "CD10001", "CD" & Format(Mid(dtMax.Rows(i).Item(0), 3, 9)) + 1))
                i += 1

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return lblDisbursmentID
        Return lblCashdisbursment1

    End Function
    Private Sub btnHeaderSave_Click(sender As Object, e As EventArgs) Handles btnHeaderSave.Click


        Try
            If cmbModeofPayment.selectedValue = "" Then

            End If
        Catch ex As Exception
            MessageBox.Show("Please select mode of payment", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End Try
       

        If txtCheckNumber.Text = Nothing Then
            MessageBox.Show("Please enter check number", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtCheckNumber.Focus()
            Exit Sub

        End If


        If lblamountwords.TextLength = 0 Then

            MessageBox.Show("Please check at least 1 item to pay", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        Dim i As Integer

        i = MessageBox.Show("You are about to save the information. Do you wish to continue?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbYes Then
        Else
            Exit Sub

        End If

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry2, qry1 As String


            Dim accountid As Integer

            qry1 = "Select accountid from chartofaccounts where accountname ='" & cmbModeofPayment.selectedValue & "'" 'gets accountid of mode of payment, a query that returns a single value

            Dim dtu As New DataTable


            sqlcmd = New MySqlCommand(qry1, sqlcon)
            accountid = sqlcmd.ExecuteScalar

            'you can turn this block of code into a single-line ExecuteScalar by the way


            Dim amtpx = txtAmtPdrr.Text.Replace(",", "")
            Dim totcwtx = lbltotalcwt.Text.Replace(",", "")


            qry2 = "Insert into cashdisbursment (disbursmentid,date,grandtotal,totalCWT,method,amountinwords,checkNumber) values ('" & lblDisbursmentID.Text & "','" & lblDate.Text & "','" & amtpx & "','" & lblTotalCWT1.Text & "','" & accountid & "','" & lblamountwords.Text & "','" & txtCheckNumber.Text & "')"

            sqlcmd = New MySqlCommand(qry2, sqlcon)
            sqlcmd.ExecuteNonQuery()

            'íf value is checked 

            For Each dtrow As DataGridViewRow In dgvUnpaidBalance.Rows
                Try
                    If Boolean.Parse(dtrow.Cells(0).Value.ToString) = True Then

                        Dim qry3 As String

                        Dim cwt = dtrow.Cells(6).Value.ToString.Replace(",", "")
                        Dim amtPaidp = dtrow.Cells(7).Value.ToString.Replace(",", "")

                        qry3 = "Insert into cashdisbursmentrr (disbursmentid,reportid,CWT,amountPaid) values ('" & lblDisbursmentID.Text & "','" & dtrow.Cells(1).Value.ToString & "','" & cwt & "','" & amtPaidp & "')"
                        cmbAddcashReceipts.Items.Add(qry3)

                        Dim qry4 As String
                        qry4 = "Update receivingreport set status ='Paid' where reportid ='" & dtrow.Cells(1).Value.ToString & "'"
                        cmbUpdateCashReceipts.Items.Add(qry4)

                    End If
                Catch ex As Exception

                End Try

            Next

            Dim oo As Integer

            While oo <= cmbAddcashReceipts.Items.Count - 1

                sqlcmd = New MySqlCommand(cmbAddcashReceipts.Items(oo).ToString, sqlcon)
                sqlcmd.ExecuteNonQuery()

                oo += 1

            End While

            Dim hindi As Integer

            While hindi <= cmbUpdateCashReceipts.Items.Count - 1

                sqlcmd = New MySqlCommand(cmbUpdateCashReceipts.Items(hindi).ToString, sqlcon)
                sqlcmd.ExecuteNonQuery()

                hindi += 1

            End While


            sqlcmd = New MySqlCommand("Insert into journal(journaldesc) values ('To record payment')", sqlcon)
            sqlcmd.ExecuteNonQuery()

            Dim journalid As Integer

            Dim qry7 As String

            qry7 = "Select max(journalid) from journal" 'gets most recent journal by journalid, another query that returns a single value

            sqlcmd = New MySqlCommand(qry7, sqlcon)
            journalid = sqlcmd.ExecuteScalar


            Dim qry8 As String

            Dim accpayable, wtp As Integer

            accpayable = 8
            wtp = 24


            '================Accounts Payable =================='

            Dim superTotal As Double

            Dim totalcwt0 = lbltotalcwt.Text.Replace(",", "")


            superTotal = CDbl(amtpx) + CDbl(totalcwt0)

            Dim newRunAccpayable As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & accpayable & " order by journalentryid desc limit 1 ", sqlcon)
            Dim val1 = sqlcmd.ExecuteScalar

            newRunAccpayable = val1 + superTotal

            qry8 = "Insert into journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & journalid & "','" & lblDate.Text & "','" & accpayable & "','" & superTotal & "','0','Cash Disbursement Inventory','" & lblDisbursmentID.Text & "','" & newRunAccpayable & "')"

            sqlcmd = New MySqlCommand(qry8, sqlcon)
            sqlcmd.ExecuteNonQuery()


            '==================W=T=P=====================

            Dim qry9 As String

            Dim newRunWTP As Double
            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & wtp & " order by journalentryid desc limit 1 ", sqlcon)
            Dim val2 = sqlcmd.ExecuteScalar


            newRunWTP = val2 - CDbl(totalcwt0)

            qry9 = "Insert into journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & journalid & "','" & lblDate.Text & "','" & wtp & "','0','" & totalcwt0 & "','Cash Disbursement Inventory','" & lblDisbursmentID.Text & "','" & newRunWTP & "')"

            sqlcmd = New MySqlCommand(qry9, sqlcon)
            sqlcmd.ExecuteNonQuery()

            '==============Account Cash=============================

            Dim qry10 As String

            Dim newRunAccID As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & accountid & " order by journalentryid desc limit 1 ", sqlcon)
            Dim val3 = sqlcmd.ExecuteScalar

            Dim amtp0 = lblAmountPaid1.Text.Replace(",", "")

            newRunAccID = val3 - CDbl(amtp0)

            qry10 = "Insert into journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & journalid & "','" & lblDate.Text & "','" & accountid & "','0','" & amtpx & "','Cash Disbursement Inventory','" & lblDisbursmentID.Text & "','" & newRunAccID & "')"
            sqlcmd = New MySqlCommand(qry10, sqlcon)
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Information Successfully Saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            sqlcon.Close()
            lvcashdisbursement.Items.Clear()
            cmbAddcashReceipts.Items.Clear()
            cmbUpdateCashReceipts.Items.Clear()
            getSupplier()
            dgvUnpaidBalance.Rows.Clear()
            btnCancelIventory.PerformClick()
            disbursmentid()
            getcashrr()
            getcashinven()
            txtCheckNumber.Clear()


        End Try


    End Sub

    Public Function getSupplierAPV()
        Try
            cmbSupplierBilling1.Clear()

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select suppliers.suppliername from suppliers natural join billings where billings.isPaid = 'Unpaid' group by suppliers.suppliername"

            Dim dt12125 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt12125)

            Dim i As Integer

            While i <= dt12125.Rows.Count - 1

                cmbSupplierBilling1.AddItem(dt12125.Rows(i).Item(0))
                i += 1

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

        Return cmbSupplierBilling1

    End Function


    Public Function getSupplier()

        Try

            cmbsupplierbilling.Clear()

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select suppliers.suppliername from receivingreport inner join purchaseorder on receivingreport.purchaseorderid = purchaseorder.purchaseorderid inner join suppliers on purchaseorder.supplierid = suppliers.supplierid where receivingreport.status ='Unpaid' group by suppliers.suppliername order by suppliers.suppliername asc"

            Dim suppDt As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(suppDt)
            Dim i As Integer

            i = 0

            While i <= suppDt.Rows.Count - 1

                cmbsupplierbilling.AddItem(suppDt.Rows(i).Item(0))

                i += 1

            End While


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return cmbsupplierbilling

    End Function
    Private Sub dgvUnpaidBalance_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnpaidBalance.CellContentClick
        dgvUnpaidBalance.CommitEdit(DataGridViewDataErrorContexts.Commit)

    End Sub
    Private Sub dgvUnpaidBalance_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnpaidBalance.CellValueChanged

        Try

            Dim totwtp As Double

            Dim qry1 As String

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            qry1 = "Select vendorTax from suppliers"
            sqlcmd = New MySqlCommand(qry1, sqlcon)
            lblcwt.Text = sqlcmd.ExecuteScalar


            Dim wtp = Convert.ToInt32(lblcwt.Text) / 100

            Dim cashcol As Double
            If dgvUnpaidBalance.Rows(e.RowIndex).Cells(0).Value = True Then

                dgvUnpaidBalance.Rows(e.RowIndex).Cells(6).Value = FormatNumber((CDbl(dgvUnpaidBalance.Rows(e.RowIndex).Cells(3).Value) * wtp))

                dgvUnpaidBalance.Rows(e.RowIndex).Cells(6).Value = FormatNumber(dgvUnpaidBalance.Rows(e.RowIndex).Cells(6).Value)

                dgvUnpaidBalance.Rows(e.RowIndex).Cells(7).Value = FormatNumber(dgvUnpaidBalance.Rows(e.RowIndex).Cells(5).Value - (CDbl(dgvUnpaidBalance.Rows(e.RowIndex).Cells(6).Value)))
                dgvUnpaidBalance.Rows(e.RowIndex).Cells(7).Value = FormatNumber(dgvUnpaidBalance.Rows(e.RowIndex).Cells(7).Value)

            Else

                dgvUnpaidBalance.Rows(e.RowIndex).Cells(6).Value = FormatNumber(0)
                dgvUnpaidBalance.Rows(e.RowIndex).Cells(7).Value = FormatNumber(0)

            End If

            Dim itm As DataGridViewRow

            For Each itm In dgvUnpaidBalance.Rows

                cashcol += itm.Cells(7).Value.ToString
                totwtp += itm.Cells(6).Value.ToString

            Next

            lbltotalcwt.Text = FormatNumber(totwtp)
            lblamountpaid.Text = FormatNumber(cashcol)


            txtAmtPdrr.Text = cashcol - totwtp


            txtAmtPdrr.Text = FormatNumber(txtAmtPdrr.Text)
            lblamountwords.Text = AmountInWords(txtAmtPdrr.Text)

            lblTotalCWT1.Text = totwtp
            lblAmountPaid1.Text = cashcol


        Catch ex As Exception

            Exit Sub

        Finally

            sqlcon.Close()

        End Try

    End Sub

    Public Function getChartofAcc()

        cmbModeofPayment.Clear()
        cmbModeofPayment1.Clear()


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select accountname from chartofAccounts where accountname like '%' 'Cash' '%' "

            Dim dt12 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt12)

            Dim i As Integer

            While i <= dt12.Rows.Count - 1

                cmbModeofPayment.AddItem(dt12.Rows(i).Item(0))
                cmbModeofPayment1.AddItem(dt12.Rows(i).Item(0))
                i += 1

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return cmbModeofPayment
        Return cmbModeofPayment1


    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblDate.Text = Format(Date.Now, "yyyy-MM-dd")
        lblDateAPV.Text = Format(Date.Now, "yyyy-MM-dd")

    End Sub

    Private Sub frmCashDisbursement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        frmMain.Enabled = True
        frmMain.Focus()

    End Sub

    Private Sub frmCashDisbursement_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Timer1.Start()
        getChartofAcc()
        disbursmentid()
        getSupplier()
        getcashinven()
        getcashrr()
        getSupplierAPV()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        frmMain.Focus()

    End Sub

    Private Sub cmbSupplierBilling_onItemSelected_1(sender As Object, e As EventArgs) Handles cmbSupplierBilling.onItemSelected

        dgvUnpaidBalance.Rows.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select * from suppliers where suppliername ='" & cmbSupplierBilling.selectedValue & "'"

            sqlda = New MySqlDataAdapter(qry, sqlcon)

            Dim dt3 As New DataTable

            sqlda.Fill(dt3)

            For i = 0 To dt3.Rows.Count - 1

                lblcwt.Text = dt3.Rows(i).Item("vendorTax")

                txtCDSAddress.Text = dt3.Rows(i).Item("supplieraddress")
                txtCDSContact.Text = dt3.Rows(i).Item("suppliercontactperson")
                txtCDSEmail.Text = dt3.Rows(i).Item("supplieremail")
                txtCDSFax.Text = dt3.Rows(i).Item("supplierfax")
                txtCDSID.Text = dt3.Rows(i).Item("supplierid")
                txtCDSNumber.Text = dt3.Rows(i).Item("supplierphone")
                txtCDSTin.Text = dt3.Rows(i).Item("suppliertin")
                txtCDSWebsite.Text = dt3.Rows(i).Item("supplierwebsite")
                txtCDSZip.Text = dt3.Rows(i).Item("supplierzip")
                i += 1

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            sqlcon.Close()
        End Try


        disbursmentid()

        Dim dt123 As New DataTable
        Dim drow As DataRow
        dt123.Reset()
        dgvUnpaidBalance.Rows.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select receivingreport.reportid,receivingreport.duedate,receivingreport.total - receivingreport.inputVat,receivingreport.inputVat, receivingreport.total,receivingreport.status from receivingreport inner join purchaseorder on receivingreport.purchaseorderid = purchaseorder.purchaseorderid inner join suppliers on purchaseorder.supplierid = suppliers.supplierid where suppliers.suppliername ='" & cmbSupplierBilling.selectedValue & "' and receivingreport.status ='Unpaid'"

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt123)

            For Each drow In dt123.Rows

                Dim l As Integer

                l = dgvUnpaidBalance.Rows.Add()

                dgvUnpaidBalance.Rows(l).Cells(1).Value = dt123.Rows(l).Item(0).ToString 'reportid
                dgvUnpaidBalance.Rows(l).Cells(2).Value = FormatDateTime(dt123.Rows(l).Item(1).ToString, DateFormat.ShortDate) 'duedate
                dgvUnpaidBalance.Rows(l).Cells(3).Value = FormatNumber(dt123.Rows(l).Item(2).ToString) 'basetotal
                dgvUnpaidBalance.Rows(l).Cells(4).Value = FormatNumber(dt123.Rows(l).Item(3).ToString) 'inputvat
                dgvUnpaidBalance.Rows(l).Cells(5).Value = FormatNumber(dt123.Rows(l).Item(4).ToString) 'total
            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try
    End Sub


    Private Sub dgvUnpaidBalance1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnpaidBalance1.CellContentClick

        dgvUnpaidBalance1.CommitEdit(DataGridViewDataErrorContexts.Commit)

    End Sub

    Private Sub cmbSupplierBilling1_onItemSelected(sender As Object, e As EventArgs) Handles cmbSupplierBilling1.onItemSelected
        dgvUnpaidBalance1.Rows.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select * from suppliers where suppliername ='" & cmbSupplierBilling1.selectedValue & "'"

            sqlda = New MySqlDataAdapter(qry, sqlcon)

            Dim dt3 As New DataTable

            sqlda.Fill(dt3)

            For i = 0 To dt3.Rows.Count - 1

                lblcwt1.Text = dt3.Rows(i).Item("vendorTax")
               
                txtCDSAddress1.Text = dt3.Rows(i).Item("supplieraddress")
                txtCDSContact1.Text = dt3.Rows(i).Item("suppliercontactperson")
                txtCDSEmail1.Text = dt3.Rows(i).Item("supplieremail")
                txtCDSFax1.Text = dt3.Rows(i).Item("supplierfax")
                txtCDSID1.Text = dt3.Rows(i).Item("supplierid")
                txtCDSNumber1.Text = dt3.Rows(i).Item("supplierphone")
                txtCDSTin1.Text = dt3.Rows(i).Item("suppliertin")
                txtCDSWebsite1.Text = dt3.Rows(i).Item("supplierwebsite")
                txtCDSZip1.Text = dt3.Rows(i).Item("supplierzip")
                i += 1

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            sqlcon.Close()
        End Try


        disbursmentid()


        Try

            Dim dt123 As New DataTable
            Dim drow As DataRow
            dt123.Reset()

            dgvUnpaidBalance.Rows.Clear()

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select APVid,duedate,totalBill - inputVat, inputVat, totalBill from billings natural join suppliers where suppliers.suppliername ='" & cmbSupplierBilling1.selectedValue & "' and billings.isPaid ='Unpaid'"


            '"Select receivingreport.reportid,receivingreport.duedate,receivingreport.inputVat, receivingreport.total,receivingreport.status from receivingreport inner join purchaseorder on receivingreport.purchaseorderid = purchaseorder.purchaseorderid inner join suppliers on purchaseorder.supplierid = suppliers.supplierid where suppliers.suppliername ='" & cmbSupplierBilling1.selectedValue & "' and receivingreport.status ='Unpaid'"


            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt123)


            dgvUnpaidBalance1.Columns(2).DefaultCellStyle.Format = "yyyy-MM-dd"


            For Each drow In dt123.Rows

                Dim l As Integer

                l = dgvUnpaidBalance1.Rows.Add()

                dgvUnpaidBalance1.Rows(l).Cells(1).Value = dt123.Rows(l).Item(0).ToString 'reportid
                dgvUnpaidBalance1.Rows(l).Cells(2).Value = FormatDateTime(dt123.Rows(l).Item(1).ToString, DateFormat.ShortDate) 'duedate
                dgvUnpaidBalance1.Rows(l).Cells(3).Value = FormatNumber(dt123.Rows(l).Item(2).ToString) 'basetotal
                dgvUnpaidBalance1.Rows(l).Cells(4).Value = FormatNumber(dt123.Rows(l).Item(3).ToString) 'vat
                dgvUnpaidBalance1.Rows(l).Cells(5).Value = FormatNumber(dt123.Rows(l).Item(4).ToString) 'total

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try
    End Sub

    Private Sub dgvUnpaidBalance1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnpaidBalance1.CellValueChanged

        Try

            Dim totwtp As Double

            Dim qry1 As String

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            qry1 = "Select vendorTax from suppliers"
            sqlcmd = New MySqlCommand(qry1, sqlcon)
            lblcwt.Text = sqlcmd.ExecuteScalar


            Dim wtp = Convert.ToInt32(lblcwt1.Text) / 100

            Dim cashcol As Double
            If dgvUnpaidBalance1.Rows(e.RowIndex).Cells(0).Value = True Then

                dgvUnpaidBalance1.Rows(e.RowIndex).Cells(6).Value = FormatNumber((CDbl(dgvUnpaidBalance1.Rows(e.RowIndex).Cells(3).Value) * wtp)) '3 Base Amount

                
                dgvUnpaidBalance1.Rows(e.RowIndex).Cells(7).Value = FormatNumber(dgvUnpaidBalance1.Rows(e.RowIndex).Cells(5).Value - (CDbl(dgvUnpaidBalance1.Rows(e.RowIndex).Cells(6).Value)))


            Else

                dgvUnpaidBalance1.Rows(e.RowIndex).Cells(6).Value = FormatNumber(0)
                dgvUnpaidBalance1.Rows(e.RowIndex).Cells(7).Value = FormatNumber(0)

            End If

            Dim itm As DataGridViewRow

            For Each itm In dgvUnpaidBalance1.Rows

                cashcol += itm.Cells(7).Value.ToString
                totwtp += itm.Cells(6).Value.ToString

            Next

            lbltotalcwt3.Text = FormatNumber(totwtp)
            lblamountpaid2.Text = FormatNumber(cashcol)
            

            txtAmtPd1.Text = cashcol - totwtp
            txtAmtPd1.Text = FormatNumber(txtAmtPd1.Text)
            lblamountwords2.Text = AmountInWords(txtAmtPd1.Text)


            lblTotalCWT2.Text = totwtp

        Catch ex As Exception

            Exit Sub

        Finally

            sqlcon.Close()

        End Try

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles btnCancelIventory.Click
        getChartofAcc()

    End Sub

    Private Sub btnHeaderSave1_Click(sender As Object, e As EventArgs) Handles btnHeaderSave1.Click

        If lblamountwords2.TextLength = 0 Then

            MessageBox.Show("Please check at least 1 item to pay", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        Try
            If cmbModeofPayment1.selectedValue = "" Then
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Please select mode of payment", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End Try

        If lblamountwords2.TextLength = 0 Then
            MessageBox.Show("Please check at least 1 transaction to pay", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End If

        If txtCheckNumber2.Text = Nothing Then
            MessageBox.Show("Please enter check number", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtCheckNumber2.Focus()
            Exit Sub

        End If

        Dim i As Integer

        i = MessageBox.Show("You are about to save the information. Do you wish to continue?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbYes Then
        Else
            Exit Sub

        End If

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry2, qry1 As String


            Dim accountid As Integer

            qry1 = "Select accountid from chartofaccounts where accountname ='" & cmbModeofPayment1.selectedValue & "'" 'gets accountid of mode of payment, a query that returns a single value

            Dim dtu As New DataTable


            sqlcmd = New MySqlCommand(qry1, sqlcon)
            accountid = sqlcmd.ExecuteScalar

            Dim amountpaidl = txtAmtPd1.Text.Replace(",", "")

            'you can turn this block of code into a single-line ExecuteScalar by the way

            qry2 = "Insert into cashdisbursment (disbursmentid,date,grandtotal,totalCWT,method,amountinwords,checkNumber) values ('" & lblCashdisbursment1.Text & "','" & lblDateAPV.Text & "','" & amountpaidl & "','" & lblTotalCWT2.Text & "','" & accountid & "','" & lblamountwords2.Text & "','" & txtCheckNumber2.Text & "')"

            sqlcmd = New MySqlCommand(qry2, sqlcon)
            sqlcmd.ExecuteNonQuery()

            'íf value is checked 

            For Each dtrow As DataGridViewRow In dgvUnpaidBalance1.Rows

                Try
                    If Boolean.Parse(dtrow.Cells(0).Value.ToString) = True Then

                        Dim qry3 As String

                        Dim cwtP = dtrow.Cells(6).Value.ToString.Replace(",", "")
                        Dim amtP = dtrow.Cells(7).Value.ToString.Replace(",", "")


                        qry3 = "Insert into cashdisbursmentAPV (disbursmentid,APVid,CWT,amountPaid) values ('" & lblDisbursmentID.Text & "','" & dtrow.Cells(1).Value.ToString & "','" & cwtP & "','" & amtP & "')"
                        cmbAddcashReceipts.Items.Add(qry3)

                        Dim qry4 As String
                        qry4 = "Update billings set isPaid ='Paid' where APVid ='" & dtrow.Cells(1).Value.ToString & "'"
                        cmbUpdateCashReceipts.Items.Add(qry4)


                    End If
                Catch ex As Exception

                End Try

            Next

            Dim oo As Integer

            While oo <= cmbAddcashReceipts.Items.Count - 1

                sqlcmd = New MySqlCommand(cmbAddcashReceipts.Items(oo).ToString, sqlcon)
                sqlcmd.ExecuteNonQuery()

                oo += 1

            End While

            Dim hindi As Integer

            While hindi <= cmbUpdateCashReceipts.Items.Count - 1

                sqlcmd = New MySqlCommand(cmbUpdateCashReceipts.Items(hindi).ToString, sqlcon)
                sqlcmd.ExecuteNonQuery()

                hindi += 1

            End While


            sqlcmd = New MySqlCommand("Insert into journal(journaldesc) values ('To record payment')", sqlcon)
            sqlcmd.ExecuteNonQuery()

            Dim journalid As Integer

            Dim qry7 As String

            qry7 = "Select max(journalid) from journal" 'gets most recent journal by journalid, another query that returns a single value

            sqlcmd = New MySqlCommand(qry7, sqlcon)
            journalid = sqlcmd.ExecuteScalar


            Dim qry8 As String

            Dim accpayable, wtp As Integer

            accpayable = 8
            wtp = 24


            '================

            Dim superTotal As Double

            Dim amountpaidx = lblamountpaid2.Text.Replace(",", "")

            superTotal = amountpaidx + CDbl(lblTotalCWT2.Text)

            Dim newRunAccpayable As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & accpayable & " order by journalentryid desc limit 1 ", sqlcon)
            Dim val1 = sqlcmd.ExecuteScalar

            newRunAccpayable = val1 + superTotal

            'Accounts Payable Debit

            qry8 = "Insert into journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & journalid & "','" & lblDateAPV.Text & "','" & accpayable & "','" & superTotal & "','0','Cash Disbursement APV','" & lblCashdisbursment1.Text & "','" & newRunAccpayable & "')"

            sqlcmd = New MySqlCommand(qry8, sqlcon)
            sqlcmd.ExecuteNonQuery()


            '==================W=T=P=====================

            Dim qry9 As String

            Dim newRunWTP As Double
            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & wtp & " order by journalentryid desc limit 1 ", sqlcon)
            Dim val2 = sqlcmd.ExecuteScalar

            newRunWTP = val2 - lblTotalCWT2.Text

            qry9 = "Insert into journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & journalid & "','" & lblDateAPV.Text & "','" & wtp & "','0','" & lblTotalCWT2.Text & "','Cash Disbursement APV','" & lblCashdisbursment1.Text & "','" & newRunWTP & "')"

            sqlcmd = New MySqlCommand(qry9, sqlcon)
            sqlcmd.ExecuteNonQuery()

            '==============Account Cash=============================

            Dim qry10 As String

            Dim newRunAccID As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & accountid & " order by journalentryid desc limit 1 ", sqlcon)
            Dim val3 = sqlcmd.ExecuteScalar

            Dim amtpaid = lblamountpaid2.Text.Replace(",", "")

            newRunAccID = val3 - amtpaid

            qry10 = "Insert into journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & journalid & "','" & lblDateAPV.Text & "','" & accountid & "','0','" & amtpaid & "','Cash Disbursement APV','" & lblCashdisbursment1.Text & "','" & newRunAccID & "')"
            sqlcmd = New MySqlCommand(qry10, sqlcon)
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Information Successfully Saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        Finally

            sqlcon.Close()
            lvcashdisbursement.Items.Clear()
            cmbAddcashReceipts.Items.Clear()
            cmbUpdateCashReceipts.Items.Clear()
            getSupplier()
            dgvUnpaidBalance.Rows.Clear()
            btnCancelIventory.PerformClick()
            disbursmentid()
            getcashrr()
            getcashinven()

        End Try
        txtCheckNumber2.Clear()
        btnCancelAPV.PerformClick()
        btnClose.PerformClick()

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub lvbilling_MouseClick(sender As Object, e As MouseEventArgs) Handles lvbilling.MouseClick
        Try


            TextBox1.Text = lvbilling.SelectedItems.Item(0).Text
            Dim sTitle8 As String
            sTitle8 = TextBox1.Text
            Dim frm8 As New viewcashdis(sTitle8)
            frm8.Show()
        Catch ex As Exception
            Exit Sub

        End Try

    End Sub

    Private Sub lvcashrr_MouseClick(sender As Object, e As MouseEventArgs) Handles lvcashrr.MouseClick
        Try


            TextBox2.Text = lvcashrr.SelectedItems.Item(0).Text
            Dim sTitle9 As String
            sTitle9 = TextBox2.Text
            Dim frm8 As New viewdisrr(sTitle9)
            frm8.Show()
        Catch ex As Exception
            Exit Sub

        End Try

    End Sub

    Private Sub lvcashrr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvcashrr.SelectedIndexChanged

    End Sub


    Private Sub cmbModeofPayment_onItemSelected(sender As Object, e As EventArgs) Handles cmbModeofPayment.onItemSelected

    End Sub

    Private Sub cmbModeofPayment1_onItemSelected(sender As Object, e As EventArgs) Handles cmbModeofPayment1.onItemSelected

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnCancelAPV_Click(sender As Object, e As EventArgs) Handles btnCancelAPV.Click
        lbltotalcwt3.Clear()
        lblamountpaid2.Clear()
        lblamountwords2.Clear()
        txtCheckNumber2.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        getcashinven()

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        viewreportprintallinventorycdreport.Show()
    End Sub

    Private Sub Label35_Click(sender As Object, e As EventArgs) Handles Label35.Click

    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        getcashrr()
        getcashinven()
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        viewreportprintallapvcd.Show()
    End Sub

    Private Sub lvbilling_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvbilling.SelectedIndexChanged

    End Sub
End Class