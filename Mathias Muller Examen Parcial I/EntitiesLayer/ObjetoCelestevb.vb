Public Class ObjetoCelestevb

    Private nombre As String
    Private masa As Double
    Private TemperaturaMedia As Double
    Private duracionDeUnDia As Double

    Public Sub New(ByVal pnombre As String, ByVal pmasa As Double, ByVal ptemperatura As Double, ByVal pduracionDia As Double)

        setNombre(pnombre)
        setMasa(pmasa)
        setTemperaturaMedia(ptemperatura)
        setDuracionDeUnDia(pduracionDia)


    End Sub

    Protected Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Function getNombre() As String

        Return nombre

    End Function

    Public Function getMasa() As Double

        Return masa

    End Function

    Public Function getTemperaturaMedia() As Double

        Return TemperaturaMedia

    End Function

    Public Function getDuracionDia() As Double

        Return duracionDeUnDia

    End Function

    Public Sub setNombre(ByVal pnombre As String)

        nombre = pnombre

    End Sub

    Public Sub setMasa(ByVal pmasa As Double)

        masa = pmasa

    End Sub

    Public Sub setTemperaturaMedia(ByVal ptemp As Double)

        TemperaturaMedia = ptemp

    End Sub

    Public Sub setDuracionDeUnDia(ByVal pduracionDia As Double)

        duracionDeUnDia = pduracionDia

    End Sub
End Class
