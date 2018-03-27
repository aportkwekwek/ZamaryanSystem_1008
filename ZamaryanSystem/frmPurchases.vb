Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports System.Globalization

Public Class frmPurchases

    Dim sqlcon As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Dim sqlda As New MySqlDataAdapter
    Public adding As Boolean
    Public editing As Boolean
    Dim dr As MySqlDataReader
    Dim search As String
    Dim sql As String
    Dim accountid As String
    Dim idofsupp As String
    Dim truepoid As Integer
    Dim maxbillingid As String
    Dim apVoucherRE As Double
    Dim accGroupRE As String


    Public Function getrecievingreport()

        dgvrecievingreport.Items.Clear()


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select receivingreport.reportid, suppliers.suppliername, receivingreport.datedelivered ,  receivingreport.total ,receivingreport.status  from receivingreport inner join purchaseorder on receivingreport.purchaseorderid = purchaseorder.purchaseorderid INNER join suppliers on purchaseorder.supplierid = suppliers.supplierid where purchaseorder.remarks !='NULL' group by receivingreport.reportid"

            Dim dtk22 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtk22)

            Dim i As Integer

            While i <= dtk22.Rows.Count - 1
                Dim itm As ListViewItem

                itm = dgvrecievingreport.Items.Add(dtk22.Rows(i).Item(0))
                itm.SubItems.Add((dtk22.Rows(i).Item(1)))
                itm.SubItems.Add(dtk22.Rows(i).Item(2))
                itm.SubItems.Add((FormatNumber(dtk22.Rows(i).Item(3))))
                itm.SubItems.Add((dtk22.Rows(i).Item(4)))



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

        Return dgvrecievingreport


    End Function



    Public Function getpurchasereport()

        lvpurchase.Items.Clear()


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select poid,purchaseorderdate, suppliers.suppliername, termsInDays,remarks,total-inputVat ,inputVat,total  from purchaseorder NATURAL join suppliers where remarks !='NULL'"

            Dim dtk2 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtk2)

            Dim i As Integer

            While i <= dtk2.Rows.Count - 1
                Dim itm As ListViewItem

                itm = lvpurchase.Items.Add(dtk2.Rows(i).Item(0))
                itm.SubItems.Add((dtk2.Rows(i).Item(1)))
                itm.SubItems.Add(dtk2.Rows(i).Item(2))
                itm.SubItems.Add(dtk2.Rows(i).Item(3))
                itm.SubItems.Add(dtk2.Rows(i).Item(4))
                itm.SubItems.Add(FormatNumber(dtk2.Rows(i).Item(5)))
                itm.SubItems.Add(FormatNumber(dtk2.Rows(i).Item(6)))
                itm.SubItems.Add(FormatNumber(dtk2.Rows(i).Item(7)))



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

        Return lvpurchase


    End Function

    Public Function getbillingstatement()

        lvbilling.Items.Clear()


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select APVid , datebill , duedate,  suppliers.suppliername, totalbill - inputVat ,inputVat ,  totalbill  from billings NATURAL JOIN suppliers where isPaid = 'Unpaid'"

            Dim dtk4 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtk4)

            Dim i As Integer

            While i <= dtk4.Rows.Count - 1
                Dim itm As ListViewItem

                itm = lvbilling.Items.Add(dtk4.Rows(i).Item(0)) 'APVID
                itm.SubItems.Add((dtk4.Rows(i).Item(1))) 'datebill
                itm.SubItems.Add((dtk4.Rows(i).Item(2))) 'duedate
                itm.SubItems.Add((dtk4.Rows(i).Item(3))) 'suppliername
                itm.SubItems.Add(FormatNumber(dtk4.Rows(i).Item(4))) 'baseamount
                itm.SubItems.Add(FormatNumber(dtk4.Rows(i).Item(5))) 'inputvat
                itm.SubItems.Add(FormatNumber(dtk4.Rows(i).Item(6))) 'total

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
    Public Function getPayee()

        Try
            cmbPayee.Clear()

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry1 As String

            qry1 = "Select suppliername from suppliers order by suppliername asc"

            Dim suppDt1 As New DataTable

            sqlda = New MySqlDataAdapter(qry1, sqlcon)
            sqlda.Fill(suppDt1)

            Dim i As Integer

            i = 0

            While i <= suppDt1.Rows.Count - 1

                cmbPayee.AddItem(suppDt1.Rows(i).Item(0))

                i += 1

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            sqlcon.Close()

        End Try

        Return cmbPayee

    End Function

    Public Function getSupplier()

        Try
            cmbSupplier.Clear()
          
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select suppliername from suppliers  where InventorySupplier = 1 order by suppliername asc"

            Dim suppDt As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(suppDt)

            Dim i As Integer

            While i <= suppDt.Rows.Count - 1

                cmbSupplier.AddItem(suppDt.Rows(i).Item(0))
                i += 1

            End While


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return cmbSupplier

    End Function

    Private Sub frmPurchases_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        frmMain.Enabled = True
        frmMain.Focus()

    End Sub

    Private Sub frmPurchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        
        Timer1.Start()
        marlboro()
        getmaxpoidformat()
        getSupplier()
        getmaxpoid()
        getPOtoReceive()
        getapvid()
        getbillingstatement()
        getrecievingreport()
        getpurchasereport()
        getPayee()

        dtpBilling.Text = Format(Date.Now, "yyyy-MM-dd")

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub cmbSupplier_onItemSelected(sender As Object, e As EventArgs) Handles cmbSupplier.onItemSelected
        Try

            Dim qry As String
            Dim dtr As New DataTable

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            qry = "Select * from suppliers where suppliername ='" & cmbSupplier.selectedValue & "'"

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtr)

            For i = 0 To dtr.Rows.Count - 1

                txtTermsPO.Text = dtr.Rows(i).Item("termsofAgreement")
                txtAddress.Text = dtr.Rows(i).Item("supplieraddress")
                txtTelephonePO.Text = dtr.Rows(i).Item("supplierphone")
                txtTinPO.Text = dtr.Rows(i).Item("suppliertin")
                txtWebsitePO.Text = dtr.Rows(i).Item("supplierwebsite")
                txtContactPO.Text = dtr.Rows(i).Item("suppliercontactperson")
                txtEmailPO.Text = dtr.Rows(i).Item("supplieremail")
                txtFaxPO.Text = dtr.Rows(i).Item("supplierfax")
                i += 1

            Next

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally
            sqlcon.Close()


        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateRequest.Text = Format(DateTime.Now, "yyyy-MM-dd hh:mm:ss tt")
        txtDateReceivedRR.Text = Format(DateTime.Now, "yyyy-MM-dd")
        dtpBilling.Text = Format(Date.Now, "yyyy-MM-dd")

    End Sub

    Private Sub txtSearchItem_TextChanged(sender As Object, e As EventArgs) Handles txtSearchItem.TextChanged

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            'Dim qry As String
            'Dim dt1 As New DataTable

            'Dim col As New AutoCompleteStringCollection

            'qry = "Select itemdesc from items where itemdesc like '%" & txtSearchItem.Text & "%'"

            'sqlda = New MySqlDataAdapter(qry, sqlcon)
            'sqlda.Fill(dt1)

            'Dim i As Integer

            'For i = 0 To dt1.Rows.Count - 1

            '    col.Add(dt1.Rows(i).Item(0).ToString)
            'Next

            'txtSearchItem.AutoCompleteCustomSource = col

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try


        ''========================================================
        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim dt3 As New DataTable

            Dim qry As String

            qry = "Select items.itemnumber as Item_ID, items.itemid as Product_ID,items.itemdesc as Description, quantity as Number_in_Stocks, quota as Safety_Stock, maxQuota as Maximum_Stocks from items where items.itemdesc like '%" & txtSearchItem.Text & "%'"
            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt3)

            dgvItems.DataSource = dt3


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click

        Try
            If cmbSupplier.selectedValue = Nothing Then

            End If
        Catch ex As Exception
            MessageBox.Show("Please select supplier", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cmbSupplier.Focus()
          
            Exit Sub
        End Try
        
        cmbSupplier.Enabled = False

        Try
            If dgvItems.SelectedCells.Item(0).Value = Nothing Then

            End If

        Catch ex As Exception

            MessageBox.Show("Please indicate the item to add", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            dgvItems.Focus()

            Exit Sub

        End Try
 
        If txtQuantityPO.Text = Nothing Then
            MessageBox.Show("Please insert the number of quantity", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtQuantityPO.Focus()
            Exit Sub

        End If

        If txtUnitCostPO.Text = Nothing Then
            MessageBox.Show("Please insert the cost of the item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txtUnitCostPO.Focus()
            Exit Sub

        End If


        Dim noStocks, Safe, max, add, tot As Integer

        noStocks = dgvItems.SelectedCells.Item(3).Value
        Safe = dgvItems.SelectedCells.Item(4).Value
        max = dgvItems.SelectedCells.Item(5).Value
        add = txtQuantityPO.Text


        tot = noStocks + add

        If tot > max Then

            MessageBox.Show("You can't exceed from the maximum stocks", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End If


        Try

            Dim wish As ListViewItem

            For Each wish In lvPOItems.Items

                Dim gtc As String

                gtc = dgvItems.SelectedCells.Item(2).Value

                If gtc = wish.SubItems(0).Text Then

                    MessageBox.Show("The item is already listed below", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub

                End If


            Next

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim itemid As String

            Dim dtitem As New DataTable

            itemid = dgvItems.SelectedCells.Item(0).Value


            Dim qty, price, subtotal As Double

            qty = txtQuantityPO.Text

            price = txtUnitCostPO.Text

            Dim vat As Double


            subtotal = qty * price

            vat = subtotal * 0.12

            Dim semitotal As Double

            semitotal = vat + subtotal

            Dim lvItems As ListViewItem

            lvItems = lvPOItems.Items.Add(dgvItems.SelectedCells.Item(2).Value)
            lvItems.SubItems.Add(FormatNumber(price))
            lvItems.SubItems.Add(qty)
            lvItems.SubItems.Add(FormatNumber(subtotal))
            lvItems.SubItems.Add(FormatNumber(vat))
            lvItems.SubItems.Add(FormatNumber(semitotal))
            lvItems.SubItems.Add(lblPOID.Text)
            lvItems.SubItems.Add(itemid)
            lvItems.SubItems.Add(price)


            Dim total, inputVat, basetot As Double

            Dim temp As ListViewItem

            For Each temp In lvPOItems.Items
                basetot += CDbl(temp.SubItems.Item(3).Text)
                total += CDbl(temp.SubItems.Item(5).Text)
                inputVat += CDbl(temp.SubItems.Item(4).Text)

            Next

            lblAmtTotalPO.Text = FormatNumber(basetot)
            lblOutputVat.Text = FormatNumber(inputVat)
            lblTotal.Text = FormatNumber(total)
            lblAmountinWord.Text = AmountInWords(total)

            lblInputVATPO1.Text = inputVat
            lblTotalPO.Text = total

            btnSendPurchase.Enabled = True
            btnDeletefromList.Enabled = True


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

    End Sub

    Public Function getmaxpoid()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            Dim qry As String


            qry = "Select max(purchaseorderid) from purchaseorder"

            Dim dt0 As New DataTable
            Dim maxpo As Integer

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt0)

            Dim i As Integer

            While i <= dt0.Rows.Count - 1

                If IsDBNull(dt0.Rows(i).Item(0)) Then
                    maxpo = 1
                Else
                    maxpo = FormatNumber(dt0.Rows(i).Item(0) + 1)
                End If

                i += 1

            End While

            lblPOID.Text = maxpo

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            sqlcon.Close()


        End Try

        Return lblPOID
       
    End Function

    Public Function getmaxpoidformat()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String
            Dim dt12 As New DataTable

            qry = "SELECT MAX(poid) FROM purchaseorder"
            sqlcmd = New MySqlCommand(qry, sqlcon)
            Dim rid = sqlcmd.ExecuteScalar

            lblpoidformat.Text = ("PO" & If(IsDBNull(rid), "100001", Format(Mid(rid, 3, 9)) + 1))

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return lblpoidformat

    End Function

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles btnSendPurchase.Click

        Try
            If cmbSupplier.selectedValue = "" Then
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Please select supplier name", "Zamaryan Systeme", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End Try

        Dim suppid As Integer

        suppid = 0

        lblSuppID.Text = suppid

        Dim i As Integer

        i = MessageBox.Show("Are you sure you want to send this request?", "Zamaryan System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbNo Then
            Exit Sub
        End If

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim dt9 As New DataTable

            '============Get Supplier ID ==============='

            sqlda = New MySqlDataAdapter("Select supplierid from suppliers where suppliername ='" & cmbSupplier.selectedValue & "'", sqlcon)
            sqlda.Fill(dt9)

            For i = 0 To dt9.Rows.Count - 1

                suppid = dt9.Rows(i).Item(0)

                lblSuppID.Text = suppid
                i += 1

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            sqlcon.Close()

        End Try

        '==============================================================


        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            'Insert data to main table of purchaseorder

            sqlcmd = New MySqlCommand("Insert into purchaseorder(purchaseorderdate,supplierid,termsInDays,inputVat,total,remarks,poid,comments) values ('" & lblDateRequest.Text & "','" & suppid & "','" & txtTermsPO.Text & "','" & lblInputVATPO1.Text & "','" & lblTotalPO.Text & "','Pending','" & lblpoidformat.Text & "','" & txtComments.Text & "')", sqlcon)
            sqlcmd.ExecuteNonQuery()

            '=============================================================


            'insert each item in listview

            For Each item As ListViewItem In lvPOItems.Items

                sqlcmd = New MySqlCommand("Select MAX(purchaseorderid) from purchaseorder", sqlcon)
                Dim var1 = sqlcmd.ExecuteScalar


                sqlcmd = New MySqlCommand("Insert into purchaseorderitems (purchaseorderid, itemnumber, quantity, cost) values ('" & var1 & "','" & item.SubItems(7).Text & "','" & item.SubItems(2).Text & "','" & item.SubItems(8).Text & "')", sqlcon)

                sqlcmd.ExecuteNonQuery()

            Next

            MessageBox.Show("Information successfully saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnSendPurchase.Enabled = False
            btnDeletefromList.Enabled = False

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        marlboro()
        getmaxpoidformat()
        getSupplier()
        getmaxpoid()
        getPOtoReceive()
        getPayee()
        txtComments.Clear()
        btnCancelAll.PerformClick()

    End Sub

    Private Sub MaterialFlatButton9_Click(sender As Object, e As EventArgs)

        lvRequestPO.Items.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select purchaseorder.purchaseorderid,purchaseorder.purchaseorderdate,purchaseorder.inputVat,purchaseorder.total,suppliers.suppliername from purchaseorder inner join suppliers on purchaseorder.supplierid = suppliers.supplierid where purchaseorder.remarks = 'Pending' order by purchaseorder.purchaseorderdate asc"

            Dim dtqq As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtqq)

            Dim i As Integer


            While i <= dtqq.Rows.Count - 1

                Dim itm As ListViewItem

                itm = lvRequestPO.Items.Add(dtqq.Rows(i).Item(0))
                itm.SubItems.Add(dtqq.Rows(i).Item(1))
                itm.SubItems.Add(FormatNumber(dtqq.Rows(i).Item(2)))
                itm.SubItems.Add(FormatNumber(dtqq.Rows(i).Item(3)))
                itm.SubItems.Add(dtqq.Rows(i).Item(4))

                i += 1

            End While


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try
    End Sub

    Private Sub MaterialFlatButton10_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton10.Click
        If pnlViewRequest.Visible = False Then


            BunifuTransition1.ShowSync(pnlViewRequest, True, BunifuAnimatorNS.Animation.Leaf)
            BunifuTransition1.HideSync(pnlRequestItems, True, BunifuAnimatorNS.Animation.Leaf)

        Else

            Try
                lblPOIDitem.Text = lvRequestPO.SelectedItems.Item(0).Text

            Catch ex As Exception

                MessageBox.Show("Select one item to approve", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End Try

            larra()

            BunifuTransition1.HideSync(pnlViewRequest, True, BunifuAnimatorNS.Animation.Leaf)
            BunifuTransition1.ShowSync(pnlRequestItems, True, BunifuAnimatorNS.Animation.Leaf)

        End If

    End Sub

    Public Function larra()

        lvDetailedRequest.Items.Clear()


        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select items.itemid, items.itemdesc, purchaseorderitems.quantity, purchaseorderitems.cost, purchaseorderitems.quantity * purchaseorderitems.cost from items inner join purchaseorderitems on items.itemnumber = purchaseorderitems.itemnumber inner join purchaseorder on purchaseorderitems.purchaseorderid = purchaseorder.purchaseorderid where purchaseorder.poid = '" & lblPOIDitem.Text & "'"

            sqlda = New MySqlDataAdapter(qry, sqlcon)

            Dim dt2 As New DataTable
            sqlda.Fill(dt2)

            Dim i As Integer

            Do While i <= dt2.Rows.Count - 1

                Dim itm As ListViewItem

                itm = lvDetailedRequest.Items.Add(dt2.Rows(i).Item(0))
                itm.SubItems.Add(dt2.Rows(i).Item(1))
                itm.SubItems.Add(dt2.Rows(i).Item(2))
                itm.SubItems.Add(FormatNumber(dt2.Rows(i).Item(3)))
                itm.SubItems.Add(FormatNumber(dt2.Rows(i).Item(4)))

                i += 1

            Loop

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

        Return lvDetailedRequest

    End Function

    Public Function getInventoryitems()

        lvInventoryItems1.Items.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select * from items where quantity < quota"

            Dim dtk As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtk)

            Dim i As Integer

            While i <= dtk.Rows.Count - 1
                Dim itm As ListViewItem

                itm = lvInventoryItems1.Items.Add(dtk.Rows(i).Item(1))
                itm.SubItems.Add(dtk.Rows(i).Item(2))
                itm.SubItems.Add(dtk.Rows(i).Item(9))
                itm.SubItems.Add(dtk.Rows(i).Item(3))
                itm.SubItems.Add(dtk.Rows(i).Item(7))
                itm.SubItems.Add(dtk.Rows(i).Item(8))
                itm.SubItems.Add(FormatNumber(dtk.Rows(i).Item(5)))

                i += 1

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            sqlcon.Close()

        End Try

        Return lvInventoryItems1

    End Function
    Private Sub MaterialFlatButton8_Click(sender As Object, e As EventArgs)
        getInventoryitems()

    End Sub

    Private Sub MaterialFlatButton12_Click(sender As Object, e As EventArgs)
        Dim remarks As String
        remarks = InputBox("Enter the reason for declining", "Enter Reason", " ")

        If remarks = " " Then
            MessageBox.Show("You must enter a remarks to continue.")
            Exit Sub
        ElseIf remarks = "" Then
            Exit Sub
        Else

            Try

                sqlcon.ConnectionString = strconnection()
                sqlcon.Open()

                Dim qry As String

                qry = "Update purchaseorder set remarks ='Denied',remarks2 ='" & remarks & "' where purchaseorderid =" & lblPOIDitem.Text & ""

                sqlcmd = New MySqlCommand(qry, sqlcon)
                sqlcmd.ExecuteNonQuery()

                MessageBox.Show("Purchase Declined!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

            Finally

                sqlcon.Close()

                btnRefreshView.PerformClick()

            End Try


        End If

    End Sub

    Private Sub MaterialFlatButton13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialFlatButton9_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton9.Click

        lvRequestStatus.Items.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String


            Dim dt98 As New DataTable

            qry = "Select poid,purchaseorderdate,total-inputVat,inputVat,total,remarks,remarks2 from purchaseorder where remarks ='Approved' or remarks = 'Denied' or remarks ='Pending' order by remarks asc"

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt98)

            Dim i As Integer

            i = 0

            While i <= dt98.Rows.Count - 1

                Dim itm As ListViewItem

                itm = lvRequestStatus.Items.Add(dt98.Rows(i).Item(0))
                itm.SubItems.Add(dt98.Rows(i).Item(1))
                itm.SubItems.Add(FormatNumber(dt98.Rows(i).Item(2)))
                itm.SubItems.Add(FormatNumber(dt98.Rows(i).Item(3)))
                itm.SubItems.Add(FormatNumber(dt98.Rows(i).Item(4)))
                itm.SubItems.Add(dt98.Rows(i).Item(5))
                itm.SubItems.Add(dt98.Rows(i).Item(6))


                i += 1

            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles btnDeletefromList.Click

        Try

            'Remove Multiple Selected Items 
            For Each item As ListViewItem In lvPOItems.SelectedItems
                item.Remove()
            Next

            Dim total, inputVat, basetot As Double

            For Each temp In lvPOItems.Items
                basetot += CDbl(temp.subitems.item(4).text)
                total += CDbl(temp.SubItems.Item(5).Text)
                inputVat += CDbl(temp.SubItems.Item(4).Text)
            Next

            lblAmtTotalPO.Text = FormatNumber(basetot)
            lblOutputVat.Text = FormatNumber(inputVat)
            lblTotal.Text = FormatNumber(total)
            lblAmountinWord.Text = AmountInWords(total)

            lblInputVATPO1.Text = inputVat
            lblTotalPO.Text = total


        Catch ex As Exception

            Exit Sub

        End Try


    End Sub

    Public Function marlboro()

        Try
            cmbAccountName.Clear()

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String
            Dim dtwo As New DataTable

            qry = "Select accountname from chartofaccounts where accountgroup ='Noncurrent Assets' or accountgroup ='General & Administrative Expenses' order by accountname asc"
            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtwo)

            Dim i As Integer

            While i <= dtwo.Rows.Count - 1

                cmbAccountName.AddItem(dtwo.Rows(i).Item(0))

                i += 1

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

        Return cmbAccountName

    End Function


    Public Function getRRNumber()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim rid = ExecuteScalar("Select max(reportid) from receivingreport")
            lblReceivingReport.Text = ("RR" & If(IsDBNull(rid), "100001", Format(Mid(rid, 3, 9)) + 1))


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()


        End Try

        Return lblReceivingReport


    End Function

    Public Function getPOtoReceive()

        cmbPOReceive.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim dt97 As New DataTable

            Dim qry As String

            qry = "Select purchaseorder.poid from purchaseorder inner join purchaseorderitems on purchaseorder.purchaseorderid = purchaseorderitems.purchaseorderid where purchaseorder.remarks ='Approved' and purchaseorderitems.quantity > purchaseorderitems.quantityArrived group by purchaseorder.poid"

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt97)

            Dim q As Integer

            While q <= dt97.Rows.Count - 1

                cmbPOReceive.AddItem(dt97.Rows(q).Item(0))

                q += 1

            End While


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally
            sqlcon.Close()

        End Try

        Return cmbPOReceive

    End Function
    Private Sub MaterialFlatButton15_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton15.Click

        Try
            If cmbPOReceive.selectedValue = "" Then

            End If
        Catch ex As Exception
            MessageBox.Show("Select purchase order id to continue", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            cmbPOReceive.Focus()

            Exit Sub

        End Try
     

        getRRNumber()

        cmbPOReceive.Enabled = False
        cmbItemCodeRR.Enabled = True

        Try

            cmbItemCodeRR.Clear()

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry001 As String

            qry001 = "Select suppliers.supplierid from suppliers inner join purchaseorder on suppliers.supplierid = purchaseorder.supplierid order by suppliers.suppliername asc"

            sqlcmd = New MySqlCommand(qry001, sqlcon)
            idofsupp = sqlcmd.ExecuteScalar

            Dim qry1 As String

            Dim dt95 As New DataTable

            qry1 = "Select items.itemid from items inner join purchaseorderitems on items.itemnumber = purchaseorderitems.itemnumber inner join purchaseorder on purchaseorderitems.purchaseorderid = purchaseorder.purchaseorderid where purchaseorder.poid ='" & cmbPOReceive.selectedValue & "'"

            sqlda = New MySqlDataAdapter(qry1, sqlcon)
            sqlda.Fill(dt95)

            Dim k As Integer

            Do While k <= dt95.Rows.Count - 1

                cmbItemCodeRR.AddItem(dt95.Rows(k).Item(0))

                k += 1

            Loop

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()
            cmbItemCodeRR.Enabled = True

        End Try
    End Sub

    Private Sub cmbItemCodeRR_onItemSelected(sender As Object, e As EventArgs) Handles cmbItemCodeRR.onItemSelected

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select items.itemnumber,items.itemdesc,purchaseorderitems.quantity, ifnull(purchaseorderitems.quantityArrived,0), purchaseorderitems.cost from items inner join purchaseorderitems on items.itemnumber = purchaseorderitems.itemnumber inner join purchaseorder on purchaseorderitems.purchaseorderid = purchaseorder.purchaseorderid where items.itemid ='" & cmbItemCodeRR.selectedValue & "' and purchaseorder.poid='" & cmbPOReceive.selectedValue & "'"

            Dim dtq As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtq)

            For i = 0 To dtq.Rows.Count - 1

                txtItemID.Text = dtq.Rows(i).Item(0)
                txtDescription.Text = dtq.Rows(i).Item(1)
                lblQuantityNeededRR.Text = dtq.Rows(i).Item(2)
                lblQuantityArrivedRR.Text = dtq.Rows(i).Item(3)
                lblUnitCostRR.Text = dtq.Rows(i).Item(4)

                i += 1

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

            txtQuantityReceivedRR.Focus()


        End Try
    End Sub


    Private Sub MaterialFlatButton16_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton16.Click

        If txtQuantityReceivedRR.Text = Nothing Then
            MessageBox.Show("Please indicate the number of quantity received", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

        Try

            Dim tot As Integer

            tot = CInt(txtQuantityReceivedRR.Text) + CInt(lblQuantityArrivedRR.Text)


            If tot > lblQuantityNeededRR.Text Then

                MessageBox.Show("The quantity should not be greater than requested", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                txtQuantityReceivedRR.Focus()


                Exit Sub

            End If

            Dim grandtotal, inputvat As Double


            Dim itm As ListViewItem


            For Each itm In lvReceivingInvi.Items


                If txtItemID.Text = itm.SubItems.Item(1).Text Then

                    MessageBox.Show("The item is already in the list", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Sub


                End If

            Next

            Dim o As Integer

            o = MessageBox.Show("Are you sure you want to save this data?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If o = vbNo Then
                Exit Sub

            End If


            
            Dim vat, subtot, totality As Double

            subtot = lblUnitCostRR.Text * txtQuantityReceivedRR.Text

            vat = (lblUnitCostRR.Text * txtQuantityReceivedRR.Text) * 0.12


            totality = subtot + vat

            itm = lvReceivingInvi.Items.Add(truepoid) '0
            itm.SubItems.Add(txtItemID.Text) '1
            itm.SubItems.Add(txtQuantityReceivedRR.Text) '2 
            itm.SubItems.Add(lblUnitCostRR.Text) '3
            itm.SubItems.Add(vat) '4
            itm.SubItems.Add(subtot) '5
            itm.SubItems.Add(totality) '6
            itm.SubItems.Add(lblReceivingReport.Text) '7
            itm.SubItems.Add(tot) '8

            Dim kl As ListViewItem

            For Each kl In lvReceivingInvi.Items

                grandtotal += CDbl(itm.SubItems(6).Text)
                inputvat += CDbl(itm.SubItems(4).Text)

            Next

            lblGrandTotal.Text = FormatNumber(grandtotal)
            lblInputVAT.Text = FormatNumber(inputvat)
            lblAmtinWordsRR.Text = AmountInWords(grandtotal)

            lblGrandTotal1.Text = grandtotal
            lblInputVat1.Text = inputvat


            txtDescription.Text = Nothing
            txtItemID.Text = Nothing

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

    End Sub

    Private Sub MaterialFlatButton17_Click(sender As Object, e As EventArgs) Handles btnCancelRR.Click
        txtQuantityReceivedRR.Clear()

        getPOtoReceive()
        cmbItemCodeRR.Clear()
        cmbItemCodeRR.Enabled = False
        cmbPOReceive.Enabled = True
        lvReceivingInvi.Items.Clear()
        lvReceivingReport.Items.Clear()
        txtQuantityReceivedRR.Clear()
        cmbItemCodeRR.Enabled = False
        ''  txtQuantityReceivedRR.Enabled = False
        txtQuantityReceivedRR.Text = Nothing
        lblGrandTotal.Clear()
        lblInputVAT.Clear()
        lblAmtinWordsRR.Text = ""
        getRRNumber()


    End Sub

    Private Sub MaterialFlatButton18_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton18.Click

        Try

            Dim i As Integer

            i = MessageBox.Show("Are you sure you want to save this data?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If i = vbNo Then
                Exit Sub

            End If

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            'insert reference billing for po

            Dim qry2 As String
            Dim duedate, datenow As Date

            Dim qry20 As String

            qry20 = "Select suppliers.termsofAgreement from suppliers where suppliers.supplierid =" & idofsupp

            sqlda = New MySqlDataAdapter(qry20, sqlcon)

            Dim dtrqs As New DataTable
            sqlda.Fill(dtrqs)


            For u = 0 To dtrqs.Rows.Count - 1

                lblTermsSupplier.Text = dtrqs.Rows(u).Item(0)

                u += 1

            Next

            Dim dateToAdd As Integer

            dateToAdd = CInt(lblTermsSupplier.Text)
            datenow = Format(Date.Now, "yyyy-MM-dd")

            duedate = DateAdd(DateInterval.Day, dateToAdd, datenow)

            Dim duedate1 = duedate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

            Dim inputvat = lblInputVat1.Text.Replace(",", "")

            Dim gtot = lblGrandTotal1.Text.Replace(",", "")

            qry2 = "Insert into receivingreport(reportid,purchaseorderid,datedelivered,inputVat,total,duedate,status) values ('" & lblReceivingReport.Text & "','" & truepoid & "','" & txtDateReceivedRR.Text & "','" & inputvat & "','" & gtot & "','" & duedate1 & "','Unpaid')"

            sqlcmd = New MySqlCommand(qry2, sqlcon)
            sqlcmd.ExecuteNonQuery()

            Dim item2 As ListViewItem


            For Each item2 In lvReceivingInvi.Items


                Dim qry3 As String

                qry3 = "Insert into receivingitems (reportid,itemnumber,quantityreceived,cost,inputVat,total) values ('" & item2.SubItems(7).Text & "','" & item2.SubItems(1).Text & "','" & item2.SubItems(2).Text & "','" & item2.SubItems(3).Text & "','" & item2.SubItems(4).Text & "','" & item2.SubItems(6).Text & "')"

                sqlcmd = New MySqlCommand(qry3, sqlcon)
                sqlcmd.ExecuteNonQuery()

            Next

            Dim item As ListViewItem


            For Each item In lvReceivingInvi.Items

                Dim qryx As String

                qryx = "Update purchaseorderitems set quantityArrived =" & item.SubItems(8).Text & " where purchaseorderid =" & truepoid & " and itemnumber =" & item.SubItems(1).Text

                sqlcmd = New MySqlCommand(qryx, sqlcon)
                sqlcmd.ExecuteNonQuery()

                'insert data in uniqueitem

                Dim o As Integer

                While o <= item.SubItems(8).Text - 1

                    sqlcmd = New MySqlCommand("Insert into uniqueitem (itemnumber,cost,isInventory,dateInventory) values ('" & item.SubItems(1).Text & "','" &
                                              item.SubItems(3).Text & "','YES','" & txtDateReceivedRR.Text & "')", sqlcon)
                    sqlcmd.ExecuteNonQuery()

                    o += 1

                End While

                '======================================================================================


                'get Data Per item 

                Dim currentqty, addedQty, newqty As Integer
                Dim currentRunning, newRunning, addedBal As Double



                Dim dtqty As New DataTable


                sqlda = New MySqlDataAdapter("Select quantity,runningBalance from items where itemnumber='" & item.SubItems(1).Text & "'", sqlcon)
                sqlda.Fill(dtqty)

                For i = 0 To dtqty.Rows.Count - 1

                    currentqty = dtqty.Rows(i).Item(0)
                    currentRunning = dtqty.Rows(i).Item(1)

                    i += 1
                Next

                addedQty = item.SubItems(2).Text

                newqty = addedQty + currentqty

                addedBal = item.SubItems(5).Text

                newRunning = currentRunning + addedBal


                ' ''update inventory table

                sqlcmd = New MySqlCommand("Update items set quantity ='" & newqty & "' where itemnumber = " & item.SubItems(1).Text & "", sqlcon)
                sqlcmd.ExecuteNonQuery()


                sqlcmd = New MySqlCommand("Update items set runningBalance='" & newRunning & "' where itemnumber =" & item.SubItems(1).Text, sqlcon)
                sqlcmd.ExecuteNonQuery()

                ' '' =============================================================

                Dim lvitem As ListViewItem

                Dim inventoryChartVal, outputvatChartVal As Double

                inventoryChartVal = 0

                For Each lvitem In lvReceivingInvi.Items

                    inventoryChartVal += FormatNumber(lvitem.SubItems(5).Text)
                    outputvatChartVal += FormatNumber(lvitem.SubItems(4).Text)

                Next

                lblinventorychart.Text = inventoryChartVal
                lbloutputvatot.Text = outputvatChartVal
            Next

            Dim qry8 As String

            qry8 = "Insert into journal(journaldesc) values ('To record purchase')"
            sqlcmd = New MySqlCommand(qry8, sqlcon)
            sqlcmd.ExecuteNonQuery()

            Dim qry9 As String

            Dim dtqqq As New DataTable
            qry9 = "Select max(journalid) from journal"
            sqlda = New MySqlDataAdapter(qry9, sqlcon)
            sqlda.Fill(dtqqq)

            Dim journalid As String

            For i = 0 To dtqqq.Rows.Count - 1

                journalid = dtqqq.Rows(i).Item(0)

                lblJournalID.Text = journalid
                i += 1
            Next

            'Insert automatic Journal Entry

            Dim inventoryCOA, inputVatCOA, AccPayable As String

            inventoryCOA = "5"
            inputVatCOA = "6"
            AccPayable = "8"

            Dim qry11 As String

            Dim debitinventory, debitinputVat As Double

            debitinventory = lblGrandTotal1.Text - lblInputVat1.Text
            debitinputVat = lblInputVat1.Text

            Dim datetoday As String

            datetoday = Format(Date.Now, "yyyy-MM-dd")

            ''===============Inventory=================

            Dim newRunInventory As Double
            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & inventoryCOA & "  order by journalentryid desc limit 1 ", sqlcon)
            Dim val1 = sqlcmd.ExecuteScalar

            newRunInventory = val1 + lblinventorychart.Text


            qry11 = "Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values (" & lblJournalID.Text & ",'" & datetoday & "'," & inventoryCOA & "," & lblinventorychart.Text & ",0,'Receiving Report','" & lblReceivingReport.Text & "' ," & newRunInventory & ")"

            sqlcmd = New MySqlCommand(qry11, sqlcon)
            sqlcmd.ExecuteNonQuery()

            ''==============end======================


            ''=========================inputVAT========================

            Dim newRunInputVat As Double


            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & inputVatCOA & "  order by journalentryid desc limit 1 ", sqlcon)
            Dim val2 = sqlcmd.ExecuteScalar

            newRunInputVat = val2 + lblInputVAT.Text

            Dim qry12 As String
            qry12 = "Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values(" & lblJournalID.Text & ",'" & datetoday & "'," & inputVatCOA & "," & lblInputVat1.Text & ",0,'Receiving Report','" & lblReceivingReport.Text & "', " & newRunInputVat & ")"

            sqlcmd = New MySqlCommand(qry12, sqlcon)
            sqlcmd.ExecuteNonQuery()

            ''==============================end=======================

            ''=Accounts payable

            Dim newRunAccpayable As Double
            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & AccPayable & " order by journalentryid desc limit 1 ", sqlcon)
            Dim val3 = sqlcmd.ExecuteScalar

            newRunAccpayable = val3 - lblGrandTotal1.Text

            Dim qry13 As String
            qry13 = "Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values('" & lblJournalID.Text & "','" & datetoday & "','" & AccPayable & "','0','" & lblGrandTotal1.Text & "','Receiving Report','" & lblReceivingReport.Text & "','" & newRunAccpayable & "')"

            sqlcmd = New MySqlCommand(qry13, sqlcon)
            sqlcmd.ExecuteNonQuery()
            MessageBox.Show("Information Successfully Saved!", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        btnCancelRR.PerformClick()
        lblGrandTotal.Clear()
        lblInputVAT.Clear()
        getrecievingreport()


    End Sub

    Private Sub cmbPOReceive_onItemSelected(sender As Object, e As EventArgs) Handles cmbPOReceive.onItemSelected

        lvReceivingReport.Items.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select items.itemnumber, items.itemid, items.itemdesc, purchaseorderitems.quantity, purchaseorderitems.quantityArrived,purchaseorder.purchaseorderid,purchaseorderitems.cost from items inner join purchaseorderitems on items.itemnumber = purchaseorderitems.itemnumber inner join purchaseorder on purchaseorderitems.purchaseorderid = purchaseorder.purchaseorderid where purchaseorder.poid = '" & cmbPOReceive.selectedValue & "'"

            Dim dt96 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt96)

            Dim jk As Integer

            While jk <= dt96.Rows.Count - 1

                truepoid = dt96.Rows(jk).Item(5)

                Dim itm As ListViewItem


                itm = lvReceivingReport.Items.Add(dt96.Rows(jk).Item(1))
                itm.SubItems.Add(dt96.Rows(jk).Item(2))
                itm.SubItems.Add(dt96.Rows(jk).Item(3))
                itm.SubItems.Add(dt96.Rows(jk).Item(4))
                itm.SubItems.Add(dt96.Rows(jk).Item(0))
                itm.SubItems.Add(FormatNumber(dt96.Rows(jk).Item(6)))

                jk += 1
            End While

            lblPOtrueID.Text = cmbPOReceive.selectedValue

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try
    End Sub

    Public Function getapvid()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select max(APVID) from billings"

            sqlcmd = New MySqlCommand(qry, sqlcon)
            Dim koko = sqlcmd.ExecuteScalar

            lblAVPID.Text = ("APV" & If(IsDBNull(koko), "100001", Format(Mid(koko, 4, 9)) + 1))
           
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            sqlcon.Close()

        End Try

        Return lblAVPID.Text

    End Function

    Private Sub MaterialFlatButton14_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton14.Click

        If MaterialSingleLineTextField1.Text = Nothing Then
            MessageBox.Show("Please fill in the blank item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            MaterialSingleLineTextField1.Focus()
            Exit Sub

        End If

        If MaterialSingleLineTextField2.Text = Nothing Then
            MessageBox.Show("Please fill in the blank item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            MaterialSingleLineTextField2.Focus()
            Exit Sub

        End If

        Try
            Dim vat As Double


            Dim spatiu1 As New ListViewItem

            spatiu1 = MaterialListView1.Items.Add(txtAccountCode.Text)
            spatiu1.SubItems.Add(cmbAccountName.selectedValue)
            spatiu1.SubItems.Add(MaterialSingleLineTextField1.Text)
            spatiu1.SubItems.Add(FormatNumber(MaterialSingleLineTextField2.Text))
         

            If MaterialCheckBox1.Checked = True Then

                vat = MaterialSingleLineTextField2.Text * 0.12

            Else
                vat = 0
            End If

            spatiu1.SubItems.Add(FormatNumber(vat))

            Dim itemL As ListViewItem


            Dim amt, totV As Double

            For Each itemL In MaterialListView1.Items

                amt += CDbl(itemL.SubItems(3).Text)
                totV += CDbl(itemL.SubItems(4).Text)

            Next

          
            lbltotalamount.Text = FormatNumber(amt)
            lbltotalvat.Text = FormatNumber(totV)

            lbltotalvat1.Text = totV

            lblTotalAPVoucher.Text = CDbl(lbltotalamount.Text) + lbltotalvat1.Text

            lblTotalAPVoucher.Text = FormatNumber(lblTotalAPVoucher.Text)

            lblAmtInword.Text = AmountInWords(lblTotalAPVoucher.Text)

            MaterialCheckBox1.Checked = False
            txtAccountCode.Clear()


            If txtAccountGroupAPV.Text = "General & Administrative Expenses" Then

                Dim k As ListViewItem

                k = lvRetainedEarnings.Items.Add(MaterialSingleLineTextField2.Text)

            End If

            MaterialSingleLineTextField2.Clear()
            MaterialSingleLineTextField1.Clear()

        Catch ex As Exception

            MsgBox(ex.Message)
            MessageBox.Show("Please fill in the blank item", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub

        End Try


    End Sub

    Private Sub cmbAccountName_onItemSelected(sender As Object, e As EventArgs) Handles cmbAccountName.onItemSelected

        txtAccountCode.Text = ExecuteScalar("SELECT accountcode FROM chartofaccounts WHERE accountname='" & cmbAccountName.selectedValue & "'")
        sqlcon.Close()

        accountid = ExecuteScalar("SELECT accountid FROM chartofaccounts WHERE accountname='" & cmbAccountName.selectedValue & "'")

        accGroupRE = ExecuteScalar("Select accountgroup from chartofaccounts where accountname ='" & cmbAccountName.selectedValue & "'")

        txtAccountGroupAPV.Text = accGroupRE

    End Sub

    Private Function ExecuteScalar(query As String) As Object

        If sqlcon.State = ConnectionState.Closed Then
            ''sqlcon.ConnectionString = strconnection()
            sqlcon.Open()
        End If
        sqlcmd = New MySqlCommand(query, sqlcon)

        Return sqlcmd.ExecuteScalar
        sqlcon.Close()

    End Function

    Private Sub MaterialFlatButton17_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton17.Click


        Dim i As Integer

        i = MessageBox.Show("Are you sure you want to save this data?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbNo Then
            Exit Sub

        End If

        ' Dim accountspayable = 8
        Dim inputvat = 6
        Dim itm As ListViewItem

        Try

            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.Open()
            End If

            ''add each item in billingitems

            Dim billingdate, dueDate1 As Date
            Dim dateAdded As Integer

            billingdate = dtpBilling.Text
            dateAdded = CInt(txtTerms1.Text)

            dueDate1 = DateAdd(DateInterval.Day, dateAdded, billingdate)

            Dim dueDate2 As String

            dueDate2 = dueDate1.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)

            Dim totbawcher = lblTotalAPVoucher.Text.Replace(",", "")

            sqlcmd = New MySqlCommand("Insert into billings(dateBill,totalBill,inputVat,APVid,isPaid,supplierid,duedate) values('" & Format(Date.Now, "yyyy-MM-dd") & "','" & totbawcher & "','" & lbltotalvat1.Text & "','" & lblAVPID.Text & "','Unpaid','" & lblSupplierID.Text & "','" & dueDate2 & "')", sqlcon)
            sqlcmd.ExecuteNonQuery()

            accountid = ExecuteScalar("Select accountid from chartofaccounts where accountname='Accounts Payable'")

            sqlcmd = New MySqlCommand("Insert into journal(journaldesc) values ('Accounts Payable Voucher')", sqlcon)
            sqlcmd.ExecuteNonQuery()


            Dim newjid = ExecuteScalar("Select max(journalid) from journal")

            For Each itm In MaterialListView1.Items


                Dim perAccountID As Integer

                perAccountID = ExecuteScalar("Select accountid from chartofaccounts where accountname = '" & itm.SubItems(1).Text & "'")
                Dim amount1 = itm.SubItems(3).Text.Replace(",", "")
                Dim vat1 = itm.SubItems(4).Text.Replace(",", "")
                sqlcmd = New MySqlCommand("Insert into billingitem(APVid,accountid,description,amount,vat) values('" & lblAVPID.Text & "','" & perAccountID & "','" & itm.SubItems(2).Text & "'," & amount1 & "," & vat1 & ")", sqlcon)
                sqlcmd.ExecuteNonQuery()

                '=========================================================

                'per Accountid 

                sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & perAccountID & " order by journalentryid desc limit 1 ", sqlcon)
                Dim val3 = sqlcmd.ExecuteScalar

                Dim newRunperAccount As Double

                newRunperAccount = val3 + amount1

                sqlcmd = New MySqlCommand("Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & newjid & "','" & dtpBilling.Text & "','" & perAccountID & "','" & amount1 & "','0','Accounts Payable Voucher','" & lblAVPID.Text & "','" & newRunperAccount & "')", sqlcon)
                sqlcmd.ExecuteNonQuery()


                '------------------------

            Next

            ' input vat debit
            If lbltotalvat1.Text > 0 Then

                'input vat debit

                Dim newRunInputVAT As Double

                sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & inputvat & " order by journalentryid desc limit 1 ", sqlcon)
                Dim val2 = sqlcmd.ExecuteScalar

                newRunInputVAT = val2 + lbltotalvat1.Text

                Dim inputbat = lbltotalvat1.Text.Replace(",", "")

                sqlcmd = New MySqlCommand("Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & newjid & "','" & dtpBilling.Text & "','" & inputvat & "','" & inputbat & "','0','Accounts Payable Voucher','" & lblAVPID.Text & "','" & newRunInputVAT & "')", sqlcon)
                sqlcmd.ExecuteNonQuery()

            End If


            ''=====================Start ========================

            Dim accRunningBal As Double

            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & accountid & " order by journalentryid desc limit 1 ", sqlcon)
            Dim val1 = sqlcmd.ExecuteScalar

            accRunningBal = val1 - lblTotalAPVoucher.Text

            ''credit on accounts payable

            Dim apvoucherAP = lblTotalAPVoucher.Text.Replace(",", "")

            sqlcmd = New MySqlCommand("Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & newjid & "','" & dtpBilling.Text & "','" & accountid & "','0','" & apvoucherAP & "','Accounts Payable Voucher','" & lblAVPID.Text & "','" & accRunningBal & "')", sqlcon)
            sqlcmd.ExecuteNonQuery()

            ''=================END=====================


            Dim retainedEarnings As Double
            Dim retCOA As Integer

            Dim items As ListViewItem


            For Each items In lvRetainedEarnings.Items

                retainedEarnings += CDbl(items.SubItems(0).Text)

            Next

            Dim totbat1 = lbltotalvat1.Text.Replace(",", "")

            retainedEarnings = retainedEarnings

            Dim qry9 As String

            qry9 = "Select accountid from chartofaccounts where accountname ='Retained Earnings'"
            sqlcmd = New MySqlCommand(qry9, sqlcon)
            retCOA = sqlcmd.ExecuteScalar

            sqlcmd = New MySqlCommand("Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2) values ('" & newjid & "','" & dtpBilling.Text & "','" & retCOA & "','" & retainedEarnings & "','0','Accounts Payable Voucher','" & lblAVPID.Text & "')", sqlcon)
            sqlcmd.ExecuteNonQuery()


            '=================End==========================
            MessageBox.Show("Vouchers are successfully recorded.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()

            End If

        End Try


        lvRetainedEarnings.Items.Clear()
        btnCancelAPV.PerformClick()
        lblAVPID.Text = getapvid()
        lblTotalAPVoucher.Clear()

        getbillingstatement()

    End Sub

    Private Sub MaterialFlatButton11_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton11.Click

        btnRefreshView.PerformClick()

    End Sub
    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles btnCancelAll.Click
        lblAmtTotalPO.Clear()
        txtContactPO.Clear()
        lblAmountinWord.Text = ""
        lblTotal.Text = ""
        lblOutputVat.Text = ""
        dgvItems.DataSource = Nothing
        txtQuantityPO.Clear()
        txtItemID.Clear()
        txtQuantityReceivedRR.Clear()
        txtSearchItem.Clear()
        txtTelephonePO.Clear()
        txtTermsPO.Clear()
        txtTinPO.Clear()
        txtUnitCostPO.Clear()
        txtWebsitePO.Clear()
        txtEmailPO.Clear()
        txtAddress.Clear()
        txtAccountCode.Clear()
        txtDateReceivedRR.Clear()
        txtDescription.Clear()
        txtFaxPO.Clear()
        txtItemID.Clear()
        lvPOItems.Items.Clear()
        getSupplier()
        getPayee()
        getmaxpoidformat()
        cmbSupplier.Enabled = True


    End Sub


    Private Sub txtQuantityPO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityPO.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub
    Private Sub txtUnitCostPO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitCostPO.KeyPress

        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case 46

            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtTermsPO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTermsPO.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub
    Private Sub txtQuantityReceivedRR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityReceivedRR.KeyPress

        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select

    End Sub

    Private Sub MaterialFlatButton6_Click_1(sender As Object, e As EventArgs) Handles btnCancelAPV.Click

        lblAmtInword.Text = ""
        lbltotalamount.Text = ""
        lbltotalvat.Text = ""
        MaterialListView1.Items.Clear()
        txtAccountCode.Clear()
        MaterialSingleLineTextField1.Clear()
        MaterialSingleLineTextField2.Clear()
        MaterialCheckBox1.Checked = False
        cmbPayee.selectedIndex = 0
        txtTerms1.Clear()

    End Sub


    Private Sub lvpurchase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvpurchase.SelectedIndexChanged


    End Sub

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click

    End Sub

    Private Sub lvbilling_MouseClick(sender As Object, e As MouseEventArgs) Handles lvbilling.MouseClick
        Try


            TextBox5.Text = lvbilling.SelectedItems.Item(0).Text
            Dim sTitle8 As String
            sTitle8 = TextBox5.Text
            Dim frm8 As New viewreportbilling(sTitle8)
            frm8.Show()
        Catch ex As Exception
            Exit Sub

        End Try


    End Sub

    Private Sub tabInventory_MouseClick(sender As Object, e As MouseEventArgs) Handles tabInventory.MouseClick
    
    End Sub

    Private Sub lvpurchase_MouseClick(sender As Object, e As MouseEventArgs) Handles lvpurchase.MouseClick
        TextBox3.Text = lvpurchase.SelectedItems.Item(0).Text
        Dim sTitle6 As String
        sTitle6 = TextBox3.Text
        Dim frm6 As New viewpurchasereport(sTitle6)
        frm6.Show()
    End Sub

    Private Sub dgvrecievingreport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvrecievingreport.SelectedIndexChanged

    End Sub

    Private Sub dgvrecievingreport_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvrecievingreport.MouseClick
        TextBox6.Text = dgvrecievingreport.SelectedItems.Item(0).Text
        Dim sTitle22 As String
        sTitle22 = TextBox6.Text
        Dim frm22 As New viewrecievingreport(sTitle22)
        frm22.Show()
    End Sub

    Private Sub cmbPayee_onItemSelected(sender As Object, e As EventArgs) Handles cmbPayee.onItemSelected

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select * from suppliers where suppliername ='" & cmbPayee.selectedValue & "'"

            sqlcmd = New MySqlCommand(qry, sqlcon)
            sqlcmd.Connection = sqlcon
            Using i = sqlcmd.ExecuteReader
                If i.Read Then

                    lblSupplierID.Text = i.GetValue(0)
                    txtAddress1.Text = i.GetValue(2)
                    txtZip1.Text = i.GetValue(3)
                    txtContact1.Text = i.GetValue(4)
                    txtTerms1.Text = i.GetValue(10)
                    txtCP1.Text = i.GetValue(7)
              
                End If

                i.Close()

            End Using

        Catch ex As Exception

            Exit Sub

        Finally
            sqlcon.Close()


        End Try
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MaterialFlatButton8_Click_1(sender As Object, e As EventArgs) Handles btnRefreshView.Click

        lvRequestPO.Items.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select purchaseorder.poid, purchaseorder.purchaseorderdate, suppliers.suppliername ,purchaseorder.total - purchaseorder.inputVat ,purchaseorder.inputVat,purchaseorder.total from purchaseorder inner join suppliers on purchaseorder.supplierid = suppliers.supplierid where purchaseorder.remarks = 'Pending' and  purchaseorder.remarks != 'Denied' order by purchaseorder.purchaseorderdate asc"

            Dim dtqq As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtqq)

            Dim i As Integer


            While i <= dtqq.Rows.Count - 1

                Dim itm As ListViewItem

                itm = lvRequestPO.Items.Add(dtqq.Rows(i).Item(0))
                itm.SubItems.Add(dtqq.Rows(i).Item(1))
                itm.SubItems.Add(dtqq.Rows(i).Item(2))
                itm.SubItems.Add(FormatNumber(dtqq.Rows(i).Item(3)))
                itm.SubItems.Add(FormatNumber(dtqq.Rows(i).Item(4)))
                itm.SubItems.Add(FormatNumber(dtqq.Rows(i).Item(5)))

                i += 1

            End While


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try
    End Sub

    Private Sub MaterialFlatButton4_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click
        getInventoryitems()

    End Sub

    Private Sub MaterialFlatButton19_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton19.Click

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Update purchaseorder set remarks ='Approved' where poid ='" & lblPOIDitem.Text & "'"

            sqlcmd = New MySqlCommand(qry, sqlcon)
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Purchase Approved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

            marlboro()
            getmaxpoidformat()
            getSupplier()
            getmaxpoid()
            getPOtoReceive()
            getPayee()


        End Try

        BunifuTransition1.HideSync(pnlRequestItems, True, BunifuAnimatorNS.Animation.Leaf)
        BunifuTransition1.ShowSync(pnlViewRequest, True, BunifuAnimatorNS.Animation.Leaf)

        btnRefreshView.PerformClick()
        getpurchasereport()


    End Sub

    Private Sub MaterialFlatButton6_Click_2(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click
        Dim remarks As String
        remarks = InputBox("Enter the reason for declining", "Enter Reason", " ")

        If remarks = " " Then
            MessageBox.Show("You must enter a remarks to continue.")
            Exit Sub
        ElseIf remarks = "" Then
            Exit Sub
        Else

            Try

                sqlcon.ConnectionString = strconnection()
                sqlcon.Open()

                Dim qry As String

                qry = "Update purchaseorder set remarks ='Denied',remarks2 ='" & remarks & "' where poid ='" & lblPOIDitem.Text & "'"

                sqlcmd = New MySqlCommand(qry, sqlcon)
                sqlcmd.ExecuteNonQuery()

                MessageBox.Show("Purchase Declined!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

            Finally

                sqlcon.Close()

            End Try

            marlboro()
            getmaxpoidformat()
            getSupplier()
            getmaxpoid()
            getPOtoReceive()
            getPayee()

            BunifuTransition1.HideSync(pnlRequestItems, True, BunifuAnimatorNS.Animation.Leaf)
            BunifuTransition1.ShowSync(pnlViewRequest, True, BunifuAnimatorNS.Animation.Leaf)


        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialFlatButton1_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click

        getpurchasereport()
    End Sub

    Private Sub MaterialFlatButton2_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click

        viewreportprintallpurchase.Show()
    End Sub

    Private Sub MaterialFlatButton5_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click

        viewreportprintallrecievingreport.Show()

    End Sub

    Private Sub MaterialFlatButton7_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton7.Click

        getrecievingreport()
    End Sub

    Private Sub MaterialFlatButton8_Click_2(sender As Object, e As EventArgs) Handles MaterialFlatButton8.Click

        viewreportprintallapv.Show()

    End Sub

    Private Sub MaterialFlatButton12_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton12.Click

        getbillingstatement()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub lvDetailedRequest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvDetailedRequest.SelectedIndexChanged

    End Sub
End Class