Imports MySql.Data.MySqlClient
Imports MaterialSkin.MaterialSkinManager
Imports MaterialSkin


Public Class frmLogin

    Dim sqlcon As New MySqlConnection
    Dim sqlda As New MySqlDataAdapter
    Dim sqlcmd As New MySqlCommand
    Dim s As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub MaterialFlatButton2_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try

            sqlcon.ConnectionString = strconnection()
            sqlcon.Open()


            Dim qry As String

            qry = "Select * from users where username='" & txtUsername.Text & "' and password ='" & txtPassword.Text & "'"

            Dim dt As New DataTable

            sqlda = New MySqlDataAdapter(qry, sqlcon)
            sqlda.Fill(dt)

            If dt.Rows.Count = 1 Then


                MessageBox.Show("Welcome " & dt.Rows(0).Item(3), "Zamaryan Holdings", MessageBoxButtons.OK, MessageBoxIcon.Information)

                TextBox1.Text = dt.Rows(0).Item(3)
                TextBox2.Text = dt.Rows(0).Item(0)

                s = TextBox1.Text
                txtUsername.Clear()
                txtPassword.Clear()

                Me.Hide()
                btnCancel.PerformClick()
                SplashScreen.Show()


            Else

                MessageBox.Show("Incorrect username or password", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        Finally

            sqlcon.Close()

        End Try
        
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        'BunifuTransition1.TimeStep = 0.01

        'If pnlLogin.Visible = True Then

        '    BunifuTransition1.HideSync(pnlLogin, True, BunifuAnimatorNS.Animation.Particles)
        '    BunifuTransition1.ShowSync(pnlZamaryan, True, BunifuAnimatorNS.Animation.Rotate)


        'ElseIf pnlLogin.Visible = False Then

        '    BunifuTransition1.ShowSync(pnlLogin, True, BunifuAnimatorNS.Animation.Rotate)
        '    BunifuTransition1.HideSync(pnlZamaryan, True, BunifuAnimatorNS.Animation.Rotate)

        'End If
    End Sub

    Private Sub pnlLogin_Paint(sender As Object, e As PaintEventArgs) Handles pnlLogin.Paint


    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        txtUsername.Clear()
        txtPassword.Clear()
        Me.Close()
        frmCheat.Show()


    End Sub

End Class
