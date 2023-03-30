<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSelectConference = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblEmsil = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelectConference
        '
        Me.btnSelectConference.Location = New System.Drawing.Point(71, 638)
        Me.btnSelectConference.Name = "btnSelectConference"
        Me.btnSelectConference.Size = New System.Drawing.Size(191, 70)
        Me.btnSelectConference.TabIndex = 0
        Me.btnSelectConference.Text = "Select Conference Options"
        Me.btnSelectConference.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(441, 638)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(191, 70)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(793, 638)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(191, 70)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtZip)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblZip)
        Me.GroupBox1.Controls.Add(Me.lblState)
        Me.GroupBox1.Controls.Add(Me.lblEmsil)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblCity)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.lblCompany)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Location = New System.Drawing.Point(107, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(939, 440)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrant"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(692, 293)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(174, 22)
        Me.txtZip.TabIndex = 15
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(692, 227)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(174, 22)
        Me.txtState.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(692, 160)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(174, 22)
        Me.txtEmail.TabIndex = 13
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(692, 107)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(174, 22)
        Me.txtPhone.TabIndex = 12
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(128, 290)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(195, 22)
        Me.txtCity.TabIndex = 11
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(128, 227)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(195, 22)
        Me.txtAddress.TabIndex = 10
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(128, 160)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(195, 22)
        Me.txtCompany.TabIndex = 9
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(128, 107)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(195, 22)
        Me.txtName.TabIndex = 8
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(568, 296)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(26, 16)
        Me.lblZip.TabIndex = 7
        Me.lblZip.Text = "Zip"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(568, 230)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(38, 16)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State"
        '
        'lblEmsil
        '
        Me.lblEmsil.AutoSize = True
        Me.lblEmsil.Location = New System.Drawing.Point(568, 163)
        Me.lblEmsil.Name = "lblEmsil"
        Me.lblEmsil.Size = New System.Drawing.Size(41, 16)
        Me.lblEmsil.TabIndex = 5
        Me.lblEmsil.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(568, 107)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(46, 16)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(35, 296)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(29, 16)
        Me.lblCity.TabIndex = 3
        Me.lblCity.Text = "City"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(32, 227)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(32, 163)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(65, 16)
        Me.lblCompany.TabIndex = 1
        Me.lblCompany.Text = "Company"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(32, 107)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(718, 530)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 16)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPrice.Location = New System.Drawing.Point(832, 530)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(40, 18)
        Me.lblTotalPrice.TabIndex = 5
        Me.lblTotalPrice.Text = "$0.00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 750)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSelectConference)
        Me.Name = "Form1"
        Me.Text = "Conference Registration System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelectConference As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblEmsil As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalPrice As Label
End Class
