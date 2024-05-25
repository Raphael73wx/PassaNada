<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelaLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelaLogin))
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pcForm = New System.Windows.Forms.PictureBox()
        Me.btnLimpar = New System.Windows.Forms.PictureBox()
        CType(Me.pcForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLimpar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(265, 281)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(59, 21)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "E-mail:"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.Location = New System.Drawing.Point(265, 337)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(61, 20)
        Me.lblSenha.TabIndex = 2
        Me.lblSenha.Text = "Senha:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(269, 305)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(191, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(269, 360)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(191, 20)
        Me.txtSenha.TabIndex = 4
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(269, 386)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrar.TabIndex = 5
        Me.btnEntrar.Text = "entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'btnLimpa
        '
        Me.btnLimpa.Location = New System.Drawing.Point(385, 384)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpa.TabIndex = 6
        Me.btnLimpa.Text = "Limpar"
        Me.btnLimpa.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(301, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(143, 25)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Tela de Login"
        '
        'pcForm
        '
        Me.pcForm.BackgroundImage = Global.PassaNada.My.Resources.Resources.t1
        Me.pcForm.Location = New System.Drawing.Point(259, 51)
        Me.pcForm.Name = "pcForm"
        Me.pcForm.Size = New System.Drawing.Size(221, 210)
        Me.pcForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcForm.TabIndex = 8
        Me.pcForm.TabStop = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackgroundImage = Global.PassaNada.My.Resources.Resources.t
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.No
        Me.btnLimpar.Location = New System.Drawing.Point(-2, 1)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(804, 450)
        Me.btnLimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnLimpar.TabIndex = 0
        Me.btnLimpar.TabStop = False
        '
        'frmTelaLogin
        '
        Me.AcceptButton = Me.btnEntrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pcForm)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnLimpar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTelaLogin"
        Me.Text = "Form1"
        CType(Me.pcForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLimpar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpar As PictureBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents btnLimpa As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pcForm As PictureBox
End Class
