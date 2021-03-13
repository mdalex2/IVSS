Imports MySql.Data.MySqlClient
Module Fecha
    Public Var_es_Fin_de_Semana As Boolean = False
    Public Primer_dia_semana, Ultimo_dia_Semana, Primer_dia_mes, Ultimo_dia_mes, Primer_dia_año, Ultimo_dia_año As Date
    Public VarP_Cant_Feriados As Integer
    Dim Fechatexto As String
    Public VarP_Es_Feriado As Boolean
    Public Sub ObtenerPrimerUltimoDiaMesAño(ByVal Fecha As Date)


        'Usamos la funcion DAteSerial para obtener el primero y el ultimo dia  
        Primer_dia_mes = DateSerial(Year(Fecha), Month(Fecha) + 0, 1)
        Ultimo_dia_mes = DateSerial(Year(Fecha), Month(Fecha) + 1, 0)

        'primer dia año y ultimo dia del año
        Primer_dia_año = DateSerial(Year(Fecha) + 0, 1, 1)
        Ultimo_dia_año = DateAdd(DateInterval.Year, 1, Primer_dia_año)
        Ultimo_dia_año = DateAdd(DateInterval.Day, -1, Ultimo_dia_año)

        'MsgBox(" Primer día : " & Primer_dia_mes & vbNewLine & _
        '       " Último día : " & Ultimo_dia_mes & vbNewLine & _
        '       " Primer dia año: " & Primer_dia_año & vbNewLine & _
        '       " ultimo dia año: " & Ultimo_dia_año)

    End Sub

   

    'Devuelve el primer día de la semana
    Public Function Obt_Primer_ultimo_dia_semana(ByVal Fecha As Date) As Date
        If IsDate(Fecha) Then
            Primer_dia_semana = FormatDateTime(DateAdd(DateInterval.Day, -Weekday(Fecha) + 1, Fecha), vbGeneralDate)
            Primer_dia_semana = DateValue(Primer_dia_semana)
        End If

        If IsDate(Fecha) Then
            Ultimo_dia_Semana = FormatDateTime(DateAdd(DateInterval.Day, -Weekday(Fecha) + 7, Fecha), vbGeneralDate)
            Ultimo_dia_Semana = DateValue(Ultimo_dia_Semana)
        End If
        'MsgBox("Primer dia semana: " & Primer_dia_semana & " " & Primer_dia_semana.ToString("dddd") & vbNewLine & _
        '"Ultimo dia semana: " & Ultimo_dia_Semana & " " & Ultimo_dia_Semana.ToString("dddd"))

        Return Primer_dia_semana
        Return Ultimo_dia_Semana
    End Function
    Public Function Es_Fin_de_Semana(ByVal Fecha As Object) As Boolean
        Var_es_Fin_de_Semana = False
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            comando.CommandText = "Select * from Dias_Fin_sem"

            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()

            If dr.HasRows Then
                While dr.Read()
                    If IsDate(Fecha) Then
                        If (Weekday(Fecha, vbSunday) = dr("No_Dia")) And CBool(dr("Fin_semana")) = CBool(True) Then
                            Var_es_Fin_de_Semana = True
                            Exit While
                        End If
                    End If
                End While
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Es_Fin_de_Semana", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Es_Fin_de_Semana", Err.Number, ex.Message)
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
        Return Var_es_Fin_de_Semana
    End Function
    Public Function Verifica_Feriado(ByVal VP_Fecha As Date)
        Dim comando As New MySqlCommand
        Dim dr As MySqlDataReader 'dr=data reader
        Try
            comando.CommandText = "select * from feriados"

            ConectarBD()
            comando.Connection = myCloneCon
            dr = comando.ExecuteReader()
            VarP_Cant_Feriados = 0
            VarP_Es_Feriado = False
            Fechatexto = VP_Fecha
            If dr.HasRows Then
                While dr.Read
                    If CBool(dr("Variable")) = CBool(True) Then 'si varia en los dias ejm semana santa que es la primera semana de abril jueves y viernes santo casi nunca cae igual el mismo dia
                        If (CDate(dr("Fecha")) = CDate(VP_Fecha)) Then
                            VarP_Cant_Feriados = VarP_Cant_Feriados + 1
                            VarP_Es_Feriado = True
                            Exit While
                        End If
                    Else '***si no varia osea que sea ejm 01 de mayo asi caiga lune o martes o miercoles siempre sera 01 mayo
                        'Val_Fecha = Format(!Fecha, "dd") & "/" & Format(!Fecha, "mm") & "/" & Format(VP_Fecha_desde, "yyyy")
                        Dim Fecha_BD As Date = dr("Fecha")
                        If (Fecha_BD.Day = VP_Fecha.Day) And (Fecha_BD.Month = VP_Fecha.Month) Then
                            VarP_Cant_Feriados = VarP_Cant_Feriados + 1
                            VarP_Es_Feriado = True
                            Exit While
                        End If
                    End If
                End While
            End If
        Catch Mysql_ex As MySqlException
            Mostrar_mensaje_error_Mysql("Verifica_Feriado", Mysql_ex.Number, Mysql_ex.Message)
        Catch ex As Exception
            Mostrar_mensaje_error("Verifica_Feriado", Err.Number, ex.Message)
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
        Return VarP_Es_Feriado
    End Function
End Module
