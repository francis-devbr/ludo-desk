<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadUser
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

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.txtUNome = New System.Windows.Forms.TextBox()
        Me.lblUNome = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lsvReduzida = New System.Windows.Forms.ListView()
        Me.lblCSenha = New System.Windows.Forms.Label()
        Me.txtCSenha = New System.Windows.Forms.TextBox()
        Me.cboPerfil = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lblPNome = New System.Windows.Forms.Label()
        Me.txtPNome = New System.Windows.Forms.TextBox()
        Me.gb.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCPF
        '
        Me.txtCPF.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPF.Location = New System.Drawing.Point(10, 134)
        Me.txtCPF.MaxLength = 14
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(221, 27)
        Me.txtCPF.TabIndex = 0
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(11, 114)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(33, 19)
        Me.lblCPF.TabIndex = 123
        Me.lblCPF.Text = "CPF"
        '
        'txtUNome
        '
        Me.txtUNome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUNome.Location = New System.Drawing.Point(10, 84)
        Me.txtUNome.MaxLength = 7
        Me.txtUNome.Name = "txtUNome"
        Me.txtUNome.Size = New System.Drawing.Size(221, 27)
        Me.txtUNome.TabIndex = 1
        '
        'lblUNome
        '
        Me.lblUNome.AutoSize = True
        Me.lblUNome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUNome.Location = New System.Drawing.Point(7, 66)
        Me.lblUNome.Name = "lblUNome"
        Me.lblUNome.Size = New System.Drawing.Size(128, 19)
        Me.lblUNome.TabIndex = 120
        Me.lblUNome.Text = "Ultimo Sobrenome"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.Location = New System.Drawing.Point(7, 164)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(197, 19)
        Me.lblSenha.TabIndex = 123
        Me.lblSenha.Text = "Senha (Mínimo 4 Caracteres)"
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(11, 186)
        Me.txtSenha.MaxLength = 8
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(221, 27)
        Me.txtSenha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 19)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Perfil"
        '
        'lsvReduzida
        '
        Me.lsvReduzida.Location = New System.Drawing.Point(324, 42)
        Me.lsvReduzida.Name = "lsvReduzida"
        Me.lsvReduzida.Size = New System.Drawing.Size(249, 370)
        Me.lsvReduzida.TabIndex = 124
        Me.lsvReduzida.TabStop = False
        Me.lsvReduzida.UseCompatibleStateImageBehavior = False
        '
        'lblCSenha
        '
        Me.lblCSenha.AutoSize = True
        Me.lblCSenha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCSenha.Location = New System.Drawing.Point(7, 216)
        Me.lblCSenha.Name = "lblCSenha"
        Me.lblCSenha.Size = New System.Drawing.Size(94, 19)
        Me.lblCSenha.TabIndex = 123
        Me.lblCSenha.Text = "Repita Senha"
        '
        'txtCSenha
        '
        Me.txtCSenha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSenha.Location = New System.Drawing.Point(11, 238)
        Me.txtCSenha.MaxLength = 8
        Me.txtCSenha.Name = "txtCSenha"
        Me.txtCSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCSenha.Size = New System.Drawing.Size(221, 27)
        Me.txtCSenha.TabIndex = 3
        '
        'cboPerfil
        '
        Me.cboPerfil.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPerfil.FormattingEnabled = True
        Me.cboPerfil.Location = New System.Drawing.Point(10, 290)
        Me.cboPerfil.Name = "cboPerfil"
        Me.cboPerfil.Size = New System.Drawing.Size(221, 27)
        Me.cboPerfil.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 22)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "Cadastro de Usuários"
        '
        'gb
        '
        Me.gb.Controls.Add(Me.cboPerfil)
        Me.gb.Controls.Add(Me.Label2)
        Me.gb.Controls.Add(Me.txtCSenha)
        Me.gb.Controls.Add(Me.lblCSenha)
        Me.gb.Controls.Add(Me.txtSenha)
        Me.gb.Controls.Add(Me.lblSenha)
        Me.gb.Controls.Add(Me.txtPNome)
        Me.gb.Controls.Add(Me.lblPNome)
        Me.gb.Controls.Add(Me.txtCPF)
        Me.gb.Controls.Add(Me.lblCPF)
        Me.gb.Controls.Add(Me.txtUNome)
        Me.gb.Controls.Add(Me.lblUNome)
        Me.gb.Enabled = False
        Me.gb.Location = New System.Drawing.Point(55, 82)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(244, 330)
        Me.gb.TabIndex = 140
        Me.gb.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Panel1.Controls.Add(Me.gb)
        Me.Panel1.Controls.Add(Me.btnNovo)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnDesativar)
        Me.Panel1.Controls.Add(Me.btnSalvar)
        Me.Panel1.Controls.Add(Me.lsvReduzida)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(182, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 526)
        Me.Panel1.TabIndex = 141
        '
        'btnNovo
        '
        Me.btnNovo.AutoSize = True
        Me.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnNovo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.Black
        Me.btnNovo.Image = Global.PjtLudosII.My.Resources.Resources.add_user
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(54, 431)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(100, 38)
        Me.btnNovo.TabIndex = 135
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = Global.PjtLudosII.My.Resources.Resources.block
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(324, 431)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 38)
        Me.btnCancelar.TabIndex = 139
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnDesativar
        '
        Me.btnDesativar.AutoSize = True
        Me.btnDesativar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDesativar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDesativar.Enabled = False
        Me.btnDesativar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnDesativar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnDesativar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesativar.ForeColor = System.Drawing.Color.Black
        Me.btnDesativar.Image = Global.PjtLudosII.My.Resources.Resources.remove
        Me.btnDesativar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDesativar.Location = New System.Drawing.Point(468, 431)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(105, 38)
        Me.btnDesativar.TabIndex = 137
        Me.btnDesativar.Text = "&Desativar"
        Me.btnDesativar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDesativar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDesativar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.AutoSize = True
        Me.btnSalvar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnSalvar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Image = Global.PjtLudosII.My.Resources.Resources.user_accept
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(187, 431)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(100, 38)
        Me.btnSalvar.TabIndex = 138
        Me.btnSalvar.Text = "Gravar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'lblPNome
        '
        Me.lblPNome.AutoSize = True
        Me.lblPNome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNome.Location = New System.Drawing.Point(11, 16)
        Me.lblPNome.Name = "lblPNome"
        Me.lblPNome.Size = New System.Drawing.Size(105, 19)
        Me.lblPNome.TabIndex = 123
        Me.lblPNome.Text = "Primeiro Nome"
        '
        'txtPNome
        '
        Me.txtPNome.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNome.Location = New System.Drawing.Point(10, 36)
        Me.txtPNome.MaxLength = 14
        Me.txtPNome.Name = "txtPNome"
        Me.txtPNome.Size = New System.Drawing.Size(221, 27)
        Me.txtPNome.TabIndex = 0
        '
        'frmCadUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1010, 635)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmCadUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Usuários"
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCPF As System.Windows.Forms.TextBox
    Friend WithEvents lblCPF As System.Windows.Forms.Label
    Friend WithEvents txtUNome As System.Windows.Forms.TextBox
    Friend WithEvents lblUNome As System.Windows.Forms.Label
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lsvReduzida As System.Windows.Forms.ListView
    Friend WithEvents lblCSenha As System.Windows.Forms.Label
    Friend WithEvents txtCSenha As System.Windows.Forms.TextBox
    Friend WithEvents cboPerfil As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents gb As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPNome As System.Windows.Forms.TextBox
    Friend WithEvents lblPNome As System.Windows.Forms.Label
End Class
