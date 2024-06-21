<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TextBoxName = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxGithub = New TextBox()
        TextBoxPhone = New TextBox()
        ButtonToggleTime = New Button()
        ButtonSubmit = New Button()
        TimerStopwatch = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        LabelTimeLabel = New TextBox()
        SuspendLayout()
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Font = New Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxName.Location = New Point(400, 147)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(708, 43)
        TextBoxName.TabIndex = 0
        TextBoxName.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Font = New Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxEmail.Location = New Point(400, 223)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(708, 43)
        TextBoxEmail.TabIndex = 1
        TextBoxEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxGithub
        ' 
        TextBoxGithub.Font = New Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxGithub.Location = New Point(400, 363)
        TextBoxGithub.Name = "TextBoxGithub"
        TextBoxGithub.Size = New Size(708, 43)
        TextBoxGithub.TabIndex = 3
        TextBoxGithub.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.Font = New Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxPhone.Location = New Point(400, 300)
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(708, 43)
        TextBoxPhone.TabIndex = 4
        TextBoxPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' ButtonToggleTime
        ' 
        ButtonToggleTime.BackColor = SystemColors.Info
        ButtonToggleTime.FlatStyle = FlatStyle.Flat
        ButtonToggleTime.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonToggleTime.Location = New Point(32, 441)
        ButtonToggleTime.Name = "ButtonToggleTime"
        ButtonToggleTime.Size = New Size(700, 53)
        ButtonToggleTime.TabIndex = 5
        ButtonToggleTime.Text = "TOGGLE STOPWATCH (CTRL+T)"
        ButtonToggleTime.UseVisualStyleBackColor = False
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.BackColor = Color.LightSkyBlue
        ButtonSubmit.FlatStyle = FlatStyle.Flat
        ButtonSubmit.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonSubmit.Location = New Point(190, 520)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(850, 59)
        ButtonSubmit.TabIndex = 6
        ButtonSubmit.Text = "SUBMIT (CTRL+S)"
        ButtonSubmit.UseVisualStyleBackColor = False
        ' 
        ' TimerStopwatch
        ' 
        TimerStopwatch.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonHighlight
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(248, 155)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 31)
        Label1.TabIndex = 8
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(253, 235)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 31)
        Label2.TabIndex = 9
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(193, 308)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 31)
        Label3.TabIndex = 10
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(122, 371)
        Label4.Name = "Label4"
        Label4.Size = New Size(235, 31)
        Label4.TabIndex = 11
        Label4.Text = "Github Link For Task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(193, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(901, 54)
        Label5.TabIndex = 12
        Label5.Text = "Akkul Gautam , Slidely Task2 -  Create Submission"
        ' 
        ' LabelTimeLabel
        ' 
        LabelTimeLabel.BackColor = Color.Gainsboro
        LabelTimeLabel.Font = New Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTimeLabel.Location = New Point(807, 441)
        LabelTimeLabel.Name = "LabelTimeLabel"
        LabelTimeLabel.Size = New Size(233, 47)
        LabelTimeLabel.TabIndex = 13
        LabelTimeLabel.Text = "00:00:00"
        LabelTimeLabel.TextAlign = HorizontalAlignment.Center
        ' 
        ' CreateSubmissions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1176, 591)
        Controls.Add(LabelTimeLabel)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ButtonSubmit)
        Controls.Add(ButtonToggleTime)
        Controls.Add(TextBoxPhone)
        Controls.Add(TextBoxGithub)
        Controls.Add(TextBoxEmail)
        Controls.Add(TextBoxName)
        Name = "CreateSubmissions"
        Text = "CreateSubmissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxGithub As TextBox
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents ButtonToggleTime As Button
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents TimerStopwatch As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelTimeLabel As TextBox
End Class
