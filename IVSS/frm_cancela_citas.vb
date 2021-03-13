Imports System.Windows.Forms

Public Class frm_cancela_citas

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frm_cancela_citas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Lbl_titulo.Parent = Pic_Encabezado 'para que quede transparente el label del titulo
        'Buscar()
        Limpiar_Controles(Me)
        Cambiar_Fondo_formulario(Me, Me.Pic_Encabezado, True, Me.Pic_pie_pagina, True, Me.Pic_icono, "Iconos formularios\Icono_frm_turnos.png")

    End Sub

    Private Sub Btn_cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancela_cita.Click
        If cmb_motivo.Text <> "" Then
            var_pu_motivo_cancela_cosulta = cmb_motivo.Text
            frm_control_cita.cancelar_cita()
            Me.Close()
        Else
            Mostrar_informacion("inf", "Información:", "Debe seleccionar el motivo de la cancelación", True, 4000, cmb_motivo, "inf")
        End If

    End Sub
End Class
