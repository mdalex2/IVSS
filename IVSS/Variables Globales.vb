Module Variables_Globales
    Public Cod_usuario As String = "" 'para el usuario que tiene abierto el sistema
    Public Nombre_usuario_actual As String = ""
    Public Var_historia_abierta, Var_historia_para_abrir As String
    Public Modificar_historia As Boolean
    'para el mensaje tooltip
    Public tooltip As New ToolTip
    Public Var_Public_quien_guardo As String 'guarda teporalmente una consulta de quien hizo el registro en una base de datos
    Public Destino As String = ""
    Public var_pu_motivo_cancela_cosulta As String = ""
    Public LLave_AES As String
    Public nueva_ventana As New frm_reportes
    Public CANCELAR_CIERRE As Boolean 'PARA CANCELAR EL CIERRE DE LA VENTANA
    Public PREGUNTA_CIERRE As Boolean 'PARA CANCELAR EL CIERRE DE LA VENTANA
End Module
