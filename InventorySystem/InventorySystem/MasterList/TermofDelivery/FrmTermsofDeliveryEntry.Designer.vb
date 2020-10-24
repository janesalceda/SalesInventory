<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTermsofDeliveryEntry
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
        Me.txtTD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkDisuse = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtTD
        '
        Me.txtTD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTD.Location = New System.Drawing.Point(160, 18)
        Me.txtTD.MaxLength = 100
        Me.txtTD.Name = "txtTD"
        Me.txtTD.Size = New System.Drawing.Size(284, 26)
        Me.txtTD.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 18)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Terms of Delivery:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(234, 90)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(174, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtDes
        '
        Me.txtDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDes.Location = New System.Drawing.Point(160, 54)
        Me.txtDes.MaxLength = 150
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(373, 26)
        Me.txtDes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Description:"
        '
        'chkDisuse
        '
        Me.chkDisuse.AutoSize = True
        Me.chkDisuse.Location = New System.Drawing.Point(451, 17)
        Me.chkDisuse.Name = "chkDisuse"
        Me.chkDisuse.Size = New System.Drawing.Size(76, 22)
        Me.chkDisuse.TabIndex = 2
        Me.chkDisuse.Text = "Disuse"
        Me.chkDisuse.UseVisualStyleBackColor = True
        '
        'FrmTermsofDeliveryEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(546, 132)
        Me.Controls.Add(Me.chkDisuse)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTD)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmTermsofDeliveryEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmTermsofDelivery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtDes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkDisuse As CheckBox
End Class
