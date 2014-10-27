Imports BLL

Public Class AsignacionSatelite

    Dim idPlaneta As Integer
    Dim gestor As New Gestor()

    Private Sub AsignacionSatelite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim listaSatelites As New ArrayList
        Dim nombre As String
        listaSatelites = gestor.consultarSatelite

        For i As Integer = 0 To listaSatelites.Count - 1

            cmbSatelites.Items.Add(listaSatelites.Item(i).getNombre())

        Next

        nombre = cmbSatelites.SelectedItem

    End Sub

    Public Sub asignarSatelite(ByVal pidPlaneta As Integer)

        idPlaneta = pidPlaneta

    End Sub

    
End Class