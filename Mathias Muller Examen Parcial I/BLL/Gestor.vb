Imports EntitiesLayer
Public Class Gestor

    Private _isNullOrEmpty As Boolean

    Private Property isNullOrEmpty(p1 As String) As Boolean
        Get
            Return _isNullOrEmpty
        End Get
        Set(value As Boolean)
            _isNullOrEmpty = value
        End Set
    End Property


    Public Function validacionTextBox(ByVal ptexto As String) As Boolean

        Dim result As Boolean = True

        If IsNumeric(ptexto) = True Then

            result = False

        End If

        Return result

    End Function

    Public Function validacionCampoVacio(ByVal ptexto As String) As Boolean

        Dim result As Boolean = True

        If String.IsNullOrEmpty(ptexto) = True Then

            result = False

        End If

        Return result

    End Function

    Public Sub registrarEstrella(ByVal pnombre As String, ByVal pmasa As Double, ByVal ptempMedia As Double, ByVal pduracionDia As Double,
                                      ByVal pedad As Double, ByVal pcomposicion As String, ByVal pintensLuminica As Double, ByVal ptamano As Double)

        Dim multiEstrella As New MultiEstrella()

        Dim estrella As New Estrella(pnombre, pmasa, ptempMedia, pduracionDia, pedad, pcomposicion, pintensLuminica, ptamano)

        multiEstrella.agregarEstrella(estrella)

    End Sub

    Public Function consultarEstrella()


        Dim multiEstrella As New MultiEstrella()
        Dim listaEstrellas As New ArrayList()

        listaEstrellas = multiEstrella.consultarEstrella()

        Return listaEstrellas

    End Function

    Public Sub registrarPlaneta(ByVal pnombre As String, ByVal pmasa As Double, ByVal ptempMedia As Double, ByVal pduracionDia As Double,
                                    ByVal pdistanciaSol As Double, ByVal pduracionAno As Double)

        Dim multiPlaneta As New multiPlaneta()

        Dim planeta As New Planeta(pnombre, pmasa, ptempMedia, pduracionDia, pdistanciaSol, pduracionAno)

        multiPlaneta.agregarPlaneta(planeta)

    End Sub

    Public Sub registrarSatelite(ByVal pnombre As String, ByVal pmasa As Double, ByVal ptempMedia As Double, ByVal pduracionDia As Double,
                                   ByVal pdistancia As Double, ByVal pcaracteristicas As String)

        Dim multiSatelite As New multiSatelite()

        Dim satelite As New Satelite(pnombre, pmasa, ptempMedia, pduracionDia, pdistancia, pcaracteristicas)

        multiSatelite.agregarSatelite(satelite)

    End Sub

    Public Function consultarPlaneta()


        Dim multiPlaneta As New multiPlaneta()
        Dim listaPlanetas As New ArrayList()

        listaPlanetas = multiPlaneta.consultarPlaneta()


        Return listaPlanetas

    End Function

    Public Function consultarSatelite()


        Dim multiSatelite As New multiSatelite()
        Dim listaSatelites As New ArrayList()

        listaSatelites = multiSatelite.consultarSatelite()

        Return listaSatelites

    End Function

    Public Sub registrarPrograma(ByVal pnombre As String, ByVal pfechaInicio As Date, ByVal pfechaFinalizacion As Date, ByVal palcance As String)

        Dim multiPrograma As New MultiPrograma()

        Dim programa As New ProgramaEspacial(pnombre, pfechaInicio, pfechaFinalizacion, palcance)

        multiPrograma.agregarPrograma(programa)

    End Sub

    Public Function consultarPrograma()


        Dim multiPrograma As New MultiPrograma()
        Dim listaProgramas As New ArrayList()

        listaProgramas = multiPrograma.consultarPrograma()

        Return listaProgramas

    End Function


    Public Sub registrarMision(ByVal pnombre As String, ByVal ptripulantes As String, ByVal pfecha As Date, ByVal pduracion As String,
                 ByVal pdatos As String, ByVal presul As String, ByVal pnombreNave As String)

        Dim multiMision As New multiMision()

        Dim mision As New Mision(pnombre, ptripulantes, pfecha, pduracion, pdatos, presul, pnombreNave)

        multiMision.agregarMision(mision)

    End Sub

    Public Function consultarMision()


        Dim multiMision As New multiMision()
        Dim listaMisiones As New ArrayList()

        listaMisiones = multiMision.consultarMisiones()

        Return listaMisiones

    End Function

    Public Sub asignarSatelite(ByVal nombreSatelite As String, ByVal idPlaneta As Integer)






    End Sub

End Class
