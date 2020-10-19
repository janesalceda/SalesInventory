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
        Me.btnclear = New System.Windows.Forms.Button()
        Me.chkDisuse = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtCategoryname
        '
        Me.txtCategoryname.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCategoryname.Location = New System.Drawing.Point(142, 16)
        Me.txtCategoryname.MaxLength = 50
        Me.txtCategoryname.Name = "txtCategoryname"
        Me.txtCategoryname.Size = New System.Drawing.Size(303, 26)
        Me.txtCategoryname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Category Name:"
        '
        'btnInsert
        '
        Me.btnInsert.Enabled = False
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Location = New System.Drawing.Point(292, 55)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(116, 30)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "INSERT"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Enabled = False
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(414, 55)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(116, 30)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'chkDisuse
        '
        Me.chkDisuse.AutoSize = True
        Me.chkDisuse.Location = New System.Drawing.Point(454, 18)
        Me.chkDisuse.Name = "chkDisuse"
        Me.chkDisuse.Size = New System.Drawing.Size(76, 22)
        Me.chkDisuse.TabIndex = 1
        Me.chkDisuse.Text = "Disuse"
        Me.chkDisuse.UseVisualStyleBackColor = True
        '
        'FrmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(546, 101)
        Me.Controls.Add(Me.chkDisuse)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtCategoryname)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCategory"
        Me.Text = "Categories"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCategoryname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents chkDisuse As CheckBox
End Class
