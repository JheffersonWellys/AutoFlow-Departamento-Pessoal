Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AutoFlow___Departamento_Pessoal__DP_.AutoFlow.Globais
Public Class Frm__Cadastro__Colaboradores

#Region "VARIÁVEIS DO FORMULÁRIO"

    Public Property ColaboradorAtual As Colaborador
    Dim ModoAtual As ModoAtualCadastro
    Dim NomeFormulario As String = NomeSistema & " | Cadastro de Colaboradores"

#End Region

#Region "FUNÇÕES PARA CONTROLE DO FORMULÁRIO"

    Private Sub Frm__Cadastro__Colaboradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InicializarFormulario()

    End Sub

    Private Sub Frm__Cadastro__Colaboradores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Clss__UIHelper.ConfirmarSaidaDoCadastro(Me, ModoAtual, "colaborador") Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Frm__Cadastro__Colaboradores_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If ModoAtual <> 4 Then
                If Not Clss__UIHelper.ConfirmarSaidaDoCadastro(Me, ModoAtual, "colaborador") Then
                    DesativarModoCadastro()
                End If
            Else
                Me.Close()
            End If
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

        TxtBx_NomeCompleto.Enabled = Status
        TxtBx_NomeSocial.Enabled = Status
        TxtBx_EmailPessoal.Enabled = Status
        MskdTxtBx_TelefonePessoal.Enabled = Status
        CmbBx_Sexo.Enabled = Status
        DtTmPckr_DataDeNascimento.Enabled = Status
        MskdTxtBx_CPF.Enabled = Status
        TxtBx_RG.Enabled = Status
        TxtBx_EmailCorporativo.Enabled = Status
        TxtBx_Funcao.Enabled = Status
        TxtBx_Setor.Enabled = Status
        MskdTxtBx_Chapa.Enabled = Status
        DtTmPckr_DataDeAdmissao.Enabled = Status
        DtTmPckr_DataDeDemissao.Enabled = Status
        CmbBx_TipoContrato.Enabled = Status
        CmbBx_ModalidadeContrato.Enabled = Status

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

        CmbBx_ModalidadeContrato.Enabled = False

    End Sub

#End Region

