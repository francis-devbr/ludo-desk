<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidoCompra
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
        Me.pnInfo = New System.Windows.Forms.Panel()
        Me.DGVPedido = New System.Windows.Forms.DataGridView()
        Me.gbCabeca = New System.Windows.Forms.GroupBox()
        Me.txtVlNF = New NumericBox.NumericBox()
        Me.txtNCNPJ = New System.Windows.Forms.TextBox()
        Me.lblNomeForn = New System.Windows.Forms.Label()
        Me.lblCNPJ = New System.Windows.Forms.Label()
        Me.txtDtRece = New System.Windows.Forms.TextBox()
        Me.lblDtReceb = New System.Windows.Forms.Label()
        Me.txtDtEmissaoo = New System.Windows.Forms.TextBox()
        Me.lblEmissao = New System.Windows.Forms.Label()
        Me.lblVlNF = New System.Windows.Forms.Label()
        Me.txtNºNF = New System.Windows.Forms.TextBox()
        Me.lblNºNF = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lsvReduzida = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPrecoVenda = New NumericBox.NumericBox()
        Me.txtCusto = New NumericBox.NumericBox()
        Me.lblCmdAddItem = New System.Windows.Forms.Label()
        Me.lblCmbExcluirItem = New System.Windows.Forms.Label()
        Me.txtEAN = New System.Windows.Forms.TextBox()
        Me.lblPVenda = New System.Windows.Forms.Label()
        Me.lblCusto = New System.Windows.Forms.Label()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.lblQtde = New System.Windows.Forms.Label()
        Me.lblCodProd = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lblPOnline = New System.Windows.Forms.Label()
        Me.btnPPDC = New System.Windows.Forms.PictureBox()
        Me.pnLatEsq = New System.Windows.Forms.Panel()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.lblProcurar = New System.Windows.Forms.Label()
        Me.txtNPedido = New System.Windows.Forms.TextBox()
        Me.txtPNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPNome = New System.Windows.Forms.Label()
        Me.pbNext = New System.Windows.Forms.PictureBox()
        Me.lvPedidos = New System.Windows.Forms.ListView()
        Me.pnInfo.SuspendLayout()
        CType(Me.DGVPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCabeca.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btnPPDC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnLatEsq.SuspendLayout()
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnInfo
        '
        Me.pnInfo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pnInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnInfo.Controls.Add(Me.DGVPedido)
        Me.pnInfo.Controls.Add(Me.gbCabeca)
        Me.pnInfo.Controls.Add(Me.Label10)
        Me.pnInfo.Controls.Add(Me.txtTotal)
        Me.pnInfo.Controls.Add(Me.lsvReduzida)
        Me.pnInfo.Controls.Add(Me.GroupBox2)
        Me.pnInfo.Controls.Add(Me.ShapeContainer1)
        Me.pnInfo.Enabled = False
        Me.pnInfo.ForeColor = System.Drawing.Color.LightCyan
        Me.pnInfo.Location = New System.Drawing.Point(30, 48)
        Me.pnInfo.Name = "pnInfo"
        Me.pnInfo.Size = New System.Drawing.Size(718, 575)
        Me.pnInfo.TabIndex = 137
        '
        'DGVPedido
        '
        Me.DGVPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPedido.Location = New System.Drawing.Point(9, 150)
        Me.DGVPedido.Name = "DGVPedido"
        Me.DGVPedido.Size = New System.Drawing.Size(696, 351)
        Me.DGVPedido.TabIndex = 140
        '
        'gbCabeca
        '
        Me.gbCabeca.Controls.Add(Me.txtVlNF)
        Me.gbCabeca.Controls.Add(Me.txtNCNPJ)
        Me.gbCabeca.Controls.Add(Me.lblNomeForn)
        Me.gbCabeca.Controls.Add(Me.lblCNPJ)
        Me.gbCabeca.Controls.Add(Me.txtDtRece)
        Me.gbCabeca.Controls.Add(Me.lblDtReceb)
        Me.gbCabeca.Controls.Add(Me.txtDtEmissaoo)
        Me.gbCabeca.Controls.Add(Me.lblEmissao)
        Me.gbCabeca.Controls.Add(Me.lblVlNF)
        Me.gbCabeca.Controls.Add(Me.txtNºNF)
        Me.gbCabeca.Controls.Add(Me.lblNºNF)
        Me.gbCabeca.Controls.Add(Me.txtCod)
        Me.gbCabeca.Controls.Add(Me.Label2)
        Me.gbCabeca.Location = New System.Drawing.Point(9, 10)
        Me.gbCabeca.Name = "gbCabeca"
        Me.gbCabeca.Size = New System.Drawing.Size(696, 134)
        Me.gbCabeca.TabIndex = 139
        Me.gbCabeca.TabStop = False
        '
        'txtVlNF
        '
        Me.txtVlNF.BackColor = System.Drawing.SystemColors.Window
        Me.txtVlNF.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtVlNF.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVlNF.ForeColor = System.Drawing.Color.Black
        Me.txtVlNF.Location = New System.Drawing.Point(346, 91)
        Me.txtVlNF.Name = "txtVlNF"
        Me.txtVlNF.NegativeNumberColor = System.Drawing.Color.Red
        Me.txtVlNF.Size = New System.Drawing.Size(94, 23)
        Me.txtVlNF.TabIndex = 4
        Me.txtVlNF.Text = "0,00"
        '
        'txtNCNPJ
        '
        Me.txtNCNPJ.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCNPJ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNCNPJ.Location = New System.Drawing.Point(175, 40)
        Me.txtNCNPJ.MaxLength = 18
        Me.txtNCNPJ.Name = "txtNCNPJ"
        Me.txtNCNPJ.Size = New System.Drawing.Size(151, 23)
        Me.txtNCNPJ.TabIndex = 1
        '
        'lblNomeForn
        '
        Me.lblNomeForn.AutoSize = True
        Me.lblNomeForn.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeForn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNomeForn.Location = New System.Drawing.Point(332, 43)
        Me.lblNomeForn.Name = "lblNomeForn"
        Me.lblNomeForn.Size = New System.Drawing.Size(10, 15)
        Me.lblNomeForn.TabIndex = 8
        Me.lblNomeForn.Text = "."
        '
        'lblCNPJ
        '
        Me.lblCNPJ.AutoSize = True
        Me.lblCNPJ.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPJ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCNPJ.Location = New System.Drawing.Point(172, 22)
        Me.lblCNPJ.Name = "lblCNPJ"
        Me.lblCNPJ.Size = New System.Drawing.Size(97, 15)
        Me.lblCNPJ.TabIndex = 8
        Me.lblCNPJ.Text = "CNPJ Fornecedor"
        '
        'txtDtRece
        '
        Me.txtDtRece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDtRece.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtRece.Location = New System.Drawing.Point(16, 91)
        Me.txtDtRece.MaxLength = 70
        Me.txtDtRece.Name = "txtDtRece"
        Me.txtDtRece.Size = New System.Drawing.Size(128, 23)
        Me.txtDtRece.TabIndex = 2
        Me.txtDtRece.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDtReceb
        '
        Me.lblDtReceb.AutoSize = True
        Me.lblDtReceb.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDtReceb.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblDtReceb.Location = New System.Drawing.Point(13, 73)
        Me.lblDtReceb.Name = "lblDtReceb"
        Me.lblDtReceb.Size = New System.Drawing.Size(106, 15)
        Me.lblDtReceb.TabIndex = 3
        Me.lblDtReceb.Text = "Data Recebimento"
        '
        'txtDtEmissaoo
        '
        Me.txtDtEmissaoo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDtEmissaoo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDtEmissaoo.Location = New System.Drawing.Point(487, 91)
        Me.txtDtEmissaoo.MaxLength = 70
        Me.txtDtEmissaoo.Name = "txtDtEmissaoo"
        Me.txtDtEmissaoo.Size = New System.Drawing.Size(118, 23)
        Me.txtDtEmissaoo.TabIndex = 5
        Me.txtDtEmissaoo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEmissao
        '
        Me.lblEmissao.AutoSize = True
        Me.lblEmissao.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmissao.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblEmissao.Location = New System.Drawing.Point(484, 73)
        Me.lblEmissao.Name = "lblEmissao"
        Me.lblEmissao.Size = New System.Drawing.Size(82, 15)
        Me.lblEmissao.TabIndex = 3
        Me.lblEmissao.Text = "Data Emissão"
        '
        'lblVlNF
        '
        Me.lblVlNF.AutoSize = True
        Me.lblVlNF.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVlNF.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblVlNF.Location = New System.Drawing.Point(345, 73)
        Me.lblVlNF.Name = "lblVlNF"
        Me.lblVlNF.Size = New System.Drawing.Size(56, 15)
        Me.lblVlNF.TabIndex = 3
        Me.lblVlNF.Text = "Valor N.F"
        '
        'txtNºNF
        '
        Me.txtNºNF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNºNF.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNºNF.Location = New System.Drawing.Point(175, 91)
        Me.txtNºNF.MaxLength = 70
        Me.txtNºNF.Name = "txtNºNF"
        Me.txtNºNF.Size = New System.Drawing.Size(151, 23)
        Me.txtNºNF.TabIndex = 3
        Me.txtNºNF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNºNF
        '
        Me.lblNºNF.AutoSize = True
        Me.lblNºNF.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNºNF.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblNºNF.Location = New System.Drawing.Point(172, 73)
        Me.lblNºNF.Name = "lblNºNF"
        Me.lblNºNF.Size = New System.Drawing.Size(40, 15)
        Me.lblNºNF.TabIndex = 3
        Me.lblNºNF.Text = "Nº N.F"
        '
        'txtCod
        '
        Me.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(16, 40)
        Me.txtCod.MaxLength = 70
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(128, 23)
        Me.txtCod.TabIndex = 0
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cod.Pedido"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightGray
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(511, 524)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(558, 520)
        Me.txtTotal.MaxLength = 70
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(134, 27)
        Me.txtTotal.TabIndex = 16
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lsvReduzida
        '
        Me.lsvReduzida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvReduzida.Location = New System.Drawing.Point(9, 231)
        Me.lsvReduzida.Name = "lsvReduzida"
        Me.lsvReduzida.Size = New System.Drawing.Size(696, 270)
        Me.lsvReduzida.TabIndex = 18
        Me.lsvReduzida.TabStop = False
        Me.lsvReduzida.UseCompatibleStateImageBehavior = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPrecoVenda)
        Me.GroupBox2.Controls.Add(Me.txtCusto)
        Me.GroupBox2.Controls.Add(Me.lblCmdAddItem)
        Me.GroupBox2.Controls.Add(Me.lblCmbExcluirItem)
        Me.GroupBox2.Controls.Add(Me.txtEAN)
        Me.GroupBox2.Controls.Add(Me.lblPVenda)
        Me.GroupBox2.Controls.Add(Me.lblCusto)
        Me.GroupBox2.Controls.Add(Me.txtQtd)
        Me.GroupBox2.Controls.Add(Me.lblQtde)
        Me.GroupBox2.Controls.Add(Me.lblCodProd)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(9, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(696, 66)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrecoVenda.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPrecoVenda.Enabled = False
        Me.txtPrecoVenda.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecoVenda.ForeColor = System.Drawing.Color.Black
        Me.txtPrecoVenda.Location = New System.Drawing.Point(362, 34)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.NegativeNumberColor = System.Drawing.Color.Red
        Me.txtPrecoVenda.Size = New System.Drawing.Size(94, 23)
        Me.txtPrecoVenda.TabIndex = 9
        Me.txtPrecoVenda.Text = "0,00"
        '
        'txtCusto
        '
        Me.txtCusto.BackColor = System.Drawing.SystemColors.Window
        Me.txtCusto.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtCusto.Enabled = False
        Me.txtCusto.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusto.ForeColor = System.Drawing.Color.Black
        Me.txtCusto.Location = New System.Drawing.Point(256, 34)
        Me.txtCusto.Name = "txtCusto"
        Me.txtCusto.NegativeNumberColor = System.Drawing.Color.Red
        Me.txtCusto.Size = New System.Drawing.Size(94, 23)
        Me.txtCusto.TabIndex = 8
        Me.txtCusto.Text = "0,00"
        '
        'lblCmdAddItem
        '
        Me.lblCmdAddItem.AutoSize = True
        Me.lblCmdAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCmdAddItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmdAddItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCmdAddItem.Location = New System.Drawing.Point(508, 34)
        Me.lblCmdAddItem.Name = "lblCmdAddItem"
        Me.lblCmdAddItem.Size = New System.Drawing.Size(87, 15)
        Me.lblCmdAddItem.TabIndex = 11
        Me.lblCmdAddItem.Text = "Adicionar Item"
        '
        'lblCmbExcluirItem
        '
        Me.lblCmbExcluirItem.AutoSize = True
        Me.lblCmbExcluirItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCmbExcluirItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmbExcluirItem.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCmbExcluirItem.Location = New System.Drawing.Point(602, 34)
        Me.lblCmbExcluirItem.Name = "lblCmbExcluirItem"
        Me.lblCmbExcluirItem.Size = New System.Drawing.Size(71, 15)
        Me.lblCmbExcluirItem.TabIndex = 12
        Me.lblCmbExcluirItem.Text = "Excluir Item"
        '
        'txtEAN
        '
        Me.txtEAN.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEAN.Location = New System.Drawing.Point(20, 34)
        Me.txtEAN.MaxLength = 15
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Size = New System.Drawing.Size(128, 23)
        Me.txtEAN.TabIndex = 6
        Me.txtEAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPVenda
        '
        Me.lblPVenda.AutoSize = True
        Me.lblPVenda.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPVenda.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblPVenda.Location = New System.Drawing.Point(381, 16)
        Me.lblPVenda.Name = "lblPVenda"
        Me.lblPVenda.Size = New System.Drawing.Size(75, 15)
        Me.lblPVenda.TabIndex = 3
        Me.lblPVenda.Text = "Preço Venda"
        '
        'lblCusto
        '
        Me.lblCusto.AutoSize = True
        Me.lblCusto.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCusto.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCusto.Location = New System.Drawing.Point(265, 16)
        Me.lblCusto.Name = "lblCusto"
        Me.lblCusto.Size = New System.Drawing.Size(85, 15)
        Me.lblCusto.TabIndex = 3
        Me.lblCusto.Text = "Custo Unitário"
        '
        'txtQtd
        '
        Me.txtQtd.Enabled = False
        Me.txtQtd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Location = New System.Drawing.Point(162, 34)
        Me.txtQtd.MaxLength = 5
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(68, 23)
        Me.txtQtd.TabIndex = 7
        Me.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQtde
        '
        Me.lblQtde.AutoSize = True
        Me.lblQtde.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtde.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblQtde.Location = New System.Drawing.Point(159, 16)
        Me.lblQtde.Name = "lblQtde"
        Me.lblQtde.Size = New System.Drawing.Size(71, 15)
        Me.lblQtde.TabIndex = 3
        Me.lblQtde.Text = "Quantidade"
        '
        'lblCodProd
        '
        Me.lblCodProd.AutoSize = True
        Me.lblCodProd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodProd.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCodProd.Location = New System.Drawing.Point(17, 16)
        Me.lblCodProd.Name = "lblCodProd"
        Me.lblCodProd.Size = New System.Drawing.Size(79, 15)
        Me.lblCodProd.TabIndex = 8
        Me.lblCodProd.Text = "Cód. Produto"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(716, 573)
        Me.ShapeContainer1.TabIndex = 138
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.LightGray
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(9, 516)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(694, 35)
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(162, 87)
        Me.TextBox2.MaxLength = 70
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 23)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnEditar.Location = New System.Drawing.Point(134, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 38)
        Me.btnEditar.TabIndex = 142
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
        Me.btnNovo.Location = New System.Drawing.Point(28, 4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(100, 38)
        Me.btnNovo.TabIndex = 141
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
        Me.btnCancelar.Location = New System.Drawing.Point(346, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 38)
        Me.btnCancelar.TabIndex = 145
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
        Me.btnDesativar.Location = New System.Drawing.Point(460, 4)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(105, 38)
        Me.btnDesativar.TabIndex = 143
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
        Me.btnSalvar.Location = New System.Drawing.Point(240, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(100, 38)
        Me.btnSalvar.TabIndex = 144
        Me.btnSalvar.Text = "Gravar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'lblPOnline
        '
        Me.lblPOnline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPOnline.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOnline.ForeColor = System.Drawing.Color.DimGray
        Me.lblPOnline.Location = New System.Drawing.Point(796, 275)
        Me.lblPOnline.Name = "lblPOnline"
        Me.lblPOnline.Size = New System.Drawing.Size(151, 63)
        Me.lblPOnline.TabIndex = 158
        Me.lblPOnline.Text = "Pesquisar Pedido de Compras"
        Me.lblPOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPPDC
        '
        Me.btnPPDC.BackColor = System.Drawing.Color.Transparent
        Me.btnPPDC.BackgroundImage = Global.PjtLudosII.My.Resources.Resources.search_globe
        Me.btnPPDC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPPDC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPPDC.Location = New System.Drawing.Point(812, 150)
        Me.btnPPDC.Name = "btnPPDC"
        Me.btnPPDC.Size = New System.Drawing.Size(125, 122)
        Me.btnPPDC.TabIndex = 157
        Me.btnPPDC.TabStop = False
        '
        'pnLatEsq
        '
        Me.pnLatEsq.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnLatEsq.Controls.Add(Me.btnPesquisar)
        Me.pnLatEsq.Controls.Add(Me.lblProcurar)
        Me.pnLatEsq.Controls.Add(Me.txtNPedido)
        Me.pnLatEsq.Controls.Add(Me.txtPNome)
        Me.pnLatEsq.Controls.Add(Me.Label1)
        Me.pnLatEsq.Controls.Add(Me.lblPNome)
        Me.pnLatEsq.Controls.Add(Me.pbNext)
        Me.pnLatEsq.Controls.Add(Me.lvPedidos)
        Me.pnLatEsq.Location = New System.Drawing.Point(5, 1)
        Me.pnLatEsq.Name = "pnLatEsq"
        Me.pnLatEsq.Size = New System.Drawing.Size(35, 633)
        Me.pnLatEsq.TabIndex = 159
        Me.pnLatEsq.Visible = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(312, 185)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(68, 27)
        Me.btnPesquisar.TabIndex = 150
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'lblProcurar
        '
        Me.lblProcurar.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcurar.ForeColor = System.Drawing.Color.Gray
        Me.lblProcurar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblProcurar.Location = New System.Drawing.Point(10, 72)
        Me.lblProcurar.Name = "lblProcurar"
        Me.lblProcurar.Size = New System.Drawing.Size(103, 33)
        Me.lblProcurar.TabIndex = 147
        Me.lblProcurar.Text = "Procurar"
        '
        'txtNPedido
        '
        Me.txtNPedido.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNPedido.Location = New System.Drawing.Point(13, 181)
        Me.txtNPedido.MaxLength = 70
        Me.txtNPedido.Name = "txtNPedido"
        Me.txtNPedido.Size = New System.Drawing.Size(232, 31)
        Me.txtNPedido.TabIndex = 148
        '
        'txtPNome
        '
        Me.txtPNome.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNome.Location = New System.Drawing.Point(13, 128)
        Me.txtPNome.MaxLength = 18
        Me.txtPNome.Name = "txtPNome"
        Me.txtPNome.Size = New System.Drawing.Size(232, 31)
        Me.txtPNome.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Digite Nº Pedido"
        '
        'lblPNome
        '
        Me.lblPNome.AutoSize = True
        Me.lblPNome.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNome.Location = New System.Drawing.Point(12, 105)
        Me.lblPNome.Name = "lblPNome"
        Me.lblPNome.Size = New System.Drawing.Size(178, 16)
        Me.lblPNome.TabIndex = 149
        Me.lblPNome.Text = "Digite CNPJ  do Fornecedor"
        '
        'pbNext
        '
        Me.pbNext.BackgroundImage = Global.PjtLudosII.My.Resources.Resources._next
        Me.pbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNext.Location = New System.Drawing.Point(3, 3)
        Me.pbNext.Name = "pbNext"
        Me.pbNext.Size = New System.Drawing.Size(33, 30)
        Me.pbNext.TabIndex = 104
        Me.pbNext.TabStop = False
        Me.pbNext.Visible = False
        '
        'lvPedidos
        '
        Me.lvPedidos.Location = New System.Drawing.Point(13, 227)
        Me.lvPedidos.Name = "lvPedidos"
        Me.lvPedidos.Size = New System.Drawing.Size(973, 363)
        Me.lvPedidos.TabIndex = 17
        Me.lvPedidos.TabStop = False
        Me.lvPedidos.UseCompatibleStateImageBehavior = False
        '
        'frmPedidoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 635)
        Me.Controls.Add(Me.pnLatEsq)
        Me.Controls.Add(Me.lblPOnline)
        Me.Controls.Add(Me.btnPPDC)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.pnInfo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnDesativar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmPedidoCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmPedidoCompra"
        Me.pnInfo.ResumeLayout(False)
        Me.pnInfo.PerformLayout()
        CType(Me.DGVPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCabeca.ResumeLayout(False)
        Me.gbCabeca.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btnPPDC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnLatEsq.ResumeLayout(False)
        Me.pnLatEsq.PerformLayout()
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnInfo As System.Windows.Forms.Panel
    Friend WithEvents lsvReduzida As System.Windows.Forms.ListView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCmdAddItem As System.Windows.Forms.Label
    Friend WithEvents lblCmbExcluirItem As System.Windows.Forms.Label
    Friend WithEvents txtEAN As System.Windows.Forms.TextBox
    Friend WithEvents lblPVenda As System.Windows.Forms.Label
    Friend WithEvents lblCusto As System.Windows.Forms.Label
    Friend WithEvents txtQtd As System.Windows.Forms.TextBox
    Friend WithEvents lblQtde As System.Windows.Forms.Label
    Friend WithEvents lblCodProd As System.Windows.Forms.Label
    Friend WithEvents gbCabeca As System.Windows.Forms.GroupBox
    Friend WithEvents txtNCNPJ As System.Windows.Forms.TextBox
    Friend WithEvents lblNomeForn As System.Windows.Forms.Label
    Friend WithEvents lblCNPJ As System.Windows.Forms.Label
    Friend WithEvents txtDtRece As System.Windows.Forms.TextBox
    Friend WithEvents lblDtReceb As System.Windows.Forms.Label
    Friend WithEvents txtDtEmissaoo As System.Windows.Forms.TextBox
    Friend WithEvents lblEmissao As System.Windows.Forms.Label
    Friend WithEvents lblVlNF As System.Windows.Forms.Label
    Friend WithEvents txtNºNF As System.Windows.Forms.TextBox
    Friend WithEvents lblNºNF As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGVPedido As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents txtVlNF As NumericBox.NumericBox
    Friend WithEvents txtPrecoVenda As NumericBox.NumericBox
    Friend WithEvents txtCusto As NumericBox.NumericBox
    Friend WithEvents lblPOnline As System.Windows.Forms.Label
    Friend WithEvents btnPPDC As System.Windows.Forms.PictureBox
    Friend WithEvents pnLatEsq As System.Windows.Forms.Panel
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents lblProcurar As System.Windows.Forms.Label
    Friend WithEvents txtPNome As System.Windows.Forms.TextBox
    Friend WithEvents lblPNome As System.Windows.Forms.Label
    Friend WithEvents pbNext As System.Windows.Forms.PictureBox
    Friend WithEvents lvPedidos As System.Windows.Forms.ListView
    Friend WithEvents txtNPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
