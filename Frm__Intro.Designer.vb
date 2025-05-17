<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm__Intro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm__Intro))
        Me.PrgrssBr_BarraDeCarregamento = New System.Windows.Forms.ProgressBar()
        Me.Lbl_VersaoSistema = New System.Windows.Forms.Label()
        Me.Lbl_ModuloSistema = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PrgrssBr_BarraDeCarregamento
        '
        Me.PrgrssBr_BarraDeCarregamento.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PrgrssBr_BarraDeCarregamento.Location = New System.Drawing.Point(15, 334)
        Me.PrgrssBr_BarraDeCarregamento.Name = "PrgrssBr_BarraDeCarregamento"
        Me.PrgrssBr_BarraDeCarregamento.Size = New System.Drawing.Size(604, 5)
        Me.PrgrssBr_BarraDeCarregamento.TabIndex = 0
        '
        'Lbl_VersaoSistema
        '
        Me.Lbl_VersaoSistema.AutoSize = True
        Me.Lbl_VersaoSistema.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_VersaoSistema.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_VersaoSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Lbl_VersaoSistema.Location = New System.Drawing.Point(36, 48)
        Me.Lbl_VersaoSistema.Name = "Lbl_VersaoSistema"
        Me.Lbl_VersaoSistema.Size = New System.Drawing.Size(31, 14)
        Me.Lbl_VersaoSistema.TabIndex = 1
        Me.Lbl_VersaoSistema.Text = "1.0.0"
        '
        'Lbl_ModuloSistema
        '
        Me.Lbl_ModuloSistema.AutoSize = True
        Me.Lbl_ModuloSistema.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_ModuloSistema.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ModuloSistema.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Lbl_ModuloSistema.Location = New System.Drawing.Point(36, 81)
        Me.Lbl_ModuloSistema.Name = "Lbl_ModuloSistema"
        Me.Lbl_ModuloSistema.Size = New System.Drawing.Size(144, 14)
        Me.Lbl_ModuloSistema.TabIndex = 2
        Me.Lbl_ModuloSistema.Text = "Departamento Pessoal (DP)"
        '
        'Frm__Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.AutoFlow___Departamento_Pessoal__DP_.My.Resources.Resources.bnnr__BackgroundIntroModuloDP
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 354)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_ModuloSistema)
        Me.Controls.Add(Me.Lbl_VersaoSistema)
        Me.Controls.Add(Me.PrgrssBr_BarraDeCarregamento)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm__Intro"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrgrssBr_BarraDeCarregamento As ProgressBar
    Friend WithEvents Lbl_VersaoSistema As Label
    Friend WithEvents Lbl_ModuloSistema As Label
End Class
