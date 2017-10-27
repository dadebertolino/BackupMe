<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnCopia = New System.Windows.Forms.Button()
        Me.btnConfigura = New System.Windows.Forms.Button()
        Me.lblStato = New System.Windows.Forms.Label()
        Me.tmrWait = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'btnCopia
        '
        Me.btnCopia.Location = New System.Drawing.Point(12, 12)
        Me.btnCopia.Name = "btnCopia"
        Me.btnCopia.Size = New System.Drawing.Size(75, 23)
        Me.btnCopia.TabIndex = 0
        Me.btnCopia.Text = "Copia"
        Me.btnCopia.UseVisualStyleBackColor = True
        '
        'btnConfigura
        '
        Me.btnConfigura.Location = New System.Drawing.Point(12, 41)
        Me.btnConfigura.Name = "btnConfigura"
        Me.btnConfigura.Size = New System.Drawing.Size(75, 23)
        Me.btnConfigura.TabIndex = 1
        Me.btnConfigura.Text = "Configura"
        Me.btnConfigura.UseVisualStyleBackColor = True
        '
        'lblStato
        '
        Me.lblStato.AutoSize = True
        Me.lblStato.Location = New System.Drawing.Point(12, 76)
        Me.lblStato.Name = "lblStato"
        Me.lblStato.Size = New System.Drawing.Size(39, 13)
        Me.lblStato.TabIndex = 2
        Me.lblStato.Text = "Label1"
        '
        'tmrWait
        '
        Me.tmrWait.Interval = 1000
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 101)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(538, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 136)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblStato)
        Me.Controls.Add(Me.btnConfigura)
        Me.Controls.Add(Me.btnCopia)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackupMe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCopia As Button
    Friend WithEvents btnConfigura As Button
    Friend WithEvents lblStato As Label
    Friend WithEvents tmrWait As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
