Imports BLL

Public Class PantallaConsultarPrograma

    Dim gestor As New Gestor()

    Private Sub PantallaConsultarPrograma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim listaProgramas As New ArrayList
        listaProgramas = gestor.consultarPrograma()

        For i As Integer = 0 To listaProgramas.Count - 1

            dataGridPrograma.Rows.Add(1 + i)

            dataGridPrograma.Rows(i).Cells(0).Value = listaProgramas.Item(i).getId()
            dataGridPrograma.Rows(i).Cells(1).Value = listaProgramas.Item(i).getNombre()
            dataGridPrograma.Rows(i).Cells(2).Value = listaProgramas.Item(i).getFechaDeInicio()
            dataGridPrograma.Rows(i).Cells(3).Value = listaProgramas.Item(i).getFechaDeFinalizacion()
            dataGridPrograma.Rows(i).Cells(4).Value = listaProgramas.Item(i).getAlcance()

        Next
    End Sub
End Class