<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangeSupplierName
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
        Me.txtSupid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCurSupname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnewSupName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSupid
        '
        Me.txtSupid.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSupid.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSupid.Location = New System.Drawing.Point(94, 11)
        Me.txtSupid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSupid.MaxLength = 19
        Me.txtSupid.Name = "txtSupid"
        Me.txtSupid.Size = New System.Drawing.Size(218, 23)
        Me.txtSupid.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Supplier ID:"
        '
        'txtCurSupname
        '
        Me.txtCurSupname.BackColor = System.Drawing.Color.White
        Me.txtCurSupname.Enabled = False
        Me.txtCurSupname.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCurSupname.Location = New System.Drawing.Point(10, 73)
        Me.txtCurSupname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCurSupname.MaxLength = 19
        Me.txtCurSupname.Multiline = True
        Me.txtCurSupname.Name = "txtCurSupname"
        Me.txtCurSupname.Size = New System.Drawing.Size(302, 44)
        Me.txtCurSupname.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Current Supplier Name:"
        '
        'txtnewSupName
        '
        Me.txtnewSupName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnewSupName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtnewSupName.Location = New System.Drawing.Point(10, 150)
        Me.txtnewSupName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtnewSupName.MaxLength = 19
        Me.txtnewSupName.Multiline = True
        Me.txtnewSupName.Name = "txtnewSupName"
        Me.txtnewSupName.Size = New System.Drawing.Size(302, 44)
        Me.txtnewSupName.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "New Supplier Name:"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(176, 206)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(67, 31)
        Me.btnUpdate.TabIndex = 73
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LightCoral
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(248, 206)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 32)
        Me.btnCancel.TabIndex = 74
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FrmChangeSupplierName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(318, 252)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtnewSupName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCurSupname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSupid)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmChangeSupplierName"
        Me.Text = "Change Supplier Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSupid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCurSupname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnewSupName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
