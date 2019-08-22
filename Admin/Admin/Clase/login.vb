Public Class ClaseLogin
    Private idEmpleado As String
    Private contraseña As String

    Public Sub New()
        idEmpleado = ""
        contraseña = ""
    End Sub
    Public Sub New(ByVal idE As String, ByVal cont As String)
        idEmpleado = idE
        contraseña = cont
    End Sub
    Public Function login() As Boolean
        Dim strSQL As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable

        strSQL = "SELECT * FROM  LOGIN " &
                 "WHERE id_empleado=" & idEmpleado & "and contrasena = '" & contraseña & "' "
        login = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            login = True
            strSQL = "SELECT NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  EMPLEADOS " &
                 "WHERE ID_EMPLEADO =" & idEmpleado
            xDT = xCnx.objetoDataAdapter(strSQL)
            LOGINNOMBRE = CStr(xDT.Rows(0)("nombre"))
            LOGINCLAVE = idEmpleado



        End If
    End Function


End Class
