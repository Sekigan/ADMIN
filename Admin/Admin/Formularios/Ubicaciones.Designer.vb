<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ubicaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.dgvCol = New System.Windows.Forms.DataGridView()
        Me.dgvCi = New System.Windows.Forms.DataGridView()
        Me.dgvEdo = New System.Windows.Forms.DataGridView()
        Me.dgvPaises = New System.Windows.Forms.DataGridView()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.gbCol = New System.Windows.Forms.GroupBox()
        Me.txtID_CO = New System.Windows.Forms.TextBox()
        Me.txtnombreCO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CBoxCiudadesCol = New System.Windows.Forms.ComboBox()
        Me.CBoxEstadosCol = New System.Windows.Forms.ComboBox()
        Me.CBoxPaisesCol = New System.Windows.Forms.ComboBox()
        Me.btnAP = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.gbCiu = New System.Windows.Forms.GroupBox()
        Me.txtID_C = New System.Windows.Forms.TextBox()
        Me.txtNombreC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBoxEstadosCiudades = New System.Windows.Forms.ComboBox()
        Me.CBoxPaisCiudades = New System.Windows.Forms.ComboBox()
        Me.btnEP = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnElP = New System.Windows.Forms.Button()
        Me.gbEdo = New System.Windows.Forms.GroupBox()
        Me.txtID_E = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBoxPaisesE = New System.Windows.Forms.ComboBox()
        Me.gbPaises = New System.Windows.Forms.GroupBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtIdPais = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEdo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCol.SuspendLayout()
        Me.gbCiu.SuspendLayout()
        Me.gbEdo.SuspendLayout()
        Me.gbPaises.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.dgvCol)
        Me.Panel1.Controls.Add(Me.dgvCi)
        Me.Panel1.Controls.Add(Me.dgvEdo)
        Me.Panel1.Controls.Add(Me.dgvPaises)
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.gbCol)
        Me.Panel1.Controls.Add(Me.btnAP)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.gbCiu)
        Me.Panel1.Controls.Add(Me.btnEP)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.btnElP)
        Me.Panel1.Controls.Add(Me.gbEdo)
        Me.Panel1.Controls.Add(Me.gbPaises)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 970)
        Me.Panel1.TabIndex = 2
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
        Me.btnCancelar.Location = New System.Drawing.Point(1058, 920)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 107
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(532, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 27)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Ubicaciones"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(469, 694)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 23)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "Ver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(469, 721)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 23)
        Me.Button2.TabIndex = 103
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(469, 748)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 23)
        Me.Button3.TabIndex = 104
        Me.Button3.Text = "Editar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button10.BackColor = System.Drawing.Color.Silver
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(469, 775)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(68, 23)
        Me.Button10.TabIndex = 105
        Me.Button10.Text = "Eliminar"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'dgvCol
        '
        Me.dgvCol.AllowUserToAddRows = False
        Me.dgvCol.AllowUserToDeleteRows = False
        Me.dgvCol.AllowUserToOrderColumns = True
        Me.dgvCol.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvCol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCol.BackgroundColor = System.Drawing.Color.White
        Me.dgvCol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCol.Location = New System.Drawing.Point(616, 656)
        Me.dgvCol.Name = "dgvCol"
        Me.dgvCol.ReadOnly = True
        Me.dgvCol.Size = New System.Drawing.Size(537, 204)
        Me.dgvCol.TabIndex = 101
        '
        'dgvCi
        '
        Me.dgvCi.AllowUserToAddRows = False
        Me.dgvCi.AllowUserToDeleteRows = False
        Me.dgvCi.AllowUserToOrderColumns = True
        Me.dgvCi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvCi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCi.BackgroundColor = System.Drawing.Color.White
        Me.dgvCi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCi.Location = New System.Drawing.Point(616, 438)
        Me.dgvCi.Name = "dgvCi"
        Me.dgvCi.ReadOnly = True
        Me.dgvCi.Size = New System.Drawing.Size(506, 172)
        Me.dgvCi.TabIndex = 100
        '
        'dgvEdo
        '
        Me.dgvEdo.AllowUserToAddRows = False
        Me.dgvEdo.AllowUserToDeleteRows = False
        Me.dgvEdo.AllowUserToOrderColumns = True
        Me.dgvEdo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvEdo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEdo.BackgroundColor = System.Drawing.Color.White
        Me.dgvEdo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEdo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEdo.Location = New System.Drawing.Point(616, 267)
        Me.dgvEdo.Name = "dgvEdo"
        Me.dgvEdo.ReadOnly = True
        Me.dgvEdo.Size = New System.Drawing.Size(437, 136)
        Me.dgvEdo.TabIndex = 99
        '
        'dgvPaises
        '
        Me.dgvPaises.AllowUserToAddRows = False
        Me.dgvPaises.AllowUserToDeleteRows = False
        Me.dgvPaises.AllowUserToOrderColumns = True
        Me.dgvPaises.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPaises.BackgroundColor = System.Drawing.Color.White
        Me.dgvPaises.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaises.Location = New System.Drawing.Point(616, 117)
        Me.dgvPaises.Name = "dgvPaises"
        Me.dgvPaises.ReadOnly = True
        Me.dgvPaises.Size = New System.Drawing.Size(375, 117)
        Me.dgvPaises.TabIndex = 98
        '
        'Button15
        '
        Me.Button15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button15.BackColor = System.Drawing.Color.Silver
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(469, 117)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(68, 23)
        Me.Button15.TabIndex = 81
        Me.Button15.Text = "Ver"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button14.BackColor = System.Drawing.Color.Silver
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(469, 257)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(68, 23)
        Me.Button14.TabIndex = 85
        Me.Button14.Text = "Ver"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button13.BackColor = System.Drawing.Color.Silver
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(469, 469)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(68, 23)
        Me.Button13.TabIndex = 89
        Me.Button13.Text = "Ver"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.BackColor = System.Drawing.Color.Silver
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(469, 496)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(68, 23)
        Me.Button7.TabIndex = 90
        Me.Button7.Text = "Agregar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(469, 284)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 23)
        Me.Button4.TabIndex = 86
        Me.Button4.Text = "Agregar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.BackColor = System.Drawing.Color.Silver
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(469, 523)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(68, 23)
        Me.Button8.TabIndex = 91
        Me.Button8.Text = "Editar"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'gbCol
        '
        Me.gbCol.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbCol.Controls.Add(Me.txtID_CO)
        Me.gbCol.Controls.Add(Me.txtnombreCO)
        Me.gbCol.Controls.Add(Me.Label15)
        Me.gbCol.Controls.Add(Me.Label14)
        Me.gbCol.Controls.Add(Me.Label13)
        Me.gbCol.Controls.Add(Me.Label12)
        Me.gbCol.Controls.Add(Me.Label11)
        Me.gbCol.Controls.Add(Me.CBoxCiudadesCol)
        Me.gbCol.Controls.Add(Me.CBoxEstadosCol)
        Me.gbCol.Controls.Add(Me.CBoxPaisesCol)
        Me.gbCol.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCol.Location = New System.Drawing.Point(93, 656)
        Me.gbCol.Name = "gbCol"
        Me.gbCol.Size = New System.Drawing.Size(334, 212)
        Me.gbCol.TabIndex = 97
        Me.gbCol.TabStop = False
        Me.gbCol.Text = "Colonias"
        '
        'txtID_CO
        '
        Me.txtID_CO.Location = New System.Drawing.Point(142, 27)
        Me.txtID_CO.Name = "txtID_CO"
        Me.txtID_CO.Size = New System.Drawing.Size(161, 20)
        Me.txtID_CO.TabIndex = 34
        '
        'txtnombreCO
        '
        Me.txtnombreCO.Location = New System.Drawing.Point(142, 60)
        Me.txtnombreCO.Name = "txtnombreCO"
        Me.txtnombreCO.Size = New System.Drawing.Size(161, 20)
        Me.txtnombreCO.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 16)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Pais"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 16)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Ciudad"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Colonia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Id de la Colonia"
        '
        'CBoxCiudadesCol
        '
        Me.CBoxCiudadesCol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CBoxCiudadesCol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBoxCiudadesCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxCiudadesCol.FormattingEnabled = True
        Me.CBoxCiudadesCol.Location = New System.Drawing.Point(142, 168)
        Me.CBoxCiudadesCol.Name = "CBoxCiudadesCol"
        Me.CBoxCiudadesCol.Size = New System.Drawing.Size(161, 24)
        Me.CBoxCiudadesCol.TabIndex = 27
        '
        'CBoxEstadosCol
        '
        Me.CBoxEstadosCol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CBoxEstadosCol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBoxEstadosCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxEstadosCol.FormattingEnabled = True
        Me.CBoxEstadosCol.Location = New System.Drawing.Point(142, 132)
        Me.CBoxEstadosCol.Name = "CBoxEstadosCol"
        Me.CBoxEstadosCol.Size = New System.Drawing.Size(161, 24)
        Me.CBoxEstadosCol.TabIndex = 26
        '
        'CBoxPaisesCol
        '
        Me.CBoxPaisesCol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CBoxPaisesCol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBoxPaisesCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxPaisesCol.FormattingEnabled = True
        Me.CBoxPaisesCol.Location = New System.Drawing.Point(142, 96)
        Me.CBoxPaisesCol.Name = "CBoxPaisesCol"
        Me.CBoxPaisesCol.Size = New System.Drawing.Size(161, 24)
        Me.CBoxPaisesCol.TabIndex = 25
        '
        'btnAP
        '
        Me.btnAP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAP.BackColor = System.Drawing.Color.Silver
        Me.btnAP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAP.FlatAppearance.BorderSize = 0
        Me.btnAP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAP.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAP.Location = New System.Drawing.Point(469, 145)
        Me.btnAP.Name = "btnAP"
        Me.btnAP.Size = New System.Drawing.Size(68, 23)
        Me.btnAP.TabIndex = 82
        Me.btnAP.Text = "Agregar"
        Me.btnAP.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.BackColor = System.Drawing.Color.Silver
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(469, 550)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(68, 23)
        Me.Button9.TabIndex = 92
        Me.Button9.Text = "Eliminar"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(469, 311)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(68, 23)
        Me.Button5.TabIndex = 87
        Me.Button5.Text = "Editar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'gbCiu
        '
        Me.gbCiu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbCiu.Controls.Add(Me.txtID_C)
        Me.gbCiu.Controls.Add(Me.txtNombreC)
        Me.gbCiu.Controls.Add(Me.Label10)
        Me.gbCiu.Controls.Add(Me.Label9)
        Me.gbCiu.Controls.Add(Me.Label8)
        Me.gbCiu.Controls.Add(Me.Label7)
        Me.gbCiu.Controls.Add(Me.CBoxEstadosCiudades)
        Me.gbCiu.Controls.Add(Me.CBoxPaisCiudades)
        Me.gbCiu.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCiu.Location = New System.Drawing.Point(93, 438)
        Me.gbCiu.Name = "gbCiu"
        Me.gbCiu.Size = New System.Drawing.Size(334, 172)
        Me.gbCiu.TabIndex = 96
        Me.gbCiu.TabStop = False
        Me.gbCiu.Text = "Ciudades"
        '
        'txtID_C
        '
        Me.txtID_C.Location = New System.Drawing.Point(142, 24)
        Me.txtID_C.Name = "txtID_C"
        Me.txtID_C.ReadOnly = True
        Me.txtID_C.Size = New System.Drawing.Size(161, 20)
        Me.txtID_C.TabIndex = 25
        '
        'txtNombreC
        '
        Me.txtNombreC.Location = New System.Drawing.Point(142, 59)
        Me.txtNombreC.Name = "txtNombreC"
        Me.txtNombreC.Size = New System.Drawing.Size(161, 20)
        Me.txtNombreC.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Estado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Pais"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Ciudad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Id de la Ciudad"
        '
        'CBoxEstadosCiudades
        '
        Me.CBoxEstadosCiudades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CBoxEstadosCiudades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBoxEstadosCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxEstadosCiudades.FormattingEnabled = True
        Me.CBoxEstadosCiudades.Location = New System.Drawing.Point(142, 132)
        Me.CBoxEstadosCiudades.Name = "CBoxEstadosCiudades"
        Me.CBoxEstadosCiudades.Size = New System.Drawing.Size(161, 24)
        Me.CBoxEstadosCiudades.TabIndex = 19
        '
        'CBoxPaisCiudades
        '
        Me.CBoxPaisCiudades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CBoxPaisCiudades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBoxPaisCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxPaisCiudades.FormattingEnabled = True
        Me.CBoxPaisCiudades.Location = New System.Drawing.Point(142, 94)
        Me.CBoxPaisCiudades.Name = "CBoxPaisCiudades"
        Me.CBoxPaisCiudades.Size = New System.Drawing.Size(161, 24)
        Me.CBoxPaisCiudades.TabIndex = 18
        '
        'btnEP
        '
        Me.btnEP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEP.BackColor = System.Drawing.Color.Silver
        Me.btnEP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEP.FlatAppearance.BorderSize = 0
        Me.btnEP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEP.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEP.Location = New System.Drawing.Point(469, 173)
        Me.btnEP.Name = "btnEP"
        Me.btnEP.Size = New System.Drawing.Size(68, 23)
        Me.btnEP.TabIndex = 83
        Me.btnEP.Text = "Editar"
        Me.btnEP.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.BackColor = System.Drawing.Color.Silver
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(469, 338)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(68, 23)
        Me.Button6.TabIndex = 88
        Me.Button6.Text = "Eliminar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnElP
        '
        Me.btnElP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnElP.BackColor = System.Drawing.Color.Silver
        Me.btnElP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnElP.FlatAppearance.BorderSize = 0
        Me.btnElP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnElP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElP.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElP.Location = New System.Drawing.Point(469, 201)
        Me.btnElP.Name = "btnElP"
        Me.btnElP.Size = New System.Drawing.Size(68, 23)
        Me.btnElP.TabIndex = 84
        Me.btnElP.Text = "Eliminar"
        Me.btnElP.UseVisualStyleBackColor = False
        '
        'gbEdo
        '
        Me.gbEdo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbEdo.Controls.Add(Me.txtID_E)
        Me.gbEdo.Controls.Add(Me.txtNombreE)
        Me.gbEdo.Controls.Add(Me.Label6)
        Me.gbEdo.Controls.Add(Me.Label5)
        Me.gbEdo.Controls.Add(Me.Label4)
        Me.gbEdo.Controls.Add(Me.CBoxPaisesE)
        Me.gbEdo.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEdo.Location = New System.Drawing.Point(93, 257)
        Me.gbEdo.Name = "gbEdo"
        Me.gbEdo.Size = New System.Drawing.Size(334, 135)
        Me.gbEdo.TabIndex = 95
        Me.gbEdo.TabStop = False
        Me.gbEdo.Text = "Estados"
        '
        'txtID_E
        '
        Me.txtID_E.Location = New System.Drawing.Point(142, 24)
        Me.txtID_E.Name = "txtID_E"
        Me.txtID_E.ReadOnly = True
        Me.txtID_E.Size = New System.Drawing.Size(161, 20)
        Me.txtID_E.TabIndex = 17
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(142, 61)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(161, 20)
        Me.txtNombreE.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Pais"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Id del Estado"
        '
        'CBoxPaisesE
        '
        Me.CBoxPaisesE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CBoxPaisesE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBoxPaisesE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxPaisesE.FormattingEnabled = True
        Me.CBoxPaisesE.Location = New System.Drawing.Point(142, 92)
        Me.CBoxPaisesE.Name = "CBoxPaisesE"
        Me.CBoxPaisesE.Size = New System.Drawing.Size(161, 24)
        Me.CBoxPaisesE.TabIndex = 12
        '
        'gbPaises
        '
        Me.gbPaises.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbPaises.Controls.Add(Me.txtPais)
        Me.gbPaises.Controls.Add(Me.txtIdPais)
        Me.gbPaises.Controls.Add(Me.Label3)
        Me.gbPaises.Controls.Add(Me.Label2)
        Me.gbPaises.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPaises.Location = New System.Drawing.Point(93, 117)
        Me.gbPaises.Name = "gbPaises"
        Me.gbPaises.Size = New System.Drawing.Size(334, 94)
        Me.gbPaises.TabIndex = 94
        Me.gbPaises.TabStop = False
        Me.gbPaises.Text = "Paises"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(142, 59)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(161, 20)
        Me.txtPais.TabIndex = 3
        '
        'txtIdPais
        '
        Me.txtIdPais.Location = New System.Drawing.Point(142, 24)
        Me.txtIdPais.Name = "txtIdPais"
        Me.txtIdPais.ReadOnly = True
        Me.txtIdPais.Size = New System.Drawing.Size(161, 20)
        Me.txtIdPais.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Pais"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id del pais"
        '
        'Ubicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1200, 970)
        Me.ClientSize = New System.Drawing.Size(1200, 788)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ubicaciones"
        Me.Text = "Ubicac"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEdo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPaises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCol.ResumeLayout(False)
        Me.gbCol.PerformLayout()
        Me.gbCiu.ResumeLayout(False)
        Me.gbCiu.PerformLayout()
        Me.gbEdo.ResumeLayout(False)
        Me.gbEdo.PerformLayout()
        Me.gbPaises.ResumeLayout(False)
        Me.gbPaises.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvCol As DataGridView
    Friend WithEvents dgvCi As DataGridView
    Friend WithEvents dgvEdo As DataGridView
    Friend WithEvents dgvPaises As DataGridView
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents gbCol As GroupBox
    Friend WithEvents CBoxCiudadesCol As ComboBox
    Friend WithEvents CBoxEstadosCol As ComboBox
    Friend WithEvents CBoxPaisesCol As ComboBox
    Friend WithEvents btnAP As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents gbCiu As GroupBox
    Friend WithEvents CBoxEstadosCiudades As ComboBox
    Friend WithEvents CBoxPaisCiudades As ComboBox
    Friend WithEvents btnEP As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnElP As Button
    Friend WithEvents gbEdo As GroupBox
    Friend WithEvents CBoxPaisesE As ComboBox
    Friend WithEvents gbPaises As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID_CO As TextBox
    Friend WithEvents txtnombreCO As TextBox
    Friend WithEvents txtID_C As TextBox
    Friend WithEvents txtNombreC As TextBox
    Friend WithEvents txtID_E As TextBox
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtIdPais As TextBox
    Friend WithEvents btnCancelar As Button
End Class
