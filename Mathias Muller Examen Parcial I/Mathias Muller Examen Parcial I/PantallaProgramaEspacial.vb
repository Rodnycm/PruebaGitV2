Imports BLL
Public Class PantallaProgramaEspacial

    Private gestor As New Gestor

    Private Sub validacionFechaInicio()

        If dateFechaInicio.Value.Date > Today Then

            lblErrorFechaInicio.Visible = True

        Else
            lblErrorFechaInicio.Visible = False

        End If

    End Sub

    Private Sub validacionFechaFinalizacion()

        If dateFechaFinalizacion.Value.Date < Today Then

            lblErrorFechaFinalizacion.Visible = True

        Else
            lblErrorFechaFinalizacion.Visible = False

        End If

    End Sub

    Private Sub btnAgregarMisiones_Click(sender As Object, e As EventArgs) Handles btnAgregarMisiones.Click

        validacionFechaInicio()
        validacionFechaFinalizacion()

    End Sub

    Private Sub btnAgregarPrograma_Click(sender As Object, e As EventArgs) Handles btnAgregarPrograma.Click

        gestor.registrarPrograma(txtNombre.Text, dateFechaInicio.Text, dateFechaFinalizacion.Text, txtAlcance.Text)



    End Sub
End Class