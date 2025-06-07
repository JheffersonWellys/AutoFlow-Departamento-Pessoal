<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm__Cadastro__Colaboradores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm__Cadastro__Colaboradores))
        Me.MnStrp_MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.TlStrpMnItm_MenuAcoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlStrpMnItm_Acoes_Adicionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlStrpMnItm_Acoes_Editar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlStrpMnItm_Acoes_Remover = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlStrpSprtr_Acoes_1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlStrpMnItm_Acoes_Visualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pnl_Informacoes = New System.Windows.Forms.Panel()
        Me.SttsStrp_InformacoesSobreATabela = New System.Windows.Forms.StatusStrip()
        Me.TlStrpSttsLbl_TotalDeColaboradoresCadastrados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TlStrpSttsLbl_NumeroTotalDeColaboradores = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Pnl_Dados = New System.Windows.Forms.Panel()
        Me.TbCntrl_Dados = New System.Windows.Forms.TabControl()
        Me.TbPg_InformacoesPessoais = New System.Windows.Forms.TabPage()
        Me.MskdTxtBx_TelefonePessoal = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_TelefonePessoal = New System.Windows.Forms.Label()
        Me.TxtBx_EmailPessoal = New System.Windows.Forms.TextBox()
        Me.TxtBx_RG = New System.Windows.Forms.TextBox()
        Me.TxtBx_NomeSocial = New System.Windows.Forms.TextBox()
        Me.TxtBx_NomeCompleto = New System.Windows.Forms.TextBox()
        Me.Lbl_EmailPessoal = New System.Windows.Forms.Label()
        Me.DtTmPckr_DataDeNascimento = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DataDeNascimento = New System.Windows.Forms.Label()
        Me.Lbl_RG = New System.Windows.Forms.Label()
        Me.MskdTxtBx_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_CPF = New System.Windows.Forms.Label()
        Me.CmbBx_Sexo = New System.Windows.Forms.ComboBox()
        Me.Lbl_Sexo = New System.Windows.Forms.Label()
        Me.Lbl_NomeSocial = New System.Windows.Forms.Label()
        Me.Lbl_NomeCompleto = New System.Windows.Forms.Label()
        Me.TbPg_InformacoesCorporativas = New System.Windows.Forms.TabPage()
        Me.CmbBx_ModalidadeContrato = New System.Windows.Forms.ComboBox()
        Me.Lbl_ModalidadeContrato = New System.Windows.Forms.Label()
        Me.CmbBx_TipoContrato = New System.Windows.Forms.ComboBox()
        Me.Lbl_TipoContrato = New System.Windows.Forms.Label()
        Me.DtTmPckr_DataDeDemissao = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DataDeDemissao = New System.Windows.Forms.Label()
        Me.DtTmPckr_DataDeAdmissao = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DataDeAdmissao = New System.Windows.Forms.Label()
        Me.TxtBx_Setor = New System.Windows.Forms.TextBox()
        Me.TxtBx_Funcao = New System.Windows.Forms.TextBox()
        Me.TxtBx_EmailCorporativo = New System.Windows.Forms.TextBox()
        Me.Lbl_Setor = New System.Windows.Forms.Label()
        Me.Lbl_Funcao = New System.Windows.Forms.Label()
        Me.MskdTxtBx_Chapa = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_Chapa = New System.Windows.Forms.Label()
        Me.Lbl_EmailCorporativo = New System.Windows.Forms.Label()
        Me.Pnl_BotoesDeAcao = New System.Windows.Forms.Panel()
        Me.Bttn_Excluir = New System.Windows.Forms.Button()
        Me.Bttn_Limpar = New System.Windows.Forms.Button()
        Me.Bttn_Atualizar = New System.Windows.Forms.Button()
        Me.Bttn_Adicionar = New System.Windows.Forms.Button()
        Me.Bttn_Cancelar = New System.Windows.Forms.Button()
        Me.MnStrp_MenuPrincipal.SuspendLayout()
        Me.Pnl_Informacoes.SuspendLayout()
        Me.SttsStrp_InformacoesSobreATabela.SuspendLayout()
        Me.Pnl_Dados.SuspendLayout()
        Me.TbCntrl_Dados.SuspendLayout()
        Me.TbPg_InformacoesPessoais.SuspendLayout()
        Me.TbPg_InformacoesCorporativas.SuspendLayout()
        Me.Pnl_BotoesDeAcao.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnStrp_MenuPrincipal
        '
        Me.MnStrp_MenuPrincipal.BackColor = System.Drawing.Color.White
        Me.MnStrp_MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpMnItm_MenuAcoes})
        Me.MnStrp_MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MnStrp_MenuPrincipal.Name = "MnStrp_MenuPrincipal"
        Me.MnStrp_MenuPrincipal.Size = New System.Drawing.Size(693, 30)
        Me.MnStrp_MenuPrincipal.TabIndex = 0
        Me.MnStrp_MenuPrincipal.Text = "MnStrp_MenuAcoes"
        '
        'TlStrpMnItm_MenuAcoes
        '
        Me.TlStrpMnItm_MenuAcoes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpMnItm_Acoes_Adicionar, Me.TlStrpMnItm_Acoes_Editar, Me.TlStrpMnItm_Acoes_Remover, Me.TlStrpSprtr_Acoes_1, Me.TlStrpMnItm_Acoes_Visualizar})
        Me.TlStrpMnItm_MenuAcoes.Image = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.icn_Menu
        Me.TlStrpMnItm_MenuAcoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlStrpMnItm_MenuAcoes.Name = "TlStrpMnItm_MenuAcoes"
        Me.TlStrpMnItm_MenuAcoes.Size = New System.Drawing.Size(73, 26)
        Me.TlStrpMnItm_MenuAcoes.Text = "Ações"
        '
        'TlStrpMnItm_Acoes_Adicionar
        '
        Me.TlStrpMnItm_Acoes_Adicionar.Image = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.icn_Adicionar
        Me.TlStrpMnItm_Acoes_Adicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlStrpMnItm_Acoes_Adicionar.Name = "TlStrpMnItm_Acoes_Adicionar"
        Me.TlStrpMnItm_Acoes_Adicionar.Size = New System.Drawing.Size(131, 28)
        Me.TlStrpMnItm_Acoes_Adicionar.Text = "Adicionar"
        '
        'TlStrpMnItm_Acoes_Editar
        '
        Me.TlStrpMnItm_Acoes_Editar.Image = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.icn_Editar
        Me.TlStrpMnItm_Acoes_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlStrpMnItm_Acoes_Editar.Name = "TlStrpMnItm_Acoes_Editar"
        Me.TlStrpMnItm_Acoes_Editar.Size = New System.Drawing.Size(131, 28)
        Me.TlStrpMnItm_Acoes_Editar.Text = "Editar"
        '
        'TlStrpMnItm_Acoes_Remover
        '
        Me.TlStrpMnItm_Acoes_Remover.Image = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.icn_Remover
        Me.TlStrpMnItm_Acoes_Remover.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlStrpMnItm_Acoes_Remover.Name = "TlStrpMnItm_Acoes_Remover"
        Me.TlStrpMnItm_Acoes_Remover.Size = New System.Drawing.Size(131, 28)
        Me.TlStrpMnItm_Acoes_Remover.Text = "Remover"
        '
        'TlStrpSprtr_Acoes_1
        '
        Me.TlStrpSprtr_Acoes_1.Name = "TlStrpSprtr_Acoes_1"
        Me.TlStrpSprtr_Acoes_1.Size = New System.Drawing.Size(128, 6)
        '
        'TlStrpMnItm_Acoes_Visualizar
        '
        Me.TlStrpMnItm_Acoes_Visualizar.Image = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.icn_Visualizar
        Me.TlStrpMnItm_Acoes_Visualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlStrpMnItm_Acoes_Visualizar.Name = "TlStrpMnItm_Acoes_Visualizar"
        Me.TlStrpMnItm_Acoes_Visualizar.Size = New System.Drawing.Size(131, 28)
        Me.TlStrpMnItm_Acoes_Visualizar.Text = "Visualizar"
        '
        'Pnl_Informacoes
        '
        Me.Pnl_Informacoes.Controls.Add(Me.SttsStrp_InformacoesSobreATabela)
        Me.Pnl_Informacoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_Informacoes.Location = New System.Drawing.Point(0, 309)
        Me.Pnl_Informacoes.Name = "Pnl_Informacoes"
        Me.Pnl_Informacoes.Padding = New System.Windows.Forms.Padding(10)
        Me.Pnl_Informacoes.Size = New System.Drawing.Size(693, 40)
        Me.Pnl_Informacoes.TabIndex = 2
        '
        'SttsStrp_InformacoesSobreATabela
        '
        Me.SttsStrp_InformacoesSobreATabela.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpSttsLbl_TotalDeColaboradoresCadastrados, Me.TlStrpSttsLbl_NumeroTotalDeColaboradores})
        Me.SttsStrp_InformacoesSobreATabela.Location = New System.Drawing.Point(10, 8)
        Me.SttsStrp_InformacoesSobreATabela.Name = "SttsStrp_InformacoesSobreATabela"
        Me.SttsStrp_InformacoesSobreATabela.Size = New System.Drawing.Size(673, 22)
        Me.SttsStrp_InformacoesSobreATabela.TabIndex = 0
        Me.SttsStrp_InformacoesSobreATabela.Text = "StatusStrip1"
        '
        'TlStrpSttsLbl_TotalDeColaboradoresCadastrados
        '
        Me.TlStrpSttsLbl_TotalDeColaboradoresCadastrados.BackColor = System.Drawing.Color.Transparent
        Me.TlStrpSttsLbl_TotalDeColaboradoresCadastrados.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TlStrpSttsLbl_TotalDeColaboradoresCadastrados.Name = "TlStrpSttsLbl_TotalDeColaboradoresCadastrados"
        Me.TlStrpSttsLbl_TotalDeColaboradoresCadastrados.Size = New System.Drawing.Size(203, 17)
        Me.TlStrpSttsLbl_TotalDeColaboradoresCadastrados.Text = "Total de Colaboradores Cadastrados: "
        '
        'TlStrpSttsLbl_NumeroTotalDeColaboradores
        '
        Me.TlStrpSttsLbl_NumeroTotalDeColaboradores.BackColor = System.Drawing.Color.Transparent
        Me.TlStrpSttsLbl_NumeroTotalDeColaboradores.Name = "TlStrpSttsLbl_NumeroTotalDeColaboradores"
        Me.TlStrpSttsLbl_NumeroTotalDeColaboradores.Size = New System.Drawing.Size(13, 17)
        Me.TlStrpSttsLbl_NumeroTotalDeColaboradores.Text = "0"
        '
        'Pnl_Dados
        '
        Me.Pnl_Dados.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Pnl_Dados.Controls.Add(Me.TbCntrl_Dados)
        Me.Pnl_Dados.Controls.Add(Me.Pnl_BotoesDeAcao)
        Me.Pnl_Dados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Dados.Location = New System.Drawing.Point(0, 30)
        Me.Pnl_Dados.Name = "Pnl_Dados"
        Me.Pnl_Dados.Padding = New System.Windows.Forms.Padding(20, 20, 20, 10)
        Me.Pnl_Dados.Size = New System.Drawing.Size(693, 279)
        Me.Pnl_Dados.TabIndex = 1
        Me.Pnl_Dados.Visible = False
        '
        'TbCntrl_Dados
        '
        Me.TbCntrl_Dados.Controls.Add(Me.TbPg_InformacoesPessoais)
        Me.TbCntrl_Dados.Controls.Add(Me.TbPg_InformacoesCorporativas)
        Me.TbCntrl_Dados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbCntrl_Dados.Location = New System.Drawing.Point(20, 20)
        Me.TbCntrl_Dados.Name = "TbCntrl_Dados"
        Me.TbCntrl_Dados.SelectedIndex = 0
        Me.TbCntrl_Dados.Size = New System.Drawing.Size(653, 204)
        Me.TbCntrl_Dados.TabIndex = 0
        '
        'TbPg_InformacoesPessoais
        '
        Me.TbPg_InformacoesPessoais.BackColor = System.Drawing.Color.White
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.MskdTxtBx_TelefonePessoal)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.Lbl_TelefonePessoal)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.TxtBx_EmailPessoal)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.TxtBx_RG)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.TxtBx_NomeSocial)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.TxtBx_NomeCompleto)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.Lbl_EmailPessoal)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.DtTmPckr_DataDeNascimento)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.Lbl_DataDeNascimento)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.Lbl_RG)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.MskdTxtBx_CPF)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.Lbl_CPF)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.CmbBx_Sexo)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.Lbl_Sexo)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.Lbl_NomeSocial)
        Me.TbPg_InformacoesPessoais.Controls.Add(Me.Lbl_NomeCompleto)
        Me.TbPg_InformacoesPessoais.Location = New System.Drawing.Point(4, 22)
        Me.TbPg_InformacoesPessoais.Name = "TbPg_InformacoesPessoais"
        Me.TbPg_InformacoesPessoais.Padding = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.TbPg_InformacoesPessoais.Size = New System.Drawing.Size(645, 178)
        Me.TbPg_InformacoesPessoais.TabIndex = 3
        Me.TbPg_InformacoesPessoais.Text = "Informações Pessoais"
        '
        'MskdTxtBx_TelefonePessoal
        '
        Me.MskdTxtBx_TelefonePessoal.Location = New System.Drawing.Point(514, 104)
        Me.MskdTxtBx_TelefonePessoal.Mask = "(##) # ####-####"
        Me.MskdTxtBx_TelefonePessoal.Name = "MskdTxtBx_TelefonePessoal"
        Me.MskdTxtBx_TelefonePessoal.Size = New System.Drawing.Size(120, 20)
        Me.MskdTxtBx_TelefonePessoal.TabIndex = 15
        Me.MskdTxtBx_TelefonePessoal.Tag = "Telefone Pessoal"
        '
        'Lbl_TelefonePessoal
        '
        Me.Lbl_TelefonePessoal.AutoSize = True
        Me.Lbl_TelefonePessoal.Location = New System.Drawing.Point(511, 88)
        Me.Lbl_TelefonePessoal.Name = "Lbl_TelefonePessoal"
        Me.Lbl_TelefonePessoal.Size = New System.Drawing.Size(89, 13)
        Me.Lbl_TelefonePessoal.TabIndex = 14
        Me.Lbl_TelefonePessoal.Text = "Telefone Pessoal"
        '
        'TxtBx_EmailPessoal
        '
        Me.TxtBx_EmailPessoal.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBx_EmailPessoal.Location = New System.Drawing.Point(11, 104)
        Me.TxtBx_EmailPessoal.Name = "TxtBx_EmailPessoal"
        Me.TxtBx_EmailPessoal.Size = New System.Drawing.Size(497, 20)
        Me.TxtBx_EmailPessoal.TabIndex = 13
        Me.TxtBx_EmailPessoal.Tag = "E-mail Pessoal"
        '
        'TxtBx_RG
        '
        Me.TxtBx_RG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBx_RG.Location = New System.Drawing.Point(514, 65)
        Me.TxtBx_RG.Name = "TxtBx_RG"
        Me.TxtBx_RG.Size = New System.Drawing.Size(120, 20)
        Me.TxtBx_RG.TabIndex = 11
        Me.TxtBx_RG.Tag = "RG"
        '
        'TxtBx_NomeSocial
        '
        Me.TxtBx_NomeSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBx_NomeSocial.Location = New System.Drawing.Point(11, 65)
        Me.TxtBx_NomeSocial.Name = "TxtBx_NomeSocial"
        Me.TxtBx_NomeSocial.Size = New System.Drawing.Size(371, 20)
        Me.TxtBx_NomeSocial.TabIndex = 7
        Me.TxtBx_NomeSocial.Tag = "Nome Social"
        '
        'TxtBx_NomeCompleto
        '
        Me.TxtBx_NomeCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBx_NomeCompleto.Location = New System.Drawing.Point(11, 26)
        Me.TxtBx_NomeCompleto.Name = "TxtBx_NomeCompleto"
        Me.TxtBx_NomeCompleto.Size = New System.Drawing.Size(371, 20)
        Me.TxtBx_NomeCompleto.TabIndex = 1
        Me.TxtBx_NomeCompleto.Tag = "Nome Completo"
        '
        'Lbl_EmailPessoal
        '
        Me.Lbl_EmailPessoal.AutoSize = True
        Me.Lbl_EmailPessoal.Location = New System.Drawing.Point(8, 88)
        Me.Lbl_EmailPessoal.Name = "Lbl_EmailPessoal"
        Me.Lbl_EmailPessoal.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_EmailPessoal.TabIndex = 12
        Me.Lbl_EmailPessoal.Text = "E-mail Pessoal"
        '
        'DtTmPckr_DataDeNascimento
        '
        Me.DtTmPckr_DataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTmPckr_DataDeNascimento.Location = New System.Drawing.Point(514, 25)
        Me.DtTmPckr_DataDeNascimento.Name = "DtTmPckr_DataDeNascimento"
        Me.DtTmPckr_DataDeNascimento.Size = New System.Drawing.Size(120, 20)
        Me.DtTmPckr_DataDeNascimento.TabIndex = 5
        Me.DtTmPckr_DataDeNascimento.Tag = "Data de Nascimento"
        '
        'Lbl_DataDeNascimento
        '
        Me.Lbl_DataDeNascimento.AutoSize = True
        Me.Lbl_DataDeNascimento.Location = New System.Drawing.Point(511, 9)
        Me.Lbl_DataDeNascimento.Name = "Lbl_DataDeNascimento"
        Me.Lbl_DataDeNascimento.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_DataDeNascimento.TabIndex = 4
        Me.Lbl_DataDeNascimento.Tag = ""
        Me.Lbl_DataDeNascimento.Text = "Data de Nascimento"
        '
        'Lbl_RG
        '
        Me.Lbl_RG.AutoSize = True
        Me.Lbl_RG.Location = New System.Drawing.Point(511, 49)
        Me.Lbl_RG.Name = "Lbl_RG"
        Me.Lbl_RG.Size = New System.Drawing.Size(23, 13)
        Me.Lbl_RG.TabIndex = 10
        Me.Lbl_RG.Text = "RG"
        '
        'MskdTxtBx_CPF
        '
        Me.MskdTxtBx_CPF.Location = New System.Drawing.Point(388, 65)
        Me.MskdTxtBx_CPF.Mask = "###,###,###-##"
        Me.MskdTxtBx_CPF.Name = "MskdTxtBx_CPF"
        Me.MskdTxtBx_CPF.Size = New System.Drawing.Size(120, 20)
        Me.MskdTxtBx_CPF.TabIndex = 9
        Me.MskdTxtBx_CPF.Tag = "CPF"
        '
        'Lbl_CPF
        '
        Me.Lbl_CPF.AutoSize = True
        Me.Lbl_CPF.Location = New System.Drawing.Point(385, 49)
        Me.Lbl_CPF.Name = "Lbl_CPF"
        Me.Lbl_CPF.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_CPF.TabIndex = 8
        Me.Lbl_CPF.Text = "CPF"
        '
        'CmbBx_Sexo
        '
        Me.CmbBx_Sexo.BackColor = System.Drawing.SystemColors.Window
        Me.CmbBx_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBx_Sexo.FormattingEnabled = True
        Me.CmbBx_Sexo.Location = New System.Drawing.Point(388, 25)
        Me.CmbBx_Sexo.Name = "CmbBx_Sexo"
        Me.CmbBx_Sexo.Size = New System.Drawing.Size(120, 21)
        Me.CmbBx_Sexo.TabIndex = 3
        Me.CmbBx_Sexo.Tag = "Sexo"
        '
        'Lbl_Sexo
        '
        Me.Lbl_Sexo.AutoSize = True
        Me.Lbl_Sexo.Location = New System.Drawing.Point(385, 9)
        Me.Lbl_Sexo.Name = "Lbl_Sexo"
        Me.Lbl_Sexo.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_Sexo.TabIndex = 2
        Me.Lbl_Sexo.Tag = ""
        Me.Lbl_Sexo.Text = "Sexo"
        '
        'Lbl_NomeSocial
        '
        Me.Lbl_NomeSocial.AutoSize = True
        Me.Lbl_NomeSocial.Location = New System.Drawing.Point(8, 49)
        Me.Lbl_NomeSocial.Name = "Lbl_NomeSocial"
        Me.Lbl_NomeSocial.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_NomeSocial.TabIndex = 6
        Me.Lbl_NomeSocial.Text = "Nome Social"
        '
        'Lbl_NomeCompleto
        '
        Me.Lbl_NomeCompleto.AutoSize = True
        Me.Lbl_NomeCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NomeCompleto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbl_NomeCompleto.Location = New System.Drawing.Point(8, 10)
        Me.Lbl_NomeCompleto.Name = "Lbl_NomeCompleto"
        Me.Lbl_NomeCompleto.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_NomeCompleto.TabIndex = 0
        Me.Lbl_NomeCompleto.Text = "Nome Completo"
        '
        'TbPg_InformacoesCorporativas
        '
        Me.TbPg_InformacoesCorporativas.BackColor = System.Drawing.Color.White
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.CmbBx_ModalidadeContrato)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.Lbl_ModalidadeContrato)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.CmbBx_TipoContrato)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.Lbl_TipoContrato)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.DtTmPckr_DataDeDemissao)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.Lbl_DataDeDemissao)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.DtTmPckr_DataDeAdmissao)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.Lbl_DataDeAdmissao)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.TxtBx_Setor)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.TxtBx_Funcao)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.TxtBx_EmailCorporativo)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.Lbl_Setor)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.Lbl_Funcao)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.MskdTxtBx_Chapa)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.Lbl_Chapa)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.Lbl_EmailCorporativo)
        Me.TbPg_InformacoesCorporativas.Location = New System.Drawing.Point(4, 22)
        Me.TbPg_InformacoesCorporativas.Name = "TbPg_InformacoesCorporativas"
        Me.TbPg_InformacoesCorporativas.Padding = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.TbPg_InformacoesCorporativas.Size = New System.Drawing.Size(645, 178)
        Me.TbPg_InformacoesCorporativas.TabIndex = 4
        Me.TbPg_InformacoesCorporativas.Text = "Informações Corporativas"
        '
        'CmbBx_ModalidadeContrato
        '
        Me.CmbBx_ModalidadeContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBx_ModalidadeContrato.FormattingEnabled = True
        Me.CmbBx_ModalidadeContrato.Location = New System.Drawing.Point(263, 143)
        Me.CmbBx_ModalidadeContrato.Name = "CmbBx_ModalidadeContrato"
        Me.CmbBx_ModalidadeContrato.Size = New System.Drawing.Size(245, 21)
        Me.CmbBx_ModalidadeContrato.TabIndex = 13
        Me.CmbBx_ModalidadeContrato.Tag = "Modalidade de Contrato"
        '
        'Lbl_ModalidadeContrato
        '
        Me.Lbl_ModalidadeContrato.AutoSize = True
        Me.Lbl_ModalidadeContrato.Location = New System.Drawing.Point(260, 127)
        Me.Lbl_ModalidadeContrato.Name = "Lbl_ModalidadeContrato"
        Me.Lbl_ModalidadeContrato.Size = New System.Drawing.Size(120, 13)
        Me.Lbl_ModalidadeContrato.TabIndex = 12
        Me.Lbl_ModalidadeContrato.Text = "Modalidade de Contrato"
        '
        'CmbBx_TipoContrato
        '
        Me.CmbBx_TipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBx_TipoContrato.FormattingEnabled = True
        Me.CmbBx_TipoContrato.Location = New System.Drawing.Point(137, 143)
        Me.CmbBx_TipoContrato.Name = "CmbBx_TipoContrato"
        Me.CmbBx_TipoContrato.Size = New System.Drawing.Size(120, 21)
        Me.CmbBx_TipoContrato.TabIndex = 11
        Me.CmbBx_TipoContrato.Tag = "Tipo de Contrato"
        '
        'Lbl_TipoContrato
        '
        Me.Lbl_TipoContrato.AutoSize = True
        Me.Lbl_TipoContrato.Location = New System.Drawing.Point(134, 127)
        Me.Lbl_TipoContrato.Name = "Lbl_TipoContrato"
        Me.Lbl_TipoContrato.Size = New System.Drawing.Size(86, 13)
        Me.Lbl_TipoContrato.TabIndex = 10
        Me.Lbl_TipoContrato.Text = "Tipo de Contrato"
        '
        'DtTmPckr_DataDeDemissao
        '
        Me.DtTmPckr_DataDeDemissao.Enabled = False
        Me.DtTmPckr_DataDeDemissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTmPckr_DataDeDemissao.Location = New System.Drawing.Point(514, 143)
        Me.DtTmPckr_DataDeDemissao.Name = "DtTmPckr_DataDeDemissao"
        Me.DtTmPckr_DataDeDemissao.Size = New System.Drawing.Size(120, 20)
        Me.DtTmPckr_DataDeDemissao.TabIndex = 15
        Me.DtTmPckr_DataDeDemissao.Tag = "Data de Demissão"
        '
        'Lbl_DataDeDemissao
        '
        Me.Lbl_DataDeDemissao.AutoSize = True
        Me.Lbl_DataDeDemissao.Location = New System.Drawing.Point(511, 127)
        Me.Lbl_DataDeDemissao.Name = "Lbl_DataDeDemissao"
        Me.Lbl_DataDeDemissao.Size = New System.Drawing.Size(94, 13)
        Me.Lbl_DataDeDemissao.TabIndex = 14
        Me.Lbl_DataDeDemissao.Text = "Data de Demissão"
        '
        'DtTmPckr_DataDeAdmissao
        '
        Me.DtTmPckr_DataDeAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTmPckr_DataDeAdmissao.Location = New System.Drawing.Point(11, 143)
        Me.DtTmPckr_DataDeAdmissao.Name = "DtTmPckr_DataDeAdmissao"
        Me.DtTmPckr_DataDeAdmissao.Size = New System.Drawing.Size(120, 20)
        Me.DtTmPckr_DataDeAdmissao.TabIndex = 9
        Me.DtTmPckr_DataDeAdmissao.Tag = "Data de Admissão"
        '
        'Lbl_DataDeAdmissao
        '
        Me.Lbl_DataDeAdmissao.AutoSize = True
        Me.Lbl_DataDeAdmissao.Location = New System.Drawing.Point(8, 127)
        Me.Lbl_DataDeAdmissao.Name = "Lbl_DataDeAdmissao"
        Me.Lbl_DataDeAdmissao.Size = New System.Drawing.Size(93, 13)
        Me.Lbl_DataDeAdmissao.TabIndex = 8
        Me.Lbl_DataDeAdmissao.Text = "Data de Admissão"
        '
        'TxtBx_Setor
        '
        Me.TxtBx_Setor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBx_Setor.Location = New System.Drawing.Point(11, 104)
        Me.TxtBx_Setor.Name = "TxtBx_Setor"
        Me.TxtBx_Setor.Size = New System.Drawing.Size(623, 20)
        Me.TxtBx_Setor.TabIndex = 7
        Me.TxtBx_Setor.Tag = "Setor"
        '
        'TxtBx_Funcao
        '
        Me.TxtBx_Funcao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBx_Funcao.Location = New System.Drawing.Point(11, 65)
        Me.TxtBx_Funcao.Name = "TxtBx_Funcao"
        Me.TxtBx_Funcao.Size = New System.Drawing.Size(623, 20)
        Me.TxtBx_Funcao.TabIndex = 5
        Me.TxtBx_Funcao.Tag = "Função"
        '
        'TxtBx_EmailCorporativo
        '
        Me.TxtBx_EmailCorporativo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBx_EmailCorporativo.Location = New System.Drawing.Point(11, 26)
        Me.TxtBx_EmailCorporativo.Name = "TxtBx_EmailCorporativo"
        Me.TxtBx_EmailCorporativo.Size = New System.Drawing.Size(497, 20)
        Me.TxtBx_EmailCorporativo.TabIndex = 1
        Me.TxtBx_EmailCorporativo.Tag = "E-mail Corporativo"
        '
        'Lbl_Setor
        '
        Me.Lbl_Setor.AutoSize = True
        Me.Lbl_Setor.Location = New System.Drawing.Point(8, 88)
        Me.Lbl_Setor.Name = "Lbl_Setor"
        Me.Lbl_Setor.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_Setor.TabIndex = 6
        Me.Lbl_Setor.Text = "Setor"
        '
        'Lbl_Funcao
        '
        Me.Lbl_Funcao.AutoSize = True
        Me.Lbl_Funcao.Location = New System.Drawing.Point(8, 49)
        Me.Lbl_Funcao.Name = "Lbl_Funcao"
        Me.Lbl_Funcao.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Funcao.TabIndex = 4
        Me.Lbl_Funcao.Text = "Função"
        '
        'MskdTxtBx_Chapa
        '
        Me.MskdTxtBx_Chapa.Location = New System.Drawing.Point(514, 26)
        Me.MskdTxtBx_Chapa.Mask = "??? ######"
        Me.MskdTxtBx_Chapa.Name = "MskdTxtBx_Chapa"
        Me.MskdTxtBx_Chapa.Size = New System.Drawing.Size(120, 20)
        Me.MskdTxtBx_Chapa.TabIndex = 3
        Me.MskdTxtBx_Chapa.Tag = "Chapa"
        '
        'Lbl_Chapa
        '
        Me.Lbl_Chapa.AutoSize = True
        Me.Lbl_Chapa.Location = New System.Drawing.Point(511, 10)
        Me.Lbl_Chapa.Name = "Lbl_Chapa"
        Me.Lbl_Chapa.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Chapa.TabIndex = 2
        Me.Lbl_Chapa.Text = "Chapa"
        '
        'Lbl_EmailCorporativo
        '
        Me.Lbl_EmailCorporativo.AutoSize = True
        Me.Lbl_EmailCorporativo.Location = New System.Drawing.Point(8, 10)
        Me.Lbl_EmailCorporativo.Name = "Lbl_EmailCorporativo"
        Me.Lbl_EmailCorporativo.Size = New System.Drawing.Size(92, 13)
        Me.Lbl_EmailCorporativo.TabIndex = 0
        Me.Lbl_EmailCorporativo.Text = "E-mail Corporativo"
        '
        'Pnl_BotoesDeAcao
        '
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Excluir)
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Limpar)
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Atualizar)
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Adicionar)
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Cancelar)
        Me.Pnl_BotoesDeAcao.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_BotoesDeAcao.Location = New System.Drawing.Point(20, 224)
        Me.Pnl_BotoesDeAcao.Name = "Pnl_BotoesDeAcao"
        Me.Pnl_BotoesDeAcao.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Pnl_BotoesDeAcao.Size = New System.Drawing.Size(653, 45)
        Me.Pnl_BotoesDeAcao.TabIndex = 1
        '
        'Bttn_Excluir
        '
        Me.Bttn_Excluir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Excluir.Location = New System.Drawing.Point(253, 10)
        Me.Bttn_Excluir.Name = "Bttn_Excluir"
        Me.Bttn_Excluir.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Excluir.TabIndex = 3
        Me.Bttn_Excluir.Text = "Excluir"
        Me.Bttn_Excluir.UseVisualStyleBackColor = True
        '
        'Bttn_Limpar
        '
        Me.Bttn_Limpar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Limpar.Location = New System.Drawing.Point(353, 10)
        Me.Bttn_Limpar.Name = "Bttn_Limpar"
        Me.Bttn_Limpar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Limpar.TabIndex = 2
        Me.Bttn_Limpar.Text = "Limpar"
        Me.Bttn_Limpar.UseVisualStyleBackColor = True
        '
        'Bttn_Atualizar
        '
        Me.Bttn_Atualizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Atualizar.Location = New System.Drawing.Point(453, 10)
        Me.Bttn_Atualizar.Name = "Bttn_Atualizar"
        Me.Bttn_Atualizar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Atualizar.TabIndex = 1
        Me.Bttn_Atualizar.Text = "Atualizar"
        Me.Bttn_Atualizar.UseVisualStyleBackColor = True
        '
        'Bttn_Adicionar
        '
        Me.Bttn_Adicionar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Adicionar.Location = New System.Drawing.Point(553, 10)
        Me.Bttn_Adicionar.Name = "Bttn_Adicionar"
        Me.Bttn_Adicionar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Adicionar.TabIndex = 0
        Me.Bttn_Adicionar.Text = "Adicionar"
        Me.Bttn_Adicionar.UseVisualStyleBackColor = True
        '
        'Bttn_Cancelar
        '
        Me.Bttn_Cancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Bttn_Cancelar.Location = New System.Drawing.Point(0, 10)
        Me.Bttn_Cancelar.Name = "Bttn_Cancelar"
        Me.Bttn_Cancelar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Cancelar.TabIndex = 4
        Me.Bttn_Cancelar.Text = "Cancelar"
        Me.Bttn_Cancelar.UseVisualStyleBackColor = True
        '
        'Frm__Cadastro__Colaboradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(693, 349)
        Me.Controls.Add(Me.Pnl_Dados)
        Me.Controls.Add(Me.Pnl_Informacoes)
        Me.Controls.Add(Me.MnStrp_MenuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm__Cadastro__Colaboradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoFlow | Cadastro de Colaboradores"
        Me.MnStrp_MenuPrincipal.ResumeLayout(False)
        Me.MnStrp_MenuPrincipal.PerformLayout()
        Me.Pnl_Informacoes.ResumeLayout(False)
        Me.Pnl_Informacoes.PerformLayout()
        Me.SttsStrp_InformacoesSobreATabela.ResumeLayout(False)
        Me.SttsStrp_InformacoesSobreATabela.PerformLayout()
        Me.Pnl_Dados.ResumeLayout(False)
        Me.TbCntrl_Dados.ResumeLayout(False)
        Me.TbPg_InformacoesPessoais.ResumeLayout(False)
        Me.TbPg_InformacoesPessoais.PerformLayout()
        Me.TbPg_InformacoesCorporativas.ResumeLayout(False)
        Me.TbPg_InformacoesCorporativas.PerformLayout()
        Me.Pnl_BotoesDeAcao.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnStrp_MenuPrincipal As MenuStrip
    Friend WithEvents TlStrpMnItm_MenuAcoes As ToolStripMenuItem
    Friend WithEvents TlStrpMnItm_Acoes_Adicionar As ToolStripMenuItem
    Friend WithEvents TlStrpMnItm_Acoes_Editar As ToolStripMenuItem
    Friend WithEvents TlStrpMnItm_Acoes_Remover As ToolStripMenuItem
    Friend WithEvents TlStrpSprtr_Acoes_1 As ToolStripSeparator
    Friend WithEvents TlStrpMnItm_Acoes_Visualizar As ToolStripMenuItem
    Friend WithEvents Pnl_Informacoes As Panel
    Friend WithEvents SttsStrp_InformacoesSobreATabela As StatusStrip
    Friend WithEvents TlStrpSttsLbl_TotalDeColaboradoresCadastrados As ToolStripStatusLabel
    Friend WithEvents TlStrpSttsLbl_NumeroTotalDeColaboradores As ToolStripStatusLabel
    Friend WithEvents Pnl_Dados As Panel
    Friend WithEvents TbCntrl_Dados As TabControl
    Friend WithEvents TbPg_InformacoesPessoais As TabPage
    Friend WithEvents MskdTxtBx_TelefonePessoal As MaskedTextBox
    Friend WithEvents Lbl_TelefonePessoal As Label
    Friend WithEvents TxtBx_EmailPessoal As TextBox
    Friend WithEvents TxtBx_RG As TextBox
    Friend WithEvents TxtBx_NomeSocial As TextBox
    Friend WithEvents TxtBx_NomeCompleto As TextBox
    Friend WithEvents Lbl_EmailPessoal As Label
    Friend WithEvents DtTmPckr_DataDeNascimento As DateTimePicker
    Friend WithEvents Lbl_DataDeNascimento As Label
    Friend WithEvents Lbl_RG As Label
    Friend WithEvents MskdTxtBx_CPF As MaskedTextBox
    Friend WithEvents Lbl_CPF As Label
    Friend WithEvents CmbBx_Sexo As ComboBox
    Friend WithEvents Lbl_Sexo As Label
    Friend WithEvents Lbl_NomeSocial As Label
    Friend WithEvents Lbl_NomeCompleto As Label
    Friend WithEvents TbPg_InformacoesCorporativas As TabPage
    Friend WithEvents CmbBx_ModalidadeContrato As ComboBox
    Friend WithEvents Lbl_ModalidadeContrato As Label
    Friend WithEvents CmbBx_TipoContrato As ComboBox
    Friend WithEvents Lbl_TipoContrato As Label
    Friend WithEvents DtTmPckr_DataDeDemissao As DateTimePicker
    Friend WithEvents Lbl_DataDeDemissao As Label
    Friend WithEvents DtTmPckr_DataDeAdmissao As DateTimePicker
    Friend WithEvents Lbl_DataDeAdmissao As Label
    Friend WithEvents TxtBx_Setor As TextBox
    Friend WithEvents TxtBx_Funcao As TextBox
    Friend WithEvents TxtBx_EmailCorporativo As TextBox
    Friend WithEvents Lbl_Setor As Label
    Friend WithEvents Lbl_Funcao As Label
    Friend WithEvents MskdTxtBx_Chapa As MaskedTextBox
    Friend WithEvents Lbl_Chapa As Label
    Friend WithEvents Lbl_EmailCorporativo As Label
    Friend WithEvents Pnl_BotoesDeAcao As Panel
    Friend WithEvents Bttn_Excluir As Button
    Friend WithEvents Bttn_Limpar As Button
    Friend WithEvents Bttn_Atualizar As Button
    Friend WithEvents Bttn_Adicionar As Button
    Friend WithEvents Bttn_Cancelar As Button
End Class
