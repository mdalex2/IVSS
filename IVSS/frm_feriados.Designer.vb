<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_feriados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_feriados))
        Me.btn_reporte = New System.Windows.Forms.Button()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Grupo_datos = New System.Windows.Forms.GroupBox()
        Me.txt_notas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_variable = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_guardado_por = New System.Windows.Forms.Label()
        Me.fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.TXT_feriado = New System.Windows.Forms.ComboBox()
        Me.fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.Informativo = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_archivar = New System.Windows.Forms.Button()
        Me.btn_nueva = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lista_buscar = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fecha_h_lista = New System.Windows.Forms.DateTimePicker()
        Me.fecha_d_lista = New System.Windows.Forms.DateTimePicker()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_datos.SuspendLayout()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_reporte
        '
        Me.btn_reporte.BackColor = System.Drawing.Color.LightBlue
        Me.btn_reporte.Image = CType(resources.GetObject("btn_reporte.Image"), System.Drawing.Image)
        Me.btn_reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reporte.Location = New System.Drawing.Point(556, 455)
        Me.btn_reporte.Name = "btn_reporte"
        Me.btn_reporte.Size = New System.Drawing.Size(85, 33)
        Me.btn_reporte.TabIndex = 47
        Me.btn_reporte.Text = "Listado"
        Me.btn_reporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_reporte, "Vista previa del listado")
        Me.btn_reporte.UseVisualStyleBackColor = False
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
        Me.Pic_icono.Size = New System.Drawing.Size(62, 58)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 40
        Me.Pic_icono.TabStop = False
        '
        'Grupo_datos
        '
        Me.Grupo_datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grupo_datos.Controls.Add(Me.txt_notas)
        Me.Grupo_datos.Controls.Add(Me.Label5)
        Me.Grupo_datos.Controls.Add(Me.chk_variable)
        Me.Grupo_datos.Controls.Add(Me.Label8)
        Me.Grupo_datos.Controls.Add(Me.Label3)
        Me.Grupo_datos.Controls.Add(Me.Label7)
        Me.Grupo_datos.Controls.Add(Me.lbl_guardado_por)
        Me.Grupo_datos.Controls.Add(Me.fecha_hasta)
        Me.Grupo_datos.Controls.Add(Me.TXT_feriado)
        Me.Grupo_datos.Controls.Add(Me.fecha_desde)
        Me.Grupo_datos.Controls.Add(Me.Label4)
        Me.Grupo_datos.Location = New System.Drawing.Point(282, 95)
        Me.Grupo_datos.Name = "Grupo_datos"
        Me.Grupo_datos.Size = New System.Drawing.Size(359, 349)
        Me.Grupo_datos.TabIndex = 45
        Me.Grupo_datos.TabStop = False
        Me.Grupo_datos.Text = "Opciones"
        '
        'txt_notas
        '
        Me.txt_notas.Location = New System.Drawing.Point(11, 192)
        Me.txt_notas.Multiline = True
        Me.txt_notas.Name = "txt_notas"
        Me.txt_notas.Size = New System.Drawing.Size(331, 85)
        Me.txt_notas.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 17)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "NOTAS:"
        '
        'chk_variable
        '
        Me.chk_variable.AutoSize = True
        Me.chk_variable.Location = New System.Drawing.Point(227, 14)
        Me.chk_variable.Name = "chk_variable"
        Me.chk_variable.Size = New System.Drawing.Size(100, 17)
        Me.chk_variable.TabIndex = 66
        Me.chk_variable.Text = "Varía cada año"
        Me.chk_variable.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 17)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Guardado por:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Fecha hasta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 17)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Fecha desde:"
        '
        'lbl_guardado_por
        '
        Me.lbl_guardado_por.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_guardado_por.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guardado_por.Location = New System.Drawing.Point(11, 298)
        Me.lbl_guardado_por.Name = "lbl_guardado_por"
        Me.lbl_guardado_por.Size = New System.Drawing.Size(333, 34)
        Me.lbl_guardado_por.TabIndex = 57
        Me.lbl_guardado_por.Tag = "limpiar"
        Me.lbl_guardado_por.Text = "Usuario:"
        Me.lbl_guardado_por.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Informativo.SetToolTip(Me.lbl_guardado_por, "Usuario que efectuó el registro")
        '
        'fecha_hasta
        '
        Me.fecha_hasta.Location = New System.Drawing.Point(9, 89)
        Me.fecha_hasta.Name = "fecha_hasta"
        Me.fecha_hasta.Size = New System.Drawing.Size(335, 25)
        Me.fecha_hasta.TabIndex = 61
        Me.fecha_hasta.Tag = "limpiar"
        '
        'TXT_feriado
        '
        Me.TXT_feriado.FormattingEnabled = True
        Me.TXT_feriado.Items.AddRange(New Object() {"DIA DE LA MADRE", "DIA DEL PADRE", "DIA FESTIVO DECRETO PRESIDENCIAL", "DIA DE LA BANDERA", "FIRMA DEL ACTA DE INDEPENDENCIA", "DIA DE LA RESISTENCIA INDIGENA", "BATALLA DE CARABOBO", "DIA DEL TRABAJADOR", "DIA DEL MÉDICO", "DIA DE LA ENFERMERA"})
        Me.TXT_feriado.Location = New System.Drawing.Point(7, 144)
        Me.TXT_feriado.Name = "TXT_feriado"
        Me.TXT_feriado.Size = New System.Drawing.Size(335, 25)
        Me.TXT_feriado.TabIndex = 60
        '
        'fecha_desde
        '
        Me.fecha_desde.Location = New System.Drawing.Point(9, 41)
        Me.fecha_desde.Name = "fecha_desde"
        Me.fecha_desde.Size = New System.Drawing.Size(335, 25)
        Me.fecha_desde.TabIndex = 59
        Me.fecha_desde.Tag = "limpiar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DESCRIPCION FERIADO"
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
        Me.Lbl_titulo.Text = "DIAS FERIADOS"
        Me.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cerrar.BackColor = System.Drawing.Color.LightBlue
        Me.Btn_cerrar.Image = CType(resources.GetObject("Btn_cerrar.Image"), System.Drawing.Image)
        Me.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cerrar.Location = New System.Drawing.Point(552, 16)
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
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 434)
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
        Me.Pic_Encabezado.Size = New System.Drawing.Size(652, 80)
        Me.Pic_Encabezado.TabIndex = 41
        Me.Pic_Encabezado.TabStop = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Enabled = False
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(465, 455)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(84, 33)
        Me.btn_eliminar.TabIndex = 55
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_eliminar, "Borrar  feriado")
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_archivar
        '
        Me.btn_archivar.Image = CType(resources.GetObject("btn_archivar.Image"), System.Drawing.Image)
        Me.btn_archivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_archivar.Location = New System.Drawing.Point(371, 455)
        Me.btn_archivar.Name = "btn_archivar"
        Me.btn_archivar.Size = New System.Drawing.Size(88, 33)
        Me.btn_archivar.TabIndex = 54
        Me.btn_archivar.Tag = "0"
        Me.btn_archivar.Text = "&Archivar"
        Me.btn_archivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_archivar, "Archivar ")
        Me.btn_archivar.UseVisualStyleBackColor = True
        '
        'btn_nueva
        '
        Me.btn_nueva.Image = CType(resources.GetObject("btn_nueva.Image"), System.Drawing.Image)
        Me.btn_nueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nueva.Location = New System.Drawing.Point(288, 455)
        Me.btn_nueva.Name = "btn_nueva"
        Me.btn_nueva.Size = New System.Drawing.Size(77, 33)
        Me.btn_nueva.TabIndex = 53
        Me.btn_nueva.Text = "&Nuevo"
        Me.btn_nueva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.btn_nueva, "Agregar nuevo")
        Me.btn_nueva.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(180, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 23)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "&Mostrar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Informativo.SetToolTip(Me.Button1, "Mostrar dias feriados")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lista_buscar
        '
        Me.Lista_buscar.CheckBoxes = True
        Me.Lista_buscar.FullRowSelect = True
        Me.Lista_buscar.GridLines = True
        Me.Lista_buscar.HideSelection = False
        Me.Lista_buscar.Location = New System.Drawing.Point(12, 106)
        Me.Lista_buscar.MultiSelect = False
        Me.Lista_buscar.Name = "Lista_buscar"
        Me.Lista_buscar.Size = New System.Drawing.Size(259, 266)
        Me.Lista_buscar.TabIndex = 49
        Me.Lista_buscar.Tag = "limpiar"
        Me.Lista_buscar.UseCompatibleStateImageBehavior = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.fecha_h_lista)
        Me.GroupBox2.Controls.Add(Me.fecha_d_lista)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 378)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 129)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mostrar en la lista fechas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Fecha hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Fecha desde:"
        '
        'fecha_h_lista
        '
        Me.fecha_h_lista.Location = New System.Drawing.Point(10, 88)
        Me.fecha_h_lista.Name = "fecha_h_lista"
        Me.fecha_h_lista.Size = New System.Drawing.Size(247, 25)
        Me.fecha_h_lista.TabIndex = 60
        '
        'fecha_d_lista
        '
        Me.fecha_d_lista.Location = New System.Drawing.Point(12, 41)
        Me.fecha_d_lista.Name = "fecha_d_lista"
        Me.fecha_d_lista.Size = New System.Drawing.Size(247, 25)
        Me.fecha_d_lista.TabIndex = 59
        '
        'frm_feriados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(652, 519)
        Me.Controls.Add(Me.Grupo_datos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_archivar)
        Me.Controls.Add(Me.btn_nueva)
        Me.Controls.Add(Me.Lista_buscar)
        Me.Controls.Add(Me.btn_reporte)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_feriados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_datos.ResumeLayout(False)
        Me.Grupo_datos.PerformLayout()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Informativo As System.Windows.Forms.ToolTip
    Friend WithEvents btn_reporte As System.Windows.Forms.Button
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Grupo_datos As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents Lista_buscar As System.Windows.Forms.ListView
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_archivar As System.Windows.Forms.Button
    Friend WithEvents btn_nueva As System.Windows.Forms.Button
    Friend WithEvents TXT_feriado As System.Windows.Forms.ComboBox
    Friend WithEvents fecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha_h_lista As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_d_lista As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_guardado_por As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chk_variable As System.Windows.Forms.CheckBox
    Friend WithEvents txt_notas As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
