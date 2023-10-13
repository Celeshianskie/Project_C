<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CusPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CusUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(379, 332)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 47)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(216, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 47)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "REGISTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComName
        '
        Me.ComName.Location = New System.Drawing.Point(368, 232)
        Me.ComName.Name = "ComName"
        Me.ComName.Size = New System.Drawing.Size(244, 20)
        Me.ComName.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Complete Name:"
        '
        'CusPass
        '
        Me.CusPass.Location = New System.Drawing.Point(368, 152)
        Me.CusPass.Name = "CusPass"
        Me.CusPass.Size = New System.Drawing.Size(145, 20)
        Me.CusPass.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password:"
        '
        'CusUser
        '
        Me.CusUser.Location = New System.Drawing.Point(368, 76)
        Me.CusUser.Name = "CusUser"
        Me.CusUser.Size = New System.Drawing.Size(145, 20)
        Me.CusUser.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username:"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CusPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CusUser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CusPass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CusUser As TextBox
    Friend WithEvents Label1 As Label
End Class
