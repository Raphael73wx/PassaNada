<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVisitantes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVisitantes))
        Me.msMoradores = New System.Windows.Forms.MenuStrip()
        Me.mnNovo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalvar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExcluir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFechar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCadastro = New System.Windows.Forms.Label()
        Me.gpVisitantes = New System.Windows.Forms.GroupBox()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.txtPlaca = New System.Windows.Forms.MaskedTextBox()
        Me.txtWhatsapp = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.imgfoto = New System.Windows.Forms.PictureBox()
        Me.lblWhatsapp = New System.Windows.Forms.Label()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.gpMorador = New System.Windows.Forms.GroupBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.cbMorador = New System.Windows.Forms.ComboBox()
        Me.txtWhatsappM = New System.Windows.Forms.MaskedTextBox()
        Me.lblWhatsappm = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.lblMorador = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.msMoradores.SuspendLayout()
        Me.gpVisitantes.SuspendLayout()
        CType(Me.imgfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpMorador.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMoradores
        '
        Me.msMoradores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnNovo, Me.mnSalvar, Me.mnExcluir, Me.mnFechar})
        Me.msMoradores.Location = New System.Drawing.Point(0, 0)
        Me.msMoradores.Name = "msMoradores"
        Me.msMoradores.Size = New System.Drawing.Size(800, 39)
        Me.msMoradores.TabIndex = 1
        Me.msMoradores.Text = "MenuStrip1"
        '
        'mnNovo
        '
        Me.mnNovo.Image = Global.PassaNada.My.Resources.Resources.Aha_Soft_Free_3d_Glossy_Interface_Create_32
        Me.mnNovo.Name = "mnNovo"
        Me.mnNovo.Size = New System.Drawing.Size(48, 35)
        Me.mnNovo.Text = "&Novo"
        Me.mnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnSalvar
        '
        Me.mnSalvar.Image = Global.PassaNada.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_document_save_32
        Me.mnSalvar.Name = "mnSalvar"
        Me.mnSalvar.Size = New System.Drawing.Size(50, 35)
        Me.mnSalvar.Text = "&Salvar"
        Me.mnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnExcluir
        '
        Me.mnExcluir.Image = Global.PassaNada.My.Resources.Resources.Wwalczyszyn_Iwindows_Recycle_Bin_32
        Me.mnExcluir.Name = "mnExcluir"
        Me.mnExcluir.Size = New System.Drawing.Size(54, 35)
        Me.mnExcluir.Text = "&Excluir"
        Me.mnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnFechar
        '
        Me.mnFechar.Image = Global.PassaNada.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Close_2_32
        Me.mnFechar.Name = "mnFechar"
        Me.mnFechar.Size = New System.Drawing.Size(54, 35)
        Me.mnFechar.Text = "&Fechar"
        Me.mnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'lblCadastro
        '
        Me.lblCadastro.AutoSize = True
        Me.lblCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadastro.Location = New System.Drawing.Point(12, 50)
        Me.lblCadastro.Name = "lblCadastro"
        Me.lblCadastro.Size = New System.Drawing.Size(103, 25)
        Me.lblCadastro.TabIndex = 2
        Me.lblCadastro.Text = "cadastro"
        '
        'gpVisitantes
        '
        Me.gpVisitantes.Controls.Add(Me.btnFoto)
        Me.gpVisitantes.Controls.Add(Me.txtPlaca)
        Me.gpVisitantes.Controls.Add(Me.txtWhatsapp)
        Me.gpVisitantes.Controls.Add(Me.txtCpf)
        Me.gpVisitantes.Controls.Add(Me.imgfoto)
        Me.gpVisitantes.Controls.Add(Me.lblWhatsapp)
        Me.gpVisitantes.Controls.Add(Me.lblPlaca)
        Me.gpVisitantes.Controls.Add(Me.lblCpf)
        Me.gpVisitantes.Controls.Add(Me.lblNome)
        Me.gpVisitantes.Controls.Add(Me.txtNome)
        Me.gpVisitantes.Location = New System.Drawing.Point(12, 78)
        Me.gpVisitantes.Name = "gpVisitantes"
        Me.gpVisitantes.Size = New System.Drawing.Size(776, 147)
        Me.gpVisitantes.TabIndex = 3
        Me.gpVisitantes.TabStop = False
        Me.gpVisitantes.Text = "Visitantes"
        '
        'btnFoto
        '
        Me.btnFoto.Location = New System.Drawing.Point(635, 118)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(75, 23)
        Me.btnFoto.TabIndex = 12
        Me.btnFoto.Text = "Foto"
        Me.btnFoto.UseVisualStyleBackColor = True
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(208, 94)
        Me.txtPlaca.Mask = "___-____"
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(151, 20)
        Me.txtPlaca.TabIndex = 11
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(10, 94)
        Me.txtWhatsapp.Mask = "(00)0.000-0000"
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(179, 20)
        Me.txtWhatsapp.TabIndex = 10
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(259, 49)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(100, 20)
        Me.txtCpf.TabIndex = 9
        '
        'imgfoto
        '
        Me.imgfoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgfoto.Location = New System.Drawing.Point(622, 17)
        Me.imgfoto.Name = "imgfoto"
        Me.imgfoto.Size = New System.Drawing.Size(100, 95)
        Me.imgfoto.TabIndex = 8
        Me.imgfoto.TabStop = False
        '
        'lblWhatsapp
        '
        Me.lblWhatsapp.AutoSize = True
        Me.lblWhatsapp.Location = New System.Drawing.Point(7, 78)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(56, 13)
        Me.lblWhatsapp.TabIndex = 7
        Me.lblWhatsapp.Text = "Whatsapp"
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.Location = New System.Drawing.Point(206, 78)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(86, 13)
        Me.lblPlaca.TabIndex = 4
        Me.lblPlaca.Text = "Placa do veiculo"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(265, 33)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 2
        Me.lblCpf.Text = "CPF"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(7, 33)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(10, 49)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(230, 20)
        Me.txtNome.TabIndex = 0
        '
        'gpMorador
        '
        Me.gpMorador.Controls.Add(Me.lblComplemento)
        Me.gpMorador.Controls.Add(Me.txtComplemento)
        Me.gpMorador.Controls.Add(Me.cbMorador)
        Me.gpMorador.Controls.Add(Me.txtWhatsappM)
        Me.gpMorador.Controls.Add(Me.lblWhatsappm)
        Me.gpMorador.Controls.Add(Me.lblNumero)
        Me.gpMorador.Controls.Add(Me.txtNumero)
        Me.gpMorador.Controls.Add(Me.lblLogradouro)
        Me.gpMorador.Controls.Add(Me.lblMorador)
        Me.gpMorador.Controls.Add(Me.txtLogradouro)
        Me.gpMorador.Location = New System.Drawing.Point(12, 231)
        Me.gpMorador.Name = "gpMorador"
        Me.gpMorador.Size = New System.Drawing.Size(776, 155)
        Me.gpMorador.TabIndex = 4
        Me.gpMorador.TabStop = False
        Me.gpMorador.Text = "Morador"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(86, 87)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(71, 13)
        Me.lblComplemento.TabIndex = 40
        Me.lblComplemento.Text = "Complemento"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(89, 103)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.ReadOnly = True
        Me.txtComplemento.Size = New System.Drawing.Size(203, 20)
        Me.txtComplemento.TabIndex = 39
        '
        'cbMorador
        '
        Me.cbMorador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMorador.FormattingEnabled = True
        Me.cbMorador.Location = New System.Drawing.Point(10, 50)
        Me.cbMorador.Name = "cbMorador"
        Me.cbMorador.Size = New System.Drawing.Size(277, 21)
        Me.cbMorador.TabIndex = 38
        '
        'txtWhatsappM
        '
        Me.txtWhatsappM.Location = New System.Drawing.Point(549, 51)
        Me.txtWhatsappM.Mask = "(00)0,000-0000"
        Me.txtWhatsappM.Name = "txtWhatsappM"
        Me.txtWhatsappM.ReadOnly = True
        Me.txtWhatsappM.Size = New System.Drawing.Size(186, 20)
        Me.txtWhatsappM.TabIndex = 37
        '
        'lblWhatsappm
        '
        Me.lblWhatsappm.AutoSize = True
        Me.lblWhatsappm.Location = New System.Drawing.Point(546, 35)
        Me.lblWhatsappm.Name = "lblWhatsappm"
        Me.lblWhatsappm.Size = New System.Drawing.Size(56, 13)
        Me.lblWhatsappm.TabIndex = 10
        Me.lblWhatsappm.Text = "Whatsapp"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(7, 87)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(47, 13)
        Me.lblNumero.TabIndex = 36
        Me.lblNumero.Text = "Número:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(5, 103)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(69, 20)
        Me.txtNumero.TabIndex = 35
        '
        'lblLogradouro
        '
        Me.lblLogradouro.AutoSize = True
        Me.lblLogradouro.Location = New System.Drawing.Point(298, 35)
        Me.lblLogradouro.Name = "lblLogradouro"
        Me.lblLogradouro.Size = New System.Drawing.Size(61, 13)
        Me.lblLogradouro.TabIndex = 10
        Me.lblLogradouro.Text = "Logradouro"
        '
        'lblMorador
        '
        Me.lblMorador.AutoSize = True
        Me.lblMorador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMorador.Location = New System.Drawing.Point(7, 33)
        Me.lblMorador.Name = "lblMorador"
        Me.lblMorador.Size = New System.Drawing.Size(54, 15)
        Me.lblMorador.TabIndex = 32
        Me.lblMorador.Text = "Morador"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(293, 51)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.ReadOnly = True
        Me.txtLogradouro.Size = New System.Drawing.Size(236, 20)
        Me.txtLogradouro.TabIndex = 9
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FrmVisitantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gpMorador)
        Me.Controls.Add(Me.gpVisitantes)
        Me.Controls.Add(Me.lblCadastro)
        Me.Controls.Add(Me.msMoradores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVisitantes"
        Me.Text = "frmVisitantes"
        Me.msMoradores.ResumeLayout(False)
        Me.msMoradores.PerformLayout()
        Me.gpVisitantes.ResumeLayout(False)
        Me.gpVisitantes.PerformLayout()
        CType(Me.imgfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpMorador.ResumeLayout(False)
        Me.gpMorador.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMoradores As MenuStrip
    Friend WithEvents mnNovo As ToolStripMenuItem
    Friend WithEvents mnSalvar As ToolStripMenuItem
    Friend WithEvents mnExcluir As ToolStripMenuItem
    Friend WithEvents mnFechar As ToolStripMenuItem
    Friend WithEvents lblCadastro As Label
    Friend WithEvents gpVisitantes As GroupBox
    Friend WithEvents lblWhatsapp As Label
    Friend WithEvents lblPlaca As Label
    Friend WithEvents lblCpf As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents gpMorador As GroupBox
    Friend WithEvents imgfoto As PictureBox
    Friend WithEvents lblLogradouro As Label
    Friend WithEvents txtLogradouro As TextBox
    Friend WithEvents lblMorador As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtPlaca As MaskedTextBox
    Friend WithEvents txtWhatsapp As MaskedTextBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtWhatsappM As MaskedTextBox
    Friend WithEvents lblWhatsappm As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnFoto As Button
    Friend WithEvents cbMorador As ComboBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtComplemento As TextBox
End Class
