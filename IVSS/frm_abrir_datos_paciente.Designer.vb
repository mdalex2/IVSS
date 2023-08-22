<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_abrir_datos_paciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_abrir_datos_paciente))
        Me.Lista_abrir_paciente = New System.Windows.Forms.ListView()
        Me.Txt_busca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_opcn_busca = New System.Windows.Forms.ComboBox()
        Me.Lbl_total_reg_encontrados = New System.Windows.Forms.Label()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Btn_aceptar = New System.Windows.Forms.Button()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lista_abrir_paciente
        '
        Me.Lista_abrir_paciente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lista_abrir_paciente.FullRowSelect = True
        Me.Lista_abrir_paciente.GridLines = True
        Me.Lista_abrir_paciente.HideSelection = False
        Me.Lista_abrir_paciente.Location = New System.Drawing.Point(2, 67)
        Me.Lista_abrir_paciente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Lista_abrir_paciente.Name = "Lista_abrir_paciente"
        Me.Lista_abrir_paciente.Size = New System.Drawing.Size(687, 300)
        Me.Lista_abrir_paciente.TabIndex = 3
        Me.Lista_abrir_paciente.Tag = ""
        Me.Lista_abrir_paciente.UseCompatibleStateImageBehavior = False
        Me.Lista_abrir_paciente.View = System.Windows.Forms.View.Details
        '
        'Txt_busca
        '
        Me.Txt_busca.Location = New System.Drawing.Point(161, 35)
        Me.Txt_busca.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_busca.Name = "Txt_busca"
        Me.Txt_busca.Size = New System.Drawing.Size(320, 25)
        Me.Txt_busca.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar por:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightBlue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(487, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmb_opcn_busca
        '
        Me.cmb_opcn_busca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_opcn_busca.BackColor = System.Drawing.Color.LightYellow
        Me.cmb_opcn_busca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_opcn_busca.FormattingEnabled = True
        Me.cmb_opcn_busca.Items.AddRange(New Object() {"Num. historia", "Num. documento", "Nombres y apellidos"})
        Me.cmb_opcn_busca.Location = New System.Drawing.Point(12, 34)
        Me.cmb_opcn_busca.Name = "cmb_opcn_busca"
        Me.cmb_opcn_busca.Size = New System.Drawing.Size(143, 25)
        Me.cmb_opcn_busca.TabIndex = 2
        '
        'Lbl_total_reg_encontrados
        '
        Me.Lbl_total_reg_encontrados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_total_reg_encontrados.AutoSize = True
        Me.Lbl_total_reg_encontrados.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_total_reg_encontrados.Location = New System.Drawing.Point(12, 383)
        Me.Lbl_total_reg_encontrados.Name = "Lbl_total_reg_encontrados"
        Me.Lbl_total_reg_encontrados.Size = New System.Drawing.Size(0, 17)
        Me.Lbl_total_reg_encontrados.TabIndex = 8
        Me.Lbl_total_reg_encontrados.Tag = "limpiar"
        Me.Lbl_total_reg_encontrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 368)
        Me.Pic_pie_pagina.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(689, 61)
        Me.Pic_pie_pagina.TabIndex = 31
        Me.Pic_pie_pagina.TabStop = False
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Encabezado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(689, 70)
        Me.Pic_Encabezado.TabIndex = 32
        Me.Pic_Encabezado.TabStop = False
        '
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(616, 4)
        Me.Pic_icono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(62, 56)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 34
        Me.Pic_icono.TabStop = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_Button.BackColor = System.Drawing.Color.LightBlue
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Image = CType(resources.GetObject("Cancel_Button.Image"), System.Drawing.Image)
        Me.Cancel_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel_Button.Location = New System.Drawing.Point(588, 375)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 41)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "Cancelar"
        Me.Cancel_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Btn_aceptar
        '
        Me.Btn_aceptar.BackColor = System.Drawing.Color.LightBlue
        Me.Btn_aceptar.Image = CType(resources.GetObject("Btn_aceptar.Image"), System.Drawing.Image)
        Me.Btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_aceptar.Location = New System.Drawing.Point(487, 377)
        Me.Btn_aceptar.Name = "Btn_aceptar"
        Me.Btn_aceptar.Size = New System.Drawing.Size(89, 40)
        Me.Btn_aceptar.TabIndex = 4
        Me.Btn_aceptar.Text = "&Aceptar"
        Me.Btn_aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_aceptar.UseVisualStyleBackColor = False
        '
        'frm_abrir_datos_paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(689, 429)
        Me.Controls.Add(Me.Btn_aceptar)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Lbl_total_reg_encontrados)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.cmb_opcn_busca)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_busca)
        Me.Controls.Add(Me.Lista_abrir_paciente)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_abrir_datos_paciente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abrir datos personales"
        Me.TopMost = True
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_busca As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmb_opcn_busca As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_total_reg_encontrados As System.Windows.Forms.Label
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Lista_abrir_paciente As System.Windows.Forms.ListView
    Friend WithEvents Btn_aceptar As System.Windows.Forms.Button

End Class
