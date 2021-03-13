Imports MySql.Data.MySqlClient
Public Class frm_asig_familiares
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim var_cod_familiar As String
    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub frm_asig_familiares_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar_Controles(Grupo_familiar)
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo

        'Buscar()
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\frm_asig_familiares.png")
        'If Not IsNothing(MyListItem) Then
        '    MyListItem.ListView.Clear()
        'End If
        Llenar_combo_con_BD(Me.cmb_afinidad, "cod_afinidad", "afinidad", "afinidades", True, "afinidad")
        Buscar_familiares()
    End Sub
    Public Sub Buscar_familiares()
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            comando.CommandText = "SELECT familiares.*, datos_personales.nombres,datos_personales.apellidos,afinidades.afinidad FROM (familiares inner join datos_personales on datos_personales.num_historia=familiares.cod_familiar inner join afinidades on afinidades.cod_afinidad=familiares.cod_afinidad) where familiares.num_historia='" & lbl_num_hist_paciente.Text & "' order by datos_personales.nombres,datos_personales.apellidos"
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            Lista_buscar.Clear()

            'limpio la lista y agrego encabezados
            Lista_buscar.View = View.Details 'importante para que los datos se vean como lista
            Lista_buscar.Columns.Add("NOMBRES Y APELLIDOS", 100, HorizontalAlignment.Left)
            Lista_buscar.Columns.Add("PARENTESCO", 200, HorizontalAlignment.Left)
            Lista_buscar.Columns.Add("BENEFICIARIO", 200, HorizontalAlignment.Left)
            Lista_buscar.Columns.Add("Nº HISTORIA", 200, HorizontalAlignment.Left)


            If dr.HasRows Then


                'agrego a la lista todo
                While dr.Read()
                    MyListText(0) = UCase(dr("nombres") & " " & dr("apellidos"))
                    MyListText(1) = dr("afinidad")
                    If dr("beneficiario") = True Then
                        MyListText(2) = "SI"
                    Else
                        MyListText(2) = "NO"
                    End If

                    MyListText(3) = dr("cod_familiar")
                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list

                    Lista_buscar.Items.Add(MyListItem)
                    Dim item_principal As New ListViewItem
                End While

                Ajustar_tamaño_listas(Me.Lista_buscar)
                Lista_buscar.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize)

                'limpio la lista y agrego encabezados
                Frm_menu.Lista_HM_fam_datos_pers.Clear()
                Frm_menu.Lista_HM_fam_datos_pers.View = View.Details 'importante para que los datos se vean como lista
                Frm_menu.Lista_HM_fam_datos_pers.Columns.Add("NOMBRES Y APELLIDOS", 100, HorizontalAlignment.Left)
                Frm_menu.Lista_HM_fam_datos_pers.Columns.Add("PARENTESCO", 200, HorizontalAlignment.Left)
                Frm_menu.Lista_HM_fam_datos_pers.Columns.Add("BENEFICIARIO", 200, HorizontalAlignment.Left)
                Frm_menu.Lista_HM_fam_datos_pers.Columns.Add("Nº HISTORIA", 200, HorizontalAlignment.Left)

                For i = 0 To Lista_buscar.Items.Count - 1
                    Dim item As New ListViewItem
                    item = Lista_buscar.Items(i).Clone
                    Frm_menu.Lista_HM_fam_datos_pers.Items.Add(item)
                Next
                Ajustar_tamaño_listas(Frm_menu.Lista_HM_fam_datos_pers)
                Frm_menu.Lista_HM_fam_datos_pers.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize)
                'Lista_buscar.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent)
                'lista_buscar.Items(0).Selected = True
                'lista_buscar.Focus()
            Else
                Frm_menu.Lista_HM_fam_datos_pers.Clear()
                'MsgBox("No se encontró el area", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If
            dr.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_familiares", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_familiares", Err.Number, ex.Message)
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

    Private Sub Archivar_asignacion()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Try
            sql_str = "INSERT INTO familiares (num_historia,cod_familiar,cod_afinidad,beneficiario,guardado_por,fecha_g) values ('" & _
                lbl_num_hist_paciente.Text & "','" & _
                lbl_num_hist_familiar.Text & "','" & _
                cmb_afinidad.SelectedValue & "'," & _
                chk_beneficiario.Checked & ",'" & _
                Cod_usuario & "','" & _
                Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"

            comando.CommandText = UCase(sql_str)
            ConectarBD()
            comando.Connection = myCloneCon
            comando.ExecuteReader()
            'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
            MsgBox("Los datos del familiar se guardaron correctamente", vbInformation, "Notificación")
            btn_eliminar.Enabled = True
            Limpiar_Controles(Grupo_familiar)
            Buscar_familiares()


        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar_asignacion", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_asignacion", Err.Number, ex.Message)

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

    Private Sub btn_nueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nueva.Click
        Destino = "frm_asig_familiares"
        Mostrar_formulario(frm_abrir_datos_paciente, True)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_asignar.Click
        If lbl_num_hist_familiar.Text = "" Then
            Mostrar_informacion("inf", "Observación:", "Debe seleccionar un familiar, presione el botón nuevo y asigne un familiar", True, 4000, lbl_num_hist_familiar, "inf")
            Exit Sub
        End If
        If IsNothing(cmb_afinidad.SelectedValue) Or cmb_afinidad.SelectedValue = "" Then
            Mostrar_informacion("inf", "Observación:", "Debe seleccionar el grado de parentesco del familiar", True, 4000, cmb_afinidad, "inf")
            Exit Sub
        End If
        Archivar_asignacion()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Buscar_familiares()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Eliminar_generico("familiares", "cod_familiar", "texto", var_cod_familiar, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Grupo_familiar)
            Buscar_familiares()
        End If
    End Sub

    Private Sub Lista_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_buscar.SelectedIndexChanged
        If Not IsNothing(Lista_buscar.FocusedItem.Text) Then
            var_cod_familiar = Lista_buscar.FocusedItem.SubItems(3).Text
        End If
    End Sub
End Class