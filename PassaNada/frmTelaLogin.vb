Imports System.ComponentModel

Public Class frmTelaLogin
    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        limparFormulario()
    End Sub
    Private Sub frmTelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limparFormulario()
        conecta()
    End Sub

    Private Sub limparFormulario()
        txtEmail.Clear()
        txtSenha.Clear()
        txtEmail.Select()
    End Sub
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim email As String = txtEmail.Text
        Dim senha As String = txtSenha.Text
        Dim sql As String

        If email = "" Or senha = "" Then
            MsgBox("Por favor preencha todos os campos!",
                   MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly,
                   "Campo obrigatório")
            limparFormulario()
        Else
            sql = "
            SElECT PK_USUARIO, NOME
            FROM USUARIO
            WHERE EMAIL = '" & email & "'
             AND SENHA =  '" & senha & "'
            "
            ' Chamado a variável vgRegistros para poder utilizá-la
            vgDados.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            vgRegistros.Open(sql, vgDados)


            If vgRegistros.RecordCount > 0 Then
                frmTelainicial.ToolStripUsuario.Text = vgRegistros("NOME").Value
                vgRegistros.Close()
                Me.Visible = False
                frmTelainicial.ShowDialog()
                Me.Visible = True
                limparFormulario()

            Else
                vgRegistros.Close()
                MsgBox("E-mail e/ou senha inválidos!",
                        MsgBoxStyle.Critical + MsgBoxStyle.OkOnly,
                        "Dados incorretos")
                limparFormulario()
            End If
        End If


    End Sub

    Private Sub frmTelaLogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        desconecta()
    End Sub
End Class