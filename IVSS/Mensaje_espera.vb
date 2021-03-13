Module Mensaje_espera
    Public Sub Mostrar_mensaje_Espera(ByVal TituloM As String, ByVal TextoM As String, ByVal BtnCancelaM As Boolean, ByVal AnimacionM As String, ByVal BarraInicio As Double, ByVal BarraFin As Double, ByVal VerBarra As Boolean)
        On Error Resume Next
        'Reproducir_Sonido "PROCESO", VarP_Esq_Sonido, VarP_Mute
        frm_espera.Show()
        frm_espera.BringToFront()
        frm_espera.lbl_mensaje.Text = TextoM
        frm_espera.Text = TituloM
        frm_espera.btn_cancela.Enabled = BtnCancelaM
        frm_espera.Barra_progreso.Visible = VerBarra
        frm_espera.Barra_progreso.Minimum = BarraInicio
        frm_espera.Barra_progreso.Maximum = BarraFin
        Select Case AnimacionM
            Case "COPIAR" 'COPIAR ESTILO VARIOS Y IMAGEN DE GENTE
                'frm_espera.Animation1.Open(Application.StartupPath & "\Animacion\COPIAR_VARIOS.AVI")
            Case "COPICA" 'COPIAR ETILO CARPETA A CARPETA SOLO
                'frm_espera.Animation1.Open(Application.StartupPath & "\Animacion\COPIA_CARPETA.AVI")
            Case "LUPAHOJA"
                'frm_espera.Animation1.Open(Application.StartupPath & "\Animacion\LUPAHOJA.AVI")
            Case "PROC"
                'frm_espera.Animation1.Open(Application.StartupPath & "\Animacion\Procesar_Verde.AVI")
            Case "PROCESOBIN"
                'frm_espera.Animation1.Open(Application.StartupPath & "\Animacion\PROCESOBIN.AVI")
            Case "ELIMINAR"
                'frm_espera.Animation1.Open(Application.StartupPath & "\Animacion\ELIMINA_VARIOS.AVI")
            Case "CHECK"
                'frm_espera.Animation1.Open(Application.StartupPath & "\Animacion\Verif_check.AVI")
        End Select

        System.Windows.Forms.Application.DoEvents()
        'Esperar (0.1)
    End Sub

    Public Sub esperar(ByVal tiempo_espera)
        On Error Resume Next
        System.Threading.Thread.Sleep(tiempo_espera)
    End Sub
End Module
