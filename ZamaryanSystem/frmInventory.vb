Imports MySql.Data.MySqlClient
Imports MySql.Data


Public Class frmInventory

    Dim sqlcon As New MySqlConnection
    Dim sqlda As New MySqlDataAdapter
    Dim sqlcmd As New MySqlCommand

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        btnClearItem.PerformClick()
        lvInventory.Items.Clear()
        Me.Close()
    End Sub


    Public Function getInventory()

        lvInventory.Items.Clear()

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "Select * from items"

            Dim dtk As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dtk)

            Dim i As Integer

            While i <= dtk.Rows.Count - 1
                Dim itm As ListViewItem

                itm = lvInventory.Items.Add(dtk.Rows(i).Item(1))
                itm.SubItems.Add(dtk.Rows(i).Item(2))
                itm.SubItems.Add(dtk.Rows(i).Item(3))
                itm.SubItems.Add(dtk.Rows(i).Item(8))
                itm.SubItems.Add(dtk.Rows(i).Item(7))
                itm.SubItems.Add(FormatNumber(dtk.Rows(i).Item(5)))

                i += 1

            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            sqlcon.Close()

        End Try

        Return lvInventory


    End Function
    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        getInventory()

    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton4.Click

        For Each control As Control In TabPage2.Controls
            If TypeOf control Is MaterialSkin.Controls.MaterialSingleLineTextField Then
                If String.IsNullOrWhiteSpace(control.Text) Then
                    MsgBox("All fields must be filled out.")
                    Exit Sub
                End If
            End If
        Next

        Dim vatable As String


        If CInt(txtMinStocksItem.Text) < 1 Then
            MessageBox.Show("There has to be a minimum stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        If CInt(txtQuantityItem.Text) > CInt(txtMaxStocksItem.Text) Then
            MessageBox.Show("The quantity stock cannot be greater than maximum stocks", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        If CInt(txtMaxStocksItem.Text) = CInt(txtMinStocksItem.Text) Then
            MessageBox.Show("The maximum stock cannot be equal to minimum stocks", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        If CInt(txtMaxStocksItem.Text) < CInt(txtMinStocksItem.Text) Then
            MessageBox.Show("The maximum stock cannot be less than minimum stocks", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        txtSellingPriceItem.Text = txtSellingPriceItem.Text.Replace(",", "")
        txtUnitCostItem.Text = txtUnitCostItem.Text.Replace(",", "")

        Dim i As Integer

        i = MessageBox.Show("Are you sure you want to save this data?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbNo Then
            Exit Sub

        End If

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "SELECT * FROM items WHERE itemid = '" & txtItemCodeItem.Text & "'"

            Dim dt As New DataTable

            If chkVat.Checked = True Then
                vatable = "NO"
            Else
                vatable = "YES"
            End If

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt)

            If dt.Rows.Count = 1 Then

                MessageBox.Show("Item already exist in the database", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                sqlcon.Close()
                Exit Sub

            End If

            Dim qty, quota, maxquota As Integer
            Dim itemid, description, uom As String
            Dim selling, runningBalance, cost As Double


            uom = txtUOMItem.Text
            qty = txtQuantityItem.Text
            cost = txtUnitCostItem.Text
            quota = txtMinStocksItem.Text
            selling = txtSellingPriceItem.Text
            maxquota = txtMaxStocksItem.Text


            runningBalance = FormatNumber(qty * cost)

            itemid = txtItemCodeItem.Text
            description = txtDescriptionItem.Text

            Dim sql As String

            sql = "INSERT INTO items(itemid,itemdesc,quantity,sellingPrice,runningBalance,isVatable,quota,maxQuota,unitofmeasurement) VALUES('" &
                itemid & "','" & description & "'," & qty & "," & selling & "," & runningBalance & ",'" & vatable & "'," & quota & "," & txtMaxStocksItem.Text & ",'" & uom & "')"
            sqlcmd = New MySqlCommand(sql, sqlcon)
            sqlcmd.ExecuteNonQuery()

            Dim sql2 As String

            sql2 = "Select max(itemnumber) from items"

            Dim dtx As New DataTable

            sqlda = New MySqlDataAdapter(sql2, sqlcon)
            sqlda.Fill(dtx)

            Dim itemnumber As Integer

            For i = 0 To dtx.Rows.Count - 1

                itemnumber = dtx.Rows(i).Item(0)

                i += 1

            Next

            Dim j As Integer

            While j <= qty - 1

                Dim sql3, isInventory As String

                isInventory = "YES"

                sql3 = "Insert into uniqueitem(itemnumber,cost,isInventory,dateInventory) values (" & itemnumber & "," & cost & ",'" & isInventory & "','" & Format(DateTime.Now, "yyyy-MM-dd hh:mm:ss") & "')"
                sqlcmd = New MySqlCommand(sql3, sqlcon)
                sqlcmd.ExecuteNonQuery()

                j += 1

            End While
            
            Dim qry8 As String

            qry8 = "Insert into journal(journaldesc) values ('To record inventory stock')"
            sqlcmd = New MySqlCommand(qry8, sqlcon)
            sqlcmd.ExecuteNonQuery()

            Dim qry9 As String

            Dim dtqqq As New DataTable
            qry9 = "Select max(journalid) from journal"
            sqlcmd = New MySqlCommand(qry9, sqlcon)
            Dim jid = sqlcmd.ExecuteScalar


            'Capital Stock
            


            Dim ucost As Double
            Dim quant As Integer
            Dim entryCost As Double


            ucost = CDbl(txtUnitCostItem.Text)
            quant = CInt(txtQuantityItem.Text)

            entryCost = ucost * quant

            Dim qry10 As String

            qry10 = "Select accountid from chartofaccounts where accountname ='Capital Stock'"

            sqlcmd = New MySqlCommand(qry10, sqlcon)
            Dim capstock = sqlcmd.ExecuteScalar

            Dim capstockNewRun As Double
            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & capstock & "  order by journalentryid desc limit 1 ", sqlcon)
            Dim val1 = sqlcmd.ExecuteScalar

            capstockNewRun = val1 - entryCost

            Dim qry11 As String

            qry11 = "Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values (" & jid & ",'" & Format(Date.Now, "yyyy-MM-dd") & "'," & capstock & ",0," & entryCost & ",'Inventory Capital','" & txtItemCodeItem.Text & "' ," & capstockNewRun & ")"

            sqlcmd = New MySqlCommand(qry11, sqlcon)
            sqlcmd.ExecuteNonQuery()

            '==============End Capital Stock======================'


            'Inventory Asset
            '------------------------------------
            Dim qry15 As String

            qry15 = "Select accountid from chartofaccounts where accountname ='Inventory'"

            sqlcmd = New MySqlCommand(qry15, sqlcon)
            Dim invent = sqlcmd.ExecuteScalar

            Dim capStockInventory As Double
            sqlcmd = New MySqlCommand("Select ifnull(runningBal,0) from journalentry where accountid = " & invent & "  order by journalentryid desc limit 1 ", sqlcon)
            Dim val2 = sqlcmd.ExecuteScalar

            capStockInventory = val2 + entryCost


            Dim qry12 As String

            qry12 = "Insert into journalentry(journalid,journaldate,accountid,journaldebit,journalcredit,source,source2,runningBal) values ('" & jid & "','" & Format(Date.Now, "yyyy-MM-dd") & "','" & invent & "','" & entryCost & "','0','Inventory Capital','" & txtItemCodeItem.Text & "','" & capStockInventory & "')"

            sqlcmd = New MySqlCommand(qry12, sqlcon)
            sqlcmd.ExecuteNonQuery()

            '===============End Inventory=================='


            MessageBox.Show("Information Successfully uploaded!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            sqlcon.Close()
            btnClearItem.PerformClick()
            Dim ic = ExecuteScalar("select max(itemid) from items")
            txtItemCodeItem.Text = ("IC" & If(IsDBNull(ic), "100001", Format(Mid(ic, 3, 9)) + 1))
        End Try

        getInventory()

    End Sub

    Private Sub MaterialFlatButton3_Click(sender As Object, e As EventArgs) Handles btnClearItem.Click

        txtDescriptionItem.Clear()
        txtMaxStocksItem.Clear()
        txtMinStocksItem.Clear()
        txtQuantityItem.Clear()
        txtSellingPriceItem.Clear()
        txtUnitCostItem.Clear()
        txtUOMItem.Clear()
        chkVat.Checked = False

    End Sub

    Private Sub txtItemCodeEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemCodeEdit.KeyPress
        PerformSearch()
    End Sub

    Private Sub MaterialFlatButton3_Click_1(sender As Object, e As EventArgs) Handles btnSaveEdit.Click
        txtEditSellingPrice.Text = txtEditSellingPrice.Text.Replace(",", "")
        If btnSaveEdit.Text = "Edit" Then
            Try
                txtItemIDtoEdit.Text = dgvEditItems.SelectedCells.Item(0).Value
                txtDescriptionEdit.Text = dgvEditItems.SelectedCells.Item(2).Value
                txtMaximumStocksEdit.Text = dgvEditItems.SelectedCells.Item(5).Value
                txtMinimumStocksEdit.Text = dgvEditItems.SelectedCells.Item(4).Value
                txtEditSellingPrice.Text = dgvEditItems.SelectedCells.Item(3).Value

            Catch ex As Exception
                MessageBox.Show("Please select item code", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub

            End Try

            BunifuTransition1.HideSync(dgvEditItems, True, BunifuAnimatorNS.Animation.Leaf)
            BunifuTransition1.ShowSync(pnlEditInventory, False, BunifuAnimatorNS.Animation.Leaf)
            Label6.Visible = False
            txtItemCodeEdit.Visible = False
            Panel6.Visible = True
            btnSaveEdit.Text = "Save"

        ElseIf btnSaveEdit.Text = "Save" Then
            Dim k As Integer

            k = MessageBox.Show("Are you sure you want to update this information?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If k = vbNo Then
                Exit Sub

            End If
            Try
                sqlcon.ConnectionString = strconnection()
                sqlcon.Open()

                Dim qry As String

                qry = "Update items set itemdesc ='" & txtDescriptionEdit.Text & "' where itemnumber = " & txtItemIDtoEdit.Text
                sqlcmd = New MySqlCommand(qry, sqlcon)
                sqlcmd.ExecuteNonQuery()

                Dim qry1 As String

                qry1 = "Update items set sellingPrice = " & txtEditSellingPrice.Text & " where itemnumber = " & txtItemIDtoEdit.Text
                sqlcmd = New MySqlCommand(qry1, sqlcon)
                sqlcmd.ExecuteNonQuery()

                Dim qry2 As String

                qry2 = "Update items set quota =" & txtMinimumStocksEdit.Text & " where itemnumber = " & txtItemIDtoEdit.Text
                sqlcmd = New MySqlCommand(qry2, sqlcon)
                sqlcmd.ExecuteNonQuery()

                Dim qry3 As String

                qry3 = "Update items set maxQuota = " & txtMaximumStocksEdit.Text & " where itemnumber = " & txtItemIDtoEdit.Text
                sqlcmd = New MySqlCommand(qry3, sqlcon)
                sqlcmd.ExecuteNonQuery()

                MessageBox.Show("Information successfully updated!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)



                BunifuTransition1.ShowSync(dgvEditItems, True, BunifuAnimatorNS.Animation.Leaf)
                BunifuTransition1.HideSync(pnlEditInventory, False, BunifuAnimatorNS.Animation.Leaf)
                Label6.Visible = True
                txtItemCodeEdit.Visible = True
                txtDescriptionEdit.Enabled = False
                txtEditSellingPrice.Enabled = False
                txtMaximumStocksEdit.Enabled = False
                txtMinimumStocksEdit.Enabled = False
                Button2.Visible = True
                Panel6.Visible = False
                btnSaveEdit.Text = "Edit"
                PerformSearch()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                sqlcon.Close()
                btnClearEdit.PerformClick()
            End Try


        End If
    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles btnClearEdit.Click
        '  dgvEditItems.Visible = True
        '  pnlEditInventory.Visible = False
        dgvEditItems.Visible = True
        pnlEditInventory.Visible = False
        Label6.Visible = True
        txtItemCodeEdit.Visible = True
        Dim control As Control

        For Each control In Panel1.Controls
            If (control.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(control, TextBox)
                textbox.Clear()
            End If
        Next

        txtDescriptionEdit.Enabled = False
        txtEditSellingPrice.Enabled = False
        txtMaximumStocksEdit.Enabled = False
        txtMinimumStocksEdit.Enabled = False
        Button2.Visible = True
        Panel6.Visible = False
        btnSaveEdit.Text = "Edit"
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub frmInventory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Enabled = True
        frmMain.Focus()


    End Sub

    Private Sub txtQuantityItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityItem.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtSellingPriceItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSellingPriceItem.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtUnitCostItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitCostItem.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtMaxStocksItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaxStocksItem.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub
    Private Sub txtMinStocksItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinStocksItem.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub
    Private Sub txtUOMItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUOMItem.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtEditSellingPrice_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtMaximumStocksEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaximumStocksEdit.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub txtMinimumStocksEdit_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub

    Private Sub lvInventory_DoubleClick(sender As Object, e As EventArgs) Handles lvInventory.DoubleClick

        Try

            Dim itemcode As String

            itemcode = lvInventory.SelectedItems.Item(0).Text
            frmDetailedItems.lblItemCode.Text = itemcode

            frmDetailedItems.Focus()
            frmDetailedItems.Show()

        Catch ex As Exception

            Exit Sub

        End Try

    End Sub

    Private Sub tabEdit_Click(sender As Object, e As EventArgs) Handles tabEdit.Click

    End Sub

    Private Sub txtEditSellingPrice_TextChanged(sender As Object, e As EventArgs)
        CurrencyFormat(txtEditSellingPrice)
    End Sub

    Private Sub txtItemCodeEdit_Click(sender As Object, e As EventArgs) Handles txtItemCodeEdit.Click

    End Sub

    Private Sub MaterialFlatButton3_Click_2(sender As Object, e As EventArgs) Handles Button2.Click

        forpassword.ShowDialog()
        For Each control As Control In pnlEditInventory.Controls
            If TypeOf control Is TextBox Then
                If String.IsNullOrWhiteSpace(control.Text) Then
                    MsgBox("All fields must be filled out.")
                    Exit Sub
                End If
            End If
        Next

        'If txtMinimumStocksEdit.Text < 1 Then
        '    MessageBox.Show("There has to be a minimum stock", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        '    Exit Sub
        'End If

        'If txtMaximumStocksEdit.Text = txtMinimumStocksEdit.Text Then
        '    MessageBox.Show("The maximum stock cannot be equal to minimum stocks", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        '    Exit Sub
        'End If

        'If txtMaximumStocksEdit.Text > txtMinimumStocksEdit.Text Then
        '    MessageBox.Show("The maximum stock cannot be less than minimum stocks", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        '    Exit Sub
        'End If



    End Sub

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ic = ExecuteScalar("select max(itemid) from items")
        txtItemCodeItem.Text = ("IC" & If(IsDBNull(ic), "100001", Format(Mid(ic, 3, 9)) + 1))

    End Sub

    Private Sub txtSellingPriceItem_TextChanged(sender As Object, e As EventArgs) Handles txtSellingPriceItem.TextChanged
        CurrencyFormat(txtSellingPriceItem)
    End Sub

    Private Sub txtUnitCostItem_TextChanged(sender As Object, e As EventArgs) Handles txtUnitCostItem.TextChanged
        CurrencyFormat(txtUnitCostItem)
    End Sub

    Private Sub PerformSearch()
        Try
            If sqlcon.State = ConnectionState.Closed Then
                sqlcon.ConnectionString = strconnection()
                sqlcon.Open()
            End If

            'Dim qry As String
            'Dim dt1 As New DataTable

            'Dim col As New AutoCompleteStringCollection

            'qry = "Select itemid from items"

            'sqlda = New MySqlDataAdapter(qry, sqlcon)
            'sqlda.Fill(dt1)

            'Dim i As Integer

            'For i = 0 To dt1.Rows.Count - 1

            '    col.Add(dt1.Rows(i).Item(0).ToString)
            'Next

            'txtItemCodeEdit.AutoCompleteCustomSource = col

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry1 As String
            Dim dt2 As New DataTable

            qry1 = "Select itemnumber as 'Item ID',itemid as 'Item Code',itemdesc as 'Description',sellingPrice as 'Selling Price',quota as 'Min Stocks',maxQuota as 'Max Stocks' from items where itemid like '%" & txtItemCodeEdit.Text & "%' or itemdesc like '%" & txtItemCodeEdit.Text & "%'"
            sqlda = New MySqlDataAdapter(qry1, sqlcon)
            sqlda.Fill(dt2)

            dgvEditItems.DataSource = dt2

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try
    End Sub

    Private Sub cbitemcolumn_SelectedIndexChanged(sender As Object, e As EventArgs)
        PerformSearch()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub lvInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvInventory.SelectedIndexChanged

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        viewreportitems.Show()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub txtMinimumStocksEdit_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtMinimumStocksEdit.KeyPress

        Select Asc(e.KeyChar)
            Case 8
            Case 13
            Case 47 To 57
            Case Else
                e.KeyChar = Nothing

        End Select
    End Sub
End Class