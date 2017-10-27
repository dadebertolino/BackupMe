Public Class frmDettaglio


    Public Property DirectorySorgente As String
        Get
            Return Me.txtDirectorySorgente.Text
        End Get
        Set(value As String)
            Me.txtDirectorySorgente.Text = value
        End Set
    End Property

    Public Property DirectoryBackup As String
        Get
            Return Me.txtDestinazioneBackup.Text
        End Get
        Set(value As String)
            Me.txtDestinazioneBackup.Text = value
        End Set
    End Property
    Private Sub btnLocale_Click(sender As Object, e As EventArgs) Handles btnLocale.Click
        Dim fbd As New FolderBrowserDialog
        If Me.txtDirectorySorgente.Text <> "" Then
            fbd.SelectedPath = Me.txtDirectorySorgente.Text
        End If
        If fbd.ShowDialog = DialogResult.OK Then
            Me.txtDirectorySorgente.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btnRemoto_Click(sender As Object, e As EventArgs) Handles btnRemoto.Click
        Dim fbd As New FolderBrowserDialog
        If Me.txtDestinazioneBackup.Text <> "" Then
            fbd.SelectedPath = Me.txtDestinazioneBackup.Text
        End If
        If fbd.ShowDialog = DialogResult.OK Then
            Me.txtDestinazioneBackup.Text = fbd.SelectedPath
        End If
    End Sub
End Class