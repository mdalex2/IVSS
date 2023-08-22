<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_respaldar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_respaldar))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_destino = New System.Windows.Forms.Label()
        Me.Pic_icono = New System.Windows.Forms.PictureBox()
        Me.Btn_cerrar = New System.Windows.Forms.Button()
        Me.Lbl_titulo = New System.Windows.Forms.Label()
        Me.Pic_Encabezado = New System.Windows.Forms.PictureBox()
        Me.btn_respaldar = New System.Windows.Forms.Button()
        Me.Pic_pie_pagina = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Seleccionarcarpeta = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightBlue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(411, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 64)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Seleccionar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Buscar la ruta donde desea copiar el respaldo de la Base de datos")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_destino
        '
        Me.txt_destino.BackColor = System.Drawing.Color.White
        Me.txt_destino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_destino.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_destino.Location = New System.Drawing.Point(12, 86)
        Me.txt_destino.Name = "txt_destino"
        Me.txt_destino.Size = New System.Drawing.Size(392, 106)
        Me.txt_destino.TabIndex = 3
        Me.txt_destino.Text = "RUTA DONDE SE ALMACENARÁ LA COPIA DE SEGURIDAD"
        Me.ToolTip1.SetToolTip(Me.txt_destino, "Clic aqui para buscar la ruta donde desea copiar el respaldo de la Base de datos")
        '
        'Pic_icono
        '
        Me.Pic_icono.BackColor = System.Drawing.Color.Transparent
        Me.Pic_icono.Location = New System.Drawing.Point(12, 4)
        Me.Pic_icono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_icono.Name = "Pic_icono"
        Me.Pic_icono.Size = New System.Drawing.Size(62, 60)
        Me.Pic_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_icono.TabIndex = 43
        Me.Pic_icono.TabStop = False
        '
        'Btn_cerrar
        '
        Me.Btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_cerrar.BackColor = System.Drawing.Color.LightBlue
        Me.Btn_cerrar.Image = CType(resources.GetObject("Btn_cerrar.Image"), System.Drawing.Image)
        Me.Btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cerrar.Location = New System.Drawing.Point(411, 13)
        Me.Btn_cerrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_cerrar.Name = "Btn_cerrar"
        Me.Btn_cerrar.Size = New System.Drawing.Size(88, 43)
        Me.Btn_cerrar.TabIndex = 41
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
        Me.Lbl_titulo.Location = New System.Drawing.Point(99, 0)
        Me.Lbl_titulo.Name = "Lbl_titulo"
        Me.Lbl_titulo.Size = New System.Drawing.Size(306, 64)
        Me.Lbl_titulo.TabIndex = 42
        Me.Lbl_titulo.Text = "COPIAS DE SEGURIDAD DE BD"
        Me.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pic_Encabezado
        '
        Me.Pic_Encabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pic_Encabezado.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Encabezado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_Encabezado.Name = "Pic_Encabezado"
        Me.Pic_Encabezado.Size = New System.Drawing.Size(507, 73)
        Me.Pic_Encabezado.TabIndex = 44
        Me.Pic_Encabezado.TabStop = False
        '
        'btn_respaldar
        '
        Me.btn_respaldar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_respaldar.BackColor = System.Drawing.Color.LightBlue
        Me.btn_respaldar.Enabled = False
        Me.btn_respaldar.Image = CType(resources.GetObject("btn_respaldar.Image"), System.Drawing.Image)
        Me.btn_respaldar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_respaldar.Location = New System.Drawing.Point(411, 171)
        Me.btn_respaldar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_respaldar.Name = "btn_respaldar"
        Me.btn_respaldar.Size = New System.Drawing.Size(88, 66)
        Me.btn_respaldar.TabIndex = 45
        Me.btn_respaldar.Text = "Copiar"
        Me.btn_respaldar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btn_respaldar, "Copiar la base de datos")
        Me.btn_respaldar.UseVisualStyleBackColor = False
        '
        'Pic_pie_pagina
        '
        Me.Pic_pie_pagina.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pic_pie_pagina.Location = New System.Drawing.Point(0, 196)
        Me.Pic_pie_pagina.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Pic_pie_pagina.Name = "Pic_pie_pagina"
        Me.Pic_pie_pagina.Size = New System.Drawing.Size(507, 54)
        Me.Pic_pie_pagina.TabIndex = 46
        Me.Pic_pie_pagina.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "DIRECTORIO:"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(12, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 41)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "NOTA: NO USAR DIRECTORIOS CON ESPACIOS EN BLANCO EJM: ""C:\RESPALDO BASE"" ==> USAR" & _
            " ""C:\RESPALDO_BASE"
        '
        'frm_respaldar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(507, 250)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_destino)
        Me.Controls.Add(Me.btn_respaldar)
        Me.Controls.Add(Me.Pic_pie_pagina)
        Me.Controls.Add(Me.Pic_icono)
        Me.Controls.Add(Me.Btn_cerrar)
        Me.Controls.Add(Me.Lbl_titulo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pic_Encabezado)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_respaldar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Respaldar base de datos"
        CType(Me.Pic_icono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Encabezado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_pie_pagina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_destino As System.Windows.Forms.Label
    Friend WithEvents Pic_icono As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents Pic_Encabezado As System.Windows.Forms.PictureBox
    Friend WithEvents btn_respaldar As System.Windows.Forms.Button
    Friend WithEvents Pic_pie_pagina As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Seleccionarcarpeta As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
