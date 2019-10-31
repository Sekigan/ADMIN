Public Class FormBuscarPaquete
    Private Sub FormBuscarPaquete_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub


    Private Sub CBEmp_Click(sender As Object, e As EventArgs) Handles CBEmp.Click
        poblarComboBox(CBEmp, "SELECT empleados.id_empleado, NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  empleados order by ID_empleado", "id_empleado", "Nombre")
    End Sub
    Private Sub Cbc_Click(sender As Object, e As EventArgs) Handles CBc.Click
        poblarComboBox(CBc, "SELECT clientes.id_cliente, NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  CLIENTES order by ID_CLIENTE", "id_cliente", "Nombre")
    End Sub

    Private Sub CheckBoxEm_CheckedChanged(sender As Object, e As EventArgs)
        CBEmp.Visible = True
        CheckBoxCEntregas.Visible = True
        CheckBoxDevC.Visible = True

    End Sub
    Private Sub ChC_CheckedChanged(sender As Object, e As EventArgs)
        CBc.Visible = True
    End Sub

    Private Sub CheckBoxFecha_CheckedChanged(sender As Object, e As EventArgs)
        DTPfecha.Visible = True

    End Sub



    Private Sub Ver_Click(sender As Object, e As EventArgs) Handles Ver.Click

        Dim dd As Integer = DTPfecha.Value.Day
        Dim mm As Integer = DTPfecha.Value.Month
        Dim yy As Integer = DTPfecha.Value.Year

        Dim dia As String = dd & "/" & mm & "/" & yy
        Try

            'muestra(dgvRes, "SELECT paquetes.id_paquete, c.nombre||' '||c.paterno as nombre_cliente_remitente, paquetes.nombre_empleado, paquetes.fecha_entrega FROM paquetes,clientes c WHERE paquetes.id_cliente=c.id_cliente AND NOT EXIST(select *from entregas where entregas.fecha_entrega= '" & dia & "')")
            'and entregas.id_paquete=paquetes.id_cliente 
            muestra(dgvRes, "SELECT paquetes.id_paquete,  paquetes.nombre_empleado, paquetes.fecha_entrega, p.nOmbre||' '||p.paternO||' '||p.maternO as N0mbre FROM paquetes,clientes p where paquetes.id_cliente=p.id_cliente and  paquetes.fecha_entrega= '" & dd & "/" & mm & "/" & yy & "' and  NOT EXISTS(select *from entregas where paquetes.id_paquete=entregas.id_paquete ) and NOT EXISTS(select *from devoluciones where paquetes.id_paquete=devoluciones.id_paquete )")

        Catch er As Exception
            '   MsgBox("REVISA LOS DATOS", vbInformation)
        End Try


    End Sub

    Private Sub VerXCliente_Click(sender As Object, e As EventArgs) Handles VerXCliente.Click
        Try

            muestra(dgvRes, "select entregas.id_paquete, entregas.fecha_entrega, Paquetes.nombre_empleado, Paquetes.contenido, c.nombre||' '||c.paterno||' '||c.materno as Recibido_por
        From paquetes, entregas, clientes , clientes c
        Where paquetes.id_paquete = entregas.id_paquete And
         paquetes.id_cliente_d= c.id_cliente and
    paquetes.id_cliente = clientes.id_cliente And paquetes.id_cliente = " & CBc.SelectedValue)

        Catch er As Exception
            MsgBox("Selecciona el cliente", vbInformation)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim name As String = "Select	 EMPLEADOS.id_EMPLEADO As NOMBRE from	 EMPLEADOS where id_EMPLEADO = " & CBEmp.SelectedValue
        'Dim xCnx As New Oracle
        'Dim xDT As DataTable
        'xDT = xCnx.objetoDataAdapter(name)
        'Dim name1 As String = CStr(xDT.Rows(0)("nombre"))



        If CheckBoxCEntregas.Checked = True Then

            muestra(dgvRes, "select entregas.id_paquete, paquetes.contenido, entregas.fecha_entrega, clientes.nombre||' '||clientes.paterno||' '||clientes.materno as NOMBRE_REMITENTE,
            c.nombre||' '||c.paterno||' '||c.materno as NOMBRE_DESTINATARIO,
            empleados.nombre||' '||empleados.paterno||' '||empleados.materno as ENCARGAD0_ENTREGA,
            e.nombre||' '||e.paterno||' '||e.materno as EMP_ENTREGA
            from entregas, paquetes, clientes, clientes c, empleados e, empleados
            where paquetes.id_paquete = entregas.id_paquete and
            paquetes.id_cliente_d = c.id_cliente and
            paquetes.empleado_entrega=empleados.id_empleado and 
            e.id_empleado=entregas.id_empleado and
	        paquetes.id_cliente = clientes.id_cliente and entregas.id_empleado=" & CBEmp.SelectedValue)
        End If

        If CheckBoxDevC.Checked Then

            muestra(dgvRes, "select devoluciones.id_paquete,  clientes.nombre, paquetes.fecha_entrega, devoluciones.fecha_devolucion, devoluciones.motivo 
        from paquetes, devoluciones, clientes
        where paquetes.id_paquete = devoluciones.id_paquete and
	paquetes.id_cliente = clientes.id_cliente and devoluciones.id_empleado =" & CBEmp.SelectedValue)
        End If
        If CheckBoxCEntregas.Checked And CheckBoxDevC.Checked Then
            CheckBoxCEntregas.CheckState = CheckState.Unchecked
            CheckBoxDevC.CheckState = CheckState.Unchecked
            MsgBox("SOLO SELECCIONA UNA OPCION", vbInformation)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim met As New Metodos
        met.LimpiarCamposG(gbFiltros)
    End Sub

    Private Sub btcActualizar_Click(sender As Object, e As EventArgs) Handles btcActualizar.Click
        Try
            muestra(dgvRes, "select devoluciones.id_paquete, devoluciones.motivo, devoluciones.fecha_devolucion, clientes.paterno as CLIENTE_P, clientes.nombre as CLIENTE
        from devoluciones, clientes, paquetes
        where devoluciones.id_paquete = paquetes.id_paquete and
	    paquetes.id_cliente = clientes.id_cliente")
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub


End Class