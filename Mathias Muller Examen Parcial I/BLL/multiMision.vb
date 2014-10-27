Imports DAL
Imports System.Data.SqlClient
Imports EntitiesLayer
Public Class multiMision

    Dim acceso As AccesoBD = New AccesoBD()

    Public Sub agregarMision(pmision As Mision)

        Dim objParam As New Parametro("Nombre", pmision.getNombre())
        Dim objParam2 As New Parametro("Tripulantes", pmision.getTripulantes())
        Dim objParam3 As New Parametro("Fecha_Lanzamiento", pmision.getFechaLanzamiento())
        Dim objParam4 As New Parametro("Duracion", pmision.getDuracion())
        Dim objParam5 As New Parametro("Datos_Interes", pmision.getDatosInteres())
        Dim objParam6 As New Parametro("Resultado", pmision.getResultado())
        Dim objParam7 As New Parametro("Nombre_Nave", pmision.getNombreNave())

        acceso.EjecutarSQL("Sp_agregarMision", New Parametro() {objParam, objParam2, objParam3, objParam4, objParam5, objParam6, objParam7})

        MsgBox(pmision.getNombre())

    End Sub

    Public Function consultarMisiones() As ArrayList

        Dim listaMisiones As New ArrayList()
        Dim respuesta As SqlDataReader
        Dim mision
        Dim id As Integer
        Dim nombre As String = ""
        Dim tripulantes As String
        Dim fechaLanzamiento As Date
        Dim duracion As String
        Dim datosInteres As String
        Dim resultado As String
        Dim nombreNave As String


        respuesta = acceso.selectInfoEstrellas("Sp_consultarMision")
        While respuesta.Read
            id = (respuesta.Item("idMision"))
            nombre = (respuesta.Item("Nombre"))
            tripulantes = (respuesta.Item("Tripulantes"))
            fechaLanzamiento = (respuesta.Item("Fecha_Lanzamiento"))
            duracion = (respuesta.Item("Duracion"))
            datosInteres = (respuesta.Item("Datos_Interes"))
            resultado = (respuesta.Item("Resultado"))
            nombreNave = (respuesta.Item("Nombre_Nave"))

            mision = New Mision(nombre, tripulantes, fechaLanzamiento, duracion, datosInteres, resultado, nombreNave)
            mision.setId(id)
            listaMisiones.Add(mision)
        End While

        Return listaMisiones

    End Function

End Class
