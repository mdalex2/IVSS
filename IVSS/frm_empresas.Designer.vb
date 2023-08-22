<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_empresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_empresas))
        Me.chk_activo = New System.Windows.Forms.CheckBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Informativo = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.lbl_guardado_por = New System.Windows.Forms.Label()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.btn_archivar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nueva = New System.Windows.Forms.Button()
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Grupo_datos = New System.Windows.Forms.GroupBox()
        Me.txt_blog = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_web = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_correo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_fax = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telf_secundario = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telf_principal = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_notas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_ciudad = New System.Windows.Forms.ComboBox()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_mostrar_inactivos = New System.Windows.Forms.CheckBox()
        Me.Lista_buscar = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_datos.SuspendLayout()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_activo
        '
        Me.chk_activo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chk_activo.AutoSize = True
        Me.chk_activo.Checked = True
        Me.chk_activo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_activo.Location = New System.Drawing.Point(208, 32)
        Me.chk_activo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Size = New System.Drawing.Size(158, 17)
        Me.chk_activo.TabIndex = 1
        Me.chk_activo.Text = "Empresa / organismo activo"
        Me.chk_activo.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_buscar.ImageIndex = 0
        Me.btn_buscar.ImageList = Me.imagenes
        Me.btn_buscar.Location = New System.Drawing.Point(595, 93)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(47, 33)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Tag = "0"
        Me.Informativo.SetToolTip(Me.btn_buscar, "Buscar")
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'imagenes
        '
        Me.imagenes.ImageStream = CType(resources.GetObject("imagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imagenes.Images.SetKeyName(0, "LupaX24.png")
        Me.imagenes.Images.SetKeyName(1, "Lupa-quitar-x24.png")
        Me.imagenes.Images.SetKeyName(2, "ArchivadorX24.png")
        Me.imagenes.Images.SetKeyName(3, "archivar-editar-x24.png")
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cerrar.BackColor = System.Drawing.Color.LightBlue
        Me.Btn_cerrar.Image = CType(resources.GetObject("Btn_cerrar.Image"), System.Drawing.Image)
        Me.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cerrar.Location = New System.Drawing.Point(893, 26)
        Me.Btn_cerrar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_cerrar.Name = "Btn_cerrar"
        Me.Btn_cerrar.Size = New System.Drawing.Size(103, 43)
        Me.Btn_cerrar.TabIndex = 17
        Me.Btn_cerrar.Text = "&Cerrar"
        Me.Btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Informativo.SetToolTip(Me.Btn_cerrar, "Cerrar ventana")
        Me.Btn_cerrar.UseVisualStyleBackColor = False
        '
        'lbl_guardado_por
        '
        Me.lbl_guardado_por.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_guardado_por.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_guardado_por.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guardado_por.Location = New System.Drawing.Point(17, 650)
        Me.lbl_guardado_por.Name = "lbl_guardado_por"
        Me.lbl_guardado_por.Size = New System.Drawing.Size(455, 29)
        Me.lbl_guardado_por.TabIndex = 62
        Me.lbl_guardado_por.Tag = "limpiar"
        Me.lbl_guardado_por.Text = "Usuario:"
        Me.lbl_guardado_por.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Informativo.SetToolTip(Me.lbl_guardado_por, "Usuario que efectuó el registro")
        '
        'btn_reporte
        '
        Me.btn_reporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reporte.BackColor = System.Drawing.Color.LightBlue
        Me.btn_reporte.Enabled = False
        Me.btn_reporte.Image = CType(resources.GetObject("btn_reporte.Image"), System.Drawing.Image)
        Me.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reporte.Location = New System.Drawing.Point(785, 637)
        Me.btn_reporte.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(102, 43)
        Me.btn_reporte.TabIndex = 15
        Me.btn_reporte.Text = "&Listado"
        Me.btn_reporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_reporte, "Vista previa del listado")
        Me.btn_reporte.UseVisualStyleBackColor = False
        '
        'btn_archivar
        '
        Me.btn_archivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_archivar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_archivar.Image = CType(resources.GetObject("btn_archivar.Image"), System.Drawing.Image)
        Me.btn_archivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_archivar.Location = New System.Drawing.Point(677, 637)
        Me.btn_archivar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_archivar.Name = "btn_archivar"
        Me.btn_archivar.Size = New System.Drawing.Size(102, 43)
        Me.btn_archivar.TabIndex = 14
        Me.btn_archivar.Tag = "0"
        Me.btn_archivar.Text = "&Archivar"
        Me.btn_archivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_archivar, "Archivar / Actualizar")
        Me.btn_archivar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(893, 637)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(103, 43)
        Me.btn_eliminar.TabIndex = 16
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_eliminar, "Borrar especialidad")
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_nueva
        '
        Me.btn_nueva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_nueva.BackColor = System.Drawing.Color.LightBlue
        Me.btn_nueva.Image = CType(resources.GetObject("btn_nueva.Image"), System.Drawing.Image)
        Me.btn_nueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nueva.Location = New System.Drawing.Point(570, 637)
        Me.btn_nueva.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_nueva.Name = "btn_nueva"
        Me.btn_nueva.Size = New System.Drawing.Size(101, 43)
        Me.btn_nueva.TabIndex = 13
        Me.btn_nueva.Text = "&Nueva"
        Me.btn_nueva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_nueva, "Agregar nuevo")
        Me.btn_nueva.UseVisualStyleBackColor = False
        '
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(14, 13)
        Me.Pic_icono.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(54, 56)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 53
        Me.Pic_icono.TabStop = False
        '
        'Grupo_datos
        '
        Me.Grupo_datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grupo_datos.Controls.Add(Me.txt_blog)
        Me.Grupo_datos.Controls.Add(Me.Label13)
        Me.Grupo_datos.Controls.Add(Me.txt_web)
        Me.Grupo_datos.Controls.Add(Me.Label12)
        Me.Grupo_datos.Controls.Add(Me.txt_correo)
        Me.Grupo_datos.Controls.Add(Me.Label11)
        Me.Grupo_datos.Controls.Add(Me.txt_fax)
        Me.Grupo_datos.Controls.Add(Me.txt_telf_secundario)
        Me.Grupo_datos.Controls.Add(Me.txt_telf_principal)
        Me.Grupo_datos.Controls.Add(Me.Label9)
        Me.Grupo_datos.Controls.Add(Me.Label8)
        Me.Grupo_datos.Controls.Add(Me.Label10)
        Me.Grupo_datos.Controls.Add(Me.txt_notas)
        Me.Grupo_datos.Controls.Add(Me.Label7)
        Me.Grupo_datos.Controls.Add(Me.Label6)
        Me.Grupo_datos.Controls.Add(Me.txt_direccion)
        Me.Grupo_datos.Controls.Add(Me.txt_empresa)
        Me.Grupo_datos.Controls.Add(Me.Label3)
        Me.Grupo_datos.Controls.Add(Me.txt_cod)
        Me.Grupo_datos.Controls.Add(Me.Label2)
        Me.Grupo_datos.Controls.Add(Me.chk_activo)
        Me.Grupo_datos.Controls.Add(Me.cmb_ciudad)
        Me.Grupo_datos.Controls.Add(Me.cmb_estado)
        Me.Grupo_datos.Controls.Add(Me.Label5)
        Me.Grupo_datos.Controls.Add(Me.Label4)
        Me.Grupo_datos.Location = New System.Drawing.Point(11, 264)
        Me.Grupo_datos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grupo_datos.Name = "Grupo_datos"
        Me.Grupo_datos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grupo_datos.Size = New System.Drawing.Size(985, 428)
        Me.Grupo_datos.TabIndex = 4
        Me.Grupo_datos.TabStop = False
        Me.Grupo_datos.Text = "Opciones"
        '
        'txt_blog
        '
        Me.txt_blog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_blog.Location = New System.Drawing.Point(475, 202)
        Me.txt_blog.Name = "txt_blog"
        Me.txt_blog.Size = New System.Drawing.Size(504, 25)
        Me.txt_blog.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(472, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 17)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Blog / otra web"
        '
        'txt_web
        '
        Me.txt_web.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_web.Location = New System.Drawing.Point(475, 154)
        Me.txt_web.Name = "txt_web"
        Me.txt_web.Size = New System.Drawing.Size(504, 25)
        Me.txt_web.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(472, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 17)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Pagina Web"
        '
        'txt_correo
        '
        Me.txt_correo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_correo.Location = New System.Drawing.Point(475, 107)
        Me.txt_correo.Name = "txt_correo"
        Me.txt_correo.Size = New System.Drawing.Size(504, 25)
        Me.txt_correo.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(472, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Correo electronico"
        '
        'txt_fax
        '
        Me.txt_fax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_fax.Location = New System.Drawing.Point(759, 48)
        Me.txt_fax.Mask = "(9999)000-0000"
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Size = New System.Drawing.Size(122, 25)
        Me.txt_fax.TabIndex = 8
        '
        'txt_telf_secundario
        '
        Me.txt_telf_secundario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_telf_secundario.Location = New System.Drawing.Point(619, 48)
        Me.txt_telf_secundario.Mask = "(9999)000-0000"
        Me.txt_telf_secundario.Name = "txt_telf_secundario"
        Me.txt_telf_secundario.Size = New System.Drawing.Size(122, 25)
        Me.txt_telf_secundario.TabIndex = 7
        '
        'txt_telf_principal
        '
        Me.txt_telf_principal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_telf_principal.Location = New System.Drawing.Point(475, 50)
        Me.txt_telf_principal.Mask = "(9999)000-0000"
        Me.txt_telf_principal.Name = "txt_telf_principal"
        Me.txt_telf_principal.Size = New System.Drawing.Size(122, 25)
        Me.txt_telf_principal.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(616, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Teléfono secundario"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(472, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Teléfono principal"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(756, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Fax"
        '
        'txt_notas
        '
        Me.txt_notas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_notas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notas.Location = New System.Drawing.Point(475, 251)
        Me.txt_notas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_notas.Multiline = True
        Me.txt_notas.Name = "txt_notas"
        Me.txt_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notas.Size = New System.Drawing.Size(504, 118)
        Me.txt_notas.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(472, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Notas / Observaciones"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Dirección"
        '
        'txt_direccion
        '
        Me.txt_direccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_direccion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion.Location = New System.Drawing.Point(6, 251)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_direccion.Multiline = True
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_direccion.Size = New System.Drawing.Size(455, 118)
        Me.txt_direccion.TabIndex = 5
        '
        'txt_empresa
        '
        Me.txt_empresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_empresa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empresa.Location = New System.Drawing.Point(6, 79)
        Me.txt_empresa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_empresa.MaxLength = 300
        Me.txt_empresa.Multiline = True
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_empresa.Size = New System.Drawing.Size(457, 54)
        Me.txt_empresa.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Empresa / Organismo"
        '
        'txt_cod
        '
        Me.txt_cod.BackColor = System.Drawing.Color.LightYellow
        Me.txt_cod.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod.Location = New System.Drawing.Point(101, 20)
        Me.txt_cod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_cod.MaxLength = 4
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(87, 33)
        Me.txt_cod.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cod. empresa"
        '
        'cmb_ciudad
        '
        Me.cmb_ciudad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_ciudad.FormattingEnabled = True
        Me.cmb_ciudad.Location = New System.Drawing.Point(6, 202)
        Me.cmb_ciudad.Name = "cmb_ciudad"
        Me.cmb_ciudad.Size = New System.Drawing.Size(455, 25)
        Me.cmb_ciudad.TabIndex = 4
        '
        'cmb_estado
        '
        Me.cmb_estado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(6, 154)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(455, 25)
        Me.cmb_estado.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ciudad"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Estado territorial"
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 626)
        Me.Pic_pie_pagina.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(1008, 104)
        Me.Pic_pie_pagina.TabIndex = 51
        Me.Pic_pie_pagina.TabStop = False
        '
        'Lbl_titulo
        '
        Me.Lbl_titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_titulo.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_titulo.Location = New System.Drawing.Point(74, 26)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(667, 28)
        Me.Lbl_titulo.TabIndex = 52
        Me.Lbl_titulo.Text = "CONFIGURACIÓN DE EMPRESAS Y ORGANISMOS"
        Me.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Encabezado.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(1008, 89)
        Me.Pic_Encabezado.TabIndex = 54
        Me.Pic_Encabezado.TabStop = False
        '
        'txt_busca
        '
        Me.txt_busca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_busca.Location = New System.Drawing.Point(12, 93)
        Me.txt_busca.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(577, 33)
        Me.txt_busca.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 17)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Escriba el nombre de la empresa a buscar"
        '
        'chk_mostrar_inactivos
        '
        Me.chk_mostrar_inactivos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_mostrar_inactivos.AutoSize = True
        Me.chk_mostrar_inactivos.Checked = True
        Me.chk_mostrar_inactivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_mostrar_inactivos.Location = New System.Drawing.Point(648, 100)
        Me.chk_mostrar_inactivos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_mostrar_inactivos.Name = "chk_mostrar_inactivos"
        Me.chk_mostrar_inactivos.Size = New System.Drawing.Size(163, 21)
        Me.chk_mostrar_inactivos.TabIndex = 2
        Me.chk_mostrar_inactivos.Text = "Mostrar items inactivos"
        Me.chk_mostrar_inactivos.UseVisualStyleBackColor = True
        '
        'Lista_buscar
        '
        Me.Lista_buscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lista_buscar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.Lista_buscar.FullRowSelect = True
        Me.Lista_buscar.GridLines = True
        Me.Lista_buscar.Location = New System.Drawing.Point(11, 128)
        Me.Lista_buscar.MultiSelect = False
        Me.Lista_buscar.Name = "Lista_buscar"
        Me.Lista_buscar.Size = New System.Drawing.Size(985, 134)
        Me.Lista_buscar.TabIndex = 3
        Me.Lista_buscar.Tag = "limpiar"
        Me.Lista_buscar.UseCompatibleStateImageBehavior = False
        '
        'frm_empresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.btn_archivar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nueva)
        Me.Controls.Add(Me.lbl_guardado_por)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.Grupo_datos)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.txt_busca)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.chk_mostrar_inactivos)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Controls.Add(Me.Lista_buscar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_empresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_datos.ResumeLayout(False)
        Me.Grupo_datos.PerformLayout()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_activo As System.Windows.Forms.CheckBox
    Friend WithEvents Informativo As System.Windows.Forms.ToolTip
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Grupo_datos As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_empresa As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents txt_busca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_mostrar_inactivos As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_guardado_por As System.Windows.Forms.Label
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents btn_archivar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_nueva As System.Windows.Forms.Button
    Friend WithEvents cmb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Lista_buscar As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_notas As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_correo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_fax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_telf_secundario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_telf_principal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_blog As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_web As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
