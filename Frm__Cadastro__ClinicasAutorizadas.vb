Imports AutoFlow___Departamento_Pessoal__DP_.AutoFlow.Globais
Imports Newtonsoft.Json.Linq

Public Class Frm__Cadastro__ClinicasAutorizadas

#Region "VARIÁVEIS DO FORMULÁRIO"

    Public Property ClinicaAutorizadaAtual As ClinicaAutorizada
    Dim ModoAtual As ModoAtualCadastro
    Dim NomeFormulario As String = NomeSistema & " | Cadastro de Clínicas Autorizadas"

#End Region

#Region "FUNÇÕES PARA CONTROLE DO FORMULÁRIO"

    Private Sub Frm__Cadastro__ClinicasAutorizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InicializarFormulario()

    End Sub

    Private Sub Frm__Cadastro__ClinicasAutorizadas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Clss__UIHelper.ConfirmarSaidaDoCadastro(Me, ModoAtual, "Clínica Autorizada") Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Frm__Cadastro__ClinicasAutorizadas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If ModoAtual <> 4 Then
                If Not Clss__UIHelper.ConfirmarSaidaDoCadastro(Me, ModoAtual, "Clínica Autorizada") Then
                    DesativarModoCadastro()
                End If
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Frm__Cadastro__ClinicasAutorizadas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        TlStrpSttsLbl_NumeroTotalDeClinicasAutorizadas.Text = ClinicasAutorizadas__ObterQuantidadeDeAtivas()

        If TlStrpSttsLbl_NumeroTotalDeClinicasAutorizadas.Text = 0 Then

            TlStrpMnItm_Acoes_Editar.Enabled = False
            TlStrpMnItm_Acoes_Remover.Enabled = False
            TlStrpMnItm_Acoes_Visualizar.Enabled = False

        Else

            TlStrpMnItm_Acoes_Editar.Enabled = True
            TlStrpMnItm_Acoes_Remover.Enabled = True
            TlStrpMnItm_Acoes_Visualizar.Enabled = True

        End If

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS COMPONENTES DO FORMULÁRIO"

    Public Sub AtivarModoCadastro(Modo As Integer)

        ModoAtual = Modo

        VisualizacaoPainelDados(True)
        ConfigurarModoCadastro()
        AtualizarTituloFormulario(Me, ModoAtual, NomeFormulario)

    End Sub

    Public Sub CamposEditaveis(Status As Boolean)

        TxtBx_NomeClinica.Enabled = Status
        TxtBx_NomeAtendente.Enabled = Status
        TxtBx_EmailAtendimento.Enabled = Status
        MskdTxtBx_Telefone.Enabled = Status
        MskdTxtBx_Fixo.Enabled = Status
        MskdTxtBx_CEP.Enabled = Status
        TxtBx_Numero.Enabled = Status
        Bttn_PesquisarCEP.Enabled = Status
        Bttn_PesquisarCEP.Visible = Status

    End Sub

    Public Sub DesativarModoCadastro()

        ModoAtual = 4

        VisualizacaoPainelDados(False)
        AtualizarTituloFormulario(Me, ModoAtual, NomeFormulario)
        LimparCampos()

    End Sub

    Public Sub VisualizacaoPainelDados(ModoVisualizacaoAtual As Boolean)

        Pnl_Dados.Visible = ModoVisualizacaoAtual
        MnStrp_MenuPrincipal.Enabled = Not ModoVisualizacaoAtual

    End Sub

    Public Sub ConfigurarModoCadastro()

        If Not ModoCadastroConfiguracoes.ContainsKey(ModoAtual) Then Exit Sub

        Dim config = ModoCadastroConfiguracoes(ModoAtual)

        Bttn_Adicionar.Visible = config.Adicionar
        Bttn_Atualizar.Visible = config.Atualizar
        Bttn_Excluir.Visible = config.Excluir
        Bttn_Limpar.Visible = config.Limpar

        If ModoAtual = ModoAtualCadastro.REMOVENDO Or ModoAtual = ModoAtualCadastro.VISUALIZANDO Then
            CamposEditaveis(False)
        Else
            CamposEditaveis(True)
        End If

        Select Case config.BotaoPadrao

            Case BotaoPadraoEnum.ADICIONAR : Me.AcceptButton = Bttn_Adicionar
            Case BotaoPadraoEnum.ATUALIZAR : Me.AcceptButton = Bttn_Atualizar
            Case BotaoPadraoEnum.EXCLUIR : Me.AcceptButton = Bttn_Excluir

            Case Else : Me.AcceptButton = Nothing

        End Select

    End Sub

