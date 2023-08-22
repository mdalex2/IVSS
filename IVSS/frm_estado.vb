Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class frm_estados
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Public KeyAscii As Short
    Dim Consulta_SQL, Var_cod_estado, Var_cod_ciudad, Var_cod_nac As String
    Dim modif_estado As Boolean = False
    Dim modif_ciudad As Boolean = False
    Dim modif_nac As Boolean = False
    Private Sub frm_estados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado
        'Buscar()
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_form_estado.png")
        Buscar_estado()
        Buscar_nacionalidad()
        If Not IsNothing(MyListItem) Then
            MyListItem.ListView.Clear()
        End If
        Buscar_nacionalidad()
    End Sub

    Private Sub Buscar_estado()

        Consulta_SQL = "SELECT * FROM estado_territorial WHERE cod_edo_ter like '%" & txt_cod_estado.Text & "%' AND edo_territorial  like '%" & txt_nombre_estado.Text & "%'"
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            ConectarBD()
            'la consultaSQL la almacené en el evento clic del boton
            comando.CommandText = Consulta_SQL
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            lv_estado.Clear()
            If dr.HasRows Then

                lv_estado.View = View.Details 'importante para que los datos se vean como lista
                '.....Agrego Los Titulos a el listview y tamaño de columnas
                lv_estado.Columns.Add("Código", 100, HorizontalAlignment.Left)
                lv_estado.Columns.Add("Estado", 200, HorizontalAlignment.Left)
                lv_estado.Columns.Add("estatus-valor", 200, HorizontalAlignment.Left)
                lv_estado.Columns.Add("Estatus", 200, HorizontalAlignment.Left)
                While dr.Read()
                    '...Agrego al listview la data de la consulta efectuada
                    MyListText(0) = dr("cod_edo_ter")
                    MyListText(1) = dr("edo_territorial")
                    MyListText(2) = dr("visible")
                    If dr("VISIBLE") = True Then
                        MyListText(3) = "ACTIVO"
                    Else
                        MyListText(3) = "DESHABILITADO"
                    End If
                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list
                    lv_estado.Items.Add(MyListItem)
                End While
                Ajustar_tamaño_listas(lv_estado)
                lv_estado.Columns(0).Width = 0
                lv_estado.Columns(2).Width = 0


                'SELECCIONO LA LISTA PARA EVITAR VALORE SNULOS
                lv_estado.Items(0).Selected = True
                lv_estado.Focus()

            Else
                MsgBox("No se encontró el registro de estados", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If

            dr.Close()
            myCloneCon.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_estado", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_estado", Err.Number, ex.Message)

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
    Private Sub Buscar_ciudad()
        Try
            ConectarBD()
            'la consultaSQL la almacené en el evento clic del boton
            Consulta_SQL = "SELECT * FROM ciudades WHERE cod_edo_ter = '" & txt_cod_estado.Text & "' AND nombre_ciudad  like '%" & txt_nombre_ciudad.Text & "%'"
            Dim comando As New MySqlCommand(Consulta_SQL, myCloneCon)
            Dim dr As MySqlDataReader 'dr=data reader
            dr = comando.ExecuteReader()
            lv_ciudades.Clear()
            If dr.HasRows Then
                lv_ciudades.View = View.Details 'importante para que los datos se vean como lista
                '.....Agrego Los Titulos a el listview y tamaño de columnas
                lv_ciudades.Columns.Add("Código", 100, HorizontalAlignment.Left)
                lv_ciudades.Columns.Add("Ciudad", 200, HorizontalAlignment.Left)
                lv_ciudades.Columns.Add("Cod-estado-territorial", 200, HorizontalAlignment.Left)
                lv_ciudades.Columns.Add("Visible", 200, HorizontalAlignment.Left)
                lv_ciudades.Columns.Add("Estatus", 200, HorizontalAlignment.Left)
                While dr.Read()
                    '...Agrego al listview la data de la consulta efectuada
                    MyListText(0) = dr("cod_ciudad")
                    MyListText(1) = dr("nombre_ciudad")
                    MyListText(2) = dr("cod_edo_ter")
                    MyListText(3) = dr("visible")
                    If dr("VISIBLE") = True Then
                        MyListText(4) = "ACTIVO"
                    Else
                        MyListText(4) = "DESHABILITADO"
                    End If
                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list
                    lv_ciudades.Items.Add(MyListItem)

                End While
                Ajustar_tamaño_listas(lv_ciudades)
                lv_ciudades.Columns(0).Width = 0
                lv_ciudades.Columns(2).Width = 0
                lv_ciudades.Columns(3).Width = 0


                'SELECCIONO LA LISTA PARA EVITAR VALORE SNULOS
                lv_ciudades.Items(0).Selected = True
                lv_ciudades.Focus()
                btn_ciud_elim.Enabled = True
                btn_ciud_guardar.Enabled = True
            Else

                Mostrar_informacion("inf", "Notificación", "No se encontaron ciudades para el estado seleccionado", True, 2500, lv_ciudades, "exc")
            End If

            dr.Close()
            myCloneCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message & Err.Number, vbSystemModal + vbExclamation, "Ayuda del sistema del modulo buscar ciudades")
        End Try
    End Sub
    Private Sub Buscar_nacionalidad()
        Try
            ConectarBD()
            'la consultaSQL la almacené en el evento clic del boton
            Consulta_SQL = "SELECT * FROM nacionalidades WHERE cod_nacionalidad like '%" & txt_cod_nac.Text & "%' AND nacionalidad  like '%" & txt_nacionalidad.Text & "%'"
            Dim comando As New MySqlCommand(Consulta_SQL, myCloneCon)
            Dim dr As MySqlDataReader 'dr=data reader
            dr = comando.ExecuteReader()
            Lista_nacionalidades.Clear()
            If dr.HasRows Then

                Lista_nacionalidades.View = View.Details 'importante para que los datos se vean como lista
                '.....Agrego Los Titulos a el listview y tamaño de columnas
                Lista_nacionalidades.Columns.Add("Código", 100, HorizontalAlignment.Left)
                Lista_nacionalidades.Columns.Add("Nacionalidad", 200, HorizontalAlignment.Left)
                Lista_nacionalidades.Columns.Add("estatus-valor", 200, HorizontalAlignment.Left)
                Lista_nacionalidades.Columns.Add("Estatus", 200, HorizontalAlignment.Left)
                While dr.Read()
                    '...Agrego al listview la data de la consulta efectuada
                    MyListText(0) = dr("cod_nacionalidad")
                    MyListText(1) = dr("nacionalidad")
                    MyListText(2) = dr("visible")
                    If dr("VISIBLE") = True Then
                        MyListText(3) = "ACTIVO"
                    Else
                        MyListText(3) = "DESHABILITADO"
                    End If
                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list
                    Lista_nacionalidades.Items.Add(MyListItem)




                End While
                'SELECCIONO LA LISTA PARA EVITAR VALORE SNULOS
                Lista_nacionalidades.Items(0).Selected = True
                Lista_nacionalidades.Focus()
                Ajustar_tamaño_listas(Lista_nacionalidades)
                Lista_nacionalidades.Columns(0).Width = 0
                Lista_nacionalidades.Columns(2).Width = 0
            Else
                MsgBox("No se encontró la nacionalidad", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If

            dr.Close()
            myCloneCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message & Err.Number, vbSystemModal + vbExclamation, "Ayuda del sistema del modulo buscar estados")
        End Try
    End Sub


    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub lv_estado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_estado.SelectedIndexChanged
        If lv_estado.SelectedItems.Count > 0 Then
            txt_cod_estado.Text = lv_estado.SelectedItems(0).SubItems(0).Text
            Var_cod_estado = lv_estado.SelectedItems(0).SubItems(0).Text
            txt_nombre_estado.Text = lv_estado.SelectedItems(0).SubItems(1).Text
            chk_estado_visible.Checked = lv_estado.SelectedItems(0).SubItems(2).Text
            txt_cod_ciudad.Text = ""
            txt_nombre_ciudad.Text = ""
            btn_estado_guardar.Enabled = True
            btn_estado_guardar.Text = "&Modificar"
            btn_est_eliminar.Enabled = True
            modif_estado = True
            Informativo_por_codigo.Dispose()
            btn_ciud_elim.Enabled = False
            btn_ciud_guardar.Enabled = False
            Var_cod_ciudad = ""
            Buscar_ciudad()
        End If
    End Sub

    Private Sub btn_ciudad_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ciudad_buscar.Click
        Buscar_ciudad()
    End Sub

    Private Sub lv_ciudades_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lv_ciudades.SelectedIndexChanged
        If lv_ciudades.SelectedItems.Count > 0 Then
            txt_cod_ciudad.Text = lv_ciudades.SelectedItems(0).SubItems(0).Text
            Var_cod_ciudad = lv_ciudades.SelectedItems(0).SubItems(0).Text
            txt_nombre_ciudad.Text = lv_ciudades.SelectedItems(0).SubItems(1).Text
            chk_ciudad_visible.Checked = lv_ciudades.SelectedItems(0).SubItems(3).Text
            btn_ciud_elim.Enabled = True
            btn_ciud_guardar.Text = "&Modificar"
            btn_ciud_guardar.Enabled = True
            modif_ciudad = True
        End If
    End Sub

    Private Sub btn_est_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_nuevo.Click
        Limpiar_Controles(Grupo_Estados)
        txt_cod_estado.Focus()
        chk_estado_visible.Checked = True
        btn_estado_guardar.Enabled = False
        btn_estado_guardar.Text = "&Agregar"
        btn_est_eliminar.Enabled = False
        modif_estado = False
    End Sub

    Private Sub btn_busca_estado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_busca_estado.Click
        Buscar_estado()
    End Sub

    Private Sub btn_ciud_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ciud_nuevo.Click
        Limpiar_Controles(Grupo_Ciudad)
        txt_cod_ciudad.Focus()
        chk_ciudad_visible.Checked = True
        btn_ciud_elim.Enabled = False
        btn_ciud_guardar.Text = "&Agregar"
        btn_ciud_guardar.Enabled = False
        modif_ciudad = False
    End Sub
    Private Sub Archivar_estados()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Dim Reg_afectados As Double
        Try
            If modif_estado = False Then
                sql_str = "INSERT INTO estado_territorial (cod_edo_ter, edo_territorial,visible) values ('" & _
                txt_cod_estado.Text & "','" & _
                txt_nombre_estado.Text & "'," & _
                chk_estado_visible.Checked & ")"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                MsgBox("Los datos del estado " & Chr(34) & txt_cod_estado.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                modif_estado = True
                Var_cod_estado = txt_cod_estado.Text
                'activo los botones de reporte y eliminar
                btn_est_eliminar.Enabled = True
                btn_estado_guardar.Text = "&Modificar"
                Limpiar_Controles(Grupo_Estados)
                Buscar_estado()
            Else
                sql_str = "update estado_territorial set " & _
                "cod_edo_ter='" & txt_cod_estado.Text & "'," & _
                "edo_territorial='" & txt_nombre_estado.Text & "'," & _
                "visible=" & chk_estado_visible.Checked & _
                " where cod_edo_ter='" & Var_cod_estado & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()
                modif_estado = True
                Var_cod_estado = txt_cod_estado.Text
                MsgBox("Los datos del estado " & Chr(34) & txt_nombre_estado.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                modif_estado = True
                Var_cod_estado = txt_cod_estado.Text
                'activo los botones de reporte y eliminar
                btn_est_eliminar.Enabled = True
                btn_estado_guardar.Text = "&Modificar"
                Limpiar_Controles(Grupo_Estados)
                Buscar_estado()
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar_estados", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_estados", Err.Number, ex.Message)

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

    Private Sub btn_estado_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estado_guardar.Click
        Archivar_estados()
    End Sub

    Private Sub txt_cod_estado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_estado.TextChanged
        Verifica_activar_textos()
    End Sub
    Private Sub Verifica_activar_textos()
        If txt_cod_estado.Text <> "" And txt_nombre_estado.Text <> "" Then
            btn_estado_guardar.Enabled = True
        Else
            btn_estado_guardar.Enabled = False
        End If
    End Sub
    Private Sub Verifica_activar_textos_Ciudad()
        If txt_cod_estado.Text <> "" And txt_nombre_estado.Text <> "" Then
            btn_ciud_guardar.Enabled = True
        Else
            btn_ciud_guardar.Enabled = False
        End If
    End Sub

    Private Sub txt_nombre_estado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre_estado.TextChanged
        Verifica_activar_textos()
    End Sub

    Private Sub btn_est_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_eliminar.Click
        Eliminar_generico("estado_territorial", "cod_edo_ter", "texto", Var_cod_estado, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Grupo_Estados)
            Limpiar_Controles(lv_estado)
            Buscar_estado()
        End If
    End Sub

    Private Sub btn_ciud_elim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ciud_elim.Click
        Eliminar_generico("ciudades", "cod_ciudad", "texto", Var_cod_ciudad, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Grupo_Estados)
            Limpiar_Controles(lv_estado)
            Buscar_estado()
        End If
    End Sub
    Private Sub Archivar_ciudades()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Dim Reg_afectados As Double
        Try
            If modif_ciudad = False Then
                sql_str = "INSERT INTO ciudades (cod_ciudad,cod_edo_ter,nombre_ciudad,visible ) values ('" & _
                txt_cod_ciudad.Text & "','" & _
                Var_cod_estado & "','" & _
                txt_nombre_ciudad.Text & "'," & _
                chk_ciudad_visible.Checked & ")"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                MsgBox("Los datos de la ciudad " & Chr(34) & txt_nombre_ciudad.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                modif_ciudad = True
                Var_cod_ciudad = txt_cod_ciudad.Text
                'activo los botones de reporte y eliminar
                btn_ciud_elim.Enabled = True
                btn_ciud_guardar.Text = "&Modificar"
                Limpiar_Controles(Grupo_Ciudad)
                Buscar_ciudad()
            Else
                sql_str = "update ciudades set " & _
                "cod_ciudad='" & txt_cod_ciudad.Text & "'," & _
                "cod_edo_ter='" & Var_cod_estado & "'," & _
                "nombre_ciudad='" & txt_nombre_ciudad.Text & "'," & _
                "visible=" & chk_ciudad_visible.Checked & _
                " where cod_ciudad='" & Var_cod_ciudad & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()
                modif_ciudad = True
                Var_cod_ciudad = txt_cod_ciudad.Text
                MsgBox("Los datos de la ciudad " & Chr(34) & txt_nombre_ciudad.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                modif_ciudad = True
                Var_cod_ciudad = txt_cod_ciudad.Text
                'activo los botones de reporte y eliminar
                btn_ciud_elim.Enabled = True
                btn_ciud_guardar.Text = "&Modificar"
                Limpiar_Controles(Grupo_Ciudad)
                Buscar_ciudad()
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar_ciudades", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_ciudades", Err.Number, ex.Message)

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

    Private Sub txt_cod_ciudad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_ciudad.TextChanged
        Verifica_activar_textos_Ciudad()
    End Sub

    Private Sub txt_nombre_ciudad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre_ciudad.TextChanged
        Verifica_activar_textos_Ciudad()
    End Sub

    Private Sub btn_ciud_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ciud_guardar.Click
        Archivar_ciudades()
    End Sub

    Private Sub btn_nuevo_nac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo_nac.Click
        Limpiar_Controles(Grupo_nacionalidades)
        btn_archivar_nac.Text = "&Agregar"
        btn_archivar_nac.Enabled = False
        btn_elim_nac.Enabled = False
        modif_nac = False
        chk_nac_visible.Checked = True
        txt_cod_nac.Focus()
    End Sub

    Private Sub Lista_nacionalidades_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_nacionalidades.SelectedIndexChanged
        If Lista_nacionalidades.SelectedItems.Count > 0 Then
            txt_cod_nac.Text = Lista_nacionalidades.SelectedItems(0).SubItems(0).Text
            Var_cod_nac = Lista_nacionalidades.SelectedItems(0).SubItems(0).Text
            txt_nacionalidad.Text = Lista_nacionalidades.SelectedItems(0).SubItems(1).Text
            chk_nac_visible.Checked = Lista_nacionalidades.SelectedItems(0).SubItems(2).Text
            btn_archivar_nac.Text = "&Modifica"
            btn_archivar_nac.Enabled = True
            btn_elim_nac.Enabled = True
            modif_nac = True
        End If

    End Sub

    Private Sub btn_buscar_nac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar_nac.Click
        Buscar_nacionalidad()
    End Sub

    Private Sub txt_cod_nac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_nac.TextChanged
        Activar_boton_guarda()
    End Sub
    Private Sub Activar_boton_guarda()
        If txt_cod_nac.Text <> "" And txt_nacionalidad.Text <> "" Then
            btn_archivar_nac.Enabled = True
        End If
    End Sub

    Private Sub txt_nacionalidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nacionalidad.TextChanged
        Activar_boton_guarda()
    End Sub
    Private Sub Archivar_nacionalidad()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Dim Reg_afectados As Double
        Try
            If modif_nac = False Then
                sql_str = "INSERT INTO nacionalidades (cod_nacionalidad, nacionalidad,visible) values ('" & _
                txt_cod_nac.Text & "','" & _
                txt_nacionalidad.Text & "'," & _
                chk_nac_visible.Checked & ")"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                Mostrar_informacion("inf", "Notificación", "Los datos de la nacionalidad " & Chr(34) & txt_nacionalidad.Text & Chr(34) & " se archivaron correctamente", True, 2500, Lista_nacionalidades, "inf")
                'MsgBox("Los datos de la nacionalidad " & Chr(34) & txt_nacionalidad.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                modif_nac = True
                Var_cod_nac = txt_cod_nac.Text
                'activo los botones de reporte y eliminar
                btn_elim_nac.Enabled = True
                btn_archivar_nac.Text = "&Modificar"
                Limpiar_Controles(Grupo_nacionalidades)
                Buscar_nacionalidad()
            Else
                sql_str = "update nacionalidades set " & _
                "cod_nacionalidad='" & txt_cod_nac.Text & "'," & _
                "nacionalidad='" & txt_nacionalidad.Text & "'," & _
                "visible=" & chk_nac_visible.Checked & _
                " where cod_nacionalidad='" & Var_cod_nac & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()
                modif_nac = True
                Var_cod_nac = txt_cod_nac.Text
                Mostrar_informacion("inf", "Notificación", "Los datos de la nacionalidad " & Chr(34) & txt_nacionalidad.Text & Chr(34) & " se modificaron correctamente", True, 2500, Lista_nacionalidades, "inf")
                'MsgBox("Los datos de la nacionalidad " & Chr(34) & txt_nacionalidad.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                modif_nac = True
                Var_cod_nac = txt_cod_nac.Text
                'activo los botones de reporte y eliminar
                btn_elim_nac.Enabled = True
                btn_archivar_nac.Text = "&Modificar"
                Limpiar_Controles(Grupo_nacionalidades)
                Buscar_nacionalidad()
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar_nacionalidad", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_nacionalidad", Err.Number, ex.Message)

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

    Private Sub btn_archivar_nac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_archivar_nac.Click
        Archivar_nacionalidad()
    End Sub

    Private Sub btn_elim_nac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_elim_nac.Click
        Eliminar_generico("nacionalidades", "cod_nacionalidad", "texto", Var_cod_nac, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Nacionalidades)
            Buscar_nacionalidad()
        End If

    End Sub

    Private Sub Pic_Encabezado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_Encabezado.Click

    End Sub
End Class