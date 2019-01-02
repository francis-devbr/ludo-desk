Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Public Class frmProduto
    Private ObjSistema As New cldSistema
    Private ObjProduto As New clnProduto
    Dim ctrlScreen As Integer


    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        e.Cancel = False
    End Sub

    Private codigo As Integer
    Private idFornecedor As Integer
    Private IdCodItem As String
    Dim mOperacao As clnFuncoesGerais.IncluirAlterar
    Dim mCategoria As clnProduto.MenuCategoria
    Dim mModoForm As clnFuncoesGerais.ModoForm
    Dim mModoListar As clnFuncoesGerais.ModoListar
    Dim Erro As New ErrorProvider
    Dim x As String
    Dim mAtivo As Boolean
    Public Property Ativo() As Boolean
        Get
            Return mAtivo
        End Get
        Set(ByVal Value As Boolean)
            mAtivo = Value
        End Set
    End Property

    Public Property ModoListar() As clnFuncoesGerais.ModoListar
        Get
            Return mModoListar
        End Get
        Set(ByVal Value As clnFuncoesGerais.ModoListar)
            mModoListar = Value
        End Set
    End Property

    Public Property ModoForm() As clnFuncoesGerais.ModoForm
        Get
            Return mModoForm
        End Get
        Set(ByVal Value As clnFuncoesGerais.ModoForm)
            mModoForm = Value
        End Set
    End Property

    Public Property Operacao() As clnFuncoesGerais.IncluirAlterar
        Get
            Return mOperacao
        End Get
        Set(ByVal Value As clnFuncoesGerais.IncluirAlterar)
            mOperacao = Value
        End Set
    End Property

    Private Sub ModoPesquisa()
        mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
        Me.pnLatEsq.Size = New Size(1014, 635)
        Me.lsvReduzida.Size = New Size(991, 363)
        With Me.pbNext
            .Name = "pbForward"
            .BackgroundImage = My.Resources.back
            .Location = New Point(969, 12)
        End With
        Me.lsvReduzida.Visible = True
        Me.lblProcurar.Visible = True
        Me.lblPNome.Visible = True
        Me.btnPesquisar.Visible = True
        Me.txtPNome.Visible = True
        Me.pnPrincipal.Visible = False
        Me.gbBtn.Visible = False


        If mModoListar = clnFuncoesGerais.ModoListar.ModoListarProdutos Then
            With frmMenu.lblInfoTela
                .Text = "Pesquisa de Produtos"
                .Visible = True
            End With
        ElseIf mModoListar = clnFuncoesGerais.ModoListar.ModoListarEstoque Then
            With frmMenu.lblInfoTela
                .Text = "Estoque dos Produtos"
                .Visible = True
            End With
        ElseIf mModoListar = clnFuncoesGerais.ModoListar.ModoLProdutoUser Then
            With frmMenu.lblInfoTela
                .Text = "Pesquisa de Produtos"
                .Visible = True
            End With
        End If
        InicializarLV()
    End Sub

    Private Sub ModoCadastroLV()
        mModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
        Me.pnLatEsq.Size = New Size(39, 633)
        Me.lsvReduzida.Visible = False
        Me.pbNext.Name = "pbNext"
        Me.pbNext.BackgroundImage = My.Resources._next
        Me.pbNext.Location = New Point(3, 3)
        Me.lblProcurar.Visible = False
        Me.lblPNome.Visible = False
        Me.btnPesquisar.Visible = False
        Me.txtPNome.Visible = False
        With Me.pnPrincipal
            .Visible = False
        End With

        Me.pnCadProd.Visible = True
        With frmMenu.lblInfoTela
            .Text = "Cadastro de Produtos"
            .Visible = True
        End With

        Me.gbBtn.Visible = True
        With Me.btnCancelar
            .Visible = True
            .Enabled = True
        End With

        With Me.btnEditar
            .Visible = True
            .Enabled = True
        End With

        With Me.btnNovo
            .Visible = True
            .Enabled = False
        End With

        Me.btnSalvar.Visible = True
        Me.btnDesativar.Visible = True
        Me.lblCmbAcessorio.Visible = True
        Me.lblCmbJogo.Visible = True
        Me.lblpbCmbConsole.Visible = True


    End Sub

    Private Sub ModoCadastro()
        mModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
        Me.pnLatEsq.Size = New Size(39, 633)
        Me.lsvReduzida.Visible = False
        Me.pbNext.Name = "pbNext"
        Me.pbNext.BackgroundImage = My.Resources._next
        Me.pbNext.Location = New Point(3, 3)
        Me.lblProcurar.Visible = False
        Me.lblPNome.Visible = False
        Me.btnPesquisar.Visible = False
        Me.txtPNome.Visible = False
        With Me.pnPrincipal
            .Visible = True
            .Location = New Point(48, 176)
            .Size = New Size(945, 199)
        End With

        Me.gbBtn.Visible = False
        Me.pnCadProd.Visible = False
        With frmMenu.lblInfoTela
            .Text = "Cadastro de Produtos"
            .Visible = True
        End With
        InicializaLVScreen()
    End Sub

    Private Sub Modo()
        Me.gbBtn.Visible = True
        With Me.pnCadProd
            .Visible = True
            .Enabled = False
        End With

        Me.pnPrincipal.Visible = False
        With Me.btnNovo
            .Visible = True
            .Enabled = True
        End With

        With Me.btnEditar
            .Visible = True
            .Enabled = False
        End With

        With Me.btnSalvar
            .Visible = True
            .Enabled = False
        End With

        With Me.btnCancelar
            .Visible = True
            .Enabled = False
        End With

        With Me.btnDesativar
            .Visible = False
            .Enabled = False
        End With
        Me.lblCmbAcessorio.Visible = True
        Me.lblCmbJogo.Visible = True
        Me.lblpbCmbConsole.Visible = True
    End Sub

    Private Sub CarregaCombo()
        With clbCategoria
            .DataSource = ObjProduto.ListaTabela("CATEGORIA").Tables(0)
            .DisplayMember = "nmCATEGORIA"
            .ValueMember = "idCATEGORIA"

        End With

        With clbGenero
            .DataSource = ObjProduto.ListaTabela("Genero").Tables(0)
            .DisplayMember = "nmGenero"
            .ValueMember = "idGenero"
        End With
        With cboPlataforma
            .DataSource = ObjProduto.ListaTabela("PLATAFORMA").Tables(0)
            .DisplayMember = "nmPlataforma"
            .ValueMember = "idPlataforma"
            .SelectedIndex = -1
        End With

        With cboFormato
            .DataSource = ObjProduto.ListaTabela("MIDIA").Tables(0)
            .DisplayMember = "nmMidia"
            .ValueMember = "idMidia"
            .SelectedIndex = -1
        End With

        With cboFabPub
            .DataSource = ObjProduto.ListaTabela("PUBLICADOR").Tables(0)
            .DisplayMember = "nmPublicador"
            .ValueMember = "idPublicador"
            .SelectedIndex = -1
        End With

        With cboDesenvolvedor
            .DataSource = ObjProduto.ListaTabela("DESENVOLVEDOR").Tables(0)
            .DisplayMember = "nmDESENVOLVEDOR"
            .ValueMember = "idDESENVOLVEDOR"
            .SelectedIndex = -1
        End With

        With cboESRB
            .DataSource = ObjProduto.ListaTabela("ESRB").Tables(0)
            .DisplayMember = "nmESRB"
            .ValueMember = "idESRB"
            .SelectedIndex = -1

        End With

    End Sub

    'Private Sub GeraCodItem() Handles txtEan.LostFocus
    '    Dim vDados As String
    '    Dim Numero(12) As Integer
    '    vDados = Me.txtEan.Text
    '    For i = 0 To 12
    '        Numero(i) = CInt(vDados.Substring(i, 1))
    '    Next

    '    Dim coditem As Integer = mCategoria & (Numero(0) + Numero(1) + Numero(2) + Numero(3) & Numero(4) + Numero(5) + Numero(6) + Numero(7) & Numero(8) + Numero(9) + Numero(10) + Numero(11)) * 2 & Numero(12)

    '    IdCodItem = coditem

    'End Sub

    Private Sub Limpar() Handles btnCancelar.Click

        For Each LC As Control In Me.pnCadProd.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = Nothing
                LC.CausesValidation = False
            End If
            If TypeOf LC Is ComboBox Then
                LC.Text = Nothing
            End If
        Next



        For Each LC As Control In Me.pnLatEsq.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = Nothing
                LC.CausesValidation = False
            End If
        Next


        Me.rtbdescrProduto2.Text = Nothing
        Me.rtbdescrProduto.Text = Nothing
        Me.btnCancelar.Enabled = False
        Me.btnSalvar.Enabled = False
        Me.btnNovo.Enabled = True
        Me.btnDesativar.Enabled = False
        Me.pnCadProd.Enabled = False
        Me.btnEditar.Enabled = False
        Me.Foto.Image = Nothing
        lblCmbJogo.Visible = True
        lblpbCmbConsole.Visible = True
        lblCmbAcessorio.Visible = True
        pbNext.Visible = True
        lsvSV.Clear()

    End Sub

    Private Sub CampoObrigatorio()
        'lblRazaoSocial.ForeColor = Color.Red
        'lblCNPJ.ForeColor = Color.Red
        'lblCep.ForeColor = Color.Red
        'lblNo.ForeColor = Color.Red
        'lblTelefone.ForeColor = Color.Red
    End Sub

    Private Sub frmProduto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub frmProduto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mModoForm = clnFuncoesGerais.ModoForm.ModoCadastro Then
            ModoCadastro()
        Else
            ModoPesquisa()
        End If
        CarregaCombo()
    End Sub


    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao

        Me.btnCancelar.Enabled = True
        Me.btnSalvar.Enabled = True
        Me.btnNovo.Enabled = False
        Me.btnDesativar.Visible = False
        Me.pnCadProd.Enabled = True
        Me.txtEan.Focus()
        mAtivo = True
        For Each LC As Control In Me.pnCadProd.Controls
            If TypeOf LC Is TextBox Then
                LC.CausesValidation = True
            End If
        Next
    End Sub

    Private Sub btnDesativar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesativar.Click

        If Me.btnDesativar.Text = "&Desativar" Then
            mAtivo = False
            With Me.btnDesativar
                .Text = "&Ativar"
                .Image = My.Resources.green_button
            End With
            mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao

        ElseIf Me.btnDesativar.Text = "&Ativar" Then
            mAtivo = True
            With Me.btnDesativar
                .Text = "&Desativar"
                .Image = My.Resources.remove
            End With
            mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao

        End If
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click

        Dim objClsProduto As New clnProduto

        With objClsProduto
            .Nome = txtNomeProduto.Text.Trim.Replace("'", "")
            .NomeRzd = txtnmReduzido.Text.Trim.Replace("'", "")
            .Desc = rtbdescrProduto.Text.Trim.Replace("'", "")
            .Desc2 = rtbdescrProduto2.Text.Trim.Replace("'", "")
            .Icone = x
            .IdDesenvolvedor = cboDesenvolvedor.SelectedValue
            .IdPublicador = cboFabPub.SelectedValue
            .IdPlataforma = cboPlataforma.SelectedValue
            If txtdtLancamento.Text = "" Then
                .DtLancamento = Date.Now
            Else
                .DtLancamento = txtdtLancamento.Text
            End If

            .idESRB = cboESRB.SelectedValue
            .IdMidia = cboFormato.SelectedValue
            .IdTpProduto = mCategoria
            If txtdtLancamento.Text = "" Then
                .NoPlayers = 1
            Else
                .NoPlayers = txtnoPlayers.Text.Trim.Replace("'", "")
            End If

            .Garantia = txtGarantia.Text.Trim.Replace("'", "")
            .NoEstMin = txtEstMin.Text.Trim.Replace("'", "")
            .NoEstMax = txtEstMax.Text.Trim.Replace("'", "")
            .NoEstAlvo = txtEstAlvo.Text.Trim.Replace("'", "")
            .Ativo = mAtivo
            .DtCadastro = Date.Now
            .Margem = txtMargem.Text.Trim.Replace("'", "")
        End With

        If mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao Then

            objClsProduto.GravaProduto()

            Dim drDados As SqlDataReader

            drDados = objClsProduto.RetornaUltimoCod("idProduto", "PRODUTO")
            If drDados.Read Then
                IdCodItem = drDados("ID")
            End If

            Dim i As Integer

            For i = 0 To lbEAN.Items.Count - 1
                With objClsProduto
                    .Nome = lbEAN.Items(i)
                    .ID = IdCodItem
                    .GravaEAN()
                End With
            Next

            For i = 0 To lbItemIncluso.Items.Count - 1
                With objClsProduto
                    .Nome = lbItemIncluso.Items(i)
                    .ID = IdCodItem
                    .GravaITEMINCLUSO()
                End With
            Next


            For i = 0 To clbCategoria.Items.Count - 1

                If clbCategoria.GetItemCheckState(i) = CheckState.Checked Then
                    clbCategoria.SetSelected(i, True)
                    With objClsProduto
                        .ID = IdCodItem
                        .IdCategoria = clbCategoria.SelectedValue
                        .GravaPRODUTO_CATEGORIA()
                    End With

                End If
            Next

            For i = 0 To clbGenero.Items.Count - 1

                If clbGenero.GetItemCheckState(i) = CheckState.Checked Then
                    clbGenero.SetSelected(i, True)
                    With objClsProduto
                        .ID = IdCodItem
                        .IdGenero = clbGenero.SelectedValue
                        .GravaPRODUTO_GENERO()
                    End With

                End If
            Next

            With objClsProduto
                .ID = IdCodItem
                .VlCusto = txtValorCusto.Text.Trim.Replace("'", "")
                .VlVendaLoja = txtVendaLoja.Text.Trim.Replace("'", "")
                .DtCadastro = Date.Now
                .GravaPRECO_PRODUTO()
            End With



            i = lsvSV.Items.Count

            For Each lvi As ListViewItem In lsvSV.Items
                With objClsProduto
                    .Nome = (lvi.Text)
                    .ID = IdCodItem
                    .NomeRzd = (lvi.SubItems(2).Text)
                    .GravaSCREENSHOT()
                End With
            Next


            MessageBox.Show("Registro do item  GRAVADO com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao Then 'Alteração
            If mCategoria = clnProduto.MenuCategoria.Jogo Then
                objClsProduto.AtualizaProduto()
            Else
                'objClsProduto.AlterarConsole()
            End If
            MessageBox.Show("Registro Número " & txtEan.Text & ", alterado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        'Limpar()
    End Sub

    Private Sub pbNext_Click(sender As System.Object, e As System.EventArgs) Handles pbNext.Click
        If Me.pbNext.Name = "pbNext" Then
            ModoPesquisa()
            mModoListar = clnFuncoesGerais.ModoListar.ModoListarProdutos
            Limpar()
            Exit Sub
        ElseIf Me.pbNext.Name = "pbForward" Then
            ModoCadastro()
        End If

    End Sub

    Private Sub pbCmbJogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCmbJogo.Click, lblCmbJogo.Click
        lblCmbJogo.BackColor = Color.PaleGreen
        lblpbCmbConsole.BackColor = Color.WhiteSmoke
        lblCmbAcessorio.BackColor = Color.WhiteSmoke
        mCategoria = clnProduto.MenuCategoria.Jogo
        lblGenero.Visible = True
        Modo()
    End Sub

    Private Sub pbCmbConsole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCmbConsole.Click, lblpbCmbConsole.Click
        lblCmbJogo.BackColor = Color.WhiteSmoke
        lblpbCmbConsole.BackColor = Color.PaleGreen
        lblCmbAcessorio.BackColor = Color.WhiteSmoke
        mCategoria = clnProduto.MenuCategoria.Console
        lblGenero.Visible = False
        Modo()
    End Sub

    Private Sub pbCmbAcessorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbCmbAcessorio.Click, lblCmbAcessorio.Click
        lblCmbJogo.BackColor = Color.WhiteSmoke
        lblpbCmbConsole.BackColor = Color.WhiteSmoke
        lblCmbAcessorio.BackColor = Color.PaleGreen
        mCategoria = clnProduto.MenuCategoria.Acessorio
        lblGenero.Visible = False
        Modo()
    End Sub

    Private Sub InicializarLV()

        With lsvReduzida
            .MultiSelect = False
            .Sorting = SortOrder.Ascending
            .GridLines = True
            .FullRowSelect = True
            .AllowColumnReorder = False
            .LabelEdit = False
            .View = View.Details
        End With

        If mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa Then
            If mModoListar = clnFuncoesGerais.ModoListar.ModoLProdutoUser Then
                With lsvReduzida
                    .Items.Clear()
                    .Columns.Clear()
                    .Columns.Add("NºItem", 100, HorizontalAlignment.Center)
                    .Columns.Add("EAN", 120, HorizontalAlignment.Center)
                    .Columns.Add("Categoria", 120, HorizontalAlignment.Center)
                    .Columns.Add("Nome", 250, HorizontalAlignment.Left)
                    .Columns.Add("Plataforma", 150, HorizontalAlignment.Center)
                    .Columns.Add("Fabricante", 150, HorizontalAlignment.Center)
                    .Columns.Add("Preço", 70, HorizontalAlignment.Center)
                    .Font = New System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold)
                End With
            ElseIf mModoListar = clnFuncoesGerais.ModoListar.ModoListarProdutos Then
                With lsvReduzida
                    .Items.Clear()
                    .Columns.Clear()
                    .Columns.Add("NºItem", 100, HorizontalAlignment.Center)
                    .Columns.Add("EAN", 120, HorizontalAlignment.Center)
                    .Columns.Add("Categoria", 120, HorizontalAlignment.Center)
                    .Columns.Add("Nome", 250, HorizontalAlignment.Left)
                    .Columns.Add("Plataforma", 150, HorizontalAlignment.Center)
                    .Columns.Add("Fabricante", 150, HorizontalAlignment.Center)
                    .Columns.Add("Preço", 70, HorizontalAlignment.Center)
                    .Font = New System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold)
                End With

            ElseIf mModoListar = clnFuncoesGerais.ModoListar.ModoListarEstoque Then
                With lsvReduzida
                    .Items.Clear()
                    .Columns.Clear()
                    .Columns.Add("NºItem", 100, HorizontalAlignment.Center)
                    .Columns.Add("EAN", 120, HorizontalAlignment.Center)
                    .Columns.Add("Nome", 350, HorizontalAlignment.Left)
                    .Columns.Add("Comprado", 80, HorizontalAlignment.Center)
                    .Columns.Add("Vendido", 80, HorizontalAlignment.Center)
                    .Columns.Add("Reservado", 80, HorizontalAlignment.Center)
                    .Columns.Add("Est.Fisico", 80, HorizontalAlignment.Center)
                    .Columns.Add("Est.Virtual", 80, HorizontalAlignment.Center)
                    .Font = New System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold)
                End With

            End If
        End If

    End Sub

    Private Sub CarregarListView()
        Dim clsObjclnFuncoesGerais As New clnFuncoesGerais
        Dim objClsProduto As New clnProduto

        If mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa Then
            If mModoListar = clnFuncoesGerais.ModoListar.ModoListarProdutos Then
                Dim ds As Data.DataSet = objClsProduto.ListaProdutos((Regex.Replace(Me.txtPNome.Text, "[\\\?\*-./]", "")))
                Dim dtable As DataTable = ds.Tables(0)
                lsvReduzida.Items.Clear()
                For i As Integer = 0 To dtable.Rows.Count - 1
                    Dim drow As DataRow = dtable.Rows(i)
                    If drow.RowState <> DataRowState.Deleted Then
                        Dim lvi As New ListViewItem(drow("EAN").ToString())
                        lvi.SubItems.Add(drow("nmCategoria").ToString())
                        lvi.SubItems.Add(drow("Nome").ToString())
                        lvi.SubItems.Add(drow("nmPlataforma").ToString())
                        lvi.SubItems.Add(drow("nmFabricante").ToString())
                        lvi.SubItems.Add(drow("vlVenda").ToString())
                        lvi.Font = New System.Drawing.Font("calibri", 10, System.Drawing.FontStyle.Regular)
                        lsvReduzida.Items.Add(lvi)
                    End If
                Next
            ElseIf mModoListar = clnFuncoesGerais.ModoListar.ModoLProdutoUser Then
                Dim ds As Data.DataSet = objClsProduto.ListaProdutos((Regex.Replace(Me.txtPNome.Text, "[\\\?\*-./]", "")))
                Dim dtable As DataTable = ds.Tables(0)
                lsvReduzida.Items.Clear()
                For i As Integer = 0 To dtable.Rows.Count - 1
                    Dim drow As DataRow = dtable.Rows(i)
                    If drow.RowState <> DataRowState.Deleted Then
                        Dim lvi As New ListViewItem(drow("EAN").ToString())
                        lvi.SubItems.Add(drow("nmCategoria").ToString())
                        lvi.SubItems.Add(drow("Nome").ToString())
                        lvi.SubItems.Add(drow("nmPlataforma").ToString())
                        lvi.SubItems.Add(drow("nmFabricante").ToString())
                        lvi.SubItems.Add(drow("vlVenda").ToString())
                        lvi.Font = New System.Drawing.Font("calibri", 10, System.Drawing.FontStyle.Regular)
                        lsvReduzida.Items.Add(lvi)
                    End If
                Next
            ElseIf mModoListar = clnFuncoesGerais.ModoListar.ModoListarEstoque Then
                Dim ds As Data.DataSet = objClsProduto.ListaEstoque((Regex.Replace(Me.txtPNome.Text, "[\\\?\*-./]", "")))
                Dim dtable As DataTable = ds.Tables(0)
                lsvReduzida.Items.Clear()
                For i As Integer = 0 To dtable.Rows.Count - 1
                    Dim drow As DataRow = dtable.Rows(i)
                    If drow.RowState <> DataRowState.Deleted Then
                        Dim lvi As New ListViewItem(drow("EAN").ToString())
                        lvi.SubItems.Add(drow("Nome").ToString())
                        lvi.SubItems.Add(drow("QtdComprada").ToString())
                        lvi.SubItems.Add(drow("QtdVendida").ToString())
                        lvi.SubItems.Add(drow("QtdReservada").ToString())
                        lvi.SubItems.Add(drow("Estoque_Fisico").ToString())
                        lvi.SubItems.Add(drow("Estoque_Virtual").ToString())
                        lvi.Font = New System.Drawing.Font("calibri", 10, System.Drawing.FontStyle.Regular)
                        lsvReduzida.Items.Add(lvi)
                    End If
                Next
            End If
        End If
        ObjSistema.pZebra(lsvReduzida, Color.SlateGray, Color.PaleGreen)
    End Sub

    Private Sub CarregaPesquisa()
        Dim objClsProduto As New clnProduto
        Dim drDados As System.Data.SqlClient.SqlDataReader
        drDados = objClsProduto.CarregarProduto(codigo)
        If drDados.Read Then
            CarregaCombo()
            Me.txtEan.Text = drDados("EAN").ToString.Trim
            Me.txtNomeProduto.Text = drDados("Nome").ToString.Trim
            Me.txtEstMin.Text = drDados("noMinEst").ToString.Trim
            Me.txtEstMax.Text = drDados("noMaxEst").ToString.Trim
            Me.txtEstAlvo.Text = drDados("EstAlvo").ToString.Trim
            Me.rtbdescrProduto.Text = drDados("Descricao").ToString.Trim
            Me.Foto.ImageLocation = "C:Imagem\" & drDados("Foto").ToString.Trim
            Me.cboFabPub.SelectedValue = drDados("cdFabricante").ToString.Trim
            Me.cboPlataforma.SelectedValue = Integer.Parse(drDados("cdPlataforma"))
            Me.cboFormato.SelectedValue = Integer.Parse(drDados("cdMidia"))
            mAtivo = CInt(drDados("Ativo"))
            If mAtivo = False Then
                With Me.btnDesativar
                    .Text = "&Ativar"
                    .Image = My.Resources.green_button
                End With
            Else
                With Me.btnDesativar
                    .Text = "&Desativar"
                    .Image = My.Resources.remove
                End With
            End If
            Me.btnDesativar.Visible = True
        End If

    End Sub

    Private Sub lsvReduzida_DoubleClick(sender As Object, e As System.EventArgs) Handles lsvReduzida.DoubleClick
        If Not lsvReduzida.SelectedItems.Count = 0 Then
            With lsvReduzida.SelectedItems.Item(0)
                codigo = .SubItems(0).Text
            End With
            If mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa Then
                If mModoListar = clnFuncoesGerais.ModoListar.ModoListarProdutos Then
                    CarregaPesquisa()
                    ModoCadastroLV()
                    Me.pnCadProd.Enabled = False
                ElseIf mModoListar = clnFuncoesGerais.ModoListar.ModoListarEstoque Then
                    Exit Sub
                ElseIf mModoListar = clnFuncoesGerais.ModoListar.ModoLProdutoUser Then
                    Exit Sub
                End If
            End If
        End If
        lblCmbJogo.Visible = False
        lblpbCmbConsole.Visible = False
        lblCmbAcessorio.Visible = False

    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao
        Me.pnCadProd.Enabled = True
        Me.btnSalvar.Enabled = True
        Me.btnDesativar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEditar.Enabled = False
        Me.pbNext.Visible = False
        Me.txtEan.Focus()

    End Sub

    Private Sub cboPlataforma_GotFocus(sender As Object, e As System.EventArgs) Handles cboPlataforma.GotFocus, cboFabPub.GotFocus, cboFormato.GotFocus, cboESRB.GotFocus, cboDesenvolvedor.GotFocus
        SendKeys.Send("{F4}")
    End Sub

    Private Sub btnPesquisar_Click(sender As System.Object, e As System.EventArgs) Handles btnPesquisar.Click
        CarregarListView()
    End Sub


    Private Sub btnVideo_Click(sender As System.Object, e As System.EventArgs) Handles btnVideo.Click
        Dim TextReturned As String = ""
        Dim a As New InputBox
        If a.ShowDialog("URL do Video", "Digite a URL do Vídeo", "", TextReturned, False) = Windows.Forms.DialogResult.Cancel Then
            Beep()
            MessageBox.Show("OPERAÇÃO CANCELADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else


            Dim Itens(2) As String
            Itens(0) = txtnmReduzido.Text.Replace("'", "")
            Itens(1) = a.Txt_TextEntry.Text.Replace("'", "")
            Itens(2) = "Video"

            Dim ItemEncontrado As Boolean = False

            For Each objLVI As ListViewItem In lsvSV.Items
                If objLVI.Text.Equals(Itens(0).ToString()) Then
                    MsgBox("Ja na lista")
                    ItemEncontrado = True
                End If
            Next

            If Not ItemEncontrado Then
                Dim item As New ListViewItem(Itens(0).ToString())
                item.SubItems.Add(Itens(1).ToString)
                item.SubItems.Add(Itens(2).ToString)
                lsvSV.Items.Add(item)

            End If

        End If
    End Sub

    Private Sub InicializaLVScreen()
        With lsvSV
            .MultiSelect = False
            .Sorting = SortOrder.Ascending
            .GridLines = True
            .FullRowSelect = True
            .AllowColumnReorder = False
            .LabelEdit = False
            .View = View.Details
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("Descrição", 150, HorizontalAlignment.Center)
            .Columns.Add("Local", 200, HorizontalAlignment.Center)
            .Columns.Add("Tipo", 100, HorizontalAlignment.Left)
            .Font = New System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold)
        End With
    End Sub

    Private Sub Carrega_SV()
        Dim Itens(6) As String


        Dim ItemEncontrado As Boolean = False

        For Each objLVI As ListViewItem In lsvReduzida.Items
            If objLVI.Text.Equals(Itens(0).ToString()) Then
                MsgBox("Ja na lista")
                ItemEncontrado = True
            End If
        Next

        If Not ItemEncontrado Then
            Dim item As New ListViewItem(Itens(0).ToString())
            item.SubItems.Add(Itens(1).ToString)
            item.SubItems.Add(Itens(2).ToString)
            item.SubItems.Add(String.Format("{0:C}", Convert.ToDouble(Itens(3).ToString)))
            item.SubItems.Add(String.Format("{0:C}", Convert.ToDouble(Itens(4).ToString)))
            item.SubItems.Add(Itens(5).ToString)
            lsvReduzida.Items.Add(item)
            item.SubItems.Add(Itens(6).ToString)
        End If
        Dim objClsFGeral As New clnFuncoesGerais
        ObjSistema.AgruparListView(lsvReduzida, 5)

    End Sub

    Private Sub Foto_Click(sender As System.Object, e As System.EventArgs) Handles Foto.Click, pbScreen.Click
        Dim ObjOFDImagem As New OpenFileDialog
        With ObjOFDImagem
            .InitialDirectory = "C:\"
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.png;*.jpg"
            .FilterIndex = 2
            If .ShowDialog = DialogResult.OK Then
                With Foto
                    .Image = Image.FromFile(ObjOFDImagem.FileName)
                    .SizeMode = PictureBoxSizeMode.Zoom
                    .BorderStyle = BorderStyle.None
                End With

                Dim file_name As String = ObjOFDImagem.FileName
                file_name = _
                    file_name.Substring(file_name.LastIndexOf("."))
                My.Computer.FileSystem.CreateDirectory("C:\Imagem\Cover")
                file_name = "capa_" & cboPlataforma.Text & "_" & txtNomeProduto.TextLength & cboFormato.SelectedValue & cboFabPub.SelectedValue & cboDesenvolvedor.SelectedValue & cboESRB.SelectedValue & clbCategoria.SelectedValue & file_name
                Foto.Image.Save("C:\Imagem\Cover\" & file_name)

                x = file_name

            End If

        End With
    End Sub

    Private Sub btnAddEAN_Click(sender As System.Object, e As System.EventArgs) Handles btnAddEAN.Click
        lbEAN.Items.Add(txtEan.Text.Replace("'", ""))
    End Sub

    Private Sub btnAddItemIncl_Click(sender As System.Object, e As System.EventArgs) Handles btnAddItemIncl.Click
        lbItemIncluso.Items.Add(txtItemIncluso.Text.Replace("'", ""))
    End Sub

    Private Sub lbEAN_DoubleClick(sender As Object, e As System.EventArgs) Handles lbEAN.DoubleClick
        lbEAN.Items.Remove(lbEAN.SelectedItem)
    End Sub

    Private Sub lbItemIncluso_DoubleClick(sender As Object, e As System.EventArgs) Handles lbItemIncluso.DoubleClick
        lbItemIncluso.Items.Remove(lbItemIncluso.SelectedItem)
    End Sub

    Private Sub btnScreen_Click_1(sender As System.Object, e As System.EventArgs) Handles btnScreen.Click
        Dim Tipo As String
        ctrlScreen = ctrlScreen + 1
        Tipo = "ScreenShoot"
        Dim ObjOFDImagem As New OpenFileDialog
        With ObjOFDImagem
            .InitialDirectory = "C:\"
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.png;*.jpg"
            .FilterIndex = 2
            If .ShowDialog = DialogResult.OK Then
                With pbScreen
                    .Image = Image.FromFile(ObjOFDImagem.FileName)
                    .SizeMode = PictureBoxSizeMode.Zoom
                    .BorderStyle = BorderStyle.None
                End With

                Dim URL As String = ObjOFDImagem.FileName
                URL = URL.Substring(URL.LastIndexOf("."))
                URL = "screen_" & cboPlataforma.Text & "_" & txtNomeProduto.TextLength & cboFormato.SelectedValue & cboFabPub.SelectedValue & cboDesenvolvedor.SelectedValue & cboESRB.SelectedValue & clbCategoria.SelectedValue & ctrlScreen & URL
                My.Computer.FileSystem.CreateDirectory("C:\Imagem\Screen")
                pbScreen.Image.Save("C:\Imagem\Screen\" & URL)

                Dim Itens(2) As String
                Itens(0) = URL
                Itens(1) = "C:\Imagem\Screen\" & URL
                Itens(2) = Tipo

                Dim item As New ListViewItem(Itens(0).ToString())
                item.SubItems.Add(Itens(1).ToString)
                item.SubItems.Add(Itens(2).ToString)
                lsvSV.Items.Add(item)

            End If

        End With
    End Sub

    Private Sub lsvSV_DoubleClick(sender As Object, e As System.EventArgs) Handles lsvSV.DoubleClick
        For Each i As ListViewItem In lsvSV.SelectedItems
            lsvSV.Items.Remove(i)
        Next
    End Sub

    Private Sub lsvSV_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lsvSV.SelectedIndexChanged
        With Me.lsvSV
            Dim i As Integer
            For Each item As ListViewItem In lsvSV.SelectedItems
                i = item.Index
            Next

            Dim innercounter As Integer = 0

            For Each subItem As ListViewItem.ListViewSubItem In lsvSV.Items(i).SubItems
                Dim myString As String = lsvSV.Items(i).SubItems(innercounter).Text

                If lsvSV.Items(i).SubItems(2).Text = "Video" Then
                    Exit Sub
                Else
                    Select Case innercounter
                        Case 1
                            pbScreen.Image = Image.FromFile(myString)
                        Case 2

                        Case 3

                        Case 4

                        Case 5

                    End Select
                End If
                innercounter += 1
            Next
        End With


    End Sub


    Private Sub txtValorCusto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtValorCusto.TextChanged

    End Sub

    Private Sub txtNomeProduto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNomeProduto.TextChanged

    End Sub
End Class
