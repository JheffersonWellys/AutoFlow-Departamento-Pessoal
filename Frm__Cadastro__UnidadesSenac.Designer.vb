<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm__Cadastro__UnidadesSenac
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm__Cadastro__UnidadesSenac))
        Me.MnStrp_MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.TlStrpMnItm_MenuAcoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlStrpMnItm_Acoes_Adicionar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlStrpMnItm_Acoes_Editar = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlStrpMnItm_Acoes_Remover = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlStrpSprtr_Acoes_1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlStrpMnItm_Acoes_Visualizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pnl_Informacoes = New System.Windows.Forms.Panel()
        Me.SttsStrp_InformacoesSobreATabela = New System.Windows.Forms.StatusStrip()
        Me.TlStrpSttsLbl_TotalDeUnidadesSenacCadastradas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TlStrpSttsLbl_NumeroTotalDeUnidadesSenac = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Pnl_Dados = New System.Windows.Forms.Panel()
        Me.TbCntrl_Dados = New System.Windows.Forms.TabControl()
        Me.TbPg_InformacoesCorporativas = New System.Windows.Forms.TabPage()
        Me.TbPg_InformacoesDeLocalizacao = New System.Windows.Forms.TabPage()
        Me.TxtBx_Estado = New System.Windows.Forms.TextBox()
        Me.Lbl_Estado = New System.Windows.Forms.Label()
        Me.TxtBx_Cidade = New System.Windows.Forms.TextBox()
        Me.Lbl_Cidade = New System.Windows.Forms.Label()
        Me.TxtBx_Numero = New System.Windows.Forms.TextBox()
        Me.Lbl_Numero = New System.Windows.Forms.Label()
        Me.TxtBx_Bairro = New System.Windows.Forms.TextBox()
        Me.Lbl_Bairro = New System.Windows.Forms.Label()
        Me.TxtBx_Logradouro = New System.Windows.Forms.TextBox()
        Me.Lbl_Logradouro = New System.Windows.Forms.Label()
        Me.Bttn_PesquisarCEP = New System.Windows.Forms.Button()
        Me.MskdTxtBx_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_CEP = New System.Windows.Forms.Label()
        Me.Pnl_BotoesDeAcao = New System.Windows.Forms.Panel()
        Me.Bttn_Excluir = New System.Windows.Forms.Button()
        Me.Bttn_Limpar = New System.Windows.Forms.Button()
        Me.Bttn_Atualizar = New System.Windows.Forms.Button()
        Me.Bttn_Adicionar = New System.Windows.Forms.Button()
        Me.Bttn_Cancelar = New System.Windows.Forms.Button()
        Me.Lbl_NomeUnidade = New System.Windows.Forms.Label()
        Me.TxtBx_NomeUnidade = New System.Windows.Forms.TextBox()
        Me.MskdTxtBx_CodigoUnidade = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_CodigoUnidade = New System.Windows.Forms.Label()
        Me.MnStrp_MenuPrincipal.SuspendLayout()
        Me.Pnl_Informacoes.SuspendLayout()
        Me.SttsStrp_InformacoesSobreATabela.SuspendLayout()
        Me.Pnl_Dados.SuspendLayout()
        Me.TbCntrl_Dados.SuspendLayout()
        Me.TbPg_InformacoesCorporativas.SuspendLayout()
        Me.TbPg_InformacoesDeLocalizacao.SuspendLayout()
        Me.Pnl_BotoesDeAcao.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnStrp_MenuPrincipal
        '
        Me.MnStrp_MenuPrincipal.BackColor = System.Drawing.Color.White
        Me.MnStrp_MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpMnItm_MenuAcoes})
        Me.MnStrp_MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MnStrp_MenuPrincipal.Name = "MnStrp_MenuPrincipal"
        Me.MnStrp_MenuPrincipal.Size = New System.Drawing.Size(695, 30)
        Me.MnStrp_MenuPrincipal.TabIndex = 1
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
        Me.Pnl_Informacoes.Location = New System.Drawing.Point(0, 269)
        Me.Pnl_Informacoes.Name = "Pnl_Informacoes"
        Me.Pnl_Informacoes.Padding = New System.Windows.Forms.Padding(10)
        Me.Pnl_Informacoes.Size = New System.Drawing.Size(695, 40)
        Me.Pnl_Informacoes.TabIndex = 3
        '
        'SttsStrp_InformacoesSobreATabela
        '
        Me.SttsStrp_InformacoesSobreATabela.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpSttsLbl_TotalDeUnidadesSenacCadastradas, Me.TlStrpSttsLbl_NumeroTotalDeUnidadesSenac})
        Me.SttsStrp_InformacoesSobreATabela.Location = New System.Drawing.Point(10, 8)
        Me.SttsStrp_InformacoesSobreATabela.Name = "SttsStrp_InformacoesSobreATabela"
        Me.SttsStrp_InformacoesSobreATabela.Size = New System.Drawing.Size(675, 22)
        Me.SttsStrp_InformacoesSobreATabela.TabIndex = 0
        Me.SttsStrp_InformacoesSobreATabela.Text = "StatusStrip1"
        '
        'TlStrpSttsLbl_TotalDeUnidadesSenacCadastradas
        '
        Me.TlStrpSttsLbl_TotalDeUnidadesSenacCadastradas.BackColor = System.Drawing.Color.Transparent
        Me.TlStrpSttsLbl_TotalDeUnidadesSenacCadastradas.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TlStrpSttsLbl_TotalDeUnidadesSenacCadastradas.Name = "TlStrpSttsLbl_TotalDeUnidadesSenacCadastradas"
        Me.TlStrpSttsLbl_TotalDeUnidadesSenacCadastradas.Size = New System.Drawing.Size(208, 17)
        Me.TlStrpSttsLbl_TotalDeUnidadesSenacCadastradas.Text = "Total de Unidades Senac Cadastradas: "
        '
        'TlStrpSttsLbl_NumeroTotalDeUnidadesSenac
        '
        Me.TlStrpSttsLbl_NumeroTotalDeUnidadesSenac.BackColor = System.Drawing.Color.Transparent
        Me.TlStrpSttsLbl_NumeroTotalDeUnidadesSenac.Name = "TlStrpSttsLbl_NumeroTotalDeUnidadesSenac"
        Me.TlStrpSttsLbl_NumeroTotalDeUnidadesSenac.Size = New System.Drawing.Size(13, 17)
        Me.TlStrpSttsLbl_NumeroTotalDeUnidadesSenac.Text = "0"
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
        Me.Pnl_Dados.Size = New System.Drawing.Size(695, 239)
        Me.Pnl_Dados.TabIndex = 4
        Me.Pnl_Dados.Visible = False
        '
        'TbCntrl_Dados
        '
        Me.TbCntrl_Dados.Controls.Add(Me.TbPg_InformacoesCorporativas)
        Me.TbCntrl_Dados.Controls.Add(Me.TbPg_InformacoesDeLocalizacao)
        Me.TbCntrl_Dados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbCntrl_Dados.Location = New System.Drawing.Point(20, 20)
        Me.TbCntrl_Dados.Name = "TbCntrl_Dados"
        Me.TbCntrl_Dados.SelectedIndex = 0
        Me.TbCntrl_Dados.Size = New System.Drawing.Size(655, 164)
        Me.TbCntrl_Dados.TabIndex = 0
        '
        'TbPg_InformacoesCorporativas
        '
        Me.TbPg_InformacoesCorporativas.BackColor = System.Drawing.Color.White
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.Lbl_NomeUnidade)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.TxtBx_NomeUnidade)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.MskdTxtBx_CodigoUnidade)
        Me.TbPg_InformacoesCorporativas.Controls.Add(Me.Lbl_CodigoUnidade)
        Me.TbPg_InformacoesCorporativas.Location = New System.Drawing.Point(4, 22)
        Me.TbPg_InformacoesCorporativas.Name = "TbPg_InformacoesCorporativas"
        Me.TbPg_InformacoesCorporativas.Padding = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.TbPg_InformacoesCorporativas.Size = New System.Drawing.Size(647, 138)
        Me.TbPg_InformacoesCorporativas.TabIndex = 3
        Me.TbPg_InformacoesCorporativas.Text = "Informações Corporativas"
        '
        'TbPg_InformacoesDeLocalizacao
        '
        Me.TbPg_InformacoesDeLocalizacao.BackColor = System.Drawing.Color.White
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.TxtBx_Estado)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.Lbl_Estado)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.TxtBx_Cidade)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.Lbl_Cidade)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.TxtBx_Numero)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.Lbl_Numero)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.TxtBx_Bairro)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.Lbl_Bairro)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.TxtBx_Logradouro)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.Lbl_Logradouro)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.Bttn_PesquisarCEP)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.MskdTxtBx_CEP)
        Me.TbPg_InformacoesDeLocalizacao.Controls.Add(Me.Lbl_CEP)
        Me.TbPg_InformacoesDeLocalizacao.Location = New System.Drawing.Point(4, 22)
        Me.TbPg_InformacoesDeLocalizacao.Name = "TbPg_InformacoesDeLocalizacao"
        Me.TbPg_InformacoesDeLocalizacao.Padding = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.TbPg_InformacoesDeLocalizacao.Size = New System.Drawing.Size(647, 138)
        Me.TbPg_InformacoesDeLocalizacao.TabIndex = 4
        Me.TbPg_InformacoesDeLocalizacao.Text = "Informações de Localização"
        '
        'TxtBx_Estado
        '
        Me.TxtBx_Estado.Enabled = False
        Me.TxtBx_Estado.Location = New System.Drawing.Point(389, 104)
        Me.TxtBx_Estado.Name = "TxtBx_Estado"
        Me.TxtBx_Estado.Size = New System.Drawing.Size(243, 20)
        Me.TxtBx_Estado.TabIndex = 12
        '
        'Lbl_Estado
        '
        Me.Lbl_Estado.AutoSize = True
        Me.Lbl_Estado.Location = New System.Drawing.Point(386, 88)
        Me.Lbl_Estado.Name = "Lbl_Estado"
        Me.Lbl_Estado.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Estado.TabIndex = 11
        Me.Lbl_Estado.Text = "Estado"
        '
        'TxtBx_Cidade
        '
        Me.TxtBx_Cidade.Enabled = False
        Me.TxtBx_Cidade.Location = New System.Drawing.Point(11, 104)
        Me.TxtBx_Cidade.Name = "TxtBx_Cidade"
        Me.TxtBx_Cidade.Size = New System.Drawing.Size(372, 20)
        Me.TxtBx_Cidade.TabIndex = 10
        '
        'Lbl_Cidade
        '
        Me.Lbl_Cidade.AutoSize = True
        Me.Lbl_Cidade.Location = New System.Drawing.Point(8, 88)
        Me.Lbl_Cidade.Name = "Lbl_Cidade"
        Me.Lbl_Cidade.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Cidade.TabIndex = 9
        Me.Lbl_Cidade.Text = "Cidade"
        '
        'TxtBx_Numero
        '
        Me.TxtBx_Numero.Location = New System.Drawing.Point(263, 65)
        Me.TxtBx_Numero.Name = "TxtBx_Numero"
        Me.TxtBx_Numero.Size = New System.Drawing.Size(120, 20)
        Me.TxtBx_Numero.TabIndex = 6
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.AutoSize = True
        Me.Lbl_Numero.Location = New System.Drawing.Point(260, 49)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Numero.TabIndex = 5
        Me.Lbl_Numero.Text = "Número"
        '
        'TxtBx_Bairro
        '
        Me.TxtBx_Bairro.Enabled = False
        Me.TxtBx_Bairro.Location = New System.Drawing.Point(389, 65)
        Me.TxtBx_Bairro.Name = "TxtBx_Bairro"
        Me.TxtBx_Bairro.Size = New System.Drawing.Size(243, 20)
        Me.TxtBx_Bairro.TabIndex = 8
        '
        'Lbl_Bairro
        '
        Me.Lbl_Bairro.AutoSize = True
        Me.Lbl_Bairro.Location = New System.Drawing.Point(386, 49)
        Me.Lbl_Bairro.Name = "Lbl_Bairro"
        Me.Lbl_Bairro.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_Bairro.TabIndex = 7
        Me.Lbl_Bairro.Text = "Bairro"
        '
        'TxtBx_Logradouro
        '
        Me.TxtBx_Logradouro.Enabled = False
        Me.TxtBx_Logradouro.Location = New System.Drawing.Point(11, 65)
        Me.TxtBx_Logradouro.Name = "TxtBx_Logradouro"
        Me.TxtBx_Logradouro.Size = New System.Drawing.Size(246, 20)
        Me.TxtBx_Logradouro.TabIndex = 4
        Me.TxtBx_Logradouro.Tag = "Logradouro"
        '
        'Lbl_Logradouro
        '
        Me.Lbl_Logradouro.AutoSize = True
        Me.Lbl_Logradouro.Location = New System.Drawing.Point(8, 49)
        Me.Lbl_Logradouro.Name = "Lbl_Logradouro"
        Me.Lbl_Logradouro.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_Logradouro.TabIndex = 3
        Me.Lbl_Logradouro.Text = "Logradouro"
        '
        'Bttn_PesquisarCEP
        '
        Me.Bttn_PesquisarCEP.Location = New System.Drawing.Point(137, 12)
        Me.Bttn_PesquisarCEP.Name = "Bttn_PesquisarCEP"
        Me.Bttn_PesquisarCEP.Size = New System.Drawing.Size(120, 35)
        Me.Bttn_PesquisarCEP.TabIndex = 2
        Me.Bttn_PesquisarCEP.Text = "Pesquisar CEP"
        Me.Bttn_PesquisarCEP.UseVisualStyleBackColor = True
        '
        'MskdTxtBx_CEP
        '
        Me.MskdTxtBx_CEP.Location = New System.Drawing.Point(11, 26)
        Me.MskdTxtBx_CEP.Mask = "00000,000"
        Me.MskdTxtBx_CEP.Name = "MskdTxtBx_CEP"
        Me.MskdTxtBx_CEP.Size = New System.Drawing.Size(120, 20)
        Me.MskdTxtBx_CEP.TabIndex = 1
        Me.MskdTxtBx_CEP.Tag = "CEP"
        '
        'Lbl_CEP
        '
        Me.Lbl_CEP.AutoSize = True
        Me.Lbl_CEP.Location = New System.Drawing.Point(8, 10)
        Me.Lbl_CEP.Name = "Lbl_CEP"
        Me.Lbl_CEP.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_CEP.TabIndex = 0
        Me.Lbl_CEP.Text = "CEP"
        '
        'Pnl_BotoesDeAcao
        '
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Excluir)
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Limpar)
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Atualizar)
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Adicionar)
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Cancelar)
        Me.Pnl_BotoesDeAcao.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_BotoesDeAcao.Location = New System.Drawing.Point(20, 184)
        Me.Pnl_BotoesDeAcao.Name = "Pnl_BotoesDeAcao"
        Me.Pnl_BotoesDeAcao.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Pnl_BotoesDeAcao.Size = New System.Drawing.Size(655, 45)
        Me.Pnl_BotoesDeAcao.TabIndex = 1
        '
        'Bttn_Excluir
        '
        Me.Bttn_Excluir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Excluir.Location = New System.Drawing.Point(255, 10)
        Me.Bttn_Excluir.Name = "Bttn_Excluir"
        Me.Bttn_Excluir.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Excluir.TabIndex = 3
        Me.Bttn_Excluir.Text = "Excluir"
        Me.Bttn_Excluir.UseVisualStyleBackColor = True
        '
        'Bttn_Limpar
        '
        Me.Bttn_Limpar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Limpar.Location = New System.Drawing.Point(355, 10)
        Me.Bttn_Limpar.Name = "Bttn_Limpar"
        Me.Bttn_Limpar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Limpar.TabIndex = 2
        Me.Bttn_Limpar.Text = "Limpar"
        Me.Bttn_Limpar.UseVisualStyleBackColor = True
        '
        'Bttn_Atualizar
        '
        Me.Bttn_Atualizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Atualizar.Location = New System.Drawing.Point(455, 10)
        Me.Bttn_Atualizar.Name = "Bttn_Atualizar"
        Me.Bttn_Atualizar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Atualizar.TabIndex = 1
        Me.Bttn_Atualizar.Text = "Atualizar"
        Me.Bttn_Atualizar.UseVisualStyleBackColor = True
        '
        'Bttn_Adicionar
        '
        Me.Bttn_Adicionar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Adicionar.Location = New System.Drawing.Point(555, 10)
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
        'Lbl_NomeUnidade
        '
        Me.Lbl_NomeUnidade.AutoSize = True
        Me.Lbl_NomeUnidade.Location = New System.Drawing.Point(134, 10)
        Me.Lbl_NomeUnidade.Name = "Lbl_NomeUnidade"
        Me.Lbl_NomeUnidade.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_NomeUnidade.TabIndex = 12
        Me.Lbl_NomeUnidade.Text = "Nome Unidade"
        '
        'TxtBx_NomeUnidade
        '
        Me.TxtBx_NomeUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBx_NomeUnidade.Location = New System.Drawing.Point(137, 26)
        Me.TxtBx_NomeUnidade.Name = "TxtBx_NomeUnidade"
        Me.TxtBx_NomeUnidade.Size = New System.Drawing.Size(497, 20)
        Me.TxtBx_NomeUnidade.TabIndex = 13
        Me.TxtBx_NomeUnidade.Tag = "Nome Unidade"
        '
        'MskdTxtBx_CodigoUnidade
        '
        Me.MskdTxtBx_CodigoUnidade.Location = New System.Drawing.Point(11, 26)
        Me.MskdTxtBx_CodigoUnidade.Mask = "0,000"
        Me.MskdTxtBx_CodigoUnidade.Name = "MskdTxtBx_CodigoUnidade"
        Me.MskdTxtBx_CodigoUnidade.Size = New System.Drawing.Size(120, 20)
        Me.MskdTxtBx_CodigoUnidade.TabIndex = 11
        Me.MskdTxtBx_CodigoUnidade.Tag = "Código Unidade"
        '
        'Lbl_CodigoUnidade
        '
        Me.Lbl_CodigoUnidade.AutoSize = True
        Me.Lbl_CodigoUnidade.Location = New System.Drawing.Point(8, 10)
        Me.Lbl_CodigoUnidade.Name = "Lbl_CodigoUnidade"
        Me.Lbl_CodigoUnidade.Size = New System.Drawing.Size(83, 13)
        Me.Lbl_CodigoUnidade.TabIndex = 10
        Me.Lbl_CodigoUnidade.Text = "Código Unidade"
        '
        'Frm__Cadastro__UnidadesSenac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(695, 309)
        Me.Controls.Add(Me.Pnl_Dados)
        Me.Controls.Add(Me.Pnl_Informacoes)
        Me.Controls.Add(Me.MnStrp_MenuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm__Cadastro__UnidadesSenac"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoFlow | Cadastro de Unidades Senac"
        Me.MnStrp_MenuPrincipal.ResumeLayout(False)
        Me.MnStrp_MenuPrincipal.PerformLayout()
        Me.Pnl_Informacoes.ResumeLayout(False)
        Me.Pnl_Informacoes.PerformLayout()
        Me.SttsStrp_InformacoesSobreATabela.ResumeLayout(False)
        Me.SttsStrp_InformacoesSobreATabela.PerformLayout()
        Me.Pnl_Dados.ResumeLayout(False)
        Me.TbCntrl_Dados.ResumeLayout(False)
        Me.TbPg_InformacoesCorporativas.ResumeLayout(False)
        Me.TbPg_InformacoesCorporativas.PerformLayout()
        Me.TbPg_InformacoesDeLocalizacao.ResumeLayout(False)
        Me.TbPg_InformacoesDeLocalizacao.PerformLayout()
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
    Friend WithEvents TlStrpSttsLbl_TotalDeUnidadesSenacCadastradas As ToolStripStatusLabel
    Friend WithEvents TlStrpSttsLbl_NumeroTotalDeUnidadesSenac As ToolStripStatusLabel
    Friend WithEvents Pnl_Dados As Panel
    Friend WithEvents TbCntrl_Dados As TabControl
    Friend WithEvents TbPg_InformacoesCorporativas As TabPage
    Friend WithEvents Pnl_BotoesDeAcao As Panel
    Friend WithEvents Bttn_Excluir As Button
    Friend WithEvents Bttn_Limpar As Button
    Friend WithEvents Bttn_Atualizar As Button
    Friend WithEvents Bttn_Adicionar As Button
    Friend WithEvents Bttn_Cancelar As Button
    Friend WithEvents TbPg_InformacoesDeLocalizacao As TabPage
    Friend WithEvents MskdTxtBx_CEP As MaskedTextBox
    Friend WithEvents Lbl_CEP As Label
    Friend WithEvents Bttn_PesquisarCEP As Button
    Friend WithEvents Lbl_Logradouro As Label
    Friend WithEvents TxtBx_Numero As TextBox
    Friend WithEvents Lbl_Numero As Label
    Friend WithEvents TxtBx_Bairro As TextBox
    Friend WithEvents Lbl_Bairro As Label
    Friend WithEvents TxtBx_Logradouro As TextBox
    Friend WithEvents TxtBx_Cidade As TextBox
    Friend WithEvents Lbl_Cidade As Label
    Friend WithEvents TxtBx_Estado As TextBox
    Friend WithEvents Lbl_Estado As Label
    Friend WithEvents Lbl_NomeUnidade As Label
    Friend WithEvents TxtBx_NomeUnidade As TextBox
    Friend WithEvents MskdTxtBx_CodigoUnidade As MaskedTextBox
    Friend WithEvents Lbl_CodigoUnidade As Label
End Class
