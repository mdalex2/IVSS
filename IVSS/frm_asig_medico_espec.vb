Imports MySql.Data.MySqlClient
Public Class frm_asig_medico_espec
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim modifica_asigancion As Boolean = False
    Dim Var_Num_Hist_medico As String

    Private Sub frm_asig_medico_espec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo

        'Buscar()
        Limpiar_Controles(Me)
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_asignar_medico_espec.png")
        Llenar_combo_con_BD(cmb_turnos, "cod_turno", "turno", "turnos", True, "turno")

        Informativo_por_codigo.Dispose()
    End Sub
    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub
    Private Sub Mostrar_especialidades()
        Dim comando As New MySqlCommand
        Try
            'If Not IsNothing(Lista_espec.FocusedItem) Then
            Lista_espec.Clear()
            '-----------------------------------------------
            comando.CommandText = "SELECT especialidades.*,medico_especialidad.num_historia,medico_especialidad.fecha_g as fg," & _
                "datos_personales.nombres, datos_personales.apellidos FROM " & _
                "((especialidades left join medico_especialidad on especialidades.cod_espec=medico_especialidad.cod_espec and medico_especialidad.num_historia='" & Lista_medico.FocusedItem.SubItems(0).Text & "' and medico_especialidad.cod_turno='" & cmb_turnos.SelectedValue & "') left join datos_personales on medico_especialidad.guardado_por=datos_personales.num_historia)  ORDER BY especialidad"

            'MsgBox(comando.CommandText)
            'codigo bueno-------------------------------------------
            'comando.CommandText = "SELECT especialidades.*,medico_especialidad.num_historia,medico_especialidad.fecha_g as fg," & _
            '    "datos_personales.nombres, datos_personales.apellidos FROM " & _
            '    "((especialidades left join medico_especialidad on especialidades.cod_espec=medico_especialidad.cod_espec and medico_especialidad.num_historia='" & Lista_medico.FocusedItem.SubItems(0).Text & "' and medico_especialidad.cod_turno='" & cmb_turnos.SelectedValue & "') left join datos_personales on medico_especialidad.guardado_por=datos_personales.num_historia)  ORDER BY especialidad"
            '-----------------------------------------------

            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                Lista_espec.Clear()
                Lista_espec.View = View.Details 'importante para que los datos se vean como lista
                '.....Agrego Los Titulos a el listview y tamaño de columnas
                Lista_espec.Columns.Add("ESPECIALIDAD", 200, HorizontalAlignment.Left)
                Lista_espec.Columns.Add("COD. ESPECIALIDAD", 100, HorizontalAlignment.Left)
                Lista_espec.Columns.Add("ASIGNADO POR  /  FECHA", 200, HorizontalAlignment.Left)

                Lista_espec.MultiSelect = False
                Lista_espec.View = View.Details
                Lista_espec.FullRowSelect = True
                While dr.Read()
                    Dim Var_Nombre_guardo As String = ""
                    If Not IsDBNull(dr("nombres")) Then
                        Var_Nombre_guardo = dr("nombres") & " " & dr("apellidos") & " - " & dr("fg")
                    Else
                        Var_Nombre_guardo = "NO ASIGANDA"
                    End If

                    If IsDBNull(dr("num_historia")) Then
                        Lista_espec.Items.Add(New ListViewItem(New String() {dr("especialidad").ToString, dr("cod_espec").ToString, UCase(Var_Nombre_guardo.ToString)}))
                    Else
                        Lista_espec.Items.Add(New ListViewItem(New String() {dr("especialidad").ToString, dr("cod_espec").ToString, UCase(Var_Nombre_guardo.ToString)})).Checked = True
                    End If
                    ''...Agrego al listview la data de la consulta efectuada
                End While
                dr.Close()
                Ajustar_tamaño_listas(Lista_espec)
                Lista_espec.Columns(1).Width = 0
                Lista_espec.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)


            Else
                MsgBox("No se encontró registros de turnos, debe almacenar al menos un turno", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If
            'End If
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
    Private Sub Buscar_Medico()
        Dim comando As New MySqlCommand
        Try
            Lista_medico.Clear()
            If Opc_busca_nombres.Checked = True Then
                comando.CommandText = "SELECT datos_personales.num_historia,datos_personales.nombres,datos_personales.apellidos,profesiones.profesion from (datos_personales inner join profesiones on datos_personales.cod_profesion=profesiones.cod_profesion) where nombres like '%" & txt_busca.Text & "%' ORDER BY nombres,apellidos asc"
            Else
                comando.CommandText = "SELECT datos_personales.num_historia,datos_personales.nombres,datos_personales.apellidos,profesiones.profesion from (datos_personales inner join profesiones on datos_personales.cod_profesion=profesiones.cod_profesion) where n_identificacion like '%" & txt_busca.Text & "%' ORDER BY nombres,apellidos asc"
            End If


            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                Lista_medico.Clear()
                Lista_medico.View = View.Details 'importante para que los datos se vean como lista
                '.....Agrego Los Titulos a el listview y tamaño de columnas
                Lista_medico.Columns.Add("NUM. HISTORIA", 200, HorizontalAlignment.Left)
                Lista_medico.Columns.Add("NOMBRES", 200, HorizontalAlignment.Left)
                Lista_medico.Columns.Add("APELLIDOS", 100, HorizontalAlignment.Left)
                Lista_medico.Columns.Add("PROFESION", 100, HorizontalAlignment.Left)


                Lista_medico.MultiSelect = False
                Lista_medico.View = View.Details
                Lista_medico.FullRowSelect = True
                While dr.Read()
                    MyListText(0) = dr("num_historia")
                    MyListText(1) = dr("nombres")

                    MyListText(2) = dr("apellidos")
                    MyListText(3) = dr("profesion")

                    'creo un listitem
                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list
                    Lista_medico.Items.Add(MyListItem)
                End While
                dr.Close()
                Ajustar_tamaño_listas(Lista_medico)

                'Lista_turnos.Items(0).Selected = True
            Else
                txt_busca.Focus()
                Informativo.SetToolTip(btn_buscar, "Buscar médico")
                btn_buscar.Tag = 0
                btn_buscar.ImageIndex = 0
                MsgBox("No se encontró el médico, verifique los datos de la consulta", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_medico", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_medico", Err.Number, ex.Message)
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
    Private Sub mostrar_asignacion()
        If Not IsNothing(Lista_medico.FocusedItem) Then
            ' txt_busca.Text = Lista_medicos.FocusedItem.SubItems(0).Text
            Var_Num_Hist_medico = Lista_medico.FocusedItem.SubItems(0).Text
            Lbl_usuario.Text = "USUARIO: " & Lista_medico.FocusedItem.SubItems(4).Text
            'chk_activo.Checked = CBool(Lista_medicos.FocusedItem.SubItems(5).Text)
            modifica_asigancion = True
            btn_eliminar.Enabled = True
            btn_archivar.Enabled = True
            Mostrar_especialidades()
        End If
    End Sub
    Private Sub Nueva_asignacion()
        modifica_asigancion = False
        btn_eliminar.Enabled = False
        btn_archivar.Enabled = False
        Var_Num_Hist_medico = Nothing
        txt_busca.Text = ""
        Limpiar_Controles(Me)
        Informativo.SetToolTip(btn_buscar, "Buscar médico")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
        Opc_busca_nombres.Checked = True
        txt_busca.Focus()
        Mostrar_informacion("inf", "Instrucciones", "- Ingrese el nombre del medico y presione el botón buscar" & vbCrLf & "- Seleccione el nombre del médico en la lista" & _
                            vbCrLf & "- asigne las especialidades", True, 7000, btn_buscar, "inf")
    End Sub



    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        Nueva_asignacion()
    End Sub
    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Eliminar_generico("medico_especialidad", "num_historia", "texto", Var_Num_Hist_medico, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Me)
            Nueva_asignacion()
            Buscar_Medico()
        End If
    End Sub
    Private Sub Guardar_Medico_especialidad()
        ' Si hay un Item seleccionado ...
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Try
            If (Not IsNothing(Lista_medico.SelectedItems)) And (Not IsNothing(cmb_turnos.SelectedValue)) Then

                comando.CommandText = "delete from medico_especialidad where num_historia='" & Var_Num_Hist_medico & "' and cod_turno='" & cmb_turnos.SelectedValue & "'"
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                'comando.Dispose()
                'myCloneCon.Dispose()

                'Eliminar_generico("medico_especialidad", "num_historia", "texto", Var_Num_Hist_medico, False)
                Dim i As Integer

                'Recorre todos los items y para sumar los SubItems
                For i = 0 To Lista_espec.Items.Count - 1
                    If Lista_espec.Items(i).Checked = True Then

                        sql_str = "INSERT INTO medico_especialidad (num_historia,cod_espec,cod_turno,guardado_por,fecha_g) values ('" & _
                            Var_Num_Hist_medico & "','" & _
                            Lista_espec.Items(i).SubItems(1).Text & "','" & _
                            cmb_turnos.SelectedValue.ToString & "','" & _
                            Cod_usuario & "','" & _
                            Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"
                        comando.CommandText = UCase(sql_str)
                        ConectarBD()
                        comando.Connection = myCloneCon
                        comando.ExecuteReader()
                    End If
                Next i
                Mostrar_especialidades()
                MsgBox("La asiganción del médico a las especialidades se efectuó correctamente", vbInformation, "Ayuda del sistema")
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Guardar_Medico_especialidad", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Guardar_Medico_especialidad", Err.Number, ex.Message)
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

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If btn_buscar.Tag = 0 Then 'si es buscar
            Informativo.SetToolTip(btn_buscar, "Quitar filtro de busqueda")
            btn_buscar.Tag = 1
            btn_buscar.ImageIndex = 1
            Buscar_Medico()
        Else 'si es quitar filtro de busqueda
            txt_busca.Text = ""
            txt_busca.Focus()
            Informativo.SetToolTip(btn_buscar, "Buscar médico")
            btn_buscar.Tag = 0
            btn_buscar.ImageIndex = 0
            Buscar_Medico()
        End If
    End Sub

    Private Sub btn_archivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_archivar.Click
        If IsNothing(Lista_medico.FocusedItem) Then
            Mostrar_informacion("inf", "Notificación:", "Debe seleccionar un médico de la lista", True, 3500, Lista_medico, "inf")
            Exit Sub
        End If
        If IsNothing(cmb_turnos.SelectedValue) Then
            Mostrar_informacion("inf", "Notificación:", "Debe seleccionar un turno", True, 3500, cmb_turnos, "inf")
            cmb_turnos.Focus()
            cmb_turnos.DroppedDown = True
            Exit Sub
        End If
        Guardar_Medico_especialidad()
    End Sub





    Private Sub Lista_medico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_medico.SelectedIndexChanged
        mostrar_asignacion()
    End Sub

    Private Sub Lista_espec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_espec.SelectedIndexChanged

    End Sub


    Private Sub cmb_turnos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_turnos.SelectedIndexChanged
        mostrar_asignacion()
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE ASIGNACION DE MEDICOS A ESPECIAILDADES", "Listado de medico-especialidad.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub
End Class