Imports MySql.Data.MySqlClient
Public Class frm_turnos
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim modifica_turno As Boolean = False
    Dim Var_cod_turno As String
    Private Sub Turnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo

        'Buscar()
        Limpiar_Controles(Me)
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_turnos.png")
        'Llenar_combo_con_BD(cmb_especialidad, "cod_espec", "especialidad", "especialidades", True, "especialidad")
        Buscar_turnos()
        'Mostrar_especialidades()
        Informativo_por_codigo.Dispose()
    End Sub

    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub
    Private Sub Mostrar_especialidades()
        Dim comando As New MySqlCommand
        Try
            Lista_espec.Clear()
            comando.CommandText = "SELECT especialidades.*,turno_especialidad.max_pacientes FROM (especialidades left join turno_especialidad on especialidades.cod_espec=turno_especialidad.cod_espec and turno_especialidad.cod_turno='" & Lista_turnos.FocusedItem.SubItems(0).Text & "')  ORDER BY especialidad"

            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                Lista_espec.Clear()
                Lista_espec.View = View.Details 'importante para que los datos se vean como lista
                '.....Agrego Los Titulos a el listview y tamaño de columnas
                Lista_espec.Columns.Add("ESPECIALIDAD", 200, HorizontalAlignment.Left)
                Lista_espec.Columns.Add("PACIENTES POR DIA", 200, HorizontalAlignment.Left)
                Lista_espec.Columns.Add("COD. ESPECIALIDAD", 100, HorizontalAlignment.Left)

                Lista_espec.MultiSelect = False
                Lista_espec.View = View.Details
                Lista_espec.FullRowSelect = True
                While dr.Read()
                    Dim var_num_pacientes As Integer = 0
                    Cant_Reg = Cant_Reg + 1
                    If IsDBNull(dr("max_pacientes")) Then
                        var_num_pacientes = 0

                    Else
                        var_num_pacientes = Val(dr("max_pacientes"))
                    End If
                    If IsDBNull(dr("max_pacientes")) Then
                        Lista_espec.Items.Add(New ListViewItem(New String() {dr("especialidad").ToString, var_num_pacientes.ToString, dr("cod_espec").ToString}))
                    Else
                        Lista_espec.Items.Add(New ListViewItem(New String() {dr("especialidad").ToString, var_num_pacientes.ToString, dr("cod_espec").ToString})).Checked = True
                    End If
                    ''...Agrego al listview la data de la consulta efectuada
                End While
                dr.Close()
                Ajustar_tamaño_listas(Lista_espec)
                Lista_espec.Columns(2).Width = 0
                Lista_espec.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize)
                Lista_espec.Columns(1).TextAlign = HorizontalAlignment.Center

            Else
                MsgBox("No se encontró registros de turnos, debe almacenar al menos un turno", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Mostrar_especialidades", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            If Err.Number = 91 Then
                'ignora el error que da si el list es noothing
            Else
                Mostrar_mensaje_error("Mostrar_especialidades", Err.Number, ex.Message)
            End If

        Finally
            'si la conexion esta abierta la cierro
            If myCloneCon.State = 1 Then
                myCloneCon.Close()
            End If
            'descargo memoria de cmandos y consultas usadas para que el sistema no se vuelva lento e inestable
            comando.Dispose()
            myCloneCon.Dispose()
            dr = Nothing
        End Try
    End Sub
    Private Sub Buscar_turnos()
        Dim comando As New MySqlCommand
        Try
            Lista_turnos.Clear()
            If chk_mostrar_todos.Checked = True Then
                comando.CommandText = "SELECT turnos.*,datos_personales.nombres,datos_personales.apellidos from (turnos inner join datos_personales on turnos.guardado_por=datos_personales.num_historia) ORDER BY hora_inicio,hora_fin"
            Else
                comando.CommandText = "SELECT turnos.*,datos_personales.nombres,datos_personales.apellidos from (turnos inner join datos_personales on turnos.guardado_por=datos_personales.num_historia) WHERE turnos.VISIBLE=1 ORDER BY hora_inicio,hora_fin"
            End If


            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                Lista_turnos.Clear()
                Lista_turnos.View = View.Details 'importante para que los datos se vean como lista
                '.....Agrego Los Titulos a el listview y tamaño de columnas
                Lista_turnos.Columns.Add("COD. TURNO", 200, HorizontalAlignment.Left)
                Lista_turnos.Columns.Add("TURNO", 200, HorizontalAlignment.Left)
                Lista_turnos.Columns.Add("HORA INICIO", 100, HorizontalAlignment.Left)
                Lista_turnos.Columns.Add("HORA FIN", 100, HorizontalAlignment.Left)
                Lista_turnos.Columns.Add("USUARIO", 100, HorizontalAlignment.Left)
                Lista_turnos.Columns.Add("ESTATUS-VALOR", 100, HorizontalAlignment.Left)
                Lista_turnos.Columns.Add("ESTATUS", 100, HorizontalAlignment.Left)

                Lista_turnos.MultiSelect = False
                Lista_turnos.View = View.Details
                Lista_turnos.FullRowSelect = True
                While dr.Read()
                    MyListText(0) = dr("cod_turno")
                    MyListText(1) = dr("turno")

                    MyListText(2) = FormatDateTime(dr("hora_inicio").ToString, DateFormat.LongTime)
                    MyListText(3) = FormatDateTime(dr("hora_fin").ToString, DateFormat.LongTime)

                    If Not IsDBNull(dr("nombres")) And Not IsDBNull(dr("apellidos")) Then
                        MyListText(4) = dr("nombres") & " " & dr("Apellidos") & " - " & Format(dr("fecha_g"), "dd/MM/yyyy hh:mm:ss tt")
                    Else
                        MyListText(4) = "No se pudo detectar el nombre del usuario"
                    End If
                    MyListText(5) = dr("visible")
                    If dr("visible") = True Then
                        MyListText(6) = "ACTIVO"
                    Else
                        MyListText(6) = "DESHABILITADO"
                    End If
                    'creo un listitem
                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list
                    Lista_turnos.Items.Add(MyListItem)
                End While
                dr.Close()
                Quitar_tamaño_listas(Lista_turnos)

                Lista_turnos.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
                Lista_turnos.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent)
                Lista_turnos.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent)
                Lista_turnos.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.ColumnContent)
                'Lista_turnos.Items(0).Selected = True
            Else
                MsgBox("No se encontró registros de especialidades, debe almacenar al menos una especialidad", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Mostrar_especialidades", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar_especialidades", Err.Number, ex.Message)
        Finally
            'si la conexion esta abierta la cierro
            If myCloneCon.State = 1 Then
                myCloneCon.Close()
            End If
            'descargo memoria de cmandos y consultas usadas para que el sistema no se vuelva lento e inestable
            comando.Dispose()
            myCloneCon.Dispose()
            dr = Nothing
        End Try
    End Sub
    Private Sub asignar_maximo()
        If Not IsNothing(Lista_espec.FocusedItem) Then
            Lista_espec.FocusedItem.SubItems(1).Text = max_pacientes.Value
            If max_pacientes.Value > 0 Then
                Lista_espec.FocusedItem.Checked = True
            Else
                Lista_espec.FocusedItem.Checked = False
            End If
        Else
            Mostrar_informacion("inf", "Ayuda", "Debe seleccionar una especialidad para efectuar cambios" & vbCrLf & "en el máximo de pacientes permitidos por dia", True, 4000, Lista_espec, "inf")
        End If
    End Sub
    Private Sub max_pacientes_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles max_pacientes.ValueChanged
        asignar_maximo()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_restaurar.Click
        If MsgBox("¿Está seguro que desea restaurar la cantidad de pacientes al predeterminado en la base de datos?", vbQuestion + vbSystemModal + vbYesNo, "Confirme la operación") = vbYes Then
            Mostrar_especialidades()
        End If
    End Sub

    Private Sub Lista_espec_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles Lista_espec.ItemCheck

    End Sub

    Private Sub Lista_espec_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles Lista_espec.ItemChecked

    End Sub

    Private Sub Lista_espec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_espec.SelectedIndexChanged
        If Not IsNothing(Lista_espec.FocusedItem) Then
            Informativo_por_codigo.Dispose()
            max_pacientes.Value = Lista_espec.FocusedItem.SubItems(1).Text
        End If
    End Sub

    Private Sub chk_mostrar_todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mostrar_todos.CheckedChanged
        Buscar_turnos()
    End Sub

    Private Sub Lista_turnos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lista_turnos.Click
        mostrar_turno()
    End Sub

    Private Sub Lista_turnos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_turnos.SelectedIndexChanged
        'If Not IsNothing(Lista_espec.FocusedItem) Then
        Mostrar_especialidades()
        'End If
    End Sub
    Private Sub mostrar_turno()
        If Not IsNothing(Lista_turnos.FocusedItem) Then
            txt_codigo.Text = Lista_turnos.FocusedItem.SubItems(0).Text
            Var_cod_turno = Lista_turnos.FocusedItem.SubItems(0).Text
            txt_turno.Text = Lista_turnos.FocusedItem.SubItems(1).Text
            txt_hora_desde.Text = TimeValue(Lista_turnos.FocusedItem.SubItems(2).Text)
            txt_hora_hasta.Text = TimeValue(Lista_turnos.FocusedItem.SubItems(3).Text)
            Lbl_usuario.Text = "USUARIO: " & Lista_turnos.FocusedItem.SubItems(4).Text
            chk_activo.Checked = CBool(Lista_turnos.FocusedItem.SubItems(5).Text)
            modifica_turno = True
            btn_eliminar.Enabled = True

        End If
    End Sub
    Private Sub Nuevo_turno()
        modifica_turno = False
        btn_eliminar.Enabled = False
        btn_archivar.Enabled = False
        Var_cod_turno = Nothing
        txt_codigo.Text = ""
        txt_hora_desde.Text = "08:00:59"
        txt_hora_hasta.Text = "08:00:59"
        txt_turno.Text = ""
        chk_activo.Checked = True
        txt_codigo.Focus()
        Mostrar_informacion("inf", "Instrucciones", "Llene los datos y presione el botón archivar", True, 2500, txt_codigo, "inf")
    End Sub

    Private Sub txt_codigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        If txt_codigo.Text = "" Then
            btn_archivar.Enabled = False
        Else
            btn_archivar.Enabled = True
        End If
    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Nuevo_turno()
    End Sub
    Private Sub Archivar_turno()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Dim Reg_afectados As Double
        Try
            If modifica_turno = False Then
                sql_str = "INSERT INTO turnos (cod_turno,turno,hora_inicio,hora_fin,guardado_por,fecha_g,visible) values ('" & _
                txt_codigo.Text & "','" & _
                txt_turno.Text & "','" & _
                Format(txt_hora_desde.Text, "HH:mm:ss") & "','" & _
                Format(txt_hora_hasta.Text, "HH:mm:ss") & "','" & _
                Cod_usuario & "','" & _
                Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," & _
                chk_activo.Checked & ")"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
                MsgBox("Los datos del turno " & Chr(34) & txt_turno.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                modifica_turno = True
                Var_cod_turno = txt_codigo.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                Lista_turnos.Clear()
                Buscar_turnos()
            Else
                sql_str = "update turnos set " & _
                "cod_turno='" & txt_codigo.Text & "'," & _
                "turno='" & txt_turno.Text & "'," & _
                "hora_inicio='" & txt_hora_desde.Value.ToString("HH:mm:ss") & "'," & _
                "hora_fin='" & txt_hora_hasta.Value.ToString("HH:mm:ss") & "'," & _
                "guardado_por='" & Cod_usuario & "'," &
                "fecha_g='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," & _
                "visible=" & chk_activo.Checked & _
                " where cod_turno='" & Var_cod_turno & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()

                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se modificaron correctamente", True, 2500, lista_buscar, "inf")
                MsgBox("Los datos del turno " & Chr(34) & txt_turno.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                modifica_turno = True
                Var_cod_turno = txt_codigo.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                Limpiar_Controles(Lista_turnos)
                Buscar_turnos()
            End If
            Guardar_turno_especialidad()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar_Turnos", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_Turnos", Err.Number, ex.Message)
        Finally
            'si la conexion esta abierta la cierro
            If myCloneCon.State = 1 Then
                myCloneCon.Close()
            End If
            'descargo memoria de cmandos y consultas usadas para que el sistema no se vuelva lento e inestable
            comando.Dispose()
            myCloneCon.Dispose()
        End Try
    End Sub

    Private Sub btn_archivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_archivar.Click
        Archivar_turno()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Eliminar_generico("turnos", "cod_turno", "texto", Var_cod_turno, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Me)
            Nuevo_turno()
            Buscar_turnos()
        End If
    End Sub
    Private Sub Guardar_turno_especialidad()
        ' Si hay un Item seleccionado ...
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Try
            If Not Lista_turnos.SelectedItems Is Nothing Then

                Eliminar_generico("turno_especialidad", "cod_turno", "texto", Var_cod_turno, False)
                Dim i As Integer
                'Recorre todos los items y para sumar los SubItems
                For i = 0 To Lista_espec.Items.Count - 1
                    If Lista_espec.Items(i).Checked = True And Val(Lista_espec.Items(i).SubItems(1).Text) > 0 Then
                        sql_str = "INSERT INTO turno_especialidad (cod_turno,cod_espec,max_pacientes,guardado_por,fecha_g) values ('" & _
                            Var_cod_turno & "','" & _
                            Lista_espec.Items(i).SubItems(2).Text & "','" & _
                            Lista_espec.Items(i).SubItems(1).Text & "','" & _
                            Cod_usuario & "','" & _
                            Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"
                        comando.CommandText = UCase(sql_str)
                        ConectarBD()
                        comando.Connection = myCloneCon
                        comando.ExecuteReader()
                    End If
                Next i
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Guardar_turno_especialidad", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Guardar_turno_especialidad", Err.Number, ex.Message)
        Finally
            'si la conexion esta abierta la cierro
            If myCloneCon.State = 1 Then
                myCloneCon.Close()
            End If
            'descargo memoria de cmandos y consultas usadas para que el sistema no se vuelva lento e inestable
            comando.Dispose()
            myCloneCon.Dispose()

        End Try
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE TURNOS", "Listado de turnos-especialidad.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Boton reporte", Err.Number, ex.Message)
        End Try
    End Sub
End Class