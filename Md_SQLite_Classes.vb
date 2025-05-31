Module Md_SQLite_Classes

    Public Class AgenciaCaixa

        Public Property IdAgenciaCaixa As Integer
        Public Property IdEndereco As Integer
        Public Property CodigoAgencia As String
        Public Property UidUsuarioLogado As String
        Public Property Status As Integer

    End Class

    Public Class CartaDeAberturaDeContaSalario

        Public Property IdCarta As Integer
        Public Property IdColaborador As Integer
        Public Property IdAgenciaCaixa As Integer
        Public Property IdUnidadeSenac As Integer
        Public Property CaminhoArquivo As String
        Public Property StatusArquivo As String
        Public Property UidUsuarioLogado As String
        Public Property Status As Integer

    End Class

    Public Class TermoCienciaDeHomologacao

        Public Property IdTermo As Integer
        Public Property IdColaborador As Integer
        Public Property IdUnidadeSenac As Integer
        Public Property IdExame As Integer
        Public Property EmailPessoal As String
        Public Property TelefonePessoal As String
        Public Property DataHomologacao As String
        Public Property CaminhoArquivo As String
        Public Property StatusArquivo As Integer
        Public Property UidUsuarioLogado As String
        Public Property Status As Integer

    End Class

    Public Class TermoFinsRescisorios

        Public Property IdTermo As Integer
        Public Property IdColaborador As Integer
        Public Property IdUnidadeSenac As Integer
        Public Property IdTermoCienciaDeHomologacao As Integer
        Public Property RespostaItem1 As Integer
        Public Property RespostaItem11 As String
        Public Property RespostaItem2 As Integer
        Public Property RespostaItem21 As String
        Public Property RespostaItem3 As Integer
        Public Property RespostaItem4 As Integer
        Public Property RespostaItem41 As String
        Public Property RespostaItem5 As Integer
        Public Property RespostaItem51 As String
        Public Property RespostaItem6 As Integer
        Public Property RespostaItem7 As Integer
        Public Property RespostaItem8 As Integer
        Public Property RespostaItem811 As String
        Public Property RespostaItem812 As String
        Public Property RespostaItem82 As String
        Public Property RespostaItem9 As Integer
        Public Property RespostaItem91 As String
        Public Property RespostaItem10 As String
        Public Property LocalEmissao As String
        Public Property DataEmissao As String
        Public Property CaminhoArquivo As String
        Public Property StatusArquivo As Integer
        Public Property UidUsuarioLogado As String
        Public Property Status As Integer

    End Class

    Public Class ClinicaAutorizada

        Public Property IdClinicaAutorizada As Integer
        Public Property IdEndereco As Integer
        Public Property NomeClinica As String
        Public Property EmailAtendimento As String
        Public Property NomeAtendente As String
        Public Property Telefone As String
        Public Property Fixo As String
        Public Property UidUsuarioLogado As String
        Public Property Status As Integer

    End Class

    Public Class Colaborador

        Public Property IdColaborador As Integer
        Public Property NomeCompleto As String
        Public Property NomeSocial As String
        Public Property EmailPessoal As String
        Public Property TelefonePessoal As String
        Public Property Sexo As String
        Public Property DataDeNascimento As String
        Public Property CPF As String
        Public Property RG As String
        Public Property EmailCorporativo As String
        Public Property Funcao As String
        Public Property Setor As String
        Public Property Chapa As String
        Public Property DataDeAdmissao As String
        Public Property DataDeDemissao As String
        Public Property TipoContrato As String
        Public Property ModalidadeContrato As String
        Public Property StatusDocumentosAdmissionais As Integer
        Public Property StatusCartaDeAberturaDeContaSalario As Integer
        Public Property StatusContrato As Integer
        Public Property UidUsuarioLogado As String
        Public Property Status As Integer

    End Class

    Public Class Endereco

        Public Property IdEndereco As Integer
        Public Property Logradouro As String
        Public Property Numero As String
        Public Property Bairro As String
        Public Property Cidade As String
        Public Property Estado As String
        Public Property CEP As String
        Public Property UidUsuarioLogado As String
        Public Property Status As Integer

    End Class

    Public Class ExameMedico

        Public Property IdExame As Integer
        Public Property IdColaborador As Integer
        Public Property IdClinicaAutorizada As Integer
        Public Property TipoExame As String
        Public Property StatusExame As Integer
        Public Property DataRealizacao As String
        Public Property HorarioRealizacao As String
        Public Property StatusASO As Integer
        Public Property CaminhoArquivoASO As String
        Public Property UidUsuarioLogado As String
        Public Property Status As Integer

    End Class

    Public Class UnidadeSenac

        Public Property IdUnidadeSenac As Integer
        Public Property IdEndereco As Integer
        Public Property CodigoUnidade As String
        Public Property NomeUnidade As String
        Public Property UidUsuarioLogado As String
        Public Property Status As Integer

    End Class

    Public Class DocumentoColaborador

        Public Property IdDocumentosColaborador As Integer
        Public Property IdColaborador As Integer
        Public Property NomeDocumento As String
        Public Property CaminhoArquivo As String
        Public Property StatusDocumento As Integer
        Public Property UidUsuarioLogado As String
        Public Property Status As Integer

    End Class

    Public Class DocumentoModelo

        Public Property IdDocumentoModelo As Integer
        Public Property TipoContrato As String
        Public Property ModalidadeContrato As String
        Public Property NomeDocumento As String
        Public Property CaminhoArquivo As String
        Public Property UidUsuarioLogado As String
        Public Property Status As String

    End Class


End Module
