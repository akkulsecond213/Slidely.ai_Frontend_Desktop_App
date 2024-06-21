Imports Newtonsoft.Json
Imports System.Net.Http

Public Class CreateSubmissions
    Private Const V As String = "00:00:00"
    Dim stopwatchRunning As Boolean = False
    Dim elapsedTime As TimeSpan = TimeSpan.Zero
    Dim startTime As DateTime

    ' Fields to keep track of the editing mode and index
    Private isEditMode As Boolean = False
    Public editIndex As Integer = -1

    ' Constructor to initialize components and set KeyPreview to true
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Enable KeyPreview for the form
    End Sub

    ' Handle KeyDown event for the form to capture keyboard shortcuts
    Private Sub CreateSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle Ctrl+T for ButtonToggleTime
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ButtonToggleTime.PerformClick()
        End If

        ' Handle Ctrl+S for ButtonSubmit
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ButtonSubmit.PerformClick()
        End If
    End Sub

    ' Toggle the stopwatch between running and paused states
    Private Sub ButtonToggleTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonToggleTime.Click
        If stopwatchRunning Then
            ' Pause the stopwatch
            TimerStopwatch.Stop()
            elapsedTime += DateTime.Now - startTime
            stopwatchRunning = False
            ButtonToggleTime.Text = "Start (CTRL+T)"
        Else
            ' Start or resume the stopwatch
            startTime = DateTime.Now
            TimerStopwatch.Start()
            stopwatchRunning = True
            ButtonToggleTime.Text = "Pause (CTRL+T)"
        End If
    End Sub

    ' Open the ViewSubmissionsForm form
    Private Sub OpenViewSubmissionsForm()
        Using viewSubmissionsForm As New ViewSubmissionsForm()
            viewSubmissionsForm.ShowDialog()
        End Using
    End Sub

    ' Update the elapsed time display every tick
    Private Sub TimerStopwatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerStopwatch.Tick
        Dim currentElapsedTime As TimeSpan = elapsedTime + (DateTime.Now - startTime)
        LabelTimeLabel.ReadOnly = True
        LabelTimeLabel.Text = currentElapsedTime.ToString("hh\:mm\:ss")
    End Sub

    ' Submit the form data to the backend
    Private Async Sub ButtonSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubmit.Click
        ' Collect data from form inputs
        Dim name As String = TextBoxName.Text
        Dim email As String = TextBoxEmail.Text
        Dim phone As String = TextBoxPhone.Text
        Dim github As String = TextBoxGithub.Text
        Dim stopwatchTime As String = LabelTimeLabel.Text

        ' Check if any required field is empty
        If String.IsNullOrWhiteSpace(name) OrElse
           String.IsNullOrWhiteSpace(email) OrElse
           String.IsNullOrWhiteSpace(phone) OrElse
           String.IsNullOrWhiteSpace(github) OrElse
           String.IsNullOrWhiteSpace(stopwatchTime) Then

            MessageBox.Show("Please fill out all fields before submitting.")
            Return ' Exit the method without submitting
        End If

        ' Create a dictionary with the form data
        Dim formData As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", github},
            {"stopwatch_time", stopwatchTime}
        }

        ' Convert the dictionary to a JSON string
        Dim jsonData As String = JsonConvert.SerializeObject(formData)

        ' Determine whether to send a POST (create) or PUT (update) request
        Dim url As String
        If isEditMode AndAlso editIndex >= 0 Then
            url = $"http://localhost:8000/update/{editIndex}"
        Else
            url = "http://localhost:8000/submit"
        End If

        ' Use HttpClient to send the request to the backend
        Using client As New HttpClient()
            Try
                ' Prepare the content for the request
                Dim content As New StringContent(jsonData, System.Text.Encoding.UTF8, "application/json")

                ' Send the request to the server
                Dim response As HttpResponseMessage
                If isEditMode AndAlso editIndex >= 0 Then
                    response = Await client.PutAsync(url, content) ' Send PUT request for update
                Else
                    response = Await client.PostAsync(url, content) ' Send POST request for create
                End If

                ' Check if the request was successful
                If response.IsSuccessStatusCode Then
                    Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                    Dim isEdit As Boolean = isEditMode ' Set this based on your edit mode condition

                    ' Simulate response content for demonstration


                    ' Determine the appropriate message based on edit mode
                    Dim message As String
                    If isEdit Then
                        message = "Submission updated successfully"
                    Else
                        message = "Submission sent successfully"
                    End If

                    ' Show the MessageBox with the appropriate message
                    MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close() ' Close the form after successful submission
                Else
                    MessageBox.Show("Error: " & response.StatusCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Method to load data into the form for editing
    Public Sub LoadDataForEditing(data As Dictionary(Of String, Object), index As Integer)
        ' Set the form fields with the provided data for editing
        TextBoxName.Text = data("name").ToString()
        TextBoxEmail.Text = data("email").ToString()
        TextBoxPhone.Text = data("phone").ToString()
        TextBoxGithub.Text = data("github_link").ToString()
        LabelTimeLabel.Text = V ' Use actual data for editing mode

        ' Set edit mode and index
        isEditMode = True
        editIndex = index

        ' Update the form's title and Label5 text
        Me.Text = "Edit Submissions" ' Change the form's title
        Label5.Text = "Akkul Gautam, Slidely Task2 - Edit Submission" ' Change the text of Label5
    End Sub

    ' Form Load event handler
    Private Sub CreateSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize any form setup if needed

        ' Call RoundAndBorderButton for each button that needs to be styled
        RoundAndBorderButton(ButtonToggleTime)
        RoundAndBorderButton(ButtonSubmit)
        ' Add more buttons as needed
    End Sub

    ' Method to style a button with rounded corners and a border
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ' Handle label click event if needed
    End Sub
End Class
