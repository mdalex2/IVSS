<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_control_cita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_control_cita))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Nº Historia", "Nº historia"}, -1)
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_max_pac_por_tipo_cita = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_max_por_dia_especialidad = New System.Windows.Forms.Label()
        Me.btn_prox_mes = New System.Windows.Forms.Button()
        Me.btn_prox = New System.Windows.Forms.Button()
        Me.Progreso_espera = New System.Windows.Forms.ProgressBar()
        Me.btn_atendido = New System.Windows.Forms.Button()
        Me.Lista_pacientes_dia = New System.Windows.Forms.ListView()
        Me.Grupo_fecha = New System.Windows.Forms.GroupBox()
        Me.lbl_notas_calendario = New System.Windows.Forms.Label()
        Me.meses = New System.Windows.Forms.NumericUpDown()
        Me.año_up = New System.Windows.Forms.NumericUpDown()
        Me.btn_ant_mes = New System.Windows.Forms.Button()
        Me.btn_sig_mes = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.Grupo_paciente = New System.Windows.Forms.GroupBox()
        Me.lbl_apellidos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_edad = New System.Windows.Forms.Label()
        Me.lbl_tipo_paciente = New System.Windows.Forms.Label()
        Me.lbl_nombres = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_num_hist = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Grupo_cita_med = New System.Windows.Forms.GroupBox()
        Me.cmb_especialidad = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Grupo_limites = New System.Windows.Forms.GroupBox()
        Me.lbl_total_pac_citado_x_tipocita = New System.Windows.Forms.Label()
        Me.lbl_cupos_disponibles = New System.Windows.Forms.Label()
        Me.lbl_total_paciente_citados_x_turno = New System.Windows.Forms.Label()
        Me.cmb_medico = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_tipo_cita = New System.Windows.Forms.ComboBox()
        Me.cmb_turno = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Lbl_paciente_fecha = New System.Windows.Forms.Label()
        Me.Grupo_Resumen = New System.Windows.Forms.GroupBox()
        Me.Lista_solicitudes = New System.Windows.Forms.ListView()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.botonera = New System.Windows.Forms.Panel()
        Me.Barra_botones = New System.Windows.Forms.ToolStrip()
        Me.btn_nueva_cita = New System.Windows.Forms.ToolStripButton()
        Me.btn_archivar_cita = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar_cita = New System.Windows.Forms.ToolStripButton()
        Me.btn_reporte = New System.Windows.Forms.ToolStripButton()
        Me.btn_cerrar = New System.Windows.Forms.ToolStripButton()
        Me.txt_atendido = New System.Windows.Forms.TextBox()
        Me.lbl_resultado_consulta = New System.Windows.Forms.Label()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_fecha.SuspendLayout()
        CType(Me.meses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.año_up, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_paciente.SuspendLayout()
        Me.Grupo_cita_med.SuspendLayout()
        Me.Grupo_limites.SuspendLayout()
        Me.Grupo_Resumen.SuspendLayout()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.botonera.SuspendLayout()
        Me.Barra_botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(16, 13)
        Me.Pic_icono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(62, 66)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 33
        Me.Pic_icono.TabStop = False
        '
        'Lbl_titulo
        '
        Me.Lbl_titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_titulo.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_titulo.Location = New System.Drawing.Point(89, 13)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(259, 49)
        Me.Lbl_titulo.TabIndex = 32
        Me.Lbl_titulo.Text = "CONTROL DE CITAS MÉDICAS"
        Me.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 661)
        Me.Pic_pie_pagina.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(1008, 69)
        Me.Pic_pie_pagina.TabIndex = 31
        Me.Pic_pie_pagina.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(215, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Pacientes citados por tipo cita ==>"
        Me.ToolTip1.SetToolTip(Me.Label7, "Total de pacientes citados por tipo de cita para el dia seleccionado")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(3, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(302, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Cupos disponibles para citas  ==>"
        Me.ToolTip1.SetToolTip(Me.Label5, "Total de citas disponibles")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Total Gral. pacientes por turno  =>"
        Me.ToolTip1.SetToolTip(Me.Label1, "Total de pacientes citados para el dia seleccionado")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(187, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 17)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Máximo permitido:"
        Me.ToolTip1.SetToolTip(Me.Label11, "Máximo permitido por dia para el tipo de cita seleccionado")
        '
        'lbl_max_pac_por_tipo_cita
        '
        Me.lbl_max_pac_por_tipo_cita.AutoSize = True
        Me.lbl_max_pac_por_tipo_cita.BackColor = System.Drawing.Color.Transparent
        Me.lbl_max_pac_por_tipo_cita.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_max_pac_por_tipo_cita.Location = New System.Drawing.Point(308, 171)
        Me.lbl_max_pac_por_tipo_cita.Name = "lbl_max_pac_por_tipo_cita"
        Me.lbl_max_pac_por_tipo_cita.Size = New System.Drawing.Size(15, 17)
        Me.lbl_max_pac_por_tipo_cita.TabIndex = 38
        Me.lbl_max_pac_por_tipo_cita.Tag = "limpiar"
        Me.lbl_max_pac_por_tipo_cita.Text = "0"
        Me.ToolTip1.SetToolTip(Me.lbl_max_pac_por_tipo_cita, "Máximo permitido por dia para el tipo de cita seleccionado")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(186, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Máximo permitido:"
        Me.ToolTip1.SetToolTip(Me.Label4, "Máximo de pacientes permitido por dia para el turno seleccionado")
        '
        'lbl_max_por_dia_especialidad
        '
        Me.lbl_max_por_dia_especialidad.AutoSize = True
        Me.lbl_max_por_dia_especialidad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_max_por_dia_especialidad.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_max_por_dia_especialidad.Location = New System.Drawing.Point(308, 73)
        Me.lbl_max_por_dia_especialidad.Name = "lbl_max_por_dia_especialidad"
        Me.lbl_max_por_dia_especialidad.Size = New System.Drawing.Size(15, 17)
        Me.lbl_max_por_dia_especialidad.TabIndex = 40
        Me.lbl_max_por_dia_especialidad.Tag = "limpiar"
        Me.lbl_max_por_dia_especialidad.Text = "0"
        Me.ToolTip1.SetToolTip(Me.lbl_max_por_dia_especialidad, "Máximo de pacientes permitido por dia para el turno seleccionado")
        '
        'btn_prox_mes
        '
        Me.btn_prox_mes.BackColor = System.Drawing.Color.LightBlue
        Me.btn_prox_mes.Location = New System.Drawing.Point(171, 272)
        Me.btn_prox_mes.Name = "btn_prox_mes"
        Me.btn_prox_mes.Size = New System.Drawing.Size(64, 28)
        Me.btn_prox_mes.TabIndex = 7
        Me.btn_prox_mes.Text = "Mes"
        Me.ToolTip1.SetToolTip(Me.btn_prox_mes, "Calcula la fecha de la próxima cita a partir de el número de meses suministrado")
        Me.btn_prox_mes.UseVisualStyleBackColor = False
        '
        'btn_prox
        '
        Me.btn_prox.BackColor = System.Drawing.Color.LightBlue
        Me.btn_prox.Location = New System.Drawing.Point(6, 272)
        Me.btn_prox.Name = "btn_prox"
        Me.btn_prox.Size = New System.Drawing.Size(102, 28)
        Me.btn_prox.TabIndex = 5
        Me.btn_prox.Text = "Próx. día disp."
        Me.ToolTip1.SetToolTip(Me.btn_prox, "Calcular el día más cercano con cupo disponible")
        Me.btn_prox.UseVisualStyleBackColor = False
        '
        'Progreso_espera
        '
        Me.Progreso_espera.Location = New System.Drawing.Point(9, 248)
        Me.Progreso_espera.Name = "Progreso_espera"
        Me.Progreso_espera.Size = New System.Drawing.Size(224, 23)
        Me.Progreso_espera.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.Progreso_espera.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.Progreso_espera, "Espere...")
        Me.Progreso_espera.Value = 100
        '
        'btn_atendido
        '
        Me.btn_atendido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_atendido.BackColor = System.Drawing.Color.LightBlue
        Me.btn_atendido.Image = CType(resources.GetObject("btn_atendido.Image"), System.Drawing.Image)
        Me.btn_atendido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_atendido.Location = New System.Drawing.Point(910, 629)
        Me.btn_atendido.Name = "btn_atendido"
        Me.btn_atendido.Size = New System.Drawing.Size(86, 53)
        Me.btn_atendido.TabIndex = 52
        Me.btn_atendido.Text = "&Atendido"
        Me.btn_atendido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_atendido, "Paciente atendido")
        Me.btn_atendido.UseVisualStyleBackColor = False
        '
        'Lista_pacientes_dia
        '
        Me.Lista_pacientes_dia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lista_pacientes_dia.CheckBoxes = True
        Me.Lista_pacientes_dia.FullRowSelect = True
        Me.Lista_pacientes_dia.GridLines = True
        ListViewItem1.StateImageIndex = 0
        Me.Lista_pacientes_dia.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.Lista_pacientes_dia.Location = New System.Drawing.Point(622, 92)
        Me.Lista_pacientes_dia.Name = "Lista_pacientes_dia"
        Me.Lista_pacientes_dia.ShowItemToolTips = True
        Me.Lista_pacientes_dia.Size = New System.Drawing.Size(374, 517)
        Me.Lista_pacientes_dia.TabIndex = 0
        Me.Lista_pacientes_dia.UseCompatibleStateImageBehavior = False
        Me.Lista_pacientes_dia.View = System.Windows.Forms.View.Details
        '
        'Grupo_fecha
        '
        Me.Grupo_fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grupo_fecha.Controls.Add(Me.Progreso_espera)
        Me.Grupo_fecha.Controls.Add(Me.lbl_notas_calendario)
        Me.Grupo_fecha.Controls.Add(Me.meses)
        Me.Grupo_fecha.Controls.Add(Me.btn_prox_mes)
        Me.Grupo_fecha.Controls.Add(Me.btn_prox)
        Me.Grupo_fecha.Controls.Add(Me.año_up)
        Me.Grupo_fecha.Controls.Add(Me.btn_ant_mes)
        Me.Grupo_fecha.Controls.Add(Me.btn_sig_mes)
        Me.Grupo_fecha.Controls.Add(Me.Label3)
        Me.Grupo_fecha.Controls.Add(Me.cmb_mes)
        Me.Grupo_fecha.Controls.Add(Me.Calendario)
        Me.Grupo_fecha.Location = New System.Drawing.Point(375, 359)
        Me.Grupo_fecha.Name = "Grupo_fecha"
        Me.Grupo_fecha.Size = New System.Drawing.Size(241, 323)
        Me.Grupo_fecha.TabIndex = 40
        Me.Grupo_fecha.TabStop = False
        Me.Grupo_fecha.Text = "Fecha"
        '
        'lbl_notas_calendario
        '
        Me.lbl_notas_calendario.AutoSize = True
        Me.lbl_notas_calendario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_notas_calendario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notas_calendario.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_notas_calendario.Location = New System.Drawing.Point(6, 252)
        Me.lbl_notas_calendario.Name = "lbl_notas_calendario"
        Me.lbl_notas_calendario.Size = New System.Drawing.Size(54, 17)
        Me.lbl_notas_calendario.TabIndex = 51
        Me.lbl_notas_calendario.Tag = "limpiar"
        Me.lbl_notas_calendario.Text = "NOTAS:"
        Me.lbl_notas_calendario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'meses
        '
        Me.meses.Location = New System.Drawing.Point(110, 272)
        Me.meses.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.meses.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.meses.Name = "meses"
        Me.meses.Size = New System.Drawing.Size(55, 25)
        Me.meses.TabIndex = 6
        Me.meses.Tag = ""
        Me.meses.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'año_up
        '
        Me.año_up.Location = New System.Drawing.Point(80, 55)
        Me.año_up.Maximum = New Decimal(New Integer() {9998, 0, 0, 0})
        Me.año_up.Minimum = New Decimal(New Integer() {2011, 0, 0, 0})
        Me.año_up.Name = "año_up"
        Me.año_up.Size = New System.Drawing.Size(120, 25)
        Me.año_up.TabIndex = 3
        Me.año_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.año_up.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'btn_ant_mes
        '
        Me.btn_ant_mes.Enabled = False
        Me.btn_ant_mes.Image = CType(resources.GetObject("btn_ant_mes.Image"), System.Drawing.Image)
        Me.btn_ant_mes.Location = New System.Drawing.Point(6, 24)
        Me.btn_ant_mes.Name = "btn_ant_mes"
        Me.btn_ant_mes.Size = New System.Drawing.Size(27, 23)
        Me.btn_ant_mes.TabIndex = 0
        Me.btn_ant_mes.UseVisualStyleBackColor = True
        '
        'btn_sig_mes
        '
        Me.btn_sig_mes.Image = CType(resources.GetObject("btn_sig_mes.Image"), System.Drawing.Image)
        Me.btn_sig_mes.Location = New System.Drawing.Point(206, 24)
        Me.btn_sig_mes.Name = "btn_sig_mes"
        Me.btn_sig_mes.Size = New System.Drawing.Size(27, 23)
        Me.btn_sig_mes.TabIndex = 2
        Me.btn_sig_mes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Año"
        '
        'cmb_mes
        '
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Location = New System.Drawing.Point(39, 24)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(161, 25)
        Me.cmb_mes.TabIndex = 1
        Me.cmb_mes.Tag = "nolimpiar"
        '
        'Calendario
        '
        Me.Calendario.BackColor = System.Drawing.Color.White
        Me.Calendario.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.Calendario.Location = New System.Drawing.Point(6, 88)
        Me.Calendario.MaxSelectionCount = 1
        Me.Calendario.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 4
        Me.Calendario.TitleBackColor = System.Drawing.Color.DarkCyan
        '
        'Grupo_paciente
        '
        Me.Grupo_paciente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grupo_paciente.Controls.Add(Me.lbl_apellidos)
        Me.Grupo_paciente.Controls.Add(Me.Label9)
        Me.Grupo_paciente.Controls.Add(Me.lbl_edad)
        Me.Grupo_paciente.Controls.Add(Me.lbl_tipo_paciente)
        Me.Grupo_paciente.Controls.Add(Me.lbl_nombres)
        Me.Grupo_paciente.Controls.Add(Me.Label6)
        Me.Grupo_paciente.Controls.Add(Me.lbl_num_hist)
        Me.Grupo_paciente.Controls.Add(Me.Label2)
        Me.Grupo_paciente.Location = New System.Drawing.Point(257, 92)
        Me.Grupo_paciente.Name = "Grupo_paciente"
        Me.Grupo_paciente.Size = New System.Drawing.Size(359, 261)
        Me.Grupo_paciente.TabIndex = 41
        Me.Grupo_paciente.TabStop = False
        Me.Grupo_paciente.Text = "Paciente"
        '
        'lbl_apellidos
        '
        Me.lbl_apellidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_apellidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_apellidos.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellidos.Location = New System.Drawing.Point(6, 167)
        Me.lbl_apellidos.Name = "lbl_apellidos"
        Me.lbl_apellidos.Size = New System.Drawing.Size(345, 36)
        Me.lbl_apellidos.TabIndex = 8
        Me.lbl_apellidos.Tag = "limpiar"
        Me.lbl_apellidos.Text = "DEL SISTEMA"
        Me.lbl_apellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "APELLIDOS"
        '
        'lbl_edad
        '
        Me.lbl_edad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.Location = New System.Drawing.Point(6, 233)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(101, 17)
        Me.lbl_edad.TabIndex = 6
        Me.lbl_edad.Tag = "limpiar"
        Me.lbl_edad.Text = "EDAD: 00 AÑOS"
        '
        'lbl_tipo_paciente
        '
        Me.lbl_tipo_paciente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_tipo_paciente.AutoSize = True
        Me.lbl_tipo_paciente.Location = New System.Drawing.Point(6, 203)
        Me.lbl_tipo_paciente.Name = "lbl_tipo_paciente"
        Me.lbl_tipo_paciente.Size = New System.Drawing.Size(170, 17)
        Me.lbl_tipo_paciente.TabIndex = 5
        Me.lbl_tipo_paciente.Tag = "limpiar"
        Me.lbl_tipo_paciente.Text = "TIPO PACIENTE: COTIZANTE"
        '
        'lbl_nombres
        '
        Me.lbl_nombres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_nombres.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombres.Location = New System.Drawing.Point(6, 105)
        Me.lbl_nombres.Name = "lbl_nombres"
        Me.lbl_nombres.Size = New System.Drawing.Size(345, 36)
        Me.lbl_nombres.TabIndex = 4
        Me.lbl_nombres.Tag = "limpiar"
        Me.lbl_nombres.Text = "ADMINISTRADOR"
        Me.lbl_nombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "NOMBRES"
        '
        'lbl_num_hist
        '
        Me.lbl_num_hist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_num_hist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_num_hist.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num_hist.Location = New System.Drawing.Point(6, 44)
        Me.lbl_num_hist.Name = "lbl_num_hist"
        Me.lbl_num_hist.Size = New System.Drawing.Size(345, 36)
        Me.lbl_num_hist.TabIndex = 1
        Me.lbl_num_hist.Tag = "limpiar"
        Me.lbl_num_hist.Text = "NCI-000"
        Me.lbl_num_hist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nº HISTORIA"
        '
        'Grupo_cita_med
        '
        Me.Grupo_cita_med.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grupo_cita_med.Controls.Add(Me.Label4)
        Me.Grupo_cita_med.Controls.Add(Me.cmb_especialidad)
        Me.Grupo_cita_med.Controls.Add(Me.Label10)
        Me.Grupo_cita_med.Controls.Add(Me.Label11)
        Me.Grupo_cita_med.Controls.Add(Me.lbl_max_pac_por_tipo_cita)
        Me.Grupo_cita_med.Controls.Add(Me.lbl_max_por_dia_especialidad)
        Me.Grupo_cita_med.Controls.Add(Me.Label15)
        Me.Grupo_cita_med.Controls.Add(Me.Grupo_limites)
        Me.Grupo_cita_med.Controls.Add(Me.cmb_medico)
        Me.Grupo_cita_med.Controls.Add(Me.Label13)
        Me.Grupo_cita_med.Controls.Add(Me.cmb_tipo_cita)
        Me.Grupo_cita_med.Controls.Add(Me.cmb_turno)
        Me.Grupo_cita_med.Controls.Add(Me.Label12)
        Me.Grupo_cita_med.Location = New System.Drawing.Point(7, 354)
        Me.Grupo_cita_med.Name = "Grupo_cita_med"
        Me.Grupo_cita_med.Size = New System.Drawing.Size(361, 328)
        Me.Grupo_cita_med.TabIndex = 42
        Me.Grupo_cita_med.TabStop = False
        Me.Grupo_cita_med.Text = "Cita médica"
        '
        'cmb_especialidad
        '
        Me.cmb_especialidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_especialidad.FormattingEnabled = True
        Me.cmb_especialidad.Location = New System.Drawing.Point(5, 45)
        Me.cmb_especialidad.Name = "cmb_especialidad"
        Me.cmb_especialidad.Size = New System.Drawing.Size(347, 25)
        Me.cmb_especialidad.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "ESPECIALIDAD"
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 17)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "MÉDICO"
        '
        'Grupo_limites
        '
        Me.Grupo_limites.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grupo_limites.Controls.Add(Me.lbl_total_pac_citado_x_tipocita)
        Me.Grupo_limites.Controls.Add(Me.Label7)
        Me.Grupo_limites.Controls.Add(Me.lbl_cupos_disponibles)
        Me.Grupo_limites.Controls.Add(Me.Label5)
        Me.Grupo_limites.Controls.Add(Me.lbl_total_paciente_citados_x_turno)
        Me.Grupo_limites.Controls.Add(Me.Label1)
        Me.Grupo_limites.Location = New System.Drawing.Point(6, 214)
        Me.Grupo_limites.Name = "Grupo_limites"
        Me.Grupo_limites.Size = New System.Drawing.Size(349, 108)
        Me.Grupo_limites.TabIndex = 12
        Me.Grupo_limites.TabStop = False
        '
        'lbl_total_pac_citado_x_tipocita
        '
        Me.lbl_total_pac_citado_x_tipocita.AutoSize = True
        Me.lbl_total_pac_citado_x_tipocita.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_pac_citado_x_tipocita.Location = New System.Drawing.Point(219, 10)
        Me.lbl_total_pac_citado_x_tipocita.Name = "lbl_total_pac_citado_x_tipocita"
        Me.lbl_total_pac_citado_x_tipocita.Size = New System.Drawing.Size(22, 25)
        Me.lbl_total_pac_citado_x_tipocita.TabIndex = 31
        Me.lbl_total_pac_citado_x_tipocita.Tag = "limpiar"
        Me.lbl_total_pac_citado_x_tipocita.Text = "0"
        '
        'lbl_cupos_disponibles
        '
        Me.lbl_cupos_disponibles.AutoSize = True
        Me.lbl_cupos_disponibles.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cupos_disponibles.ForeColor = System.Drawing.Color.Firebrick
        Me.lbl_cupos_disponibles.Location = New System.Drawing.Point(302, 63)
        Me.lbl_cupos_disponibles.Name = "lbl_cupos_disponibles"
        Me.lbl_cupos_disponibles.Size = New System.Drawing.Size(23, 25)
        Me.lbl_cupos_disponibles.TabIndex = 25
        Me.lbl_cupos_disponibles.Tag = "limpiar"
        Me.lbl_cupos_disponibles.Text = "0"
        '
        'lbl_total_paciente_citados_x_turno
        '
        Me.lbl_total_paciente_citados_x_turno.AutoSize = True
        Me.lbl_total_paciente_citados_x_turno.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_paciente_citados_x_turno.Location = New System.Drawing.Point(219, 37)
        Me.lbl_total_paciente_citados_x_turno.Name = "lbl_total_paciente_citados_x_turno"
        Me.lbl_total_paciente_citados_x_turno.Size = New System.Drawing.Size(22, 25)
        Me.lbl_total_paciente_citados_x_turno.TabIndex = 23
        Me.lbl_total_paciente_citados_x_turno.Tag = "limpiar"
        Me.lbl_total_paciente_citados_x_turno.Text = "0"
        '
        'cmb_medico
        '
        Me.cmb_medico.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_medico.FormattingEnabled = True
        Me.cmb_medico.Location = New System.Drawing.Point(6, 141)
        Me.cmb_medico.Name = "cmb_medico"
        Me.cmb_medico.Size = New System.Drawing.Size(349, 25)
        Me.cmb_medico.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 171)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "TIPO DE CITA     ==>"
        '
        'cmb_tipo_cita
        '
        Me.cmb_tipo_cita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_tipo_cita.FormattingEnabled = True
        Me.cmb_tipo_cita.Location = New System.Drawing.Point(6, 191)
        Me.cmb_tipo_cita.Name = "cmb_tipo_cita"
        Me.cmb_tipo_cita.Size = New System.Drawing.Size(349, 25)
        Me.cmb_tipo_cita.TabIndex = 3
        '
        'cmb_turno
        '
        Me.cmb_turno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_turno.FormattingEnabled = True
        Me.cmb_turno.Location = New System.Drawing.Point(5, 93)
        Me.cmb_turno.Name = "cmb_turno"
        Me.cmb_turno.Size = New System.Drawing.Size(349, 25)
        Me.cmb_turno.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(2, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "TURNO             ==>"
        '
        'Lbl_paciente_fecha
        '
        Me.Lbl_paciente_fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_paciente_fecha.AutoSize = True
        Me.Lbl_paciente_fecha.Location = New System.Drawing.Point(619, 72)
        Me.Lbl_paciente_fecha.Name = "Lbl_paciente_fecha"
        Me.Lbl_paciente_fecha.Size = New System.Drawing.Size(122, 17)
        Me.Lbl_paciente_fecha.TabIndex = 47
        Me.Lbl_paciente_fecha.Tag = "limpiar"
        Me.Lbl_paciente_fecha.Text = "PACIENTES DEL DÍA"
        '
        'Grupo_Resumen
        '
        Me.Grupo_Resumen.Controls.Add(Me.Lista_solicitudes)
        Me.Grupo_Resumen.Location = New System.Drawing.Point(7, 92)
        Me.Grupo_Resumen.Name = "Grupo_Resumen"
        Me.Grupo_Resumen.Size = New System.Drawing.Size(241, 259)
        Me.Grupo_Resumen.TabIndex = 48
        Me.Grupo_Resumen.TabStop = False
        Me.Grupo_Resumen.Text = "Resumen del solicitudes"
        '
        'Lista_solicitudes
        '
        Me.Lista_solicitudes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lista_solicitudes.Location = New System.Drawing.Point(9, 21)
        Me.Lista_solicitudes.Name = "Lista_solicitudes"
        Me.Lista_solicitudes.Size = New System.Drawing.Size(224, 232)
        Me.Lista_solicitudes.TabIndex = 0
        Me.Lista_solicitudes.Tag = "limpiar"
        Me.Lista_solicitudes.UseCompatibleStateImageBehavior = False
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Encabezado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(1008, 79)
        Me.Pic_Encabezado.TabIndex = 50
        Me.Pic_Encabezado.TabStop = False
        '
        'botonera
        '
        Me.botonera.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botonera.BackColor = System.Drawing.Color.Transparent
        Me.botonera.Controls.Add(Me.Barra_botones)
        Me.botonera.Location = New System.Drawing.Point(354, 23)
        Me.botonera.Name = "botonera"
        Me.botonera.Size = New System.Drawing.Size(642, 56)
        Me.botonera.TabIndex = 51
        '
        'Barra_botones
        '
        Me.Barra_botones.BackColor = System.Drawing.Color.Transparent
        Me.Barra_botones.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.Barra_botones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_nueva_cita, Me.btn_archivar_cita, Me.btn_eliminar, Me.btn_cancelar_cita, Me.btn_reporte, Me.btn_cerrar})
        Me.Barra_botones.Location = New System.Drawing.Point(0, 0)
        Me.Barra_botones.Name = "Barra_botones"
        Me.Barra_botones.Size = New System.Drawing.Size(642, 39)
        Me.Barra_botones.TabIndex = 51
        '
        'btn_nueva_cita
        '
        Me.btn_nueva_cita.Image = CType(resources.GetObject("btn_nueva_cita.Image"), System.Drawing.Image)
        Me.btn_nueva_cita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_nueva_cita.Name = "btn_nueva_cita"
        Me.btn_nueva_cita.Size = New System.Drawing.Size(99, 36)
        Me.btn_nueva_cita.Text = "Nueva cita"
        '
        'btn_archivar_cita
        '
        Me.btn_archivar_cita.Enabled = False
        Me.btn_archivar_cita.Image = CType(resources.GetObject("btn_archivar_cita.Image"), System.Drawing.Image)
        Me.btn_archivar_cita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_archivar_cita.Name = "btn_archivar_cita"
        Me.btn_archivar_cita.Size = New System.Drawing.Size(87, 36)
        Me.btn_archivar_cita.Text = "Archivar"
        Me.btn_archivar_cita.ToolTipText = "Archivar cita medica"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(108, 36)
        Me.btn_eliminar.Text = "Eliminar cita"
        Me.btn_eliminar.ToolTipText = "Eliminar cita seleccionada"
        '
        'btn_cancelar_cita
        '
        Me.btn_cancelar_cita.Image = CType(resources.GetObject("btn_cancelar_cita.Image"), System.Drawing.Image)
        Me.btn_cancelar_cita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar_cita.Name = "btn_cancelar_cita"
        Me.btn_cancelar_cita.Size = New System.Drawing.Size(116, 36)
        Me.btn_cancelar_cita.Text = "Cancelar citas"
        Me.btn_cancelar_cita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar_cita.ToolTipText = "Cancelar citas seleccionadas"
        '
        'btn_reporte
        '
        Me.btn_reporte.Image = CType(resources.GetObject("btn_reporte.Image"), System.Drawing.Image)
        Me.btn_reporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(84, 36)
        Me.btn_reporte.Text = "Reporte"
        Me.btn_reporte.ToolTipText = "Listado de citas del dia"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btn_cerrar.Image = CType(resources.GetObject("btn_cerrar.Image"), System.Drawing.Image)
        Me.btn_cerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 36)
        Me.btn_cerrar.Text = "Cerrar"
        '
        'txt_atendido
        '
        Me.txt_atendido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_atendido.BackColor = System.Drawing.Color.Khaki
        Me.txt_atendido.Location = New System.Drawing.Point(622, 629)
        Me.txt_atendido.MaxLength = 400
        Me.txt_atendido.Multiline = True
        Me.txt_atendido.Name = "txt_atendido"
        Me.txt_atendido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_atendido.Size = New System.Drawing.Size(282, 53)
        Me.txt_atendido.TabIndex = 53
        '
        'lbl_resultado_consulta
        '
        Me.lbl_resultado_consulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_resultado_consulta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_resultado_consulta.Location = New System.Drawing.Point(622, 605)
        Me.lbl_resultado_consulta.Name = "lbl_resultado_consulta"
        Me.lbl_resultado_consulta.Size = New System.Drawing.Size(230, 23)
        Me.lbl_resultado_consulta.TabIndex = 54
        Me.lbl_resultado_consulta.Text = "Resultado de la consulta:"
        Me.lbl_resultado_consulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_control_cita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.txt_atendido)
        Me.Controls.Add(Me.btn_atendido)
        Me.Controls.Add(Me.Lbl_paciente_fecha)
        Me.Controls.Add(Me.botonera)
        Me.Controls.Add(Me.Grupo_Resumen)
        Me.Controls.Add(Me.Grupo_cita_med)
        Me.Controls.Add(Me.Grupo_paciente)
        Me.Controls.Add(Me.Grupo_fecha)
        Me.Controls.Add(Me.Lista_pacientes_dia)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Controls.Add(Me.lbl_resultado_consulta)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_control_cita"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_fecha.ResumeLayout(False)
        Me.Grupo_fecha.PerformLayout()
        CType(Me.meses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.año_up, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_paciente.ResumeLayout(False)
        Me.Grupo_paciente.PerformLayout()
        Me.Grupo_cita_med.ResumeLayout(False)
        Me.Grupo_cita_med.PerformLayout()
        Me.Grupo_limites.ResumeLayout(False)
        Me.Grupo_limites.PerformLayout()
        Me.Grupo_Resumen.ResumeLayout(False)
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.botonera.ResumeLayout(False)
        Me.botonera.PerformLayout()
        Me.Barra_botones.ResumeLayout(False)
        Me.Barra_botones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Lista_pacientes_dia As System.Windows.Forms.ListView
    Friend WithEvents Grupo_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents año_up As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_ant_mes As System.Windows.Forms.Button
    Friend WithEvents btn_sig_mes As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents Grupo_paciente As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_num_hist As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_edad As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_paciente As System.Windows.Forms.Label
    Friend WithEvents lbl_nombres As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Grupo_cita_med As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_apellidos As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_cita As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmb_turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmb_especialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_paciente_fecha As System.Windows.Forms.Label
    Friend WithEvents Grupo_Resumen As System.Windows.Forms.GroupBox
    Friend WithEvents Lista_solicitudes As System.Windows.Forms.ListView
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents botonera As System.Windows.Forms.Panel
    Friend WithEvents Barra_botones As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_nueva_cita As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_archivar_cita As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_eliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_reporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Grupo_limites As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_total_pac_citado_x_tipocita As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_cupos_disponibles As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_total_paciente_citados_x_turno As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_max_por_dia_especialidad As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_max_pac_por_tipo_cita As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_medico As System.Windows.Forms.ComboBox
    Friend WithEvents meses As System.Windows.Forms.NumericUpDown
    Friend WithEvents btn_prox_mes As System.Windows.Forms.Button
    Friend WithEvents btn_prox As System.Windows.Forms.Button
    Friend WithEvents lbl_notas_calendario As System.Windows.Forms.Label
    Friend WithEvents Progreso_espera As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_cancelar_cita As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_atendido As System.Windows.Forms.Button
    Friend WithEvents txt_atendido As System.Windows.Forms.TextBox
    Friend WithEvents lbl_resultado_consulta As System.Windows.Forms.Label
End Class
