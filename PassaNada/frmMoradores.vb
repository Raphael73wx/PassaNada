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
End Class