
Public Class FrmAccountDetails
    Public SQL As New SQLControl
    Public OpenFlg As Boolean
    Private Sub LoadDataGrid(Optional Query As String = "")
        SQL.AddParams("@userid", moduleId)
        SQL.AddParams("@user", txtUsername.Text)
        SQL.AddParams("@pass", txtPass.Text)
        SQL.AddParams("@updatedby", moduleId)

        If Query = "Update" Then
            SQL.ExecQuery("UPDATE Users SET Password=@pass,Username=@user,UpdatedDate=GETDATE(),UpdatedBy=@updatedby WHERE userid=@userid")
        Else
            SQL.ExecQuery("SELECT  EmployeeName, gender, Username, Password FROM Users u INNER JOIN Employees e ON u.UserID=e.EmpId where userid=@userid")
        End If
        If SQL.HasException(True) Then Exit Sub

        If SQL.RecordCount = 0 Then
            MsgBox("Successfully Updated", MsgBoxStyle.Information, "Information")
            Exit Sub
        End If
        txtName.Text = SQL.DBDT.Rows(0).Item(0)
        txtUsername.Text = SQL.DBDT.Rows(0).Item(2)
        txtPass.Text = SQL.DBDT.Rows(0).Item(3)
        If SQL.DBDT.Rows(0).Item(1) = "F" Then
            radF.Checked = True
        Else
            radM.Checked = True
        End If

    End Sub
    Private Sub PicVisible_Click(sender As Object, e As EventArgs) Handles picVisible.Click
        If txtPass.PasswordChar = "•" Then
            txtPass.PasswordChar = ""
            picVisible.Image = Image.FromFile(Application.StartupPath + "\\..\\..\\Resources\visible.png")
        Else
            txtPass.PasswordChar = "•"
            picVisible.Image = Image.FromFile(Application.StartupPath + "\\..\\..\\Resources\invisible.png")
        End If

    End Sub

    Private Sub FrmAccountDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = AppForm
        LoadDataGrid()
        If radM.Checked = True Then
            picProf.Image = Image.FromFile(Application.StartupPath + "\\..\\..\\Resources\maleuser.png")
        Else
            picProf.Image = Image.FromFile(Application.StartupPath + "\\..\\..\\Resources\femaleuser.png")

            'picProf.Image = Image.FromFile("C:\temp\SalesandInventory\images\femaleuser.png")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        txtPass.Enabled = True
        picVisible.Image = Image.FromFile(Application.StartupPath + "\\..\\..\\Resources\invisible.png")
        picVisible.Visible = True
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        LoadDataGrid("Update")
        txtPass.Enabled = False
        picVisible.Image = Image.FromFile(Application.StartupPath + "\\..\\..\\Resources\invisible.png")
        picVisible.Visible = True
        txtPass.PasswordChar = "•"
    End Sub

    Private Sub FrmAccountDetails_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        OpenFlg = False
    End Sub
End Class