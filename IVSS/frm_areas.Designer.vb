<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_areas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_areas))
        Me.chk_activo = New System.Windows.Forms.CheckBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_archivar = New System.Windows.Forms.Button()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Grupo_area = New System.Windows.Forms.GroupBox()
        Me.lbl_guardado_por = New System.Windows.Forms.Label()
        Me.btn_nueva = New System.Windows.Forms.Button()
        Me.txt_notas_observ = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_area = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.Informativo = New System.Windows.Forms.ToolTip(Me.components)
        Me.chk_mostrar_inactivos = New System.Windows.Forms.CheckBox()
        Me.Lista_buscar = New System.Windows.Forms.ListView()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_area.SuspendLayout()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_activo
        '
        Me.chk_activo.AutoSize = True
        Me.chk_activo.Location = New System.Drawing.Point(236, 49)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Size = New System.Drawing.Size(56, 17)
        Me.chk_activo.TabIndex = 11
        Me.chk_activo.Text = "Activa"
        Me.chk_activo.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(210, 392)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(88, 33)
        Me.btn_eliminar.TabIndex = 10
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_eliminar, "Borrar especialidad")
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_archivar
        '
        Me.btn_archivar.Image = CType(resources.GetObject("btn_archivar.Image"), System.Drawing.Image)
        Me.btn_archivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_archivar.Location = New System.Drawing.Point(103, 392)
        Me.btn_archivar.Name = "btn_archivar"
        Me.btn_archivar.Size = New System.Drawing.Size(101, 33)
        Me.btn_archivar.TabIndex = 9
        Me.btn_archivar.Tag = "0"
        Me.btn_archivar.Text = "&Archivar"
        Me.btn_archivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_archivar, "Archivar / Actualizar")
        Me.btn_archivar.UseVisualStyleBackColor = True
        '
        'btn_reporte
        '
        Me.btn_reporte.BackColor = System.Drawing.Color.LightBlue
        Me.btn_reporte.Image = CType(resources.GetObject("btn_reporte.Image"), System.Drawing.Image)
        Me.btn_reporte.Location = New System.Drawing.Point(303, 115)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(40, 33)
        Me.btn_reporte.TabIndex = 47
        Me.Informativo.SetToolTip(Me.btn_reporte, "Vista previa del listado")
        Me.btn_reporte.UseVisualStyleBackColor = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_buscar.ImageIndex = 0
        Me.btn_buscar.ImageList = Me.imagenes
        Me.btn_buscar.Location = New System.Drawing.Point(259, 115)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(40, 33)
        Me.btn_buscar.TabIndex = 46
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
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(12, 13)
        Me.Pic_icono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(81, 80)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 40
        Me.Pic_icono.TabStop = False
        '
        'Grupo_area
        '
        Me.Grupo_area.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grupo_area.Controls.Add(Me.lbl_guardado_por)
        Me.Grupo_area.Controls.Add(Me.chk_activo)
        Me.Grupo_area.Controls.Add(Me.btn_eliminar)
        Me.Grupo_area.Controls.Add(Me.btn_archivar)
        Me.Grupo_area.Controls.Add(Me.btn_nueva)
        Me.Grupo_area.Controls.Add(Me.txt_notas_observ)
        Me.Grupo_area.Controls.Add(Me.Label4)
        Me.Grupo_area.Controls.Add(Me.txt_area)
        Me.Grupo_area.Controls.Add(Me.Label3)
        Me.Grupo_area.Controls.Add(Me.txt_codigo)
        Me.Grupo_area.Controls.Add(Me.Label2)
        Me.Grupo_area.Location = New System.Drawing.Point(349, 83)
        Me.Grupo_area.Name = "Grupo_area"
        Me.Grupo_area.Size = New System.Drawing.Size(302, 431)
        Me.Grupo_area.TabIndex = 45
        Me.Grupo_area.TabStop = False
        Me.Grupo_area.Text = "Opciones"
        '
        'lbl_guardado_por
        '
        Me.lbl_guardado_por.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_guardado_por.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guardado_por.Location = New System.Drawing.Point(10, 335)
        Me.lbl_guardado_por.Name = "lbl_guardado_por"
        Me.lbl_guardado_por.Size = New System.Drawing.Size(288, 43)
        Me.lbl_guardado_por.TabIndex = 13
        Me.lbl_guardado_por.Tag = "limpiar"
        Me.lbl_guardado_por.Text = "Usuario:"
        Me.lbl_guardado_por.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Informativo.SetToolTip(Me.lbl_guardado_por, "Usuario que efectuó el registro")
        '
        'btn_nueva
        '
        Me.btn_nueva.Image = CType(resources.GetObject("btn_nueva.Image"), System.Drawing.Image)
        Me.btn_nueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nueva.Location = New System.Drawing.Point(10, 392)
        Me.btn_nueva.Name = "btn_nueva"
        Me.btn_nueva.Size = New System.Drawing.Size(87, 33)
        Me.btn_nueva.TabIndex = 8
        Me.btn_nueva.Text = "&Nueva"
        Me.btn_nueva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_nueva, "Agregar nuevo")
        Me.btn_nueva.UseVisualStyleBackColor = True
        '
        'txt_notas_observ
        '
        Me.txt_notas_observ.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notas_observ.Location = New System.Drawing.Point(10, 189)
        Me.txt_notas_observ.Multiline = True
        Me.txt_notas_observ.Name = "txt_notas_observ"
        Me.txt_notas_observ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notas_observ.Size = New System.Drawing.Size(287, 74)
        Me.txt_notas_observ.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Notas / Observaciones"
        '
        'txt_area
        '
        Me.txt_area.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_area.Location = New System.Drawing.Point(10, 93)
        Me.txt_area.MaxLength = 300
        Me.txt_area.Multiline = True
        Me.txt_area.Name = "txt_area"
        Me.txt_area.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_area.Size = New System.Drawing.Size(288, 73)
        Me.txt_area.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Area"
        '
        'txt_codigo
        '
        Me.txt_codigo.BackColor = System.Drawing.Color.LightYellow
        Me.txt_codigo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(10, 41)
        Me.txt_codigo.MaxLength = 4
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(75, 29)
        Me.txt_codigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo"
        Me.Informativo.SetToolTip(Me.Label2, "Codigo del tipo de documento")
        '
        'txt_busca
        '
        Me.txt_busca.Location = New System.Drawing.Point(2, 120)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(251, 25)
        Me.txt_busca.TabIndex = 44
        '
        'Lbl_titulo
        '
        Me.Lbl_titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_titulo.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_titulo.Location = New System.Drawing.Point(99, 16)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(435, 64)
        Me.Lbl_titulo.TabIndex = 39
        Me.Lbl_titulo.Text = "CONFIGURACION DE AREAS"
        Me.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cerrar.BackColor = System.Drawing.Color.LightBlue
        Me.Btn_cerrar.Image = CType(resources.GetObject("Btn_cerrar.Image"), System.Drawing.Image)
        Me.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cerrar.Location = New System.Drawing.Point(557, 40)
        Me.Btn_cerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_cerrar.Name = "Btn_cerrar"
        Me.Btn_cerrar.Size = New System.Drawing.Size(88, 43)
        Me.Btn_cerrar.TabIndex = 37
        Me.Btn_cerrar.Text = "&Cerrar"
        Me.Btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Informativo.SetToolTip(Me.Btn_cerrar, "Cerrar ventana")
        Me.Btn_cerrar.UseVisualStyleBackColor = False
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 477)
        Me.Pic_pie_pagina.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(652, 85)
        Me.Pic_pie_pagina.TabIndex = 38
        Me.Pic_pie_pagina.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Buscar tipo documento"
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Encabezado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(652, 105)
        Me.Pic_Encabezado.TabIndex = 41
        Me.Pic_Encabezado.TabStop = False
        '
        'chk_mostrar_inactivos
        '
        Me.chk_mostrar_inactivos.AutoSize = True
        Me.chk_mostrar_inactivos.Checked = True
        Me.chk_mostrar_inactivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_mostrar_inactivos.Location = New System.Drawing.Point(12, 482)
        Me.chk_mostrar_inactivos.Name = "chk_mostrar_inactivos"
        Me.chk_mostrar_inactivos.Size = New System.Drawing.Size(163, 21)
        Me.chk_mostrar_inactivos.TabIndex = 48
        Me.chk_mostrar_inactivos.Text = "Mostrar items inactivos"
        Me.chk_mostrar_inactivos.UseVisualStyleBackColor = True
        '
        'Lista_buscar
        '
        Me.Lista_buscar.FullRowSelect = True
        Me.Lista_buscar.Location = New System.Drawing.Point(2, 151)
        Me.Lista_buscar.MultiSelect = False
        Me.Lista_buscar.Name = "Lista_buscar"
        Me.Lista_buscar.Size = New System.Drawing.Size(341, 325)
        Me.Lista_buscar.TabIndex = 49
        Me.Lista_buscar.Tag = "limpiar"
        Me.Lista_buscar.UseCompatibleStateImageBehavior = False
        '
        'frm_areas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(652, 562)
        Me.Controls.Add(Me.Lista_buscar)
        Me.Controls.Add(Me.chk_mostrar_inactivos)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.Grupo_area)
        Me.Controls.Add(Me.txt_busca)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_areas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_area.ResumeLayout(False)
        Me.Grupo_area.PerformLayout()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_activo As System.Windows.Forms.CheckBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents Informativo As System.Windows.Forms.ToolTip
    Friend WithEvents btn_archivar As System.Windows.Forms.Button
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Grupo_area As System.Windows.Forms.GroupBox
    Friend WithEvents btn_nueva As System.Windows.Forms.Button
    Friend WithEvents txt_notas_observ As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_area As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_busca As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_guardado_por As System.Windows.Forms.Label
    Friend WithEvents chk_mostrar_inactivos As System.Windows.Forms.CheckBox
    Friend WithEvents Lista_buscar As System.Windows.Forms.ListView
End Class
