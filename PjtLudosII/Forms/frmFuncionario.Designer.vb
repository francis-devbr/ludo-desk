<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.lblDtAdm = New System.Windows.Forms.Label()
        Me.txtDtAdmissao = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.pnInfo = New System.Windows.Forms.Panel()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtNr = New System.Windows.Forms.TextBox()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.txtDDD = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbF = New System.Windows.Forms.RadioButton()
        Me.rbM = New System.Windows.Forms.RadioButton()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.lblDtNasc = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.txtDTNasc = New System.Windows.Forms.TextBox()
        Me.pnLatEsq = New System.Windows.Forms.Panel()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.pbNext = New System.Windows.Forms.PictureBox()
        Me.lsvReduzida = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPNome = New System.Windows.Forms.TextBox()
        Me.lblPNome = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lblCadCep = New System.Windows.Forms.Label()
        Me.btnCadCep = New System.Windows.Forms.PictureBox()
        Me.lblPOnline = New System.Windows.Forms.Label()
        Me.btnPOnline = New System.Windows.Forms.PictureBox()
        Me.pnInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnLatEsq.SuspendLayout()
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCadCep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPOnline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCargo
        '
        Me.cboCargo.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Location = New System.Drawing.Point(20, 152)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(192, 23)
        Me.cboCargo.TabIndex = 9
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblCargo.Location = New System.Drawing.Point(19, 134)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(39, 15)
        Me.lblCargo.TabIndex = 1
        Me.lblCargo.Text = "Cargo"
        '
        'lblDtAdm
        '
        Me.lblDtAdm.AutoSize = True
        Me.lblDtAdm.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblDtAdm.Location = New System.Drawing.Point(222, 134)
        Me.lblDtAdm.Name = "lblDtAdm"
        Me.lblDtAdm.Size = New System.Drawing.Size(90, 15)
        Me.lblDtAdm.TabIndex = 1
        Me.lblDtAdm.Text = "Data Admissão"
        '
        'txtDtAdmissao
        '
        Me.txtDtAdmissao.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtDtAdmissao.Location = New System.Drawing.Point(226, 152)
        Me.txtDtAdmissao.MaxLength = 10
        Me.txtDtAdmissao.Name = "txtDtAdmissao"
        Me.txtDtAdmissao.Size = New System.Drawing.Size(98, 23)
        Me.txtDtAdmissao.TabIndex = 10
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtNome.Location = New System.Drawing.Point(20, 42)
        Me.txtNome.MaxLength = 70
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(475, 23)
        Me.txtNome.TabIndex = 5
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.lblNome.Location = New System.Drawing.Point(17, 24)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 15)
        Me.lblNome.TabIndex = 3
        Me.lblNome.Text = "Nome"
        '
        'pnInfo
        '
        Me.pnInfo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pnInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnInfo.Controls.Add(Me.lblCEP)
        Me.pnInfo.Controls.Add(Me.Label27)
        Me.pnInfo.Controls.Add(Me.lblNo)
        Me.pnInfo.Controls.Add(Me.Label29)
        Me.pnInfo.Controls.Add(Me.Label30)
        Me.pnInfo.Controls.Add(Me.lblTel)
        Me.pnInfo.Controls.Add(Me.Label31)
        Me.pnInfo.Controls.Add(Me.Label32)
        Me.pnInfo.Controls.Add(Me.txtLog)
        Me.pnInfo.Controls.Add(Me.txtCep)
        Me.pnInfo.Controls.Add(Me.txtTel)
        Me.pnInfo.Controls.Add(Me.txtComplemento)
        Me.pnInfo.Controls.Add(Me.txtBairro)
        Me.pnInfo.Controls.Add(Me.txtCidade)
        Me.pnInfo.Controls.Add(Me.txtNr)
        Me.pnInfo.Controls.Add(Me.txtUF)
        Me.pnInfo.Controls.Add(Me.txtDDD)
        Me.pnInfo.Controls.Add(Me.GroupBox1)
        Me.pnInfo.Controls.Add(Me.txtCPF)
        Me.pnInfo.Controls.Add(Me.lblCPF)
        Me.pnInfo.Controls.Add(Me.lblDtNasc)
        Me.pnInfo.Controls.Add(Me.lblSexo)
        Me.pnInfo.Controls.Add(Me.txtDTNasc)
        Me.pnInfo.Controls.Add(Me.txtNome)
        Me.pnInfo.Controls.Add(Me.cboCargo)
        Me.pnInfo.Controls.Add(Me.lblNome)
        Me.pnInfo.Controls.Add(Me.txtDtAdmissao)
        Me.pnInfo.Controls.Add(Me.lblCargo)
        Me.pnInfo.Controls.Add(Me.lblDtAdm)
        Me.pnInfo.Enabled = False
        Me.pnInfo.Location = New System.Drawing.Point(269, 55)
        Me.pnInfo.Name = "pnInfo"
        Me.pnInfo.Size = New System.Drawing.Size(537, 575)
        Me.pnInfo.TabIndex = 135
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCEP.Location = New System.Drawing.Point(16, 193)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(27, 15)
        Me.lblCEP.TabIndex = 139
        Me.lblCEP.Text = "CEP"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(19, 247)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 15)
        Me.Label27.TabIndex = 138
        Me.Label27.Text = "End."
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.Location = New System.Drawing.Point(19, 304)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(20, 15)
        Me.lblNo.TabIndex = 140
        Me.lblNo.Text = "Nº"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(426, 405)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(24, 15)
        Me.Label29.TabIndex = 137
        Me.Label29.Text = "U.F"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(184, 304)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(82, 15)
        Me.Label30.TabIndex = 134
        Me.Label30.Text = "Complemento"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(19, 459)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(52, 15)
        Me.lblTel.TabIndex = 133
        Me.lblTel.Text = "Telefone"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(19, 358)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(42, 15)
        Me.Label31.TabIndex = 135
        Me.Label31.Text = "Bairro"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(17, 405)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 15)
        Me.Label32.TabIndex = 136
        Me.Label32.Text = "Cidade"
        '
        'txtLog
        '
        Me.txtLog.Enabled = False
        Me.txtLog.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(19, 265)
        Me.txtLog.MaxLength = 300
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(476, 23)
        Me.txtLog.TabIndex = 130
        '
        'txtCep
        '
        Me.txtCep.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCep.Location = New System.Drawing.Point(19, 211)
        Me.txtCep.MaxLength = 9
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(189, 23)
        Me.txtCep.TabIndex = 11
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(82, 477)
        Me.txtTel.MaxLength = 9
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(179, 23)
        Me.txtTel.TabIndex = 15
        '
        'txtComplemento
        '
        Me.txtComplemento.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplemento.Location = New System.Drawing.Point(187, 322)
        Me.txtComplemento.MaxLength = 70
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(308, 23)
        Me.txtComplemento.TabIndex = 13
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(19, 376)
        Me.txtBairro.MaxLength = 100
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(476, 23)
        Me.txtBairro.TabIndex = 131
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(18, 423)
        Me.txtCidade.MaxLength = 100
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(382, 23)
        Me.txtCidade.TabIndex = 132
        '
        'txtNr
        '
        Me.txtNr.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNr.Location = New System.Drawing.Point(18, 322)
        Me.txtNr.MaxLength = 8
        Me.txtNr.Name = "txtNr"
        Me.txtNr.Size = New System.Drawing.Size(141, 23)
        Me.txtNr.TabIndex = 12
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUF.Location = New System.Drawing.Point(429, 423)
        Me.txtUF.MaxLength = 2
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(66, 23)
        Me.txtUF.TabIndex = 128
        '
        'txtDDD
        '
        Me.txtDDD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDDD.Location = New System.Drawing.Point(22, 477)
        Me.txtDDD.MaxLength = 2
        Me.txtDDD.Name = "txtDDD"
        Me.txtDDD.Size = New System.Drawing.Size(45, 23)
        Me.txtDDD.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbF)
        Me.GroupBox1.Controls.Add(Me.rbM)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 34)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'rbF
        '
        Me.rbF.AutoSize = True
        Me.rbF.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbF.Location = New System.Drawing.Point(12, 12)
        Me.rbF.Name = "rbF"
        Me.rbF.Size = New System.Drawing.Size(77, 18)
        Me.rbF.TabIndex = 98
        Me.rbF.TabStop = True
        Me.rbF.Text = "Feminino"
        Me.rbF.UseVisualStyleBackColor = True
        '
        'rbM
        '
        Me.rbM.AutoSize = True
        Me.rbM.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbM.Location = New System.Drawing.Point(100, 12)
        Me.rbM.Name = "rbM"
        Me.rbM.Size = New System.Drawing.Size(82, 18)
        Me.rbM.TabIndex = 100
        Me.rbM.TabStop = True
        Me.rbM.Text = "Masculino"
        Me.rbM.UseVisualStyleBackColor = True
        '
        'txtCPF
        '
        Me.txtCPF.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPF.Location = New System.Drawing.Point(329, 95)
        Me.txtCPF.MaxLength = 14
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(166, 23)
        Me.txtCPF.TabIndex = 8
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(330, 75)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(27, 15)
        Me.lblCPF.TabIndex = 119
        Me.lblCPF.Text = "CPF"
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDtNasc.Location = New System.Drawing.Point(223, 75)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(101, 15)
        Me.lblDtNasc.TabIndex = 120
        Me.lblDtNasc.Text = "Data Nascimento"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(19, 74)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(32, 15)
        Me.lblSexo.TabIndex = 121
        Me.lblSexo.Text = "Sexo"
        '
        'txtDTNasc
        '
        Me.txtDTNasc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDTNasc.Location = New System.Drawing.Point(225, 95)
        Me.txtDTNasc.MaxLength = 10
        Me.txtDTNasc.Name = "txtDTNasc"
        Me.txtDTNasc.Size = New System.Drawing.Size(98, 23)
        Me.txtDTNasc.TabIndex = 7
        '
        'pnLatEsq
        '
        Me.pnLatEsq.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnLatEsq.Controls.Add(Me.btnPesquisar)
        Me.pnLatEsq.Controls.Add(Me.pbNext)
        Me.pnLatEsq.Controls.Add(Me.lsvReduzida)
        Me.pnLatEsq.Controls.Add(Me.Label4)
        Me.pnLatEsq.Controls.Add(Me.txtPNome)
        Me.pnLatEsq.Controls.Add(Me.lblPNome)
        Me.pnLatEsq.Location = New System.Drawing.Point(0, 0)
        Me.pnLatEsq.Name = "pnLatEsq"
        Me.pnLatEsq.Size = New System.Drawing.Size(251, 633)
        Me.pnLatEsq.TabIndex = 16
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(174, 129)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(68, 27)
        Me.btnPesquisar.TabIndex = 142
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'pbNext
        '
        Me.pbNext.BackgroundImage = Global.PjtLudosII.My.Resources.Resources._next
        Me.pbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNext.Location = New System.Drawing.Point(215, 3)
        Me.pbNext.Name = "pbNext"
        Me.pbNext.Size = New System.Drawing.Size(33, 30)
        Me.pbNext.TabIndex = 102
        Me.pbNext.TabStop = False
        '
        'lsvReduzida
        '
        Me.lsvReduzida.Location = New System.Drawing.Point(11, 164)
        Me.lsvReduzida.Name = "lsvReduzida"
        Me.lsvReduzida.Size = New System.Drawing.Size(231, 426)
        Me.lsvReduzida.TabIndex = 18
        Me.lsvReduzida.TabStop = False
        Me.lsvReduzida.UseCompatibleStateImageBehavior = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label4.Location = New System.Drawing.Point(7, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Procurar"
        '
        'txtPNome
        '
        Me.txtPNome.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNome.Location = New System.Drawing.Point(10, 90)
        Me.txtPNome.MaxLength = 70
        Me.txtPNome.Name = "txtPNome"
        Me.txtPNome.Size = New System.Drawing.Size(232, 31)
        Me.txtPNome.TabIndex = 17
        '
        'lblPNome
        '
        Me.lblPNome.AutoSize = True
        Me.lblPNome.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNome.Location = New System.Drawing.Point(9, 67)
        Me.lblPNome.Name = "lblPNome"
        Me.lblPNome.Size = New System.Drawing.Size(134, 16)
        Me.lblPNome.TabIndex = 101
        Me.lblPNome.Text = "Digite Nome ou CPF"
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 252
        Me.LineShape1.X2 = 253
        Me.LineShape1.Y1 = -1
        Me.LineShape1.Y2 = 634
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1010, 635)
        Me.ShapeContainer1.TabIndex = 141
        Me.ShapeContainer1.TabStop = False
        '
        'btnEditar
        '
        Me.btnEditar.AutoSize = True
        Me.btnEditar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnEditar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Image = Global.PjtLudosII.My.Resources.Resources.edit_business_user
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(375, 12)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 38)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btnNovo.Image = Global.PjtLudosII.My.Resources.Resources.add_business_user
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(269, 12)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(100, 38)
        Me.btnNovo.TabIndex = 0
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
        Me.btnCancelar.Location = New System.Drawing.Point(587, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 38)
        Me.btnCancelar.TabIndex = 4
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
        Me.btnDesativar.Location = New System.Drawing.Point(701, 12)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(105, 38)
        Me.btnDesativar.TabIndex = 2
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
        Me.btnSalvar.Image = Global.PjtLudosII.My.Resources.Resources.accept_business_user
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(481, 12)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(100, 38)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Gravar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'lblCadCep
        '
        Me.lblCadCep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCadCep.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadCep.ForeColor = System.Drawing.Color.DimGray
        Me.lblCadCep.Location = New System.Drawing.Point(852, 352)
        Me.lblCadCep.Name = "lblCadCep"
        Me.lblCadCep.Size = New System.Drawing.Size(125, 23)
        Me.lblCadCep.TabIndex = 159
        Me.lblCadCep.Text = "Cadastrar CEP "
        Me.lblCadCep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCadCep
        '
        Me.btnCadCep.BackColor = System.Drawing.Color.Transparent
        Me.btnCadCep.BackgroundImage = Global.PjtLudosII.My.Resources.Resources.map_add
        Me.btnCadCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCadCep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadCep.Location = New System.Drawing.Point(852, 226)
        Me.btnCadCep.Name = "btnCadCep"
        Me.btnCadCep.Size = New System.Drawing.Size(125, 123)
        Me.btnCadCep.TabIndex = 158
        Me.btnCadCep.TabStop = False
        '
        'lblPOnline
        '
        Me.lblPOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPOnline.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOnline.ForeColor = System.Drawing.Color.DimGray
        Me.lblPOnline.Location = New System.Drawing.Point(848, 192)
        Me.lblPOnline.Name = "lblPOnline"
        Me.lblPOnline.Size = New System.Drawing.Size(125, 20)
        Me.lblPOnline.TabIndex = 160
        Me.lblPOnline.Text = "Consultar CPF "
        Me.lblPOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPOnline.Visible = False
        '
        'btnPOnline
        '
        Me.btnPOnline.BackColor = System.Drawing.Color.Transparent
        Me.btnPOnline.BackgroundImage = Global.PjtLudosII.My.Resources.Resources.search_globe
        Me.btnPOnline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPOnline.Location = New System.Drawing.Point(848, 67)
        Me.btnPOnline.Name = "btnPOnline"
        Me.btnPOnline.Size = New System.Drawing.Size(125, 122)
        Me.btnPOnline.TabIndex = 157
        Me.btnPOnline.TabStop = False
        Me.btnPOnline.Visible = False
        '
        'frmFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1010, 635)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCadCep)
        Me.Controls.Add(Me.btnCadCep)
        Me.Controls.Add(Me.lblPOnline)
        Me.Controls.Add(Me.btnPOnline)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.pnLatEsq)
        Me.Controls.Add(Me.btnDesativar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.pnInfo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmFuncionario"
        Me.pnInfo.ResumeLayout(False)
        Me.pnInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnLatEsq.ResumeLayout(False)
        Me.pnLatEsq.PerformLayout()
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCadCep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPOnline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboCargo As System.Windows.Forms.ComboBox
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents txtDtAdmissao As System.Windows.Forms.TextBox
    Friend WithEvents lblDtAdm As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents pnInfo As System.Windows.Forms.Panel
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents pnLatEsq As System.Windows.Forms.Panel
    Friend WithEvents pbNext As System.Windows.Forms.PictureBox
    Friend WithEvents lsvReduzida As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPNome As System.Windows.Forms.TextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbF As System.Windows.Forms.RadioButton
    Friend WithEvents rbM As System.Windows.Forms.RadioButton
    Friend WithEvents txtCPF As System.Windows.Forms.TextBox
    Friend WithEvents lblCPF As System.Windows.Forms.Label
    Friend WithEvents lblDtNasc As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents txtDTNasc As System.Windows.Forms.TextBox
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents txtCep As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtNr As System.Windows.Forms.TextBox
    Friend WithEvents txtUF As System.Windows.Forms.TextBox
    Friend WithEvents txtDDD As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents lblPNome As System.Windows.Forms.Label
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents lblCadCep As System.Windows.Forms.Label
    Friend WithEvents btnCadCep As System.Windows.Forms.PictureBox
    Friend WithEvents lblPOnline As System.Windows.Forms.Label
    Friend WithEvents btnPOnline As System.Windows.Forms.PictureBox
End Class
