Imports System.ComponentModel

Public Class frmMain
    Dim TimeToWait As Integer = 10
    Shared dsCartelleDaCopiare1 As dsCartelleDaCopiare
    Shared LogFile As IO.StreamWriter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dsCartelleDaCopiare1 = New dsCartelleDaCopiare
        Dim fi As New IO.FileInfo(My.Application.fileConfig)
        If fi.Exists = True Then
            dsCartelleDaCopiare1.ReadXml(fi.FullName)
        End If
        Me.tmrWait.Enabled = True
        Me.UpdateLBLInfo()
    End Sub

    Private Sub tmrWait_Tick(sender As Object, e As EventArgs) Handles tmrWait.Tick
        If Me.TimeToWait > 0 Then
            Me.TimeToWait -= 1
            UpdateLBLInfo()
        Else
            Me.tmrWait.Enabled = False
            If BackgroundWorker1.IsBusy = False Then
                BackgroundWorker1.RunWorkerAsync()
            End If
            Me.lblStato.Text = "Copia in corso"
        End If
    End Sub

    Private Sub UpdateLBLInfo()

        If Me.BackgroundWorker1.IsBusy Then
            Me.lblStato.Text = "Copia in corso"
            Me.btnCopia.Enabled = False
            Return
        End If
        Me.btnCopia.Enabled = True
        If Me.TimeToWait > 0 Then
            Me.lblStato.Text = "Inizio copia tra " & TimeToWait & " secondi"
            Return
        End If
        'Me.lblStato.Text = "Copia terminata"
    End Sub

    Private Sub btnCopia_Click(sender As Object, e As EventArgs) Handles btnCopia.Click
        If Me.BackgroundWorker1.IsBusy = False Then
            BackgroundWorker1.RunWorkerAsync()
            Me.tmrWait.Enabled = False
            Me.lblStato.Text = "Copia in corso"

        End If
    End Sub

    Public Function CopiaDirectory(DirectorySorgente As String, DirectoryDestinazione As String) As Boolean
        Dim diDestinazione As New IO.DirectoryInfo(DirectoryDestinazione)
        Dim diSorgente As New IO.DirectoryInfo(DirectorySorgente)
        If diDestinazione.Exists = False Then
            Try
                diDestinazione.Create()
            Catch ex As Exception
                LogFile.WriteLine(ex.Message)
                Return False
            End Try
        End If
        Dim DSorgente() As IO.DirectoryInfo = diSorgente.GetDirectories()
        For Each di As IO.DirectoryInfo In DSorgente
            Dim di2 As New IO.DirectoryInfo(IO.Path.Combine(diDestinazione.FullName, di.Name))
            Try
                di2.Create()
                If CopiaDirectory(di.FullName, di2.FullName) = False Then
                    Return False
                End If
            Catch ex As Exception
                LogFile.WriteLine(ex.Message)
                Return False
            End Try
        Next
        Dim fiSorgente() As IO.FileInfo = diSorgente.GetFiles()
        For Each fi As IO.FileInfo In fiSorgente
            Try
                fi.CopyTo(IO.Path.Combine(diDestinazione.FullName, fi.Name), True)
            Catch ex As Exception
                LogFile.WriteLine(ex.Message)
                Return False
            End Try
        Next
        Return True
    End Function

    Private Sub btnConfigura_Click(sender As Object, e As EventArgs) Handles btnConfigura.Click
        Dim TimerRunning As Boolean = Me.tmrWait.Enabled
        If TimerRunning Then
            Me.tmrWait.Enabled = False
        End If
        Dim frm As New frmPassword
        If frm.ShowDialog = DialogResult.OK Then
            Using frmConfigurazione As New frmConfigurazione
                If frmConfigurazione.ShowDialog = DialogResult.OK Then
                    Dim fi As New IO.FileInfo(My.Application.fileConfig)
                    If fi.Exists = True Then
                        dsCartelleDaCopiare1.Clear()
                        dsCartelleDaCopiare1.ReadXml(fi.FullName)
                    End If
                End If
            End Using
        End If
        If TimerRunning Then
            Me.tmrWait.Enabled = True
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        LogFile = New IO.StreamWriter("Log" & DateTime.Now.ToString("yyMMddhhmm") & ".txt")
        Dim Max As Integer = dsCartelleDaCopiare1.tbCartelleDaCopiare.Count
        Dim CartelleCopiate As Integer = 0
        BackgroundWorker1.ReportProgress(0)
        For Each riga As dsCartelleDaCopiare.tbCartelleDaCopiareRow In dsCartelleDaCopiare1.tbCartelleDaCopiare
            Dim DI3 As New IO.DirectoryInfo(IO.Path.Combine(riga.PathDestinazione, "3"))
            Dim DI2 As New IO.DirectoryInfo(IO.Path.Combine(riga.PathDestinazione, "2"))
            Dim DI1 As New IO.DirectoryInfo(IO.Path.Combine(riga.PathDestinazione, "1"))
            Dim DICurrent As New IO.DirectoryInfo(IO.Path.Combine(riga.PathDestinazione, "Current"))
            If DI3.Exists Then
                DI3.Delete(True)
            End If
            If DI2.Exists Then
                DI2.MoveTo(IO.Path.Combine(riga.PathDestinazione, "3"))
            End If
            If DI1.Exists Then
                DI1.MoveTo(IO.Path.Combine(riga.PathDestinazione, "2"))
            End If
            If DICurrent.Exists Then
                DICurrent.MoveTo(IO.Path.Combine(riga.PathDestinazione, "1"))
            End If
            If CopiaDirectory(riga.PathSorgente, IO.Path.Combine(riga.PathDestinazione, "Current")) Then
                LogFile.WriteLine("Copia di " & riga.PathSorgente & " completata correttamente")
            Else
                LogFile.WriteLine("Errore nella copia di" & riga.PathSorgente)
            End If
            BackgroundWorker1.ReportProgress(CartelleCopiate * 100 / Max)
        Next
        LogFile.Flush()
        LogFile.Close()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.lblStato.Text = "Spegnimento PC in corso..."
        WindowsController.ExitWindows(RestartOptions.ShutDown, True)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.ProgressBar1.Value = e.ProgressPercentage
        UpdateLBLInfo()
    End Sub
End Class
