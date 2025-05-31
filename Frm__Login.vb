Public Class Frm__Login

#Region "VARIÁVEIS DO FORMULÁRIO"

    Private Email As String = ""
    Private Senha As String = ""

#End Region

#Region "FUNÇÕES PARA CONTROLE DO FORMULÁRIO"

    Private Sub Frm__Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InicializarFormulario()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS COMPONENTES DO FORMULÁRIO"

    Private Sub ChckBx_VisualizarSenha_Click(sender As Object, e As EventArgs) Handles ChckBx_VisualizarSenha.Click

        ConfigurarVisualizacaoDeSenha()

    End Sub

#End Region

#Region "FUNÇÕES PARA CONFIGURAÇÃO DOS COMPONENTES DO FORMULÁRIO"

    Private Sub ConfigurarVisualizacaoDeSenha()

        If ChckBx_VisualizarSenha.Checked Then

            TxtBx_Senha.PasswordChar = Nothing

        Else

            TxtBx_Senha.PasswordChar = "*"

        End If

    End Sub

#End Region

#Region "FUNÇÕES PARA CONTROLE DOS BOTÕES DE AÇÃO"

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Bttn_Cancelar.Click

        FinalizarFormulario()

    End Sub

    Private Async Sub Bttn_Entrar_Click(sender As Object, e As EventArgs) Handles Bttn_Entrar.Click

        Await RealizarLoginAsync()

    End Sub

#End Region

#Region "FUNÇÕES MANIPULAÇÃO DE DADOS"

    Public Sub RecuperarModuloAtualDoSistema()

        Me.Lbl_NomeDoModulo.Text = My.Settings.AutoFlow__ModuloSistema

    End Sub

#End Region

#Region "FUNÇÕES AUXILIARES"

    Private Sub InicializarFormulario()

        RecuperarModuloAtualDoSistema()

    End Sub

    Private Sub FinalizarFormulario(Optional Status As DialogResult = DialogResult.Cancel)

        Me.DialogResult = Status
        Me.Close()

    End Sub

    Private Sub RecuperarDadosDeLogin()

        Email = TxtBx_Email.Text
        Senha = TxtBx_Senha.Text

    End Sub

    Private Function CamposValidos() As Boolean

        RecuperarDadosDeLogin()

        If Senha = "SenacMinas" Then

            ExibirMensagem__Alerta("Senha padrão, favor alterar.")

            Return False

        End If

        If VerificarObrigatorio(TxtBx_Email, Nothing, Nothing) = False Then Return False
        If VerificarObrigatorio(TxtBx_Senha, Nothing, Nothing) = False Then Return False
        If EmailValido(TxtBx_Email, Nothing, Nothing) = False Then Return False
        If EmailValidoSenac(TxtBx_Email) = False Then Return False

        Return True

    End Function

#End Region

#Region "FUNÇÕES ASSÍNCRONAS"

    Private Async Function RealizarLoginAsync() As Task

        If CamposValidos() = False Then Exit Function

        Bttn_Entrar.Enabled = False

        Try

            Dim resultado = Await LoginUsuarioFirebase(Email, Senha)

            If resultado IsNot Nothing Then

                Call RecuperarTokenUsuario(resultado)
                Call RegistrarLogLogin(Email)

                UID_UsuarioLogado = Await ObterMatriculaPorUID()
                HoraLogin = DateTime.Now

                Call InicializarBancoDeDadosLocal()

                Dim Frm_Menu As New Frm__Menu
                Frm_Menu.Show()
                Frm_Menu.BringToFront()

                FinalizarFormulario(DialogResult.OK)

            Else

                ExibirMensagem__Erro("Erro ao efetuar login. Verifique suas credenciais.")

                Bttn_Entrar.Enabled = True

                Exit Function

            End If

        Catch ex As Exception

            ExibirMensagem__Erro("Ocorreu um erro inesperado durante o login: " & ex.Message)

            Bttn_Entrar.Enabled = True

            Exit Function

        End Try

    End Function

#End Region

End Class