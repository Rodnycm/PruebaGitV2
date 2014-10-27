<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaMision
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lbltripulantes = New System.Windows.Forms.Label()
        Me.txtTripulantes = New System.Windows.Forms.TextBox()
        Me.lblFechaLanzamiento = New System.Windows.Forms.Label()
        Me.dateLanzamiento = New System.Windows.Forms.DateTimePicker()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.txtDatosInteres = New System.Windows.Forms.TextBox()
        Me.lblDatosInteres = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.lblNave = New System.Windows.Forms.Label()
        Me.txtNave = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblErrorNombre = New System.Windows.Forms.Label()
        Me.lblErrorTripulantes = New System.Windows.Forms.Label()
        Me.lblErrorDuracion = New System.Windows.Forms.Label()
        Me.lblErrorDatosInteres = New System.Windows.Forms.Label()
        Me.lblErrorResultado = New System.Windows.Forms.Label()
        Me.lblErrorNave = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(89, 71)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(210, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(166, 20)
        Me.txtNombre.TabIndex = 1
        '
        'lbltripulantes
        '
        Me.lbltripulantes.AutoSize = True
        Me.lbltripulantes.Location = New System.Drawing.Point(89, 108)
        Me.lbltripulantes.Name = "lbltripulantes"
        Me.lbltripulantes.Size = New System.Drawing.Size(59, 13)
        Me.lbltripulantes.TabIndex = 2
        Me.lbltripulantes.Text = "Tripulantes"
        '
        'txtTripulantes
        '
        Me.txtTripulantes.Location = New System.Drawing.Point(210, 101)
        Me.txtTripulantes.Name = "txtTripulantes"
        Me.txtTripulantes.Size = New System.Drawing.Size(166, 20)
        Me.txtTripulantes.TabIndex = 3
        '
        'lblFechaLanzamiento
        '
        Me.lblFechaLanzamiento.AutoSize = True
        Me.lblFechaLanzamiento.Location = New System.Drawing.Point(89, 144)
        Me.lblFechaLanzamiento.Name = "lblFechaLanzamiento"
        Me.lblFechaLanzamiento.Size = New System.Drawing.Size(115, 13)
        Me.lblFechaLanzamiento.TabIndex = 4
        Me.lblFechaLanzamiento.Text = "Fecha de Lanzamiento"
        '
        'dateLanzamiento
        '
        Me.dateLanzamiento.Location = New System.Drawing.Point(210, 144)
        Me.dateLanzamiento.Name = "dateLanzamiento"
        Me.dateLanzamiento.Size = New System.Drawing.Size(200, 20)
        Me.dateLanzamiento.TabIndex = 5
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Location = New System.Drawing.Point(89, 183)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(50, 13)
        Me.lblDuracion.TabIndex = 6
        Me.lblDuracion.Text = "Duracion"
        '
        'txtDatosInteres
        '
        Me.txtDatosInteres.Location = New System.Drawing.Point(210, 231)
        Me.txtDatosInteres.Multiline = True
        Me.txtDatosInteres.Name = "txtDatosInteres"
        Me.txtDatosInteres.Size = New System.Drawing.Size(246, 80)
        Me.txtDatosInteres.TabIndex = 7
        '
        'lblDatosInteres
        '
        Me.lblDatosInteres.AutoSize = True
        Me.lblDatosInteres.Location = New System.Drawing.Point(89, 234)
        Me.lblDatosInteres.Name = "lblDatosInteres"
        Me.lblDatosInteres.Size = New System.Drawing.Size(84, 13)
        Me.lblDatosInteres.TabIndex = 8
        Me.lblDatosInteres.Text = "Datos de interes"
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(210, 183)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(166, 20)
        Me.txtDuracion.TabIndex = 11
        Me.txtDuracion.TabStop = False
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(551, 55)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(55, 13)
        Me.lblResultado.TabIndex = 12
        Me.lblResultado.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(627, 55)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(246, 80)
        Me.txtResultado.TabIndex = 13
        '
        'lblNave
        '
        Me.lblNave.AutoSize = True
        Me.lblNave.Location = New System.Drawing.Point(573, 169)
        Me.lblNave.Name = "lblNave"
        Me.lblNave.Size = New System.Drawing.Size(33, 13)
        Me.lblNave.TabIndex = 14
        Me.lblNave.Text = "Nave"
        '
        'txtNave
        '
        Me.txtNave.Location = New System.Drawing.Point(627, 162)
        Me.txtNave.Name = "txtNave"
        Me.txtNave.Size = New System.Drawing.Size(166, 20)
        Me.txtNave.TabIndex = 15
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(460, 372)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(102, 23)
        Me.btnRegistrar.TabIndex = 17
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lblErrorNombre
        '
        Me.lblErrorNombre.AutoSize = True
        Me.lblErrorNombre.Location = New System.Drawing.Point(394, 64)
        Me.lblErrorNombre.Name = "lblErrorNombre"
        Me.lblErrorNombre.Size = New System.Drawing.Size(102, 13)
        Me.lblErrorNombre.TabIndex = 18
        Me.lblErrorNombre.Text = "Debe ingresar texto."
        Me.lblErrorNombre.Visible = False
        '
        'lblErrorTripulantes
        '
        Me.lblErrorTripulantes.AutoSize = True
        Me.lblErrorTripulantes.Location = New System.Drawing.Point(394, 108)
        Me.lblErrorTripulantes.Name = "lblErrorTripulantes"
        Me.lblErrorTripulantes.Size = New System.Drawing.Size(96, 13)
        Me.lblErrorTripulantes.TabIndex = 19
        Me.lblErrorTripulantes.Text = "Debe ingresar texo"
        Me.lblErrorTripulantes.Visible = False
        '
        'lblErrorDuracion
        '
        Me.lblErrorDuracion.AutoSize = True
        Me.lblErrorDuracion.Location = New System.Drawing.Point(382, 190)
        Me.lblErrorDuracion.Name = "lblErrorDuracion"
        Me.lblErrorDuracion.Size = New System.Drawing.Size(99, 13)
        Me.lblErrorDuracion.TabIndex = 21
        Me.lblErrorDuracion.Text = "Debe ingresar texto"
        Me.lblErrorDuracion.Visible = False
        '
        'lblErrorDatosInteres
        '
        Me.lblErrorDatosInteres.AutoSize = True
        Me.lblErrorDatosInteres.Location = New System.Drawing.Point(472, 254)
        Me.lblErrorDatosInteres.Name = "lblErrorDatosInteres"
        Me.lblErrorDatosInteres.Size = New System.Drawing.Size(99, 13)
        Me.lblErrorDatosInteres.TabIndex = 22
        Me.lblErrorDatosInteres.Text = "Debe ingresar texto"
        Me.lblErrorDatosInteres.Visible = False
        '
        'lblErrorResultado
        '
        Me.lblErrorResultado.AutoSize = True
        Me.lblErrorResultado.Location = New System.Drawing.Point(879, 55)
        Me.lblErrorResultado.Name = "lblErrorResultado"
        Me.lblErrorResultado.Size = New System.Drawing.Size(99, 13)
        Me.lblErrorResultado.TabIndex = 23
        Me.lblErrorResultado.Text = "Debe ingresar texto"
        Me.lblErrorResultado.Visible = False
        '
        'lblErrorNave
        '
        Me.lblErrorNave.AutoSize = True
        Me.lblErrorNave.Location = New System.Drawing.Point(799, 165)
        Me.lblErrorNave.Name = "lblErrorNave"
        Me.lblErrorNave.Size = New System.Drawing.Size(99, 13)
        Me.lblErrorNave.TabIndex = 24
        Me.lblErrorNave.Text = "Debe ingresar texto"
        Me.lblErrorNave.Visible = False
        '
        'PantallaMision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 625)
        Me.Controls.Add(Me.lblErrorNave)
        Me.Controls.Add(Me.lblErrorResultado)
        Me.Controls.Add(Me.lblErrorDatosInteres)
        Me.Controls.Add(Me.lblErrorDuracion)
        Me.Controls.Add(Me.lblErrorTripulantes)
        Me.Controls.Add(Me.lblErrorNombre)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtNave)
        Me.Controls.Add(Me.lblNave)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.lblDatosInteres)
        Me.Controls.Add(Me.txtDatosInteres)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.dateLanzamiento)
        Me.Controls.Add(Me.lblFechaLanzamiento)
        Me.Controls.Add(Me.txtTripulantes)
        Me.Controls.Add(Me.lbltripulantes)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "PantallaMision"
        Me.Text = "PantallaMision"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lbltripulantes As System.Windows.Forms.Label
    Friend WithEvents txtTripulantes As System.Windows.Forms.TextBox
    Friend WithEvents lblFechaLanzamiento As System.Windows.Forms.Label
    Friend WithEvents dateLanzamiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDuracion As System.Windows.Forms.Label
    Friend WithEvents txtDatosInteres As System.Windows.Forms.TextBox
    Friend WithEvents lblDatosInteres As System.Windows.Forms.Label
    Friend WithEvents txtDuracion As System.Windows.Forms.TextBox
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents lblNave As System.Windows.Forms.Label
    Friend WithEvents txtNave As System.Windows.Forms.TextBox
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lblErrorNombre As System.Windows.Forms.Label
    Friend WithEvents lblErrorTripulantes As System.Windows.Forms.Label
    Friend WithEvents lblErrorDuracion As System.Windows.Forms.Label
    Friend WithEvents lblErrorDatosInteres As System.Windows.Forms.Label
    Friend WithEvents lblErrorResultado As System.Windows.Forms.Label
    Friend WithEvents lblErrorNave As System.Windows.Forms.Label
End Class
