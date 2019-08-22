Public Class CrearUsuarioLOGIN

    Private Sub CrearUsuarioLOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxSex.DataSource = {"Femenino", "Masculino"}

        poblarComboBox(ComboBoxPais, "SELECT * FROM PAISES", "ID_PAIS", "NOMBRE")


        ComboBoxEstad.Enabled = True
        poblarComboBox(ComboBoxEstad, "SELECT * FROM ESTADOS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue, "ID_ESTADO", "NOMBRE")


        ComboBoxCiudad.Enabled = True
        poblarComboBox(ComboBoxCiudad, "SELECT * FROM CIUDADES WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue, "ID_CIUDAD", "NOMBRE")


        ComboBoxC.Enabled = True
        poblarComboBox(ComboBoxC, "SELECT * FROM COLONIAS WHERE ID_PAIS=" & ComboBoxPais.SelectedValue & " AND ID_ESTADO=" & ComboBoxEstad.SelectedValue & " AND ID_CIUDAD=" & ComboBoxCiudad.SelectedValue, "ID_COLONIA", "NOMBRE")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
                        Login.Enabled = True
                        Login.Show()
                        Me.Visible = False

                    End If


                End If
            Catch ex As Exception
                MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")
            End Try
            Dim met As New Metodos
            met.LimpiarCamposG(gbUsr)
        Else
            MsgBox("EL ID YA EXISTE...")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Visible = False
        Login.Enabled = True

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
End Class