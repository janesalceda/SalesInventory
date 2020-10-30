<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangeItemDescription
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
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCurDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtItemId
        '
        Me.txtItemId.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemId.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtItemId.Location = New System.Drawing.Point(60, 11)
        Me.txtItemId.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtItemId.MaxLength = 19
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(266, 23)
        Me.txtItemId.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Item ID:"
        '
        'txtCurDescription
        '
        Me.txtCurDescription.BackColor = System.Drawing.Color.White
        Me.txtCurDescription.Enabled = False
        Me.txtCurDescription.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCurDescription.Location = New System.Drawing.Point(9, 63)
        Me.txtCurDescription.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCurDescription.MaxLength = 19
        Me.txtCurDescription.Name = "txtCurDescription"
        Me.txtCurDescription.Size = New System.Drawing.Size(315, 23)
        Me.txtCurDescription.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Current Item Description:"
        '
        'txtNewDescription
        '
        Me.txtNewDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNewDescription.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtNewDescription.Location = New System.Drawing.Point(9, 113)
        Me.txtNewDescription.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNewDescription.MaxLength = 19
        Me.txtNewDescription.Name = "txtNewDescription"
        Me.txtNewDescription.Size = New System.Drawing.Size(315, 23)
        Me.txtNewDescription.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(7, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "New Item Description"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Location = New System.Drawing.Point(180, 141)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(65, 32)
        Me.btnUpdate.TabIndex = 69
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(250, 141)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 32)
        Me.btnCancel.TabIndex = 73
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'FrmChangeItemDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 183)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNewDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCurDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtItemId)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmChangeItemDescription"
        Me.Text = "Change Item Description"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItemId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCurDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
