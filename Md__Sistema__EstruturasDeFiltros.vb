Public Module Md__Sistema__EstruturasDeFiltros

    Public Structure FiltroContrato

        Public Tipo As TipoContrato?
        Public Modalidade As ModalidadeContrato?

        Public Sub New(Optional tipo As TipoContrato? = Nothing, Optional modalidade As ModalidadeContrato? = Nothing)

            Me.Tipo = tipo
            Me.Modalidade = modalidade

        End Sub

        Public Overrides Function ToString() As String
            ' Formata texto como: "HORISTA | INTERMITENTE" ou "MENSALISTA | TODOS"
            Return $"{GetEnumDescription(Tipo)} | {GetEnumDescription(Modalidade)}"
        End Function

    End Structure


End Module
