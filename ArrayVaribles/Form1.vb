Public Class Form1

    Private Sub btbEx1_Click(sender As Object, e As EventArgs) Handles btbEx1.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            MsgBox(aiData(i))
        Next

    End Sub

    Private Sub btnEx2_Click(sender As Object, e As EventArgs) Handles btnEx2.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        MsgBox(aiData(0) _
                & vbNewLine & aiData(1) _
                & vbNewLine & aiData(2) _
                & vbNewLine & aiData(3) _
                & vbNewLine & aiData(4)
                )

    End Sub

    Private Sub btnEx3_Click(sender As Object, e As EventArgs) Handles btnEx3.Click

        Dim aiData(4) As Integer
        Dim iTotal As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        For i = 0 To 4
            iTotal = iTotal + aiData(i)
        Next

        MsgBox(iTotal)

    End Sub

    Private Sub btnEx4_Click(sender As Object, e As EventArgs) Handles btnEx4.Click

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

    Private Sub btnEx5_Click(sender As Object, e As EventArgs) Handles btnEx5.Click

        Dim aiData(4) As Integer
        Dim iTotal As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        For i = 0 To 4
            If aiData(i) > 20 Then
                iTotal = iTotal + aiData(i)
            End If
        Next

        MsgBox(iTotal)

    End Sub

    Private Sub btnEx6_Click(sender As Object, e As EventArgs) Handles btnEx6.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iLargest As Integer

        For i = 0 To 4
            If aiData(i) > iLargest Then
                iLargest = aiData(i)
            End If
        Next

        MsgBox(iLargest)

    End Sub

    Private Sub btnEx7_Click(sender As Object, e As EventArgs) Handles btnEx7.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer
        Dim iSmallest As Integer

        iSmallest = aiData(i)

        For i = 0 To 4
            If aiData(i) < iSmallest Then
                iSmallest = aiData(i)
            End If
        Next

        MsgBox(iSmallest)

    End Sub

    Private Sub btnEx8_Click(sender As Object, e As EventArgs) Handles btnEx8.Click

        Dim aiData(4) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer

        For i = 0 To 4
            aiData(i) = aiData(i) * 2
            MsgBox(aiData(i))
        Next

    End Sub
End Class
