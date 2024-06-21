<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        components = New ComponentModel.Container()
        BTNPrevious = New Button()
        BTNNext = New Button()
        LblSubmissionDetails = New Label()
        txtName = New TextBox()
        txtStopwatchTime = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ButtonDelete = New Button()
        ButtonEdit = New Button()
        TimerStopwatch = New Timer(components)
        TextBoxEmail = New TextBox()
        LabelSearch = New Label()
        ButtonSearch = New Button()
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' BTNPrevious
        ' 
        BTNPrevious.BackColor = SystemColors.Info
        BTNPrevious.FlatStyle = FlatStyle.Flat
        BTNPrevious.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNPrevious.Location = New Point(31, 579)
        BTNPrevious.Name = "BTNPrevious"
        BTNPrevious.Size = New Size(650, 49)
        BTNPrevious.TabIndex = 0
        BTNPrevious.Text = "PREVIOUS (CTRL+P)"
        BTNPrevious.UseVisualStyleBackColor = False
        ' 
        ' BTNNext
        ' 
        BTNNext.BackColor = Color.LightSkyBlue
        BTNNext.FlatStyle = FlatStyle.Flat
        BTNNext.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNNext.Location = New Point(714, 579)
        BTNNext.Name = "BTNNext"
        BTNNext.Size = New Size(650, 49)
        BTNNext.TabIndex = 1
        BTNNext.Text = "NEXT (CTRL+N)"
        BTNNext.UseVisualStyleBackColor = False
        ' 
        ' LblSubmissionDetails
        ' 
        LblSubmissionDetails.AutoSize = True
        LblSubmissionDetails.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblSubmissionDetails.Location = New Point(333, 9)
        LblSubmissionDetails.Name = "LblSubmissionDetails"
        LblSubmissionDetails.Size = New Size(877, 54)
        LblSubmissionDetails.TabIndex = 2
        LblSubmissionDetails.Text = "Akkul Gautam , Slidely Task2 -  ViewSubmissions"
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.Gainsboro
        txtName.Font = New Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(467, 193)
        txtName.Name = "txtName"
        txtName.Size = New Size(850, 43)
        txtName.TabIndex = 3
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = Color.Gainsboro
        txtStopwatchTime.Font = New Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStopwatchTime.Location = New Point(467, 492)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(850, 43)
        txtStopwatchTime.TabIndex = 4
        txtStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.Gainsboro
        txtEmail.Font = New Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(467, 264)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(850, 43)
        txtEmail.TabIndex = 5
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = Color.Gainsboro
        txtPhone.Font = New Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(467, 335)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(850, 43)
        txtPhone.TabIndex = 6
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.Gainsboro
        txtGithubLink.Font = New Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGithubLink.Location = New Point(467, 414)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(850, 43)
        txtGithubLink.TabIndex = 7
        txtGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(288, 201)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 31)
        Label1.TabIndex = 8
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(288, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 31)
        Label2.TabIndex = 9
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(254, 343)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 31)
        Label3.TabIndex = 10
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(171, 422)
        Label4.Name = "Label4"
        Label4.Size = New Size(235, 31)
        Label4.TabIndex = 11
        Label4.Text = "Github Link For Task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(211, 500)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 31)
        Label5.TabIndex = 12
        Label5.Text = "Stopwatch Time"
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.BackColor = Color.OrangeRed
        ButtonDelete.FlatStyle = FlatStyle.Flat
        ButtonDelete.Font = New Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonDelete.Location = New Point(1261, 21)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(133, 59)
        ButtonDelete.TabIndex = 13
        ButtonDelete.Text = "DELETE FORM (CTRL+D)"
        ButtonDelete.UseVisualStyleBackColor = False
        ' 
        ' ButtonEdit
        ' 
        ButtonEdit.BackColor = Color.Thistle
        ButtonEdit.FlatStyle = FlatStyle.Flat
        ButtonEdit.Location = New Point(1261, 86)
        ButtonEdit.Name = "ButtonEdit"
        ButtonEdit.Size = New Size(133, 63)
        ButtonEdit.TabIndex = 14
        ButtonEdit.Text = "EDIT FORM (CTRL+E)"
        ButtonEdit.UseVisualStyleBackColor = False
        ' 
        ' TimerStopwatch
        ' 
        TimerStopwatch.Interval = 1000
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.BackColor = SystemColors.ControlLightLight
        TextBoxEmail.Font = New Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxEmail.Location = New Point(467, 74)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(618, 38)
        TextBoxEmail.TabIndex = 15
        TextBoxEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' LabelSearch
        ' 
        LabelSearch.AutoSize = True
        LabelSearch.BackColor = SystemColors.ButtonHighlight
        LabelSearch.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSearch.Location = New Point(335, 74)
        LabelSearch.Name = "LabelSearch"
        LabelSearch.Size = New Size(88, 41)
        LabelSearch.TabIndex = 16
        LabelSearch.Text = "Email"
        ' 
        ' ButtonSearch
        ' 
        ButtonSearch.BackColor = SystemColors.Info
        ButtonSearch.FlatStyle = FlatStyle.Flat
        ButtonSearch.Location = New Point(1091, 71)
        ButtonSearch.Name = "ButtonSearch"
        ButtonSearch.Size = New Size(150, 41)
        ButtonSearch.TabIndex = 17
        ButtonSearch.Text = "SEARCH (CTRL+S )"
        ButtonSearch.UseVisualStyleBackColor = False
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(762, 133)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(125, 29)
        ProgressBar1.TabIndex = 18
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1427, 756)
        Controls.Add(ProgressBar1)
        Controls.Add(ButtonSearch)
        Controls.Add(LabelSearch)
        Controls.Add(TextBoxEmail)
        Controls.Add(ButtonEdit)
        Controls.Add(ButtonDelete)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtName)
        Controls.Add(LblSubmissionDetails)
        Controls.Add(BTNNext)
        Controls.Add(BTNPrevious)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BTNPrevious As Button
    Friend WithEvents BTNNext As Button
    Friend WithEvents LblSubmissionDetails As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents TimerStopwatch As Timer
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelSearch As Label
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
