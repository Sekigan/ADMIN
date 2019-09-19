Public Class formCUsuario
    Dim met As New Metodos
    'Cargar Combos y DataGrindView
    Private Sub formCUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtId.Text = contar()

        muestra(dgvUsuarios, "select	 EMPLEADOS.ID_EMPLEADO as ID_EMPLEADO,
         EMPLEADOS.NOMBRE as NOMBRE,
         EMPLEADOS.PATERNO as PATERNO,
         EMPLEADOS.MATERNO as MATERNO,
         EMPLEADOS.SEXO as SEXO,
         EMPLEADOS.TELEFONO as TELEFONO,
         EMPLEADOS.CORREO AS CORREO,
         EMPLEADOS.NUMERO_CASA as NUMERO_CASA,
         EMPLEADOS.CALLE as CALLE,
         COLONIAS.NOMBRE as COLONIA,
         CIUDADES.NOMBRE as CIUDAD,
         ESTADOS.NOMBRE as ESTADO,
         PAISES.NOMBRE as PAIS,
         EMPLEADOS.CORREO as CORREO,
         EMPLEADOS.CURP as CURP,
         EMPLEADOS.RFC as RFC 
        from	 COLONIAS COLONIAS,
         CIUDADES CIUDADES,
         ESTADOS ESTADOS,
         PAISES PAISES,
         EMPLEADOS EMPLEADOS
        where   empleados.id_pais = colonias.id_pais and
	    empleados.id_pais = ciudades.id_pais and
        empleados.id_pais = estados.id_pais and
        empleados.id_pais = paises.id_pais and
	    empleados.id_estado = colonias.id_estado and
	    empleados.id_estado = ciudades.id_estado and
	    empleados.id_estado = estados.id_estado and
	    empleados.id_ciudad = colonias.id_ciudad and
	    empleados.id_ciudad = ciudades.id_ciudad and
	    empleados.id_colonia = colonias.id_colonia ")
        ComboBoxSex.DataSource = {"Femenino", "Masculino"}

        poblarComboBox(ComboBoxPais, "SELECT * FROM PAISES", "ID_PAIS", "NOMBRE")


        ComboBoxEstad.Enabled = True
        poblarComboBox(ComboBoxEstad, "SELECT * FROM ESTADOS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue, "ID_ESTADO", "NOMBRE")


        ComboBoxCiudad.Enabled = True
        poblarComboBox(ComboBoxCiudad, "SELECT * FROM CIUDADES WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue, "ID_CIUDAD", "NOMBRE")


        ComboBoxC.Enabled = True
        poblarComboBox(ComboBoxC, "SELECT * FROM COLONIAS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue & " AND ID_CIUDAD=" & ComboBoxCiudad.SelectedValue, "ID_COLONIA", "NOMBRE")
        Label11.Visible = False
        LabContraAnte.Visible = False
        Label6.Visible = False

        txtContraseña.Visible = False
        txtContraseña.Text = ""

        txtConfirmar.Visible = False
        txtConfirmar.Text = ""

        TxtAnteriorContra.Visible = False
        TxtAnteriorContra.Text = ""
    End Sub
    Private Sub CBoxPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPais.SelectionChangeCommitted

        poblarComboBox(ComboBoxEstad, "SELECT * FROM ESTADOS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue, "ID_ESTADO", "NOMBRE")

        If Not IsNothing(ComboBoxEstad.SelectedValue) Then

            poblarComboBox(ComboBoxCiudad, "SELECT * FROM CIUDADES WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue, "ID_CIUDAD", "NOMBRE")

            If Not IsNothing(ComboBoxCiudad.SelectedValue) Then

                poblarComboBox(ComboBoxC, "SELECT * FROM COLONIAS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue & "AND ID_CIUDAD=" & ComboBoxCiudad.SelectedValue, "ID_COLONIA", "NOMBRE")
            Else
            End If
        Else
        End If


    End Sub
    Private Sub CBoxEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEstad.SelectionChangeCommitted

        poblarComboBox(ComboBoxCiudad, "SELECT * FROM CIUDADES WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue, "ID_CIUDAD", "NOMBRE")

        If Not IsNothing(ComboBoxCiudad.SelectedValue) Then

            poblarComboBox(ComboBoxC, "SELECT * FROM COLONIAS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue & "AND ID_CIUDAD=" & ComboBoxCiudad.SelectedValue, "ID_COLONIA", "NOMBRE")
        Else

            ComboBoxC.DataSource = {}
        End If

    End Sub
    Private Sub CBoxCiudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCiudad.SelectionChangeCommitted


        poblarComboBox(ComboBoxEstad, "SELECT * FROM COLONIAS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue & "AND ID_CIUDAD=" & ComboBoxCiudad.SelectedValue, "ID_COLONIA", "NOMBRE")

    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    'Insert Usuarios
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim empl As New Empleado

        txtNombre.Text = txtNombre.Text.Trim
        txtPaterno.Text = txtPaterno.Text.Trim
        txtMaterno.Text = txtMaterno.Text.Trim
        txtRFC.Text = txtRFC.Text.Trim
        TxtCurp.Text = TxtCurp.Text.Trim
        txtemai.Text = txtemai.Text.Trim
        txttef.Text = txttef.Text.Trim
        txtca.Text = txtca.Text.Trim
        txtnCa.Text = txtnCa.Text.Trim

        If txtNombre.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtNombre.Focus()
        ElseIf txtPaterno.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtPaterno.Focus()
        ElseIf txtMaterno.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtMaterno.Focus()
        ElseIf txtRFC.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtRFC.Focus()
        ElseIf TxtCurp.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            TxtCurp.Focus()
        ElseIf txttef.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txttef.Focus()
        ElseIf txtca.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtca.Focus()
        ElseIf txtnCa.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtnCa.Focus()
        ElseIf IsNothing(ComboBoxPais.SelectedValue) Then
            MessageBox.Show("Estado No Seleccionado")
            ComboBoxPais.Focus()
        ElseIf IsNothing(ComboBoxCiudad.SelectedValue) Then
            MessageBox.Show("Ciudad No Seleccionada")
            ComboBoxEstad.Focus()

        ElseIf IsNothing(ComboBoxC.SelectedValue) Then
            MessageBox.Show("Colonia No Seleccionada")
            ComboBoxCiudad.Focus()
        End If
        Dim Sex As String
        If ComboBoxSex.SelectedIndex = 0 Then
            Sex = "F"
        Else
            Sex = "M"
        End If
        If (Not Existe(Convert.ToInt32(txtId.Text))) Then

            Dim consulta As String = "INSERT INTO EMPLEADOS VALUES(" & txtId.Text & "," &
                ComboBoxPais.SelectedValue & "," &
                ComboBoxEstad.SelectedValue & "," &
                ComboBoxCiudad.SelectedValue & "," &
                ComboBoxC.SelectedValue & ",
                    '" & txtNombre.Text & "','" &
                txtPaterno.Text & "','" &
                txtMaterno.Text & "','" &
                txtRFC.Text & "','" &
                TxtCurp.Text & "','" &
                Sex & "','" &
                txtemai.Text & "'," &
                txttef.Text & "," &
                txtnCa.Text & ",'" &
                txtca.Text & "')"


            Try
                Dim contrasena As String

                txtContraseña.Text = txtContraseña.Text.Trim
                If txtContraseña.Text = "" Then
                    MessageBox.Show("Falta capturar datos")
                    txtContraseña.Focus()

                Else
                    If Not txtContraseña.Text.Equals(txtConfirmar.Text) Then
                        MessageBox.Show("No coincide la contraseña")
                        txtContraseña.Focus()
                    Else
                        contrasena = "INSERT INTO LOGIN VALUES(" & txtId.Text & ",'" &
                            txtContraseña.Text & "')"
                        empl.realizarQuery(consulta)
                        empl.realizarQuery(contrasena)


                        MessageBox.Show("EMPLEADO INGRESADO")

                        muestra(dgvUsuarios, "select	 EMPLEADOS.ID_EMPLEADO as ID_EMPLEADO,
         EMPLEADOS.NOMBRE as NOMBRE,
         EMPLEADOS.PATERNO as PATERNO,
         EMPLEADOS.MATERNO as MATERNO,
         EMPLEADOS.SEXO as SEXO,
         EMPLEADOS.TELEFONO as TELEFONO,
         EMPLEADOS.CORREO AS CORREO,
         EMPLEADOS.NUMERO_CASA as NUMERO_CASA,
         EMPLEADOS.CALLE as CALLE,
         COLONIAS.NOMBRE as COLONIA,
         CIUDADES.NOMBRE as CIUDAD,
         ESTADOS.NOMBRE as ESTADO,
         PAISES.NOMBRE as PAIS,
         EMPLEADOS.CORREO as CORREO,
         EMPLEADOS.CURP as CURP,
         EMPLEADOS.RFC as RFC 
        from	 COLONIAS COLONIAS,
         CIUDADES CIUDADES,
         ESTADOS ESTADOS,
         PAISES PAISES,
         EMPLEADOS EMPLEADOS
where   empleados.id_pais = colonias.id_pais and
	empleados.id_pais = ciudades.id_pais and
        empleados.id_pais = estados.id_pais and
        empleados.id_pais = paises.id_pais and
	empleados.id_estado = colonias.id_estado and
	empleados.id_estado = ciudades.id_estado and
	empleados.id_estado = estados.id_estado and
	empleados.id_ciudad = colonias.id_ciudad and
	empleados.id_ciudad = ciudades.id_ciudad and
	empleados.id_colonia = colonias.id_colonia ")

                    End If


                End If
            Catch ex As Exception
                MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
            End Try
            Dim met As New Metodos
            met.LimpiarCamposG(gbUsr)
            txtId.Text = contar()
        Else
            MsgBox("EL ID YA EXISTE..")
        End If

    End Sub



    Private Sub btnSelect_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If MessageBox.Show("Esta Seguro", "Confirmar", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then

                Dim empl As New Empleado


                empl.realizarQuery("DELETE FROM LOGIN WHERE ID_EMPLEADO=" & txtId.Text)
                empl.realizarQuery("DELETE FROM EMPLEADOS WHERE ID_EMPLEADO=" & txtId.Text)

                MessageBox.Show("EMPLEADO BORRADO")
                muestra(dgvUsuarios, "select	 EMPLEADOS.ID_EMPLEADO as ID_EMPLEADO,
         EMPLEADOS.NOMBRE as NOMBRE,
         EMPLEADOS.PATERNO as PATERNO,
         EMPLEADOS.MATERNO as MATERNO,
         EMPLEADOS.SEXO as SEXO,
         EMPLEADOS.TELEFONO as TELEFONO,
         EMPLEADOS.CORREO AS CORREO,
         EMPLEADOS.NUMERO_CASA as NUMERO_CASA,
         EMPLEADOS.CALLE as CALLE,
         COLONIAS.NOMBRE as COLONIA,
         CIUDADES.NOMBRE as CIUDAD,
         ESTADOS.NOMBRE as ESTADO,
         PAISES.NOMBRE as PAIS,
         EMPLEADOS.CORREO as CORREO,
         EMPLEADOS.CURP as CURP,
         EMPLEADOS.RFC as RFC 
        from	 COLONIAS COLONIAS,
         CIUDADES CIUDADES,
         ESTADOS ESTADOS,
         PAISES PAISES,
         EMPLEADOS EMPLEADOS
where   empleados.id_pais = colonias.id_pais and
	empleados.id_pais = ciudades.id_pais and
        empleados.id_pais = estados.id_pais and
        empleados.id_pais = paises.id_pais and
	empleados.id_estado = colonias.id_estado and
	empleados.id_estado = ciudades.id_estado and
	empleados.id_estado = estados.id_estado and
	empleados.id_ciudad = colonias.id_ciudad and
	empleados.id_ciudad = ciudades.id_ciudad and
	empleados.id_colonia = colonias.id_colonia ")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try

        txtId.Text = contar()
        met.LimpiarCamposG(gbUsr)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        met.LimpiarCamposG(gbUsr)
        txtId.Text = contar()
    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvUsuarios.Rows(e.RowIndex)

            txtId.Text = row.Cells("ID_EMPLEADO").Value.ToString
            txtNombre.Text = row.Cells("NOMBRE").Value.ToString
            txtPaterno.Text = row.Cells("PATERNO").Value.ToString
            txtMaterno.Text = row.Cells("MATERNO").Value.ToString

            ComboBoxSex.Text = row.Cells("SEXO").Value.ToString
            txttef.Text = row.Cells("TELEFONO").Value.ToString
            txtemai.Text = row.Cells("CORREO").Value.ToString

            txtnCa.Text = row.Cells("NUMERO_CASA").Value.ToString
            txtca.Text = row.Cells("CALLE").Value.ToString
            ComboBoxC.Text = row.Cells("COLONIA").Value.ToString
            ComboBoxCiudad.Text = row.Cells("CIUDAD").Value.ToString
            ComboBoxEstad.Text = row.Cells("ESTADO").Value.ToString
            ComboBoxPais.Text = row.Cells("PAIS").Value.ToString
            TxtCurp.Text = row.Cells("CURP").Value.ToString
            txtRFC.Text = row.Cells("RFC").Value.ToString

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim contrasena As String
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        Dim nm As String = "SELECT contrasena from login where  ID_EMPLEADO=" & txtId.Text
        xDT = xCnx.objetoDataAdapter(nm)
        Dim Contra As String = CStr(xDT.Rows(0)("contrasena"))

        Try

            Dim Sex As String
            If ComboBoxSex.SelectedIndex = 0 Then
                Sex = "F"
            Else
                Sex = "M"
            End If

            Dim consulta As String = "UPDATE EMPLEADOS SET NOMBRE='" & txtNombre.Text & "',PATERNO='" & txtPaterno.Text & "',MATERNO='" & txtMaterno.Text & "',RFC='" &
                    txtRFC.Text & "',CURP='" & TxtCurp.Text & "',ID_SEXO=" & Sex & ",EMAIL='" & txtemai.Text & "',TELEFONO='" &
                    txttef.Text & "',NUMERO_CASA ='" & txtnCa.Text & "',CALLE='" & txtca.Text & "',ID_COLONIA=" &
                    ComboBoxC.SelectedValue & ",ID_CIUDAD=" &
                    ComboBoxCiudad.SelectedValue & ",ID_ESTADO=" &
                    ComboBoxEstad.SelectedValue & ",ID_PAIS=" &
                    ComboBoxPais.SelectedValue & ",' WHERE ID_EMPLEADO=" & txtId.Text

            txtContraseña.Text = txtContraseña.Text.Trim
            If ChBoxCambiarContra.Checked Then


                If txtContraseña.Text = "" Then
                    MessageBox.Show("Falta capturar datos")
                    txtContraseña.Focus()

                Else
                    If Not txtContraseña.Text.Equals(txtConfirmar.Text) Then
                        MessageBox.Show("No coincide la contraseña")
                        txtConfirmar.Focus()
                    ElseIf Not Contra.Equals(TxtAnteriorContra.Text) Then
                        MessageBox.Show("Contraseña Erronea")
                        TxtAnteriorContra.Focus()
                    Else
                        contrasena = "UPDATE LOGIN SET CONTRASENA='" & txtContraseña.Text & "' WHERE ID_EMPLEADO=" & txtId.Text

                        met.realizarQuery(contrasena)
                        MessageBox.Show("DATOS EMPLEADO ACTUALIZADOS")
                        txtId.Text = contar()

                    End If
                End If
            End If






        Catch ex As Exception
            MsgBox("Error")
        End Try
        muestra(dgvUsuarios, "select	 EMPLEADOS.ID_EMPLEADO as ID_EMPLEADO,
         EMPLEADOS.NOMBRE as NOMBRE,
         EMPLEADOS.PATERNO as PATERNO,
         EMPLEADOS.MATERNO as MATERNO,
         EMPLEADOS.SEXO as SEXO,
         EMPLEADOS.TELEFONO as TELEFONO,
         EMPLEADOS.CORREO AS CORREO,
         EMPLEADOS.NUMERO_CASA as NUMERO_CASA,
         EMPLEADOS.CALLE as CALLE,
         COLONIAS.NOMBRE as COLONIA,
         CIUDADES.NOMBRE as CIUDAD,
         ESTADOS.NOMBRE as ESTADO,
         PAISES.NOMBRE as PAIS,
         EMPLEADOS.CORREO as CORREO,
         EMPLEADOS.CURP as CURP,
         EMPLEADOS.RFC as RFC 
        from	 COLONIAS COLONIAS,
         CIUDADES CIUDADES,
         ESTADOS ESTADOS,
         PAISES PAISES,
         EMPLEADOS EMPLEADOS
where   empleados.id_pais = colonias.id_pais and
	empleados.id_pais = ciudades.id_pais and
        empleados.id_pais = estados.id_pais and
        empleados.id_pais = paises.id_pais and
	empleados.id_estado = colonias.id_estado and
	empleados.id_estado = ciudades.id_estado and
	empleados.id_estado = estados.id_estado and
	empleados.id_ciudad = colonias.id_ciudad and
	empleados.id_ciudad = ciudades.id_ciudad and
	empleados.id_colonia = colonias.id_colonia ")

    End Sub


    Private Sub SoloNumerosSinPuntos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttef.KeyPress, txtId.KeyPress, txtnCa.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
    Public Function Existe(ByVal id As Integer) As Boolean

        Dim xCnx As New Oracle

        Dim nm As String = "select	 EMPLEADOS.ID_EMPLEADO as ID_EMPLEADO from	 EMPLEADOS where ID_EMPLEADO=" & txtId.Text



        Dim count As Integer = xCnx.objetoScalar(nm)
        If count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChBoxCambiarContra.CheckedChanged
        Dim sino As Boolean = ChBoxCambiarContra.Checked

        Label11.Visible = sino
        LabContraAnte.Visible = sino
        Label6.Visible = sino

        txtContraseña.Visible = sino
        txtContraseña.Text = ""

        txtConfirmar.Visible = sino
        txtConfirmar.Text = ""

        TxtAnteriorContra.Visible = sino
        TxtAnteriorContra.Text = ""

    End Sub

    Public Function contar() As Double
        Dim xCnx As New Oracle
        Dim nm As String = "SELECT COUNT(*) FROM empleados"

        Dim c As Integer = xCnx.objetoScalar(nm)

        Return c + 1






    End Function

End Class