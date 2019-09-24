Public Class FormPaquetes
    Dim met As New Metodos


    Private Sub FormPaquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdPaquetes.Text = contar()
        muestra(dgvPaquetes, "Select paquetes.id_paquete as id_paquete,
	        paquetes.contenido as contenido,
            paquetes.precio_envio as precio_envio,
            paquetes.remitente as remitente,
	        paquetes.telefono_remitente as telefono_remitente,
        	paquetes.fecha_envio as fecha_envio,
            paquetes.fecha_entrega as fecha_entrega,
	        paquetes.peso as peso,
	        paquetes.nombre_empleado as nombre_empleado,
	        paquetes.dia_dealta as dia_de_alta,
	        paquetes.observacion as observacion,
	        empleados.id_empleado as id_empleado,
	        clientes.id_cliente as id_cliente
            from PAQUETES, empleados, clientes 
            where paquetes.id_cliente = clientes.id_cliente and 
            paquetes.id_empleado = empleados.id_empleado")
        DateEntrega.MinDate = Today
        DateToday.MinDate = Today
        DateEntrega.CustomFormat = "DD/MM/YYYY"
        muestra(DataGridView1, "Select id_paquete from entregas")
        muestra(DataGridView2, "Select id_paquete from devoluciones")
        comparar()
        poblarComboBox(CBoxCliente, "SELECT clientes.id_cliente, NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  CLIENTES order by ID_CLIENTE ", "id_cliente", "nombre")

        poblarComboBox(CBoxCliente, "SELECT clientes.id_cliente, NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  CLIENTES WHERE NOT EXISTS(select FROM  CLIENTES  where paquetes.id_paquete= " & CBoxCliente.SelectedValue & ")", "id_cliente", "nombre")

    End Sub



    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub ChBoxCliente_CheckedChanged(sender As Object, e As EventArgs) Handles ChBoxCliente.CheckedChanged

        If ChBoxCliente.Checked Then


            poblarComboBox(CBoxCliente, "SELECT clientes.id_cliente, NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  CLIENTES order by ID_CLIENTE ", "id_cliente", "nombre")


        End If
    End Sub

    Private Sub ChBoxNuevoCliente_CheckedChanged(sender As Object, e As EventArgs) Handles ChBoxNuevoCliente.CheckedChanged
        If ChBoxNuevoCliente.Checked Then

            ChBoxCliente.CheckState = CheckState.Unchecked
            ChBoxNuevoCliente.CheckState = CheckState.Unchecked
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
        muestra(dgvPaquetes, "Select paquetes.id_paquete as id_paquete,
	        paquetes.contenido as contenido,
            paquetes.precio_envio as precio_envio,
            paquetes.remitente as remitente,
	        paquetes.telefono_remitente as telefono_remitente,
        	paquetes.fecha_envio as fecha_envio,
            paquetes.fecha_entrega as fecha_entrega,
	        paquetes.peso as peso,
	        paquetes.nombre_empleado as nombre_empleado,
	        paquetes.dia_dealta as dia_de_alta,
	        paquetes.observacion as observacion,
	        empleados.id_empleado as id_empleado,
	        clientes.id_cliente as id_cliente
            from PAQUETES, empleados, clientes
            where paquetes.id_cliente = clientes.id_cliente and 
            paquetes.id_empleado = empleados.id_empleado")
        txtIdPaquetes.Text = contar()
        comparar()

    End Sub
    Private Sub dgvPaquetes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaquetes.CellContentClick


        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvPaquetes.Rows(e.RowIndex)




            CBoxCliente.Text = row.Cells("Remitente").Value.ToString
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
        muestra(dgvPaquetes, "Select paquetes.id_paquete as id_paquete,
	        paquetes.contenido as contenido,
            paquetes.precio_envio as precio_envio,
            paquetes.remitente as remitente,
	        paquetes.telefono_remitente as telefono_remitente,
        	paquetes.fecha_envio as fecha_envio,
            paquetes.fecha_entrega as fecha_entrega,
	        paquetes.peso as peso,
	        paquetes.nombre_empleado as nombre_empleado,
	        paquetes.dia_dealta as dia_de_alta,
	        paquetes.observacion as observacion,
	        empleados.id_empleado as id_empleado,
	        clientes.id_cliente as id_cliente
            from PAQUETES, empleados, clientes
            where paquetes.id_cliente = clientes.id_cliente and 
            paquetes.id_empleado = empleados.id_empleado")
        comparar()

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

        muestra(dgvPaquetes, "Select paquetes.id_paquete as id_paquete,
	        paquetes.contenido as contenido,
            paquetes.precio_envio as precio_envio,
            paquetes.remitente as remitente,
	        paquetes.telefono_remitente as telefono_remitente,
        	paquetes.fecha_envio as fecha_envio,
            paquetes.fecha_entrega as fecha_entrega,
	        paquetes.peso as peso,
	        paquetes.nombre_empleado as nombre_empleado,
	        paquetes.dia_dealta as dia_de_alta,
	        paquetes.observacion as observacion,
	        empleados.id_empleado as id_empleado,
	        clientes.id_cliente as id_cliente
            from PAQUETES, empleados, clientes
            where paquetes.id_cliente = clientes.id_cliente and 
            paquetes.id_empleado = empleados.id_empleado")
        comparar()
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
        Try
            Dim nm As String = "SELECT NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  CLIENTES WHERE ID_CLIENTE =" & CBoxCliente.SelectedValue
            xDT = xCnx.objetoDataAdapter(nm)
            Dim te As String = "SELECT TELEFONO FROM  CLIENTES WHERE ID_CLIENTE =" & CBoxCliente.SelectedValue
            xDT1 = xCnx1.objetoDataAdapter(te)
            ClienteN = CStr(xDT.Rows(0)("nombre"))
            ClienteT = CStr(xDT1.Rows(0)("TELEFONO"))
        Catch ex As Exception
            MsgBox("Verifica la informacion del cliente")
        End Try
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
	        paquetes.contenido as contenido,
            paquetes.precio_envio as precio_envio,
            paquetes.remitente as remitente,
	        paquetes.telefono_remitente as telefono_remitente,
        	paquetes.fecha_envio as fecha_envio,
            paquetes.fecha_entrega as fecha_entrega,
	        paquetes.peso as peso,
	        paquetes.nombre_empleado as nombre_empleado,
	        paquetes.dia_dealta as dia_de_alta,
	        paquetes.observacion as observacion,
	        empleados.id_empleado as id_empleado,
	        clientes.id_cliente as id_cliente
            from PAQUETES, empleados, clientes
            where paquetes.id_cliente = clientes.id_cliente and 
            paquetes.id_empleado = empleados.id_empleado")
        txtIdPaquetes.Text = contar()
        comparar()
    End Sub

    Public Function contar() As Double
        Dim xCnx As New Oracle
        Dim nm As String = "SELECT COUNT(*) FROM paquetes"

        Dim c As Integer = xCnx.objetoScalar(nm)

        Return c + 1

    End Function





    Private Sub txtPeso_TextChanged(sender As Object, e As EventArgs) Handles txtPeso.TextChanged
        Try
            Dim peso As Double = txtPeso.Text
            met.precioPaq(peso)
            Costo.Text = preciop
        Catch ex As Exception
            MsgBox("Solo numeros, por favor")
        End Try
    End Sub




    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fuente As System.Drawing.Font = New Font("consolas", 15)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim count As Integer = 0
        Dim textoC As String = ""
        Dim id As Byte = 0
        Dim contenidotext As String = ""
        Dim valor As Decimal = 0
        Dim tabulacion As String = ""
        Dim compensador As Integer = 0
        Dim total As Decimal = 0
        Dim titulo As String = ""

        Dim xCnx As New Oracle
        Dim nm As String = "SELECT NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  CLIENTES WHERE ID_CLIENTE =" & CBoxCliente.SelectedValue
        Dim nombre As String = xCnx.objetoScalar(nm)
        Try
            ' Imprime la cabecera
            yPos = 40
            Dim printFont As System.Drawing.Font = New Font("consolas", 13)
            Dim printFont2 As System.Drawing.Font = New Font("consolas", 12)
            e.Graphics.DrawString(("PAQUETES TUR"), fuente, Brushes.Black, 100, 40)
            e.Graphics.DrawString((" "), printFont, Brushes.Black, 10, 60)
            e.Graphics.DrawString("Ticket N. " & txtIdPaquetes.Text, printFont, Brushes.Black, 10, 100)
            e.Graphics.DrawString((" "), printFont, Brushes.Black, 10, 60)
            e.Graphics.DrawString("Fecha: " & Date.Now, printFont, Brushes.Black, 10, 120)
            e.Graphics.DrawString("Nombre del Cliente: " & nombre, printFont, Brushes.Black, 10, 160)

            e.Graphics.DrawString("---------------------------------", printFont, Brushes.Black, 10, 180)



            id = txtIdPaquetes.Text : contenidotext = Contenido.Text : valor = preciop


            titulo = "ID_PAQUETE" & " | " & "PAQUETE" & "     |  " & "PRECIO"
            textoC = id & "            " & contenidotext & "       " & valor 'Configura la linea
            yPos = 200
            e.Graphics.DrawString(titulo, printFont, System.Drawing.Brushes.Black, 10, yPos)
            yPos = 120 + topMargin + (count * printFont.GetHeight(e.Graphics)) ' Calcula la posición en la que se escribe la línea
            ' Imprime la línea con el objeto Graphics

            e.Graphics.DrawString(textoC, printFont, System.Drawing.Brushes.Black, 10, yPos)

            yPos += 20
            e.Graphics.DrawString("---------------------------------", printFont, Brushes.Black, 10, yPos)

            Dim puntos As String
            puntos = StrDup(20, ".")
            yPos += 20
            e.Graphics.DrawString("Total + IVA" & puntos & Costo.Text + 50, printFont2, System.Drawing.Brushes.Black, 10, yPos)
            yPos += 30
            e.Graphics.DrawString("Fue atendido por: " & LOGINNOMBRE, printFont, System.Drawing.Brushes.Black, 10, yPos)
            e.Graphics.DrawString(("VUELVA PRONTO!!"), printFont, Brushes.Black, 10, yPos + 20)
        Catch ex As Exception
            MsgBox("Verifica los datos")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub dgvPaquetes_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaquetes.CellMouseEnter


        comparar()
    End Sub

    Sub comparar()
        Try
            ':::Variable para contar los registros validados

            ':::Ciclo For que va desde 0 hasta el total de los registro de DGTabla
            For i = 0 To dgvPaquetes.RowCount - 1
                For j = 0 To DataGridView1.RowCount - 1
                    ':::Realizamos la validación de cada celda
                    If DataGridView1.Rows(j).Cells(0).Value = dgvPaquetes.Rows(i).Cells(0).Value Then
                        ':::Pintamos de color azul las que son iguales
                        dgvPaquetes.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                        ':::Aumentamos nuestro contador en 1
                    End If
                Next
                For x = 0 To DataGridView2.RowCount - 1
                    ':::Pintamos de naranja los que no son iguales
                    If DataGridView2.Rows(x).Cells(0).Value = dgvPaquetes.Rows(i).Cells(0).Value Then
                        dgvPaquetes.Rows(i).DefaultCellStyle.BackColor = Color.Tomato
                    End If
                    ':::Mostramos el resultado
                Next
            Next
        Catch ex As Exception
            MsgBox("Error en la operación por: " & ex.Message)
        End Try
    End Sub


End Class