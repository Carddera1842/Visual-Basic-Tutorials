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
        Me.lblExamination = New System.Windows.Forms.Label()
        Me.txtExamScore = New System.Windows.Forms.TextBox()
        Me.btbGrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblExamination
        '
        Me.lblExamination.AutoSize = True
        Me.lblExamination.Location = New System.Drawing.Point(129, 160)
        Me.lblExamination.Name = "lblExamination"
        Me.lblExamination.Size = New System.Drawing.Size(367, 32)
        Me.lblExamination.TabIndex = 0
        Me.lblExamination.Text = "Enter the examination score"
        '
        'txtExamScore
        '
        Me.txtExamScore.Location = New System.Drawing.Point(531, 161)
        Me.txtExamScore.Name = "txtExamScore"
        Me.txtExamScore.Size = New System.Drawing.Size(257, 38)
        Me.txtExamScore.TabIndex = 1
        '
        'btbGrade
        '
        Me.btbGrade.Location = New System.Drawing.Point(281, 323)
        Me.btbGrade.Name = "btbGrade"
        Me.btbGrade.Size = New System.Drawing.Size(464, 263)
        Me.btbGrade.TabIndex = 2
        Me.btbGrade.Text = "Get Grade"
        Me.btbGrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 1092)
        Me.Controls.Add(Me.btbGrade)
        Me.Controls.Add(Me.txtExamScore)
        Me.Controls.Add(Me.lblExamination)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblExamination As Label
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents btbGrade As Button
End Class
