Public Class Frm__Intro

#Region "VARIÁVEIS DO FORMULÁRIO"

#End Region

#Region "FUNÇÕES PARA CONTROLE DO FORMULÁRIO"

    Private Async Sub Frm__Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Await InicializarFormularioAsync()

    End Sub

    Private Sub Frm__Intro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Call ValidarLicenca()

    End Sub

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

    Private Async Function InicializarFormularioAsync() As Task

        RecuperarInformacoesSobreOSistema()
        ConfigurarBarraDeProgresso()

        PrgrssBr_BarraDeCarregamento.Value = 0

        Await Aguardar3SegundosAsync()

        Await Task.Delay(200)

        FinalizarFormulario(DialogResult.OK)

    End Function

    Private Sub FinalizarFormulario(Optional status As DialogResult = DialogResult.Cancel)

        Me.DialogResult = status
        Me.Close()

    End Sub

    Private Sub ValidarLicenca()

        Dim Verificacao As (Boolean, String) = ValidarLicencaERecuperarApiKey()

        If Not Verificacao.Item1 Then

            ExibirMensagem__Erro("O arquivo de licença não foi encontrato ou a licença está inválida!")

        Else

            If VerificarApiKeyValida(Verificacao.Item2) Then

                'Call ExibirMensagem__Sucesso(Msg__Firebase__ApiKeyInvalida)'

            Else

                ExibirMensagem__Erro("A apikey não é valida")

            End If

        End If

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

