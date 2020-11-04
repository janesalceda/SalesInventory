Public Class FrmCompanyInfo
    Dim op As OpenFileDialog = New OpenFileDialog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If op.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(op.FileName)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim where As String = ""
            If Not String.IsNullOrWhiteSpace(op.FileName) Then
                Dim filename As String = op.FileName & ".jpg"
                Dim mstream As New System.IO.MemoryStream()
                PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer()
                mstream.Close()

                SQL.AddParams("@companylogo", arrImage)
                where = " ,CompanyLogo=@companylogo"
            End If
            'Dim filesize = mstream.Length
            SQL.AddParams("@companyname", txtCompany.Text)
            SQL.AddParams("@website", txtWeb.Text)
            SQL.AddParams("@streetadress", txtStreet.Text)
            SQL.AddParams("@cityzip", txtZip.Text)
            SQL.AddParams("@phone", txtPhone.Text)
            SQL.AddParams("@fax", txtFax.Text)
            If Button2.Text = "Save" Then
                SQL.ExecQuery("INSERT INTO dbo.CompanyInfo
	                (
	                CompanyName,
	                StreetAdress,
	                CityZip,
	                Phone,
	                Fax,
	                website,
	                CompanyLogo
	                )
                VALUES 
	                (
	                @companyname,
	                @streetadress,
	                @cityzip,
	                @phone,
	                @fax,
	                @website,
	                @companylogo
	                )
                ")
            Else
                SQL.ExecQuery("update  dbo.CompanyInfo
	        set
	        CompanyName= @companyname,
	        StreetAdress=@streetadress,
	        CityZip=@cityzip,
	        Phone=@phone,
	        Fax=@fax,
	        website=@website" & where)
            End If
            If SQL.HasException Then
                MsgBox("Failed to upload", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            MsgBox("Successfully uploaded!", MsgBoxStyle.Information, "Information")
            Close()
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub FrmCompanyInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL.ExecQuery("Select * From companyinfo")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub
        Button2.Text = "UPDATE"
        Dim picbyte() As Byte = SQL.DBDT.Rows(0).Item("CompanyLogo")
        Dim pic As New System.IO.MemoryStream(picbyte)
        PictureBox1.Image = Image.FromStream(pic)
        pic.Close()
        txtCompany.Text = SQL.DBDT.Rows(0).Item("CompanyName")
        txtFax.Text = SQL.DBDT.Rows(0).Item("Fax")
        txtPhone.Text = SQL.DBDT.Rows(0).Item("Phone")
        txtStreet.Text = SQL.DBDT.Rows(0).Item("StreetAdress")
        txtWeb.Text = SQL.DBDT.Rows(0).Item("website")
        txtZip.Text = SQL.DBDT.Rows(0).Item("CityZip")
    End Sub

End Class