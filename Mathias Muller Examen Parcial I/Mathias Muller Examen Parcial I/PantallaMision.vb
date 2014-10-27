Imports BLL

Public Class PantallaMision

    Private gestor As New Gestor()

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If (gestor.validacionTextBox(txtNombre.Text)) = False Then

            lblErrorNombre.Visible = True

        Else

            lblErrorNombre.Visible = False

        End If

        If (gestor.validacionTextBox(txtTripulantes.Text)) = False Then

            lblErrorTripulantes.Visible = True

        Else

            lblErrorTripulantes.Visible = False

        End If

        If (gestor.validacionTextBox(txtDuracion.Text)) = False Then

            lblErrorDuracion.Visible = True

        Else

            lblErrorDuracion.Visible = True

        End If

        If (gestor.validacionTextBox(txtDatosInteres.Text)) = False Then

            lblErrorDatosInteres.Visible = True

        Else

            lblErrorDatosInteres.Visible = False

        End If

        If (gestor.validacionTextBox(txtResultado.Text)) = False Then

            lblErrorResultado.Visible = True

        Else

            lblErrorResultado.Visible = False

        End If

        If (gestor.validacionTextBox(txtNave.Text)) = False Then

            lblErrorNave.Visible = True

        Else

            lblErrorNave.Visible = False

        End If

        crearMision()

    End Sub

    Public Sub crearMision()

        gestor.registrarMision(txtNombre.Text, txtTripulantes.Text, dateLanzamiento.Text, txtDuracion.Text, txtDatosInteres.Text,
                               txtResultado.Text, txtNave.Text)


    End Sub
   
End Class