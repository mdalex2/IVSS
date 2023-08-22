Imports MySql.Data.MySqlClient
Public Class frm_tipo_doc_identificacion
    Dim Modificar_documento As Boolean = False
    Dim Var_cod_doc As String = ""

    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()

    End Sub
    Private Sub Buscar_documento()
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            If chk_mostrar_inactivos.Checked = True Then
                comando.CommandText = "SELECT * FROM tipo_identificacion where identificacion like '%" & txt_busca.Text & "%' order by identificacion"
            Else
                comando.CommandText = "SELECT * FROM tipo_identificacion where identificacion like '%" & txt_busca.Text & "%' and visible=1  order by identificacion"
            End If
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()

            If dr.HasRows Then
                'limpio la lista y agrego encabezados
                lista_buscar.Clear()
                lista_buscar.View = View.Details 'importante para que los datos se vean como lista
                lista_buscar.Columns.Add("Código", 100, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Documento", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Notas / Observaciones", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Visible", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Estado", 200, HorizontalAlignment.Left)
                'agrego a la lista todo
                While dr.Read()
                    MyListText(0) = dr("cod_tipo_iden")
                    MyListText(1) = dr("identificacion")
                    MyListText(2) = dr("notas")
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
                'lista_buscar.Columns(4).Width = 0

                'lista_buscar.Items(0).Selected = True
                'lista_buscar.Focus()
            Else
                MsgBox("No se encontró el tipo de documento", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
                Informativo.SetToolTip(btn_buscar, "Buscar el tipo de documento")
                btn_buscar.Tag = 0
                btn_buscar.ImageIndex = 0
                txt_busca.Focus()
            End If
            dr.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_documento", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_documento", Err.Number, ex.Message)
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
            Buscar_documento()
        Else 'si es quitar filtro de busqueda
            txt_busca.Text = ""
            txt_busca.Focus()
            Informativo.SetToolTip(btn_buscar, "Buscar el tipo de documento")
            btn_buscar.Tag = 0
            btn_buscar.ImageIndex = 0
            Buscar_documento()
        End If
    End Sub

    Private Sub btn_archivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_archivar.Click
        Archivar_documento()
    End Sub
    Private Sub Archivar_documento()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Dim Reg_afectados As Double
        Try
            If Modificar_documento = False Then
                sql_str = "INSERT INTO tipo_identificacion (cod_tipo_iden, identificacion,notas, visible) values ('" & _
                txt_cod_doc.Text & "','" & _
                txt_documento.Text & "','" & _
                txt_notas_observ.Text & "'," & _
                chk_activo.Checked & ")"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
                MsgBox("Los datos del tipo de documento " & Chr(34) & txt_documento.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                Modificar_documento = True
                Var_cod_doc = txt_cod_doc.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                MyListText(0) = txt_cod_doc.Text
                MyListText(1) = txt_documento.Text
                MyListText(2) = txt_notas_observ.Text
                MyListText(3) = chk_activo.Checked
                If chk_activo.Checked = True Then
                    MyListText(4) = "ACTIVO"
                Else
                    MyListText(4) = "DESHABILITADO"
                End If
                MyListItem = New ListViewItem(MyListText)
                '.....Muestro los datos en el list
                lista_buscar.Items.Add(MyListItem)
            Else
                sql_str = "update tipo_identificacion set " & _
                "cod_tipo_iden='" & txt_cod_doc.Text & "'," & _
                "identificacion='" & txt_documento.Text & "'," & _
                "notas='" & txt_notas_observ.Text & "'," & _
                "visible=" & chk_activo.Checked & _
                " where cod_tipo_iden='" & Var_cod_doc & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()

                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se modificaron correctamente", True, 2500, lista_buscar, "inf")
                MsgBox("Los datos del tipo de documento " & Chr(34) & txt_documento.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                Modificar_documento = True
                Var_cod_doc = txt_cod_doc.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                Limpiar_Controles(lista_buscar)
                txt_busca.Text = ""
                Buscar_documento()
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar_documento", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_documento", Err.Number, ex.Message)

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
        Limpiar_Controles(Grupo_documento)
        Modificar_documento = False
        Mostrar_informacion("inf", "Instrucciones:", "Rellene todos los campos y presione el botón archivar", True, 3500, txt_cod_doc, "inf")
        txt_documento.Focus()
        chk_activo.Checked = True
        Informativo.SetToolTip(btn_buscar, "Buscar el tipo de documento")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
        txt_cod_doc.Enabled = True
    End Sub

    Private Sub txt_cod_doc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cod_doc.Click

    End Sub

    Private Sub txt_cod_doc_TextAlignChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cod_doc.TextAlignChanged

    End Sub
    Private Sub txt_cod_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_doc.TextChanged
        On Error Resume Next
        Informativo_por_codigo.Dispose()
    End Sub

    Private Sub txt_busca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_busca.TextChanged
        Informativo.SetToolTip(btn_buscar, "Buscar el tipo de documento")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
    End Sub

    Private Sub lista_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista_buscar.SelectedIndexChanged
        If lista_buscar.SelectedItems.Count > 0 Then
            txt_cod_doc.Enabled = False
            txt_cod_doc.Text = lista_buscar.SelectedItems(0).SubItems(0).Text
            txt_documento.Text = lista_buscar.SelectedItems(0).SubItems(1).Text
            txt_notas_observ.Text = lista_buscar.SelectedItems(0).SubItems(2).Text
            chk_activo.Checked = CBool(lista_buscar.SelectedItems(0).SubItems(3).Text)
            Modificar_documento = True
            Var_cod_doc = lista_buscar.SelectedItems(0).SubItems(0).Text
            Mostrar_informacion("inf", "Modo de edición", "Si lo desea cambie los datos, " & vbCrLf & "luego presione archivar para modificarlos", True, 4000, txt_documento, "inf")
        End If
    End Sub
    Private Sub mostrar_datos_para_modificar()

    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Eliminar_generico("tipo_identificacion", "cod_tipo_iden", "texto", Var_cod_doc, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Me)
            Buscar_documento()
        End If
    End Sub

    Private Sub frm_tipo_doc_identificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo

        'Buscar()
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_documento.png")
        If Not IsNothing(MyListItem) Then
            MyListItem.ListView.Clear()
        End If

    End Sub

    Private Sub chk_ocultar_inactivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mostrar_inactivos.CheckedChanged
        Buscar_documento()
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click

    End Sub
End Class