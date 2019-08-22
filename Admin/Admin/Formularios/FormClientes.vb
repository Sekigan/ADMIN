Public Class FormClientes

    Dim met As New Metodos
    Private Sub FormCientes_Loader(sender As Object, e As EventArgs) Handles MyBase.Load
        muestra(dgvClientes, "select CLIENTES.ID_CLIENTE as ID_CLIENTE,
	 CLIENTES.NOMBRE as NOMBRE,
	 CLIENTES.PATERNO as PATERNO,
	 CLIENTES.MATERNO as MATERNO,
	 CLIENTES.EDAD as EDAD,
	 CLIENTES.SEXO as SEXO,
	 CLIENTES.TELEFONO as TELEFONO,
	 CLIENTES.CORREO as CORREO,
	 CLIENTES.NUMEROCASA as NUMEROCASA,
     CLIENTES.CALLE AS CALLE,
	 COLONIAS.NOMBRE as COLONIA,
	 CIUDADES.NOMBRE as CIUDAD,
    ESTADOS.NOMBRE as ESTADO,
	 PAISES.NOMBRE as PAIS,
	 CLIENTES.CURP as CURP,
	 CLIENTES.RFC as RFC 
 from	 ESTADOS ESTADOS,
	 COLONIAS COLONIAS,
	 CIUDADES CIUDADES,
	 PAISES PAISES,
	 CLIENTES CLIENTES
where   clientes.id_pais = colonias.id_pais and
	clientes.id_pais = ciudades.id_pais and
        clientes.id_pais = estados.id_pais and
        clientes.id_pais = paises.id_pais and
	clientes.id_estado = colonias.id_estado and
	clientes.id_estado = ciudades.id_estado and
	clientes.id_estado = estados.id_estado and
	clientes.id_ciudad = colonias.id_ciudad and
	clientes.id_ciudad = ciudades.id_ciudad and
	clientes.id_colonia = colonias.id_colonia")

        ComboBoxSex.DataSource = {"Femenino", "Masculino"}

        poblarComboBox(ComboBoxPais, "SELECT * FROM PAISES", "ID_PAIS", "NOMBRE")

        poblarComboBox(ComboBoxEstad, "SELECT * FROM ESTADOS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue, "ID_ESTADO", "NOMBRE")

        poblarComboBox(ComboBoxCiudad, "SELECT * FROM CIUDADES WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue, "ID_CIUDAD", "NOMBRE")

        poblarComboBox(ComboBoxCo, "SELECT * FROM COLONIAS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue & " AND ID_CIUDAD=" & ComboBoxCiudad.SelectedValue, "ID_COLONIA", "NOMBRE")

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        txtIdCliente.Text = txtIdCliente.Text.Trim
        txtNombre.Text = txtNombre.Text.Trim
        txtPaterno.Text = txtPaterno.Text.Trim
        txtMaterno.Text = txtMaterno.Text.Trim
        TxtRFC.Text = TxtRFC.Text.Trim
        TxtCurp.Text = TxtCurp.Text.Trim

        Textemail.Text = Textemail.Text.Trim
        TxtTel.Text = TxtTel.Text.Trim

        TxtCalle.Text = TxtCalle.Text.Trim
        TxtNcasa.Text = TxtNcasa.Text.Trim

        If txtIdCliente.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtIdCliente.Focus()
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtNombre.Focus()
        ElseIf txtPaterno.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtPaterno.Focus()
        ElseIf txtMaterno.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtMaterno.Focus()
        ElseIf TxtRFC.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            TxtRFC.Focus()
        ElseIf TxtCurp.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            TxtCurp.Focus()
        ElseIf Textemail.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            Textemail.Focus()
        ElseIf TxtTel.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            TxtTel.Focus()
        ElseIf TxtNcasa.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            TxtNcasa.Focus()
        ElseIf TxtCalle.Text = "" Then
            MessageBox.Show("Faltan Capturar datos")
            TxtCalle.Focus()
        ElseIf IsNothing(ComboBoxPais.SelectedValue) Then
            MessageBox.Show("Estado No Seleccionado")
            ComboBoxPais.Focus()
        ElseIf IsNothing(ComboBoxCiudad.SelectedValue) Then
            MessageBox.Show("Ciudad No Seleccionada")
            ComboBoxCiudad.Focus()
        ElseIf IsNothing(ComboBoxCo.SelectedValue) Then
            MessageBox.Show("Colonia No Seleccionada")
            ComboBoxCiudad.Focus()
        End If

        Dim Sex As String
        If ComboBoxSex.SelectedIndex = 0 Then
            Sex = "F"
        Else
            Sex = "M"
        End If

        If (Not Existe(Convert.ToInt32(txtIdCliente.Text))) Then

            Dim Insert As String

            Insert = "Insert into clientes values(" & txtIdCliente.Text & "," &
                     ComboBoxPais.SelectedValue & "," &
                    ComboBoxEstad.SelectedValue & "," &
                    ComboBoxCiudad.SelectedValue & "," & ComboBoxCo.SelectedValue & ",'" & txtNombre.Text & "','" &
                        txtPaterno.Text & "','" &
                        txtMaterno.Text & "','" &
                        TxtEdad.Text & "','" &
                        TxtRFC.Text & "','" &
                        TxtCurp.Text & "','" &
            Sex & "','" &
            Textemail.Text & "'," &
            TxtTel.Text & "," &
            TxtNcasa.Text & ",'" &
            TxtCalle.Text & "')"
            Try
                met.realizarQuery(Insert)

                MessageBox.Show("CLIENTE INGRESADO")
                met.LimpiarCamposG(gbUsr)
            Catch er As Exception
                MsgBox("Verifica que la informacion sea la correcta", vbInformation)
            End Try
        Else
            MsgBox("EL ID YA EXISTE..")
        End If
        muestra(dgvClientes, "select CLIENTES.ID_CLIENTE as ID_CLIENTE,
	 CLIENTES.NOMBRE as NOMBRE,
	 CLIENTES.PATERNO as PATERNO,
	 CLIENTES.MATERNO as MATERNO,
	 CLIENTES.EDAD as EDAD,
	 CLIENTES.SEXO as SEXO,
	 CLIENTES.TELEFONO as TELEFONO,
	 CLIENTES.CORREO as CORREO,
	 CLIENTES.NUMEROCASA as NUMEROCASA,
     CLIENTES.CALLE AS CALLE,
	 COLONIAS.NOMBRE as COLONIA,
	 CIUDADES.NOMBRE as CIUDAD,
    ESTADOS.NOMBRE as ESTADO,
	 PAISES.NOMBRE as PAIS,
	 CLIENTES.CURP as CURP,
	 CLIENTES.RFC as RFC 
 from	 ESTADOS ESTADOS,
	 COLONIAS COLONIAS,
	 CIUDADES CIUDADES,
	 PAISES PAISES,
	 CLIENTES CLIENTES
where   clientes.id_pais = colonias.id_pais and
	clientes.id_pais = ciudades.id_pais and
        clientes.id_pais = estados.id_pais and
        clientes.id_pais = paises.id_pais and
	clientes.id_estado = colonias.id_estado and
	clientes.id_estado = ciudades.id_estado and
	clientes.id_estado = estados.id_estado and
	clientes.id_ciudad = colonias.id_ciudad and
	clientes.id_ciudad = ciudades.id_ciudad and
	clientes.id_colonia = colonias.id_colonia")




    End Sub





    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim delet As String
        Try
            delet = "delete from clientes where id_cliente = '" & txtIdCliente.Text & "' "
            met.realizarQuery(delet)
            MessageBox.Show("Registro Eliminado")
        Catch ex As Exception
            MsgBox("No se puede eliminar este registro", vbInformation, "Precaución")
        End Try
        met.LimpiarCamposG(gbUsr)

        muestra(dgvClientes, "select CLIENTES.ID_CLIENTE as ID_CLIENTE,
	 CLIENTES.NOMBRE as NOMBRE,
	 CLIENTES.PATERNO as PATERNO,
	 CLIENTES.MATERNO as MATERNO,
	 CLIENTES.EDAD as EDAD,
	 CLIENTES.SEXO as SEXO,
	 CLIENTES.TELEFONO as TELEFONO,
	 CLIENTES.CORREO as CORREO,
	 CLIENTES.NUMEROCASA as NUMEROCASA,
     CLIENTES.CALLE AS CALLE,
	 COLONIAS.NOMBRE as COLONIA,
	 CIUDADES.NOMBRE as CIUDAD,
    ESTADOS.NOMBRE as ESTADO,
	 PAISES.NOMBRE as PAIS,
	 CLIENTES.CURP as CURP,
	 CLIENTES.RFC as RFC 
 from	 ESTADOS ESTADOS,
	 COLONIAS COLONIAS,
	 CIUDADES CIUDADES,
	 PAISES PAISES,
	 CLIENTES CLIENTES
where   clientes.id_pais = colonias.id_pais and
	clientes.id_pais = ciudades.id_pais and
        clientes.id_pais = estados.id_pais and
        clientes.id_pais = paises.id_pais and
	clientes.id_estado = colonias.id_estado and
	clientes.id_estado = ciudades.id_estado and
	clientes.id_estado = estados.id_estado and
	clientes.id_ciudad = colonias.id_ciudad and
	clientes.id_ciudad = ciudades.id_ciudad and
	clientes.id_colonia = colonias.id_colonia")

    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvClientes.Rows(e.RowIndex)

            txtIdCliente.Text = row.Cells("ID_CLIENTE").Value.ToString
            txtNombre.Text = row.Cells("NOMBRE").Value.ToString
            txtPaterno.Text = row.Cells("PATERNO").Value.ToString
            txtMaterno.Text = row.Cells("MATERNO").Value.ToString
            TxtEdad.Text = row.Cells("EDAD").Value.ToString
            ComboBoxSex.Text = row.Cells("SEXO").Value.ToString
            TxtTel.Text = row.Cells("TELEFONO").Value.ToString
            Textemail.Text = row.Cells("CORREO").Value.ToString
            TxtNcasa.Text = row.Cells("NUMEROCASA").Value.ToString
            TxtCalle.Text = row.Cells("CALLE").Value.ToString
            ComboBoxCo.Text = row.Cells("COLONIA").Value.ToString
            ComboBoxCiudad.Text = row.Cells("CIUDAD").Value.ToString
            ComboBoxEstad.Text = row.Cells("ESTADO").Value.ToString
            ComboBoxPais.Text = row.Cells("PAIS").Value.ToString
            TxtCurp.Text = row.Cells("CURP").Value.ToString
            TxtRFC.Text = row.Cells("RFC").Value.ToString



        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        met.LimpiarCamposG(gbUsr)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Insert As String

        Dim Sex As String
        If ComboBoxSex.SelectedIndex = 1 Then
            Sex = "F"
        Else
            Sex = "M"
        End If

        Insert = "update clientes set id_cliente=" & txtIdCliente.Text & ",id_pais = " &
                     ComboBoxPais.SelectedValue & ", id_estado = " &
                    ComboBoxEstad.SelectedValue & ",id_ciudad =" &
                    ComboBoxCiudad.SelectedValue & ",id_colonia =" &
                    ComboBoxCo.SelectedValue & ", nombre =
                    '" & txtNombre.Text & "', paterno ='" &
                        txtPaterno.Text & "',materno ='" &
                        txtMaterno.Text & "',rfc='" &
                        TxtRFC.Text & "',curp ='" &
                        TxtCurp.Text & "','edad=" &
                        TxtEdad.Text & "',sexo'" &
            Sex & "',correo ='" &
            Textemail.Text & "',telefono=" &
            TxtTel.Text & ",numerocasa=" &
            TxtNcasa.Text & ",calle='" &
            TxtCalle.Text & "' where id_clientes " & txtIdCliente.Text & ")"

        met.realizarQuery(Insert)
        MessageBox.Show("CLIENTE ACTUALIZADO")
        met.LimpiarCamposG(gbUsr)

        muestra(dgvClientes, "select CLIENTES.ID_CLIENTE as ID_CLIENTE,
	 CLIENTES.NOMBRE as NOMBRE,
	 CLIENTES.PATERNO as PATERNO,
	 CLIENTES.MATERNO as MATERNO,
	 CLIENTES.EDAD as EDAD,
	 CLIENTES.SEXO as SEXO,
	 CLIENTES.TELEFONO as TELEFONO,
	 CLIENTES.CORREO as CORREO,
	 CLIENTES.NUMEROCASA as NUMEROCASA,
     CLIENTES.CALLE AS CALLE,
	 COLONIAS.NOMBRE as COLONIA,
	 CIUDADES.NOMBRE as CIUDAD,
     ESTADOS.NOMBRE as ESTADO,
	 PAISES.NOMBRE as PAIS,
	 CLIENTES.CURP as CURP,
	 CLIENTES.RFC as RFC 
     from	 ESTADOS ESTADOS,
	 COLONIAS COLONIAS,
	 CIUDADES CIUDADES,
	 PAISES PAISES,
	 CLIENTES CLIENTES
     where   clientes.id_pais = colonias.id_pais and
	 clientes.id_pais = ciudades.id_pais and
     clientes.id_pais = estados.id_pais and
     clientes.id_pais = paises.id_pais and
	clientes.id_estado = colonias.id_estado and
	clientes.id_estado = ciudades.id_estado and
	clientes.id_estado = estados.id_estado and
	clientes.id_ciudad = colonias.id_ciudad and
	clientes.id_ciudad = ciudades.id_ciudad and
	clientes.id_colonia = colonias.id_colonia")
    End Sub
    Private Sub CBoxPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPais.SelectionChangeCommitted

        poblarComboBox(ComboBoxEstad, "SELECT * FROM ESTADOS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue, "ID_ESTADO", "NOMBRE")

        If Not IsNothing(ComboBoxEstad.SelectedValue) Then

            poblarComboBox(ComboBoxCiudad, "SELECT * FROM CIUDADES WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue, "ID_CIUDAD", "NOMBRE")

            If Not IsNothing(ComboBoxCiudad.SelectedValue) Then

                poblarComboBox(ComboBoxCo, "SELECT * FROM COLONIAS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue & "AND ID_CIUDAD=" & ComboBoxCiudad.SelectedValue, "ID_COLONIA", "NOMBRE")
            Else
            End If
        Else
        End If


    End Sub
    Private Sub CBoxEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstad.SelectionChangeCommitted

        poblarComboBox(ComboBoxCiudad, "SELECT * FROM CIUDADES WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue, "ID_CIUDAD", "NOMBRE")

        If Not IsNothing(ComboBoxCiudad.SelectedValue) Then

            poblarComboBox(ComboBoxCo, "SELECT * FROM COLONIAS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue & "AND ID_CIUDAD=" & ComboBoxCiudad.SelectedValue, "ID_COLONIA", "NOMBRE")
        Else


        End If

    End Sub
    Private Sub CBoxCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCiudad.SelectionChangeCommitted


        poblarComboBox(ComboBoxEstad, "SELECT * FROM COLONIAS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue & "AND ID_CIUDAD=" & ComboBoxCiudad.SelectedValue, "ID_COLONIA", "NOMBRE")

    End Sub
    Private Sub SoloNumerosSinPuntos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTel.KeyPress, TxtNcasa.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
    Public Function Existe(ByVal id As Integer) As Boolean

        Dim xCnx As New Oracle

        Dim nm As String = "select	 CLIENTES.ID_CLIENTE as ID_CLIENTE from	 CLIENTES where ID_CLIENTE=" & txtIdCliente.Text



        Dim count As Integer = xCnx.objetoScalar(nm)
        If count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
End Class