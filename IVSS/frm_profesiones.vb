Imports MySql.Data.MySqlClient
Public Class frm_profesiones
    Dim Modificar As Boolean = False
    Dim Var_cod_profesion As String = ""
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()

    End Sub
    Private Sub Buscar_profesion()
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            If chk_mostrar_inactivos.Checked = True Then
                comando.CommandText = "SELECT * FROM profesiones where profesion like '%" & txt_busca.Text & "%' order by profesion"
            Else
                comando.CommandText = "SELECT * FROM profesiones where profesion like '%" & txt_busca.Text & "%' and visible=1  order by profesion"
            End If
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()

            If dr.HasRows Then
                'limpio la lista y agrego encabezados
                lista_buscar.Clear()
                lista_buscar.View = View.Details 'importante para que los datos se vean como lista
                lista_buscar.Columns.Add("Código", 100, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Profesión", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Visible", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Estado", 200, HorizontalAlignment.Left)
                'agrego a la lista todo
                While dr.Read()
                    MyListText(0) = dr("cod_profesion")
                    MyListText(1) = dr("profesion")
                    MyListText(3) = dr("visible")
                    If dr("visible") = True Then
                        MyListText(4) = "ACTIVO"
                    Else
                        MyListText(4) = "DESHABILITADO"
                    End If
                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list
                    lista_buscar.Items.Add(MyListItem)

                End While
                Ajustar_tamaño_listas(Me.lista_buscar)
                lista_buscar.Columns(0).Width = 0
                lista_buscar.Columns(2).Width = 0
                lista_buscar.Columns(3).Width = 0
                'lista_buscar.Items(0).Selected = True
                'lista_buscar.Focus()
            Else
                MsgBox("No se encontró la profesión", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
                Informativo.SetToolTip(btn_buscar, "Buscar la profesión")
                btn_buscar.Tag = 0
                btn_buscar.ImageIndex = 0
                txt_busca.Focus()
            End If
            dr.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_profesion", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_profesion", Err.Number, ex.Message)
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
            Buscar_profesion()
        Else 'si es quitar filtro de busqueda
            txt_busca.Text = ""
            txt_busca.Focus()
            Informativo.SetToolTip(btn_buscar, "Buscar la profesión")
            btn_buscar.Tag = 0
            btn_buscar.ImageIndex = 0
            Buscar_profesion()
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
                sql_str = "INSERT INTO profesiones (cod_profesion, profesion, visible) values ('" & _
                txt_cod_prof.Text & "','" & _
                txt_profesion.Text & "'," & _
                chk_activo.Checked & ")"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
                MsgBox("Los datos del tipo de la profesión " & Chr(34) & txt_profesion.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                Modificar = True
                Var_cod_profesion = txt_cod_prof.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                MyListText(0) = txt_cod_prof.Text
                MyListText(1) = txt_profesion.Text
                MyListText(3) = chk_activo.Checked

                txt_busca.Text = ""
                Buscar_profesion()

            Else
                sql_str = "update profesiones set " & _
                "cod_profesion='" & txt_cod_prof.Text & "'," & _
                "profesion='" & txt_profesion.Text & "'," & _
                "visible=" & chk_activo.Checked & _
                " where cod_profesion='" & Var_cod_profesion & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()

                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se modificaron correctamente", True, 2500, lista_buscar, "inf")
                MsgBox("Los datos de la profesión " & Chr(34) & txt_profesion.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                Modificar = True
                Var_cod_profesion = txt_cod_prof.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                Limpiar_Controles(lista_buscar)
                txt_busca.Text = ""
                Buscar_profesion()
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar", Err.Number, ex.Message)

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
        nueva_profesion()
    End Sub
    Private Sub nueva_profesion()
        Limpiar_Controles(Grupo_documento)
        Modificar = False
        Mostrar_informacion("inf", "Instrucciones:", "Rellene todos los campos y presione el botón archivar", True, 3500, txt_cod_prof, "inf")
        txt_cod_prof.Focus()
        chk_activo.Checked = True
        Informativo.SetToolTip(btn_buscar, "Buscar el tipo de documento")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
    End Sub
    Private Sub txt_cod_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_prof.TextChanged
        On Error Resume Next
        Informativo_por_codigo.Dispose()
    End Sub

    Private Sub txt_busca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_busca.TextChanged
        Informativo.SetToolTip(btn_buscar, "Buscar la profesión")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
    End Sub

    Private Sub lista_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista_buscar.SelectedIndexChanged
        If lista_buscar.SelectedItems.Count > 0 Then
            txt_cod_prof.Text = lista_buscar.SelectedItems(0).SubItems(0).Text
            txt_profesion.Text = lista_buscar.SelectedItems(0).SubItems(1).Text
            chk_activo.Checked = CBool(lista_buscar.SelectedItems(0).SubItems(3).Text)
            Modificar = True
            Var_cod_profesion = lista_buscar.SelectedItems(0).SubItems(0).Text
            Mostrar_informacion("inf", "Modo de edición", "Si lo desea cambie los datos, " & vbCrLf & "luego presione archivar para modificarlos", True, 4000, txt_profesion, "inf")
        End If
    End Sub
    Private Sub mostrar_datos_para_modificar()

    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Eliminar_generico("profesiones", "cod_profesion", "texto", Var_cod_profesion, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Me)
            Buscar_profesion()
        End If
    End Sub

    Private Sub chk_ocultar_inactivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mostrar_inactivos.CheckedChanged
        Buscar_profesion()
    End Sub

    Private Sub frm_profesiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo

        'Buscar()
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_profesiones.png")
        If Not IsNothing(MyListItem) Then
            MyListItem.ListView.Clear()
        End If
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE PROFESIONES", "listado de profesiones.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try

    End Sub
End Class