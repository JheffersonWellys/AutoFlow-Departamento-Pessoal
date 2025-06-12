Public Class Frm__Selecao__AgenciaCaixa

#Region "VARIÁVEIS DO FORMULÁRIO"

    Public Property AgenciaCaixaSelecionada As AgenciaCaixa
    Private Property Lista_AgenciasCaixa As DataTable

#End Region

#Region "FUNÇÕES PARA CONTROLE DO FORMULÁRIO"

    Private Sub Frm__Selecao__AgenciaCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InicializarFormulario()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS COMPONENTES DO FORMULÁRIO"

    Private Sub TxtBx_TermoDePesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtBx_TermoDePesquisa.TextChanged

        FiltrarListaAgenciasCaixa(TxtBx_TermoDePesquisa.Text)

    End Sub

#End Region

#Region "FUNÇÕES PARA CONFIGURAÇÃO DOS COMPONENTES DO FORMULÁRIO"

    Private Sub ConfigurarLayoutLista_AgenciasCaixa()

        If DtGrdVw_Lista_AgenciasCaixa.DataSource Is Nothing Then Exit Sub
        If DtGrdVw_Lista_AgenciasCaixa.Columns.Count = 0 Then Exit Sub

        DtGrdVw_Lista_AgenciasCaixa.Columns("id_agencia_caixa").Visible = False
        DtGrdVw_Lista_AgenciasCaixa.Columns("codigo_agencia").Visible = True
        DtGrdVw_Lista_AgenciasCaixa.Columns("uid_usuario_logado").Visible = False
        DtGrdVw_Lista_AgenciasCaixa.Columns("cidade").Visible = True
        DtGrdVw_Lista_AgenciasCaixa.Columns("estado").Visible = True
        DtGrdVw_Lista_AgenciasCaixa.Columns("cep").Visible = True

        DtGrdVw_Lista_AgenciasCaixa.Columns("codigo_agencia").HeaderText = "Código da Agência"
        DtGrdVw_Lista_AgenciasCaixa.Columns("cidade").HeaderText = "Cidade"
        DtGrdVw_Lista_AgenciasCaixa.Columns("estado").HeaderText = "Estado"
        DtGrdVw_Lista_AgenciasCaixa.Columns("cep").HeaderText = "CEP"

        DtGrdVw_Lista_AgenciasCaixa.Columns("codigo_agencia").Width = 150
        DtGrdVw_Lista_AgenciasCaixa.Columns("cidade").Width = 300
        DtGrdVw_Lista_AgenciasCaixa.Columns("estado").Width = 300
        DtGrdVw_Lista_AgenciasCaixa.Columns("cep").Width = 135

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE MENU"

    Private Sub TlStrpMnItm_Acoes_LimparFiltro_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_LimparFiltro.Click

        LimparFiltros()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE SUB MENU"

    Private Sub TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa.Click

        Selecionar_AgenciaCaixaMarcada()

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

        Selecionar_AgenciaCaixaMarcada()

    End Sub

#End Region

#Region "FUNÇÕES MANIPULAÇÃO DE DADOS"

    Private Sub FiltrarListaAgenciasCaixa(text As String)

        Dim dt As DataTable = TryCast(DtGrdVw_Lista_AgenciasCaixa.DataSource, DataTable)

        If dt Is Nothing Then Return

        Dim dv As New DataView(dt)

        Dim filtro As String = text.Trim().Replace("'", "''")

        If filtro.Length > 0 Then
            dv.RowFilter = String.Format("codigo_agencia LIKE '%{0}%' OR cidade LIKE '%{0}%' OR estado LIKE '%{0}%' OR cep LIKE '%{0}%'", filtro)
        Else
            dv.RowFilter = String.Empty
        End If

        DtGrdVw_Lista_AgenciasCaixa.DataSource = dv

        DtGrdVw_Lista_AgenciasCaixa.ClearSelection()

    End Sub

    Public Sub CarregarLista_AgenciasCaixa()

        Dim dt As DataTable = Nothing

        dt = Listar_AgenciasCaixaAtivas()

        DtGrdVw_Lista_AgenciasCaixa.DataSource = dt

        If dt IsNot Nothing Then

            ConfigurarLayoutLista_AgenciasCaixa()

        End If

    End Sub

#End Region

#Region "FUNÇÕES AUXILIARES"

    Public Sub InicializarFormulario()

        Call CarregarLista_AgenciasCaixa()

    End Sub

    Public Sub FinalizarFormulario(Optional Status As DialogResult = DialogResult.Cancel)

        Me.DialogResult = Status
        Me.Close()

    End Sub

    Private Sub LimparFiltros()

        TxtBx_TermoDePesquisa.Text = String.Empty

        Dim dt As DataTable = TryCast(DtGrdVw_Lista_AgenciasCaixa.DataSource, DataTable)
        If dt IsNot Nothing Then
            DtGrdVw_Lista_AgenciasCaixa.DataSource = dt
        End If

        Dim dv As DataView = TryCast(DtGrdVw_Lista_AgenciasCaixa.DataSource, DataView)
        If dv IsNot Nothing Then
            dv.RowFilter = String.Empty
            DtGrdVw_Lista_AgenciasCaixa.DataSource = dv
        End If

        TxtBx_TermoDePesquisa.Focus()

    End Sub

    Private Sub Selecionar_AgenciaCaixaMarcada()

        If DtGrdVw_Lista_AgenciasCaixa.SelectedRows.Count > 0 Then
            Dim id_AgenciaCaixa As Integer = Convert.ToInt32(DtGrdVw_Lista_AgenciasCaixa.SelectedRows(0).Cells("id_agencia_caixa").Value)
            AgenciaCaixaSelecionada = AgenciaCaixa__ObterPorId(id_AgenciaCaixa)

            If AgenciaCaixaSelecionada IsNot Nothing Then
                FinalizarFormulario(DialogResult.OK)
            End If
        End If

    End Sub

#End Region

End Class