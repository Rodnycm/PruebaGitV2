<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaConsultarObjeto
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
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dataGridEstrella = New System.Windows.Forms.DataGridView()
        Me.dtaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaMasa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaTempMedia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaDuracionDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaComposicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaIntensidadLuminica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaTamano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridPlaneta = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaDistMedia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaDuracionAno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaCantSatelites = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataGridSatelite = New System.Windows.Forms.DataGridView()
        Me.rbtPlaneta = New System.Windows.Forms.RadioButton()
        Me.rbtEstrella = New System.Windows.Forms.RadioButton()
        Me.rbtSatelite = New System.Windows.Forms.RadioButton()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dsitanciaMedia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Caracteristicas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dataGridEstrella, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridPlaneta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridSatelite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(412, 107)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(139, 23)
        Me.btnConsultar.TabIndex = 0
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe Marker", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(344, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(272, 34)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "Consultar Objeto Celeste"
        '
        'dataGridEstrella
        '
        Me.dataGridEstrella.AllowUserToOrderColumns = True
        Me.dataGridEstrella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridEstrella.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaId, Me.dtaNombre, Me.dtaMasa, Me.dtaTempMedia, Me.dtaDuracionDia, Me.dtaEdad, Me.dtaComposicion, Me.dtaIntensidadLuminica, Me.dtaTamano})
        Me.dataGridEstrella.Location = New System.Drawing.Point(30, 158)
        Me.dataGridEstrella.Name = "dataGridEstrella"
        Me.dataGridEstrella.Size = New System.Drawing.Size(918, 176)
        Me.dataGridEstrella.TabIndex = 7
        Me.dataGridEstrella.Visible = False
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
        'dtaMasa
        '
        Me.dtaMasa.HeaderText = "Masa"
        Me.dtaMasa.Name = "dtaMasa"
        '
        'dtaTempMedia
        '
        Me.dtaTempMedia.HeaderText = "Temperatura Media"
        Me.dtaTempMedia.Name = "dtaTempMedia"
        '
        'dtaDuracionDia
        '
        Me.dtaDuracionDia.HeaderText = "Duracion de un dia"
        Me.dtaDuracionDia.Name = "dtaDuracionDia"
        '
        'dtaEdad
        '
        Me.dtaEdad.HeaderText = "Edad"
        Me.dtaEdad.Name = "dtaEdad"
        '
        'dtaComposicion
        '
        Me.dtaComposicion.HeaderText = "Composicion"
        Me.dtaComposicion.Name = "dtaComposicion"
        '
        'dtaIntensidadLuminica
        '
        Me.dtaIntensidadLuminica.HeaderText = "Intensidad Luminica"
        Me.dtaIntensidadLuminica.Name = "dtaIntensidadLuminica"
        '
        'dtaTamano
        '
        Me.dtaTamano.HeaderText = "Tamano"
        Me.dtaTamano.Name = "dtaTamano"
        '
        'dataGridPlaneta
        '
        Me.dataGridPlaneta.AllowUserToOrderColumns = True
        Me.dataGridPlaneta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridPlaneta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.dtaDistMedia, Me.dtaDuracionAno, Me.dtaCantSatelites})
        Me.dataGridPlaneta.Location = New System.Drawing.Point(30, 340)
        Me.dataGridPlaneta.Name = "dataGridPlaneta"
        Me.dataGridPlaneta.Size = New System.Drawing.Size(845, 176)
        Me.dataGridPlaneta.TabIndex = 8
        Me.dataGridPlaneta.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Masa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Temperatura Media"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Duracion de un dia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'dtaDistMedia
        '
        Me.dtaDistMedia.HeaderText = "Distancia Media Del Sol"
        Me.dtaDistMedia.Name = "dtaDistMedia"
        '
        'dtaDuracionAno
        '
        Me.dtaDuracionAno.HeaderText = "Duracion de un Ano"
        Me.dtaDuracionAno.Name = "dtaDuracionAno"
        '
        'dtaCantSatelites
        '
        Me.dtaCantSatelites.HeaderText = "Total de Satelites"
        Me.dtaCantSatelites.Name = "dtaCantSatelites"
        '
        'dataGridSatelite
        '
        Me.dataGridSatelite.AllowUserToOrderColumns = True
        Me.dataGridSatelite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridSatelite.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.dsitanciaMedia, Me.Caracteristicas})
        Me.dataGridSatelite.Location = New System.Drawing.Point(118, 414)
        Me.dataGridSatelite.Name = "dataGridSatelite"
        Me.dataGridSatelite.Size = New System.Drawing.Size(757, 176)
        Me.dataGridSatelite.TabIndex = 9
        Me.dataGridSatelite.Visible = False
        '
        'rbtPlaneta
        '
        Me.rbtPlaneta.AutoSize = True
        Me.rbtPlaneta.Location = New System.Drawing.Point(316, 67)
        Me.rbtPlaneta.Name = "rbtPlaneta"
        Me.rbtPlaneta.Size = New System.Drawing.Size(61, 17)
        Me.rbtPlaneta.TabIndex = 10
        Me.rbtPlaneta.TabStop = True
        Me.rbtPlaneta.Text = "Planeta"
        Me.rbtPlaneta.UseVisualStyleBackColor = True
        '
        'rbtEstrella
        '
        Me.rbtEstrella.AutoSize = True
        Me.rbtEstrella.Location = New System.Drawing.Point(444, 67)
        Me.rbtEstrella.Name = "rbtEstrella"
        Me.rbtEstrella.Size = New System.Drawing.Size(59, 17)
        Me.rbtEstrella.TabIndex = 11
        Me.rbtEstrella.TabStop = True
        Me.rbtEstrella.Text = "Estrella"
        Me.rbtEstrella.UseVisualStyleBackColor = True
        '
        'rbtSatelite
        '
        Me.rbtSatelite.AutoSize = True
        Me.rbtSatelite.Location = New System.Drawing.Point(567, 67)
        Me.rbtSatelite.Name = "rbtSatelite"
        Me.rbtSatelite.Size = New System.Drawing.Size(60, 17)
        Me.rbtSatelite.TabIndex = 12
        Me.rbtSatelite.TabStop = True
        Me.rbtSatelite.Text = "Satelite"
        Me.rbtSatelite.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Masa"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Temperatura Media"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Duracion de un dia"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'dsitanciaMedia
        '
        Me.dsitanciaMedia.HeaderText = "Distancia Media"
        Me.dsitanciaMedia.Name = "dsitanciaMedia"
        '
        'Caracteristicas
        '
        Me.Caracteristicas.HeaderText = "Caracteristicas"
        Me.Caracteristicas.Name = "Caracteristicas"
        '
        'PantallaConsultarObjeto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 616)
        Me.Controls.Add(Me.rbtSatelite)
        Me.Controls.Add(Me.rbtEstrella)
        Me.Controls.Add(Me.rbtPlaneta)
        Me.Controls.Add(Me.dataGridSatelite)
        Me.Controls.Add(Me.dataGridPlaneta)
        Me.Controls.Add(Me.dataGridEstrella)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnConsultar)
        Me.Name = "PantallaConsultarObjeto"
        Me.Text = " "
        CType(Me.dataGridEstrella, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridPlaneta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridSatelite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dataGridEstrella As System.Windows.Forms.DataGridView
    Friend WithEvents dtaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaMasa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaTempMedia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaDuracionDia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaEdad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaComposicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaIntensidadLuminica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaTamano As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataGridPlaneta As System.Windows.Forms.DataGridView
    Friend WithEvents dataGridSatelite As System.Windows.Forms.DataGridView
    Friend WithEvents rbtPlaneta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEstrella As System.Windows.Forms.RadioButton
    Friend WithEvents rbtSatelite As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaDistMedia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaDuracionAno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaCantSatelites As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dsitanciaMedia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Caracteristicas As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
