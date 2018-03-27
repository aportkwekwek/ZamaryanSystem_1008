Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class frmEditProfile

    Dim con As New MySqlConnection
    Dim com As New MySqlCommand
    Dim dr As MySqlDataReader
    Private istinformat, backspacepressed As Boolean
    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmEditProfile_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Enabled = True
        frmMain.Focus()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub frmEditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con.ConnectionString = strconnection()
            con.Open()
            com = New MySqlCommand("select * from companies", con)
            dr = com.ExecuteReader
            While dr.Read
                txtname.Text = dr("companyname")
                txtaddress.Text = dr("companyaddress")
                txtzip.Text = dr("companyzip")
                txtphone.Text = dr("companyphone")
                txtfax.Text = dr("companyfax")
                txtwebsite.Text = dr("companywebsite")
                txtcontactperson.Text = dr("companycontactperson")
                txtemail.Text = dr("companyemail")
                txttin.Text = dr("tin")
                txtcwt.Text = dr("CWT")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub MaterialFlatButton4_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            con.ConnectionString = strconnection()
            con.Open()
            com = New MySqlCommand("update companies set companyname='" & txtname.Text & "', companyaddress='" & txtaddress.Text & "', companyzip='" & txtzip.Text & "', companyphone='" & txtphone.Text & "', companyfax='" & txtfax.Text & "', companywebsite='" & txtwebsite.Text & "', companycontactperson='" & txtcontactperson.Text & "', companyemail='" & txtemail.Text & "', tin='" & txttin.Text & "', CWT='" & txtcwt.Text & "'", con)
            com.ExecuteNonQuery()
            MessageBox.Show("Profile updated.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            btnclear.PerformClick()
        End Try
    End Sub

    Private Sub btnClearItem_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        For Each control As Control In Me.Controls
            If (control.GetType Is GetType(MaterialSkin.Controls.MaterialSingleLineTextField)) Then
                Dim textbox As MaterialSkin.Controls.MaterialSingleLineTextField = CType(control, MaterialSkin.Controls.MaterialSingleLineTextField)
                textbox.Clear()
            End If
        Next
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
End Class