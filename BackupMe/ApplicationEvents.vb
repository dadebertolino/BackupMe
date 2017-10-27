Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' I seguenti eventi sono disponibili per MyApplication:
    ' Startup: generato all'avvio dell'applicazione, prima della creazione del form di avvio.
    ' Shutdown: generato dopo la chiusura di tutti i form dell'applicazione. L'evento non è generato se l'applicazione termina in modo anomalo.
    ' UnhandledException: generato se nell'applicazione si verifica un'eccezione non gestita.
    ' StartupNextInstance: generato all'avvio di un'applicazione a istanza singola se l'applicazione è già attiva. 
    ' NetworkAvailabilityChanged: generato se la connessione di rete è connessa o disconnessa.
    Partial Friend Class MyApplication
        Public fileConfig As String

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim Percorso As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "BackupMe")
            Dim di As New IO.DirectoryInfo(Percorso)
            If di.Exists = False Then
                di.Create()
            End If
            fileConfig = IO.Path.Combine(Percorso, "BackupMe.xml")
        End Sub
    End Class
End Namespace
