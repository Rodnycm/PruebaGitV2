Public Class ProgramaEspacial

    Private id As Integer
    Private nombre As String
    Private fechaDeInicio As Date
    Private fechaDeFinalizacion As Date
    Private alcance As String
    ' Private listaMisiones As List(Of Mission)

    Public Sub New(ByVal pnombre As String, ByVal pfechaInicio As Date, ByVal pfechaFinalizacion As Date, ByVal palcance As String)

        setNombre(pnombre)
        setFechaInicio(pfechaInicio)
        setFechaFinal(pfechaFinalizacion)
        setAlcance(palcance)

    End Sub


    Public Function getId()

        Return id

    End Function

    Public Sub setId(ByVal pid As Integer)

        id = pid

    End Sub

    Public Function getNombre() As String

        Return nombre

    End Function

    Public Function getFechaDeInicio() As Date

        Return fechaDeInicio

    End Function

    Public Function getFechaDeFinalizacion() As Date

        Return fechaDeFinalizacion

    End Function

    Public Function getAlcance() As String

        Return alcance
    End Function

    Public Sub setNombre(ByVal pnombre As String)

        nombre = pnombre

    End Sub

    Public Sub setFechaInicio(ByVal pfechaInicio As Date)

        fechaDeInicio = pfechaInicio
    End Sub

    Public Sub setFechaFinal(ByVal pfechaFinalizacion As Date)

        fechaDeFinalizacion = pfechaFinalizacion

    End Sub

    Public Sub setAlcance(ByVal palcance As String)

        alcance = palcance

    End Sub
End Class
