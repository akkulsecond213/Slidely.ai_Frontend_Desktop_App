Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set KeyPreview to true so the form receives key events
        Me.KeyPreview = True

        ' Call RoundButton for each button that needs to be rounded and bordered
        RoundButton(BTNViewSubmissions)
        RoundButton(BTNCreateSubmission)
    End Sub

    Private Sub RoundButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.Cursor = Cursors.Hand
        btn.FlatAppearance.BorderSize = 0 ' Remove default border

        ' Add a handler for the button's Paint event to draw the rounded corners and border
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

    ' Event handler for BTNViewSubmissions button click
    Private Sub BTNViewSubmissions_Click(sender As Object, e As EventArgs) Handles BTNViewSubmissions.Click
        OpenViewSubmissionsForm()
    End Sub

    ' Event handler for BTNCreateSubmission button click
    Private Sub BTNCreateSubmission_Click(sender As Object, e As EventArgs) Handles BTNCreateSubmission.Click
        OpenCreateSubmissionsForm()
    End Sub

    Private Sub OpenViewSubmissionsForm()
        ' Implement your logic to open View Submissions form here
        Using viewForm As New ViewSubmissionsForm()
            viewForm.ShowDialog()
        End Using
    End Sub

    Private Sub OpenCreateSubmissionsForm()
        ' Implement your logic to open Create Submissions form here
        Using createForm As New CreateSubmissions()
            createForm.ShowDialog()
        End Using
    End Sub

    ' Handle the KeyDown event to detect Ctrl+V and Ctrl+N
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Ctrl+V: Open View Submissions form
            OpenViewSubmissionsForm()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl+N: Open Create Submissions form
            OpenCreateSubmissionsForm()
        End If
    End Sub

End Class
