Public Class FormDev
    Dim met As New Metodos
    Private Sub FormDev_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIDDev.Text = contar()
        muestra(dgvDev, "Select devoluciones.id_devolucion as id_devolucion,
	devoluciones.fecha_devolucion as Fecha_devolucion,
	devoluciones.motivo as Motivo_devolucion,
	'ID: '||paquetes.id_paquete||' CONTENIDO: '||paquetes.contenido as Informacion_paquete
from DEVOLUCIONES, paquetes
where devoluciones.id_paquete = paquetes.id_paquete")
        poblarComboBox(ComboBoxPaquetes, "SELECT paquetes.id_paquete, id_paquete||'.- '||Contenido AS NOMBRE FROM  paquetes order by ID_paquete", "id_paquete", "nombre")
        datedev.MinDate = Today
        poblarComboBox(ComboBox1, "SELECT empleados.id_empleado, NOMBRE||' '||PATERNO||' '||MATERNO AS NOMBRE FROM  empleados order by ID_empleado", "id_empleado", "nombre")
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtMotivo.Text = txtMotivo.Text.Trim
        Dim dd As Integer = datedev.Value.Day
        Dim mm As Integer = datedev.Value.Month.ToString
        Dim yy As Integer = datedev.Value.Year
        Dim fecha1 As String = dd & "/" & "0" & mm & "/" & yy

        If txtMotivo.Text = "" Then
            MessageBox.Show("Falta capturar datos")
            txtMotivo.Focus()
        End If
        If Existe(ComboBoxPaquetes.SelectedValue) Then
            Try
                Dim delete As String = "delete from entregas where ID_Paquete=" & ComboBoxPaquetes.SelectedValue
                met.realizarQuery(delete)
                MsgBox("PAQUETE DE ENTREGADO A DEVUELTO", vbInformation)
            Catch er As Exception
                MsgBox("ERROR", vbInformation)
            End Try
        End If

        If Not Existe1(ComboBoxPaquetes.SelectedValue) Then
            Try
                Dim insert As String = "Insert into devoluciones values(" & txtIDDev.Text & "," & ComboBoxPaquetes.SelectedValue & "," & ComboBox1.SelectedValue & ",'" & fecha1 & "','" & txtMotivo.Text & "')"
                met.realizarQuery(insert)
            Catch ex As Exception
                MsgBox("Verifica bien la informacion", vbInformation)
            End Try
        Else
            MsgBox("PAQUETE DEVUELTO..")
        End If
        muestra(dgvDev, "Select devoluciones.id_devolucion as id_devolucion,
	devoluciones.fecha_devolucion as Fecha_devolucion,
	devoluciones.motivo as Motivo_devolucion,
	'ID: '||paquetes.id_paquete||' CONTENIDO: '||paquetes.contenido as Informacion_paquete
from DEVOLUCIONES, paquetes
where devoluciones.id_paquete = paquetes.id_paquete")
        txtIDDev.Text = contar()

    End Sub
    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Try
            Dim delete As String = "Delete from devoluciones where ID_DEVOLUCION=" & txtIDDev.Text
            met.realizarQuery(delete)
        Catch ex As Exception
            MsgBox("Verifica la informacion", vbInformation)
        End Try
        muestra(dgvDev, "Select devoluciones.id_devolucion as id_devolucion,
	devoluciones.fecha_devolucion as Fecha_devolucion,
	devoluciones.motivo as Motivo_devolucion,
	'ID: '||paquetes.id_paquete||' CONTENIDO: '||paquetes.contenido as Informacion_paquete
from DEVOLUCIONES, paquetes
where devoluciones.id_paquete = paquetes.id_paquete")
        txtIDDev.Text = contar()
    End Sub

    Private Sub dgvDev_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDev.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgvDev.Rows(e.RowIndex)

            ComboBoxPaquetes.Text = row.Cells("Informacion_paquete").Value.ToString
            txtIDDev.Text = row.Cells("id_devolucion").Value.ToString
            txtMotivo.Text = row.Cells("Motivo_devolucion").Value.ToString

        End If
    End Sub



    Private Sub Ver_Click_1(sender As Object, e As EventArgs) Handles Ver.Click
        muestra(dgvDev, "Select devoluciones.id_devolucion as id_devolucion,
	devoluciones.fecha_devolucion as Fecha_devolucion,
	devoluciones.motivo as Motivo_devolucion,
	'ID: '||paquetes.id_paquete||' CONTENIDO: '||paquetes.contenido as Informacion_paquete
from DEVOLUCIONES, paquetes
where devoluciones.id_paquete = paquetes.id_paquete")
        txtIDDev.Text = contar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dd As Integer = datedev.Value.Day
        Dim mm As Integer = datedev.Value.Month.ToString
        Dim yy As Integer = datedev.Value.Year
        Dim fecha1 As String = dd & "/" & "0" & mm & "/" & yy
        Try
            Dim up As String = "update devoluciones set id_devolucion=" & txtIDDev.Text & ",id_paquete=" & ComboBoxPaquetes.SelectedValue & ",id_empleado=" & ComboBox1.SelectedValue & ",fecha_devolucion='" & fecha1 & "',motivo='" & txtMotivo.Text & "'where id_devolucion=" & txtIDDev.Text
            met.realizarQuery(up)
            MsgBox("DEV ACTUALIZADA")
        Catch er As Exception
            MsgBox("Verifica inf", vbInformation)
        End Try
        muestra(dgvDev, "Select devoluciones.id_devolucion as id_devolucion,
	devoluciones.fecha_devolucion as Fecha_devolucion,
	devoluciones.motivo as Motivo_devolucion,
	'ID: '||paquetes.id_paquete||' CONTENIDO: '||paquetes.contenido as Informacion_paquete
from DEVOLUCIONES, paquetes
where devoluciones.id_paquete = paquetes.id_paquete")
        txtIDDev.Text = contar()
    End Sub

    Public Function Existe(ByVal id As Integer) As Boolean

        Dim xCnx As New Oracle

        Dim nm As String = "select ENTREGAS.ID_PAQUETE as ID_PAQUETE from	ENTREGAS ENTREGAS where ID_PAQUETE=" & ComboBoxPaquetes.SelectedValue



        Dim count As Integer = xCnx.objetoScalar(nm)
        If count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
    Public Function Existe1(ByVal id As Integer) As Boolean

        Dim xCnx As New Oracle

        Dim nm As String = "select DEVOLUCIONES.ID_DEVOLUCION as ID_DEVOLUCION from	DEVOLUCIONES where ID_PAQUETE=" & ComboBoxPaquetes.SelectedValue



        Dim count As Integer = xCnx.objetoScalar(nm)
        If count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function contar() As Double
        Dim xCnx As New Oracle
        Dim nm As String = "SELECT COUNT(*) FROM devoluciones"

        Dim c As Integer = xCnx.objetoScalar(nm)

        Return c + 1

    End Function


End Class