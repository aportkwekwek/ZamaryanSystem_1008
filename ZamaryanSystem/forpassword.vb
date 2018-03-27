Imports MySql.Data.MySqlClient

Public Class forpassword

    Dim con As New MySqlConnection
    Dim com As New MySqlCommand
    Dim dr As MySqlDataReader
    'Dim dt1237 As New DataTable
    ' Dim tweqw As Integer



    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        con.ConnectionString = "server=localhost; uid=root; password=''; database=accountingsystem;convert Zero Datetime=true"
        con.Open()
        com = New MySqlCommand("select username,password from users where password='" & txtpassword.Text & "'", con)
        dr = com.ExecuteReader
        If (dr.Read) Then
            MsgBox("Edit privilege is granted.")
            frmInventory.txtDescriptionEdit.Enabled = True
            frmInventory.txtEditSellingPrice.Enabled = True
            frmInventory.txtMaximumStocksEdit.Enabled = True
            frmInventory.txtMinimumStocksEdit.Enabled = True
            frmInventory.Button2.Visible = False
            If frmCustomers.t = True Then
                frmCustomers.txtaddedit.Enabled = True
                frmCustomers.txtnameedit.Enabled = True
                frmCustomers.txtzipedit.Enabled = True
                frmCustomers.txtnameedit.Enabled = True
                frmCustomers.txtphoneedit.Enabled = True
                frmCustomers.txtfaxedit.Enabled = True
                frmCustomers.txtcpedit.Enabled = True
                frmCustomers.txtemailedit.Enabled = True
                frmCustomers.txttermsedit.Enabled = True
                frmCustomers.txttinedit.Enabled = True
                frmCustomers.Button2.Visible = False
            End If
            If frmSuppliers.tangina = True Then
                frmSuppliers.txtnameedit.Enabled = True
                frmSuppliers.txtaddedit.Enabled = True
                frmSuppliers.txtzipedit.Enabled = True
                frmSuppliers.txtphoneedit.Enabled = True
                frmSuppliers.txtfaxedit.Enabled = True
                frmSuppliers.txtcpedit.Enabled = True
                frmSuppliers.txtemailedit.Enabled = True
                frmSuppliers.txttermsedit.Enabled = True
                frmSuppliers.txttin.Enabled = True
                frmSuppliers.txtwebsiteedit.Enabled = True
                frmSuppliers.txtvendortaxedit.Enabled = True
                frmSuppliers.chbinventorysupplier.Enabled = True
                frmSuppliers.Button2.Visible = False
            End If
        Else
            MsgBox("Wrong password.")
        End If
        con.Close()
        txtpassword.Clear()
        Close()
    End Sub
End Class