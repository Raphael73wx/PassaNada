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
        Me.gpMorador = New System.Windows.Forms.GroupBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.lblWhatsapp = New System.Windows.Forms.Label()
        Me.pcVisitantes = New System.Windows.Forms.PictureBox()
        Me.lblNomem = New System.Windows.Forms.Label()
        Me.txtNomem = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblWhatsappm = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtWhatsappM = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtPlaca = New System.Windows.Forms.MaskedTextBox()
        Me.msMoradores.SuspendLayout()
        Me.gpVisitantes.SuspendLayout()
        Me.gpMorador.SuspendLayout()
        CType(Me.pcVisitantes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gpVisitantes.Controls.Add(Me.txtPlaca)
        Me.gpVisitantes.Controls.Add(Me.MaskedTextBox2)
        Me.gpVisitantes.Controls.Add(Me.MaskedTextBox1)
        Me.gpVisitantes.Controls.Add(Me.pcVisitantes)
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
        'gpMorador
        '
        Me.gpMorador.Controls.Add(Me.txtWhatsappM)
        Me.gpMorador.Controls.Add(Me.lblWhatsappm)
        Me.gpMorador.Controls.Add(Me.lblEndereco)
        Me.gpMorador.Controls.Add(Me.txtEndereco)
        Me.gpMorador.Controls.Add(Me.btnBuscar)
        Me.gpMorador.Controls.Add(Me.lblNomem)
        Me.gpMorador.Controls.Add(Me.txtBuscar)
        Me.gpMorador.Controls.Add(Me.lblBuscar)
        Me.gpMorador.Controls.Add(Me.txtNomem)
        Me.gpMorador.Location = New System.Drawing.Point(12, 231)
        Me.gpMorador.Name = "gpMorador"
        Me.gpMorador.Size = New System.Drawing.Size(776, 155)
        Me.gpMorador.TabIndex = 4
        Me.gpMorador.TabStop = False
        Me.gpMorador.Text = "Morador"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(10, 49)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(230, 20)
        Me.txtNome.TabIndex = 0
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
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(265, 33)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 2
        Me.lblCpf.Text = "CPF"
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
        'lblWhatsapp
        '
        Me.lblWhatsapp.AutoSize = True
        Me.lblWhatsapp.Location = New System.Drawing.Point(7, 78)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(56, 13)
        Me.lblWhatsapp.TabIndex = 7
        Me.lblWhatsapp.Text = "Whatsapp"
        '
        'pcVisitantes
        '
        Me.pcVisitantes.BackgroundImage = CType(resources.GetObject("pcVisitantes.BackgroundImage"), System.Drawing.Image)
        Me.pcVisitantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcVisitantes.Location = New System.Drawing.Point(534, 19)
        Me.pcVisitantes.Name = "pcVisitantes"
        Me.pcVisitantes.Size = New System.Drawing.Size(100, 109)
        Me.pcVisitantes.TabIndex = 8
        Me.pcVisitantes.TabStop = False
        '
        'lblNomem
        '
        Me.lblNomem.AutoSize = True
        Me.lblNomem.Location = New System.Drawing.Point(305, 32)
        Me.lblNomem.Name = "lblNomem"
        Me.lblNomem.Size = New System.Drawing.Size(35, 13)
        Me.lblNomem.TabIndex = 10
        Me.lblNomem.Text = "Nome"
        '
        'txtNomem
        '
        Me.txtNomem.Location = New System.Drawing.Point(308, 50)
        Me.txtNomem.Name = "txtNomem"
        Me.txtNomem.ReadOnly = True
        Me.txtNomem.Size = New System.Drawing.Size(236, 20)
        Me.txtNomem.TabIndex = 9
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(7, 33)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(30, 15)
        Me.lblBuscar.TabIndex = 32
        Me.lblBuscar.Text = "CPF"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(10, 51)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(179, 20)
        Me.txtBuscar.TabIndex = 33
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(208, 48)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 34
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(7, 87)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(52, 13)
        Me.lblEndereco.TabIndex = 36
        Me.lblEndereco.Text = "endereco"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(10, 103)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.ReadOnly = True
        Me.txtEndereco.Size = New System.Drawing.Size(303, 20)
        Me.txtEndereco.TabIndex = 35
        '
        'lblWhatsappm
        '
        Me.lblWhatsappm.AutoSize = True
        Me.lblWhatsappm.Location = New System.Drawing.Point(565, 34)
        Me.lblWhatsappm.Name = "lblWhatsappm"
        Me.lblWhatsappm.Size = New System.Drawing.Size(56, 13)
        Me.lblWhatsappm.TabIndex = 10
        Me.lblWhatsappm.Text = "Whatsapp"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'txtWhatsappM
        '
        Me.txtWhatsappM.Location = New System.Drawing.Point(568, 50)
        Me.txtWhatsappM.Mask = "(00)0,000-0000"
        Me.txtWhatsappM.Name = "txtWhatsappM"
        Me.txtWhatsappM.ReadOnly = True
        Me.txtWhatsappM.Size = New System.Drawing.Size(186, 20)
        Me.txtWhatsappM.TabIndex = 37
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(259, 49)
        Me.MaskedTextBox1.Mask = "000,000,000-00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 9
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(10, 94)
        Me.MaskedTextBox2.Mask = "(00)0.000-0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(179, 20)
        Me.MaskedTextBox2.TabIndex = 10
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(208, 94)
        Me.txtPlaca.Mask = "000-0000"
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(151, 20)
        Me.txtPlaca.TabIndex = 11
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
        Me.gpMorador.ResumeLayout(False)
        Me.gpMorador.PerformLayout()
        CType(Me.pcVisitantes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pcVisitantes As PictureBox
    Friend WithEvents lblNomem As Label
    Friend WithEvents txtNomem As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As MaskedTextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtPlaca As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents txtWhatsappM As MaskedTextBox
    Friend WithEvents lblWhatsappm As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
