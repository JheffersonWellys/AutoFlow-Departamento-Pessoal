
Imports AutoFlow___Departamento_Pessoal__DP_.AutoFlow.Globais

Public NotInheritable Class Clss__UIHelper

    Private Sub New()
        ' Evita instanciação
    End Sub

    Public Shared Function ObterDescricaoModo(modo As ModoAtualCadastro) As String
        Select Case modo
            Case ModoAtualCadastro.CRIANDO : Return "adicionando um"
            Case ModoAtualCadastro.EDITANDO : Return "editando o"
            Case ModoAtualCadastro.REMOVENDO : Return "removendo o"
            Case Else : Return "em operação com o"
        End Select
    End Function

    Public Shared Function DeveConfirmarSaida(modo As ModoAtualCadastro) As Boolean
        Return modo <> ModoAtualCadastro.VISUALIZANDO AndAlso modo <> ModoAtualCadastro.NENHUM
    End Function

    Public Shared Function ConfirmarSaidaDoCadastro(formulario As Form, modo As ModoAtualCadastro, entidade As String) As Boolean
        If Not DeveConfirmarSaida(modo) Then Return False

        Dim descricaoModo As String = ObterDescricaoModo(modo)
        Dim mensagem As String = $"Você está {descricaoModo} cadastro de {entidade}. Deseja realmente sair?"

        Dim resultado = MessageBox.Show(formulario, mensagem, "Cancelar Operação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Return resultado = DialogResult.No
    End Function

End Class
