<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaPrincipal
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
        Me.btnCrearObjetoCelste = New System.Windows.Forms.Button()
        Me.btnCrearPrograma = New System.Windows.Forms.Button()
        Me.btnConsultarObjetos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAsignarSatelite = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnConsultarMision = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCrearObjetoCelste
        '
        Me.btnCrearObjetoCelste.Location = New System.Drawing.Point(246, 89)
        Me.btnCrearObjetoCelste.Name = "btnCrearObjetoCelste"
        Me.btnCrearObjetoCelste.Size = New System.Drawing.Size(181, 23)
        Me.btnCrearObjetoCelste.TabIndex = 2
        Me.btnCrearObjetoCelste.Text = "Crear Objeto Celeste"
        Me.btnCrearObjetoCelste.UseVisualStyleBackColor = True
        '
        'btnCrearPrograma
        '
        Me.btnCrearPrograma.Location = New System.Drawing.Point(246, 164)
        Me.btnCrearPrograma.Name = "btnCrearPrograma"
        Me.btnCrearPrograma.Size = New System.Drawing.Size(181, 23)
        Me.btnCrearPrograma.TabIndex = 3
        Me.btnCrearPrograma.Text = "Crear Programa Espacial"
        Me.btnCrearPrograma.UseVisualStyleBackColor = True
        '
        'btnConsultarObjetos
        '
        Me.btnConsultarObjetos.Location = New System.Drawing.Point(246, 235)
        Me.btnConsultarObjetos.Name = "btnConsultarObjetos"
        Me.btnConsultarObjetos.Size = New System.Drawing.Size(181, 23)
        Me.btnConsultarObjetos.TabIndex = 4
        Me.btnConsultarObjetos.Text = "Consultar Objetos"
        Me.btnConsultarObjetos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(246, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Consultar Programas Espaciales"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAsignarSatelite
        '
        Me.btnAsignarSatelite.Location = New System.Drawing.Point(534, 89)
        Me.btnAsignarSatelite.Name = "btnAsignarSatelite"
        Me.btnAsignarSatelite.Size = New System.Drawing.Size(181, 23)
        Me.btnAsignarSatelite.TabIndex = 6
        Me.btnAsignarSatelite.Text = "Asignar Satelite"
        Me.btnAsignarSatelite.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(534, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Crear Mision"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnConsultarMision
        '
        Me.btnConsultarMision.Location = New System.Drawing.Point(534, 235)
        Me.btnConsultarMision.Name = "btnConsultarMision"
        Me.btnConsultarMision.Size = New System.Drawing.Size(181, 23)
        Me.btnConsultarMision.TabIndex = 8
        Me.btnConsultarMision.Text = "Consultar Misiones"
        Me.btnConsultarMision.UseVisualStyleBackColor = True
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 523)
        Me.Controls.Add(Me.btnConsultarMision)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAsignarSatelite)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnConsultarObjetos)
        Me.Controls.Add(Me.btnCrearPrograma)
        Me.Controls.Add(Me.btnCrearObjetoCelste)
        Me.Name = "PantallaPrincipal"
        Me.Text = "PantallaPrincipal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCrearObjetoCelste As System.Windows.Forms.Button
    Friend WithEvents btnCrearPrograma As System.Windows.Forms.Button
    Friend WithEvents btnConsultarObjetos As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAsignarSatelite As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnConsultarMision As System.Windows.Forms.Button
End Class
