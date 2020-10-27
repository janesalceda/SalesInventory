<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangeUOM
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCliQtyUnit = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtItemid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOldConCoe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbOldSupQtyUnit = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbOldCliQtyUnit = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNewConCoe = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbNewSupQtyUnit = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbNewCliQtyUnit = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Choose UOM:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCliQtyUnit
        '
        Me.cmbCliQtyUnit.BackColor = System.Drawing.Color.LightBlue
        Me.cmbCliQtyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliQtyUnit.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbCliQtyUnit.FormattingEnabled = True
        Me.cmbCliQtyUnit.Items.AddRange(New Object() {"Client Qty Unit", "Converting Coefficient", "Supplier Qty Unit"})
        Me.cmbCliQtyUnit.Location = New System.Drawing.Point(135, 9)
        Me.cmbCliQtyUnit.Name = "cmbCliQtyUnit"
        Me.cmbCliQtyUnit.Size = New System.Drawing.Size(241, 29)
        Me.cmbCliQtyUnit.TabIndex = 57
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(339, 348)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 36)
        Me.btnSave.TabIndex = 59
        Me.btnSave.Text = "Update"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtItemid
        '
        Me.txtItemid.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemid.Location = New System.Drawing.Point(135, 61)
        Me.txtItemid.MaxLength = 19
        Me.txtItemid.Name = "txtItemid"
        Me.txtItemid.Size = New System.Drawing.Size(377, 26)
        Me.txtItemid.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Item ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOldConCoe)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbOldSupQtyUnit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbOldCliQtyUnit)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 108)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        '
        'txtOldConCoe
        '
        Me.txtOldConCoe.BackColor = System.Drawing.Color.White
        Me.txtOldConCoe.Enabled = False
        Me.txtOldConCoe.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldConCoe.Location = New System.Drawing.Point(183, 64)
        Me.txtOldConCoe.MaxLength = 19
        Me.txtOldConCoe.Name = "txtOldConCoe"
        Me.txtOldConCoe.Size = New System.Drawing.Size(322, 26)
        Me.txtOldConCoe.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 25)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Converting Coeffiecient:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 25)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "SupplierQtyUnit:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbOldSupQtyUnit
        '
        Me.cmbOldSupQtyUnit.BackColor = System.Drawing.Color.LightBlue
        Me.cmbOldSupQtyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOldSupQtyUnit.Enabled = False
        Me.cmbOldSupQtyUnit.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbOldSupQtyUnit.FormattingEnabled = True
        Me.cmbOldSupQtyUnit.Location = New System.Drawing.Point(352, 21)
        Me.cmbOldSupQtyUnit.Name = "cmbOldSupQtyUnit"
        Me.cmbOldSupQtyUnit.Size = New System.Drawing.Size(86, 29)
        Me.cmbOldSupQtyUnit.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "ClientQtyUnit:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbOldCliQtyUnit
        '
        Me.cmbOldCliQtyUnit.BackColor = System.Drawing.Color.LightBlue
        Me.cmbOldCliQtyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOldCliQtyUnit.Enabled = False
        Me.cmbOldCliQtyUnit.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbOldCliQtyUnit.FormattingEnabled = True
        Me.cmbOldCliQtyUnit.Location = New System.Drawing.Point(126, 21)
        Me.cmbOldCliQtyUnit.Name = "cmbOldCliQtyUnit"
        Me.cmbOldCliQtyUnit.Size = New System.Drawing.Size(86, 29)
        Me.cmbOldCliQtyUnit.TabIndex = 59
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNewConCoe)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbNewSupQtyUnit)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbNewCliQtyUnit)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 108)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        '
        'txtNewConCoe
        '
        Me.txtNewConCoe.BackColor = System.Drawing.Color.White
        Me.txtNewConCoe.Enabled = False
        Me.txtNewConCoe.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewConCoe.Location = New System.Drawing.Point(183, 64)
        Me.txtNewConCoe.MaxLength = 19
        Me.txtNewConCoe.Name = "txtNewConCoe"
        Me.txtNewConCoe.Size = New System.Drawing.Size(322, 26)
        Me.txtNewConCoe.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 25)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Converting Coeffiecient:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(218, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 25)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "SupplierQtyUnit:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbNewSupQtyUnit
        '
        Me.cmbNewSupQtyUnit.BackColor = System.Drawing.Color.LightBlue
        Me.cmbNewSupQtyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewSupQtyUnit.Enabled = False
        Me.cmbNewSupQtyUnit.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbNewSupQtyUnit.FormattingEnabled = True
        Me.cmbNewSupQtyUnit.Location = New System.Drawing.Point(352, 21)
        Me.cmbNewSupQtyUnit.Name = "cmbNewSupQtyUnit"
        Me.cmbNewSupQtyUnit.Size = New System.Drawing.Size(86, 29)
        Me.cmbNewSupQtyUnit.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 25)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "ClientQtyUnit:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbNewCliQtyUnit
        '
        Me.cmbNewCliQtyUnit.BackColor = System.Drawing.Color.LightBlue
        Me.cmbNewCliQtyUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewCliQtyUnit.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cmbNewCliQtyUnit.FormattingEnabled = True
        Me.cmbNewCliQtyUnit.Location = New System.Drawing.Point(126, 21)
        Me.cmbNewCliQtyUnit.Name = "cmbNewCliQtyUnit"
        Me.cmbNewCliQtyUnit.Size = New System.Drawing.Size(86, 29)
        Me.cmbNewCliQtyUnit.TabIndex = 59
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(433, 348)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 36)
        Me.btnCancel.TabIndex = 72
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FrmChangeUOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(524, 396)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtItemid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCliQtyUnit)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmChangeUOM"
        Me.Text = "Change Item UOM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCliQtyUnit As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtItemid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbOldSupQtyUnit As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbOldCliQtyUnit As ComboBox
    Friend WithEvents txtOldConCoe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNewConCoe As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbNewSupQtyUnit As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbNewCliQtyUnit As ComboBox
    Friend WithEvents btnCancel As Button
End Class
