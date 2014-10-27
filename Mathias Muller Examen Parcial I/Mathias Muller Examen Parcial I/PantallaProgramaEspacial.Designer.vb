<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaProgramaEspacial
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
        Me.lblErrorFechaFinalizacion = New System.Windows.Forms.Label()
        Me.lblErrorFechaInicio = New System.Windows.Forms.Label()
        Me.btnAgregarMisiones = New System.Windows.Forms.Button()
        Me.txtAlcance = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dateFechaFinalizacion = New System.Windows.Forms.DateTimePicker()
        Me.dateFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblMisiones = New System.Windows.Forms.Label()
        Me.lblAlcance = New System.Windows.Forms.Label()
        Me.lblFechaFinalizacion = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblNombrePrograma = New System.Windows.Forms.Label()
        Me.lblProgramaEspacial = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAgregarPrograma = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblErrorFechaFinalizacion
        '
        Me.lblErrorFechaFinalizacion.AutoSize = True
        Me.lblErrorFechaFinalizacion.Location = New System.Drawing.Point(625, 215)
        Me.lblErrorFechaFinalizacion.Name = "lblErrorFechaFinalizacion"
        Me.lblErrorFechaFinalizacion.Size = New System.Drawing.Size(194, 13)
        Me.lblErrorFechaFinalizacion.TabIndex = 26
        Me.lblErrorFechaFinalizacion.Text = "La Fecha No puede Ser Antes Que hoy"
        Me.lblErrorFechaFinalizacion.Visible = False
        '
        'lblErrorFechaInicio
        '
        Me.lblErrorFechaInicio.AutoSize = True
        Me.lblErrorFechaInicio.Location = New System.Drawing.Point(625, 176)
        Me.lblErrorFechaInicio.Name = "lblErrorFechaInicio"
        Me.lblErrorFechaInicio.Size = New System.Drawing.Size(242, 13)
        Me.lblErrorFechaInicio.TabIndex = 25
        Me.lblErrorFechaInicio.Text = "La fecha De Inicio no Puede Ser Despues de hoy"
        Me.lblErrorFechaInicio.Visible = False
        '
        'btnAgregarMisiones
        '
        Me.btnAgregarMisiones.Location = New System.Drawing.Point(413, 285)
        Me.btnAgregarMisiones.Name = "btnAgregarMisiones"
        Me.btnAgregarMisiones.Size = New System.Drawing.Size(129, 23)
        Me.btnAgregarMisiones.TabIndex = 24
        Me.btnAgregarMisiones.Text = "Agregar Mision"
        Me.btnAgregarMisiones.UseVisualStyleBackColor = True
        '
        'txtAlcance
        '
        Me.txtAlcance.Location = New System.Drawing.Point(383, 245)
        Me.txtAlcance.Name = "txtAlcance"
        Me.txtAlcance.Size = New System.Drawing.Size(199, 20)
        Me.txtAlcance.TabIndex = 23
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(382, 132)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(199, 20)
        Me.txtNombre.TabIndex = 22
        '
        'dateFechaFinalizacion
        '
        Me.dateFechaFinalizacion.Location = New System.Drawing.Point(382, 209)
        Me.dateFechaFinalizacion.Name = "dateFechaFinalizacion"
        Me.dateFechaFinalizacion.Size = New System.Drawing.Size(200, 20)
        Me.dateFechaFinalizacion.TabIndex = 21
        '
        'dateFechaInicio
        '
        Me.dateFechaInicio.Location = New System.Drawing.Point(381, 176)
        Me.dateFechaInicio.Name = "dateFechaInicio"
        Me.dateFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.dateFechaInicio.TabIndex = 20
        '
        'lblMisiones
        '
        Me.lblMisiones.AutoSize = True
        Me.lblMisiones.Location = New System.Drawing.Point(265, 290)
        Me.lblMisiones.Name = "lblMisiones"
        Me.lblMisiones.Size = New System.Drawing.Size(86, 13)
        Me.lblMisiones.TabIndex = 19
        Me.lblMisiones.Text = "Asignar Misiones"
        '
        'lblAlcance
        '
        Me.lblAlcance.AutoSize = True
        Me.lblAlcance.Location = New System.Drawing.Point(268, 252)
        Me.lblAlcance.Name = "lblAlcance"
        Me.lblAlcance.Size = New System.Drawing.Size(46, 13)
        Me.lblAlcance.TabIndex = 18
        Me.lblAlcance.Text = "Alcance"
        '
        'lblFechaFinalizacion
        '
        Me.lblFechaFinalizacion.AutoSize = True
        Me.lblFechaFinalizacion.Location = New System.Drawing.Point(265, 217)
        Me.lblFechaFinalizacion.Name = "lblFechaFinalizacion"
        Me.lblFechaFinalizacion.Size = New System.Drawing.Size(110, 13)
        Me.lblFechaFinalizacion.TabIndex = 17
        Me.lblFechaFinalizacion.Text = "Fecha De Finalzacion"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(265, 182)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(82, 13)
        Me.lblFechaInicio.TabIndex = 16
        Me.lblFechaInicio.Text = "Fecha De Inicio"
        '
        'lblNombrePrograma
        '
        Me.lblNombrePrograma.AutoSize = True
        Me.lblNombrePrograma.Location = New System.Drawing.Point(262, 140)
        Me.lblNombrePrograma.Name = "lblNombrePrograma"
        Me.lblNombrePrograma.Size = New System.Drawing.Size(44, 13)
        Me.lblNombrePrograma.TabIndex = 15
        Me.lblNombrePrograma.Text = "Nombre"
        '
        'lblProgramaEspacial
        '
        Me.lblProgramaEspacial.AutoSize = True
        Me.lblProgramaEspacial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramaEspacial.Location = New System.Drawing.Point(378, 62)
        Me.lblProgramaEspacial.Name = "lblProgramaEspacial"
        Me.lblProgramaEspacial.Size = New System.Drawing.Size(193, 25)
        Me.lblProgramaEspacial.TabIndex = 14
        Me.lblProgramaEspacial.Text = "Programa Espacial"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(320, 327)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(329, 97)
        Me.ListView1.TabIndex = 27
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnAgregarPrograma
        '
        Me.btnAgregarPrograma.Location = New System.Drawing.Point(413, 495)
        Me.btnAgregarPrograma.Name = "btnAgregarPrograma"
        Me.btnAgregarPrograma.Size = New System.Drawing.Size(129, 23)
        Me.btnAgregarPrograma.TabIndex = 28
        Me.btnAgregarPrograma.Text = "Agregar Programa"
        Me.btnAgregarPrograma.UseVisualStyleBackColor = True
        '
        'PantallaProgramaEspacial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 580)
        Me.Controls.Add(Me.btnAgregarPrograma)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblErrorFechaFinalizacion)
        Me.Controls.Add(Me.lblErrorFechaInicio)
        Me.Controls.Add(Me.btnAgregarMisiones)
        Me.Controls.Add(Me.txtAlcance)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dateFechaFinalizacion)
        Me.Controls.Add(Me.dateFechaInicio)
        Me.Controls.Add(Me.lblMisiones)
        Me.Controls.Add(Me.lblAlcance)
        Me.Controls.Add(Me.lblFechaFinalizacion)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.lblNombrePrograma)
        Me.Controls.Add(Me.lblProgramaEspacial)
        Me.Name = "PantallaProgramaEspacial"
        Me.Text = "PantallaProgramaEspacial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblErrorFechaFinalizacion As System.Windows.Forms.Label
    Friend WithEvents lblErrorFechaInicio As System.Windows.Forms.Label
    Friend WithEvents btnAgregarMisiones As System.Windows.Forms.Button
    Friend WithEvents txtAlcance As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents dateFechaFinalizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMisiones As System.Windows.Forms.Label
    Friend WithEvents lblAlcance As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinalizacion As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents lblNombrePrograma As System.Windows.Forms.Label
    Friend WithEvents lblProgramaEspacial As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnAgregarPrograma As System.Windows.Forms.Button
End Class
