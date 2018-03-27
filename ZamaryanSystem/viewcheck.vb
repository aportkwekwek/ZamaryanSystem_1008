Public Class viewcheck
    Public Sub loadCheck(checkDataSet As DataSet)
        Dim check As New Check
        check.SetDataSource(checkDataSet)
        CrystalReportViewer1.ReportSource = check
    End Sub
End Class