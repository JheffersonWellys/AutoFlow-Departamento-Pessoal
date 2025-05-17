Imports System.IO
Imports CredentialManagement
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text
Imports System.Management

Module Md__Licenciamento
#Region "VARIÁVEIS DO MÓDULO"

    Private ReadOnly CaminhoLicenca As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "licenca.lic")
    Private ReadOnly ChavePublicaPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "chave_publica.xml")
    Private ReadOnly CaminhoToken As String = Path.Combine(Path.GetTempPath(), "token.tmp")

#End Region

#Region "FUNÇÃO DE VALIDAÇÃO DE API KEY"

    Public Function ValidarLicencaERecuperarApiKey() As (Boolean, String)

        If Not File.Exists(CaminhoLicenca) Then

            Console.WriteLine("Arquivo de licença não encontrado.")

            Return (False, String.Empty)

        End If

        Dim licenca As String = File.ReadAllText(CaminhoLicenca)

        Dim dadosDoSegundoNivel As String = DescriptografarPrimeiroNivel(licenca)

        If String.IsNullOrEmpty(dadosDoSegundoNivel) Then Return (False, String.Empty)

        Dim dadosDoTerceiroNivel As String = DescriptografarSegundoNivel(dadosDoSegundoNivel)

        If String.IsNullOrEmpty(dadosDoTerceiroNivel) Then Return (False, String.Empty)

        Dim chaveAES As String = DescriptografarTerceiroNivel(dadosDoTerceiroNivel)

        If String.IsNullOrEmpty(chaveAES) Then Return (False, String.Empty)

        Dim partes As String() = dadosDoTerceiroNivel.Split("|"c)
        Dim apiKey As String = DescriptografarComAES(partes(0), chaveAES)

        Return (True, apiKey)

    End Function

#End Region

#Region "DESCRIPTOGRAFICA - NÍVEL 1 (HMAC)"

    Private Function DescriptografarPrimeiroNivel(licenca As String) As String

        Dim partes As String() = licenca.Split("|"c)

        If partes.Length < 2 Then

            Console.WriteLine("Licença inválida.")

            Return Nothing

        End If

        Dim dados As String = partes(0)
        Dim hmacNaLicenca As String = partes(1)
        Dim fingerprint As String = ObterFingerprintMaquina()
        Dim hmacCalculado As String = GerarHMACSHA256(dados, fingerprint)

        If Not hmacCalculado.Equals(hmacNaLicenca) Then

            Console.WriteLine("Verificação do HMAC falhou!")

            Return Nothing

        End If

        Return partes(0)

    End Function

    Private Function GerarHMACSHA256(dados As String, fingerprint As String) As String

        Dim keyBytes = Encoding.UTF8.GetBytes(fingerprint)

        Using hmac As New HMACSHA256(keyBytes)

            Dim hash As Byte() = hmac.ComputeHash(Encoding.UTF8.GetBytes(dados))

            Return Convert.ToBase64String(hash)

        End Using

    End Function

#End Region

#Region "DESCRIPTOGRAFICA - NÍVEL 2 (RSA)"

    Private Function DescriptografarSegundoNivel(dados As String) As String

        Return VerificarAssinaturaComRSA(dados)

    End Function

    Private Function VerificarAssinaturaComRSA(dadosComAssinatura As String) As String

        If Not File.Exists(ChavePublicaPath) Then

            Throw New FileNotFoundException("Chave pública RSA não encontrada.")

        End If

        Dim partes = dadosComAssinatura.Split("."c)

        If partes.Length <> 2 Then

            Console.WriteLine("Formato de dados inválido.")

            Return Nothing

        End If

        Dim dadosBase64 = partes(0)
        Dim assinaturaBase64 = partes(1)

        Try

            Dim rsa = New RSACryptoServiceProvider(2048)
            rsa.FromXmlString(File.ReadAllText(ChavePublicaPath))

            Dim dadosBytes = Convert.FromBase64String(dadosBase64)
            Dim assinaturaBytes = Convert.FromBase64String(assinaturaBase64)

            Dim isValido = rsa.VerifyData(dadosBytes, CryptoConfig.MapNameToOID("SHA256"), assinaturaBytes)

            If isValido Then

                Return Encoding.UTF8.GetString(dadosBytes)

            Else

                Console.WriteLine("Assinatura RSA inválida.")

                Return Nothing

            End If

        Catch ex As Exception

            Console.WriteLine("Erro ao verificar assinatura: " & ex.Message)

            Return Nothing

        End Try

    End Function

