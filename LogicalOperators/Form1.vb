Public Class Form1
    Private Sub btbGrade_Click(sender As Object, e As EventArgs) Handles btbGrade.Click

        Dim iScore As Integer

        If IsNumeric(txtExamScore.Text) = True Then
            iScore = CInt(txtExamScore.Text)
        Else
            MsgBox("You must enter a number")
            Exit Sub
        End If

        If iScore < 0 Or iScore > 100 Then
            MsgBox("That is not a valid score. Enter a number between 0 and 100")
        ElseIf iScore >= 50 Then
            MsgBox("pass")
        ElseIf iScore < 50 Then
            MsgBox("fail")
        End If

        MsgBox("All done")

    End Sub

End Class
