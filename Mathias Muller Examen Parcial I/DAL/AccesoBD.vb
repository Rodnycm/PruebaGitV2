Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager

Public Class AccesoBD

    'atributos del objeto
    Private mcadena As String = "Data Source=MATHIAS-PC;Initial Catalog=DBExamenI;Integrated Security=True"

    'cadena de caracteres que contiene
    'el string de conexión
    Public ReadOnly Property Cadena() As String
        Get
            If mcadena = "" Then
                mcadena = ConnectionStrings("conexion").ConnectionString
            End If
            Return mcadena
        End Get
    End Property

    'método que abre una conexión con la 
    'configuración dada
    Public Function GetConexion() As IDbConnection
        Return New SqlConnection(Cadena)
    End Function

    'Métodos que ejecutan sentencias
    'en la BD
    'método que no devuelve resultados
    Public Sub EjecutarSQL(ByVal pSQL As String, ByVal ParamArray parametros() As Parametro)
        Dim cmd As SqlCommand
        Dim objPar As Parametro
        Dim nombre As String
        'se crea el comando
        cmd = New SqlCommand
        cmd.Connection = GetConexion()
        'se sacan los parámetros
        For i As Integer = 0 To parametros.Length - 1
            objPar = parametros(i)
            nombre = "@" & objPar.Nombre()
            cmd.Parameters.AddWithValue(nombre, objPar.Dato)
            pSQL = pSQL & " " & nombre

            If (i + 1) < parametros.Length Then
                pSQL = pSQL & ","
            End If
        Next

        cmd.CommandText = pSQL
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
    End Sub

    'método que devuelve resultados
    'en un datareader
    Public Function EjecutarSQL(ByVal pSQL As String, ByVal pconexion As IDbConnection, ByVal ParamArray parametros() As Parametro) As IDataReader
        Dim cmd As SqlCommand
        Dim objPar As Parametro
        Dim nombre As String
        'se crea el comando
        cmd = New SqlCommand
        cmd.Connection = pconexion
        'se sacan los parámetros
        For Each objPar In parametros
            nombre = String.Format("@{0}", objPar.Nombre)
            cmd.Parameters.AddWithValue(nombre, objPar.Dato)
            pSQL = pSQL.Replace(objPar.Nombre, nombre)
        Next
        cmd.CommandText = pSQL

        'si la conexión no está abierta, se abre
        If cmd.Connection.State = ConnectionState.Closed Then
            cmd.Connection.Open()
        End If


        Return cmd.ExecuteReader
    End Function

    'método que devuelve resultados en un
    'dataset
    Public Function EjecutarSQL(ByVal pSQL As String, ByVal pTabla As String) As DataSet
        Dim adp As SqlDataAdapter
        Dim datasetL As New DataSet()
        adp = New SqlDataAdapter(pSQL, CType(GetConexion(), SqlConnection))
        adp.Fill(datasetL, pTabla)
        Return datasetL
    End Function


    Public Function selectInfoEstrellas(ByVal pSQL As String) As SqlDataReader
        Dim respuesta As SqlDataReader
        Dim comando As SqlCommand
        comando = New SqlCommand()
        comando.Connection = GetConexion()
        comando.CommandText = pSQL
        comando.Connection.Open()
        respuesta = comando.ExecuteReader

        Return respuesta

    End Function

End Class
