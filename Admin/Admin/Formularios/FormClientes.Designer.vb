<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbUsr = New System.Windows.Forms.GroupBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNcasa = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Textemail = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBoxSex = New System.Windows.Forms.ComboBox()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtRFC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.ComboBoxCo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCiudad = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEstad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxPais = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtConfirmar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbUsr.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.dgvClientes)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.gbUsr)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1211, 970)
        Me.Panel1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 15.75!)
        Me.Label12.Location = New System.Drawing.Point(398, -33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 27)
        Me.Label12.TabIndex = 117
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
        Me.Button2.Location = New System.Drawing.Point(635, 615)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAgregar.BackColor = System.Drawing.Color.Silver
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Location = New System.Drawing.Point(544, 615)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
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
        Me.Button3.Location = New System.Drawing.Point(818, 615)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 20
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
        Me.btneliminar.Location = New System.Drawing.Point(725, 615)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 19
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToOrderColumns = True
        Me.dgvClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(534, 82)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.Size = New System.Drawing.Size(614, 495)
        Me.dgvClientes.TabIndex = 109
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
        Me.btnCancelar.Location = New System.Drawing.Point(1057, 657)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'gbUsr
        '
        Me.gbUsr.Controls.Add(Me.TxtEdad)
        Me.gbUsr.Controls.Add(Me.Label5)
        Me.gbUsr.Controls.Add(Me.TxtNcasa)
        Me.gbUsr.Controls.Add(Me.Label19)
        Me.gbUsr.Controls.Add(Me.TxtCalle)
        Me.gbUsr.Controls.Add(Me.Label18)
        Me.gbUsr.Controls.Add(Me.TxtTel)
        Me.gbUsr.Controls.Add(Me.Label17)
        Me.gbUsr.Controls.Add(Me.Textemail)
        Me.gbUsr.Controls.Add(Me.Label16)
        Me.gbUsr.Controls.Add(Me.Label15)
        Me.gbUsr.Controls.Add(Me.ComboBoxSex)
        Me.gbUsr.Controls.Add(Me.TxtCurp)
        Me.gbUsr.Controls.Add(Me.Label14)
        Me.gbUsr.Controls.Add(Me.TxtRFC)
        Me.gbUsr.Controls.Add(Me.Label13)
        Me.gbUsr.Controls.Add(Me.Label1)
        Me.gbUsr.Controls.Add(Me.Label2)
        Me.gbUsr.Controls.Add(Me.txtNombre)
        Me.gbUsr.Controls.Add(Me.Label3)
        Me.gbUsr.Controls.Add(Me.txtPaterno)
        Me.gbUsr.Controls.Add(Me.Label4)
        Me.gbUsr.Controls.Add(Me.txtIdCliente)
        Me.gbUsr.Controls.Add(Me.txtMaterno)
        Me.gbUsr.Controls.Add(Me.ComboBoxCo)
        Me.gbUsr.Controls.Add(Me.ComboBoxCiudad)
        Me.gbUsr.Controls.Add(Me.ComboBoxEstad)
        Me.gbUsr.Controls.Add(Me.Label7)
        Me.gbUsr.Controls.Add(Me.ComboBoxPais)
        Me.gbUsr.Controls.Add(Me.Label8)
        Me.gbUsr.Controls.Add(Me.txtConfirmar)
        Me.gbUsr.Controls.Add(Me.Label9)
        Me.gbUsr.Controls.Add(Me.Label11)
        Me.gbUsr.Controls.Add(Me.Label10)
        Me.gbUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbUsr.Location = New System.Drawing.Point(70, 69)
        Me.gbUsr.Name = "gbUsr"
        Me.gbUsr.Size = New System.Drawing.Size(324, 593)
        Me.gbUsr.TabIndex = 115
        Me.gbUsr.TabStop = False
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(144, 245)
        Me.TxtEdad.MaxLength = 2
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(157, 20)
        Me.TxtEdad.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Edad*"
        '
        'TxtNcasa
        '
        Me.TxtNcasa.Location = New System.Drawing.Point(144, 568)
        Me.TxtNcasa.MaxLength = 4
        Me.TxtNcasa.Name = "TxtNcasa"
        Me.TxtNcasa.Size = New System.Drawing.Size(157, 20)
        Me.TxtNcasa.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(22, 568)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 13)
        Me.Label19.TabIndex = 95
        Me.Label19.Text = "N° de la casa"
        '
        'TxtCalle
        '
        Me.TxtCalle.Location = New System.Drawing.Point(144, 528)
        Me.TxtCalle.MaxLength = 30
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(157, 20)
        Me.TxtCalle.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(22, 528)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 93
        Me.Label18.Text = "Calle"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(144, 344)
        Me.TxtTel.MaxLength = 10
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(157, 20)
        Me.TxtTel.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 344)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 91
        Me.Label17.Text = "Telefono"
        '
        'Textemail
        '
        Me.Textemail.Location = New System.Drawing.Point(144, 308)
        Me.Textemail.MaxLength = 60
        Me.Textemail.Name = "Textemail"
        Me.Textemail.Size = New System.Drawing.Size(157, 20)
        Me.Textemail.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(22, 308)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "email"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(22, 272)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 13)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "Sex"
        '
        'ComboBoxSex
        '
        Me.ComboBoxSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSex.FormattingEnabled = True
        Me.ComboBoxSex.Location = New System.Drawing.Point(144, 271)
        Me.ComboBoxSex.Name = "ComboBoxSex"
        Me.ComboBoxSex.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxSex.TabIndex = 8
        '
        'TxtCurp
        '
        Me.TxtCurp.Location = New System.Drawing.Point(144, 211)
        Me.TxtCurp.MaxLength = 18
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.Size = New System.Drawing.Size(157, 20)
        Me.TxtCurp.TabIndex = 6
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
        'TxtRFC
        '
        Me.TxtRFC.Location = New System.Drawing.Point(144, 176)
        Me.TxtRFC.MaxLength = 13
        Me.TxtRFC.Name = "TxtRFC"
        Me.TxtRFC.Size = New System.Drawing.Size(157, 20)
        Me.TxtRFC.TabIndex = 5
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
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Id Cliente*"
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
        Me.txtNombre.TabIndex = 2
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
        Me.txtPaterno.TabIndex = 3
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
        'txtIdCliente
        '
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(144, 19)
        Me.txtIdCliente.MaxLength = 3
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.ReadOnly = True
        Me.txtIdCliente.Size = New System.Drawing.Size(157, 20)
        Me.txtIdCliente.TabIndex = 1
        '
        'txtMaterno
        '
        Me.txtMaterno.Location = New System.Drawing.Point(144, 139)
        Me.txtMaterno.MaxLength = 30
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(157, 20)
        Me.txtMaterno.TabIndex = 4
        '
        'ComboBoxCo
        '
        Me.ComboBoxCo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxCo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCo.FormattingEnabled = True
        Me.ComboBoxCo.Location = New System.Drawing.Point(144, 495)
        Me.ComboBoxCo.Name = "ComboBoxCo"
        Me.ComboBoxCo.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxCo.TabIndex = 14
        '
        'ComboBoxCiudad
        '
        Me.ComboBoxCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCiudad.FormattingEnabled = True
        Me.ComboBoxCiudad.Location = New System.Drawing.Point(144, 456)
        Me.ComboBoxCiudad.Name = "ComboBoxCiudad"
        Me.ComboBoxCiudad.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxCiudad.TabIndex = 13
        '
        'ComboBoxEstad
        '
        Me.ComboBoxEstad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxEstad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxEstad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEstad.FormattingEnabled = True
        Me.ComboBoxEstad.Location = New System.Drawing.Point(144, 417)
        Me.ComboBoxEstad.Name = "ComboBoxEstad"
        Me.ComboBoxEstad.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxEstad.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 382)
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
        Me.ComboBoxPais.Location = New System.Drawing.Point(144, 381)
        Me.ComboBoxPais.Name = "ComboBoxPais"
        Me.ComboBoxPais.Size = New System.Drawing.Size(157, 21)
        Me.ComboBoxPais.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 420)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Estado"
        '
        'txtConfirmar
        '
        Me.txtConfirmar.Location = New System.Drawing.Point(144, 646)
        Me.txtConfirmar.Name = "txtConfirmar"
        Me.txtConfirmar.Size = New System.Drawing.Size(157, 20)
        Me.txtConfirmar.TabIndex = 71
        Me.txtConfirmar.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Ciudad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 646)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Confirmar Contraseña"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 495)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Colonia"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(483, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 25)
        Me.Label6.TabIndex = 124
        Me.Label6.Text = "Clientes"
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1000, 970)
        Me.ClientSize = New System.Drawing.Size(1228, 615)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbUsr.ResumeLayout(False)
        Me.gbUsr.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents gbUsr As GroupBox
    Friend WithEvents TxtNcasa As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtCalle As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Textemail As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ComboBoxSex As ComboBox
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtRFC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents ComboBoxCo As ComboBox
    Friend WithEvents ComboBoxCiudad As ComboBox
    Friend WithEvents ComboBoxEstad As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxPais As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtConfirmar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
