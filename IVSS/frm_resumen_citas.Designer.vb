<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_resumen_citas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_resumen_citas))
        Me.Dialogo_abrir = New System.Windows.Forms.OpenFileDialog()
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.btn_restaurar = New System.Windows.Forms.Button()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Grupo_fechas = New System.Windows.Forms.GroupBox()
        Me.cmb_estatus_cita = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.otros = New System.Windows.Forms.RadioButton()
        Me.anio_pasado = New System.Windows.Forms.RadioButton()
        Me.este_anio = New System.Windows.Forms.RadioButton()
        Me.este_mes = New System.Windows.Forms.RadioButton()
        Me.esta_semana = New System.Windows.Forms.RadioButton()
        Me.manana = New System.Windows.Forms.RadioButton()
        Me.ayer = New System.Windows.Forms.RadioButton()
        Me.hoy = New System.Windows.Forms.RadioButton()
        Me.Fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox()
        Me.LBL_especialidad = New System.Windows.Forms.Label()
        Me.lbl_medico = New System.Windows.Forms.Label()
        Me.cmb_medico = New System.Windows.Forms.ComboBox()
        Me.cmb_turno = New System.Windows.Forms.ComboBox()
        Me.lbl_turno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_todos_med = New System.Windows.Forms.CheckBox()
        Me.chk_todas_espc = New System.Windows.Forms.CheckBox()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_fechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dialogo_abrir
        '
        Me.Dialogo_abrir.FileName = "OpenFileDialog1"
        '
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(12, 4)
        Me.Pic_icono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(62, 60)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 43
        Me.Pic_icono.TabStop = False
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cerrar.BackColor = System.Drawing.Color.LightBlue
        Me.Btn_cerrar.Image = CType(resources.GetObject("Btn_cerrar.Image"), System.Drawing.Image)
        Me.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cerrar.Location = New System.Drawing.Point(419, 13)
        Me.Btn_cerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_cerrar.Name = "Btn_cerrar"
        Me.Btn_cerrar.Size = New System.Drawing.Size(93, 44)
        Me.Btn_cerrar.TabIndex = 9
        Me.Btn_cerrar.Text = "&Cerrar"
        Me.Btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_cerrar.UseVisualStyleBackColor = False
        '
        'Lbl_titulo
        '
        Me.Lbl_titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_titulo.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_titulo.Location = New System.Drawing.Point(80, 4)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(342, 60)
        Me.Lbl_titulo.TabIndex = 42
        Me.Lbl_titulo.Text = "RESUMEN GENERAL DE CITAS"
        Me.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Encabezado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(524, 73)
        Me.Pic_Encabezado.TabIndex = 44
        Me.Pic_Encabezado.TabStop = False
        '
        'btn_restaurar
        '
        Me.btn_restaurar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_restaurar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_restaurar.Image = CType(resources.GetObject("btn_restaurar.Image"), System.Drawing.Image)
        Me.btn_restaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_restaurar.Location = New System.Drawing.Point(289, 380)
        Me.btn_restaurar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_restaurar.Name = "btn_restaurar"
        Me.btn_restaurar.Size = New System.Drawing.Size(197, 45)
        Me.btn_restaurar.TabIndex = 8
        Me.btn_restaurar.Text = "&Vista previa del reporte"
        Me.btn_restaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_restaurar, "Restaura la base de datos seleccionada")
        Me.btn_restaurar.UseVisualStyleBackColor = False
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 381)
        Me.Pic_pie_pagina.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(524, 54)
        Me.Pic_pie_pagina.TabIndex = 46
        Me.Pic_pie_pagina.TabStop = False
        '
        'Grupo_fechas
        '
        Me.Grupo_fechas.Controls.Add(Me.cmb_estatus_cita)
        Me.Grupo_fechas.Controls.Add(Me.Label2)
        Me.Grupo_fechas.Controls.Add(Me.otros)
        Me.Grupo_fechas.Controls.Add(Me.anio_pasado)
        Me.Grupo_fechas.Controls.Add(Me.este_anio)
        Me.Grupo_fechas.Controls.Add(Me.este_mes)
        Me.Grupo_fechas.Controls.Add(Me.esta_semana)
        Me.Grupo_fechas.Controls.Add(Me.manana)
        Me.Grupo_fechas.Controls.Add(Me.ayer)
        Me.Grupo_fechas.Controls.Add(Me.hoy)
        Me.Grupo_fechas.Location = New System.Drawing.Point(12, 224)
        Me.Grupo_fechas.Name = "Grupo_fechas"
        Me.Grupo_fechas.Size = New System.Drawing.Size(243, 200)
        Me.Grupo_fechas.TabIndex = 5
        Me.Grupo_fechas.TabStop = False
        Me.Grupo_fechas.Text = "Fechas:"
        '
        'cmb_estatus_cita
        '
        Me.cmb_estatus_cita.FormattingEnabled = True
        Me.cmb_estatus_cita.Location = New System.Drawing.Point(7, 156)
        Me.cmb_estatus_cita.Name = "cmb_estatus_cita"
        Me.cmb_estatus_cita.Size = New System.Drawing.Size(230, 25)
        Me.cmb_estatus_cita.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "TIPOS DE CONSULTA:"
        '
        'otros
        '
        Me.otros.AutoSize = True
        Me.otros.Location = New System.Drawing.Point(126, 105)
        Me.otros.Name = "otros"
        Me.otros.Size = New System.Drawing.Size(85, 17)
        Me.otros.TabIndex = 7
        Me.otros.Text = "Otros rangos"
        Me.otros.UseVisualStyleBackColor = True
        '
        'anio_pasado
        '
        Me.anio_pasado.AutoSize = True
        Me.anio_pasado.Location = New System.Drawing.Point(126, 78)
        Me.anio_pasado.Name = "anio_pasado"
        Me.anio_pasado.Size = New System.Drawing.Size(93, 17)
        Me.anio_pasado.TabIndex = 6
        Me.anio_pasado.Text = "El año pasado"
        Me.anio_pasado.UseVisualStyleBackColor = True
        '
        'este_anio
        '
        Me.este_anio.AutoSize = True
        Me.este_anio.Location = New System.Drawing.Point(126, 51)
        Me.este_anio.Name = "este_anio"
        Me.este_anio.Size = New System.Drawing.Size(67, 17)
        Me.este_anio.TabIndex = 5
        Me.este_anio.Text = "Este año"
        Me.este_anio.UseVisualStyleBackColor = True
        '
        'este_mes
        '
        Me.este_mes.AutoSize = True
        Me.este_mes.Location = New System.Drawing.Point(126, 24)
        Me.este_mes.Name = "este_mes"
        Me.este_mes.Size = New System.Drawing.Size(68, 17)
        Me.este_mes.TabIndex = 4
        Me.este_mes.Text = "Este mes"
        Me.este_mes.UseVisualStyleBackColor = True
        '
        'esta_semana
        '
        Me.esta_semana.AutoSize = True
        Me.esta_semana.Location = New System.Drawing.Point(6, 105)
        Me.esta_semana.Name = "esta_semana"
        Me.esta_semana.Size = New System.Drawing.Size(86, 17)
        Me.esta_semana.TabIndex = 3
        Me.esta_semana.Text = "Esta semana"
        Me.esta_semana.UseVisualStyleBackColor = True
        '
        'manana
        '
        Me.manana.AutoSize = True
        Me.manana.Location = New System.Drawing.Point(6, 78)
        Me.manana.Name = "manana"
        Me.manana.Size = New System.Drawing.Size(64, 17)
        Me.manana.TabIndex = 2
        Me.manana.Text = "Mañana"
        Me.manana.UseVisualStyleBackColor = True
        '
        'ayer
        '
        Me.ayer.AutoSize = True
        Me.ayer.Location = New System.Drawing.Point(6, 51)
        Me.ayer.Name = "ayer"
        Me.ayer.Size = New System.Drawing.Size(46, 17)
        Me.ayer.TabIndex = 1
        Me.ayer.Text = "Ayer"
        Me.ayer.UseVisualStyleBackColor = True
        '
        'hoy
        '
        Me.hoy.AutoSize = True
        Me.hoy.Checked = True
        Me.hoy.Location = New System.Drawing.Point(6, 24)
        Me.hoy.Name = "hoy"
        Me.hoy.Size = New System.Drawing.Size(44, 17)
        Me.hoy.TabIndex = 0
        Me.hoy.TabStop = True
        Me.hoy.Text = "Hoy"
        Me.hoy.UseVisualStyleBackColor = True
        '
        'Fecha_desde
        '
        Me.Fecha_desde.Location = New System.Drawing.Point(267, 277)
        Me.Fecha_desde.Name = "Fecha_desde"
        Me.Fecha_desde.Size = New System.Drawing.Size(251, 25)
        Me.Fecha_desde.TabIndex = 6
        '
        'Fecha_hasta
        '
        Me.Fecha_hasta.Location = New System.Drawing.Point(267, 332)
        Me.Fecha_hasta.Name = "Fecha_hasta"
        Me.Fecha_hasta.Size = New System.Drawing.Size(248, 25)
        Me.Fecha_hasta.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Fecha desde:"
        '
        'cmb_especialidad
        '
        Me.cmb_especialidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_especialidad.FormattingEnabled = True
        Me.cmb_especialidad.Location = New System.Drawing.Point(12, 97)
        Me.cmb_especialidad.Name = "cmb_especialidad"
        Me.cmb_especialidad.Size = New System.Drawing.Size(503, 25)
        Me.cmb_especialidad.TabIndex = 0
        '
        'LBL_especialidad
        '
        Me.LBL_especialidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_especialidad.AutoSize = True
        Me.LBL_especialidad.Location = New System.Drawing.Point(12, 77)
        Me.LBL_especialidad.Name = "LBL_especialidad"
        Me.LBL_especialidad.Size = New System.Drawing.Size(90, 17)
        Me.LBL_especialidad.TabIndex = 54
        Me.LBL_especialidad.Text = "ESPECIALIDAD"
        '
        'lbl_medico
        '
        Me.lbl_medico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_medico.AutoSize = True
        Me.lbl_medico.Location = New System.Drawing.Point(13, 173)
        Me.lbl_medico.Name = "lbl_medico"
        Me.lbl_medico.Size = New System.Drawing.Size(57, 17)
        Me.lbl_medico.TabIndex = 56
        Me.lbl_medico.Text = "MÉDICO"
        '
        'cmb_medico
        '
        Me.cmb_medico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_medico.FormattingEnabled = True
        Me.cmb_medico.Location = New System.Drawing.Point(12, 193)
        Me.cmb_medico.Name = "cmb_medico"
        Me.cmb_medico.Size = New System.Drawing.Size(500, 25)
        Me.cmb_medico.TabIndex = 2
        '
        'cmb_turno
        '
        Me.cmb_turno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_turno.FormattingEnabled = True
        Me.cmb_turno.Location = New System.Drawing.Point(12, 145)
        Me.cmb_turno.Name = "cmb_turno"
        Me.cmb_turno.Size = New System.Drawing.Size(251, 25)
        Me.cmb_turno.TabIndex = 1
        '
        'lbl_turno
        '
        Me.lbl_turno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_turno.AutoSize = True
        Me.lbl_turno.Location = New System.Drawing.Point(12, 125)
        Me.lbl_turno.Name = "lbl_turno"
        Me.lbl_turno.Size = New System.Drawing.Size(52, 17)
        Me.lbl_turno.TabIndex = 55
        Me.lbl_turno.Text = "TURNO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Fecha hasta:"
        '
        'chk_todos_med
        '
        Me.chk_todos_med.AutoSize = True
        Me.chk_todos_med.Location = New System.Drawing.Point(277, 155)
        Me.chk_todos_med.Name = "chk_todos_med"
        Me.chk_todos_med.Size = New System.Drawing.Size(235, 21)
        Me.chk_todos_med.TabIndex = 4
        Me.chk_todos_med.Text = "Mostrar citas de todos los médicos"
        Me.chk_todos_med.UseVisualStyleBackColor = True
        '
        'chk_todas_espc
        '
        Me.chk_todas_espc.AutoSize = True
        Me.chk_todas_espc.Location = New System.Drawing.Point(277, 128)
        Me.chk_todas_espc.Name = "chk_todas_espc"
        Me.chk_todas_espc.Size = New System.Drawing.Size(221, 21)
        Me.chk_todas_espc.TabIndex = 3
        Me.chk_todas_espc.Text = "Mostrar todas las especialidades"
        Me.chk_todas_espc.UseVisualStyleBackColor = True
        '
        'frm_resumen_citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(524, 435)
        Me.Controls.Add(Me.chk_todas_espc)
        Me.Controls.Add(Me.chk_todos_med)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_especialidad)
        Me.Controls.Add(Me.LBL_especialidad)
        Me.Controls.Add(Me.lbl_medico)
        Me.Controls.Add(Me.cmb_medico)
        Me.Controls.Add(Me.cmb_turno)
        Me.Controls.Add(Me.lbl_turno)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Fecha_hasta)
        Me.Controls.Add(Me.Fecha_desde)
        Me.Controls.Add(Me.Grupo_fechas)
        Me.Controls.Add(Me.btn_restaurar)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_resumen_citas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de citas"
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_fechas.ResumeLayout(False)
        Me.Grupo_fechas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dialogo_abrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents btn_restaurar As System.Windows.Forms.Button
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Grupo_fechas As System.Windows.Forms.GroupBox
    Friend WithEvents otros As System.Windows.Forms.RadioButton
    Friend WithEvents anio_pasado As System.Windows.Forms.RadioButton
    Friend WithEvents este_anio As System.Windows.Forms.RadioButton
    Friend WithEvents este_mes As System.Windows.Forms.RadioButton
    Friend WithEvents esta_semana As System.Windows.Forms.RadioButton
    Friend WithEvents manana As System.Windows.Forms.RadioButton
    Friend WithEvents ayer As System.Windows.Forms.RadioButton
    Friend WithEvents hoy As System.Windows.Forms.RadioButton
    Friend WithEvents Fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_estatus_cita As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents LBL_especialidad As System.Windows.Forms.Label
    Friend WithEvents lbl_medico As System.Windows.Forms.Label
    Friend WithEvents cmb_medico As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_turno As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_turno As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chk_todos_med As System.Windows.Forms.CheckBox
    Friend WithEvents chk_todas_espc As System.Windows.Forms.CheckBox

End Class
