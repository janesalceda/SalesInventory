Public Class AddSupplier
    Private Sub getDelivery()
        SQL.ExecQuery("select * from TermsOfDelivery")
        For index As Integer = 0 To SQL.RecordCount - 1
            'cmbTDelivery.Items.Add(SQL.DBDT.Rows(index).Item(0))
            cmbTOD.DataSource = SQL.DBDT
            cmbTOD.DisplayMember = "TermOfDelivery"
            cmbTOD.ValueMember = "TermOfDeliveryId"
        Next
    End Sub

    Private Sub getPayment()
        SQL.ExecQuery("select * from TermsOfPayment")
        For index As Integer = 0 To SQL.RecordCount - 1
            cmbTOP.DataSource = SQL.DBDT
            cmbTOP.DisplayMember = "TermOfPayment"
            cmbTOP.ValueMember = "TermOfPaymentId"
        Next
    End Sub
    Private Sub getCurrency()
        SQL.ExecQuery("select * from CurrencyUnits")
        For index As Integer = 0 To SQL.RecordCount - 1
            cmbCurrency.DataSource = SQL.DBDT
            cmbCurrency.DisplayMember = "CurrencyUnit"
            cmbCurrency.ValueMember = "CurrencyUnitId"
        Next
    End Sub
    Private Sub AddSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        getDelivery()
        getPayment()
        getCurrency()
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