#Region "FUNÇÕES PARA CONFIGURAÇÃO DOS COMPONENTES DO FORMULÁRIO"

    Public Sub ConfigurarComboxes()

        CmbBx_Sexo.DataSource = ObterListaChaveValorDeEnum(Of Sexo)()
        CmbBx_Sexo.DisplayMember = "Value"
        CmbBx_Sexo.ValueMember = "Key"

        Dim listaFiltradaTipoContrato = ObterListaChaveValorDeEnum(Of TipoContrato)() _
            .Where(Function(item) item.Key <> TipoContrato.TODOS) _
            .ToList()
        CmbBx_TipoContrato.DataSource = listaFiltradaTipoContrato
        CmbBx_TipoContrato.DisplayMember = "Value"
        CmbBx_TipoContrato.ValueMember = "Key"

        Dim listaFiltradaModalidadeContrato = ObterListaChaveValorDeEnum(Of ModalidadeContrato)() _
            .Where(Function(item) item.Key <> ModalidadeContrato.TODOS) _
            .ToList()

        CmbBx_ModalidadeContrato.DataSource = listaFiltradaModalidadeContrato
        CmbBx_ModalidadeContrato.DisplayMember = "Value"
        CmbBx_ModalidadeContrato.ValueMember = "Key"

    End Sub

    Public Sub LimparCampos()

        TxtBx_NomeCompleto.Text = ""
        TxtBx_NomeSocial.Text = ""
        TxtBx_EmailPessoal.Text = ""
        MskdTxtBx_TelefonePessoal.Text = ""
        CmbBx_Sexo.SelectedIndex = -1
        DtTmPckr_DataDeNascimento.Value = Date.Today
        MskdTxtBx_CPF.Text = ""
        TxtBx_RG.Text = ""
        TxtBx_EmailCorporativo.Text = ""
        TxtBx_Funcao.Text = ""
        TxtBx_Setor.Text = ""
        MskdTxtBx_Chapa.Text = ""
        DtTmPckr_DataDeAdmissao.Value = Date.Today
        DtTmPckr_DataDeDemissao.Value = Date.Today
        Lbl_DataDeDemissao.Visible = False
        DtTmPckr_DataDeDemissao.Visible = False
        CmbBx_TipoContrato.SelectedIndex = -1
        CmbBx_ModalidadeContrato.SelectedIndex = -1

        TbCntrl_Dados.SelectedTab = TbPg_InformacoesPessoais

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE MENU"

    Private Sub TlStrpMnItm_Acoes_Adicionar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_Adicionar.Click

        AtivarModoCadastro(0)

    End Sub

    Private Sub TlStrpMnItm_Acoes_Editar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_Editar.Click

        ColaboradorAtual = IniciarFormulario_Selecao_Colaboradores()

        If ColaboradorAtual IsNot Nothing Then
            RecuperarDadosColaborador()
            AtivarModoCadastro(1)
        End If

    End Sub

    Private Sub TlStrpMnItm_Acoes_Remover_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_Remover.Click

        ColaboradorAtual = IniciarFormulario_Selecao_Colaboradores()
        If ColaboradorAtual IsNot Nothing Then
            RecuperarDadosColaborador()
            AtivarModoCadastro(2)
        End If

    End Sub

    Private Sub TlStrpMnItm_Acoes_Visualizar_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_Visualizar.Click

        ColaboradorAtual = IniciarFormulario_Selecao_Colaboradores()
        If ColaboradorAtual IsNot Nothing Then
            RecuperarDadosColaborador()
            AtivarModoCadastro(3)
        End If

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE AÇÃO"

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Bttn_Cancelar.Click

        DesativarModoCadastro()

    End Sub

    Private Sub Bttn_Excluir_Click(sender As Object, e As EventArgs) Handles Bttn_Excluir.Click

        Excluir_Colaborador()

    End Sub

    Private Sub Bttn_Limpar_Click(sender As Object, e As EventArgs) Handles Bttn_Limpar.Click

        LimparCampos()

    End Sub

    Private Sub Bttn_Atualizar_Click(sender As Object, e As EventArgs) Handles Bttn_Atualizar.Click

        Atualizar_Colaborador()

    End Sub

    Private Sub Bttn_Adicionar_Click(sender As Object, e As EventArgs) Handles Bttn_Adicionar.Click

        Adicionar_Colaborador()

    End Sub

#End Region

