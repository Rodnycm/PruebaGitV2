Imports DAL
Imports System.Data.SqlClient
Imports EntitiesLayer

Public Class multiSatelite


    Dim acceso As AccesoBD = New AccesoBD()

    Public Sub agregarSatelite(psatelite As Satelite)


        Dim objParam As New Parametro("Nombre", psatelite.getNombre())
        Dim objParam2 As New Parametro("Masa", psatelite.getMasa())
        Dim objParam3 As New Parametro("Temperatura_Media", psatelite.getTemperaturaMedia())
        Dim objParam4 As New Parametro("Duracion_Dia", psatelite.getDuracionDia())
        Dim objParam5 As New Parametro("Distancia_Media", psatelite.getDistanciaMedia())
        Dim objParam6 As New Parametro("Caracteristicas", psatelite.getCaracteristicas())



        acceso.EjecutarSQL("Sp_agregarSatelite", New Parametro() {objParam, objParam2, objParam3, objParam4, objParam5, objParam6})

        MsgBox(psatelite.getNombre())

    End Sub

    Public Function consultarSatelite() As ArrayList

        Dim listaSatelites As New ArrayList()
        Dim respuesta As SqlDataReader
        Dim satelite
        Dim id As Integer
        Dim nombre As String = ""
        Dim masa As Double
        Dim tempMedia As Double
        Dim duracionDia As Double
        Dim distanciaMedia As Double
        Dim caracteristicas As String

        respuesta = acceso.selectInfoEstrellas("Sp_consultarSatelite")
        While respuesta.Read
            id = (respuesta.Item("idSatelite"))
            nombre = (respuesta.Item("Nombre"))
            masa = (respuesta.Item("Masa"))
            tempMedia = (respuesta.Item("Temperatura_Media"))
            duracionDia = (respuesta.Item("Duracion_Dia"))
            distanciaMedia = (respuesta.Item("Distancia_Media"))
            caracteristicas = (respuesta.Item("Caracteristicas"))

            satelite = New Satelite(nombre, masa, tempMedia, duracionDia, distanciaMedia, caracteristicas)
            satelite.setId(id)
            listaSatelites.Add(satelite)
        End While

        Return listaSatelites
    End Function

    Public Sub asignarSatelite(ByRef psatelite As Satelite)

        Dim objParam As New Parametro("Nombre", psatelite.getId())
        acceso.EjecutarSQL("Sp_asignarSatelite", New Parametro() {objParam})

    End Sub


    Public Function llenarComboSatelite()

        Dim listaSatelites As New ArrayList()
        Dim respuesta As SqlDataReader

        respuesta = acceso.selectInfoEstrellas("Sp_consultarSatelite")
        While respuesta.Read

            listaSatelites.Add(respuesta.Item("Nombre"))
        End While

        Return listaSatelites
    End Function




End Class
