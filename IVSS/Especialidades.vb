Imports MySql.Data.MySqlClient
Public Class Especialidades
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim Modificar_especialidad As Boolean = False
    Dim Var_cod_especialidad As String = ""
    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub Especialidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo

        'Buscar()
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\icono_frm_especialidades.png")
        If Not IsNothing(MyListItem) Then
            MyListItem.ListView.Clear()
        End If
    End Sub

    Private Sub Buscar_especialidad()
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            If chk_mostrar_inactivos.Checked = True Then
                comando.CommandText = "SELECT * FROM especialidades where especialidad like '%" & txt_busca.Text & "%'"
            Else
                comando.CommandText = "SELECT * FROM especialidades where especialidad like '%" & txt_busca.Text & "%' and visible=1"
            End If
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()

            If dr.HasRows Then
                'limpio la lista y agrego encabezados
                lista_buscar.Clear()
                lista_buscar.View = View.Details 'importante para que los datos se vean como lista
                lista_buscar.Columns.Add("Código", 100, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Especialidad", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Notas / Observaciones", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Usuario", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Fecha apertura", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Fecha guardado", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Visible", 200, HorizontalAlignment.Left)
                lista_buscar.Columns.Add("Estado", 200, HorizontalAlignment.Left)
                Cant_Reg = 0
                'agrego a la lista todo
                While dr.Read()
                    Cant_Reg = Cant_Reg + 1
                    MyListText(0) = dr("cod_espec")
                    MyListText(1) = dr("especialidad")
                    MyListText(2) = dr("notas")
                    MyListText(3) = dr("guardado_por")
                    MyListText(4) = dr("fecha_a")
                    MyListText(5) = dr("fecha_g")
                    MyListText(6) = dr("visible")
                    If dr("VISIBLE") = True Then
                        MyListText(7) = "ACTIVO"
                    Else
                        MyListText(7) = "DESHABILITADO"
                    End If
                    MyListItem = New ListViewItem(MyListText)
                    Dim EsPar As Boolean = False
                    EsPar = IIf(Cant_Reg Mod 2, False, True)
                    If EsPar Then
                        MyListItem.BackColor = Color.DarkSeaGreen
                    Else
                        MyListItem.BackColor = Color.White
                    End If
                    '.....Muestro los datos en el list
                    lista_buscar.Items.Add(MyListItem)

                End While
                Ajustar_tamaño_listas(Me.lista_buscar)
                lista_buscar.Columns(0).Width = 0
                lista_buscar.Columns(2).Width = 0
                lista_buscar.Columns(3).Width = 0
                lista_buscar.Columns(4).Width = 0
                lista_buscar.Columns(5).Width = 0
                lista_buscar.Columns(6).Width = 0
                'lista_buscar.Items(0).Selected = True
                'lista_buscar.Focus()
            Else
                MsgBox("No se encontró la especialidad", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
                Informativo.SetToolTip(btn_buscar, "Buscar la especialidad")
                btn_buscar.Tag = 0
                btn_buscar.ImageIndex = 0
                txt_busca.Focus()
            End If
            dr.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_especialidad", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_especialidad", Err.Number, ex.Message)
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
            Buscar_especialidad()
        Else 'si es quitar filtro de busqueda
            txt_busca.Text = ""
            txt_busca.Focus()
            Informativo.SetToolTip(btn_buscar, "Buscar la especialidad")
            btn_buscar.Tag = 0
            btn_buscar.ImageIndex = 0
            Buscar_especialidad()
        End If
    End Sub

    Private Sub btn_archivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_archivar.Click
        Archivar_especialidad()
    End Sub
    Private Sub Archivar_especialidad()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Dim Reg_afectados As Double
        Try
            If Modificar_especialidad = False Then
                sql_str = "INSERT INTO especialidades (cod_espec, especialidad, notas, guardado_por, fecha_a, fecha_g, visible) values ('" & _
                txt_cod_espec.Text & "','" & _
                txt_especialidad.Text & "','" & _
                txt_notas_observ.Text & "','" & _
                Cod_usuario & "','" & _
                Format(dt_apertura_fecha.Value, "yyyy-MM-dd") & "','" & _
                Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," & _
                chk_activo.Checked & ")"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
                MsgBox("Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                Modificar_especialidad = True
                Var_cod_especialidad = txt_cod_espec.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                MyListText(0) = txt_cod_espec.Text
                MyListText(1) = txt_especialidad.Text
                MyListText(2) = txt_notas_observ.Text
                MyListText(3) = Cod_usuario
                MyListText(4) = Format(dt_apertura_fecha.Value, "yyyy-MM-dd")
                MyListText(5) = Format(Now, "yyyy-MM-dd hh:mm:ss")
                MyListText(6) = chk_activo.Checked
                If chk_activo.Checked = True Then
                    MyListText(7) = "ACTIVO"
                Else
                    MyListText(7) = "DESHABILITADO"
                End If
                MyListItem = New ListViewItem(MyListText)
                '.....Muestro los datos en el list
                lista_buscar.Items.Add(MyListItem)
            Else
                sql_str = "update especialidades set " & _
                "cod_espec='" & txt_cod_espec.Text & "'," & _
                "especialidad='" & txt_especialidad.Text & "'," & _
                "notas='" & txt_notas_observ.Text & "'," & _
                "guardado_por='" & Cod_usuario & "'," & _
                "fecha_a='" & Format(dt_apertura_fecha.Value, "yyyy-MM-dd") & "'," & _
                "fecha_g='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," & _
                "visible=" & chk_activo.Checked & _
                " where cod_espec='" & Var_cod_especialidad & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()

                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se modificaron correctamente", True, 2500, lista_buscar, "inf")
                MsgBox("Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                Modificar_especialidad = True
                Var_cod_especialidad = txt_cod_espec.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                Limpiar_Controles(lista_buscar)
                txt_busca.Text = ""
                Buscar_especialidad()
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar_especialidad", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_especialidad", Err.Number, ex.Message)

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
        nueva_especialidad()
    End Sub
    Private Sub nueva_especialidad()
        Limpiar_Controles(Grupo_especialida)
        Mostrar_informacion("inf", "Instrucciones:", "Rellene todos los campos y presione el botón archivar", True, 3500, txt_cod_espec, "inf")
        txt_cod_espec.Focus()
        chk_activo.Checked = True
        Informativo.SetToolTip(btn_buscar, "Buscar la especialidad")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
        Modificar_especialidad = False
    End Sub

    Private Sub txt_cod_espec_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cod_espec.MouseHover

    End Sub

    Private Sub txt_cod_espec_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt_cod_espec.MouseMove

    End Sub

    Private Sub txt_cod_espec_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txt_cod_espec.MouseUp

    End Sub
    Private Sub txt_cod_espec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod_espec.TextChanged
        On Error Resume Next
        Informativo_por_codigo.Dispose()
    End Sub

    Private Sub txt_busca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_busca.TextChanged
        Informativo.SetToolTip(btn_buscar, "Buscar la especialidad")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
    End Sub

    Private Sub lista_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lista_buscar.SelectedIndexChanged
        If lista_buscar.SelectedItems.Count > 0 Then
            txt_cod_espec.Text = lista_buscar.SelectedItems(0).SubItems(0).Text
            txt_especialidad.Text = lista_buscar.SelectedItems(0).SubItems(1).Text
            txt_notas_observ.Text = lista_buscar.SelectedItems(0).SubItems(2).Text
            dt_apertura_fecha.Value = CDate(lista_buscar.SelectedItems(0).SubItems(4).Text)
            lbl_guardado_por.Text = "USUARIO: " & UCase(Ver_quien_guardo(lista_buscar.SelectedItems(0).SubItems(3).Text))
            chk_activo.Checked = CBool(lista_buscar.SelectedItems(0).SubItems(6).Text)
            Modificar_especialidad = True
            Var_cod_especialidad = lista_buscar.SelectedItems(0).SubItems(0).Text
            Mostrar_informacion("inf", "Modo de edición", "Si lo desea cambie los datos y luego presione archivar para modificarlos", True, 4000, txt_cod_espec, "inf")
        End If
    End Sub
    Private Sub mostrar_datos_para_modificar()

    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Eliminar_generico("especialidades", "cod_espec", "texto", Var_cod_especialidad, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Me)
            Buscar_especialidad()
        End If
    End Sub

    Private Sub chk_mostrar_inactivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mostrar_inactivos.CheckedChanged
        Buscar_especialidad()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseUp

    End Sub

    Private Sub Label2_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.Move

    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Try
            frm_reportes.Muestra_reporte("LISTADO DE ESPECIALIDADES", "listado de especialidades.rpt", "", 120, Nombre_usuario_actual)
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try

    End Sub
End Class