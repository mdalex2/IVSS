Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class frm_resumen_citas
    Dim CMDEXE
    Dim origen As String

    Private Sub frm_resumen_citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\icono_frm_citas.png")
        Fecha_desde.Value = Now
        Fecha_hasta.Value = Now
        Llenar_combo_con_BD(cmb_especialidad, "cod_espec", "especialidad", "especialidades", True, "especialidad")
        chk_todas_espc.Checked = True
        chk_todos_med.Checked = True
    End Sub



    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub
    Private Sub esta_semana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles esta_semana.CheckedChanged
        Obt_Primer_ultimo_dia_semana(Now)
        Fecha_desde.Value = Primer_dia_semana
        Fecha_hasta.Value = Ultimo_dia_Semana
    End Sub

    Private Sub manana_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manana.CheckedChanged
        Fecha_desde.Value = DateAdd("d", 1, Now)
        Fecha_hasta.Value = DateAdd("d", 1, Now)
    End Sub

    Private Sub ayer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ayer.CheckedChanged
        Fecha_desde.Value = DateAdd("d", -1, Now)
        Fecha_hasta.Value = DateAdd("d", -1, Now)
    End Sub

    Private Sub hoy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hoy.CheckedChanged
        Fecha_desde.Value = Now
        Fecha_hasta.Value = Now
    End Sub

    Private Sub este_mes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles este_mes.CheckedChanged
        ObtenerPrimerUltimoDiaMesAño(Now)
        Fecha_desde.Value = Primer_dia_mes
        Fecha_hasta.Value = Ultimo_dia_mes
    End Sub

    Private Sub este_anio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles este_anio.CheckedChanged
        ObtenerPrimerUltimoDiaMesAño(Now)
        Fecha_desde.Value = Primer_dia_año
        Fecha_hasta.Value = Ultimo_dia_año
    End Sub

    Private Sub anio_pasado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anio_pasado.CheckedChanged
        Dim año_pasado As Date = DateAdd(DateInterval.Year, -1, Now)
        ObtenerPrimerUltimoDiaMesAño(año_pasado)
        Fecha_desde.Value = Primer_dia_año
        Fecha_hasta.Value = Ultimo_dia_año
    End Sub

    Private Sub btn_restaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_restaurar.Click
        Try
            If IsNothing(cmb_estatus_cita.SelectedValue) Then
                Mostrar_informacion("inf", "Información:", "Debe seleccionar un tipo de consulta", True, 4000, cmb_estatus_cita, "inf")
                Exit Sub
            End If
            If Fecha_desde.Value > Fecha_hasta.Value Then
                Mostrar_informacion("err", "Información:", "La fecha desde debe ser menor que la fecha hasta", True, 3500, Fecha_desde, "err")
                Exit Sub
            End If
            If IsNothing(cmb_estatus_cita.SelectedValue) Then
                Mostrar_informacion("inf", "Información:", "Debe seleccionar un tipo de consulta", True, 4000, cmb_estatus_cita, "inf")
                Exit Sub
            End If
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)

            Dim fecha_inicio_rpt, fecha_fin_rpt As String
            fecha_inicio_rpt = Fecha_desde.Value.Year.ToString & "," & Fecha_desde.Value.Month.ToString & "," & Fecha_desde.Value.Day.ToString
            'Format(Fecha_desde, "yyyy,MM,dd")
            fecha_fin_rpt = Fecha_hasta.Value.Year.ToString & "," & Fecha_hasta.Value.Month.ToString & "," & Fecha_hasta.Value.Day.ToString
            Dim formula_seleccion As String = ""

            If Not chk_todas_espc.Checked = True Then
                formula_seleccion = "{citas_medicas.cod_espec}='" & cmb_especialidad.SelectedValue & "'"
            End If
            If chk_todos_med.Checked = False Then
                If formula_seleccion = "" Then
                    formula_seleccion = "{citas_medicas.cod_medico}='" & cmb_medico.SelectedValue & "'"
                Else
                    formula_seleccion = formula_seleccion & " and {citas_medicas.cod_medico}='" & cmb_medico.SelectedValue & "'"
                End If

            End If
            If formula_seleccion <> "" Then formula_seleccion = formula_seleccion & " and "

            formula_seleccion = formula_seleccion & _
                "{citas_medicas.cod_turno}='" & cmb_turno.SelectedValue & "'" & _
                " and {citas_medicas.cod_edo_cita}='" & cmb_estatus_cita.SelectedValue & "'" & _
                " and {citas_medicas.fecha_cita} >= datevalue(" & fecha_inicio_rpt & ") and {citas_medicas.fecha_cita} <= datevalue(" & fecha_fin_rpt & ")"
            'MsgBox(formula_seleccion)
            Dim fecha_tit_desde As Date = Fecha_desde.Value.Day.ToString & "/" & Fecha_desde.Value.Month.ToString & "/" & Fecha_desde.Value.Year.ToString
            Dim fecha_tit_hasta As Date = Fecha_hasta.Value.Day.ToString & "/" & Fecha_hasta.Value.Month.ToString & "/" & Fecha_hasta.Value.Year.ToString
            Dim TITULO_REPORTE As String = ""
            If hoy.Checked = True Or ayer.Checked = True Or manana.Checked = True Then
                TITULO_REPORTE = Lbl_titulo.Text & " DEL DÍA " + fecha_tit_desde.ToString("dddd,dd-MMMM-yyyy")
            Else
                If este_mes.Checked = True Then
                    TITULO_REPORTE = Lbl_titulo.Text & " PARA EL MES DE " & fecha_tit_desde.ToString("MMMM") + " DE " & fecha_tit_desde.Year.ToString
                Else
                    If este_anio.Checked = True Or anio_pasado.Checked = True Then
                        TITULO_REPORTE = Lbl_titulo.Text & " PARA EL AÑO " & fecha_tit_desde.Year.ToString
                    Else
                        TITULO_REPORTE = Lbl_titulo.Text & " DESDE " & fecha_tit_desde.ToString("dd/MM/yyyy") & " HASTA " & fecha_tit_hasta.ToString("dd/MM/yyyy")
                    End If
                End If
            End If

            frm_reportes.Muestra_reporte(UCase(TITULO_REPORTE), "Reporte citas.rpt", formula_seleccion, 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
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

    Private Sub cmb_especialidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_especialidad.SelectedIndexChanged
        Informativo_por_codigo.Dispose()
        If Not IsNothing(cmb_especialidad.SelectedValue) Then
            Llenar_combo_turno()
        End If
    End Sub
    Private Sub Llenar_combo_medico()
        If Not IsNothing(cmb_especialidad.SelectedValue) Then
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
                cmb_medico.DisplayMember = "dp"
                If cmb_medico.Items.Count > 0 Then
                    cmb_medico.SelectedIndex = 0
                    cmb_medico.BackColor = Color.White
                    cmb_medico.ForeColor = Color.Black
                    Informativo_por_codigo.Dispose()
                    If cmb_medico.Visible = True Then
                        Mostrar_informacion("inf", "Notificación", "Se ha cambiado el turno, la lista médicos se actualizó" & vbNewLine & "verifique el médico y turno", True, 4000, cmb_medico, "inf")
                    End If
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

    Private Sub cmb_turno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_turno.SelectedIndexChanged
        Llenar_combo_medico()
    End Sub


    Private Sub chk_todas_espc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_todas_espc.CheckedChanged
        If chk_todas_espc.Checked = True Then
            LBL_especialidad.Visible = False
            cmb_especialidad.Visible = False

            cmb_especialidad.SelectedValue = ""
            cmb_especialidad.Text = "TODAS LAS ESPECIALIDADES"
        Else
            LBL_especialidad.Visible = True
            cmb_especialidad.Visible = True
            cmb_especialidad.SelectedIndex = 0
            Mostrar_informacion("inf", "Notificación", "Verifique la especialidad", True, 2500, cmb_especialidad, "inf")
        End If
    End Sub

    Private Sub chk_todos_med_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_todos_med.CheckedChanged

        If chk_todos_med.Checked = True Then
            cmb_medico.Visible = False
            lbl_medico.Visible = False
            cmb_medico.SelectedValue = ""
            cmb_medico.Text = "TODOS LOS MÉDICOS"
        Else
            cmb_medico.Visible = True
            lbl_medico.Visible = True

            If cmb_medico.Items.Count > 0 Then
                cmb_medico.SelectedValue = ""
                cmb_medico.SelectedIndex = 0
                Mostrar_informacion("inf", "Notificación", "Verifique el nombre del médico", True, 3000, cmb_medico, "inf")
            End If
        End If
    End Sub

    Private Sub otros_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles otros.CheckedChanged
        'Mostrar_informacion("inf", "Notificación", "Seleccione la fecha de inicio y la fecha fin", True, 3000, Fecha_desde, "inf")
    End Sub

    Private Sub Fecha_desde_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fecha_desde.DropDown
        otros.Checked = True
    End Sub

    Private Sub Fecha_desde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Fecha_desde.KeyPress
        otros.Checked = True
    End Sub

    Private Sub Fecha_desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha_desde.ValueChanged

    End Sub

    Private Sub Fecha_hasta_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fecha_hasta.DropDown
        otros.Checked = True
    End Sub

    Private Sub Fecha_hasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Fecha_hasta.KeyPress
        otros.Checked = True
    End Sub

    Private Sub Fecha_hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha_hasta.ValueChanged

    End Sub

    Private Sub cmb_estatus_cita_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_estatus_cita.SelectedIndexChanged
        If Not IsNothing(cmb_estatus_cita.SelectedValue) Then
            Select Case cmb_estatus_cita.SelectedValue.ToString
                Case "0000"
                    Lbl_titulo.Text = "LISTADO DE CITAS PENDIENTES"
                Case "0001"
                    Lbl_titulo.Text = "LISTADO DE PACIENTES ATENDIDOS"
                Case "0002"
                    Lbl_titulo.Text = "LISTADO DE CITAS CANCELADAS"
                Case Else
                    Lbl_titulo.Text = "RESUMEN DE CITAS"
            End Select
        End If
    End Sub
End Class
