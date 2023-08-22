<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reportes
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
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.CRViewer91 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewer91
        '
        Me.CRViewer91.ActiveViewIndex = -1
        Me.CRViewer91.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CRViewer91.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer91.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer91.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRViewer91.Location = New System.Drawing.Point(0, 0)
        Me.CRViewer91.Name = "CRViewer91"
        Me.CRViewer91.ReuseParameterValuesOnRefresh = True
        Me.CRViewer91.ShowParameterPanelButton = False
        Me.CRViewer91.Size = New System.Drawing.Size(691, 426)
        Me.CRViewer91.TabIndex = 1
        Me.CRViewer91.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frm_reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 426)
        Me.Controls.Add(Me.CRViewer91)
        Me.DoubleBuffered = True
        Me.Name = "frm_reportes"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewer91 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Public WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
End Class
