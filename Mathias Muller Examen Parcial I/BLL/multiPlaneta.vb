Imports DAL
Imports System.Data.SqlClient
Imports EntitiesLayer

Public Class multiPlaneta

    Dim acceso As AccesoBD = New AccesoBD()

    Public Sub agregarPlaneta(pplaneta As Planeta)

        Dim agregarEstrella As SqlCommand = New SqlCommand("Sp_agregarPlaneta", acceso.GetConexion())
        agregarEstrella.CommandType = CommandType.StoredProcedure



        Dim objParam As New Parametro("Nombre", pplaneta.getNombre())
        Dim objParam2 As New Parametro("Masa", pplaneta.getMasa())
        Dim objParam3 As New Parametro("Temperatura_Media", pplaneta.getTemperaturaMedia())
        Dim objParam4 As New Parametro("Duracion_Dia", pplaneta.getDuracionDia())
        Dim objParam5 As New Parametro("Edad", pplaneta.getDistanciaMediaDelSol())
        Dim objParam6 As New Parametro("Composicion", pplaneta.getDuracionDeUnAno())


        acceso.EjecutarSQL("Sp_agregarPlaneta", New Parametro() {objParam, objParam2, objParam3, objParam4, objParam5, objParam6})

        MsgBox(pplaneta.getNombre())

    End Sub

    Public Function consultarPlaneta() As ArrayList

        Dim listaPlanetas As New ArrayList()
        Dim respuesta As SqlDataReader
        Dim planeta
        Dim id As Integer
        Dim nombre As String = ""
        Dim masa As Double
        Dim tempMedia As Double
        Dim duracionDia As Double
        Dim distanciaMedia As Double
        Dim duracionAno As Double

        ' Dim listaPlanetas As ArrayList = New ArrayList

        respuesta = acceso.selectInfoEstrellas("Sp_consultarPlaneta")
        While respuesta.Read
            id = (respuesta.Item("idPlaneta"))
            nombre = (respuesta.Item("Nombre"))
            masa = (respuesta.Item("Masa"))
            tempMedia = (respuesta.Item("Temperatura_Media"))
            duracionDia = (respuesta.Item("Duracion_Dia"))
            distanciaMedia = (respuesta.Item("Distancia_Media"))
            duracionAno = (respuesta.Item("Duracion_Ano"))

            planeta = New Planeta(nombre, masa, tempMedia, duracionDia, distanciaMedia, duracionAno)
            planeta.setId(id)
            listaPlanetas.Add(planeta)
        End While

        Return listaPlanetas
    End Function


End Class
