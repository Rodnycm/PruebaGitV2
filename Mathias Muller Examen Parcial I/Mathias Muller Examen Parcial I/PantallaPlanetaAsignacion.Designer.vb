<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaPlanetaAsignacion
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
        Me.txtPlanetas = New System.Windows.Forms.ListBox()
        Me.lblLista = New System.Windows.Forms.Label()
        Me.btnSaleccionar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPlanetas
        '
        Me.txtPlanetas.FormattingEnabled = True
        Me.txtPlanetas.Location = New System.Drawing.Point(188, 90)
        Me.txtPlanetas.Name = "txtPlanetas"
        Me.txtPlanetas.Size = New System.Drawing.Size(391, 108)
        Me.txtPlanetas.TabIndex = 0
        '
        'lblLista
        '
        Me.lblLista.AutoSize = True
        Me.lblLista.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLista.Location = New System.Drawing.Point(260, 20)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.Size = New System.Drawing.Size(255, 27)
        Me.lblLista.TabIndex = 1
        Me.lblLista.Text = "Lista De planetas Actuales"
        '
        'btnSaleccionar
        '
        Me.btnSaleccionar.Location = New System.Drawing.Point(328, 253)
        Me.btnSaleccionar.Name = "btnSaleccionar"
        Me.btnSaleccionar.Size = New System.Drawing.Size(121, 23)
        Me.btnSaleccionar.TabIndex = 2
        Me.btnSaleccionar.Text = "Seleccionar"
        Me.btnSaleccionar.UseVisualStyleBackColor = True
        '
        'PantallaPlanetaAsignacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 336)
        Me.Controls.Add(Me.btnSaleccionar)
        Me.Controls.Add(Me.lblLista)
        Me.Controls.Add(Me.txtPlanetas)
        Me.Name = "PantallaPlanetaAsignacion"
        Me.Text = "PantallaPlanetaAsignacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPlanetas As System.Windows.Forms.ListBox
    Friend WithEvents lblLista As System.Windows.Forms.Label
    Friend WithEvents btnSaleccionar As System.Windows.Forms.Button
End Class
