Imports MaterialSkin
Imports MySql.Data.MySqlClient
Public Class CheckWriter
    Dim checkno
    Dim generatecheckno = "SELECT LPAD(IFNULL(MAX(checkno)+1,1),10,'0') FROM checks"
    Dim con As New MySqlConnection
    Dim com As New MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        checkno = ExecuteScalar(generatecheckno)
        Text = "Check No." & checkno.ToString
        txtissuer.Text = If(frmLogin.TextBox1.Text <> "", frmLogin.TextBox1.Text, "User is not logged in")
        lblamountinwords.Text = ""
    End Sub

    Private Sub txtamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount.KeyPress

    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged
        'CurrencyFormat(txtamount.Text)
        Try

            txtamount.Text = FormatNumber(txtamount.Text)
            lblamountinwords.Text = AmountInWords(txtamount.Text.Replace(",", ""))
        Catch ex As Exception
            Exit Sub

        End Try
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtamount_Click(sender As Object, e As EventArgs) Handles txtamount.Click

    End Sub

    Private Sub btnHeaderSave_Click(sender As Object, e As EventArgs) Handles btnHeaderSave.Click
        con.ConnectionString = strconnection()
        con.Open()
        com = New MySqlCommand("INSERT INTO checks(checkno,id,date,amount,name,amountinwords) VALUES ('" & checkno & "','" & frmLogin.TextBox2.Text & "','" & dtdate.Value & "','" & txtamount.Text.Replace(",", "") & "','" & txtname.Text & "','" & lblamountinwords.Text & "')", con)
        com.ExecuteNonQuery()
        con.Close()
        Dim checkDataSet = New CheckDataSet
        checkDataSet.Tables(0).Rows.Add(checkno, frmLogin.TextBox2.Text & " - " & frmLogin.TextBox1.Text, dtdate.Value, txtamount.Text.Replace(",", ""), txtname.Text, lblamountinwords.Text)
        viewcheck.loadCheck(checkDataSet)
        viewcheck.Show()
        checkno = ExecuteScalar(generatecheckno)
        Text = "Check No." & checkno.ToString
        txtamount.Clear()
        txtname.Clear()
        lblamountinwords.Text = ""
    End Sub
End Class