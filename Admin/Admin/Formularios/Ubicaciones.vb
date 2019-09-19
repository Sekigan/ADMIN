Imports Oracle.DataAccess.Client



'Variables de instancia de la Clase
Public Class Ubicaciones


    Dim met As New Metodos

    Private Sub Ubicaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdPais.Text=contarPaises()
        txtID_E.Text = contarEstad()
        txtID_C.Text = contarCiudades()
        txtID_CO.Text = contarco()

        'Paises
        muestra(dgvPaises, "SELECT * FROM PAISES")

        'Estados
        muestra(dgvEdo, "select	 ESTADOS.ID_ESTADO as ID_ESTADO,
	 ESTADOS.NOMBRE as NOMBRE,
	 PAISES.NOMBRE as NOMBRE_PAIS 
     from PAISES PAISES,
	 ESTADOS ESTADOS where paises.id_pais=estados.id_pais ")
        poblarComboBox(CBoxPaisesE, "SELECT * FROM PAISES ", "ID_PAIS", "NOMBRE")

        'Ciudades
        muestra(dgvCi, "select ciudades.id_ciudad as id_ciudad, ciudades.nombre As nombre, estados.nombre As nombre_estado, paises.nombre as nombre_pais
      From paises, estados, ciudades
      Where ciudades.id_pais = estados.id_pais And
      ciudades.id_pais = paises.id_pais And
      ciudades.id_estado = estados.id_estado")
        poblarComboBox(CBoxPaisCiudades, "Select * From PAISES", "ID_PAIS", "NOMBRE")
        poblarComboBox(CBoxEstadosCiudades, "Select * From ESTADOS Where ID_PAIS = " & CBoxPaisCiudades.SelectedValue, "ID_ESTADO", "NOMBRE")
        'Colonias
        muestra(dgvCol, "Select colonias.id_colonia As id_colonia, colonias.nombre As nombre, ciudades.nombre As ciudad, estados.nombre As estado, paises.nombre as pais
         From estados, paises, colonias, ciudades
        where colonias.id_pais = ciudades.id_pais and
        colonias.id_pais = estados.id_pais and
        colonias.id_pais = paises.id_pais and
        colonias.id_estado = ciudades.id_estado and
        colonias.id_estado = estados.id_estado and
        colonias.id_ciudad = ciudades.id_ciudad")
        poblarComboBox(CBoxPaisesCol, "Select * From PAISES", "ID_PAIS", "NOMBRE")
        poblarComboBox(CBoxEstadosCol, "Select * From ESTADOS Where ID_PAIS = " & CBoxPaisesCol.SelectedValue, "ID_ESTADO", "NOMBRE")
        poblarComboBox(CBoxCiudadesCol, "Select * From CIUDADES Where ID_PAIS = " & CBoxPaisesCol.SelectedValue & " And ID_ESTADO = " & CBoxEstadosCol.SelectedValue, "ID_CIUDAD", "NOMBRE")

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    'Insert pais
    Private Sub btnAP_Click(sender As Object, e As EventArgs) Handles btnAP.Click
        Dim cadena As String

        txtIdPais.Text = txtIdPais.Text.Trim
        txtPais.Text = txtPais.Text.Trim


        cadena = "INSERT INTO PAISES VALUES(" & txtIdPais.Text & ",'" & txtPais.Text & "')"
        Try
            met.realizarQuery(cadena)
            MsgBox("Pais Agregado")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvPaises, "SELECT * FROM PAISES")
        met.LimpiarCamposG(gbPaises)
        poblarComboBox(CBoxPaisesE, "SELECT * FROM PAISES ", "ID_PAIS", "NOMBRE")
        poblarComboBox(CBoxPaisCiudades, "Select * From PAISES", "ID_PAIS", "NOMBRE")
        poblarComboBox(CBoxPaisesCol, "Select * From PAISES", "ID_PAIS", "NOMBRE")
        txtIdPais.Text = contarPaises()

    End Sub
    'Mostrar Pais
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        muestra(dgvPaises, "SELECT * FROM PAISES")
        poblarComboBox(CBoxPaisesE, "SELECT * FROM PAISES ", "ID_PAIS", "NOMBRE")
        poblarComboBox(CBoxPaisCiudades, "Select * From PAISES", "ID_PAIS", "NOMBRE")
        poblarComboBox(CBoxPaisesCol, "Select * From PAISES", "ID_PAIS", "NOMBRE")
        txtIdPais.Text = contarPaises()

    End Sub
    'Update Pais
    Private Sub btnEP_Click(sender As Object, e As EventArgs) Handles btnEP.Click
        Dim cadena As String

        txtIdPais.Text = txtIdPais.Text.Trim
        txtPais.Text = txtPais.Text.Trim


        cadena = "update paises set id_pais =" & txtIdPais.Text & ",nombre = '" & txtPais.Text & "' where id_pais = " & txtIdPais.Text & " "
        Try
            met.realizarQuery(cadena)
            MsgBox("Pais Actualizado")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvPaises, "SELECT * FROM PAISES")
        met.LimpiarCamposG(gbPaises)
        poblarComboBox(CBoxPaisesE, "SELECT * FROM PAISES ", "ID_PAIS", "NOMBRE")
        poblarComboBox(CBoxPaisCiudades, "Select * From PAISES", "ID_PAIS", "NOMBRE")
        poblarComboBox(CBoxPaisesCol, "Select * From PAISES", "ID_PAIS", "NOMBRE")
        txtIdPais.Text = contarPaises()

    End Sub
    'Borrar pais
    Private Sub btnElP_Click(sender As Object, e As EventArgs) Handles btnElP.Click
        Dim cadena As String

        cadena = "delete from paises where id_pais =" & txtIdPais.Text & "and nombre = '" & txtPais.Text & "'"
        Try
            met.realizarQuery(cadena)
            MsgBox("Pais borrado")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvPaises, "Select * FROM PAISES")
        met.LimpiarCamposG(gbPaises)
        poblarComboBox(CBoxPaisesE, "SELECT * FROM PAISES ", "ID_PAIS", "NOMBRE")
        poblarComboBox(CBoxPaisCiudades, "Select * From PAISES", "ID_PAIS", "NOMBRE")
        poblarComboBox(CBoxPaisesCol, "Select * From PAISES", "ID_PAIS", "NOMBRE")
        txtIdPais.Text = contarPaises()

    End Sub
    'Seleccionar pais desde el dgv
    Private Sub dgvPaises_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaises.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvPaises.Rows(e.RowIndex)

            txtIdPais.Text = row.Cells("ID_PAIS").Value.ToString
            txtPais.Text = row.Cells("NOMBRE").Value.ToString
        End If
    End Sub
    'Seleccionar estado desde el dgv
    Private Sub dgvEdo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEdo.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvEdo.Rows(e.RowIndex)

            txtID_E.Text = row.Cells("ID_ESTADO").Value.ToString
            txtNombreE.Text = row.Cells("NOMBRE").Value.ToString

            CBoxPaisesE.Text = row.Cells("NOMBRE_PAIS").Value.ToString

        End If
    End Sub
    'Ver estados
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        muestra(dgvEdo, "Select	 ESTADOS.ID_ESTADO As ID_ESTADO,
	 ESTADOS.NOMBRE as NOMBRE,
	 PAISES.NOMBRE as NOMBRE_PAIS 
    from	 PAISES PAISES,
	 ESTADOS ESTADOS where paises.id_pais=estados.id_pais ")
        poblarComboBox(CBoxEstadosCiudades, "Select * From ESTADOS Where ID_PAIS = " & CBoxPaisCiudades.SelectedValue, "ID_ESTADO", "NOMBRE")
        poblarComboBox(CBoxEstadosCol, "Select * From ESTADOS Where ID_PAIS = " & CBoxPaisesCol.SelectedValue, "ID_ESTADO", "NOMBRE")

        txtID_E.Text = contarEstad()


    End Sub
    'Insert Estado
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cadena As String


        cadena = "INSERT INTO ESTADOS VALUES(" & txtID_E.Text & "," & CBoxPaisesE.SelectedValue & ",'" & txtNombreE.Text & "')"
        Try
            met.realizarQuery(cadena)
            MsgBox("Estado Agregado")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvEdo, "select	 ESTADOS.ID_ESTADO as ID_ESTADO,
	 ESTADOS.NOMBRE as NOMBRE,
	 PAISES.NOMBRE as NOMBRE_PAIS 
    from	 PAISES PAISES,
	 ESTADOS ESTADOS where paises.id_pais=estados.id_pais")
        met.LimpiarCamposG(gbEdo)
        poblarComboBox(CBoxEstadosCiudades, "Select * From ESTADOS Where ID_PAIS = " & CBoxPaisCiudades.SelectedValue, "ID_ESTADO", "NOMBRE")
        poblarComboBox(CBoxEstadosCol, "Select * From ESTADOS Where ID_PAIS = " & CBoxPaisesCol.SelectedValue, "ID_ESTADO", "NOMBRE")

        txtID_E.Text = contarEstad()

    End Sub
    'Update Estado
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cadena As String

        cadena = "update estados set id_estado =" & txtID_E.Text & ", nombre = '" & txtNombreE.Text & "', id_pais= " & CBoxPaisesE.SelectedValue & " where id_estado = " & txtID_E.Text & " "
        Try
            met.realizarQuery(cadena)
            MsgBox("Estado Actualizado")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvEdo, "select	 ESTADOS.ID_ESTADO as ID_ESTADO,
	 ESTADOS.NOMBRE as NOMBRE,
	 PAISES.NOMBRE as NOMBRE_PAIS 
    from	 PAISES PAISES,
	 ESTADOS ESTADOS where paises.id_pais=estados.id_pais")
        met.LimpiarCamposG(gbEdo)
        poblarComboBox(CBoxEstadosCiudades, "Select * From ESTADOS Where ID_PAIS = " & CBoxPaisCiudades.SelectedValue, "ID_ESTADO", "NOMBRE")
        poblarComboBox(CBoxEstadosCol, "Select * From ESTADOS Where ID_PAIS = " & CBoxPaisesCol.SelectedValue, "ID_ESTADO", "NOMBRE")

        txtID_E.Text = contarEstad()

    End Sub
    'Borrar estado
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cadena As String

        cadena = "delete from estados where id_estado =" & txtID_E.Text & "and nombre = '" & txtNombreE.Text & "'and id_pais= " & CBoxPaisesE.SelectedValue
        Try
            met.realizarQuery(cadena)
            MsgBox("Estado borrado")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvEdo, "select	 ESTADOS.ID_ESTADO as ID_ESTADO,
	 ESTADOS.NOMBRE as NOMBRE,
	 PAISES.NOMBRE as NOMBRE_PAIS 
    from	 PAISES PAISES,
	 ESTADOS ESTADOS where paises.id_pais=estados.id_pais")
        met.LimpiarCamposG(gbEdo)
        poblarComboBox(CBoxEstadosCiudades, "Select * From ESTADOS Where ID_PAIS = " & CBoxPaisCiudades.SelectedValue, "ID_ESTADO", "NOMBRE")
        poblarComboBox(CBoxEstadosCol, "Select * From ESTADOS Where ID_PAIS = " & CBoxPaisesCol.SelectedValue, "ID_ESTADO", "NOMBRE")

        txtID_E.Text = contarEstad()

    End Sub
    'Seleccionar ciudad desde el dgv
    Private Sub dgvCi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCi.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvCi.Rows(e.RowIndex)

            txtID_C.Text = row.Cells("ID_CIUDAD").Value.ToString
            txtNombreC.Text = row.Cells("NOMBRE").Value.ToString
            CBoxEstadosCiudades.Text = row.Cells("NOMBRE_ESTADO").Value.ToString
            CBoxPaisCiudades.Text = row.Cells("NOMBRE_PAIS").Value.ToString


        End If
    End Sub
    'Ver Ciudades
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        muestra(dgvCi, "select ciudades.id_ciudad as id_ciudad, ciudades.nombre As nombre, estados.nombre As nombre_estado, paises.nombre as nombre_pais
From paises, estados, ciudades
Where ciudades.id_pais = estados.id_pais And
      ciudades.id_pais = paises.id_pais And
      ciudades.id_estado = estados.id_estado")
        met.LimpiarCamposG(gbCiu)
        txtID_C.Text = contarCiudades()
        poblarComboBox(CBoxCiudadesCol, "Select * From CIUDADES Where ID_PAIS = " & CBoxPaisesCol.SelectedValue & " And ID_ESTADO = " & CBoxEstadosCol.SelectedValue, "ID_CIUDAD", "NOMBRE")
    End Sub
    'Insert Ciudad
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim cadena As String
        cadena = "INSERT INTO CIUDADES VALUES(" & txtID_C.Text & "," & CBoxPaisCiudades.SelectedValue & "," & CBoxEstadosCiudades.SelectedValue & ",'" & txtNombreC.Text & "')"
        Try
            met.realizarQuery(cadena)
            MsgBox("Ciudad Agregada")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvCi, "select ciudades.id_ciudad as id_ciudad, ciudades.nombre As nombre, estados.nombre As nombre_estado, paises.nombre as nombre_pais
From paises, estados, ciudades
Where ciudades.id_pais = estados.id_pais And
      ciudades.id_pais = paises.id_pais And
      ciudades.id_estado = estados.id_estado")
        met.LimpiarCamposG(gbCiu)
        poblarComboBox(CBoxCiudadesCol, "Select * From CIUDADES Where ID_PAIS = " & CBoxPaisesCol.SelectedValue & " And ID_ESTADO = " & CBoxEstadosCol.SelectedValue, "ID_CIUDAD", "NOMBRE")
        txtID_C.Text = contarCiudades()

    End Sub
    'Update Ciudad
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim cadena As String

        cadena = "update ciudades set id_ciudad ='" & txtID_C.Text & "', nombre = '" & txtNombreC.Text & "', id_pais='" & Val(CBoxPaisCiudades.SelectedValue.ToString) & "', id_estado='" & Val(CBoxEstadosCiudades.SelectedValue.ToString) & "' where id_ciudad = '" & txtID_C.Text & "' "
        Try
            met.realizarQuery(cadena)
            MsgBox("Ciudad Actualizado")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvCi, "select ciudades.id_ciudad as id_ciudad, ciudades.nombre As nombre, estados.nombre As nombre_estado, paises.nombre as nombre_pais
From paises, estados, ciudades
Where ciudades.id_pais = estados.id_pais And
      ciudades.id_pais = paises.id_pais And
      ciudades.id_estado = estados.id_estado")
        met.LimpiarCamposG(gbCiu)
        poblarComboBox(CBoxCiudadesCol, "Select * From CIUDADES Where ID_PAIS = " & CBoxPaisesCol.SelectedValue & " And ID_ESTADO = " & CBoxEstadosCol.SelectedValue, "ID_CIUDAD", "NOMBRE")

        txtID_C.Text = contarCiudades()
    End Sub
    'Borrar Ciudad
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim cadena As String

        cadena = "delete from ciudades where id_ciudad =" & txtID_C.Text & "and nombre = '" & txtNombreC.Text & "'and id_pais=" & Val(CBoxPaisCiudades.SelectedValue.ToString) & "and id_estado=" & Val(CBoxEstadosCiudades.SelectedValue.ToString)
        Try
            met.realizarQuery(cadena)
            MsgBox("Ciudad borrado")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvCi, "select ciudades.id_ciudad as id_ciudad, ciudades.nombre As nombre, estados.nombre As nombre_estado, paises.nombre as nombre_pais
From paises, estados, ciudades
Where ciudades.id_pais = estados.id_pais And
      ciudades.id_pais = paises.id_pais And
      ciudades.id_estado = estados.id_estado")
        met.LimpiarCamposG(gbCiu)

        poblarComboBox(CBoxCiudadesCol, "Select * From CIUDADES Where ID_PAIS = " & CBoxPaisesCol.SelectedValue & " And ID_ESTADO = " & CBoxEstadosCol.SelectedValue, "ID_CIUDAD", "NOMBRE")
        txtID_C.Text = contarCiudades()

    End Sub
    'Ver Colonias
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        muestra(dgvCol, "select colonias.id_colonia as id_colonia, colonias.nombre as nombre, ciudades.nombre as ciudad, estados.nombre as estado, paises.nombre as pais
from estados, paises, colonias, ciudades
where colonias.id_pais = ciudades.id_pais and
      colonias.id_pais = estados.id_pais and
      colonias.id_pais = paises.id_pais and
      colonias.id_estado = ciudades.id_estado and
      colonias.id_estado = estados.id_estado and
      colonias.id_ciudad = ciudades.id_ciudad")

        txtID_CO.Text = contarco()
    End Sub
    'Seleccionar colonia desde dgv
    Private Sub dgvCol_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCol.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvCol.Rows(e.RowIndex)

            txtID_CO.Text = row.Cells("id_colonia").Value.ToString
            txtnombreCO.Text = row.Cells("nombre").Value.ToString
            CBoxCiudadesCol.Text = row.Cells("ciudad").Value.ToString
            CBoxEstadosCol.Text = row.Cells("estado").Value.ToString
            CBoxPaisesCol.Text = row.Cells("pais").Value.ToString

        End If
    End Sub
    'Insert COlonia
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cadena As String
        cadena = "INSERT INTO COLONIAS VALUES(" & txtID_CO.Text & "," & CBoxPaisesCol.SelectedValue & "," & CBoxEstadosCol.SelectedValue & "," & CBoxCiudadesCol.SelectedValue & ",'" & txtnombreCO.Text & "')"
        Try
            met.realizarQuery(cadena)
            MsgBox("Colonia Agregada")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvCol, "select colonias.id_colonia as id_colonia, colonias.nombre as nombre, ciudades.nombre as ciudad, estados.nombre as estado, paises.nombre as pais
from estados, paises, colonias, ciudades
where colonias.id_pais = ciudades.id_pais and
      colonias.id_pais = estados.id_pais and
      colonias.id_pais = paises.id_pais and
      colonias.id_estado = ciudades.id_estado and
      colonias.id_estado = estados.id_estado and
      colonias.id_ciudad = ciudades.id_ciudad")
        met.LimpiarCamposG(gbCol)

        txtID_CO.Text = contarco()
    End Sub
    'Update Colonia
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cadena As String

        cadena = "update colonias set id_colonia =" & txtID_CO.Text & ", colonias.nombre = '" & txtnombreCO.Text & ", id_pais=" & Val(CBoxPaisesCol.SelectedValue.ToString) & ", id_estado=" & Val(CBoxEstadosCol.SelectedValue.ToString) & ", id_ciudad=" & Val(CBoxCiudadesCol.SelectedValue.ToString) & "' where id_colonia = '" & txtID_CO.Text & "' "
        Try
            met.realizarQuery(cadena)
            MsgBox("Colonia Actualizado")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvCol, "select colonias.id_colonia as id_colonia, colonias.nombre as nombre, ciudades.nombre as ciudad, estados.nombre as estado, paises.nombre as pais
from estados, paises, colonias, ciudades
where colonias.id_pais = ciudades.id_pais and
      colonias.id_pais = estados.id_pais and
      colonias.id_pais = paises.id_pais and
      colonias.id_estado = ciudades.id_estado and
      colonias.id_estado = estados.id_estado and
      colonias.id_ciudad = ciudades.id_ciudad")
        met.LimpiarCamposG(gbCol)

        txtID_CO.Text = contarco()
    End Sub
    'Borrar colonia
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim cadena As String

        cadena = "delete from colonias where id_colonia =" & txtID_CO.Text & "and nombre = '" & txtnombreCO.Text & "' and id_pais=" & Val(CBoxPaisesCol.SelectedValue.ToString) & " and id_estado=" & Val(CBoxEstadosCol.SelectedValue.ToString) & "and id_ciudad=" & Val(CBoxCiudadesCol.SelectedValue.ToString)
        Try
            met.realizarQuery(cadena)
            MsgBox("Colonia borrado")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
        End Try
        muestra(dgvCol, "select colonias.id_colonia as id_colonia, colonias.nombre as nombre, ciudades.nombre as ciudad, estados.nombre as estado, paises.nombre as pais
from estados, paises, colonias, ciudades
where colonias.id_pais = ciudades.id_pais and
      colonias.id_pais = estados.id_pais and
      colonias.id_pais = paises.id_pais and
      colonias.id_estado = ciudades.id_estado and
      colonias.id_estado = estados.id_estado and
      colonias.id_ciudad = ciudades.id_ciudad")
        met.LimpiarCamposG(gbCol)

        txtID_CO.Text = contarco()
    End Sub

    Private Sub CBoxPaisCiudades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxPaisCiudades.SelectionChangeCommitted

        poblarComboBox(CBoxEstadosCiudades, "SELECT * FROM ESTADOS WHERE ID_PAIS=" & CBoxPaisCiudades.SelectedValue, "ID_ESTADO", "NOMBRE")

    End Sub

    Private Sub CBoxPaisesCol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxPaisesCol.SelectionChangeCommitted
        CBoxEstadosCol.Text = ""
        CBoxCiudadesCol.Text = ""

        poblarComboBox(CBoxEstadosCol, "SELECT * FROM ESTADOS WHERE ID_PAIS=" & CBoxPaisesCol.SelectedValue, "ID_ESTADO", "NOMBRE")

        If Not IsNothing(CBoxEstadosCol.SelectedValue) Then

            poblarComboBox(CBoxCiudadesCol, "SELECT * FROM CIUDADES WHERE ID_PAIS=" & CBoxPaisesCol.SelectedValue & " AND ID_ESTADO=" & CBoxEstadosCol.SelectedValue, "ID_CIUDAD", "NOMBRE")

        Else


            CBoxCiudadesCol.DataSource = {}
        End If
    End Sub
    Private Sub CBoxEstadosCol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxEstadosCol.SelectionChangeCommitted
        CBoxCiudadesCol.Text = ""
        CBoxCiudadesCol.Text = ""
        poblarComboBox(CBoxCiudadesCol, "SELECT * FROM CIUDADES WHERE ID_PAIS=" & CBoxPaisesCol.SelectedValue & " AND ID_ESTADO=" & CBoxEstadosCol.SelectedValue, "ID_CIUDAD", "NOMBRE")

    End Sub
    Private Sub SoloNumerosSinPuntos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID_CO.KeyPress, txtID_C.KeyPress, txtID_E.KeyPress, txtIdPais.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Public Function contarPaises() As Double
        Dim xCnx As New Oracle
        Dim nm As String = "SELECT COUNT(*) FROM paises"

        Dim c As Integer = xCnx.objetoScalar(nm)

        Return c + 1

    End Function
    Public Function contarEstad() As Double
        Dim xCnx As New Oracle
        Dim nm As String = "SELECT COUNT(*) FROM estados"

        Dim c As Integer = xCnx.objetoScalar(nm)

        Return c + 1

    End Function
    Public Function contarCiudades() As Double
        Dim xCnx As New Oracle
        Dim nm As String = "SELECT COUNT(*) FROM ciudades"

        Dim c As Integer = xCnx.objetoScalar(nm)

        Return c + 1

    End Function
    Public Function contarco() As Double
        Dim xCnx As New Oracle
        Dim nm As String = "SELECT COUNT(*) FROM colonias"

        Dim c As Integer = xCnx.objetoScalar(nm)

        Return c + 1

    End Function

End Class


