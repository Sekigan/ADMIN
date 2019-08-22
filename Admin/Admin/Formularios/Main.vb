Imports System.Runtime.InteropServices

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnUser.Text = LOGINNOMBRE

    End Sub

#Region "Botones Cerrar,Minimizar, etc"

    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.PanelContenedor.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(244, 244, 244))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub

    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()


    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
#End Region
    'METODO DE ABRIR FORMULARIO
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelForm.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion
        'Si form no fue econtrado/ no existe
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelForm.Controls.Add(Formulario)
            PanelForm.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    'METODO/EVENTO AL CERRAR FORMS
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        'CONDICION SI FORMS ESTA ABIERTO
        If Application.OpenForms("FormPaquetes") Is Nothing Then
            btnPaquetes.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If Application.OpenForms("FormCientes") Is Nothing Then
            btnCientes.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If Application.OpenForms("FormBuscarPaquete") Is Nothing Then
            btnBuscarPaquete.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If Application.OpenForms("FormEntregas") Is Nothing Then
            btnEntregas.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If Application.OpenForms("FormDev") Is Nothing Then
            btnDEV.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If Application.OpenForms("Ubicaciones") Is Nothing Then
            btnUbi.BackColor = Color.FromArgb(4, 41, 68)
        End If
        If Application.OpenForms("formCUsuario") Is Nothing Then
            btnUser.BackColor = Color.FromArgb(4, 41, 68)
        End If
    End Sub






    Private Sub btnBuscarPaquete_Click(sender As Object, e As EventArgs) Handles btnBuscarPaquete.Click
        AbrirFormEnPanel(Of FormBuscarPaquete)()
        btnBuscarPaquete.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        AbrirFormEnPanel(Of formCUsuario)()
        btnUser.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnCientes_Click(sender As Object, e As EventArgs) Handles btnCientes.Click
        AbrirFormEnPanel(Of FormClientes)()
        btnCientes.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnPaquetes_Click(sender As Object, e As EventArgs) Handles btnPaquetes.Click
        AbrirFormEnPanel(Of FormPaquetes)()
        btnPaquetes.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnUbi_Click(sender As Object, e As EventArgs) Handles btnUbi.Click
        AbrirFormEnPanel(Of Ubicaciones)()
        btnUbi.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnDEV_Click(sender As Object, e As EventArgs) Handles btnDEV.Click
        AbrirFormEnPanel(Of FormDev)()
        btnDEV.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnEntregas_Click(sender As Object, e As EventArgs) Handles btnEntregas.Click
        AbrirFormEnPanel(Of FormEntregas)()
        btnEntregas.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If MessageBox.Show("Seguro que quiere cerrar sesion?", "CONFIRMAR", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            Me.Close()
            Login.Show()
        End If
    End Sub
End Class