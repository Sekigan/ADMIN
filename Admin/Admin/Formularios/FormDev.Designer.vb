<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDev
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Ver = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbPaises = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxPaquetes = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.datedev = New System.Windows.Forms.DateTimePicker()
        Me.txtIDDev = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMotivo = New System.Windows.Forms.RichTextBox()
        Me.dgvDev = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbPaises.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDev, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Ver)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.gbPaises)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dgvDev)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1369, 970)
        Me.Panel1.TabIndex = 0
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
        Me.Button2.Location = New System.Drawing.Point(743, 758)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 119
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(652, 758)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 118
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Ver.ForeColor = System.Drawing.Color.Black
        Me.Ver.Location = New System.Drawing.Point(557, 758)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(75, 23)
        Me.Ver.TabIndex = 121
        Me.Ver.Text = "Ver"
        Me.Ver.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(1051, 786)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 122
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'gbPaises
        '
        Me.gbPaises.Controls.Add(Me.TextBox2)
        Me.gbPaises.Controls.Add(Me.Label7)
        Me.gbPaises.Controls.Add(Me.ComboBox1)
        Me.gbPaises.Controls.Add(Me.Label6)
        Me.gbPaises.Controls.Add(Me.ComboBoxPaquetes)
        Me.gbPaises.Controls.Add(Me.Label4)
        Me.gbPaises.Controls.Add(Me.datedev)
        Me.gbPaises.Controls.Add(Me.txtIDDev)
        Me.gbPaises.Controls.Add(Me.Label3)
        Me.gbPaises.Controls.Add(Me.Label2)
        Me.gbPaises.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPaises.Location = New System.Drawing.Point(105, 245)
        Me.gbPaises.Name = "gbPaises"
        Me.gbPaises.Size = New System.Drawing.Size(345, 223)
        Me.gbPaises.TabIndex = 113
        Me.gbPaises.TabStop = False
        Me.gbPaises.Text = "Paquete"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(144, 138)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(161, 20)
        Me.TextBox2.TabIndex = 126
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Dueño del Paquete"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 24)
        Me.ComboBox1.TabIndex = 124
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 37)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Empleado que hizo la devolucion"
        '
        'ComboBoxPaquetes
        '
        Me.ComboBoxPaquetes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPaquetes.FormattingEnabled = True
        Me.ComboBoxPaquetes.Location = New System.Drawing.Point(140, 51)
        Me.ComboBoxPaquetes.Name = "ComboBoxPaquetes"
        Me.ComboBoxPaquetes.Size = New System.Drawing.Size(161, 24)
        Me.ComboBoxPaquetes.TabIndex = 116
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Fecha"
        '
        'datedev
        '
        Me.datedev.Enabled = False
        Me.datedev.Location = New System.Drawing.Point(96, 182)
        Me.datedev.Name = "datedev"
        Me.datedev.Size = New System.Drawing.Size(207, 20)
        Me.datedev.TabIndex = 114
        '
        'txtIDDev
        '
        Me.txtIDDev.Location = New System.Drawing.Point(142, 19)
        Me.txtIDDev.MaxLength = 3
        Me.txtIDDev.Name = "txtIDDev"
        Me.txtIDDev.ReadOnly = True
        Me.txtIDDev.Size = New System.Drawing.Size(161, 20)
        Me.txtIDDev.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "id Devoluciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contenido Del Paquete"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMotivo)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(105, 485)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 109)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motivo"
        '
        'txtMotivo
        '
        Me.txtMotivo.Location = New System.Drawing.Point(16, 30)
        Me.txtMotivo.MaxLength = 100
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(303, 52)
        Me.txtMotivo.TabIndex = 3
        Me.txtMotivo.Text = ""
        '
        'dgvDev
        '
        Me.dgvDev.AllowUserToAddRows = False
        Me.dgvDev.AllowUserToDeleteRows = False
        Me.dgvDev.AllowUserToOrderColumns = True
        Me.dgvDev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvDev.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDev.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDev.Location = New System.Drawing.Point(648, 245)
        Me.dgvDev.Name = "dgvDev"
        Me.dgvDev.ReadOnly = True
        Me.dgvDev.Size = New System.Drawing.Size(598, 432)
        Me.dgvDev.TabIndex = 111
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(538, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Devoluciones"
        '
        'FormDev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1200, 970)
        Me.ClientSize = New System.Drawing.Size(1386, 460)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDev"
        Me.Text = "FormDev"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbPaises.ResumeLayout(False)
        Me.gbPaises.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDev, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDev As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMotivo As RichTextBox
    Friend WithEvents gbPaises As GroupBox
    Friend WithEvents txtIDDev As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents datedev As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Ver As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents ComboBoxPaquetes As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
End Class
