<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaObjetoCeleste
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
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.lblErrorMasa = New System.Windows.Forms.Label()
        Me.lblErrorTempMedia = New System.Windows.Forms.Label()
        Me.lblErrorDuracionDia = New System.Windows.Forms.Label()
        Me.lblErrorNombre = New System.Windows.Forms.Label()
        Me.rbtSatelite = New System.Windows.Forms.RadioButton()
        Me.rbtEstrella = New System.Windows.Forms.RadioButton()
        Me.rbtPlaneta = New System.Windows.Forms.RadioButton()
        Me.lblDuracionDia = New System.Windows.Forms.Label()
        Me.lblTempMedia = New System.Windows.Forms.Label()
        Me.lblMasa = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtMasa = New System.Windows.Forms.TextBox()
        Me.txtTemperaturaMedia = New System.Windows.Forms.TextBox()
        Me.txtDuracionDia = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.pnlEstrella = New System.Windows.Forms.Panel()
        Me.lblErrorTamano = New System.Windows.Forms.Label()
        Me.lblErrorEdad = New System.Windows.Forms.Label()
        Me.lblErrorLuminica = New System.Windows.Forms.Label()
        Me.lblErrorComposicion = New System.Windows.Forms.Label()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.lblComposicion = New System.Windows.Forms.Label()
        Me.txtComposicion = New System.Windows.Forms.TextBox()
        Me.lblIntensidadLuminica = New System.Windows.Forms.Label()
        Me.txtIntensidadLuminica = New System.Windows.Forms.TextBox()
        Me.lblTamano = New System.Windows.Forms.Label()
        Me.txtTamano = New System.Windows.Forms.TextBox()
        Me.pnlPlaneta = New System.Windows.Forms.Panel()
        Me.lblErrorDuracionAno = New System.Windows.Forms.Label()
        Me.lblErrorDistSol = New System.Windows.Forms.Label()
        Me.lblDistanciaMedia = New System.Windows.Forms.Label()
        Me.txtDistanciaMedia = New System.Windows.Forms.TextBox()
        Me.lblDuracionAno = New System.Windows.Forms.Label()
        Me.txtDuracionAno = New System.Windows.Forms.TextBox()
        Me.pnlSatelite = New System.Windows.Forms.Panel()
        Me.lblErrorCaracteristicas = New System.Windows.Forms.Label()
        Me.lblErrorDistMediaObjeto = New System.Windows.Forms.Label()
        Me.lblDistanciaEntreObj = New System.Windows.Forms.Label()
        Me.txtDistMediaSatelite = New System.Windows.Forms.TextBox()
        Me.txtCaracteristicas = New System.Windows.Forms.TextBox()
        Me.lblCaracteristicas = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlEstrella.SuspendLayout()
        Me.pnlPlaneta.SuspendLayout()
        Me.pnlSatelite.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(434, 520)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 88
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'lblErrorMasa
        '
        Me.lblErrorMasa.AutoSize = True
        Me.lblErrorMasa.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorMasa.Location = New System.Drawing.Point(553, 129)
        Me.lblErrorMasa.Name = "lblErrorMasa"
        Me.lblErrorMasa.Size = New System.Drawing.Size(138, 13)
        Me.lblErrorMasa.TabIndex = 87
        Me.lblErrorMasa.Text = "Solo debe ingresar numeros"
        Me.lblErrorMasa.Visible = False
        '
        'lblErrorTempMedia
        '
        Me.lblErrorTempMedia.AutoSize = True
        Me.lblErrorTempMedia.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorTempMedia.Location = New System.Drawing.Point(553, 175)
        Me.lblErrorTempMedia.Name = "lblErrorTempMedia"
        Me.lblErrorTempMedia.Size = New System.Drawing.Size(138, 13)
        Me.lblErrorTempMedia.TabIndex = 86
        Me.lblErrorTempMedia.Text = "Solo debe ingresar numeros"
        Me.lblErrorTempMedia.Visible = False
        '
        'lblErrorDuracionDia
        '
        Me.lblErrorDuracionDia.AutoSize = True
        Me.lblErrorDuracionDia.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorDuracionDia.Location = New System.Drawing.Point(553, 228)
        Me.lblErrorDuracionDia.Name = "lblErrorDuracionDia"
        Me.lblErrorDuracionDia.Size = New System.Drawing.Size(138, 13)
        Me.lblErrorDuracionDia.TabIndex = 85
        Me.lblErrorDuracionDia.Text = "Solo debe ingresar numeros"
        Me.lblErrorDuracionDia.Visible = False
        '
        'lblErrorNombre
        '
        Me.lblErrorNombre.AutoSize = True
        Me.lblErrorNombre.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorNombre.Location = New System.Drawing.Point(553, 80)
        Me.lblErrorNombre.Name = "lblErrorNombre"
        Me.lblErrorNombre.Size = New System.Drawing.Size(124, 13)
        Me.lblErrorNombre.TabIndex = 84
        Me.lblErrorNombre.Text = "Solo debe Ingresar letras"
        Me.lblErrorNombre.Visible = False
        '
        'rbtSatelite
        '
        Me.rbtSatelite.AutoSize = True
        Me.rbtSatelite.Location = New System.Drawing.Point(720, 150)
        Me.rbtSatelite.Name = "rbtSatelite"
        Me.rbtSatelite.Size = New System.Drawing.Size(60, 17)
        Me.rbtSatelite.TabIndex = 80
        Me.rbtSatelite.TabStop = True
        Me.rbtSatelite.Text = "Satelite"
        Me.rbtSatelite.UseVisualStyleBackColor = True
        '
        'rbtEstrella
        '
        Me.rbtEstrella.AutoSize = True
        Me.rbtEstrella.Location = New System.Drawing.Point(720, 207)
        Me.rbtEstrella.Name = "rbtEstrella"
        Me.rbtEstrella.Size = New System.Drawing.Size(59, 17)
        Me.rbtEstrella.TabIndex = 79
        Me.rbtEstrella.TabStop = True
        Me.rbtEstrella.Text = "Estrella"
        Me.rbtEstrella.UseVisualStyleBackColor = True
        '
        'rbtPlaneta
        '
        Me.rbtPlaneta.AutoSize = True
        Me.rbtPlaneta.Location = New System.Drawing.Point(720, 98)
        Me.rbtPlaneta.Name = "rbtPlaneta"
        Me.rbtPlaneta.Size = New System.Drawing.Size(61, 17)
        Me.rbtPlaneta.TabIndex = 78
        Me.rbtPlaneta.TabStop = True
        Me.rbtPlaneta.Text = "Planeta"
        Me.rbtPlaneta.UseVisualStyleBackColor = True
        '
        'lblDuracionDia
        '
        Me.lblDuracionDia.AutoSize = True
        Me.lblDuracionDia.Location = New System.Drawing.Point(238, 224)
        Me.lblDuracionDia.Name = "lblDuracionDia"
        Me.lblDuracionDia.Size = New System.Drawing.Size(101, 13)
        Me.lblDuracionDia.TabIndex = 77
        Me.lblDuracionDia.Text = "Duracion De un Dia"
        '
        'lblTempMedia
        '
        Me.lblTempMedia.AutoSize = True
        Me.lblTempMedia.Location = New System.Drawing.Point(238, 175)
        Me.lblTempMedia.Name = "lblTempMedia"
        Me.lblTempMedia.Size = New System.Drawing.Size(99, 13)
        Me.lblTempMedia.TabIndex = 76
        Me.lblTempMedia.Text = "Temperatura Media"
        '
        'lblMasa
        '
        Me.lblMasa.AutoSize = True
        Me.lblMasa.Location = New System.Drawing.Point(238, 126)
        Me.lblMasa.Name = "lblMasa"
        Me.lblMasa.Size = New System.Drawing.Size(33, 13)
        Me.lblMasa.TabIndex = 75
        Me.lblMasa.Text = "Masa"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(238, 87)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 74
        Me.lblNombre.Text = "Nombre"
        '
        'txtMasa
        '
        Me.txtMasa.Location = New System.Drawing.Point(423, 126)
        Me.txtMasa.Name = "txtMasa"
        Me.txtMasa.Size = New System.Drawing.Size(100, 20)
        Me.txtMasa.TabIndex = 73
        '
        'txtTemperaturaMedia
        '
        Me.txtTemperaturaMedia.Location = New System.Drawing.Point(423, 168)
        Me.txtTemperaturaMedia.Name = "txtTemperaturaMedia"
        Me.txtTemperaturaMedia.Size = New System.Drawing.Size(100, 20)
        Me.txtTemperaturaMedia.TabIndex = 72
        '
        'txtDuracionDia
        '
        Me.txtDuracionDia.Location = New System.Drawing.Point(423, 221)
        Me.txtDuracionDia.Name = "txtDuracionDia"
        Me.txtDuracionDia.Size = New System.Drawing.Size(100, 20)
        Me.txtDuracionDia.TabIndex = 71
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(423, 80)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 70
        '
        'pnlEstrella
        '
        Me.pnlEstrella.Controls.Add(Me.lblErrorTamano)
        Me.pnlEstrella.Controls.Add(Me.lblErrorEdad)
        Me.pnlEstrella.Controls.Add(Me.lblErrorLuminica)
        Me.pnlEstrella.Controls.Add(Me.lblErrorComposicion)
        Me.pnlEstrella.Controls.Add(Me.txtEdad)
        Me.pnlEstrella.Controls.Add(Me.lblEdad)
        Me.pnlEstrella.Controls.Add(Me.lblComposicion)
        Me.pnlEstrella.Controls.Add(Me.txtComposicion)
        Me.pnlEstrella.Controls.Add(Me.lblIntensidadLuminica)
        Me.pnlEstrella.Controls.Add(Me.txtIntensidadLuminica)
        Me.pnlEstrella.Controls.Add(Me.lblTamano)
        Me.pnlEstrella.Controls.Add(Me.txtTamano)
        Me.pnlEstrella.Location = New System.Drawing.Point(12, 58)
        Me.pnlEstrella.Name = "pnlEstrella"
        Me.pnlEstrella.Size = New System.Drawing.Size(523, 200)
        Me.pnlEstrella.TabIndex = 89
        Me.pnlEstrella.Visible = False
        '
        'lblErrorTamano
        '
        Me.lblErrorTamano.AutoSize = True
        Me.lblErrorTamano.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorTamano.Location = New System.Drawing.Point(348, 166)
        Me.lblErrorTamano.Name = "lblErrorTamano"
        Me.lblErrorTamano.Size = New System.Drawing.Size(138, 13)
        Me.lblErrorTamano.TabIndex = 83
        Me.lblErrorTamano.Text = "Solo debe ingresar numeros"
        Me.lblErrorTamano.Visible = False
        '
        'lblErrorEdad
        '
        Me.lblErrorEdad.AutoSize = True
        Me.lblErrorEdad.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorEdad.Location = New System.Drawing.Point(348, 32)
        Me.lblErrorEdad.Name = "lblErrorEdad"
        Me.lblErrorEdad.Size = New System.Drawing.Size(138, 13)
        Me.lblErrorEdad.TabIndex = 80
        Me.lblErrorEdad.Text = "Solo debe ingresar numeros"
        Me.lblErrorEdad.Visible = False
        '
        'lblErrorLuminica
        '
        Me.lblErrorLuminica.AutoSize = True
        Me.lblErrorLuminica.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorLuminica.Location = New System.Drawing.Point(348, 120)
        Me.lblErrorLuminica.Name = "lblErrorLuminica"
        Me.lblErrorLuminica.Size = New System.Drawing.Size(124, 13)
        Me.lblErrorLuminica.TabIndex = 82
        Me.lblErrorLuminica.Text = "Solo debe Ingresar letras"
        Me.lblErrorLuminica.Visible = False
        '
        'lblErrorComposicion
        '
        Me.lblErrorComposicion.AutoSize = True
        Me.lblErrorComposicion.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorComposicion.Location = New System.Drawing.Point(348, 71)
        Me.lblErrorComposicion.Name = "lblErrorComposicion"
        Me.lblErrorComposicion.Size = New System.Drawing.Size(124, 13)
        Me.lblErrorComposicion.TabIndex = 81
        Me.lblErrorComposicion.Text = "Solo debe Ingresar letras"
        Me.lblErrorComposicion.Visible = False
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(225, 22)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(100, 20)
        Me.txtEdad.TabIndex = 76
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Location = New System.Drawing.Point(37, 32)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(32, 13)
        Me.lblEdad.TabIndex = 72
        Me.lblEdad.Text = "Edad"
        '
        'lblComposicion
        '
        Me.lblComposicion.AutoSize = True
        Me.lblComposicion.Location = New System.Drawing.Point(37, 71)
        Me.lblComposicion.Name = "lblComposicion"
        Me.lblComposicion.Size = New System.Drawing.Size(67, 13)
        Me.lblComposicion.TabIndex = 73
        Me.lblComposicion.Text = "Composicion"
        '
        'txtComposicion
        '
        Me.txtComposicion.Location = New System.Drawing.Point(225, 68)
        Me.txtComposicion.Name = "txtComposicion"
        Me.txtComposicion.Size = New System.Drawing.Size(100, 20)
        Me.txtComposicion.TabIndex = 79
        '
        'lblIntensidadLuminica
        '
        Me.lblIntensidadLuminica.AutoSize = True
        Me.lblIntensidadLuminica.Location = New System.Drawing.Point(37, 120)
        Me.lblIntensidadLuminica.Name = "lblIntensidadLuminica"
        Me.lblIntensidadLuminica.Size = New System.Drawing.Size(101, 13)
        Me.lblIntensidadLuminica.TabIndex = 74
        Me.lblIntensidadLuminica.Text = "Intensidad Luminica"
        '
        'txtIntensidadLuminica
        '
        Me.txtIntensidadLuminica.Location = New System.Drawing.Point(225, 117)
        Me.txtIntensidadLuminica.Name = "txtIntensidadLuminica"
        Me.txtIntensidadLuminica.Size = New System.Drawing.Size(100, 20)
        Me.txtIntensidadLuminica.TabIndex = 78
        '
        'lblTamano
        '
        Me.lblTamano.AutoSize = True
        Me.lblTamano.Location = New System.Drawing.Point(37, 169)
        Me.lblTamano.Name = "lblTamano"
        Me.lblTamano.Size = New System.Drawing.Size(46, 13)
        Me.lblTamano.TabIndex = 75
        Me.lblTamano.Text = "Tamano"
        '
        'txtTamano
        '
        Me.txtTamano.Location = New System.Drawing.Point(225, 163)
        Me.txtTamano.Name = "txtTamano"
        Me.txtTamano.Size = New System.Drawing.Size(100, 20)
        Me.txtTamano.TabIndex = 77
        '
        'pnlPlaneta
        '
        Me.pnlPlaneta.Controls.Add(Me.lblErrorDuracionAno)
        Me.pnlPlaneta.Controls.Add(Me.lblErrorDistSol)
        Me.pnlPlaneta.Controls.Add(Me.lblDistanciaMedia)
        Me.pnlPlaneta.Controls.Add(Me.txtDistanciaMedia)
        Me.pnlPlaneta.Controls.Add(Me.lblDuracionAno)
        Me.pnlPlaneta.Controls.Add(Me.txtDuracionAno)
        Me.pnlPlaneta.Location = New System.Drawing.Point(38, 298)
        Me.pnlPlaneta.Name = "pnlPlaneta"
        Me.pnlPlaneta.Size = New System.Drawing.Size(461, 189)
        Me.pnlPlaneta.TabIndex = 90
        Me.pnlPlaneta.Visible = False
        '
        'lblErrorDuracionAno
        '
        Me.lblErrorDuracionAno.AutoSize = True
        Me.lblErrorDuracionAno.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorDuracionAno.Location = New System.Drawing.Point(308, 62)
        Me.lblErrorDuracionAno.Name = "lblErrorDuracionAno"
        Me.lblErrorDuracionAno.Size = New System.Drawing.Size(138, 13)
        Me.lblErrorDuracionAno.TabIndex = 82
        Me.lblErrorDuracionAno.Text = "Solo debe ingresar numeros"
        Me.lblErrorDuracionAno.Visible = False
        '
        'lblErrorDistSol
        '
        Me.lblErrorDistSol.AutoSize = True
        Me.lblErrorDistSol.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorDistSol.Location = New System.Drawing.Point(308, 19)
        Me.lblErrorDistSol.Name = "lblErrorDistSol"
        Me.lblErrorDistSol.Size = New System.Drawing.Size(138, 13)
        Me.lblErrorDistSol.TabIndex = 81
        Me.lblErrorDistSol.Text = "Solo debe ingresar numeros"
        Me.lblErrorDistSol.Visible = False
        '
        'lblDistanciaMedia
        '
        Me.lblDistanciaMedia.AutoSize = True
        Me.lblDistanciaMedia.Location = New System.Drawing.Point(16, 19)
        Me.lblDistanciaMedia.Name = "lblDistanciaMedia"
        Me.lblDistanciaMedia.Size = New System.Drawing.Size(120, 13)
        Me.lblDistanciaMedia.TabIndex = 73
        Me.lblDistanciaMedia.Text = "Distancia Media Del Sol"
        '
        'txtDistanciaMedia
        '
        Me.txtDistanciaMedia.Location = New System.Drawing.Point(199, 12)
        Me.txtDistanciaMedia.Name = "txtDistanciaMedia"
        Me.txtDistanciaMedia.Size = New System.Drawing.Size(100, 20)
        Me.txtDistanciaMedia.TabIndex = 77
        '
        'lblDuracionAno
        '
        Me.lblDuracionAno.AutoSize = True
        Me.lblDuracionAno.Location = New System.Drawing.Point(16, 62)
        Me.lblDuracionAno.Name = "lblDuracionAno"
        Me.lblDuracionAno.Size = New System.Drawing.Size(104, 13)
        Me.lblDuracionAno.TabIndex = 74
        Me.lblDuracionAno.Text = "Duracion De un Ano"
        '
        'txtDuracionAno
        '
        Me.txtDuracionAno.Location = New System.Drawing.Point(199, 62)
        Me.txtDuracionAno.Name = "txtDuracionAno"
        Me.txtDuracionAno.Size = New System.Drawing.Size(100, 20)
        Me.txtDuracionAno.TabIndex = 80
        '
        'pnlSatelite
        '
        Me.pnlSatelite.Controls.Add(Me.lblErrorCaracteristicas)
        Me.pnlSatelite.Controls.Add(Me.lblErrorDistMediaObjeto)
        Me.pnlSatelite.Controls.Add(Me.lblDistanciaEntreObj)
        Me.pnlSatelite.Controls.Add(Me.txtDistMediaSatelite)
        Me.pnlSatelite.Controls.Add(Me.txtCaracteristicas)
        Me.pnlSatelite.Controls.Add(Me.lblCaracteristicas)
        Me.pnlSatelite.Location = New System.Drawing.Point(520, 360)
        Me.pnlSatelite.Name = "pnlSatelite"
        Me.pnlSatelite.Size = New System.Drawing.Size(443, 127)
        Me.pnlSatelite.TabIndex = 91
        Me.pnlSatelite.Visible = False
        '
        'lblErrorCaracteristicas
        '
        Me.lblErrorCaracteristicas.AutoSize = True
        Me.lblErrorCaracteristicas.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorCaracteristicas.Location = New System.Drawing.Point(298, 62)
        Me.lblErrorCaracteristicas.Name = "lblErrorCaracteristicas"
        Me.lblErrorCaracteristicas.Size = New System.Drawing.Size(124, 13)
        Me.lblErrorCaracteristicas.TabIndex = 77
        Me.lblErrorCaracteristicas.Text = "Solo debe Ingresar letras"
        Me.lblErrorCaracteristicas.Visible = False
        '
        'lblErrorDistMediaObjeto
        '
        Me.lblErrorDistMediaObjeto.AutoSize = True
        Me.lblErrorDistMediaObjeto.ForeColor = System.Drawing.Color.DarkRed
        Me.lblErrorDistMediaObjeto.Location = New System.Drawing.Point(298, 26)
        Me.lblErrorDistMediaObjeto.Name = "lblErrorDistMediaObjeto"
        Me.lblErrorDistMediaObjeto.Size = New System.Drawing.Size(138, 13)
        Me.lblErrorDistMediaObjeto.TabIndex = 78
        Me.lblErrorDistMediaObjeto.Text = "Solo debe ingresar numeros"
        Me.lblErrorDistMediaObjeto.Visible = False
        '
        'lblDistanciaEntreObj
        '
        Me.lblDistanciaEntreObj.AutoSize = True
        Me.lblDistanciaEntreObj.Location = New System.Drawing.Point(7, 23)
        Me.lblDistanciaEntreObj.Name = "lblDistanciaEntreObj"
        Me.lblDistanciaEntreObj.Size = New System.Drawing.Size(134, 13)
        Me.lblDistanciaEntreObj.TabIndex = 71
        Me.lblDistanciaEntreObj.Text = "Distancia Media del Objeto"
        '
        'txtDistMediaSatelite
        '
        Me.txtDistMediaSatelite.Location = New System.Drawing.Point(192, 23)
        Me.txtDistMediaSatelite.Name = "txtDistMediaSatelite"
        Me.txtDistMediaSatelite.Size = New System.Drawing.Size(100, 20)
        Me.txtDistMediaSatelite.TabIndex = 74
        '
        'txtCaracteristicas
        '
        Me.txtCaracteristicas.Location = New System.Drawing.Point(192, 55)
        Me.txtCaracteristicas.Name = "txtCaracteristicas"
        Me.txtCaracteristicas.Size = New System.Drawing.Size(100, 20)
        Me.txtCaracteristicas.TabIndex = 76
        '
        'lblCaracteristicas
        '
        Me.lblCaracteristicas.AutoSize = True
        Me.lblCaracteristicas.Location = New System.Drawing.Point(7, 58)
        Me.lblCaracteristicas.Name = "lblCaracteristicas"
        Me.lblCaracteristicas.Size = New System.Drawing.Size(76, 13)
        Me.lblCaracteristicas.TabIndex = 72
        Me.lblCaracteristicas.Text = "Caracteristicas"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(757, 298)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(569, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "amor"
        '
        'PantallaObjetoCeleste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 608)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlSatelite)
        Me.Controls.Add(Me.pnlPlaneta)
        Me.Controls.Add(Me.pnlEstrella)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.lblErrorMasa)
        Me.Controls.Add(Me.lblErrorTempMedia)
        Me.Controls.Add(Me.lblErrorDuracionDia)
        Me.Controls.Add(Me.lblErrorNombre)
        Me.Controls.Add(Me.rbtSatelite)
        Me.Controls.Add(Me.rbtEstrella)
        Me.Controls.Add(Me.rbtPlaneta)
        Me.Controls.Add(Me.lblDuracionDia)
        Me.Controls.Add(Me.lblTempMedia)
        Me.Controls.Add(Me.lblMasa)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtMasa)
        Me.Controls.Add(Me.txtTemperaturaMedia)
        Me.Controls.Add(Me.txtDuracionDia)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "PantallaObjetoCeleste"
        Me.Text = "PantallaObjetoCeleste"
        Me.pnlEstrella.ResumeLayout(False)
        Me.pnlEstrella.PerformLayout()
        Me.pnlPlaneta.ResumeLayout(False)
        Me.pnlPlaneta.PerformLayout()
        Me.pnlSatelite.ResumeLayout(False)
        Me.pnlSatelite.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblErrorMasa As System.Windows.Forms.Label
    Friend WithEvents lblErrorTempMedia As System.Windows.Forms.Label
    Friend WithEvents lblErrorDuracionDia As System.Windows.Forms.Label
    Friend WithEvents lblErrorNombre As System.Windows.Forms.Label
    Friend WithEvents rbtSatelite As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEstrella As System.Windows.Forms.RadioButton
    Friend WithEvents rbtPlaneta As System.Windows.Forms.RadioButton
    Friend WithEvents lblDuracionDia As System.Windows.Forms.Label
    Friend WithEvents lblTempMedia As System.Windows.Forms.Label
    Friend WithEvents lblMasa As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtMasa As System.Windows.Forms.TextBox
    Friend WithEvents txtTemperaturaMedia As System.Windows.Forms.TextBox
    Friend WithEvents txtDuracionDia As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents pnlEstrella As System.Windows.Forms.Panel
    Friend WithEvents lblErrorTamano As System.Windows.Forms.Label
    Friend WithEvents lblErrorEdad As System.Windows.Forms.Label
    Friend WithEvents lblErrorLuminica As System.Windows.Forms.Label
    Friend WithEvents lblErrorComposicion As System.Windows.Forms.Label
    Friend WithEvents txtEdad As System.Windows.Forms.TextBox
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents lblComposicion As System.Windows.Forms.Label
    Friend WithEvents txtComposicion As System.Windows.Forms.TextBox
    Friend WithEvents lblIntensidadLuminica As System.Windows.Forms.Label
    Friend WithEvents txtIntensidadLuminica As System.Windows.Forms.TextBox
    Friend WithEvents lblTamano As System.Windows.Forms.Label
    Friend WithEvents txtTamano As System.Windows.Forms.TextBox
    Friend WithEvents pnlPlaneta As System.Windows.Forms.Panel
    Friend WithEvents lblErrorDuracionAno As System.Windows.Forms.Label
    Friend WithEvents lblErrorDistSol As System.Windows.Forms.Label
    Friend WithEvents lblDistanciaMedia As System.Windows.Forms.Label
    Friend WithEvents txtDistanciaMedia As System.Windows.Forms.TextBox
    Friend WithEvents lblDuracionAno As System.Windows.Forms.Label
    Friend WithEvents txtDuracionAno As System.Windows.Forms.TextBox
    Friend WithEvents pnlSatelite As System.Windows.Forms.Panel
    Friend WithEvents lblErrorCaracteristicas As System.Windows.Forms.Label
    Friend WithEvents lblErrorDistMediaObjeto As System.Windows.Forms.Label
    Friend WithEvents lblDistanciaEntreObj As System.Windows.Forms.Label
    Friend WithEvents txtDistMediaSatelite As System.Windows.Forms.TextBox
    Friend WithEvents txtCaracteristicas As System.Windows.Forms.TextBox
    Friend WithEvents lblCaracteristicas As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
