Public Class frmTelaLogin
    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        limparFormulario()
    End Sub
    Private Sub frmTelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparFormulario()

    End Sub

    Private Sub limparFormulario()
        txtEmail.Clear()
        txtSenha.Clear()
        txtEmail.Select()
    End Sub
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim email As String = txtEmail.Text
        Dim senha As String = txtSenha.Text

        If email = "" Or senha = "" Then
            MsgBox("Por favor preencha todos os campos!",
                   MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly,
                   "Campo obrigatório")
            limparFormulario()
        Else
            If email = "admin" And senha = "1234" Then
                Me.Visible = False
                frmTelainicial.ShowDialog()
                Me.Visible = True
                limparFormulario()

            Else
                MsgBox("E-mail e/ou senha inválidos!",
                        MsgBoxStyle.Critical + MsgBoxStyle.OkOnly,
                        "Dados incorretos")
                limparFormulario()
            End If
        End If


    End Sub
End Class