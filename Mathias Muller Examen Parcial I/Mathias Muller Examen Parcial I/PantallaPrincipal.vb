Public Class PantallaPrincipal

    Private Sub btnCrearObjetoCelste_Click(sender As Object, e As EventArgs) Handles btnCrearObjetoCelste.Click

        PantallaObjetoCeleste.Show()


    End Sub

    Private Sub btnCrearPrograma_Click(sender As Object, e As EventArgs) Handles btnCrearPrograma.Click

        PantallaProgramaEspacial.Show()

    End Sub

    Private Sub btnConsultarObjetos_Click(sender As Object, e As EventArgs) Handles btnConsultarObjetos.Click

        PantallaConsultarObjeto.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        PantallaConsultarPrograma.Show()

    End Sub

    Private Sub btnAsignarSatelite_Click(sender As Object, e As EventArgs) Handles btnAsignarSatelite.Click

        PantallaPlanetaAsignacion.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PantallaMision.Show()

    End Sub

    Private Sub btnConsultarMision_Click(sender As Object, e As EventArgs) Handles btnConsultarMision.Click

        PantallaConsultarMisiones.Show()

    End Sub
End Class