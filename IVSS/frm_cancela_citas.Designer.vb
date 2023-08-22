<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cancela_citas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cancela_citas))
        Me.cmb_motivo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_cancela_cita = New System.Windows.Forms.Button()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_motivo
        '
        Me.cmb_motivo.FormattingEnabled = True
        Me.cmb_motivo.Items.AddRange(New Object() {"A PETICIÓN DEL PACIENTE", "NO ASISTE EL MÉDICO", "DIA DE NO CONSULTAS EN EL HOSPITAL"})
        Me.cmb_motivo.Location = New System.Drawing.Point(15, 108)
        Me.cmb_motivo.Name = "cmb_motivo"
        Me.cmb_motivo.Size = New System.Drawing.Size(480, 25)
        Me.cmb_motivo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione el motivo de la cancelación"
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 225)
        Me.Pic_pie_pagina.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(507, 54)
        Me.Pic_pie_pagina.TabIndex = 53
        Me.Pic_pie_pagina.TabStop = False
        '
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(12, 4)
        Me.Pic_icono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(62, 60)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 50
        Me.Pic_icono.TabStop = False
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cerrar.BackColor = System.Drawing.Color.LightBlue
        Me.Btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_cerrar.Image = CType(resources.GetObject("Btn_cerrar.Image"), System.Drawing.Image)
        Me.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cerrar.Location = New System.Drawing.Point(411, 13)
        Me.Btn_cerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_cerrar.Name = "Btn_cerrar"
        Me.Btn_cerrar.Size = New System.Drawing.Size(88, 43)
        Me.Btn_cerrar.TabIndex = 48
        Me.Btn_cerrar.Text = "&Cerrar"
        Me.Btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_cerrar.UseVisualStyleBackColor = False
        '
        'Lbl_titulo
        '
        Me.Lbl_titulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_titulo.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_titulo.Location = New System.Drawing.Point(99, 4)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(306, 64)
        Me.Lbl_titulo.TabIndex = 49
        Me.Lbl_titulo.Text = "CANCELAR CITAS"
        Me.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_cancela_cita
        '
        Me.btn_cancela_cita.BackColor = System.Drawing.Color.LightBlue
        Me.btn_cancela_cita.Image = CType(resources.GetObject("btn_cancela_cita.Image"), System.Drawing.Image)
        Me.btn_cancela_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancela_cita.Location = New System.Drawing.Point(407, 154)
        Me.btn_cancela_cita.Name = "btn_cancela_cita"
        Me.btn_cancela_cita.Size = New System.Drawing.Size(88, 82)
        Me.btn_cancela_cita.TabIndex = 47
        Me.btn_cancela_cita.Text = "&Cancelar citas"
        Me.btn_cancela_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancela_cita.UseVisualStyleBackColor = False
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Encabezado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(507, 84)
        Me.Pic_Encabezado.TabIndex = 51
        Me.Pic_Encabezado.TabStop = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(12, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(389, 82)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'frm_cancela_citas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Btn_cerrar
        Me.ClientSize = New System.Drawing.Size(507, 279)
        Me.Controls.Add(Me.btn_cancela_cita)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_motivo)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_cancela_citas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Motivo de la cancelación"
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_motivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents btn_cancela_cita As System.Windows.Forms.Button
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
