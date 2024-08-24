Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox4_GotFocus(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
        If TextBox4.Text = "Name" Then
            TextBox4.Text = ""
            TextBox4.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox4_LostFocus(sender As Object, e As EventArgs) Handles TextBox4.LostFocus
        If TextBox4.Text = "" Then
            TextBox4.Text = "Name"
            TextBox4.ForeColor = Color.DimGray

        End If
    End Sub


    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If TextBox1.Text = "Username" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = "" Then
            TextBox1.Text = "Username"
            TextBox1.ForeColor = Color.DimGray

        End If
    End Sub


    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        If TextBox2.Text = "Password" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text = "" Then
            TextBox2.Text = "Password"
            TextBox2.ForeColor = Color.DimGray

        End If
    End Sub


    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        If TextBox3.Text = "Confirm Password" Then
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        If TextBox3.Text = "" Then
            TextBox3.Text = "Confirm Password"
            TextBox3.ForeColor = Color.DimGray

        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class