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
            sql = "
             INSERT INTO VISITANTE(VISITANTE,CPF,WHATSAPP,PLACA,ID_MORADOR)
             VALUES(
             '" & txtNome.Text & "'
             '" & txtCpf.Text & "'
             '" & txtWhatsapp.Text & "'
             '" & txtPlaca.Text & "'
             '" & id_morador & "'
             )
            "
        End If
    End Sub
End Class