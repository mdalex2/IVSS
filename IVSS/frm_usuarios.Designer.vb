<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_usuarios))
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.Informativo = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_archivar = New System.Windows.Forms.Button()
        Me.btn_nueva = New System.Windows.Forms.Button()
        Me.lbl_guardado_por = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_notas_observ = New System.Windows.Forms.TextBox()
        Me.chk_modifica_clave = New System.Windows.Forms.CheckBox()
        Me.Grupo_cargos = New System.Windows.Forms.GroupBox()
        Me.cmb_tipo_cuenta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_activo = New System.Windows.Forms.CheckBox()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_num_hist = New System.Windows.Forms.Label()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_cargos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_reporte
        '
        Me.btn_reporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_reporte.BackColor = System.Drawing.Color.LightBlue
        Me.btn_reporte.Image = CType(resources.GetObject("btn_reporte.Image"), System.Drawing.Image)
        Me.btn_reporte.Location = New System.Drawing.Point(605, 379)
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
        Me.btn_buscar.Location = New System.Drawing.Point(190, 27)
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
        'Lbl_titulo
        '
        Me.Lbl_titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_titulo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_titulo.Location = New System.Drawing.Point(99, 16)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(435, 64)
        Me.Lbl_titulo.TabIndex = 39
        Me.Lbl_titulo.Text = "CONFIGURACION DE USUARIOS"
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
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 353)
        Me.Pic_pie_pagina.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(652, 85)
        Me.Pic_pie_pagina.TabIndex = 38
        Me.Pic_pie_pagina.TabStop = False
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nº Historia"
        Me.Informativo.SetToolTip(Me.Label2, "Codigo del tipo de documento")
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(497, 379)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(88, 33)
        Me.btn_eliminar.TabIndex = 51
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_eliminar, "Borrar especialidad")
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_archivar
        '
        Me.btn_archivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_archivar.Image = CType(resources.GetObject("btn_archivar.Image"), System.Drawing.Image)
        Me.btn_archivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_archivar.Location = New System.Drawing.Point(404, 379)
        Me.btn_archivar.Name = "btn_archivar"
        Me.btn_archivar.Size = New System.Drawing.Size(87, 33)
        Me.btn_archivar.TabIndex = 50
        Me.btn_archivar.Tag = "0"
        Me.btn_archivar.Text = "&Archivar"
        Me.btn_archivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_archivar, "Archivar / Actualizar")
        Me.btn_archivar.UseVisualStyleBackColor = True
        '
        'btn_nueva
        '
        Me.btn_nueva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_nueva.Image = CType(resources.GetObject("btn_nueva.Image"), System.Drawing.Image)
        Me.btn_nueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nueva.Location = New System.Drawing.Point(311, 379)
        Me.btn_nueva.Name = "btn_nueva"
        Me.btn_nueva.Size = New System.Drawing.Size(87, 33)
        Me.btn_nueva.TabIndex = 49
        Me.btn_nueva.Text = "&Nuevo"
        Me.btn_nueva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_nueva, "Agregar nuevo")
        Me.btn_nueva.UseVisualStyleBackColor = True
        '
        'lbl_guardado_por
        '
        Me.lbl_guardado_por.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_guardado_por.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_guardado_por.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guardado_por.Location = New System.Drawing.Point(12, 369)
        Me.lbl_guardado_por.Name = "lbl_guardado_por"
        Me.lbl_guardado_por.Size = New System.Drawing.Size(288, 43)
        Me.lbl_guardado_por.TabIndex = 53
        Me.lbl_guardado_por.Tag = "limpiar"
        Me.lbl_guardado_por.Text = "Usuario:"
        Me.lbl_guardado_por.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Informativo.SetToolTip(Me.lbl_guardado_por, "Usuario que efectuó el registro")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Clave de acceso"
        '
        'txt_login
        '
        Me.txt_login.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(8, 148)
        Me.txt_login.MaxLength = 50
        Me.txt_login.Name = "txt_login"
        Me.txt_login.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_login.Size = New System.Drawing.Size(339, 29)
        Me.txt_login.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(350, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Notas / Observaciones"
        '
        'txt_notas_observ
        '
        Me.txt_notas_observ.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notas_observ.Location = New System.Drawing.Point(353, 89)
        Me.txt_notas_observ.MaxLength = 300
        Me.txt_notas_observ.Multiline = True
        Me.txt_notas_observ.Name = "txt_notas_observ"
        Me.txt_notas_observ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notas_observ.Size = New System.Drawing.Size(269, 88)
        Me.txt_notas_observ.TabIndex = 5
        '
        'chk_modifica_clave
        '
        Me.chk_modifica_clave.AutoSize = True
        Me.chk_modifica_clave.Location = New System.Drawing.Point(222, 179)
        Me.chk_modifica_clave.Name = "chk_modifica_clave"
        Me.chk_modifica_clave.Size = New System.Drawing.Size(106, 17)
        Me.chk_modifica_clave.TabIndex = 11
        Me.chk_modifica_clave.Text = "Modifica la clave"
        Me.chk_modifica_clave.UseVisualStyleBackColor = True
        '
        'Grupo_cargos
        '
        Me.Grupo_cargos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Grupo_cargos.Controls.Add(Me.cmb_tipo_cuenta)
        Me.Grupo_cargos.Controls.Add(Me.Label1)
        Me.Grupo_cargos.Controls.Add(Me.chk_activo)
        Me.Grupo_cargos.Controls.Add(Me.txt_clave)
        Me.Grupo_cargos.Controls.Add(Me.Label8)
        Me.Grupo_cargos.Controls.Add(Me.lbl_usuario)
        Me.Grupo_cargos.Controls.Add(Me.Label6)
        Me.Grupo_cargos.Controls.Add(Me.lbl_num_hist)
        Me.Grupo_cargos.Controls.Add(Me.chk_modifica_clave)
        Me.Grupo_cargos.Controls.Add(Me.txt_notas_observ)
        Me.Grupo_cargos.Controls.Add(Me.Label4)
        Me.Grupo_cargos.Controls.Add(Me.btn_buscar)
        Me.Grupo_cargos.Controls.Add(Me.txt_login)
        Me.Grupo_cargos.Controls.Add(Me.Label3)
        Me.Grupo_cargos.Controls.Add(Me.Label2)
        Me.Grupo_cargos.Location = New System.Drawing.Point(12, 101)
        Me.Grupo_cargos.Name = "Grupo_cargos"
        Me.Grupo_cargos.Size = New System.Drawing.Size(628, 240)
        Me.Grupo_cargos.TabIndex = 45
        Me.Grupo_cargos.TabStop = False
        Me.Grupo_cargos.Text = "Opciones"
        '
        'cmb_tipo_cuenta
        '
        Me.cmb_tipo_cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_cuenta.FormattingEnabled = True
        Me.cmb_tipo_cuenta.Items.AddRange(New Object() {"ADMINISTRADOR", "USUARIO AVANZADO", "USUARIO"})
        Me.cmb_tipo_cuenta.Location = New System.Drawing.Point(356, 200)
        Me.cmb_tipo_cuenta.Name = "cmb_tipo_cuenta"
        Me.cmb_tipo_cuenta.Size = New System.Drawing.Size(266, 25)
        Me.cmb_tipo_cuenta.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(353, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Tipo cuenta"
        '
        'chk_activo
        '
        Me.chk_activo.AutoSize = True
        Me.chk_activo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_activo.ForeColor = System.Drawing.Color.DarkRed
        Me.chk_activo.Location = New System.Drawing.Point(353, 36)
        Me.chk_activo.Name = "chk_activo"
        Me.chk_activo.Size = New System.Drawing.Size(115, 21)
        Me.chk_activo.TabIndex = 51
        Me.chk_activo.Text = "Usuario activo"
        Me.chk_activo.UseVisualStyleBackColor = True
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(8, 200)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_clave.Size = New System.Drawing.Size(339, 25)
        Me.txt_clave.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Login"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_usuario.Location = New System.Drawing.Point(8, 89)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(339, 24)
        Me.lbl_usuario.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Usuario"
        '
        'lbl_num_hist
        '
        Me.lbl_num_hist.BackColor = System.Drawing.Color.Khaki
        Me.lbl_num_hist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_num_hist.Location = New System.Drawing.Point(8, 34)
        Me.lbl_num_hist.Name = "lbl_num_hist"
        Me.lbl_num_hist.Size = New System.Drawing.Size(176, 23)
        Me.lbl_num_hist.TabIndex = 16
        '
        'frm_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(652, 438)
        Me.Controls.Add(Me.lbl_guardado_por)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_archivar)
        Me.Controls.Add(Me.btn_nueva)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.Grupo_cargos)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_cargos.ResumeLayout(False)
        Me.Grupo_cargos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Informativo As System.Windows.Forms.ToolTip
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_login As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_notas_observ As System.Windows.Forms.TextBox
    Friend WithEvents chk_modifica_clave As System.Windows.Forms.CheckBox
    Friend WithEvents Grupo_cargos As System.Windows.Forms.GroupBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_num_hist As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_archivar As System.Windows.Forms.Button
    Friend WithEvents btn_nueva As System.Windows.Forms.Button
    Friend WithEvents lbl_guardado_por As System.Windows.Forms.Label
    Friend WithEvents chk_activo As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_tipo_cuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
