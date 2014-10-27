Imports DAL
Imports System.Data.SqlClient
Imports EntitiesLayer

Public Class MultiEstrella
    Dim acceso As AccesoBD = New AccesoBD()

    Public Sub agregarEstrella(pestrella As Estrella)



        Dim agregarEstrella As SqlCommand = New SqlCommand("Sp_agregarEstrella", acceso.GetConexion())
        agregarEstrella.CommandType = CommandType.StoredProcedure



        Dim objParam As New Parametro("Nombre", pestrella.getNombre())
        Dim objParam2 As New Parametro("Masa", pestrella.getMasa())
        Dim objParam3 As New Parametro("Temperatura_Media", pestrella.getTemperaturaMedia())
        Dim objParam4 As New Parametro("Duracion_Dia", pestrella.getDuracionDia())
        Dim objParam5 As New Parametro("Edad", pestrella.getEdad())
        Dim objParam6 As New Parametro("Composicion", pestrella.getComposicion())
        Dim objParam7 As New Parametro("Intensidad_Luminica", pestrella.getIntensidadLuminica())
        Dim objParam8 As New Parametro("Tamano", pestrella.getTamano())


        acceso.EjecutarSQL("Sp_agregarEstrella", New Parametro() {objParam, objParam2, objParam3, objParam4, objParam5, objParam6, objParam7, objParam8})

        MsgBox(pestrella.getNombre())

    End Sub

    Public Function consultarEstrella() As ArrayList

        Dim listaEstrellas As New ArrayList()
        Dim respuesta As SqlDataReader
        Dim estrella
        Dim id As Integer
        Dim nombre As String = ""
        Dim masa As Double
        Dim tempMedia As Double
        Dim duracionDia As Double
        Dim edad As Double
        Dim composicion As String = ""
        Dim intensLuminica As Double
        Dim tamano As Double

        ' Dim listaPlanetas As ArrayList = New ArrayList
        Dim acceso As AccesoBD = New AccesoBD()
        respuesta = acceso.selectInfoEstrellas("Sp_consultarEstrella")
        While respuesta.Read
            id = (respuesta.Item("idEstrella"))
            nombre = (respuesta.Item("Nombre"))
            masa = (respuesta.Item("Masa"))
            tempMedia = (respuesta.Item("Temperatura_Media"))
            duracionDia = (respuesta.Item("Duracion_Dia"))
            edad = (respuesta.Item("Edad"))
            composicion = (respuesta.Item("Composicion"))
            intensLuminica = (respuesta.Item("Intensidad_Luminica"))
            tamano = (respuesta.Item("Tamano"))
            estrella = New Estrella(nombre, masa, tempMedia, duracionDia, edad, composicion, intensLuminica, tamano)
            estrella.setId(id)
            listaEstrellas.Add(estrella)
        End While


        Return listaEstrellas
    End Function

    Public Function llenarComboPlanetas() As ArrayList
        Dim respuesta As SqlDataReader
        Dim listaPlanetas As ArrayList = New ArrayList
        Dim acceso As AccesoBD = New AccesoBD()
        respuesta = acceso.selectInfoEstrellas("Sp_seleccionarPlaneta")
        While respuesta.Read
            listaPlanetas.Add(respuesta.Item("Nombre"))
        End While
        Return listaPlanetas

    End Function

End Class
