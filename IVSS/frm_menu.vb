Imports System.Windows.Forms
Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.IO 'para poder almacenar la foto en la bd
'para crystal report
Imports System.Data.SqlClient

Public Class Frm_menu
    Dim MyListText(50) As String
    Dim MyListItem As ListViewItem
    Dim Pos_asterisco As Integer
    Dim sql_nombre, sql_apellido, opcn_de_busca, Var_ID_foto_mostrada As String
    Dim Num_foto_mostrada As Integer
    Dim paso_Validacion As Boolean = False
    Dim Paso_guarda_datos_per As Boolean = False
    Dim Paso_guarda_antecedentes As Boolean = False
    Dim Modificar_antecedentes As Boolean = False
    'Private Sub mostrar_reporte_turnos()
    '    ' ---------------------------By CesarL--------------
    '    ' SETEANDO CONEXION PARA CR
    '    Dim oConexInfo As ConnectionInfo
    '    Dim oListaTablas As Tables
    '    Dim oTabla As Table
    '    Dim oTablaConexInfo As TableLogOnInfo
    '    ' instanciar objeto para guardar datos de conexión
    '    oConexInfo = New ConnectionInfo()
    '    oConexInfo.ServerName = "NombreServidor"
    '    oConexInfo.DatabaseName = "NombreBaseDatosODBC"
    '    oConexInfo.UserID = "Usuario"
    '    oConexInfo.Password = "Password"

    '    Dim rpt_id As New ReportDocument
    '    ' Comprobamos la existencia del reporte, si el reporte no existe abortamos si no continuamos
    '    Dim Reporte As String = Application.StartupPath & "Reporte.rpt"
    '    If Not IO.File.Exists(Reporte) Then
    '        MessageBox.Show("No se encontro reporte:" & vbCrLf & _
    '        Reporte, "Report Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Me.Close()
    '        Exit Sub
    '    End If
    '    'Una vez verificado el reporte procedemos a cargarlo
    '    rpt_id.Load(Reporte)
    '    oListaTablas = rpt_id.Database.Tables
    '    For Each oTabla In oListaTablas
    '        oTablaConexInfo = oTabla.LogOnInfo
    '        oTablaConexInfo.ConnectionInfo = oConexInfo
    '        oTabla.ApplyLogOnInfo(oTablaConexInfo)
    '        'ENVIANDO VARIABLE A CR
    '        rpt_id.SetParameterValue("@FechaInicio", "VariableFechaInicial")
    '        rpt_id.SetParameterValue("@FechaFin", "VariableFechaFinal")
    '        rpt_id.SetParameterValue("@Company", "VariableCompany")
    '        Me.CrystalReportViewer1.ReportSource = rpt_id
    'End Sub
    Private Sub Btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_buscar_princ.Click
        Mostrar_ocultar_barra_progreso(Me.Barra_progreso_menu, "Buscando el paciente", True)
        Validar_buscar_Paciente()
        Buscar_paciente_frm_princ()
        Mostrar_ocultar_barra_progreso(Me.Barra_progreso_menu, "", False)
    End Sub
    Private Sub Validar_buscar_Paciente()
        If cmb_opcn_busca.Text = "" Then
            cmb_opcn_busca.Focus()
            cmb_opcn_busca.DroppedDown = True
            Mostrar_informacion("inf", "Informacion:", "Debe seleccionar el tipo de documento a consultar", True, 5000, Me.cmb_opcn_busca, "inf")
            Exit Sub
        End If
        If Txt_busca_princ.Text = "" Then
            Mostrar_informacion("inf", "Informacion:", "Debe escribir el " & cmb_opcn_busca.Text, True, 5000, Me.Txt_busca_princ, "inf")
            Txt_busca_princ.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub Buscar_paciente_frm_princ()
        Dim comando As New MySqlCommand
        Try
            Lista_historias_buscar.Clear()
            Lista_HM_familares_principal.Clear()
            Select Case UCase(cmb_opcn_busca.Text)
                Case UCase("num. historia")
                    comando.CommandText = "SELECT num_historia,n_identificacion,nombres,apellidos,fecha_nac FROM Datos_personales where num_historia like '%" & Txt_busca_princ.Text & "%' and num_historia<>'NCI-0000' ORDER BY num_historia"
                Case UCase("num. documento")
                    comando.CommandText = "SELECT num_historia,n_identificacion,nombres,apellidos,fecha_nac FROM Datos_personales where n_identificacion like '%" & Txt_busca_princ.Text & "%' and num_historia<>'NCI-0000'  ORDER BY num_historia"
                Case UCase("nombres y apellidos")
                    comando.CommandText = "SELECT num_historia,n_identificacion,nombres,apellidos,fecha_nac FROM Datos_personales where (nombres like '%" & Txt_busca_princ.Text & "%' or apellidos like '%" & Txt_busca_princ.Text & "%') and num_historia<>'NCI-0000' ORDER BY nombres,apellidos asc"
            End Select
            ConectarBD()
            comando.Connection = myCloneCon
            Cant_Reg = 0
            If Txt_busca_princ.Text <> "" And cmb_opcn_busca.Text <> "" Then
                dr = comando.ExecuteReader()
                If dr.HasRows Then
                    Lista_historias_buscar.Clear()
                    Lista_historias_buscar.View = View.Details 'importante para que los datos se vean como lista
                    '.....Agrego Los Titulos a el listview y tamaño de columnas
                    Lista_historias_buscar.Columns.Add("NOMBRES", 200, HorizontalAlignment.Left)
                    Lista_historias_buscar.Columns.Add("APELLIDOS", 200, HorizontalAlignment.Left)
                    Lista_historias_buscar.Columns.Add("Nº HISTORIA", 100, HorizontalAlignment.Left)
                    Lista_historias_buscar.Columns.Add("Nº DOCUMENTO", 200, HorizontalAlignment.Left)
                    Lista_historias_buscar.Columns.Add("EDAD", 200, HorizontalAlignment.Left)

                    While dr.Read()
                        Cant_Reg = Cant_Reg + 1

                        '...Agrego al listview la data de la consulta efectuada
                        MyListText(0) = StrConv(dr("nombres"), VbStrConv.ProperCase)
                        MyListText(1) = StrConv(dr("apellidos"), VbStrConv.ProperCase)


                        MyListText(2) = UCase(dr("num_historia"))
                        MyListText(3) = dr("n_identificacion")
                        Calcular_edad(dr("fecha_nac"), Now)
                        MyListText(4) = Edad_Completa
                        MyListItem = New ListViewItem(MyListText)
                        Dim EsPar As Boolean = False
                        EsPar = IIf(Cant_Reg Mod 2, False, True)
                        If EsPar Then
                            MyListItem.BackColor = Color.Lavender
                        Else
                            MyListItem.BackColor = Color.WhiteSmoke
                        End If
                        '.....Muestro los datos en el list
                        Lista_historias_buscar.Items.Add(MyListItem)
                        'Lista_historias_buscar.Columns(0).Width = 0
                    End While
                    dr.Close()
                    Ajustar_tamaño_listas(Lista_historias_buscar)
                    Lista_historias_buscar.Columns(4).Width = 0
                    Lista_historias_buscar.Items(0).Selected = True
                    Lista_historias_buscar.Items(0).EnsureVisible()
                    Lista_historias_buscar.Focus()

                Else
                    MsgBox("No se encontró la información solicitada", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
                End If
                Lbl_total_reg_encontrados.Text = "Total de registros encontrados: " & Cant_Reg
                If Cant_Reg > 0 Then
                    Btn_abrir_historia_princ.Enabled = True
                Else
                    Btn_abrir_historia_princ.Enabled = False
                End If
            End If

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_paciente_frm_princ", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_paciente_frm_princ", Err.Number, ex.Message)
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
    Private Sub Dividir_nombre_apellidos()
        Pos_asterisco = InStr(Txt_busca_princ.Text, " ")
        If Pos_asterisco > 0 Then 'si se busca ingresando ejemplo "jai*mend" separo nombres de apellidos
            sql_nombre = Microsoft.VisualBasic.Left(Txt_busca_princ.Text, Pos_asterisco - 1)
            sql_apellido = Microsoft.VisualBasic.Right(Txt_busca_princ.Text, Len(Txt_busca_princ.Text) - Pos_asterisco)
        Else
            sql_nombre = Txt_busca_princ.Text
            sql_apellido = ""
        End If
        MsgBox("Nombres: " & sql_nombre & Chr(13) & "Apellidos: " & sql_apellido, vbInformation, "Sistema")
    End Sub

    Private Sub Frm_menu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If PREGUNTA_CIERRE = True Then
            e.Cancel = CANCELAR_CIERRE
            If MsgBox("¿Está seguro que desea salir del sistema?", vbSystemModal + vbInformation + vbYesNo, "Ayuda del sistema") = vbYes Then
                End
            End If
        End If
    End Sub



    Private Sub Frm_menu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'para que esto funcione debe activarse en form la propiedad keypreview
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            SendKeys.Send("{TAB}")

        End If
        If e.KeyCode = Keys.Up Then
            e.Handled = True
            SendKeys.Send("+{TAB}")
        End If
    End Sub

    Private Sub Frm_menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LLeno los combos con los valores almacenados en las tablas de las bases de datos
        CANCELAR_CIERRE = False
        PREGUNTA_CIERRE = True
        Limpiar_Controles(Me)
        Refrescar_contenido_combos()

        'coloco un fondo a la barras de menu y barra de botonnes
        Dim img As Image
        img = Image.FromFile(Application.StartupPath & "\imagenes\sistema\Fondo_encabezado.png")
        Me.Barra_menu.BackgroundImage = img
        Me.Barra_botones.BackgroundImage = img
        Mostrar_imagen_sistema("sin_foto.png", Foto_busqueda)
        Mostrar_imagen_sistema("sin_foto.png", Foto_datos_per)
        'Cod_usuario = "NCI-0000"
        'Nombre_usuario_actual = "JAIRO ALEXI MENDOZA"
        'Hoja.SelectedTab = Datos_personales
        '.....Agrego Los Titulos a el listview y tamaño de columnas
        Lista_historias_buscar.Columns.Add("NOMBRES", 200, HorizontalAlignment.Left)
        Lista_historias_buscar.Columns.Add("APELLIDOS", 200, HorizontalAlignment.Left)
        Lista_historias_buscar.Columns.Add("Nº HISTORIA", 100, HorizontalAlignment.Left)
        Lista_historias_buscar.Columns.Add("Nº DOCUMENTO", 200, HorizontalAlignment.Left)
        Lista_historias_buscar.Columns.Add("EDAD", 200, HorizontalAlignment.Left)
        'agrego titulos a lista historias familiares
    End Sub

    Private Sub EstadosTerritorialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_estados.Show()
    End Sub

    Private Sub TipoDeDocumentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeDocumentosToolStripMenuItem.Click
        Mostrar_formulario(frm_tipo_doc_identificacion, False)
    End Sub

    Private Sub Refrescar_contenido_combos()
        'LLeno los combos con los valores almacenados en las tablas de las bases de datos
        Llenar_combo_con_BD(Me.cmb_nacionalidad, "cod_nacionalidad", "nacionalidad", "nacionalidades", True, "nacionalidad")
        Llenar_combo_con_BD(Me.Cmb_Tipo_doc, "cod_tipo_iden", "identificacion", "tipo_identificacion", True, "identificacion")
        Llenar_combo_con_BD(Me.Cmb_edo_civil, "cod_edo_civil", "estado_civil", "estado_civil", True, "estado_civil")
        Llenar_combo_con_BD(Me.Cmb_ocupacion, "cod_profesion", "Profesion", "profesiones", True, "Profesion")
        Cmb_ocupacion.DropDownWidth = 400

        If Hoja.SelectedIndex = 0 Then
            Mostrar_informacion("inf", "Notificación", "Las listas desplegables se actualizaron", True, 2000, cmb_opcn_busca, "inf")
        Else
            Mostrar_informacion("inf", "Notificación", "Las listas desplegables se actualizaron", True, 2000, Cmb_Tipo_doc, "inf")
        End If
    End Sub

    Private Sub Cmb_Tipo_doc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_Tipo_doc.KeyUp
        If e.KeyCode = Keys.F2 = True Then
            Llenar_combo_con_BD(Me.Cmb_Tipo_doc, "cod_tipo_iden", "identificacion", "tipo_identificacion", True, "identificacion")
        End If
    End Sub

    Private Sub Cmb_Tipo_doc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_Tipo_doc.LostFocus
        Validar_seleccion_combo(Me.Cmb_Tipo_doc)
    End Sub

    Private Sub Cmb_Tipo_doc_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_Tipo_doc.SelectedValueChanged
        Validar_seleccion_combo(Me.Cmb_Tipo_doc)
        Genera_num_hist()
    End Sub
    Private Sub Cmb_Tipo_doc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_Tipo_doc.TextChanged

        Genera_num_hist()
    End Sub

    Private Sub cmb_nacionalidad_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_nacionalidad.KeyUp
        If e.KeyCode = Keys.F2 Then
            Llenar_combo_con_BD(Me.cmb_nacionalidad, "cod_nacionalidad", "nacionalidad", "nacionalidades", True, "nacionalidad")
        End If
    End Sub

    Private Sub cmb_nacionalidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_nacionalidad.LostFocus
        Validar_seleccion_combo(Me.cmb_nacionalidad)
    End Sub

    Private Sub cmb_nacionalidad_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_nacionalidad.SelectedValueChanged
        Validar_seleccion_combo(Me.cmb_nacionalidad)
    End Sub

    Private Sub Cmb_ocupacion_DisplayMemberChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_ocupacion.DisplayMemberChanged

    End Sub

    Private Sub Cmb_ocupacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_ocupacion.LostFocus
        Validar_seleccion_combo(Me.Cmb_ocupacion)
    End Sub

    Private Sub Cmb_ocupacion_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_ocupacion.SelectedValueChanged
        Validar_seleccion_combo(Me.Cmb_ocupacion)

    End Sub
    Private Sub Cmb_ocupacion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_ocupacion.TextChanged

    End Sub

    Private Sub Cmb_edo_civil_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_edo_civil.KeyUp
        If e.KeyCode = Keys.F2 Then
            Llenar_combo_con_BD(Me.Cmb_edo_civil, "cod_edo_civil", "estado_civil", "estado_civil", True, "estado_civil")
        End If
    End Sub

    Private Sub Cmb_edo_civil_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_edo_civil.LostFocus
        Validar_seleccion_combo(Cmb_edo_civil)
    End Sub
    Private Sub Cmb_edo_civil_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_edo_civil.SelectedValueChanged
        Validar_seleccion_combo(Cmb_edo_civil)
    End Sub

    Private Sub Cmb_edo_civil_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmb_edo_civil.TextChanged
        'Validar_seleccion_combo(Cmb_edo_civil)
    End Sub

    Private Sub Cmb_ocupacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_ocupacion.SelectedIndexChanged
        Informacion.SetToolTip(Me.Cmb_ocupacion, Me.Cmb_ocupacion.Text)
    End Sub


    Private Sub Link_busc_num_historia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Link_busc_num_historia.Click
        Hoja.SelectedTab = Principal
        cmb_opcn_busca.Text = Link_busc_num_historia.Text
        Txt_busca_princ.Focus()
    End Sub

    Private Sub Link_busc_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Link_busc_doc.Click
        Hoja.SelectedTab = Principal
        cmb_opcn_busca.Text = Link_busc_doc.Text
        Txt_busca_princ.Focus()
    End Sub

    Private Sub Link_busc_nombres_apellidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Link_busc_nombres_apellidos.Click
        Hoja.SelectedTab = Principal
        cmb_opcn_busca.Text = Link_busc_nombres_apellidos.Text
        Txt_busca_princ.Focus()
    End Sub

    Private Sub btn_cargar_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargar_foto.Click
        Guardar_Foto()
    End Sub
    Private Sub Guardar_Foto()
        'Dim dr As MySqlDataReader 'dr=data reader
        Dim data() As Byte 'arreglo de bytes el cual contedra la imagen
        'Dim pa As New System.Data.SqlClient.SqlParameter("@data", SqlDbType.VarBinary, 50) 'parametro de la sentencia sql
        Dim pa As New MySql.Data.MySqlClient.MySqlParameter("@data", MySqlDbType.Blob, 100)
        Dim ios As FileStream 'Manejo de archivos
        Dim comando As New MySqlCommand
        Dim sql_str As String = "SELECT * FROM fotos_perfil where num_historia='" & Var_historia_abierta
        Try
            ConectarBD()
            comando.CommandText = sql_str
            comando.Connection = myCloneCon


            If Modificar_historia = True Then

                Me.Dialogo_abrir.Filter = "Formato de imagenes permitidos|*.jpg;*.gif;*.png;*.bmp" 'filtro de archivos del OpenFileDialog 
                If Me.Dialogo_abrir.ShowDialog() = Windows.Forms.DialogResult.Cancel Then ' en caso de que se aplaste el boton cancelar salga y no haga nada
                    Exit Sub
                Else
                    ios = New FileStream(Me.Dialogo_abrir.FileName, FileMode.Open, FileAccess.Read) 'instanciamos en Stream indicandole la ruta del arvhivo,el modo de acceso y si es de lectura o escritura
                    ReDim data(ios.Length) 'llenamos el arreglo
                    ios.Read(data, 0, CInt(ios.Length)) 'llenamos el arreglo
                    Foto_datos_per.SizeMode = PictureBoxSizeMode.StretchImage 'establecemos como se visualiza la imagen
                    Foto_datos_per.Load(Me.Dialogo_abrir.FileName) 'visualizamos abriendo el archivo seleccionado

                    pa.Value = data 'llenamos la variable parametro con el arreglo
                    comando.Parameters.Add(pa) 'agregamos el parametro a la sentencia
                    comando.CommandText = "insert into fotos_perfil (idfoto,imagen,num_historia,guardado_por,fecha_g) values('',@data,'" & Var_historia_abierta & "','" & Cod_usuario & "','" & Format(Now, "yyyy-MM-dd - HH:mm:ss") & "')" ' realizacion la sentencia sql respectiva
                    comando.ExecuteReader()
                    'dr.Close()
                    'cierro y elimino variables
                    ios.Dispose()
                    Mostrar_informacion("inf", "Información", "Foto almacenada", True, 3000, btn_cargar_foto, "inf")

                    'muestro la foto almacenada y asigno variables para la elminacion en caso que se quiera elminar
                    Obtener_cant_registros("select num_historia from fotos_perfil where num_historia ='" & Var_historia_abierta & "'")

                    Lbl_Foto_mostrada.Text = "Foto " & Var_pu_cant_registros_de_consulta & " de " & Var_pu_cant_registros_de_consulta

                    mostrar_Foto_Datos_personales(Var_historia_abierta, Foto_datos_per, True, Var_pu_cant_registros_de_consulta - 1)
                    Num_foto_mostrada = Var_pu_cant_registros_de_consulta - 1
                    Habilita_Deshabilita_Botones_Foto()
                End If
            Else
                MsgBox("Debe archivar los datos del paciente para poder almacenar fotos, primero guarde la información del paciente y luego proceda a cargar las fotos", vbInformation, "Notificación")
            End If
            'detecto problemas
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Guardar_Foto", Mysql_ex.Number, Mysql_ex.Message)
            Mostrar_imagen_sistema("sin_foto.png", Foto_datos_per)
        Catch ex As Exception
            Mostrar_mensaje_error("Guardar_Foto", Err.Number, ex.Message)
            Mostrar_imagen_sistema("sin_foto.png", Foto_datos_per)
        Finally
            'si la conexion esta abierta la cierro
            If myCloneCon.State = 1 Then
                myCloneCon.Close()
            End If
            'descargo memoria de cmandos y consultas usadas para que el sistema no se vuelva lento e inestable
            pa = Nothing
            ios = Nothing
            data = Nothing
            comando.Dispose()
            myCloneCon.Dispose()
            dr = Nothing
            sql_str = Nothing
        End Try
    End Sub
    Private Sub mostrar_Foto_Datos_personales(ByVal Var_Foto_Historia As String, ByVal El_picture As PictureBox, ByVal limitar As Boolean, ByVal Num_foto As Integer)
        'crear objeto Conexión pasando como parámetro la cadena con los datos
        'Dim Con As New MySqlConnection(ConStr)
        'crear objeto comando que se encarga de ejecutar la Query pasando
        'como parámetro la sentencia SQl o Query y el objeto que contiene conexión
        Dim Sql As String
        'crear objeto DataReader que lee datos de la BD
        Dim Dr As MySqlDataReader
        'variable de datos
        Dim bDatos() As Byte
        'variable de imagen
        Dim iImagen As Image

        ''Crear cadena de conexión
        'Dim ConStr As String = "server=localhost;uid=miuser;password=mipass;database=imagenes"
        ''creamos Query o consulta SQL para llamar el campo que contiene la imágen
        Mostrar_ocultar_barra_progreso(Me.Barra_progreso_menu, "Cargando fotografía...", True)
        El_picture.Image = Nothing

        ConectarBD()
        If limitar = True Then
            Sql = "Select imagen,idfoto from fotos_perfil where num_historia='" & Var_Foto_Historia & "' order by idfoto asc limit " & Num_foto & ",1"
        Else
            Sql = "Select imagen,idfoto from fotos_perfil where num_historia='" & Var_Foto_Historia & "' order by idfoto asc "
        End If
        Dim Comando As New MySqlCommand(Sql, myCloneCon)

        Try
            If Not myCloneCon Is Nothing Then myCloneCon.Close()
            myCloneCon.Open()

            'Una vez establecida la conexión ejecutamos la Query
            'asignando el resultado al objeto MysqlDataReader
            Dr = Comando.ExecuteReader


            El_picture.Image = Nothing
            'Mientras este leyendo, cada resultado que por la Query
            ' no es mayor a uno
            If Dr.HasRows Then
                While Dr.Read
                    'Num_foto_mostrada = Num_foto_mostrada + 1
                    'lo guardamos en una variable de tipo array de bytes
                    'y convertimos en byte el resultado por si tenemos
                    'activado Option Strict en ON
                    bDatos = CType(Dr("imagen"), Byte())
                    'Dim MyImage As Bitmap

                    Var_ID_foto_mostrada = Dr("idfoto")
                    ' MsgBox(Var_ID_foto_mostrada)
                    'si la consulta no genera datos salimos del Sub
                    If bDatos.Length <> 0 Then
                        'SI HAY DATOS
                        'al ser datos binarios, los convertimos a imagen
                        'con una funcion que hicimos llamada bytes_imagen
                        'asignandolo a la variable de imagen
                        iImagen = Bytes_Imagen(bDatos)

                        'por último mostramos la imagen en el PictureBox
                        El_picture.SizeMode = PictureBoxSizeMode.StretchImage
                        El_picture.Image = iImagen
                        System.Windows.Forms.Application.DoEvents()
                        Exit While
                    Else
                        Mostrar_ocultar_barra_progreso(Me.Barra_progreso_menu, "", False)
                        El_picture.Image = Nothing
                        Mostrar_imagen_sistema("Sin_foto_Error_lectura.png", El_picture)
                        'Exit While
                    End If
                End While
            Else
                Mostrar_imagen_sistema("sin_foto.png", El_picture)
            End If
            'oculto mensaje y progreso
            Mostrar_ocultar_barra_progreso(Me.Barra_progreso_menu, "", False)
            'detecto problemas
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Mostrar_Foto_Datos_personales", Mysql_ex.Number, Mysql_ex.Message)
            Mostrar_imagen_sistema("sin_foto.png", Foto_datos_per)
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar_Foto_Datos_personales", Err.Number, ex.Message)
            Mostrar_imagen_sistema("sin_foto.png", Foto_datos_per)
        Finally
            'si la conexion esta abierta la cierro
            If myCloneCon.State = 1 Then
                myCloneCon.Close()
            End If
            'descargo memoria de cmandos y consultas usadas para que el sistema no se vuelva lento e inestable
            Comando.Dispose()
            myCloneCon.Dispose()
            Dr = Nothing
            iImagen = Nothing
            bDatos = Nothing
            Mostrar_ocultar_barra_progreso(Me.Barra_progreso_menu, "", False)
        End Try
    End Sub
    Private Sub mostrar_Foto(ByVal Var_Foto_Historia As String, ByVal El_picture As PictureBox, ByVal limitar As Boolean, ByVal Num_foto As Integer)
        ''Crear cadena de conexión
        'Dim ConStr As String = "server=localhost;uid=miuser;password=mipass;database=imagenes"
        ''creamos Query o consulta SQL para llamar el campo que contiene la imágen
        Mostrar_ocultar_barra_progreso(Me.Barra_progreso_menu, "Cargando fotografía...", True)
        El_picture.Image = Nothing
        Dim Sql As String
        ConectarBD()
        If limitar = True Then
            Sql = "Select imagen,idfoto from fotos_perfil where num_historia='" & Var_Foto_Historia & "' order by idfoto asc limit " & Num_foto & ",1"
        Else
            Sql = "Select imagen,idfoto from fotos_perfil where num_historia='" & Var_Foto_Historia & "' order by idfoto asc"
        End If
        'crear objeto Conexión pasando como parámetro la cadena con los datos
        'Dim Con As New MySqlConnection(ConStr)
        'crear objeto comando que se encarga de ejecutar la Query pasando
        'como parámetro la sentencia SQl o Query y el objeto que contiene conexión
        Dim Comando As New MySqlCommand(Sql, myCloneCon)
        'crear objeto DataReader que lee datos de la BD
        Dim Dr As MySqlDataReader
        'variable de datos
        Dim bDatos() As Byte
        'variable de imagen
        Dim iImagen As Image

        Try
            If Not myCloneCon Is Nothing Then myCloneCon.Close()
            myCloneCon.Open()

            'Una vez establecida la conexión ejecutamos la Query
            'asignando el resultado al objeto MysqlDataReader
            Dr = Comando.ExecuteReader


            El_picture.Image = Nothing
            'Mientras este leyendo, cada resultado que por la Query
            ' no es mayor a uno
            If Dr.HasRows Then
                While Dr.Read
                    'Num_foto_mostrada = Num_foto_mostrada + 1
                    'lo guardamos en una variable de tipo array de bytes
                    'y convertimos en byte el resultado por si tenemos
                    'activado Option Strict en ON
                    bDatos = CType(Dr("imagen"), Byte())
                    'Dim MyImage As Bitmap

                    'si la consulta no genera datos salimos del Sub
                    If bDatos.Length <> 0 Then
                        'SI HAY DATOS
                        'al ser datos binarios, los convertimos a imagen
                        'con una funcion que hicimos llamada bytes_imagen
                        'asignandolo a la variable de imagen
                        iImagen = Bytes_Imagen(bDatos)

                        'por último mostramos la imagen en el PictureBox
                        El_picture.SizeMode = PictureBoxSizeMode.StretchImage
                        El_picture.Image = iImagen
                        'para saber que foto se esta mostrando
                        Var_ID_foto_mostrada = Dr("idfoto")
                        System.Windows.Forms.Application.DoEvents()
                        Exit While
                    Else
                        Mostrar_ocultar_barra_progreso(Me.Barra_progreso_menu, "", False)
                        El_picture.Image = Nothing
                        Mostrar_imagen_sistema("Sin_foto_Error_lectura.png", El_picture)
                        'Exit While
                    End If
                End While
            Else
                Mostrar_imagen_sistema("sin_foto.png", El_picture)
            End If

            'oculto mensaje y progreso
            Mostrar_ocultar_barra_progreso(Me.Barra_progreso_menu, "", False)
            Comando.Dispose()
            iImagen = Nothing
            bDatos = Nothing
            myCloneCon.Dispose()
            'en caso de error mostramos el mensaje
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Mostrar_Foto", Mysql_ex.Number, Mysql_ex.Message)

            Mostrar_imagen_sistema("sin_foto.png", Foto_datos_per)
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar_Foto", Err.Number, ex.Message)
            Mostrar_imagen_sistema("sin_foto.png", Foto_datos_per)
        Finally
            'si la conexion esta abierta la cierro
            If myCloneCon.State = 1 Then
                myCloneCon.Close()
            End If
            'descargo memoria de cmandos y consultas usadas para que el sistema no se vuelva lento e inestable
            Comando.Dispose()
            myCloneCon.Dispose()
            Dr = Nothing
            iImagen = Nothing
            bDatos = Nothing
            Mostrar_ocultar_barra_progreso(Me.Barra_progreso_menu, "", False)
        End Try
    End Sub
    'convertir binario a imágen
    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub Lista_historias_buscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lista_historias_buscar.KeyDown
        If e.KeyCode = 13 Then
            Btn_abrir_historia_princ.Focus()
        End If
    End Sub

    Private Sub Lista_historias_buscar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_historias_buscar.SelectedIndexChanged
        'mostrar_Foto
        Num_foto_mostrada = 1
        If (Lista_historias_buscar.SelectedItems.Count > 0) Then
            lbl_nombre_princ.Text = Lista_historias_buscar.SelectedItems(0).SubItems(0).Text
            lbl_apellido_princ.Text = Lista_historias_buscar.SelectedItems(0).SubItems(1).Text
            Var_historia_para_abrir = Lista_historias_buscar.SelectedItems(0).SubItems(2).Text
            Lbl_num_hist_prin.Text = "Nº HISTORIA: " & Lista_historias_buscar.SelectedItems(0).SubItems(2).Text
            lbl_edad_princ.Text = "EDAD: " & Lista_historias_buscar.SelectedItems(0).SubItems(4).Text
            mostrar_Foto(Var_historia_para_abrir, Foto_busqueda, False, 0)
            Buscar_familiares_principal()
        End If
    End Sub

    Private Sub Btn_TB_Nuevo_pac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_TB_Nuevo_pac.Click
        Nuevo_paciente()
    End Sub
    Private Sub Nuevo_paciente()
        'limpio todos los controles de las hojas necesarias
        Hoja.SelectedTab = Datos_personales
        Limpiar_Controles(Datos_personales)
        Limpiar_Controles(Antecedentes)
        Modificar_historia = False
        Var_historia_abierta = ""
        Btn_cerrar_hist_tb.Enabled = False
        btn_eliminar_TB.Enabled = False
        btn_reporte_TB.Enabled = False
        Genera_num_hist()
        cmb_nacionalidad.Text = "SELECCIONAR"
        Cmb_edo_civil.Text = "SELECCIONAR"
        Cmb_ocupacion.Text = "SELECCIONAR"
        Cmb_Tipo_doc.Text = "SELECCIONAR"
        Cmb_sexo.Text = "SELECCIONAR"
        cmb_grupo_sang.Text = "SELECCIONAR"
        cmb_bebe.Text = "SELECCIONAR"
        cmb_fuma.Text = "SELECCIONAR"
        Cmb_Tipo_doc.Focus()
    End Sub
    Private Sub btn_buscar_datosper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Hoja.SelectedTab = Principal
    End Sub

    Private Sub Btn_abrir_historia_princ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_abrir_historia_princ.Click
        If Lista_historias_buscar.Items.Count > 0 Then
            Limpiar_Controles(Datos_personales)
            Limpiar_Controles(Antecedentes)
            Hoja.SelectedTab = Datos_personales
            'muestro la información filtrada
            Num_foto_mostrada = 0
            'mostrar_Foto_Datos_personales(Var_historia_para_abrir, Foto_datos_per, True, Num_foto_mostrada)
            Foto_datos_per.Image = Foto_busqueda.Image
            Var_historia_abierta = Lista_historias_buscar.FocusedItem.SubItems(2).Text

            Abrir_historia(Var_historia_abierta)
            'obtengo la cantidad de registros de fotos y agrego las fotos
            Obtener_cant_registros("select num_historia from fotos_perfil where num_historia ='" & Var_historia_para_abrir & "'")
            Lbl_Foto_mostrada.Text = "Foto " & Num_foto_mostrada & " de " & Var_pu_cant_registros_de_consulta

            'habilito o deshabilito los botones de siguiente elminar fotos
            If Var_pu_cant_registros_de_consulta > 0 Then
                Lbl_Foto_mostrada.Text = "Foto " & Num_foto_mostrada + 1 & " de " & Var_pu_cant_registros_de_consulta
                btn_elim_foto.Enabled = True
                btn_foto_sig.Enabled = True
                btn_foto_ant.Enabled = True
                If Num_foto_mostrada < Var_pu_cant_registros_de_consulta - 1 Then
                    btn_foto_sig.Enabled = True
                Else
                    btn_foto_sig.Enabled = False
                End If
                If Num_foto_mostrada > 0 Then
                    btn_foto_ant.Enabled = True
                Else
                    btn_foto_ant.Enabled = False
                End If
            Else
                btn_foto_sig.Enabled = False
                btn_foto_ant.Enabled = False
                btn_elim_foto.Enabled = False
                Lbl_Foto_mostrada.Text = "Foto " & Var_pu_cant_registros_de_consulta & " de " & Var_pu_cant_registros_de_consulta
            End If

        End If
    End Sub
    Private Sub Buscar_en_combo(ByVal cmbo As ComboBox, ByVal valor As String)
        'agrego en el combo el valor asignado en la base de datos
        Dim i As Integer = 0
        For i = 0 To cmbo.Items.Count - 1
            'el_combo.SelectedItem = i
            cmbo.SelectedIndex = i
            If cmbo.SelectedValue = valor Then
                cmbo.SelectedIndex = i
                System.Windows.Forms.Application.DoEvents()
                'el_combo.Text = el_combo.SelectedItem(i)
                Exit Sub
            Else
                'MsgBox("No esta seleccionado el valor : " & valor)
            End If
        Next
        cmbo = Nothing
    End Sub
    Private Sub Abrir_historia(ByVal Var_num_historia As String)

        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            comando.CommandText = "SELECT Datos_personales.*,tipo_identificacion.identificacion,nacionalidades.nacionalidad,estado_civil.estado_civil,profesiones.profesion,antecedentes.*" & _
            " FROM (Datos_personales INNER JOIN tipo_identificacion ON datos_personales.cod_tipo_iden=tipo_identificacion.cod_tipo_iden" & _
            " INNER JOIN nacionalidades ON datos_personales.cod_nacionalidad=nacionalidades.cod_nacionalidad" & _
             " INNER JOIN estado_civil ON datos_personales.cod_edo_civil=estado_civil.cod_edo_civil " & _
             " INNER JOIN profesiones ON datos_personales.cod_profesion=profesiones.cod_profesion" & _
             " left JOIN antecedentes ON datos_personales.num_historia=antecedentes.num_historia)" & _
            " where datos_personales.num_historia='" & Var_num_historia & "'"
            ConectarBD()
            comando.Connection = myCloneCon

            dr = comando.ExecuteReader()
            If dr.HasRows Then
                'clono la lista de familaires de la principal
                Me.Lista_HM_fam_datos_pers.Clear()

                'limpio la lista y agrego encabezados
                Lista_HM_fam_datos_pers.View = View.Details 'importante para que los datos se vean como lista
                Lista_HM_fam_datos_pers.Columns.Add("NOMBRES Y APELLIDOS", 100, HorizontalAlignment.Left)
                Lista_HM_fam_datos_pers.Columns.Add("PARENTESCO", 200, HorizontalAlignment.Left)
                Lista_HM_fam_datos_pers.Columns.Add("BENEFICIARIO", 200, HorizontalAlignment.Left)
                Lista_HM_fam_datos_pers.Columns.Add("Nº HISTORIA", 200, HorizontalAlignment.Left)

                For i = 0 To Lista_HM_familares_principal.Items.Count - 1
                    Dim item As New ListViewItem
                    item = Lista_HM_familares_principal.Items(i).Clone
                    Lista_HM_fam_datos_pers.Items.Add(item)
                Next
                Ajustar_tamaño_listas(Lista_HM_fam_datos_pers)
                Lista_HM_fam_datos_pers.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize)
                While dr.Read()
                    'activo lo boton
                    btn_asignar_familiar_Datos_per.Enabled = True
                    '...Agrego al listview la data de la consulta efectuada
                    'Buscar_en_combo(Cmb_Tipo_doc, dr("cod_tipo_iden"))

                    Cmb_Tipo_doc.Text = dr("identificacion")
                    chk_cotiza.Checked = dr("cotizante")
                    Lbl_Num_historia_datos_pers.Text = UCase(dr("num_historia"))
                    Lbl_fecha_creacion.Text = "Fecha Creado: " & FormatDateTime(dr("fecha_c"), DateFormat.LongDate)
                    txt_num_doc.Text = dr("n_identificacion")
                    txt_nombres.Text = StrConv(dr("nombres"), VbStrConv.ProperCase)
                    txt_apellidos.Text = StrConv(dr("apellidos"), VbStrConv.ProperCase)
                    'Buscar_en_combo(cmb_nacionalidad, dr("cod_nacionalidad"))
                    cmb_nacionalidad.Text = dr("Nacionalidad")
                    Cmb_edo_civil.Text = dr("estado_civil")
                    'Buscar_en_combo(Cmb_edo_civil, dr("cod_edo_civil"))

                    'Buscar_en_combo(Cmb_ocupacion, dr("cod_profesion"))
                    Cmb_ocupacion.Text = dr("profesion")
                    Cmb_sexo.Text = dr("sexo")
                    dt_fecha_nac.Text = dr("fecha_nac")
                    Calcular_edad(dr("fecha_nac"), Now)
                    Lbl_edad_datos_per.Text = Edad_Años.ToString & " Años"
                    txt_lugar_nac.Text = dr("lugar_nac")
                    txt_direccion_hab.Text = dr("direccion_hab")
                    txt_telf_movil.Text = dr("telf_cel")
                    txt_telf_fijo.Text = dr("telf_hab")
                    txt_telf_oficina.Text = dr("telf_ofi")
                    txt_telf_fax.Text = dr("telf_fax")
                    txt_telf_familiar.Text = dr("telf_otr")
                    txt_observaciones.Text = dr("notas")
                    Txt_email1.Text = dr("email1")
                    Txt_email2.Text = dr("email2")
                    'habilito el botones
                    Btn_cerrar_hist_tb.Enabled = True
                    Modificar_historia = True
                    btn_eliminar_TB.Enabled = True
                    btn_reporte_TB.Enabled = True
                    'verifico si tiene antecedentes
                    If Not IsDBNull(dr("grupo_sang")) Then
                        'lleno los antececentes si los tiene
                        Modificar_antecedentes = True
                        cmb_grupo_sang.Text = dr("grupo_sang")
                        If dr("drogas") = True Then
                            opc_drogas_si.Checked = True
                        Else
                            opc_drogas_no.Checked = True
                        End If
                        cmb_fuma.Text = dr("fuma")
                        cmb_bebe.Text = dr("bebe")
                        If dr("hepatitis") = True Then
                            opc_hepatitis_si.Checked = True
                        Else
                            opc_hepatitis_no.Checked = True
                        End If
                        If dr("asma") = True Then
                            opc_asma_si.Checked = True
                        Else
                            opc_asma_no.Checked = True
                        End If
                        If dr("diabetes") = True Then
                            opc_diabetes_si.Checked = True
                        Else
                            opc_diabetes_no.Checked = True
                        End If
                        txt_alergias.Text = dr("alergias")
                        txt_cirugias.Text = dr("cirugias")
                        txt_observaciones_antecedentes.Text = dr("observaciones")

                    Else 'es nullo
                        Modificar_antecedentes = False
                        If MsgBox("Falta suministrar la información de los antecedentes del paciente" & vbCrLf & "¿Desea suministrarlos en este momento?", vbQuestion + vbYesNo + vbDefaultButton1, "Ayuda del sistema") = vbYes Then
                            Limpiar_Controles(Antecedentes)
                            Hoja.SelectedTab = Antecedentes
                            cmb_grupo_sang.Focus()
                        End If
                    End If

                    Exit While
                End While
            Else
                Hoja.SelectedTab = Principal
                btn_asignar_familiar_Datos_per.Enabled = False
                MsgBox("No se encontró la historia solicitada", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If
            dr.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Abrir_historia", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Abrir_historia", Err.Number, ex.Message)
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

    Private Sub btn_foto_ant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_foto_ant.Click
        Obtener_cant_registros("select num_historia from fotos_perfil where num_historia ='" & Var_historia_abierta & "'")
        Num_foto_mostrada = Num_foto_mostrada - 1
        Lbl_Foto_mostrada.Text = "Foto " & Num_foto_mostrada + 1 & " de " & Var_pu_cant_registros_de_consulta
        Habilita_Deshabilita_Botones_Foto()
        mostrar_Foto_Datos_personales(Var_historia_abierta, Foto_datos_per, True, Num_foto_mostrada)

    End Sub

    Private Sub btn_foto_sig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_foto_sig.Click
        Obtener_cant_registros("select num_historia from fotos_perfil where num_historia ='" & Var_historia_abierta & "'")
        Num_foto_mostrada = Num_foto_mostrada + 1
        Lbl_Foto_mostrada.Text = "Foto " & Num_foto_mostrada + 1 & " de " & Var_pu_cant_registros_de_consulta
        Habilita_Deshabilita_Botones_Foto()
        mostrar_Foto_Datos_personales(Var_historia_abierta, Foto_datos_per, True, Num_foto_mostrada)
    End Sub
    Private Sub Habilita_Deshabilita_Botones_Foto()
        If Var_pu_cant_registros_de_consulta > 0 Then
            btn_elim_foto.Enabled = True
            btn_foto_sig.Enabled = True
            btn_foto_ant.Enabled = True
            If Num_foto_mostrada < Var_pu_cant_registros_de_consulta - 1 Then
                btn_foto_sig.Enabled = True
            Else
                btn_foto_sig.Enabled = False
            End If
            If Num_foto_mostrada > 0 Then
                btn_foto_ant.Enabled = True
            Else
                btn_foto_ant.Enabled = False
            End If
        Else
            btn_foto_sig.Enabled = False
            btn_foto_ant.Enabled = False
            btn_elim_foto.Enabled = False
        End If

    End Sub
    Private Sub btn_elim_foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_elim_foto.Click
        Eliminar_Foto(Var_ID_foto_mostrada)
    End Sub
    Private Sub Eliminar_Foto(ByVal Id As String)
        Dim sql As String = "Delete from fotos_perfil where idfoto='" & Id & "'"
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Dim total_reg_eliminados As Integer
        Try
            comando.CommandText = sql
            ConectarBD()
            comando.Connection = myCloneCon
            If MsgBox("Está seguro que desea eliminar la foto del perfil", vbYesNo + vbSystemModal + vbQuestion, "Confirme la eliminación") = vbYes Then
                total_reg_eliminados = comando.ExecuteNonQuery
                If total_reg_eliminados > 0 Then
                    Mostrar_informacion("inf", "Información", "Foto borrada", True, 3000, Lbl_Foto_mostrada, "exc")
                End If
                Obtener_cant_registros("select num_historia from fotos_perfil where num_historia ='" & Var_historia_abierta & "'")
                Num_foto_mostrada = Var_pu_cant_registros_de_consulta
                If Var_pu_cant_registros_de_consulta > 0 Then
                    mostrar_Foto_Datos_personales(Var_historia_abierta, Foto_datos_per, True, Num_foto_mostrada - 1)
                Else
                    Mostrar_imagen_sistema("Sin_foto.png", Foto_datos_per)
                End If
                Lbl_Foto_mostrada.Text = "Foto " & Var_pu_cant_registros_de_consulta & " de " & Var_pu_cant_registros_de_consulta
                Num_foto_mostrada = Var_pu_cant_registros_de_consulta - 1
                Habilita_Deshabilita_Botones_Foto()
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Eliminar_Foto", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Eliminar_Foto", Err.Number, ex.Message)
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
    Private Sub cmb_opcn_busca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_opcn_busca.SelectedIndexChanged
        Informativo_por_codigo.Dispose()
    End Sub
    Private Sub Txt_busca_princ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_busca_princ.TextChanged
        Informativo_por_codigo.Dispose()
    End Sub
    Private Sub Btn_cerrar_hist_tb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar_hist_tb.Click
        Limpiar_Controles(Datos_personales)
        Limpiar_Controles(Antecedentes)
        Hoja.SelectedTab = Principal
        Btn_cerrar_hist_tb.Enabled = False
        btn_eliminar_TB.Enabled = False
        btn_reporte_TB.Enabled = False
        Var_historia_abierta = ""
        Modificar_historia = False

    End Sub

    Private Sub dt_fecha_nac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dt_fecha_nac.ValueChanged
        Calcular_edad(dt_fecha_nac.Value, Now)
        Lbl_edad_datos_per.Text = Edad_Años & " años"
    End Sub
    Private Sub Archivar_Datos_personales()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        Dim Reg_afectados As Double
        Try
            Paso_guarda_datos_per = False
            If Modificar_historia = False Then
                sql_str = "INSERT INTO datos_personales (num_historia,cotizante, id_num_historia , cod_tipo_iden,  n_identificacion,  nombres,  apellidos,  cod_nacionalidad,  cod_edo_civil,  cod_profesion,  sexo,  fecha_nac,  lugar_nac,  direccion_hab,  telf_cel, telf_hab,  telf_ofi,  telf_fax,  telf_otr,  notas,  email1, email2,  guardado_por,  fecha_c,  fecha_m) values ('" & _
                Lbl_Num_historia_datos_pers.Text & "'," & _
                chk_cotiza.Checked & ",'" & _
                Lbl_Num_historia_datos_pers.Text & "','" & _
                Cmb_Tipo_doc.SelectedValue & "','" & _
                txt_num_doc.Text & "','" & _
                UCase(txt_nombres.Text) & "','" & _
                UCase(txt_apellidos.Text) & "','" & _
                cmb_nacionalidad.SelectedValue & "','" & _
                Cmb_edo_civil.SelectedValue & "','" & _
                Cmb_ocupacion.SelectedValue & "','" & _
                Cmb_sexo.Text & "','" & _
                Format(dt_fecha_nac.Value, "yyyy-MM-dd") & "','" & _
                txt_lugar_nac.Text & "','" & _
                txt_direccion_hab.Text & "','" & _
                txt_telf_movil.Text & "','" & _
                txt_telf_fijo.Text & "','" & _
                txt_telf_oficina.Text & "','" & _
                txt_telf_fax.Text & "','" & _
                txt_telf_familiar.Text & "','" & _
                txt_observaciones.Text & "','" & _
                Txt_email1.Text & "','" & _
                Txt_email2.Text & "','" & _
                Cod_usuario & "','" & _
                Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & _
                Format(Now, "yyyy-MM-dd HH:mm:ss") & "')"
                comando.CommandText = sql_str
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                'MsgBox("Los datos del paciente " & Chr(34) & txt_nombres.Text & " " & txt_apellidos.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")

                Var_historia_abierta = Lbl_Num_historia_datos_pers.Text
                'activo los botones de reporte y eliminar
                btn_eliminar_TB.Enabled = True
                btn_reporte_TB.Enabled = True
                Btn_cerrar_hist_tb.Enabled = True
                System.Windows.Forms.Application.DoEvents()
                Modificar_antecedentes = False
            Else
                sql_str = "update datos_personales set " & _
                "num_historia='" & Lbl_Num_historia_datos_pers.Text & "'," & _
                "cotizante=" & chk_cotiza.Checked & "," & _
                "id_num_historia='" & Lbl_Num_historia_datos_pers.Text & "'," & _
                "cod_tipo_iden='" & Cmb_Tipo_doc.SelectedValue & "'," & _
                "n_identificacion='" & txt_num_doc.Text & "'," & _
                "nombres='" & UCase(txt_nombres.Text) & "'," & _
                "apellidos='" & UCase(txt_apellidos.Text) & "'," & _
                "cod_nacionalidad='" & cmb_nacionalidad.SelectedValue & "'," & _
                "cod_edo_civil='" & Cmb_edo_civil.SelectedValue & "'," & _
                "cod_profesion='" & Cmb_ocupacion.SelectedValue & "'," & _
                "sexo='" & Cmb_sexo.Text & "'," & _
                "fecha_nac='" & Format(dt_fecha_nac.Value, "yyyy,MM,dd") & "'," & _
                "lugar_nac='" & txt_lugar_nac.Text & "'," & _
                "direccion_hab='" & txt_direccion_hab.Text & "'," & _
                "telf_cel='" & txt_telf_movil.Text & "'," & _
                "telf_hab='" & txt_telf_fijo.Text & "'," & _
                "telf_ofi='" & txt_telf_oficina.Text & "'," & _
                "telf_fax='" & txt_telf_fax.Text & "'," & _
                "telf_otr='" & txt_telf_familiar.Text & "'," & _
                "notas='" & txt_observaciones.Text & "'," & _
                "guardado_por='" & Cod_usuario & "'," & _
                "fecha_m='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," & _
                "email1='" & Txt_email1.Text & "'," & _
                "email2='" & Txt_email2.Text & "'" & _
                " where num_historia='" & Var_historia_abierta & "'"
                comando.CommandText = sql_str
                ConectarBD()
                comando.Connection = myCloneCon
                Reg_afectados = comando.ExecuteNonQuery()

                Var_historia_abierta = Lbl_Num_historia_datos_pers.Text
                'MsgBox("Los datos del paciente " & Chr(34) & txt_nombres.Text & " " & txt_apellidos.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                btn_reporte_TB.Enabled = True
                btn_eliminar_TB.Enabled = True
                Btn_cerrar_hist_tb.Enabled = True
                Modificar_antecedentes = True
            End If
            Paso_guarda_datos_per = True
            System.Windows.Forms.Application.DoEvents()
            Archivar_antecedentes()
            'verifico si paso ambos almacenajes de ser asi lo notifico de lo contrario verifico que no se guardo y tambien muestro el mensaje
            If Paso_guarda_datos_per = True And Paso_guarda_antecedentes = True Then
                MsgBox("Los datos del paciente " & Chr(34) & txt_nombres.Text & " " & txt_apellidos.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
            Else
                If Paso_guarda_datos_per = True And Paso_guarda_antecedentes = False Then  'si se almaceno los datos per y no los antecedentes lo notifico
                    MsgBox("Los datos del paciente " & Chr(34) & txt_nombres.Text & " " & txt_apellidos.Text & Chr(34) & " se archivaron, pero se produjo un error al almacenar los antecedentes, verifique la información e intente de nuevo", vbExclamation, "Notificación")
                Else
                    If Paso_guarda_datos_per = False And Paso_guarda_antecedentes = True Then
                        MsgBox("Los antecedentes del paciente " & Chr(34) & txt_nombres.Text & " " & txt_apellidos.Text & Chr(34) & " se archivaron, pero se produjo un error al almacenar los datos personales, verifique la información e intente de nuevo", vbExclamation, "Notificación")
                    Else
                        If Paso_guarda_datos_per = False And Paso_guarda_antecedentes = False Then
                            MsgBox("No se pudo almacenar los datos del paciente " & Chr(34) & txt_nombres.Text & " " & txt_apellidos.Text & Chr(34) & ", verifique la información e intente de nuevo", vbExclamation, "Notificación")
                        End If
                    End If
                End If
            End If

            Modificar_historia = True

        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar_Datos_personales", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_Datos_personales", Err.Number, ex.Message)

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
    Private Sub btn_archivar_dp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        paso_Validacion = False
        valida_archivar()
        If paso_Validacion = True Then
            Archivar_Datos_personales()
        End If
    End Sub

    Private Sub Cmb_Tipo_doc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Tipo_doc.SelectedIndexChanged

    End Sub
    Public Sub Genera_num_hist()
        On Error GoTo Err
        Lbl_Num_historia_datos_pers.Text = Microsoft.VisualBasic.Left(Cmb_Tipo_doc.SelectedValue, 6) & "-" & txt_num_doc.Text
