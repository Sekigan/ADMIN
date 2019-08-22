<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LOGO = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnDEV = New System.Windows.Forms.Button()
        Me.btnEntregas = New System.Windows.Forms.Button()
        Me.btnCientes = New System.Windows.Forms.Button()
        Me.btnUbi = New System.Windows.Forms.Button()
        Me.btnBuscarPaquete = New System.Windows.Forms.Button()
        Me.btnPaquetes = New System.Windows.Forms.Button()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelForm.SuspendLayout()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelForm)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1076, 600)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Controls.Add(Me.LOGO)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Location = New System.Drawing.Point(200, 40)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(876, 560)
        Me.PanelForm.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(370, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PAQUETES TUR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LOGO
        '
        Me.LOGO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LOGO.Image = Global.Admin.My.Resources.Resources._69011
        Me.LOGO.Location = New System.Drawing.Point(150, 47)
        Me.LOGO.Name = "LOGO"
        Me.LOGO.Size = New System.Drawing.Size(621, 290)
        Me.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LOGO.TabIndex = 0
        Me.LOGO.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnUser)
        Me.PanelMenu.Controls.Add(Me.btnDEV)
        Me.PanelMenu.Controls.Add(Me.btnEntregas)
        Me.PanelMenu.Controls.Add(Me.btnCientes)
        Me.PanelMenu.Controls.Add(Me.btnUbi)
        Me.PanelMenu.Controls.Add(Me.btnBuscarPaquete)
        Me.PanelMenu.Controls.Add(Me.btnPaquetes)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 560)
        Me.PanelMenu.TabIndex = 1
        '
        'btnUser
        '
        Me.btnUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(3, 496)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(200, 61)
        Me.btnUser.TabIndex = 9
        Me.btnUser.Text = "Usuarios"
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnDEV
        '
        Me.btnDEV.FlatAppearance.BorderSize = 0
        Me.btnDEV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnDEV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnDEV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDEV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDEV.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnDEV.Image = CType(resources.GetObject("btnDEV.Image"), System.Drawing.Image)
        Me.btnDEV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDEV.Location = New System.Drawing.Point(3, 324)
        Me.btnDEV.Name = "btnDEV"
        Me.btnDEV.Size = New System.Drawing.Size(200, 75)
        Me.btnDEV.TabIndex = 5
        Me.btnDEV.Text = "Paquetes Devueltos"
        Me.btnDEV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDEV.UseVisualStyleBackColor = True
        '
        'btnEntregas
        '
        Me.btnEntregas.FlatAppearance.BorderSize = 0
        Me.btnEntregas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnEntregas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnEntregas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregas.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnEntregas.Image = CType(resources.GetObject("btnEntregas.Image"), System.Drawing.Image)
        Me.btnEntregas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntregas.Location = New System.Drawing.Point(3, 248)
        Me.btnEntregas.Name = "btnEntregas"
        Me.btnEntregas.Size = New System.Drawing.Size(197, 70)
        Me.btnEntregas.TabIndex = 4
        Me.btnEntregas.Text = "Paquetes Entregados"
        Me.btnEntregas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEntregas.UseVisualStyleBackColor = True
        '
        'btnCientes
        '
        Me.btnCientes.FlatAppearance.BorderSize = 0
        Me.btnCientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnCientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnCientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCientes.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnCientes.Image = CType(resources.GetObject("btnCientes.Image"), System.Drawing.Image)
        Me.btnCientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCientes.Location = New System.Drawing.Point(0, 121)
        Me.btnCientes.Name = "btnCientes"
        Me.btnCientes.Size = New System.Drawing.Size(200, 56)
        Me.btnCientes.TabIndex = 3
        Me.btnCientes.Text = "Clientes"
        Me.btnCientes.UseVisualStyleBackColor = True
        '
        'btnUbi
        '
        Me.btnUbi.FlatAppearance.BorderSize = 0
        Me.btnUbi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnUbi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnUbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUbi.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnUbi.Image = CType(resources.GetObject("btnUbi.Image"), System.Drawing.Image)
        Me.btnUbi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUbi.Location = New System.Drawing.Point(0, 405)
        Me.btnUbi.Name = "btnUbi"
        Me.btnUbi.Size = New System.Drawing.Size(200, 61)
        Me.btnUbi.TabIndex = 2
        Me.btnUbi.Text = "Agregar Ubicaciones"
        Me.btnUbi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUbi.UseVisualStyleBackColor = True
        '
        'btnBuscarPaquete
        '
        Me.btnBuscarPaquete.FlatAppearance.BorderSize = 0
        Me.btnBuscarPaquete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnBuscarPaquete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnBuscarPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPaquete.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnBuscarPaquete.Image = CType(resources.GetObject("btnBuscarPaquete.Image"), System.Drawing.Image)
        Me.btnBuscarPaquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarPaquete.Location = New System.Drawing.Point(0, 186)
        Me.btnBuscarPaquete.Name = "btnBuscarPaquete"
        Me.btnBuscarPaquete.Size = New System.Drawing.Size(200, 56)
        Me.btnBuscarPaquete.TabIndex = 1
        Me.btnBuscarPaquete.Text = "Buscar Paquete"
        Me.btnBuscarPaquete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarPaquete.UseVisualStyleBackColor = True
        '
        'btnPaquetes
        '
        Me.btnPaquetes.FlatAppearance.BorderSize = 0
        Me.btnPaquetes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnPaquetes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnPaquetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaquetes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaquetes.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnPaquetes.Image = CType(resources.GetObject("btnPaquetes.Image"), System.Drawing.Image)
        Me.btnPaquetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaquetes.Location = New System.Drawing.Point(3, 46)
        Me.btnPaquetes.Name = "btnPaquetes"
        Me.btnPaquetes.Size = New System.Drawing.Size(194, 69)
        Me.btnPaquetes.TabIndex = 0
        Me.btnPaquetes.Text = "Paquetes"
        Me.btnPaquetes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPaquetes.UseVisualStyleBackColor = True
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.Label2)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1076, 40)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(865, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cerrar Sesion"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(992, 12)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(20, 20)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(1018, 12)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(20, 20)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1044, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 20)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 600)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(750, 600)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        CType(Me.LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnDEV As Button
    Friend WithEvents btnEntregas As Button
    Friend WithEvents btnCientes As Button
    Friend WithEvents btnUbi As Button
    Friend WithEvents btnBuscarPaquete As Button
    Friend WithEvents btnPaquetes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LOGO As PictureBox
    Friend WithEvents btnUser As Button
    Friend WithEvents Label2 As Label
End Class
