Public Class AddSupplier
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
    End Sub
    Private Sub AddSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCurrency()
        LoadPayment()
        LoadDelivery()
        If btnSave.Text = "UPDATE" Then
            LoadData()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
        MsgBox("Successfully saved", MsgBoxStyle.Information)
        Suppliers.loadgrid()
        Me.Close()
    End Sub
End Class