#End Region

#Region "FUNÇÕES PARA CONFIGURAÇÃO DOS COMPONENTES DO FORMULÁRIO"

    Public Sub LimparCampos()

        TxtBx_NomeClinica.Text = ""
        TxtBx_NomeAtendente.Text = ""
        TxtBx_EmailAtendimento.Text = ""
        MskdTxtBx_Telefone.Text = ""
        MskdTxtBx_Fixo.Text = ""
        MskdTxtBx_CEP.Text = ""
        TxtBx_Logradouro.Text = ""
        TxtBx_Numero.Text = ""
        TxtBx_Bairro.Text = ""
        TxtBx_Cidade.Text = ""
        TxtBx_Estado.Text = ""

        TbCntrl_Dados.SelectedTab = TbPg_InformacoesCorporativas

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE MENU"

    Private Sub TlStrpMnItm_Acoes_Adicionar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_Adicionar.Click

        AtivarModoCadastro(0)

    End Sub

    Private Sub TlStrpMnItm_Acoes_Editar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_Editar.Click

        'ClinicaAutorizadaAtual = IniciarFormulario_Selecao_ClinicasAutorizadas()
        'RecuperarDadosClinicaAutorizada()
        'AtivarModoCadastro(1)

    End Sub

    Private Sub TlStrpMnItm_Acoes_Remover_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_Remover.Click

        'ClinicaAutorizadaAtual = IniciarFormulario_Selecao_ClinicasAutorizadas()
        'RecuperarDadosClinicaAutorizada()
        'AtivarModoCadastro(2)

    End Sub

    Private Sub TlStrpMnItm_Acoes_Visualizar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_Visualizar.Click

        'ClinicaAutorizadaAtual = IniciarFormulario_Selecao_ClinicasAutorizadas()
        'RecuperarDadosClinicaAutorizada()
        'AtivarModoCadastro(3)

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE AÇÃO"

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Bttn_Cancelar.Click

        DesativarModoCadastro()

    End Sub

    Private Sub Bttn_Excluir_Click(sender As Object, e As EventArgs) Handles Bttn_Excluir.Click

        Excluir_ClinicaAutorizada()

    End Sub

    Private Sub Bttn_Limpar_Click(sender As Object, e As EventArgs) Handles Bttn_Limpar.Click

        LimparCampos()

    End Sub

    Private Sub Bttn_Atualizar_Click(sender As Object, e As EventArgs) Handles Bttn_Atualizar.Click

        Atualizar_ClinicaAutorizada()

    End Sub

    Private Sub Bttn_Adicionar_Click(sender As Object, e As EventArgs) Handles Bttn_Adicionar.Click

        Adicionar_ClinicaAutorizada()

    End Sub

    Private Sub Bttn_PesquisarCEP_Click(sender As Object, e As EventArgs) Handles Bttn_PesquisarCEP.Click

        Pesquisar__CEP()

    End Sub

#End Region

