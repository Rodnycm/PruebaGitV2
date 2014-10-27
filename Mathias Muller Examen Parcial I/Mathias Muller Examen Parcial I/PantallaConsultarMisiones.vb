Imports BLL

Public Class PantallaConsultarMisiones

    Dim gestor As New Gestor()

    Private Sub PantallaConsultarMisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim listaMisiones As New ArrayList
        listaMisiones = gestor.consultarMision()

        For i As Integer = 0 To listaMisiones.Count - 1

            dataGridMisiones.Rows.Add(1 + i)
            dataGridMisiones.Rows(i).Cells(0).Value = listaMisiones.Item(i).getId()
            dataGridMisiones.Rows(i).Cells(1).Value = listaMisiones.Item(i).getNombre()
            dataGridMisiones.Rows(i).Cells(2).Value = listaMisiones.Item(i).getTripulantes()
            dataGridMisiones.Rows(i).Cells(3).Value = listaMisiones.Item(i).getFechaLanzamiento()
            dataGridMisiones.Rows(i).Cells(4).Value = listaMisiones.Item(i).getDuracion()
            dataGridMisiones.Rows(i).Cells(5).Value = listaMisiones.Item(i).getDatosInteres()
            dataGridMisiones.Rows(i).Cells(6).Value = listaMisiones.Item(i).getResultado()
            dataGridMisiones.Rows(i).Cells(7).Value = listaMisiones.Item(i).getNombreNAve()

        Next

    End Sub
End Class