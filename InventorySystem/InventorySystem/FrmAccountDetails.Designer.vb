<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAccountDetails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picVisible = New System.Windows.Forms.PictureBox()
        Me.picProf = New System.Windows.Forms.PictureBox()
        Me.radM = New System.Windows.Forms.RadioButton()
        Me.radF = New System.Windows.Forms.RadioButton()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(92, 24)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(156, 23)
        Me.txtName.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(92, 110)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(202, 23)
        Me.txtUsername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 149)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password:"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPass.Enabled = False
        Me.txtPass.Location = New System.Drawing.Point(92, 146)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPass.Size = New System.Drawing.Size(202, 23)
        Me.txtPass.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(126, 176)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Change Password"
        '
        'picVisible
        '
        Me.picVisible.Location = New System.Drawing.Point(298, 150)
        Me.picVisible.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picVisible.Name = "picVisible"
        Me.picVisible.Size = New System.Drawing.Size(19, 14)
        Me.picVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisible.TabIndex = 8
        Me.picVisible.TabStop = False
        Me.picVisible.Visible = False
        '
        'picProf
        '
        Me.picProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProf.Location = New System.Drawing.Point(250, 12)
        Me.picProf.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picProf.Name = "picProf"
        Me.picProf.Size = New System.Drawing.Size(84, 77)
        Me.picProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProf.TabIndex = 9
        Me.picProf.TabStop = False
        '
        'radM
        '
        Me.radM.AutoSize = True
        Me.radM.Enabled = False
        Me.radM.Location = New System.Drawing.Point(92, 56)
        Me.radM.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.radM.Name = "radM"
        Me.radM.Size = New System.Drawing.Size(56, 20)
        Me.radM.TabIndex = 10
        Me.radM.TabStop = True
        Me.radM.Text = "Male"
        Me.radM.UseVisualStyleBackColor = True
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Enabled = False
        Me.radF.Location = New System.Drawing.Point(156, 56)
        Me.radF.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(73, 20)
        Me.radF.TabIndex = 11
        Me.radF.TabStop = True
        Me.radF.Text = "Female"
        Me.radF.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(114, 204)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(129, 25)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'FrmAccountDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(336, 242)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.radF)
        Me.Controls.Add(Me.radM)
        Me.Controls.Add(Me.picProf)
        Me.Controls.Add(Me.picVisible)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAccountDetails"
        Me.Text = "Account Details"
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents picVisible As PictureBox
    Friend WithEvents picProf As PictureBox
    Friend WithEvents radM As RadioButton
    Friend WithEvents radF As RadioButton
    Friend WithEvents btnUpdate As Button
End Class
