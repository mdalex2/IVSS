Imports System.Windows.Forms

Public Class frm_espera
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frm_espera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_mensaje.Parent = Pic_Encabezado

        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\icono_frm_citas.png")

    End Sub

    Private Sub btn_cancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela.Click

    End Sub
End Class
