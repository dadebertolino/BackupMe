<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigurazione
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCartelleDaCopiare1 = New BackupMe.dsCartelleDaCopiare()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnNuovo = New System.Windows.Forms.Button()
        Me.btnModifica = New System.Windows.Forms.Button()
        Me.btnCancella = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.btnConferma = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathSorgenteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathDestinazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtSiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCartelleDaCopiare1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tbCartelleDaCopiare"
        Me.BindingSource1.DataSource = Me.DsCartelleDaCopiare1
        '
        'DsCartelleDaCopiare1
        '
        Me.DsCartelleDaCopiare1.DataSetName = "dsCartelleDaCopiare"
        Me.DsCartelleDaCopiare1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PathSorgenteDataGridViewTextBoxColumn, Me.PathDestinazioneDataGridViewTextBoxColumn, Me.ExtSiDataGridViewTextBoxColumn, Me.ExtNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(668, 453)
        Me.DataGridView1.TabIndex = 0
        '
        'btnNuovo
        '
        Me.btnNuovo.Location = New System.Drawing.Point(281, 485)
        Me.btnNuovo.Name = "btnNuovo"
        Me.btnNuovo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuovo.TabIndex = 1
        Me.btnNuovo.Text = "Nuovo"
        Me.btnNuovo.UseVisualStyleBackColor = True
        '
        'btnModifica
        '
        Me.btnModifica.Location = New System.Drawing.Point(362, 485)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(75, 23)
        Me.btnModifica.TabIndex = 2
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'btnCancella
        '
        Me.btnCancella.Location = New System.Drawing.Point(443, 485)
        Me.btnCancella.Name = "btnCancella"
        Me.btnCancella.Size = New System.Drawing.Size(75, 23)
        Me.btnCancella.TabIndex = 3
        Me.btnCancella.Text = "Cancella"
        Me.btnCancella.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnulla.Location = New System.Drawing.Point(524, 485)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulla.TabIndex = 4
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'btnConferma
        '
        Me.btnConferma.Location = New System.Drawing.Point(605, 485)
        Me.btnConferma.Name = "btnConferma"
        Me.btnConferma.Size = New System.Drawing.Size(75, 23)
        Me.btnConferma.TabIndex = 5
        Me.btnConferma.Text = "Conferma"
        Me.btnConferma.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'PathSorgenteDataGridViewTextBoxColumn
        '
        Me.PathSorgenteDataGridViewTextBoxColumn.DataPropertyName = "PathSorgente"
        Me.PathSorgenteDataGridViewTextBoxColumn.HeaderText = "Directory Sorgente"
        Me.PathSorgenteDataGridViewTextBoxColumn.Name = "PathSorgenteDataGridViewTextBoxColumn"
        Me.PathSorgenteDataGridViewTextBoxColumn.ReadOnly = True
        Me.PathSorgenteDataGridViewTextBoxColumn.Width = 300
        '
        'PathDestinazioneDataGridViewTextBoxColumn
        '
        Me.PathDestinazioneDataGridViewTextBoxColumn.DataPropertyName = "PathDestinazione"
        Me.PathDestinazioneDataGridViewTextBoxColumn.HeaderText = "Destinazione Backup"
        Me.PathDestinazioneDataGridViewTextBoxColumn.Name = "PathDestinazioneDataGridViewTextBoxColumn"
        Me.PathDestinazioneDataGridViewTextBoxColumn.ReadOnly = True
        Me.PathDestinazioneDataGridViewTextBoxColumn.Width = 300
        '
        'ExtSiDataGridViewTextBoxColumn
        '
        Me.ExtSiDataGridViewTextBoxColumn.DataPropertyName = "ExtSi"
        Me.ExtSiDataGridViewTextBoxColumn.HeaderText = "ExtSi"
        Me.ExtSiDataGridViewTextBoxColumn.Name = "ExtSiDataGridViewTextBoxColumn"
        Me.ExtSiDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExtSiDataGridViewTextBoxColumn.Visible = False
        '
        'ExtNoDataGridViewTextBoxColumn
        '
        Me.ExtNoDataGridViewTextBoxColumn.DataPropertyName = "ExtNo"
        Me.ExtNoDataGridViewTextBoxColumn.HeaderText = "ExtNo"
        Me.ExtNoDataGridViewTextBoxColumn.Name = "ExtNoDataGridViewTextBoxColumn"
        Me.ExtNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExtNoDataGridViewTextBoxColumn.Visible = False
        '
        'frmConfigurazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 524)
        Me.Controls.Add(Me.btnConferma)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnCancella)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.btnNuovo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmConfigurazione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurazione"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCartelleDaCopiare1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DsCartelleDaCopiare1 As dsCartelleDaCopiare
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnNuovo As Button
    Friend WithEvents btnModifica As Button
    Friend WithEvents btnCancella As Button
    Friend WithEvents btnAnnulla As Button
    Friend WithEvents btnConferma As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PathSorgenteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PathDestinazioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtSiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExtNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
