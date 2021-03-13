Imports MySql.Data.MySqlClient
Module Proc_globales
    Public Informativo As New ToolTip
    Public Informativo_por_codigo As New ToolTip
    Public Edad_Dias As Integer, Edad_Meses As Integer, Edad_Años As Integer
    Public Var_pu_cant_registros_de_consulta As Double
    Public Edad_Completa As String
    Public Cant_Reg As Double
    'para pasar al control de citas la informacion de un resumen de citas en el años en orden descendente
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Public Pasa_num_historia As String
    Public Var_P_Medico_Labora As Boolean
    Public Sub Mostrar_formulario(ByVal El_formulario As Form, ByVal siempre_encima As Boolean)
        If El_formulario.WindowState = FormWindowState.Minimized Then
            El_formulario.WindowState = FormWindowState.Maximized
        End If
        El_formulario.TopMost = siempre_encima
        El_formulario.Show()
        El_formulario.BringToFront()
    End Sub
    Public Sub Ajustar_tamaño_listas(ByVal La_lista As ListView)
        For i = 0 To La_lista.Columns.Count - 1
            La_lista.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent)
        Next
    End Sub

    Public Sub Quitar_tamaño_listas(ByVal La_lista As ListView)
        For i = 0 To La_lista.Columns.Count - 1
            La_lista.Columns(i).Width = 0
        Next
    End Sub
    Public Sub Mostrar_imagen_sistema(ByVal Nombre_archivo As String, ByVal El_picture As PictureBox)
        Try
            El_picture.Load(Application.StartupPath & "/imagenes/sistema/" & Nombre_archivo)
            'Catch el_error As Exception
        Catch ex As Exception
            Select Case Err.Number
                Case Else
                    MsgBox("No se encuentra el archivo " & Application.StartupPath & "\imagenes\sistema\" & Nombre_archivo, MsgBoxStyle.Exclamation, "Informacion")
            End Select
        End Try
    End Sub
    Public Sub Mostrar_ocultar_barra_progreso(ByVal La_barra As ToolStripProgressBar, ByVal Informacion As String, ByVal visible As Boolean)
        Frm_menu.Infomacion_barra_progreso.Visible = visible
        Frm_menu.Infomacion_barra_progreso.Text = Informacion
        La_barra.Visible = visible
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Public Sub Mostrar_informacion(ByVal Tipo As String, ByVal Titulo As String, ByVal Mensaje As String, ByVal Es_Baloon As Boolean, ByVal Duracion As Integer, ByVal Ver_en_Control As Control, ByVal Sonido As String)
        Try
            Informativo_por_codigo.Dispose()
            Informativo_por_codigo = New ToolTip
            Informativo_por_codigo.Hide(Ver_en_Control)

            Informativo_por_codigo.ToolTipTitle = Titulo
            Select Case Tipo
                Case "inf"
                    Informativo_por_codigo.ToolTipIcon = 1
                Case "exc"
                    Informativo_por_codigo.ToolTipIcon = 2
                Case "err"
                    Informativo_por_codigo.ToolTipIcon = 3
                    'Reproducir_audio("Error.wav")
                Case ""
                    Informativo_por_codigo.ToolTipIcon = 0
                Case Else
                    Informativo_por_codigo.ToolTipIcon = 1
            End Select
            Select Case Sonido
                Case "inf"
                    Reproducir_audio("Notificacion.wav")
                Case "exc"
                    Reproducir_audio("Exclamacion.wav")
                Case "err"
                    Reproducir_audio("Error.wav")
                Case ""
                    'Reproducir_audio("Notificacion.wav")
                Case Else
                    Reproducir_audio("Notificacion.wav")
            End Select

            Informativo_por_codigo.SetToolTip(Ver_en_Control, ".")
            Informativo_por_codigo.ShowAlways = True
            Informativo_por_codigo.IsBalloon = Es_Baloon
            Informativo_por_codigo.Show(Mensaje, Ver_en_Control, Duracion)
        Catch elerror As Exception
            Select Case Err.Number
                Case 0
                    ' MsgBox("correcto")
                Case Else
                    MsgBox("No se puede mostrar un mensaje", vbExclamation, "Ayuda del sistema")
            End Select

        End Try

    End Sub
    Public Sub Reproducir_audio(ByVal Archivo_Audio As String)
        Try
            Dim ruta As String
            ruta = Application.StartupPath & "\Audio\" & Archivo_Audio
            My.Computer.Audio.Play(ruta, AudioPlayMode.Background)
            'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub Cambiar_Fondo_formulario(ByVal Formulario As Form, ByVal Encabezado As PictureBox, ByVal Extender_Encabezado As Boolean, ByVal Pie_pagina As PictureBox, ByVal extender_pie As Boolean, ByVal Icono_encabezado As PictureBox, ByVal Nombre_icono As String)
        Try
            Dim img_encabezado, Img_pie_pagina, Img_icono_encabezado As Image
            img_encabezado = Image.FromFile(Application.StartupPath & "\imagenes\sistema\fondo_encabezado.png")
            Img_pie_pagina = Image.FromFile(Application.StartupPath & "\imagenes\sistema\pie_pagina.png")
            Img_icono_encabezado = Image.FromFile(Application.StartupPath & "\imagenes\sistema\" & Nombre_icono)
            Icono_encabezado.BackColor = Color.Transparent
            Icono_encabezado.Parent = Encabezado
            Encabezado.Image = img_encabezado
            Icono_encabezado.Image = Img_icono_encabezado
            If Extender_Encabezado = True Then
                Encabezado.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                Encabezado.SizeMode = PictureBoxSizeMode.Normal
            End If
            Pie_pagina.Image = Img_pie_pagina
            If extender_pie = True Then
                Pie_pagina.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                Pie_pagina.SizeMode = PictureBoxSizeMode.Normal
            End If
        Catch El_error As Exception
            Select Case Err.Number
                Case 53
                    Mostrar_informacion("err", "Informacion:", "No se puede leer el archivo de fondo: ", True, 5000, frm_estados, "err")
                Case Else
                    MsgBox(El_error.Message & Err.Number, vbInformation, "Ayuda del sistema")
            End Select
        End Try
    End Sub
    Public Sub Validar_seleccion_combo(ByVal El_comboV As ComboBox)
        Try
            Informativo_por_codigo.Dispose()
            If IsNothing(El_comboV.SelectedValue) Then
                El_comboV.BackColor = Color.DarkRed
                El_comboV.ForeColor = Color.White
                'El_comboV.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                ' si hay error o no se selecciono un elemento valido reproduce un audio
                'Reproducir_audio("Error.wav")
                Mostrar_informacion("exc", "Error en los datos", "Debe seleccionar un elemento de la lista", True, 2500, El_comboV, "err")
                Return
            Else
                El_comboV.BackColor = Color.White
                El_comboV.ForeColor = Color.Black
                Informativo_por_codigo.Dispose()

                Return
            End If
        Catch El_error As Exception
            Select Case Err.Number
                Case 0
                Case Else
                    MsgBox("Se ha detectado un evento: " & El_error.Message, vbInformation + vbSystemModal, "Ayuda del sistema")
            End Select
        End Try
    End Sub
    Public Sub Llenar_combo_con_BD(ByVal El_combo As ComboBox, ByVal Campo_codigo As String, ByVal Campo_Descripcion As String,
                                   ByVal Nombre_tabla As String, ByVal Tiene_campo_visible As Boolean, ByVal Campo_Ordenado As String)

        Dim myAdapter As New MySqlDataAdapter
        Dim myDS As New DataSet
        Dim comando As New MySqlCommand
        Try
            ConectarBD()
            comando.Connection = myCloneCon
            If Tiene_campo_visible = True Then
                comando.CommandText = "Select " & Campo_codigo & "," & Campo_Descripcion & " from " & Nombre_tabla & " where visible=true order by " & Campo_Ordenado
            Else
                comando.CommandText = "Select " & Campo_codigo & "," & Campo_Descripcion & " from " & Nombre_tabla & " order by " & Campo_Ordenado
            End If
            myAdapter.SelectCommand = comando
            myAdapter.Fill(myDS)

            El_combo.DataSource = myDS.Tables(0)
            El_combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            El_combo.AutoCompleteSource = AutoCompleteSource.ListItems
            El_combo.MaxDropDownItems = 20

            'ValueMember en realidad almacenaria el valor del dato a visualizar
            El_combo.ValueMember = Campo_codigo
            'DisplayMember sirve para visualizar los datos cuando se despliega el control()
            El_combo.DisplayMember = Campo_Descripcion
            'Informativo_por_codigo.SetToolTip(El_combo, El_combo.DisplayMember)
            comando.Dispose()
            myDS.Dispose()
            myAdapter.Dispose()
            If El_combo.Items.Count > 0 Then
                El_combo.SelectedIndex = 0
            End If

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
    Public Sub Llenar_combo_anidado(ByVal Campo_a_comparar As String, ByVal Valor_a_comparar As String, ByVal combo_Destino As ComboBox, ByVal campo_cod_destino As String, ByVal Campo_Descripcion As String,
                               ByVal Nombre_tabla As String, ByVal Tiene_campo_visible As Boolean, ByVal Campo_Ordenado As String)

        Dim myAdapter As New MySqlDataAdapter
        Dim myDS As New DataSet
        Dim comando As New MySqlCommand
        Try
            ConectarBD()
            comando.Connection = myCloneCon
            If Tiene_campo_visible = True Then
                comando.CommandText = "Select " & campo_cod_destino & "," & Campo_Descripcion & " from " & Nombre_tabla & " where " & Campo_a_comparar & "='" & Valor_a_comparar & "' and visible=true order by " & Campo_Ordenado
            Else
                comando.CommandText = "Select " & campo_cod_destino & "," & Campo_Descripcion & " from " & Nombre_tabla & " where " & Campo_a_comparar & "='" & Valor_a_comparar & "' order by " & Campo_Ordenado
            End If
            myAdapter.SelectCommand = comando
            myAdapter.Fill(myDS)

            combo_Destino.DataSource = myDS.Tables(0)
            combo_Destino.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            combo_Destino.AutoCompleteSource = AutoCompleteSource.ListItems
            combo_Destino.MaxDropDownItems = 20

            'ValueMember en realidad almacenaria el valor del dato a visualizar
            combo_Destino.ValueMember = campo_cod_destino
            'DisplayMember sirve para visualizar los datos cuando se despliega el control()
            combo_Destino.DisplayMember = Campo_Descripcion
            If combo_Destino.Items.Count > 0 Then
                combo_Destino.SelectedIndex = 0
            End If
            'Informativo_por_codigo.SetToolTip(El_combo, El_combo.DisplayMember)
            comando.Dispose()
            myDS.Dispose()
            myAdapter.Dispose()
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

    Public Function Calcular_edad(ByVal dInicio As Date, ByVal dFin As Date) As String
        Dim DiasMes As Integer
        Edad_Dias = Microsoft.VisualBasic.DateAndTime.Day(dFin) - Microsoft.VisualBasic.DateAndTime.Day(dInicio)
        Edad_Meses = DatePart("m", dFin) - DatePart("m", dInicio)
        Edad_Años = DateDiff("yyyy", dInicio, dFin)
        If Edad_Dias < 0 Then
            DiasMes = Microsoft.VisualBasic.DateAndTime.Day(DateSerial(Year(dInicio), Month(dInicio) + 1, 0))
            Edad_Dias = (DiasMes - Microsoft.VisualBasic.DateAndTime.Day(dInicio)) + Microsoft.VisualBasic.DateAndTime.Day(dFin)
            Edad_Meses = Edad_Meses - 1
        End If

        If Edad_Meses < 0 Then
            Edad_Meses = 12 + Edad_Meses
            Edad_Años = Edad_Años - 1
        End If
        'MsgBox("Tenes " & Format(Edad_Años, "00" & " Años") & Format(Edad_Meses, "00" & " Meses ") & Format(Edad_Dias, "00" & " Dias"))
        Edad_Completa = Format(Edad_Años, "00" & " Años ") & Format(Edad_Meses, "00" & " Meses ") & Format(Edad_Dias, "00" & " Dias")
        Return Edad_Años
        Return Edad_Meses
        Return Edad_Dias
    End Function
    Public Function Obtener_cant_registros(ByVal sql As String)
        Try
            Var_pu_cant_registros_de_consulta = 0
            If sql <> "" Then

                Dim comando As New MySqlCommand
                Dim dr As MySqlDataReader
                ConectarBD()
                comando.Connection = myCloneCon
                comando.CommandText = sql
                dr = comando.ExecuteReader()

                While dr.Read
                    Var_pu_cant_registros_de_consulta = Var_pu_cant_registros_de_consulta + 1
                End While
                myCloneCon.Close()
                comando.Dispose()
                myCloneCon.Dispose()
            End If
        Catch Elerror As Exception
            MsgBox("Problema al obtener la cantidad de registros: " & Elerror.Message & " Número: " & Err.Number, MsgBoxStyle.Information, "Información")
        End Try


        Return Var_pu_cant_registros_de_consulta
    End Function
    Public Sub Limpiar_Controles(ByVal frm As Control)
        Try
            ' recorre todos los controles que hay en el formulario y limpia los text
            For Each Control In frm.Controls
                If TypeOf Control Is Form Or TypeOf Control Is TabControl Or TypeOf Control Is TabPage Or TypeOf Control Is GroupBox Or TypeOf Control Is ContainerControl Then
                    Limpiar_Controles(Control)
                End If

                ' verifica que el control es de tipo TextBox
                If TypeOf Control Is TextBox Then
                    '... Si es un Textbox, entonces lo limpia
                    Control.Text = ""
                End If

                ' verifica que el control es de tipo maskedbox
                If TypeOf Control Is MaskedTextBox Then
                    '... Si es un Textbox, entonces lo limpia
                    Control.Text = ""
                End If
                ' verifica que el control es de tipo TextBox
                If TypeOf Control Is ComboBox Then
                    Dim combo As ComboBox
                    combo = Control
                    If combo.Tag <> "nolimpiar" Or combo.Tag = "" Then
                        If combo.Items.Count > 0 Then
                            combo.SelectedIndex = 0
                        End If
                    End If
                    'el_combo.Dispose()
                End If
                If TypeOf Control Is ListView Then
                    If Control.Tag = "limpiar" Then
                        Control.Items.Clear()
                    End If
                End If
                If TypeOf Control Is NumericUpDown Then
                    Dim numericup As NumericUpDown
                    numericup = Control
                    If numericup.Tag = "limpiar" Then
                        numericup.Value = Control.Minimum
                        numericup.Tag = "limpiar"
                    Else
                        numericup.Value = Control.Value
                        numericup.Text = Control.Value
                        numericup.Tag = ""
                    End If
                    'Control.Value = 0
                End If
                If TypeOf Control Is RadioButton Then
                    Control.checked = False
                End If
                If TypeOf Control Is DateTimePicker Then
                    If Control.tag = "limpiar" Then
                        Control.Text = Now
                    End If
                End If
                If TypeOf Control Is Label Then
                    If Control.Tag = "limpiar" Then
                        Control.Text = ""
                    End If
                End If
                If TypeOf Control Is CheckBox Then
                    Control.checked = False
                End If
                If TypeOf Control Is PictureBox Then
                    If Control.tag = "limpiar" Then
                        Mostrar_imagen_sistema("Sin_foto.png", Control)
                    End If
                End If
            Next
        Catch ex As Exception
            Mostrar_mensaje_error("Limpiar_Controles", Err.Number, ex.Message)
        End Try
    End Sub
    Public Sub Eliminar_generico(ByVal Tabla As String, ByVal campo As String, ByVal tipo_dato As String, ByVal codigo_eliminar As String, ByVal preguntar_usuario As Boolean)
        Dim sql_str As String
        Dim comando As New MySqlCommand

        If tipo_dato = "texto" Then
            sql_str = "Delete from " & Tabla & " where " & campo & " ='" & codigo_eliminar & "'"
        Else
            sql_str = "Delete from " & Tabla & " where " & campo & " =" & codigo_eliminar
        End If
        Try
            Cant_Reg = 0
            comando.CommandText = sql_str
            ConectarBD()
            comando.Connection = myCloneCon
            If preguntar_usuario = True Then
                If MsgBox("¿Está seguro que desea eliminar el registro  seleccionado?", vbYesNo + vbSystemModal + vbQuestion, "Confirme la eliminación") = vbYes Then
                    'comando.ExecuteReader()
                    'myCloneCon.Close()
                    'ConectarBD()
                    Cant_Reg = comando.ExecuteNonQuery
                    MsgBox("El registro seleccionado se eliminó correctamente ", vbInformation, "Notificación")
                End If
            Else
                Cant_Reg = comando.ExecuteNonQuery
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Eliminar_generico", Mysql_ex.Number, Mysql_ex.Message)
            Cant_Reg = 0
        Catch ex As Exception
            Mostrar_mensaje_error("Eliminar_generico", Err.Number, ex.Message)
            Cant_Reg = 0
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
    Public Function SoloNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
        End Select
        ''agregar esto al evento keypress del textox a ser solo numero
        'Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        'KeyAscii = CShort(SoloNumeros(KeyAscii))
        'If KeyAscii = 0 Then
        '    e.Handled = True
        '    Mostrar_informacion("inf", "Información", "Recuerde ingresar sólo numeros en éste codigo", True, 2500, txt_cod_nac, "inf")
        'End If
    End Function
    Public Function Ver_quien_guardo(ByVal Num_historia As String)
        Dim Mi_consulta As String = ""
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader
        Mi_consulta = "select nombres,apellidos from datos_personales where num_historia='" & Num_historia & "'"
        Try
            Var_Public_quien_guardo = "NO SE PUDO DETECTAR EL NOMBRE"
            ConectarBD()
            comando.Connection = myCloneCon
            comando.CommandText = Mi_consulta
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    Var_Public_quien_guardo = dr("nombres") & " " & dr("apellidos")
                    Exit While
                End While
            End If
            myCloneCon.Close()

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Ver_quien_guardo", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Ver_quien_guardo", Err.Number, ex.Message)

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
        Return Var_Public_quien_guardo
    End Function
    Public Sub Mostrar_resumen_citas()
        Dim comando As New MySqlCommand
        Try
            'If Not IsNothing(frm_abrir_datos_paciente.Lista_abrir_paciente.FocusedItem) Then
            Cant_Reg = 0
            'frm_abrir_datos_paciente.Lista_abrir_paciente.Clear()
            ObtenerPrimerUltimoDiaMesAño(frm_control_cita.Calendario.SelectionStart.ToString("dd-MM-yyyy"))
            comando.CommandText = "SELECT citas_medicas.fecha_cita,especialidades.especialidad,estado_cita.descrip_edo_cita from " & _
                "(citas_medicas inner join especialidades on citas_medicas.cod_espec=especialidades.cod_espec " & _
                "inner join estado_cita on citas_medicas.cod_edo_cita=estado_cita.cod_edo_cita) where citas_medicas.num_historia='" & Pasa_num_historia & "'" & _
                " and citas_medicas.fecha_cita BETWEEN '" & Primer_dia_año.ToString("yyyy-MM-dd") & "' and '" & _
                Ultimo_dia_año.ToString("yyyy-MM-dd") & "' order by fecha_cita desc"
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            If dr.HasRows Then
                frm_control_cita.Lista_solicitudes.Clear()
                frm_control_cita.Lista_solicitudes.View = View.Details 'importante para que los datos se vean como lista
                frm_control_cita.Lista_solicitudes.FullRowSelect = True
                '.....Agrego Los Titulos a el listview y tamaño de columnas
                frm_control_cita.Lista_solicitudes.Columns.Add("FECHA", 200, HorizontalAlignment.Left)
                frm_control_cita.Lista_solicitudes.Columns.Add("ESPECIALIDAD", 200, HorizontalAlignment.Left)
                frm_control_cita.Lista_solicitudes.Columns.Add("ESTADO", 100, HorizontalAlignment.Left)

                While dr.Read()
                    Cant_Reg = Cant_Reg + 1

                    '...Agrego al listview la data de la consulta efectuada
                    MyListText(0) = StrConv(dr("fecha_cita"), VbStrConv.ProperCase)
                    MyListText(1) = StrConv(dr("especialidad"), VbStrConv.ProperCase)


                    MyListText(2) = UCase(dr("descrip_edo_cita"))
                    MyListItem = New ListViewItem(MyListText)
                    'Dim EsPar As Boolean = False
                    'EsPar = IIf(Cant_Reg Mod 2, False, True)
                    'If EsPar Then
                    '    MyListItem.BackColor = Color.LightBlue
                    'Else
                    '    MyListItem.BackColor = Color.WhiteSmoke
                    'End If
                    '.....Muestro los datos en el list
                    frm_control_cita.Lista_solicitudes.Items.Add(MyListItem)
                    'frm_control_cita.Lista_solicitudes.Columns(0).Width = 0
                End While
                dr.Close()
                Ajustar_tamaño_listas(frm_control_cita.Lista_solicitudes)
                'frm_control_cita.Lista_solicitudes.Columns(3).Width = 0
                'frm_control_cita.Lista_solicitudes.Items(0).Selected = True
                ' frm_control_cita.Lista_solicitudes.Items(0).EnsureVisible()
                'frm_control_cita.Lista_solicitudes.Focus()

            Else
                frm_control_cita.Lista_solicitudes.Clear()
                'MsgBox("No se encontró la información solicitada", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If
            'End If
            frm_control_cita.Grupo_Resumen.Text = "Total citas en el año " & frm_control_cita.año_up.Value & "==> " & Cant_Reg
            'If Cant_Reg > 0 Then
            '    OK_Button.Enabled = True
            'Else
            '    OK_Button.Enabled = False
            'End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Mostrar_resumen_citas", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar_resumen_citas", Err.Number, ex.Message)
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
    Public Function Verifica_labora_medico(ByVal cod_medico As String, ByVal Fecha_estudio As Date)
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            comando.CommandText = "select count(*) as cant_registros from medico_dias_no_laborables where num_historia='" & cod_medico & "' and fecha='" & Fecha_estudio.ToString("yyyy-MM-dd") & "'"
            ConectarBD()
            comando.Connection = myCloneCon
            Dim cant_reg As Integer = comando.ExecuteScalar
            If cant_reg > 0 Then
                Var_P_Medico_Labora = False
            Else
                Var_P_Medico_Labora = True
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Verifica_no_labora_medico", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Verifica_no_labora_medico", Err.Number, ex.Message)
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
        Return Var_P_Medico_Labora
    End Function
End Module
