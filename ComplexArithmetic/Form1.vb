﻿Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decPrice As Decimal
        Dim iQuantity As Integer
        Dim decDiscount As Decimal
        Dim decPostage As Decimal
        Dim DecTotalCost As Decimal

        decPrice = 5
        iQuantity = 10
        decDiscount = 2
        decPostage = 3

        DecTotalCost = ((decPrice - decDiscount) * iQuantity) + decPostage

        'BODMAS - Brackets Order Division Multiplication Addition Subtraction

        MsgBox(DecTotalCost)

        Dim iResult As Integer
        iResult = 10 - 5 + 2
        MsgBox(iResult)

        iResult = 10 + 2 - 5
        MsgBox(iResult)

        iResult = 10 - 2 + 5
        MsgBox(iResult)



        iResult = 10 / 5 * 2
        MsgBox(iResult)

        iResult = 2 * 10 / 5
        MsgBox(iResult)

        iResult = 10 * 5 / 2
        MsgBox(iResult)

    End Sub

End Class
