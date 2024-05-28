Public Class frmMoradores
    Private Sub frmMoradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparFormulario()
        listarDados()
    End Sub
    Private Sub limparFormulario()
        txtCod.Clear()
        txtResponsavel.Clear()
        txtCpf.Clear()
        txtWhatsapp.Clear()
        txtEmail.Clear()
        txtLogradouro.Clear()
        txtNumero.Clear()
        txtComplemento.Clear()
        txtBairro.Clear()
        txtCidade.Clear()
        cbEstado.SelectedText = -1
        txtResponsavel.Select()
    End Sub

    Private Sub mnNovo_Click(sender As Object, e As EventArgs) Handles mnNovo.Click
        If MsgBox("deseja realmente criar um novo registro?",
                     MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                        "Novo") = MsgBoxResult.Yes Then
            limparFormulario()
        End If
    End Sub

    Private Sub mnFechar_Click(sender As Object, e As EventArgs) Handles mnFechar.Click
        If MsgBox("deseja realmente fechar?",
                   MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                    "fechar") = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub
    Private Sub mnSalvar_Click(sender As Object, e As EventArgs) Handles mnSalvar.Click
        If txtResponsavel.Text = "" Or txtEmail.Text = "" Then
            MsgBox("Por favor, preecha os campos obrigatórios!",
                    MsgBoxStyle.Information, "Campo obrigatório")
        Else
            'Dim item As New ListViewItem
            'Dim teste As String = "raphael"'

            ' With lsvDados.Items.Add(item)
            '.Text = txtCod.Text
            '.SubItems.Add(txtResponsavel.Text)
            '.SubItems.Add(txtCpf.Text)
            '.SubItems.Add(txtWhatsapp.Text)
            '.SubItems.Add(txtEmail.Text)
            ' End With
            Dim sql As String
            If txtCod.Text = "" Then
                sql = "
                INSERT INTO MORADOR(
                RESPONSAVEL,
                CPF,
                EMAIL,
                WHATSAPP,
                LOGRADOURO,
                NUMERO,
                COMPLEMENTO,
                BAIRRO,
                CIDADE,
                ESTADO
                )VALUES
                (
                '" & txtResponsavel.Text & "',
                '" & txtCpf.Text & "',
                '" & txtEmail.Text & "',
                '" & txtWhatsapp.Text & "',
                '" & txtLogradouro.Text & "',
                '" & txtNumero.Text & "',
                '" & txtComplemento.Text & "',
                '" & txtBairro.Text & "',
                '" & txtCidade.Text & "',
                '" & cbEstado.Text & "'
                )"
            Else
                sql = "
                UPDATE MORADOR SET
                RESPONSAVEL = '" & txtResponsavel.Text & "',
                CPF = '" & txtCpf.Text & "',
                EMAIL ='" & txtEmail.Text & "',
                WHATSAPP = '" & txtWhatsapp.Text & "',
                LOGRADOURO = '" & txtLogradouro.Text & "',
                NUMERO = '" & txtNumero.Text & "',
                COMPLEMENTO = '" & txtComplemento.Text & "',
                BAIRRO = '" & txtBairro.Text & "',
                CIDADE = '" & txtCidade.Text & "',
                ESTADO = '" & cbEstado.Text & "'
                WHERE PK_MORADOR = '"& txtCod.Text &"'
                "

            End If
            vgDados.Execute(sql)
            limparFormulario()
            listarDados()
        End If

    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        txtCod.Text = lsvDados.SelectedItems(0).Text
        ' txtResponsavel.Text = lsvDados.SelectedItems(0).SubItems(1).Text
        ' txtCpf.Text = lsvDados.SelectedItems(0).SubItems(2).Text
        ' txtWhatsapp.Text = lsvDados.SelectedItems(0).SubItems(3).Text
        'txtEmail.Text = lsvDados.SelectedItems(0).SubItems(4).Text
        Dim sql As String
        sql = "
        SELECT *
        FROM MORADOR
        WHERE PK_MORADOR = '" & txtCod.Text & "'
        "
        vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vgRegistros.Open(sql, vgDados)

        If vgRegistros.RecordCount > 0 Then
            txtResponsavel.Text = vgRegistros("RESPONSAVEL").Value
            txtCpf.Text = vgRegistros("CPF").Value
            txtWhatsapp.Text = vgRegistros("WHATSAPP").Value
            txtEmail.Text = vgRegistros("EMAIL").Value
            txtLogradouro.Text = vgRegistros("LOGRADOURO").Value
            txtNumero.Text = vgRegistros("NUMERO").Value
            txtComplemento.Text = vgRegistros("COMPLEMENTO").Value
            txtBairro.Text = vgRegistros("BAIRRO").Value
            txtCidade.Text = vgRegistros("CIDADE").Value
            cbEstado.Text = vgRegistros("ESTADO").Value
        End If

        vgRegistros.Close()

    End Sub

    Private Sub listarDados()
        Dim sql As String

        lsvDados.Items.Clear()

        sql = "
        SELECT * 
        FROM MORADOR
        WHERE PK_MORADOR LIKE '%" & txtBuscar.Text & "%'    
        OR LOWER(RESPONSAVEL) LIKE '%" & LCase(txtBuscar.Text) & "%'
        OR LOWER(CPF) LIKE '%" & LCase(txtBuscar.Text) & "%'
        OR LOWER(EMAIL) LIKE '%" & LCase(txtBuscar.Text) & "%'
        ORDER BY RESPONSAVEL
        "
        vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vgRegistros.Open(sql, vgDados)

        If vgRegistros.RecordCount > 0 Then

            While Not vgRegistros.EOF

                Dim item As New ListViewItem

                With lsvDados.Items.Add(item)
                    .Text = vgRegistros("PK_MORADOR").Value
                    .SubItems.Add(vgRegistros("RESPONSAVEL").Value)
                    .SubItems.Add(vgRegistros("CPF").Value)
                    .SubItems.Add(vgRegistros("WHATSAPP").Value)
                    .SubItems.Add(vgRegistros("EMAIL").Value)
                End With

                vgRegistros.MoveNext()

            End While
        End If
        vgRegistros.Close()


    End Sub

    Private Sub mnExcluir_Click(sender As Object, e As EventArgs) Handles mnExcluir.Click
        If txtCod.Text <> "" Then
            Dim sql As String
            sql = "
            DELETE FROM MORADOR 
            WHERE PK_MORADOR = '" & txtCod.Text & "'
            "
            vgDados.Execute(sql)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        listarDados()
    End Sub
End Class