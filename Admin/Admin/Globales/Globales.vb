Imports Oracle.DataAccess.Client
Module Globales
    Public LOGINNOMBRE As String
    Public LOGINCLAVE As String

    Public ClienteN As String
    Public ClienteT As String
    Public preciop As Integer

    Public El_Nombre As String
    Public pila As Stack(Of Form) = New Stack(Of Form)

    Public id_PaisAgregar As Integer
    Public id_EstadoAgregar As Integer
    Public id_CiudadAgregar As Integer
    Public id_ColoniaAgregar As Integer
    Public forma_pago As String
    Public total As Double







    Public cnx As OracleConnection


    Public Function listar(ByVal consulta As String) As AutoCompleteStringCollection
        Dim lista As New AutoCompleteStringCollection

        Dim xCnx As New Oracle
        Dim xDT As DataTable
        Dim i As Integer


        xDT = xCnx.objetoDataAdapter(consulta)
        For i = 0 To xDT.Rows.Count - 1
            lista.Add(xDT.Rows(i)("NOMBRE"))
        Next


        listar = lista
    End Function
    Public Function buscarCampoConsulta(ByVal consulta As String, ByVal campo As String) As String
        Dim xCnx As New Oracle


        Try
            buscarCampoConsulta = xCnx.objetoDataAdapter(consulta).Rows(0)(campo)
        Catch ex As InvalidCastException
            buscarCampoConsulta = ""
        End Try
    End Function



    Public Sub poblarComboBox(combo As ComboBox, consulta As String, valor As String, mostrar As String)

        Dim xCnx As New Oracle

        combo.DataSource = xCnx.objetoDataAdapter(consulta)

        combo.DisplayMember = mostrar
        combo.ValueMember = valor

    End Sub
    Public Sub muestra(tabla As DataGridView, consulta As String)

        Using cn As New OracleConnection With {.ConnectionString = "Data Source=XE;User Id=PAQUETES;Password=its1;"}
            Using cmd As New OracleCommand With {.Connection = cn, .CommandText = consulta}
                cn.Open()
                Dim dr As OracleDataReader = cmd.ExecuteReader
                Dim dt As New DataTable
                dt.Load(dr)
                tabla.DataSource = dt
            End Using
        End Using

    End Sub


    Private Sub SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsNumber(e.KeyChar)) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub SoloLetras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsNumber(e.KeyChar)) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Ambas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsNumber(e.KeyChar)) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
    End Sub



End Module
