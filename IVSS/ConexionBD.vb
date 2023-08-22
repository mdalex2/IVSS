Imports MySql.Data.MySqlClient
Module ConexionBD
    Public dr As MySqlDataReader 'dr=data reader para las consultas de bd
    Public myCloneCon As MySqlConnection
    Public servidor_mysql As String = "server=127.0.0.1;"
    Public usuario_Mysql As String = "User Id=siste+;"
    Public BD As String = "database=IVSS;"
    Public Clave_mysql As String = "password=SisTe+2812+;"
    Public Mysql_extra As String = "Persist Security Info=True"
    Public Cadena_Conexion As String
    Public Sub ConectarBD()
        Try
            Cadena_Conexion = servidor_mysql + usuario_Mysql + BD + Clave_mysql + Mysql_extra
            myCloneCon = New MySqlConnection(Cadena_Conexion)
            myCloneCon.Open()
            'detecto errorres en la conexion
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("ConectarBD", Mysql_ex.Number, Mysql_ex.Message)
            myCloneCon.Dispose()
        Catch El_error As Exception
            If Err.Number <> 0 Then
                Select Case Err.Number
                    Case Else
                        MsgBox("Error: " & El_error.Message & " Número: " & Err.Number, MsgBoxStyle.Information)
                End Select
            End If
        End Try
    End Sub

End Module
