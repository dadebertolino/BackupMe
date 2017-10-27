<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDettaglio
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRemoto = New System.Windows.Forms.Button()
        Me.txtDestinazioneBackup = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLocale = New System.Windows.Forms.Button()
        Me.txtDirectorySorgente = New System.Windows.Forms.TextBox()
        Me.btnConferma = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Destinazione Backup"
        '
        'btnRemoto
        '
        Me.btnRemoto.Location = New System.Drawing.Point(702, 36)
        Me.btnRemoto.Name = "btnRemoto"
        Me.btnRemoto.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoto.TabIndex = 10
        Me.btnRemoto.Text = "Cerca"
        Me.btnRemoto.UseVisualStyleBackColor = True
        '
        'txtDestinazioneBackup
        '
        Me.txtDestinazioneBackup.Location = New System.Drawing.Point(118, 38)
        Me.txtDestinazioneBackup.Name = "txtDestinazioneBackup"
        Me.txtDestinazioneBackup.Size = New System.Drawing.Size(578, 20)
        Me.txtDestinazioneBackup.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Directory Sorgente"
        '
        'btnLocale
        '
        Me.btnLocale.Location = New System.Drawing.Point(702, 10)
        Me.btnLocale.Name = "btnLocale"
        Me.btnLocale.Size = New System.Drawing.Size(75, 23)
        Me.btnLocale.TabIndex = 7
        Me.btnLocale.Text = "Cerca"
        Me.btnLocale.UseVisualStyleBackColor = True
        '
        'txtDirectorySorgente
        '
        Me.txtDirectorySorgente.Location = New System.Drawing.Point(118, 12)
        Me.txtDirectorySorgente.Name = "txtDirectorySorgente"
        Me.txtDirectorySorgente.Size = New System.Drawing.Size(578, 20)
        Me.txtDirectorySorgente.TabIndex = 6
        '
        'btnConferma
        '
        Me.btnConferma.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnConferma.Location = New System.Drawing.Point(699, 100)
        Me.btnConferma.Name = "btnConferma"
        Me.btnConferma.Size = New System.Drawing.Size(75, 23)
        Me.btnConferma.TabIndex = 13
        Me.btnConferma.Text = "Conferma"
        Me.btnConferma.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnulla.Location = New System.Drawing.Point(618, 100)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulla.TabIndex = 12
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'frmDettaglio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 135)
        Me.Controls.Add(Me.btnConferma)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRemoto)
        Me.Controls.Add(Me.txtDestinazioneBackup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLocale)
        Me.Controls.Add(Me.txtDirectorySorgente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDettaglio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passo Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnRemoto As Button
    Friend WithEvents txtDestinazioneBackup As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLocale As Button
    Friend WithEvents txtDirectorySorgente As TextBox
    Friend WithEvents btnConferma As Button
    Friend WithEvents btnAnnulla As Button
End Class
