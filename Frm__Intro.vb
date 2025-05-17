Public Class Frm__Intro

#Region "VARIÁVEIS DO FORMULÁRIO"

#End Region

#Region "FUNÇÕES PARA CONTROLE DO FORMULÁRIO"

    Private Async Sub Frm__Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InicializarFormulario()

        Await Aguardar3SegundosAsync()

        Await Task.Delay(200)

        FinalizarFormulario(DialogResult.OK)

    End Sub

    Private Sub Frm__Intro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing



    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS COMPONENTES DO FORMULÁRIO"

#End Region

#Region "FUNÇÕES PARA CONFIGURAÇÃO DOS COMPONENTES DO FORMULÁRIO"

    Public Sub ConfigurarBarraDeProgresso()

        PrgrssBr_BarraDeCarregamento.Minimum = 0
        PrgrssBr_BarraDeCarregamento.Maximum = 100
        PrgrssBr_BarraDeCarregamento.Value = 0

    End Sub

#End Region

#Region "FUNÇÕES MANIPULAÇÃO DE DADOS"

    Private Sub RecuperarInformacoesSobreOSistema()
        Lbl_VersaoSistema.Text = My.Settings.AutoFlow__VersaoSistema
        Lbl_ModuloSistema.Text = My.Settings.AutoFlow__ModuloSistema
    End Sub

#End Region

#Region "FUNÇÕES AUXILIARES"

    Private Sub InicializarFormulario()

        RecuperarInformacoesSobreOSistema()
        ConfigurarBarraDeProgresso()
        PrgrssBr_BarraDeCarregamento.Value = 0

    End Sub

    Private Sub FinalizarFormulario(Optional status As DialogResult = DialogResult.Cancel)

        Me.DialogResult = status
        Me.Close()

    End Sub

#End Region

#Region "FUNÇÕES ASSÍNCRONAS"

    Private Async Function Aguardar3SegundosAsync() As Task

        Dim totalDuration As Integer = 3000
        Dim interval As Integer = 300
        Dim steps As Integer = totalDuration \ interval

        For i As Integer = 1 To steps

            Await Task.Delay(interval)

            PrgrssBr_BarraDeCarregamento.Value = CInt((i / steps) * 100)

        Next

        PrgrssBr_BarraDeCarregamento.Value = 100

    End Function

#End Region

End Class