Err:
        If Err.Number <> 0 Then
            Resume Next
        End If

    End Sub

    Private Sub txt_num_doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_num_doc.TextChanged
        Genera_num_hist()
    End Sub

    Private Sub btn_eliminar_TB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Lista_historias_familares_principal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lista_HM_familares_principal.SelectedIndexChanged
        'mostrar_Foto
        Num_foto_mostrada = 1
        If (Lista_HM_familares_principal.SelectedItems.Count > 0) Then
            lbl_nombre_princ.Text = Lista_HM_familares_principal.SelectedItems(0).SubItems(0).Text
            lbl_apellido_princ.Text = Lista_HM_familares_principal.SelectedItems(0).SubItems(1).Text
            Var_historia_para_abrir = Lista_HM_familares_principal.SelectedItems(0).SubItems(3).Text
            Lbl_num_hist_prin.Text = "Nº HISTORIA: " & Lista_HM_familares_principal.SelectedItems(0).SubItems(3).Text
            lbl_edad_princ.Text = "EDAD: " & Lista_HM_familares_principal.SelectedItems(0).SubItems(4).Text
            mostrar_Foto(Var_historia_para_abrir, Foto_busqueda, False, 0)
        End If

    End Sub
    Private Sub Eliminar_Historia(ByVal Num_historia As String)
        Dim sql As String = "Delete from datos_personales where num_historia='" & Num_historia & "'"
        Dim comando As New MySqlCommand
        Try
            comando.CommandText = sql
            ConectarBD()
            comando.Connection = myCloneCon
            If MsgBox("Está seguro que desea eliminar la historia Nº " & Var_historia_abierta & " del paciente " & txt_nombres.Text & " " & txt_apellidos.Text, vbYesNo + vbSystemModal + vbQuestion, "Confirme la eliminación") = vbYes Then
                'comando.ExecuteReader()
                'myCloneCon.Close()
                'ConectarBD()
                Cant_Reg = comando.ExecuteNonQuery
                MsgBox("Los datos del paciente " & Chr(34) & txt_nombres.Text & " " & txt_apellidos.Text & Chr(34) & " se borraron", vbInformation, "Notificación")
                Mostrar_imagen_sistema("Sin_foto.png", Foto_datos_per)
                Limpiar_Controles(Me)
                Var_historia_abierta = ""
                btn_eliminar_TB.Enabled = False
                btn_reporte_tb.Enabled = False
            End If
            Habilita_Deshabilita_Botones_Foto()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Eliminar_Historia", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Eliminar_Historia", Err.Number, ex.Message)
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

    Private Sub UbicaciónGeográficaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbicaciónGeográficaToolStripMenuItem.Click
        Mostrar_formulario(frm_estados, False)
    End Sub

    Private Sub TurnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnosToolStripMenuItem.Click
        Mostrar_formulario(frm_turnos, False)
    End Sub

    Private Sub EspecialidadesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecialidadesToolStripMenuItem1.Click
        Mostrar_formulario(Especialidades, False)
    End Sub

    Private Sub CargarContenidoDeLasListasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargarContenidoDeLasListasToolStripMenuItem.Click
        'LLeno los combos con los valores almacenados en las tablas de las bases de datos
        If MsgBox("Esta opción cerrará la historia abierta, ¿Desea continuar?", vbQuestion + vbYesNo, "Confirme la instruccion") = vbYes Then
            Limpiar_Controles(Me)
            Modificar_historia = False

            Hoja.SelectedTab = Principal
            Refrescar_contenido_combos()
        End If
    End Sub

    Private Sub NuevoPacienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoPacienteToolStripMenuItem.Click
        Nuevo_paciente()
    End Sub

    Private Sub BuscarPacienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarPacienteToolStripMenuItem.Click
        Hoja.SelectedTab = Principal
        cmb_opcn_busca.Text = Link_busc_nombres_apellidos.Text
        Txt_busca_princ.Focus()
    End Sub

    Private Sub Foto_datos_per_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Foto_datos_per.Click
        Dim ELFORM As New frm_expandir_foto
        ELFORM.foto.Image = Foto_datos_per.Image
        ELFORM.Show()
        ELFORM.BringToFront()
    End Sub

    Private Sub DepartamentosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem1.Click
        Mostrar_formulario(frm_empresas, False)
    End Sub

    Private Sub Recargar_combos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recargar_combos.Click
        If MsgBox("Esta opción cerrará la historia abierta, ¿Desea continuar?", vbQuestion + vbYesNo, "Confirme la instruccion") = vbYes Then
            Limpiar_Controles(Me)
            Modificar_historia = False

            Hoja.SelectedTab = Principal
            Refrescar_contenido_combos()
        End If

    End Sub

    Private Sub AreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreasToolStripMenuItem.Click
        Mostrar_formulario(frm_areas, False)
    End Sub

    Private Sub DependenciasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DependenciasToolStripMenuItem1.Click
        Mostrar_formulario(frm_departamentos, False)
    End Sub

    Private Sub CargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargosToolStripMenuItem.Click
        Mostrar_formulario(frm_cargos, False)
    End Sub

    Private Sub ProfesionesOcupacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesionesOcupacionesToolStripMenuItem.Click
        Mostrar_formulario(frm_profesiones, False)
    End Sub
    Private Sub valida_archivar()
        If Cmb_Tipo_doc.Text = "SELECCIONAR" Then
            Hoja.SelectedTab = Datos_personales
            Cmb_Tipo_doc.DroppedDown = True
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar un valor válido en el tipo de documento", True, 3000, Cmb_Tipo_doc, "err")
            Exit Sub
        End If
        If txt_num_doc.Text = "" Then
            Hoja.SelectedTab = Datos_personales
            Mostrar_informacion("err", "Faltan datos", "El campo  Nº de documento debe contener algún valor", True, 3000, txt_num_doc, "err")
            txt_num_doc.Focus()
            Exit Sub
        End If
        If txt_nombres.Text = "" Then
            Hoja.SelectedTab = Datos_personales
            Mostrar_informacion("err", "Faltan datos", "El campo  nombre debe contener algún valor", True, 3000, txt_nombres, "err")
            txt_nombres.Focus()
            Exit Sub
        End If
        If txt_apellidos.Text = "" Then
            Hoja.SelectedTab = Datos_personales
            Mostrar_informacion("err", "Faltan datos", "El campo  apellidos debe contener algún valor", True, 3000, txt_apellidos, "err")
            txt_apellidos.Focus()
            Exit Sub
        End If
        If Cmb_sexo.Text = "SELECCIONAR" Then
            Hoja.SelectedTab = Datos_personales
            Cmb_sexo.DroppedDown = True
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar el sexo del paciente", True, 3000, Cmb_sexo, "err")
            Exit Sub
        End If
        If cmb_nacionalidad.Text = "SELECCIONAR" Then
            Hoja.SelectedTab = Datos_personales
            cmb_nacionalidad.DroppedDown = True
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar un valor válido en el campo nacionalidad", True, 3000, cmb_nacionalidad, "err")
            Exit Sub
        End If
        If Cmb_edo_civil.Text = "SELECCIONAR" Then
            Hoja.SelectedTab = Datos_personales
            Cmb_edo_civil.DroppedDown = True
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar un valor válido en el campo estado civil", True, 3000, Cmb_edo_civil, "err")
            Exit Sub
        End If
        If Cmb_ocupacion.Text = "SELECCIONAR" Then
            Hoja.SelectedTab = Datos_personales
            Cmb_ocupacion.DroppedDown = True
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar un valor válido en el campo profesión o ocupación", True, 3000, Cmb_ocupacion, "err")
            Exit Sub
        End If
        If cmb_grupo_sang.Text = "SELECCIONAR" Then
            Hoja.SelectedTab = Antecedentes
            cmb_grupo_sang.DroppedDown = True
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar un valor válido en el campo grupo sanguíneo", True, 3000, cmb_grupo_sang, "err")
            Exit Sub
        End If
        If cmb_fuma.Text = "SELECCIONAR" Then
            Hoja.SelectedTab = Antecedentes
            cmb_fuma.DroppedDown = True
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar un valor válido en el campo fumador", True, 3000, cmb_fuma, "err")
            Exit Sub
        End If
        If cmb_bebe.Text = "SELECCIONAR" Then
            Hoja.SelectedTab = Antecedentes
            cmb_bebe.DroppedDown = True
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar un valor válido en el campo bebe", True, 3000, cmb_bebe, "err")
            Exit Sub
        End If
        If opc_drogas_si.Checked = False And opc_drogas_no.Checked = False Then
            Hoja.SelectedTab = Antecedentes
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar si el paciente usa drogas", True, 3000, opc_drogas_si, "err")
            Exit Sub
        End If
        If opc_hepatitis_si.Checked = False And opc_hepatitis_no.Checked = False Then
            Hoja.SelectedTab = Antecedentes
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar si el paciente ha padecido de hepatitis", True, 3000, opc_hepatitis_si, "err")
            Exit Sub
        End If
        If opc_asma_si.Checked = False And opc_asma_no.Checked = False Then
            Hoja.SelectedTab = Antecedentes
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar si el paciente ha padecido asma", True, 3000, opc_asma_si, "err")
            Exit Sub
        End If
        If opc_diabetes_si.Checked = False And opc_diabetes_no.Checked = False Then
            Hoja.SelectedTab = Antecedentes
            Mostrar_informacion("err", "Faltan datos", "Debe seleccionar si el paciente es diabético", True, 3000, opc_diabetes_si, "err")
            Exit Sub
        End If
        paso_Validacion = True
    End Sub
    Private Sub Archivar_TB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Archivar_TB.Click
        'If Hoja.SelectedTab Is Datos_personales Then
        paso_Validacion = False
        valida_archivar()
        If paso_Validacion = True Then
            Archivar_Datos_personales() 'dentro de este se llama a archivar antecedentes ojo
        End If
        'End If
    End Sub

    Private Sub Archivar_TB_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Archivar_TB.MouseMove
        If Hoja.SelectedTab Is Datos_personales Then
            Archivar_TB.ToolTipText = "Archivar datos personales del paciente"
            Exit Sub
        End If
        If Hoja.SelectedTab Is Antecedentes Then
            Archivar_TB.ToolTipText = "Archivar los antecedentes médicos"
            Exit Sub
        End If
    End Sub

    Private Sub DoctoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctoresToolStripMenuItem.Click
        Mostrar_formulario(frm_asig_medico_espec, False)
    End Sub

    Private Sub btn_eliminar_TB_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar_TB.Click
        'If Hoja.SelectedTab Is Datos_personales Then
        Eliminar_Historia(Var_historia_abierta)
        'End If
    End Sub
    Private Sub Archivar_antecedentes()
        Dim sql_str As String
        Dim comando As New MySqlCommand
        'Dim Reg_afectados As Double
        Try
            Paso_guarda_antecedentes = False
            If Modificar_antecedentes = False Then
                sql_str = "INSERT INTO antecedentes (num_historia,grupo_sang,drogas,hepatitis,asma,diabetes,fuma,bebe,alergias,cirugias,observaciones,fecha_g,guardado_por) values ('" & _
                Lbl_Num_historia_datos_pers.Text & "','" & _
                cmb_grupo_sang.Text & "'," & _
                opc_drogas_si.Checked & "," & _
                opc_hepatitis_si.Checked & "," & _
                opc_asma_si.Checked & "," & _
                opc_diabetes_si.Checked & ",'" & _
                cmb_fuma.Text & "','" & _
                cmb_bebe.Text & "','" & _
                txt_alergias.Text & "','" & _
                txt_cirugias.Text & "','" & _
                txt_observaciones_antecedentes.Text & "','" & _
                Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" & _
                Cod_usuario & "')"

                comando.CommandText = sql_str
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteNonQuery()
                Modificar_antecedentes = True
                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se archivaron correctamente", True, 3500, lista_buscar, "inf")
                'MsgBox("Los datos del descrip_Cargo " & Chr(34) & txt_cargo.Text & Chr(34) & " se archivaron correctamente", vbInformation, "Notificación")
                'Modificar = True
                'Var_cod_cargo = txt_codigo.Text
                'activo los botones de reporte y eliminar
                'btn_eliminar.Enabled = True
                'txt_busca.Text = ""
                'Buscar_cargo()
            Else
                sql_str = "update antecedentes set " & _
                "num_historia='" & Var_historia_abierta & "'," & _
                "grupo_sang='" & cmb_grupo_sang.Text & "'," & _
                "drogas=" & opc_drogas_si.Checked & "," & _
                "hepatitis=" & opc_hepatitis_si.Checked & "," & _
                "asma=" & opc_asma_si.Checked & "," & _
                "diabetes=" & opc_diabetes_si.Checked & "," & _
                "fuma='" & cmb_fuma.Text & "'," & _
                "bebe='" & cmb_bebe.Text & "'," & _
                "alergias='" & txt_alergias.Text & "'," & _
                "cirugias='" & txt_cirugias.Text & "'," & _
                "observaciones='" & txt_observaciones_antecedentes.Text & "'," & _
                "guardado_por='" & Cod_usuario & "'," & _
                "fecha_g='" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'" & _
                " where num_historia='" & Var_historia_abierta & "'"
                comando.CommandText = UCase(sql_str)
                ConectarBD()
                comando.Connection = myCloneCon
                comando.ExecuteReader()
                Modificar_antecedentes = True
                'Mostrar_informacion("inf", "Notificación", "Los datos de la especialidad " & Chr(34) & txt_especialidad.Text & Chr(34) & " se modificaron correctamente", True, 2500, lista_buscar, "inf")
                'MsgBox("Los datos del cargo " & Chr(34) & txt_cargo.Text & Chr(34) & " se modificaron correctamente, se actualizaron (" & Reg_afectados.ToString & ") registro(s) ", vbInformation, "Notificación")
                'activo los botones de accion
                'Modificar = True
                'Var_cod_cargo = txt_codigo.Text
                'activo los botones de reporte y eliminar
                'btn_eliminar.Enabled = True
                'Limpiar_Controles(Lista_buscar)
                'txt_busca.Text = ""
                'Buscar_cargo()
            End If
            Paso_guarda_antecedentes = True
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Archivar _antecedentes", Mysql_ex.Number, Mysql_ex.Message)

        Catch ex As Exception
            Mostrar_mensaje_error("Archivar_antecedentes", Err.Number, ex.Message)

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

    Private Sub btn_archivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Archivar_antecedentes()
    End Sub

    Private Sub boton_control_citas_TB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton_control_citas_TB.Click
        Mostrar_mensaje_Espera("Espere...", "Abriendo el control de citas", False, "PROC", 1, 2, False)
        Mostrar_formulario(frm_control_cita, False)
        frm_espera.Close()
    End Sub

    Private Sub OtorgarCitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OtorgarCitasToolStripMenuItem.Click
        Mostrar_formulario(frm_control_cita, False)
    End Sub

    Private Sub ListadoDeTurnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeTurnosToolStripMenuItem.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE TURNOS", "Listado de turnos-especialidad.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub EspecialidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EspecialidadesToolStripMenuItem.Click
        Try
            'Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE ESPECIALIDADES", "listado de especialidades.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub RestaurarBDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestaurarBDToolStripMenuItem.Click
        Mostrar_formulario(frm_restaurar, True)
    End Sub

    Private Sub CopiaDeSeguridadDeBDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiaDeSeguridadDeBDToolStripMenuItem.Click
        Mostrar_formulario(frm_respaldar, True)
    End Sub

    Private Sub DependenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DependenciasToolStripMenuItem.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE EMPRESAS / EMPRESAS", "listado de empresas.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub ListadoDepacientesAtendidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDepacientesAtendidosToolStripMenuItem.Click
        Try
            frm_resumen_citas.Close()
            Mostrar_formulario(frm_resumen_citas, False)
            Llenar_combo_con_BD(frm_resumen_citas.cmb_estatus_cita, "cod_edo_cita", "descrip_edo_cita", "estado_cita", True, "cod_edo_cita")
            frm_resumen_citas.cmb_estatus_cita.SelectedValue = ""
            frm_resumen_citas.cmb_estatus_cita.SelectedValue = "0001"
            'frm_resumen_citas.cmb_estatus_cita.Text = "ATENDIDO"
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub ListadoDeCitascanceladasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeCitascanceladasToolStripMenuItem.Click
        Try
            frm_resumen_citas.Close()
            Mostrar_formulario(frm_resumen_citas, False)
            Llenar_combo_con_BD(frm_resumen_citas.cmb_estatus_cita, "cod_edo_cita", "descrip_edo_cita", "estado_cita", True, "cod_edo_cita")
            frm_resumen_citas.cmb_estatus_cita.SelectedValue = ""
            frm_resumen_citas.cmb_estatus_cita.SelectedValue = "0002"
            'frm_resumen_citas.cmb_estatus_cita.Text = "ATENDIDO"
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub ListadogeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadogeneralToolStripMenuItem.Click
        Try
            frm_resumen_citas.Close()
            Mostrar_formulario(frm_resumen_citas, False)
            Llenar_combo_con_BD(frm_resumen_citas.cmb_estatus_cita, "cod_edo_cita", "descrip_edo_cita", "estado_cita", True, "cod_edo_cita")
            frm_resumen_citas.cmb_estatus_cita.SelectedValue = ""
            frm_resumen_citas.cmb_estatus_cita.SelectedValue = "0000"
            'frm_resumen_citas.cmb_estatus_cita.Text = "ATENDIDO"
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub cmb_nacionalidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_nacionalidad.SelectedIndexChanged

    End Sub

    Private Sub Cmb_edo_civil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_edo_civil.SelectedIndexChanged

    End Sub

    Private Sub Cmb_ocupacion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_ocupacion.KeyUp
        If e.KeyCode = Keys.F2 Then
            Llenar_combo_con_BD(Me.Cmb_ocupacion, "cod_profesion", "Profesion", "profesiones", True, "Profesion")
        End If
    End Sub

    Private Sub DepartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE DEPARTAMENTOS", "listado de departamentos.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub CargosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargosToolStripMenuItem1.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE CARGOS", "listado de cargos.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub AreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaToolStripMenuItem.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE AREAS", "listado de areas.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try
    End Sub

    Private Sub BeneficiariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeneficiariosToolStripMenuItem.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            frm_reportes.Muestra_reporte("LISTADO DE BENEFICIARIOS DEL IVSS", "listado de beneficiarios.rpt", "", 120, Nombre_usuario_actual)
            frm_espera.Close()

        Catch ex As Exception
            frm_espera.Close()
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try

    End Sub

    Private Sub DiasNoLaborablesMedicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiasNoLaborablesMedicosToolStripMenuItem.Click
        Mostrar_formulario(frm_dias_no_laborables, False)
    End Sub

    Private Sub btn_reporte_TB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reporte_TB.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Abriendo el informe", False, "CHECK", 1, 2, False)
            Dim formula_seleccion As String = ""
            formula_seleccion = "{datos_personales.num_historia}='" & Lbl_Num_historia_datos_pers.Text & "'"
            frm_reportes.Muestra_reporte("HISTORIA MÉDICA (HOJA PRINCIPAL)", "Expediente.rpt", formula_seleccion, 120, Nombre_usuario_actual)
            frm_espera.Close()
        Catch ex As Exception
            Mostrar_mensaje_error("Mostrar reporte", Err.Number, ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_espera.Show()
    End Sub

    Private Sub DiasFeriadosNoLaborablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiasFeriadosNoLaborablesToolStripMenuItem.Click
        Mostrar_formulario(frm_feriados, False)
    End Sub

    Private Sub ACercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACercaDeToolStripMenuItem.Click
        Mostrar_formulario(frm_acerca_de, True)
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        On Error Resume Next
        'se agregaron dos variables publicas para validar el cierre de sesion y la salida del sistema verlar en modulo variables globales y en el load y validarcion de acceso de l sistema se le asignan valores a esas claves
        If MsgBox("¿Está seguro que desea cerrar la sesión?", vbQuestion + vbSystemModal + vbYesNo + vbDefaultButton2, "Ayuda del sistema") = vbYes Then
            While My.Application.OpenForms.Count > 1
                CANCELAR_CIERRE = False
                On Error Resume Next
                For Each formularios In SIGAC.My.Application.OpenForms
                    If formularios Is frm_clave Then
                        CANCELAR_CIERRE = True
                    End If
                    If formularios Is Me Then
                        PREGUNTA_CIERRE = False 'PARA DECIRLE QUE NO PREGUNTE AL USUARIO SI DESEA CERRAR
                    End If
                    formularios.Close()

                    'formularios.BackColor = My.Settings.color
                Next formularios
            End While
            frm_clave.Show()
            frm_clave.txt_clave.Text = ""
            frm_clave.txt_usuario.Text = ""
            frm_clave.txt_usuario.Focus()
            'cierro la ventana en memoria ram
            nueva_ventana.Dispose()
            frm_clave.Visible = True
            frm_clave.BringToFront()
        End If
    End Sub

    Private Sub btn_salir_tb_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_tb.ButtonClick
        CANCELAR_CIERRE = True
        Me.Close()
    End Sub

    Private Sub CuentasDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasDeUsuarioToolStripMenuItem.Click
        Mostrar_formulario(frm_usuarios, False)
    End Sub

    Private Sub AsignarFamiliaresAHistoriaActualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarFamiliaresAHistoriaActualToolStripMenuItem.Click
        frm_asig_familiares.lbl_num_hist_paciente.Text = Lbl_Num_historia_datos_pers.Text
        frm_asig_familiares.lbl_nombres_paciente.Text = txt_nombres.Text & " " & txt_apellidos.Text
        Mostrar_formulario(frm_asig_familiares, False)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_asignar_familiar_Datos_per.Click
        frm_asig_familiares.lbl_num_hist_paciente.Text = Lbl_Num_historia_datos_pers.Text
        frm_asig_familiares.lbl_nombres_paciente.Text = txt_nombres.Text & " " & txt_apellidos.Text
        Mostrar_formulario(frm_asig_familiares, False)
    End Sub

    Private Sub HistoriaClinicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoriaClinicaToolStripMenuItem.Click
        If Modificar_historia = True Then
            AsignarFamiliaresAHistoriaActualToolStripMenuItem.Enabled = True
        Else
            AsignarFamiliaresAHistoriaActualToolStripMenuItem.Enabled = False
        End If
    End Sub
    Public Sub Buscar_familiares_principal()
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            comando.CommandText = "SELECT familiares.*, datos_personales.nombres,datos_personales.apellidos,afinidades.afinidad FROM (familiares inner join datos_personales on datos_personales.num_historia=familiares.cod_familiar inner join afinidades on afinidades.cod_afinidad=familiares.cod_afinidad) where familiares.num_historia='" & Var_historia_para_abrir & "' order by datos_personales.nombres,datos_personales.apellidos"
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            Lista_HM_familares_principal.Clear()
            Me.Lista_HM_fam_datos_pers.Clear()

            'limpio la lista y agrego encabezados
            Lista_HM_familares_principal.View = View.Details 'importante para que los datos se vean como lista
            Lista_HM_familares_principal.Columns.Add("NOMBRES Y APELLIDOS", 100, HorizontalAlignment.Left)
            Lista_HM_familares_principal.Columns.Add("PARENTESCO", 200, HorizontalAlignment.Left)
            Lista_HM_familares_principal.Columns.Add("BENEFICIARIO", 200, HorizontalAlignment.Left)
            Lista_HM_familares_principal.Columns.Add("Nº HISTORIA", 200, HorizontalAlignment.Left)

            If dr.HasRows Then


                'agrego a la lista todo
                While dr.Read()
                    MyListText(0) = StrConv(dr("nombres") & " " & dr("apellidos"), VbStrConv.ProperCase)
                    MyListText(1) = StrConv(dr("afinidad"), VbStrConv.ProperCase)
                    If dr("beneficiario") = True Then
                        MyListText(2) = "SI"
                    Else
                        MyListText(2) = "NO"
                    End If

                    MyListText(3) = dr("cod_familiar")
                    MyListItem = New ListViewItem(MyListText)
                    '.....Muestro los datos en el list

                    Lista_HM_familares_principal.Items.Add(MyListItem)
                End While
                Ajustar_tamaño_listas(Me.Lista_HM_familares_principal)
                Lista_HM_familares_principal.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize)
                'Lista_buscar.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent)
                'lista_buscar.Items(0).Selected = True
                'lista_buscar.Focus()
            Else
                'MsgBox("No se encontró el area", MsgBoxStyle.Information + vbSystemModal, "Ayuda del sistema")
            End If
            dr.Close()
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Buscar_familiares_principal", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Buscar_familiares_principal", Err.Number, ex.Message)
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

    Private Sub SalirDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        CANCELAR_CIERRE = True
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        CANCELAR_CIERRE = True
        Me.Close()
    End Sub
End Class
