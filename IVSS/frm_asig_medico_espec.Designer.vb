<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_asig_medico_espec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_asig_medico_espec))
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
        Me.opc_busca_numero = New System.Windows.Forms.RadioButton()
        Me.Opc_busca_nombres = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.imagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.Lista_medico = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lista_espec = New System.Windows.Forms.ListView()
        Me.Lbl_usuario = New System.Windows.Forms.Label()
        Me.cmb_turnos = New System.Windows.Forms.ComboBox()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Lbl_titulo.Text = "ASIGNAR MEDICOS A ESPECIALIDADES"
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
        Me.btn_archivar.Enabled = False
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
        Me.btn_eliminar.Enabled = False
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
        'opc_busca_numero
        '
        Me.opc_busca_numero.AutoSize = True
        Me.opc_busca_numero.Location = New System.Drawing.Point(555, 35)
        Me.opc_busca_numero.Name = "opc_busca_numero"
        Me.opc_busca_numero.Size = New System.Drawing.Size(80, 17)
        Me.opc_busca_numero.TabIndex = 63
        Me.opc_busca_numero.TabStop = True
        Me.opc_busca_numero.Text = "Documento"
        Me.ToolTip1.SetToolTip(Me.opc_busca_numero, "Buscar por número de documento de identificación")
        Me.opc_busca_numero.UseVisualStyleBackColor = True
        '
        'Opc_busca_nombres
        '
        Me.Opc_busca_nombres.AutoSize = True
        Me.Opc_busca_nombres.Checked = True
        Me.Opc_busca_nombres.Location = New System.Drawing.Point(401, 35)
        Me.Opc_busca_nombres.Name = "Opc_busca_nombres"
        Me.Opc_busca_nombres.Size = New System.Drawing.Size(119, 17)
        Me.Opc_busca_nombres.TabIndex = 64
        Me.Opc_busca_nombres.TabStop = True
        Me.Opc_busca_nombres.Text = "Nombres y apellidos"
        Me.ToolTip1.SetToolTip(Me.Opc_busca_nombres, "Buscar por nombres y apellidos del medico")
        Me.Opc_busca_nombres.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Opc_busca_nombres)
        Me.GroupBox1.Controls.Add(Me.opc_busca_numero)
        Me.GroupBox1.Controls.Add(Me.btn_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_busca)
        Me.GroupBox1.Controls.Add(Me.Lista_medico)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 164)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_buscar.ImageIndex = 0
        Me.btn_buscar.ImageList = Me.imagenes
        Me.btn_buscar.Location = New System.Drawing.Point(338, 24)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(47, 33)
        Me.btn_buscar.TabIndex = 62
        Me.btn_buscar.Tag = "0"
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
        'txt_busca
        '
        Me.txt_busca.BackColor = System.Drawing.Color.LightYellow
        Me.txt_busca.Location = New System.Drawing.Point(6, 34)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(326, 23)
        Me.txt_busca.TabIndex = 59
        '
        'Lista_medico
        '
        Me.Lista_medico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lista_medico.BackColor = System.Drawing.Color.White
        Me.Lista_medico.GridLines = True
        Me.Lista_medico.HideSelection = False
        Me.Lista_medico.Location = New System.Drawing.Point(6, 59)
        Me.Lista_medico.Name = "Lista_medico"
        Me.Lista_medico.Size = New System.Drawing.Size(638, 99)
        Me.Lista_medico.TabIndex = 49
        Me.Lista_medico.Tag = "limpiar"
        Me.Lista_medico.UseCompatibleStateImageBehavior = False
        Me.Lista_medico.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Médico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(11, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Especialidades asignadas turno:"
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
        Me.Lista_espec.Location = New System.Drawing.Point(8, 277)
        Me.Lista_espec.MultiSelect = False
        Me.Lista_espec.Name = "Lista_espec"
        Me.Lista_espec.Size = New System.Drawing.Size(650, 195)
        Me.Lista_espec.TabIndex = 64
        Me.Lista_espec.Tag = "limpiar"
        Me.Lista_espec.UseCompatibleStateImageBehavior = False
        Me.Lista_espec.View = System.Windows.Forms.View.Details
        '
        'Lbl_usuario
        '
        Me.Lbl_usuario.BackColor = System.Drawing.Color.LightBlue
        Me.Lbl_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_usuario.Location = New System.Drawing.Point(8, 478)
        Me.Lbl_usuario.Name = "Lbl_usuario"
        Me.Lbl_usuario.Size = New System.Drawing.Size(246, 41)
        Me.Lbl_usuario.TabIndex = 68
        '
        'cmb_turnos
        '
        Me.cmb_turnos.FormattingEnabled = True
        Me.cmb_turnos.Location = New System.Drawing.Point(187, 248)
        Me.cmb_turnos.Name = "cmb_turnos"
        Me.cmb_turnos.Size = New System.Drawing.Size(471, 23)
        Me.cmb_turnos.TabIndex = 70
        '
        'frm_asig_medico_espec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(666, 531)
        Me.Controls.Add(Me.cmb_turnos)
        Me.Controls.Add(Me.Lbl_usuario)
        Me.Controls.Add(Me.Lista_espec)
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
        Me.Name = "frm_asig_medico_espec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turnos"
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents txt_busca As System.Windows.Forms.TextBox
    Friend WithEvents Lista_medico As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lista_espec As System.Windows.Forms.ListView
    Friend WithEvents Lbl_usuario As System.Windows.Forms.Label
    Friend WithEvents imagenes As System.Windows.Forms.ImageList
    Friend WithEvents Opc_busca_nombres As System.Windows.Forms.RadioButton
    Friend WithEvents opc_busca_numero As System.Windows.Forms.RadioButton
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_turnos As System.Windows.Forms.ComboBox
End Class
