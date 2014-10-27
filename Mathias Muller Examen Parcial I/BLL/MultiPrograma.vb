Imports DAL
Imports System.Data.SqlClient
Imports EntitiesLayer
Public Class MultiPrograma

    Dim acceso As AccesoBD = New AccesoBD()

    Public Sub agregarPrograma(pprograma As ProgramaEspacial)

        Dim objParam As New Parametro("Nombre", pprograma.getNombre())
        Dim objParam2 As New Parametro("Fecha_Inicio", pprograma.getFechaDeInicio())
        Dim objParam3 As New Parametro("Fecha_Finalizacion", pprograma.getFechaDeFinalizacion())
        Dim objParam4 As New Parametro("Alcance", pprograma.getAlcance())

        acceso.EjecutarSQL("Sp_agregarPrograma", New Parametro() {objParam, objParam2, objParam3, objParam4})

        MsgBox(pprograma.getNombre())

    End Sub

    Public Function consultarPrograma() As ArrayList

        Dim listaProgramas As New ArrayList()
        Dim respuesta As SqlDataReader
        Dim programa
        Dim id As Integer
        Dim nombre As String = ""
        Dim fechaInicio As Date
        Dim fechaFinalizacion As Date
        Dim alcance As String = ""

        ' Dim listaPlanetas As ArrayList = New ArrayList
        Dim acceso As AccesoBD = New AccesoBD()
        respuesta = acceso.selectInfoEstrellas("Sp_consultarPrograma")
        While respuesta.Read
            id = (respuesta.Item("idPrograma"))
            nombre = (respuesta.Item("Nombre"))
            fechaInicio = (respuesta.Item("Fecha_Inicio"))
            fechaFinalizacion = (respuesta.Item("Fecha_Finalizacion"))
            alcance = (respuesta.Item("Alcance"))
            programa = New ProgramaEspacial(nombre, fechaInicio, fechaFinalizacion, alcance)
            programa.setId(id)
            listaProgramas.Add(programa)
        End While


        Return listaProgramas

    End Function


End Class
