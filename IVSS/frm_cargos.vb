Imports MySql.Data.MySqlClient
Public Class frm_cargos
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim Modificar As Boolean = False
    Dim Var_cod_cargo As String = ""
    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub
    Private Sub Buscar_cargo()
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            If chk_mostrar_inactivos.Checked = True Then
                comando.CommandText = "SELECT cargos.*, datos_personales.nombres,datos_personales.apellidos FROM (cargos inner join datos_personales on datos_personales.id_num_historia=cargos.guardado_por) where descrip_Cargo like '%" & txt_busca.Text & "%' order by descrip_Cargo"
            Else
                comando.CommandText = "SELECT cargos.*, datos_personales.nombres,datos_personales.apellidos FROM (cargos inner join datos_personales on datos_personales.id_num_historia=cargos.guardado_por) where descrip_Cargo like '%" & txt_busca.Text & "%' and cargos.visible=1 order by descrip_Cargo"
            End If
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()

            If dr.HasRows Then
                'limpio la lista y agrego encabezados
                Lista_buscar.Clear()
                Lista_buscar.View = View.Details 'importante para que los datos se vean como lista
                Lista_buscar.Columns.Add("Código", 100, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Cargo", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Notas / Observaciones", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Grado", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Visible", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Estado", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Usuario", 200, HorizontalAlignment.Left)
                'agrego a la lista todo
                While dr.Read()
                    MyListText(0) = dr("cod_cargo")
                    MyListText(1) = dr("descrip_cargo")
                    MyListText(2) = dr("notas")
                    MyListText(3) = dr("grado")
                    MyListText(4) = dr("visible")
                    If dr("visible") = True Then
                        MyListText(5) = "ACTIVO"
                    Else
                        MyListText(5) = "DESHABILITADO"
                    End If
                    MyListText(6) = UCase("USUARIO: " & dr("nombres") & " " & dr("apellidos") & vbCrLf & FormatDateTime(dr("fecha_g"), DateFormat.GeneralDate).ToString)

                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list
                    Lista_buscar.Items.Add(MyListItem)

                End While
                Quitar_tamaño_listas(Me.Lista_buscar)
                Lista_buscar.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
                Lista_buscar.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent)

                'lista_buscar.Items(0).Selected = True
                'lista_buscar.Focus()
            Else
                MsgBox("No se encontró el cargo", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
                Informativo.SetToolTip(btn_buscar, "Buscar el cargo")
                btn_buscar.Tag = 0
                btn_buscar.ImageIndex = 0
                txt_busca.Focus()
            End If
            dr.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_cargo", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_cargo", Err.Number, ex.Message)
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

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        If btn_buscar.Tag = 0 Then 'si es buscar
            Informativo.SetToolTip(btn_buscar, "Quitar filtro de busqueda")
            btn_buscar.Tag = 1
            btn_buscar.ImageIndex = 1
            Buscar_cargo()
        Else 'si es quitar filtro de busqueda
            txt_busca.Text = ""
            txt_busca.Focus()
            Informativo.SetToolTip(btn_buscar, "Buscar el cargo")
            btn_buscar.Tag = 0
            btn_buscar.ImageIndex = 0
            Buscar_cargo()
        End If
    End Sub

    Private Sub btn_archivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_archivar.Click
        Archivar()
    End Sub
    Private Sub Archivar()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Dim Reg_afectados As Double
        Try
            If Modificar = False Then
                sql_str = "INSERT INTO cargos (cod_cargo,descrip_cargo,grado,Notas,guardado_por,fecha_g,visible) values ('" & _
                txt_codigo.Text & "','" & _
                txt_cargo.Text & "'," & _
                txt_grado.Value & ",'" & _
                txt_notas_observ.Text & "','" & _
                Cod_usuario & "','" & _
                Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," & _
                chk_activo.Checked & ")"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
                MsgBox("Los datos del descrip_Cargo " & Chr(34) & txt_cargo.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                Modificar = True
                Var_cod_cargo = txt_codigo.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                txt_busca.Text = ""
                Buscar_cargo()
            Else
                sql_str = "update cargos set " & _
                "cod_cargo='" & txt_codigo.Text & "'," & _
                "descrip_Cargo='" & txt_cargo.Text & "'," & _
                "grado=" & txt_grado.Value & "," & _
                "notas='" & txt_notas_observ.Text & "'," & _
                "visible=" & chk_activo.Checked & "," & _
                "guardado_por='" & Cod_usuario & "'," & _
                "fecha_g='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'" & _
                " where cod_cargo='" & Var_cod_cargo & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()

                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se modificaron correctamente", True, 2500, lista_buscar, "inf")
                MsgBox("Los datos del cargo " & Chr(34) & txt_cargo.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                Modificar = True
                Var_cod_cargo = txt_codigo.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                Limpiar_Controles(Lista_buscar)
                txt_busca.Text = ""
                Buscar_cargo()
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
    Private Sub btn_nueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nueva.Click
        nuevo_documento()
    End Sub
    Private Sub nuevo_documento()
        Limpiar_Controles(Grupo_cargos)
        Modificar = False
        Mostrar_informacion("inf", "Instrucciones:", "Rellene todos los campos y presione el botón archivar", True, 3500, txt_codigo, "inf")
        txt_codigo.Focus()
        chk_activo.Checked = True
        Informativo.SetToolTip(btn_buscar, "Buscar el cargo")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0

    End Sub
    Private Sub txt_cod_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        On Error Resume Next
        Informativo_por_codigo.Dispose()
    End Sub

    Private Sub txt_busca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_busca.TextChanged
        Informativo.SetToolTip(btn_buscar, "Buscar el cargo")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
    End Sub
    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Eliminar_generico("cargos", "cod_cargo ", "texto", Var_cod_cargo, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Me)
            Buscar_cargo()
        End If
    End Sub

    Private Sub frm_tipo_doc_descrip_Cargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo

        'Buscar()
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_cargos.png")
        If Not IsNothing(MyListItem) Then
            MyListItem.ListView.Clear()
        End If

    End Sub

    Private Sub chk_ocultar_inactivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mostrar_inactivos.CheckedChanged
        Buscar_cargo()
    End Sub

    Private Sub Lista_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_buscar.SelectedIndexChanged
        If Lista_buscar.SelectedItems.Count > 0 Then
            Limpiar_Controles(Grupo_cargos)
            txt_codigo.Text = Lista_buscar.SelectedItems(0).SubItems(0).Text
            txt_cargo.Text = Lista_buscar.SelectedItems(0).SubItems(1).Text
            txt_notas_observ.Text = Lista_buscar.SelectedItems(0).SubItems(2).Text
            txt_grado.Value = Val(Lista_buscar.SelectedItems(0).SubItems(3).Text)
            chk_activo.Checked = CBool(Lista_buscar.SelectedItems(0).SubItems(4).Text)
            Modificar = True
            Var_cod_cargo = Lista_buscar.SelectedItems(0).SubItems(0).Text
            lbl_guardado_por.Text = Lista_buscar.SelectedItems(0).SubItems(6).Text
            Mostrar_informacion("inf", "Modo de edición", "Si lo desea cambie los datos, " & vbCrLf & "luego presione archivar para modificarlos", True, 4000, txt_cargo, "inf")
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
End Class