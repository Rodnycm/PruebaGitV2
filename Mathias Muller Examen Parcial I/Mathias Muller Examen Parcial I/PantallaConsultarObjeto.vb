Imports BLL
Public Class PantallaConsultarObjeto

    Dim gestor As New Gestor()

    

    Private Sub rbtPlaneta_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPlaneta.CheckedChanged

        dataGridPlaneta.Visible = True
        dataGridEstrella.Visible = False
        dataGridSatelite.Visible = False
        dataGridPlaneta.Location = New Point(70, 158)


        Dim listaPlanetas As New ArrayList
        listaPlanetas = gestor.consultarPlaneta()

        For i As Integer = 0 To listaPlanetas.Count - 1

            dataGridPlaneta.Rows.Add(1)
            dataGridPlaneta.Rows(i).Cells(0).Value = listaPlanetas.Item(i).getId()
            dataGridPlaneta.Rows(i).Cells(1).Value = listaPlanetas.Item(i).getNombre()
            dataGridPlaneta.Rows(i).Cells(2).Value = listaPlanetas.Item(i).getMasa()
            dataGridPlaneta.Rows(i).Cells(3).Value = listaPlanetas.Item(i).getTemperaturaMedia()
            dataGridPlaneta.Rows(i).Cells(4).Value = listaPlanetas.Item(i).getDuracionDia()
            dataGridPlaneta.Rows(i).Cells(5).Value = listaPlanetas.Item(i).getDistanciaMediaDelSol()
            dataGridPlaneta.Rows(i).Cells(6).Value = listaPlanetas.Item(i).getDuracionDeUnAno()


        Next
    End Sub

    Private Sub rbtEstrella_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEstrella.CheckedChanged

        dataGridEstrella.Visible = True
        dataGridPlaneta.Visible = False
        dataGridSatelite.Visible = False

        Dim listaEstrellas As New ArrayList
        listaEstrellas = gestor.consultarEstrella()

        For i As Integer = 0 To listaEstrellas.Count - 1

            dataGridEstrella.Rows.Add(1)
            dataGridEstrella.Rows(i).Cells(0).Value = listaEstrellas.Item(i).getId()
            dataGridEstrella.Rows(i).Cells(1).Value = listaEstrellas.Item(i).getNombre()
            dataGridEstrella.Rows(i).Cells(2).Value = listaEstrellas.Item(i).getMasa()
            dataGridEstrella.Rows(i).Cells(3).Value = listaEstrellas.Item(i).getTemperaturaMedia()
            dataGridEstrella.Rows(i).Cells(4).Value = listaEstrellas.Item(i).getDuracionDia()
            dataGridEstrella.Rows(i).Cells(5).Value = listaEstrellas.Item(i).getEdad()
            dataGridEstrella.Rows(i).Cells(6).Value = listaEstrellas.Item(i).getComposicion()
            dataGridEstrella.Rows(i).Cells(7).Value = listaEstrellas.Item(i).getIntensidadLuminica()
            dataGridEstrella.Rows(i).Cells(8).Value = listaEstrellas.Item(i).getTamano()


        Next
    End Sub

    Private Sub rbtSatelite_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSatelite.CheckedChanged

        dataGridSatelite.Visible = True
        dataGridPlaneta.Visible = False
        dataGridEstrella.Visible = False
        dataGridSatelite.Location = New Point(30, 158)

        Dim listaSatelites As New ArrayList
        listaSatelites = gestor.consultarSatelite()

        For i As Integer = 0 To listaSatelites.Count - 1

            dataGridSatelite.Rows.Add(1)
            dataGridSatelite.Rows(i).Cells(0).Value = listaSatelites.Item(i).getId()
            dataGridSatelite.Rows(i).Cells(1).Value = listaSatelites.Item(i).getNombre()
            dataGridSatelite.Rows(i).Cells(2).Value = listaSatelites.Item(i).getMasa()
            dataGridSatelite.Rows(i).Cells(3).Value = listaSatelites.Item(i).getTemperaturaMedia()
            dataGridSatelite.Rows(i).Cells(4).Value = listaSatelites.Item(i).getDuracionDia()
            dataGridSatelite.Rows(i).Cells(5).Value = listaSatelites.Item(i).getDistanciaMedia()
            dataGridSatelite.Rows(i).Cells(6).Value = listaSatelites.Item(i).getCaracteristicas()
          


        Next
    End Sub

   
    Private Sub dataGridSatelite_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridSatelite.CellContentClick

    End Sub
End Class