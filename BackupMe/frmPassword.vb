Public Class frmPassword
    Private Sub btnConferma_Click(sender As Object, e As EventArgs) Handles btnConferma.Click
        If Me.txtPassword.Text = "pompetta" Then
            Me.DialogResult = DialogResult.OK
            Exit Sub
        End If
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class