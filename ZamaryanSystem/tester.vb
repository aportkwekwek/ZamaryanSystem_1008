Public Class tester

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sTitle1 As String
        sTitle1 = TextBox1.Text
        Dim frm1 As New viewreportsales(sTitle1)
        frm1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sTitle2 As String
        sTitle2 = TextBox1.Text
        Dim frm2 As New viewpurchasereport(sTitle2)
        frm2.Show()
    End Sub
End Class