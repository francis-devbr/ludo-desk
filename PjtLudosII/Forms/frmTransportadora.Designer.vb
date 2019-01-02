<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransportadora
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
        Me.pnLatEsq = New System.Windows.Forms.Panel()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPNome = New System.Windows.Forms.TextBox()
        Me.lblPNome = New System.Windows.Forms.Label()
        Me.pbNext = New System.Windows.Forms.PictureBox()
        Me.lsvReduzida = New System.Windows.Forms.ListView()
        Me.pnInfo = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtDDD = New System.Windows.Forms.TextBox()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtRzSocial = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtNrLog = New System.Windows.Forms.TextBox()
        Me.txtnmFantasia = New System.Windows.Forms.TextBox()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.txtCep = New System.Windows.Forms.TextBox()
        Me.txtCNPJ = New System.Windows.Forms.TextBox()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblNr = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblRazaoSocial = New System.Windows.Forms.Label()
        Me.lblNomeFantasia = New System.Windows.Forms.Label()
        Me.lblCNPJ = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtEmailCont = New System.Windows.Forms.TextBox()
        Me.txtnmContato = New System.Windows.Forms.TextBox()
        Me.txtDDDTelCont = New System.Windows.Forms.TextBox()
        Me.txtCelCont = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblCadCep = New System.Windows.Forms.Label()
        Me.btnCadCep = New System.Windows.Forms.PictureBox()
        Me.lblPOnline = New System.Windows.Forms.Label()
        Me.btnPOnline = New System.Windows.Forms.PictureBox()
        Me.pnLatEsq.SuspendLayout()
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnInfo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.btnCadCep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPOnline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnLatEsq
        '
        Me.pnLatEsq.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnLatEsq.Controls.Add(Me.btnPesquisar)
        Me.pnLatEsq.Controls.Add(Me.Label1)
        Me.pnLatEsq.Controls.Add(Me.txtPNome)
        Me.pnLatEsq.Controls.Add(Me.lblPNome)
        Me.pnLatEsq.Controls.Add(Me.pbNext)
        Me.pnLatEsq.Controls.Add(Me.lsvReduzida)
        Me.pnLatEsq.Location = New System.Drawing.Point(0, 0)
        Me.pnLatEsq.Name = "pnLatEsq"
        Me.pnLatEsq.Size = New System.Drawing.Size(251, 633)
        Me.pnLatEsq.TabIndex = 147
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(179, 162)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(68, 27)
        Me.btnPesquisar.TabIndex = 150
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 33)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "Procurar"
        '
        'txtPNome
        '
        Me.txtPNome.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNome.Location = New System.Drawing.Point(15, 123)
        Me.txtPNome.MaxLength = 70
        Me.txtPNome.Name = "txtPNome"
        Me.txtPNome.Size = New System.Drawing.Size(232, 31)
        Me.txtPNome.TabIndex = 148
        '
        'lblPNome
        '
        Me.lblPNome.AutoSize = True
        Me.lblPNome.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNome.Location = New System.Drawing.Point(14, 100)
        Me.lblPNome.Name = "lblPNome"
        Me.lblPNome.Size = New System.Drawing.Size(141, 16)
        Me.lblPNome.TabIndex = 149
        Me.lblPNome.Text = "Digite Nome ou CNPJ"
        '
        'pbNext
        '
        Me.pbNext.BackgroundImage = Global.PjtLudosII.My.Resources.Resources._next
        Me.pbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNext.Location = New System.Drawing.Point(215, 4)
        Me.pbNext.Name = "pbNext"
        Me.pbNext.Size = New System.Drawing.Size(33, 33)
        Me.pbNext.TabIndex = 104
        Me.pbNext.TabStop = False
        '
        'lsvReduzida
        '
        Me.lsvReduzida.Location = New System.Drawing.Point(15, 227)
        Me.lsvReduzida.Name = "lsvReduzida"
        Me.lsvReduzida.Size = New System.Drawing.Size(231, 363)
        Me.lsvReduzida.TabIndex = 17
        Me.lsvReduzida.TabStop = False
        Me.lsvReduzida.UseCompatibleStateImageBehavior = False
        '
        'pnInfo
        '
        Me.pnInfo.Controls.Add(Me.TabPage1)
        Me.pnInfo.Controls.Add(Me.TabPage2)
        Me.pnInfo.Enabled = False
        Me.pnInfo.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.pnInfo.Location = New System.Drawing.Point(269, 55)
        Me.pnInfo.Multiline = True
        Me.pnInfo.Name = "pnInfo"
        Me.pnInfo.SelectedIndex = 0
        Me.pnInfo.Size = New System.Drawing.Size(519, 575)
        Me.pnInfo.TabIndex = 146
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.txtUF)
        Me.TabPage1.Controls.Add(Me.txtTel)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(Me.txtDDD)
        Me.TabPage1.Controls.Add(Me.txtHP)
        Me.TabPage1.Controls.Add(Me.txtBairro)
        Me.TabPage1.Controls.Add(Me.txtRzSocial)
        Me.TabPage1.Controls.Add(Me.txtComplemento)
        Me.TabPage1.Controls.Add(Me.txtNrLog)
        Me.TabPage1.Controls.Add(Me.txtnmFantasia)
        Me.TabPage1.Controls.Add(Me.txtLog)
        Me.TabPage1.Controls.Add(Me.txtCep)
        Me.TabPage1.Controls.Add(Me.txtCNPJ)
        Me.TabPage1.Controls.Add(Me.lblTel)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.lblNr)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.lblCEP)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lblRazaoSocial)
        Me.TabPage1.Controls.Add(Me.lblNomeFantasia)
        Me.TabPage1.Controls.Add(Me.lblCNPJ)
        Me.TabPage1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(511, 547)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Transportadora"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(421, 328)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(24, 15)
        Me.Label29.TabIndex = 141
        Me.Label29.Text = "U.F"
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUF.Location = New System.Drawing.Point(424, 345)
        Me.txtUF.MaxLength = 2
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(66, 23)
        Me.txtUF.TabIndex = 140
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(78, 389)
        Me.txtTel.MaxLength = 9
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(134, 23)
        Me.txtTel.TabIndex = 12
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(20, 345)
        Me.txtCidade.MaxLength = 60
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(390, 23)
        Me.txtCidade.TabIndex = 9
        '
        'txtDDD
        '
        Me.txtDDD.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDDD.Location = New System.Drawing.Point(21, 389)
        Me.txtDDD.MaxLength = 2
        Me.txtDDD.Name = "txtDDD"
        Me.txtDDD.Size = New System.Drawing.Size(49, 23)
        Me.txtDDD.TabIndex = 11
        '
        'txtHP
        '
        Me.txtHP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHP.Location = New System.Drawing.Point(20, 445)
        Me.txtHP.MaxLength = 100
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(470, 23)
        Me.txtHP.TabIndex = 13
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(20, 301)
        Me.txtBairro.MaxLength = 100
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(470, 23)
        Me.txtBairro.TabIndex = 8
        '
        'txtRzSocial
        '
        Me.txtRzSocial.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRzSocial.Location = New System.Drawing.Point(20, 38)
        Me.txtRzSocial.MaxLength = 70
        Me.txtRzSocial.Name = "txtRzSocial"
        Me.txtRzSocial.Size = New System.Drawing.Size(471, 23)
        Me.txtRzSocial.TabIndex = 0
        '
        'txtComplemento
        '
        Me.txtComplemento.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplemento.Location = New System.Drawing.Point(250, 257)
        Me.txtComplemento.MaxLength = 70
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(241, 23)
        Me.txtComplemento.TabIndex = 7
        '
        'txtNrLog
        '
        Me.txtNrLog.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNrLog.Location = New System.Drawing.Point(20, 257)
        Me.txtNrLog.MaxLength = 8
        Me.txtNrLog.Name = "txtNrLog"
        Me.txtNrLog.Size = New System.Drawing.Size(189, 23)
        Me.txtNrLog.TabIndex = 6
        '
        'txtnmFantasia
        '
        Me.txtnmFantasia.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnmFantasia.Location = New System.Drawing.Point(21, 81)
        Me.txtnmFantasia.MaxLength = 70
        Me.txtnmFantasia.Name = "txtnmFantasia"
        Me.txtnmFantasia.Size = New System.Drawing.Size(470, 23)
        Me.txtnmFantasia.TabIndex = 1
        '
        'txtLog
        '
        Me.txtLog.Enabled = False
        Me.txtLog.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.Location = New System.Drawing.Point(21, 213)
        Me.txtLog.MaxLength = 100
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(470, 23)
        Me.txtLog.TabIndex = 5
        '
        'txtCep
        '
        Me.txtCep.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCep.Location = New System.Drawing.Point(20, 169)
        Me.txtCep.MaxLength = 9
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(192, 23)
        Me.txtCep.TabIndex = 3
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNPJ.Location = New System.Drawing.Point(21, 125)
        Me.txtCNPJ.MaxLength = 18
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(191, 23)
        Me.txtCNPJ.TabIndex = 2
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(18, 371)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(52, 15)
        Me.lblTel.TabIndex = 29
        Me.lblTel.Text = "Telefone"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(17, 327)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 15)
        Me.Label32.TabIndex = 52
        Me.Label32.Text = "Cidade"
        '
        'lblNr
        '
        Me.lblNr.AutoSize = True
        Me.lblNr.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNr.Location = New System.Drawing.Point(18, 239)
        Me.lblNr.Name = "lblNr"
        Me.lblNr.Size = New System.Drawing.Size(50, 15)
        Me.lblNr.TabIndex = 56
        Me.lblNr.Text = "Número"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(17, 195)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 15)
        Me.Label27.TabIndex = 54
        Me.Label27.Text = "Endereço"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(17, 283)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(42, 15)
        Me.Label31.TabIndex = 51
        Me.Label31.Text = "Bairro"
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCEP.Location = New System.Drawing.Point(18, 151)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(27, 15)
        Me.lblCEP.TabIndex = 55
        Me.lblCEP.Text = "CEP"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(247, 239)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(82, 15)
        Me.Label30.TabIndex = 50
        Me.Label30.Text = "Complemento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "HomePage"
        '
        'lblRazaoSocial
        '
        Me.lblRazaoSocial.AutoSize = True
        Me.lblRazaoSocial.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazaoSocial.Location = New System.Drawing.Point(18, 20)
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        Me.lblRazaoSocial.Size = New System.Drawing.Size(80, 15)
        Me.lblRazaoSocial.TabIndex = 18
        Me.lblRazaoSocial.Text = "Razão Social "
        '
        'lblNomeFantasia
        '
        Me.lblNomeFantasia.AutoSize = True
        Me.lblNomeFantasia.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeFantasia.Location = New System.Drawing.Point(18, 64)
        Me.lblNomeFantasia.Name = "lblNomeFantasia"
        Me.lblNomeFantasia.Size = New System.Drawing.Size(89, 15)
        Me.lblNomeFantasia.TabIndex = 18
        Me.lblNomeFantasia.Text = "Nome Fantasia"
        '
        'lblCNPJ
        '
        Me.lblCNPJ.AutoSize = True
        Me.lblCNPJ.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPJ.Location = New System.Drawing.Point(18, 107)
        Me.lblCNPJ.Name = "lblCNPJ"
        Me.lblCNPJ.Size = New System.Drawing.Size(32, 15)
        Me.lblCNPJ.TabIndex = 28
        Me.lblCNPJ.Text = "CNPJ"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtEmailCont)
        Me.TabPage2.Controls.Add(Me.txtnmContato)
        Me.TabPage2.Controls.Add(Me.txtDDDTelCont)
        Me.TabPage2.Controls.Add(Me.txtCelCont)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(511, 547)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contato Transportadora"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtEmailCont
        '
        Me.txtEmailCont.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtEmailCont.Location = New System.Drawing.Point(33, 192)
        Me.txtEmailCont.MaxLength = 70
        Me.txtEmailCont.Name = "txtEmailCont"
        Me.txtEmailCont.Size = New System.Drawing.Size(447, 31)
        Me.txtEmailCont.TabIndex = 17
        '
        'txtnmContato
        '
        Me.txtnmContato.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnmContato.Location = New System.Drawing.Point(33, 49)
        Me.txtnmContato.MaxLength = 70
        Me.txtnmContato.Name = "txtnmContato"
        Me.txtnmContato.Size = New System.Drawing.Size(447, 31)
        Me.txtnmContato.TabIndex = 14
        '
        'txtDDDTelCont
        '
        Me.txtDDDTelCont.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtDDDTelCont.Location = New System.Drawing.Point(33, 117)
        Me.txtDDDTelCont.MaxLength = 2
        Me.txtDDDTelCont.Name = "txtDDDTelCont"
        Me.txtDDDTelCont.Size = New System.Drawing.Size(52, 31)
        Me.txtDDDTelCont.TabIndex = 15
        '
        'txtCelCont
        '
        Me.txtCelCont.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtCelCont.Location = New System.Drawing.Point(91, 117)
        Me.txtCelCont.MaxLength = 9
        Me.txtCelCont.Name = "txtCelCont"
        Me.txtCelCont.Size = New System.Drawing.Size(131, 31)
        Me.txtCelCont.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Celular"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(29, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 23)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Nome Contato"
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
        Me.btnEditar.Location = New System.Drawing.Point(373, 8)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 38)
        Me.btnEditar.TabIndex = 149
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
        Me.btnNovo.Location = New System.Drawing.Point(267, 8)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(100, 38)
        Me.btnNovo.TabIndex = 148
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
        Me.btnCancelar.Location = New System.Drawing.Point(585, 8)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 38)
        Me.btnCancelar.TabIndex = 152
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
        Me.btnDesativar.Location = New System.Drawing.Point(699, 8)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(105, 38)
        Me.btnDesativar.TabIndex = 150
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
        Me.btnSalvar.Location = New System.Drawing.Point(479, 8)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(100, 38)
        Me.btnSalvar.TabIndex = 151
        Me.btnSalvar.Text = "Gravar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 253
        Me.LineShape1.X2 = 254
        Me.LineShape1.Y1 = 1
        Me.LineShape1.Y2 = 634
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1010, 635)
        Me.ShapeContainer1.TabIndex = 153
        Me.ShapeContainer1.TabStop = False
        '
        'lblCadCep
        '
        Me.lblCadCep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCadCep.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadCep.ForeColor = System.Drawing.Color.DimGray
        Me.lblCadCep.Location = New System.Drawing.Point(843, 465)
        Me.lblCadCep.Name = "lblCadCep"
        Me.lblCadCep.Size = New System.Drawing.Size(125, 23)
        Me.lblCadCep.TabIndex = 163
        Me.lblCadCep.Text = "Cadastrar CEP "
        Me.lblCadCep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCadCep
        '
        Me.btnCadCep.BackColor = System.Drawing.Color.Transparent
        Me.btnCadCep.BackgroundImage = Global.PjtLudosII.My.Resources.Resources.map_add
        Me.btnCadCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCadCep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadCep.Location = New System.Drawing.Point(843, 339)
        Me.btnCadCep.Name = "btnCadCep"
        Me.btnCadCep.Size = New System.Drawing.Size(125, 123)
        Me.btnCadCep.TabIndex = 162
        Me.btnCadCep.TabStop = False
        '
        'lblPOnline
        '
        Me.lblPOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPOnline.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOnline.ForeColor = System.Drawing.Color.DimGray
        Me.lblPOnline.Location = New System.Drawing.Point(841, 287)
        Me.lblPOnline.Name = "lblPOnline"
        Me.lblPOnline.Size = New System.Drawing.Size(131, 23)
        Me.lblPOnline.TabIndex = 164
        Me.lblPOnline.Text = "Consultar CNPJ"
        Me.lblPOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPOnline.Visible = False
        '
        'btnPOnline
        '
        Me.btnPOnline.BackColor = System.Drawing.Color.Transparent
        Me.btnPOnline.BackgroundImage = Global.PjtLudosII.My.Resources.Resources.search_globe
        Me.btnPOnline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPOnline.Location = New System.Drawing.Point(843, 162)
        Me.btnPOnline.Name = "btnPOnline"
        Me.btnPOnline.Size = New System.Drawing.Size(125, 122)
        Me.btnPOnline.TabIndex = 161
        Me.btnPOnline.TabStop = False
        Me.btnPOnline.Visible = False
        '
        'frmTransportadora
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
        Me.Controls.Add(Me.btnDesativar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.pnLatEsq)
        Me.Controls.Add(Me.pnInfo)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmTransportadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmTransportadora"
        Me.pnLatEsq.ResumeLayout(False)
        Me.pnLatEsq.PerformLayout()
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnInfo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.btnCadCep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPOnline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnLatEsq As System.Windows.Forms.Panel
    Friend WithEvents lsvReduzida As System.Windows.Forms.ListView
    Friend WithEvents pnInfo As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtDDD As System.Windows.Forms.TextBox
    Friend WithEvents txtHP As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtRzSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtNrLog As System.Windows.Forms.TextBox
    Friend WithEvents txtnmFantasia As System.Windows.Forms.TextBox
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents txtCep As System.Windows.Forms.TextBox
    Friend WithEvents txtCNPJ As System.Windows.Forms.TextBox
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblNr As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents lblNomeFantasia As System.Windows.Forms.Label
    Friend WithEvents lblCNPJ As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtEmailCont As System.Windows.Forms.TextBox
    Friend WithEvents txtnmContato As System.Windows.Forms.TextBox
    Friend WithEvents txtDDDTelCont As System.Windows.Forms.TextBox
    Friend WithEvents txtCelCont As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents pbNext As System.Windows.Forms.PictureBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPNome As System.Windows.Forms.TextBox
    Friend WithEvents lblPNome As System.Windows.Forms.Label
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtUF As System.Windows.Forms.TextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblCadCep As System.Windows.Forms.Label
    Friend WithEvents btnCadCep As System.Windows.Forms.PictureBox
    Friend WithEvents lblPOnline As System.Windows.Forms.Label
    Friend WithEvents btnPOnline As System.Windows.Forms.PictureBox
End Class
