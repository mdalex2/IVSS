Imports MySql.Data.MySqlClient
Public Class frm_usuarios
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim Modificar As Boolean = False
    Dim var_num_historia As String = ""
    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub


    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        nuevo_usuario()
    End Sub
    Private Sub Archivar()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Try
            If Modificar = False Then
                sql_str = "INSERT INTO usuarios (num_historia,nombre_usuario,clave,activo,tipo_cuenta,notas,guardado_por,fecha_g) values ('" & _
                lbl_num_hist.Text & "','" & _
                txt_login.Text & "',aes_encrypt('" & _
                 txt_clave.Text & "','" & LLave_AES & "')," & _
                 chk_activo.Checked & ",'" & _
                 cmb_tipo_cuenta.Text & "','" & _
                 txt_notas_observ.Text & "','" & _
                 Cod_usuario & "','" & _
                Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"

                comando.CommandText = sql_str
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
                MsgBox("El usuario se creó con exito", vbInformation, "Notificación")
                Modificar = True
                var_num_historia = lbl_num_hist.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
            Else
                If chk_modifica_clave.Checked = True Then
                    sql_str = "update usuarios set " & _
                        "nombre_usuario='" & txt_login.Text & "'," & _
                        "Clave=aes_encrypt('" & txt_clave.Text & "','" & LLave_AES & "')," & _
                        "notas='" & txt_notas_observ.Text & "'," & _
                        "tipo_cuenta='" & cmb_tipo_cuenta.Text & "'," & _
                        "activo=" & chk_activo.Checked & "," & _
                        "guardado_por='" & Cod_usuario & "'," & _
                        "fecha_g='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'" & _
                        " where num_historia='" & var_num_historia & "'"
                Else
                    sql_str = "update usuarios set " & _
                        "nombre_usuario='" & txt_login.Text & "'," & _
                        "notas='" & txt_notas_observ.Text & "'," & _
                        "tipo_cuenta='" & cmb_tipo_cuenta.Text & "'," & _
                        "activo=" & chk_activo.Checked & "," & _
                        "guardado_por='" & Cod_usuario & "'," & _
                        "fecha_g='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'" & _
                        " where num_historia='" & var_num_historia & "'"
                End If
                comando.CommandText = sql_str
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()

                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se modificaron correctamente", True, 2500, lista_buscar, "inf")
                MsgBox("Los datos del usuario " & Chr(34) & lbl_usuario.Text & " se modificaron correctamente", vbInformation, "Notificación")
                'activo los botones de accion
                Modificar = True
                var_num_historia = lbl_num_hist.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar _Cargo", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_Cargo", Err.Number, ex.Message)
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
    Private Sub txt_cod_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        Informativo_por_codigo.Dispose()
    End Sub

    Private Sub txt_busca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Informativo.SetToolTip(btn_buscar, "Buscar el cargo")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
    End Sub
    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Eliminar_generico("cargos", "cod_cargo ", "texto", var_num_historia, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Me)
        End If
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE CARGOS", "listado de cargos.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub Grupo_cargos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grupo_cargos.Enter

    End Sub
    Private Sub nuevo_usuario()
        Limpiar_Controles(Me)
        Destino = "frm_usuarios"
        Mostrar_formulario(frm_abrir_datos_paciente, True)
    End Sub
    Private Sub btn_nueva_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nueva.Click
        nuevo_usuario()
    End Sub
    Public Sub Buscar_usuario()
        Dim comando As New MySqlCommand
        Try
            Cant_Reg = 0
            Modificar = False
            Informativo_por_codigo.Dispose()
            comando.CommandText = "SELECT usuarios.*,datos_personales.nombres,datos_personales.apellidos FROM (usuarios inner join datos_personales on usuarios.num_historia=datos_personales.num_historia) where usuarios.num_historia ='" & lbl_num_hist.Text & "'"
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    Cant_Reg = Cant_Reg + 1
                    '...Agrego al listview la data de la consulta efectuada
                    txt_login.Text = dr("nombre_usuario")
                    txt_clave.Text = dr("clave").ToString
                    txt_notas_observ.Text = dr("notas")
                    chk_activo.Checked = dr("activo")
                    cmb_tipo_cuenta.Text = dr("tipo_cuenta")
                    Dim fecha_guardado As Date = dr("FECHA_G")
                    lbl_guardado_por.Text = "GUARDADO POR: " & UCase(dr("NOMBRES")) & " " & UCase(dr("APELLIDOS")) & _
                        " EL DÍA " & UCase(fecha_guardado.ToString("dddd, dd-MMMM-yyyy hh:mm:ss tt"))
                    chk_modifica_clave.Checked = False
                    Modificar = True
                    var_num_historia = lbl_num_hist.Text
                    Mostrar_informacion("inf", "Modo de edición", "Modifique los campos y presione el botón archivar", True, 3500, txt_login, "inf")
                    Exit While
                End While
                dr.Close()
            Else
                chk_modifica_clave.Checked = True
                chk_activo.Checked = True
                Mostrar_informacion("inf", "Instrucciones", "Rellene los campos y presione el botón archivar", True, 3500, txt_login, "inf")
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_usuario", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_usuario", Err.Number, ex.Message)
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

    Private Sub btn_archivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_archivar.Click
        Archivar()
    End Sub

    Private Sub frm_usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo

        'Buscar()
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\icono_frm_usuarios.png")
        If Not IsNothing(MyListItem) Then
            MyListItem.ListView.Clear()
        End If
    End Sub

    Private Sub btn_eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Eliminar_generico("usuarios", "num_historia", "texto", lbl_num_hist.Text, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Me)
            MsgBox("Registro eliminado", vbInformation + vbSystemModal, "Ayuda del sistema")
        End If
    End Sub
End Class