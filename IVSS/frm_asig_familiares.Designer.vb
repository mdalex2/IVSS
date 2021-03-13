<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_asig_familiares
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_asig_familiares))
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.Lista_buscar = New System.Windows.Forms.ListView()
        Me.Grupo_familiar = New System.Windows.Forms.GroupBox()
        Me.chk_beneficiario = New System.Windows.Forms.CheckBox()
        Me.btn_asignar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_afinidad = New System.Windows.Forms.ComboBox()
        Me.lbl_nombre_familiar = New System.Windows.Forms.Label()
        Me.lbl_num_hist_familiar = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_nueva = New System.Windows.Forms.Button()
        Me.Grupo_paciente = New System.Windows.Forms.GroupBox()
        Me.lbl_nombres_paciente = New System.Windows.Forms.Label()
        Me.lbl_num_hist_paciente = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo_familiar.SuspendLayout()
        Me.Grupo_paciente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(11, 13)
        Me.Pic_icono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(81, 80)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 47
        Me.Pic_icono.TabStop = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(536, 507)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(88, 33)
        Me.btn_eliminar.TabIndex = 43
        Me.btn_eliminar.Text = "&Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cerrar.BackColor = System.Drawing.Color.LightBlue
        Me.Btn_cerrar.Image = CType(resources.GetObject("Btn_cerrar.Image"), System.Drawing.Image)
        Me.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cerrar.Location = New System.Drawing.Point(539, 28)
        Me.Btn_cerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_cerrar.Name = "Btn_cerrar"
        Me.Btn_cerrar.Size = New System.Drawing.Size(91, 43)
        Me.Btn_cerrar.TabIndex = 44
        Me.Btn_cerrar.Text = "&Cerrar"
        Me.Btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_cerrar.UseVisualStyleBackColor = False
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 467)
        Me.Pic_pie_pagina.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(642, 85)
        Me.Pic_pie_pagina.TabIndex = 45
        Me.Pic_pie_pagina.TabStop = False
        '
        'Lbl_titulo
        '
        Me.Lbl_titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_titulo.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_titulo.Location = New System.Drawing.Point(98, 16)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(435, 64)
        Me.Lbl_titulo.TabIndex = 46
        Me.Lbl_titulo.Text = "ASIGNACIÓN DE FAMILIARES O BENEFICIARIOS"
        Me.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Encabezado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(642, 105)
        Me.Pic_Encabezado.TabIndex = 48
        Me.Pic_Encabezado.TabStop = False
        '
        'Lista_buscar
        '
        Me.Lista_buscar.FullRowSelect = True
        Me.Lista_buscar.GridLines = True
        Me.Lista_buscar.HideSelection = False
        Me.Lista_buscar.Location = New System.Drawing.Point(11, 339)
        Me.Lista_buscar.MultiSelect = False
        Me.Lista_buscar.Name = "Lista_buscar"
        Me.Lista_buscar.Size = New System.Drawing.Size(619, 162)
        Me.Lista_buscar.TabIndex = 50
        Me.Lista_buscar.Tag = "limpiar"
        Me.Lista_buscar.UseCompatibleStateImageBehavior = False
        '
        'Grupo_familiar
        '
        Me.Grupo_familiar.Controls.Add(Me.chk_beneficiario)
        Me.Grupo_familiar.Controls.Add(Me.btn_asignar)
        Me.Grupo_familiar.Controls.Add(Me.Label5)
        Me.Grupo_familiar.Controls.Add(Me.cmb_afinidad)
        Me.Grupo_familiar.Controls.Add(Me.lbl_nombre_familiar)
        Me.Grupo_familiar.Controls.Add(Me.lbl_num_hist_familiar)
        Me.Grupo_familiar.Controls.Add(Me.label)
        Me.Grupo_familiar.Controls.Add(Me.Label1)
        Me.Grupo_familiar.Controls.Add(Me.btn_nueva)
        Me.Grupo_familiar.Location = New System.Drawing.Point(12, 187)
        Me.Grupo_familiar.Name = "Grupo_familiar"
        Me.Grupo_familiar.Size = New System.Drawing.Size(618, 146)
        Me.Grupo_familiar.TabIndex = 51
        Me.Grupo_familiar.TabStop = False
        Me.Grupo_familiar.Text = "Datos del familia o beneficiario"
        '
        'chk_beneficiario
        '
        Me.chk_beneficiario.AutoSize = True
        Me.chk_beneficiario.Location = New System.Drawing.Point(263, 76)
        Me.chk_beneficiario.Name = "chk_beneficiario"
        Me.chk_beneficiario.Size = New System.Drawing.Size(94, 21)
        Me.chk_beneficiario.TabIndex = 51
        Me.chk_beneficiario.Text = "Beneficiario"
        Me.chk_beneficiario.UseVisualStyleBackColor = True
        '
        'btn_asignar
        '
        Me.btn_asignar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_asignar.Image = CType(resources.GetObject("btn_asignar.Image"), System.Drawing.Image)
        Me.btn_asignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_asignar.Location = New System.Drawing.Point(514, 76)
        Me.btn_asignar.Name = "btn_asignar"
        Me.btn_asignar.Size = New System.Drawing.Size(98, 50)
        Me.btn_asignar.TabIndex = 50
        Me.btn_asignar.Text = "&Asignar"
        Me.btn_asignar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ToolTip1.SetToolTip(Me.btn_asignar, "Asignar familiar o beneficiario")
        Me.btn_asignar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(260, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Afinidad"
        '
        'cmb_afinidad
        '
        Me.cmb_afinidad.FormattingEnabled = True
        Me.cmb_afinidad.Location = New System.Drawing.Point(263, 41)
        Me.cmb_afinidad.Name = "cmb_afinidad"
        Me.cmb_afinidad.Size = New System.Drawing.Size(220, 25)
        Me.cmb_afinidad.TabIndex = 48
        '
        'lbl_nombre_familiar
        '
        Me.lbl_nombre_familiar.AutoSize = True
        Me.lbl_nombre_familiar.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_familiar.Location = New System.Drawing.Point(5, 96)
        Me.lbl_nombre_familiar.Name = "lbl_nombre_familiar"
        Me.lbl_nombre_familiar.Size = New System.Drawing.Size(0, 30)
        Me.lbl_nombre_familiar.TabIndex = 47
        Me.lbl_nombre_familiar.Tag = "limpiar"
        '
        'lbl_num_hist_familiar
        '
        Me.lbl_num_hist_familiar.AutoSize = True
        Me.lbl_num_hist_familiar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num_hist_familiar.Location = New System.Drawing.Point(7, 41)
        Me.lbl_num_hist_familiar.Name = "lbl_num_hist_familiar"
        Me.lbl_num_hist_familiar.Size = New System.Drawing.Size(0, 25)
        Me.lbl_num_hist_familiar.TabIndex = 46
        Me.lbl_num_hist_familiar.Tag = "limpiar"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(7, 76)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(130, 17)
        Me.label.TabIndex = 45
        Me.label.Text = "Nombres y apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Nº Historia"
        '
        'btn_nueva
        '
        Me.btn_nueva.BackColor = System.Drawing.Color.LightBlue
        Me.btn_nueva.Image = CType(resources.GetObject("btn_nueva.Image"), System.Drawing.Image)
        Me.btn_nueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nueva.Location = New System.Drawing.Point(514, 41)
        Me.btn_nueva.Name = "btn_nueva"
        Me.btn_nueva.Size = New System.Drawing.Size(98, 25)
        Me.btn_nueva.TabIndex = 43
        Me.btn_nueva.Text = "&Nueva"
        Me.btn_nueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btn_nueva, "Crear nueva asignación")
        Me.btn_nueva.UseVisualStyleBackColor = False
        '
        'Grupo_paciente
        '
        Me.Grupo_paciente.Controls.Add(Me.lbl_nombres_paciente)
        Me.Grupo_paciente.Controls.Add(Me.lbl_num_hist_paciente)
        Me.Grupo_paciente.Controls.Add(Me.Label9)
        Me.Grupo_paciente.Controls.Add(Me.Label10)
        Me.Grupo_paciente.Location = New System.Drawing.Point(12, 100)
        Me.Grupo_paciente.Name = "Grupo_paciente"
        Me.Grupo_paciente.Size = New System.Drawing.Size(618, 86)
        Me.Grupo_paciente.TabIndex = 52
        Me.Grupo_paciente.TabStop = False
        Me.Grupo_paciente.Text = "Datos del paciente"
        '
        'lbl_nombres_paciente
        '
        Me.lbl_nombres_paciente.AutoSize = True
        Me.lbl_nombres_paciente.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombres_paciente.Location = New System.Drawing.Point(200, 41)
        Me.lbl_nombres_paciente.Name = "lbl_nombres_paciente"
        Me.lbl_nombres_paciente.Size = New System.Drawing.Size(0, 30)
        Me.lbl_nombres_paciente.TabIndex = 47
        Me.lbl_nombres_paciente.Tag = "limpiar"
        '
        'lbl_num_hist_paciente
        '
        Me.lbl_num_hist_paciente.AutoSize = True
        Me.lbl_num_hist_paciente.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_num_hist_paciente.Location = New System.Drawing.Point(7, 41)
        Me.lbl_num_hist_paciente.Name = "lbl_num_hist_paciente"
        Me.lbl_num_hist_paciente.Size = New System.Drawing.Size(0, 25)
        Me.lbl_num_hist_paciente.TabIndex = 46
        Me.lbl_num_hist_paciente.Tag = "limpiar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(202, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 17)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Nombres y apellidos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Nº Historia"
        '
        'frm_asig_familiares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(642, 552)
        Me.Controls.Add(Me.Grupo_paciente)
        Me.Controls.Add(Me.Lista_buscar)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Controls.Add(Me.Grupo_familiar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_asig_familiares"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_asig_familiares"
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo_familiar.ResumeLayout(False)
        Me.Grupo_familiar.PerformLayout()
        Me.Grupo_paciente.ResumeLayout(False)
        Me.Grupo_paciente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents Lista_buscar As System.Windows.Forms.ListView
    Friend WithEvents Grupo_familiar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_asignar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_afinidad As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_nombre_familiar As System.Windows.Forms.Label
    Friend WithEvents lbl_num_hist_familiar As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_nueva As System.Windows.Forms.Button
    Friend WithEvents Grupo_paciente As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_nombres_paciente As System.Windows.Forms.Label
    Friend WithEvents lbl_num_hist_paciente As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents chk_beneficiario As System.Windows.Forms.CheckBox
End Class
