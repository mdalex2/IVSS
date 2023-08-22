Imports System.Windows.Forms
Imports System.IO

Public Class frm_restaurar
    Dim CMDEXE
    Dim origen As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BUSCAR_BD()
    End Sub
    Private Sub BUSCAR_BD()
        Me.Dialogo_abrir.Filter = "Dumps MySQL|*.sql;" 'filtro de archivos del OpenFileDialog 
        If Me.Dialogo_abrir.ShowDialog() = Windows.Forms.DialogResult.Cancel Then ' en caso de que se aplaste el boton cancelar salga y no haga nada
            Exit Sub
        End If
        txt_origen.Text = Dialogo_abrir.FileName()
        origen = Dialogo_abrir.FileName
        btn_restaurar.Enabled = True
        Dim Archivo As New FileInfo(origen)
        Dim tamaño As String

        If (Archivo.Length) > 1000000 Then 'si el archivo es mayor que 1000000 kb o lo que es = 1 mb
            tamaño = (Archivo.Length / 1000000).ToString("##,##0.00") & " MB"
        Else
            tamaño = Archivo.Length.ToString & " KB"
        End If
        lbl_descripcion.Text = "Modificado el: " & Archivo.LastWriteTime.ToString("dddd, dd MMMM yyyy") & " " & Archivo.LastWriteTime.ToShortTimeString & " Tamaño: " & tamaño

    End Sub
    Private Sub frm_restaurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_restaurar.png")
    End Sub

    Private Sub btn_restaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_restaurar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If MsgBox("IMPORTANTE: Si restaura una base de datos, la información que actualmente existe será reemplazada con los datos que contiene el archivo seleccionado por usted," & _
                  "se aconseja antes de restaurar cualquier base de datos, hacer una copia de seguridad de la base de datos que actualmente usa del sistema" & vbNewLine & vbNewLine & _
                  "¿En realidad desea restaurar los datos que contienen el archivo: " & txt_origen.Text & "?", vbQuestion + vbYesNo + vbSystemModal + vbDefaultButton2, "Salir del sistema") = vbYes Then
            Mostrar_mensaje_Espera("Espere...", "Importando la base de datos", False, "COPIAR", 1, 2, False)
            CMDEXE = CreateObject("WSCript.shell")
            CMDEXE.Run("cmd /K C: & CD \wamp\bin\mysql\mysql5.1.53\bin & mysql --user=root --password=1234 < " & origen & " & exit &")
            esperar(3000)
            frm_espera.Close()
            MsgBox("Se Restauro La Base de Datos", vbInformation + vbSystemModal, "Ayuda del sistema")
            CMDEXE = Nothing

            'Me.Close()
        End If
    End Sub

    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub txt_origen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_origen.Click
        BUSCAR_BD()
    End Sub
End Class
