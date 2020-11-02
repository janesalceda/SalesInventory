<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategoryEntry
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
        Me.txtCategoryname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.chkDisuse = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtCategoryname
        '
        Me.txtCategoryname.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCategoryname.Location = New System.Drawing.Point(111, 14)
        Me.txtCategoryname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCategoryname.MaxLength = 50
        Me.txtCategoryname.Name = "txtCategoryname"
        Me.txtCategoryname.Size = New System.Drawing.Size(237, 23)
        Me.txtCategoryname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Category Name:"
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnInsert.Enabled = False
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.ForeColor = System.Drawing.Color.Black
        Me.btnInsert.Location = New System.Drawing.Point(160, 46)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(135, 27)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "SAVE"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'chkDisuse
        '
        Me.chkDisuse.AutoSize = True
        Me.chkDisuse.Enabled = False
        Me.chkDisuse.Location = New System.Drawing.Point(354, 16)
        Me.chkDisuse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkDisuse.Name = "chkDisuse"
        Me.chkDisuse.Size = New System.Drawing.Size(70, 20)
        Me.chkDisuse.TabIndex = 1
        Me.chkDisuse.Text = "Disuse"
        Me.chkDisuse.UseVisualStyleBackColor = True
        '
        'FrmCategoryEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 83)
        Me.Controls.Add(Me.chkDisuse)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtCategoryname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCategoryEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Categories"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCategoryname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents chkDisuse As CheckBox
End Class
