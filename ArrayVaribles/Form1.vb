Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        MsgBox(aiData(0) _
                   & vbNewLine & aiData(1) _
                   & vbNewLine & aiData(2) _
                   & vbNewLine & aiData(3) _
                   & vbNewLine & aiData(4))

    End Sub

End Class
