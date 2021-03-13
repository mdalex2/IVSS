Public Class frm_expandir_foto

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        dlg_guardar.CheckFileExists = False
        Me.dlg_guardar.Filter = "imagen jpg|*.jpg;" 'filtro de archivos del OpenFileDialog 
        If Me.dlg_guardar.ShowDialog() = Windows.Forms.DialogResult.Cancel Then ' en caso de que se aplaste el boton cancelar salga y no haga nada
            Exit Sub
        End If
        Dim archivo As String = ""
        archivo = dlg_guardar.FileName
        Me.foto.Image.Save(archivo, System.Drawing.Imaging.ImageFormat.Jpeg)
        If MsgBox("Imagen almacenada con éxito, ¿Desea abrirla en éste momento?", vbQuestion + vbYesNo + vbDefaultButton2 + vbSystemModal, "Ayuda del sistema") = vbYes Then
            Shell("explorer.exe root = " & archivo, vbNormalFocus)
        End If
    End Sub

End Class