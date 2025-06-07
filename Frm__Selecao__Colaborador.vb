Imports System.Data.SQLite
Imports AutoFlow___Departamento_Pessoal__DP_.Md__SQLite__Classes

Public Class Frm__Selecao__Colaborador

#Region "VARIÁVEIS DO FORMULÁRIO"

    Public Property ColaboradorSelecionado As Colaborador
    Private Property Lista_Colaboradores As DataTable
    Public Property ModoSelecao As FiltroContrato

#End Region

#Region "FUNÇÕES PARA CONTROLE DO FORMULÁRIO"

    Private Sub Frm__Selecao__Colaborador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InicializarFormulario()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS COMPONENTES DO FORMULÁRIO"

    Private Sub TxtBx_TermoDePesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtBx_TermoDePesquisa.TextChanged

        FiltrarListaColaboradores(TxtBx_TermoDePesquisa.Text)

    End Sub

#End Region

#Region "FUNÇÕES PARA CONFIGURAÇÃO DOS COMPONENTES DO FORMULÁRIO"

    Private Sub PopularComboFiltro()

        CmbBx_TipoDeContratoEModalidadeDeContrato.Items.Clear()

        CmbBx_TipoDeContratoEModalidadeDeContrato.Items.Add(New FiltroContrato(TipoContrato.TODOS, ModalidadeContrato.TODOS))
        CmbBx_TipoDeContratoEModalidadeDeContrato.Items.Add(New FiltroContrato(TipoContrato.HORISTA, ModalidadeContrato.TODOS))
        CmbBx_TipoDeContratoEModalidadeDeContrato.Items.Add(New FiltroContrato(TipoContrato.HORISTA, ModalidadeContrato.INTERMITENTE))
        CmbBx_TipoDeContratoEModalidadeDeContrato.Items.Add(New FiltroContrato(TipoContrato.HORISTA, ModalidadeContrato.INSTRUTOR_DE_FORMACAO_PROFISSIONAL))
        CmbBx_TipoDeContratoEModalidadeDeContrato.Items.Add(New FiltroContrato(TipoContrato.MENSALISTA, ModalidadeContrato.TODOS))
        CmbBx_TipoDeContratoEModalidadeDeContrato.Items.Add(New FiltroContrato(TipoContrato.MENSALISTA, ModalidadeContrato.ADMINISTRATIVO))
        CmbBx_TipoDeContratoEModalidadeDeContrato.Items.Add(New FiltroContrato(TipoContrato.MENSALISTA, ModalidadeContrato.INSTRUTOR_DE_FORMACAO_PROFISSIONAL))
        CmbBx_TipoDeContratoEModalidadeDeContrato.Items.Add(New FiltroContrato(TipoContrato.MENSALISTA, ModalidadeContrato.PRAZO_DETERMINADO))

        CmbBx_TipoDeContratoEModalidadeDeContrato.SelectedIndex = 0

    End Sub

    Private Sub ConfigurarLayoutLista_Colaboradores()

        If DtGrdVw_Lista_Colaboradores.DataSource Is Nothing Then Exit Sub
        If DtGrdVw_Lista_Colaboradores.Columns.Count = 0 Then Exit Sub

        DtGrdVw_Lista_Colaboradores.Columns("id").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("nome_completo").Visible = True
        DtGrdVw_Lista_Colaboradores.Columns("chapa").Visible = True
        DtGrdVw_Lista_Colaboradores.Columns("funcao").Visible = True
        DtGrdVw_Lista_Colaboradores.Columns("tipo_contrato").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("modalidade_contrato").Visible = False
        DtGrdVw_Lista_Colaboradores.Columns("uid_usuario_logado").Visible = False

        DtGrdVw_Lista_Colaboradores.Columns("nome_completo").HeaderText = "Nome Completo"
        DtGrdVw_Lista_Colaboradores.Columns("chapa").HeaderText = "Chapa"
        DtGrdVw_Lista_Colaboradores.Columns("funcao").HeaderText = "Função"

        DtGrdVw_Lista_Colaboradores.Columns("nome_completo").Width = 380
        DtGrdVw_Lista_Colaboradores.Columns("chapa").Width = 110
        DtGrdVw_Lista_Colaboradores.Columns("funcao").Width = 400

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE MENU"

    Private Sub TlStrpMnItm_Acoes_LimparFiltro_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_LimparFiltro.Click

        LimparFiltros()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE SUB MENU"

    Private Sub TlStrpMnItm_SubMenuPrincipal_SelecionarColaborador_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_SubMenuPrincipal_SelecionarColaborador.Click

    End Sub

    Private Sub TlStrpMnItm_SubMenuPrincipal_LimparFiltro_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_SubMenuPrincipal_LimparFiltro.Click

        LimparFiltros()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE AÇÃO"

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Bttn_Cancelar.Click

        FinalizarFormulario()

    End Sub

    Private Sub Bttn_Selecionar_Click(sender As Object, e As EventArgs) Handles Bttn_Selecionar.Click

        Selecionar_ColaboradorMarcado

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE SELEÇÃO"

    Private Sub CmbBx_TipoDeContratoEModalidadeDeContrato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBx_TipoDeContratoEModalidadeDeContrato.SelectedIndexChanged

        If CmbBx_TipoDeContratoEModalidadeDeContrato.SelectedIndex >= 0 Then

            Dim filtroSelecionado As FiltroContrato = CType(CmbBx_TipoDeContratoEModalidadeDeContrato.SelectedItem, FiltroContrato)

            ModoSelecao = filtroSelecionado

            CarregarLista_Colaboradores()

        End If

    End Sub

