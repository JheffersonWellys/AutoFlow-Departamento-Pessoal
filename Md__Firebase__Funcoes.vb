Imports Firebase.Database
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text
Imports Firebase.Database.Query
Imports System.Security.Cryptography
Imports System.IO

Module Md__Firebase__Funcoes

#Region "FIREBASE FUNÇÕES DE CADASTRO"

    Public Async Function CadastrarUsuarioFirebase(email As String, senha As String) As Task(Of AuthResult)

        Dim client As New HttpClient()
        Dim url As String = Firebase__BaseURL & "signUp?key=" & ObterApiKey()

        Dim dados = New With {
            .email = email,
            .password = senha,
            .returnSecureToken = True
        }

        Dim json = JsonConvert.SerializeObject(dados)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Try

            Dim response = Await client.PostAsync(url, content)
            response.EnsureSuccessStatusCode()

            Dim responseBody = Await response.Content.ReadAsStringAsync()
            Dim resultado = JsonConvert.DeserializeObject(Of FirebaseAuthResponse)(responseBody)

            Return New AuthResult With {
                .IdToken = resultado.idToken,
                .LocalId = resultado.localId
            }

        Catch ex As Exception

            ExibirMensagem__Erro("Erro ao cadastrar usuário no Firebase: " & ex.Message & vbCrLf & "Stack Trace: " & ex.StackTrace)

            Return Nothing

        End Try

    End Function

    Public Async Function Adicionar_Usuario(NovoUsuario As Usuario) As Task(Of Boolean)

        Dim resultado = Await CadastrarUsuarioFirebase(NovoUsuario.Email, "SenacMinas")

        If resultado Is Nothing Then

            MessageBox.Show("Não foi possível criar o usuário no Firebase Auth.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Return False

        End If

        Try

            Dim firebaseClient = New FirebaseClient(
                Firebase__DatabaseURL,
                New FirebaseOptions With {
                    .AuthTokenAsyncFactory = Function() Task.FromResult(resultado.IdToken)
                }
            )

            Dim userRef = firebaseClient.
                        Child("usuarios").
                        Child(resultado.LocalId)

            Await userRef.PutAsync(New With {
                .matricula = NovoUsuario.Chapa,
                .email = NovoUsuario.Email,
                .nome_completo = NovoUsuario.NomeCompleto
            })

            Return True

        Catch ex As Exception

            ExibirMensagem__Erro("Erro ao cadastrar [Usuário] no Firebase: " & ex.Message & vbCrLf &
                        "Stack Trace: " & ex.StackTrace)

            Return False

        End Try

    End Function

#End Region

#Region "FIREBASE FUNÇÕES DE VERIFICAÇÃO"

    Public Function VerificarApiKeyValida(apiKey As String) As Boolean

        Try

            If String.IsNullOrEmpty(apiKey) Then

                Return False

            End If

            Dim firebaseUrl As String = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=" & apiKey
            Dim httpClient As New HttpClient()

            Dim content As New StringContent("{""email"":""admin@autoflow.com"",""password"":""admin_autoflow"",""returnSecureToken"":true}", Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = httpClient.PostAsync(firebaseUrl, content).Result

            If response.IsSuccessStatusCode Then

                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            ExibirMensagem__Erro("Erro ao realizar login ou verificar a API Key: " & ex.Message)

            Return False

        End Try

    End Function

#End Region

#Region "FIREBASE FUNÇÕES DE REGISTRO"

    Public Async Function RegistrarLogLogin(Email As String) As Task

        Try
            Dim DataAtual As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim HoraAtual As String = DateTime.Now.ToString("HH:mm:ss")
            Dim nomeUsuarioPC As String = Environment.UserName
            Dim sistemaOperacional As String = Environment.OSVersion.ToString()
            Dim versaoApp As String = Application.ProductVersion

            Dim firebaseClient = New FirebaseClient(
                Firebase__DatabaseURL,
                New FirebaseOptions With {
                    .AuthTokenAsyncFactory = Function() Task.FromResult(TokenUsuarioLogado)
                }
            )

            Dim logRef = firebaseClient _
            .Child("logs") _
            .Child(LerTokenDescriptografado())

            Dim log As New With {
                .email = Email,
                .nome_usuario_pc = nomeUsuarioPC,
                .data = DataAtual,
                .horario = HoraAtual,
                .sistema_operacional = sistemaOperacional,
                .versao_app = versaoApp
            }

            Await logRef.PostAsync(log)

        Catch ex As Exception

            ExibirMensagem__Erro("Erro ao registrar log de login no Firebase: " & ex.Message &
                        vbCrLf & "Stack Trace: " & ex.StackTrace)

        End Try
    End Function

#End Region

#Region "FIREBASE FUNÇÕES DE LOGIN"

    Public Async Function LoginUsuarioFirebase(email As String, senha As String) As Task(Of String)

        Dim client As New HttpClient()
        Dim url As String = Firebase__BaseURL & "signInWithPassword?key=" & ObterApiKey()

        Dim dados = New With {
            .email = email,
            .password = senha,
            .returnSecureToken = True
        }

        Dim json = JsonConvert.SerializeObject(dados)
        Dim content = New StringContent(json, Encoding.UTF8, "application/json")

        Try

            Dim response = Await client.PostAsync(url, content)
            response.EnsureSuccessStatusCode()

            Dim responseBody = Await response.Content.ReadAsStringAsync()
            Dim resultado = JsonConvert.DeserializeObject(Of FirebaseAuthResponse)(responseBody)

            TokenUsuarioLogado = resultado.idToken
            TokenUsuario = resultado.localId

            Return resultado.idToken

        Catch ex As Exception

            Return Nothing

        End Try

    End Function

#End Region

#Region "FIREBASE FUNÇÕES DE LEITURA"

    Private Function ObterApiKey() As String

        Dim ResultadoLicencaEApiKey As (Boolean, String) = ValidarLicencaERecuperarApiKey()

        If ResultadoLicencaEApiKey.Item1 Then

            Return ResultadoLicencaEApiKey.Item2

        Else

            ExibirMensagem__Erro("Licença inválida ou não encontrada.")

            Return String.Empty

        End If

    End Function

#End Region

End Module
