Public Class Frm__Selecao__ClinicaAutorizada

#Region "VARIÁVEIS DO FORMULÁRIO"

    Public Property ClinicaAutorizadaSelecionada As ClinicaAutorizada
    Private Property Lista_ClinicasAutorizadas As DataTable

#End Region

#Region "FUNÇÕES PARA CONTROLE DO FORMULÁRIO"

    Private Sub Frm__Selecao__ClinicaAutorizada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InicializarFormulario()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS COMPONENTES DO FORMULÁRIO"

    Private Sub TxtBx_TermoDePesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtBx_TermoDePesquisa.TextChanged

        FiltrarListaClinicasAutorizadas(TxtBx_TermoDePesquisa.Text)

    End Sub

#End Region

#Region "FUNÇÕES PARA CONFIGURAÇÃO DOS COMPONENTES DO FORMULÁRIO"

    Private Sub ConfigurarLayoutLista_ClinicasAutorizadas()

        If DtGrdVw_Lista_ClinicasAutorizadas.DataSource Is Nothing Then Exit Sub
        If DtGrdVw_Lista_ClinicasAutorizadas.Columns.Count = 0 Then Exit Sub

        DtGrdVw_Lista_ClinicasAutorizadas.Columns("id_clinica_autorizada").Visible = False
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("nome_clinica").Visible = True
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("uid_usuario_logado").Visible = False
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("cidade").Visible = True
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("estado").Visible = True

        DtGrdVw_Lista_ClinicasAutorizadas.Columns("nome_clinica").HeaderText = "Nome Clínica Autorizada"
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("cidade").HeaderText = "Cidade"
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("estado").HeaderText = "Estado"

        DtGrdVw_Lista_ClinicasAutorizadas.Columns("nome_clinica").Width = 410
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("cidade").Width = 240
        DtGrdVw_Lista_ClinicasAutorizadas.Columns("estado").Width = 235

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE MENU"

    Private Sub TlStrpMnItm_Acoes_LimparFiltro_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_Acoes_LimparFiltro.Click

        LimparFiltros()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE SUB MENU"

    Private Sub TlStrpMnItm_SubMenuPrincipal_SelecionarClinicaAutorizada_Click(sender As Object, e As EventArgs) Handles TlStrpMnItm_SubMenuPrincipal_SelecionarClinicaAutorizada.Click

        Selecionar_ClinicaAutorizadaMarcada()

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

        Selecionar_ClinicaAutorizadaMarcada()

    End Sub

#End Region

#Region "FUNÇÕES MANIPULAÇÃO DE DADOS"

    Private Sub FiltrarListaClinicasAutorizadas(text As String)

        Dim dt As DataTable = TryCast(DtGrdVw_Lista_ClinicasAutorizadas.DataSource, DataTable)

        If dt Is Nothing Then Return

        Dim dv As New DataView(dt)

        Dim filtro As String = text.Trim().Replace("'", "''")

        If filtro.Length > 0 Then
            dv.RowFilter = String.Format("nome_clinica LIKE '%{0}%' OR cidade LIKE '%{0}%' OR estado LIKE '%{0}%'", filtro)
        Else
            dv.RowFilter = String.Empty
        End If

        DtGrdVw_Lista_ClinicasAutorizadas.DataSource = dv

        DtGrdVw_Lista_ClinicasAutorizadas.ClearSelection()

    End Sub

    Public Sub CarregarLista_ClinicasAutorizadas()

        Dim dt As DataTable = Nothing

        dt = Listar_ClinicasAutorizadasAtivas()

        DtGrdVw_Lista_ClinicasAutorizadas.DataSource = dt

        If dt IsNot Nothing Then

            ConfigurarLayoutLista_ClinicasAutorizadas()

        End If

    End Sub

#End Region

#Region "FUNÇÕES AUXILIARES"

    Public Sub InicializarFormulario()

        Call CarregarLista_ClinicasAutorizadas()

    End Sub

    Public Sub FinalizarFormulario(Optional Status As DialogResult = DialogResult.Cancel)

        Me.DialogResult = Status
        Me.Close()

    End Sub

    Private Sub LimparFiltros()

        TxtBx_TermoDePesquisa.Text = String.Empty

        Dim dt As DataTable = TryCast(DtGrdVw_Lista_ClinicasAutorizadas.DataSource, DataTable)
        If dt IsNot Nothing Then
            DtGrdVw_Lista_ClinicasAutorizadas.DataSource = dt
        End If

        Dim dv As DataView = TryCast(DtGrdVw_Lista_ClinicasAutorizadas.DataSource, DataView)
        If dv IsNot Nothing Then
            dv.RowFilter = String.Empty
            DtGrdVw_Lista_ClinicasAutorizadas.DataSource = dv
        End If

        TxtBx_TermoDePesquisa.Focus()

    End Sub

    Private Sub Selecionar_ClinicaAutorizadaMarcada()

        If DtGrdVw_Lista_ClinicasAutorizadas.SelectedRows.Count > 0 Then
            Dim id_ClinicaAutorizada As Integer = Convert.ToInt32(DtGrdVw_Lista_ClinicasAutorizadas.SelectedRows(0).Cells("id_clinica_autorizada").Value)
            ClinicaAutorizadaSelecionada = ClinicaAutorizada__ObterPorId(id_ClinicaAutorizada)

            If ClinicaAutorizadaSelecionada IsNot Nothing Then
                FinalizarFormulario(DialogResult.OK)
            End If
        End If

    End Sub

#End Region

End Class