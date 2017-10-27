Public Class frmConfigurazione
    Private Sub btnConferma_Click(sender As Object, e As EventArgs) Handles btnConferma.Click
        Dim fi As New IO.FileInfo(My.Application.fileConfig)
        Me.DsCartelleDaCopiare1.WriteXml(fi.FullName)
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnNuovo_Click(sender As Object, e As EventArgs) Handles btnNuovo.Click
        Dim frm As New frmDettaglio
        If frm.ShowDialog = DialogResult.OK Then
            Dim riga As dsCartelleDaCopiare.tbCartelleDaCopiareRow = Me.DsCartelleDaCopiare1.tbCartelleDaCopiare.NewtbCartelleDaCopiareRow
            riga.PathSorgente = frm.DirectorySorgente
            riga.PathDestinazione = frm.DirectoryBackup
            Me.DsCartelleDaCopiare1.tbCartelleDaCopiare.AddtbCartelleDaCopiareRow(riga)
            Me.DsCartelleDaCopiare1.AcceptChanges()
        End If
    End Sub

    Private Sub frmConfigurazione_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim fi As New IO.FileInfo(My.Application.fileConfig)
        If fi.Exists = True Then
            Me.DsCartelleDaCopiare1.ReadXml(fi.FullName)
        End If
    End Sub

    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        If Me.BindingSource1.Current Is Nothing Then
            MsgBox("Selezionare una riga per modificarla")
            Exit Sub
        End If
        Dim RV As DataRowView = Me.BindingSource1.Current
        Dim Riga As dsCartelleDaCopiare.tbCartelleDaCopiareRow
        Try
            Riga = RV.Row
        Catch ex As Exception
            Exit Sub
        End Try
        Dim frm As New frmDettaglio
        frm.DirectorySorgente = Riga.PathSorgente
        frm.DirectoryBackup = Riga.PathDestinazione
        If frm.ShowDialog = DialogResult.OK Then
            Riga.PathSorgente = frm.DirectorySorgente
            Riga.PathDestinazione = frm.DirectoryBackup
            Me.DsCartelleDaCopiare1.AcceptChanges()
        End If
    End Sub

    Private Sub btnCancella_Click(sender As Object, e As EventArgs) Handles btnCancella.Click
        If Me.BindingSource1.Current Is Nothing Then
            MsgBox("Selezionare una riga per cancellarla")
            Exit Sub
        End If
        If MsgBox("Vuoi cancellare la riga selezionata", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim RV As DataRowView = Me.BindingSource1.Current
            Dim Riga As dsCartelleDaCopiare.tbCartelleDaCopiareRow
            Try
                Riga = RV.Row
            Catch ex As Exception
                Exit Sub
            End Try
            Riga.Delete()
            Me.DsCartelleDaCopiare1.AcceptChanges()
        End If
    End Sub
End Class