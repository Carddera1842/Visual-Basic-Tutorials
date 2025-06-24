Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("course")
        MsgBox("programming")
        MsgBox("VB.NET")
        MsgBox("the")
        MsgBox("to")
        MsgBox("Welcome")

    End Sub
    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Kevin"
        stLastName = "Drumm"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & ". I hope you are well.")

        stFirstName = "Murvin"
        stLastName = "Drake"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & ". I hope you are well.")

    End Sub
    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColor = "red"
        bTaxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #11/2/2020#

        MsgBox("The car is a " & stMake & " " & stModel _
               & vbNewLine & iDoors & " doors" _
               & vbNewLine & stColor & " paint" _
               & vbNewLine & bTaxed _
               & vbNewLine & iEngineSize & " cc" _
               & vbNewLine & decPrice _
               & vbNewLine & dtDateRegistered)

    End Sub

End Class
