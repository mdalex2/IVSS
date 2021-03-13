Module Control_Errores
    Public Sub Mostrar_mensaje_error_Mysql(ByVal Modulo As String, ByVal Numero_error As Double, ByVal Info_tecnica As String)
        Select Case Numero_error
            Case 1042
                MsgBox("No se puede conectar al servidor, es posible que el servidor esté apagado, no exista conexión a la red local o a internet, espere unos minutos en caso de falla de suministro eléctrico, e intente de nuevo acceder, si el problema persiste llame al técnico encargado", vbCritical + vbSystemModal, "Notificación")
            Case 1045
                MsgBox("Acceso denegado por el servidor de Base de Datos MySQL, el técnico debe verificar nombre de usuario y clave de acceso en la cadena de conexión", vbCritical + vbSystemModal, "Notificación")
            Case 1049
                If MsgBox("La base de datos del sistema no existe, el archivo no se creó correctamente o fue elminado, debe llamar al técnico, para que efectue una restauración de la base de datos mediante un archivo de copia de seguridad" & vbNewLine & "Desea efectuar una recuperación del archivo de seguridad en éste momento?", vbCritical + vbSystemModal + vbYesNo + vbDefaultButton1, "Notificación") = vbYes Then
                    Mostrar_formulario(frm_restaurar, True)
                End If
            Case 1054
                MsgBox("No se reconoce el valor de un campo en la consulta SQL: " & Info_tecnica, vbCritical + vbSystemModal, "Notificación módulo: " & Modulo)
            Case 1062
                MsgBox("La información ya existe en la base de datos, no se almacenaron los datos porque crearían valores duplicados", vbCritical + vbSystemModal, "Ayuda del sistema")
            Case 1452
                MsgBox("No se puede archivar la información, faltan algunos datos relacionados, debe verificar los campos resaltados", vbExclamation + vbSystemModal, "Ayuda del sistema")
            Case 1064
                MsgBox("No se puede ejecutar la instruccion, es probable que exista un error de sintáxis o faltan algunos campos necesarios", vbExclamation + vbSystemModal, "Ayuda del sistema")
            Case 1451
                MsgBox("No se puede eliminar la información porque existen datos que dependen del registro que intenta eliminar", vbExclamation + vbSystemModal, "Ayuda del sistema")
            Case Else
                MsgBox("Se ha detectado un evento MySQL, Módulo (" & Modulo & ") Información Técnica: " & Info_tecnica & " Número: " & Numero_error, vbExclamation + vbSystemModal, "Control de errores")
        End Select
    End Sub
    Public Sub Mostrar_mensaje_error(ByVal Modulo As String, ByVal Numero_error As Double, ByVal Info_tecnica As String)
        Select Case Numero_error
            Case 9
                MsgBox("El nombre de un campo de la consulta no existe en la base de datos: " & Info_tecnica, vbCritical + vbSystemModal, "Módulo: " & Modulo)
            Case Else
                MsgBox("Se ha detectado un evento parcial de ejecución, Módulo (" & Modulo & ") Información Técnica: " & Info_tecnica & " Número: " & Numero_error, vbExclamation + vbSystemModal, "Control de errores")
        End Select
    End Sub

End Module
