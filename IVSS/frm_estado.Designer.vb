<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_estados))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_busca_estado = New System.Windows.Forms.Button()
        Me.btn_estado_guardar = New System.Windows.Forms.Button()
        Me.btn_est_eliminar = New System.Windows.Forms.Button()
        Me.btn_ciudad_buscar = New System.Windows.Forms.Button()
        Me.btn_ciud_guardar = New System.Windows.Forms.Button()
        Me.btn_ciud_elim = New System.Windows.Forms.Button()
        Me.btn_ciud_nuevo = New System.Windows.Forms.Button()
        Me.btn_est_nuevo = New System.Windows.Forms.Button()
        Me.btn_nuevo_nac = New System.Windows.Forms.Button()
        Me.btn_buscar_nac = New System.Windows.Forms.Button()
        Me.btn_archivar_nac = New System.Windows.Forms.Button()
        Me.btn_elim_nac = New System.Windows.Forms.Button()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Estados_ciudades = New System.Windows.Forms.TabPage()
        Me.Grupo_Estados = New System.Windows.Forms.GroupBox()
        Me.chk_estado_visible = New System.Windows.Forms.CheckBox()
        Me.txt_nombre_estado = New System.Windows.Forms.TextBox()
        Me.txt_cod_estado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lv_estado = New System.Windows.Forms.ListView()
        Me.lv_ciudades = New System.Windows.Forms.ListView()
        Me.Grupo_Ciudad = New System.Windows.Forms.GroupBox()
        Me.chk_ciudad_visible = New System.Windows.Forms.CheckBox()
        Me.txt_nombre_ciudad = New System.Windows.Forms.TextBox()
        Me.txt_cod_ciudad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nacionalidades = New System.Windows.Forms.TabPage()
        Me.Grupo_nacionalidades = New System.Windows.Forms.GroupBox()
        Me.chk_nac_visible = New System.Windows.Forms.CheckBox()
        Me.txt_nacionalidad = New System.Windows.Forms.TextBox()
        Me.txt_cod_nac = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lista_nacionalidades = New System.Windows.Forms.ListView()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Estados_ciudades.SuspendLayout()
        Me.Grupo_Estados.SuspendLayout()
        Me.Grupo_Ciudad.SuspendLayout()
        Me.Nacionalidades.SuspendLayout()
        Me.Grupo_nacionalidades.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(16, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 36)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "&Nuevo"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button3, "Agregar nuevo estado")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'btn_busca_estado
        '
        Me.btn_busca_estado.BackColor = System.Drawing.Color.LightBlue
        Me.btn_busca_estado.Image = CType(resources.GetObject("btn_busca_estado.Image"), System.Drawing.Image)
        Me.btn_busca_estado.Location = New System.Drawing.Point(91, 72)
        Me.btn_busca_estado.Name = "btn_busca_estado"
        Me.btn_busca_estado.Size = New System.Drawing.Size(26, 23)
        Me.btn_busca_estado.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btn_busca_estado, "Buscar estado")
        Me.btn_busca_estado.UseVisualStyleBackColor = False
        '
        'btn_estado_guardar
        '
        Me.btn_estado_guardar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_estado_guardar.Enabled = False
        Me.btn_estado_guardar.Image = CType(resources.GetObject("btn_estado_guardar.Image"), System.Drawing.Image)
        Me.btn_estado_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_estado_guardar.Location = New System.Drawing.Point(123, 71)
        Me.btn_estado_guardar.Name = "btn_estado_guardar"
        Me.btn_estado_guardar.Size = New System.Drawing.Size(81, 24)
        Me.btn_estado_guardar.TabIndex = 2
        Me.btn_estado_guardar.Text = "&Agregar"
        Me.btn_estado_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_estado_guardar, "Agregar / actualizar")
        Me.btn_estado_guardar.UseVisualStyleBackColor = False
        '
        'btn_est_eliminar
        '
        Me.btn_est_eliminar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_est_eliminar.Enabled = False
        Me.btn_est_eliminar.Image = CType(resources.GetObject("btn_est_eliminar.Image"), System.Drawing.Image)
        Me.btn_est_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_eliminar.Location = New System.Drawing.Point(210, 71)
        Me.btn_est_eliminar.Name = "btn_est_eliminar"
        Me.btn_est_eliminar.Size = New System.Drawing.Size(81, 24)
        Me.btn_est_eliminar.TabIndex = 3
        Me.btn_est_eliminar.Text = "&Eliminar"
        Me.btn_est_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_est_eliminar, "Eliminar estado")
        Me.btn_est_eliminar.UseVisualStyleBackColor = False
        '
        'btn_ciudad_buscar
        '
        Me.btn_ciudad_buscar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_ciudad_buscar.Image = CType(resources.GetObject("btn_ciudad_buscar.Image"), System.Drawing.Image)
        Me.btn_ciudad_buscar.Location = New System.Drawing.Point(86, 71)
        Me.btn_ciudad_buscar.Name = "btn_ciudad_buscar"
        Me.btn_ciudad_buscar.Size = New System.Drawing.Size(26, 24)
        Me.btn_ciudad_buscar.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.btn_ciudad_buscar, "Buscar ciudad")
        Me.btn_ciudad_buscar.UseVisualStyleBackColor = False
        '
        'btn_ciud_guardar
        '
        Me.btn_ciud_guardar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_ciud_guardar.Enabled = False
        Me.btn_ciud_guardar.Image = CType(resources.GetObject("btn_ciud_guardar.Image"), System.Drawing.Image)
        Me.btn_ciud_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ciud_guardar.Location = New System.Drawing.Point(118, 71)
        Me.btn_ciud_guardar.Name = "btn_ciud_guardar"
        Me.btn_ciud_guardar.Size = New System.Drawing.Size(81, 24)
        Me.btn_ciud_guardar.TabIndex = 8
        Me.btn_ciud_guardar.Text = "&Agregar"
        Me.btn_ciud_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_ciud_guardar, "Agregar / actualizar")
        Me.btn_ciud_guardar.UseVisualStyleBackColor = False
        '
        'btn_ciud_elim
        '
        Me.btn_ciud_elim.BackColor = System.Drawing.Color.LightBlue
        Me.btn_ciud_elim.Enabled = False
        Me.btn_ciud_elim.Image = CType(resources.GetObject("btn_ciud_elim.Image"), System.Drawing.Image)
        Me.btn_ciud_elim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ciud_elim.Location = New System.Drawing.Point(205, 71)
        Me.btn_ciud_elim.Name = "btn_ciud_elim"
        Me.btn_ciud_elim.Size = New System.Drawing.Size(81, 24)
        Me.btn_ciud_elim.TabIndex = 9
        Me.btn_ciud_elim.Text = "&Eliminar"
        Me.btn_ciud_elim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_ciud_elim, "Eliminar ciudad")
        Me.btn_ciud_elim.UseVisualStyleBackColor = False
        '
        'btn_ciud_nuevo
        '
        Me.btn_ciud_nuevo.BackColor = System.Drawing.Color.LightBlue
        Me.btn_ciud_nuevo.Image = CType(resources.GetObject("btn_ciud_nuevo.Image"), System.Drawing.Image)
        Me.btn_ciud_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ciud_nuevo.Location = New System.Drawing.Point(6, 71)
        Me.btn_ciud_nuevo.Name = "btn_ciud_nuevo"
        Me.btn_ciud_nuevo.Size = New System.Drawing.Size(71, 24)
        Me.btn_ciud_nuevo.TabIndex = 10
        Me.btn_ciud_nuevo.Text = "&Nuevo"
        Me.btn_ciud_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_ciud_nuevo, "Agregar nueva ciudad")
        Me.btn_ciud_nuevo.UseVisualStyleBackColor = False
        '
        'btn_est_nuevo
        '
        Me.btn_est_nuevo.BackColor = System.Drawing.Color.LightBlue
        Me.btn_est_nuevo.Image = CType(resources.GetObject("btn_est_nuevo.Image"), System.Drawing.Image)
        Me.btn_est_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_nuevo.Location = New System.Drawing.Point(9, 70)
        Me.btn_est_nuevo.Name = "btn_est_nuevo"
        Me.btn_est_nuevo.Size = New System.Drawing.Size(71, 24)
        Me.btn_est_nuevo.TabIndex = 18
        Me.btn_est_nuevo.Text = "&Nuevo"
        Me.btn_est_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_est_nuevo, "Agregar nueva ciudad")
        Me.btn_est_nuevo.UseVisualStyleBackColor = False
        '
        'btn_nuevo_nac
        '
        Me.btn_nuevo_nac.BackColor = System.Drawing.Color.LightBlue
        Me.btn_nuevo_nac.Image = CType(resources.GetObject("btn_nuevo_nac.Image"), System.Drawing.Image)
        Me.btn_nuevo_nac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_nac.Location = New System.Drawing.Point(9, 170)
        Me.btn_nuevo_nac.Name = "btn_nuevo_nac"
        Me.btn_nuevo_nac.Size = New System.Drawing.Size(78, 24)
        Me.btn_nuevo_nac.TabIndex = 18
        Me.btn_nuevo_nac.Text = "&Nuevo"
        Me.btn_nuevo_nac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_nuevo_nac, "Agregar nueva ciudad")
        Me.btn_nuevo_nac.UseVisualStyleBackColor = False
        '
        'btn_buscar_nac
        '
        Me.btn_buscar_nac.BackColor = System.Drawing.Color.LightBlue
        Me.btn_buscar_nac.Image = CType(resources.GetObject("btn_buscar_nac.Image"), System.Drawing.Image)
        Me.btn_buscar_nac.Location = New System.Drawing.Point(86, 39)
        Me.btn_buscar_nac.Name = "btn_buscar_nac"
        Me.btn_buscar_nac.Size = New System.Drawing.Size(26, 23)
        Me.btn_buscar_nac.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btn_buscar_nac, "Buscar estado")
        Me.btn_buscar_nac.UseVisualStyleBackColor = False
        '
        'btn_archivar_nac
        '
        Me.btn_archivar_nac.BackColor = System.Drawing.Color.LightBlue
        Me.btn_archivar_nac.Enabled = False
        Me.btn_archivar_nac.Image = CType(resources.GetObject("btn_archivar_nac.Image"), System.Drawing.Image)
        Me.btn_archivar_nac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_archivar_nac.Location = New System.Drawing.Point(104, 170)
        Me.btn_archivar_nac.Name = "btn_archivar_nac"
        Me.btn_archivar_nac.Size = New System.Drawing.Size(92, 24)
        Me.btn_archivar_nac.TabIndex = 2
        Me.btn_archivar_nac.Text = "&Agregar"
        Me.btn_archivar_nac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_archivar_nac, "Agregar / actualizar")
        Me.btn_archivar_nac.UseVisualStyleBackColor = False
        '
        'btn_elim_nac
        '
        Me.btn_elim_nac.BackColor = System.Drawing.Color.LightBlue
        Me.btn_elim_nac.Enabled = False
        Me.btn_elim_nac.Image = CType(resources.GetObject("btn_elim_nac.Image"), System.Drawing.Image)
        Me.btn_elim_nac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_elim_nac.Location = New System.Drawing.Point(214, 170)
        Me.btn_elim_nac.Name = "btn_elim_nac"
        Me.btn_elim_nac.Size = New System.Drawing.Size(81, 24)
        Me.btn_elim_nac.TabIndex = 3
        Me.btn_elim_nac.Text = "&Eliminar"
        Me.btn_elim_nac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_elim_nac, "Eliminar estado")
        Me.btn_elim_nac.UseVisualStyleBackColor = False
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.BackColor = System.Drawing.Color.LightBlue
        Me.Btn_cerrar.Image = CType(resources.GetObject("Btn_cerrar.Image"), System.Drawing.Image)
        Me.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cerrar.Location = New System.Drawing.Point(573, 12)
        Me.Btn_cerrar.Name = "Btn_cerrar"
        Me.Btn_cerrar.Size = New System.Drawing.Size(86, 46)
        Me.Btn_cerrar.TabIndex = 12
        Me.Btn_cerrar.Text = "&Cerrar"
        Me.Btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_cerrar.UseVisualStyleBackColor = False
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 476)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(669, 46)
        Me.Pic_pie_pagina.TabIndex = 16
        Me.Pic_pie_pagina.TabStop = False
        '
        'Lbl_titulo
        '
        Me.Lbl_titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_titulo.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_titulo.Location = New System.Drawing.Point(79, 1)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(284, 60)
        Me.Lbl_titulo.TabIndex = 18
        Me.Lbl_titulo.Text = "CONFIGURACION DE AREAS GEOGRÁFICAS"
        Me.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, -2)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(671, 73)
        Me.Pic_Encabezado.TabIndex = 19
        Me.Pic_Encabezado.TabStop = False
        '
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(7, 4)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(59, 57)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 20
        Me.Pic_icono.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Estados_ciudades)
        Me.TabControl1.Controls.Add(Me.Nacionalidades)
        Me.TabControl1.Location = New System.Drawing.Point(7, 77)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(656, 433)
        Me.TabControl1.TabIndex = 21
        '
        'Estados_ciudades
        '
        Me.Estados_ciudades.Controls.Add(Me.Grupo_Estados)
        Me.Estados_ciudades.Controls.Add(Me.lv_estado)
        Me.Estados_ciudades.Controls.Add(Me.lv_ciudades)
        Me.Estados_ciudades.Controls.Add(Me.Grupo_Ciudad)
        Me.Estados_ciudades.Location = New System.Drawing.Point(4, 24)
        Me.Estados_ciudades.Name = "Estados_ciudades"
        Me.Estados_ciudades.Padding = New System.Windows.Forms.Padding(3)
        Me.Estados_ciudades.Size = New System.Drawing.Size(648, 405)
        Me.Estados_ciudades.TabIndex = 0
        Me.Estados_ciudades.Text = "Estados y ciudades"
        Me.Estados_ciudades.UseVisualStyleBackColor = True
        '
        'Grupo_Estados
        '
        Me.Grupo_Estados.Controls.Add(Me.btn_est_nuevo)
        Me.Grupo_Estados.Controls.Add(Me.chk_estado_visible)
        Me.Grupo_Estados.Controls.Add(Me.btn_busca_estado)
        Me.Grupo_Estados.Controls.Add(Me.btn_estado_guardar)
        Me.Grupo_Estados.Controls.Add(Me.txt_nombre_estado)
        Me.Grupo_Estados.Controls.Add(Me.txt_cod_estado)
        Me.Grupo_Estados.Controls.Add(Me.Label5)
        Me.Grupo_Estados.Controls.Add(Me.btn_est_eliminar)
        Me.Grupo_Estados.Controls.Add(Me.Label6)
        Me.Grupo_Estados.Location = New System.Drawing.Point(3, 5)
        Me.Grupo_Estados.Name = "Grupo_Estados"
        Me.Grupo_Estados.Size = New System.Drawing.Size(297, 101)
        Me.Grupo_Estados.TabIndex = 19
        Me.Grupo_Estados.TabStop = False
        Me.Grupo_Estados.Text = "Datos de Estados"
        '
        'chk_estado_visible
        '
        Me.chk_estado_visible.AutoSize = True
        Me.chk_estado_visible.Location = New System.Drawing.Point(228, 18)
        Me.chk_estado_visible.Name = "chk_estado_visible"
        Me.chk_estado_visible.Size = New System.Drawing.Size(56, 17)
        Me.chk_estado_visible.TabIndex = 17
        Me.chk_estado_visible.Text = "Visible"
        Me.chk_estado_visible.UseVisualStyleBackColor = True
        '
        'txt_nombre_estado
        '
        Me.txt_nombre_estado.Location = New System.Drawing.Point(91, 40)
        Me.txt_nombre_estado.MaxLength = 100
        Me.txt_nombre_estado.Name = "txt_nombre_estado"
        Me.txt_nombre_estado.Size = New System.Drawing.Size(200, 24)
        Me.txt_nombre_estado.TabIndex = 1
        '
        'txt_cod_estado
        '
        Me.txt_cod_estado.Location = New System.Drawing.Point(9, 40)
        Me.txt_cod_estado.MaxLength = 4
        Me.txt_cod_estado.Name = "txt_cod_estado"
        Me.txt_cod_estado.Size = New System.Drawing.Size(71, 24)
        Me.txt_cod_estado.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Descripción"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cod. Estado"
        '
        'lv_estado
        '
        Me.lv_estado.BackColor = System.Drawing.Color.White
        Me.lv_estado.FullRowSelect = True
        Me.lv_estado.HideSelection = False
        Me.lv_estado.Location = New System.Drawing.Point(3, 112)
        Me.lv_estado.Name = "lv_estado"
        Me.lv_estado.Size = New System.Drawing.Size(297, 290)
        Me.lv_estado.TabIndex = 17
        Me.lv_estado.Tag = "limpiar"
        Me.lv_estado.UseCompatibleStateImageBehavior = False
        '
        'lv_ciudades
        '
        Me.lv_ciudades.BackColor = System.Drawing.Color.White
        Me.lv_ciudades.FullRowSelect = True
        Me.lv_ciudades.HideSelection = False
        Me.lv_ciudades.Location = New System.Drawing.Point(306, 112)
        Me.lv_ciudades.Name = "lv_ciudades"
        Me.lv_ciudades.Size = New System.Drawing.Size(337, 290)
        Me.lv_ciudades.TabIndex = 18
        Me.lv_ciudades.Tag = "limpiar"
        Me.lv_ciudades.UseCompatibleStateImageBehavior = False
        '
        'Grupo_Ciudad
        '
        Me.Grupo_Ciudad.Controls.Add(Me.chk_ciudad_visible)
        Me.Grupo_Ciudad.Controls.Add(Me.btn_ciudad_buscar)
        Me.Grupo_Ciudad.Controls.Add(Me.btn_ciud_guardar)
        Me.Grupo_Ciudad.Controls.Add(Me.btn_ciud_elim)
        Me.Grupo_Ciudad.Controls.Add(Me.btn_ciud_nuevo)
        Me.Grupo_Ciudad.Controls.Add(Me.txt_nombre_ciudad)
        Me.Grupo_Ciudad.Controls.Add(Me.txt_cod_ciudad)
        Me.Grupo_Ciudad.Controls.Add(Me.Label3)
        Me.Grupo_Ciudad.Controls.Add(Me.Label4)
        Me.Grupo_Ciudad.Location = New System.Drawing.Point(306, 5)
        Me.Grupo_Ciudad.Name = "Grupo_Ciudad"
        Me.Grupo_Ciudad.Size = New System.Drawing.Size(337, 101)
        Me.Grupo_Ciudad.TabIndex = 16
        Me.Grupo_Ciudad.TabStop = False
        Me.Grupo_Ciudad.Text = "Datos de ciudades"
        '
        'chk_ciudad_visible
        '
        Me.chk_ciudad_visible.AutoSize = True
        Me.chk_ciudad_visible.Location = New System.Drawing.Point(268, 18)
        Me.chk_ciudad_visible.Name = "chk_ciudad_visible"
        Me.chk_ciudad_visible.Size = New System.Drawing.Size(56, 17)
        Me.chk_ciudad_visible.TabIndex = 12
        Me.chk_ciudad_visible.Text = "Visible"
        Me.chk_ciudad_visible.UseVisualStyleBackColor = True
        '
        'txt_nombre_ciudad
        '
        Me.txt_nombre_ciudad.Location = New System.Drawing.Point(86, 40)
        Me.txt_nombre_ciudad.MaxLength = 100
        Me.txt_nombre_ciudad.Name = "txt_nombre_ciudad"
        Me.txt_nombre_ciudad.Size = New System.Drawing.Size(245, 24)
        Me.txt_nombre_ciudad.TabIndex = 7
        '
        'txt_cod_ciudad
        '
        Me.txt_cod_ciudad.Location = New System.Drawing.Point(6, 40)
        Me.txt_cod_ciudad.MaxLength = 4
        Me.txt_cod_ciudad.Name = "txt_cod_ciudad"
        Me.txt_cod_ciudad.Size = New System.Drawing.Size(70, 24)
        Me.txt_cod_ciudad.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cod. ciudad"
        '
        'Nacionalidades
        '
        Me.Nacionalidades.Controls.Add(Me.Grupo_nacionalidades)
        Me.Nacionalidades.Controls.Add(Me.Lista_nacionalidades)
        Me.Nacionalidades.Location = New System.Drawing.Point(4, 24)
        Me.Nacionalidades.Name = "Nacionalidades"
        Me.Nacionalidades.Padding = New System.Windows.Forms.Padding(3)
        Me.Nacionalidades.Size = New System.Drawing.Size(648, 405)
        Me.Nacionalidades.TabIndex = 1
        Me.Nacionalidades.Text = "Nacionalidades"
        Me.Nacionalidades.UseVisualStyleBackColor = True
        '
        'Grupo_nacionalidades
        '
        Me.Grupo_nacionalidades.Controls.Add(Me.btn_nuevo_nac)
        Me.Grupo_nacionalidades.Controls.Add(Me.chk_nac_visible)
        Me.Grupo_nacionalidades.Controls.Add(Me.btn_buscar_nac)
        Me.Grupo_nacionalidades.Controls.Add(Me.btn_archivar_nac)
        Me.Grupo_nacionalidades.Controls.Add(Me.txt_nacionalidad)
        Me.Grupo_nacionalidades.Controls.Add(Me.txt_cod_nac)
        Me.Grupo_nacionalidades.Controls.Add(Me.Label1)
        Me.Grupo_nacionalidades.Controls.Add(Me.btn_elim_nac)
        Me.Grupo_nacionalidades.Controls.Add(Me.Label2)
        Me.Grupo_nacionalidades.Location = New System.Drawing.Point(319, 6)
        Me.Grupo_nacionalidades.Name = "Grupo_nacionalidades"
        Me.Grupo_nacionalidades.Size = New System.Drawing.Size(323, 397)
        Me.Grupo_nacionalidades.TabIndex = 21
        Me.Grupo_nacionalidades.TabStop = False
        Me.Grupo_nacionalidades.Text = "Datos de nacionalidades"
        '
        'chk_nac_visible
        '
        Me.chk_nac_visible.AutoSize = True
        Me.chk_nac_visible.Location = New System.Drawing.Point(9, 136)
        Me.chk_nac_visible.Name = "chk_nac_visible"
        Me.chk_nac_visible.Size = New System.Drawing.Size(56, 17)
        Me.chk_nac_visible.TabIndex = 17
        Me.chk_nac_visible.Text = "Visible"
        Me.chk_nac_visible.UseVisualStyleBackColor = True
        '
        'txt_nacionalidad
        '
        Me.txt_nacionalidad.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nacionalidad.Location = New System.Drawing.Point(9, 98)
        Me.txt_nacionalidad.MaxLength = 100
        Me.txt_nacionalidad.Name = "txt_nacionalidad"
        Me.txt_nacionalidad.Size = New System.Drawing.Size(308, 31)
        Me.txt_nacionalidad.TabIndex = 1
        '
        'txt_cod_nac
        '
        Me.txt_cod_nac.Location = New System.Drawing.Point(9, 40)
        Me.txt_cod_nac.MaxLength = 4
        Me.txt_cod_nac.Name = "txt_cod_nac"
        Me.txt_cod_nac.Size = New System.Drawing.Size(71, 24)
        Me.txt_cod_nac.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nacionalidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cod. nacionalidad"
        '
        'Lista_nacionalidades
        '
        Me.Lista_nacionalidades.BackColor = System.Drawing.Color.White
        Me.Lista_nacionalidades.FullRowSelect = True
        Me.Lista_nacionalidades.HideSelection = False
        Me.Lista_nacionalidades.Location = New System.Drawing.Point(6, 6)
        Me.Lista_nacionalidades.Name = "Lista_nacionalidades"
        Me.Lista_nacionalidades.Size = New System.Drawing.Size(307, 397)
        Me.Lista_nacionalidades.TabIndex = 20
        Me.Lista_nacionalidades.Tag = "limpiar"
        Me.Lista_nacionalidades.UseCompatibleStateImageBehavior = False
        '
        'frm_estados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(669, 522)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_estados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Estados_ciudades.ResumeLayout(False)
        Me.Grupo_Estados.ResumeLayout(False)
        Me.Grupo_Estados.PerformLayout()
        Me.Grupo_Ciudad.ResumeLayout(False)
        Me.Grupo_Ciudad.PerformLayout()
        Me.Nacionalidades.ResumeLayout(False)
        Me.Grupo_nacionalidades.ResumeLayout(False)
        Me.Grupo_nacionalidades.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Estados_ciudades As System.Windows.Forms.TabPage
    Friend WithEvents Grupo_Estados As System.Windows.Forms.GroupBox
    Friend WithEvents chk_estado_visible As System.Windows.Forms.CheckBox
    Friend WithEvents btn_busca_estado As System.Windows.Forms.Button
    Friend WithEvents btn_estado_guardar As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_estado As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_estado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_est_eliminar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lv_estado As System.Windows.Forms.ListView
    Friend WithEvents lv_ciudades As System.Windows.Forms.ListView
    Friend WithEvents Grupo_Ciudad As System.Windows.Forms.GroupBox
    Friend WithEvents chk_ciudad_visible As System.Windows.Forms.CheckBox
    Friend WithEvents btn_ciudad_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_ciud_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_ciud_elim As System.Windows.Forms.Button
    Friend WithEvents btn_ciud_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_ciudad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nacionalidades As System.Windows.Forms.TabPage
    Friend WithEvents btn_est_nuevo As System.Windows.Forms.Button
    Friend WithEvents Grupo_nacionalidades As System.Windows.Forms.GroupBox
    Friend WithEvents btn_nuevo_nac As System.Windows.Forms.Button
    Friend WithEvents chk_nac_visible As System.Windows.Forms.CheckBox
    Friend WithEvents btn_buscar_nac As System.Windows.Forms.Button
    Friend WithEvents btn_archivar_nac As System.Windows.Forms.Button
    Friend WithEvents txt_nacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_cod_nac As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_elim_nac As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lista_nacionalidades As System.Windows.Forms.ListView
End Class
