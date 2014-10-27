Public Class Satelite
    Inherits ObjetoCelestevb

    Private id As Integer
    Private distanciaMediaSatYObjeto As Double
    Private caracteristicas As String

    Public Sub New(ByVal pnombre As String, ByVal pmasa As Double, ByVal ptemperatura As Double, ByVal pduracionDia As Double,
                   ByVal pdistancia As Double, ByVal pcaracteristicas As String)

        MyBase.New(pnombre, pmasa, ptemperatura, pduracionDia)
        setDistanciaMedia(pdistancia)
        setCaracteristicas(pcaracteristicas)

    End Sub


    Public Function getId()

        Return id

    End Function

    Public Sub setId(ByVal pid As Integer)

        id = pid

    End Sub

    Public Function getDistanciaMedia()

        Return distanciaMediaSatYObjeto

    End Function

    Public Function getCaracteristicas()

        Return caracteristicas

    End Function


    Public Sub setDistanciaMedia(ByVal pdist As Double)

        distanciaMediaSatYObjeto = pdist

    End Sub

    Public Sub setCaracteristicas(ByVal pcaracteristicas As String)

        caracteristicas = pcaracteristicas

    End Sub


End Class
