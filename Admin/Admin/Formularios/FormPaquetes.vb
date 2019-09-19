Public Class FormPaquetes
    Dim met As New Metodos
    Private Sub FormPaquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdPaquetes.Text = contar()
        muestra(dgvPaquetes, "Select paquetes.id_paquete as id_paquete,
	paquetes.remitente as remitente,
	paquetes.telefono_remitente as telefono_remitente,
	paquetes.fecha_envio as fecha_envio,
	paquetes.contenido as contenido,
	paquetes.peso as peso,
	paquetes.nombre_empleado as nombre_empleado,
	paquetes.dia_dealta as dia_de_alta,
	paquetes.precio_envio as precio_envio,
	paquetes.observacion as observacion,
	paquetes.fecha_entrega as fecha_entrega,
	empleados.id_empleado as id_empleado,
	clientes.id_cliente as id_cliente
from PAQUETES, empleados, clientes
where paquetes.id_cliente = clientes.id_cliente and 
      paquetes.id_empleado = empleados.id_empleado")

        DateEntrega.MinDate = Today
        DateToday.MinDate = Today
        DateEntrega.CustomFormat = "DD/MM/YYYY"



    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub ChBoxCliente_CheckedChanged(sender As Object, e As EventArgs) Handles ChBoxCliente.CheckedChanged

        If ChBoxCliente.Checked Then


            poblarComboBox(CBoxCliente, "SELECT * FROM  CLIENTES order by id_CLIENTE", "id_cliente", "PaternO")


        End If
    End Sub

    Private Sub ChBoxNuevoCliente_CheckedChanged(sender As Object, e As EventArgs) Handles ChBoxNuevoCliente.CheckedChanged
        If ChBoxNuevoCliente.Checked Then

            FormClientes.ShowDialog()

        End If

    End Sub

    Private Sub btnAgrega_Click(sender As Object, e As EventArgs) Handles btnAgrega.Click

        Try
            Dim dd As Integer = DateEntrega.Value.Day
            Dim mm As Integer = DateEntrega.Value.Month
            Dim yy As Integer = DateEntrega.Value.Year

            Dim d As Integer = DateToday.Value.Day
            Dim m As Integer = DateToday.Value.Month
            Dim y As Integer = DateToday.Value.Year

            txtIdPaquetes.Text = txtIdPaquetes.Text.Trim
            txtPeso.Text = txtPeso.Text.Trim

            Contenido.Text = Contenido.Text.Trim

            Observa.Text = Observa.Text.Trim

            If txtPeso.Text = "" Then
                MessageBox.Show("Falta capturar datos")
                txtPeso.Focus()

            ElseIf Contenido.Text = "" Then
                MessageBox.Show("Falta capturar datos")
                Contenido.Focus()
            ElseIf Observa.Text = "" Then
                MessageBox.Show("Falta capturar datos")
                Observa.Focus()


            End If
            Dim peso As String = txtPeso.Text
            met.precioPaq(peso)
            Costo.Text = preciop

            Dim xCnx As New Oracle
            Dim xDT As DataTable
            Dim xDT1 As DataTable
            Dim xCnx1 As New Oracle
            Dim nm As String = "SELECT NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  CLIENTES WHERE ID_CLIENTE =" & CBoxCliente.SelectedValue
            xDT = xCnx.objetoDataAdapter(nm)
            Dim te As String = "SELECT TELEFONO FROM  CLIENTES WHERE ID_CLIENTE =" & CBoxCliente.SelectedValue
            xDT1 = xCnx1.objetoDataAdapter(te)
            ClienteN = CStr(xDT.Rows(0)("nombre"))
            ClienteT = CStr(xDT1.Rows(0)("TELEFONO"))




            Dim diaa As String = d & "/" & m & "/" & y
            Dim diaE As String = dd & "/" & mm & "/" & yy

            Dim consulta As String = "insert into PAQUETES values(" & txtIdPaquetes.Text & "," & LOGINCLAVE & "," & CBoxCliente.SelectedValue & ",'" & ClienteN & "'," & ClienteT & ",'" & d & "/" & m & "/" & y & "','" & Contenido.Text & "','" & txtPeso.Text & "','" & LOGINNOMBRE & "','" & d & "/" & m & "/" & y & "'," & preciop & ",'" & Observa.Text & "','" & dd & "/" & mm & "/" & yy & "')"



            met.realizarQuery(consulta)


            MessageBox.Show("PAQUETE INGRESADO")
        Catch ex As Exception
            MsgBox("Verifica que la información sea correcta", vbInformation, "Datos Incorrectos")

        End Try
        muestra(dgvPaquetes, "Select *from paquetes")
        txtIdPaquetes.Text = contar()

    End Sub
    Private Sub dgvPaquetes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaquetes.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvPaquetes.Rows(e.RowIndex)

            CBoxCliente.Text = row.Cells("ID_CLIENTE").Value.ToString
            txtIdPaquetes.Text = row.Cells("ID_PAQUETE").Value.ToString
            txtPeso.Text = row.Cells("PESO").Value.ToString
            Contenido.Text = row.Cells("CONTENIDO").Value.ToString


            Costo.Text = row.Cells("PRECIO_ENVIO").Value.ToString
            Observa.Text = row.Cells("OBSERVACION").Value.ToString



        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        met.LimpiarCamposG(GroupBox1)
        met.LimpiarCamposG(GroupBox2)

        met.LimpiarCamposG(gbPaises)
        txtIdPaquetes.Text = contar()

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            If MessageBox.Show("Esta Seguro", "Confirmar", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
                met.realizarQuery("DELETE FROM PAQUETES WHERE ID_PAQUETE=" & txtIdPaquetes.Text)
                MessageBox.Show("PAQUETE BORRADO")
            End If
        Catch er As Exception
            MsgBox("Imposible borrar")
        End Try

        muestra(dgvPaquetes, "Select *from paquetes")
        txtIdPaquetes.Text = contar()
    End Sub
    Private Sub SoloNumerosSinPuntos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeso.KeyPress, txtIdPaquetes.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Dim xCnx As New Oracle
        Dim xDT As DataTable
        Dim xDT1 As DataTable
        Dim xCnx1 As New Oracle
        Dim nm As String = "SELECT NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  CLIENTES WHERE ID_CLIENTE =" & CBoxCliente.SelectedValue
        xDT = xCnx.objetoDataAdapter(nm)
        Dim te As String = "SELECT TELEFONO FROM  CLIENTES WHERE ID_CLIENTE =" & CBoxCliente.SelectedValue
        xDT1 = xCnx1.objetoDataAdapter(te)
        ClienteN = CStr(xDT.Rows(0)("nombre"))
        ClienteT = CStr(xDT1.Rows(0)("TELEFONO"))
        Dim dd As Integer = DateEntrega.Value.Day
        Dim mm As Integer = DateEntrega.Value.Month
        Dim yy As Integer = DateEntrega.Value.Year

        Dim d As Integer = DateToday.Value.Day
        Dim m As Integer = DateToday.Value.Month
        Dim y As Integer = DateToday.Value.Year
        Dim diaa As String = d & "/" & m & "/" & y
        Dim diaE As String = dd & "/" & mm & "/" & yy
        Dim peso As String = txtPeso.Text
        met.precioPaq(peso)
        Costo.Text = preciop
        Try
            Dim update As String = "update paquetes set id_paquete=" & txtIdPaquetes.Text & ",id_empleado=" & LOGINCLAVE & ", id_cliente=" & CBoxCliente.SelectedValue & ",remitente='" & ClienteN & "', telefono_remitente=" & ClienteT & ", fecha_envio ='" & diaE & "',
        contenido='" & Contenido.Text & "',peso=" & txtPeso.Text & ",nombre_empleado  ='" & LOGINNOMBRE & "', dia_dealta ='" & diaa & "',precio_envio =" & preciop & ", observacion ='" & Observa.Text & "',fecha_entrega ='" & diaa & "' where id_paquete=" & txtIdPaquetes.Text
            met.realizarQuery(update)
            MsgBox("UPDATE")
        Catch er As Exception
            MsgBox("ERR", vbInformation)
        End Try
        muestra(dgvPaquetes, "Select paquetes.id_paquete as id_paquete,
	paquetes.remitente as remitente,
	paquetes.telefono_remitente as telefono_remitente,
	paquetes.fecha_envio as fecha_envio,
	paquetes.contenido as contenido,
	paquetes.peso as peso,
	paquetes.nombre_empleado as nombre_empleado,
	paquetes.dia_dealta as dia_de_alta,
	paquetes.precio_envio as precio_envio,
	paquetes.observacion as observacion,
	paquetes.fecha_entrega as fecha_entrega,
	empleados.id_empleado as id_empleado,
	clientes.id_cliente as id_cliente
from PAQUETES, empleados, clientes
where paquetes.id_cliente = clientes.id_cliente and 
      paquetes.id_empleado = empleados.id_empleado")
        txtIdPaquetes.Text = contar()
    End Sub

    Public Function contar() As Double
        Dim xCnx As New Oracle
        Dim nm As String = "SELECT COUNT(*) FROM paquetes"

        Dim c As Integer = xCnx.objetoScalar(nm)

        Return c + 1

    End Function



End Class