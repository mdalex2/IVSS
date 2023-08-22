Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frm_control_cita
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim paso_validacion_cita As Boolean
    Dim Var_temp_contador

    Private Sub frm_control_citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Limpiar_Controles(Grupo_paciente)
        Limpiar_Controles(Grupo_limites)
        Limpiar_Controles(Grupo_Resumen)
        Limpiar_Controles(Grupo_fecha)
        Llenar_combo_con_BD(cmb_tipo_cita, "cod_tipo_cita", "descripcion_tipo", "tipos_citas", True, "descripcion_tipo")
        'coloco un fondo a la barras de menu y barra de botonnes
        'Dim img As Image
        'img = Image.FromFile(Application.StartupPath & "\imagenes\sistema\Fondo_encabezado.png")
        'Me.Barra_botones.BackgroundImage = img
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo
        botonera.Parent = Pic_Encabezado
        'Barra_botones.Parent = botonera
        Llenar_combo_con_BD(cmb_especialidad, "cod_espec", "especialidad", "especialidades", True, "especialidad")



        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\icono_frm_citas.png")
        If Not IsNothing(MyListItem) Then
            MyListItem.ListView.Clear()
        End If

        'establecer_fecha()
        cmb_mes.Text = UCase(Now.ToString("MMMM"))

        Llenar_combo_con_BD(cmb_mes, "no_mes", "mes", "mes", True, "no_mes")
        Calendario.SelectionStart = Now
        Calendario.SelectionEnd = Now
        If Calendario.SelectionStart.Month > 1 Then
            btn_ant_mes.Enabled = True
        End If
        'nueva_cita()
    End Sub

    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub btn_sig_mes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sig_mes.Click
        If cmb_mes.SelectedValue < cmb_mes.Items.Count Then
            cmb_mes.SelectedIndex = cmb_mes.SelectedIndex + 1
            establecer_fecha()
            btn_ant_mes.Enabled = True
            If cmb_mes.SelectedValue = cmb_mes.Items.Count Then
                btn_sig_mes.Enabled = False

            End If
        End If
    End Sub

    Private Sub cmb_mes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_mes.SelectedIndexChanged
        'MsgBox(cmb_mes.SelectedIndex)
    End Sub

    Private Sub btn_ant_mes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ant_mes.Click
        If cmb_mes.SelectedValue > 1 Then
            cmb_mes.SelectedIndex = cmb_mes.SelectedIndex - 1
            establecer_fecha()
            btn_sig_mes.Enabled = True
            If cmb_mes.SelectedValue = 1 Then
                btn_ant_mes.Enabled = False
            End If
        End If
    End Sub

    Private Sub año_up_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles año_up.ValueChanged

        establecer_fecha()
    End Sub
    Private Sub establecer_fecha()
        On Error Resume Next

        Dim dia, mes, año As String
        dia = Calendario.SelectionStart.Day
        mes = cmb_mes.SelectedValue
        año = año_up.Value
        'MsgBox(dia)
        'Calendario.TodayDate = New Date(año, mes, dia)
        Calendario.SelectionStart = Nothing
        Calendario.SelectionEnd = Nothing
        Calendario.SelectionStart = New Date(año, mes, dia)
        Calendario.SelectionEnd = New Date(año, mes, dia)
        cmb_mes.Text = UCase(Calendario.SelectionEnd.ToString("MMMM"))
        If lbl_num_hist.Text <> "" Then
            Mostrar_resumen_citas()
        End If
    End Sub

    Private Sub Calendario_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles Calendario.DateChanged
        Try
            btn_archivar_cita.Enabled = False
            Progreso_espera.Visible = True
            Progreso_espera.Value = 100
            System.Windows.Forms.Application.DoEvents()
            Informativo_por_codigo.Dispose()
            lbl_total_pac_citado_x_tipocita.Text = 0
            lbl_total_paciente_citados_x_turno.Text = 0
            If lbl_num_hist.Text <> "" And Val(año_up.Value) <> Val(Calendario.SelectionStart.Year) Then
                Mostrar_resumen_citas()
            End If
            cmb_mes.Text = UCase(Calendario.SelectionStart.ToString("MMMM"))
            año_up.Value = Calendario.SelectionStart.Year
            If IsNothing(cmb_especialidad.SelectedValue) Then
                Mostrar_informacion("inf", "Notificación:", "Debe seleccionar la especialidad a la cual acudirá el paciente", True, 3000, cmb_especialidad, "")
                Exit Sub
            End If
            If IsNothing(cmb_turno.SelectedValue) Then
                Mostrar_informacion("inf", "Notificación:", "Debe seleccionar el turno", True, 3000, cmb_turno, "")
                Exit Sub
            End If
            If IsNothing(cmb_tipo_cita.SelectedValue) Then
                Mostrar_informacion("inf", "Notificación:", "Debe seleccionar el tipo de cita", True, 3000, cmb_tipo_cita, "")
                Exit Sub
            End If
            'verifico si el medico esta disponible para ese dia si no muestro el mensajito rojo debajo del calendario

            Verifica_labora_medico(cmb_medico.SelectedValue, Calendario.SelectionStart.ToString("dd-MM-yyyy"))
            If Var_P_Medico_Labora = False Then
                lbl_notas_calendario.Text = "MÉDICO NO DISPONIBLE"
                Reproducir_audio("ERROR.WAV")
                Exit Sub
            Else
                Es_Fin_de_Semana(Calendario.SelectionStart.ToString("dd-MM-yyyy"))
                If Var_es_Fin_de_Semana = True Then
                    lbl_notas_calendario.Text = "DIA NO DISPONIBLE (FIN SEMANA)"
                    Reproducir_audio("ERROR.WAV")
                    Exit Sub
                Else

                    If Verifica_Feriado(Calendario.SelectionStart.ToString("dd-MM-yyyy")) = True Then
                        lbl_notas_calendario.Text = "DIA NO DISPONIBLE (FERIADO)"
                        Reproducir_audio("ERROR.WAV")
                        Exit Sub
                    End If
                End If
            End If
            Mostrar_pacientes_del_dia()
            lbl_notas_calendario.Text = "DIA: " & Calendario.SelectionStart.ToString("dd-MM-yyyy") & " DISPONIBLE (" & lbl_cupos_disponibles.Text & ")"
            'habilito el botno guardar
            btn_archivar_cita.Enabled = True

        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("El año seleccionado no es válido", vbInformation, "Ayuda del sistema")
            Else
                MsgBox("Error: " & ex.Message & " Número: " & Err.Number)
            End If
        Finally
            Progreso_espera.Visible = False
        End Try

    End Sub

    Private Sub Llenar_combo_medico()
        If Not IsNothing(cmb_turno.SelectedValue) Then
            Dim myAdapter As New MySqlDataAdapter
            Dim myDS As New DataSet
            Dim comando As New MySqlCommand
            Try
                ConectarBD()
                comando.Connection = myCloneCon
                comando.CommandText = "SELECT medico_especialidad.*,CONCAT(datos_personales.nombres,' ',datos_personales.apellidos) as DP" & _
                    " from (medico_especialidad inner join datos_personales on medico_especialidad.num_historia=datos_personales.num_historia)" & _
                    " where medico_especialidad.cod_turno='" & cmb_turno.SelectedValue & "' AND medico_especialidad.cod_espec='" & cmb_especialidad.SelectedValue.ToString & "' ORDER BY DP"

                myAdapter.SelectCommand = comando
                myAdapter.Fill(myDS)

                cmb_medico.DataSource = myDS.Tables(0)
                cmb_medico.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                cmb_medico.AutoCompleteSource = AutoCompleteSource.ListItems
                cmb_medico.MaxDropDownItems = 20

                cmb_medico.ValueMember = "num_historia"
                'DisplayMember sirve para visualizar los datos cuando se despliega el control()
                cmb_medico.DisplayMember = "DP"
                If cmb_medico.Items.Count > 0 Then
                    cmb_medico.SelectedIndex = 0
                    cmb_medico.BackColor = Color.White
                    cmb_medico.ForeColor = Color.Black
                    Informativo_por_codigo.Dispose()
                    Mostrar_informacion("inf", "Notificación", "Se ha cambiado la especialidad, la lista médicos y turnos se actualizarón" & vbNewLine & "verifique el médico y turno", True, 4000, cmb_medico, "")
                Else
                    cmb_medico.Text = "DEBE ASIGNAR UN MEDICO A LA ESPECIALIDAD"
                    cmb_medico.BackColor = Color.DarkRed
                    cmb_medico.ForeColor = Color.White
                End If
                'Informativo_por_codigo.SetToolTip(El_combo, El_combo.DisplayMember)
                comando.Dispose()
                myDS.Dispose()
                myAdapter.Dispose()
            Catch ex As Exception
                Select Case Err.Number
                    Case 0

                    Case 5
                        'MsgBox("No se pudo cargar la tabla: " & Nombre_tabla & " en el cuadro de lista: " & El_combo.Name, vbExclamation + vbSystemModal, "Ayuda del sistema")
                    Case Else
                        MsgBox(ex.Message & Err.Number, vbSystemModal + vbExclamation, "Ayuda del sistema del llenar_combo_turno")
                End Select
            End Try
        End If
    End Sub

    Private Sub cmb_especialidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_especialidad.SelectedIndexChanged
        Informativo_por_codigo.Dispose()
        Limpiar_Controles(Lista_pacientes_dia)
        If Not IsNothing(cmb_especialidad.SelectedValue) Then
            Llenar_combo_turno()
        End If
    End Sub
    Private Sub obtener_lim_pac_x_dia_x_esp()
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            comando.CommandText = "select max_pacientes from turno_especialidad where cod_espec='" & cmb_especialidad.SelectedValue & "' and cod_turno='" & cmb_turno.SelectedValue & "'"
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()

            If dr.HasRows Then
                While dr.Read()
                    lbl_max_por_dia_especialidad.Text = dr("max_pacientes")
                    Exit While
                End While
            Else
                lbl_max_por_dia_especialidad.Text = "0"
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("obtener_lim_pac_x_dia_x_esp", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("obtener_lim_pac_x_dia_x_esp", Err.Number, ex.Message)
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
    Private Sub Llenar_combo_turno()

        Dim myAdapter As New MySqlDataAdapter
        Dim myDS As New DataSet
        Dim comando As New MySqlCommand
        Try
            ConectarBD()
            comando.Connection = myCloneCon
            comando.CommandText = "SELECT turno_especialidad.*,turnos.turno " & _
                "from (turno_especialidad inner join turnos on turno_especialidad.cod_turno=turnos.cod_turno)" & _
                "where turno_especialidad.cod_espec='" & cmb_especialidad.SelectedValue.ToString & "' ORDER BY turno"

            myAdapter.SelectCommand = comando
            myAdapter.Fill(myDS)

            cmb_turno.DataSource = myDS.Tables(0)
            cmb_turno.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmb_turno.AutoCompleteSource = AutoCompleteSource.ListItems
            cmb_turno.MaxDropDownItems = 20

            cmb_turno.ValueMember = "cod_turno"
            'DisplayMember sirve para visualizar los datos cuando se despliega el control()
            cmb_turno.DisplayMember = "turno"
            If cmb_turno.Items.Count > 0 Then
                cmb_turno.SelectedIndex = 0
                cmb_turno.BackColor = Color.White
                cmb_turno.ForeColor = Color.Black
            Else
                cmb_turno.Text = "DEBE ASIGNAR UN TURNO A LA ESPECIALIDAD"
                cmb_turno.BackColor = Color.DarkRed
                cmb_turno.ForeColor = Color.White
            End If
            'Informativo_por_codigo.SetToolTip(El_combo, El_combo.DisplayMember)
            comando.Dispose()
            myDS.Dispose()
            myAdapter.Dispose()
        Catch ex As Exception
            Select Case Err.Number
                Case 0

                Case 5
                    'MsgBox("No se pudo cargar la lista de turnos", vbExclamation + vbSystemModal, "Ayuda del sistema")
                Case Else
                    MsgBox(ex.Message & Err.Number, vbSystemModal + vbExclamation, "Ayuda del sistema del llenar_combo_turno")
            End Select
        End Try
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub cmb_turno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_turno.SelectedIndexChanged
        Informativo_por_codigo.Dispose()
        If Not IsNothing(cmb_turno.SelectedValue) Then
            Llenar_combo_medico()
            obtener_can_pac_tipo_cita()
        End If

    End Sub
    Private Sub nueva_cita()
        'Limpiar_Controles(Me)
        'Calendario.SelectionStart = Now
        'año_up.Value = Year(Now)

        'cmb_especialidad.SelectedValue = ""
        'cmb_turno.SelectedValue = ""
        'cmb_tipo_cita.SelectedValue = ""
        'cmb_medico.SelectedValue = ""
        'cmb_tipo_cita.Text = "SELECCIONAR"
        'cmb_especialidad.Text = "SELECCIONAR"
        'cmb_turno.Text = "SELECCIONAR"
        'cmb_medico.Text = "SELECCIONAR"
        Destino = "frm_control_citas"
        frm_abrir_datos_paciente.Show()
        'Mostrar_formulario(frm_abrir_datos_paciente)
    End Sub
    Private Sub btn_nueva_cita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nueva_cita.Click
        nueva_cita()
    End Sub
    Private Sub obtener_can_pac_tipo_cita()
        If Not IsNothing(cmb_tipo_cita.SelectedValue) Then
            Dim comando As New MySqlCommand
            Dim dr As MySqlDataReader 'dr=data reader
            Try
                comando.CommandText = "select max_diario from tipos_citas where cod_tipo_cita='" & cmb_tipo_cita.SelectedValue.ToString & "'"

                ConectarBD()
                comando.Connection = myCloneCon
                dr = comando.ExecuteReader()

                If dr.HasRows Then
                    While dr.Read()
                        If dr("max_diario") > 0 Then
                            lbl_max_pac_por_tipo_cita.Text = dr("max_diario")
                        Else
                            lbl_max_pac_por_tipo_cita.Text = lbl_max_por_dia_especialidad.Text
                        End If

                        Exit While
                    End While
                Else
                    lbl_max_pac_por_tipo_cita.Text = "0"
                End If
                If Val(lbl_max_pac_por_tipo_cita.Text) > Val(lbl_max_por_dia_especialidad.Text) And (lbl_max_pac_por_tipo_cita.Text <> "" And lbl_max_por_dia_especialidad.Text <> "") Then
                    Mostrar_informacion("exc", "Error en configuración", "El maximo de pacientes por tipo de cita" & vbNewLine & "no puede ser mayor que el maximo de citas permitido por turno", True, 6000, lbl_max_pac_por_tipo_cita, "")
                End If
            Catch Mysql_ex As MySqlException
                Mostrar_mensaje_error_Mysql("obtener_can_pac_tipo_cita", Mysql_ex.Number, Mysql_ex.Message)
            Catch ex As Exception
                Mostrar_mensaje_error("obtener_can_pac_tipo_cita", Err.Number, ex.Message)
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
        End If
    End Sub
    Private Sub calcular_citas_disponibles()
        lbl_cupos_disponibles.Text = Val(lbl_max_por_dia_especialidad.Text) - Val(lbl_total_paciente_citados_x_turno.Text)
        lbl_notas_calendario.Text = "DIA: " & Calendario.SelectionStart.ToString("dd-MM-yyyy") & " DISPONIBLE(" & lbl_cupos_disponibles.Text & ")"
        If lbl_cupos_disponibles.Text < 0 Then
            lbl_cupos_disponibles.Text = 0
            lbl_notas_calendario.Text = "DIA: " & Calendario.SelectionStart.ToString("dd-MM-yyyy") & " DISPONIBLE(0)"
        End If
    End Sub
    Private Sub cmb_tipo_cita_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tipo_cita.SelectedIndexChanged
        Informativo_por_codigo.Dispose()
        If Not IsNothing(cmb_tipo_cita.SelectedValue) And Not IsNothing(cmb_turno.SelectedValue) And Not IsNothing(cmb_especialidad.SelectedValue) Then
            'Mostrar_resumen_citas()
            Mostrar_pacientes_del_dia()
            obtener_can_pac_tipo_cita()
            calcular_citas_disponibles()
        End If
    End Sub

    Private Sub lbl_num_hist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_num_hist.Click
        nueva_cita()
    End Sub

    Private Sub lbl_nombres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_nombres.Click
        nueva_cita()
    End Sub

    Private Sub lbl_apellidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_apellidos.Click
        nueva_cita()
    End Sub
    Public Sub Mostrar_pacientes_del_dia()
        Dim comando As New MySqlCommand
        lbl_total_pac_citado_x_tipocita.Text = 0
        lbl_total_paciente_citados_x_turno.Text = 0
        Dim total_diario_pacientes_citados_turno As Integer = 0
        Dim Tot_diario_x_tipo_cita As Integer = 0
        Dim grupoTurno As String = String.Empty
        Dim grupoEspecialidad As String = String.Empty

        Dim gt, ge, gtotal As New ListViewGroup
        Try

            If Not IsNothing(cmb_turno.SelectedValue) Then
                Cant_Reg = 1
                Lista_pacientes_dia.Clear()
                Lbl_paciente_fecha.Text = UCase("PACIENTES DEL DIA: " & Calendario.SelectionStart.ToString("dddd,dd-MMMM-yyyy"))
                'ObtenerPrimerUltimoDiaMesAño(Calendario.SelectionStart.ToString("dd-MM-yyyy"))
                comando.CommandText = "SELECT citas_medicas.num_historia,citas_medicas.cod_espec,citas_medicas.cod_medico,citas_medicas.cod_turno,citas_medicas.fecha_cita,citas_medicas.cod_tipo_cita,datos_personales.nombres,datos_personales.apellidos,especialidades.especialidad,estado_cita.descrip_edo_cita,turnos.turno,tipos_citas.descripcion_tipo from " & _
                    "(citas_medicas inner join especialidades on citas_medicas.cod_espec=especialidades.cod_espec " & _
                    " inner join turnos on citas_medicas.cod_turno=turnos.cod_turno " & _
                    " inner join datos_personales on citas_medicas.num_historia=datos_personales.num_historia " & _
                    " inner join tipos_citas on citas_medicas.cod_tipo_cita=tipos_citas.cod_tipo_cita " & _
                    "inner join estado_cita on citas_medicas.cod_edo_cita=estado_cita.cod_edo_cita) where citas_medicas.fecha_cita='" & Calendario.SelectionStart.ToString("yyyy-MM-dd") & "'" & _
                    " AND citas_medicas.cod_turno='" & cmb_turno.SelectedValue & "'" & _
                    " AND citas_medicas.cod_edo_cita='0000'" & _
                    " order by turno,especialidad,nombres,apellidos asc"
                ConectarBD()
                comando.Connection = myCloneCon
                dr = comando.ExecuteReader()
                Lista_pacientes_dia.Clear()
                Lista_pacientes_dia.View = View.Details 'importante para que los datos se vean como lista
                Lista_pacientes_dia.FullRowSelect = True
                '.....Agrego Los Titulos a el listview y tamaño de columnas
                Lista_pacientes_dia.Columns.Add("Nº", 200, HorizontalAlignment.Left)
                Lista_pacientes_dia.Columns.Add("TURNO", 200, HorizontalAlignment.Left)
                Lista_pacientes_dia.Columns.Add("PACIENTE", 200, HorizontalAlignment.Left)
                'Lista_pacientes_dia.Columns.Add("ESPECIALIDAD", 200, HorizontalAlignment.Left)
                Lista_pacientes_dia.Columns.Add("ESTADO", 100, HorizontalAlignment.Left)
                'ESTOS CODIGOS LUEGO LOS OCULTO ME SIRVEN SOLO PARA ELMINAR O CANCELAR LA CITA
                Lista_pacientes_dia.Columns.Add("TIPO CITA", 200, HorizontalAlignment.Left)
                Lista_pacientes_dia.Columns.Add("Nº HISTORIA", 200, HorizontalAlignment.Left)
                Lista_pacientes_dia.Columns.Add("COD. ESPECIALIDAD", 200, HorizontalAlignment.Left)
                Lista_pacientes_dia.Columns.Add("COD. MÉDICO", 200, HorizontalAlignment.Left)
                Lista_pacientes_dia.Columns.Add("COD. TURNO", 200, HorizontalAlignment.Left)
                Lista_pacientes_dia.Columns.Add("FECHA CITA", 200, HorizontalAlignment.Left)

                If dr.HasRows Then
                    'desabilito el boton eliminar y cancelar cita
                    btn_eliminar.Enabled = False
                    btn_cancelar_cita.Enabled = False

                    While dr.Read()
                        Cant_Reg = Cant_Reg + 1


                        '-------------------------------------------------------
                        If dr("especialidad").ToString <> grupoEspecialidad Then

                            ge = New ListViewGroup(dr("especialidad").ToString)
                            grupoEspecialidad = dr("especialidad").ToString
                            Lista_pacientes_dia.Groups.Add(ge)
                            Cant_Reg = 1
                        End If

                        '...Agrego al listview la data de la consulta efectuada
                        Dim item As New ListViewItem("")
                        If dr("cod_espec") = cmb_especialidad.SelectedValue Then
                            item.ForeColor = Color.Black
                            'item.Font = New Font(Lista_pacientes_dia.Font, FontStyle.Bold)
                            total_diario_pacientes_citados_turno = total_diario_pacientes_citados_turno + 1
                            If Not IsNothing(cmb_tipo_cita.SelectedValue) Then
                                If dr("cod_tipo_cita") = cmb_tipo_cita.SelectedValue Then
                                    Tot_diario_x_tipo_cita = Tot_diario_x_tipo_cita + 1
                                    lbl_total_pac_citado_x_tipocita.Text = Tot_diario_x_tipo_cita
                                End If
                            End If

                            item.Text = Cant_Reg.ToString()
                            item.SubItems.Add(dr("turno").ToString())
                            item.SubItems.Add(StrConv(dr("nombres").ToString() & " " & UCase(dr("apellidos").ToString()), VbStrConv.ProperCase))
                            item.SubItems.Add(StrConv(dr("descrip_edo_cita").ToString, VbStrConv.ProperCase))
                            item.SubItems.Add(StrConv(dr("descripcion_tipo").ToString, VbStrConv.ProperCase))
                            'AGREGO LOS CODIGOS
                            item.SubItems.Add(dr("num_historia"))
                            item.SubItems.Add(dr("cod_espec"))
                            item.SubItems.Add(dr("cod_medico"))
                            item.SubItems.Add(dr("cod_turno"))
                            item.SubItems.Add(dr("fecha_cita"))
                            'item.Group = gt
                            item.Group = ge

                            Lista_pacientes_dia.Items.Add(item)
                        Else
                            item.ForeColor = Color.Gray
                        End If
                        Dim EsPar As Boolean = False
                        'EsPar = IIf(total_diario_pacientes_citados_turno Mod 2, False, True)
                        'If EsPar Then
                        '    item.BackColor = Color.Gray
                        'Else
                        '    item.BackColor = Color.WhiteSmoke
                        'End If

                    End While
                    dr.Close()
                    ' If total_diario_pacientes_citados_turno > 0 Then


                Else
                    'Lista_pacientes_dia.Clear()
                    calcular_citas_disponibles()
                    'MsgBox("No se encontró la información solicitada", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
                End If
                gtotal = New ListViewGroup("TOTAL DE PACIENTES POR TURNO ")
                Lista_pacientes_dia.Groups.Add(gtotal)
                Dim itemTotal As New ListViewItem("")
                itemTotal.SubItems.Add("")
                itemTotal.SubItems.Add("TOTAL DE PACIENTES: " & total_diario_pacientes_citados_turno.ToString)
                itemTotal.Group = gtotal
                'itemTotal.ForeColor = Color.Black
                itemTotal.Font = New Font(Lista_pacientes_dia.Font, FontStyle.Bold)
                Lista_pacientes_dia.Items.Add(itemTotal)
                Ajustar_tamaño_listas(Lista_pacientes_dia)
                'End If
                lbl_total_paciente_citados_x_turno.Text = total_diario_pacientes_citados_turno
                calcular_citas_disponibles()

                'Lista_pacientes_dia.Columns(3).Width = 0
                'Lista_pacientes_dia.Items(0).Selected = True
                ' Lista_pacientes_dia.Items(0).EnsureVisible()
                'Lista_pacientes_dia.Focus()

                'Grupo_Resumen.Text = "Total solicitudes del año: " & Cant_Reg
            Else
                Informativo_por_codigo.Dispose()
                Mostrar_informacion("inf", "Notificación:", "Debe seleccionar la especialidad a la que acudirá el paciente", True, 3500, cmb_especialidad, "")
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Mostrar_pacientes_del_dia", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar_pacientes_del_dia", Err.Number, ex.Message)
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

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Calcular_proximo_dia_disponible(ByVal fecha As Date)
        If IsNothing(cmb_especialidad.SelectedValue) Then
            Mostrar_informacion("inf", "Notificación:", "Debe seleccionar la especialidad a la cual acudirá el paciente", True, 3000, cmb_especialidad, "inf")
            Exit Sub
        End If
        If IsNothing(cmb_turno.SelectedValue) Then
            Mostrar_informacion("inf", "Notificación:", "Debe seleccionar el turno", True, 3000, cmb_turno, "")
            Exit Sub
        End If
        If IsNothing(cmb_tipo_cita.SelectedValue) Then
            Mostrar_informacion("inf", "Notificación:", "Debe seleccionar el tipo de cita", True, 3000, cmb_tipo_cita, "")
            Exit Sub
        End If
        Dim Encontrado As Boolean = False
        Dim Fecha_evaluada As Date = Nothing
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Dim contador_x_tipo_cita As Integer = 0
        Try
            Fecha_evaluada = fecha
            While Encontrado = False
                Fecha_evaluada = DateAdd("d", 1, Fecha_evaluada.ToString("yyyy-MM-dd"))
                Es_Fin_de_Semana(Fecha_evaluada.ToString("dd-MM-yyyy"))
                'verifico si la fecha es feriado
                Verifica_Feriado(Fecha_evaluada.ToString("dd-MM-yyyy"))
                Verifica_labora_medico(cmb_medico.SelectedValue, Fecha_evaluada.ToString("dd-MM-yyyy"))
                'verifico si no es fin de semana , si no es veriado y si el medico labora el dia en estudio
                If Var_es_Fin_de_Semana = False And VarP_Es_Feriado = False And Var_P_Medico_Labora = True Then
                    'obtengo el total por tipo de cita para cada especialidad para cada turno
                    comando.CommandText = "select count(*) as MySql_tot_paciente_dia_turno from citas_medicas " & _
                    "where  cod_turno='" & cmb_turno.SelectedValue & "' and cod_espec='" & cmb_especialidad.SelectedValue & "' and cod_tipo_cita='" & cmb_tipo_cita.SelectedValue & "' and date(fecha_cita)='" & Fecha_evaluada.ToString("yyyy-MM-dd") & "' AND cod_edo_cita='" & "0000" & "'"
                    ConectarBD()
                    comando.Connection = myCloneCon
                    contador_x_tipo_cita = comando.ExecuteScalar  'me devuelve en numeros la cantidad de registros mientras que con excecutereader no
                    '------------------------------------------------------------------------------------------------
                    'obtengo el total por turno por especialidad
                    comando.CommandText = "select count(*) as MySql_tot_paciente_dia_turno from citas_medicas " & _
                        "where  cod_turno='" & cmb_turno.SelectedValue & "' and cod_espec='" & cmb_especialidad.SelectedValue & "' and date(fecha_cita)='" & Fecha_evaluada.ToString("yyyy-MM-dd") & "'"
                    ConectarBD()
                    comando.Connection = myCloneCon
                    dr = comando.ExecuteReader()

                    If dr.HasRows Then
                        While dr.Read()
                            If (Val(lbl_max_por_dia_especialidad.Text) - Val(dr("MySql_tot_paciente_dia_turno"))) > 0 And contador_x_tipo_cita < Val(lbl_max_pac_por_tipo_cita.Text) Then
                                Encontrado = True

                                Calendario.SelectionStart = Fecha_evaluada
                                'Calendario.BoldedDates = Nothing
                                Calendario.BoldedDates = New System.DateTime() {New System.DateTime(Year(Fecha_evaluada), Month(Fecha_evaluada), Calendario.SelectionStart.Day, 0, 0, 0, 0)}
                                Mostrar_informacion("inf", "Notificación:", "Se encontró la fecha: " & Fecha_evaluada.ToString("dddd, dd-MMMM-yyyy"), True, 3000, Calendario, "inf")
                            End If
                            Exit While
                        End While
                    Else
                        lbl_max_por_dia_especialidad.Text = "0"
                    End If
                End If
            End While
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("obtener_lim_pac_x_dia_x_esp", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("obtener_lim_pac_x_dia_x_esp", Err.Number, ex.Message)
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

    Private Sub meses_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If meses.Value > 1 Then
            btn_prox_mes.Text = "Meses"
        Else
            btn_prox_mes.Text = "Mes"
        End If
    End Sub

    Private Sub btn_prox_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prox.Click
        Calcular_proximo_dia_disponible(Calendario.SelectionStart)
    End Sub

    Private Sub btn_prox_mes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_prox_mes.Click
        'calculo el mes anterior y le resto un dia para leugo hacer el calculo de el proximo mes disponible
        Dim lafecha As Date
        '-1 para que calclule la fecha exacta no cambiar ese valor ver logica de procedim calcular prox dia dipsonible para entender
        lafecha = DateAdd("d", -1, Calendario.SelectionStart)
        lafecha = DateAdd("m", meses.Value, lafecha)
        Calcular_proximo_dia_disponible(lafecha)
    End Sub

    Private Sub cmb_medico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_medico.SelectedIndexChanged
        'If Not IsNothing(cmb_medico.SelectedValue) Then
        Informativo_por_codigo.Dispose()
        Verifica_labora_medico(cmb_medico.SelectedValue.ToString, Calendario.SelectionStart)
        If Var_P_Medico_Labora = False Then
            btn_archivar_cita.Enabled = False
            Mostrar_informacion("err", "Error:", "El médico seleccionado no recibirá pacientes el día seleccionado", True, 4000, cmb_medico, "err")
            lbl_notas_calendario.Text = "MÉDICO NO DISPONIBLE"
            Exit Sub
        Else
            If Val(lbl_cupos_disponibles.Text) > 0 Then
                btn_archivar_cita.Enabled = True
            End If
            Limpiar_Controles(Lista_pacientes_dia)
            obtener_lim_pac_x_dia_x_esp()
            Mostrar_pacientes_del_dia()
            obtener_can_pac_tipo_cita()
        End If
        'End If
    End Sub
    Private Sub valida_archivar()
        paso_validacion_cita = False
        If lbl_num_hist.Text = "" Then
            Mostrar_informacion("inf", "Notificación:", "Debe seleccionar un paciente", True, 3000, lbl_num_hist, "")
            Exit Sub
        End If
        If IsNothing(cmb_especialidad.SelectedValue) Then
            Mostrar_informacion("inf", "Notificación:", "Debe seleccionar la especialidad a la cual acudirá el paciente", True, 3000, cmb_especialidad, "")
            Exit Sub
        End If
        If IsNothing(cmb_turno.SelectedValue) Then
            Mostrar_informacion("inf", "Notificación:", "Debe seleccionar el turno", True, 3000, cmb_turno, "")
            Exit Sub
        End If
        If IsNothing(cmb_tipo_cita.SelectedValue) Then
            Mostrar_informacion("inf", "Notificación:", "Debe seleccionar el tipo de cita", True, 3000, cmb_tipo_cita, "")
            Exit Sub
        End If
        Verifica_labora_medico(cmb_medico.SelectedValue, Calendario.SelectionStart.ToString("dd-MM-yyyy"))
        If Var_P_Medico_Labora = False Then
            Mostrar_informacion("err", "Error:", "El médico seleccionado no recibirá pacientes el día seleccionado", True, 4000, cmb_medico, "err")
            Exit Sub
        End If
        If lbl_notas_calendario.Text = "DIA NO DISPONIBLE (FIN SEMANA)" Then
            Mostrar_informacion("err", "Error:", "El dia seleccionado no se reciben pacientes" & vbNewLine & "es fin de semana", True, 4000, Calendario, "err")
            Exit Sub
        End If
        If lbl_notas_calendario.Text = "DIA NO DISPONIBLE (FERIADO)" Then
            Mostrar_informacion("err", "Error:", "El dia seleccionado no se reciben pacientes" & vbNewLine & "es fin de feriado", True, 4000, Calendario, "err")
            Exit Sub
        End If
        If Val(lbl_cupos_disponibles.Text) <= 0 Then
            If MsgBox("Para el día seleccionado no hay cupo disponible para citas" & vbNewLine & _
                      "Nota: Puede agregar citas extras pero quedaría bajo su responsabilidad" & vbNewLine & _
                      "¿Está seguro que desea agregar una cita extra?", vbQuestion + vbYesNo, "Cupos llenos") = vbNo Then
                Exit Sub
            End If
        End If
        'si no sale con exit sub pasa la validadcion y paso la variable al modulo de guardar la cita
        paso_validacion_cita = True
    End Sub
    Private Sub Archivar_cita()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Try
            valida_archivar()
            If paso_validacion_cita = True Then
                If MsgBox("Confirme los datos de la cita:" & vbNewLine & vbNewLine & _
                    "PACIENTE: " & lbl_nombres.Text & " " & lbl_apellidos.Text & vbNewLine & _
                    "TURNO: " & cmb_turno.Text & vbNewLine & _
                     "ESPECIALIDAD: " & cmb_especialidad.Text & vbNewLine & _
                    "TIPO DE CITA: " & cmb_tipo_cita.Text & vbNewLine & _
                    "MÉDICO: " & cmb_medico.Text & vbNewLine & _
                    "FECHA DE CITA: " & Calendario.SelectionStart.ToString("dddd, dd-MMMM-yyyy") & vbNewLine & vbNewLine & _
                    "¿Los datos anteriores son correctos?", vbQuestion + vbYesNo + vbDefaultButton1, "Programación de cita") = vbYes Then

                    sql_str = "INSERT INTO citas_medicas (num_historia,cod_espec,cod_medico,cod_turno,cod_tipo_cita,cod_edo_cita,fecha_cita,guardado_por,fecha_g) values ('" & _
                        lbl_num_hist.Text & "','" & _
                        cmb_especialidad.SelectedValue & "','" & _
                        cmb_medico.SelectedValue & "','" & _
                        cmb_turno.SelectedValue & "','" & _
                        cmb_tipo_cita.SelectedValue & _
                        "','0000','" & _
                        Calendario.SelectionStart.ToString("yyyy-MM-dd") & "','" & _
                        Cod_usuario & "','" & _
                        Now.ToString("yyyy-MM-dd HH:mm:ss") & "')"
                    comando.CommandText = sql_str
                    ConectarBD()
                    comando.Connection = myCloneCon


                    comando.ExecuteReader()
                    'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
                    MsgBox("La cita se programó correctamente", vbInformation, "Notificación")
                    'btn_eliminar.Enabled = True
                    Mostrar_pacientes_del_dia()
                    Limpiar_Controles(Grupo_paciente)
                    Limpiar_Controles(Grupo_Resumen)
                    'Limpiar_Controles(Grupo_limites)
                End If
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar_cita", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_cita", Err.Number, ex.Message)

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

    Private Sub btn_archivar_cita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_archivar_cita.Click
        Archivar_cita()
    End Sub

    Private Sub Lista_pacientes_dia_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles Lista_pacientes_dia.ItemCheck
        If Lista_pacientes_dia.Items.Count > 1 Then
            btn_eliminar.Enabled = True
            btn_cancelar_cita.Enabled = True
        Else
            btn_eliminar.Enabled = False
            btn_cancelar_cita.Enabled = False
        End If
    End Sub

    Private Sub Lista_pacientes_dia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_pacientes_dia.SelectedIndexChanged
        If Lista_pacientes_dia.Items.Count > 1 Then
            btn_eliminar.Enabled = True
            btn_cancelar_cita.Enabled = True
        Else
            btn_eliminar.Enabled = False
            btn_cancelar_cita.Enabled = False
        End If

    End Sub
    Private Sub eliminar_cita()
        If Lista_pacientes_dia.Items.Count > 1 Then
            Try
                Var_temp_contador = 0
                For i = 0 To Lista_pacientes_dia.Items.Count - 2
                    If Lista_pacientes_dia.Items(i).Checked = True Then
                        Dim num_historia As String = Lista_pacientes_dia.Items(i).SubItems(5).Text
                        Dim cod_espe As String = Lista_pacientes_dia.Items(i).SubItems(6).Text
                        Dim cod_medico As String = Lista_pacientes_dia.Items(i).SubItems(7).Text
                        Dim cod_turno As String = Lista_pacientes_dia.Items(i).SubItems(8).Text
                        Dim fecha_cita As String = Lista_pacientes_dia.Items(i).SubItems(9).Text
                        Sql_Eliminar_cita(num_historia, cod_espe, cod_medico, cod_turno, fecha_cita)
                    End If
                Next
                If Var_temp_contador > 0 Then
                    MsgBox("Se eliminó la(s) cita(s) seleccionada(s), Total de citas: " & Var_temp_contador, vbInformation, "Citas eliminadas")
                    Mostrar_pacientes_del_dia()
                Else
                    MsgBox("No se eliminó ninguna cita", vbInformation, "Eliminar citas")
                End If
            Catch ex As Exception
                Mostrar_mensaje_error("Eliminar_cita", Err.Number, ex.Message)
                Cant_Reg = 0
            End Try
        End If
    End Sub
    Private Sub Sql_Eliminar_cita(ByVal num_historia As String, ByVal cod_espec As String, ByVal cod_medico As String, ByVal cod_turno As String, ByVal fecha_cita As Date)
        Dim sql_str As String
        Dim comando As New MySqlCommand
        sql_str = "Delete from citas_medicas where num_historia='" & num_historia & "' and " & _
            "cod_espec='" & cod_espec & "' and " & _
            "cod_medico='" & cod_medico & "' and " & _
            "cod_turno='" & cod_turno & "' and " & _
            "cod_turno='" & cod_turno & "' and " & _
            "fecha_cita='" & fecha_cita.ToString("yyyy-MM-dd") & "'"
        Try
            Cant_Reg = 0
            comando.CommandText = sql_str
            ConectarBD()
            comando.Connection = myCloneCon
            Cant_Reg = comando.ExecuteNonQuery
            Var_temp_contador = Var_temp_contador + Cant_Reg

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Sql_Eliminar_cita", Mysql_ex.Number, Mysql_ex.Message)
            Cant_Reg = 0
        Catch ex As Exception
            Mostrar_mensaje_error("Sql_Eliminar_cita", Err.Number, ex.Message)
            Cant_Reg = 0
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

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim hay_seleccionados As Boolean = False
        For i = 0 To Lista_pacientes_dia.Items.Count - 2
            If Lista_pacientes_dia.Items(i).Checked = True Then
                hay_seleccionados = True
                Exit For
            End If
        Next
        If hay_seleccionados = True Then
            If MsgBox("Nota: esta acción no se podrá deshacer y los pacientes seleccionados quedarán sin cita por lo tanto no podrán asistir a la consulta" & _
                      vbNewLine & "¿Está seguro que desea eliminar la selección de citas médicas?", vbYesNo + vbQuestion + vbDefaultButton2 + vbSystemModal, "Confirme la eliminación") = vbYes Then
                eliminar_cita()
            End If
        Else
            MsgBox("No hay citas seleccionadas, debe marcar las citas que desea eliminar", vbExclamation, "Ayuda del sistema")
        End If
    End Sub

    Private Sub btn_cancelar_cita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar_cita.Click
        Dim hay_seleccionados As Boolean = False
        For i = 0 To Lista_pacientes_dia.Items.Count - 2
            If Lista_pacientes_dia.Items(i).Checked = True Then
                hay_seleccionados = True
                Exit For
            End If
        Next
        If hay_seleccionados = True Then
            Mostrar_formulario(frm_cancela_citas, True)
        Else
            MsgBox("No hay citas seleccionadas, debe marcar las citas que desea cancelar", vbExclamation, "Ayuda del sistema")
        End If

    End Sub
    Public Sub cancelar_cita()
        If Lista_pacientes_dia.Items.Count > 1 Then
            Try
                Var_temp_contador = 0
                For i = 0 To Lista_pacientes_dia.Items.Count - 2
                    If Lista_pacientes_dia.Items(i).Checked = True Then
                        Dim num_historia As String = Lista_pacientes_dia.Items(i).SubItems(5).Text
                        Dim cod_espe As String = Lista_pacientes_dia.Items(i).SubItems(6).Text
                        Dim cod_medico As String = Lista_pacientes_dia.Items(i).SubItems(7).Text
                        Dim cod_turno As String = Lista_pacientes_dia.Items(i).SubItems(8).Text
                        Dim fecha_cita As String = Lista_pacientes_dia.Items(i).SubItems(9).Text
                        Sql_cancelar_cita(num_historia, cod_espe, cod_medico, cod_turno, fecha_cita)
                    End If
                Next
                If Var_temp_contador > 0 Then
                    MsgBox("Se cancelaron la(s) cita(s) seleccionada(s), Total de citas: " & Var_temp_contador, vbInformation, "Citas eliminadas")
                    Mostrar_pacientes_del_dia()
                Else
                    MsgBox("No se canceló ninguna cita", vbInformation, "Eliminar citas")
                End If
            Catch ex As Exception
                Mostrar_mensaje_error("Eliminar_cita", Err.Number, ex.Message)
                Cant_Reg = 0
            End Try
        End If
    End Sub
    Private Sub Sql_cancelar_cita(ByVal num_historia As String, ByVal cod_espec As String, ByVal cod_medico As String, ByVal cod_turno As String, ByVal fecha_cita As Date)
        Dim sql_str As String
        Dim comando As New MySqlCommand
        sql_str = "update citas_medicas set cod_edo_cita='0002',notas='" & var_pu_motivo_cancela_cosulta & "' " & _
            "where num_historia='" & num_historia & "' and " & _
            "cod_espec='" & cod_espec & "' and " & _
            "cod_medico='" & cod_medico & "' and " & _
            "cod_turno='" & cod_turno & "' and " & _
            "cod_turno='" & cod_turno & "' and " & _
            "fecha_cita='" & fecha_cita.ToString("yyyy-MM-dd") & "'"
        Try
            Cant_Reg = 0
            comando.CommandText = sql_str
            ConectarBD()
            comando.Connection = myCloneCon
            Cant_Reg = comando.ExecuteNonQuery
            Var_temp_contador = Var_temp_contador + Cant_Reg

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Sql_Eliminar_cita", Mysql_ex.Number, Mysql_ex.Message)
            Cant_Reg = 0
        Catch ex As Exception
            Mostrar_mensaje_error("Sql_Eliminar_cita", Err.Number, ex.Message)
            Cant_Reg = 0
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
            frm_resumen_citas.Close()
            Mostrar_formulario(frm_resumen_citas, False)
            Llenar_combo_con_BD(frm_resumen_citas.cmb_estatus_cita, "cod_edo_cita", "descrip_edo_cita", "estado_cita", True, "cod_edo_cita")
            frm_resumen_citas.cmb_estatus_cita.SelectedValue = ""
            frm_resumen_citas.cmb_estatus_cita.SelectedValue = "0000"
            'frm_resumen_citas.cmb_estatus_cita.Text = "ATENDIDO"
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub
    Public Sub Cambia_edo_cita_atendido()
        If Lista_pacientes_dia.Items.Count > 1 Then
            Try
                Var_temp_contador = 0
                For i = 0 To Lista_pacientes_dia.Items.Count - 2
                    If Lista_pacientes_dia.Items(i).Checked = True Then
                        Dim num_historia As String = Lista_pacientes_dia.Items(i).SubItems(5).Text
                        Dim cod_espe As String = Lista_pacientes_dia.Items(i).SubItems(6).Text
                        Dim cod_medico As String = Lista_pacientes_dia.Items(i).SubItems(7).Text
                        Dim cod_turno As String = Lista_pacientes_dia.Items(i).SubItems(8).Text
                        Dim fecha_cita As String = Lista_pacientes_dia.Items(i).SubItems(9).Text
                        Sql_paciente_atendido(num_historia, cod_espe, cod_medico, cod_turno, fecha_cita)
                    End If
                Next
                If Var_temp_contador > 0 Then
                    MsgBox("Se actualizó el estado del paciente a atendido, Total de pacientes: " & Var_temp_contador, vbInformation, "Atender pacientes")
                    Mostrar_pacientes_del_dia()
                Else
                    MsgBox("No se procesó ningun paciente", vbInformation, "Cambiar estado de paciente a atendido")
                End If
            Catch ex As Exception
                Mostrar_mensaje_error("Eliminar_cita", Err.Number, ex.Message)
                Cant_Reg = 0
            End Try
        End If
    End Sub
    Private Sub Sql_paciente_atendido(ByVal num_historia As String, ByVal cod_espec As String, ByVal cod_medico As String, ByVal cod_turno As String, ByVal fecha_cita As Date)
        Dim sql_str As String
        Dim comando As New MySqlCommand
        sql_str = "update citas_medicas set cod_edo_cita='0001',notas='" & txt_atendido.Text & "' " & _
            "where num_historia='" & num_historia & "' and " & _
            "cod_espec='" & cod_espec & "' and " & _
            "cod_medico='" & cod_medico & "' and " & _
            "cod_turno='" & cod_turno & "' and " & _
            "cod_turno='" & cod_turno & "' and " & _
            "fecha_cita='" & fecha_cita.ToString("yyyy-MM-dd") & "'"
        Try
            Cant_Reg = 0
            comando.CommandText = sql_str
            ConectarBD()
            comando.Connection = myCloneCon
            Cant_Reg = comando.ExecuteNonQuery
            Var_temp_contador = Var_temp_contador + Cant_Reg

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Sql_Eliminar_cita", Mysql_ex.Number, Mysql_ex.Message)
            Cant_Reg = 0
        Catch ex As Exception
            Mostrar_mensaje_error("Sql_Eliminar_cita", Err.Number, ex.Message)
            Cant_Reg = 0
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

    Private Sub lbl_resultado_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_resultado_consulta.Click

    End Sub

    Private Sub txt_atendido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_atendido.TextChanged

    End Sub

    Private Sub btn_atendido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_atendido.Click
        Dim hay_seleccionados As Boolean = False
        For i = 0 To Lista_pacientes_dia.Items.Count - 2
            If Lista_pacientes_dia.Items(i).Checked = True Then
                hay_seleccionados = True
                Exit For
            End If
        Next
        If hay_seleccionados = True Then
            If MsgBox("¿Está seguro que desea cambiar el estado a atendido de la selección de pacientes?", vbYesNo + vbDefaultButton1 + vbSystemModal, "Ayuda del sistema") = vbYes Then
                Cambia_edo_cita_atendido()
                txt_atendido.Text = ""
            End If
        Else
            MsgBox("No hay pacientes atendidos, debe seleccionar los pacientes que ya fueron atendidos", vbExclamation, "Ayuda del sistema")
        End If

    End Sub
End Class