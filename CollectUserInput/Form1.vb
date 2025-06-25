Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim stFristName As String

        stFristName = InputBox("Please enter your first name")

        MsgBox("Hello " & stFristName)

    End Sub
End Class
