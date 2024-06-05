<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelainicial
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
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnVisitantes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnHistorico = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMoradores = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFechar = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pcTelaini = New System.Windows.Forms.PictureBox()
        Me.btnHistorico = New System.Windows.Forms.Button()
        Me.btnMoradores = New System.Windows.Forms.Button()
        Me.BtnVisitantes = New System.Windows.Forms.Button()
        Me.MenuStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.pcTelaini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnVisitantes, Me.mnHistorico, Me.mnMoradores, Me.mnFechar})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 39)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'mnVisitantes
        '
        Me.mnVisitantes.Image = Global.PassaNada.My.Resources.Resources.Pictogrammers_Material_Exit_run_32
        Me.mnVisitantes.Name = "mnVisitantes"
        Me.mnVisitantes.Size = New System.Drawing.Size(69, 35)
        Me.mnVisitantes.Text = "&Visitantes"
        Me.mnVisitantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnHistorico
        '
        Me.mnHistorico.Image = Global.PassaNada.My.Resources.Resources.Treetog_Junior_Folder_documents_32
        Me.mnHistorico.Name = "mnHistorico"
        Me.mnHistorico.Size = New System.Drawing.Size(67, 35)
        Me.mnHistorico.Text = "&Histórico"
        Me.mnHistorico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnMoradores
        '
        Me.mnMoradores.Image = Global.PassaNada.My.Resources.Resources.Awicons_Vista_Artistic_4_Disabled_Home_32
        Me.mnMoradores.Name = "mnMoradores"
        Me.mnMoradores.Size = New System.Drawing.Size(76, 35)
        Me.mnMoradores.Text = "&Moradores"
        Me.mnMoradores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnFechar
        '
        Me.mnFechar.Image = Global.PassaNada.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Close_2_32
        Me.mnFechar.Name = "mnFechar"
        Me.mnFechar.Size = New System.Drawing.Size(54, 35)
        Me.mnFechar.Text = "&Fechar"
        Me.mnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(271, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripUsuario
        '
        Me.ToolStripUsuario.Name = "ToolStripUsuario"
        Me.ToolStripUsuario.Size = New System.Drawing.Size(0, 17)
        '
        'pcTelaini
        '
        Me.pcTelaini.BackgroundImage = Global.PassaNada.My.Resources.Resources.t
        Me.pcTelaini.Dock = System.Windows.Forms.DockStyle.Right
        Me.pcTelaini.Location = New System.Drawing.Point(271, 39)
        Me.pcTelaini.Name = "pcTelaini"
        Me.pcTelaini.Size = New System.Drawing.Size(529, 411)
        Me.pcTelaini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcTelaini.TabIndex = 3
        Me.pcTelaini.TabStop = False
        '
        'btnHistorico
        '
        Me.btnHistorico.Image = Global.PassaNada.My.Resources.Resources.Treetog_Junior_Folder_documents_32
        Me.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHistorico.Location = New System.Drawing.Point(12, 265)
        Me.btnHistorico.Name = "btnHistorico"
        Me.btnHistorico.Size = New System.Drawing.Size(253, 101)
        Me.btnHistorico.TabIndex = 2
        Me.btnHistorico.Text = "Historico"
        Me.btnHistorico.UseVisualStyleBackColor = True
        '
        'btnMoradores
        '
        Me.btnMoradores.Image = Global.PassaNada.My.Resources.Resources.Awicons_Vista_Artistic_4_Disabled_Home_32
        Me.btnMoradores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMoradores.Location = New System.Drawing.Point(12, 51)
        Me.btnMoradores.Name = "btnMoradores"
        Me.btnMoradores.Size = New System.Drawing.Size(253, 102)
        Me.btnMoradores.TabIndex = 1
        Me.btnMoradores.Text = "Moradores"
        Me.btnMoradores.UseVisualStyleBackColor = True
        '
        'BtnVisitantes
        '
        Me.BtnVisitantes.Image = Global.PassaNada.My.Resources.Resources.Pictogrammers_Material_Exit_run_32
        Me.BtnVisitantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnVisitantes.Location = New System.Drawing.Point(12, 159)
        Me.BtnVisitantes.Name = "BtnVisitantes"
        Me.BtnVisitantes.Size = New System.Drawing.Size(253, 100)
        Me.BtnVisitantes.TabIndex = 0
        Me.BtnVisitantes.Text = "Visitantes"
        Me.BtnVisitantes.UseVisualStyleBackColor = True
        '
        'frmTelainicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pcTelaini)
        Me.Controls.Add(Me.btnHistorico)
        Me.Controls.Add(Me.btnMoradores)
        Me.Controls.Add(Me.BtnVisitantes)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "frmTelainicial"
        Me.Text = "Tela Inicial"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.pcTelaini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVisitantes As Button
    Friend WithEvents btnMoradores As Button
    Friend WithEvents btnHistorico As Button
    Friend WithEvents pcTelaini As PictureBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents mnVisitantes As ToolStripMenuItem
    Friend WithEvents mnHistorico As ToolStripMenuItem
    Friend WithEvents mnMoradores As ToolStripMenuItem
    Friend WithEvents mnFechar As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripUsuario As ToolStripStatusLabel
End Class