#End Region

#Region "DESCRIPTOGRAFICA - NÍVEL 3 (AES DO CREDENTIAL MANAGER)"

    Private Function DescriptografarTerceiroNivel(dados As String) As String

        Dim partes As String() = dados.Split("|"c)

        If partes.Length < 2 Then

            Console.WriteLine("Dados insuficientes para descriptografar o 3º nível.")

            Return Nothing

        End If

        Return ObterChaveAES(partes)

    End Function

    Private Function ObterChaveAES(partes) As String

        Try

            Dim cred As New Credential With {
                .Target = partes(1),
                .Username = partes(2)
            }

            cred.Load()

            If String.IsNullOrEmpty(cred.Password) Then

                Console.WriteLine("Chave AES não encontrada no Credential Manager.")

                Return Nothing

            Else

                Dim dadosCriptografados As Byte() = Convert.FromBase64String(cred.Password)
                Dim chaveAES As Byte() = ProtectedData.Unprotect(dadosCriptografados, Nothing, DataProtectionScope.CurrentUser)

                Return Encoding.UTF8.GetString(chaveAES)

            End If

        Catch ex As Exception

            Console.WriteLine("Erro ao obter a chave AES: " & ex.Message)

            Return Nothing

        End Try

    End Function

#End Region

#Region "DESCRIPTOGRAFICA - NÍVEL 4 (API KEY COM AES)"

    Private Function DescriptografarComAES(dadosCriptografadosBase64 As String, chave As String) As String

        Dim dadosComIV As Byte() = Convert.FromBase64String(dadosCriptografadosBase64)
        Dim iv As Byte() = dadosComIV.Take(16).ToArray()
        Dim dadosCriptografados As Byte() = dadosComIV.Skip(16).ToArray()

        Dim salt As Byte() = Encoding.UTF8.GetBytes("AutoFlow_Salt_2025")
        Dim key As Byte() = DerivarChaveAES(chave, salt)

        Dim aes As Aes = Aes.Create()
        aes.Key = key
        aes.IV = iv
        aes.Mode = CipherMode.CBC
        aes.Padding = PaddingMode.PKCS7

        Using ms As New MemoryStream()

            Using cs As New CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write)

                cs.Write(dadosCriptografados, 0, dadosCriptografados.Length)
                cs.FlushFinalBlock()

            End Using

            Return Encoding.UTF8.GetString(ms.ToArray())

        End Using

    End Function

    Private Function DerivarChaveAES(senha As String, salt As Byte()) As Byte()

        Dim pbkdf2 As New Rfc2898DeriveBytes(senha, salt, 10000)

        Return pbkdf2.GetBytes(32)

    End Function

#End Region

#Region "Fingerprint da Máquina"

    Private Function ObterFingerprintMaquina() As String

        Dim nomePC As String = Environment.MachineName
        Dim mac As String = ObterMacAddress()
        Dim serial As String = ObterSerialDisco()

        Return $"{nomePC}-{mac}-{serial}"

    End Function

    Private Function ObterMacAddress() As String

        Return NetworkInterface.GetAllNetworkInterfaces().
        FirstOrDefault(Function(nic) nic.OperationalStatus = OperationalStatus.Up AndAlso
                       nic.NetworkInterfaceType <> NetworkInterfaceType.Loopback)?.
                       GetPhysicalAddress()?.ToString()

    End Function

    Private Function ObterSerialDisco() As String

        Try

            Dim searcher = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia")

            For Each wmi_HD As ManagementObject In searcher.Get()

                If wmi_HD("SerialNumber") IsNot Nothing Then

                    Return wmi_HD("SerialNumber").ToString().Trim()

                End If

            Next

        Catch

        End Try

        Return "DESCONHECIDO"

    End Function

#End Region

End Module
