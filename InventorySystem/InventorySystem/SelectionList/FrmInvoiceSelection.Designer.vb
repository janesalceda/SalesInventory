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
        Me.btnOk.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Location = New System.Drawing.Point(468, 319)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(61, 26)
        Me.btnOk.TabIndex = 81
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'dtitems
        '
        Me.dtitems.AllowUserToAddRows = False
        Me.dtitems.AllowUserToDeleteRows = False
        Me.dtitems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtitems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtitems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seq, Me.ItemID, Me.ItemName, Me.PONo, Me.POSeq, Me.qtyexpected})
        Me.dtitems.Location = New System.Drawing.Point(7, 11)
        Me.dtitems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtitems.Name = "dtitems"
        Me.dtitems.ReadOnly = True
        Me.dtitems.RowHeadersVisible = False
        Me.dtitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtitems.Size = New System.Drawing.Size(522, 302)
        Me.dtitems.TabIndex = 73
        '
        'Seq
        '
        Me.Seq.HeaderText = "Seq"
        Me.Seq.Name = "Seq"
        Me.Seq.ReadOnly = True
        Me.Seq.Width = 54
        '
        'ItemID
        '
        Me.ItemID.HeaderText = "ItemID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        Me.ItemID.Width = 68
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Description"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 95
        '
        'PONo
        '
        Me.PONo.HeaderText = "PONo"
        Me.PONo.Name = "PONo"
        Me.PONo.ReadOnly = True
        Me.PONo.Width = 65
        '
        'POSeq
        '
        Me.POSeq.HeaderText = "Seq"
        Me.POSeq.Name = "POSeq"
        Me.POSeq.ReadOnly = True
        Me.POSeq.Width = 54
        '
        'qtyexpected
        '
        Me.qtyexpected.HeaderText = "QtyExpected"
        Me.qtyexpected.Name = "qtyexpected"
        Me.qtyexpected.ReadOnly = True
        Me.qtyexpected.Width = 99
        '
        'FrmInvoiceSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(539, 351)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.dtitems)
        Me.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInvoiceSelection"
        Me.Text = "List of Invoice"
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
