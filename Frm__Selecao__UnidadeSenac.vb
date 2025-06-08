Public Class Frm__Selecao__UnidadeSenac


#Region "VARIÁVEIS DO FORMULÁRIO"

    Public Property UnidadeSenacSelecionada As UnidadeSenac
    Private Property Lista_UnidadesSenac As DataTable

#End Region

#Region "FUNÇÕES PARA CONTROLE DO FORMULÁRIO"

    Private Sub Frm__Selecao__UnidadeSenac_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InicializarFormulario()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS COMPONENTES DO FORMULÁRIO"

    Private Sub TxtBx_TermoDePesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtBx_TermoDePesquisa.TextChanged

        FiltrarListaUnidadesSenac(TxtBx_TermoDePesquisa.Text)

    End Sub

#End Region

#Region "FUNÇÕES PARA CONFIGURAÇÃO DOS COMPONENTES DO FORMULÁRIO"

    Private Sub ConfigurarLayoutLista_UnidadesSenac()

        If DtGrdVw_Lista_UnidadesSenac.DataSource Is Nothing Then Exit Sub
        If DtGrdVw_Lista_UnidadesSenac.Columns.Count = 0 Then Exit Sub

        DtGrdVw_Lista_UnidadesSenac.Columns("id_unidade_senac").Visible = False
        DtGrdVw_Lista_UnidadesSenac.Columns("codigo_unidade").Visible = True
        DtGrdVw_Lista_UnidadesSenac.Columns("nome_unidade").Visible = True
        DtGrdVw_Lista_UnidadesSenac.Columns("uid_usuario_logado").Visible = False
        DtGrdVw_Lista_UnidadesSenac.Columns("estado").Visible = True
        DtGrdVw_Lista_UnidadesSenac.Columns("cep").Visible = True

        DtGrdVw_Lista_UnidadesSenac.Columns("codigo_unidade").HeaderText = "Código Unidade"
        DtGrdVw_Lista_UnidadesSenac.Columns("nome_unidade").HeaderText = "Nome Unidade"
        DtGrdVw_Lista_UnidadesSenac.Columns("estado").HeaderText = "Estado"
        DtGrdVw_Lista_UnidadesSenac.Columns("cep").HeaderText = "CEP"

        DtGrdVw_Lista_UnidadesSenac.Columns("codigo_unidade").Width = 125
        DtGrdVw_Lista_UnidadesSenac.Columns("nome_unidade").Width = 320
        DtGrdVw_Lista_UnidadesSenac.Columns("estado").Width = 320
        DtGrdVw_Lista_UnidadesSenac.Columns("cep").Width = 120

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE MENU"

    Private Sub TlStrpMnItm_Acoes_LimparFiltro_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_LimparFiltro.Click

        LimparFiltros()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE SUB MENU"

    Private Sub TlStrpMnItm_SubMenuPrincipal_SelecionarUnidadeSenac_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_SubMenuPrincipal_SelecionarUnidadeSenac.Click

        Selecionar_UnidadeSenacMarcada()

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

        Selecionar_UnidadeSenacMarcada()

    End Sub

#End Region

#Region "FUNÇÕES MANIPULAÇÃO DE DADOS"

    Private Sub FiltrarListaUnidadesSenac(text As String)

        Dim dt As DataTable = TryCast(DtGrdVw_Lista_UnidadesSenac.DataSource, DataTable)

        If dt Is Nothing Then Return

        Dim dv As New DataView(dt)

        Dim filtro As String = text.Trim().Replace("'", "''")

        If filtro.Length > 0 Then
            dv.RowFilter = String.Format("codigo_unidade LIKE '%{0}%' OR nome_unidade LIKE '%{0}%' OR estado LIKE '%{0}%' OR cep LIKE '%{0}%'", filtro)
        Else
            dv.RowFilter = String.Empty
        End If

        DtGrdVw_Lista_UnidadesSenac.DataSource = dv

        DtGrdVw_Lista_UnidadesSenac.ClearSelection()

    End Sub

    Public Sub CarregarLista_UnidadesSenac()

        Dim dt As DataTable = Nothing

        dt = Listar_UnidadesSenacAtivas()

        DtGrdVw_Lista_UnidadesSenac.DataSource = dt

        If dt IsNot Nothing Then

            ConfigurarLayoutLista_UnidadesSenac()

        End If

    End Sub

#End Region

#Region "FUNÇÕES AUXILIARES"

    Public Sub InicializarFormulario()

        Call CarregarLista_UnidadesSenac()

    End Sub

    Public Sub FinalizarFormulario(Optional Status As DialogResult = DialogResult.Cancel)

        Me.DialogResult = Status
        Me.Close()

    End Sub

    Private Sub LimparFiltros()

        TxtBx_TermoDePesquisa.Text = String.Empty

        Dim dt As DataTable = TryCast(DtGrdVw_Lista_UnidadesSenac.DataSource, DataTable)
        If dt IsNot Nothing Then
            DtGrdVw_Lista_UnidadesSenac.DataSource = dt
        End If

        Dim dv As DataView = TryCast(DtGrdVw_Lista_UnidadesSenac.DataSource, DataView)
        If dv IsNot Nothing Then
            dv.RowFilter = String.Empty
            DtGrdVw_Lista_UnidadesSenac.DataSource = dv
        End If

        TxtBx_TermoDePesquisa.Focus()

    End Sub

    Private Sub Selecionar_UnidadeSenacMarcada()

        If DtGrdVw_Lista_UnidadesSenac.SelectedRows.Count > 0 Then
            Dim id_UnidadeSenac As Integer = Convert.ToInt32(DtGrdVw_Lista_UnidadesSenac.SelectedRows(0).Cells("id_unidade_senac").Value)
            UnidadeSenacSelecionada = UnidadeSenac__ObterPorId(id_UnidadeSenac)

            If UnidadeSenacSelecionada IsNot Nothing Then
                FinalizarFormulario(DialogResult.OK)
            End If
        End If

    End Sub

#End Region


End Class