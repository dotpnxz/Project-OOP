Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedStatus As String = String.Empty

        ' Check which radio button is selected
        If rbStudent.Checked Then
            selectedStatus = "Student"
        ElseIf rbCounselor.Checked Then
            selectedStatus = "Counselor"
        ElseIf rbDirector.Checked Then
            selectedStatus = "Director"
        Else
            MessageBox.Show("Please select a status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate the input fields
        If String.IsNullOrWhiteSpace(txtFullName.Text) Then
            MessageBox.Show("Full Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFullName.Focus()
            Return
        End If


        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            MessageBox.Show("Please confirm your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmPassword.Focus()
            Return
        End If

        ' Check if the password and confirm password match
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtConfirmPassword.Clear()
            txtPassword.Focus()
            Return
        End If

        If txtPassword.Text.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
            Return
        End If

        ' Proceed with account creation logic here (e.g., saving data to a database)

        ' Show a success message after account creation
        MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Form5.Show()
        Me.Hide()
    End Sub


    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles txtFullname.GotFocus
        If txtFullname.Text = "Full Name" Then
            txtFullname.Text = ""
            txtFullname.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles txtFullname.LostFocus
        If txtFullname.Text = "" Then
            txtFullname.Text = "Full Name"
            txtFullname.ForeColor = Color.DimGray

        End If
    End Sub


    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.DimGray

        End If
    End Sub


    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.DimGray

        End If
    End Sub


    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.GotFocus
        If txtConfirmPassword.Text = "Confirm Password" Then
            txtConfirmPassword.Text = ""
            txtConfirmPassword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles txtConfirmPassword.LostFocus
        If txtConfirmPassword.Text = "" Then
            txtConfirmPassword.Text = "Confirm Password"
            txtConfirmPassword.ForeColor = Color.DimGray

        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtFullname.TextChanged

    End Sub
End Class