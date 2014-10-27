<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignacionSatelite
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
        Me.lblSatelites = New System.Windows.Forms.Label()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.cmbSatelites = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblSatelites
        '
        Me.lblSatelites.AutoSize = True
        Me.lblSatelites.Location = New System.Drawing.Point(246, 30)
        Me.lblSatelites.Name = "lblSatelites"
        Me.lblSatelites.Size = New System.Drawing.Size(98, 13)
        Me.lblSatelites.TabIndex = 1
        Me.lblSatelites.Text = "Satelites Existentes"
        '
        'btnAsignar
        '
        Me.btnAsignar.Location = New System.Drawing.Point(260, 152)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(75, 23)
        Me.btnAsignar.TabIndex = 2
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'cmbSatelites
        '
        Me.cmbSatelites.FormattingEnabled = True
        Me.cmbSatelites.Location = New System.Drawing.Point(202, 63)
        Me.cmbSatelites.Name = "cmbSatelites"
        Me.cmbSatelites.Size = New System.Drawing.Size(186, 21)
        Me.cmbSatelites.TabIndex = 3
        '
        'AsignacionSatelite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 239)
        Me.Controls.Add(Me.cmbSatelites)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.lblSatelites)
        Me.Name = "AsignacionSatelite"
        Me.Text = "AsignacionSatelite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSatelites As System.Windows.Forms.Label
    Friend WithEvents btnAsignar As System.Windows.Forms.Button
    Friend WithEvents cmbSatelites As System.Windows.Forms.ComboBox
End Class
