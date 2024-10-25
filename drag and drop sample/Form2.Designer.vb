<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.rbStudent = New System.Windows.Forms.RadioButton()
        Me.rbCounselor = New System.Windows.Forms.RadioButton()
        Me.rbDirector = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(71, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sign Up"
        '
        'txtUsername
        '
        Me.txtUsername.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsername.Location = New System.Drawing.Point(133, 85)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(121, 20)
        Me.txtUsername.TabIndex = 6
        Me.txtUsername.Text = "Username"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(42, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 24)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Create Account"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.Location = New System.Drawing.Point(6, 111)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(121, 20)
        Me.txtPassword.TabIndex = 11
        Me.txtPassword.Text = "Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtConfirmPassword.Location = New System.Drawing.Point(133, 111)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(123, 20)
        Me.txtConfirmPassword.TabIndex = 12
        Me.txtConfirmPassword.Text = "Confirm Password"
        '
        'txtFullname
        '
        Me.txtFullname.ForeColor = System.Drawing.Color.DimGray
        Me.txtFullname.Location = New System.Drawing.Point(6, 85)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(121, 20)
        Me.txtFullname.TabIndex = 15
        Me.txtFullname.Text = "Full Name"
        '
        'rbStudent
        '
        Me.rbStudent.AutoSize = True
        Me.rbStudent.BackColor = System.Drawing.Color.Transparent
        Me.rbStudent.Location = New System.Drawing.Point(70, 142)
        Me.rbStudent.Name = "rbStudent"
        Me.rbStudent.Size = New System.Drawing.Size(62, 17)
        Me.rbStudent.TabIndex = 16
        Me.rbStudent.TabStop = True
        Me.rbStudent.Text = "Student"
        Me.rbStudent.UseVisualStyleBackColor = False
        '
        'rbCounselor
        '
        Me.rbCounselor.AutoSize = True
        Me.rbCounselor.BackColor = System.Drawing.Color.Transparent
        Me.rbCounselor.Location = New System.Drawing.Point(138, 142)
        Me.rbCounselor.Name = "rbCounselor"
        Me.rbCounselor.Size = New System.Drawing.Size(72, 17)
        Me.rbCounselor.TabIndex = 17
        Me.rbCounselor.TabStop = True
        Me.rbCounselor.Text = "Counselor"
        Me.rbCounselor.UseVisualStyleBackColor = False
        '
        'rbDirector
        '
        Me.rbDirector.AutoSize = True
        Me.rbDirector.BackColor = System.Drawing.Color.Transparent
        Me.rbDirector.Location = New System.Drawing.Point(100, 165)
        Me.rbDirector.Name = "rbDirector"
        Me.rbDirector.Size = New System.Drawing.Size(62, 17)
        Me.rbDirector.TabIndex = 18
        Me.rbDirector.TabStop = True
        Me.rbDirector.Text = "Director"
        Me.rbDirector.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(257, 255)
        Me.Controls.Add(Me.rbDirector)
        Me.Controls.Add(Me.rbCounselor)
        Me.Controls.Add(Me.rbStudent)
        Me.Controls.Add(Me.txtFullname)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form2"
        Me.Text = "Signup "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtFullname As TextBox
    Friend WithEvents rbStudent As RadioButton
    Friend WithEvents rbCounselor As RadioButton
    Friend WithEvents rbDirector As RadioButton
End Class
