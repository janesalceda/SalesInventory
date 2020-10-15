<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.picItems = New System.Windows.Forms.PictureBox()
        Me.picStocks = New System.Windows.Forms.PictureBox()
        Me.picSales = New System.Windows.Forms.PictureBox()
        Me.picUser = New System.Windows.Forms.PictureBox()
        Me.picReport = New System.Windows.Forms.PictureBox()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.picItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picItems
        '
        Me.picItems.Image = CType(resources.GetObject("picItems.Image"), System.Drawing.Image)
        Me.picItems.Location = New System.Drawing.Point(50, 13)
        Me.picItems.Margin = New System.Windows.Forms.Padding(5, 4, 4, 5)
        Me.picItems.Name = "picItems"
        Me.picItems.Padding = New System.Windows.Forms.Padding(4)
        Me.picItems.Size = New System.Drawing.Size(90, 105)
        Me.picItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picItems.TabIndex = 0
        Me.picItems.TabStop = False
        '
        'picStocks
        '
        Me.picStocks.BackColor = System.Drawing.Color.White
        Me.picStocks.Image = CType(resources.GetObject("picStocks.Image"), System.Drawing.Image)
        Me.picStocks.Location = New System.Drawing.Point(216, 13)
        Me.picStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.picStocks.Name = "picStocks"
        Me.picStocks.Size = New System.Drawing.Size(90, 105)
        Me.picStocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStocks.TabIndex = 1
        Me.picStocks.TabStop = False
        '
        'picSales
        '
        Me.picSales.BackColor = System.Drawing.Color.White
        Me.picSales.Image = CType(resources.GetObject("picSales.Image"), System.Drawing.Image)
        Me.picSales.Location = New System.Drawing.Point(392, 13)
        Me.picSales.Margin = New System.Windows.Forms.Padding(4)
        Me.picSales.Name = "picSales"
        Me.picSales.Size = New System.Drawing.Size(90, 105)
        Me.picSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSales.TabIndex = 3
        Me.picSales.TabStop = False
        '
        'picUser
        '
        Me.picUser.BackColor = System.Drawing.Color.White
        Me.picUser.Image = CType(resources.GetObject("picUser.Image"), System.Drawing.Image)
        Me.picUser.Location = New System.Drawing.Point(552, 13)
        Me.picUser.Margin = New System.Windows.Forms.Padding(4)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(90, 105)
        Me.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUser.TabIndex = 4
        Me.picUser.TabStop = False
        '
        'picReport
        '
        Me.picReport.BackColor = System.Drawing.Color.White
        Me.picReport.Image = CType(resources.GetObject("picReport.Image"), System.Drawing.Image)
        Me.picReport.Location = New System.Drawing.Point(723, 13)
        Me.picReport.Margin = New System.Windows.Forms.Padding(4)
        Me.picReport.Name = "picReport"
        Me.picReport.Size = New System.Drawing.Size(90, 105)
        Me.picReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picReport.TabIndex = 5
        Me.picReport.TabStop = False
        '
        'picExit
        '
        Me.picExit.BackColor = System.Drawing.Color.White
        Me.picExit.Image = CType(resources.GetObject("picExit.Image"), System.Drawing.Image)
        Me.picExit.Location = New System.Drawing.Point(896, 13)
        Me.picExit.Margin = New System.Windows.Forms.Padding(4)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(90, 105)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExit.TabIndex = 6
        Me.picExit.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 3.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(-1, 125)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1068, 5)
        Me.TextBox1.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 569)
        Me.Panel1.TabIndex = 8
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 700)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.picReport)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.picSales)
        Me.Controls.Add(Me.picStocks)
        Me.Controls.Add(Me.picItems)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        CType(Me.picItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picItems As PictureBox
    Friend WithEvents picStocks As PictureBox
    Friend WithEvents picSales As PictureBox
    Friend WithEvents picUser As PictureBox
    Friend WithEvents picReport As PictureBox
    Friend WithEvents picExit As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
End Class
