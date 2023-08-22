Imports MySql.Data.MySqlClient
Public Class frm_departamentos
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim Modificar As Boolean = False
    Dim Var_cod_dep As String = ""
    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub
    Private Sub Buscar_departamento()
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            If chk_mostrar_inactivos.Checked = True Then
                comando.CommandText = "SELECT Departamentos.*, datos_personales.nombres,datos_personales.apellidos FROM (departamentos inner join datos_personales on datos_personales.num_historia=departamentos.guardado_por) where departamento like '%" & txt_busca.Text & "%' order by departamento"
            Else
                comando.CommandText = "SELECT departamentos.*, datos_personales.nombres,datos_personales.apellidos FROM (departamentos inner join datos_personales on datos_personales.num_historia=departamentos.guardado_por) where departamento like '%" & txt_busca.Text & "%' and departamentos.visible=1 order by departamento"
            End If
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()

            If dr.HasRows Then
                'limpio la lista y agrego encabezados
                Lista_buscar.Clear()
                Lista_buscar.View = View.Details 'importante para que los datos se vean como lista
                Lista_buscar.Columns.Add("Código", 100, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("departamento", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Notas / Observaciones", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Visible", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Estado", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Usuario", 200, HorizontalAlignment.Left)
                'agrego a la lista todo
                While dr.Read()
                    MyListText(0) = dr("cod_dep")
                    MyListText(1) = dr("departamento")
                    MyListText(2) = dr("notas")
                    MyListText(3) = dr("visible")
                    If dr("visible") = True Then
                        MyListText(4) = "ACTIVO"
                    Else
                        MyListText(4) = "DESHABILITADO"
                    End If
                    MyListText(5) = UCase("USUARIO: " & dr("nombres") & " " & dr("apellidos") & vbCrLf & FormatDateTime(dr("fecha_g"), DateFormat.GeneralDate).ToString)

                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list
                    Lista_buscar.Items.Add(MyListItem)

                End While
                Quitar_tamaño_listas(Me.Lista_buscar)
                Lista_buscar.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
                Lista_buscar.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent)
                'lista_buscar.Items(0).Selected = True
                'lista_buscar.Focus()
            Else
                MsgBox("No se encontró el departamento", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
                Informativo.SetToolTip(btn_buscar, "Buscar el departamento")
                btn_buscar.Tag = 0
                btn_buscar.ImageIndex = 0
                txt_busca.Focus()
            End If
            dr.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_departamento", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_departamento", Err.Number, ex.Message)
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
            Buscar_departamento()
        Else 'si es quitar filtro de busqueda
            txt_busca.Text = ""
            txt_busca.Focus()
            Informativo.SetToolTip(btn_buscar, "Buscar el tipo de documento")
            btn_buscar.Tag = 0
            btn_buscar.ImageIndex = 0
            Buscar_departamento()
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
                sql_str = "INSERT INTO departamentos (cod_dep,departamento,notas,guardado_por,fecha_G, visible) values ('" & _
                txt_codigo.Text & "','" & _
                txt_departamento.Text & "','" & _
                txt_notas_observ.Text & "','" & _
                Cod_usuario & "','" & _
                Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," & _
                chk_activo.Checked & ")"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
                MsgBox("Los datos del departamento " & Chr(34) & txt_departamento.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                Modificar = True
                Var_cod_dep = txt_codigo.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                txt_busca.Text = ""
                Buscar_departamento()
            Else
                sql_str = "update departamentos set " & _
                "cod_dep='" & txt_codigo.Text & "'," & _
                "departamento='" & txt_departamento.Text & "'," & _
                "notas='" & txt_notas_observ.Text & "'," & _
                "visible=" & chk_activo.Checked & "," & _
                "guardado_por='" & Cod_usuario & "'," & _
                "fecha_g='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'" & _
                " where cod_dep='" & Var_cod_dep & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()

                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se modificaron correctamente", True, 2500, lista_buscar, "inf")
                MsgBox("Los datos del departamento " & Chr(34) & txt_departamento.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                Modificar = True
                Var_cod_dep = txt_codigo.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                Limpiar_Controles(Lista_buscar)
                txt_busca.Text = ""
                Buscar_departamento()
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar departamento", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar departamento", Err.Number, ex.Message)

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
        Limpiar_Controles(Grupo_departamento)
        Modificar = False
        Mostrar_informacion("inf", "Instrucciones:", "Rellene todos los campos y presione el botón archivar", True, 3500, txt_codigo, "inf")
        txt_codigo.Focus()
        chk_activo.Checked = True
        Informativo.SetToolTip(btn_buscar, "Buscar el departamento")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0

    End Sub
    Private Sub txt_cod_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        On Error Resume Next
        Informativo_por_codigo.Dispose()
    End Sub

    Private Sub txt_busca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_busca.TextChanged
        Informativo.SetToolTip(btn_buscar, "Buscar el departamento")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
    End Sub
    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Eliminar_generico("departamentos", "cod_dep", "texto", Var_cod_dep, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Me)
            Buscar_departamento()
        End If
    End Sub

    Private Sub frm_tipo_doc_departamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo

        'Buscar()
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_departamento.png")
        If Not IsNothing(MyListItem) Then
            MyListItem.ListView.Clear()
        End If

    End Sub

    Private Sub chk_ocultar_inactivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mostrar_inactivos.CheckedChanged
        Buscar_departamento()
    End Sub

    Private Sub Lista_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_buscar.SelectedIndexChanged
        If Lista_buscar.SelectedItems.Count > 0 Then

            txt_codigo.Text = Lista_buscar.SelectedItems(0).SubItems(0).Text
            txt_departamento.Text = Lista_buscar.SelectedItems(0).SubItems(1).Text
            txt_notas_observ.Text = Lista_buscar.SelectedItems(0).SubItems(2).Text
            chk_activo.Checked = CBool(Lista_buscar.SelectedItems(0).SubItems(3).Text)
            Modificar = True
            Var_cod_dep = Lista_buscar.SelectedItems(0).SubItems(0).Text
            lbl_guardado_por.Text = Lista_buscar.SelectedItems(0).SubItems(5).Text
            Mostrar_informacion("inf", "Modo de edición", "Si lo desea cambie los datos, " & vbCrLf & "luego presione archivar para modificarlos", True, 4000, txt_departamento, "inf")
        End If
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE DEPARTAMENTOS", "listado de departamentos.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub
End Class