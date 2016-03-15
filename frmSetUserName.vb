Public Class frmSetUserName
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AccountProvider.SetUserName(tbUserName.Text.Trim)
        AccountProvider.SetUserPass(tbUserPass.Text.Trim)
        Me.Close()
    End Sub

    Private Sub frmSetUserName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUserName.Text = AccountProvider.GetUserName
        tbUserPass.Text = AccountProvider.GetUserPass
        If tbUserName.TextLength = 8 Then
            tbUserName.Select(6, 2)
        End If

        If AccountProvider.isOtMode Then
            btnCancel.Visible = False
            lbTips.Visible = False
            Me.Text = "输入他人教务账号进行登陆"
        End If
        tbUserName.Focus()
    End Sub

    Private Sub tbUserName_TextChanged(sender As Object, e As EventArgs) Handles tbUserName.TextChanged
        If tbUserName.TextLength = 8 Then tbUserPass.Focus()
        validText()
    End Sub

    Private Sub tbUserPass_KeyDown(sender As Object, e As KeyEventArgs) Handles tbUserPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub tbUserPass_TextChanged(sender As Object, e As EventArgs) Handles tbUserPass.TextChanged
        validText()
    End Sub

    Private Sub validText()
        If tbUserName.Text.Trim.Length = 8 And tbUserPass.Text.Trim <> "" Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub
End Class