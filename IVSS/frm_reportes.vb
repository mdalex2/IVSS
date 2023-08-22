Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_reportes
    Public Sub Muestra_reporte(ByVal titulo_ventana As String, ByVal nombre_reporte As String, ByVal formula_de_seleccion As String, ByVal zoom As Integer, ByVal Impreso_por As String)
        ' instanciar objeto para guardar datos de conexión
        Dim Ruta_reporte As String
        Dim oConexInfo As ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTablaConexInfo As TableLogOnInfo
        oConexInfo = New ConnectionInfo()
        oConexInfo.ServerName = "127.0.0.1"
        oConexInfo.ServerName = "Driver = (MySQL ODBC 5.1 Driver);DSN=reportes"
        oConexInfo.DatabaseName = "ivss"
        oConexInfo.UserID = "siste+"
        oConexInfo.Password = "SisTe+2812+"
        Ruta_reporte = Application.StartupPath & "\Reportes\" & nombre_reporte

        ' Comprobamos la existencia del reporte, si el reporte no existe abortamos si no continuamos
        If Not IO.File.Exists(Ruta_reporte) Then
            MessageBox.Show("No se encontro reporte:" & vbCrLf & _
            Ruta_reporte, "Report Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rpt_id As New ReportDocument
        'Una vez verificado el reporte procedemos a cargarlo
        rpt_id.Load(Ruta_reporte)

        ''---------- P A R A M E T R O S ---------------------------
        Dim Params As New ParameterValues       ' Creando una Coleccion de Parametros
        Dim Par As New ParameterDiscreteValue   ' Parametro Discreto q viene en el proc. alm. y se muestra en el Crystal Report

        Params.Clear()              ' Limpiando la Coleccion de Datos
        Par.Value = titulo_ventana  ' Asignando un Valor Discreto a nuestra variable jalando el valor de una caja de texto de tu formulario
        Params.Add(Par)             ' Agregando el param discreto a la coleccion de parametros
        rpt_id.DataDefinition.ParameterFields("TITULO_REPORTE").ApplyCurrentValues(Params)   ' Aplicando los valores de nuestra coleccion a los parametros del crystal report

        Params.Clear()
        Par.Value = Impreso_por
        Params.Add(Par)
        rpt_id.DataDefinition.ParameterFields("IMPRESO_POR").ApplyCurrentValues(Params)
        rpt_id.RecordSelectionFormula = formula_de_seleccion
        '-----------------------------------------------------------

        oListaTablas = rpt_id.Database.Tables
        Dim oTabla As Table
        For Each oTabla In oListaTablas
            oTablaConexInfo = oTabla.LogOnInfo
            oTablaConexInfo.ConnectionInfo = oConexInfo
            oTabla.ApplyLogOnInfo(oTablaConexInfo)
            'ENVIANDO VARIABLE A CR
            'rpt_id.SetParameterValue("@Company", "VariableCompany")
        Next


        nueva_ventana = New frm_reportes
        rpt_id.ReportOptions.EnableSaveDataWithReport = True
        nueva_ventana.CRViewer91.ReportSource = rpt_id
        nueva_ventana.CRViewer91.Refresh()
        nueva_ventana.CRViewer91.ShowRefreshButton = False
        nueva_ventana.WindowState = FormWindowState.Maximized
        nueva_ventana.CRViewer91.Zoom(zoom)
        nueva_ventana.Text = titulo_ventana
        nueva_ventana.Show()
        nueva_ventana.BringToFront()

    End Sub

    Private Sub CRViewer91_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRViewer91.Load

    End Sub

    Private Sub CRViewer91_ReportRefresh(ByVal source As Object, ByVal e As CrystalDecisions.Windows.Forms.ViewerEventArgs) Handles CRViewer91.ReportRefresh
        ''---------- P A R A M E T R O S ---------------------------
        'Dim Params As New ParameterValues       ' Creando una Coleccion de Parametros
        'Dim Par As New ParameterDiscreteValue   ' Parametro Discreto q viene en el proc. alm. y se muestra en el Crystal Report

        'Params.Clear()              ' Limpiando la Coleccion de Datos
        'Par.Value = Titulo  ' Asignando un Valor Discreto a nuestra variable jalando el valor de una caja de texto de tu formulario
        'Params.Add(Par)             ' Agregando el param discreto a la coleccion de parametros
        'rpt_id.DataDefinition.ParameterFields("TITULO_REPORTE").ApplyCurrentValues(Params)   ' Aplicando los valores de nuestra coleccion a los parametros del crystal report
        'Params.Clear()
        'Par.Value = impreso
        'Params.Add(Par)
        'rpt_id.DataDefinition.ParameterFields("IMPRESO_POR").ApplyCurrentValues(Params)

    End Sub

    Private Sub frm_reportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class