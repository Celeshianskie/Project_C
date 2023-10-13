<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservationForm
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
        Me.CusUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CusAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PhoneNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PaxNum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTDate = New System.Windows.Forms.DateTimePicker()
        Me.CBMod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbTour = New System.Windows.Forms.ListBox()
        Me.GbDays = New System.Windows.Forms.GroupBox()
        Me.RBSeven = New System.Windows.Forms.RadioButton()
        Me.RBFour = New System.Windows.Forms.RadioButton()
        Me.AdminAccountTableAdapter1 = New Palencia_ProjectC.ProjectCDataSetTableAdapters.AdminAccountTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GbDays.SuspendLayout()
        Me.SuspendLayout()
        '
        'CusUser
        '
        Me.CusUser.Location = New System.Drawing.Point(216, 28)
        Me.CusUser.Name = "CusUser"
        Me.CusUser.Size = New System.Drawing.Size(145, 20)
        Me.CusUser.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Name:"
        '
        'CusAddress
        '
        Me.CusAddress.Location = New System.Drawing.Point(216, 79)
        Me.CusAddress.Name = "CusAddress"
        Me.CusAddress.Size = New System.Drawing.Size(145, 20)
        Me.CusAddress.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Address:"
        '
        'PhoneNum
        '
        Me.PhoneNum.Location = New System.Drawing.Point(216, 131)
        Me.PhoneNum.Name = "PhoneNum"
        Me.PhoneNum.Size = New System.Drawing.Size(145, 20)
        Me.PhoneNum.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Phone Number:"
        '
        'PaxNum
        '
        Me.PaxNum.Location = New System.Drawing.Point(216, 183)
        Me.PaxNum.Name = "PaxNum"
        Me.PaxNum.Size = New System.Drawing.Size(145, 20)
        Me.PaxNum.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 25)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Pax Num:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Departure Date:"
        '
        'DTDate
        '
        Me.DTDate.Location = New System.Drawing.Point(216, 236)
        Me.DTDate.Name = "DTDate"
        Me.DTDate.Size = New System.Drawing.Size(196, 20)
        Me.DTDate.TabIndex = 22
        '
        'CBMod
        '
        Me.CBMod.FormattingEnabled = True
        Me.CBMod.Items.AddRange(New Object() {"Cash", "Credit", "Debit", "Pagmamahal", "Doubloons", "Git"})
        Me.CBMod.Location = New System.Drawing.Point(216, 289)
        Me.CBMod.Name = "CBMod"
        Me.CBMod.Size = New System.Drawing.Size(145, 21)
        Me.CBMod.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Mode of Payment:"
        '
        'LbTour
        '
        Me.LbTour.FormattingEnabled = True
        Me.LbTour.Items.AddRange(New Object() {"Caribbean", "Mediterranean", "Alaska", "Europe"})
        Me.LbTour.Location = New System.Drawing.Point(512, 28)
        Me.LbTour.Name = "LbTour"
        Me.LbTour.Size = New System.Drawing.Size(211, 56)
        Me.LbTour.TabIndex = 25
        '
        'GbDays
        '
        Me.GbDays.Controls.Add(Me.RBFour)
        Me.GbDays.Controls.Add(Me.RBSeven)
        Me.GbDays.Location = New System.Drawing.Point(512, 101)
        Me.GbDays.Name = "GbDays"
        Me.GbDays.Size = New System.Drawing.Size(211, 89)
        Me.GbDays.TabIndex = 26
        Me.GbDays.TabStop = False
        Me.GbDays.Text = "Number of Days"
        '
        'RBSeven
        '
        Me.RBSeven.AutoSize = True
        Me.RBSeven.Location = New System.Drawing.Point(6, 25)
        Me.RBSeven.Name = "RBSeven"
        Me.RBSeven.Size = New System.Drawing.Size(58, 17)
        Me.RBSeven.TabIndex = 0
        Me.RBSeven.TabStop = True
        Me.RBSeven.Text = "7 Days"
        Me.RBSeven.UseVisualStyleBackColor = True
        '
        'RBFour
        '
        Me.RBFour.AutoSize = True
        Me.RBFour.Location = New System.Drawing.Point(6, 59)
        Me.RBFour.Name = "RBFour"
        Me.RBFour.Size = New System.Drawing.Size(64, 17)
        Me.RBFour.TabIndex = 1
        Me.RBFour.TabStop = True
        Me.RBFour.Text = "14 Days"
        Me.RBFour.UseVisualStyleBackColor = True
        '
        'AdminAccountTableAdapter1
        '
        Me.AdminAccountTableAdapter1.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(512, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Pax Cost:"
        '
        'lblPax
        '
        Me.lblPax.AutoSize = True
        Me.lblPax.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPax.Location = New System.Drawing.Point(606, 204)
        Me.lblPax.Name = "lblPax"
        Me.lblPax.Size = New System.Drawing.Size(70, 25)
        Me.lblPax.TabIndex = 28
        Me.lblPax.Text = "Pax Cost:"
        Me.lblPax.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTotal.Location = New System.Drawing.Point(606, 247)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(76, 25)
        Me.lblTotal.TabIndex = 30
        Me.lblTotal.Text = "Total Cost:"
        Me.lblTotal.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(512, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Total Cost:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(548, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 31)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "COMPUTE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(346, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(127, 46)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "RESERVE NOW"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'ReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblPax)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GbDays)
        Me.Controls.Add(Me.LbTour)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBMod)
        Me.Controls.Add(Me.DTDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PaxNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PhoneNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CusAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CusUser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReservationForm"
        Me.Text = "ReservationForm"
        Me.GbDays.ResumeLayout(False)
        Me.GbDays.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CusUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CusAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PhoneNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PaxNum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DTDate As DateTimePicker
    Friend WithEvents CBMod As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LbTour As ListBox
    Friend WithEvents GbDays As GroupBox
    Friend WithEvents RBFour As RadioButton
    Friend WithEvents RBSeven As RadioButton
    Friend WithEvents AdminAccountTableAdapter1 As ProjectCDataSetTableAdapters.AdminAccountTableAdapter
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPax As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
