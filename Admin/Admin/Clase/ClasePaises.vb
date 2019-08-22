Public Class ClasePaises
    Private id_pais As Integer
    Private nombre As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal nom As String)
        nombre = nom
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim tabla As DataTable
        strSQL = "SELECT ID_PAIS FROM  PAISES WHERE NOMBRE='" & nom & "'"

        tabla = xCnx.objetoDataAdapter(strSQL)
        If Not IsDBNull(tabla.Rows(0)("ID_PAIS")) Then
            id_pais = tabla.Rows(0)("ID_PAIS")
        Else
            id_pais = -1
        End If


    End Sub
    Public Sub New(ByVal id_p As Integer, ByVal nom As String)
        id_pais = id_p
        nombre = nom
    End Sub
    Public Property getSetNombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property
    Public Property getSetId As Integer
        Get
            Return id_pais
        End Get
        Set(value As Integer)
            id_pais = value
        End Set

    End Property

    Public Sub buscarMayor()
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim tabla As DataTable
        Dim i As Integer

        strSQL = "SELECT ID_PAIS FROM PAISES"
        tabla = xCnx.objetoDataAdapter(strSQL)

        For i = 0 To tabla.Rows.Count - 1
            If Not tabla.Rows(i)("ID_PAIS") = (i + 1) Then
                Exit For
            End If
        Next

        id_pais = (i + 1)

    End Sub
    Public Sub realizarINSERT()
        Dim xCnx As New Oracle
        Dim strSQL As String
        buscarMayor()
        strSQL = "INSERT INTO PAISES VALUES(" & id_pais & ",'" & nombre & "')"
        xCnx.objetoDataAdapter(strSQL)
        cnx.Close()
    End Sub
    Public Sub realizarQuery(ByVal consulta As String)

        Dim xCnx As New Oracle
        xCnx.objetoDataAdapter(consulta)
        cnx.Close()


    End Sub
    Public Function buscarEstados() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle

        strSQL = "SELECT ID_ESTADO FROM ESTADOS WHERE ID_PAIS=" & id_pais

        buscarEstados = xCnx.objetoDataAdapter(strSQL).Rows.Count >= 1

    End Function
    Public Function listarPaises() As AutoCompleteStringCollection
        Dim lista As New AutoCompleteStringCollection
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        Dim i As Integer

        strSQL = "SELECT * FROM  PAISES "
        xDT = xCnx.objetoDataAdapter(strSQL)
        For i = 0 To xDT.Rows.Count - 1
            lista.Add(xDT.Rows(i)("NOMBRE"))
        Next


        listarPaises = lista
    End Function
End Class
