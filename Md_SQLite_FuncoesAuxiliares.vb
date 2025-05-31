Imports System.Data.SQLite

Module Md_SQLite_FuncoesAuxiliares

#Region "FUNÇÕES DE ADICIONAR"

#Region "FUNÇÕES DA TABELA | AGÊNCIA CAIXA"

    Public Function AgenciaCaixa__Adicionar(AgenciaCaixa As AgenciaCaixa) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()

                Dim query As String = "
                    INSERT INTO agencia_caixa (
                        id_endereco, codigo_agencia, uid_usuario_logado, status
                    ) VALUES (
                        @id_endereco, @codigo_agencia, @uid_usuario_logado, @status
                    );"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_endereco", AgenciaCaixa.IdEndereco)
                    cmd.Parameters.AddWithValue("@codigo_agencia", AgenciaCaixa.CodigoAgencia)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", AgenciaCaixa.Status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return (True, "Agência adicionada com sucesso.")
        Catch ex As Exception
            Return (False, $"Erro ao adicionar agência: {ex.Message}")
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | CARTA DE ABERTURA DE CONTA-SALÁRIO"

    Public Function CartaDeAberturaDeContaSalario__Adicionar(CartaDeAberturaDeContaSalario As CartaDeAberturaDeContaSalario) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()

                Dim query As String = "
                    INSERT INTO carta_de_abertura_de_conta_salario (
                        id_colaborador, id_agencia_caixa, id_unidade_senac,
                        caminho_arquivo, status_arquivo, uid_usuario_logado, status
                    ) VALUES (
                        @id_colaborador, @id_agencia_caixa, @id_unidade_senac,
                        @caminho_arquivo, @status_arquivo, @uid_usuario_logado, @status
                    );"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_colaborador", CartaDeAberturaDeContaSalario.IdColaborador)
                    cmd.Parameters.AddWithValue("@id_agencia_caixa", CartaDeAberturaDeContaSalario.IdAgenciaCaixa)
                    cmd.Parameters.AddWithValue("@id_unidade_senac", CartaDeAberturaDeContaSalario.IdUnidadeSenac)
                    cmd.Parameters.AddWithValue("@caminho_arquivo", CartaDeAberturaDeContaSalario.CaminhoArquivo)
                    cmd.Parameters.AddWithValue("@status_arquivo", CartaDeAberturaDeContaSalario.StatusArquivo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", CartaDeAberturaDeContaSalario.Status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return (True, "Carta adicionada com sucesso.")

        Catch ex As Exception

            Return (False, $"Erro ao adicionar CartaDeAberturaDeContaSalario: {ex.Message}")

        End Try

    End Function

#End Region

#Region "FUNÇÕES DA TABELA | TERMO DE CIÊNCIA DE HOMOLOGAÇÃO"

    Public Function TermoCienciaDeHomologacao__Adicionar(TermoCienciaDeHomologacao As TermoCienciaDeHomologacao) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()

                Dim sql As String = "
                INSERT INTO termo_ciencia_de_homologacao (
                    id_colaborador, id_unidade_senac, id_exame,
                    email_pessoal, telefone_pessoal, data_homologacao,
                    caminho_arquivo, status_arquivo, uid_usuario_logado, status
                ) VALUES (
                    @id_colaborador, @id_unidade_senac, @id_exame,
                    @email_pessoal, @telefone_pessoal, @data_homologacao,
                    @caminho_arquivo, @status_arquivo, @uid_usuario_logado, @status
                );"

                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id_colaborador", TermoCienciaDeHomologacao.IdColaborador)
                    cmd.Parameters.AddWithValue("@id_unidade_senac", TermoCienciaDeHomologacao.IdUnidadeSenac)
                    cmd.Parameters.AddWithValue("@id_exame", TermoCienciaDeHomologacao.IdExame)
                    cmd.Parameters.AddWithValue("@email_pessoal", TermoCienciaDeHomologacao.EmailPessoal)
                    cmd.Parameters.AddWithValue("@telefone_pessoal", TermoCienciaDeHomologacao.TelefonePessoal)
                    cmd.Parameters.AddWithValue("@data_homologacao", TermoCienciaDeHomologacao.DataHomologacao)
                    cmd.Parameters.AddWithValue("@caminho_arquivo", TermoCienciaDeHomologacao.CaminhoArquivo)
                    cmd.Parameters.AddWithValue("@status_arquivo", TermoCienciaDeHomologacao.StatusArquivo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", TermoCienciaDeHomologacao.Status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | TERMO DE FINS RESCISÓRIOS"

    Public Function TermoFinsRescisorios__Adicionar(TermoFinsRescisorios As TermoFinsRescisorios) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Dim sql As String = "
                INSERT INTO termo_fins_rescisorios (
                    id_colaborador, id_unidade_senac, id_termo_ciencia_de_homologacao,
                    resposta_item_1, resposta_item_1_1, resposta_item_2, resposta_item_2_1,
                    resposta_item_3, resposta_item_4, resposta_item_4_1, resposta_item_5, resposta_item_5_1,
                    resposta_item_6, resposta_item_7, resposta_item_8, resposta_item_8_1_1,
                    resposta_item_8_1_2, resposta_item_8_2, resposta_item_9, resposta_item_9_1,
                    resposta_item_10, local_emissao, data_emissao, caminho_arquivo,
                    status_arquivo, uid_usuario_logado, status
                ) VALUES (
                    @id_colaborador, @id_unidade_senac, @id_termo_ciencia_de_homologacao,
                    @resposta_item_1, @resposta_item_1_1, @resposta_item_2, @resposta_item_2_1,
                    @resposta_item_3, @resposta_item_4, @resposta_item_4_1, @resposta_item_5, @resposta_item_5_1,
                    @resposta_item_6, @resposta_item_7, @resposta_item_8, @resposta_item_8_1_1,
                    @resposta_item_8_1_2, @resposta_item_8_2, @resposta_item_9, @resposta_item_9_1,
                    @resposta_item_10, @local_emissao, @data_emissao, @caminho_arquivo,
                    @status_arquivo, @uid_usuario_logado, @status
                );"

                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id_colaborador", TermoFinsRescisorios.IdColaborador)
                    cmd.Parameters.AddWithValue("@id_unidade_senac", TermoFinsRescisorios.IdUnidadeSenac)
                    cmd.Parameters.AddWithValue("@id_termo_ciencia_de_homologacao", TermoFinsRescisorios.IdTermoCienciaDeHomologacao)
                    cmd.Parameters.AddWithValue("@resposta_item_1", TermoFinsRescisorios.RespostaItem1)
                    cmd.Parameters.AddWithValue("@resposta_item_1_1", TermoFinsRescisorios.RespostaItem11)
                    cmd.Parameters.AddWithValue("@resposta_item_2", TermoFinsRescisorios.RespostaItem2)
                    cmd.Parameters.AddWithValue("@resposta_item_2_1", TermoFinsRescisorios.RespostaItem21)
                    cmd.Parameters.AddWithValue("@resposta_item_3", TermoFinsRescisorios.RespostaItem3)
                    cmd.Parameters.AddWithValue("@resposta_item_4", TermoFinsRescisorios.RespostaItem4)
                    cmd.Parameters.AddWithValue("@resposta_item_4_1", TermoFinsRescisorios.RespostaItem41)
                    cmd.Parameters.AddWithValue("@resposta_item_5", TermoFinsRescisorios.RespostaItem5)
                    cmd.Parameters.AddWithValue("@resposta_item_5_1", TermoFinsRescisorios.RespostaItem51)
                    cmd.Parameters.AddWithValue("@resposta_item_6", TermoFinsRescisorios.RespostaItem6)
                    cmd.Parameters.AddWithValue("@resposta_item_7", TermoFinsRescisorios.RespostaItem7)
                    cmd.Parameters.AddWithValue("@resposta_item_8", TermoFinsRescisorios.RespostaItem8)
                    cmd.Parameters.AddWithValue("@resposta_item_8_1_1", TermoFinsRescisorios.RespostaItem811)
                    cmd.Parameters.AddWithValue("@resposta_item_8_1_2", TermoFinsRescisorios.RespostaItem812)
                    cmd.Parameters.AddWithValue("@resposta_item_8_2", TermoFinsRescisorios.RespostaItem82)
                    cmd.Parameters.AddWithValue("@resposta_item_9", TermoFinsRescisorios.RespostaItem9)
                    cmd.Parameters.AddWithValue("@resposta_item_9_1", TermoFinsRescisorios.RespostaItem91)
                    cmd.Parameters.AddWithValue("@resposta_item_10", TermoFinsRescisorios.RespostaItem10)
                    cmd.Parameters.AddWithValue("@local_emissao", TermoFinsRescisorios.LocalEmissao)
                    cmd.Parameters.AddWithValue("@data_emissao", TermoFinsRescisorios.DataEmissao)
                    cmd.Parameters.AddWithValue("@caminho_arquivo", TermoFinsRescisorios.CaminhoArquivo)
                    cmd.Parameters.AddWithValue("@status_arquivo", TermoFinsRescisorios.StatusArquivo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", TermoFinsRescisorios.Status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ADICIONAR | CLÍNICA AUTORIZADA"

    Public Function ClinicaAutorizada__Adicionar(ClinicaAutorizada As ClinicaAutorizada) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                INSERT INTO clinica_autorizada (
                    id_endereco, nome_clinica, email_atendimento, nome_atendente, telefone, fixo, uid_usuario_logado, status
                ) VALUES (
                    @id_endereco, @nome_clinica, @email_atendimento, @nome_atendente, @telefone, @fixo, @uid_usuario_logado, @status
                );", conn)

                    cmd.Parameters.AddWithValue("@id_endereco", ClinicaAutorizada.IdEndereco)
                    cmd.Parameters.AddWithValue("@nome_clinica", ClinicaAutorizada.NomeClinica)
                    cmd.Parameters.AddWithValue("@email_atendimento", ClinicaAutorizada.EmailAtendimento)
                    cmd.Parameters.AddWithValue("@nome_atendente", ClinicaAutorizada.NomeAtendente)
                    cmd.Parameters.AddWithValue("@telefone", ClinicaAutorizada.Telefone)
                    cmd.Parameters.AddWithValue("@fixo", ClinicaAutorizada.Fixo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", ClinicaAutorizada.Status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function


#End Region

#Region "FUNÇÕES DA TABELA | ADICIONAR | COLABORADOR"

    Public Function Colaborador__Adicionar(Colaborador As Colaborador) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                INSERT INTO colaborador (
                    nome_completo, nome_social, email_pessoal, telefone_pessoal, sexo, data_de_nascimento,
                    cpf, rg, email_corporativo, funcao, setor, chapa, data_de_admissao, data_de_demissao,
                    tipo_contrato, modalidade_contrato, status_documentos_admissionais,
                    status_carta_de_abertura_de_conta_salario, status_contrato,
                    uid_usuario_logado, status
                ) VALUES (
                    @nome_completo, @nome_social, @email_pessoal, @telefone_pessoal, @sexo, @data_de_nascimento,
                    @cpf, @rg, @email_corporativo, @funcao, @setor, @chapa, @data_de_admissao, @data_de_demissao,
                    @tipo_contrato, @modalidade_contrato, @status_documentos_admissionais,
                    @status_carta_de_abertura_de_conta_salario, @status_contrato,
                    @uid_usuario_logado, @status
                );", conn)

                    cmd.Parameters.AddWithValue("@nome_completo", Colaborador.NomeCompleto)
                    cmd.Parameters.AddWithValue("@nome_social", Colaborador.NomeSocial)
                    cmd.Parameters.AddWithValue("@email_pessoal", Colaborador.EmailPessoal)
                    cmd.Parameters.AddWithValue("@telefone_pessoal", Colaborador.TelefonePessoal)
                    cmd.Parameters.AddWithValue("@sexo", Colaborador.Sexo)
                    cmd.Parameters.AddWithValue("@data_de_nascimento", Colaborador.DataDeNascimento)
                    cmd.Parameters.AddWithValue("@cpf", Colaborador.CPF)
                    cmd.Parameters.AddWithValue("@rg", Colaborador.RG)
                    cmd.Parameters.AddWithValue("@email_corporativo", Colaborador.EmailCorporativo)
                    cmd.Parameters.AddWithValue("@funcao", Colaborador.Funcao)
                    cmd.Parameters.AddWithValue("@setor", Colaborador.Setor)
                    cmd.Parameters.AddWithValue("@chapa", Colaborador.Chapa)
                    cmd.Parameters.AddWithValue("@data_de_admissao", Colaborador.DataDeAdmissao)
                    cmd.Parameters.AddWithValue("@data_de_demissao", If(String.IsNullOrEmpty(Colaborador.DataDeDemissao), DBNull.Value, Colaborador.DataDeDemissao))
                    cmd.Parameters.AddWithValue("@tipo_contrato", Colaborador.TipoContrato)
                    cmd.Parameters.AddWithValue("@modalidade_contrato", Colaborador.ModalidadeContrato)
                    cmd.Parameters.AddWithValue("@status_documentos_admissionais", Colaborador.StatusDocumentosAdmissionais)
                    cmd.Parameters.AddWithValue("@status_carta_de_abertura_de_conta_salario", Colaborador.StatusCartaDeAberturaDeContaSalario)
                    cmd.Parameters.AddWithValue("@status_contrato", Colaborador.StatusContrato)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", Colaborador.Status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ADICIONAR | ENDEREÇO"

    Public Function Endereco__Adicionar(Endereco As Endereco) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                INSERT INTO endereco (
                    logradouro, numero, bairro, cidade, estado, cep, uid_usuario_logado, status
                ) VALUES (
                    @logradouro, @numero, @bairro, @cidade, @estado, @cep, @uid_usuario_logado, @status
                );", conn)

                    cmd.Parameters.AddWithValue("@logradouro", Endereco.Logradouro)
                    cmd.Parameters.AddWithValue("@numero", Endereco.Numero)
                    cmd.Parameters.AddWithValue("@bairro", Endereco.Bairro)
                    cmd.Parameters.AddWithValue("@cidade", Endereco.Cidade)
                    cmd.Parameters.AddWithValue("@estado", Endereco.Estado)
                    cmd.Parameters.AddWithValue("@cep", Endereco.CEP)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", Endereco.Status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ADICIONAR | EXAME MÉDICO"

    Public Function ExameMedico__Adicionar(ExameMedico As ExameMedico) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                INSERT INTO exame_medico (
                    id_colaborador, id_clinica_autorizada, tipo_exame, status_exame,
                    data_realizacao, horario_realizacao, status_aso, caminho_arquivo_aso,
                    uid_usuario_logado, status
                ) VALUES (
                    @id_colaborador, @id_clinica_autorizada, @tipo_exame, @status_exame,
                    @data_realizacao, @horario_realizacao, @status_aso, @caminho_arquivo_aso,
                    @uid_usuario_logado, @status
                );", conn)

                    cmd.Parameters.AddWithValue("@id_colaborador", ExameMedico.IdColaborador)
                    cmd.Parameters.AddWithValue("@id_clinica_autorizada", ExameMedico.IdClinicaAutorizada)
                    cmd.Parameters.AddWithValue("@tipo_exame", ExameMedico.TipoExame)
                    cmd.Parameters.AddWithValue("@status_exame", ExameMedico.StatusExame)
                    cmd.Parameters.AddWithValue("@data_realizacao", ExameMedico.DataRealizacao)
                    cmd.Parameters.AddWithValue("@horario_realizacao", ExameMedico.HorarioRealizacao)
                    cmd.Parameters.AddWithValue("@status_aso", ExameMedico.StatusASO)
                    cmd.Parameters.AddWithValue("@caminho_arquivo_aso", ExameMedico.CaminhoArquivoASO)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", ExameMedico.Status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ADICIONAR | UNIDADE SENAC"

    Public Function UnidadeSenac__Adicionar(UnidadeSenac As UnidadeSenac) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                INSERT INTO unidade_senac (
                    id_endereco, codigo_unidade, nome_unidade,
                    uid_usuario_logado, status
                ) VALUES (
                    @id_endereco, @codigo_unidade, @nome_unidade,
                    @uid_usuario_logado, @status
                );", conn)

                    cmd.Parameters.AddWithValue("@id_endereco", UnidadeSenac.IdEndereco)
                    cmd.Parameters.AddWithValue("@codigo_unidade", UnidadeSenac.CodigoUnidade)
                    cmd.Parameters.AddWithValue("@nome_unidade", UnidadeSenac.NomeUnidade)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", UnidadeSenac.Status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ADICIONAR | DOCUMENTO COLABORADOR"

    Public Function DocumentoColaborador__Adicionar(DocumentoColaborador As DocumentoColaborador) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                INSERT INTO documento_colaborador (
                    id_colaborador, nome_documento, caminho_arquivo,
                    status_documento, uid_usuario_logado, status
                ) VALUES (
                    @id_colaborador, @nome_documento, @caminho_arquivo,
                    @status_documento, @uid_usuario_logado, @status
                );", conn)

                    cmd.Parameters.AddWithValue("@id_colaborador", DocumentoColaborador.IdColaborador)
                    cmd.Parameters.AddWithValue("@nome_documento", DocumentoColaborador.NomeDocumento)
                    cmd.Parameters.AddWithValue("@caminho_arquivo", DocumentoColaborador.CaminhoArquivo)
                    cmd.Parameters.AddWithValue("@status_documento", DocumentoColaborador.StatusDocumento)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", DocumentoColaborador.Status)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ADICIONAR | DOCUMENTO MODELO"

    Public Function DocumentoModelo__Adicionar(DocumentoModelo As DocumentoModelo) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                INSERT INTO documento_modelo (
                    tipo_contrato, modalidade_contrato, nome_documento,
                    caminho_arquivo, uid_usuario_logado, status
                ) VALUES (
                    @tipo_contrato, @modalidade_contrato, @nome_documento,
                    @caminho_arquivo, @uid_usuario_logado, @status
                );", conn)

                    cmd.Parameters.AddWithValue("@tipo_contrato", Convert.ToInt32(DocumentoModelo.TipoContrato))
                    cmd.Parameters.AddWithValue("@modalidade_contrato", Convert.ToInt32(DocumentoModelo.ModalidadeContrato))
                    cmd.Parameters.AddWithValue("@nome_documento", DocumentoModelo.NomeDocumento)
                    cmd.Parameters.AddWithValue("@caminho_arquivo", DocumentoModelo.CaminhoArquivo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.Parameters.AddWithValue("@status", Convert.ToInt32(DocumentoModelo.Status))

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#End Region

#Region "FUNÇÕES DE ATUALIZAR"

#Region "FUNÇÕES DA TABELA | ATUALIZAR | AGÊNCIA CAIXA"

    Public Function AgenciaCaixa__Atualizar(AgenciaCaixa As AgenciaCaixa) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()

                Dim query As String = "
                    UPDATE agencia_caixa
                    SET id_endereco = @id_endereco,
                        codigo_agencia = @codigo_agencia,
                        status = @status
                    WHERE id_agencia_caixa = @id_agencia_caixa
                      AND uid_usuario_logado = @uid_usuario_logado;"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_endereco", AgenciaCaixa.IdEndereco)
                    cmd.Parameters.AddWithValue("@codigo_agencia", AgenciaCaixa.CodigoAgencia)
                    cmd.Parameters.AddWithValue("@status", AgenciaCaixa.Status)
                    cmd.Parameters.AddWithValue("@id_agencia_caixa", AgenciaCaixa.IdAgenciaCaixa)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhuma agência foi atualizada. Verifique o ID e o usuário.")
                    End If
                End Using
            End Using

            Return (True, "Agência atualizada com sucesso.")
        Catch ex As Exception
            Return (False, $"Erro ao atualizar agência: {ex.Message}")
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ATUALIZAR | CARTA DE ABERTURA DE CONTA-SALÁRIO"

    Public Function CartaDeAberturaDeContaSalario__Atualizar(CartaDeAberturaDeContaSalario As CartaDeAberturaDeContaSalario) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()

                Dim query As String = "
                    UPDATE carta_de_abertura_de_conta_salario
                    SET id_colaborador = @id_colaborador,
                        id_agencia_caixa = @id_agencia_caixa,
                        id_unidade_senac = @id_unidade_senac,
                        caminho_arquivo = @caminho_arquivo,
                        status_arquivo = @status_arquivo,
                        status = @status
                    WHERE id_carta = @id_carta
                      AND uid_usuario_logado = @uid_usuario_logado;"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_colaborador", CartaDeAberturaDeContaSalario.IdColaborador)
                    cmd.Parameters.AddWithValue("@id_agencia_caixa", CartaDeAberturaDeContaSalario.IdAgenciaCaixa)
                    cmd.Parameters.AddWithValue("@id_unidade_senac", CartaDeAberturaDeContaSalario.IdUnidadeSenac)
                    cmd.Parameters.AddWithValue("@caminho_arquivo", CartaDeAberturaDeContaSalario.CaminhoArquivo)
                    cmd.Parameters.AddWithValue("@status_arquivo", CartaDeAberturaDeContaSalario.StatusArquivo)
                    cmd.Parameters.AddWithValue("@status", CartaDeAberturaDeContaSalario.Status)
                    cmd.Parameters.AddWithValue("@id_carta", CartaDeAberturaDeContaSalario.IdCarta)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhuma CartaDeAberturaDeContaSalario foi atualizada. Verifique o ID e o usuário.")
                    End If
                End Using
            End Using

            Return (True, "Carta atualizada com sucesso.")
        Catch ex As Exception
            Return (False, $"Erro ao atualizar CartaDeAberturaDeContaSalario: {ex.Message}")
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ATUALIZAR | TERMO DE CIÊNCIA DE HOMOLOGAÇÃO"

    Public Function TermoCienciaDeHomologacao__ATUALIZAR(TermoCienciaDeHomologacao As TermoCienciaDeHomologacao) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()

                Dim sql As String = "
                    UPDATE termo_ciencia_de_homologacao SET
                        id_colaborador = @id_colaborador,
                        id_unidade_senac = @id_unidade_senac,
                        id_exame = @id_exame,
                        email_pessoal = @email_pessoal,
                        telefone_pessoal = @telefone_pessoal,
                        data_homologacao = @data_homologacao,
                        caminho_arquivo = @caminho_arquivo,
                        status_arquivo = @status_arquivo,
                        status = @status
                    WHERE id_termo = @id_termo AND uid_usuario_logado = @uid_usuario_logado;"

                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id_colaborador", TermoCienciaDeHomologacao.IdColaborador)
                    cmd.Parameters.AddWithValue("@id_unidade_senac", TermoCienciaDeHomologacao.IdUnidadeSenac)
                    cmd.Parameters.AddWithValue("@id_exame", TermoCienciaDeHomologacao.IdExame)
                    cmd.Parameters.AddWithValue("@email_pessoal", TermoCienciaDeHomologacao.EmailPessoal)
                    cmd.Parameters.AddWithValue("@telefone_pessoal", TermoCienciaDeHomologacao.TelefonePessoal)
                    cmd.Parameters.AddWithValue("@data_homologacao", TermoCienciaDeHomologacao.DataHomologacao)
                    cmd.Parameters.AddWithValue("@caminho_arquivo", TermoCienciaDeHomologacao.CaminhoArquivo)
                    cmd.Parameters.AddWithValue("@status_arquivo", TermoCienciaDeHomologacao.StatusArquivo)
                    cmd.Parameters.AddWithValue("@status", TermoCienciaDeHomologacao.Status)
                    cmd.Parameters.AddWithValue("@id_termo", TermoCienciaDeHomologacao.IdTermo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro atualizado. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using

            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ATUALIZAR | TERMO DE FINS RESCISÓRIOS"

    Public Function TermoFinsRescisorios__Atualizar(TermoFinsRescisorios As TermoFinsRescisorios) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Dim sql As String = "
                UPDATE termo_fins_rescisorios SET
                    id_colaborador = @id_colaborador,
                    id_unidade_senac = @id_unidade_senac,
                    id_termo_ciencia_de_homologacao = @id_termo_ciencia_de_homologacao,
                    resposta_item_1 = @resposta_item_1,
                    resposta_item_1_1 = @resposta_item_1_1,
                    resposta_item_2 = @resposta_item_2,
                    resposta_item_2_1 = @resposta_item_2_1,
                    resposta_item_3 = @resposta_item_3,
                    resposta_item_4 = @resposta_item_4,
                    resposta_item_4_1 = @resposta_item_4_1,
                    resposta_item_5 = @resposta_item_5,
                    resposta_item_5_1 = @resposta_item_5_1,
                    resposta_item_6 = @resposta_item_6,
                    resposta_item_7 = @resposta_item_7,
                    resposta_item_8 = @resposta_item_8,
                    resposta_item_8_1_1 = @resposta_item_8_1_1,
                    resposta_item_8_1_2 = @resposta_item_8_1_2,
                    resposta_item_8_2 = @resposta_item_8_2,
                    resposta_item_9 = @resposta_item_9,
                    resposta_item_9_1 = @resposta_item_9_1,
                    resposta_item_10 = @resposta_item_10,
                    local_emissao = @local_emissao,
                    data_emissao = @data_emissao,
                    caminho_arquivo = @caminho_arquivo,
                    status_arquivo = @status_arquivo,
                    status = @status
                WHERE id_termo = @id_termo AND uid_usuario_logado = @uid_usuario_logado;"

                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id_colaborador", TermoFinsRescisorios.IdColaborador)
                    cmd.Parameters.AddWithValue("@id_unidade_senac", TermoFinsRescisorios.IdUnidadeSenac)
                    cmd.Parameters.AddWithValue("@id_termo_ciencia_de_homologacao", TermoFinsRescisorios.IdTermoCienciaDeHomologacao)
                    cmd.Parameters.AddWithValue("@resposta_item_1", TermoFinsRescisorios.RespostaItem1)
                    cmd.Parameters.AddWithValue("@resposta_item_1_1", TermoFinsRescisorios.RespostaItem11)
                    cmd.Parameters.AddWithValue("@resposta_item_2", TermoFinsRescisorios.RespostaItem2)
                    cmd.Parameters.AddWithValue("@resposta_item_2_1", TermoFinsRescisorios.RespostaItem21)
                    cmd.Parameters.AddWithValue("@resposta_item_3", TermoFinsRescisorios.RespostaItem3)
                    cmd.Parameters.AddWithValue("@resposta_item_4", TermoFinsRescisorios.RespostaItem4)
                    cmd.Parameters.AddWithValue("@resposta_item_4_1", TermoFinsRescisorios.RespostaItem41)
                    cmd.Parameters.AddWithValue("@resposta_item_5", TermoFinsRescisorios.RespostaItem5)
                    cmd.Parameters.AddWithValue("@resposta_item_5_1", TermoFinsRescisorios.RespostaItem51)
                    cmd.Parameters.AddWithValue("@resposta_item_6", TermoFinsRescisorios.RespostaItem6)
                    cmd.Parameters.AddWithValue("@resposta_item_7", TermoFinsRescisorios.RespostaItem7)
                    cmd.Parameters.AddWithValue("@resposta_item_8", TermoFinsRescisorios.RespostaItem8)
                    cmd.Parameters.AddWithValue("@resposta_item_8_1_1", TermoFinsRescisorios.RespostaItem811)
                    cmd.Parameters.AddWithValue("@resposta_item_8_1_2", TermoFinsRescisorios.RespostaItem812)
                    cmd.Parameters.AddWithValue("@resposta_item_8_2", TermoFinsRescisorios.RespostaItem82)
                    cmd.Parameters.AddWithValue("@resposta_item_9", TermoFinsRescisorios.RespostaItem9)
                    cmd.Parameters.AddWithValue("@resposta_item_9_1", TermoFinsRescisorios.RespostaItem91)
                    cmd.Parameters.AddWithValue("@resposta_item_10", TermoFinsRescisorios.RespostaItem10)
                    cmd.Parameters.AddWithValue("@local_emissao", TermoFinsRescisorios.LocalEmissao)
                    cmd.Parameters.AddWithValue("@data_emissao", TermoFinsRescisorios.DataEmissao)
                    cmd.Parameters.AddWithValue("@caminho_arquivo", TermoFinsRescisorios.CaminhoArquivo)
                    cmd.Parameters.AddWithValue("@status_arquivo", TermoFinsRescisorios.StatusArquivo)
                    cmd.Parameters.AddWithValue("@status", TermoFinsRescisorios.Status)
                    cmd.Parameters.AddWithValue("@id_termo", TermoFinsRescisorios.IdTermo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro atualizado. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function


#End Region

#Region "FUNÇÕES DA TABELA | ATUALIZAR | CLÍNICA AUTORIZADA"

    Public Function ClinicaAutorizada__Atualizar(ClinicaAutorizada As ClinicaAutorizada) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                UPDATE clinica_autorizada SET
                    id_endereco = @id_endereco,
                    nome_clinica = @nome_clinica,
                    email_atendimento = @email_atendimento,
                    nome_atendente = @nome_atendente,
                    telefone = @telefone,
                    fixo = @fixo,
                    status = @status
                WHERE
                    id_clinica_autorizada = @id_clinica_autorizada
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_endereco", ClinicaAutorizada.IdEndereco)
                    cmd.Parameters.AddWithValue("@nome_clinica", ClinicaAutorizada.NomeClinica)
                    cmd.Parameters.AddWithValue("@email_atendimento", ClinicaAutorizada.EmailAtendimento)
                    cmd.Parameters.AddWithValue("@nome_atendente", ClinicaAutorizada.NomeAtendente)
                    cmd.Parameters.AddWithValue("@telefone", ClinicaAutorizada.Telefone)
                    cmd.Parameters.AddWithValue("@fixo", ClinicaAutorizada.Fixo)
                    cmd.Parameters.AddWithValue("@status", ClinicaAutorizada.Status)
                    cmd.Parameters.AddWithValue("@id_clinica_autorizada", ClinicaAutorizada.IdClinicaAutorizada)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro atualizado. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ATUALIZAR | COLABORADOR"

    Public Function Colaborador__Atualizar(Colaborador As Colaborador) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                UPDATE colaborador SET
                    nome_completo = @nome_completo,
                    nome_social = @nome_social,
                    email_pessoal = @email_pessoal,
                    telefone_pessoal = @telefone_pessoal,
                    sexo = @sexo,
                    data_de_nascimento = @data_de_nascimento,
                    cpf = @cpf,
                    rg = @rg,
                    email_corporativo = @email_corporativo,
                    funcao = @funcao,
                    setor = @setor,
                    chapa = @chapa,
                    data_de_admissao = @data_de_admissao,
                    data_de_demissao = @data_de_demissao,
                    tipo_contrato = @tipo_contrato,
                    modalidade_contrato = @modalidade_contrato,
                    status_documentos_admissionais = @status_documentos_admissionais,
                    status_carta_de_abertura_de_conta_salario = @status_carta_de_abertura_de_conta_salario,
                    status_contrato = @status_contrato,
                    status = @status
                WHERE
                    id_colaborador = @id_colaborador
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@nome_completo", Colaborador.NomeCompleto)
                    cmd.Parameters.AddWithValue("@nome_social", Colaborador.NomeSocial)
                    cmd.Parameters.AddWithValue("@email_pessoal", Colaborador.EmailPessoal)
                    cmd.Parameters.AddWithValue("@telefone_pessoal", Colaborador.TelefonePessoal)
                    cmd.Parameters.AddWithValue("@sexo", Colaborador.Sexo)
                    cmd.Parameters.AddWithValue("@data_de_nascimento", Colaborador.DataDeNascimento)
                    cmd.Parameters.AddWithValue("@cpf", Colaborador.CPF)
                    cmd.Parameters.AddWithValue("@rg", Colaborador.RG)
                    cmd.Parameters.AddWithValue("@email_corporativo", Colaborador.EmailCorporativo)
                    cmd.Parameters.AddWithValue("@funcao", Colaborador.Funcao)
                    cmd.Parameters.AddWithValue("@setor", Colaborador.Setor)
                    cmd.Parameters.AddWithValue("@chapa", Colaborador.Chapa)
                    cmd.Parameters.AddWithValue("@data_de_admissao", Colaborador.DataDeAdmissao)
                    cmd.Parameters.AddWithValue("@data_de_demissao", If(String.IsNullOrEmpty(Colaborador.DataDeDemissao), DBNull.Value, Colaborador.DataDeDemissao))
                    cmd.Parameters.AddWithValue("@tipo_contrato", Colaborador.TipoContrato)
                    cmd.Parameters.AddWithValue("@modalidade_contrato", Colaborador.ModalidadeContrato)
                    cmd.Parameters.AddWithValue("@status_documentos_admissionais", Colaborador.StatusDocumentosAdmissionais)
                    cmd.Parameters.AddWithValue("@status_carta_de_abertura_de_conta_salario", Colaborador.StatusCartaDeAberturaDeContaSalario)
                    cmd.Parameters.AddWithValue("@status_contrato", Colaborador.StatusContrato)
                    cmd.Parameters.AddWithValue("@status", Colaborador.Status)
                    cmd.Parameters.AddWithValue("@id_colaborador", Colaborador.IdColaborador)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro atualizado. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ATUALIZAR | ENDEREÇO"

    Public Function Endereco__Atualizar(Endereco As Endereco) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                UPDATE endereco SET
                    logradouro = @logradouro,
                    numero = @numero,
                    bairro = @bairro,
                    cidade = @cidade,
                    estado = @estado,
                    cep = @cep,
                    status = @status
                WHERE
                    id_endereco = @id_endereco
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@logradouro", Endereco.Logradouro)
                    cmd.Parameters.AddWithValue("@numero", Endereco.Numero)
                    cmd.Parameters.AddWithValue("@bairro", Endereco.Bairro)
                    cmd.Parameters.AddWithValue("@cidade", Endereco.Cidade)
                    cmd.Parameters.AddWithValue("@estado", Endereco.Estado)
                    cmd.Parameters.AddWithValue("@cep", Endereco.CEP)
                    cmd.Parameters.AddWithValue("@status", Endereco.Status)
                    cmd.Parameters.AddWithValue("@id_endereco", Endereco.IdEndereco)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro atualizado. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ATUALIZAR | EXAME MÉDICO"

    Public Function ExameMedico__Atualizar(ExameMedico As ExameMedico) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                UPDATE exame_medico SET
                    id_colaborador = @id_colaborador,
                    id_clinica_autorizada = @id_clinica_autorizada,
                    tipo_exame = @tipo_exame,
                    status_exame = @status_exame,
                    data_realizacao = @data_realizacao,
                    horario_realizacao = @horario_realizacao,
                    status_aso = @status_aso,
                    caminho_arquivo_aso = @caminho_arquivo_aso,
                    status = @status
                WHERE
                    id_exame = @id_exame
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_colaborador", ExameMedico.IdColaborador)
                    cmd.Parameters.AddWithValue("@id_clinica_autorizada", ExameMedico.IdClinicaAutorizada)
                    cmd.Parameters.AddWithValue("@tipo_exame", ExameMedico.TipoExame)
                    cmd.Parameters.AddWithValue("@status_exame", ExameMedico.StatusExame)
                    cmd.Parameters.AddWithValue("@data_realizacao", ExameMedico.DataRealizacao)
                    cmd.Parameters.AddWithValue("@horario_realizacao", ExameMedico.HorarioRealizacao)
                    cmd.Parameters.AddWithValue("@status_aso", ExameMedico.StatusASO)
                    cmd.Parameters.AddWithValue("@caminho_arquivo_aso", ExameMedico.CaminhoArquivoASO)
                    cmd.Parameters.AddWithValue("@status", ExameMedico.Status)
                    cmd.Parameters.AddWithValue("@id_exame", ExameMedico.IdExame)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro atualizado. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ATUALIZAR | UNIDADE SENAC"

    Public Function UnidadeSenac__Atualizar(UnidadeSenac As UnidadeSenac) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                UPDATE unidade_senac SET
                    id_endereco = @id_endereco,
                    codigo_unidade = @codigo_unidade,
                    nome_unidade = @nome_unidade,
                    status = @status
                WHERE
                    id_unidade_senac = @id_unidade_senac
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_endereco", UnidadeSenac.IdEndereco)
                    cmd.Parameters.AddWithValue("@codigo_unidade", UnidadeSenac.CodigoUnidade)
                    cmd.Parameters.AddWithValue("@nome_unidade", UnidadeSenac.NomeUnidade)
                    cmd.Parameters.AddWithValue("@status", UnidadeSenac.Status)
                    cmd.Parameters.AddWithValue("@id_unidade_senac", UnidadeSenac.IdUnidadeSenac)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro atualizado. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | ATUALIZAR | DOCUMENTO COLABORADOR"

    Public Function DocumentoColaborador__Atualizar(DocumentoColaborador As DocumentoColaborador) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                UPDATE documento_colaborador SET
                    id_colaborador = @id_colaborador,
                    nome_documento = @nome_documento,
                    caminho_arquivo = @caminho_arquivo,
                    status_documento = @status_documento,
                    status = @status
                WHERE
                    id_documento_colaborador = @id_documento_colaborador
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_colaborador", DocumentoColaborador.IdColaborador)
                    cmd.Parameters.AddWithValue("@nome_documento", DocumentoColaborador.NomeDocumento)
                    cmd.Parameters.AddWithValue("@caminho_arquivo", DocumentoColaborador.CaminhoArquivo)
                    cmd.Parameters.AddWithValue("@status_documento", DocumentoColaborador.StatusDocumento)
                    cmd.Parameters.AddWithValue("@status", DocumentoColaborador.Status)
                    cmd.Parameters.AddWithValue("@id_documento_colaborador", DocumentoColaborador.IdDocumentosColaborador)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro atualizado. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function


#End Region

#Region "FUNÇÕES DA TABELA | ATUALIZAR | DOCUMENTO MODELO"

    Public Function DocumentoModelo__Atualizar(DocumentoModelo As DocumentoModelo) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                UPDATE documento_modelo SET
                    tipo_contrato = @tipo_contrato,
                    modalidade_contrato = @modalidade_contrato,
                    nome_documento = @nome_documento,
                    caminho_arquivo = @caminho_arquivo,
                    status = @status
                WHERE
                    id_documento_modelo = @id_documento_modelo
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@tipo_contrato", Convert.ToInt32(DocumentoModelo.TipoContrato))
                    cmd.Parameters.AddWithValue("@modalidade_contrato", Convert.ToInt32(DocumentoModelo.ModalidadeContrato))
                    cmd.Parameters.AddWithValue("@nome_documento", DocumentoModelo.NomeDocumento)
                    cmd.Parameters.AddWithValue("@caminho_arquivo", DocumentoModelo.CaminhoArquivo)
                    cmd.Parameters.AddWithValue("@status", Convert.ToInt32(DocumentoModelo.Status))
                    cmd.Parameters.AddWithValue("@id_documento_modelo", DocumentoModelo.IdDocumentoModelo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro atualizado. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#End Region

#Region "FUNÇÕES DE REMOVER"

#Region "FUNÇÕES DA TABELA | REMOVER | AGÊNCIA CAIXA"

    Public Function AgenciaCaixa__Remover(AgenciaCaixa As AgenciaCaixa) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()

                Dim query As String = "
                    DELETE FROM agencia_caixa
                    WHERE id_agencia_caixa = @id_agencia_caixa
                      AND uid_usuario_logado = @uid_usuario_logado;"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_agencia_caixa", AgenciaCaixa.IdAgenciaCaixa)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhuma agência foi removida. Verifique o ID e o usuário.")
                    End If
                End Using
            End Using

            Return (True, "Agência removida com sucesso.")
        Catch ex As Exception
            Return (False, $"Erro ao remover agência: {ex.Message}")
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | REMOVER | CARTA DE ABERTURA DE CONTA-SALÁRIO"

    Public Function CartaDeAberturaDeContaSalario__Remover(CartaDeAberturaDeContaSalario As CartaDeAberturaDeContaSalario) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()

                Dim query As String = "
                    DELETE FROM carta_de_abertura_de_conta_salario
                    WHERE id_carta = @id_carta
                      AND uid_usuario_logado = @uid_usuario_logado;"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_carta", CartaDeAberturaDeContaSalario.IdCarta)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhuma CartaDeAberturaDeContaSalario foi removida. Verifique o ID e o usuário.")
                    End If
                End Using
            End Using

            Return (True, "Carta removida com sucesso.")
        Catch ex As Exception
            Return (False, $"Erro ao remover CartaDeAberturaDeContaSalario: {ex.Message}")
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | REMOVER | TERMO DE CIÊNCIA DE HOMOLOGAÇÃO"

    Public Function TermoCienciaDeHomologacao__REMOVER(TermoCienciaDeHomologacao As TermoCienciaDeHomologacao) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()

                Dim sql As String = "
                    DELETE FROM termo_ciencia_de_homologacao
                    WHERE id_termo = @id_termo AND uid_usuario_logado = @uid_usuario_logado;"

                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id_termo", TermoCienciaDeHomologacao.IdTermo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | REMOVER | TERMO DE FINS RESCISÓRIOS"

    Public Function TermoFinsRescisorios__Remover(TermoFinsRescisorios As TermoFinsRescisorios) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Dim sql As String = "
                DELETE FROM termo_fins_rescisorios
                WHERE id_termo = @id_termo AND uid_usuario_logado = @uid_usuario_logado;"

                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id_termo", TermoFinsRescisorios.IdTermo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | REMOVER | CLÍNICA AUTORIZADA"

    Public Function ClinicaAutorizada__Remover(ClinicaAutorizada As ClinicaAutorizada) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                DELETE FROM clinica_autorizada
                WHERE
                    id_clinica_autorizada = @id_clinica_autorizada
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_clinica_autorizada", ClinicaAutorizada.IdClinicaAutorizada)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro removido. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | REMOVER | COLABORADOR"

    Public Function Colaborador__Remover(Colaborador As Colaborador) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                DELETE FROM colaborador
                WHERE
                    id_colaborador = @id_colaborador
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_colaborador", Colaborador.IdColaborador)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro removido. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | REMOVER | ENDEREÇO"

    Public Function Endereco__Remover(Endereco As Endereco) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                DELETE FROM endereco
                WHERE
                    id_endereco = @id_endereco
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_endereco", Endereco.IdEndereco)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro removido. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | REMOVER | EXAME MÉDICO"

    Public Function ExameMedico__Remover(ExameMedico As ExameMedico) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                DELETE FROM exame_medico
                WHERE
                    id_exame = @id_exame
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_exame", ExameMedico.IdExame)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro removido. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | REMOVER | UNIDADE SENAC"

    Public Function UnidadeSenac__Remover(UnidadeSenac As UnidadeSenac) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                DELETE FROM unidade_senac
                WHERE
                    id_unidade_senac = @id_unidade_senac
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_unidade_senac", UnidadeSenac.IdUnidadeSenac)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro removido. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | REMOVER | DOCUMENTO COLABORADOR"

    Public Function DocumentoColaborador__Remover(DocumentoColaborador As DocumentoColaborador) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                DELETE FROM documento_colaborador
                WHERE
                    id_documento_colaborador = @id_documento_colaborador
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_documento_colaborador", DocumentoColaborador.IdDocumentosColaborador)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro removido. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#Region "FUNÇÕES DA TABELA | REMOVER | DOCUMENTO MODELO"

    Public Function DocumentoModelo__Remover(DocumentoModelo As DocumentoModelo) As (Boolean, String)
        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)
                conn.Open()
                Using cmd As New SQLiteCommand("
                DELETE FROM documento_modelo
                WHERE
                    id_documento_modelo = @id_documento_modelo
                    AND uid_usuario_logado = @uid_usuario_logado;", conn)

                    cmd.Parameters.AddWithValue("@id_documento_modelo", DocumentoModelo.IdDocumentoModelo)
                    cmd.Parameters.AddWithValue("@uid_usuario_logado", UID_UsuarioLogado)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        Return (False, "Nenhum registro removido. Verifique se o ID e UID estão corretos.")
                    End If
                End Using
            End Using
            Return (True, "")
        Catch ex As Exception
            Return (False, ex.Message)
        End Try
    End Function

#End Region

#End Region

#Region "FUNÇÕES DE CONSULTA"

#Region "FUNÇÕES DA TABELA | AGÊNCIA CAIXA"

#End Region

#Region "FUNÇÕES DA TABELA | CARTA DE ABERTURA DE CONTA-SALÁRIO"

#End Region

#Region "FUNÇÕES DA TABELA | TERMO DE CIÊNCIA DE HOMOLOGAÇÃO"

#End Region

#Region "FUNÇÕES DA TABELA | TERMO DE FINS RESCISÓRIOS"

#End Region

#Region "FUNÇÕES DA TABELA | CLÍNICA AUTORIZADA"

#End Region

#Region "FUNÇÕES DA TABELA | COLABORADOR"

#End Region

#Region "FUNÇÕES DA TABELA | ENDEREÇO"

#End Region

#Region "FUNÇÕES DA TABELA | EXAME MÉDICO"

#End Region

#Region "FUNÇÕES DA TABELA | UNIDADE SENAC"

#End Region

#Region "FUNÇÕES DA TABELA | DOCUMENTO COLABORADOR"

#End Region

#Region "FUNÇÕES DA TABELA | DOCUMENTO MODELO"

#End Region

#End Region

End Module
