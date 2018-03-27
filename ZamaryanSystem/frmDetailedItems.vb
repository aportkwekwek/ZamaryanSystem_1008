Imports MySql.Data.MySqlClient
Public Class frmDetailedItems

    Dim sqlcon As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Dim sqlda As New MySqlDataAdapter

    Private Sub frmDetailedItems_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        lvDetailedItems.Items.Clear()
        frmInventory.Focus()

    End Sub
    Private Sub frmDetailedItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getDetailedItems()

    End Sub

    Public Function getDetailedItems()

        Try

            lvDetailedItems.Items.Clear()

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()

            Dim qry As String

            Dim dt12 As New DataTable


            qry = "select items.itemdesc ,uniqueitem.dateInventory, count(uniqueitem.itemnumber), uniqueitem.cost from uniqueitem inner join items on uniqueitem.itemnumber = items.itemnumber where uniqueitem.isInventory = 'YES' and items.itemid = '" & lblItemCode.Text & "' group by items.itemdesc, cost"
            
            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt12)

            Dim k As Integer
            Dim lvitems As ListViewItem


            While k <= dt12.Rows.Count - 1

                lvitems = lvDetailedItems.Items.Add(dt12.Rows(k).Item(0))
                lvitems.SubItems.Add(dt12.Rows(k).Item(1))
                lvitems.SubItems.Add(dt12.Rows(k).Item(2))
                lvitems.SubItems.Add(FormatNumber(dt12.Rows(k).Item(3)))
                k += 1

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Finally

            sqlcon.Close()


        End Try

        Return lvDetailedItems

    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class