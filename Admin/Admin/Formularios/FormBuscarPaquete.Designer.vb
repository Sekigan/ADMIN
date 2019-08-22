<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuscarPaquete
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VerXCliente = New System.Windows.Forms.Button()
        Me.Ver = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btcActualizar = New System.Windows.Forms.Button()
        Me.dgvRes = New System.Windows.Forms.DataGridView()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBc = New System.Windows.Forms.ComboBox()
        Me.CheckBoxDevC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCEntregas = New System.Windows.Forms.CheckBox()
        Me.CBEmp = New System.Windows.Forms.ComboBox()
        Me.DTPfecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.VerXCliente)
        Me.Panel1.Controls.Add(Me.Ver)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btcActualizar)
        Me.Panel1.Controls.Add(Me.dgvRes)
        Me.Panel1.Controls.Add(Me.gbFiltros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 970)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(552, 591)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 124
        Me.Button1.Text = "Ver Por Empleado"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'VerXCliente
        '
        Me.VerXCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.VerXCliente.BackColor = System.Drawing.Color.Silver
        Me.VerXCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VerXCliente.FlatAppearance.BorderSize = 0
        Me.VerXCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.VerXCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerXCliente.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerXCliente.Location = New System.Drawing.Point(444, 591)
        Me.VerXCliente.Name = "VerXCliente"
        Me.VerXCliente.Size = New System.Drawing.Size(90, 23)
        Me.VerXCliente.TabIndex = 123
        Me.VerXCliente.Text = "Ver Por Cliente"
        Me.VerXCliente.UseVisualStyleBackColor = False
        '
        'Ver
        '
        Me.Ver.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Ver.BackColor = System.Drawing.Color.Silver
        Me.Ver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ver.FlatAppearance.BorderSize = 0
        Me.Ver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ver.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ver.Location = New System.Drawing.Point(232, 580)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(83, 44)
        Me.Ver.TabIndex = 122
        Me.Ver.Text = "Ver Paquetes a Entregar Por Fecha Especifica"
        Me.Ver.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCerrar.BackColor = System.Drawing.Color.Silver
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(1000, 591)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(90, 23)
        Me.btnCerrar.TabIndex = 121
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(507, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 27)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Buscar"
        '
        'btcActualizar
        '
        Me.btcActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btcActualizar.BackColor = System.Drawing.Color.Silver
        Me.btcActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btcActualizar.FlatAppearance.BorderSize = 0
        Me.btcActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btcActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btcActualizar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcActualizar.Location = New System.Drawing.Point(332, 591)
        Me.btcActualizar.Name = "btcActualizar"
        Me.btcActualizar.Size = New System.Drawing.Size(90, 23)
        Me.btcActualizar.TabIndex = 119
        Me.btcActualizar.Text = "Devoluciones "
        Me.btcActualizar.UseVisualStyleBackColor = False
        '
        'dgvRes
        '
        Me.dgvRes.AllowUserToAddRows = False
        Me.dgvRes.AllowUserToDeleteRows = False
        Me.dgvRes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvRes.BackgroundColor = System.Drawing.Color.White
        Me.dgvRes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRes.Location = New System.Drawing.Point(45, 183)
        Me.dgvRes.Name = "dgvRes"
        Me.dgvRes.Size = New System.Drawing.Size(1097, 390)
        Me.dgvRes.TabIndex = 116
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.Label3)
        Me.gbFiltros.Controls.Add(Me.Cliente)
        Me.gbFiltros.Controls.Add(Me.Label2)
        Me.gbFiltros.Controls.Add(Me.CBc)
        Me.gbFiltros.Controls.Add(Me.CheckBoxDevC)
        Me.gbFiltros.Controls.Add(Me.CheckBoxCEntregas)
        Me.gbFiltros.Controls.Add(Me.CBEmp)
        Me.gbFiltros.Controls.Add(Me.DTPfecha)
        Me.gbFiltros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbFiltros.Location = New System.Drawing.Point(45, 93)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(1097, 62)
        Me.gbFiltros.TabIndex = 115
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(712, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Empleado"
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(411, 31)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 127
        Me.Cliente.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Fecha Especifica"
        '
        'CBc
        '
        Me.CBc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBc.FormattingEnabled = True
        Me.CBc.Location = New System.Drawing.Point(476, 24)
        Me.CBc.Name = "CBc"
        Me.CBc.Size = New System.Drawing.Size(142, 21)
        Me.CBc.TabIndex = 125
        '
        'CheckBoxDevC
        '
        Me.CheckBoxDevC.AutoSize = True
        Me.CheckBoxDevC.Location = New System.Drawing.Point(944, 37)
        Me.CheckBoxDevC.Name = "CheckBoxDevC"
        Me.CheckBoxDevC.Size = New System.Drawing.Size(91, 17)
        Me.CheckBoxDevC.TabIndex = 124
        Me.CheckBoxDevC.Text = "Devoluciones"
        Me.CheckBoxDevC.UseVisualStyleBackColor = True
        '
        'CheckBoxCEntregas
        '
        Me.CheckBoxCEntregas.AutoSize = True
        Me.CheckBoxCEntregas.Location = New System.Drawing.Point(944, 17)
        Me.CheckBoxCEntregas.Name = "CheckBoxCEntregas"
        Me.CheckBoxCEntregas.Size = New System.Drawing.Size(68, 17)
        Me.CheckBoxCEntregas.TabIndex = 123
        Me.CheckBoxCEntregas.Text = "Entregas"
        Me.CheckBoxCEntregas.UseVisualStyleBackColor = True
        '
        'CBEmp
        '
        Me.CBEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEmp.FormattingEnabled = True
        Me.CBEmp.Location = New System.Drawing.Point(808, 24)
        Me.CBEmp.Name = "CBEmp"
        Me.CBEmp.Size = New System.Drawing.Size(130, 21)
        Me.CBEmp.TabIndex = 122
        '
        'DTPfecha
        '
        Me.DTPfecha.CustomFormat = ""
        Me.DTPfecha.Location = New System.Drawing.Point(101, 24)
        Me.DTPfecha.Name = "DTPfecha"
        Me.DTPfecha.Size = New System.Drawing.Size(254, 20)
        Me.DTPfecha.TabIndex = 114
        '
        'FormBuscarPaquete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1200, 970)
        Me.ClientSize = New System.Drawing.Size(1178, 640)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBuscarPaquete"
        Me.Text = "FormBuscarPaquete"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DTPfecha As DateTimePicker
    Friend WithEvents btcActualizar As Button
    Public WithEvents dgvRes As DataGridView
    Friend WithEvents gbFiltros As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBoxDevC As CheckBox
    Friend WithEvents CheckBoxCEntregas As CheckBox
    Friend WithEvents CBEmp As ComboBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Ver As Button
    Friend WithEvents CBc As ComboBox
    Friend WithEvents VerXCliente As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Cliente As Label
    Friend WithEvents Label2 As Label
End Class
