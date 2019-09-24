<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPaquetes
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Editar = New System.Windows.Forms.Button()
        Me.DateToday = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAgrega = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgvPaquetes = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Costo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtIdPaquetes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Contenido = New System.Windows.Forms.RichTextBox()
        Me.gbPaises = New System.Windows.Forms.GroupBox()
        Me.Observa = New System.Windows.Forms.RichTextBox()
        Me.DateEntrega = New System.Windows.Forms.DateTimePicker()
        Me.ChBoxNuevoCliente = New System.Windows.Forms.CheckBox()
        Me.CBoxCliente = New System.Windows.Forms.ComboBox()
        Me.ChBoxCliente = New System.Windows.Forms.CheckBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPaquetes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbPaises.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Editar)
        Me.Panel1.Controls.Add(Me.DateToday)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btnAgrega)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.dgvPaquetes)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.gbPaises)
        Me.Panel1.Controls.Add(Me.DateEntrega)
        Me.Panel1.Controls.Add(Me.ChBoxNuevoCliente)
        Me.Panel1.Controls.Add(Me.CBoxCliente)
        Me.Panel1.Controls.Add(Me.ChBoxCliente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1240, 970)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(824, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 39)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "*Color verde paquete entregado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*Color rojo paquete devuelto " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*Color blanco paqu" &
    "ete sin entregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Enabled = False
        Me.DataGridView2.Location = New System.Drawing.Point(375, 773)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView2.TabIndex = 130
        Me.DataGridView2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(69, 774)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 129
        Me.DataGridView1.Visible = False
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
        Me.Button1.Location = New System.Drawing.Point(496, 741)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 128
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Editar
        '
        Me.Editar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Editar.BackColor = System.Drawing.Color.Silver
        Me.Editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editar.FlatAppearance.BorderSize = 0
        Me.Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editar.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editar.ForeColor = System.Drawing.Color.Black
        Me.Editar.Location = New System.Drawing.Point(579, 698)
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(75, 23)
        Me.Editar.TabIndex = 127
        Me.Editar.Text = "Editar"
        Me.Editar.UseVisualStyleBackColor = False
        '
        'DateToday
        '
        Me.DateToday.Location = New System.Drawing.Point(827, 140)
        Me.DateToday.Name = "DateToday"
        Me.DateToday.Size = New System.Drawing.Size(200, 20)
        Me.DateToday.TabIndex = 9
        Me.DateToday.Value = New Date(2019, 5, 13, 0, 0, 0, 0)
        Me.DateToday.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(730, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Fecha de entrega"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAgrega
        '
        Me.btnAgrega.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAgrega.BackColor = System.Drawing.Color.Silver
        Me.btnAgrega.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgrega.FlatAppearance.BorderSize = 0
        Me.btnAgrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnAgrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgrega.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgrega.ForeColor = System.Drawing.Color.Black
        Me.btnAgrega.Location = New System.Drawing.Point(495, 697)
        Me.btnAgrega.Name = "btnAgrega"
        Me.btnAgrega.Size = New System.Drawing.Size(75, 23)
        Me.btnAgrega.TabIndex = 118
        Me.btnAgrega.Text = "Agregar"
        Me.btnAgrega.UseVisualStyleBackColor = False
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
        Me.Button3.Location = New System.Drawing.Point(753, 698)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 121
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
        Me.btneliminar.Location = New System.Drawing.Point(667, 698)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 120
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(1037, 765)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 122
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dgvPaquetes
        '
        Me.dgvPaquetes.AllowUserToAddRows = False
        Me.dgvPaquetes.AllowUserToDeleteRows = False
        Me.dgvPaquetes.AllowUserToOrderColumns = True
        Me.dgvPaquetes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvPaquetes.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPaquetes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaquetes.Location = New System.Drawing.Point(513, 183)
        Me.dgvPaquetes.Name = "dgvPaquetes"
        Me.dgvPaquetes.ReadOnly = True
        Me.dgvPaquetes.Size = New System.Drawing.Size(617, 472)
        Me.dgvPaquetes.TabIndex = 110
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Costo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtPeso)
        Me.GroupBox2.Controls.Add(Me.txtIdPaquetes)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(53, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 162)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paquete Info"
        '
        'Costo
        '
        Me.Costo.Enabled = False
        Me.Costo.Location = New System.Drawing.Point(142, 93)
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Size = New System.Drawing.Size(161, 20)
        Me.Costo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Costo Envio"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(142, 59)
        Me.txtPeso.MaxLength = 3
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(161, 20)
        Me.txtPeso.TabIndex = 3
        '
        'txtIdPaquetes
        '
        Me.txtIdPaquetes.Enabled = False
        Me.txtIdPaquetes.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPaquetes.Location = New System.Drawing.Point(142, 24)
        Me.txtIdPaquetes.Name = "txtIdPaquetes"
        Me.txtIdPaquetes.ReadOnly = True
        Me.txtIdPaquetes.Size = New System.Drawing.Size(161, 20)
        Me.txtIdPaquetes.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Peso Paquete"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id del paquete"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Contenido)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(53, 386)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 109)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contenido"
        '
        'Contenido
        '
        Me.Contenido.Location = New System.Drawing.Point(16, 30)
        Me.Contenido.MaxLength = 64
        Me.Contenido.Name = "Contenido"
        Me.Contenido.Size = New System.Drawing.Size(303, 52)
        Me.Contenido.TabIndex = 3
        Me.Contenido.Text = ""
        '
        'gbPaises
        '
        Me.gbPaises.Controls.Add(Me.Observa)
        Me.gbPaises.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPaises.Location = New System.Drawing.Point(53, 527)
        Me.gbPaises.Name = "gbPaises"
        Me.gbPaises.Size = New System.Drawing.Size(336, 128)
        Me.gbPaises.TabIndex = 95
        Me.gbPaises.TabStop = False
        Me.gbPaises.Text = "Observaciones"
        '
        'Observa
        '
        Me.Observa.Location = New System.Drawing.Point(16, 30)
        Me.Observa.MaxLength = 64
        Me.Observa.Name = "Observa"
        Me.Observa.Size = New System.Drawing.Size(303, 76)
        Me.Observa.TabIndex = 3
        Me.Observa.Text = ""
        '
        'DateEntrega
        '
        Me.DateEntrega.Location = New System.Drawing.Point(827, 95)
        Me.DateEntrega.Name = "DateEntrega"
        Me.DateEntrega.Size = New System.Drawing.Size(200, 20)
        Me.DateEntrega.TabIndex = 9
        '
        'ChBoxNuevoCliente
        '
        Me.ChBoxNuevoCliente.AutoSize = True
        Me.ChBoxNuevoCliente.Location = New System.Drawing.Point(52, 140)
        Me.ChBoxNuevoCliente.Name = "ChBoxNuevoCliente"
        Me.ChBoxNuevoCliente.Size = New System.Drawing.Size(96, 17)
        Me.ChBoxNuevoCliente.TabIndex = 5
        Me.ChBoxNuevoCliente.Text = "Nuevo Cliente:"
        Me.ChBoxNuevoCliente.UseVisualStyleBackColor = True
        '
        'CBoxCliente
        '
        Me.CBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxCliente.FormattingEnabled = True
        Me.CBoxCliente.Location = New System.Drawing.Point(168, 98)
        Me.CBoxCliente.Name = "CBoxCliente"
        Me.CBoxCliente.Size = New System.Drawing.Size(227, 21)
        Me.CBoxCliente.TabIndex = 4
        '
        'ChBoxCliente
        '
        Me.ChBoxCliente.AutoSize = True
        Me.ChBoxCliente.Location = New System.Drawing.Point(52, 100)
        Me.ChBoxCliente.Name = "ChBoxCliente"
        Me.ChBoxCliente.Size = New System.Drawing.Size(110, 17)
        Me.ChBoxCliente.TabIndex = 3
        Me.ChBoxCliente.Text = "Actualizar Cliente:"
        Me.ChBoxCliente.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Destinatario"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(142, 125)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 24)
        Me.ComboBox1.TabIndex = 7
        '
        'FormPaquetes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1200, 970)
        Me.ClientSize = New System.Drawing.Size(1257, 460)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPaquetes"
        Me.Text = "FormPaquetes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPaquetes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbPaises.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateEntrega As DateTimePicker
    Friend WithEvents ChBoxNuevoCliente As CheckBox
    Friend WithEvents CBoxCliente As ComboBox
    Friend WithEvents ChBoxCliente As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Contenido As RichTextBox
    Friend WithEvents gbPaises As GroupBox
    Friend WithEvents Observa As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Costo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtIdPaquetes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvPaquetes As DataGridView
    Friend WithEvents btnAgrega As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateToday As DateTimePicker
    Friend WithEvents Editar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
End Class
