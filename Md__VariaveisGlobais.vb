Imports System.IO

Module Md__VariaveisGlobais

#Region "VARIÁVEIS FIREBASE"

    Public ReadOnly Firebase__BaseURL As String = "https://identitytoolkit.googleapis.com/v1/accounts:"
    Public ReadOnly Firebase__DatabaseURL As String = "https://autoflow-departamentopessoal-default-rtdb.firebaseio.com/"

    Public TokenUsuarioLogado As String = ""
    Public TokenUsuario As String = ""

    Public CaminhoToken As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "AutoFlow",
        My.Settings.AutoFlow__ModuloSistema,
        "Token.tmp"
    )

#End Region

End Module
