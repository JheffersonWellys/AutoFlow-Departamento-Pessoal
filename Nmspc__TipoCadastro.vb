
Namespace AutoFlow.Globais

    Public Enum ModoAtualCadastro
        CRIANDO = 0
        EDITANDO = 1
        REMOVENDO = 2
        VISUALIZANDO = 3
        NENHUM = 4
    End Enum

    Public Enum BotaoPadraoEnum
        ADICIONAR
        ATUALIZAR
        EXCLUIR
        CANCELAR
    End Enum

    Public Structure ModoCadastroConfig
        Public Adicionar As Boolean
        Public Atualizar As Boolean
        Public Excluir As Boolean
        Public Limpar As Boolean
        Public BotaoPadrao As BotaoPadraoEnum
    End Structure

    Public Module ModoCadastroHelper

        Public ReadOnly ModoCadastroConfiguracoes As New Dictionary(Of ModoAtualCadastro, ModoCadastroConfig) From {
            {ModoAtualCadastro.CRIANDO, New ModoCadastroConfig With {.Adicionar = True, .Atualizar = False, .Excluir = False, .Limpar = True, .BotaoPadrao = BotaoPadraoEnum.ADICIONAR}},
            {ModoAtualCadastro.EDITANDO, New ModoCadastroConfig With {.Adicionar = False, .Atualizar = True, .Excluir = False, .Limpar = True, .BotaoPadrao = BotaoPadraoEnum.ATUALIZAR}},
            {ModoAtualCadastro.REMOVENDO, New ModoCadastroConfig With {.Adicionar = False, .Atualizar = False, .Excluir = True, .Limpar = False, .BotaoPadrao = BotaoPadraoEnum.EXCLUIR}},
            {ModoAtualCadastro.VISUALIZANDO, New ModoCadastroConfig With {.Adicionar = False, .Atualizar = False, .Excluir = False, .Limpar = False, .BotaoPadrao = BotaoPadraoEnum.CANCELAR}}
        }

    End Module

End Namespace
