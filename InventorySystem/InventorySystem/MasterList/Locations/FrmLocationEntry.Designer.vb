<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLocationEntry
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
        Me.chkDisuse = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtQtyunit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkDisuse
        '
        Me.chkDisuse.AutoSize = True
        Me.chkDisuse.Enabled = False
        Me.chkDisuse.Location = New System.Drawing.Point(341, 19)
        Me.chkDisuse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkDisuse.Name = "chkDisuse"
        Me.chkDisuse.Size = New System.Drawing.Size(70, 20)
        Me.chkDisuse.TabIndex = 65
        Me.chkDisuse.Text = "Disuse"
        Me.chkDisuse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Description"
        '
        'txtDes
        '
        Me.txtDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDes.Location = New System.Drawing.Point(113, 42)
        Me.txtDes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtDes.MaxLength = 50
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(293, 23)
        Me.txtDes.TabIndex = 64
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.ForeColor = System.Drawing.Color.Black
        Me.btnInsert.Location = New System.Drawing.Point(166, 73)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(135, 27)
        Me.btnInsert.TabIndex = 66
        Me.btnInsert.Text = "SAVE"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'txtQtyunit
        '
        Me.txtQtyunit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQtyunit.Location = New System.Drawing.Point(111, 13)
        Me.txtQtyunit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtQtyunit.MaxLength = 50
        Me.txtQtyunit.Name = "txtQtyunit"
        Me.txtQtyunit.Size = New System.Drawing.Size(191, 23)
        Me.txtQtyunit.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Location"
        '
        'FrmLocationEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 108)
        Me.Controls.Add(Me.chkDisuse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtQtyunit)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLocationEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmLocation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkDisuse As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDes As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtQtyunit As TextBox
    Friend WithEvents Label1 As Label
End Class
