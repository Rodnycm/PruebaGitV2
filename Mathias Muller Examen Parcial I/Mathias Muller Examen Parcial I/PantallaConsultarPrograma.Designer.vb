<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaConsultarPrograma
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dataGridPrograma = New System.Windows.Forms.DataGridView()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dtaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaFechaFinalizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaAlcance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridPrograma
        '
        Me.dataGridPrograma.AllowUserToOrderColumns = True
        Me.dataGridPrograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPrograma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaId, Me.dtaNombre, Me.dtaFechaInicio, Me.dtaFechaFinalizacion, Me.dtaAlcance})
        Me.dataGridPrograma.Location = New System.Drawing.Point(208, 84)
        Me.dataGridPrograma.Name = "dataGridPrograma"
        Me.dataGridPrograma.Size = New System.Drawing.Size(543, 176)
        Me.dataGridPrograma.TabIndex = 8
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe Marker", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(366, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(206, 34)
        Me.lblTitulo.TabIndex = 9
        Me.lblTitulo.Text = "Programa Espacial"
        '
        'dtaId
        '
        Me.dtaId.HeaderText = "Id"
        Me.dtaId.Name = "dtaId"
        '
        'dtaNombre
        '
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        '
        'dtaFechaInicio
        '
        Me.dtaFechaInicio.HeaderText = "Fecha Inicio"
        Me.dtaFechaInicio.Name = "dtaFechaInicio"
        '
        'dtaFechaFinalizacion
        '
        Me.dtaFechaFinalizacion.HeaderText = "Fecha Finalizacion"
        Me.dtaFechaFinalizacion.Name = "dtaFechaFinalizacion"
        '
        'dtaAlcance
        '
        Me.dtaAlcance.HeaderText = "Alcance"
        Me.dtaAlcance.Name = "dtaAlcance"
        '
        'PantallaConsultarPrograma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 596)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.dataGridPrograma)
        Me.Name = "PantallaConsultarPrograma"
        Me.Text = "PantallaConsultarPrograma"
        CType(Me.dataGridPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataGridPrograma As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dtaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaFechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaFechaFinalizacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaAlcance As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
