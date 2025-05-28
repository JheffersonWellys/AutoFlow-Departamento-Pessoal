Imports System.IO

Module Md__VariaveisGlobais

#Region "VARIÁVEIS SISTEMA"

    Public Const NomeSistema As String = "AutoFlow"

#End Region

#Region "VARIÁVEIS FIREBASE"

    Public ReadOnly Firebase__BaseURL As String = "https://identitytoolkit.googleapis.com/v1/accounts:"
    Public ReadOnly Firebase__DatabaseURL As String = "https://autoflow-departamentopessoal-default-rtdb.firebaseio.com/"

    Public TokenUsuarioLogado As String = ""
    Public TokenUsuario As String = ""

    Public PastaToken As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        NomeSistema,
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

#Region "VARIÁVEIS SQLITE"

    Public PastaAppData As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)

    Public Caminho_PastaBancoDeDados As String = Path.Combine(PastaAppData, NomeSistema, My.Settings.AutoFlow__ModuloSistema)
    Public Caminho_BancoDeDados As String = Path.Combine(Caminho_PastaBancoDeDados, NomeSistema & " - " & My.Settings.AutoFlow__ModuloSistema & ".db")

    Public CadeiaDeConexao As String = $"Data Source={Caminho_BancoDeDados};Version=3;"

#End Region

End Module
