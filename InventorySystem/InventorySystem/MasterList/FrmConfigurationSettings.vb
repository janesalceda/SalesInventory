Public Class FrmConfigurationSettings
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        My.Settings.mServer = txtServer.Text
        My.Settings.mDB = txtDB.Text
        My.Settings.mUser = txtUser.Text
        My.Settings.mPass = txtPass.Text
        My.Settings.Save()
        My.Settings.Reload()
        Close()
    End Sub

    Private Sub FrmConfigurationSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = My.Settings.mServer
        txtDB.Text = My.Settings.mDB
        txtUser.Text = My.Settings.mUser
        txtPass.Text = My.Settings.mPass
    End Sub
End Class