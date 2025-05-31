Imports System.Data.SQLite
Imports System.IO

Module Md_SQLite_FuncoesPrincipais

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
                        id_endereco INTEGER NOT NULL,
                        codigo_agencia TEXT NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL,
                        FOREIGN KEY (id_endereco) REFERENCES endereco(id_endereco)
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
                        id_endereco INTEGER NOT NULL,
                        nome_clinica TEXT NOT NULL,
                        email_atendimento TEXT NOT NULL,
                        nome_atendente TEXT NOT NULL,
                        telefone TEXT NOT NULL,
                        fixo TEXT,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL,
                        FOREIGN KEY (id_endereco) REFERENCES endereco(id_endereco)
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
                    CREATE TABLE IF NOT EXISTS endereco (
                        id_endereco INTEGER PRIMARY KEY AUTOINCREMENT,
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
                    CREATE TABLE IF NOT EXISTS exame_medico (
                        id_exame INTEGER PRIMARY KEY AUTOINCREMENT,
                        id_colaborador INTEGER NOT NULL,
                        id_clinica_autorizada INTEGER NOT NULL,
                        tipo_exame INTEGER NOT NULL,
                        status_exame INTEGER NOT NULL,
                        data_realizacao TEXT NOT NULL,
                        horario_realizacao TIME NOT NULL,
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
                        id_endereco INTEGER NOT NULL,
                        codigo_unidade TEXT NOT NULL,
                        nome_unidade TEXT NOT NULL,
                        uid_usuario_logado TEXT NOT NULL,
                        status INTEGER NOT NULL,
                        FOREIGN KEY (id_endereco) REFERENCES endereco(id_endereco)
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
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_clinica_id_endereco ON clinica_autorizada(id_endereco);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_agencia_endereco ON agencia_caixa(id_endereco);")
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
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_unidade_endereco ON unidade_senac(id_endereco);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_unidade_codigo ON unidade_senac(codigo_unidade);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_unidade_status ON unidade_senac(status);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_doc_colaborador_colaborador ON documento_colaborador(id_colaborador);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_colaborador_id ON documento_colaborador(id_colaborador);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_doc_colaborador_status ON documento_colaborador(status_documento);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_doc_modelo_tipo_modalidade ON documento_modelo(tipo_contrato, modalidade_contrato);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_endereco_cep ON endereco(cep);")
                comandos.AppendLine("CREATE INDEX IF NOT EXISTS idx_endereco_cidade ON endereco(cidade);")

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
                    CREATE TRIGGER IF NOT EXISTS trg_inativar_endereco_clinica
                    AFTER UPDATE OF status ON clinica_autorizada
                    FOR EACH ROW
                    WHEN NEW.status = {0}
                    BEGIN
                        UPDATE endereco
                        SET status = {0}
                        WHERE id_endereco = OLD.id_endereco;
                    END;", StatusCadastro.INATIVO))

                comandos.AppendLine(String.Format("
                    CREATE TRIGGER IF NOT EXISTS trg_reativar_endereco_clinica
                    AFTER UPDATE OF status ON clinica_autorizada
                    FOR EACH ROW
                    WHEN NEW.status = {0}
                    BEGIN
                        UPDATE endereco
                        SET status = {0}
                        WHERE id_endereco = OLD.id_endereco;
                    END;", StatusCadastro.ATIVO))

                comandos.AppendLine(String.Format("
                    CREATE TRIGGER IF NOT EXISTS trg_inativar_endereco_agencia
                    AFTER UPDATE OF status ON agencia_caixa
                    FOR EACH ROW
                    WHEN NEW.status = {0}
                    BEGIN
                        UPDATE endereco
                        SET status = {0}
                        WHERE id_endereco = OLD.id_endereco;
                    END;", StatusCadastro.INATIVO))

                comandos.AppendLine(String.Format("
                    CREATE TRIGGER IF NOT EXISTS trg_reativar_endereco_agencia
                    AFTER UPDATE OF status ON agencia_caixa
                    FOR EACH ROW
                    WHEN NEW.status = {0}
                    BEGIN
                        UPDATE endereco
                        SET status = {0}
                        WHERE id_endereco = OLD.id_endereco;
                    END;", StatusCadastro.ATIVO))

                comandos.AppendLine(String.Format("
                    CREATE TRIGGER IF NOT EXISTS trg_inativar_endereco_unidade
                    AFTER UPDATE OF status ON unidade_senac
                    FOR EACH ROW
                    WHEN NEW.status = {0}
                    BEGIN
                        UPDATE endereco
                        SET status = {0}
                        WHERE id_endereco = OLD.id_endereco;
                    END;", StatusCadastro.INATIVO))

                comandos.AppendLine(String.Format("
                    CREATE TRIGGER IF NOT EXISTS trg_reativar_endereco_unidade
                    AFTER UPDATE OF status ON unidade_senac
                    FOR EACH ROW
                    WHEN NEW.status = {0}
                    BEGIN
                        UPDATE endereco
                        SET status = {0}
                        WHERE id_endereco = OLD.id_endereco;
                    END;", StatusCadastro.ATIVO))

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

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_agencias_ativas AS
                        SELECT 
                            a.id_agencia_caixa,
                            a.codigo_agencia,
                            e.logradouro || ', ' || e.numero || ', ' || e.bairro || ' - ' || e.cidade || '/' || e.estado AS local
                        FROM 
                            agencia_caixa a
                        JOIN 
                            endereco e ON a.id_endereco = e.id_endereco
                        WHERE 
                            a.status = {0}
                            AND e.status = {0};
                    ", StatusCadastro.ATIVO))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_unidades_senac_ativas AS
                        SELECT 
                            u.id_unidade_senac,
                            u.codigo_unidade,
                            u.nome_unidade,
                            e.cidade
                        FROM 
                            unidade_senac u
                        JOIN 
                            endereco e ON u.id_endereco = e.id_endereco
                        WHERE 
                            u.status = {0}
                            AND e.status = {0};
                        ", StatusCadastro.ATIVO))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_clinicas_autorizadas_ativas AS
                        SELECT 
                            c.id_clinica_autorizada,
                            c.nome_clinica,
                            c.fixo,
                            c.telefone,
                            e.cidade
                        FROM 
                            clinica_autorizada c
                        JOIN 
                            endereco e ON c.id_endereco = e.id_endereco
                        WHERE 
                            c.status = {0}
                            AND e.status = {0};
                    ", StatusCadastro.ATIVO))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_ativos AS
                        SELECT 
                            c.id_colaborador,
                            c.chapa,
                            c.nome_completo,
                            c.email_corporativo
                        FROM 
                            colaborador c
                        WHERE 
                            c.status = {0};
                    ", StatusCadastro.ATIVO))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_ativos_em_admissao AS
                        SELECT 
                            c.id_colaborador,
                            c.chapa,
                            c.nome_completo,
                            c.email_corporativo
                        FROM 
                            colaborador c
                        WHERE 
                            c.status = {0}
                            AND c.status_contrato = {1};
                    ", StatusCadastro.ATIVO, StatusContrato.EM_ADMISSAO))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_ativos_admitido AS
                        SELECT 
                            c.id_colaborador,
                            c.chapa,
                            c.nome_completo,
                            c.email_corporativo
                        FROM 
                            colaborador c
                        WHERE 
                            c.status = {0}
                            AND c.status_contrato = {1};
                    ", StatusCadastro.ATIVO, StatusContrato.ADMITIDO))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_ativos_em_rescisao AS
                        SELECT 
                            c.id_colaborador,
                            c.chapa,
                            c.nome_completo,
                            c.email_corporativo
                        FROM 
                            colaborador c
                        WHERE 
                            c.status = {0}
                            AND c.status_contrato = {1};
                    ", StatusCadastro.ATIVO, StatusContrato.EM_RESCISAO))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_horista_intermitente AS
                        SELECT c.id_colaborador, c.chapa, c.nome_completo
                        FROM colaborador c
                        WHERE 
                            c.status = {0}
                            AND c.tipo_contrato = {1}
                            AND c.modalidade_contrato = {2};
                    ", StatusCadastro.ATIVO, TipoContrato.HORISTA, ModalidadeContrato.INTERMITENTE))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_horista_instrutor_de_formacao_profissional AS
                        SELECT c.id_colaborador, c.chapa, c.nome_completo
                        FROM colaborador c
                        WHERE 
                            c.status = {0}
                            AND c.tipo_contrato = {1}
                            AND c.modalidade_contrato = {2};
                    ", StatusCadastro.ATIVO, TipoContrato.HORISTA, ModalidadeContrato.INSTRUTOR_DE_FORMACAO_PROFISSIONAL))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_mensalista_administrativo AS
                        SELECT c.id_colaborador, c.chapa, c.nome_completo
                        FROM colaborador c
                        WHERE 
                            c.status = {0}
                            AND c.tipo_contrato = {1}
                            AND c.modalidade_contrato = {2};
                    ", StatusCadastro.ATIVO, TipoContrato.MENSALISTA, ModalidadeContrato.ADMINISTRATIVO))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_mensalista_instrutor_de_formacao_profissional AS
                        SELECT c.id_colaborador, c.chapa, c.nome_completo
                        FROM colaborador c
                        WHERE 
                            c.status = {0}
                            AND c.tipo_contrato = {1}
                            AND c.modalidade_contrato = {2};
                    ", StatusCadastro.ATIVO, TipoContrato.MENSALISTA, ModalidadeContrato.INSTRUTOR_DE_FORMACAO_PROFISSIONAL))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_colaboradores_mensalista_prazo_determinado AS
                        SELECT c.id_colaborador, c.chapa, c.nome_completo
                        FROM colaborador c
                        WHERE 
                            c.status = {0}
                            AND c.tipo_contrato = {1}
                            AND c.modalidade_contrato = {2};
                    ", StatusCadastro.ATIVO, TipoContrato.MENSALISTA, ModalidadeContrato.PRAZO_DETERMINADO))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_exames AS
                        SELECT 
                            ca.id_clinica_autorizada, 
                            ca.nome_clinica, 
                            e.cidade, 
                            em.data_realizacao, 
                            em.horario_realizacao
                        FROM 
                            exame_medico em
                        JOIN 
                            clinica_autorizada ca ON em.id_clinica_autorizada = ca.id_clinica_autorizada
                        JOIN 
                            colaborador c ON em.id_colaborador = c.id_colaborador
                        JOIN 
                            endereco e ON ca.id_endereco = e.id_endereco
                        WHERE 
                            c.status = {0};
                    ", StatusCadastro.ATIVO))

                comandos.AppendLine(String.Format("
                    CREATE VIEW IF NOT EXISTS vw_carta_abertura_conta_salario AS
                        SELECT
                            c.id_carta,
                            co.nome_completo,
                            co.data_de_admissao,
                            us.codigo_unidade,
                            ac.codigo_agencia
                        FROM
                            carta_de_abertura_de_conta_salario c
                        JOIN colaborador co ON c.id_colaborador = co.id_colaborador
                        JOIN unidade_senac us ON co.id_unidade_senac = us.id_unidade_senac
                        JOIN agencia_caixa ac ON c.id_agencia_caixa = ac.id_agencia_caixa
                        WHERE
                            co.status = {0}
                            AND us.status = {0}
                            AND c.status = {0};
                    ", StatusCadastro.ATIVO))

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
