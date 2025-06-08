Imports System.Data.SQLite
Imports System.IO

Module Md__SQLite__Funcoes__Principais

#Region "FUNÇÃO PRINCIPAL"

    Public Sub InicializarBancoDeDadosLocal()

        Try

            VerificarOuCriarBanco()
            CriarTabelas()
            CriarGatilhos()
            CriarVistas()
            CriarIndices()

        Catch ex As Exception

            Console.WriteLine("Erro no processo principal: " & ex.Message)

        End Try

    End Sub

#End Region

#Region "FUNÇÕES PRIVADAS"

    Private Sub VerificarOuCriarBanco()

        Try

            If Not File.Exists(Caminho_BancoDeDados) Then

                CriarPastaSeNaoExistir(Caminho_PastaBancoDeDados)
                SQLiteConnection.CreateFile(Caminho_BancoDeDados)

            End If

        Catch ex As Exception

            Console.WriteLine("Erro ao verificar/criar banco: " & ex.Message)

        End Try

    End Sub

    Private Sub CriarTabelas()

        Try

            Using conn As New SQLiteConnection(CadeiaDeConexao)

                conn.Open()

                Dim comandos As New Text.StringBuilder()

                comandos.AppendLine("
                    CREATE TABLE IF NOT EXISTS agencia_caixa (
                        id_agencia_caixa INTEGER PRIMARY KEY AUTOINCREMENT,
                        codigo_agencia TEXT NOT NULL,
                        logradouro TEXT NOT NULL,
                        numero TEXT NOT NULL,
                        bairro TEXT NOT NULL,
                        cidade TEXT NOT NULL,
                        estado TEXT NOT NULL,
                        cep TEXT NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL
                    );")

                comandos.AppendLine("
                    CREATE TABLE IF NOT EXISTS carta_de_abertura_de_conta_salario (
                        id_carta INTEGER PRIMARY KEY AUTOINCREMENT,
                        id_colaborador INTEGER NOT NULL,
                        id_agencia_caixa INTEGER NOT NULL,
                        id_unidade_senac INTEGER NOT NULL,
                        caminho_arquivo TEXT NOT NULL,
                        status_arquivo INTEGER NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL,
                        FOREIGN KEY (id_colaborador) REFERENCES colaborador(id_colaborador),
                        FOREIGN KEY (id_agencia_caixa) REFERENCES agencia_caixa(id_agencia_caixa),
                        FOREIGN KEY (id_unidade_senac) REFERENCES unidade_senac(id_unidade_senac)
                    );")

                comandos.AppendLine("
                    CREATE TABLE IF NOT EXISTS termo_ciencia_de_homologacao (
                        id_termo INTEGER PRIMARY KEY AUTOINCREMENT,
                        id_colaborador INTEGER NOT NULL,
                        id_unidade_senac INTEGER NOT NULL,
                        id_exame INTEGER NOT NULL,
                        email_pessoal TEXT NOT NULL,
                        telefone_pessoal TEXT NOT NULL,
                        data_homologacao TEXT NOT NULL,
                        caminho_arquivo TEXT NOT NULL,
                        status_arquivo INTEGER NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL,
                        FOREIGN KEY (id_colaborador) REFERENCES colaborador(id_colaborador),
                        FOREIGN KEY (id_exame) REFERENCES exame_medico(id_exame),
                        FOREIGN KEY (id_unidade_senac) REFERENCES unidade_senac(id_unidade_senac)
                    );")

                comandos.AppendLine("
                    CREATE TABLE IF NOT EXISTS termo_fins_rescisorios (
                        id_termo INTEGER PRIMARY KEY AUTOINCREMENT,
                        id_colaborador INTEGER NOT NULL,
                        id_unidade_senac INTEGER NOT NULL,
	                    id_termo_ciencia_de_homologacao INTEGER NOT NULL,
	                    resposta_item_1 INTEGER NOT NULL,
                        resposta_item_1_1 TEXT,
                        resposta_item_2 INTEGER NOT NULL,
                        resposta_item_2_1 TEXT,
                        resposta_item_3 INTEGER NOT NULL,
                        resposta_item_4 INTEGER NOT NULL,
                        resposta_item_4_1 TEXT,
                        resposta_item_5 INTEGER NOT NULL,
                        resposta_item_5_1 TEXT,
                        resposta_item_6 INTEGER NOT NULL,
                        resposta_item_7 INTEGER NOT NULL,
                        resposta_item_8 INTEGER NOT NULL,
                        resposta_item_8_1_1 TEXT,
                        resposta_item_8_1_2 TEXT,
                        resposta_item_8_2 TEXT,
                        resposta_item_9 INTEGER NOT NULL,
                        resposta_item_9_1 TEXT,
                        resposta_item_10 TEXT,
                        local_emissao TEXT NOT NULL,
                        data_emissao TEXT NOT NULL,
                        caminho_arquivo TEXT NOT NULL,
                        status_arquivo INTEGER NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL,
                        FOREIGN KEY (id_colaborador) REFERENCES colaborador(id_colaborador),
                        FOREIGN KEY (id_termo_ciencia_de_homologacao) REFERENCES termo_ciencia_de_homologacao(id_termo_ciencia_de_homologacao),
                        FOREIGN KEY (id_unidade_senac) REFERENCES unidade_senac(id_unidade_senac)
                    );")

                comandos.AppendLine("
                    CREATE TABLE IF NOT EXISTS clinica_autorizada (
                        id_clinica_autorizada INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome_clinica TEXT NOT NULL,
                        email_atendimento TEXT NOT NULL,
                        nome_atendente TEXT NOT NULL,
                        telefone TEXT NOT NULL,
                        fixo TEXT,
                        logradouro TEXT NOT NULL,
                        numero TEXT NOT NULL,
                        bairro TEXT NOT NULL,
                        cidade TEXT NOT NULL,
                        estado TEXT NOT NULL,
                        cep TEXT NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL
                    );")

                comandos.AppendLine("
                    CREATE TABLE IF NOT EXISTS colaborador (
                        id_colaborador INTEGER PRIMARY KEY AUTOINCREMENT,
                        nome_completo TEXT NOT NULL,
                        nome_social TEXT,
                        email_pessoal TEXT,
                        telefone_pessoal TEXT,
                        sexo INTEGER NOT NULL,
                        data_de_nascimento TEXT NOT NULL,
                        cpf TEXT NOT NULL UNIQUE,
                        rg TEXT,
                        email_corporativo TEXT NOT NULL,
                        funcao TEXT NOT NULL,
                        setor TEXT NOT NULL,
                        chapa TEXT NOT NULL,
                        data_de_admissao TEXT NOT NULL,
                        data_de_demissao TEXT,
                        tipo_contrato INTEGER NOT NULL,
                        modalidade_contrato INTEGER NOT NULL,
                        status_documentos_admissionais INTEGER NOT NULL,
                        status_carta_de_abertura_de_conta_salario INTEGER NOT NULL,
                        status_contrato INTEGER NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL
                    );")

                comandos.AppendLine("
                    CREATE TABLE IF NOT EXISTS exame_medico (
                        id_exame INTEGER PRIMARY KEY AUTOINCREMENT,
                        id_colaborador INTEGER NOT NULL,
                        id_clinica_autorizada INTEGER NOT NULL,
                        tipo_exame INTEGER NOT NULL,
                        status_exame INTEGER NOT NULL,
                        data_realizacao TEXT NOT NULL,
                        horario_realizacao TEXT NOT NULL,
	                    status_aso INTEGER NOT NULL, 
	                    caminho_arquivo_aso TEXT NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL,
                        FOREIGN KEY (id_colaborador) REFERENCES colaborador(id_colaborador),
                        FOREIGN KEY (id_clinica_autorizada) REFERENCES clinica_autorizada(id_clinica_autorizada)
                    );")

                comandos.AppendLine("
                    CREATE TABLE IF NOT EXISTS unidade_senac (
                        id_unidade_senac INTEGER PRIMARY KEY AUTOINCREMENT,
                        codigo_unidade TEXT NOT NULL,
                        nome_unidade TEXT NOT NULL,
                        logradouro TEXT NOT NULL,
                        numero TEXT NOT NULL,
                        bairro TEXT NOT NULL,
                        cidade TEXT NOT NULL,
                        estado TEXT NOT NULL,
                        cep TEXT NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL
                    );")

                comandos.AppendLine("
                    CREATE TABLE IF NOT EXISTS documento_colaborador (
                        id_documento_colaborador INTEGER PRIMARY KEY AUTOINCREMENT,
                        id_colaborador INTEGER NOT NULL,
                        nome_documento TEXT NOT NULL,
                        caminho_arquivo TEXT NOT NULL,
                        status_documento INTEGER NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL,
                        FOREIGN KEY (id_colaborador) REFERENCES colaborador(id_colaborador)
                    );")

                comandos.AppendLine("
                    CREATE TABLE IF NOT EXISTS documento_modelo (
                        id_documento_modelo INTEGER PRIMARY KEY AUTOINCREMENT,
                        tipo_contrato INTEGER NOT NULL,
                        modalidade_contrato INTEGER NOT NULL,
                        nome_documento TEXT NOT NULL,
                        caminho_arquivo TEXT NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL
                    );")

                Using cmd As New SQLiteCommand(comandos.ToString(), conn)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception

            Console.WriteLine("Erro ao criar tabelas: " & ex.Message)

        End Try

    End Sub

    Private Sub CriarIndices()

        Try

            Using conn As New SQLiteConnection(CadeiaDeConexao)

                conn.Open()

                Dim comandos As New Text.StringBuilder()

                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_carta_agencia ON carta_de_abertura_de_conta_salario(id_agencia_caixa);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_carta_colaborador ON carta_de_abertura_de_conta_salario(id_colaborador);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_colaborador_chapa ON colaborador(chapa);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_colaborador_cpf ON colaborador(cpf);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_colaborador_data_admissao ON colaborador(data_de_admissao);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_colaborador_data_demissao ON colaborador(data_de_demissao);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_colaborador_email ON colaborador(email_corporativo);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_colaborador_status ON colaborador(status);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_exame_clinica ON exame_medico(id_clinica_autorizada);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_exame_colaborador ON exame_medico(id_colaborador);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_exame_data_realizacao ON exame_medico(data_realizacao);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_agencia_status ON agencia_caixa(status);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_carta_unidade ON carta_de_abertura_de_conta_salario(id_unidade_senac);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_carta_status_arquivo ON carta_de_abertura_de_conta_salario(status_arquivo);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_termo_colaborador ON termo_ciencia_de_homologacao(id_colaborador);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_termo_exame ON termo_ciencia_de_homologacao(id_exame);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_termo_unidade ON termo_ciencia_de_homologacao(id_unidade_senac);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_termo_status_arquivo ON termo_ciencia_de_homologacao(status_arquivo);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_termo_fins_colaborador ON termo_fins_rescisorios(id_colaborador);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_termo_fins_termo_ciencia ON termo_fins_rescisorios(id_termo_ciencia_de_homologacao);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_termo_fins_unidade ON termo_fins_rescisorios(id_unidade_senac);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_termo_fins_status_arquivo ON termo_fins_rescisorios(status_arquivo);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_clinica_status ON clinica_autorizada(status);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_exame_status ON exame_medico(status_exame);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_exame_status_aso ON exame_medico(status_aso);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_unidade_codigo ON unidade_senac(codigo_unidade);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_unidade_status ON unidade_senac(status);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_doc_colaborador_colaborador ON documento_colaborador(id_colaborador);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_colaborador_id ON documento_colaborador(id_colaborador);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_doc_colaborador_status ON documento_colaborador(status_documento);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_doc_modelo_tipo_modalidade ON documento_modelo(tipo_contrato, modalidade_contrato);")

                Using cmd As New SQLiteCommand(comandos.ToString(), conn)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception

            Console.WriteLine("Erro ao criar índices: " & ex.Message)

        End Try

    End Sub

    Private Sub CriarGatilhos()

        Try
            Using conn As New SQLiteConnection(CadeiaDeConexao)

                conn.Open()

                Dim comandos As New Text.StringBuilder()

                comandos.AppendLine(String.Format("
                    CREATE TRIGGER IF NOT EXISTS trg_atualizar_dependentes_colaborador
                    AFTER UPDATE ON colaborador
                    FOR EACH ROW
                    WHEN NEW.status IN (0, 1)
                    BEGIN
                        UPDATE documento_colaborador SET status = NEW.status WHERE id_colaborador = NEW.id_colaborador;
                        UPDATE exame_medico SET status = NEW.status WHERE id_colaborador = NEW.id_colaborador;
                        UPDATE carta_de_abertura_de_conta_salario SET status = NEW.status WHERE id_colaborador = NEW.id_colaborador;
                        UPDATE termo_ciencia_de_homologacao SET status = NEW.status WHERE id_colaborador = NEW.id_colaborador;
                        UPDATE termo_fins_rescisorios SET status = NEW.status WHERE id_colaborador = NEW.id_colaborador;
                    END;
                "))

                comandos.AppendLine(String.Format("
                    CREATE TRIGGER IF NOT EXISTS trg_atualizar_dependentes_clinica
                    AFTER UPDATE ON clinica_autorizada
                    FOR EACH ROW
                    WHEN NEW.status IN (0, 1)
                    BEGIN
                        UPDATE exame_medico SET status = NEW.status WHERE id_clinica_autorizada = NEW.id_clinica_autorizada;
                    END;
                "))

                comandos.AppendLine(String.Format("
                    CREATE TRIGGER IF NOT EXISTS trg_atualizar_dependentes_agencia_caixa
                    AFTER UPDATE ON agencia_caixa
                    FOR EACH ROW
                    WHEN NEW.status IN (0, 1)
                    BEGIN
                        UPDATE carta_de_abertura_de_conta_salario SET status = NEW.status WHERE id_agencia_caixa = NEW.id_agencia_caixa;
                    END;
                "))

                comandos.AppendLine(String.Format("
                    CREATE TRIGGER IF NOT EXISTS trg_atualizar_dependentes_unidade_senac
                    AFTER UPDATE ON unidade_senac
                    FOR EACH ROW
                    WHEN NEW.status IN (0, 1)
                    BEGIN
                        UPDATE carta_de_abertura_de_conta_salario SET status = NEW.status WHERE id_unidade_senac = NEW.id_unidade_senac;
                        UPDATE termo_ciencia_de_homologacao SET status = NEW.status WHERE id_unidade_senac = NEW.id_unidade_senac;
                        UPDATE termo_fins_rescisorios SET status = NEW.status WHERE id_unidade_senac = NEW.id_unidade_senac;
                    END;
                "))

                comandos.AppendLine(String.Format("
                    CREATE TRIGGER IF NOT EXISTS trg_atualizar_dependentes_termo_ciencia
                    AFTER UPDATE ON termo_ciencia_de_homologacao
                    FOR EACH ROW
                    WHEN NEW.status IN (0, 1)
                    BEGIN
                        UPDATE termo_fins_rescisorios SET status = NEW.status WHERE id_termo_ciencia_de_homologacao = NEW.id_termo_ciencia_de_homologacao;
                    END;
                "))

                Using cmd As New SQLiteCommand(comandos.ToString(), conn)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception

            Console.WriteLine("Erro ao criar gatilhos: " & ex.Message)

        End Try

    End Sub

    Private Sub CriarVistas()

        Try

            Using conn As New SQLiteConnection(CadeiaDeConexao)

                conn.Open()

                Dim comandos As New Text.StringBuilder()

                comandos.AppendLine("
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_ativos AS
                    SELECT
                        id_colaborador AS id,
                        nome_completo,
                        chapa,
                        funcao,
                        tipo_contrato,
                        modalidade_contrato,
                        uid_usuario_logado
                    FROM colaborador
                    WHERE status = 1;
                ")

                comandos.AppendLine("
                    CREATE VIEW IF NOT EXISTS vw_unidades_senac_ativas AS
                    SELECT 
                        id_unidade_senac,
                        codigo_unidade,
                        nome_unidade,
                        uid_usuario_logado,
                        estado,
                        cep
                    FROM unidade_senac
                    WHERE status = 1;
                ")

                Using cmd As New SQLiteCommand(comandos.ToString(), conn)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

        Catch ex As Exception

            Console.WriteLine("Erro ao criar vistas: " & ex.Message)

        End Try

    End Sub

#End Region

End Module
