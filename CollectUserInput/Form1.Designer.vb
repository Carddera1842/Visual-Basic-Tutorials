﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(166, 471)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(368, 246)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(69, 77)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(580, 38)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(77, 19)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(151, 32)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(69, 212)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(580, 38)
        Me.txtLastName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(77, 143)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(150, 32)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(69, 347)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(580, 38)
        Me.txtGender.TabIndex = 5
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(78, 283)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(109, 32)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender"
        '
        'lstOccupation
        '
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.ItemHeight = 31
        Me.lstOccupation.Items.AddRange(New Object() {"Doctor", "Programmer", "Teacher", "Student", "Tinker", "Tailor", "Soldier", "Sailor"})
        Me.lstOccupation.Location = New System.Drawing.Point(778, 202)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(271, 376)
        Me.lstOccupation.TabIndex = 7
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(772, 143)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(159, 32)
        Me.lblOccupation.TabIndex = 8
        Me.lblOccupation.Text = "Occupation"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 1105)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnGo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
End Class