#Region "FUNÇÕES MANIPULAÇÃO DE DADOS"

    Public Function CamposObrigatoriosPreenchidos() As Boolean

        If VerificarObrigatorio(TxtBx_NomeCompleto, TbCntrl_Dados, TbPg_InformacoesPessoais) = False Then Return False
        If VerificarObrigatorio(CmbBx_Sexo, TbCntrl_Dados, TbPg_InformacoesPessoais) = False Then Return False
        If VerificarObrigatorio(DtTmPckr_DataDeNascimento, TbCntrl_Dados, TbPg_InformacoesPessoais) = False Then Return False
        If VerificarObrigatorio(MskdTxtBx_CPF, TbCntrl_Dados, TbPg_InformacoesPessoais) = False Then Return False
        If Not CPFValido(MskdTxtBx_CPF, TbCntrl_Dados, TbPg_InformacoesPessoais) Then Return False
        If TxtBx_EmailPessoal.Text <> "" AndAlso VerificarObrigatorio(TxtBx_EmailPessoal, TbCntrl_Dados, TbPg_InformacoesPessoais) = False Then Return False
        If VerificarObrigatorio(TxtBx_EmailCorporativo, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False
        If Not EmailValidoSenac(TxtBx_EmailCorporativo) Then Return False
        If VerificarObrigatorio(MskdTxtBx_Chapa, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False
        If VerificarObrigatorio(TxtBx_Funcao, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False
        If VerificarObrigatorio(TxtBx_Setor, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False
        If VerificarObrigatorio(DtTmPckr_DataDeAdmissao, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False
        If VerificarObrigatorio(CmbBx_TipoContrato, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False
        If VerificarObrigatorio(CmbBx_ModalidadeContrato, TbCntrl_Dados, TbPg_InformacoesCorporativas) = False Then Return False

        Return True

    End Function

    Public Sub AtualizarVisibilidadeDataDemissao(dataDemissaoCriptografada As String)

        If String.IsNullOrEmpty(dataDemissaoCriptografada) Then
            Lbl_DataDeDemissao.Visible = False
            DtTmPckr_DataDeDemissao.Visible = False
        Else
            DtTmPckr_DataDeDemissao.Value = DescriptografarTexto(dataDemissaoCriptografada)
            Lbl_DataDeDemissao.Visible = True
            DtTmPckr_DataDeDemissao.Visible = True
        End If

    End Sub

    Public Sub RecuperarDadosColaborador()

        If ColaboradorAtual Is Nothing Then

            LimparCampos()

            Return

        End If

        With ColaboradorAtual

            TxtBx_NomeCompleto.Text = .NomeCompleto
            TxtBx_NomeSocial.Text = .NomeSocial
            TxtBx_EmailPessoal.Text = DescriptografarTexto(.EmailPessoal)
            MskdTxtBx_TelefonePessoal.Text = DescriptografarTexto(.TelefonePessoal)
            TxtBx_EmailCorporativo.Text = .EmailCorporativo
            TxtBx_Funcao.Text = .Funcao
            TxtBx_Setor.Text = .Setor
            MskdTxtBx_Chapa.Text = .Chapa
            MskdTxtBx_CPF.Text = DescriptografarTexto(.CPF)
            TxtBx_RG.Text = DescriptografarTexto(.RG)

            CmbBx_Sexo.SelectedValue = CType(.Sexo, Integer)
            CmbBx_TipoContrato.SelectedValue = CType(.TipoContrato, Integer)
            CmbBx_ModalidadeContrato.SelectedValue = CType(.ModalidadeContrato, Integer)

            DtTmPckr_DataDeNascimento.Value = ObterDataSegura(.DataDeNascimento)
            DtTmPckr_DataDeAdmissao.Value = ObterDataSegura(.DataDeAdmissao)
            DtTmPckr_DataDeDemissao.Value = ObterDataSegura(.DataDeDemissao)

            AtualizarVisibilidadeDataDemissao(.DataDeDemissao)

        End With

    End Sub

    Public Sub SalvarDadosColaborador()

        If ColaboradorAtual Is Nothing Then
            ColaboradorAtual = New Colaborador
        End If

        With ColaboradorAtual

            .NomeCompleto = TxtBx_NomeCompleto.Text
            .NomeSocial = TxtBx_NomeSocial.Text
            .EmailPessoal = CriptografarTexto(TxtBx_EmailPessoal.Text)
            .TelefonePessoal = CriptografarTexto(MskdTxtBx_TelefonePessoal.Text)
            .Sexo = CType(CmbBx_Sexo.SelectedValue, Sexo)
            .DataDeNascimento = CriptografarTexto(DtTmPckr_DataDeNascimento.Value)
            .CPF = CriptografarTexto(MskdTxtBx_CPF.Text)
            .RG = CriptografarTexto(TxtBx_RG.Text)
            .EmailCorporativo = TxtBx_EmailCorporativo.Text
            .Funcao = TxtBx_Funcao.Text
            .Setor = TxtBx_Setor.Text
            .Chapa = MskdTxtBx_Chapa.Text
            .DataDeAdmissao = CriptografarTexto(DtTmPckr_DataDeAdmissao.Value)

            If DtTmPckr_DataDeDemissao.Visible Then
                .DataDeDemissao = CriptografarTexto(DtTmPckr_DataDeDemissao.Value)
            Else
                .DataDeDemissao = Nothing
            End If

            .TipoContrato = CType(CmbBx_TipoContrato.SelectedValue, TipoContrato)
            .ModalidadeContrato = CType(CmbBx_ModalidadeContrato.SelectedValue, ModalidadeContrato)

        End With

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE SELEÇÃO"

    Private Sub CmbBx_TipoContrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBx_TipoContrato.SelectedIndexChanged

        If CmbBx_TipoContrato.SelectedValue IsNot Nothing Then

            Dim tipoSelecionado As TipoContrato = CType(CmbBx_TipoContrato.SelectedValue, TipoContrato)

            If ModalidadesPorTipoContrato.ContainsKey(tipoSelecionado) Then
                Dim modalidadesPermitidas = ModalidadesPorTipoContrato(tipoSelecionado)

                Dim listaFiltradaModalidadeContrato = ObterListaChaveValorDeEnum(Of ModalidadeContrato)().
                Where(Function(x) modalidadesPermitidas.Contains(CType(x.Key, ModalidadeContrato)) AndAlso x.Key <> ModalidadeContrato.TODOS).
                ToList()

                CmbBx_ModalidadeContrato.DataSource = listaFiltradaModalidadeContrato
                CmbBx_ModalidadeContrato.DisplayMember = "Value"
                CmbBx_ModalidadeContrato.ValueMember = "Key"
            End If

        End If

        CmbBx_ModalidadeContrato.SelectedIndex = -1

        If CmbBx_TipoContrato.SelectedIndex = -1 Then

            CmbBx_ModalidadeContrato.Enabled = False

        Else

            CmbBx_ModalidadeContrato.Enabled = True

        End If

    End Sub

#End Region

#Region "FUNÇÕES AUXILIARES"

    Private Sub InicializarFormulario()

        Me.KeyPreview = True

        DesativarModoCadastro()
        ConfigurarComboxes()
        LimparCampos()

    End Sub

    Private Sub FinalizarFormulario(Optional status As DialogResult = DialogResult.Cancel)

        Me.DialogResult = status
        Me.Close()

    End Sub

#End Region

#Region "FUNÇÕES ASSÍNCRONAS"

    Private Sub Adicionar_Colaborador()


        If CamposObrigatoriosPreenchidos() = False Then Exit Sub

        SalvarDadosColaborador()

        Dim resultado = Colaborador__Adicionar(ColaboradorAtual)

        If resultado.Item1 Then

            ExibirMensagem__Sucesso(resultado.Item2)
            DesativarModoCadastro()

        Else

            ExibirMensagem__Erro(resultado.Item2)

        End If

    End Sub

    Private Sub Atualizar_Colaborador()

        If CamposObrigatoriosPreenchidos() = False Then Exit Sub

        SalvarDadosColaborador()

        Dim resultado = Colaborador__Atualizar(ColaboradorAtual)

        If resultado.Item1 Then

            ExibirMensagem__Sucesso(resultado.Item2)
            DesativarModoCadastro()

        Else

            ExibirMensagem__Erro(resultado.Item2)

        End If

    End Sub

    Private Sub Excluir_Colaborador()

        If MessageBox.Equals(MessageBox.Show("Tem certeza que deseja remover este colaborador?", "Confirmação",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question), DialogResult.No) Then
            Return
        End If

        Dim resultado = Colaborador__Remover(ColaboradorAtual)

        If resultado.Item1 Then

            ExibirMensagem__Sucesso(resultado.Item2)
            DesativarModoCadastro()

        Else

            ExibirMensagem__Erro(resultado.Item2)

        End If

    End Sub

    Private Sub Frm__Cadastro__Colaboradores_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        TlStrpSttsLbl_NumeroTotalDeColaboradores.Text = Colaborador_ObterQuantidadeDeAtivos()

        If TlStrpSttsLbl_NumeroTotalDeColaboradores.Text = 0 Then

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

End Class