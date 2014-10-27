Imports BLL

Public Class PantallaPlanetaAsignacion


    Private Sub PantallaPlanetaAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim gestor As New Gestor()
        Dim listaPlanetas As New ArrayList()
        Dim idPlaneta As Integer

        listaPlanetas = gestor.consultarPlaneta()

        For i As Integer = 0 To listaPlanetas.Count - 1

            txtPlanetas.Items.Add(listaPlanetas.Item(i).getId)


        Next

        idPlaneta = txtPlanetas.GetSelected(0)


    End Sub

    Private Sub btnSaleccionar_Click(sender As Object, e As EventArgs) Handles btnSaleccionar.Click

        AsignacionSatelite.Show()

    End Sub
End Class