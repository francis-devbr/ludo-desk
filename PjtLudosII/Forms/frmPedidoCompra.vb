Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic

Public Class frmPedidoCompra
    Private ObjSistema As New cldSistema
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        e.Cancel = False
    End Sub
    Dim mModoForm As clnFuncoesGerais.ModoForm
    Private codigo As Integer
    Private idFornecedor As Integer
    Private CodProduto As Integer
    Dim Erro As New ErrorProvider
    Dim Ativo As Boolean
    Dim Entregue As Boolean
    Dim TotalPedido As String
    Dim nitem As String
    Dim nomeitem As String
    Dim estitem As Integer
    Dim estmax As Integer
    Dim estalvo As Integer
    Private str As String
    Dim categoria As String
    Dim CodigoENTNF As Integer


    Public Property ModoForm() As clnFuncoesGerais.ModoForm
        Get
            Return mModoForm
        End Get
        Set(ByVal Value As clnFuncoesGerais.ModoForm)
            mModoForm = Value
        End Set
    End Property

    Private Sub PDC()
        Entregue = False
        lblDtReceb.Visible = False
        lblNºNF.Visible = False
        lblVlNF.Visible = False
        lblEmissao.Visible = False
        txtDtRece.Visible = False
        txtNºNF.Visible = False
        txtVlNF.Visible = False
        txtDtEmissaoo.Visible = False
        txtCod.Enabled = False
        Me.txtPrecoVenda.Visible = True
        Me.lblPVenda.Visible = True
        With lsvReduzida
            .Size = New Size(696, 317)
            .Location = New Point(9, 186)
        End With
        gbCabeca.Size = New Size(696, 76)
        GroupBox2.Location = New Point(9, 101)

        With frmMenu.lblInfoTela
            .Text = "Pedido de Compra"
            .Visible = True
        End With
        lsvReduzida.Visible = True
        DGVPedido.Visible = False
        btnPPDC.Visible = True
        lblPOnline.Visible = True
    End Sub

    Private Sub NF()

        lblDtReceb.Visible = True
        lblNºNF.Visible = True
        lblVlNF.Visible = True
        lblEmissao.Visible = True
        txtDtRece.Visible = True
        txtNºNF.Visible = True
        txtVlNF.Visible = True
        txtDtEmissaoo.Visible = True
        gbCabeca.Enabled = False
        gbCabeca.Size = New Size(696, 134)

        With lsvReduzida
            .Size = New Size(696, 270)
            .Location = New Point(9, 231)
        End With
        With GroupBox2
            .Visible = False
            .Location = New Point(9, 150)
        End With

        With frmMenu.lblInfoTela
            .Text = " Entrada de Nota Fiscal"
            .Visible = True
        End With

        lsvReduzida.Visible = False
        DGVPedido.Visible = True

        btnPPDC.Visible = False
        lblPOnline.Visible = False

    End Sub

    Private Sub frmPedidoCompra_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If (e.KeyChar = ChrW(13)) Then
            SendKeys.Send("{TAB}")
            e.Handled = True 'Para remover aquele som...
        End If
    End Sub

    Private Sub frmPedidoCompra_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If mModoForm = clnFuncoesGerais.ModoForm.ModoPDC Then
            PDC()
        ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoNF Then
            NF()
        End If
    End Sub
    Private Sub InicializarListView()

        With lvPedidos
            .MultiSelect = False
            .Sorting = SortOrder.Ascending
            .GridLines = True
            .FullRowSelect = True
            .AllowColumnReorder = False
            .LabelEdit = False
            .View = View.Details
        End With


        With lvPedidos
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("NºPedido", 100, HorizontalAlignment.Center)
            .Columns.Add("Fornecedor", 350, HorizontalAlignment.Center)
            .Columns.Add("Data do Pedido", 120, HorizontalAlignment.Center)
            .Columns.Add("Situacao", 80, HorizontalAlignment.Left)
            .Font = New System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold)
        End With




    End Sub
    Private Sub CarregarListView()
        Dim clsObjclnFuncoesGerais As New clnFuncoesGerais
        Dim objClsPedCompra As New clnPedCompra

        Dim ds As Data.DataSet = objClsPedCompra.ListaPDC((Regex.Replace(Me.txtPNome.Text, "[\\\?\*-./]", "")), txtNPedido.Text)
        Dim dtable As DataTable = ds.Tables(0)
        lvPedidos.Items.Clear()
        For i As Integer = 0 To dtable.Rows.Count - 1
            Dim drow As DataRow = dtable.Rows(i)
            If drow.RowState <> DataRowState.Deleted Then
                Dim lvi As New ListViewItem(drow("cdPedCompra").ToString())
                lvi.SubItems.Add(drow("RazaoSocial").ToString())
                lvi.SubItems.Add(drow("dtPedido").ToString())
                lvi.SubItems.Add(drow("Situacao").ToString())
                lvi.Font = New System.Drawing.Font("calibri", 10, System.Drawing.FontStyle.Regular)
                lvPedidos.Items.Add(lvi)
            End If
        Next
        ObjSistema.pZebra(lvPedidos, Color.SlateGray, Color.PaleGreen)
    End Sub



    Private Sub InicializarLV()
        With lsvReduzida
            .Columns.Clear()
            .Columns.Add("Nº Item", 70, HorizontalAlignment.Center)
            .Columns.Add("Nome do Produto", 280)
            .Columns.Add("Quantidade", 80, HorizontalAlignment.Center)
            .Columns.Add("Preço Unitário", 100, HorizontalAlignment.Center)
            .Columns.Add("Sub-Total", 130, HorizontalAlignment.Center)
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
        Dim Itens(7) As String
        Itens(0) = nitem
        Itens(1) = nomeitem
        Itens(2) = txtQtd.Text
        Itens(3) = txtCusto.Text
        Itens(4) = txtQtd.Text * txtCusto.Text
        Itens(5) = categoria
        Itens(6) = CodProduto
        Itens(7) = txtPrecoVenda.Text


        Dim ItemEncontrado As Boolean = False

        For Each objLVI As ListViewItem In lsvReduzida.Items
            If objLVI.Text.Equals(Itens(0).ToString()) Then
                MsgBox("Item já faz parte da lista")
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
            item.SubItems.Add(Itens(7).ToString)
        End If
        Dim objClsFGeral As New clnFuncoesGerais
        ObjSistema.AgruparListView(lsvReduzida, 5)

        For Each item As ListViewItem In lsvReduzida.Items
            btnSalvar.Enabled = True
        Next


    End Sub

    Private Sub SomarTotalLV()
        Dim TempSoma As Double = 0
        For Each objLVI As ListViewItem In lsvReduzida.Items
            TempSoma += CDbl(objLVI.SubItems(4).Text)
        Next
        Me.txtTotal.Text = CDbl(TempSoma).ToString("C")
    End Sub

    Private Sub cmbExcluirItem_Click(sender As System.Object, e As System.EventArgs) Handles lblCmbExcluirItem.Click

        For Each lvItem As ListViewItem In lsvReduzida.SelectedItems
            Dim msg As Integer
            Try
                msg = CInt(CStr(MessageBox.Show("Deseja excluir o registro? " & lvItem.SubItems(1).Text, Me.Text,
                MessageBoxButtons.YesNo)))
                If CDbl(msg) = Windows.Forms.DialogResult.Yes Then
                    lvItem.Remove()
                Else
                    MessageBox.Show("OPERAÇÃO CANCELADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro, talvez não foi definido nenhum valor para exclusão")
            End Try
        Next


    End Sub

    Private Sub lblCmdAddItem_Click(sender As System.Object, e As System.EventArgs) Handles lblCmdAddItem.Click

        CarregarLV()
        For Each LC As Control In Me.GroupBox2.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = Nothing
            End If
        Next
        With txtCusto
            .Text = 0
            .Enabled = False
        End With
        With txtPrecoVenda
            .Text = 0
            .Enabled = False
        End With
        Me.txtQtd.Enabled = False
        With Me.txtEAN
            .Focus()
        End With
        SomarTotalLV()


    End Sub



    Private Sub ConcluirPedido()
        Dim objClsPedCompra As New clnPedCompra
        Dim objClsDetPedCompra As New clnDetPedCompra
        Dim objClsProduto As New clnProduto
        codigo = CInt(Me.txtCod.Text.Trim)
        If mModoForm = clnFuncoesGerais.ModoForm.ModoPDC Then

            With objClsPedCompra
                .CdPedCompra = codigo
                .Ativo = True
                .CdSit = clnFuncoesGerais.SituacaoPDV.Enviado
                .ConcluirPDC()
            End With

            For Each item As ListViewItem In lsvReduzida.Items
                With objClsProduto
                    .ID = item.SubItems(6).Text
                    '.AlterarPreco()
                End With

                With objClsDetPedCompra
                    .CdPedCompra = codigo
                    .CdProduto = item.SubItems(6).Text
                    .QTDE = item.SubItems(2).Text
                    .CustoUnit = Replace(CDbl(FormatNumber(item.SubItems(3).Text.ToString)), ",", ".")
                    .Entregue = Entregue
                    .Ativo = True
                    .GravarDETPDC()
                End With
            Next

            MessageBox.Show("Pedido Número " & codigo & ", criado com sucesso", Me.Text, MessageBoxButtons.OK,
               MessageBoxIcon.Information)

        ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoNF Then
            With objClsPedCompra
                .CdPedCompra = codigo
                .Ativo = False
                .CdSit = clnFuncoesGerais.SituacaoPDV.Fechado
                .ConcluirPDC()
            End With

            With objClsPedCompra
                .CdPedCompra = CInt(txtCod.Text)
                .CdForne = idFornecedor
                .DtRecebimento = txtDtRece.Text
                .NoNF = txtNºNF.Text
                .VlNF = Replace(CDbl(FormatNumber(Me.txtVlNF.Text)), ",", ".")
                .DtEmissao = txtDtEmissaoo.Text
                .CdFunc = CInt(idUsuario)
                .GravarNF()
            End With

            Dim drDados As System.Data.SqlClient.SqlDataReader
            drDados = objClsPedCompra.CarregaCodNF(txtNºNF.Text, idFornecedor, txtDtRece.Text)
            If drDados.Read Then
                CodigoENTNF = CStr(drDados("cdEntNF"))
            End If

            Dim r As Integer
            While r < DGVPedido.Rows.Count - 1
                Entregue = DGVPedido.Rows.Item(r).Cells(6).Value.ToString()
                If Entregue = False Then
                    With objClsDetPedCompra
                        .CdPedCompra = codigo
                        .CdProduto = CInt(DGVPedido.Rows.Item(r).Cells(0).Value)
                        .Entregue = Entregue
                        .Ativo = True
                        .N_ENTREGUE_NF_Alterar()
                    End With
                Else
                    With objClsDetPedCompra
                        .CdPedCompra = codigo
                        .Entregue = Entregue
                        .CdProduto = CInt(DGVPedido.Rows.Item(r).Cells(0).Value)
                        .QTDE = DGVPedido.Rows.Item(r).Cells(4).Value.ToString()
                        .CustoUnit = Replace(CDbl(FormatNumber(DGVPedido.Rows.Item(r).Cells(5).Value.ToString)), ",", ".")
                        .Ativo = False
                        .EntradaNF_Alterar()
                    End With

                    With objClsDetPedCompra
                        .CdEntNF = CodigoENTNF
                        .CdProduto = CInt(DGVPedido.Rows.Item(r).Cells(0).Value)
                        .QTDE = DGVPedido.Rows.Item(r).Cells(4).Value.ToString()
                        .CustoUnit = Replace(CDbl(FormatNumber(DGVPedido.Rows.Item(r).Cells(5).Value.ToString)), ",", ".")
                        .GravarDETENNF()
                    End With

                    Dim objClsMovEst As New clnMovEst
                    With objClsMovEst
                        .CdProduto = DGVPedido.Rows.Item(r).Cells(0).Value.ToString()
                        .QTDE = DGVPedido.Rows.Item(r).Cells(4).Value.ToString()
                        .CdTPMe = clnFuncoesGerais.TPME.Entrada
                        .CdDetMe = clnFuncoesGerais.DETME.NF
                        .DtME = DateTime.Now
                        .CdEntNF = codigo
                        .Ativo = True
                        .Gravar()
                    End With
                End If
                r = r + 1
            End While



            MessageBox.Show("Registro Número Entrada NF  " & codigo & ", alterado com sucesso", Me.Text, MessageBoxButtons.OK,
             MessageBoxIcon.Information)



        End If


    End Sub

    Private Sub BuscarPedido()

        Dim objClsPedCompra As New clnPedCompra

        With DGVPedido.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Tomato
            .ForeColor = Color.DimGray
            .Font = New Font(DGVPedido.Font, FontStyle.Regular)
        End With

        With DGVPedido
            .DataSource = objClsPedCompra.CarregaPedido(idFornecedor, txtCod.Text).Tables(0)
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = Color.Black
            .ForeColor = Color.DimGray
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        Dim valor As Double
        For Each col As DataGridViewRow In DGVPedido.Rows

            valor = valor + col.Cells(5).Value

        Next
        Me.btnSalvar.Enabled = True
        Me.txtTotal.Text = valor

    End Sub

    Private Sub txtQtd_Validated(sender As Object, e As System.EventArgs) Handles txtQtd.Validated
        Erro.SetError(Me.txtQtd, "")
        Me.txtCusto.Enabled = True
        Me.txtCusto.Focus()
    End Sub

    Private Sub txtQtd_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtQtd.Validating
        If mModoForm = clnFuncoesGerais.ModoForm.ModoPDC Then
            If Me.btnCancelar.Focused Or frmMenu.pnMenuIN.Visible Then
                e.Cancel = False
                Exit Sub
            ElseIf Me.txtQtd.Text = Nothing Then
                e.Cancel = True
                Me.txtQtd.Select(0, Me.txtQtd.Text.Length)
                Erro.SetError(Me.txtQtd, "Campo Obrigatório")
            ElseIf Me.txtQtd.Text <= 0 Then
                e.Cancel = True
                Me.txtQtd.Select(0, Me.txtQtd.Text.Length)
                Erro.SetError(Me.txtQtd, "Insira um valor maior que Zero")
            ElseIf CInt(Me.txtQtd.Text) + CInt(estitem) > CInt(estmax) Then
                e.Cancel = True
                Me.txtQtd.Select(0, Me.txtQtd.Text.Length)
                Erro.SetError(Me.txtQtd, "Você execedeu o o Estoque Máximo permitido")
            End If
        End If
    End Sub

    Private Sub txtNCNPJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNCNPJ.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Me.txtNCNPJ.Text.Length > 0 Then
                    vf = True
                    Me.txtNCNPJ.Text = Mid(Me.txtNCNPJ.Text, 1, Val(Len(Me.txtNCNPJ.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtNCNPJ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNCNPJ.TextChanged
        If vf = False Then
            If Me.txtNCNPJ.Text.Length = 2 Then
                txtNCNPJ.Text = txtNCNPJ.Text & "."
                txtNCNPJ.SelectionStart = txtNCNPJ.Text.Length + 1

            ElseIf Me.txtNCNPJ.Text.Length = 6 Then
                txtNCNPJ.Text = txtNCNPJ.Text & "."
                txtNCNPJ.SelectionStart = txtNCNPJ.Text.Length + 1

            ElseIf Me.txtNCNPJ.Text.Length = 10 Then
                txtNCNPJ.Text = txtNCNPJ.Text & "/"
                txtNCNPJ.SelectionStart = Me.txtNCNPJ.Text.Length + 1

            ElseIf Me.txtNCNPJ.Text.Length = 15 Then
                txtNCNPJ.Text = txtNCNPJ.Text & "-"
                txtNCNPJ.SelectionStart = Me.txtNCNPJ.Text.Length + 1

            End If
        End If
    End Sub

    Private Sub txtNCNPJ_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNCNPJ.Validating


        Dim objClsFuncoesGerais As New clnFuncoesGerais

        If Me.btnCancelar.Focused Or frmMenu.pnMenuIN.Visible Then
            e.Cancel = False
            Exit Sub
        ElseIf Me.txtNCNPJ.Text = Nothing Then
            e.Cancel = True
            Me.txtNCNPJ.Select(0, Me.txtNCNPJ.Text.Length)
            Erro.SetError(Me.txtNCNPJ, "Campo obrigatório")

        ElseIf Not (Me.txtNCNPJ.Text Like "##.###.###/####-##") Then
            e.Cancel = True
            Me.txtNCNPJ.Select(0, Me.txtNCNPJ.Text.Length)
            Erro.SetError(Me.txtNCNPJ, "CNPJ Inválido")
            Me.lblNomeForn.Visible = False


        ElseIf Not objClsFuncoesGerais.ValidaCNPJ(txtNCNPJ.Text) Then
            e.Cancel = True
            Me.txtNCNPJ.Select(0, Me.txtNCNPJ.Text.Length)
            Erro.SetError(Me.txtNCNPJ, "Nº CNPJ Inválido ")

        Else
            If mModoForm = clnFuncoesGerais.ModoForm.ModoPDC Then
                Dim drDados As System.Data.SqlClient.SqlDataReader
                drDados = objClsFuncoesGerais.BuscaFornecedor(Regex.Replace(Me.txtNCNPJ.Text.ToString.Trim, "[\\\?\*-./]", ""))
                If drDados.Read Then
                    Me.lblNomeForn.Text = CStr(drDados("RazaoSocial"))
                    Me.idFornecedor = CStr(drDados("cdForne"))
                    Me.lblNomeForn.Visible = True
                    Me.txtNCNPJ.Enabled = False
                    Gravar()
                    GroupBox2.Enabled = True
                    txtEAN.Focus()
                Else
                    e.Cancel = True
                    Me.txtNCNPJ.Select(0, Me.txtNCNPJ.Text.Length)
                    Erro.SetError(Me.txtNCNPJ, "Fornecedor não cadastrado")
                    Me.lblNomeForn.Visible = False
                End If
            ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoNF Then

                Dim drDados As System.Data.SqlClient.SqlDataReader
                drDados = objClsFuncoesGerais.BuscaFornecedor(Regex.Replace(Me.txtNCNPJ.Text.ToString.Trim, "[\\\?\*-./]", ""))
                If drDados.Read Then
                    Me.lblNomeForn.Text = CStr(drDados("RazaoSocial"))
                    Me.idFornecedor = CStr(drDados("cdForne"))
                    Me.lblNomeForn.Visible = True
                    Me.txtNCNPJ.Enabled = False
                    GroupBox2.Enabled = True
                Else
                    e.Cancel = True
                    Me.txtNCNPJ.Select(0, Me.txtNCNPJ.Text.Length)
                    Erro.SetError(Me.txtNCNPJ, "Fornecedor não cadastrado")
                    Me.lblNomeForn.Visible = False
                End If

            End If

        End If
    End Sub

    Private Sub txtNCNPJ_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNCNPJ.Validated
        If mModoForm = clnFuncoesGerais.ModoForm.ModoPDC Then
            Erro.SetError(Me.txtNCNPJ, "")

        ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoNF Then
            Erro.SetError(Me.txtNCNPJ, "")
            BuscarPedido()
        End If

    End Sub

    Private Sub Limpar()
        For Each LC As Control In Me.pnInfo.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
            End If
        Next

        For Each LC As Control In Me.gbCabeca.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
            End If
        Next

        For Each LC As Control In Me.GroupBox2.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
            End If
        Next
        Me.txtPrecoVenda.Text = 0
        Me.txtCusto.Text = 0
        Me.txtVlNF.Text = 0
        Me.pnInfo.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnSalvar.Enabled = False
        Me.btnNovo.Enabled = True
        Me.btnDesativar.Enabled = False
        Me.btnEditar.Enabled = False
        Me.lblNomeForn.Visible = False
        Me.GroupBox2.Enabled = False
        lsvReduzida.Items.Clear()
        DGVPedido.Columns.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        If mModoForm = clnFuncoesGerais.ModoForm.ModoPDC Then
            If Me.txtCod.Text <> "" Then
                Dim objClsPedCompra As New clnPedCompra
                objClsPedCompra.Excluir(CInt(Me.txtCod.Text))
            End If
            Limpar()
        ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoNF Then
            Limpar()
            DGVPedido.Columns.Clear()
        End If


    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click

        For Each LC As Control In Me.pnInfo.Controls
            If TypeOf LC Is TextBox Then
                LC.CausesValidation = True
            End If
        Next

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

        If mModoForm = clnFuncoesGerais.ModoForm.ModoPDC Then
            Me.pnInfo.Enabled = True
            Me.txtNCNPJ.Enabled = True
            txtNCNPJ.Focus()
            Me.btnCancelar.Enabled = True
            Me.btnNovo.Enabled = False

        ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoNF Then
            gbCabeca.Enabled = True
            Me.pnInfo.Enabled = True
            Me.txtNCNPJ.Enabled = True
            With Me.txtCod
                .Enabled = True
                .Focus()
            End With
            Me.btnCancelar.Enabled = True
            Me.btnNovo.Enabled = False


        End If
        InicializarLV()
    End Sub

    Private Sub Gravar()
        If mModoForm = clnFuncoesGerais.ModoForm.ModoPDC Then
            Dim objClsPedCompra As New clnPedCompra
            Dim dtPed As Date = DateTime.Now
            With objClsPedCompra
                .CdForne = idFornecedor
                .CdComprador = idUsuario
                .DtPedido = dtPed
                .CdSit = clnFuncoesGerais.SituacaoPDV.Novo
                .Ativo = Ativo
                .GravarPDC()
            End With
            Dim drDados As System.Data.SqlClient.SqlDataReader
            drDados = objClsPedCompra.CarregaCodPDC(idUsuario, idFornecedor, dtPed)
            If drDados.Read Then
                txtCod.Text = CStr(drDados("cdPedCompra"))
            End If
        ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoNF And Not btnCancelar.Focused Then



        End If
    End Sub

    Private Sub txtCusto_Leave() Handles txtCusto.Leave
        If mModoForm = clnFuncoesGerais.ModoForm.ModoPDC Then
            If Me.txtCusto.Text <= 0 Then
                Me.txtCusto.Focus()
            Else
                With Me.txtPrecoVenda
                    .Enabled = True
                    .Focus()
                End With
            End If
        End If
    End Sub

    Private Sub txtPrecoVenda_Leave() Handles txtPrecoVenda.Leave
        If mModoForm = clnFuncoesGerais.ModoForm.ModoPDC Then
            If Me.txtPrecoVenda.Text <= 0 Then
                Me.txtPrecoVenda.Focus()
            Else

            End If
        End If

    End Sub

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click
        ConcluirPedido()
        Limpar()

    End Sub

    Private Sub txtEAN_Leave(sender As Object, e As System.EventArgs) Handles txtEAN.Leave
        Dim objClsFGeral As New clnFuncoesGerais
        Dim drDados As System.Data.SqlClient.SqlDataReader
        drDados = objClsFGeral.ListaEANPDC(Me.txtEAN.Text.ToString.Trim, idFornecedor)
        If txtEAN.Text <> "" Then

            If drDados.Read Then
                CodProduto = drDados("cdProduto").ToString
                nitem = drDados("noItem").ToString
                nomeitem = drDados("Nome").ToString
                estitem = drDados("Estoque_Fisico").ToString
                estmax = drDados("noMaxEst").ToString
                categoria = drDados("nmCategoria").ToString
                estalvo = drDados("EstAlvo").ToString
                Dim sugestao As String
                sugestao = estalvo - estitem
                With Me.txtQtd
                    .Text = sugestao
                    .Enabled = True
                    .Focus()
                End With
            Else
                MsgBox("Item não cadastrado ou não está pertence a este fornecedor")
                Me.txtEAN.Focus()
            End If
        End If
    End Sub



    Private Sub btnPesquisar_Click(sender As System.Object, e As System.EventArgs) Handles btnPesquisar.Click
        InicializarListView()
        CarregarListView()
    End Sub

    Private Sub txtPNome_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPNome.KeyDown

        Select Case e.KeyCode
            Case Keys.Back
                If Len(Me.txtPNome.Text) > 0 Then
                    vf = True
                    Me.txtPNome.Text = Mid(Me.txtPNome.Text, 1, Val(Len(Me.txtPNome.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False

    End Sub

    Private Sub txtPNome_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPNome.TextChanged
        If vf = False Then
            If Me.txtPNome.Text.Length = 2 Then
                txtPNome.Text = txtPNome.Text & "."
                txtPNome.SelectionStart = txtPNome.Text.Length + 1

            ElseIf Me.txtPNome.Text.Length = 6 Then
                txtPNome.Text = txtPNome.Text & "."
                txtPNome.SelectionStart = txtPNome.Text.Length + 1

            ElseIf Me.txtPNome.Text.Length = 10 Then
                txtPNome.Text = txtPNome.Text & "/"
                txtPNome.SelectionStart = Me.txtPNome.Text.Length + 1

            ElseIf Me.txtPNome.Text.Length = 15 Then
                txtPNome.Text = txtPNome.Text & "-"
                txtPNome.SelectionStart = Me.txtPNome.Text.Length + 1

            End If
        End If
    End Sub

    Private Sub btnPPDC_Click(sender As System.Object, e As System.EventArgs) Handles btnPPDC.Click
        If Me.pbNext.Name = "pbNext" Then
            ModoPesquisa()
            Me.btnCancelar.Visible = False
            Me.btnEditar.Visible = False
            Me.btnSalvar.Visible = False
            Me.btnNovo.Visible = False
            Me.btnDesativar.Visible = False
            Me.pbNext.Visible = True
            Limpar()
            Exit Sub
        ElseIf Me.pbNext.Name = "pbForward" Then
            ModoCadastro()
            Me.btnCancelar.Visible = True
            Me.btnEditar.Visible = True
            Me.btnSalvar.Visible = True
            Me.btnNovo.Visible = True
            Me.btnDesativar.Visible = True
        End If
    End Sub

    Private Sub ModoPesquisa()

        Me.pnLatEsq.Size = New Size(1014, 635)
        With Me.pbNext
            .Name = "pbForward"
            .BackgroundImage = My.Resources.back
            .Location = New Point(969, 12)
        End With
        With frmMenu.lblInfoTela
            .Text = "Pesquisa de Pedido de Compra"
            .Visible = True
        End With
        pnLatEsq.Visible = True
        InicializarLV()
    End Sub

    Private Sub ModoCadastro()
        mModoForm = clnFuncoesGerais.ModoForm.ModoPDC
        Me.pnLatEsq.Size = New Size(39, 633)
        Me.pbNext.Name = "pbNext"
        Me.pbNext.BackgroundImage = My.Resources._next
        Me.pbNext.Location = New Point(3, 3)
        Me.pnInfo.Visible = True
        With Me.btnEditar
            .Visible = True
            .Enabled = False
        End With
        With Me.btnNovo
            .Visible = True
            .Enabled = True
        End With
        Me.btnSalvar.Visible = True
        Me.btnDesativar.Visible = True
        Me.btnCancelar.Visible = True
        pnLatEsq.Visible = False
        Me.pbNext.Visible = False
        PDC()
        Me.lvPedidos.Items.Clear()
        Me.txtNPedido.Clear()
        Me.txtPNome.Clear()
    End Sub

    Private Sub pbNext_Click(sender As System.Object, e As System.EventArgs) Handles pbNext.Click
        ModoCadastro()
    End Sub

    Private Sub txtDtRece_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDtRece.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Len(Me.txtDtRece.Text) > 0 Then
                    vf = True
                    Me.txtDtRece.Text = Mid(Me.txtDtRece.Text, 1, Val(Len(Me.txtDtRece.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtDtRece_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDtRece.TextChanged
        If vf = False Then
            If Len(Me.txtDtRece.Text) = 2 Then
                Me.txtDtRece.Text = Me.txtDtRece.Text & "/"
                Me.txtDtRece.SelectionStart = Len(Me.txtDtRece.Text) + 1
            ElseIf Len(Me.txtDtRece.Text) = 5 Then
                Me.txtDtRece.Text = Me.txtDtRece.Text & "/"
                Me.txtDtRece.SelectionStart = Len(Me.txtDtRece.Text) + 1
            End If
        End If
    End Sub

    Private Sub txtDtRece_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDtRece.Validating
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False

        ElseIf Me.txtDtRece.Text = Nothing Then
            e.Cancel = True
            Me.txtDtRece.Select(0, Me.txtDtRece.Text.Length)
            Erro.SetError(Me.txtDtRece, "Campo obrigatório")

        ElseIf IsDate(Me.txtDtRece.Text) = False Then
            e.Cancel = True
            Me.txtDtRece.Select(0, Me.txtDtRece.Text.Length)
            Erro.SetError(Me.txtDtRece, "Data Inválida")

        ElseIf Not (Me.txtDtRece.Text Like "##/##/####") Then
            e.Cancel = True
            Me.txtDtRece.Select(0, Me.txtDtRece.Text.Length)
            Erro.SetError(Me.txtDtRece, "Formato Inválido")


        ElseIf txtDtRece.Text > DateTime.Now Then
            e.Cancel = True
            Me.txtDtRece.Select(0, Me.txtDtRece.Text.Length)
            Erro.SetError(Me.txtDtRece, "Data Incorreta")

        End If


    End Sub

    Private Sub txtDtRece_Validated(sender As Object, e As System.EventArgs) Handles txtDtRece.Validated
        Erro.SetError(Me.txtDtRece, "")
    End Sub

    Private Sub txtDtEmissaoo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDtEmissaoo.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Len(Me.txtDtEmissaoo.Text) > 0 Then
                    vf = True
                    Me.txtDtEmissaoo.Text = Mid(Me.txtDtEmissaoo.Text, 1, Val(Len(Me.txtDtEmissaoo.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtDtEmissaoo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDtEmissaoo.TextChanged
        If vf = False Then
            If Len(Me.txtDtEmissaoo.Text) = 2 Then
                Me.txtDtEmissaoo.Text = Me.txtDtEmissaoo.Text & "/"
                Me.txtDtEmissaoo.SelectionStart = Len(Me.txtDtEmissaoo.Text) + 1
            ElseIf Len(Me.txtDtEmissaoo.Text) = 5 Then
                Me.txtDtEmissaoo.Text = Me.txtDtEmissaoo.Text & "/"
                Me.txtDtEmissaoo.SelectionStart = Len(Me.txtDtEmissaoo.Text) + 1
            End If
        End If
    End Sub

    Private Sub txtDtEmissaoo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDtEmissaoo.Validating
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False

        ElseIf Me.txtDtEmissaoo.Text = Nothing Then
            e.Cancel = True
            Me.txtDtEmissaoo.Select(0, Me.txtDtEmissaoo.Text.Length)
            Erro.SetError(Me.txtDtEmissaoo, "Campo obrigatório")

        ElseIf IsDate(Me.txtDtEmissaoo.Text) = False Then
            e.Cancel = True
            Me.txtDtEmissaoo.Select(0, Me.txtDtEmissaoo.Text.Length)
            Erro.SetError(Me.txtDtEmissaoo, "Data Inválida")

        ElseIf Not (Me.txtDtEmissaoo.Text Like "##/##/####") Then
            e.Cancel = True
            Me.txtDtEmissaoo.Select(0, Me.txtDtEmissaoo.Text.Length)
            Erro.SetError(Me.txtDtEmissaoo, "Formato Inválido")

        ElseIf txtDtEmissaoo.Text > DateTime.Now Then
            e.Cancel = True
            Me.txtDtEmissaoo.Select(0, Me.txtDtEmissaoo.Text.Length)
            Erro.SetError(Me.txtDtEmissaoo, "Data Incorreta")

        End If


    End Sub

    Private Sub txtDtEmissaoo_Validated(sender As Object, e As System.EventArgs) Handles txtDtEmissaoo.Validated
        Erro.SetError(Me.txtDtEmissaoo, "")
    End Sub

    Private Sub SoNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDtEmissaoo.KeyPress, txtDtRece.KeyPress, txtVlNF.KeyPress, txtNºNF.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub somadgv()



    End Sub

End Class