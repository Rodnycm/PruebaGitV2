Imports BLL

Public Class PantallaObjetoCeleste

    Dim tipoObjeto As String

    Private gestor As Gestor = New Gestor()

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub rbtPlaneta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPlaneta.CheckedChanged

        pnlPlaneta.Visible = True
        pnlEstrella.Visible = False
        pnlSatelite.Visible = False
        tipoObjeto = "planeta"

        pnlPlaneta.Location = New Point(225, 255)

    End Sub

    Private Sub rbtSatelite_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSatelite.CheckedChanged


        pnlPlaneta.Visible = False
        pnlEstrella.Visible = False
        pnlSatelite.Visible = True
        tipoObjeto = "satelite"
        pnlSatelite.Location = New Point(235, 244)

    End Sub

    Private Sub rbtEstrella_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEstrella.CheckedChanged

        pnlPlaneta.Visible = False
        pnlEstrella.Visible = True
        pnlSatelite.Visible = False
        tipoObjeto = "estrella"
        pnlEstrella.Location = New Point(200, 245)

    End Sub
    '******************************************************************************************************
    'VALIDACIONES
    '******************************************************************************************************

    Private Sub valdiacionesObjetoCeleste()

        If gestor.validacionTextBox(txtNombre.Text) = False Then

            lblErrorNombre.Visible = True

        Else

            lblErrorNombre.Visible = False
        End If

        If gestor.validacionTextBox(txtMasa.Text) = True Then

            lblErrorMasa.Visible = True

        Else
            lblErrorMasa.Visible = False

        End If
        If gestor.validacionTextBox(txtTemperaturaMedia.Text) = True Then

            lblErrorTempMedia.Visible = True

        Else
            lblErrorTempMedia.Visible = False
        End If

        If gestor.validacionTextBox(txtDuracionDia.Text) = True Then

            lblErrorDuracionDia.Visible = True

        Else
            lblErrorDuracionDia.Visible = False

        End If



    End Sub

    Private Sub validacionCampoVacio()

        If gestor.validacionCampoVacio(txtNombre.Text) = False Then

            txtNombre.BackColor = Color.Red

        Else

            txtNombre.BackColor = Color.White

        End If

        If gestor.validacionCampoVacio(txtMasa.Text) = False Then

            txtMasa.BackColor = Color.Red

        Else

            txtMasa.BackColor = Color.White

        End If

        If gestor.validacionCampoVacio(txtTemperaturaMedia.Text) = False Then

            txtTemperaturaMedia.BackColor = Color.Red

        Else

            txtTemperaturaMedia.BackColor = Color.White

        End If

        If gestor.validacionCampoVacio(txtDuracionDia.Text) = False Then

            txtDuracionDia.BackColor = Color.Red

        Else

            txtDuracionDia.BackColor = Color.White
        End If

    End Sub

    Private Sub validacionPlaneta()

        If gestor.validacionTextBox(txtDistanciaMedia.Text) = True Then

            lblErrorDistSol.Visible = True

        Else

            lblErrorDistSol.Visible = False
        End If

        If gestor.validacionTextBox(txtDuracionAno.Text) = True Then

            lblErrorDuracionAno.Visible = True

        Else

            lblErrorDuracionAno.Visible = False

        End If

    End Sub

    Private Sub validacionesCamposVaciosPlaneta()

        If gestor.validacionCampoVacio(txtDistanciaMedia.Text) = False Then

            txtDistanciaMedia.BackColor = Color.Red

        Else
            txtDistanciaMedia.BackColor = Color.White

        End If

        If gestor.validacionCampoVacio(txtDuracionAno.Text) = False Then

            txtDuracionAno.BackColor = Color.Red

        Else
            txtDuracionAno.BackColor = Color.White

        End If

    End Sub

    Private Sub validacionEstrella()

        If gestor.validacionTextBox(txtEdad.Text) = True Then

            lblErrorEdad.Visible = True

        Else

            lblErrorEdad.Visible = False
        End If

        If gestor.validacionTextBox(txtComposicion.Text) = True Then

            lblErrorComposicion.Visible = True

        Else
            lblErrorComposicion.Visible = False
        End If

        If gestor.validacionTextBox(txtIntensidadLuminica.Text) = True Then

            lblErrorLuminica.Visible = True
        Else
            lblErrorLuminica.Visible = False

        End If

        If gestor.validacionTextBox(txtTamano.Text) = True Then

            lblErrorTamano.Visible = True

        Else
            lblErrorTamano.Visible = False

        End If
    End Sub

    Private Sub validacionesCampsVaciosEstrella()

        If gestor.validacionCampoVacio(txtEdad.Text) = False Then

            txtEdad.BackColor = Color.Red

        Else
            txtEdad.BackColor = Color.White

        End If

        If gestor.validacionCampoVacio(txtComposicion.Text) = False Then

            txtComposicion.BackColor = Color.Red

        Else
            txtComposicion.BackColor = Color.White

        End If

        If gestor.validacionCampoVacio(txtIntensidadLuminica.Text) = False Then

            txtIntensidadLuminica.BackColor = Color.Red

        Else

            txtIntensidadLuminica.BackColor = Color.White

        End If

        If gestor.validacionCampoVacio(txtTamano.Text) = False Then

            txtTamano.BackColor = Color.Red

        Else
            txtTamano.BackColor = Color.White

        End If
    End Sub

    Private Sub validacionSatelite()

        If gestor.validacionTextBox(txtDistanciaMedia.Text) = False Then

            lblErrorDistMediaObjeto.Visible = True

        Else

            lblErrorDistMediaObjeto.Visible = False
        End If

        If gestor.validacionTextBox(txtCaracteristicas.Text) = True Then

            lblErrorCaracteristicas.Visible = True
        Else

            lblErrorCaracteristicas.Visible = False
        End If

    End Sub


    Private Sub validacionesCamposVaciosSatelite()

        If gestor.validacionCampoVacio(txtDistMediaSatelite.Text) = False Then

            txtDistMediaSatelite.BackColor = Color.Red
        Else
            txtDistMediaSatelite.BackColor = Color.White
        End If

        If gestor.validacionCampoVacio(txtCaracteristicas.Text) = False Then

            txtCaracteristicas.BackColor = Color.Red

        Else

            txtCaracteristicas.BackColor = Color.White
        End If

    End Sub

    '******************************************************************************************************
    'AQUI TERMINAN LOS METODOS QUE VALIDAN
    '******************************************************************************************************

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        valdiacionesObjetoCeleste()
        validacionCampoVacio()
        validacionEstrella()
        validacionesCampsVaciosEstrella()
        validacionPlaneta()
        validacionesCamposVaciosPlaneta()
        validacionesCampsVaciosEstrella()
        validacionSatelite()
        validacionesCamposVaciosSatelite()

        registrarObjetoCeleste()


    End Sub

    Private Sub registrarObjetoCeleste()

        If tipoObjeto = "planeta" Then

            registrarPlaneta()

        ElseIf tipoObjeto = "estrella" Then

            registrarEstrella()

        ElseIf tipoObjeto = "satelite" Then

            registrarSatelite()

        End If

    End Sub

    Private Sub registrarEstrella()

        gestor.registrarEstrella(txtNombre.Text, CType(txtMasa.Text, Double), CType(txtTemperaturaMedia.Text, Double),
                                CType(txtDuracionDia.Text, Double), CType(txtEdad.Text, Double), CType(txtComposicion.Text, Double),
                                    CType(txtIntensidadLuminica.Text, Double), CType(txtTamano.Text, Double))

        MsgBox("Agregado")
    End Sub

    Private Sub registrarPlaneta()

        gestor.registrarPlaneta(txtNombre.Text, CType(txtMasa.Text, Double), CType(txtTemperaturaMedia.Text, Double),
                     CType(txtDuracionDia.Text, Double), CType(txtDistanciaMedia.Text, Double), CType(txtDuracionAno.Text, Double))

        MsgBox("Agregado")
    End Sub

    Private Sub registrarSatelite()

        gestor.registrarSatelite(txtNombre.Text, CType(txtMasa.Text, Double), CType(txtTemperaturaMedia.Text, Double),
         CType(txtDuracionDia.Text, Double), CType(txtDistMediaSatelite.Text, Double), txtCaracteristicas.Text)

        MsgBox("Agregado")
    End Sub

    Private Sub btnAsignarSatelite_Click(sender As Object, e As EventArgs)

        AsignacionSatelite.Show()

    End Sub

End Class