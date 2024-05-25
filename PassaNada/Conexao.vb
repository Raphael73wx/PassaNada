Module Conexao

    'Variável para comandos DDL - insert, update e delete 
    Public vgDados As New ADODB.Connection
    'Variável para comandos DML - select
    Public vgRegistros As New ADODB.Recordset

    'procedimento para conectar a base de dados
    Public Sub conecta()
        If vgDados.State = 0 Then
            'Utiliza a conexão feita no ODBC 32-bit do windowns
            vgDados.Open("dsn=passa_nada")
        End If
    End Sub
    'Procedimento para desconectar da base de dados
    Public Sub desconecta()
        If vgDados.State = 1 Then
            vgDados.Close()
        End If
    End Sub

End Module
