Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Imports System.Windows.Forms

Public Class frmPedido
    Private ObjSistema As New cldSistema
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        e.Cancel = False
    End Sub
    Dim teste As Double = 0

    Dim mTpVenda As clnFuncoesGerais.TPVENDA
    Dim codCli As Integer
    Dim codFunc As Integer
    Dim CodProduto As Integer
    Dim Erro As New ErrorProvider
    Dim mFPgto As clnFuncoesGerais.FPGTO
    Dim mModoForm As clnFuncoesGerais.ModoForm
    Dim Itens(6) As String


    Public Property ModoForm() As clnFuncoesGerais.ModoForm
        Get
            Return mModoForm
        End Get
        Set(ByVal Value As clnFuncoesGerais.ModoForm)
            mModoForm = Value
        End Set
    End Property

    Public Property TpVenda() As clnFuncoesGerais.TPVENDA
        Get
            Return mTpVenda
        End Get
        Set(ByVal Value As clnFuncoesGerais.TPVENDA)
            mTpVenda = Value
        End Set
    End Property

    Private Sub ModoPesquisa()

        Me.pnLatEsq.Size = New Size(1014, 635)
        With Me.pbNext
            .Name = "pbForward"
            .BackgroundImage = My.Resources.back
            .Location = New Point(969, 12)
            .Visible = False
        End With
        With frmMenu.lblInfoTela
            .Text = "Pesquisar Pedido de Venda"
            .Visible = True
        End With
        pnLatEsq.Visible = True
        InicializarLV()
    End Sub

    Private Sub Balcao()
        Me.tbDetPDV.TabPages.Add(tbPGTO())
        mTpVenda = clnFuncoesGerais.TPVENDA.Balcao
        Me.tbDetPDV.TabPages.Remove(tbEntrega())
        Me.btnNF.Visible = False
        Me.btnEnviar.Visible = False
        Me.btnSalvar.Location = New Point(150, 11)
        Me.btnCancelar.Location = New Point(293, 11)
        Me.txtCodFunc.Focus()
        With frmMenu.lblInfoTela
            .Text = "Pedido de Venda - Balcão"
            .Visible = True
        End With

    End Sub

    Private Sub Telefone()
        mTpVenda = clnFuncoesGerais.TPVENDA.Telefone
        Me.tbDetPDV.TabPages.Add(tbEntrega())
        Me.tbDetPDV.TabPages.Add(tbPGTO())
        Me.btnNF.Visible = True
        Me.btnEnviar.Visible = True
        Me.txtCPF.Enabled = True
        Me.btnSalvar.Location = New Point(401, 11)
        Me.btnCancelar.Location = New Point(544, 11)
        With frmMenu.lblInfoTela
            .Text = "Pedido de Venda - Telefone"
            .Visible = True
        End With
    End Sub

    Private Sub BuscaCep()
        Dim drDados As System.Data.SqlClient.SqlDataReader
        Dim objClsFGeral As New clnFuncoesGerais
        drDados = objClsFGeral.BuscaCEP(Me.txtCep.Text.Replace("-", ""))
        If drDados.Read Then
            Me.txtLog.Text = CStr(drDados("nmLogradouro"))
            Me.txtBairro.Text = CStr(drDados("nmBairro"))
            Me.txtCidade.Text = CStr(drDados("nmCidade"))
            Me.txtUF.Text = CStr(drDados("sgUF"))
        End If
    End Sub

    Private Sub BuscarClienteCPF()
        Dim clsObjclnFuncoesGerais As New clnFuncoesGerais
        Dim drDados As System.Data.SqlClient.SqlDataReader
        drDados = clsObjclnFuncoesGerais.BuscaCPFCliente(Regex.Replace(Me.txtCPF.Text.ToString.Trim, "[\\\?\*-./]", ""))
        If drDados.Read Then
            codCli = CInt(drDados("cdCli"))
            lblNomeCliente.Text = CStr(drDados("Nome"))
            lblNomeCliente.Visible = True
            CarregaCombo()
            txtDestinatario.Text = CStr(drDados("Nome"))
            txtCep.Text = CStr(drDados("noCEP"))
            txtNo.Text = CStr(drDados("noLog"))
            txtComplemento.Text = CStr(drDados("Complemento"))
            BuscaCep()
        End If
    End Sub

    Private Sub BuscarFuncionarioCod()
        Dim clsObjclnFuncoesGerais As New clnFuncoesGerais
        Dim drDados As System.Data.SqlClient.SqlDataReader
        drDados = clsObjclnFuncoesGerais.BuscaFuncionarioCod(Regex.Replace(Me.txtCodFunc.Text.ToString.Trim, "[\\\?\*-./]", ""))
        If drDados.Read Then
            codFunc = CInt(drDados("cdFunc"))
            lblNmFunc.Text = CStr(drDados("Nome"))
            lblNmFunc.Visible = True
            Me.GroupBox2.Enabled = True
        End If
    End Sub

    Private Sub CarregaCombo()
        Dim objClsFuncoesGerais As New clnFuncoesGerais
        Me.cboTransporte.DataSource = objClsFuncoesGerais.CarregaTransporte.Tables(0)
        Me.cboTransporte.DisplayMember = "RazaoSocial"
        Me.cboTransporte.ValueMember = "cdTransp"
        Me.cboTransporte.SelectedIndex = -1

    End Sub

    Private Sub BuscarProdutoEAN()
        Dim objClsFGeral As New clnFuncoesGerais
        Dim drDados As System.Data.SqlClient.SqlDataReader
        If txtEAN.Text <> Nothing Then
            drDados = objClsFGeral.ListaEAN(CStr(Me.txtEAN.Text))
            If drDados.Read Then
                CodProduto = CStr(drDados("cdProduto")).ToString.Trim
                lblNItem.Text = CStr(drDados("noItem")).ToString.Trim
                lblNmProd.Text = CStr(drDados("Nome")).ToString.Trim
                lblPreco.Text = CStr(drDados("vlVenda")).ToString.Trim
                lblEstVirtual.Text = CStr(drDados("Estoque_Virtual")).ToString.Trim
                lblCategoria.Text = CStr(drDados("nmCategoria")).ToString.Trim
                With FOTO
                    .ImageLocation = drDados("Foto").ToString.Trim
                    .SizeMode = PictureBoxSizeMode.Zoom
                    .BorderStyle = BorderStyle.None
                End With
                Me.lblNmProd.Visible = True
                Me.lblNItem.Visible = True
                Me.lblPreco.Visible = True
                Me.lblEstVirtual.Visible = True
                txtQtd.Enabled = True
                txtQtd.Focus()
            Else
                MsgBox("Item não cadastrado")
                With txtEAN
                    .Focus()
                    .Clear()
                End With
                txtQtd.Enabled = False
            End If
        Else
        End If

    End Sub

    Private Sub frmPedido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub frmPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.tbDetPDV.TabPages.Remove(tbEntrega())
        Me.tbDetPDV.TabPages.Remove(tbPGTO())
        If mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa Then
            ModoPesquisa()
        ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoCadastro Then
            If mTpVenda = clnFuncoesGerais.TPVENDA.Balcao Then
                Balcao()
            ElseIf mTpVenda = clnFuncoesGerais.TPVENDA.Telefone Then
                Telefone()
            End If
        End If


    End Sub

    Private Sub InicializarLV()
        With lsvReduzida
            .Columns.Clear()
            .Columns.Add("Nº Item", 100, HorizontalAlignment.Center)
            .Columns.Add("Nome do Produto", 300)
            .Columns.Add("Quantidade", 80, HorizontalAlignment.Center)
            .Columns.Add("Preço Unitário", 100, HorizontalAlignment.Center)
            .Columns.Add("Sub-Total", 100, HorizontalAlignment.Center)
            .MultiSelect = False
            .Sorting = SortOrder.Ascending
            .GridLines = False
            .FullRowSelect = True
            .AllowColumnReorder = False
            .LabelEdit = False
            .View = View.Details
        End With

    End Sub

    Private Sub CarregarLV()

        Itens(0) = lblNItem.Text
        Itens(1) = lblNmProd.Text
        Itens(2) = txtQtd.Text
        Itens(3) = lblPreco.Text
        Itens(4) = txtQtd.Text * lblPreco.Text
        Itens(5) = lblCategoria.Text
        Itens(6) = CodProduto

        Dim ItemEncontrado As Boolean = False

        For Each objLVI As ListViewItem In lsvReduzida.Items
            If objLVI.Text.Equals(Itens(0).ToString()) Then
                objLVI.SubItems(2).Text = Convert.ToDouble(objLVI.SubItems(2).Text) + Convert.ToDouble(Itens(2))
                objLVI.SubItems(4).Text = FormatCurrency((Convert.ToDouble(FormatNumber(objLVI.SubItems(4).Text)) + Convert.ToDouble(FormatNumber(Itens(4))).ToString()))
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


        If mTpVenda = clnFuncoesGerais.TPVENDA.Balcao Then
            For Each item As ListViewItem In lsvReduzida.Items
                btnSalvar.Enabled = True
            Next
        ElseIf mTpVenda = clnFuncoesGerais.TPVENDA.Telefone Then
            For Each item As ListViewItem In lsvReduzida.Items
                btnNF.Enabled = True
            Next
        End If


    End Sub

    Private Sub SomarTotalLV()
        Dim TempSoma As Double = 0
        For Each objLVI As ListViewItem In lsvReduzida.Items
            TempSoma += CDbl(objLVI.SubItems(4).Text)
        Next
        Me.txtTotal.Text = CDbl(TempSoma).ToString("C")
        Me.txtTotalPgr.Text = CDbl(TempSoma + Convert.ToDouble(FormatNumber(txtTxEnvio.Text))).ToString("C")
        teste = Me.txtTotalPgr.Text
    End Sub

    Private Sub GravarPDV()
        Dim objClsPDV As New clnPDV
        Dim dtPed As Date = DateTime.Now
        If mTpVenda = clnFuncoesGerais.TPVENDA.Balcao Then
            With objClsPDV
                .CdFunc = codFunc
                .CdCli = codCli
                .DtPedido = dtPed
                .CdSitPDV = clnFuncoesGerais.SituacaoPDV.Novo
                .CdTPvenda = mTpVenda
                .Ativo = True
            End With
            If txtCPF.Text = Nothing Then
                objClsPDV.GravarPDVBalcao()
            Else
                objClsPDV.GravarPDVBalcaoCli()
            End If


        ElseIf mTpVenda = clnFuncoesGerais.TPVENDA.Telefone Then
            With objClsPDV
                .CdFunc = codFunc
                .CdCli = codCli
                .DtPedido = dtPed
                .CdSitPDV = clnFuncoesGerais.SituacaoPDV.Novo
                .CdTPvenda = mTpVenda
                .Ativo = True
                .GravarPDVBalcaoCli()
            End With
        End If

        Dim drDados As System.Data.SqlClient.SqlDataReader
        drDados = objClsPDV.CarregaCod(Me.txtCodFunc.Text, dtPed)
        If drDados.Read Then
            txtCod.Text = CStr(drDados("cdPDV"))
        End If

    End Sub

    Private Sub Limpar()
        For Each LC As Control In Me.gbCabeca.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
                Erro.SetError(LC, "")
            End If

        Next
        For Each LC As Control In Me.GroupBox2.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
                Erro.SetError(LC, "")
            End If
        Next

        For Each LC As Control In Me.Panel1.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
                Erro.SetError(LC, "")
            End If
            FOTO.Image = Nothing
        Next


        For Each LC As Control In Me.tbPGTO.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
                Erro.SetError(LC, "")
            End If
        Next

        For Each LC As Control In Me.tbEntrega.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
                Erro.SetError(LC, "")
            End If
            Me.cboTransporte.Text = Nothing
        Next

        For Each LC As Control In Me.tbBalcao.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
                Erro.SetError(LC, "")
            End If
        Next

        Me.GroupBox2.Enabled = False
        Me.gbCabeca.Enabled = False
        Me.gbFormaPagto.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnSalvar.Enabled = False
        Me.btnNovo.Enabled = True
        Me.lblNmFunc.Visible = False
        Me.lblNomeCliente.Visible = False
        Me.tbDetPDV.Enabled = False
        Me.lblNmProd.Visible = False
        Me.lblNItem.Visible = False
        Me.lblPreco.Visible = False
        Me.lblEstVirtual.Visible = False
        Me.btnNF.Enabled = False
        Me.btnEnviar.Enabled = False
        Me.tbBalcao.Select()
        lsvReduzida.Items.Clear()
    End Sub

    Private Sub lblCmdAddItem_Click(sender As System.Object, e As System.EventArgs) Handles lblCmdAddItem.Click

        Dim objClsMovEst As New clnMovEst
        With objClsMovEst
            .CdProduto = CodProduto
            .QTDE = CInt(Me.txtQtd.Text.Trim)
            .CdTPMe = clnFuncoesGerais.TPME.Reservado
            .CdDetMe = clnFuncoesGerais.DETME.Venda
            .DtME = DateTime.Now
            .CdPDV = CInt(txtCod.Text.Trim)
            .Ativo = True
            .Gravar()
        End With
        InicializarLV()
        CarregarLV()
        With Me.txtEAN
            .Clear()
            .Focus()
        End With

        With Me.txtQtd
            .Clear()
            .Enabled = False
        End With
        SomarTotalLV()

    End Sub

    Private Sub txtEAN_Enter(sender As Object, e As System.EventArgs) Handles txtEAN.Enter
        If txtCod.Text = Nothing Then
            GravarPDV()
        End If
    End Sub

    Private Sub txtEAN_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEAN.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEAN_Leave(sender As Object, e As System.EventArgs) Handles txtEAN.Leave
        BuscarProdutoEAN()
    End Sub

    Private Sub txtCPF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCPF.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Len(Me.txtCPF.Text) > 0 Then
                    vf = True
                    Me.txtCPF.Text = Mid(Me.txtCPF.Text, 1, Val(Len(Me.txtCPF.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtCPF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCPF.TextChanged
        If vf = False Then
            If Me.txtCPF.Text.Length = 3 Then
                Me.txtCPF.Text = Me.txtCPF.Text & "."
                Me.txtCPF.SelectionStart = Me.txtCPF.Text.Length + 1
            ElseIf Me.txtCPF.Text.Length = 7 Then
                Me.txtCPF.Text = Me.txtCPF.Text & "."
                Me.txtCPF.SelectionStart = Me.txtCPF.Text.Length + 1
            ElseIf Me.txtCPF.Text.Length = 11 Then
                Me.txtCPF.Text = Me.txtCPF.Text & "-"
                Me.txtCPF.SelectionStart = Me.txtCPF.Text.Length + 1
            End If
        End If
    End Sub

    Private Sub txtCPF_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCPF.Validating

        Dim ObjClnFuncoesGerais As New clnFuncoesGerais
        If Me.btnCancelar.Focused Then
            e.Cancel = False

        ElseIf Me.txtCPF.Text = Nothing Then
            e.Cancel = True
            Me.txtCPF.Select(0, Me.txtCPF.Text.Length)
            Erro.SetError(Me.txtCPF, "Campo obrigatório")

        ElseIf Not (Me.txtCPF.Text Like "###.###.###-##") Then
            e.Cancel = True
            Me.txtCPF.Select(0, Me.txtCPF.Text.Length)
            Erro.SetError(Me.txtCPF, "CPF Inválido ")
        ElseIf Not ObjClnFuncoesGerais.validaCPF(txtCPF.Text) Then
            e.Cancel = True
            Me.txtCPF.Select(0, Me.txtCPF.Text.Length)
            Erro.SetError(Me.txtCPF, "Nº CPF Inválido ")
        End If
    End Sub

    Private Sub txtCPF_Validated(sender As Object, e As System.EventArgs) Handles txtCPF.Validated
        Erro.SetError(Me.txtCPF, "")
        Me.lblCPF.ForeColor = Color.Black
    End Sub

    Private Sub txtCPF_Leave(sender As Object, e As System.EventArgs) Handles txtCPF.Leave
        lblNomeCliente.Visible = True
        BuscarClienteCPF()
    End Sub

    Private Sub rbDinheiro_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbDinheiro.CheckedChanged
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais
        mFPgto = clnFuncoesGerais.FPGTO.Dinheiro
        Me.lblTroco.Visible = True
        Me.txtTroco.Visible = True
        Me.lblPgto.Visible = True
        Me.txtPagamento.Visible = True
        Me.txtPagamento.Focus()

    End Sub

    Private Sub rbCartao_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbCartao.CheckedChanged
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais
        mFPgto = clnFuncoesGerais.FPGTO.Cartao
        Me.lblTroco.Visible = False
        Me.txtTroco.Visible = False
        Me.lblPgto.Visible = False
        Me.txtPagamento.Visible = False
    End Sub

    Private Sub tbDetPDV_GotFocus(sender As Object, e As System.EventArgs) Handles tbDetPDV.GotFocus
        Me.txtEAN.Focus()
    End Sub

    Private Sub txtQtd_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtd.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQtd_Leave(sender As Object, e As System.EventArgs) Handles txtQtd.Leave
        Me.txtEAN.Focus()
    End Sub

    Private Sub txtQtd_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtQtd.TextChanged
        Erro.SetError(Me.txtQtd, "")
        Me.lblCmdAddItem.Enabled = True
    End Sub

    Private Sub txtQtd_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtQtd.Validating
        If Me.btnCancelar.Focused Or frmMenu.pnMenuIN.Visible Then
            e.Cancel = False
            Exit Sub
        ElseIf Me.txtQtd.Text = Nothing Then
            e.Cancel = True
            Me.txtQtd.Select(0, Me.txtQtd.Text.Length)
            Erro.SetError(Me.txtQtd, "Campo Obrigatório")
            Me.lblCmdAddItem.Enabled = False

        ElseIf Me.txtQtd.Text <= 0 Then
            e.Cancel = True
            Me.txtQtd.Select(0, Me.txtQtd.Text.Length)
            Erro.SetError(Me.txtQtd, "Insira um valor maior que Zero")
            Me.lblCmdAddItem.Enabled = False
        ElseIf CInt(Me.lblEstVirtual.Text) - CInt(Me.txtQtd.Text) < 0 Then
            e.Cancel = True
            Me.txtQtd.Select(0, Me.txtQtd.Text.Length)
            Erro.SetError(Me.txtQtd, "Não há Estoque suficiente")
            Me.lblCmdAddItem.Enabled = False

        End If
    End Sub

    Private Sub txtCodFunc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodFunc.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub



    Private Sub txtCodFunc_Leave(sender As Object, e As System.EventArgs) Handles txtCodFunc.Leave
        BuscarFuncionarioCod()
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click

        For Each LC As Control In Me.gbCabeca.Controls
            If TypeOf LC Is TextBox Then
                LC.CausesValidation = True
            End If
        Next
        For Each LC As Control In Me.GroupBox2.Controls
            If TypeOf LC Is TextBox Then
                LC.CausesValidation = True
            End If
        Next

        For Each LC As Control In Me.tbBalcao.Controls
            If TypeOf LC Is TextBox Then
                LC.CausesValidation = True
            End If
        Next

        pnInfo.Enabled = True
        gbCabeca.Enabled = True
        Me.txtCodFunc.Focus()
        Me.btnNovo.Enabled = False
        Me.btnCancelar.Enabled = True
        Me.tbDetPDV.Enabled = True

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If mTpVenda = clnFuncoesGerais.TPVENDA.Balcao Then

            If Me.txtCod.Text <> "" Then
                Dim objClsPDV As New clnPDV
                objClsPDV.Excluir(CInt(Me.txtCod.Text))

                Dim objClsDetPDVMovEst As New clnMovEst
                objClsDetPDVMovEst.Excluir(CInt(Me.txtCod.Text))
            End If
            Limpar()

        ElseIf mTpVenda = clnFuncoesGerais.TPVENDA.Telefone Then
            If Me.txtCod.Text <> "" Then
                Dim objClsPDV As New clnPDV
                objClsPDV.Excluir(CInt(Me.txtCod.Text))
                Dim objClsDetPDVMovEst As New clnMovEst
                objClsDetPDVMovEst.Excluir(CInt(Me.txtCod.Text))
            End If
            Limpar()
        End If
    End Sub

    Private Sub lblCPF_Click(sender As System.Object, e As System.EventArgs) Handles lblCPF.Click
        With Me.txtCPF
            .Enabled = True
            .Focus()
        End With
    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        Dim objClsMovEst As New clnMovEst
        If mTpVenda = clnFuncoesGerais.TPVENDA.Balcao Then
            Dim objClsPDV As New clnPDV
            Dim ObjClnFuncoesGerais As New clnFuncoesGerais

            If rbCartao.Checked Then
                mFPgto = clnFuncoesGerais.FPGTO.Cartao
            ElseIf rbDinheiro.Checked Then
                mFPgto = clnFuncoesGerais.FPGTO.Dinheiro
            End If

            With objClsPDV
                .Codigo = CInt(Me.txtCod.Text)
                .CdSitPDV = clnFuncoesGerais.SituacaoPDV.Fechado
                .CdFormaPgto = mFPgto
                .AlterarSPDV()
            End With

            Dim objClsDetPDV As New clnDetPDV
            For Each item As ListViewItem In lsvReduzida.Items
                With objClsDetPDV
                    .CdPDV = CInt(txtCod.Text)
                    .CdProduto = item.SubItems(6).Text
                    .QTDE = item.SubItems(2).Text
                    .SubTotal = Replace(CDbl(FormatNumber(item.SubItems(4).Text)), ",", ".")
                    .Gravar()
                End With
            Next

            With objClsMovEst
                .CdPDV = CInt(Me.txtCod.Text)
                .CdTPMe = clnFuncoesGerais.TPME.Saida
                .DtMod = DateTime.Now
                .AlterarTPME()
            End With
            MessageBox.Show("Registro Número " & txtCod.Text & ", Concluido com sucesso", Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information)
            Limpar()


        ElseIf mTpVenda = clnFuncoesGerais.TPVENDA.Telefone Then

            Dim objClsPDV As New clnPDV
            With objClsPDV
                .Codigo = CInt(Me.txtCod.Text)
                .CdSitPDV = clnFuncoesGerais.SituacaoPDV.Fechado
                .AlterarSPDV()
            End With

            MessageBox.Show("Registro Número " & txtCod.Text & ", concluido com sucesso", Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information)
            Limpar()

        End If
    End Sub

    Private Sub lblCmbEmitirNF_Click(sender As System.Object, e As System.EventArgs) Handles btnNF.Click

        For Each LC As Control In Me.tbEntrega.Controls
            If TypeOf LC Is TextBox Then
                If LC.Text = "" Then
                    MsgBox("Complete os Dados da Entrega")
                    Exit Sub
                End If


            End If
        Next

        For Each LC As Control In Me.tbEntrega.Controls
            If TypeOf LC Is ComboBox Then
                If LC.Text = "" Then
                    MsgBox("Complete os Dados da Entrega")
                    Exit Sub
                End If
            End If
        Next

        For Each LC As Control In Me.tbPGTO.Controls
            If LC.Text = "" Then
                MsgBox("Complete os Dados do Pagamento")
                Exit Sub
            End If
        Next


        Dim objClsMovEst As New clnMovEst
        Dim objClsPDV As New clnPDV
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais

        If rbCartao.Checked Then
            mFPgto = clnFuncoesGerais.FPGTO.Cartao
        ElseIf rbDinheiro.Checked Then
            mFPgto = clnFuncoesGerais.FPGTO.Dinheiro
        End If

        With objClsPDV
            .Codigo = CInt(Me.txtCod.Text)
            .DtEnvio = txtDtEnvio.Text
            .CdTrans = cboTransporte.SelectedValue
            .Destinatario = txtDestinatario.Text.ToString.Trim.ToUpper
            .NoCEP = txtCep.Text.ToString.Trim
            .NoLog = txtNo.Text.ToString.Trim
            .Complemento = txtComplemento.Text.ToString.Trim
            .TxEnvio = Replace(CDbl(FormatNumber(Me.txtTxEnvio.Text)), ",", ".")
            .Obs = RichTextBox1.Text
            .CdSitPDV = clnFuncoesGerais.SituacaoPDV.Faturado
            .CdFormaPgto = mFPgto
            .AlterarSPDV()
        End With

        Dim objClsDetPDV As New clnDetPDV
        For Each item As ListViewItem In lsvReduzida.Items
            With objClsDetPDV
                .CdPDV = CInt(txtCod.Text)
                .CdProduto = item.SubItems(6).Text
                .QTDE = item.SubItems(2).Text
                .SubTotal = Replace(CDbl(FormatNumber(item.SubItems(4).Text)), ",", ".")
                .Gravar()
            End With
        Next

        With objClsMovEst
            .CdPDV = CInt(Me.txtCod.Text)
            .CdTPMe = clnFuncoesGerais.TPME.Reservado
            .DtMod = DateTime.Now
            .AlterarTPME()
        End With
        MessageBox.Show("Registro Número " & txtCod.Text & ", faturado com sucesso", Me.Text, MessageBoxButtons.OK,
        MessageBoxIcon.Information)

        Me.btnEnviar.Enabled = True
        Me.btnNF.Enabled = False


    End Sub

    Private Sub lblCmbEnviarPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviar.Click
        Dim objClsMovEst As New clnMovEst
        Dim objClsPDV As New clnPDV
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais

        With objClsPDV
            .Codigo = CInt(Me.txtCod.Text)
            .CdSitPDV = clnFuncoesGerais.SituacaoPDV.Enviado
            .AlterarSPDV()
        End With

        With objClsMovEst
            .CdPDV = CInt(Me.txtCod.Text)
            .CdTPMe = clnFuncoesGerais.TPME.Saida
            .DtMod = DateTime.Now
            .AlterarTPME()
        End With
        MessageBox.Show("Registro Número " & txtCod.Text & ", enviado com sucesso", Me.Text, MessageBoxButtons.OK,
        MessageBoxIcon.Information)
        btnSalvar.Enabled = True
        Me.btnEnviar.Enabled = False
    End Sub

    Private Sub lsvReduzida_DoubleClick(sender As Object, e As System.EventArgs) Handles lsvReduzida.DoubleClick

        Dim TextReturned As String = ""
        Dim a As New InputBox
        If a.ShowDialog("Alterar Pedido", "Quantidade", "1", TextReturned, False) = Windows.Forms.DialogResult.Cancel Then
            Beep()
            MessageBox.Show("OPERAÇÃO CANCELADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For Each lvItem As ListViewItem In lsvReduzida.SelectedItems

                Dim objClsMovEst As New clnMovEst
                Dim qtde As Integer
                Dim Preco As Double
                Dim CdProd As Integer

                For Each objLVI As ListViewItem In lsvReduzida.Items
                    If objLVI.Text.Equals(Itens(0).ToString()) Then
                        qtde = Convert.ToDouble(objLVI.SubItems(2).Text) - Convert.ToDouble(FormatNumber(a.Txt_TextEntry.Text))
                        objLVI.SubItems(2).Text = qtde
                        Preco = FormatCurrency((Convert.ToDouble(FormatNumber(objLVI.SubItems(4).Text)) - Convert.ToDouble(FormatNumber(Itens(3))).ToString() * FormatNumber(a.Txt_TextEntry.Text)))
                        objLVI.SubItems(4).Text = FormatCurrency(Preco)
                        CdProd = objLVI.SubItems(6).Text()
                    End If

                    If qtde <= 0 Then
                        lvItem.Remove()
                    End If

                    With objClsMovEst
                        .CdPDV = CInt(Me.txtCod.Text)
                        .CdProduto = CdProd
                        .QTDE = qtde
                        .AlterarMOVDETPDV()
                    End With

                Next

                SomarTotalLV()
            Next
        End If


    End Sub

    Private Sub txtDtEnvio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDtEnvio.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Len(Me.txtDtEnvio.Text) > 0 Then
                    vf = True
                    Me.txtDtEnvio.Text = Mid(Me.txtDtEnvio.Text, 1, Val(Len(Me.txtDtEnvio.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtDtEnvio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDtEnvio.TextChanged
        If vf = False Then
            If Len(Me.txtDtEnvio.Text) = 2 Then
                Me.txtDtEnvio.Text = Me.txtDtEnvio.Text & "/"
                Me.txtDtEnvio.SelectionStart = Len(Me.txtDtEnvio.Text) + 1
            ElseIf Len(Me.txtDtEnvio.Text) = 5 Then
                Me.txtDtEnvio.Text = Me.txtDtEnvio.Text & "/"
                Me.txtDtEnvio.SelectionStart = Len(Me.txtDtEnvio.Text) + 1
            End If
        End If
    End Sub

    Private Sub txtDtEnvio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDtEnvio.Validating
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False

        ElseIf Me.txtDtEnvio.Text = Nothing Then
            e.Cancel = True
            Me.txtDtEnvio.Select(0, Me.txtDtEnvio.Text.Length)
            Erro.SetError(Me.txtDtEnvio, "Campo obrigatório")

        ElseIf IsDate(Me.txtDtEnvio.Text) = False Then
            e.Cancel = True
            Me.txtDtEnvio.Select(0, Me.txtDtEnvio.Text.Length)
            Erro.SetError(Me.txtDtEnvio, "Data Inválida")

        ElseIf Not (Me.txtDtEnvio.Text Like "##/##/####") Then
            e.Cancel = True
            Me.txtDtEnvio.Select(0, Me.txtDtEnvio.Text.Length)
            Erro.SetError(Me.txtDtEnvio, "Formato Inválido")


        ElseIf txtDtEnvio.Text < DateTime.Now Then
            e.Cancel = True
            Me.txtDtEnvio.Select(0, Me.txtDtEnvio.Text.Length)
            Erro.SetError(Me.txtDtEnvio, "Data Incorreta")

        End If


    End Sub

    Private Sub txtDtEnvio_Validated(sender As Object, e As System.EventArgs) Handles txtDtEnvio.Validated
        Erro.SetError(Me.txtDtEnvio, "")
    End Sub

    Private Sub txtCep_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCep.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Me.txtCep.Text.Length > 0 Then
                    vf = True
                    Me.txtCep.Text = Mid(Me.txtCep.Text, 1, Val(Len(Me.txtCep.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtCep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCep.TextChanged
        If vf = False Then
            If txtCep.Text.Length = 5 Then
                txtCep.Text = txtCep.Text & "-"
                txtCep.SelectionStart = txtCep.Text.Length + 1
            End If
        End If
    End Sub

    Private Sub txtCep_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCep.LostFocus
        BuscaCep()
        Me.txtNo.Focus()
    End Sub

    Private Sub txtCep_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCep.Validating
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False
        ElseIf Me.txtCep.Text = Nothing Then
            e.Cancel = True
            Me.txtCep.Select(0, Me.txtCep.Text.Length)
            Erro.SetError(Me.txtCep, "Campo obrigatório")
        ElseIf Not (Me.txtCep.Text Like "#####-###") Then
            e.Cancel = True
            Me.txtCep.Select(0, Me.txtCep.Text.Length)
            Erro.SetError(Me.txtCep, "Cep Inválido")
        End If
    End Sub

    Private Sub txtCep_Validated(sender As Object, e As System.EventArgs) Handles txtCep.Validated
        Erro.SetError(txtCep, "")
    End Sub

    Private Sub btnNovoEnd_Click(sender As System.Object, e As System.EventArgs) Handles btnNovoEnd.Click
        For Each LC As Control In Me.tbEntrega.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                Erro.SetError(LC, "")
            End If
            With Me.cboTransporte
                .Text = Nothing
                .Focus()
            End With

        Next
    End Sub



    Private Sub txtCPF_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPF.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtTxEnvio_Leave(sender As Object, e As System.EventArgs) Handles txtTxEnvio.Leave
        Me.txtTotalPgr.Text = CDbl(teste + Convert.ToDouble(FormatNumber(txtTxEnvio.Text))).ToString("C")
    End Sub

    Private Sub txtPagamento_Leave(sender As Object, e As System.EventArgs) Handles txtPagamento.Leave
        Me.txtTroco.Text = FormatCurrency(Convert.ToDouble(FormatNumber(txtPagamento.Text)) - Convert.ToDouble(FormatNumber(txtTotalPgr.Text)))
    End Sub



    Private Sub txtCodFunc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodFunc.TextChanged

    End Sub

    Private Sub lsvReduzida_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lsvReduzida.SelectedIndexChanged

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtTotal_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub
End Class