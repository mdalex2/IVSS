Imports MySql.Data.MySqlClient
Public Class frm_empresas
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim Modificar_Datos As Boolean = False
    Dim Var_cod_empresa As String = ""
    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub
    Private Sub Buscar_empresa()
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            If chk_mostrar_inactivos.Checked = True Then
                comando.CommandText = "SELECT empresas.*, ciudades.nombre_ciudad,estado_territorial.edo_territorial,datos_personales.nombres,datos_personales.apellidos FROM (empresas INNER JOIN ciudades ON empresas.cod_ciudad=Ciudades.cod_ciudad" & _
                   " INNER JOIN estado_territorial ON empresas.cod_edo_ter=estado_territorial.cod_edo_ter" & _
                   " INNER JOIN datos_personales ON empresas.guardado_por=datos_personales.num_historia " & _
                   ") where descrip_empresa  like '%" & txt_busca.Text & "%'"
                'ORDER BY `Ciudades`.`Cod_Estado`, `Estados`.`Nombre_estado`

                'comando.CommandText = "SELECT * FROM empresas,ciudades.nombre_ciudad where descrip_empresa like '%" & txt_busca.Text & "%'"
            Else
                comando.CommandText = "SELECT empresas.*, ciudades.nombre_ciudad,estado_territorial.edo_territorial FROM (empresas INNER JOIN ciudades ON empresas.cod_ciudad=Ciudades.cod_ciudad" & _
                   " INNER JOIN estado_territorial ON empresas.cod_edo_ter=estado_territorial.cod_edo_ter) where descrip_empresa  like '%" & txt_busca.Text & "%' and empresas.visible=1"

                'comando.CommandText = "SELECT * FROM empresas,ciudades,estado_territorial where descrip_empresa  like '%" & txt_busca.Text & "%' and visible=1"
            End If
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                'limpio la lista y agrego encabezados
                Lista_buscar.Clear()
                Lista_buscar.View = View.Details 'importante para que los datos se vean como lista
                Lista_buscar.Columns.Add("Código", 100, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Empresa", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Cod. estado", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Estado", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Cod. ciudad", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Ciudad", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Direccion", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Telf. principal", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Telf. secundario", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Telf. Fax", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Correo electronico", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Página WEB", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Blog / Otro sitio Web", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Notas / Observaciones", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Visible", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Estatus", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("Usuario", 200, HorizontalAlignment.Left)
                'agrego a la lista todo
                While dr.Read()
                    MyListText(0) = dr("cod_empresa")
                    MyListText(1) = dr("descrip_empresa")
                    MyListText(2) = dr("cod_edo_ter")
                    MyListText(3) = dr("edo_territorial")
                    MyListText(4) = dr("cod_ciudad")
                    MyListText(5) = dr("nombre_ciudad")
                    MyListText(6) = dr("direccion")
                    MyListText(7) = dr("telefono")
                    MyListText(8) = dr("otrotelf")
                    MyListText(9) = dr("fax")
                    MyListText(10) = dr("email")
                    MyListText(11) = dr("web")
                    MyListText(12) = dr("blog")
                    MyListText(13) = dr("notas")
                    MyListText(14) = dr("visible")
                    If dr("VISIBLE") = True Then
                        MyListText(15) = "ACTIVO"
                    Else
                        MyListText(15) = "DESHABILITADO"
                    End If
                    MyListText(16) = dr("nombres") & " " & dr("apellidos") & " - " & FormatDateTime(dr("fecha_g"), DateFormat.GeneralDate)
                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list
                    Lista_buscar.Items.Add(MyListItem)

                End While
                'Ajustar_tamaño_listas(Me.Lista_buscar)
                btn_reporte.Enabled = True
                Quitar_tamaño_listas(Me.Lista_buscar)
                Lista_buscar.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
                Lista_buscar.AutoResizeColumn(15, ColumnHeaderAutoResizeStyle.ColumnContent)
                'Lista_buscar.Items(0).Selected = True
                'Lista_buscar.Focus()
            Else
                MsgBox("No se encontró la empresa / organismo", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
                Informativo.SetToolTip(btn_buscar, "Buscar empresa / organismo")
                btn_buscar.Tag = 0
                btn_buscar.ImageIndex = 0
                txt_busca.Focus()
            End If
            dr.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_empresa", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_empresa", Err.Number, ex.Message)
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
            Buscar_empresa()
        Else 'si es quitar filtro de busqueda
            txt_busca.Text = ""
            txt_busca.Focus()
            Informativo.SetToolTip(btn_buscar, "Buscar la especialidad")
            btn_buscar.Tag = 0
            btn_buscar.ImageIndex = 0
            Buscar_empresa()
        End If
    End Sub


    Private Sub Archivar()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Dim Reg_afectados As Double
        Try
            If Modificar_Datos = False Then
                sql_str = "INSERT INTO empresas (cod_empresa,descrip_empresa,cod_edo_ter,cod_ciudad,direccion,telefono,fax,otrotelf,email,web,blog,notas,visible,guardado_por,fecha_g) values ('" & _
                txt_cod.Text & "','" & _
                txt_empresa.Text & "','" & _
                cmb_estado.SelectedValue & "','" & _
                cmb_ciudad.SelectedValue & "','" & _
                txt_direccion.Text & "','" & _
                txt_telf_principal.Text & "','" & _
                txt_fax.Text & "','" & _
                txt_telf_secundario.Text & "','" & _
                txt_correo.Text & "','" & _
                txt_web.Text & "','" & _
                txt_blog.Text & "','" & _
                txt_notas.Text & "'," & _
                chk_activo.Checked & ",'" & _
                Cod_usuario & "','" & _
                Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
                MsgBox("Los datos de la empresa " & Chr(34) & txt_empresa.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                Modificar_Datos = True
                Var_cod_empresa = txt_cod.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                Limpiar_Controles(Lista_buscar)
                Buscar_empresa()
            Else
                sql_str = "update empresas set " & _
                "cod_empresa='" & txt_cod.Text & "'," & _
                "descrip_empresa='" & txt_empresa.Text & "'," & _
                "cod_edo_ter='" & cmb_estado.SelectedValue & "'," & _
                "cod_ciudad='" & cmb_ciudad.SelectedValue & "'," & _
                "direccion='" & txt_direccion.Text & "'," & _
                "telefono='" & txt_telf_principal.Text & "'," & _
                "fax='" & txt_fax.Text & "'," & _
                "otrotelf='" & txt_telf_secundario.Text & "'," & _
                "email='" & txt_correo.Text & "'," & _
                "web='" & txt_web.Text & "'," & _
                "blog='" & txt_blog.Text & "'," & _
                "notas='" & txt_notas.Text & "'," & _
                "guardado_por='" & Cod_usuario & "'," & _
                "fecha_g='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," & _
                "visible=" & chk_activo.Checked & _
                " where cod_empresa='" & Var_cod_empresa & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()

                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se modificaron correctamente", True, 2500, lista_buscar, "inf")
                MsgBox("Los datos de la empresa " & Chr(34) & txt_empresa.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                Modificar_Datos = True
                Var_cod_empresa = txt_cod.Text
                'activo los botones de reporte y eliminar
                btn_eliminar.Enabled = True
                Limpiar_Controles(Lista_buscar)
                txt_busca.Text = ""
                Buscar_empresa()
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
    Private Sub Agregar_nueva()
        Limpiar_Controles(Grupo_datos)
        Mostrar_informacion("inf", "Instrucciones:", "Rellene todos los campos y presione el botón archivar", True, 3500, txt_cod, "inf")
        txt_cod.Focus()
        chk_activo.Checked = True
        Informativo.SetToolTip(btn_buscar, "Buscar la empresa")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
        btn_eliminar.Enabled = False
        Modificar_Datos = False
    End Sub

    Private Sub txt_cod_espec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cod.TextChanged
        On Error Resume Next
        Informativo_por_codigo.Dispose()
    End Sub

    Private Sub txt_busca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_busca.TextChanged
        Informativo.SetToolTip(btn_buscar, "Buscar la empresa")
        btn_buscar.Tag = 0
        btn_buscar.ImageIndex = 0
    End Sub
    Private Sub chk_mostrar_inactivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_mostrar_inactivos.CheckedChanged
        'Buscar_empresa()
    End Sub


    Private Sub frm_empresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar_Controles(Grupo_datos)
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo
        Llenar_combo_con_BD(cmb_estado, "cod_edo_ter", "edo_territorial", "estado_territorial", True, "edo_territorial")
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\icono_frm_empresas.png")

    End Sub

    Private Sub Lista_buscar_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_buscar.SelectedIndexChanged
        If Lista_buscar.SelectedItems.Count > 0 Then
            txt_cod.Text = Lista_buscar.SelectedItems(0).SubItems(0).Text
            txt_empresa.Text = Lista_buscar.SelectedItems(0).SubItems(1).Text
            cmb_estado.Text = Lista_buscar.SelectedItems(0).SubItems(3).Text
            cmb_ciudad.Text = Lista_buscar.SelectedItems(0).SubItems(5).Text
            txt_direccion.Text = Lista_buscar.SelectedItems(0).SubItems(6).Text
            txt_telf_principal.Text = Lista_buscar.SelectedItems(0).SubItems(7).Text
            txt_telf_secundario.Text = Lista_buscar.SelectedItems(0).SubItems(8).Text
            txt_fax.Text = Lista_buscar.SelectedItems(0).SubItems(9).Text
            txt_correo.Text = Lista_buscar.SelectedItems(0).SubItems(10).Text
            txt_web.Text = Lista_buscar.SelectedItems(0).SubItems(11).Text
            txt_blog.Text = Lista_buscar.SelectedItems(0).SubItems(12).Text
            txt_notas.Text = Lista_buscar.SelectedItems(0).SubItems(13).Text
            chk_activo.Checked = Lista_buscar.SelectedItems(0).SubItems(14).Text
            lbl_guardado_por.Text = Lista_buscar.SelectedItems(0).SubItems(16).Text
            btn_eliminar.Enabled = True
            Modificar_Datos = True
            Var_cod_empresa = Lista_buscar.SelectedItems(0).SubItems(0).Text
            Mostrar_informacion("inf", "Modo de edición", "Si lo desea cambie los datos y luego presione archivar para modificarlos", True, 4000, txt_empresa, "inf")
        End If

    End Sub

    Private Sub btn_nueva_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nueva.Click
        Agregar_nueva()
    End Sub

    Private Sub btn_archivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_archivar.Click
        Archivar()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Eliminar_generico("empresas", "cod_empresa", "texto", Var_cod_empresa, True)
        If Cant_Reg > 0 Then
            Limpiar_Controles(Me)
            chk_mostrar_inactivos.Checked = True
            Buscar_empresa()
        End If
    End Sub

    Private Sub cmb_estado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_estado.SelectedIndexChanged

    End Sub

    Private Sub cmb_estado_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_estado.SelectedValueChanged
        Try
            Llenar_combo_anidado("cod_edo_ter", cmb_estado.SelectedValue.ToString, cmb_ciudad, "cod_ciudad", "nombre_ciudad", "ciudades", True, "nombre_ciudad")
        Catch ex As Exception
            Select Case Err.Number
                Case 0

                Case 5
                    'MsgBox("No se pudo cargar la tabla: " & Nombre_tabla & " en el cuadro de lista: " & El_combo.Name, vbExclamation + vbSystemModal, "Ayuda del sistema")
                Case Else
                    MsgBox(ex.Message & Err.Number, vbSystemModal + vbExclamation, "Ayuda del sistema del modulo buscar")
            End Select
        End Try
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE EMPRESAS / EMPRESAS", "listado de empresas.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub
End Class