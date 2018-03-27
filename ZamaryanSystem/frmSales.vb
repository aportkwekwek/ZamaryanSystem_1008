Imports MySql.Data.MySqlClient

Public Class frmSales

    Dim sqlcon As New MySqlConnection
    Dim sqlda As New MySqlDataAdapter
    Dim sqlcmd As New MySqlCommand
    Dim totinvoicecost As Double
    Dim idSalesPerson As Integer


    Public Function getsalesinvoicereport()


        lvsalesinvoice1.Items.Clear()


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select salesinvoice.sid, salesinvoice.datesold , customers.customername , users.name, salesinvoice.remarks ,salesinvoice.total - salesinvoice.outputVat ,salesinvoice.outputVat , salesinvoice.total  from users inner join salesinvoice on users.id = salesinvoice.salesperson inner join customers on salesinvoice.customerid = customers.customerid WHERE salesinvoice.remarks = 'Approved' or salesinvoice.remarks = 'Decline' GROUP by salesinvoice.invoiceid"


            Dim dtk1 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtk1)

            Dim i As Integer

            While i <= dtk1.Rows.Count - 1
                Dim itm As ListViewItem

                itm = lvsalesinvoice1.Items.Add(dtk1.Rows(i).Item(0)) 'id
                itm.SubItems.Add((dtk1.Rows(i).Item(1))) ' datesold
                itm.SubItems.Add((dtk1.Rows(i).Item(2))) ' sname
                itm.SubItems.Add((dtk1.Rows(i).Item(3))) ' salesperson
                itm.SubItems.Add((dtk1.Rows(i).Item(4))) ' remarks
                itm.SubItems.Add(FormatNumber(dtk1.Rows(i).Item(5))) ' subamount
                itm.SubItems.Add(FormatNumber(dtk1.Rows(i).Item(6))) 'outputvat
                itm.SubItems.Add(FormatNumber(dtk1.Rows(i).Item(7))) 'grandtotal

                i += 1

            End While



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            sqlcon.Close()

        End Try

        Return lvsalesinvoice1


    End Function
    Public Function getCustomers()

        cmbCustomerName.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String
            Dim dt As New DataTable

            qry = "Select Customername from customers order by customername asc"

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt)

            Dim i As Integer

            While i <= dt.Rows.Count - 1

                cmbCustomerName.AddItem(dt.Rows(i).Item(0))

                i += 1

            End While


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

        Return cmbCustomerName


    End Function

    Private Sub frmSales_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Enabled = True
        frmMain.Focus()

    End Sub
    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getCustomers()
        Timer1.Start()
        getItemsAboveQuota()
        txtSalesPersonSI.Text = frmLogin.TextBox1.Text
        getmaxsalesinvoiceid()
        getsalesinvoicereport()
        idSalesPerson = frmLogin.TextBox2.Text

    End Sub


    Private Sub cmbCustomerName_onItemSelected(sender As Object, e As EventArgs) Handles cmbCustomerName.onItemSelected


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select customernumber,customeraddress,customerzip,customerphone,termsofAgreement,customeremail,customertin,customercontactperson from customers where customername ='" & cmbCustomerName.selectedValue & "'"

            Dim dty As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dty)

            If dty.Rows.Count = 1 Then

                txtCustomerIDSI.Text = dty.Rows(0).Item(0)
                txtAddressSI.Text = dty.Rows(0).Item(1)
                txtZipSI.Text = dty.Rows(0).Item(2)
                txtPhoneSI.Text = dty.Rows(0).Item(3)
                txtTermsSI.Text = dty.Rows(0).Item(4)
                txtEmailSI.Text = dty.Rows(0).Item(5)
                txtTinSI.Text = dty.Rows(0).Item(6)
                txtContactPersonSI.Text = dty.Rows(0).Item(7)

            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()
            txtPOnumberSI.Focus()

        End Try
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateSI.Text = Format(Date.Now, "yyyy-MM-dd")
    End Sub

    Public Function getItemsAboveQuota()

        cmbItemCodeSI.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            Dim dtopo As New DataTable

            Dim qry As String

            qry = "Select itemid from items where quota < quantity"

            Dim q As Integer

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtopo)

            While q <= dtopo.Rows.Count - 1

                cmbItemCodeSI.AddItem(dtopo.Rows(q).Item(0))

                q += 1

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return cmbItemCodeSI

    End Function

    Private Sub btnEditTermsSI_Click(sender As Object, e As EventArgs) Handles btnEditTermsSI.Click
        If btnEditTermsSI.Text = "Edit" Then
            txtTermsSI.Enabled = True
            btnEditTermsSI.Text = "Save"


        ElseIf btnEditTermsSI.Text = "Save" Then
            txtTermsSI.Enabled = False
            btnEditTermsSI.Text = "Edit"


        End If


    End Sub

    Private Sub MaterialFlatButton7_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton7.Click
        Dim itm As ListViewItem


        For Each itm In lvSalesinvoice.Items

            If cmbItemCodeSI.selectedValue = itm.SubItems(2).Text Then

                MessageBox.Show("The item is already in the list", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub

            End If

        Next

       
        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            Dim qry As String

            qry = "Select quantity from items where itemid='" & cmbItemCodeSI.selectedValue & "'"

            Dim dtl As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtl)

            For i = 0 To dtl.Rows.Count - 1

                Dim existing As Integer

                existing = dtl.Rows(i).Item(0)
                If existing < txtQuantitySI.Text Then

                    MessageBox.Show("Insufficient number of stocks", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    sqlcon.Close()
                    Exit Sub

                End If
                i += 1

            Next

            Dim spatiu1 As New ListViewItem

            spatiu1 = lvSalesinvoice.Items.Add(lblInvoiceID.Text)
            spatiu1.SubItems.Add(txtItemidSI.Text)
            spatiu1.SubItems.Add(cmbItemCodeSI.selectedValue)
            spatiu1.SubItems.Add(txtItemDescSI.Text)
            spatiu1.SubItems.Add(txtQuantitySI.Text)
            spatiu1.SubItems.Add(FormatNumber(txtSellingPriceSI.Text))

            Dim sellingpricesi As Double
            Dim qtysi As Integer
            Dim totalsi As Double

            sellingpriceSI = txtSellingPriceSI.Text
            qtySI = txtQuantitySI.Text
            totalSI = sellingpriceSI * qtySI

            Dim vat As Double

            vat = totalSI * 0.12

            Dim grandtotal As Double

            grandtotal = vat + totalSI

            spatiu1.SubItems.Add(FormatNumber(totalSI))
            spatiu1.SubItems.Add(FormatNumber(vat))
            spatiu1.SubItems.Add(FormatNumber(grandtotal))

            Dim grandtotalsi, totaloutput As Double
            Dim item2 As ListViewItem

            For Each item2 In lvSalesinvoice.Items

                grandtotalsi += CDbl(item2.SubItems.Item(8).Text)
                totaloutput += CDbl(item2.SubItems.Item(7).Text)

            Next

            lblGrandTotalSI.Text = FormatNumber(grandtotalsi)
            lbloutputVatSI.Text = FormatNumber(totaloutput)

            lblGrandTotalSI1.Text = grandtotalsi
            lbloutputVatSI1.Text = totaloutput


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        cmbItemCodeSI.ResetText()
        txtQuantitySI.Clear()
        txtItemDescSI.Clear()
        txtSellingPriceSI.Clear()

    End Sub

    Private Sub cmbItemCodeSI_onItemSelected(sender As Object, e As EventArgs) Handles cmbItemCodeSI.onItemSelected

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            Dim dty As New DataTable

            qry = "Select * from items where itemid ='" & cmbItemCodeSI.selectedValue & "'"

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dty)

            Dim itemidforsi As String

            For i = 0 To dty.Rows.Count - 1

                txtItemDescSI.Text = dty.Rows(i).Item(2)
                txtSellingPriceSI.Text = dty.Rows(i).Item(4)
                itemidforSI = dty.Rows(i).Item(0)
                txtSellingPriceSI.Text = FormatNumber(txtSellingPriceSI.Text)
                txtItemidSI.Text = itemidforSI

                i += 1

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

    End Sub

    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click
        Try

            'Remove Multiple Selected Items 
            For Each item As ListViewItem In lvSalesinvoice.SelectedItems
                item.Remove()
            Next

            Dim total, inputVat As Double

            For Each temp In lvSalesinvoice.Items
                total += CDbl(temp.SubItems.Item(8).Text)
                inputVat += CDbl(temp.SubItems.Item(7).Text)
            Next

            lbloutputVatSI.Text = FormatNumber(inputVat)
            lblGrandTotalSI.Text = FormatNumber(total)

            lblGrandTotalSI1.Text = total
            lbloutputVatSI1.Text = inputVat


        Catch ex As Exception

            Exit Sub

        End Try
    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click



        Dim i As Integer

        i = MessageBox.Show("Are you sure you want to save this item?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbNo Then
            Exit Sub

        End If


        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            '=============================
            Dim qry1 As String

            sqlcmd = New MySqlCommand("Select customerid from customers where customername='" & cmbCustomerName.selectedValue & "'", sqlcon)
            Dim custid = sqlcmd.ExecuteScalar

            qry1 = "Insert into salesinvoice(customerid,datesold,pono,remarks,outputVat,total,salesperson,sid) values ('" & custid & "','" & lblDateSI.Text & "', '" & txtPOnumberSI.Text & "', 'Pending' ,'" & lbloutputVatSI1.Text & "','" & lblGrandTotalSI1.Text & "','" & idSalesPerson & "','" & lblSalesinvoiceID.Text & "')"
            sqlcmd = New MySqlCommand(qry1, sqlcon)
            sqlcmd.ExecuteNonQuery()

            Dim itm As ListViewItem

            For Each itm In lvSalesinvoice.Items

                Dim qryqt As String

                qryqt = "Select ifnull(Max(invoiceid),0) from salesinvoice"

                Dim dtqk As New DataTable

                sqlda = New MySqlDataAdapter(qryqt, sqlcon)
                sqlda.Fill(dtqk)


                lblInvoiceID.Text = dtqk.Rows(0).Item(0)


                ''add each item in invoiceitems

                Dim cogsx = itm.SubItems(5).Text.Replace(",", "")
                Dim qtyx = itm.SubItems(4).Text.Replace(",", "")

                sqlcmd = New MySqlCommand("Insert into invoiceitems(invoiceid,itemnumber,quantity,costGoodSold) values('" & lblInvoiceID.Text &
                                       "','" & itm.SubItems(1).Text & "','" & qtyx & "','" & cogsx & "')", sqlcon)

                sqlcmd.ExecuteNonQuery()


                'get each item of the item inside the salesinvoice

                Dim qry2 As String

                Dim binili, existingItem, bagongQty As Integer

                binili = 0
                existingItem = 0
                bagongQty = 0


                qry2 = "Select quantity from items where itemnumber =" & itm.SubItems(1).Text
                sqlcmd = New MySqlCommand(qry2, sqlcon)
                existingItem = sqlcmd.ExecuteScalar()

                binili = itm.SubItems(4).Text
                bagongQty = existingItem - binili
                txtbagongqty.Text = bagongQty


                Dim qry3 As String

                'set new qty

                qry3 = "Update items set quantity='" & txtbagongqty.Text & "' where itemnumber ='" & itm.SubItems(1).Text & "'"
                sqlcmd = New MySqlCommand(qry3, sqlcon)
                sqlcmd.ExecuteNonQuery()


                '=========================================

                'get each item cost for cost of sales as well as running balance

                Dim qry238 As String

                Dim totcost As Double

                totcost = 0

                qry238 = "select sum(cost) from (select cost from uniqueitem where itemnumber =" & itm.SubItems(1).Text & " and isInventory ='YES' order by uniqueItem asc limit " & itm.SubItems(4).Text & ") as subt"

                sqlcmd = New MySqlCommand(qry238, sqlcon)
                totcost = sqlcmd.ExecuteScalar

                'set new running balance

                Dim existingBal As Double
                Dim qry4 As String

                existingBal = 0

                qry4 = "Select runningBalance from items where itemnumber ='" & itm.SubItems(1).Text & "'"
                sqlcmd = New MySqlCommand(qry4, sqlcon)
                existingBal = sqlcmd.ExecuteScalar()

                txtNewRunningBal.Text = existingBal - totcost


                'update new running balance 

                Dim qry5 As String

                qry5 = "Update items set runningBalance ='" & txtNewRunningBal.Text & "' where itemnumber ='" & itm.SubItems(1).Text & "'"
                sqlcmd = New MySqlCommand(qry5, sqlcon)
                sqlcmd.ExecuteNonQuery()


                Dim itm1 As ListViewItem


                For Each itm1 In lvSalesinvoice.Items


                    Dim qry6 As String

                    qry6 = "Select uniqueitem,cost from uniqueItem where isInventory ='YES' and itemnumber = " & itm1.SubItems(1).Text & " order by uniqueitem asc limit " & itm1.SubItems(4).Text

                    Dim dt002 As New DataTable

                    sqlda = New MySqlDataAdapter(qry6, sqlcon)
                    sqlda.Fill(dt002)

                    Dim lolo As Integer

                    While lolo <= dt002.Rows.Count - 1

                        Dim lvItems As ListViewItem

                        lvItems = ListView2.Items.Add(dt002.Rows(lolo).Item(0))
                        lvItems.SubItems.Add(dt002.Rows(lolo).Item(1))

                        lolo += 1

                    End While

                    Dim sid As ListViewItem

                    For Each sid In ListView2.Items

                        totinvoicecost += FormatCurrency(sid.SubItems(1).Text)

                        lblcostofsalestot.Text = totinvoicecost

                    Next

                Next


                Dim itemis As ListViewItem
                For Each itemis In ListView2.Items

                    sqlcmd = New MySqlCommand("Update uniqueitem set isInventory ='NO' where uniqueItem ='" & itemis.SubItems(0).Text & "'", sqlcon)
                    sqlcmd.ExecuteNonQuery()

                Next

                sqlcmd = New MySqlCommand("Update salesinvoice set costofsalesTot ='" & lblcostofsalestot.Text & "' where invoiceid ='" & lblInvoiceID.Text & "'", sqlcon)
                sqlcmd.ExecuteNonQuery()

            Next

            MessageBox.Show("Information Successfully Saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MsgBox(ex.Message)
            MessageBox.Show("Please check your inputs.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Finally
            sqlcon.Close()
            btnCancelSIClear.PerformClick()
            ListView2.Items.Clear()
            lvInvoiceItems.Items.Clear()
            lvSalesinvoice.Items.Clear()
            lvSalesInvoiceApproval.Items.Clear()

        End Try
    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles btnCancelSIClear.Click

        getItemsAboveQuota()
        getmaxsalesinvoiceid()
        getCustomers()
        lblGrandTotal.Text = "0.00"
        lblOutputVat.Text = "0.00"
        ListView2.Items.Clear()
        lvSalesinvoice.Items.Clear()
        lvSalesInvoiceApproval.Items.Clear()
        txtTermsSI.Clear()
        txtPhoneSI.Clear()
        txtAddressSI.Clear()
        txtbagongqty.Clear()
        txtContactPersonSI.Clear()
        txtCustomerIDSI.Clear()
        txtEmailSI.Clear()
        txtItemDescSI.Clear()
        txtItemidSI.Clear()
        txtPOnumberSI.Clear()
        txtNewRunningBal.Clear()
        txtZipSI.Clear()
        txtTinSI.Clear()
        txtPhoneSI.Clear()
        txtSellingPriceSI.Clear()

    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click

        lvSalesInvoiceApproval.Items.Clear()

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select salesinvoice.sid, salesinvoice.datesold, customers.customername, users.name, salesinvoice.total - salesinvoice.outputVat ,ifnull(salesinvoice.outputVat,0) , ifnull(salesinvoice.total,0) from users inner join salesinvoice on users.id = salesinvoice.salesperson inner join customers on salesinvoice.customerid = customers.customerid where remarks ='Pending'"
            Dim dt78 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt78)


            Dim itm As ListViewItem

            Dim i As Integer

            While i <= dt78.Rows.Count - 1

                itm = lvSalesInvoiceApproval.Items.Add(dt78.Rows(i).Item(0)) 'sid
                itm.SubItems.Add(dt78.Rows(i).Item(1)) ' datesold
                itm.SubItems.Add(dt78.Rows(i).Item(2)) ' customername
                itm.SubItems.Add(dt78.Rows(i).Item(3)) ' seller
                itm.SubItems.Add(FormatNumber(dt78.Rows(i).Item(4))) ' base amount
                itm.SubItems.Add(FormatNumber(dt78.Rows(i).Item(5))) ' vat
                itm.SubItems.Add(FormatNumber(dt78.Rows(i).Item(6))) ' TOTAL

                i += 1

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

    End Sub

    Public Function showSalesInvoice()

        lvInvoiceItems.Items.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String
            Dim dttable As New DataTable

            qry = "Select items.itemid,items.itemdesc,invoiceitems.quantity, invoiceitems.costGoodSold,invoiceitems.quantity * invoiceitems.costGoodSold as subtot from items inner join invoiceitems on items.itemnumber = invoiceitems.itemnumber inner join salesinvoice on invoiceitems.invoiceid = salesinvoice.invoiceid where salesinvoice.sid = '" & lbltrueinvoiceid.Text & "'"

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dttable)

            Dim i As Integer

            Dim itm As ListViewItem


            While i <= dttable.Rows.Count - 1

                Dim vat As Double

                vat = (CDbl(dttable.Rows(i).Item(2)) * CDbl(dttable.Rows(i).Item(3))) * 0.12

                Dim subtot, semitotal As Double

                subtot = dttable.Rows(i).Item(4)

                semitotal = subtot + vat

                Dim baseamt As Double
                baseamt = dttable.Rows(i).Item(4) - vat


                itm = lvInvoiceItems.Items.Add(dttable.Rows(i).Item(0)) 'itemid
                itm.SubItems.Add(dttable.Rows(i).Item(1)) 'desc 
                itm.SubItems.Add(dttable.Rows(i).Item(2)) 'quantity
                itm.SubItems.Add(FormatNumber(dttable.Rows(i).Item(3))) 'price
                itm.SubItems.Add(FormatNumber(0)) 'subamt
                itm.SubItems.Add(FormatNumber(vat)) 'vat
                itm.SubItems.Add(FormatNumber(semitotal)) 'total


                i += 1
            End While

            Dim item As ListViewItem

            Dim outputVat, grandtotal As Double

            For Each item In lvInvoiceItems.Items

                outputVat += CDbl(item.SubItems(4).Text)
                grandtotal += CDbl(item.SubItems(5).Text)

            Next

            lblOutputVat.Text = FormatNumber(outputVat)
            lblGrandTotal.Text = FormatNumber(grandtotal)
            lblAmountInWordapprove.Text = AmountInWords(lblGrandTotal.Text)

            lblGrandtotal1.Text = grandtotal

            lblOutputVAT1.Text = outputVat


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return lvInvoiceItems.Items

    End Function

    Private Sub btnClearItem_Click(sender As Object, e As EventArgs) Handles btnClearItem.Click

        Dim trueinvoiceid As String

        Try

            trueinvoiceid = lvSalesInvoiceApproval.SelectedItems.Item(0).Text

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qwe As String

            qwe = "Select costofsalesTot from salesinvoice where sid = '" & trueinvoiceid & "'"
            sqlcmd = New MySqlCommand(qwe, sqlcon)
            Dim costofsales = sqlcmd.ExecuteScalar()

            lblCostofSales.Text = FormatNumber(costofsales)
            lblCostofSales1.Text = costofsales

        Catch ex As Exception

            MessageBox.Show("Select sales invoice for approval / denying", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            Exit Sub

        Finally
            sqlcon.Close()


        End Try


        ''========================================
        ''----------------------------------------
        ''========================================

        'lblInvoiceidSales.Text = invoiceid


        lbltrueinvoiceid.Text = trueinvoiceid

        lvInvoiceItems.Items.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String
            Dim dttable As New DataTable

            qry = "Select items.itemid,items.itemdesc,invoiceitems.quantity,invoiceitems.costGoodSold, invoiceitems.quantity * invoiceitems.costGoodSold as subtot from items inner join invoiceitems on items.itemnumber = invoiceitems.itemnumber inner join salesinvoice on invoiceitems.invoiceid = salesinvoice.invoiceid where salesinvoice.sid ='" & lbltrueinvoiceid.Text & "'"

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dttable)

            Dim i As Integer

            Dim itm As ListViewItem

            While i <= dttable.Rows.Count - 1

                Dim vat As Double

                vat = (CDbl(dttable.Rows(i).Item(2)) * CDbl(dttable.Rows(i).Item(3))) * 0.12

                Dim subtot, semitotal As Double

                subtot = dttable.Rows(i).Item(4)

                semitotal = subtot + vat

                Dim baseamt As Double

                baseamt = semitotal - vat

                itm = lvInvoiceItems.Items.Add(dttable.Rows(i).Item(0))
                itm.SubItems.Add(dttable.Rows(i).Item(1))
                itm.SubItems.Add(dttable.Rows(i).Item(2))
                itm.SubItems.Add(FormatNumber(dttable.Rows(i).Item(3)))
                itm.SubItems.Add(FormatNumber(baseamt))
                itm.SubItems.Add(FormatNumber(vat))
                itm.SubItems.Add(FormatNumber(semitotal))

                i += 1

            End While

            Dim item As ListViewItem

            Dim outputVat, grandtotal, baseamtTot As Double

            For Each item In lvInvoiceItems.Items

                baseamtTot += CDbl(item.SubItems(4).Text)
                outputVat += CDbl(item.SubItems(5).Text)
                grandtotal += CDbl(item.SubItems(6).Text)

            Next

            lblSubTotal.Text = FormatNumber(baseamtTot)
            lblOutputVat.Text = FormatNumber(outputVat)
            lblGrandTotal.Text = FormatNumber(grandtotal)
            lblAmountInWordapprove.Text = AmountInWords(lblGrandTotal.Text)

            lblOutputVAT1.Text = outputVat
            lblGrandtotal1.Text = grandtotal

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        ''=====================================================
        ''-----------------------------------------------------
        ''=====================================================

        Try


            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            BunifuTransition1.HideSync(lvSalesInvoiceApproval, True, BunifuAnimatorNS.Animation.Leaf)
            BunifuTransition1.ShowSync(pnlforApproval, True, BunifuAnimatorNS.Animation.Leaf)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

    End Sub

    Private Sub MaterialFlatButton8_Click(sender As Object, e As EventArgs) Handles btnCancelSI.Click
        lblGrandTotal.Clear()
        lblOutputVat.Clear()
        lvInvoiceItems.Items.Clear()
        lvSalesinvoice.Items.Clear()
        lvSalesInvoiceApproval.Items.Clear()
        BunifuTransition1.HideSync(pnlforApproval, True, BunifuAnimatorNS.Animation.Leaf)
        BunifuTransition1.ShowSync(lvSalesInvoiceApproval, True, BunifuAnimatorNS.Animation.Leaf)

    End Sub


    Public Function getmaxsalesinvoiceid()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String
            Dim dt12 As New DataTable

            qry = "SELECT MAX(sid) FROM salesinvoice"
            sqlcmd = New MySqlCommand(qry, sqlcon)
            Dim rid = sqlcmd.ExecuteScalar

            lblSalesinvoiceID.Text = ("SI" & If(IsDBNull(rid), "100001", Format(Mid(rid, 3, 9)) + 1))

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return lblSalesinvoiceID

    End Function

    
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Close()
        frmMain.Enabled = True
        frmMain.Focus()

    End Sub

    Private Sub txtQuantitySI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantitySI.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub


    Private Sub lvsalesinvoice1_MouseClick(sender As Object, e As MouseEventArgs) Handles lvsalesinvoice1.MouseClick
        TextBox4.Text = lvsalesinvoice1.SelectedItems.Item(0).Text
        Dim sTitle7 As String
        sTitle7 = TextBox4.Text
        Dim frm7 As New viewreportsales(sTitle7)
        frm7.Show()
    End Sub

    Private Sub pnlforApproval_Paint(sender As Object, e As PaintEventArgs) Handles pnlforApproval.Paint

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub MaterialFlatButton12_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton12.Click

        Try
            Dim i As Integer

            i = MessageBox.Show("Are you sure you want to save this item?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If i = vbNo Then
                Exit Sub

            End If

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            Dim qry As String

            qry = "Update salesinvoice set remarks ='Approved' where sid ='" & lbltrueinvoiceid.Text & "'"

            sqlcmd = New MySqlCommand(qry, sqlcon)
            sqlcmd.ExecuteNonQuery()

            Dim qry2 As String

            qry2 = "Insert into journal(journaldesc) values ('To record sales')"
            sqlcmd = New MySqlCommand(qry2, sqlcon)
            sqlcmd.ExecuteNonQuery()

            Dim qry3 As String

            Dim accountsreceivable, outputvat, salesCOA, journalid, inventoryCOA, costofsalesCOA As Integer

            Dim dt1212 As New DataTable

            qry3 = "Select Max(journalid) from journal"

            sqlcmd = New MySqlCommand(qry3, sqlcon)
            journalid = sqlcmd.ExecuteScalar

            accountsreceivable = 4
            outputvat = 9
            salesCOA = 13


            ''accounts receivable

            Dim qry4 As String

            Dim newRunAR As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & accountsreceivable & "  order by journalentryid desc limit 1 ", sqlcon)
            Dim val1 = sqlcmd.ExecuteScalar

            newRunAR = val1 + lblGrandtotal1.Text

            'accounts receivable
            qry4 = "Insert into journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & journalid & "','" & Format(Date.Now, "yyyy-MM-dd") & "','" & accountsreceivable & "','" & lblGrandtotal1.Text & "','0','Sales Invoice','" & lbltrueinvoiceid.Text & "','" & newRunAR & "')"
            sqlcmd = New MySqlCommand(qry4, sqlcon)
            sqlcmd.ExecuteNonQuery()


            ''outputvat
            Dim qry5 As String
            Dim newRunOV As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & outputvat & "  order by journalentryid desc limit 1 ", sqlcon)
            Dim val2 = sqlcmd.ExecuteScalar

            newRunOV = val2 - lblOutputVAT1.Text

            qry5 = "Insert into journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values('" & journalid & "','" & Format(Date.Now, "yyyy-MM-dd") & "','" & outputvat & "','0','" & lblOutputVAT1.Text & "','Sales Invoice','" & lbltrueinvoiceid.Text & "','" & newRunOV & "')"
            sqlcmd = New MySqlCommand(qry5, sqlcon)
            sqlcmd.ExecuteNonQuery()


            '===============================SALES========================='
            Dim qry6 As String

            Dim totalsales As Double

            totalsales = FormatNumber(CDbl(lblGrandtotal1.Text) - CDbl(lblOutputVAT1.Text))

            Dim newRunSales As Double


            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & salesCOA & " order by journalentryid desc limit 1 ", sqlcon)
            Dim val3 = sqlcmd.ExecuteScalar

            newRunSales = val3 - totalsales

            ''sales
            qry6 = "Insert into journalentry (journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values('" & journalid & "','" & Format(Date.Now, "yyyy-MM-dd") & "','" & salesCOA & "','0','" & totalsales & "','Sales Invoice','" & lbltrueinvoiceid.Text & "','" & newRunSales & "')"
            sqlcmd = New MySqlCommand(qry6, sqlcon)
            sqlcmd.ExecuteNonQuery()


            ''=============================END=============================''

            'for inventory and cost of sales entry 


            Dim qry7 As String

            qry7 = "Select accountid from chartofaccounts where accountname ='Cost of Sales'"
            sqlcmd = New MySqlCommand(qry7, sqlcon)
            costofsalesCOA = sqlcmd.ExecuteScalar

            Dim qry8 As String

            qry8 = "Select accountid from chartofaccounts where accountname ='Inventory'"
            sqlcmd = New MySqlCommand(qry8, sqlcon)
            inventoryCOA = sqlcmd.ExecuteScalar


            ''inventory running Balance

            Dim newRuninventory As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & inventoryCOA & "  order by journalentryid desc limit 1 ", sqlcon)
            Dim val4 = sqlcmd.ExecuteScalar

            newRuninventory = val4 - lblCostofSales1.Text

            'ínventory 

            sqlcmd = New MySqlCommand("Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & journalid & "','" & Format(Date.Now, "yyyy-MM-dd") & "','" & inventoryCOA & "','0','" & lblCostofSales1.Text & "','Sales Invoice','" & lbltrueinvoiceid.Text & "','" & newRuninventory & "')", sqlcon)
            sqlcmd.ExecuteNonQuery()


            ''=====================================
            ''cost of sales running balance

            Dim newRunCOGS As Double
            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & costofsalesCOA & "  order by journalentryid desc limit 1 ", sqlcon)
            Dim val5 = sqlcmd.ExecuteScalar

            newRunCOGS = val5 + lblCostofSales1.Text

            'costofsales
            sqlcmd = New MySqlCommand("Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & journalid & "','" & Format(Date.Now, "yyyy-MM-dd") & "','" & costofsalesCOA & "','" & lblCostofSales1.Text & "','0','Sales Invoice','" & lbltrueinvoiceid.Text & "','" & newRunCOGS & "')", sqlcon)
            sqlcmd.ExecuteNonQuery()


            '======================================================


            ''retained earnings

            Dim qry9 As String
            Dim retainedEarningsCOA As Integer

            qry9 = "Select accountid from chartofaccounts where accountname ='Retained Earnings'"
            sqlcmd = New MySqlCommand(qry9, sqlcon)
            retainedEarningsCOA = sqlcmd.ExecuteScalar

            Dim retainedEarningsTotal As Double

            retainedEarningsTotal = totalsales - lblCostofSales1.Text

            If totalsales < lblCostofSales1.Text Then

                sqlcmd = New MySqlCommand("Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2) values ('" & journalid & "','" & Format(Date.Now, "yyyy-MM-dd") & "','" & retainedEarningsCOA & "','" & retainedEarningsTotal & "','0','Sales Invoice', '" & lbltrueinvoiceid.Text & "')", sqlcon)
                sqlcmd.ExecuteNonQuery()


            ElseIf totalsales > lblCostofSales1.Text Then

                sqlcmd = New MySqlCommand("Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2) values ('" & journalid & "','" & Format(Date.Now, "yyyy-MM-dd") & "','" & retainedEarningsCOA & "','0','" & retainedEarningsTotal & "','Sales Invoice','" & lbltrueinvoiceid.Text & "')", sqlcon)
                sqlcmd.ExecuteNonQuery()

            ElseIf totalsales = lblCostofSales1.Text Then

                sqlcmd = New MySqlCommand("Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2) values ('" & journalid & "','" & Format(Date.Now, "yyyy-MM-dd") & "','" & retainedEarningsCOA & "','0','0','Sales Invoice','" & lbltrueinvoiceid.Text & "')", sqlcon)
                sqlcmd.ExecuteNonQuery()

            End If

            MessageBox.Show("Information Successfully Saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            sqlcon.Close()
            btnCancelSI.PerformClick()

        End Try
        getsalesinvoicereport()

    End Sub

    Private Sub MaterialFlatButton8_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton8.Click

    End Sub

    Private Sub lvSalesInvoiceApproval_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSalesInvoiceApproval.SelectedIndexChanged

    End Sub

    Private Sub MaterialFlatButton3_Click_1(sender As Object, e As EventArgs)
        getsalesinvoicereport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lvsalesinvoice1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvsalesinvoice1.SelectedIndexChanged

    End Sub

    Private Sub txtQuantitySI_Click(sender As Object, e As EventArgs) Handles txtQuantitySI.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        getsalesinvoicereport()
    End Sub

    Private Sub MaterialFlatButton3_Click_2(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        viewreportprintallsalesinvoce.Show()

    End Sub
End Class