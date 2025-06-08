<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm__Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm__Login))
        Me.Pnl_BotoesDeAcao = New System.Windows.Forms.Panel()
        Me.Bttn_Entrar = New System.Windows.Forms.Button()
        Me.Bttn_Cancelar = New System.Windows.Forms.Button()
        Me.Pnl_DadosDeLogin = New System.Windows.Forms.Panel()
        Me.ChckBx_VisualizarSenha = New System.Windows.Forms.CheckBox()
        Me.TxtBx_Senha = New System.Windows.Forms.TextBox()
        Me.Lbl_Senha = New System.Windows.Forms.Label()
        Me.TxtBx_Email = New System.Windows.Forms.TextBox()
        Me.Lbl_Email = New System.Windows.Forms.Label()
        Me.Pnl_DadosDoSistema = New System.Windows.Forms.Panel()
        Me.Lbl_NomeDoModulo = New System.Windows.Forms.Label()
        Me.PctrBx_LogormarcaDoSistema = New System.Windows.Forms.PictureBox()
        Me.Pnl_BotoesDeAcao.SuspendLayout()
        Me.Pnl_DadosDeLogin.SuspendLayout()
        Me.Pnl_DadosDoSistema.SuspendLayout()
        CType(Me.PctrBx_LogormarcaDoSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl_BotoesDeAcao
        '
        Me.Pnl_BotoesDeAcao.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Entrar)
        Me.Pnl_BotoesDeAcao.Controls.Add(Me.Bttn_Cancelar)
        Me.Pnl_BotoesDeAcao.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_BotoesDeAcao.Location = New System.Drawing.Point(0, 229)
        Me.Pnl_BotoesDeAcao.Name = "Pnl_BotoesDeAcao"
        Me.Pnl_BotoesDeAcao.Padding = New System.Windows.Forms.Padding(20)
        Me.Pnl_BotoesDeAcao.Size = New System.Drawing.Size(262, 75)
        Me.Pnl_BotoesDeAcao.TabIndex = 1
        '
        'Bttn_Entrar
        '
        Me.Bttn_Entrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bttn_Entrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Entrar.Location = New System.Drawing.Point(122, 20)
        Me.Bttn_Entrar.Name = "Bttn_Entrar"
        Me.Bttn_Entrar.Size = New System.Drawing.Size(120, 35)
        Me.Bttn_Entrar.TabIndex = 0
        Me.Bttn_Entrar.Text = "Entrar"
        Me.Bttn_Entrar.UseVisualStyleBackColor = True
        '
        'Bttn_Cancelar
        '
        Me.Bttn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Bttn_Cancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Bttn_Cancelar.Location = New System.Drawing.Point(20, 20)
        Me.Bttn_Cancelar.Name = "Bttn_Cancelar"
        Me.Bttn_Cancelar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Cancelar.TabIndex = 1
        Me.Bttn_Cancelar.Text = "Cancelar"
        Me.Bttn_Cancelar.UseVisualStyleBackColor = True
        '
        'Pnl_DadosDeLogin
        '
        Me.Pnl_DadosDeLogin.Controls.Add(Me.ChckBx_VisualizarSenha)
        Me.Pnl_DadosDeLogin.Controls.Add(Me.TxtBx_Senha)
        Me.Pnl_DadosDeLogin.Controls.Add(Me.Lbl_Senha)
        Me.Pnl_DadosDeLogin.Controls.Add(Me.TxtBx_Email)
        Me.Pnl_DadosDeLogin.Controls.Add(Me.Lbl_Email)
        Me.Pnl_DadosDeLogin.Controls.Add(Me.Pnl_DadosDoSistema)
        Me.Pnl_DadosDeLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_DadosDeLogin.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_DadosDeLogin.Name = "Pnl_DadosDeLogin"
        Me.Pnl_DadosDeLogin.Padding = New System.Windows.Forms.Padding(20)
        Me.Pnl_DadosDeLogin.Size = New System.Drawing.Size(262, 229)
        Me.Pnl_DadosDeLogin.TabIndex = 0
        '
        'ChckBx_VisualizarSenha
        '
        Me.ChckBx_VisualizarSenha.AutoSize = True
        Me.ChckBx_VisualizarSenha.Location = New System.Drawing.Point(224, 186)
        Me.ChckBx_VisualizarSenha.Name = "ChckBx_VisualizarSenha"
        Me.ChckBx_VisualizarSenha.Size = New System.Drawing.Size(15, 14)
        Me.ChckBx_VisualizarSenha.TabIndex = 2
        Me.ChckBx_VisualizarSenha.UseVisualStyleBackColor = True
        '
        'TxtBx_Senha
        '
        Me.TxtBx_Senha.Dock = System.Windows.Forms.DockStyle.Left
        Me.TxtBx_Senha.Location = New System.Drawing.Point(20, 182)
        Me.TxtBx_Senha.Name = "TxtBx_Senha"
        Me.TxtBx_Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBx_Senha.Size = New System.Drawing.Size(198, 20)
        Me.TxtBx_Senha.TabIndex = 1
        Me.TxtBx_Senha.Tag = "Senha"
        Me.TxtBx_Senha.Text = "102030"
        '
        'Lbl_Senha
        '
        Me.Lbl_Senha.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_Senha.Location = New System.Drawing.Point(20, 157)
        Me.Lbl_Senha.Name = "Lbl_Senha"
        Me.Lbl_Senha.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Lbl_Senha.Size = New System.Drawing.Size(222, 25)
        Me.Lbl_Senha.TabIndex = 3
        Me.Lbl_Senha.Text = "Senha"
        Me.Lbl_Senha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtBx_Email
        '
        Me.TxtBx_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBx_Email.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtBx_Email.Location = New System.Drawing.Point(20, 137)
        Me.TxtBx_Email.Name = "TxtBx_Email"
        Me.TxtBx_Email.Size = New System.Drawing.Size(222, 20)
        Me.TxtBx_Email.TabIndex = 0
        Me.TxtBx_Email.Tag = "E-mail"
        Me.TxtBx_Email.Text = "jhefferson.silva@mg.senac.br"
        '
        'Lbl_Email
        '
        Me.Lbl_Email.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_Email.Location = New System.Drawing.Point(20, 112)
        Me.Lbl_Email.Name = "Lbl_Email"
        Me.Lbl_Email.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Lbl_Email.Size = New System.Drawing.Size(222, 25)
        Me.Lbl_Email.TabIndex = 1
        Me.Lbl_Email.Text = "E-mail"
        Me.Lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pnl_DadosDoSistema
        '
        Me.Pnl_DadosDoSistema.Controls.Add(Me.Lbl_NomeDoModulo)
        Me.Pnl_DadosDoSistema.Controls.Add(Me.PctrBx_LogormarcaDoSistema)
        Me.Pnl_DadosDoSistema.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_DadosDoSistema.Location = New System.Drawing.Point(20, 20)
        Me.Pnl_DadosDoSistema.Name = "Pnl_DadosDoSistema"
        Me.Pnl_DadosDoSistema.Padding = New System.Windows.Forms.Padding(20)
        Me.Pnl_DadosDoSistema.Size = New System.Drawing.Size(222, 92)
        Me.Pnl_DadosDoSistema.TabIndex = 0
        '
        'Lbl_NomeDoModulo
        '
        Me.Lbl_NomeDoModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_NomeDoModulo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_NomeDoModulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Lbl_NomeDoModulo.Location = New System.Drawing.Point(20, 60)
        Me.Lbl_NomeDoModulo.Name = "Lbl_NomeDoModulo"
        Me.Lbl_NomeDoModulo.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.Lbl_NomeDoModulo.Size = New System.Drawing.Size(182, 20)
        Me.Lbl_NomeDoModulo.TabIndex = 2
        Me.Lbl_NomeDoModulo.Text = "Departamento Pessoal (DP)"
        Me.Lbl_NomeDoModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctrBx_LogormarcaDoSistema
        '
        Me.PctrBx_LogormarcaDoSistema.BackgroundImage = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.Logormarca_AutoFlow
        Me.PctrBx_LogormarcaDoSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PctrBx_LogormarcaDoSistema.Dock = System.Windows.Forms.DockStyle.Top
        Me.PctrBx_LogormarcaDoSistema.Location = New System.Drawing.Point(20, 20)
        Me.PctrBx_LogormarcaDoSistema.Name = "PctrBx_LogormarcaDoSistema"
        Me.PctrBx_LogormarcaDoSistema.Size = New System.Drawing.Size(182, 40)
        Me.PctrBx_LogormarcaDoSistema.TabIndex = 0
        Me.PctrBx_LogormarcaDoSistema.TabStop = False
        '
        'Frm__Login
        '
        Me.AcceptButton = Me.Bttn_Entrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Bttn_Cancelar
        Me.ClientSize = New System.Drawing.Size(262, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pnl_DadosDeLogin)
        Me.Controls.Add(Me.Pnl_BotoesDeAcao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm__Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Pnl_BotoesDeAcao.ResumeLayout(False)
        Me.Pnl_DadosDeLogin.ResumeLayout(False)
        Me.Pnl_DadosDeLogin.PerformLayout()
        Me.Pnl_DadosDoSistema.ResumeLayout(False)
        CType(Me.PctrBx_LogormarcaDoSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_BotoesDeAcao As Panel
    Friend WithEvents Bttn_Entrar As Button
    Friend WithEvents Bttn_Cancelar As Button
    Friend WithEvents Pnl_DadosDeLogin As Panel
    Friend WithEvents Pnl_DadosDoSistema As Panel
    Friend WithEvents PctrBx_LogormarcaDoSistema As PictureBox
    Friend WithEvents TxtBx_Email As TextBox
    Friend WithEvents Lbl_Email As Label
    Friend WithEvents TxtBx_Senha As TextBox
    Friend WithEvents Lbl_Senha As Label
    Friend WithEvents Lbl_NomeDoModulo As Label
    Friend WithEvents ChckBx_VisualizarSenha As CheckBox
End Class
