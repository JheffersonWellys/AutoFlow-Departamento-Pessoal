<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm__Selecao__AgenciaCaixa
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm__Selecao__AgenciaCaixa))
        Me.Pnl_DadosLista_AgenciasCaixa = New System.Windows.Forms.Panel()
        Me.TbCntrl_Lista_AgenciasCaixa = New System.Windows.Forms.TabControl()
        Me.TbPg_Lista_AgenciasCaixa = New System.Windows.Forms.TabPage()
        Me.DtGrdVw_Lista_AgenciasCaixa = New System.Windows.Forms.DataGridView()
        Me.CntxtMnStrp_SubMenuPrincipal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlStrpSprtr_SubMenuPrincipal = New System.Windows.Forms.ToolStripSeparator()
        Me.TlStrpMnItm_SubMenuPrincipal_LimparFiltro = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pnl_Filtro = New System.Windows.Forms.Panel()
        Me.GrpBx_FiltrosDePesquisa = New System.Windows.Forms.GroupBox()
        Me.TxtBx_TermoDePesquisa = New System.Windows.Forms.TextBox()
        Me.Lbl_TermoDePesquisa = New System.Windows.Forms.Label()
        Me.Pnl_BotoesDeAcao = New System.Windows.Forms.Panel()
        Me.Bttn_Cancelar = New System.Windows.Forms.Button()
        Me.Bttn_Selecionar = New System.Windows.Forms.Button()
        Me.MnStrp_MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.TlStrpMnItm_MenuDeAcoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlStrpMnItm_Acoes_LimparFiltro = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pnl_DadosLista_AgenciasCaixa.SuspendLayout()
        Me.TbCntrl_Lista_AgenciasCaixa.SuspendLayout()
        Me.TbPg_Lista_AgenciasCaixa.SuspendLayout()
        CType(Me.DtGrdVw_Lista_AgenciasCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CntxtMnStrp_SubMenuPrincipal.SuspendLayout()
        Me.Pnl_Filtro.SuspendLayout()
        Me.GrpBx_FiltrosDePesquisa.SuspendLayout()
        Me.Pnl_BotoesDeAcao.SuspendLayout()
        Me.MnStrp_MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_DadosLista_AgenciasCaixa
        '
        Me.Pnl_DadosLista_AgenciasCaixa.Controls.Add(Me.TbCntrl_Lista_AgenciasCaixa)
        Me.Pnl_DadosLista_AgenciasCaixa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_DadosLista_AgenciasCaixa.Location = New System.Drawing.Point(0, 30)
        Me.Pnl_DadosLista_AgenciasCaixa.Name = "Pnl_DadosLista_AgenciasCaixa"
        Me.Pnl_DadosLista_AgenciasCaixa.Padding = New System.Windows.Forms.Padding(20, 20, 20, 10)
        Me.Pnl_DadosLista_AgenciasCaixa.Size = New System.Drawing.Size(979, 321)
        Me.Pnl_DadosLista_AgenciasCaixa.TabIndex = 13
        '
        'TbCntrl_Lista_AgenciasCaixa
        '
        Me.TbCntrl_Lista_AgenciasCaixa.Controls.Add(Me.TbPg_Lista_AgenciasCaixa)
        Me.TbCntrl_Lista_AgenciasCaixa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbCntrl_Lista_AgenciasCaixa.Location = New System.Drawing.Point(20, 20)
        Me.TbCntrl_Lista_AgenciasCaixa.Name = "TbCntrl_Lista_AgenciasCaixa"
        Me.TbCntrl_Lista_AgenciasCaixa.SelectedIndex = 0
        Me.TbCntrl_Lista_AgenciasCaixa.Size = New System.Drawing.Size(939, 291)
        Me.TbCntrl_Lista_AgenciasCaixa.TabIndex = 0
        '
        'TbPg_Lista_AgenciasCaixa
        '
        Me.TbPg_Lista_AgenciasCaixa.Controls.Add(Me.DtGrdVw_Lista_AgenciasCaixa)
        Me.TbPg_Lista_AgenciasCaixa.Location = New System.Drawing.Point(4, 22)
        Me.TbPg_Lista_AgenciasCaixa.Name = "TbPg_Lista_AgenciasCaixa"
        Me.TbPg_Lista_AgenciasCaixa.Padding = New System.Windows.Forms.Padding(10)
        Me.TbPg_Lista_AgenciasCaixa.Size = New System.Drawing.Size(931, 265)
        Me.TbPg_Lista_AgenciasCaixa.TabIndex = 0
        Me.TbPg_Lista_AgenciasCaixa.Text = "Lista de Agências CAIXA"
        Me.TbPg_Lista_AgenciasCaixa.UseVisualStyleBackColor = True
        '
        'DtGrdVw_Lista_AgenciasCaixa
        '
        Me.DtGrdVw_Lista_AgenciasCaixa.AllowDrop = True
        Me.DtGrdVw_Lista_AgenciasCaixa.AllowUserToAddRows = False
        Me.DtGrdVw_Lista_AgenciasCaixa.AllowUserToDeleteRows = False
        Me.DtGrdVw_Lista_AgenciasCaixa.AllowUserToResizeColumns = False
        Me.DtGrdVw_Lista_AgenciasCaixa.AllowUserToResizeRows = False
        Me.DtGrdVw_Lista_AgenciasCaixa.BackgroundColor = System.Drawing.Color.White
        Me.DtGrdVw_Lista_AgenciasCaixa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DtGrdVw_Lista_AgenciasCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DtGrdVw_Lista_AgenciasCaixa.ContextMenuStrip = Me.CntxtMnStrp_SubMenuPrincipal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtGrdVw_Lista_AgenciasCaixa.DefaultCellStyle = DataGridViewCellStyle1
        Me.DtGrdVw_Lista_AgenciasCaixa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DtGrdVw_Lista_AgenciasCaixa.Location = New System.Drawing.Point(10, 10)
        Me.DtGrdVw_Lista_AgenciasCaixa.MultiSelect = False
        Me.DtGrdVw_Lista_AgenciasCaixa.Name = "DtGrdVw_Lista_AgenciasCaixa"
        Me.DtGrdVw_Lista_AgenciasCaixa.ReadOnly = True
        Me.DtGrdVw_Lista_AgenciasCaixa.RowHeadersVisible = False
        Me.DtGrdVw_Lista_AgenciasCaixa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DtGrdVw_Lista_AgenciasCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtGrdVw_Lista_AgenciasCaixa.Size = New System.Drawing.Size(911, 245)
        Me.DtGrdVw_Lista_AgenciasCaixa.TabIndex = 0
        '
        'CntxtMnStrp_SubMenuPrincipal
        '
        Me.CntxtMnStrp_SubMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa, Me.TlStrpSprtr_SubMenuPrincipal, Me.TlStrpMnItm_SubMenuPrincipal_LimparFiltro})
        Me.CntxtMnStrp_SubMenuPrincipal.Name = "CntxtMnStrp_SubMenuPrincipal"
        Me.CntxtMnStrp_SubMenuPrincipal.Size = New System.Drawing.Size(218, 66)
        '
        'TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa
        '
        Me.TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa.Image = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.icn_Selecionar
        Me.TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa.Name = "TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa"
        Me.TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa.Size = New System.Drawing.Size(217, 28)
        Me.TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa.Text = "Selecionar Agência CAIXA"
        '
        'TlStrpSprtr_SubMenuPrincipal
        '
        Me.TlStrpSprtr_SubMenuPrincipal.Name = "TlStrpSprtr_SubMenuPrincipal"
        Me.TlStrpSprtr_SubMenuPrincipal.Size = New System.Drawing.Size(214, 6)
        '
        'TlStrpMnItm_SubMenuPrincipal_LimparFiltro
        '
        Me.TlStrpMnItm_SubMenuPrincipal_LimparFiltro.Image = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.icn_Limpar
        Me.TlStrpMnItm_SubMenuPrincipal_LimparFiltro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlStrpMnItm_SubMenuPrincipal_LimparFiltro.Name = "TlStrpMnItm_SubMenuPrincipal_LimparFiltro"
        Me.TlStrpMnItm_SubMenuPrincipal_LimparFiltro.Size = New System.Drawing.Size(217, 28)
        Me.TlStrpMnItm_SubMenuPrincipal_LimparFiltro.Text = "Limpar Filtros"
        '
        'Pnl_Filtro
        '
        Me.Pnl_Filtro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Pnl_Filtro.Controls.Add(Me.GrpBx_FiltrosDePesquisa)
        Me.Pnl_Filtro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_Filtro.Location = New System.Drawing.Point(0, 351)
        Me.Pnl_Filtro.Name = "Pnl_Filtro"
        Me.Pnl_Filtro.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.Pnl_Filtro.Size = New System.Drawing.Size(979, 85)
        Me.Pnl_Filtro.TabIndex = 12
        '
        'GrpBx_FiltrosDePesquisa
        '
        Me.GrpBx_FiltrosDePesquisa.Controls.Add(Me.TxtBx_TermoDePesquisa)
        Me.GrpBx_FiltrosDePesquisa.Controls.Add(Me.Lbl_TermoDePesquisa)
        Me.GrpBx_FiltrosDePesquisa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpBx_FiltrosDePesquisa.Location = New System.Drawing.Point(20, 10)
        Me.GrpBx_FiltrosDePesquisa.Name = "GrpBx_FiltrosDePesquisa"
        Me.GrpBx_FiltrosDePesquisa.Padding = New System.Windows.Forms.Padding(5)
        Me.GrpBx_FiltrosDePesquisa.Size = New System.Drawing.Size(939, 65)
        Me.GrpBx_FiltrosDePesquisa.TabIndex = 0
        Me.GrpBx_FiltrosDePesquisa.TabStop = False
        Me.GrpBx_FiltrosDePesquisa.Text = "Filtros de Pesquisa"
        '
        'TxtBx_TermoDePesquisa
        '
        Me.TxtBx_TermoDePesquisa.Location = New System.Drawing.Point(11, 34)
        Me.TxtBx_TermoDePesquisa.Name = "TxtBx_TermoDePesquisa"
        Me.TxtBx_TermoDePesquisa.Size = New System.Drawing.Size(914, 20)
        Me.TxtBx_TermoDePesquisa.TabIndex = 1
        '
        'Lbl_TermoDePesquisa
        '
        Me.Lbl_TermoDePesquisa.AutoSize = True
        Me.Lbl_TermoDePesquisa.Location = New System.Drawing.Point(8, 18)
        Me.Lbl_TermoDePesquisa.Name = "Lbl_TermoDePesquisa"
        Me.Lbl_TermoDePesquisa.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_TermoDePesquisa.TabIndex = 0
        Me.Lbl_TermoDePesquisa.Text = "Termo de Pesquisa"
        '
        'Pnl_BotoesDeAcao
        '
        Me.Pnl_BotoesDeAcao.BackColor = System.Drawing.Color.White
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Cancelar)
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Selecionar)
        Me.Pnl_BotoesDeAcao.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_BotoesDeAcao.Location = New System.Drawing.Point(0, 436)
        Me.Pnl_BotoesDeAcao.Name = "Pnl_BotoesDeAcao"
        Me.Pnl_BotoesDeAcao.Padding = New System.Windows.Forms.Padding(15)
        Me.Pnl_BotoesDeAcao.Size = New System.Drawing.Size(979, 65)
        Me.Pnl_BotoesDeAcao.TabIndex = 11
        '
        'Bttn_Cancelar
        '
        Me.Bttn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bttn_Cancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Bttn_Cancelar.Location = New System.Drawing.Point(15, 15)
        Me.Bttn_Cancelar.Name = "Bttn_Cancelar"
        Me.Bttn_Cancelar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Cancelar.TabIndex = 1
        Me.Bttn_Cancelar.Text = "Cancelar"
        Me.Bttn_Cancelar.UseVisualStyleBackColor = True
        '
        'Bttn_Selecionar
        '
        Me.Bttn_Selecionar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Selecionar.Location = New System.Drawing.Point(864, 15)
        Me.Bttn_Selecionar.Name = "Bttn_Selecionar"
        Me.Bttn_Selecionar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Selecionar.TabIndex = 0
        Me.Bttn_Selecionar.Text = "Selecionar"
        Me.Bttn_Selecionar.UseVisualStyleBackColor = True
        '
        'MnStrp_MenuPrincipal
        '
        Me.MnStrp_MenuPrincipal.BackColor = System.Drawing.Color.White
        Me.MnStrp_MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpMnItm_MenuDeAcoes})
        Me.MnStrp_MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MnStrp_MenuPrincipal.Name = "MnStrp_MenuPrincipal"
        Me.MnStrp_MenuPrincipal.Size = New System.Drawing.Size(979, 30)
        Me.MnStrp_MenuPrincipal.TabIndex = 10
        Me.MnStrp_MenuPrincipal.Text = "MenuStrip1"
        '
        'TlStrpMnItm_MenuDeAcoes
        '
        Me.TlStrpMnItm_MenuDeAcoes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpMnItm_Acoes_LimparFiltro})
        Me.TlStrpMnItm_MenuDeAcoes.Image = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.icn_Menu
        Me.TlStrpMnItm_MenuDeAcoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlStrpMnItm_MenuDeAcoes.Name = "TlStrpMnItm_MenuDeAcoes"
        Me.TlStrpMnItm_MenuDeAcoes.Size = New System.Drawing.Size(73, 26)
        Me.TlStrpMnItm_MenuDeAcoes.Text = "Ações"
        '
        'TlStrpMnItm_Acoes_LimparFiltro
        '
        Me.TlStrpMnItm_Acoes_LimparFiltro.Image = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.icn_Limpar
        Me.TlStrpMnItm_Acoes_LimparFiltro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TlStrpMnItm_Acoes_LimparFiltro.Name = "TlStrpMnItm_Acoes_LimparFiltro"
        Me.TlStrpMnItm_Acoes_LimparFiltro.Size = New System.Drawing.Size(152, 28)
        Me.TlStrpMnItm_Acoes_LimparFiltro.Text = "Limpar Filtros"
        '
        'Frm__Selecao__AgenciaCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(979, 501)
        Me.Controls.Add(Me.Pnl_DadosLista_AgenciasCaixa)
        Me.Controls.Add(Me.Pnl_Filtro)
        Me.Controls.Add(Me.Pnl_BotoesDeAcao)
        Me.Controls.Add(Me.MnStrp_MenuPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm__Selecao__AgenciaCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoFlow | Selecionar Agência CAIXA"
        Me.Pnl_DadosLista_AgenciasCaixa.ResumeLayout(False)
        Me.TbCntrl_Lista_AgenciasCaixa.ResumeLayout(False)
        Me.TbPg_Lista_AgenciasCaixa.ResumeLayout(False)
        CType(Me.DtGrdVw_Lista_AgenciasCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CntxtMnStrp_SubMenuPrincipal.ResumeLayout(False)
        Me.Pnl_Filtro.ResumeLayout(False)
        Me.GrpBx_FiltrosDePesquisa.ResumeLayout(False)
        Me.GrpBx_FiltrosDePesquisa.PerformLayout()
        Me.Pnl_BotoesDeAcao.ResumeLayout(False)
        Me.MnStrp_MenuPrincipal.ResumeLayout(False)
        Me.MnStrp_MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pnl_DadosLista_AgenciasCaixa As Panel
    Friend WithEvents TbCntrl_Lista_AgenciasCaixa As TabControl
    Friend WithEvents TbPg_Lista_AgenciasCaixa As TabPage
    Friend WithEvents DtGrdVw_Lista_AgenciasCaixa As DataGridView
    Friend WithEvents Pnl_Filtro As Panel
    Friend WithEvents GrpBx_FiltrosDePesquisa As GroupBox
    Friend WithEvents TxtBx_TermoDePesquisa As TextBox
    Friend WithEvents Lbl_TermoDePesquisa As Label
    Friend WithEvents Pnl_BotoesDeAcao As Panel
    Friend WithEvents Bttn_Cancelar As Button
    Friend WithEvents Bttn_Selecionar As Button
    Friend WithEvents MnStrp_MenuPrincipal As MenuStrip
    Friend WithEvents TlStrpMnItm_MenuDeAcoes As ToolStripMenuItem
    Friend WithEvents TlStrpMnItm_Acoes_LimparFiltro As ToolStripMenuItem
    Friend WithEvents CntxtMnStrp_SubMenuPrincipal As ContextMenuStrip
    Friend WithEvents TlStrpMnItm_SubMenuPrincipal_SelecionarAgenciaCaixa As ToolStripMenuItem
    Friend WithEvents TlStrpSprtr_SubMenuPrincipal As ToolStripSeparator
    Friend WithEvents TlStrpMnItm_SubMenuPrincipal_LimparFiltro As ToolStripMenuItem
End Class
