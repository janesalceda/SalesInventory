Public Class FrmSupplierEntry
    Private Sub ViewSupplier()
        txtSupplierName.Enabled = False
        txtAttention.Enabled = False
        txtAddress.Enabled = False
        txtPhone.Enabled = False
        txtFax.Enabled = False
        txtRemarks.Enabled = False
        txtAccountsName.Enabled = False
        cmbTOD.Enabled = False
        cmbTOP.Enabled = False
        cmbCurrency.Enabled = False
        chkImport.Enabled = False
        txtEmailAd.Enabled = False
        chkDisuse.Checked = False
    End Sub
    Private Sub AddSupplier()
        txtSupplierName.Enabled = True
        txtAttention.Enabled = True
        txtAddress.Enabled = True
        txtPhone.Enabled = True
        txtFax.Enabled = True
        txtRemarks.Enabled = True
        txtAccountsName.Enabled = True
        cmbTOD.Enabled = True
        cmbTOP.Enabled = True
        cmbCurrency.Enabled = True
        chkImport.Enabled = True
        txtEmailAd.Enabled = True
        chkDisuse.Checked = False
    End Sub
    Private Sub LoadDelivery()
        cmbTOD.DataSource = getDelivery()
        cmbTOD.DisplayMember = "TermOfDelivery"
        cmbTOD.ValueMember = "TermOfDeliveryId"
    End Sub

    Private Sub LoadPayment()
        cmbTOP.DataSource = getPayment()
        cmbTOP.DisplayMember = "TermOfPayment"
        cmbTOP.ValueMember = "TermOfPaymentId"
    End Sub
    Private Sub LoadCurrency()
        cmbCurrency.DataSource = GetCurrency()
        cmbCurrency.DisplayMember = "CurrencyUnit"
        cmbCurrency.ValueMember = "CurrencyUnitId"
    End Sub
    Private Sub LoadData()
        SQL.AddParams("@supplierid", txtSupplierId.Text)
        SQL.ExecQuery("SELECT * FROM SUPPLIERS where Supplierid=@supplierid")
        If SQL.HasException Then Exit Sub

        txtSupplierName.Text = SQL.DBDT.Rows(0).Item(1)
        txtAttention.Text = SQL.DBDT.Rows(0).Item(2)
        txtAddress.Text = SQL.DBDT.Rows(0).Item(3)
        txtPhone.Text = SQL.DBDT.Rows(0).Item(4)
        txtFax.Text = SQL.DBDT.Rows(0).Item(5)
        txtRemarks.Text = SQL.DBDT.Rows(0).Item(6)
        txtAccountsName.Text = SQL.DBDT.Rows(0).Item(7)
        cmbTOD.SelectedValue = SQL.DBDT.Rows(0).Item(8)
        cmbTOP.SelectedValue = SQL.DBDT.Rows(0).Item(9)
        cmbCurrency.SelectedValue = SQL.DBDT.Rows(0).Item(10)
        chkImport.Checked = SQL.DBDT.Rows(0).Item(11)
        txtEmailAd.Text = SQL.DBDT.Rows(0).Item(12)
        If Not String.IsNullOrEmpty(SQL.DBDT.Rows(0).Item(14).ToString) Then
            chkDisuse.Checked = True
        Else
            chkDisuse.Checked = False
        End If
    End Sub
    Private Sub AddSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadCurrency()
        LoadPayment()
        LoadDelivery()

        If btnSave.Text = "UPDATE" Then
            LoadData()
            ViewSupplier()
        Else
            AddSupplier()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim complete As String = "Please input the ff:" & vbNewLine
            If String.IsNullOrWhiteSpace(txtSupplierId.Text) Then
                complete += "*Supplierid"
            End If
            If String.IsNullOrWhiteSpace(txtSupplierName.Text) Then
                complete += "*SupplierName" & vbNewLine
            End If
            If String.IsNullOrWhiteSpace(txtAccountsName.Text) Then
                complete += "*AccountsName" & vbNewLine
            End If
            If cmbCurrency.SelectedIndex = -1 Then
                complete += "*Currency" & vbNewLine
            End If
            If String.IsNullOrWhiteSpace(txtSupplierId.Text) Then
                complete += "*Attention" & vbNewLine
            End If
            If String.IsNullOrWhiteSpace(txtSupplierId.Text) Then
                complete += "*Address" & vbNewLine
            End If
            If String.IsNullOrWhiteSpace(txtSupplierId.Text) Then
                complete += "*EmailAddress" & vbNewLine
            End If
            If String.IsNullOrWhiteSpace(txtSupplierId.Text) Then
                complete += "*Phone" & vbNewLine
            End If
            If cmbCurrency.SelectedIndex = -1 Then
                complete += "*Terms of Payment" & vbNewLine
            End If
            If cmbCurrency.SelectedIndex = -1 Then
                complete += "*Terms of Delivery" & vbNewLine
            End If
            If complete <> "Please input the ff:" & vbNewLine Then
                msgboxDisplay(complete, 2)
                Exit Sub
            End If
            SQL.AddParams("@SupplierId", txtSupplierId.Text)
            SQL.ExecQuery("SELECT * FROM SUPPLIERs where SupplierId=@SupplierId")
            If SQL.DBDT.Rows.Count > 0 Then MsgBox("SupplierId already exists!", MsgBoxStyle.Critical, "Error")
            SQL.AddParams("@SupplierId", txtSupplierId.Text)
            SQL.AddParams("@SupplierName", txtSupplierName.Text)
            SQL.AddParams("@Attention", txtAttention.Text)
            SQL.AddParams("@Address", txtAddress.Text)
            SQL.AddParams("@Phone", txtPhone.Text)
            SQL.AddParams("@Fax", txtFax.Text)
            SQL.AddParams("@Remarks", txtRemarks.Text)
            SQL.AddParams("@AccountsName", txtAccountsName.Text)
            SQL.AddParams("@TermOfDeliveryId", cmbTOD.SelectedValue)
            SQL.AddParams("@TermOfPaymentId", cmbTOP.SelectedValue)
            SQL.AddParams("@CurrencyUnitId", cmbCurrency.SelectedValue)
            SQL.AddParams("@ImportSupplier", chkImport.Checked)
            SQL.AddParams("@EmailAddress", txtEmailAd.Text)
            SQL.AddParams("@UpdatedBy", moduleId)
            SQL.ExecQuery("INSERT INTO Suppliers(SupplierId,SupplierName,Attention,
                Address,Phone,Fax,Remarks,AccountsName,TermOfDeliveryId,TermOfPaymentId,
                CurrencyUnitId,ImportSupplier,EmailAddress,UpdatedBy)
                VALUES(@SupplierId,@SupplierName,@Attention,@Address,@Phone,@Fax,@Remarks,@AccountsName,@TermOfDeliveryId,@TermOfPaymentId,
                    @CurrencyUnitId,@ImportSupplier,@EmailAddress,@UpdatedBy)")

            If SQL.HasException Then Exit Sub
            MsgBox("Successfully saved", MsgBoxStyle.Information, "Information")
            Me.Close()
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub

    Private Sub TxtSupplierId_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierId.TextChanged
        Try
            If btnSave.Text = "UPDATE" Then
                SQL.AddParams("@SupplierId", txtSupplierId.Text)
                SQL.ExecQuery("SELECT * FROM SUPPLIERs WHERE SupplierId=@SupplierId")
                If SQL.DBDT.Rows.Count = 0 Then Exit Sub
                txtSupplierId.Text = SQL.DBDT.Rows(0).Item(0)
                txtSupplierName.Text = SQL.DBDT.Rows(0).Item(1)
                txtAttention.Text = SQL.DBDT.Rows(0).Item(2)
                txtAddress.Text = SQL.DBDT.Rows(0).Item(3)
                txtPhone.Text = SQL.DBDT.Rows(0).Item(4)
                txtFax.Text = SQL.DBDT.Rows(0).Item(5)
                txtRemarks.Text = SQL.DBDT.Rows(0).Item(6)
                txtAccountsName.Text = SQL.DBDT.Rows(0).Item(7)
                cmbTOD.Text = SQL.DBDT.Rows(0).Item(8)
                cmbTOP.Text = SQL.DBDT.Rows(0).Item(9)
                cmbCurrency.Text = SQL.DBDT.Rows(0).Item(10)
                chkImport.Checked = SQL.DBDT.Rows(0).Item(11)
                txtEmailAd.Text = SQL.DBDT.Rows(0).Item(12)
            End If
        Catch ex As Exception
            msgboxDisplay(ex.Message, 3)
            Exit Sub
        End Try
    End Sub
    Private Sub CmbCurrency_GotFocus(sender As Object, e As EventArgs) Handles cmbCurrency.GotFocus
        LoadCurrency()
    End Sub

    Private Sub CmbTOP_GotFocus(sender As Object, e As EventArgs) Handles cmbTOP.GotFocus
        LoadPayment()
    End Sub
    Private Sub CmbTOD_GotFocus(sender As Object, e As EventArgs) Handles cmbTOD.GotFocus
        LoadDelivery()
    End Sub

End Class