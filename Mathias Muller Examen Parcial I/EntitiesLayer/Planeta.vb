Public Class Planeta
    Inherits ObjetoCelestevb

    Private id As Integer
    Private distanciaMediaDelSol As Double
    Private duracionDeUnAno As Double
    Private cantSatelites As Integer
    Private listaSatelites As List(Of Satelite)


    Public Sub New(ByVal pnombre As String, ByVal pmasa As Double, ByVal ptemperatura As Double, ByVal pduracionDia As Double,
                   ByVal pdistancia As Double, ByVal pduracion As Double)

        MyBase.New(pnombre, pmasa, ptemperatura, pduracionDia)
        setDistanciaMediaDelSol(pdistancia)
        setDuracionDeUnAno(pduracion)
        'setCantSatelites(pcantSatelites)

    End Sub

    Public Function getId()

        Return id

    End Function

    Public Sub setId(ByVal pid As Integer)

        id = pid

    End Sub

    Public Function getDistanciaMediaDelSol()
        Return distanciaMediaDelSol
    End Function

    Public Function getDuracionDeUnAno()

        Return duracionDeUnAno

    End Function

    Public Function getCantSatelites()

        Return cantSatelites

    End Function

    Public Sub setDistanciaMediaDelSol(ByVal pdist As Double)

        distanciaMediaDelSol = pdist

    End Sub

    Public Sub setDuracionDeUnAno(ByVal pduracion As Double)

        duracionDeUnAno = pduracion

    End Sub

    ' Public Sub setCantSatelites(ByVal pcantSatelites As Integer)

    'cantSatelites = pcantSatelites

    '    End Sub

    Public Sub agregarSatelite(ByRef psatelite As Satelite)

        listaSatelites.Add(psatelite)

    End Sub

    Public Sub contarSatelites()

        cantSatelites = listaSatelites.Count()

    End Sub

End Class
