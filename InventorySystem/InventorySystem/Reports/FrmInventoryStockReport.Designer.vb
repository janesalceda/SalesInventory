<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventoryStockReport
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtitem = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.TransactionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OUTQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACQTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANCE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Date:"
        '
        'txtitem
        '
        Me.txtitem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtitem.Location = New System.Drawing.Point(48, 5)
        Me.txtitem.Margin = New System.Windows.Forms.Padding(2)
        Me.txtitem.MaxLength = 20
        Me.txtitem.Name = "txtitem"
        Me.txtitem.Size = New System.Drawing.Size(214, 23)
        Me.txtitem.TabIndex = 11
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Location = New System.Drawing.Point(279, 4)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(103, 27)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "~"
        '
        'dtTo
        '
        Me.dtTo.Location = New System.Drawing.Point(281, 34)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(2)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(209, 23)
        Me.dtTo.TabIndex = 14
        '
        'dtFrom
        '
        Me.dtFrom.Location = New System.Drawing.Point(48, 34)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(2)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(214, 23)
        Me.dtFrom.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Items:"
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionDate, Me.TRANSID, Me.INQTY, Me.OUTQTY, Me.ACQTY, Me.BALANCE, Me.Remarks})
        Me.dgvData.Location = New System.Drawing.Point(448, 2)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(42, 43)
        Me.dgvData.TabIndex = 17
        Me.dgvData.Visible = False
        '
        'TransactionDate
        '
        Me.TransactionDate.HeaderText = "Transaction Date"
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.ReadOnly = True
        '
        'TRANSID
        '
        Me.TRANSID.HeaderText = "TRANSID"
        Me.TRANSID.Name = "TRANSID"
        Me.TRANSID.ReadOnly = True
        '
        'INQTY
        '
        Me.INQTY.HeaderText = "IN QTY"
        Me.INQTY.Name = "INQTY"
        Me.INQTY.ReadOnly = True
        '
        'OUTQTY
        '
        Me.OUTQTY.HeaderText = "OUT QTY"
        Me.OUTQTY.Name = "OUTQTY"
        Me.OUTQTY.ReadOnly = True
        '
        'ACQTY
        '
        Me.ACQTY.HeaderText = "AC QTY"
        Me.ACQTY.Name = "ACQTY"
        Me.ACQTY.ReadOnly = True
        '
        'BALANCE
        '
        Me.BALANCE.HeaderText = "BALANCE"
        Me.BALANCE.Name = "BALANCE"
        Me.BALANCE.ReadOnly = True
        '
        'Remarks
        '
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ReadOnly = True
        '
        'FrmInventoryStockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 75)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtitem)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtFrom)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Name = "FrmInventoryStockReport"
        Me.Text = "Inventory Stock Report"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtitem As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtTo As DateTimePicker
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents TRANSID As DataGridViewTextBoxColumn
    Friend WithEvents INQTY As DataGridViewTextBoxColumn
    Friend WithEvents OUTQTY As DataGridViewTextBoxColumn
    Friend WithEvents ACQTY As DataGridViewTextBoxColumn
    Friend WithEvents BALANCE As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
End Class
