Public Class frmTelainicial
    Private Sub BtnVisitantes_Click(sender As Object, e As EventArgs) Handles BtnVisitantes.Click
        FrmVisitantes.ShowDialog()
    End Sub

    Private Sub btnMoradores_Click(sender As Object, e As EventArgs) Handles btnMoradores.Click
        frmMoradores.ShowDialog()
    End Sub

    Private Sub mnVisitantes_Click(sender As Object, e As EventArgs) Handles mnVisitantes.Click
        FrmVisitantes.ShowDialog()
    End Sub

    Private Sub mnMoradores_Click(sender As Object, e As EventArgs) Handles mnMoradores.Click
        frmMoradores.ShowDialog()
    End Sub

    Private Sub mnFechar_Click(sender As Object, e As EventArgs) Handles mnFechar.Click
        If MsgBox("Deseja realmente fechar o sistema?",
                    MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                    "Fechar") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
