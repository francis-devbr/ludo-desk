
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Public Class frmEstoque

    Private codigo As String
    Dim Ativo As Boolean
    Dim Erro As New ErrorProvider
    Dim mModoForm As clnFuncoesGerais.ModoForm
    Dim mTPME As clnFuncoesGerais.TPME
    Dim nitem As String
    Dim nomeitem As String
    Dim estitem As Integer
    Dim custoitem As Double
    Private CodProduto As Integer

    Public Property TPME() As clnFuncoesGerais.IncluirAlterar
        Get
            Return mTPME
        End Get
        Set(ByVal Value As clnFuncoesGerais.IncluirAlterar)
            mTPME = Value
        End Set
    End Property

    Private Sub Limpar()

      

        With Me.lblNm
            .Visible = False
        End With

        Me.pnInfo.Enabled = False
        Me.pbBtnSaida.Visible = True
        Me.lblSaida.Visible = True
        Me.pbBtnEntrada.Visible = True
        Me.lblEntrada.Visible = True
        Me.btnCancelar.Enabled = False
        Me.btnAjustar.Enabled = False
        lsvReduzida.Items.Clear()
        txtEAN.Text = Nothing
        txtQtd.Text = Nothing

    End Sub

    Private Sub frmEstoque_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub frmEstoque_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With frmMenu.lblInfoTela
            .Text = "Ajuste de Estoque"
            .Visible = True
        End With
    End Sub

    Private Sub pbBtnEntrada_Click(sender As System.Object, e As System.EventArgs) Handles pbBtnEntrada.Click
        Dim objClsFGeral As New clnFuncoesGerais
        mTPME = clnFuncoesGerais.TPME.Entrada
        Me.pnInfo.Enabled = True
        Me.txtEAN.Focus()
        Me.pbBtnSaida.Visible = False
        Me.lblSaida.Visible = False
        Me.btnCancelar.Enabled = True
        With frmMenu.lblInfoTela
            .Text = "Ajuste de Estoque - Entrada"
            .Visible = True
        End With
    End Sub

    Private Sub pbBtnSaida_Click(sender As System.Object, e As System.EventArgs) Handles pbBtnSaida.Click
        Dim objClsFGeral As New clnFuncoesGerais
        mTPME = clnFuncoesGerais.TPME.Saida
        Me.pnInfo.Enabled = True
        Me.txtEAN.Focus()
        Me.pbBtnEntrada.Visible = False
        Me.lblEntrada.Visible = False
        Me.btnCancelar.Enabled = True
        With frmMenu.lblInfoTela
            .Text = "Ajuste de Estoque - Saida"
            .Visible = True
        End With
    End Sub

    Private Sub btnAjustar_Click(sender As System.Object, e As System.EventArgs) Handles btnAjustar.Click

        If mTPME = clnFuncoesGerais.TPME.Saida Then

            For Each item As ListViewItem In lsvReduzida.Items
                Dim objClsMovEst As New clnMovEst
                With objClsMovEst
                    .CdProduto = item.SubItems(7).Text
                    .QTDE = item.SubItems(2).Text
                    .CdTPMe = clnFuncoesGerais.TPME.Saida
                    .CdDetMe = clnFuncoesGerais.DETME.AcertoEstoque
                    .DtMod = DateTime.Now
                    .Ativo = True
                    .Gravar()
                End With
            Next

        ElseIf mTPME = clnFuncoesGerais.TPME.Entrada Then

            For Each item As ListViewItem In lsvReduzida.Items
                Dim objClsMovEst As New clnMovEst
                With objClsMovEst
                    .CdProduto = item.SubItems(7).Text
                    .QTDE = item.SubItems(2).Text
                    .CdTPMe = clnFuncoesGerais.TPME.Entrada
                    .CdDetMe = clnFuncoesGerais.DETME.AcertoEstoque
                    .DtMod = DateTime.Now
                    .Ativo = True
                    .Gravar()
                End With
            Next
        End If

        MessageBox.Show("Estoque Ajustado com sucesso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Limpar()

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        With frmMenu.lblInfoTela
            .Text = "Ajuste de Estoque"
            .Visible = True
        End With
        Limpar()
    End Sub

    Private Sub txtEAN_Leave(sender As Object, e As System.EventArgs) Handles txtEAN.Leave
        Dim objClsFGeral As New clnFuncoesGerais
        Dim drDados As System.Data.SqlClient.SqlDataReader
        drDados = objClsFGeral.ListaEAN(Me.txtEAN.Text.ToString)
        If txtEAN.Text <> "" Then


            If drDados.Read Then
                CodProduto = drDados("cdProduto").ToString
                nitem = drDados("noItem").ToString
                nomeitem = drDados("Nome").ToString
                estitem = drDados("Estoque_Fisico").ToString
                With Me.lblNm
                    .Text = nomeitem
                    .Visible = True
                End With

                'custoitem = drDados("CustoUnit").ToString
                With Me.txtQtd
                    .Enabled = True
                    .Focus()
                End With
            Else
                MsgBox("Item não cadastrado")
                Me.txtEAN.Focus()
            End If
        End If
    End Sub

    Private Sub InicializarLV()
        With lsvReduzida
            .Columns.Clear()
            .Columns.Add("Nº Item", 70, HorizontalAlignment.Center)
            .Columns.Add("Nome do Produto", 250)
            .Columns.Add("Ajuste", 80, HorizontalAlignment.Center)
            .Columns.Add("Estoque", 60, HorizontalAlignment.Center)
            .Columns.Add("Est.Ajustado", 80, HorizontalAlignment.Center)
            .Columns.Add("Preço Custo", 80, HorizontalAlignment.Center)
            .Columns.Add("Sub-Total", 80, HorizontalAlignment.Center)
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
        If mTPME = clnFuncoesGerais.TPME.Saida Then

            Itens(0) = nitem
            Itens(1) = nomeitem
            Itens(2) = txtQtd.Text
            Itens(3) = estitem
            Itens(4) = estitem - txtQtd.Text
            Itens(5) = custoitem
            Itens(6) = txtQtd.Text * custoitem
            Itens(7) = CodProduto

        ElseIf mTPME = clnFuncoesGerais.TPME.Entrada Then
            Itens(0) = nitem
            Itens(1) = nomeitem
            Itens(2) = txtQtd.Text
            Itens(3) = estitem
            Itens(4) = estitem + txtQtd.Text
            Itens(5) = custoitem
            Itens(6) = txtQtd.Text * custoitem
            Itens(7) = CodProduto
        End If

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
            item.SubItems.Add(Itens(3).ToString)
            item.SubItems.Add(Itens(4).ToString)
            item.SubItems.Add(String.Format("{0:C}", Convert.ToDouble(Itens(5).ToString)))
            item.SubItems.Add(String.Format("{0:C}", Convert.ToDouble(Itens(6).ToString)))
            lsvReduzida.Items.Add(item)
            item.SubItems.Add(Itens(7).ToString)
        End If

        For Each item As ListViewItem In lsvReduzida.Items
            btnAjustar.Enabled = True
        Next

    End Sub

    Private Sub txtQtd_Leave(sender As Object, e As System.EventArgs) Handles txtQtd.Leave
        InicializarLV()
        CarregarLV()
    End Sub

   
End Class