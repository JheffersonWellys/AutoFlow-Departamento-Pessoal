Imports AutoFlow___Departamento_Pessoal__DP_.AutoFlow.Globais
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net.Http
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Module Md__Sistema__Funcoes__Auxiliares

#Region "FUNÇÕES DE TOKEN"

    Public Sub RecuperarTokenUsuario(token As String)

        Dim payloadJson As String = ExtrairPayloadJWT(token)
        Dim objeto As JObject = JObject.Parse(payloadJson)
        Dim userId As String = objeto("user_id").ToString()

        Call SalvarTokenCriptografado(userId)

    End Sub

    Public Sub SalvarTokenCriptografado(token As String)

        Dim dados As Byte() = Encoding.UTF8.GetBytes(token)
        Dim dadosCriptografados As Byte() = ProtectedData.Protect(dados, Nothing, DataProtectionScope.CurrentUser)

        File.WriteAllBytes(CaminhoToken, dadosCriptografados)

    End Sub

    Public Function LerTokenDescriptografado() As String

        If Not File.Exists(CaminhoToken) Then Return Nothing

        Dim dadosCriptografados As Byte() = File.ReadAllBytes(CaminhoToken)
        Dim dadosDescriptografados As Byte() = ProtectedData.Unprotect(dadosCriptografados, Nothing, DataProtectionScope.CurrentUser)

        Return Encoding.UTF8.GetString(dadosDescriptografados)

    End Function

    Public Function LerTokenCriptografado() As String

        If Not File.Exists(CaminhoToken) Then Return Nothing

        Dim dadosCriptografados As Byte() = File.ReadAllBytes(CaminhoToken)

        Return Convert.ToBase64String(dadosCriptografados)

    End Function

    Public Sub DeletarTokenTemporario()

        If File.Exists(CaminhoToken) Then File.Delete(CaminhoToken)

    End Sub

#End Region

#Region "FUNÇÕES DE RECUPERAR DADOS"

    Public Function ObterDataSegura(dataCriptografada As String) As Date
        Try
            Dim dataTexto = DescriptografarTexto(dataCriptografada)
            Dim dataConvertida As Date
            If Date.TryParse(dataTexto, dataConvertida) Then
                If dataConvertida = Date.MinValue Then Return Date.Today
                Return dataConvertida
            End If
        Catch
            ' Log opcional ou tratamento de erro silencioso
        End Try
        Return Date.Today
    End Function

#End Region

#Region "FUNÇÕES DE CRIPTOGRAFIA"

    Public Function CriptografarTexto(texto As String) As String
        Try

            Dim chaveBytes As Byte() = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(LerTokenDescriptografado))

            Dim iv(15) As Byte
            Using rng As RandomNumberGenerator = RandomNumberGenerator.Create()
                rng.GetBytes(iv)
            End Using

            Using aes As Aes = Aes.Create()
                aes.Key = chaveBytes
                aes.IV = iv
                aes.Mode = CipherMode.CBC
                aes.Padding = PaddingMode.PKCS7

                Using encryptor = aes.CreateEncryptor()
                    Dim textoBytes = Encoding.UTF8.GetBytes(texto)
                    Dim textoCriptografado = encryptor.TransformFinalBlock(textoBytes, 0, textoBytes.Length)

                    Dim resultadoFinal(iv.Length + textoCriptografado.Length - 1) As Byte
                    Buffer.BlockCopy(iv, 0, resultadoFinal, 0, iv.Length)
                    Buffer.BlockCopy(textoCriptografado, 0, resultadoFinal, iv.Length, textoCriptografado.Length)

                    Return Convert.ToBase64String(resultadoFinal)
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function DescriptografarTexto(textoCriptografado As String) As String
        Try
            Dim chaveBytes As Byte() = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(LerTokenDescriptografado()))

            Dim dadosCompletos As Byte() = Convert.FromBase64String(textoCriptografado)

            Dim iv(15) As Byte
            Buffer.BlockCopy(dadosCompletos, 0, iv, 0, iv.Length)

            Dim dadosCriptografados(dadosCompletos.Length - iv.Length - 1) As Byte
            Buffer.BlockCopy(dadosCompletos, iv.Length, dadosCriptografados, 0, dadosCriptografados.Length)

            Using aes As Aes = Aes.Create()
                aes.Key = chaveBytes
                aes.IV = iv
                aes.Mode = CipherMode.CBC
                aes.Padding = PaddingMode.PKCS7

                Using decryptor = aes.CreateDecryptor()
                    Dim textoBytes = decryptor.TransformFinalBlock(dadosCriptografados, 0, dadosCriptografados.Length)
                    Return Encoding.UTF8.GetString(textoBytes)
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region

