Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class frm_abrir_datos_paciente
    Dim Var_Pub_string_list(50) As String
    Dim Var_Pu_list_item As ListViewItem
    Private Sub frm_abrir_datos_paciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_opcn_busca.SelectedIndex = 0
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_documento.png")
        Label1.Parent = Pic_Encabezado
        Txt_busca.Focus()
        'Lbl_total_reg_encontrados.Parent = Pic_pie_pagina
        'CONTENEDOR.Parent = Pic_pie_pagina
    End Sub
    Private Sub Buscar_paciente_ventana()
        Dim comando As New MySqlCommand
        Try
            Lista_abrir_paciente.Clear()
            'Lista_HM_familares_principal.Clear()
            Select Case UCase(cmb_opcn_busca.Text)
                Case UCase("num. historia")
                    comando.CommandText = "SELECT num_historia,n_identificacion,nombres,apellidos,fecha_nac,cotizante FROM Datos_personales where num_historia like '%" & Txt_busca.Text & "%' and num_historia<>'NCI-0000' ORDER BY num_historia"
                Case UCase("num. documento")
                    comando.CommandText = "SELECT num_historia,n_identificacion,nombres,apellidos,fecha_nac,cotizante FROM Datos_personales where n_identificacion like '%" & Txt_busca.Text & "%' and num_historia<>'NCI-0000' ORDER BY num_historia"
                Case UCase("nombres y apellidos")
                    comando.CommandText = "SELECT num_historia,n_identificacion,nombres,apellidos,fecha_nac,cotizante FROM Datos_personales where (nombres like '%" & Txt_busca.Text & "%' or apellidos like '%" & Txt_busca.Text & "%') and num_historia<>'NCI-0000' ORDER BY nombres,apellidos asc"
            End Select
            Cant_Reg = 0
            ConectarBD()
            comando.Connection = myCloneCon
            If Txt_busca.Text <> "" And cmb_opcn_busca.Text <> "" Then
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    Lista_abrir_paciente.Clear()
                    Lista_abrir_paciente.View = View.Details 'importante para que los datos se vean como lista
                    Lista_abrir_paciente.FullRowSelect = True
                    '.....Agrego Los Titulos a el listview y tamaño de columnas
                    Lista_abrir_paciente.Columns.Add("NOMBRES", 200, HorizontalAlignment.Left)
                    Lista_abrir_paciente.Columns.Add("APELLIDOS", 200, HorizontalAlignment.Left)
                    Lista_abrir_paciente.Columns.Add("Nº HISTORIA", 100, HorizontalAlignment.Left)
                    Lista_abrir_paciente.Columns.Add("Nº DOCUMENTO", 200, HorizontalAlignment.Left)
                    Lista_abrir_paciente.Columns.Add("EDAD", 200, HorizontalAlignment.Left)
                    Lista_abrir_paciente.Columns.Add("TIPO PACIENTE", 200, HorizontalAlignment.Left)

                    While dr.Read()
                        Cant_Reg = Cant_Reg + 1

                        '...Agrego al listview la data de la consulta efectuada
                        Var_Pub_string_list(0) = StrConv(dr("nombres"), VbStrConv.ProperCase)
                        Var_Pub_string_list(1) = StrConv(dr("apellidos"), VbStrConv.ProperCase)


                        Var_Pub_string_list(2) = UCase(dr("num_historia"))
                        Var_Pub_string_list(3) = dr("n_identificacion")
                        Calcular_edad(dr("fecha_nac"), Now)
                        Var_Pub_string_list(4) = Edad_Completa
                        If dr("cotizante") = True Then
                            Var_Pub_string_list(5) = "COTIZANTE"
                        Else
                            Var_Pub_string_list(5) = "NO COTIZANTE"
                        End If

                        Var_Pu_list_item = New ListViewItem(Var_Pub_string_list)
                        Dim EsPar As Boolean = False
                        EsPar = IIf(Cant_Reg Mod 2, False, True)
                        If EsPar Then
                            Var_Pu_list_item.BackColor = Color.Lavender
                        Else
                            Var_Pu_list_item.BackColor = Color.White
                        End If
                        '.....Muestro los datos en el list
                        Lista_abrir_paciente.Items.Add(Var_Pu_list_item)
                        'Lista_abrir_paciente.Columns(0).Width = 0
                    End While
                    dr.Close()
                    Ajustar_tamaño_listas(Lista_abrir_paciente)
                    Lista_abrir_paciente.Columns(3).Width = 0
                    'Lista_abrir_paciente.Items(0).Selected = True
                    'Lista_abrir_paciente.Items(0).EnsureVisible()
                    'Lista_abrir_paciente.Focus()
                    'Pasa_num_historia = Lista_abrir_paciente.FocusedItem.SubItems(2).Text
                Else
                    MsgBox("No se encontró la información solicitada", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
                End If
                Lbl_total_reg_encontrados.BorderStyle = BorderStyle.FixedSingle
                Lbl_total_reg_encontrados.Text = "Total de registros encontrados: " & Cant_Reg
                If Cant_Reg > 0 Then
                    Btn_aceptar.Enabled = True
                Else
                    Btn_aceptar.Enabled = False
                End If
            Else
                If Txt_busca.Text = "" Then
                    Mostrar_informacion("inf", "Información:", "Debe escribir " & cmb_opcn_busca.Text & " del paciente a buscar", True, 3500, Txt_busca, "inf")
                    Txt_busca.Focus()
                End If
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_paciente_ventana", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_paciente_ventana", Err.Number, ex.Message)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Buscar_paciente_ventana()
    End Sub



    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Lista_abrir_paciente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_abrir_paciente.SelectedIndexChanged
        Pasa_num_historia = Lista_abrir_paciente.FocusedItem.SubItems(2).Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_aceptar.Click
        If Not IsNothing(Lista_abrir_paciente.FocusedItem) Then
            Select Case Destino
                Case "frm_control_citas"
                    frm_control_cita.lbl_nombres.Text = Lista_abrir_paciente.FocusedItem.Text
                    frm_control_cita.lbl_apellidos.Text = Lista_abrir_paciente.FocusedItem.SubItems(1).Text
                    frm_control_cita.lbl_num_hist.Text = Lista_abrir_paciente.FocusedItem.SubItems(2).Text
                    frm_control_cita.lbl_edad.Text = "EDAD: " & Lista_abrir_paciente.FocusedItem.SubItems(4).Text
                    frm_control_cita.lbl_tipo_paciente.Text = "TIPO PACIENTE: " & Lista_abrir_paciente.FocusedItem.SubItems(5).Text
                    Pasa_num_historia = Lista_abrir_paciente.FocusedItem.SubItems(2).Text
                    Mostrar_resumen_citas()
                    Me.Visible = False
                Case "frm_medicos_dias_no_lab"
                    frm_dias_no_laborables.lbl_nombres_apellidos.Text = Lista_abrir_paciente.FocusedItem.Text & " " & Lista_abrir_paciente.FocusedItem.SubItems(1).Text
                    frm_dias_no_laborables.lbl_num_hist.Text = Lista_abrir_paciente.FocusedItem.SubItems(2).Text
                    frm_dias_no_laborables.mostrar_lista()
                    Me.Visible = False
                Case "frm_usuarios"
                    frm_usuarios.lbl_usuario.Text = Lista_abrir_paciente.FocusedItem.Text & " " & Lista_abrir_paciente.FocusedItem.SubItems(1).Text
                    frm_usuarios.lbl_num_hist.Text = Lista_abrir_paciente.FocusedItem.SubItems(2).Text
                    frm_usuarios.Buscar_usuario()
                    Me.Visible = False
                Case "frm_asig_familiares"
                    If Lista_abrir_paciente.FocusedItem.SubItems(2).Text = frm_asig_familiares.lbl_num_hist_paciente.Text Then
                        MsgBox("No se puede asignar a la misma persona como familiar, seleccione otra persona diferente", vbExclamation + vbSystemModal, "Ayuda del sistema")
                    Else

                        frm_asig_familiares.lbl_nombre_familiar.Text = Lista_abrir_paciente.FocusedItem.Text & " " & Lista_abrir_paciente.FocusedItem.SubItems(1).Text
                        frm_asig_familiares.lbl_num_hist_familiar.Text = Lista_abrir_paciente.FocusedItem.SubItems(2).Text
                        frm_asig_familiares.Buscar_familiares()
                        Me.Visible = False
                    End If
                Case Else
                    MsgBox("No se ha determinado donde se deben colocar los datos", vbInformation + vbSystemModal, "Ayuda del sistema")
                    Me.Close()
            End Select
            'Me.Visible = False
        Else
            Mostrar_informacion("inf", "Observación", "Debe seleccionar de la lista el nombre de una persona", True, 3000, Lista_abrir_paciente, "exc")
        End If
    End Sub

    Private Sub Txt_busca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_busca.TextChanged
        Informativo_por_codigo.Dispose()
    End Sub

    Private Sub cmb_opcn_busca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_opcn_busca.SelectedIndexChanged
        Informativo_por_codigo.Dispose()
        Txt_busca.Focus()
    End Sub
End Class
