Imports QRCoder
Imports ZXing
Public Class FrmPrintingItemBarcode
    Public formname As String
    Dim pic As New PictureBox
    Dim w As Integer = 223
    Dim h As Integer = 74
    Private num1 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formname = "Bar" Then
            Dim writer As New BarcodeWriter
            writer.Format = BarcodeFormat.CODE_128
            pic.Image = writer.Write(FrmItemEntry.txtItemId.Text)
        Else
            Dim qrCoder As New QRCodeGenerator
            Dim data = qrCoder.CreateQrCode(FrmItemEntry.txtItemId.Text, QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As New QRCode(data)
            pic.Image = qrCode.GetGraphic(6)
            w = 100
            h = 100
        End If

        'PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Legal", 850, 110)
        'ppd.WindowState = FormWindowState.Maximized
        'ppd.show()
        ' PrintDocument1.Print()
        num1 = 0
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Integer = 10
        Dim y As Integer = 10
        Dim lx As Integer = 0
        Dim ly As Integer = 0
        Dim num As Integer = 0
        Dim remaining As Integer
        remaining = Val(TextBox1.Text)
        num = Math.Ceiling(remaining / 3)

        If formname = "QR" Then e.Graphics.DrawLine(New Pen(Color.Black), x + 380, 1, x + 380, 2000)
        While num1 < num
            ' For i As Integer = 1 To num
            x = 0
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
                    ' e.Graphics.DrawLine(New Pen(Color.Black), 1, y - 10, 900, y - 10)
                    e.Graphics.DrawImage(pic.Image, x + 20, y + 10, w, h)
                    e.Graphics.DrawString(FrmItemEntry.txtItemId.Text, New Font("Arial black", 16), Brushes.Black, x + w + 25, y + 30)
                    e.Graphics.DrawImage(pic.Image, x + w + 150, y + h - 40, w, h)
                    e.Graphics.DrawLine(New Pen(Color.Black), 1, y + lx, 900, y + lx)
                    'e.HasMorePages = True
                Else
                    e.Graphics.DrawImage(pic.Image, x, y, w, h)
                End If
                If formname = "QR" Then
                    x = x + w + 270
                Else
                    x = x + w + 40
                End If
            Next

            num1 += 1

            e.HasMorePages = num1 <= num
            If formname = "QR" Then
                y = y + h + 100
                lx = lx + 20
            Else
                y = y + h + 40

            End If
        End While
        'Next
    End Sub

End Class