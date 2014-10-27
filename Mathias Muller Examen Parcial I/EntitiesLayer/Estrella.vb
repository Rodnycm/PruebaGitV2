Public Class Estrella
    Inherits ObjetoCelestevb

    Private id As Integer
    Private edad As Integer
    Private composicion As String
    Private intensidadLuminica As Double
    Private tamano As Double


    Public Sub New(ByVal pnombre As String, ByVal pmasa As Double, ByVal ptemperatura As Double, ByVal pduracionDia As Double,
                   ByVal pedad As Integer, ByVal pcomposicion As String, ByVal pintensidadLuminca As Double, ByVal ptamano As Double)

        MyBase.New(pnombre, pmasa, ptemperatura, pduracionDia)
        setEdad(pedad)
        setComposicion(pcomposicion)
        setIntensidadLuminica(pintensidadLuminca)
        setTamano(ptamano)

        'adsasdasdasdasdasdasda()
        'adsasda()
    End Sub

    Sub crearamor()

    End Sub


    Public Function getId()

        Return id

    End Function

    Public Sub setId(ByVal pid As Integer)

        id = pid

    End Sub

    Public Function getEdad()

        Return edad

    End Function

    Public Function getComposicion()

        Return composicion

    End Function

    Public Function getIntensidadLuminica()

        Return intensidadLuminica

    End Function

    Public Function getTamano()

        Return tamano

    End Function

    Public Sub setEdad(ByVal pedad As Integer)

        Me.edad = pedad

    End Sub

    Public Sub setComposicion(ByVal pcomposicion As String)

        Me.composicion = pcomposicion

    End Sub

    Public Sub setIntensidadLuminica(ByVal pintensidadLuminca As Double)

        Me.intensidadLuminica = pintensidadLuminca

    End Sub

    Public Sub setTamano(ByVal ptamano As Double)

        Me.tamano = ptamano

    End Sub



End Class
