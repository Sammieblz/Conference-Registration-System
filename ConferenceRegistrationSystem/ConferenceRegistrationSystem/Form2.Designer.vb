<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lstConference = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkOpeningNight = New System.Windows.Forms.CheckBox()
        Me.chkRegistration = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstWorkShops = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstConference.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstConference
        '
        Me.lstConference.Controls.Add(Me.Label3)
        Me.lstConference.Controls.Add(Me.Label2)
        Me.lstConference.Controls.Add(Me.chkOpeningNight)
        Me.lstConference.Controls.Add(Me.chkRegistration)
        Me.lstConference.Location = New System.Drawing.Point(24, 41)
        Me.lstConference.Name = "lstConference"
        Me.lstConference.Size = New System.Drawing.Size(581, 316)
        Me.lstConference.TabIndex = 0
        Me.lstConference.TabStop = False
        Me.lstConference.Text = "Conference"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(523, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "$30"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(520, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "$895"
        '
        'chkOpeningNight
        '
        Me.chkOpeningNight.AutoSize = True
        Me.chkOpeningNight.Location = New System.Drawing.Point(39, 169)
        Me.chkOpeningNight.Name = "chkOpeningNight"
        Me.chkOpeningNight.Size = New System.Drawing.Size(282, 20)
        Me.chkOpeningNight.TabIndex = 1
        Me.chkOpeningNight.Text = "Opening Night Dinner and Keynote                "
        Me.chkOpeningNight.UseVisualStyleBackColor = True
        '
        'chkRegistration
        '
        Me.chkRegistration.AutoSize = True
        Me.chkRegistration.Location = New System.Drawing.Point(39, 83)
        Me.chkRegistration.Name = "chkRegistration"
        Me.chkRegistration.Size = New System.Drawing.Size(248, 20)
        Me.chkRegistration.TabIndex = 0
        Me.chkRegistration.Text = "Conference Registration                         "
        Me.chkRegistration.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lstWorkShops)
        Me.GroupBox1.Location = New System.Drawing.Point(625, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 316)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PreConference Workshops"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select One:"
        '
        'lstWorkShops
        '
        Me.lstWorkShops.FormattingEnabled = True
        Me.lstWorkShops.ItemHeight = 16
        Me.lstWorkShops.Items.AddRange(New Object() {"Intro to E-commerce                                                           $29" &
                "5", "The Future of the Web                                                        $295" &
                "", "Advanced Visual Basic                                                     $395", "Network Security                                                                 " &
                " $395"})
        Me.lstWorkShops.Location = New System.Drawing.Point(45, 94)
        Me.lstWorkShops.Name = "lstWorkShops"
        Me.lstWorkShops.Size = New System.Drawing.Size(413, 116)
        Me.lstWorkShops.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(656, 383)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(197, 77)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(972, 383)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(197, 77)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 568)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstConference)
        Me.Name = "Form2"
        Me.Text = "Conference Options"
        Me.lstConference.ResumeLayout(False)
        Me.lstConference.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstConference As GroupBox
    Friend WithEvents chkOpeningNight As CheckBox
    Friend WithEvents chkRegistration As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lstWorkShops As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
