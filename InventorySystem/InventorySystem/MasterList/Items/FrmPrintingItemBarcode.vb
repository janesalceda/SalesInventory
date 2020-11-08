Imports QRCoder
Imports ZXing
Public Class FrmPrintingItemBarcode
    Public formname As String
    Dim pic As New PictureBox
    Dim w As Integer = 223
    Dim h As Integer = 74
    Private num1 As Integer
    Private count As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim img As Image
        Dim pic As New PictureBox
        If formname = "Bar" Then
            Dim barcode As New BarcodeLib.Barcode
            img = barcode.Encode(BarcodeLib.TYPE.CODE39, Trim(FrmItemEntry.txtItemId.Text), Color.Black, Color.White, 200, 30)
        Else
            Dim qrCoder As New QRCodeGenerator
            Dim data = qrCoder.CreateQrCode(FrmItemEntry.txtItemId.Text, QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As New QRCode(data)
            img = qrCode.GetGraphic(6)
        End If
        pic.Image = img
        DataSet81.Clear()

        Dim mstream As New System.IO.MemoryStream()
        pic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
        Dim arrImage() As Byte = mstream.GetBuffer()
            mstream.Close()
        For i As Integer = 0 To Val(TextBox1.Text) - 1
            DataSet81.DataTable1.AddDataTable1Row(i, Trim(FrmItemEntry.txtItemId.Text), arrImage, Trim(FrmItemEntry.txtDes.Text))
        Next

        If formname = "Bar" Then
            PrintPreviewBarcode.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            'PrintPreviewBarcode.ReportViewer1.ZoomMode = ZoomMode.Percent
            PrintPreviewBarcode.ReportViewer1.ZoomPercent = 100
            PrintPreviewBarcode.barcode = DataSet81.DataTable1
            PrintPreviewBarcode.ShowDialog()
        Else
            PrintingQR.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            'PrintingQR.ReportViewer1.ZoomMode = ZoomMode.Percent
            PrintingQR.ReportViewer1.ZoomPercent = 100
            PrintingQR.barcode = DataSet81.DataTable1
            PrintingQR.ShowDialog()
        End If


        'Try
        '    If String.IsNullOrWhiteSpace(TextBox1.Text) Then Exit Sub
        '    QtyPrint = Val(TextBox1.Text)
        '    If formname = "Bar" Then
        '        Dim writer As New BarcodeWriter
        '        writer.Format = BarcodeFormat.CODE_128
        '        pic.Image = writer.Write(FrmItemEntry.txtItemId.Text)
        '    Else
        '        Dim qrCoder As New QRCodeGenerator
        '        Dim data = qrCoder.CreateQrCode(FrmItemEntry.txtItemId.Text, QRCodeGenerator.ECCLevel.Q)
        '        Dim qrCode As New QRCode(data)
        '        pic.Image = qrCode.GetGraphic(6)
        '        w = 100
        '        h = 100
        '    End If
        '    num1 = 0
        '    PrintPreviewDialog1.Show()
        '    Me.Close()
        '    Timer1.Start()

        'Catch ex As Exception
        '    msgboxDisplay(ex.Message, 3)
        '    Exit Sub
        'End Try
    End Sub
    Public Function AppendBorder(ByVal original As Image, ByVal borderWidth As Integer) As Image

        Dim borderColor As Color = Color.Black
        Dim mypen As New Pen(borderColor, borderWidth * 2)
        Dim newSize As Size = New Size(original.Width + borderWidth * 4, original.Height + borderWidth * 2)

        Dim img As Bitmap = New Bitmap(newSize.Width, newSize.Height)
        Dim g As Graphics = Graphics.FromImage(img)

        'g.Clear(borderColor)   
        g.DrawImage(original, New Point(borderWidth, borderWidth))
        g.DrawRectangle(mypen, 0, 0, newSize.Width, newSize.Height)
        g.Dispose()

        Return img
    End Function
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim x As Integer = 10
            Dim y As Integer = 10
            Dim lx As Integer = 0
            Dim ly As Integer = 0
            Dim num As Integer = 0
            Dim remaining As Integer
            remaining = QtyPrint
            If formname = "QR" Then
                x = 10
                lx = 0

                num = Math.Ceiling(remaining / 2)
            Else
                x = 10

                num = Math.Ceiling(remaining / 3)
            End If

            While num1 <= num
                ' For i As Integer = 1 To num
                If formname = "QR" Then
                    x = 10
                    lx = 0
                Else
                    x = 40
                End If
                Dim roration As Integer
                Dim cut As Integer = 0
                If formname = "Bar" Then
                    cut = 3
                Else
                    cut = 2
                End If
                If remaining - cut >= 0 Then
                    roration = cut
                Else
                    roration = remaining
                End If
                For j As Integer = 1 To roration
                    remaining -= 1
                    If formname = "QR" Then
                        pic.BackColor = Color.Transparent
                        e.Graphics.DrawRectangle(New Pen(Color.Black), lx, ly, 440, 180)
                        e.Graphics.DrawImage(AppendBorder(pic.Image, 2), x + 20, y, w, h)
                        e.Graphics.DrawString(FrmItemEntry.txtItemId.Text, New Font("Arial black", 16), Brushes.Black, x + 150, y + 20)
                        e.Graphics.DrawImage(AppendBorder(pic.Image, 2), x + w + 190, y + h - 50, w, h)
                        e.Graphics.DrawString(FrmItemEntry.txtDes.Text, New Font("Arial black", 8), Brushes.Black, x + 20, y + h)
                    Else
                        e.Graphics.DrawImage(AppendBorder(pic.Image, 2), x, y, w, h)
                    End If
                    If formname = "QR" Then
                        x = x + w + 330
                        lx = lx + 440
                    Else
                        x = x + w + 30
                    End If
                Next

                num1 += 1

                ' e.HasMorePages = num1 <= num
                If formname = "QR" Then
                    y = y + h + 80
                    ly = ly + h + 80
                Else
                    y = y + h + 10

                End If
            End While
            'Next

        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub


    Private Sub FrmPrintingItemBarcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count += 1
        If count = 10 Then
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub
End Class