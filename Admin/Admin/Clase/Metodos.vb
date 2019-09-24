Public Class Metodos
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

    Public Sub realizarQuery(ByVal consulta As String)
        Dim xCnx As New Oracle

        xCnx.objetoCommand(consulta)
        cnx.Close()
    End Sub
    Public Sub precioPaq(ByVal peso As Double)

        preciop = 10 * peso

    End Sub
    Public Sub realizarConsulta(ByVal consulta As String)
        Dim xCnx As New Oracle

        xCnx.objetoScalar(consulta)
        cnx.Close()
    End Sub

End Class
