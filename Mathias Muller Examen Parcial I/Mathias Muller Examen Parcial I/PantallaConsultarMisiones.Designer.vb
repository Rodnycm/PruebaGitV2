<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaConsultarMisiones
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dataGridMisiones = New System.Windows.Forms.DataGridView()
        Me.dtaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tripulantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaLanzamiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatosRelevantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreNave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridMisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe Marker", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(435, 35)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(106, 34)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Misiones"
        '
        'dataGridMisiones
        '
        Me.dataGridMisiones.AllowUserToOrderColumns = True
        Me.dataGridMisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridMisiones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaId, Me.dtaNombre, Me.tripulantes, Me.fechaLanzamiento, Me.Duracion, Me.DatosRelevantes, Me.resul, Me.nombreNave})
        Me.dataGridMisiones.Location = New System.Drawing.Point(72, 89)
        Me.dataGridMisiones.Name = "dataGridMisiones"
        Me.dataGridMisiones.Size = New System.Drawing.Size(841, 176)
        Me.dataGridMisiones.TabIndex = 10
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
        'tripulantes
        '
        Me.tripulantes.HeaderText = "Tripulantes"
        Me.tripulantes.Name = "tripulantes"
        '
        'fechaLanzamiento
        '
        Me.fechaLanzamiento.HeaderText = "Fecha de lanzamiento"
        Me.fechaLanzamiento.Name = "fechaLanzamiento"
        '
        'Duracion
        '
        Me.Duracion.HeaderText = "Duracion"
        Me.Duracion.Name = "Duracion"
        '
        'DatosRelevantes
        '
        Me.DatosRelevantes.HeaderText = "Datos Relevantes"
        Me.DatosRelevantes.Name = "DatosRelevantes"
        '
        'resul
        '
        Me.resul.HeaderText = "Resultado"
        Me.resul.Name = "resul"
        '
        'nombreNave
        '
        Me.nombreNave.HeaderText = "Nombre De La Nave"
        Me.nombreNave.Name = "nombreNave"
        '
        'PantallaConsultarMisiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 439)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.dataGridMisiones)
        Me.Name = "PantallaConsultarMisiones"
        Me.Text = "PantallaConsultarMisiones"
        CType(Me.dataGridMisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dataGridMisiones As System.Windows.Forms.DataGridView
    Friend WithEvents dtaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tripulantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaLanzamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatosRelevantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreNave As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
