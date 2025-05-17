Imports System.IO

Module Md__VariaveisGlobais

#Region "VARIÁVEIS FIREBASE"

    Public ReadOnly Firebase__BaseURL As String = "https://identitytoolkit.googleapis.com/v1/accounts:"
    Public ReadOnly Firebase__DatabaseURL As String = "https://autoflow-departamentopessoal-default-rtdb.firebaseio.com/"

    Public TokenUsuarioLogado As String = ""
    Public TokenUsuario As String = ""

    Public PastaToken As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "AutoFlow",
        My.Settings.AutoFlow__ModuloSistema
    )

    Public CaminhoToken As String = Path.Combine(
        PastaToken,
        "Token.tmp"
    )

    Public UID_UsuarioLogado As String = ""

    Public HoraLogin As DateTime
    Public Const DuracaoMaximaSessaoMin As Integer = 30

#End Region



End Module
