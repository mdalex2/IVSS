Imports System.Drawing
Imports MySql.Data.MySqlClient
Public Class frm_clave

    Private Sub frm_clave_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = CANCELAR_CIERRE
    End Sub

    Private Sub frm_clave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_ivss.png")
        LLave_AES = "80865062812"
        Lbl_titulo.Parent = Pic_Encabezado
        img_clave.Parent = Me
        'Me.BackgroundImageLayout = ImageLayout.Stretch
        Dim img As Image = Image.FromFile(Application.StartupPath & "\imagenes\sistema\Iconos formularios\img_frm_clave.png")
        'img.ImageLocation = Application.StartupPath & "\imagenes\sistema\candado.png"
        img_clave.Image = img
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        CANCELAR_CIERRE = False
        End
    End Sub
    Private Sub LLamar_clave()
        Try
            If txt_usuario.Text = "" Then
                Mostrar_informacion("inf", "Información", "Debe escribir el nombre de usuario", True, 2500, txt_usuario, "exc")
                Exit Sub
            End If
            If txt_clave.Text = "" Then
                Mostrar_informacion("inf", "Información", "Debe escribir su clave de acceso", True, 2500, txt_clave, "exc")
                Exit Sub
            End If
            'If cmb_dsn.Text = "" Then
            '    Mostrar_informacion("inf", "Información", "Debe seleccionar la base de datos a trabajar", True, 2500, cmb_dsn, "exc")
            '    Exit Sub
            'End If
            valida_clave()
        Catch ex As Exception
            MsgBox(ex.Message, vbSystemModal + vbInformation, "Ayuda del sistema")
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_entrar.Click
        LLamar_clave()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_entrar_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_entrar.MouseHover
        'ToolTip1.SetToolTip(btn_entrar, "abc")
    End Sub
    Public Shared AppToolTip As New ToolTip()

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub valida_clave()
        Dim comando As New MySqlCommand
        Dim encontrado As Integer = 0
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            comando.CommandText = "SELECT usuarios.*,datos_personales.nombres,datos_personales.apellidos from (usuarios inner join datos_personales on usuarios.num_historia=datos_personales.num_historia) where nombre_usuario='" & txt_usuario.Text & "' And BINARY aes_decrypt(clave,'" & LLave_AES & "')='" & txt_clave.Text & "'"
            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader
            If dr.HasRows Then

                While dr.Read
                    If dr("activo") = True Then
                        'se encontro el usuario
                        Select Case dr("tipo_cuenta")
                            Case "ADMINISTRADOR"

                            Case "USUARIO AVANZADO"
                                Frm_menu.SistemaToolStripMenuItem.Visible = False
                            Case "USUARIO"
                                Frm_menu.ConfiguraciónToolStripMenuItem.Visible = False
                            Case Else
                                MsgBox("El usuario no está correctamente configurado, debe contactar con un usuario administrador para que verifique su tipo de cuenta", vbCritical + vbSystemModal, "Ayuda del sistema")
                        End Select
                        Nombre_usuario_actual = UCase(dr("nombres") & " " & dr("apellidos"))
                        Cod_usuario = dr("num_historia")
                        Me.Hide()
                        Me.txt_clave.Text = ""
                        Me.txt_usuario.Text = ""
                        Mostrar_mensaje_Espera("Espere...", "Abriendo el menú", False, "PROC", 1, 2, False)
                        Frm_menu.Show()
                        Frm_menu.lbl_nombre_usuario.Text = "USUARIO: " & Nombre_usuario_actual
                        CANCELAR_CIERRE = True
                        frm_espera.Close()
                        Exit While
                    Else
                        MsgBox("El usuario se encuentra bloqueado", vbCritical + vbSystemModal, "Ayuda del sistema")
                    End If
                End While

            Else
            'no se encontro el usuario
            MsgBox("Nombre de usuario o clave incorrecta", vbCritical + vbSystemModal, "Acceso denegado")
            txt_clave.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_clave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_clave.KeyDown
        If e.KeyCode = Keys.Return Then
            LLamar_clave()
        End If
    End Sub

    Private Sub txt_clave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clave.KeyPress

    End Sub

    Private Sub txt_clave_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_clave.KeyUp

    End Sub

    Private Sub txt_clave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_clave.TextChanged

    End Sub
End Class
