Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim iTemperature As Integer
        iTemperature = CInt(txtTemperature.Text)

        Dim iWindSpeed As Integer
        iWindSpeed = 30

        'Can only test one variable at a time
        Select Case iTemperature
            Case Is < 0
                MsgBox("Sub Zero")
                If iTemperature <= 0 And iWindSpeed > 20 Then
                    MsgBox("That will feel realy cold!")
                End If
            Case Is = 0
                MsgBox("Freezing")
                MsgBox("Water will freeze")
                MsgBox(" and you can go skating")
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")
        End Select

    End Sub
End Class
