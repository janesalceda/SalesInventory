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
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.picVisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(76, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(199, 26)
        Me.txtName.TabIndex = 1
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(17, 125)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(258, 26)
        Me.txtUsername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password:"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPass.Enabled = False
        Me.txtPass.Location = New System.Drawing.Point(17, 174)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPass.Size = New System.Drawing.Size(258, 26)
        Me.txtPass.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(73, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Change Password"
        '
        'picVisible
        '
        Me.picVisible.Location = New System.Drawing.Point(282, 178)
        Me.picVisible.Name = "picVisible"
        Me.picVisible.Size = New System.Drawing.Size(25, 16)
        Me.picVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisible.TabIndex = 8
        Me.picVisible.TabStop = False
        Me.picVisible.Visible = False
        '
        'picProf
        '
        Me.picProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProf.Location = New System.Drawing.Point(285, 11)
        Me.picProf.Name = "picProf"
        Me.picProf.Size = New System.Drawing.Size(107, 86)
        Me.picProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProf.TabIndex = 9
        Me.picProf.TabStop = False
        '
        'radM
        '
        Me.radM.AutoSize = True
        Me.radM.Enabled = False
        Me.radM.Location = New System.Drawing.Point(107, 63)
        Me.radM.Name = "radM"
        Me.radM.Size = New System.Drawing.Size(60, 22)
        Me.radM.TabIndex = 10
        Me.radM.TabStop = True
        Me.radM.Text = "Male"
        Me.radM.UseVisualStyleBackColor = True
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Enabled = False
        Me.radF.Location = New System.Drawing.Point(181, 63)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(79, 22)
        Me.radF.TabIndex = 11
        Me.radF.TabStop = True
        Me.radF.Text = "Female"
        Me.radF.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.White
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnUpdate.Location = New System.Drawing.Point(219, 234)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(84, 28)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(310, 234)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 28)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FrmAccountDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(403, 272)
        Me.Controls.Add(Me.btnCancel)
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
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents btnCancel As Button
End Class
