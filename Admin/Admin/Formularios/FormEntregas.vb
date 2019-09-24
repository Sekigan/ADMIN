﻿Public Class FormEntregas
    Dim met As New Metodos
    Private Sub FormEntregas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Text = contar()
        muestra(dgvEntregas, "Select  entregas.id_entrega as id_entrega,
	entregas.fecha_entrega as fecha_entrega,
paquetes.remitente as nombre_remitente,
	'ID : '||paquetes.id_paquete||' Contenido: '||paquetes.contenido as Informacion_Paquete,
	empleados.nombre||' '||empleados.paterno||' '||empleados.materno as nombre_empleado
from ENTREGAS, empleados, paquetes where entregas.id_paquete = paquetes.id_paquete and
      entregas.id_empleado = empleados.id_empleado ")

        poblarComboBox(ComboBox1, "SELECT empleados.id_empleado, NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  empleados order by ID_empleado", "id_empleado", "nombre")
        poblarComboBox(ComboBoxPaquete, "SELECT paquetes.id_paquete, id_paquete||'.- '||Contenido AS NOMBRE FROM  paquetes order by ID_paquete", "id_paquete", "nombre")
        DateTimePicker1.MinDate = Today

        TextBox1.Text = Format(Now, "h:mm:ss A5/P5")
        muestra(DataGridView1, "Select id_entrega from entregas")


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fecha As String
            Dim fecha1 As String
            Dim xCnx As New Oracle
            Dim xDT As DataTable
            Dim dd As Integer = DateTimePicker1.Value.Day
            Dim mm As Integer = DateTimePicker1.Value.Month.ToString
        Dim yy As Integer = DateTimePicker1.Value.Year

        fecha1 = dd & "/" & "0" & mm & "/" & yy
            Dim nm As String = "select	 PAQUETES.FECHA_ENTREGA as FECHA_ENTREGA 
                             from	 PAQUETES PAQUETES WHERE ID_PAQUETE =" & ComboBoxPaquete.SelectedValue
            xDT = xCnx.objetoDataAdapter(nm)
            fecha = CStr(xDT.Rows(0)("FECHA_ENTREGA"))



        Try


            If Not Existe(ComboBoxPaquete.SelectedValue) Then
                'aqui haces el insert
                If txtID.Text = "" Then
                    MessageBox.Show("Falta capturar datos")
                    txtID.Focus()
                End If

                If fecha1.Equals(fecha) Or fecha <= fecha1 Then
                    If Existe1(ComboBoxPaquete.SelectedValue) Then
                        Try
                            Dim delet As String = "Delete from devoluciones where ID_PAQUETE=" & ComboBoxPaquete.SelectedValue
                            met.realizarQuery(delet)
                            MsgBox("PAQUETE DE DEVUELTO A ENTREGADO")
                        Catch er As Exception
                            MsgBox("ERROR")
                        End Try

                    End If
                    Dim insert As String = "insert into ENTREGAS values(" & txtID.Text & "," & ComboBoxPaquete.SelectedValue & "," & ComboBox1.SelectedValue & ",'" & fecha1 & "')"
                    Try
                        met.realizarQuery(insert)
                        MsgBox("PAQUETE ENTREGADO")

                    Catch ex As Exception
                        MsgBox("VERIFIQUE INFORMACION", vbInformation)
                    End Try
                Else
                    MsgBox("PAQUETES ACTUALIZADOS")
                    End If
                Else
                    MsgBox("El Paquete ya ah sido entregado o su fecha es proxima a entregarse", vbInformation)
            End If
        Catch er As Exception
            MsgBox("Ingresa los datos", vbInformation)
        End Try

        muestra(dgvEntregas, "Select  entregas.id_entrega as id_entrega,
	entregas.fecha_entrega as fecha_entrega,
paquetes.remitente as nombre_remitente,
	'ID : '||paquetes.id_paquete||' Contenido: '||paquetes.contenido as Informacion_Paquete,
	empleados.nombre||' '||empleados.paterno||' '||empleados.materno as nombre_empleado
from ENTREGAS, empleados, paquetes where entregas.id_paquete = paquetes.id_paquete and
      entregas.id_empleado = empleados.id_empleado ")
        txtID.Text = contar()
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        If MessageBox.Show("Esta Seguro", "Confirmar", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
            met.realizarQuery("DELETE FROM ENTREGAS WHERE ID_ENTREGA=" & txtID.Text)
            MessageBox.Show("PAQUETE BORRADO")
        End If
        muestra(dgvEntregas, "Select  entregas.id_entrega as id_entrega,
	entregas.fecha_entrega as fecha_entrega,
paquetes.remitente as nombre_remitente,
	'ID : '||paquetes.id_paquete||' Contenido: '||paquetes.contenido as Informacion_Paquete,
	empleados.nombre||' '||empleados.paterno||' '||empleados.materno as nombre_empleado
from ENTREGAS, empleados, paquetes where entregas.id_paquete = paquetes.id_paquete and
      entregas.id_empleado = empleados.id_empleado ")
        txtID.Text = contar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        muestra(dgvEntregas, "Select  entregas.id_entrega as id_entrega,
	entregas.fecha_entrega as fecha_entrega,
paquetes.remitente as nombre_remitente,
	'ID : '||paquetes.id_paquete||' Contenido: '||paquetes.contenido as Informacion_Paquete,
	empleados.nombre||' '||empleados.paterno||' '||empleados.materno as nombre_empleado
from ENTREGAS, empleados, paquetes where entregas.id_paquete = paquetes.id_paquete and
      entregas.id_empleado = empleados.id_empleado ")
        txtID.Text = contar()
    End Sub


    Public Function Existe(ByVal id As Integer) As Boolean

        Dim xCnx As New Oracle

        Dim nm As String = "select ENTREGAS.ID_PAQUETE as ID_PAQUETE from	ENTREGAS ENTREGAS where ID_PAQUETE=" & ComboBoxPaquete.SelectedValue



        Dim count As Integer = xCnx.objetoScalar(nm)
        If count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
    Public Function Existe1(ByVal id As Integer) As Boolean

        Dim xCnx As New Oracle

        Dim nm As String = "select DEVOLUCIONES.ID_DEVOLUCION as ID_DEVOLUCION from	DEVOLUCIONES where ID_PAQUETE=" & ComboBoxPaquete.SelectedValue



        Dim count As Integer = xCnx.objetoScalar(nm)
        If count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function contar() As Double
        Dim xCnx As New Oracle
        Dim nm As String = "SELECT COUNT(*) FROM entregas"
        Dim c As Integer = xCnx.objetoScalar(nm)

        Dim xCnx1 As New Oracle
        Dim nm1 As String = "SELECT id_paquete FROM entregas"
        Dim c1 As Integer = xCnx1.objetoScalar(nm)

        Return c + 1



        'For i = 0 To dgvEntregas.RowCount - 1
        '    For j = 0 To DataGridView1.RowCount - 1
        '        ':::Realizamos la validación de cada celda
        '        If DataGridView1.Rows(j).Cells(0).Value = dgvEntregas.Rows(i).Cells(0).Value Then
        '            ':::Pintamos de color azul las que son iguales
        '            Return c + 2
        '            ':::Aumentamos nuestro contador en 1
        '        Else
        '            Return c + 1
        '        End If
        '    Next
        'Next

    End Function

    Private Sub dgvEntregas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntregas.CellContentClick


        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvEntregas.Rows(e.RowIndex)

            '            Select Case entregas.id_entrega As id_entrega,
            '    entregas.fecha_entrega as fecha_entrega,
            'Paquetes.remitente As nombre_remitente,
            '    'ID : '||paquetes.id_paquete||' Contenido: '||paquetes.contenido as Informacion_Paquete,
            '                empleados.nombre||' '||empleados.paterno||' '||empleados.materno as nombre_empleado
            'From ENTREGAS, empleados, paquetes Where ENTREGAS.id_paquete = paquetes.id_paquete And
            '      ENTREGAS.id_empleado = empleados.id_empleado


            TextBox2.Text = row.Cells("nombre_remitente").Value.ToString
            txtID.Text = row.Cells("ID_Entrega").Value.ToString
            ComboBox1.Text = row.Cells("nombre_empleado").Value.ToString
            ComboBoxPaquete.Text = row.Cells("Informacion_Paquete").Value.ToString





        End If
    End Sub
    Private Sub ComboBoxPaquete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPaquete.SelectionChangeCommitted

        Dim xCnx As New Oracle
        Dim nm As String = "SELECT remitente from paquetes WHERE id_paquete=" & ComboBoxPaquete.SelectedValue

        Dim c As String = xCnx.objetoScalar(nm)
        TextBox2.Text = c


    End Sub


End Class