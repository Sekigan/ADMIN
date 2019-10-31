Imports Oracle.DataAccess.Client

Public Class Login


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If IsNumeric(txt_user.Text) Then
            Dim Objlogin As New ClaseLogin(txt_user.Text, txt_pass.Text)
            If Objlogin.login() Then

                Main.Show()

                Me.Visible = False
                txt_user.Text = ""
                txt_pass.Text = ""
            Else
                Label1.Visible = True
            End If
        Else
            Label1.Visible = True
        End If

    End Sub



    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        Application.Exit()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CrearUsuarioLOGIN.Show()
        Me.Enabled = False

    End Sub
    Private Sub SoloNumerosSinPuntos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_user.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class
