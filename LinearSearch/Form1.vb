Public Class Form1
    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click

        Dim stTarget As String
        Dim stFruit(9) As String
        Dim bFound As Boolean

        stFruit(0) = "Apple"
        stFruit(1) = "Mango"
        stFruit(2) = "Strawberry"
        stFruit(3) = "Banana"
        stFruit(4) = "Tomato"
        stFruit(5) = "Grape"
        stFruit(6) = "Pear"
        stFruit(7) = "Lemon"
        stFruit(8) = "Melon"
        stFruit(9) = "Fig"

        stTarget = InputBox("Which fruit are you looking for?")

        Dim i As Integer

        For i = 0 To 9
            If UCase(stFruit(i)) = UCase(stTarget) Then
                bFound = True
                Exit For
            End If
        Next

        If bFound Then
            MsgBox("Found it!")
        Else
            MsgBox("Not Found")
        End If

    End Sub

End Class
