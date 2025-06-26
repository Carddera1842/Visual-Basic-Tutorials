<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRow = New System.Windows.Forms.Button()
        Me.btnColumn = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRow
        '
        Me.btnRow.Location = New System.Drawing.Point(75, 34)
        Me.btnRow.Name = "btnRow"
        Me.btnRow.Size = New System.Drawing.Size(603, 209)
        Me.btnRow.TabIndex = 0
        Me.btnRow.Text = "Display data items row wise"
        Me.btnRow.UseVisualStyleBackColor = True
        '
        'btnColumn
        '
        Me.btnColumn.Location = New System.Drawing.Point(75, 275)
        Me.btnColumn.Name = "btnColumn"
        Me.btnColumn.Size = New System.Drawing.Size(603, 203)
        Me.btnColumn.TabIndex = 1
        Me.btnColumn.Text = "Display data items column wise"
        Me.btnColumn.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(75, 506)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(603, 193)
        Me.btnAll.TabIndex = 2
        Me.btnAll.Text = "Display all data items at once"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(75, 744)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(603, 193)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search for a person"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 1066)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnColumn)
        Me.Controls.Add(Me.btnRow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRow As Button
    Friend WithEvents btnColumn As Button
    Friend WithEvents btnAll As Button
    Friend WithEvents btnSearch As Button
End Class
