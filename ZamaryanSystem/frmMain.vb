Imports MySql.Data.MySqlClient


Public Class frmMain
    Dim sqlcon As New MySqlConnection
    Dim sqlda As MySqlDataAdapter
    Dim sqlcmd As MySqlCommand

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim i As Integer
        i = MessageBox.Show("Are you sure you want to close the application?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbYes Then
            Me.Close()
            Application.Exit()
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = frmLogin.TextBox1.Text


        getSalesChart()
        loadData()
        getPurchaseChart()
    End Sub

    Public Function getPurchaseChart()

        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry1 As String

            qry1 = "select monthname(purchaseorderdate), sum(total) from purchaseorder where remarks ='Approved' and year(purchaseorderdate) = year(curdate()) group by monthname(purchaseorderdate) order by month(purchaseorderdate) asc"
            Dim dt13x As New DataTable

            sqlda = New MySqlDataAdapter(qry1, sqlcon)
            sqlda.Fill(dt13x)

            Dim j As Integer


            While j <= dt13x.Rows.Count - 1

                Me.Chart3.Series("Purchases").Points.AddXY(dt13x.Rows(j).Item(0), dt13x.Rows(j).Item(1))
                Me.Chart3.ChartAreas(0).AxisX.Interval = 1

                j += 1

            End While


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try

        Return Chart3

    End Function

    Public Function getSalesChart()
      
        Try
            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "select monthname(datesold), sum(total) from salesinvoice where remarks ='Done' or remarks ='Approved' and year(datesold) = year(curdate()) group by monthname(datesold) order by month(datesold) asc"

            Dim dt12x As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt12x)

            Dim i As Integer

            While i <= dt12x.Rows.Count - 1

                Me.Chart1.Series("Sales").Points.AddXY(dt12x.Rows(i).Item(0), dt12x.Rows(i).Item(1))
                i += 1

            End While


            ' ''for purchases
            'Dim qry1 As String

            'qry1 = "select monthname(purchaseorderdate), sum(total) from purchaseorder where remarks ='Approved' and year(purchaseorderdate) = year(curdate()) group by monthname(purchaseorderdate) order by month(purchaseorderdate) asc"
            'Dim dt13x As New DataTable

            'sqlda = New MySqlDataAdapter(qry1, sqlcon)
            'sqlda.Fill(dt13x)

            'Dim j As Integer


            'While j <= dt13x.Rows.Count - 1

            '    Me.Chart1.Series("Purchases").Points.AddXY(dt13x.Rows(j).Item(0), dt13x.Rows(j).Item(1))
            '    Me.Chart1.ChartAreas(0).AxisX.Interval = 1

            '    j += 1

            'End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

        Return Chart1

    End Function
    Public Sub loadData()
      
        Chart2.DataSource = getSecond()

        Chart2.Series("Item Description").XValueMember = "Item Description"
        Chart2.Series("Item Description").YValueMembers = "Total"

    End Sub
    Public Function getSecond() As DataTable

        Dim dtchart As New DataTable

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            qry = "select items.itemdesc as 'Item Description', sum(invoiceitems.quantity) as 'Total' from salesinvoice inner join invoiceitems on salesinvoice.invoiceid = invoiceitems.invoiceid inner join items on invoiceitems.itemnumber = items.itemnumber where year(salesinvoice.datesold) = year(curdate())  group by items.itemdesc order by sum(invoiceitems.quantity) desc limit 5;"

            sqlcmd = New MySqlCommand(qry, sqlcon)
            Dim rdr As MySqlDataReader = sqlcmd.ExecuteReader

            dtchart.Load(rdr)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlcon.Close()

        End Try

        Return dtchart

    End Function
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles BunifuImageButton11.Click
        Dim i As Integer

        i = MessageBox.Show("Are you sure you want to log out?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = vbYes Then
            Me.Close()
            frmLogin.Show()
        Else

            Exit Sub

        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click


        frmCustomers.Show()
        frmCustomers.Focus()
        frmCustomers.Size = New Size(1121, 742)
        frmCustomers.Location = New Point(245, 0)


    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click


        frmInventory.Show()
        frmInventory.Focus()
        frmInventory.Size = New Size(1121, 742)
        frmInventory.Location = New Point(245, 0)


    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click

        frmReports.Show()
        frmReports.Focus()
        frmReports.Size = New Size(1121, 742)
        frmReports.Location = New Point(245, 0)

    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click

        frmPurchases.Show()
        frmPurchases.Focus()
        frmPurchases.Size = New Size(1121, 742)
        frmPurchases.Location = New Point(245, 0)


    End Sub

    Private Sub BunifuImageButton11_Click(sender As Object, e As EventArgs)
        Me.Close()
        frmLogin.Show()

    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs) Handles BunifuImageButton8.Click

        frmJournalEntry.Show()
        frmJournalEntry.Focus()
        frmJournalEntry.Size = New Size(1121, 742)
        frmJournalEntry.Location = New Point(245, 0)

    End Sub

    Private Sub BunifuImageButton9_Click(sender As Object, e As EventArgs) Handles BunifuImageButton9.Click


        frmSales.Show()
        frmSales.Focus()
        frmSales.Size = New Size(1121, 742)
        frmSales.Location = New Point(245, 0)


    End Sub

    Private Sub BunifuImageButton10_Click(sender As Object, e As EventArgs) Handles BunifuImageButton10.Click

        frmEditProfile.Show()
        frmEditProfile.Focus()
        frmEditProfile.Size = New Size(1121, 742)
        frmEditProfile.Location = New Point(245, 0)


    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click


        frmChartofAccounts.Show()
        frmChartofAccounts.Focus()
        frmChartofAccounts.Size = New Size(1121, 742)
        frmChartofAccounts.Location = New Point(245, 0)


    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click


        frmSuppliers.Show()
        frmSuppliers.Focus()
        frmSuppliers.Size = New Size(1121, 742)
        frmSuppliers.Location = New Point(245, 0)

    End Sub

    Private Sub BunifuImageButton12_Click(sender As Object, e As EventArgs) Handles BunifuImageButton12.Click


        frmCashReceipt.Show()
        frmCashReceipt.Focus()
        frmCashReceipt.Size = New Size(1121, 742)
        frmCashReceipt.Location = New Point(245, 0)

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click


        frmCashDisbursement.Show()
        frmCashDisbursement.Focus()
        frmCashDisbursement.Size = New Size(1121, 742)
        frmCashDisbursement.Location = New Point(245, 0)

    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub BunifuImageButton13_Click(sender As Object, e As EventArgs) Handles BunifuImageButton13.Click
        CheckWriter.Show()
    End Sub
End Class