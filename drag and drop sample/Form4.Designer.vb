﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnPreviousMonth = New System.Windows.Forms.Button()
        Me.btnNextMonth = New System.Windows.Forms.Button()
        Me.lblSelectedDate = New System.Windows.Forms.Label()
        Me.ComboBoxTime = New System.Windows.Forms.ComboBox()
        Me.btnBookAppointment = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(133, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(746, 377)
        Me.DataGridView1.TabIndex = 0
        '
        'btnPreviousMonth
        '
        Me.btnPreviousMonth.Location = New System.Drawing.Point(133, 13)
        Me.btnPreviousMonth.Name = "btnPreviousMonth"
        Me.btnPreviousMonth.Size = New System.Drawing.Size(98, 23)
        Me.btnPreviousMonth.TabIndex = 2
        Me.btnPreviousMonth.Text = "Previous Month"
        Me.btnPreviousMonth.UseVisualStyleBackColor = True
        '
        'btnNextMonth
        '
        Me.btnNextMonth.Location = New System.Drawing.Point(237, 13)
        Me.btnNextMonth.Name = "btnNextMonth"
        Me.btnNextMonth.Size = New System.Drawing.Size(98, 23)
        Me.btnNextMonth.TabIndex = 3
        Me.btnNextMonth.Text = "Next Month"
        Me.btnNextMonth.UseVisualStyleBackColor = True
        '
        'lblSelectedDate
        '
        Me.lblSelectedDate.AutoSize = True
        Me.lblSelectedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDate.Location = New System.Drawing.Point(548, 9)
        Me.lblSelectedDate.Name = "lblSelectedDate"
        Me.lblSelectedDate.Size = New System.Drawing.Size(77, 25)
        Me.lblSelectedDate.TabIndex = 5
        Me.lblSelectedDate.Text = "Month"
        '
        'ComboBoxTime
        '
        Me.ComboBoxTime.FormattingEnabled = True
        Me.ComboBoxTime.Location = New System.Drawing.Point(10, 55)
        Me.ComboBoxTime.Name = "ComboBoxTime"
        Me.ComboBoxTime.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTime.TabIndex = 6
        '
        'btnBookAppointment
        '
        Me.btnBookAppointment.Location = New System.Drawing.Point(10, 83)
        Me.btnBookAppointment.Name = "btnBookAppointment"
        Me.btnBookAppointment.Size = New System.Drawing.Size(117, 23)
        Me.btnBookAppointment.TabIndex = 7
        Me.btnBookAppointment.Text = "Book Appointment"
        Me.btnBookAppointment.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Profile Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(781, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Sign Out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Delete Appointment"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 423)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBookAppointment)
        Me.Controls.Add(Me.ComboBoxTime)
        Me.Controls.Add(Me.lblSelectedDate)
        Me.Controls.Add(Me.btnNextMonth)
        Me.Controls.Add(Me.btnPreviousMonth)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.Text = "Student Tab"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnPreviousMonth As Button
    Friend WithEvents btnNextMonth As Button
    Friend WithEvents lblSelectedDate As Label
    Friend WithEvents ComboBoxTime As ComboBox
    Friend WithEvents btnBookAppointment As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
