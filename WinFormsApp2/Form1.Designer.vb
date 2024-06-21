<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        BTNViewSubmissions = New Button()
        BTNCreateSubmission = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' BTNViewSubmissions
        ' 
        BTNViewSubmissions.BackColor = SystemColors.Info
        BTNViewSubmissions.FlatStyle = FlatStyle.Flat
        BTNViewSubmissions.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNViewSubmissions.Location = New Point(143, 189)
        BTNViewSubmissions.Name = "BTNViewSubmissions"
        BTNViewSubmissions.Size = New Size(1006, 114)
        BTNViewSubmissions.TabIndex = 0
        BTNViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL+V)"
        BTNViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' BTNCreateSubmission
        ' 
        BTNCreateSubmission.BackColor = Color.LightSkyBlue
        BTNCreateSubmission.FlatStyle = FlatStyle.Flat
        BTNCreateSubmission.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BTNCreateSubmission.Location = New Point(143, 444)
        BTNCreateSubmission.Name = "BTNCreateSubmission"
        BTNCreateSubmission.Size = New Size(1006, 99)
        BTNCreateSubmission.TabIndex = 1
        BTNCreateSubmission.Text = "CREATE NEW SUBMISSIONS (CTRL+N)"
        BTNCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(197, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(864, 54)
        Label1.TabIndex = 2
        Label1.Text = "Akkul Gautam , Slidely Task2 - Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(1313, 692)
        Controls.Add(Label1)
        Controls.Add(BTNCreateSubmission)
        Controls.Add(BTNViewSubmissions)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        Text = "Form Submission App"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BTNViewSubmissions As Button
    Friend WithEvents BTNCreateSubmission As Button
    Friend WithEvents Label1 As Label

End Class
