Public Class frmSetUserName
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dfUserName = tbUserName.Text.Trim
        dfUserPass = tbUserPass.Text.Trim
        Me.Close()
    End Sub

    Private Sub frmSetUserName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUserName.Focus()
    End Sub

    Private Sub tbUserName_TextChanged(sender As Object, e As EventArgs) Handles tbUserName.TextChanged
        validText()
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