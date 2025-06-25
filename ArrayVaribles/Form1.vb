Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim aiData(4) As Integer
        Dim iTotal As Integer
        Dim dblAverage As Double

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        For i = 0 To 4
            iTotal = iTotal + aiData(i)
        Next

        dblAverage = iTotal / aiData.Length

        MsgBox(dblAverage)

    End Sub

End Class