#Region "FUNÇÕES DO FIREBASE"

    Public Async Function ObterMatriculaPorUID() As Task(Of String)

        Dim client As New HttpClient()
        Dim url As String = $"{Firebase__DatabaseURL}usuarios/{TokenUsuario}/matricula.json?auth={TokenUsuarioLogado}"

        Try

            Dim response = Await client.GetAsync(url)

            response.EnsureSuccessStatusCode()

            Dim matriculaJson = Await response.Content.ReadAsStringAsync()
            Dim matricula = JsonConvert.DeserializeObject(Of String)(matriculaJson)

            Return matricula

        Catch ex As Exception

            ExibirMensagem__Erro("Erro ao buscar matrícula: " & ex.Message)

            Return Nothing

        End Try

    End Function

#End Region

#Region "FUNÇÕES DE JSON"

    Private Function ExtrairPayloadJWT(jwt As String) As String

        Dim partes = jwt.Split("."c)

        If partes.Length <> 3 Then Throw New ArgumentException("Token JWT inválido.")

        Dim payloadBase64 = partes(1)

        While payloadBase64.Length Mod 4 <> 0

            payloadBase64 &= "="

        End While

        Dim bytes = Convert.FromBase64String(payloadBase64)

        Return Encoding.UTF8.GetString(bytes)

    End Function

#End Region

#Region "FUNÇÕES DE INICIALIZAÇÃO"

    Public Sub InicializarSistemaAutoFlow()

        CriarPastaSeNaoExistir(PastaToken)

    End Sub

    Public Sub IniciarFormulario_Cadastro_Colaboradores()

        Dim Frm_Cadastro_Colaboradores As New Frm__Cadastro__Colaboradores
        Frm_Cadastro_Colaboradores.ShowDialog()

    End Sub

#End Region

#Region "FUNÇÕES DE CRIAÇÃO"

    Public Sub CriarPastaSeNaoExistir(caminho As String)

        If Not Directory.Exists(caminho) Then

            Directory.CreateDirectory(caminho)

        End If

    End Sub

#End Region

