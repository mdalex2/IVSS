Imports System.Windows.Forms
Imports System.IO

Public Class frm_respaldar
    Dim CMDEXE
    Dim Destino As String

    Dim ruta As String
    Dim Nombre_archivo As String
    Dim dia As String
    Dim mes As String
    Dim anio As String
    Dim Hora As String
    Dim minu As String
    Dim Seg As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BUSCAR_RUTA()
    End Sub
    Private Sub BUSCAR_RUTA()
        If Seleccionarcarpeta.ShowDialog() = Windows.Forms.DialogResult.Cancel Then ' en caso de que se aplaste el boton cancelar salga y no haga nada
            Exit Sub
        End If
        txt_destino.Text = Seleccionarcarpeta.SelectedPath
        Destino = Seleccionarcarpeta.SelectedPath
        btn_respaldar.Enabled = True
    End Sub
    Private Sub frm_restaurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_restaurar.png")
    End Sub


    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub txt_origen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_destino.Click
        BUSCAR_RUTA()
    End Sub

    Private Sub btn_respaldar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_respaldar.Click
        Try
            Mostrar_mensaje_Espera("Espere...", "Haciendo copia de seguridad...", False, "COPIAR", 1, 2, False)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            CMDEXE = CreateObject("WSCript.shell")
            dia = Now.Day
            mes = Now.Month
            anio = Now.Year
            Hora = Now.Hour
            minu = Now.Minute
            Seg = Now.Second
            Nombre_archivo = "SIGAC_IVSS" + "_" + dia + "_" + mes + "_" + anio + "_" + Hora + "_" + minu + "_" + Seg + ".sql"
            ruta = Destino + "\" & Nombre_archivo
            CMDEXE.Run("cmd /K C: & CD \wamp\bin\mysql\mysql5.1.53\bin & mysqldump --user=root --password=1234 --databases ivss > " & ruta & " & exit &")

            'CMDEXE.Run("cmd /K C: & CD \wamp\bin\mysql\mysql5.1.53\bin & mysqldump --user=root --password=1234 --databases ivss > " & Nombre_archivo & " &")
            esperar(4000)
            frm_espera.Close()
            MsgBox("Verificar en directorio si se realizo el respaldo de la Base de Datos con nombre de archivo: " & Nombre_archivo, vbInformation + vbSystemModal, "Ayuda del sistema")
            CMDEXE = Nothing
            Me.TopMost = False
            Shell("explorer.exe root = " & txt_destino.Text, vbNormalFocus)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
