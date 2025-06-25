Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim stAge As String
        Dim iAge As Integer

        Do While IsNumeric(stAge) = False
            stAge = InputBox("Please enter your age in years")
        Loop

        'Casting / Explicit Type Conversion
        iAge = CInt(stAge)

        MsgBox("Hello you are " & iAge)

    End Sub

End Class
