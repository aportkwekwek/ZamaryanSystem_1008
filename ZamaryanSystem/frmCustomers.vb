Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmCustomers

    Dim sqlcon As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim sqlda As New MySqlDataAdapter
    Dim dt As DataTable
    Dim lvi As ListViewItem
    Dim istinformat, backspacepressed As Boolean
    Public t As Boolean
    Private Sub frmCustomers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        frmMain.Enabled = True
        frmMain.Focus()

    End Sub

    Public Function getcustomerid()

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()
            '  Dim cu = ExecuteScalar("select max(customernumber) from customers")

            sqlda = New MySqlDataAdapter("select max(customernumber) from customers", sqlcon)
            Dim dtmax As New DataTable

            sqlda.Fill(dtmax)

            Dim i As Integer
            For i = 0 To dtmax.Rows.Count - 1

                txtCustomerCode.Text = (If(IsDBNull(dtmax.Rows(i).Item(0)), "CU10001", "CU" & Format(Mid(dtmax.Rows(i).Item(0), 3, 9)) + 1))

            Next
               


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            sqlcon.Close()

        End Try


        Return txtCustomerCode

    End Function

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    

        'txtCustomerCode.Text = ("CU" & If(IsDBNull(cu), "100001", Format(Mid(cu, 3, 9)) + 1))

        getcustomerid()

        currenttimer.Start()


    End Sub

    
    Private Function ExecuteScalar(query As String)

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            sqlcmd.CommandText = query
            sqlcmd.Connection = sqlcon


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

        Return 0


    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
       
        sqlcon.Close()
        Me.Close()
        frmMain.Focus()


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
    Public Sub customer()
        lvCustomers.Items.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select customerid,customername,customeraddress,customerzip,customerphone,customercontactperson,customertin from customers"

            Dim dt3 As New DataTable


            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt3)

            Dim lv As New ListViewItem

            Dim i As Integer

            While i <= dt3.Rows.Count - 1

                lv = lvCustomers.Items.Add(dt3.Rows(i).Item(0))
                lv.SubItems.Add(dt3.Rows(i).Item(1))
                lv.SubItems.Add(dt3.Rows(i).Item(2))
                lv.SubItems.Add(dt3.Rows(i).Item(3))
                lv.SubItems.Add(dt3.Rows(i).Item(4))
                lv.SubItems.Add(dt3.Rows(i).Item(5))
                lv.SubItems.Add(dt3.Rows(i).Item(6))

                i += 1

            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try
    End Sub
    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click

        customer()

    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click

        Dim i As Integer

        i = MessageBox.Show("Are you sure you want to save this data?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbNo Then
            Exit Sub

        End If

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select * from customers where customername = '" & txtCompanyProfile.Text & "'"

            Dim dt5 As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt5)

            If dt5.Rows.Count = 1 Then

                MessageBox.Show("The customer is already listed in the database", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                sqlcon.Close()
                Exit Sub

            End If

            Dim sql As String

            sql = "INSERT INTO customers(customername,customeraddress,customerzip,customerphone,customerfax,customercontactperson,customeremail,customertin,termsofAgreement,customernumber) VALUES('" & txtCompanyProfile.Text & "','" & txtCompanyAddress.Text & "','" & txtzip.Text & "', '" & txtPhoneNumber.Text & "', '" & txtfax.Text & "', '" & txtcontactperson.Text & "', '" & txtemail.Text & "', '" & txttin.Text & "','" & txtTerms.Text & "','" & txtCustomerCode.Text & "')"
            sqlcmd = New MySqlCommand(sql, sqlcon)
            sqlcmd.ExecuteNonQuery()

            MessageBox.Show("Information Successfully Saved!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnClearItem.PerformClick()

        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("Please check your inputs!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Finally

            sqlcon.Close()

        End Try
        getcustomerid()

        customer()
        'Dim cu = ExecuteScalar("select max(customerid) from customers")
        'txtCustomerCode.Text = ("CU" & If(IsDBNull(cu), "100001", Format(Mid(cu, 3, 9)) + 1))

    End Sub

    Private Sub btnClearItem_Click(sender As Object, e As EventArgs) Handles btnClearItem.Click

        txtCompanyAddress.Clear()
        txtCompanyProfile.Clear()
        txtcontactperson.Clear()
        txtemail.Clear()
        txtfax.Clear()
        txtPhoneNumber.Clear()
        txtTerms.Clear()
        txttin.Clear()
        txtzip.Clear()



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


            sqlda = New MySqlDataAdapter("Select customernumber as 'Customer ID',customername as 'Name', customeraddress as 'Address', customerzip as 'Zip',customerphone as 'Phone Number', customerfax as 'Fax', customercontactperson as 'Contact Person',customeremail as 'Email', customertin as 'Tin', termsofAgreement as 'Terms' from customers where customername like '%" & txtsearchcustomer.Text & "%'", sqlcon)
            sqlda.Fill(dt9)

            dgveditcustomer.DataSource = dt9

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try



    End Sub

    Private Sub btnsaveedit_Click(sender As Object, e As EventArgs) Handles btnsaveedit.Click
        Try

            If btnsaveedit.Text = "Edit" Then

                BunifuTransition1.HideSync(dgveditcustomer, True, BunifuAnimatorNS.Animation.Leaf)
                BunifuTransition1.ShowSync(pnleditcustomer, False, BunifuAnimatorNS.Animation.Leaf)

                txtidedit.Text = dgveditcustomer.SelectedCells.Item(0).Value 'CUSTOMERNUMBER
                txtnameedit.Text = dgveditcustomer.SelectedCells.Item(1).Value
                txtaddedit.Text = dgveditcustomer.SelectedCells.Item(2).Value
                txtzipedit.Text = dgveditcustomer.SelectedCells.Item(3).Value
                txtphoneedit.Text = dgveditcustomer.SelectedCells.Item(4).Value
                txtfaxedit.Text = dgveditcustomer.SelectedCells.Item(5).Value
                txtcpedit.Text = dgveditcustomer.SelectedCells.Item(6).Value
                txtemailedit.Text = dgveditcustomer.SelectedCells.Item(7).Value
                txttinedit.Text = dgveditcustomer.SelectedCells.Item(8).Value
                txttermsedit.Text = dgveditcustomer.SelectedCells.Item(9).Value

                btnsaveedit.Text = "Save"


            ElseIf btnsaveedit.Text = "Save" Then

                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                sqlcmd = New MySqlCommand("UPDATE customers SET customername='" & txtnameedit.Text & "',customeraddress='" & txtaddedit.Text & "',customerzip='" & txtzipedit.Text & "',customerphone='" & txtphoneedit.Text & "',customerfax='" & txtfaxedit.Text & "',customercontactperson='" & txtcpedit.Text & "',customeremail='" & txtemailedit.Text & "',customertin='" & txttinedit.Text & "',termsofAgreement='" & txttermsedit.Text & "' WHERE customerid='" & txtidedit.Text & "'", sqlcon)
                sqlcmd.ExecuteNonQuery()
                MessageBox.Show("Information updated.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BunifuTransition1.ShowSync(dgveditcustomer, True, BunifuAnimatorNS.Animation.Leaf)
                BunifuTransition1.HideSync(pnleditcustomer, False, BunifuAnimatorNS.Animation.Leaf)
                btnsaveedit.Text = "Edit"
                sqlcon.Close()

                btnclearedit.PerformClick()

                Dim dtnew As New DataTable


                sqlda = New MySqlDataAdapter("Select customerid as 'Customer ID',customername as 'Name', customeraddress as 'Address', customerzip as 'Zip',customerphone as 'Phone Number', customerfax as 'Fax', customercontactperson as 'Contact Person',customeremail as 'Email', customertin as 'Tin', termsofAgreement as 'Terms' from customers where customername like '%" & txtsearchcustomer.Text & "%'", sqlcon)
                sqlda.Fill(dtnew)

                dgveditcustomer.DataSource = dtnew
            End If

        Catch ex As Exception

            Exit Sub

        End Try

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

        txtaddedit.Enabled = False
        txtnameedit.Enabled = False
        txtzipedit.Enabled = False
        txtnameedit.Enabled = False
        txtphoneedit.Enabled = False
        txtfaxedit.Enabled = False
        txtcpedit.Enabled = False
        txtemailedit.Enabled = False
        txttermsedit.Enabled = False
        txttinedit.Enabled = False
        Button2.Visible = True
        Panel6.Visible = False
        btnsaveedit.Text = "Edit"
        MaterialFlatButton3.Text = "Edit"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtcontactperson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontactperson.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
                e.KeyChar = Nothing
        End Select
    End Sub
    Private Sub txtzip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtzip.KeyPress
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
    Private Sub txtfax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfax.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 58
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub
    Private Sub txtTerms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTerms.KeyPress
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


    Private Sub txttinedit_KeyDown(sender As Object, e As KeyEventArgs) Handles txttinedit.KeyDown
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

    Private Sub txttinedit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttinedit.KeyPress
        If istinformat = False Then
            e.Handled = True
        End If
        If txttinedit.Text.Count = 3 OrElse txttinedit.Text.Count = 7 OrElse txttinedit.Text.Count = 11 Then
            If backspacepressed = False Then
                txttinedit.Text += "-"
                txttinedit.SelectionStart = txttinedit.TextLength + 1
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        t = True
        forpassword.ShowDialog()




    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton3.Click
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
                txtcpedit.Text = dgveditcustomer.SelectedCells.Item(6).Value
                txtemailedit.Text = dgveditcustomer.SelectedCells.Item(7).Value
                txttinedit.Text = dgveditcustomer.SelectedCells.Item(8).Value
                txttermsedit.Text = dgveditcustomer.SelectedCells.Item(9).Value
                Panel6.Visible = True
                btnsaveedit.Text = "Save"
                MaterialFlatButton3.Text = "Save"


            ElseIf btnsaveedit.Text = "Save" Then
                Dim k As Integer

                k = MessageBox.Show("Are you sure you want to update this information?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If k = vbNo Then
                    Exit Sub

                End If
                If sqlcon.State = ConnectionState.Closed Then
                    sqlcon.Open()
                End If
                sqlcmd = New MySqlCommand("UPDATE customers SET customername='" & txtnameedit.Text & "',customeraddress='" & txtaddedit.Text & "',customerzip='" & txtzipedit.Text & "',customerphone='" & txtphoneedit.Text & "',customerfax='" & txtfaxedit.Text & "',customercontactperson='" & txtcpedit.Text & "',customeremail='" & txtemailedit.Text & "',customertin='" & txttinedit.Text & "',termsofAgreement='" & txttermsedit.Text & "' WHERE customernumber='" & txtidedit.Text & "'", sqlcon)
                sqlcmd.ExecuteNonQuery()
                MessageBox.Show("Information updated.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BunifuTransition1.ShowSync(dgveditcustomer, True, BunifuAnimatorNS.Animation.Leaf)
                BunifuTransition1.HideSync(pnleditcustomer, False, BunifuAnimatorNS.Animation.Leaf)
                Label26.Visible = True
                txtsearchcustomer.Visible = True
                txtaddedit.Enabled = False
                txtnameedit.Enabled = False
                txtzipedit.Enabled = False
                txtnameedit.Enabled = False
                txtphoneedit.Enabled = False
                txtfaxedit.Enabled = False
                txtcpedit.Enabled = False
                txtemailedit.Enabled = False
                txttermsedit.Enabled = False
                txttinedit.Enabled = False
                Button2.Visible = True
                Panel6.Visible = False
                btnsaveedit.Text = "Edit"
                MaterialFlatButton3.Text = "Edit"
                sqlcon.Close()

                btnclearedit.PerformClick()

                Dim dtnew As New DataTable


                sqlda = New MySqlDataAdapter("Select customernumber as 'Customer ID',customername as 'Name', customeraddress as 'Address', customerzip as 'Zip',customerphone as 'Phone Number', customerfax as 'Fax', customercontactperson as 'Contact Person',customeremail as 'Email', customertin as 'Tin', termsofAgreement as 'Terms' from customers where customername like '%" & txtsearchcustomer.Text & "%'", sqlcon)
                sqlda.Fill(dtnew)

                dgveditcustomer.DataSource = dtnew
            End If

        Catch ex As Exception

            Exit Sub

        End Try
    End Sub

    Private Sub txtTerms_Click(sender As Object, e As EventArgs) Handles txtTerms.Click

    End Sub

    Private Sub MaterialFlatButton3_TextChanged(sender As Object, e As EventArgs) Handles MaterialFlatButton3.TextChanged


    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
        viewreportcustomer.Show()

    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        t = True
        forpassword.ShowDialog()
    End Sub

    Private Sub txtsearchcustomer_Click(sender As Object, e As EventArgs) Handles txtsearchcustomer.Click

    End Sub
End Class
