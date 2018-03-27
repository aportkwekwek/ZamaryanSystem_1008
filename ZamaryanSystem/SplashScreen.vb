Public Class SplashScreen

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim i As Integer
        i = 0
        While i <= 100
            Threading.Thread.Sleep(10)
            BunifuCircleProgressbar1.Value = i
            BunifuCircleProgressbar1.Update()
            i += 2

        End While

        Timer1.Stop()
        Me.Close()

        frmMain.Show()


    End Sub
End Class