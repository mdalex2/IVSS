Imports MySql.Data.MySqlClient
Public Class frm_feriados
    Dim Modificar As Boolean = False
    Dim Var_cod_area As String = ""
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim Var_temp_contador As Integer
    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte.Click

        If DateValue(fecha_desde.Value) > DateValue(fecha_hasta.Value) Then
            Mostrar_informacion("inf", "Notificación:", "La fecha final no puede ser menor que la fecha incicial", True, 4000, fecha_hasta, "exc")
            Exit Sub
        End If
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            Dim fecha_inicio_rpt, fecha_fin_rpt As String
            fecha_inicio_rpt = fecha_d_lista.Value.Year.ToString & "," & fecha_d_lista.Value.Month.ToString & "," & fecha_d_lista.Value.Day.ToString
            'Format(Fecha_desde, "yyyy,MM,dd")
            fecha_fin_rpt = fecha_h_lista.Value.Year.ToString & "," & fecha_h_lista.Value.Month.ToString & "," & fecha_h_lista.Value.Day.ToString
            Dim formula_seleccion As String = ""
            formula_seleccion = "{feriados.fecha} >= datevalue(" & fecha_inicio_rpt & ") and {feriados.fecha} <= datevalue(" & fecha_fin_rpt & ")"
            frm_reportes.Muestra_reporte(UCase("LISTADO DE DIAS FERIADOS DESDE " & fecha_desde.Value.ToString("dddd, dd-MMMM-yyyy") & _
                                        " HASTA " & fecha_hasta.Value.ToString("dddd, dd-MMMM-yyyy")), "Listado de feriados.rpt", formula_seleccion, 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            frm_espera.Close()
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub frm_feriados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar_Controles(Me)
        Me.Text = Application.ProductName
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo

        'Buscar()
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_feriados.png")
        If Not IsNothing(MyListItem) Then
            MyListItem.ListView.Clear()
        End If
        ObtenerPrimerUltimoDiaMesAño(Now)
        fecha_d_lista.Value = Primer_dia_mes
        fecha_h_lista.Value = Ultimo_dia_mes
    End Sub

    Public Sub mostrar_lista()
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            'Dim var_fecha_desde, var_fecha_hasta As Date

            comando.CommandText = "SELECT feriados.*, DATOS_PERSONALES.NOMBRES,DATOS_PERSONALES.APELLIDOS FROM (feriados INNER JOIN DATOS_PERSONALES ON feriados.guardado_por=datos_personales.num_historia) where fecha BETWEEN '" & fecha_d_lista.Value.ToString("yyyy-MM-dd") & "' and '" & _
                fecha_h_lista.Value.ToString("yyyy-MM-dd") & "' order by fecha asc"
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()

            If dr.HasRows Then
                'limpio la lista y agrego encabezados
                Lista_buscar.Clear()
                Lista_buscar.View = View.Details 'importante para que los datos se vean como lista
                Lista_buscar.Columns.Add("FECHA", 100, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("FERIADOS", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("MODO CALCULO", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("GUARDADO POR", 200, HorizontalAlignment.Left)
                Lista_buscar.Columns.Add("ID", 200, HorizontalAlignment.Left)
                Cant_Reg = 0
                'agrego a la lista todo
                While dr.Read()
                    Cant_Reg = Cant_Reg + 1
                    MyListText(0) = dr("fecha")
                    MyListText(1) = dr("nombre_feriado")
                    If dr("variable") = True Then
                        MyListText(2) = "SOLO PARA ESTE AÑO"
                    Else
                        MyListText(2) = "PARA TODOS LOS AÑOS"
                    End If
                    Dim fecha_g As Date = dr("fecha_g")
                    MyListText(3) = dr("nombres") & " " & dr("apellidos") & " el " & fecha_g.ToString("dddd,dd-MMMM-yyyy")
                    MyListText(4) = dr("ID")
                    MyListItem = New ListViewItem(MyListText)
                    'Dim EsPar As Boolean = False
                    'EsPar = IIf(Cant_Reg Mod 2, False, True)
                    'If EsPar Then
                    '    MyListItem.BackColor = Color.DarkSeaGreen
                    'Else
                    '    MyListItem.BackColor = Color.White
                    'End If
                    '.....Muestro los datos en el list
                    Lista_buscar.Items.Add(MyListItem)

                End While
                Ajustar_tamaño_listas(Me.Lista_buscar)
                'Lista_buscar.Columns(2).Width = 0
            Else
                Lista_buscar.Clear()
                MsgBox("Para la fecha seleccionada no existen feriados", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If
            dr.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("mostrar_lista", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("mostrar_lista", Err.Number, ex.Message)
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
        mostrar_lista()
    End Sub

    Private Sub Lista_buscar_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles Lista_buscar.ItemCheck
        btn_eliminar.Enabled = True
    End Sub


    Private Sub btn_eliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim hay_seleccionados As Boolean = False
        For i = 0 To Lista_buscar.Items.Count - 1
            If Lista_buscar.Items(i).Checked = True Then
                hay_seleccionados = True
                Exit For
            End If
        Next
        If hay_seleccionados = True Then
            If MsgBox("Nota: esta acción no se podrá deshacer y automáticamente se otorgarán citas médicas para los días feriados eliminados" & _
          vbNewLine & "¿Está seguro que desea eliminar la selección de días feriados?", vbYesNo + vbQuestion + vbDefaultButton2 + vbSystemModal, "Confirme la eliminación") = vbYes Then
                eliminar_dias_feriados()
            End If
        Else
            MsgBox("No se ha seleccionado ningún dia, debe marcar los días que desea eliminar", vbExclamation, "Ayuda del sistema")
        End If

    End Sub
    Private Sub eliminar_dias_feriados()
        If Lista_buscar.Items.Count > 0 Then
            Try
                Var_temp_contador = 0
                For i = 0 To Lista_buscar.Items.Count - 1
                    If Lista_buscar.Items(i).Checked = True Then
                        Dim id_feriado As String = Lista_buscar.Items(i).SubItems(4).Text
                        Dim fecha As Date = Lista_buscar.Items(i).Text
                        Sql_eliminar_dias_feriados(id_feriado, fecha)
                    End If
                Next
                If Var_temp_contador > 0 Then
                    MsgBox("Se eliminó lo(s) dia(s) seleccionado(s), Total de dias: " & Var_temp_contador, vbInformation, "Días feriados eliminados")
                    mostrar_lista()
                Else
                    MsgBox("No se eliminó ninguna día", vbInformation, "Eliminar dias feriados")
                End If
            Catch ex As Exception
                Mostrar_mensaje_error("eliminar_dias_feriados", Err.Number, ex.Message)
                Cant_Reg = 0
            End Try
        End If
    End Sub
    Private Sub Sql_eliminar_dias_feriados(ByVal id_feriado As String, ByVal fecha As Date)
        Dim sql_str As String
        Dim comando As New MySqlCommand
        sql_str = "Delete from feriados where id='" & id_feriado & "' and " & _
            "fecha='" & fecha.ToString("yyyy-MM-dd") & "'"
        Try
            Cant_Reg = 0
            comando.CommandText = sql_str
            ConectarBD()
            comando.Connection = myCloneCon
            Cant_Reg = comando.ExecuteNonQuery
            Var_temp_contador = Var_temp_contador + Cant_Reg

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Sql_eliminar_dias_feriados", Mysql_ex.Number, Mysql_ex.Message)
            Cant_Reg = 0
        Catch ex As Exception
            Mostrar_mensaje_error("Sql_eliminar_dias_feriados", Err.Number, ex.Message)
            Cant_Reg = 0
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

    Private Sub btn_nueva_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nueva.Click
        Limpiar_Controles(Grupo_datos)
    End Sub
    Private Sub archivar()
        Dim fecha_actual As Date = fecha_desde.Value
        While DateValue(fecha_actual) <= DateValue(fecha_hasta.Value)
            Dim sql_str As String
            Dim comando As New MySqlCommand
            sql_str = "select count(*) from FERIADOS where fecha='" & _
                    fecha_actual.ToString("yyyy-MM-dd") & "'"
            comando.CommandText = sql_str
            ConectarBD()
            comando.Connection = myCloneCon
            Dim Reg_encontrados As Integer
            Reg_encontrados = comando.ExecuteScalar
            comando.Dispose()
            myCloneCon.Dispose()
            If Reg_encontrados = 0 Then
                sql_str = "INSERT INTO FERIADOS (fecha,nombre_feriado,variable,notas,guardado_por,fecha_g) values ('" & _
                        fecha_actual.ToString("yyyy-MM-dd") & "','" & _
                        TXT_feriado.Text & "'," & _
                        chk_variable.Checked & ",'" & _
                        txt_notas.Text & "','" & _
                        Cod_usuario & "','" & _
                        Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"

                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
            End If
            fecha_actual = DateAdd(DateInterval.Day, 1, fecha_actual)
        End While
        MsgBox("El intervalo de dias seleccionados se almacenó con exito", vbInformation + vbSystemModal, "Ayuda del sistema")
        mostrar_lista()
    End Sub

    Private Sub btn_archivar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_archivar.Click
        If fecha_desde.Value > fecha_hasta.Value Then
            Mostrar_informacion("inf", "Notificación:", "La fecha final no puede ser menor que la fecha incicial", True, 4000, fecha_hasta, "exc")
            Exit Sub
        End If
        archivar()
    End Sub

    Private Sub Lista_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_buscar.SelectedIndexChanged
        If Not IsNothing(Lista_buscar.FocusedItem) Then
            lbl_guardado_por.Text = Lista_buscar.FocusedItem.SubItems(3).Text
        End If
    End Sub

End Class