Public Class Form4
    ' Declare variables
    Private currentMonth As Integer = DateTime.Now.Month
    Private currentYear As Integer = DateTime.Now.Year
    Private eventsDict As New Dictionary(Of DateTime, String)
    Private occupiedSlots As New Dictionary(Of DateTime, List(Of String))

    ' Form Load event
    Private Sub AppointmentCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup the DataGridView to display calendar days
        SetupCalendar()
        LoadMonthCalendar(currentMonth, currentYear)

        ' Populate ComboBox with available appointment times (10 AM - 5 PM)
        For hour As Integer = 10 To 11 ' From 10 AM to 11 AM, 11 AM to 12 PM
            Dim startTime As String = $"{hour}:00 AM"
            Dim endTime As String = If(hour = 11, "12:00 PM", $"{hour + 1}:00 AM") ' Correct transition from AM to PM
            ComboBoxTime.Items.Add($"{startTime} - {endTime}")
        Next

        ' Add 12 PM to 1 PM
        ComboBoxTime.Items.Add("12:00 PM - 1:00 PM")

        ' Populate the PM times from 1 PM to 5 PM
        For hour As Integer = 1 To 4 ' From 1 PM to 5 PM
            Dim startTime As String = $"{hour}:00 PM"
            Dim endTime As String = $"{hour + 1}:00 PM"
            ComboBoxTime.Items.Add($"{startTime} - {endTime}")
        Next
    End Sub


    ' Setup the DataGridView columns and rows to represent the days of the week
    Private Sub SetupCalendar()
        DataGridView1.ColumnCount = 7
        DataGridView1.Columns(0).Name = "Sun"
        DataGridView1.Columns(1).Name = "Mon"
        DataGridView1.Columns(2).Name = "Tue"
        DataGridView1.Columns(3).Name = "Wed"
        DataGridView1.Columns(4).Name = "Thu"
        DataGridView1.Columns(5).Name = "Fri"
        DataGridView1.Columns(6).Name = "Sat"

        DataGridView1.RowTemplate.Height = 50
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.RowCount = 6
    End Sub

    ' Load the calendar for the current month and year
    Private Sub LoadMonthCalendar(month As Integer, year As Integer)
        DataGridView1.Rows.Clear()
        DataGridView1.Rows.Add(6) ' Add 6 rows to accommodate all possible weeks in a month

        Dim firstDay As New DateTime(year, month, 1)
        Dim daysInMonth As Integer = DateTime.DaysInMonth(year, month)
        Dim startDayOfWeek As Integer = CInt(firstDay.DayOfWeek)

        Dim currentDay As Integer = 1
        For row As Integer = 0 To 5
            For col As Integer = 0 To 6
                If row = 0 And col < startDayOfWeek Then
                    DataGridView1(col, row).Value = ""
                    DataGridView1(col, row).ReadOnly = True
                ElseIf currentDay <= daysInMonth Then
                    Dim currentDate As New DateTime(year, month, currentDay)
                    Dim displayText As String = currentDay.ToString()

                    ' Check if the date is occupied
                    If eventsDict.ContainsKey(currentDate) Then
                        displayText &= vbCrLf & "Occupied" ' Add "Occupied" on a new line

                        ' Set background shading for the occupied date
                        DataGridView1(col, row).Style.BackColor = Color.LightGray

                        ' Set the font style for "Occupied"
                        Dim occupiedFont As New Font("Arial", 9, FontStyle.Bold)
                        DataGridView1(col, row).Style.Font = occupiedFont

                        ' Set font color to match the shading
                        DataGridView1(col, row).Style.ForeColor = Color.DarkRed
                    End If

                    ' Display the updated text in the cell
                    DataGridView1(col, row).Value = displayText
                    DataGridView1(col, row).ReadOnly = False

                    ' Allow multiline display
                    DataGridView1(col, row).Style.WrapMode = DataGridViewTriState.True
                    DataGridView1(col, row).Style.Alignment = DataGridViewContentAlignment.TopLeft ' Adjust alignment

                    currentDay += 1
                Else
                    DataGridView1(col, row).Value = ""
                    DataGridView1(col, row).ReadOnly = True
                End If
            Next
        Next
    End Sub

    ' Handle cell click event to set an appointment
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedDay As String = DataGridView1.CurrentCell.Value

        If Not String.IsNullOrEmpty(selectedDay) Then
            Dim selectedDate As New DateTime(currentYear, currentMonth, CInt(selectedDay))

            ' Check if the selected date is Saturday or Sunday
            If selectedDate.DayOfWeek = DayOfWeek.Saturday OrElse selectedDate.DayOfWeek = DayOfWeek.Sunday Then
                MessageBox.Show("Scheduling is not allowed on weekends.")
                Return
            End If

            If occupiedSlots.ContainsKey(selectedDate) AndAlso occupiedSlots(selectedDate).Count > 0 Then
                MessageBox.Show("Slot occupied. Choose another date.")
                Return
            End If

            lblSelectedDate.Text = selectedDate.ToString("MMMM d, yyyy")
            ComboBoxTime.Enabled = True ' Enable the time selection
        End If
    End Sub


    ' Book appointment when the button is clicked
    Private Sub btnBookAppointment_Click(sender As Object, e As EventArgs) Handles btnBookAppointment.Click
        Dim selectedDay As String = DataGridView1.CurrentCell.Value

        If Not String.IsNullOrEmpty(selectedDay) Then
            Dim selectedDate As New DateTime(currentYear, currentMonth, CInt(selectedDay))
            Dim selectedTime As String = ComboBoxTime.SelectedItem?.ToString()

            If selectedTime Is Nothing Then
                MessageBox.Show("Please select a time for the appointment.")
                Return
            End If

            If occupiedSlots.ContainsKey(selectedDate) AndAlso occupiedSlots(selectedDate).Contains(selectedTime) Then
                MessageBox.Show("Slot occupied. Choose another date.")
                Return
            End If

            ' Add appointment to events and mark the time as occupied
            Dim appointmentDetails As String = InputBox("Enter appointment details for: " & selectedDate.ToShortDateString(), "Details")

            If Not String.IsNullOrEmpty(appointmentDetails) Then
                eventsDict(selectedDate) = appointmentDetails & vbCrLf & "Time: " & selectedTime
                If Not occupiedSlots.ContainsKey(selectedDate) Then
                    occupiedSlots(selectedDate) = New List(Of String)()
                End If
                occupiedSlots(selectedDate).Add(selectedTime)

                ' Update the calendar display
                LoadMonthCalendar(currentMonth, currentYear)
            End If
        End If
    End Sub

    ' Navigate to the previous month
    Private Sub btnPreviousMonth_Click(sender As Object, e As EventArgs) Handles btnPreviousMonth.Click
        If currentMonth = 1 Then
            currentMonth = 12
            currentYear -= 1
        Else
            currentMonth -= 1
        End If
        LoadMonthCalendar(currentMonth, currentYear)
    End Sub

    ' Navigate to the next month
    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        If currentMonth = 12 Then
            currentMonth = 1
            currentYear += 1
        Else
            currentMonth += 1
        End If
        LoadMonthCalendar(currentMonth, currentYear)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBoxTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTime.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub lblSelectedDate_Click(sender As Object, e As EventArgs) Handles lblSelectedDate.Click

    End Sub
End Class
