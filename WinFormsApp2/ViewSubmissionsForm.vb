Imports Newtonsoft.Json
Imports System.Net.Http

Public Class ViewSubmissionsForm

    Private currentIndex As Integer = 0 ' Track current index
    Private submissionsCount As Integer = 0 ' Total count of submissions
    Private urlBase As String = "http://localhost:8000/read?index=" ' Base URL for fetching submissions

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize progress bar
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.Visible = False

        ' Check if there are any submissions
        If FetchTotalSubmissionsCount() Then
            ' If there are submissions, load the first one
            If submissionsCount > 0 Then
                FetchSubmissionData(currentIndex)
            Else
                ' If there are no submissions, show a message and close the form
                MessageBox.Show("There are no submissions available. Kindly create submissions", "No Submissions", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Else
            MessageBox.Show("Failed to fetch submission data. Form will not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close() ' Close the form if data fetching fails
        End If

        ' Enable KeyPreview so form receives key events
        Me.KeyPreview = True
    End Sub

    ' Fetch the total number of submissions from the server
    Private Function FetchTotalSubmissionsCount() As Boolean
        Me.Text = "View Submissions"
        Using client As New HttpClient()
            Try
                ' Attempt to fetch the first submission to estimate the total count
                Dim response As HttpResponseMessage = client.GetAsync("http://localhost:8000/read?index=0").Result

                ' If the first submission fetch is successful, start counting
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = response.Content.ReadAsStringAsync().Result
                    Dim firstSubmission As Object = JsonConvert.DeserializeObject(jsonResponse)

                    ' Initialize the count to zero and increment until no more submissions are found
                    submissionsCount = 0
                    Do
                        submissionsCount += 1
                        response = client.GetAsync($"{urlBase}{submissionsCount}").Result
                    Loop While response.IsSuccessStatusCode

                    ' Reset the current index to start from the first submission
                    currentIndex = 0

                    ' Hide progress bar after loading
                    ProgressBar1.Visible = False

                    Return True
                Else
                    ' If the initial submission fetch fails, there might be no submissions
                    submissionsCount = 0
                    ' Hide progress bar on failure
                    ProgressBar1.Visible = False
                    Return True
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while fetching submissions count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Hide progress bar on error
                ProgressBar1.Visible = False
                Return False
            End Try
        End Using
    End Function

    Private Sub FetchSubmissionData(index As Integer)
        Dim url As String = $"{urlBase}{index}"

        ' Show progress bar while fetching submission data
        ProgressBar1.Visible = True

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = client.GetAsync(url).Result

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = response.Content.ReadAsStringAsync().Result
                    Dim data As Object = JsonConvert.DeserializeObject(jsonResponse)

                    ' Populate form fields with retrieved data
                    txtName.Text = data("name").ToString()
                    txtEmail.Text = data("email").ToString()
                    txtPhone.Text = data("phone").ToString()
                    txtGithubLink.Text = data("github_link").ToString()
                    txtStopwatchTime.Text = data("stopwatch_time").ToString()

                    ' Set textboxes to read-only mode
                    txtName.ReadOnly = True
                    txtEmail.ReadOnly = True
                    txtPhone.ReadOnly = True
                    txtGithubLink.ReadOnly = True
                    txtStopwatchTime.ReadOnly = True

                Else
                    MessageBox.Show("Failed to fetch submission data: " & response.StatusCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Hide progress bar after fetching data
                ProgressBar1.Visible = False
            End Try
        End Using
    End Sub

    ' Handle Previous button click event
    Private Sub BTNPrevious_Click(sender As Object, e As EventArgs) Handles BTNPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            FetchSubmissionData(currentIndex)
        Else
            MessageBox.Show("Already at the first submission.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Handle Next button click event
    Private Sub BTNNext_Click(sender As Object, e As EventArgs) Handles BTNNext.Click
        If currentIndex < submissionsCount - 1 Then
            currentIndex += 1
            FetchSubmissionData(currentIndex)
        Else
            MessageBox.Show("Already at the last submission.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Handle the Delete button click event to delete the current submission
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        ' Confirm before deletion
        Dim result As DialogResult = MessageBox.Show("Confirm do you want to delete it?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim deleteUrl As String = $"http://localhost:8000/delete?index={currentIndex}"

            ' Show progress bar while deleting
            ProgressBar1.Visible = True

            Using client As New HttpClient()
                Try
                    Dim response As HttpResponseMessage = client.DeleteAsync(deleteUrl).Result

                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Fetch the updated total count after deletion
                        FetchTotalSubmissionsCount()

                        ' If there are still submissions left, show the previous one or the first one if at the beginning
                        If submissionsCount > 0 Then
                            If currentIndex >= submissionsCount Then
                                currentIndex = submissionsCount - 1 ' Adjust index if it was the last submission
                            End If
                            FetchSubmissionData(currentIndex)
                        Else
                            ' Clear the form if no submissions are left
                            txtName.Clear()
                            txtEmail.Clear()
                            txtPhone.Clear()
                            txtGithubLink.Clear()
                            txtStopwatchTime.Clear()
                            MessageBox.Show("All submissions have been deleted.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    Else
                        MessageBox.Show("Failed to delete the submission: " & response.StatusCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred while trying to delete the submission: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Hide progress bar after deletion attempt
                    ProgressBar1.Visible = False
                End Try
            End Using
        End If
    End Sub

    ' Add this method to handle keyboard shortcuts

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        ' Hide unnecessary buttons when editing
        BTNPrevious.Visible = False
        BTNNext.Visible = False
        ButtonDelete.Visible = False
        ButtonEdit.Visible = False

        ' Open the CreateSubmissions form in edit mode with current data
        OpenCreateSubmissionsForm(currentIndex)
    End Sub

    ' Method to open CreateSubmissions form with data for editing
    Private Sub OpenCreateSubmissionsForm(index As Integer)
        Using createForm As New CreateSubmissions()
            ' Load the current submission data into the form for editing
            Dim data As New Dictionary(Of String, Object) From {
                {"name", txtName.Text},
                {"email", txtEmail.Text},
                {"phone", txtPhone.Text},
                {"github_link", txtGithubLink.Text},
                {"stopwatch_time", txtStopwatchTime.Text}
            }
            createForm.LoadDataForEditing(data, index)

            ' Show the form and wait for it to close
            createForm.ShowDialog()

            ' After editing, refresh the current data view
            FetchSubmissionData(currentIndex)

            ' Show the buttons again after editing
            BTNPrevious.Visible = True
            BTNNext.Visible = True
            ButtonDelete.Visible = True
            ButtonEdit.Visible = True
        End Using
    End Sub
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim searchEmail As String = TextBoxEmail.Text.Trim()

        If String.IsNullOrWhiteSpace(searchEmail) Then
            MessageBox.Show("Please enter an email ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Show progress bar while searching
            ProgressBar1.Visible = True

            ' Perform search request to backend
            Dim url As String = $"http://localhost:8000/search?email={searchEmail}"
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = client.GetAsync(url).Result

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = response.Content.ReadAsStringAsync().Result
                    Dim data As Object = JsonConvert.DeserializeObject(jsonResponse)

                    ' Check if data is null (no submission found)
                    If data IsNot Nothing Then
                        ' Display the found submission
                        txtName.Text = data("name").ToString()
                        txtEmail.Text = data("email").ToString()
                        txtPhone.Text = data("phone").ToString()
                        txtGithubLink.Text = data("github_link").ToString()
                        txtStopwatchTime.Text = data("stopwatch_time").ToString()

                        ' Update currentIndex to the found index
                        currentIndex = Convert.ToInt32(data("index"))
                    Else
                        MessageBox.Show("No submission found with the provided email ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Error searching for submission: " & response.StatusCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while searching: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Hide progress bar after search operation
            ProgressBar1.Visible = False
        End Try
    End Sub


    ' Method to handle keyboard shortcuts for Delete (Ctrl+D) and Edit (Ctrl+E)
    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.D Then
            ButtonDelete.PerformClick() ' Simulate ButtonDelete click
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            ButtonEdit.PerformClick() ' Simulate ButtonEdit click
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            BTNNext.PerformClick() ' Simulate BTNNext click
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            BTNPrevious.PerformClick() ' Simulate BTNPrevious click
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            ButtonSearch.PerformClick() ' Simulate ButtonSearch click
        End If
    End Sub
    Private Sub CreateSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize any form setup if needed

        ' Call RoundAndBorderButton for each button that needs to be styled
        RoundAndBorderButton(BTNPrevious)
        RoundAndBorderButton(BTNNext)
        RoundAndBorderButton(ButtonDelete)
        RoundAndBorderButton(ButtonEdit)
        RoundAndBorderButton(ButtonSearch)
 

        ' Add more buttons as needed
    End Sub
    Private Sub RoundAndBorderButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.Cursor = Cursors.Hand
        btn.FlatAppearance.BorderSize = 0 ' Remove default border

        ' Add a Paint event handler to draw the border around the button
        AddHandler btn.Paint, Sub(sender As Object, e As PaintEventArgs)
                                  Dim g As Graphics = e.Graphics
                                  Dim path As New Drawing2D.GraphicsPath()

                                  Dim cornerRadius As Integer = 20 ' Adjust this value to change corner radius
                                  Dim borderWidth As Integer = 2 ' Adjust this value to change border width
                                  Dim borderColor As Color = Color.Gray ' Adjust this value to change border color

                                  ' Define the button shape with rounded corners
                                  path.AddArc(New Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90)
                                  path.AddLine(cornerRadius, 0, btn.Width - cornerRadius, 0)
                                  path.AddArc(New Rectangle(btn.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), -90, 90)
                                  path.AddLine(btn.Width, cornerRadius, btn.Width, btn.Height - cornerRadius)
                                  path.AddArc(New Rectangle(btn.Width - cornerRadius * 2, btn.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90)
                                  path.AddLine(btn.Width - cornerRadius, btn.Height, cornerRadius, btn.Height)
                                  path.AddArc(New Rectangle(0, btn.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90)
                                  path.AddLine(0, btn.Height - cornerRadius, 0, cornerRadius)

                                  path.CloseFigure()

                                  ' Set the button's region to the custom shape
                                  btn.Region = New Region(path)

                                  ' Draw the border around the shape
                                  g.DrawPath(New Pen(borderColor, borderWidth), path)
                              End Sub
    End Sub

End Class
