Public Class FrmVisitantes
    Private foto As String = ""

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
        Dim caminho_foto() As String
        Dim nome_foto As String = ""
        Dim ext_foto As String
        Dim destino As String = "C:\Users\raphael.e


        If txtNome.Text = "" Or txtPlaca.Text = "  -  " Or cbMorador.Text = "" Then
            MsgBox("Por favor, preencha os campos obrigatórios!",
                MsgBoxStyle.Information, "campos obrigatórios")
        Else
            Dim sql As String
            Dim FK_MORADOR As Integer = CInt(Mid(cbMorador.Text, 1, 5))
            Dim dataHoraAtual As DateTime = Now
            sql = "
             INSERT INTO VISITAS(VISITANTE,CPF,WHATSAPP,PLACA,FK_MORADOR,DATA,HORA)
             VALUES(
             '" & txtNome.Text & "',
             '" & txtCpf.Text & "',
             '" & txtWhatsapp.Text & "',
             '" & txtPlaca.Text & "',
             '" & FK_MORADOR & "',
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
        If cbMorador.Text <> "" Then
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
        End If
    End Sub
    Private Sub mnNovo_Click(sender As Object, e As EventArgs) Handles mnNovo.Click
        If MsgBox("Deseja criar um novo registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            LimparFormulario()
        End If
    End Sub

    Private Sub mnFechar_Click(sender As Object, e As EventArgs) Handles mnFechar.Click
        If MsgBox("Deseja realmente fechar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Fechar") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "Imagens|*.jpg;*.jpeg;*.png"

        If dialog.ShowDialog() = DialogResult.OK Then
            foto = dialog.FileName
            With imgfoto
                .Image = Image.FromFile(foto)
                .SizeMode = PictureBoxSizeMode.Zoom
            End With
        End If
    End Sub
End Class