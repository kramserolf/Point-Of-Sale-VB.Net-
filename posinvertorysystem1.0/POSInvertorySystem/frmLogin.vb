Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameTextBox.Focus()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        login(UsernameTextBox.Text, PasswordTextBox.Text)
        frmPOS.lblUname.Text = UsernameTextBox.Text
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class