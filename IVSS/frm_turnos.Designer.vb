<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_turnos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_turnos))
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_archivar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chk_mostrar_todos = New System.Windows.Forms.CheckBox()
        Me.btn_restaurar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_activo = New System.Windows.Forms.CheckBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_turno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_hora_hasta = New System.Windows.Forms.DateTimePicker()
        Me.txt_hora_desde = New System.Windows.Forms.DateTimePicker()
        Me.Lista_turnos = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lista_espec = New System.Windows.Forms.ListView()
        Me.max_pacientes = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_usuario = New System.Windows.Forms.Label()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.max_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(8, 6)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(69, 66)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 25
        Me.Pic_icono.TabStop = False
        '
        'Lbl_titulo
        '
        Me.Lbl_titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_titulo.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_titulo.Location = New System.Drawing.Point(92, 2)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(390, 67)
        Me.Lbl_titulo.TabIndex = 23
        Me.Lbl_titulo.Text = "CONFIGURACION DE TURNOS"
        Me.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cerrar.BackColor = System.Drawing.Color.LightBlue
        Me.Btn_cerrar.Image = CType(resources.GetObject("Btn_cerrar.Image"), System.Drawing.Image)
        Me.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cerrar.Location = New System.Drawing.Point(567, 27)
        Me.Btn_cerrar.Name = "Btn_cerrar"
        Me.Btn_cerrar.Size = New System.Drawing.Size(91, 42)
        Me.Btn_cerrar.TabIndex = 21
        Me.Btn_cerrar.Text = "&Cerrar"
        Me.Btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_cerrar.UseVisualStyleBackColor = False
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 466)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(666, 65)
        Me.Pic_pie_pagina.TabIndex = 22
        Me.Pic_pie_pagina.TabStop = False
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, -1)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(666, 80)
        Me.Pic_Encabezado.TabIndex = 24
        Me.Pic_Encabezado.TabStop = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_nuevo.BackColor = System.Drawing.Color.LightBlue
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.Location = New System.Drawing.Point(260, 478)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(95, 41)
        Me.btn_nuevo.TabIndex = 32
        Me.btn_nuevo.Text = "&Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_archivar
        '
        Me.btn_archivar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_archivar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_archivar.Image = CType(resources.GetObject("btn_archivar.Image"), System.Drawing.Image)
        Me.btn_archivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_archivar.Location = New System.Drawing.Point(361, 478)
        Me.btn_archivar.Name = "btn_archivar"
        Me.btn_archivar.Size = New System.Drawing.Size(95, 41)
        Me.btn_archivar.TabIndex = 33
        Me.btn_archivar.Text = "&Archivar"
        Me.btn_archivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_archivar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_eliminar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(462, 478)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(95, 41)
        Me.btn_eliminar.TabIndex = 34
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_reporte
        '
        Me.btn_reporte.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_reporte.BackColor = System.Drawing.Color.LightBlue
        Me.btn_reporte.Image = CType(resources.GetObject("btn_reporte.Image"), System.Drawing.Image)
        Me.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reporte.Location = New System.Drawing.Point(563, 478)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(91, 41)
        Me.btn_reporte.TabIndex = 35
        Me.btn_reporte.Text = "&Reporte"
        Me.btn_reporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reporte.UseVisualStyleBackColor = False
        '
        'chk_mostrar_todos
        '
        Me.chk_mostrar_todos.AutoSize = True
        Me.chk_mostrar_todos.Location = New System.Drawing.Point(14, 260)
        Me.chk_mostrar_todos.Name = "chk_mostrar_todos"
        Me.chk_mostrar_todos.Size = New System.Drawing.Size(163, 19)
        Me.chk_mostrar_todos.TabIndex = 58
        Me.chk_mostrar_todos.Text = "Mostrar turnos inactivos"
        Me.ToolTip1.SetToolTip(Me.chk_mostrar_todos, "Mostrar turnos desactivados")
        Me.chk_mostrar_todos.UseVisualStyleBackColor = True
        '
        'btn_restaurar
        '
        Me.btn_restaurar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_restaurar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_restaurar.Image = CType(resources.GetObject("btn_restaurar.Image"), System.Drawing.Image)
        Me.btn_restaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_restaurar.Location = New System.Drawing.Point(631, 258)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(27, 23)
        Me.btn_restaurar.TabIndex = 67
        Me.btn_restaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_restaurar, "Restablecer valores predeterminados en cada especialidad")
        Me.btn_restaurar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_activo)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_turno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_hora_hasta)
        Me.GroupBox1.Controls.Add(Me.txt_hora_desde)
        Me.GroupBox1.Controls.Add(Me.Lista_turnos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 171)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Turnos"
        '
        'chk_activo
        '
        Me.chk_activo.AutoSize = True
        Me.chk_activo.Checked = True
        Me.chk_activo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_activo.Location = New System.Drawing.Point(551, 36)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Size = New System.Drawing.Size(56, 17)
        Me.chk_activo.TabIndex = 67
        Me.chk_activo.Text = "Activo"
        Me.chk_activo.UseVisualStyleBackColor = True
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.Color.LightYellow
        Me.txt_codigo.Location = New System.Drawing.Point(6, 34)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(63, 23)
        Me.txt_codigo.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 15)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Descripción turno"
        '
        'txt_turno
        '
        Me.txt_turno.Location = New System.Drawing.Point(75, 34)
        Me.txt_turno.Name = "txt_turno"
        Me.txt_turno.Size = New System.Drawing.Size(239, 23)
        Me.txt_turno.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(435, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Desde"
        '
        'txt_hora_hasta
        '
        Me.txt_hora_hasta.CustomFormat = "hh:mm:ss tt"
        Me.txt_hora_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_hora_hasta.Location = New System.Drawing.Point(438, 34)
        Me.txt_hora_hasta.Name = "txt_hora_hasta"
        Me.txt_hora_hasta.ShowUpDown = True
        Me.txt_hora_hasta.Size = New System.Drawing.Size(107, 23)
        Me.txt_hora_hasta.TabIndex = 51
        '
        'txt_hora_desde
        '
        Me.txt_hora_desde.CustomFormat = "hh:mm:ss tt"
        Me.txt_hora_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_hora_desde.Location = New System.Drawing.Point(320, 34)
        Me.txt_hora_desde.Name = "txt_hora_desde"
        Me.txt_hora_desde.ShowUpDown = True
        Me.txt_hora_desde.Size = New System.Drawing.Size(112, 23)
        Me.txt_hora_desde.TabIndex = 50
        '
        'Lista_turnos
        '
        Me.Lista_turnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lista_turnos.BackColor = System.Drawing.Color.White
        Me.Lista_turnos.GridLines = True
        Me.Lista_turnos.HideSelection = False
        Me.Lista_turnos.Location = New System.Drawing.Point(6, 59)
        Me.Lista_turnos.Name = "Lista_turnos"
        Me.Lista_turnos.Size = New System.Drawing.Size(638, 106)
        Me.Lista_turnos.TabIndex = 49
        Me.Lista_turnos.Tag = "limpiar"
        Me.Lista_turnos.UseCompatibleStateImageBehavior = False
        Me.Lista_turnos.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(213, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Especialidades asignadas:"
        '
        'Lista_espec
        '
        Me.Lista_espec.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lista_espec.BackColor = System.Drawing.Color.White
        Me.Lista_espec.CheckBoxes = True
        Me.Lista_espec.GridLines = True
        Me.Lista_espec.HideSelection = False
        Me.Lista_espec.Location = New System.Drawing.Point(8, 285)
        Me.Lista_espec.MultiSelect = False
        Me.Lista_espec.Name = "Lista_espec"
        Me.Lista_espec.Size = New System.Drawing.Size(650, 187)
        Me.Lista_espec.TabIndex = 64
        Me.Lista_espec.Tag = "limpiar"
        Me.Lista_espec.UseCompatibleStateImageBehavior = False
        Me.Lista_espec.View = System.Windows.Forms.View.Details
        '
        'max_pacientes
        '
        Me.max_pacientes.Location = New System.Drawing.Point(563, 258)
        Me.max_pacientes.Name = "max_pacientes"
        Me.max_pacientes.Size = New System.Drawing.Size(52, 23)
        Me.max_pacientes.TabIndex = 65
        Me.max_pacientes.Tag = "limpiar"
        Me.max_pacientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.max_pacientes.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(390, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 15)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Maximo de pacientes por dia"
        '
        'Lbl_usuario
        '
        Me.Lbl_usuario.BackColor = System.Drawing.Color.LightBlue
        Me.Lbl_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_usuario.Location = New System.Drawing.Point(8, 478)
        Me.Lbl_usuario.Name = "Lbl_usuario"
        Me.Lbl_usuario.Size = New System.Drawing.Size(246, 44)
        Me.Lbl_usuario.TabIndex = 68
        '
        'frm_turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(666, 531)
        Me.Controls.Add(Me.Lbl_usuario)
        Me.Controls.Add(Me.btn_restaurar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.max_pacientes)
        Me.Controls.Add(Me.Lista_espec)
        Me.Controls.Add(Me.chk_mostrar_todos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_archivar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_turnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turnos"
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.max_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_archivar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents chk_mostrar_todos As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_turno As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_hora_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_hora_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lista_turnos As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lista_espec As System.Windows.Forms.ListView
    Friend WithEvents max_pacientes As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_activo As System.Windows.Forms.CheckBox
    Friend WithEvents btn_restaurar As System.Windows.Forms.Button
    Friend WithEvents Lbl_usuario As System.Windows.Forms.Label
End Class
