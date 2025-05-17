Module Md__Mensagens

#Region "ENUMERADORES"

    Public Enum TipoMensagem
        Erro
        Alerta
        Sucesso
        Confirmacao
    End Enum

#End Region

#Region "FUNÇÕES DE EXIBIÇÃO DE MENSAGENS"

    Private Sub ExibirMensagem(Mensagem As String, Tipo As TipoMensagem)

        Dim titulo As String
        Dim icone As MessageBoxIcon
        Dim botoes As MessageBoxButtons = MessageBoxButtons.OK

        Select Case Tipo

            Case TipoMensagem.Erro
                titulo = "AutoFlow - Erro!"
                icone = MessageBoxIcon.Error

            Case TipoMensagem.Alerta
                titulo = "AutoFlow - Aviso!"
                icone = MessageBoxIcon.Warning

            Case TipoMensagem.Sucesso
                titulo = "AutoFlow - Sucesso!"
                icone = MessageBoxIcon.Information

            Case TipoMensagem.Confirmacao
                titulo = "AutoFlow - Confirmação!"
                icone = MessageBoxIcon.Question
                botoes = MessageBoxButtons.YesNo

            Case Else
                titulo = "AutoFlow"
                icone = MessageBoxIcon.Information

        End Select

        MessageBox.Show(Mensagem, titulo, botoes, icone)

    End Sub

    Public Sub ExibirMensagem__Erro(Mensagem As String)

        ExibirMensagem(Mensagem, TipoMensagem.Erro)

    End Sub

    Public Sub ExibirMensagem__Alerta(Mensagem As String)

        ExibirMensagem(Mensagem, TipoMensagem.Alerta)

    End Sub

    Public Sub ExibirMensagem__Sucesso(Mensagem As String)

        ExibirMensagem(Mensagem, TipoMensagem.Sucesso)

    End Sub

    Public Function ExibirMensagem__Confirmacao(Mensagem As String) As DialogResult

        Return MessageBox.Show(Mensagem, "AutoFlow - Confirmação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    End Function

#End Region

End Module
