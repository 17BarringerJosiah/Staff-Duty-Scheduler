Imports System.IO

Public Class Form1
    ' List of staff members
    Private Staff As New List(Of String)
    ' Dictionary to hold exceptions (staff member -> list of unavailable days)
    Private UnavailableDays As New Dictionary(Of String, List(Of Integer))
    ' Random generator for schedule
    Private rnd As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize DataGridView columns for Date and SD Officer
        dgvSchedule.Columns.Add("Date", "Date (DD-MMM-YY)")
        dgvSchedule.Columns.Add("Officer", "SD Officer")

        ' Automatically load staff names from Personnel.txt on the desktop
        ImportStaffFromDesktop()

        ' Disable controls until staff is loaded
        btnGenerateSchedule.Enabled = Staff.Count > 0
        btnAddException.Enabled = Staff.Count > 0
    End Sub

    ' Function to import staff names from Personnel.txt on the desktop
    Private Sub ImportStaffFromDesktop()
        Try
            ' Get the path to the desktop
            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim staffFilePath As String = Path.Combine(desktopPath, "Personnel.txt")

            ' Ensure the file exists before trying to load
            If File.Exists(staffFilePath) Then
                ' Clear existing staff and exceptions
                Staff.Clear()
                UnavailableDays.Clear()
                cmbStaffMembers.Items.Clear()

                ' Read staff names from the text file
                For Each line As String In File.ReadLines(staffFilePath)
                    Dim staffMember As String = line.Trim()
                    If Not String.IsNullOrEmpty(staffMember) Then
                        Staff.Add(staffMember)
                        UnavailableDays(staffMember) = New List(Of Integer)() ' Initialize empty list of unavailable days
                        cmbStaffMembers.Items.Add(staffMember) ' Add to ComboBox for exceptions
                    End If
                Next

                If Staff.Count > 0 Then
                    MessageBox.Show("Staff loaded successfully from Personnel.txt on your desktop.")
                Else
                    MessageBox.Show("No staff names found in Personnel.txt.")
                End If
            Else
                MessageBox.Show("The file 'Personnel.txt' was not found on your desktop.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading the staff: " & ex.Message)
        End Try
    End Sub

    ' Button to generate the schedule for the selected month
    Private Sub btnGenerateSchedule_Click(sender As Object, e As EventArgs) Handles btnGenerateSchedule.Click
        ' Clear previous schedule
        dgvSchedule.Rows.Clear()

        ' Get selected month and year
        Dim selectedMonth As Integer = dtpMonth.Value.Month
        Dim selectedYear As Integer = dtpMonth.Value.Year
        Dim daysInMonth As Integer = DateTime.DaysInMonth(selectedYear, selectedMonth)

        Dim dutySchedule As New Dictionary(Of Integer, String) ' Day -> Assigned Staff
        Dim assignedStaff As New HashSet(Of String) ' To track which staff have been assigned

        ' Shuffle the staff list for random assignment
        Dim shuffledStaff As List(Of String) = Staff.OrderBy(Function() rnd.Next()).ToList()

        ' Generate the schedule randomly, ensuring no one is assigned more than once and accounting for exceptions
        For day As Integer = 1 To daysInMonth
            ' Get a list of staff members available for the current day and not yet assigned
            Dim availableStaff As List(Of String) = shuffledStaff.Where(Function(staffMember) Not UnavailableDays(staffMember).Contains(day) AndAlso Not assignedStaff.Contains(staffMember)).ToList()

            If availableStaff.Count > 0 Then
                ' Randomly select an available staff member for the current day
                Dim selectedStaffIndex As Integer = rnd.Next(availableStaff.Count)
                Dim selectedStaff As String = availableStaff(selectedStaffIndex)

                ' Assign the staff to the current day
                dutySchedule(day) = selectedStaff
                assignedStaff.Add(selectedStaff) ' Mark them as assigned
            Else
                ' No available staff for this day
                dutySchedule(day) = "No available staff"
            End If
        Next

        ' Display the schedule in the DataGridView
        For day As Integer = 1 To daysInMonth
            Dim dutyDate As DateTime = New DateTime(selectedYear, selectedMonth, day)
            dgvSchedule.Rows.Add(dutyDate.ToString("dd-MMM-yy"), dutySchedule(day))
        Next
    End Sub

    ' Button to add exception for a staff member
    Private Sub btnAddException_Click(sender As Object, e As EventArgs) Handles btnAddException.Click
        Dim staffMember As String = cmbStaffMembers.SelectedItem.ToString()
        Dim exceptionDay As DateTime = dtpExceptionDay.Value
        Dim day As Integer = exceptionDay.Day ' Get the day part of the selected date

        ' Add the unavailable day for the selected staff member
        If Not UnavailableDays(staffMember).Contains(day) Then
            UnavailableDays(staffMember).Add(day)
            MessageBox.Show(staffMember & " is now unavailable on " & exceptionDay.ToString("dd-MMM-yyyy") & ".")
        Else
            MessageBox.Show(staffMember & " is already unavailable on " & exceptionDay.ToString("dd-MMM-yyyy") & ".")
        End If
    End Sub
End Class
