Public Class FrmVisitantes
    Private Sub FrmVisitantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimparFormulario()
        listarMoradores()
    End Sub
    Private Sub LimparFormulario()
        'Dados do Visitante
        txtNome.Clear()
        txtCpf.Clear()
        txtWhatsapp.Clear()
        txtPlaca.Clear()
        'imgfoto.Clear()
        'Dados do morador
        cbMorador.SelectedIndex = -1
        txtLogradouro.Clear()
        txtNumero.Clear()
        txtComplemento.Clear()
        txtWhatsappM.Clear()

    End Sub
    Private Sub listarMoradores()
        cbMorador.Items.Clear()
        Dim sql As String
        sql = "
        SELECT (LPAD(PK_MORADOR,5,0)|| '  -  ' || RESPONSAVEL) RESPONSAVEL
        FROM MORADOR
        ORDER BY RESPONSAVEL
        "
        vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vgRegistros.Open(sql, vgDados)

        If vgRegistros.RecordCount > 0 Then
            While Not vgRegistros.EOF
                cbMorador.Items.Add(vgRegistros("RESPONSAVEL").Value)
                vgRegistros.MoveNext()
            End While
        End If
        vgRegistros.Close()
    End Sub

    Private Sub mnSalvar_Click(sender As Object, e As EventArgs) Handles mnSalvar.Click
        If txtNome.Text = "" Or txtPlaca.Text = "  -  " Or cbMorador.Text = "" Then
            MsgBox("Por favor, preencha os campos obrigatórios!",
                MsgBoxStyle.Information, "campos obrigatórios")
        Else
            Dim sql As String
            Dim id_morador As Integer = CInt(Mid(cbMorador.Text, 1, 5))
            Dim dataHoraAtual As DateTime = Now
            sql = "
             INSERT INTO VISITAS(VISITANTE,CPF,WHATSAPP,PLACA,ID_MORADOR,DATA,HORA)
             VALUES(
             '" & txtNome.Text & "',
             '" & txtCpf.Text & "',
             '" & txtWhatsapp.Text & "',
             '" & txtPlaca.Text & "',
             '" & id_morador & "',
             '" & Format(dataHoraAtual, "MM/dd/yyyy") & "',
             '" & dataHoraAtual.ToShortTimeString & "'
             )
            "

            vgDados.Execute(sql)
            MsgBox("Visitante registrado com sucesso!",
                   MsgBoxStyle.Information, "SUCESSO")
            LimparFormulario()
        End If
    End Sub
    Private Sub cbMorador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbMorador.SelectedValueChanged
        Dim id_morador As Integer = CInt(Mid(cbMorador.Text, 1, 5))
        Dim sql As String
        sql = "
        SELECT WHATSAPP,LOGRADOURO,NUMERO,COMPLEMENTO
        FROM MORADOR 
        WHERE PK_MORADOR = '" & id_morador & "'
        "
        vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vgRegistros.Open(sql, vgDados)

        If vgRegistros.RecordCount > 0 Then
            txtWhatsappM.Text = vgRegistros("WHATSAPP").Value
            txtLogradouro.Text = vgRegistros("LOGRADOURO").Value
            txtNumero.Text = vgRegistros("NUMERO").Value
            txtComplemento.Text = vgRegistros("COMPLEMENTO").Value
        End If
        vgRegistros.Close()
    End Sub
End Class