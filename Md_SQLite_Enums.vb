Module Md_SQLite_Enums

    Public Enum StatusCadastro
        ATIVO = 0
        INATIVO = 1
    End Enum

    Public Enum StatusArquivoContaSalario
        ASSINATURA_PENDENTE = 0
        ASSINATURA_SOLICITADA = 1
        ASSINADA_DIGITALMENTE = 2
    End Enum

    Public Enum StatusArquivoCienciaHomologacao
        ASSINATURA_PENDENTE = 0
        ASSINADA_MANUALMENTE = 1
    End Enum

    Public Enum StatusArquivoFinsRescisorios
        ASSINATURA_SOLICITADA_DP = 0
        ASSINATURA_SOLICITADA_GESTAO = 1
        ANEXADO = 3
    End Enum

    Public Enum Sexo
        MASCULINO = 0
        FEMININO = 1
    End Enum

    Public Enum TipoContrato
        HORISTA = 0
        MENSALISTA = 1
    End Enum

    Public Enum ModalidadeContrato
        ADMINISTRATIVO = 0
        INTERMITENTE = 1
        INSTRUTOR_DE_FORMACAO_PROFISSIONAL = 2
        PRAZO_DETERMINADO = 3
    End Enum

    Public Enum StatusDocumentosAdmissionais
        PENDENTES = 0
        SOLICITADOS = 1
        ANEXADOS = 2
    End Enum

    Public Enum StatusCartaDeAberturaDeContaSalario
        ENVIO_PENDENTE = 0
        ENVIO_SOLICITADO = 1
        ANEXADA = 2
    End Enum

    Public Enum StatusArquivoCartaDeAberturaDeContaSalario
        ASSINATURA_PENDENTE = 0
        ASSINATURA_SOLICITADA = 1
        ASSINADA_DIGITALMENTE = 2
    End Enum

    Public Enum StatusContrato
        EM_ADMISSAO = 0
        ADMITIDO = 1
        EM_RESCISAO = 2
        DESLIGADO = 3
    End Enum

    Public Enum TipoExame
        ADMISSIONAL = 0
        DEMISSIONAL = 1
        PERIODICO = 2
        RETORNO_AO_TRABALHO = 3
        MUDANCA_DE_FUNCAO = 4
    End Enum

    Public Enum StatusExame
        PENDENTE = 0
        AGENDADO = 1
        AVISADO = 2
        AGUARDANDO_REALIZACAO = 3
        REALIZADO = 4
    End Enum

    Public Enum StatusASO
        AGUARDANDO_RESULTADO = 0
        ANEXO_PENDENTE = 1
        ASO_CLINICO_ANEXADO = 2
    End Enum

    Public Enum StatusDocumentoAdmissional
        SOLICITADO = 0
        ANEXADO = 1
        PENDENTE = 2
    End Enum

End Module