#Region "FUNÇÕES DE VALIDAÇÃO DE CAMPOS"

    Public Async Function VerificarTokenValido(idToken As String) As Task(Of Boolean)

        Dim client As New HttpClient()
        Dim testUrl = Firebase__DatabaseURL & idToken

        Try

            Dim response = Await client.GetAsync(testUrl)

            If response.IsSuccessStatusCode Then

                Return True

            Else

                Dim body = Await response.Content.ReadAsStringAsync()

                If body.Contains("Auth token is expired") OrElse body.Contains("Permission denied") Then

                    Return False

                End If

            End If

        Catch ex As Exception

        End Try

        Return False

    End Function

    Public Sub PermitirApenasNumeros(e As KeyPressEventArgs)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Function CampoObrigatorio(mensagem As String, janela As TabControl, aba As TabPage, controle As Control) As Boolean

        MessageBox.Show(mensagem, "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        If janela IsNot Nothing Then

            janela.SelectedTab = aba

        End If

        If controle IsNot Nothing Then

            controle.Focus()

        End If

        Return False

    End Function

    Private Sub MostrarErro(campo As MaskedTextBox, ControleDeAbas As TabControl, aba As TabPage, nomeCampo As String)

        MessageBox.Show($"O {nomeCampo} informado não é válido. Verifique e tente novamente.", $"{nomeCampo} Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ControleDeAbas.SelectedTab = aba

        campo.Focus()

    End Sub

    Public Function VerificarObrigatorio(controle As Control, abas As TabControl, aba As TabPage) As Boolean

        If TypeOf controle Is TextBox AndAlso String.IsNullOrEmpty(DirectCast(controle, TextBox).Text) Then

            Return CampoObrigatorio($"O campo [{controle.Tag}] é obrigatório.", abas, aba, controle)

        End If

        If TypeOf controle Is MaskedTextBox AndAlso Not DirectCast(controle, MaskedTextBox).MaskFull Then

            Return CampoObrigatorio($"O campo [{controle.Tag}] é obrigatório.", abas, aba, controle)

        End If

        If TypeOf controle Is ComboBox AndAlso DirectCast(controle, ComboBox).SelectedIndex = -1 Then

            Return CampoObrigatorio($"O campo [{controle.Tag}] é obrigatório.", abas, aba, controle)

        End If

        Return True

    End Function

    Public Function ValidarDataPadrao(dtp As DateTimePicker, dataPadrao As Date, janela As TabControl, aba As TabPage) As Boolean

        If dtp.Value = dataPadrao Then

            Dim mensagem As String = $"A data do campo [{dtp.Tag}] está definida como padrão ({dataPadrao:dd/MM/yyyy}). Deseja continuar?"
            Dim titulo As String = $"Confirmação de {dtp.Tag}"

            If MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

                Return False

            End If

            janela.SelectedTab = aba
            dtp.Focus()

        End If

        Return True

    End Function

    Public Function ValidarDataMinima(dtp As DateTimePicker, janela As TabControl, aba As TabPage) As Boolean

        If dtp.Value < Date.Today Then

            Dim mensagem As String = $"A data do campo [{dtp.Tag}] está anterior à data atual ({Date.Today:dd/MM/yyyy}). Deseja continuar mesmo assim?"
            Dim titulo As String = "Confirmação de data anterior"

            If MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

                janela.SelectedTab = aba
                dtp.Focus()

                Return False

            End If

        End If

        Return True

    End Function

    Public Function EmailDescriptografadoValido(email As String) As Boolean

        Dim emailRegex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")

        If String.IsNullOrWhiteSpace(email) OrElse Not emailRegex.IsMatch(email) Then

            Return False

        End If

        Return True

    End Function

    Public Function EmailValido(campo As TextBox, ControleDeAbas As TabControl, aba As TabPage) As Boolean

        Dim emailRegex As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")

        If String.IsNullOrWhiteSpace(campo.Text) OrElse Not emailRegex.IsMatch(campo.Text) Then

            MessageBox.Show($"O {campo.Tag} informado não é válido. Verifique e tente novamente.", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            If ControleDeAbas IsNot Nothing And aba IsNot Nothing Then

                ControleDeAbas.SelectedTab = aba
                campo.Focus()

                Return False

            End If

        End If

        Return True

    End Function

    Public Function EmailValidoSenac(campo As TextBox) As Boolean

        Dim emailRegex As New Regex("^[a-zA-Z0-9._%+-]+@mg\.senac\.br$", RegexOptions.IgnoreCase)

        If String.IsNullOrWhiteSpace(campo.Text) OrElse Not emailRegex.IsMatch(campo.Text) Then

            MessageBox.Show($"O {campo.Tag} informado não é válido." & vbCrLf & vbCrLf &
                            "Apenas o domínio '@mg.senac.br' é autorizado.", "E-mail Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            campo.Focus()

            Return False

        End If

        Return True

    End Function

    Public Function CPFValido(campo As MaskedTextBox, ControleDeAbas As TabControl, aba As TabPage) As Boolean

        Dim cpfLimpo As String = Regex.Replace(campo.Text, "[^0-9]", "")

        If cpfLimpo.Length <> 11 Then

            MostrarErro(campo, ControleDeAbas, aba, "CPF")

            Return False

        End If

        If cpfLimpo.Distinct().Count() = 1 Then

            MostrarErro(campo, ControleDeAbas, aba, "CPF")

            Return False

        End If

        Dim soma As Integer = 0

        For i As Integer = 0 To 8

            soma += CInt(cpfLimpo(i).ToString()) * (10 - i)

        Next

        Dim resto As Integer = (soma * 10) Mod 11

        If resto = 10 OrElse resto = 11 Then resto = 0

        If resto <> CInt(cpfLimpo(9).ToString()) Then

            MostrarErro(campo, ControleDeAbas, aba, "CPF")

            Return False

        End If

        soma = 0

        For i As Integer = 0 To 9

            soma += CInt(cpfLimpo(i).ToString()) * (11 - i)

        Next

        resto = (soma * 10) Mod 11

        If resto = 10 OrElse resto = 11 Then resto = 0

        If resto <> CInt(cpfLimpo(10).ToString()) Then

            MostrarErro(campo, ControleDeAbas, aba, "CPF")

            Return False

        End If

        Return True

    End Function

#End Region

#Region "FUNÇÕES DE EXIBIÇÃO"

    Public Sub AtualizarTituloFormulario(formulario As Form, modo As ModoAtualCadastro, nomeBase As String)

        Dim sufixoModo As String

        Select Case modo
            Case ModoAtualCadastro.CRIANDO
                sufixoModo = " - Modo Adição"
            Case ModoAtualCadastro.EDITANDO
                sufixoModo = " - Modo Edição"
            Case ModoAtualCadastro.REMOVENDO
                sufixoModo = " - Modo Remoção"
            Case ModoAtualCadastro.VISUALIZANDO
                sufixoModo = " - Modo Visualização"
            Case Else
                sufixoModo = ""
        End Select

        formulario.Text = nomeBase & sufixoModo

    End Sub

#End Region

End Module
