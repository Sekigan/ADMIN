<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label_user = New System.Windows.Forms.Label()
        Me.Label_pass = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(116, 232)
        Me.txt_user.MaxLength = 3
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(168, 20)
        Me.txt_user.TabIndex = 0
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(116, 305)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(168, 20)
        Me.txt_pass.TabIndex = 1
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(49, 350)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 2
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(255, 350)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "&Cancelar"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label_user
        '
        Me.Label_user.AutoSize = True
        Me.Label_user.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_user.Location = New System.Drawing.Point(116, 198)
        Me.Label_user.Name = "Label_user"
        Me.Label_user.Size = New System.Drawing.Size(85, 19)
        Me.Label_user.TabIndex = 4
        Me.Label_user.Text = "ID Usuario"
        '
        'Label_pass
        '
        Me.Label_pass.AutoSize = True
        Me.Label_pass.Font = New System.Drawing.Font("Microsoft JhengHei", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label_pass.Location = New System.Drawing.Point(113, 274)
        Me.Label_pass.Name = "Label_pass"
        Me.Label_pass.Size = New System.Drawing.Size(91, 19)
        Me.Label_pass.TabIndex = 5
        Me.Label_pass.Text = "Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Admin.My.Resources.Resources._69011
        Me.PictureBox1.Location = New System.Drawing.Point(49, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Contraseña O Usuario invalidos"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(151, 255)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Crear un Usuario"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label_pass)
        Me.Controls.Add(Me.Label_user)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_user As TextBox
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label_user As Label
    Friend WithEvents Label_pass As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
