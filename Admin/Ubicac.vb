Imports Microsoft.VisualBasic
Imports Oracle.DataAccess.Client

Public Class Ubicac
    Sub limpiarCampos(ByVal control As Form)
        Dim txt As Object
        Dim txtTemporal As TextBox
        Dim cmbTemporal As ComboBox

        For Each txt In control.Controls
            If TypeOf txt Is TextBox Then
                txtTemporal = CType(txt, TextBox)
                txtTemporal.Clear()
            ElseIf TypeOf txt Is ComboBox Then
                cmbTemporal = CType(txt, ComboBox)
                cmbTemporal.SelectedItem = 0
            End If
        Next
    End Sub

    Sub LimpiarCamposG(ByVal gb As GroupBox)
        Dim txt As Object
        Dim txtTemporal As TextBox
        Dim cmbTemporal As ComboBox

        For Each txt In gb.Controls
            If TypeOf txt Is TextBox Then
                txtTemporal = CType(txt, TextBox)
                txtTemporal.Clear()
            ElseIf TypeOf txt Is ComboBox Then
                cmbTemporal = CType(txt, ComboBox)
                cmbTemporal.SelectedItem = 0

            End If
        Next
    End Sub




    'Variables de instancia de la Clase
    Public Class Ubicac
        Private idPais As String
        Private nombre As String


        Public Sub New()
            idPais = ""
            nombre = ""
        End Sub


        Public Sub New(ByVal idCarr As String, ByVal nuevoNombre As String)
            'Aquí recibimos los datos
            idPais = idCarr
            nombre = nuevoNombre
        End Sub

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

        Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
            Me.Close()
        End Sub
    End Class

End Class
