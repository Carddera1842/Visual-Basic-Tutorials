Public Class Form1
    Private Sub btbCalculate_Click(sender As Object, e As EventArgs) Handles btbCalculate.Click

        Dim dblNumber1 As Double
        Dim dblNumber2 As Double

        Dim dblResult As Double

        dblNumber1 = txtNumber1.Text
        dblNumber2 = txtNumber2.Text

        dblResult = dblNumber1 + dblNumber2

        MsgBox("Added together: " & vbNewLine & dblResult)

        dblResult = dblNumber1 - dblNumber2

        MsgBox("Subtracted: " & vbNewLine & dblResult)

        dblResult = dblNumber1 * dblNumber2

        MsgBox("Multiplied: " & vbNewLine & dblResult)

        dblResult = dblNumber1 / dblNumber2

        MsgBox("Divided: " & vbNewLine & dblResult)

        dblResult = dblNumber1 ^ dblNumber2

        MsgBox("Exponent: " & vbNewLine & dblResult)

        dblResult = dblNumber1 \ dblNumber2

        MsgBox("Integer Division: " & vbNewLine & dblResult)

        dblResult = dblNumber1 Mod dblNumber2

        MsgBox("Remainder After Division: " & vbNewLine & dblResult)

    End Sub

End Class
