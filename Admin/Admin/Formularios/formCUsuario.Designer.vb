<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formCUsuario
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbUsr = New System.Windows.Forms.GroupBox()
        Me.TxtAnteriorContra = New System.Windows.Forms.TextBox()
        Me.LabContraAnte = New System.Windows.Forms.Label()
        Me.txtnCa = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ChBoxCambiarContra = New System.Windows.Forms.CheckBox()
        Me.txtca = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txttef = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtemai = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBoxSex = New System.Windows.Forms.ComboBox()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.ComboBoxC = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxCiudad = New System.Windows.Forms.ComboBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.ComboBoxEstad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxPais = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtConfirmar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.gbUsr.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.gbUsr)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.dgvUsuarios)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1206, 970)
        Me.Panel1.TabIndex = 0
        '
        'gbUsr
        '
        Me.gbUsr.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gbUsr.Controls.Add(Me.TxtAnteriorContra)
        Me.gbUsr.Controls.Add(Me.LabContraAnte)
        Me.gbUsr.Controls.Add(Me.txtnCa)
        Me.gbUsr.Controls.Add(Me.Label19)
        Me.gbUsr.Controls.Add(Me.ChBoxCambiarContra)
        Me.gbUsr.Controls.Add(Me.txtca)
        Me.gbUsr.Controls.Add(Me.Label18)
        Me.gbUsr.Controls.Add(Me.txttef)
        Me.gbUsr.Controls.Add(Me.Label17)
        Me.gbUsr.Controls.Add(Me.txtemai)
        Me.gbUsr.Controls.Add(Me.Label16)
        Me.gbUsr.Controls.Add(Me.Label15)
        Me.gbUsr.Controls.Add(Me.ComboBoxSex)
        Me.gbUsr.Controls.Add(Me.TxtCurp)
        Me.gbUsr.Controls.Add(Me.Label14)
        Me.gbUsr.Controls.Add(Me.txtRFC)
        Me.gbUsr.Controls.Add(Me.Label13)
        Me.gbUsr.Controls.Add(Me.Label1)
        Me.gbUsr.Controls.Add(Me.Label2)
        Me.gbUsr.Controls.Add(Me.txtNombre)
        Me.gbUsr.Controls.Add(Me.Label3)
        Me.gbUsr.Controls.Add(Me.txtPaterno)
        Me.gbUsr.Controls.Add(Me.Label4)
        Me.gbUsr.Controls.Add(Me.txtId)
        Me.gbUsr.Controls.Add(Me.txtMaterno)
        Me.gbUsr.Controls.Add(Me.ComboBoxC)
        Me.gbUsr.Controls.Add(Me.Label6)
        Me.gbUsr.Controls.Add(Me.ComboBoxCiudad)
        Me.gbUsr.Controls.Add(Me.txtContraseña)
        Me.gbUsr.Controls.Add(Me.ComboBoxEstad)
        Me.gbUsr.Controls.Add(Me.Label7)
        Me.gbUsr.Controls.Add(Me.ComboBoxPais)
        Me.gbUsr.Controls.Add(Me.Label8)
        Me.gbUsr.Controls.Add(Me.txtConfirmar)
        Me.gbUsr.Controls.Add(Me.Label9)
        Me.gbUsr.Controls.Add(Me.Label11)
        Me.gbUsr.Controls.Add(Me.Label10)
        Me.gbUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbUsr.Location = New System.Drawing.Point(60, 77)
        Me.gbUsr.Name = "gbUsr"
        Me.gbUsr.Size = New System.Drawing.Size(331, 696)
        Me.gbUsr.TabIndex = 109
        Me.gbUsr.TabStop = False
        '
        'TxtAnteriorContra
        '
        Me.TxtAnteriorContra.Location = New System.Drawing.Point(140, 659)
        Me.TxtAnteriorContra.Name = "TxtAnteriorContra"
        Me.TxtAnteriorContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtAnteriorContra.Size = New System.Drawing.Size(161, 20)
        Me.TxtAnteriorContra.TabIndex = 98
        '
        'LabContraAnte
        '
        Me.LabContraAnte.AutoSize = True
        Me.LabContraAnte.Location = New System.Drawing.Point(15, 662)
        Me.LabContraAnte.Name = "LabContraAnte"
        Me.LabContraAnte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabContraAnte.Size = New System.Drawing.Size(100, 13)
        Me.LabContraAnte.TabIndex = 99
        Me.LabContraAnte.Text = "Contraseña Anterior"
        '
        'txtnCa
        '
        Me.txtnCa.Location = New System.Drawing.Point(144, 544)
        Me.txtnCa.MaxLength = 4
        Me.txtnCa.Name = "txtnCa"
        Me.txtnCa.Size = New System.Drawing.Size(157, 20)
        Me.txtnCa.TabIndex = 96
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 546)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 13)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "N° de Casa"
        '
        'ChBoxCambiarContra
        '
        Me.ChBoxCambiarContra.AutoSize = True
        Me.ChBoxCambiarContra.Location = New System.Drawing.Point(21, 638)
        Me.ChBoxCambiarContra.Name = "ChBoxCambiarContra"
        Me.ChBoxCambiarContra.Size = New System.Drawing.Size(115, 17)
        Me.ChBoxCambiarContra.TabIndex = 97
        Me.ChBoxCambiarContra.Text = "Nueva Contraseña"
        Me.ChBoxCambiarContra.UseVisualStyleBackColor = True
        '
        'txtca
        '
        Me.txtca.Location = New System.Drawing.Point(144, 506)
        Me.txtca.MaxLength = 30
        Me.txtca.Name = "txtca"
        Me.txtca.Size = New System.Drawing.Size(157, 20)
        Me.txtca.TabIndex = 94
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 506)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 93
        Me.Label18.Text = "Calle"
        '
        'txttef
        '
        Me.txttef.Location = New System.Drawing.Point(144, 318)
        Me.txttef.Name = "txttef"
        Me.txttef.Size = New System.Drawing.Size(157, 20)
        Me.txttef.TabIndex = 92
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 318)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 91
        Me.Label17.Text = "Telefono"
        '
        'txtemai
        '
        Me.txtemai.Location = New System.Drawing.Point(144, 282)
        Me.txtemai.MaxLength = 60
        Me.txtemai.Name = "txtemai"
        Me.txtemai.Size = New System.Drawing.Size(157, 20)
        Me.txtemai.TabIndex = 90
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 282)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Correo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 247)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Sexo*"
        '
        'ComboBoxSex
        '
        Me.ComboBoxSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSex.FormattingEnabled = True
        Me.ComboBoxSex.Location = New System.Drawing.Point(144, 246)
        Me.ComboBoxSex.Name = "ComboBoxSex"
        Me.ComboBoxSex.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxSex.TabIndex = 87
        '
        'TxtCurp
        '
        Me.TxtCurp.Location = New System.Drawing.Point(144, 211)
        Me.TxtCurp.MaxLength = 18
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.Size = New System.Drawing.Size(157, 20)
        Me.TxtCurp.TabIndex = 86
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "CURP*"
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(144, 176)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(157, 20)
        Me.txtRFC.TabIndex = 84
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "RFC*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Id Usuario*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Nombre*"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(144, 59)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(157, 20)
        Me.txtNombre.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Apellido Paterno*"
        '
        'txtPaterno
        '
        Me.txtPaterno.Location = New System.Drawing.Point(144, 99)
        Me.txtPaterno.MaxLength = 30
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(157, 20)
        Me.txtPaterno.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Apellido Materno*"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(144, 19)
        Me.txtId.MaxLength = 3
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(157, 20)
        Me.txtId.TabIndex = 51
        '
        'txtMaterno
        '
        Me.txtMaterno.Location = New System.Drawing.Point(144, 139)
        Me.txtMaterno.MaxLength = 30
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(157, 20)
        Me.txtMaterno.TabIndex = 57
        '
        'ComboBoxC
        '
        Me.ComboBoxC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxC.FormattingEnabled = True
        Me.ComboBoxC.Location = New System.Drawing.Point(144, 469)
        Me.ComboBoxC.Name = "ComboBoxC"
        Me.ComboBoxC.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxC.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 577)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Contraseña"
        '
        'ComboBoxCiudad
        '
        Me.ComboBoxCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCiudad.FormattingEnabled = True
        Me.ComboBoxCiudad.Location = New System.Drawing.Point(144, 430)
        Me.ComboBoxCiudad.Name = "ComboBoxCiudad"
        Me.ComboBoxCiudad.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxCiudad.TabIndex = 63
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(144, 577)
        Me.txtContraseña.MaxLength = 20
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(161, 20)
        Me.txtContraseña.TabIndex = 69
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'ComboBoxEstad
        '
        Me.ComboBoxEstad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxEstad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxEstad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstad.FormattingEnabled = True
        Me.ComboBoxEstad.Location = New System.Drawing.Point(144, 391)
        Me.ComboBoxEstad.Name = "ComboBoxEstad"
        Me.ComboBoxEstad.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxEstad.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Pais"
        '
        'ComboBoxPais
        '
        Me.ComboBoxPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPais.FormattingEnabled = True
        Me.ComboBoxPais.Location = New System.Drawing.Point(144, 355)
        Me.ComboBoxPais.Name = "ComboBoxPais"
        Me.ComboBoxPais.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxPais.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Estado"
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Location = New System.Drawing.Point(144, 610)
        Me.txtConfirmar.MaxLength = 20
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.Size = New System.Drawing.Size(161, 20)
        Me.txtConfirmar.TabIndex = 71
        Me.txtConfirmar.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 430)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Ciudad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 613)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Confirmar Contraseña"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 469)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Colonia"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 15.75!)
        Me.Label12.Location = New System.Drawing.Point(432, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 27)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Crear Usuario"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(839, 613)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 23)
        Me.Button2.TabIndex = 103
        Me.Button2.Text = "Editar "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.BackColor = System.Drawing.Color.Silver
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(539, 613)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 102
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(730, 615)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 105
        Me.Button3.Text = "Limpiar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btneliminar
        '
        Me.btneliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btneliminar.BackColor = System.Drawing.Color.Silver
        Me.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btneliminar.FlatAppearance.BorderSize = 0
        Me.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btneliminar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.Black
        Me.btneliminar.Location = New System.Drawing.Point(631, 615)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 104
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AllowUserToOrderColumns = True
        Me.dgvUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUsuarios.Location = New System.Drawing.Point(478, 77)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvUsuarios.Size = New System.Drawing.Size(671, 500)
        Me.dgvUsuarios.TabIndex = 100
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancelar.BackColor = System.Drawing.Color.Silver
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Location = New System.Drawing.Point(999, 665)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 107
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'formCUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1200, 970)
        Me.ClientSize = New System.Drawing.Size(1223, 460)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formCUsuario"
        Me.Text = "formCUsuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbUsr.ResumeLayout(False)
        Me.gbUsr.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents gbUsr As GroupBox
    Friend WithEvents txtnCa As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtca As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txttef As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtemai As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBoxSex As ComboBox
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents ComboBoxC As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxCiudad As ComboBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents ComboBoxEstad As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxPais As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtConfirmar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtAnteriorContra As TextBox
    Friend WithEvents LabContraAnte As Label
    Friend WithEvents ChBoxCambiarContra As CheckBox
End Class
