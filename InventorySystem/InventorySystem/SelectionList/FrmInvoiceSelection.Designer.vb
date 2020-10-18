<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInvoiceSelection
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.dtitems = New System.Windows.Forms.DataGridView()
        Me.Seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PONo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSeq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtyexpected = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Location = New System.Drawing.Point(602, 383)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(78, 31)
        Me.btnOk.TabIndex = 81
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'dtitems
        '
        Me.dtitems.AllowUserToAddRows = False
        Me.dtitems.AllowUserToDeleteRows = False
        Me.dtitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.ItemID, Me.ItemName, Me.PONo, Me.POSeq, Me.qtyexpected})
        Me.dtitems.Location = New System.Drawing.Point(9, 13)
        Me.dtitems.Margin = New System.Windows.Forms.Padding(4)
        Me.dtitems.Name = "dtitems"
        Me.dtitems.ReadOnly = True
        Me.dtitems.RowHeadersVisible = False
        Me.dtitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtitems.Size = New System.Drawing.Size(671, 362)
        Me.dtitems.TabIndex = 73
        '
        'Seq
        '
        Me.Seq.HeaderText = "Seq"
        Me.Seq.Name = "Seq"
        Me.Seq.ReadOnly = True
        '
        'ItemID
        '
        Me.ItemID.HeaderText = "ItemID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "ItemName"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'PONo
        '
        Me.PONo.HeaderText = "PONo"
        Me.PONo.Name = "PONo"
        Me.PONo.ReadOnly = True
        '
        'POSeq
        '
        Me.POSeq.HeaderText = "POSeq"
        Me.POSeq.Name = "POSeq"
        Me.POSeq.ReadOnly = True
        '
        'qtyexpected
        '
        Me.qtyexpected.HeaderText = "qtyexpected"
        Me.qtyexpected.Name = "qtyexpected"
        Me.qtyexpected.ReadOnly = True
        '
        'FrmInvoiceSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 421)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dtitems)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInvoiceSelection"
        Me.Text = "FrmInvoiceSelection"
        CType(Me.dtitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents dtitems As DataGridView
    Friend WithEvents Seq As DataGridViewTextBoxColumn
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents PONo As DataGridViewTextBoxColumn
    Friend WithEvents POSeq As DataGridViewTextBoxColumn
    Friend WithEvents qtyexpected As DataGridViewTextBoxColumn
End Class
