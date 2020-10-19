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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SQL.AddParams("@SupplierId", txtSupplierId.Text)
        SQL.ExecQuery("SELECT * FROM SUPPLIER where SupplierId=@SupplierId")
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
    End Sub

    Private Sub txtSupplierId_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierId.TextChanged
        SQL.AddParams("@SupplierId", txtSupplierId.Text)
        SQL.ExecQuery("SELECT * FROM SUPPLIER WHERE SupplierId=@SupplierId")
        If SQL.DBDT.Rows.Count = 0 Then Exit Sub

        txtSupplierId.Text = SQL.DBDT.Rows(0).Item(0)
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
    End Sub
End Class