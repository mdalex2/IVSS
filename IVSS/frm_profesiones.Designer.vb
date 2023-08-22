<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_profesiones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_profesiones))
        Me.chk_activo = New System.Windows.Forms.CheckBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_archivar = New System.Windows.Forms.Button()
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Grupo_documento = New System.Windows.Forms.GroupBox()
        Me.btn_nueva = New System.Windows.Forms.Button()
        Me.txt_profesion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cod_prof = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.lista_buscar = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.Informativo = New System.Windows.Forms.ToolTip(Me.components)
        Me.chk_mostrar_inactivos = New System.Windows.Forms.CheckBox()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_documento.SuspendLayout()
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
        'Grupo_documento
        '
        Me.Grupo_documento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grupo_documento.Controls.Add(Me.chk_activo)
        Me.Grupo_documento.Controls.Add(Me.btn_eliminar)
        Me.Grupo_documento.Controls.Add(Me.btn_archivar)
        Me.Grupo_documento.Controls.Add(Me.btn_nueva)
        Me.Grupo_documento.Controls.Add(Me.txt_profesion)
        Me.Grupo_documento.Controls.Add(Me.Label3)
        Me.Grupo_documento.Controls.Add(Me.txt_cod_prof)
        Me.Grupo_documento.Controls.Add(Me.Label2)
        Me.Grupo_documento.Location = New System.Drawing.Point(349, 83)
        Me.Grupo_documento.Name = "Grupo_documento"
        Me.Grupo_documento.Size = New System.Drawing.Size(302, 431)
        Me.Grupo_documento.TabIndex = 45
        Me.Grupo_documento.TabStop = False
        Me.Grupo_documento.Text = "Opciones"
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
        'txt_profesion
        '
        Me.txt_profesion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_profesion.Location = New System.Drawing.Point(10, 93)
        Me.txt_profesion.MaxLength = 300
        Me.txt_profesion.Multiline = True
        Me.txt_profesion.Name = "txt_profesion"
        Me.txt_profesion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_profesion.Size = New System.Drawing.Size(288, 148)
        Me.txt_profesion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Profesión"
        '
        'txt_cod_prof
        '
        Me.txt_cod_prof.BackColor = System.Drawing.Color.LightYellow
        Me.txt_cod_prof.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_prof.Location = New System.Drawing.Point(10, 41)
        Me.txt_cod_prof.MaxLength = 4
        Me.txt_cod_prof.Name = "txt_cod_prof"
        Me.txt_cod_prof.Size = New System.Drawing.Size(75, 29)
        Me.txt_cod_prof.TabIndex = 1
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
        Me.Lbl_titulo.Location = New System.Drawing.Point(99, 9)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(435, 88)
        Me.Lbl_titulo.TabIndex = 39
        Me.Lbl_titulo.Text = "CONFIGURACION DE PROFESIONES / OCUPACIONES"
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
        'lista_buscar
        '
        Me.lista_buscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lista_buscar.FullRowSelect = True
        Me.lista_buscar.GridLines = True
        Me.lista_buscar.HideSelection = False
        Me.lista_buscar.Location = New System.Drawing.Point(2, 151)
        Me.lista_buscar.MultiSelect = False
        Me.lista_buscar.Name = "lista_buscar"
        Me.lista_buscar.Size = New System.Drawing.Size(345, 363)
        Me.lista_buscar.TabIndex = 43
        Me.lista_buscar.Tag = "limpiar"
        Me.lista_buscar.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Buscar profesión"
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
        'frm_profesiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(652, 562)
        Me.Controls.Add(Me.chk_mostrar_inactivos)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.Grupo_documento)
        Me.Controls.Add(Me.txt_busca)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.lista_buscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_profesiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_documento.ResumeLayout(False)
        Me.Grupo_documento.PerformLayout()
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
    Friend WithEvents Grupo_documento As System.Windows.Forms.GroupBox
    Friend WithEvents btn_nueva As System.Windows.Forms.Button
    Friend WithEvents txt_profesion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cod_prof As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_busca As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents lista_buscar As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents chk_mostrar_inactivos As System.Windows.Forms.CheckBox
End Class
