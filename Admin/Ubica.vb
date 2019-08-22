Imports Microsoft.VisualBasic

Imports Oracle.DataAccess.Client

Public Class Ubicas

    'Variables de instancia de la Clase
    Private idPais As String
    Private nombre As String

    'Método constructor inicializa variables
    Public Sub New()
        idPais = ""
        nombre = ""
    End Sub


    'Metodo constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal idCarr As String, ByVal nuevoNombre As String)
        'Aquí recibimos los datos
        idPais = idCarr
        nombre = nuevoNombre
    End Sub

    'Metodos get y set
    Public Property getSetidPais() As String
        Get
            Return idPais
        End Get
        Set(ByVal Value As String)
            idPais = Value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property


    'Consulta un país específico
    Public Function consultaUsuario() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM usuarios " &
                 "WHERE login_usuario ='" & idPais & "' and clave_usuario ='" & nombre & "'"
        consultaUsuario = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then

            If IsDBNull(xDT.Rows(0)("nombre")) Then
                nombre = ""
            Else
                nombre = CStr(xDT.Rows(0)("nombre"))
                UsuarioConectado = CStr(xDT.Rows(0)("nombre")) & " " & CStr(xDT.Rows(0)("paterno")) '& " " & CStr(xDT.Rows(0)("materno"))

            End If
            consultaUsuario = True
        End If
    End Function

End Class
