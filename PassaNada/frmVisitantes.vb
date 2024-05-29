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
        SELECT PK_MORADOR, RESPONSAVEL
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
End Class