#Region "FUNÇÕES MANIPULAÇÃO DE DADOS"

    Public Function CamposObrigatoriosPreenchidos() As Boolean


        If VerificarObrigatorio(TxtBx_NomeClinica, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False
        If VerificarObrigatorio(TxtBx_NomeAtendente, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False
        If VerificarObrigatorio(TxtBx_EmailAtendimento, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False
        If EmailValido(TxtBx_EmailAtendimento, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False
        If VerificarObrigatorio(MskdTxtBx_CEP, TbCntrl_Dados, TbPg_InformacoesDeLocalizacao) = False Then Return False
        If VerificarObrigatorio(TxtBx_Numero, TbCntrl_Dados, TbPg_InformacoesDeLocalizacao) = False Then Return False

        If TxtBx_Logradouro.Text.Trim = "" Then
            ExibirMensagem__Alerta("É obrigatório pesquisar o CEP para carregar o endereço!")
            Return False
        End If

        Return True

    End Function

    Public Sub RecuperarDadosClinicaAutorizada()

        If ClinicaAutorizadaAtual Is Nothing Then

            LimparCampos()
            Return

        End If

        With ClinicaAutorizadaAtual

            TxtBx_NomeClinica.Text = .NomeClinica
            TxtBx_NomeAtendente.Text = .NomeAtendente
            TxtBx_EmailAtendimento.Text = .EmailAtendimento
            MskdTxtBx_Telefone.Text = .Telefone
            MskdTxtBx_Fixo.Text = .Fixo
            MskdTxtBx_CEP.Text = .CEP
            TxtBx_Logradouro.Text = .Logradouro
            TxtBx_Numero.Text = .Numero
            TxtBx_Bairro.Text = .Bairro
            TxtBx_Cidade.Text = .Cidade
            TxtBx_Estado.Text = .Estado

        End With

    End Sub

    Public Sub SalvarDadosClinicaAutorizada()

        If ClinicaAutorizadaAtual Is Nothing Then
            ClinicaAutorizadaAtual = New ClinicaAutorizada
        End If

        With ClinicaAutorizadaAtual

            .NomeClinica = TxtBx_NomeClinica.Text.Trim
            .NomeAtendente = TxtBx_NomeAtendente.Text.Trim
            .EmailAtendimento = TxtBx_EmailAtendimento.Text.Trim
            .Telefone = MskdTxtBx_Telefone.Text.Trim.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
            .Fixo = MskdTxtBx_Fixo.Text.Trim.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
            .CEP = MskdTxtBx_CEP.Text.Trim.Replace("-", "").Replace(".", "")
            .Logradouro = TxtBx_Logradouro.Text.Trim
            .Numero = TxtBx_Numero.Text.Trim
            .Bairro = TxtBx_Bairro.Text.Trim
            .Cidade = TxtBx_Cidade.Text.Trim
            .Estado = TxtBx_Estado.Text.Trim
            .Status = StatusCadastro.ATIVO

        End With

    End Sub

#End Region

#Region "FUNÇÕES AUXILIARES"

    Private Sub InicializarFormulario()

        Me.KeyPreview = True

        DesativarModoCadastro()
        LimparCampos()

    End Sub

    Private Sub FinalizarFormulario(Optional status As DialogResult = DialogResult.Cancel)

        Me.DialogResult = status
        Me.Close()

    End Sub

#End Region

#Region "FUNÇÕES ASSÍNCRONAS"

    Private Sub Adicionar_ClinicaAutorizada()

        If CamposObrigatoriosPreenchidos() = False Then Exit Sub

        SalvarDadosClinicaAutorizada()

        Dim resultadoClinicaAutorizada = ClinicaAutorizada__Adicionar(ClinicaAutorizadaAtual)

        If resultadoClinicaAutorizada.Item1 Then

            ExibirMensagem__Sucesso(resultadoClinicaAutorizada.Item2)
            DesativarModoCadastro()

        Else

            ExibirMensagem__Erro(resultadoClinicaAutorizada.Item2)

        End If

    End Sub

    Private Sub Atualizar_ClinicaAutorizada()

        If CamposObrigatoriosPreenchidos() = False Then Exit Sub

        SalvarDadosClinicaAutorizada()

        Dim resultadoClinicaAutorizada = ClinicaAutorizada__Atualizar(ClinicaAutorizadaAtual)

        If resultadoClinicaAutorizada.Item1 Then

            ExibirMensagem__Sucesso(resultadoClinicaAutorizada.Item2)
            DesativarModoCadastro()

        Else

            ExibirMensagem__Erro(resultadoClinicaAutorizada.Item2)

        End If

    End Sub

    Private Sub Excluir_ClinicaAutorizada()

        If MessageBox.Equals(MessageBox.Show("Tem certeza que deseja remover esta Clínica Autorizada?", "Confirmação",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question), DialogResult.No) Then
            Return
        End If

        Dim resultado = ClinicaAutorizada__Remover(ClinicaAutorizadaAtual)

        If resultado.Item1 Then

            ExibirMensagem__Sucesso(resultado.Item2)
            DesativarModoCadastro()

        Else

            ExibirMensagem__Erro(resultado.Item2)

        End If

    End Sub

    Private Sub Pesquisar__CEP()

        Dim cep As String = MskdTxtBx_CEP.Text.Replace("-", "").Replace(".", "").Trim()

        Dim endereco As JObject = ObterEnderecoPorCEP(cep)

        If endereco IsNot Nothing Then

            If endereco("erro") IsNot Nothing Then
                ExibirMensagem__Erro("CEP não encontrado.")
                Return
            End If

            TxtBx_Logradouro.Text = endereco("logradouro").ToString()
            TxtBx_Bairro.Text = endereco("bairro").ToString()
            TxtBx_Cidade.Text = endereco("localidade").ToString()
            TxtBx_Estado.Text = endereco("estado").ToString()

        End If

    End Sub

#End Region

End Class