#End Region

#Region "FUNÇÕES MANIPULAÇÃO DE DADOS"

    Private Sub FiltrarListaColaboradores(text As String)

        Dim dt As DataTable = TryCast(DtGrdVw_Lista_Colaboradores.DataSource, DataTable)

        If dt Is Nothing Then Return

        Dim dv As New DataView(dt)

        Dim filtro As String = text.Trim().Replace("'", "''")

        If filtro.Length > 0 Then
            dv.RowFilter = String.Format("nome_completo LIKE '%{0}%' OR chapa LIKE '%{0}%' OR funcao LIKE '%{0}%'", filtro)
        Else
            dv.RowFilter = String.Empty
        End If

        DtGrdVw_Lista_Colaboradores.DataSource = dv

        DtGrdVw_Lista_Colaboradores.ClearSelection()

    End Sub

    Public Sub CarregarLista_Colaboradores()

        Dim dt As DataTable = Nothing
        Dim tipo As TipoContrato? = Nothing
        Dim modalidade As ModalidadeContrato? = Nothing

        Select Case ModoSelecao.Tipo
            Case TipoContrato.TODOS
                dt = Listar_ColaboradoresAtivos()

            Case TipoContrato.HORISTA
                tipo = TipoContrato.HORISTA
                Select Case ModoSelecao.Modalidade
                    Case ModalidadeContrato.TODOS
                        modalidade = Nothing
                    Case ModalidadeContrato.INTERMITENTE
                        modalidade = ModalidadeContrato.INTERMITENTE
                    Case ModalidadeContrato.INSTRUTOR_DE_FORMACAO_PROFISSIONAL
                        modalidade = ModalidadeContrato.INSTRUTOR_DE_FORMACAO_PROFISSIONAL
                    Case Else
                        dt = New DataTable()
                End Select

            Case TipoContrato.MENSALISTA
                tipo = TipoContrato.MENSALISTA
                Select Case ModoSelecao.Modalidade
                    Case ModalidadeContrato.TODOS
                        modalidade = Nothing
                    Case ModalidadeContrato.ADMINISTRATIVO
                        modalidade = ModalidadeContrato.ADMINISTRATIVO
                    Case ModalidadeContrato.INSTRUTOR_DE_FORMACAO_PROFISSIONAL
                        modalidade = ModalidadeContrato.INSTRUTOR_DE_FORMACAO_PROFISSIONAL
                    Case ModalidadeContrato.PRAZO_DETERMINADO
                        modalidade = ModalidadeContrato.PRAZO_DETERMINADO
                    Case Else
                        dt = New DataTable()
                End Select

            Case Else
                dt = New DataTable()
        End Select

        If dt Is Nothing Then
            If tipo.HasValue AndAlso modalidade.HasValue Then
                dt = Listar_ColaboradoresAtivos(tipo:=tipo.Value, modalidade:=modalidade.Value)
            ElseIf tipo.HasValue Then
                dt = Listar_ColaboradoresAtivos(tipo:=tipo.Value)
            Else
                dt = Listar_ColaboradoresAtivos()
            End If
        End If

        DtGrdVw_Lista_Colaboradores.DataSource = dt

        If dt IsNot Nothing Then
            ConfigurarLayoutLista_Colaboradores()
        End If

    End Sub

#End Region

#Region "FUNÇÕES AUXILIARES"

    Public Sub InicializarFormulario()

        Call PopularComboFiltro()
        Call CarregarLista_Colaboradores()

    End Sub

    Public Sub FinalizarFormulario(Optional Status As DialogResult = DialogResult.Cancel)

        Me.DialogResult = Status
        Me.Close()

    End Sub

    Private Sub LimparFiltros()

        TxtBx_TermoDePesquisa.Text = String.Empty

        Dim dt As DataTable = TryCast(DtGrdVw_Lista_Colaboradores.DataSource, DataTable)
        If dt IsNot Nothing Then
            DtGrdVw_Lista_Colaboradores.DataSource = dt
        End If

        Dim dv As DataView = TryCast(DtGrdVw_Lista_Colaboradores.DataSource, DataView)
        If dv IsNot Nothing Then
            dv.RowFilter = String.Empty
            DtGrdVw_Lista_Colaboradores.DataSource = dv
        End If

        TxtBx_TermoDePesquisa.Focus()

    End Sub

    Private Sub Selecionar_ColaboradorMarcado()

        If DtGrdVw_Lista_Colaboradores.SelectedRows.Count > 0 Then
            Dim id As Integer = Convert.ToInt32(DtGrdVw_Lista_Colaboradores.SelectedRows(0).Cells("id").Value)
            ColaboradorSelecionado = ObterColaboradorPorId(id)

            If ColaboradorSelecionado IsNot Nothing Then
                FinalizarFormulario(DialogResult.OK)
            End If
        End If

    End Sub

#End Region

End Class