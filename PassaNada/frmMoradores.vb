Public Class frmMoradores
    Private Sub frmMoradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparFormulario()
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
        txtCep.Clear()
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
            Dim item As New ListViewItem
            'Dim teste As String = "raphael"'

            With lsvDados.Items.Add(item)
                .Text = txtCod.Text
                .SubItems.Add(txtResponsavel.Text)
                .SubItems.Add(txtCpf.Text)
                .SubItems.Add(txtWhatsapp.Text)
                .SubItems.Add(txtEmail.Text)
            End With

            limparFormulario()
        End If

    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        txtCod.Text = lsvDados.SelectedItems(0).Text
        txtResponsavel.Text = lsvDados.SelectedItems(0).SubItems(1).Text
        txtCpf.Text = lsvDados.SelectedItems(0).SubItems(2).Text
        txtWhatsapp.Text = lsvDados.SelectedItems(0).SubItems(3).Text
        txtEmail.Text = lsvDados.SelectedItems(0).SubItems(4).Text
    End Sub

    Private Sub listarDados()
        Dim sql As String

        lsvDados.Items.Clear()

        sql = "
        SELECT * 
        FROM MORADOR
        ORDER BY RESPONSAVEL
        "
        vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vgRegistros.Open(sql, vgDados)

        If vgRegistros.RecordCount > 0 Then

            While vgRegistros.EOF

                Dim item As New ListViewItem

                With lsvDados.Items.Add(item)
                    .Text = vgRegistros("PK_MORADOR").Value
                    .SubItems.Add(vgRegistros("REPONSAVEL").Value)
                    .SubItems.Add(vgRegistros("CPF").Value)
                    .SubItems.Add(vgRegistros("WHATSAPP").Value)
                    .SubItems.Add(vgRegistros("EMAIL").Value)
                End With

                vgRegistros.MoveNext()

            End While
        End If

    End Sub
End Class