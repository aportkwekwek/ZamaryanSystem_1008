Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class frmSuppliers

    Dim sqlcon As New MySqlConnection
    Dim sqlda As New MySqlDataAdapter
    Dim sqlcmd As New MySqlCommand
    Private istinformat, backspacepressed As Boolean
    Public tangina As Boolean


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmSuppliers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Enabled = True
        frmMain.Focus()

    End Sub

    Private Sub frmSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

        getsupplier()

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs)

      
    End Sub

    Private Sub btnClearItem_Click(sender As Object, e As EventArgs) Handles btnClearItem.Click

        txtSaddress.Clear()
        txtSCperson.Clear()
        txtSEmail.Clear()
        txtSFax.Clear()
        txtSname.Clear()
        txtsNumber.Clear()
        txtSTax.Text = Nothing

        txtSTerms.Clear()
        txtSTin.Clear()
        txtSWebsite.Clear()
        txtSzip.Clear()

    End Sub
    Public Sub sup()
        lvSuppliers.Items.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String
            Dim dt As New DataTable
            Dim i As Integer

            qry = "Select suppliername,supplieraddress,supplierphone,supplierfax,suppliercontactperson,suppliertin from suppliers"

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt)

            While i <= dt.Rows.Count - 1

                Dim itm As ListViewItem

                itm = lvSuppliers.Items.Add(dt.Rows(i).Item(0))
                itm.SubItems.Add(dt.Rows(i).Item(1))
                itm.SubItems.Add(dt.Rows(i).Item(2))
                itm.SubItems.Add(dt.Rows(i).Item(3))
                itm.SubItems.Add(dt.Rows(i).Item(4))
                itm.SubItems.Add(dt.Rows(i).Item(5))

                i += 1

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()


        End Try
    End Sub
    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        sup()

    End Sub

   

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs)


       

    End Sub

    Private Sub cmbsupplierbilling_onItemSelected(sender As Object, e As EventArgs)

      

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

   
    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs)


        

    End Sub

    Private Sub btnpaid_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvUnpaidBalance_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub txtSzip_Click(sender As Object, e As EventArgs) Handles txtSzip.Click

    End Sub

    Private Sub txtSzip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSzip.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 46 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtsNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 46 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtSFax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSFax.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 46 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtSTax_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 46 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtSCperson_Click(sender As Object, e As EventArgs) Handles txtSCperson.Click

    End Sub

    Private Sub txtSCperson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSCperson.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 46 To 58
                'Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtSTerms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSTerms.KeyPress
    
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSTin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSTin.KeyDown
        istinformat = False

        If (e.KeyCode > 47 And e.KeyCode < 58) Or (e.KeyCode > 95 And e.KeyCode < 106) Then
            If Control.ModifierKeys <> Keys.Shift Then
                istinformat = True
            End If
        End If

        backspacepressed = False
        If (e.KeyCode = Keys.Back) Then
            istinformat = True
            backspacepressed = True
        End If
    End Sub

    Private Sub txtSTin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSTin.KeyPress
        If istinformat = False Then
            e.Handled = True
        End If
        If txtSTin.Text.Count = 3 OrElse txtSTin.Text.Count = 7 OrElse txtSTin.Text.Count = 11 Then
            If backspacepressed = False Then
                txtSTin.Text += "-"
                txtSTin.SelectionStart = txtSTin.TextLength + 1
            End If
        End If
    End Sub

    Private Sub btnclearedit_Click(sender As Object, e As EventArgs) Handles btnclearedit.Click
        dgveditcustomer.Visible = True
        pnleditcustomer.Visible = False
        Label26.Visible = True
        txtsearchcustomer.Visible = True
        Dim control As Control

        For Each control In Panel1.Controls
            If (control.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(control, TextBox)
                textbox.Clear()
            End If
        Next
        btnclearedit.Visible = False
        txtnameedit.Enabled = False
        txtaddedit.Enabled = False
        txtzipedit.Enabled = False
        txtphoneedit.Enabled = False
        txtfaxedit.Enabled = False
        txtcpedit.Enabled = False
        txtemailedit.Enabled = False
        txttermsedit.Enabled = False
        txttin.Enabled = False
        txtwebsiteedit.Enabled = False
        txtvendortaxedit.Enabled = False
        chbinventorysupplier.Enabled = False
        Button2.Visible = True
        btnsaveedit.Text = "Edit"
    End Sub

    Private Sub btnsaveedit_Click(sender As Object, e As EventArgs) Handles btnsaveedit.Click
        Try

            If btnsaveedit.Text = "Edit" Then

                BunifuTransition1.HideSync(dgveditcustomer, True, BunifuAnimatorNS.Animation.Leaf)
                BunifuTransition1.ShowSync(pnleditcustomer, False, BunifuAnimatorNS.Animation.Leaf)
                Label26.Visible = False
                txtsearchcustomer.Visible = False
                txtidedit.Text = dgveditcustomer.SelectedCells.Item(0).Value
                txtnameedit.Text = dgveditcustomer.SelectedCells.Item(1).Value
                txtaddedit.Text = dgveditcustomer.SelectedCells.Item(2).Value
                txtzipedit.Text = dgveditcustomer.SelectedCells.Item(3).Value
                txtphoneedit.Text = dgveditcustomer.SelectedCells.Item(4).Value
                txtfaxedit.Text = dgveditcustomer.SelectedCells.Item(5).Value
                txtvendortaxedit.Text = dgveditcustomer.SelectedCells(11).Value
                txtwebsiteedit.Text = dgveditcustomer.SelectedCells(6).Value
                txtcpedit.Text = dgveditcustomer.SelectedCells.Item(7).Value
                txtemailedit.Text = dgveditcustomer.SelectedCells.Item(8).Value
                txttin.Text = dgveditcustomer.SelectedCells.Item(9).Value
                txttermsedit.Text = dgveditcustomer.SelectedCells.Item(10).Value
                If (dgveditcustomer.SelectedCells.Item(12).Value = 1) Then
                    chbinventorysupplier.Checked = True
                End If
                btnclearedit.Visible = True
                btnsaveedit.Text = "Save"


            ElseIf btnsaveedit.Text = "Save" Then

                Dim k As Integer

                k = MessageBox.Show("Are you sure you want to update this information?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If k = vbNo Then
                    Exit Sub

                End If

                Dim check1 As Integer

                If chbinventorysupplier.Checked = True Then
                    check1 = 1
                Else
                    check1 = 0

                End If

                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                sqlcmd = New MySqlCommand("UPDATE suppliers SET suppliername='" & txtnameedit.Text & "',supplieraddress='" & txtaddedit.Text & "',supplierzip='" & txtzipedit.Text & "',supplierphone='" & txtphoneedit.Text & "',supplierfax='" & txtfaxedit.Text & "',vendorTax='" & txtvendortaxedit.Text & "',supplierwebsite='" & txtwebsiteedit.Text & "',suppliercontactperson='" & txtcpedit.Text & "',supplieremail='" & txtemailedit.Text & "',suppliertin='" & txttin.Text & "',termsofAgreement='" & txttermsedit.Text & "',InventorySupplier='" & check1 & "' WHERE suppliernumber='" & txtidedit.Text & "'", sqlcon)
                sqlcmd.ExecuteNonQuery()
                MessageBox.Show("Information updated.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BunifuTransition1.ShowSync(dgveditcustomer, True, BunifuAnimatorNS.Animation.Leaf)
                BunifuTransition1.HideSync(pnleditcustomer, False, BunifuAnimatorNS.Animation.Leaf)
                Label26.Visible = True
                txtsearchcustomer.Visible = True
                btnclearedit.Visible = False
                txtnameedit.Enabled = False
                txtaddedit.Enabled = False
                txtzipedit.Enabled = False
                txtphoneedit.Enabled = False
                txtfaxedit.Enabled = False
                txtcpedit.Enabled = False
                txtemailedit.Enabled = False
                txttermsedit.Enabled = False
                txttin.Enabled = False
                txtwebsiteedit.Enabled = False
                txtvendortaxedit.Enabled = False
                chbinventorysupplier.Enabled = False

                Button2.Visible = True
                btnsaveedit.Text = "Edit"
                sqlcon.Close()

                btnclearedit.PerformClick()
                Dim dtnew As New DataTable
                sqlda = New MySqlDataAdapter("Select suppliernumber as 'Supplier ID',suppliername as 'Name', supplieraddress as 'Address', supplierzip as 'ZIP Code',supplierphone as 'Phone Number', supplierfax as 'Fax', supplierwebsite as 'Website', suppliercontactperson as 'Contact Person',supplieremail as 'Email', suppliertin as 'TIN', termsofAgreement as 'Terms', vendorTax as 'Vendor Tax', InventorySupplier as 'Inventory Supplier' from suppliers where suppliername like '%" & txtsearchcustomer.Text & "%'", sqlcon)
                sqlda.Fill(dtnew)

                dgveditcustomer.DataSource = dtnew
            End If

        Catch ex As Exception

            Exit Sub

        End Try

    End Sub

    Private Sub txtsearchcustomer_TextChanged(sender As Object, e As EventArgs) Handles txtsearchcustomer.TextChanged
        Dim dtooo As New DataTable
        Dim col As New AutoCompleteStringCollection

        dtooo.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            'sqlda = New MySqlDataAdapter("Select  customername as 'Name' from customers where customername like '%' '" & txtsearchcustomer.Text & "' '%'", sqlcon)
            'sqlda.Fill(dtooo)


            'Dim i As Integer

            'For i = 0 To dtooo.Rows.Count - 1
            '    col.Add(dtooo.Rows(i).Item(0).ToString)
            'Next

            'txtsearchcustomer.AutoCompleteCustomSource = col


            Dim dt9 As New DataTable


            sqlda = New MySqlDataAdapter("Select suppliernumber as 'Supplier ID',suppliername as 'Name', supplieraddress as 'Address', supplierzip as 'Zip',supplierphone as 'Phone Number', supplierfax as 'Fax', supplierwebsite as 'Website', suppliercontactperson as 'Contact Person',supplieremail as 'Email', suppliertin as 'Tin', termsofAgreement as 'Terms', vendorTax as 'Vendor Tax', InventorySupplier as 'Inventory Supplier' from suppliers where suppliername like '%" & txtsearchcustomer.Text & "%'", sqlcon)
            sqlda.Fill(dt9)

            dgveditcustomer.DataSource = dt9

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphoneedit.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtcontactperson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcpedit.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing
        End Select
    End Sub
    Private Sub txtzip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtzipedit.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub
    Private Sub txttin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttin.KeyPress
        If istinformat = False Then
            e.Handled = True
        End If
        If txttin.Text.Count = 3 OrElse txttin.Text.Count = 7 OrElse txttin.Text.Count = 11 Then
            If backspacepressed = False Then
                txttin.Text += "-"
                txttin.SelectionStart = txttin.TextLength + 1
            End If
        End If
    End Sub
    Private Sub txtfax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfaxedit.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub
    Private Sub txtTerms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttermsedit.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub MaterialFlatButton3_Click_1(sender As Object, e As EventArgs)



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txttin_KeyDown(sender As Object, e As KeyEventArgs) Handles txttin.KeyDown
        istinformat = False

        If (e.KeyCode > 47 And e.KeyCode < 58) Or (e.KeyCode > 95 And e.KeyCode < 106) Then
            If Control.ModifierKeys <> Keys.Shift Then
                istinformat = True
            End If
        End If

        backspacepressed = False
        If (e.KeyCode = Keys.Back) Then
            istinformat = True
            backspacepressed = True
        End If
    End Sub

    Private Sub txtidedit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidedit.KeyPress

    End Sub

    Private Sub txtidedit_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidedit.KeyDown

    End Sub

    Private Sub txttinedit_KeyDown(sender As Object, e As KeyEventArgs) Handles txttin.KeyDown
        istinformat = False

        If (e.KeyCode > 47 And e.KeyCode < 58) Or (e.KeyCode > 95 And e.KeyCode < 106) Then
            If Control.ModifierKeys <> Keys.Shift Then
                istinformat = True
            End If
        End If

        backspacepressed = False
        If (e.KeyCode = Keys.Back) Then
            istinformat = True
            backspacepressed = True
        End If
    End Sub

    Private Sub txttinedit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttin.KeyPress
        If istinformat = False Then
            e.Handled = True
        End If
        If txttin.Text.Count = 3 OrElse txttin.Text.Count = 7 OrElse txttin.Text.Count = 11 Then
            If backspacepressed = False Then
                txttin.Text += "-"
                txttin.SelectionStart = txttin.TextLength + 1
            End If
        End If
    End Sub

    Private Sub MaterialFlatButton3_Click_2(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
        Try

            Dim isInventory As Integer
            If txtSTax.Text = "" Then
                MessageBox.Show("Please Select Tax", "Zamaryan System", MessageBoxButtons.OK, MessageBoxIcon.Error)


            else


            If chkInventorySupplier.Checked = True Then
                isInventory = 1
            Else
                isInventory = 0
            End If


            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String
            Dim dt As New DataTable


            qry = "Select *  from suppliers where suppliername ='" & txtSname.Text & "'"
            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt)

            If dt.Rows.Count = 1 Then
                MessageBox.Show("Supplier exists in the database", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                sqlcon.Close()
                Exit Sub
            End If


            Dim i As Integer

            i = MessageBox.Show("Are you sure you want to save this supplier?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If i = vbNo Then
                Exit Sub

            End If

            Dim qry2 As String

                qry2 = "Insert into suppliers(suppliername,supplieraddress,supplierzip,supplierphone,supplierfax,supplierwebsite,suppliercontactperson,supplieremail,suppliertin,termsofAgreement,vendorTax,InventorySupplier,suppliernumber) values ('" &
                txtSname.Text & "','" & txtSaddress.Text & "','" & txtSzip.Text & "','" & txtsNumber.Text & "','" & txtSFax.Text & "','" & txtSWebsite.Text & "','" & txtSCperson.Text & "','" & txtSEmail.Text & "','" & txtSTin.Text & "','" & txtSTerms.Text & "','" & txtSTax.Text & "','" & isInventory & "','" & txtSupplierCode.Text & "')"
            sqlcmd = New MySqlCommand(qry2, sqlcon)
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Information successfully uploaded!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnClearItem.PerformClick()
            End If

        Catch ex As Exception
            MessageBox.Show("Please check your inputs", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            sqlcon.Close()
        End Try
        txtSTax.Text = Nothing
        sup()

        getsupplier()

        'Dim su = ExecuteScalar("select max(suppliernumber) from suppliers")
        'txtSupplierCode.Text = ("SU" & If(IsDBNull(su), "100001", Format(Mid(su, 3, 9)) + 1))

    End Sub

    Public Function getsupplier()
        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            sqlda = New MySqlDataAdapter("select max(suppliernumber) from suppliers", sqlcon)
            Dim dtmax As New DataTable

            sqlda.Fill(dtmax)

            Dim i As Integer
            For i = 0 To dtmax.Rows.Count - 1

                txtSupplierCode.Text = (If(IsDBNull(dtmax.Rows(i).Item(0)), "SU10001", "SU" & Format(Mid(dtmax.Rows(i).Item(0), 3, 9)) + 1))

            Next



        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            sqlcon.Close()

        End Try


        Return txtSupplierCode

    End Function

    Private Sub txttin_Click(sender As Object, e As EventArgs) Handles txttin.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtidedit_Click(sender As Object, e As EventArgs) Handles txtidedit.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        tangina = True
        forpassword.ShowDialog()


    End Sub

    Private Sub txtSTerms_Click(sender As Object, e As EventArgs) Handles txtSTerms.Click

    End Sub

    Private Sub lvSuppliers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSuppliers.SelectedIndexChanged

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub MaterialFlatButton1_Click_1(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        viewreportsupplier.Show()

    End Sub

    Private Sub TabPage3_Click_1(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        tangina = True
        forpassword.ShowDialog()
    End Sub

    Private Sub txtsearchcustomer_Click(sender As Object, e As EventArgs) Handles txtsearchcustomer.Click

    End Sub
End Class