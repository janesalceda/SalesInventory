<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierEntry
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
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmailAd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAttention = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAccountsName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSupplierId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbTOP = New System.Windows.Forms.ComboBox()
        Me.cmbTOD = New System.Windows.Forms.ComboBox()
        Me.chkDisuse = New System.Windows.Forms.CheckBox()
        Me.cmbCurrency = New System.Windows.Forms.ComboBox()
        Me.chkImport = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPhone.Location = New System.Drawing.Point(146, 230)
        Me.txtPhone.MaxLength = 50
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(371, 26)
        Me.txtPhone.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 18)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Phone:"
        '
        'txtFax
        '
        Me.txtFax.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFax.Location = New System.Drawing.Point(146, 261)
        Me.txtFax.MaxLength = 50
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(371, 26)
        Me.txtFax.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 18)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Fax:"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(146, 168)
        Me.txtAddress.MaxLength = 200
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(371, 26)
        Me.txtAddress.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Address:"
        '
        'txtEmailAd
        '
        Me.txtEmailAd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmailAd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmailAd.Location = New System.Drawing.Point(146, 199)
        Me.txtEmailAd.MaxLength = 100
        Me.txtEmailAd.Name = "txtEmailAd"
        Me.txtEmailAd.Size = New System.Drawing.Size(371, 26)
        Me.txtEmailAd.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 18)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Email Address"
        '
        'txtAttention
        '
        Me.txtAttention.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAttention.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAttention.Location = New System.Drawing.Point(146, 136)
        Me.txtAttention.MaxLength = 50
        Me.txtAttention.Name = "txtAttention"
        Me.txtAttention.Size = New System.Drawing.Size(371, 26)
        Me.txtAttention.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Attention:"
        '
        'txtAccountsName
        '
        Me.txtAccountsName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAccountsName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAccountsName.Location = New System.Drawing.Point(146, 74)
        Me.txtAccountsName.MaxLength = 100
        Me.txtAccountsName.Name = "txtAccountsName"
        Me.txtAccountsName.Size = New System.Drawing.Size(371, 26)
        Me.txtAccountsName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 18)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Accounts Name:"
        '
        'txtSupplierId
        '
        Me.txtSupplierId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSupplierId.Location = New System.Drawing.Point(146, 11)
        Me.txtSupplierId.MaxLength = 25
        Me.txtSupplierId.Name = "txtSupplierId"
        Me.txtSupplierId.Size = New System.Drawing.Size(281, 26)
        Me.txtSupplierId.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Supplier Id"
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSupplierName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSupplierName.Location = New System.Drawing.Point(146, 43)
        Me.txtSupplierName.MaxLength = 100
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(371, 26)
        Me.txtSupplierName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 18)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Supplier Name:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(246, 386)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(186, 30)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 18)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Currency Unit:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 18)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Term of Payment"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 358)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 18)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Term of Delivery"
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRemarks.Location = New System.Drawing.Point(146, 293)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(371, 26)
        Me.txtRemarks.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 293)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 18)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Remarks:"
        '
        'cmbTOP
        '
        Me.cmbTOP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTOP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTOP.FormattingEnabled = True
        Me.cmbTOP.Location = New System.Drawing.Point(146, 324)
        Me.cmbTOP.Name = "cmbTOP"
        Me.cmbTOP.Size = New System.Drawing.Size(371, 26)
        Me.cmbTOP.TabIndex = 10
        '
        'cmbTOD
        '
        Me.cmbTOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbTOD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTOD.FormattingEnabled = True
        Me.cmbTOD.Location = New System.Drawing.Point(146, 355)
        Me.cmbTOD.Name = "cmbTOD"
        Me.cmbTOD.Size = New System.Drawing.Size(371, 26)
        Me.cmbTOD.TabIndex = 11
        '
        'chkDisuse
        '
        Me.chkDisuse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDisuse.AutoSize = True
        Me.chkDisuse.Location = New System.Drawing.Point(440, 13)
        Me.chkDisuse.Name = "chkDisuse"
        Me.chkDisuse.Size = New System.Drawing.Size(76, 22)
        Me.chkDisuse.TabIndex = 14
        Me.chkDisuse.Text = "Disuse"
        Me.chkDisuse.UseVisualStyleBackColor = True
        '
        'cmbCurrency
        '
        Me.cmbCurrency.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurrency.FormattingEnabled = True
        Me.cmbCurrency.Location = New System.Drawing.Point(146, 104)
        Me.cmbCurrency.Name = "cmbCurrency"
        Me.cmbCurrency.Size = New System.Drawing.Size(371, 26)
        Me.cmbCurrency.TabIndex = 3
        '
        'chkImport
        '
        Me.chkImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkImport.AutoSize = True
        Me.chkImport.Location = New System.Drawing.Point(446, 392)
        Me.chkImport.Name = "chkImport"
        Me.chkImport.Size = New System.Drawing.Size(70, 22)
        Me.chkImport.TabIndex = 81
        Me.chkImport.Text = "Import"
        Me.chkImport.UseVisualStyleBackColor = True
        '
        'FrmSupplierEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(530, 420)
        Me.Controls.Add(Me.chkImport)
        Me.Controls.Add(Me.cmbCurrency)
        Me.Controls.Add(Me.chkDisuse)
        Me.Controls.Add(Me.cmbTOD)
        Me.Controls.Add(Me.cmbTOP)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmailAd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAttention)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAccountsName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSupplierId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSupplierName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSupplierEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFax As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmailAd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAttention As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAccountsName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSupplierId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbTOP As ComboBox
    Friend WithEvents cmbTOD As ComboBox
    Friend WithEvents chkDisuse As CheckBox
    Friend WithEvents cmbCurrency As ComboBox
    Friend WithEvents chkImport As CheckBox
End Class
