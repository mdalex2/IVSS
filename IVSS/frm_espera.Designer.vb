<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_espera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_espera))
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.Barra_progreso = New System.Windows.Forms.ProgressBar()
        Me.btn_cancela = New System.Windows.Forms.Button()
        'Me.Animation1 = New AxMSComCtl2.AxAnimation()
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        'CType(Me.Animation1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_mensaje.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mensaje.Location = New System.Drawing.Point(62, 9)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(278, 36)
        Me.lbl_mensaje.TabIndex = 0
        Me.lbl_mensaje.Text = "Label1"
        '
        'Barra_progreso
        '
        Me.Barra_progreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Barra_progreso.Location = New System.Drawing.Point(12, 129)
        Me.Barra_progreso.Name = "Barra_progreso"
        Me.Barra_progreso.Size = New System.Drawing.Size(243, 23)
        Me.Barra_progreso.TabIndex = 1
        '
        'btn_cancela
        '
        Me.btn_cancela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancela.Location = New System.Drawing.Point(265, 129)
        Me.btn_cancela.Name = "btn_cancela"
        Me.btn_cancela.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancela.TabIndex = 2
        Me.btn_cancela.Text = "&Cancelar"
        Me.btn_cancela.UseVisualStyleBackColor = True
        '
        'Animation1
        '
        'Me.Animation1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
        'Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        'Me.Animation1.Location = New System.Drawing.Point(12, 48)
        'Me.Animation1.Name = "Animation1"
        'Me.Animation1.OcxState = CType(resources.GetObject("Animation1.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.Animation1.Size = New System.Drawing.Size(328, 75)
        'Me.Animation1.TabIndex = 4
        '
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(12, 9)
        Me.Pic_icono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(40, 36)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 53
        Me.Pic_icono.TabStop = False
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 122)
        Me.Pic_pie_pagina.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(348, 42)
        Me.Pic_pie_pagina.TabIndex = 51
        Me.Pic_pie_pagina.TabStop = False
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Encabezado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(348, 53)
        Me.Pic_Encabezado.TabIndex = 54
        Me.Pic_Encabezado.TabStop = False
        '
        'frm_espera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(348, 164)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.Pic_Encabezado)
        'Me.Controls.Add(Me.Animation1)
        Me.Controls.Add(Me.btn_cancela)
        Me.Controls.Add(Me.Barra_progreso)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_espera"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Espere ..."
        Me.TopMost = True
        'CType(Me.Animation1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_mensaje As System.Windows.Forms.Label
    Friend WithEvents Barra_progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_cancela As System.Windows.Forms.Button
    'Friend WithEvents Animation1 As AxMSComCtl2.AxAnimation
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
