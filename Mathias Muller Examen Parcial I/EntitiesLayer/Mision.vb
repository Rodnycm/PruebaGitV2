Public Class Mision

    Private id As Integer
    Private nombreMision As String
    Private tripulantes As String
    Private fechaLanzamiento As Date
    Private duracion As String
    Private datosInteres As String
    Private resultado As String
    Private nombreNave As String
    Private objeto As ObjetoCelestevb()

    Public Sub New(ByVal pnombre As String, ByVal ptripulantes As String, ByVal pfecha As Date, ByVal pduracion As String,
                 ByVal pdatos As String, ByVal presul As String, ByVal pnombreNave As String)

        setNombre(pnombre)
        setTripulantes(ptripulantes)
        setFechaLanzamiento(pfecha)
        setDuracion(pduracion)
        setDatosInteres(pdatos)
        setResultado(presul)
        setNombreNave(pnombre)

    End Sub

    Public Function getId()

        Return id

    End Function

    Public Sub setId(ByVal pid As Integer)

        id = pid

    End Sub

    Public Function getNombre()

        Return nombreMision

    End Function

    Public Function getTripulantes()

        Return tripulantes

    End Function

    Public Function getFechaLanzamiento()

        Return fechaLanzamiento

    End Function

    Public Function getDuracion()

        Return duracion

    End Function



    Public Function getDatosInteres()

        Return datosInteres

    End Function

    Public Function getResultado()

        Return resultado

    End Function

    Public Function getNombreNave()

        Return nombreNave

    End Function

    Public Sub setNombre(ByVal pnombre As String)

        nombreMision = pnombre

    End Sub

    Public Sub setTripulantes(ByVal ptripulantes As String)

        Me.tripulantes = ptripulantes

    End Sub

    Public Sub setFechaLanzamiento(ByVal pfechaLanzamiento As Date)

        Me.fechaLanzamiento = pfechaLanzamiento

    End Sub

    Public Sub setDuracion(ByVal pduracion As String)

        Me.duracion = pduracion

    End Sub
    Public Sub setDatosInteres(ByVal pdatos As String)

        Me.datosInteres = pdatos

    End Sub
    Public Sub setResultado(ByVal presul As String)

        Me.resultado = presul

    End Sub

    Public Sub setNombreNave(ByVal pnave As String)

        Me.nombreNave = pnave

    End Sub

End Class
