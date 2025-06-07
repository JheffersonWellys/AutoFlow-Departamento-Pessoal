Imports System.ComponentModel
Imports System.Reflection

Public Module Md__SQLite__Enums

    Public Function ObterListaChaveValorDeEnum(Of T)() As List(Of KeyValuePair(Of Integer, String))

        Dim lista As New List(Of KeyValuePair(Of Integer, String))

        For Each valor As T In [Enum].GetValues(GetType(T))

            Dim campo = GetType(T).GetField(valor.ToString())
            Dim atributoDescricao = CType(Attribute.GetCustomAttribute(campo, GetType(DescriptionAttribute)), DescriptionAttribute)

            Dim descricao As String = If(atributoDescricao IsNot Nothing, atributoDescricao.Description, valor.ToString())

            lista.Add(New KeyValuePair(Of Integer, String)(Convert.ToInt32(valor), descricao))

        Next

        Return lista

    End Function

    Public ReadOnly ModalidadesPorTipoContrato As New Dictionary(Of TipoContrato, List(Of ModalidadeContrato)) From {
        {TipoContrato.HORISTA, New List(Of ModalidadeContrato) From {
            ModalidadeContrato.INTERMITENTE,
            ModalidadeContrato.INSTRUTOR_DE_FORMACAO_PROFISSIONAL
        }},
        {TipoContrato.MENSALISTA, New List(Of ModalidadeContrato) From {
            ModalidadeContrato.ADMINISTRATIVO,
            ModalidadeContrato.INSTRUTOR_DE_FORMACAO_PROFISSIONAL,
            ModalidadeContrato.PRAZO_DETERMINADO
        }}
    }

    Public Function GetEnumDescription(value As [Enum]) As String
        Dim fi As FieldInfo = value.GetType().GetField(value.ToString())
        Dim attributes() As DescriptionAttribute = CType(fi.GetCustomAttributes(GetType(DescriptionAttribute), False), DescriptionAttribute())
        If attributes.Length > 0 Then
            Return attributes(0).Description
        Else
            Return value.ToString()
        End If
    End Function

    Public Enum StatusCadastro
        <Description("Inativo")>
        INATIVO = 0
        <Description("Ativo")>
        ATIVO = 1
    End Enum

    Public Enum StatusArquivoContaSalario
        <Description("Criação pendente")>
        CRIACAO_PENDENTE = 0
        <Description("Assinatura pendente")>
        ASSINATURA_PENDENTE = 1
        <Description("Assinatura solicitada")>
        ASSINATURA_SOLICITADA = 2
        <Description("Anexada")>
        ANEXADA = 3
    End Enum

    Public Enum StatusArquivoCienciaHomologacao
        <Description("Criação pendente")>
        CRIACAO_PENDENTE = 0
        <Description("Assinatura pendente")>
        ASSINATURA_PENDENTE = 1
        <Description("Assinada manualmente")>
        ASSINADA_MANUALMENTE = 2
    End Enum

    Public Enum StatusArquivoFinsRescisorios
        <Description("Criação pendente")>
        CRIACAO_PENDENTE = 0
        <Description("Assinatura solicitada pelo DP")>
        ASSINATURA_SOLICITADA_DP = 1
        <Description("Assinatura solicitada pela Gestão")>
        ASSINATURA_SOLICITADA_GESTAO = 2
        <Description("Documento anexado")>
        ANEXADO = 3
    End Enum

    Public Enum Sexo
        <Description("Masculino")>
        MASCULINO = 0
        <Description("Feminino")>
        FEMININO = 1
    End Enum

    Public Enum TipoContrato
        <Description("Horista")>
        HORISTA = 0
        <Description("Mensalista")>
        MENSALISTA = 1
        <Description("Todos")>
        TODOS = 3
    End Enum

    Public Enum ModalidadeContrato
        <Description("Administrativo")>
        ADMINISTRATIVO = 0
        <Description("Intermitente")>
        INTERMITENTE = 1
        <Description("Instrutor de Formação Profissional")>
        INSTRUTOR_DE_FORMACAO_PROFISSIONAL = 2
        <Description("Prazo Determinado")>
        PRAZO_DETERMINADO = 3
        <Description("Todos")>
        TODOS = 4
    End Enum

    Public Enum StatusDocumentosAdmissionais
        <Description("Pendentes")>
        PENDENTES = 0
        <Description("Solicitados")>
        SOLICITADOS = 1
        <Description("Anexados")>
        ANEXADOS = 2
    End Enum

    Public Enum StatusCartaDeAberturaDeContaSalario
        <Description("Envio pendente")>
        ENVIO_PENDENTE = 0
        <Description("Envio solicitado")>
        ENVIO_SOLICITADO = 1
        <Description("Carta anexada")>
        ANEXADA = 2
    End Enum

    Public Enum StatusArquivoCartaDeAberturaDeContaSalario
        <Description("Criação pendente")>
        CRIACAO_PENDENTE = 0
        <Description("Assinatura pendente")>
        ASSINATURA_PENDENTE = 0
        <Description("Assinatura solicitada")>
        ASSINATURA_SOLICITADA = 1
        <Description("Assinada digitalmente")>
        ASSINADA_DIGITALMENTE = 2
    End Enum

    Public Enum StatusContrato
        <Description("Em admissão")>
        EM_ADMISSAO = 0
        <Description("Admitido")>
        ADMITIDO = 1
        <Description("Em rescisão")>
        EM_RESCISAO = 2
        <Description("Desligado")>
        DESLIGADO = 3
    End Enum

    Public Enum TipoExame
        <Description("Admissional")>
        ADMISSIONAL = 0
        <Description("Demissional")>
        DEMISSIONAL = 1
        <Description("Periódico")>
        PERIODICO = 2
        <Description("Retorno ao trabalho")>
        RETORNO_AO_TRABALHO = 3
        <Description("Mudança de função")>
        MUDANCA_DE_FUNCAO = 4
    End Enum

    Public Enum StatusExame
        <Description("Pendente")>
        PENDENTE = 0
        <Description("Agendado")>
        AGENDADO = 1
        <Description("Avisado")>
        AVISADO = 2
        <Description("Aguardando realização")>
        AGUARDANDO_REALIZACAO = 3
        <Description("Realizado")>
        REALIZADO = 4
    End Enum

    Public Enum StatusASO
        <Description("Aguardando resultado")>
        AGUARDANDO_RESULTADO = 0
        <Description("Anexo pendente")>
        ANEXO_PENDENTE = 1
        <Description("ASO clínico anexado")>
        ASO_CLINICO_ANEXADO = 2
    End Enum

    Public Enum StatusDocumentoAdmissional
        <Description("Solicitado")>
        SOLICITADO = 0
        <Description("Anexado")>
        ANEXADO = 1
        <Description("Pendente")>
        PENDENTE = 2
    End Enum

End Module
