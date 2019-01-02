Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic

Public Class frmFornecedor
    Private ObjSistema As New cldSistema
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        e.Cancel = False
    End Sub
    Private codigo As Integer
    Dim mOperacao As clnFuncoesGerais.IncluirAlterar
    Dim Ativo As Boolean
    Dim Erro As New ErrorProvider
    Dim mModoForm As clnFuncoesGerais.ModoForm

    Public Property Operacao() As clnFuncoesGerais.IncluirAlterar
        Get
            Return mOperacao
        End Get
        Set(ByVal Value As clnFuncoesGerais.IncluirAlterar)
            mOperacao = Value
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

    Private Sub ModoPesquisa()
        mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
        Me.pnLatEsq.Size = New Size(1014, 635)
        Me.lsvReduzida.Size = New Size(991, 363)
        With Me.pbNext
            .Name = "pbForward"
            .BackgroundImage = My.Resources.back
            .Location = New Point(969, 12)
        End With
        With frmMenu.lblInfoTela
            .Text = "Pesquisa de Fornecedores"
            .Visible = True
        End With

        Me.btnCancelar.Visible = False
        Me.btnEditar.Visible = False
        Me.btnSalvar.Visible = False
        Me.btnNovo.Visible = False
        Me.btnDesativar.Visible = False
        Me.btnCadCep.Visible = False
        btnPOnline.Visible = False
        Me.lblPOnline.Visible = False
        Me.lblCadCep.Visible = False
        InicializarListView()

    End Sub

    Private Sub ModoCadastro()
        mModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
        CampoObrigatorio()
        Me.pnLatEsq.Size = New Size(251, 633)
        Me.lsvReduzida.Size = New Size(231, 363)
        With Me.pbNext
            .Name = "pbNext"
            .BackgroundImage = My.Resources._next
            .Location = New Point(213, 15)
        End With
        With frmMenu.lblInfoTela
            .Text = "Cadastro de Fornecedores"
            .Visible = True
        End With
        If My.Computer.Network.IsAvailable = True Then
            btnPOnline.Visible = True
            Me.lblPOnline.Visible = True
        Else
            btnPOnline.Visible = False
            Me.lblPOnline.Visible = False
        End If
        InicializarListView()

        Me.btnCancelar.Visible = True
        Me.btnEditar.Visible = True
        Me.btnSalvar.Visible = True
        Me.btnNovo.Visible = True
        Me.btnDesativar.Visible = True
        Me.btnCadCep.Visible = True
        Me.lblCadCep.Visible = True
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

    Private Sub Limpar() Handles btnCancelar.Click
        For Each LC As Control In Me.TabPage1.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
            End If
        Next
        For Each LC As Control In Me.TabPage2.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
            End If
        Next
        Me.TabPage1.Select()
        Me.pnLatEsq.Enabled = True '
        Me.pnInfo.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnSalvar.Enabled = False
        Me.btnNovo.Enabled = True
        Me.btnDesativar.Enabled = False
        Me.btnEditar.Enabled = False
        Me.pbNext.Visible = True
        Me.txtPNome.Clear()
        InicializarListView()
    End Sub

    Private Sub CampoObrigatorio()
        lblRazaoSocial.ForeColor = Color.Red
        lblCNPJ.ForeColor = Color.Red
        lblCep.ForeColor = Color.Red
        lblNo.ForeColor = Color.Red
        lblTelefone.ForeColor = Color.Red
    End Sub

    Private Sub SoTexto(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRzSocial.KeyPress, txtnmFantasia.KeyPress, txtnmContato.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," And Not e.KeyChar = Convert.ToChar(Keys.Space) Then
            e.Handled = True
        End If

        If txtRzSocial.Focused Then
            If Char.IsLower(e.KeyChar) Then
                'Converte em maiúsculo, e coloca na posição correta na TextBox.
                txtRzSocial.SelectedText = Char.ToUpper(e.KeyChar)
                e.Handled = True
            End If
        ElseIf txtnmFantasia.Focused Then
            If Char.IsLower(e.KeyChar) Then
                'Converte em maiúsculo, e coloca na posição correta na TextBox.
                txtnmFantasia.SelectedText = Char.ToUpper(e.KeyChar)
                e.Handled = True
            End If
        ElseIf txtnmContato.Focused Then
            If Char.IsLower(e.KeyChar) Then
                'Converte em maiúsculo, e coloca na posição correta na TextBox.
                txtnmContato.SelectedText = Char.ToUpper(e.KeyChar)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub SoNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNrLog.KeyPress, txtDDD.KeyPress, txtTel.KeyPress, txtCep.KeyPress, txtCNPJ.KeyPress, txtCelCont.KeyPress, txtDDDCel.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmFornecedor_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RzPesquisado = Nothing
        CNPJPesquisado = Nothing
        nmFantasia = Nothing
    End Sub



    Private Sub frmFornecedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub frmFornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = True Then
            btnPOnline.Visible = True
            lblPOnline.Visible = True
        Else
            btnPOnline.Visible = False
            lblPOnline.Visible = False
        End If

        If mModoForm = clnFuncoesGerais.ModoForm.ModoCadastro Then
            ModoCadastro()
        Else
            ModoPesquisa()
        End If
    End Sub

    Private Sub txtCNPJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCNPJ.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Me.txtCNPJ.Text.Length > 0 Then
                    vf = True
                    Me.txtCNPJ.Text = Mid(Me.txtCNPJ.Text, 1, Val(Len(Me.txtCNPJ.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtCNPJ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCNPJ.TextChanged
        If vf = False Then
            If Me.txtCNPJ.Text.Length = 2 Then
                txtCNPJ.Text = txtCNPJ.Text & "."
                txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1

            ElseIf Me.txtCNPJ.Text.Length = 6 Then
                txtCNPJ.Text = txtCNPJ.Text & "."
                txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1

            ElseIf Me.txtCNPJ.Text.Length = 10 Then
                txtCNPJ.Text = txtCNPJ.Text & "/"
                txtCNPJ.SelectionStart = Me.txtCNPJ.Text.Length + 1

            ElseIf Me.txtCNPJ.Text.Length = 15 Then
                txtCNPJ.Text = txtCNPJ.Text & "-"
                txtCNPJ.SelectionStart = Me.txtCNPJ.Text.Length + 1

            End If
        End If
    End Sub

    Private Sub txtCNPJ_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCNPJ.Validating
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais

        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False
            Exit Sub
        ElseIf Me.txtCNPJ.Text = Nothing Then
            e.Cancel = True
            Me.txtCNPJ.Select(0, Me.txtCNPJ.Text.Length)
            Erro.SetError(Me.txtCNPJ, "Campo obrigatório")

        ElseIf Not (Me.txtCNPJ.Text Like "##.###.###/####-##") Then
            e.Cancel = True
            Me.txtCNPJ.Select(0, Me.txtCNPJ.Text.Length)
            Erro.SetError(Me.txtCNPJ, "CNPJ Inválido")

        ElseIf Not ObjClnFuncoesGerais.ValidaCNPJ(txtCNPJ.Text) Then
            e.Cancel = True
            Me.txtCNPJ.Select(0, Me.txtCNPJ.Text.Length)
            Erro.SetError(Me.txtCNPJ, "Nº CNPJ Inválido ")
        End If



    End Sub

    Private Sub txtCNPJ_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.Validated
        Erro.SetError(Me.txtCNPJ, "")

        If Me.txtCNPJ.Text <> Nothing Then
            Me.lblCNPJ.ForeColor = Color.Black
        End If
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
        Me.txtNrLog.Focus()
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
        Me.lblCep.ForeColor = Color.Black
    End Sub

    Private Sub txtNrLog_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNrLog.Validating
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False
        ElseIf Me.txtNrLog.Text = Nothing Then
            e.Cancel = True
            Me.txtNrLog.Select(0, Me.txtNrLog.Text.Length)
            Erro.SetError(Me.txtNrLog, "Campo Obrigatório")
        End If
    End Sub

    Private Sub txtNrLog_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNrLog.Validated
        Erro.SetError(Me.txtNrLog, "")
        lblNo.ForeColor = Color.Black
    End Sub

    Private Sub txtDDD_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDDD.Validating
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False

        ElseIf Me.txtDDD.Text = Nothing Then
            e.Cancel = True
            Me.txtDDD.Select(0, Me.txtDDD.Text.Length)
            Erro.SetError(Me.txtDDD, "Campo obrigatório")

        ElseIf Not (Me.txtDDD.Text Like "##") Then
            e.Cancel = True
            Me.txtDDD.Select(0, Me.txtDDD.Text.Length)
            Erro.SetError(Me.txtDDD, "DDD Inválido ")
        End If
    End Sub

    Private Sub txtDDD_Validated(sender As Object, e As System.EventArgs) Handles txtDDD.Validated
        Erro.SetError(Me.txtDDD, "")
    End Sub

    Private Sub txtTel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTel.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Me.txtTel.Text.Length > 0 Then
                    vf = True
                    Me.txtTel.Text = Mid(Me.txtTel.Text, 1, Val(Len(Me.txtTel.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtTel_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTel.TextChanged
        If vf = False Then
            If Me.txtTel.Text.Length = 4 Then
                Me.txtTel.Text = Me.txtTel.Text & "-"
                Me.txtTel.SelectionStart = Me.txtTel.Text.Length + 1
            End If
        End If
    End Sub

    Private Sub txtTel_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTel.Validating
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False

        ElseIf Me.txtTel.Text = Nothing Then
            e.Cancel = True
            Me.txtTel.Select(0, Me.txtTel.Text.Length)
            Erro.SetError(Me.txtTel, "Campo obrigatório")

        ElseIf Not (Me.txtTel.Text Like "####-####") Then
            e.Cancel = True
            Me.txtTel.Select(0, Me.txtTel.Text.Length)
            Erro.SetError(Me.txtTel, "Telefone Inválido ")
        End If
    End Sub

    Private Sub txtTel_Validated(sender As Object, e As System.EventArgs) Handles txtTel.Validated
        Erro.SetError(Me.txtTel, "")
        Me.lblTelefone.ForeColor = Color.Black
    End Sub

    Private Sub txtPNome_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPNome.KeyDown
        If IsNumeric(Trim(CStr(Regex.Replace(Me.txtPNome.Text, "[\\\?\*-./]", "")))) Then
            Me.txtPNome.MaxLength = 14
            Select Case e.KeyCode
                Case Keys.Back
                    If Len(Me.txtPNome.Text) > 0 Then
                        vf = True
                        Me.txtPNome.Text = Mid(Me.txtPNome.Text, 1, Val(Len(Me.txtPNome.Text)) - 1)
                        SendKeys.Send("{END}")
                    End If
            End Select
            vf = False
        Else
            Me.txtPNome.MaxLength = 70
        End If
    End Sub

    Private Sub txtPNome_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPNome.TextChanged
        If IsNumeric(txtPNome.Text) Then
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
        End If
    End Sub

    Private Sub InicializarListView()

        With lsvReduzida
            .MultiSelect = False
            .Sorting = SortOrder.Ascending
            .GridLines = True
            .FullRowSelect = True
            .AllowColumnReorder = False
            .LabelEdit = False
            .View = View.Details
        End With

        If mModoForm = clnFuncoesGerais.ModoForm.ModoCadastro Then
            With lsvReduzida
                .Items.Clear()
                .Columns.Clear()
                .Columns.Add("Codigo", 60, HorizontalAlignment.Center) 'Nome dos campos
                .Columns.Add("Razão Social", 165, HorizontalAlignment.Left)
                .Font = New System.Drawing.Font("Times New Roman", 8, System.Drawing.FontStyle.Bold)
            End With

        ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa Then
            With lsvReduzida
                .Items.Clear()
                .Columns.Clear() 'Limpar ListView antes de novas colunas
                .Columns.Add("Codigo", 70, HorizontalAlignment.Center) 'Nome dos campos
                .Columns.Add("Razão Social", 300, HorizontalAlignment.Left)
                .Columns.Add("CNPJ", 120, HorizontalAlignment.Center)
                .Columns.Add("DDD", 70, HorizontalAlignment.Center)
                .Columns.Add("Telefone", 100, HorizontalAlignment.Center)
                .Columns.Add("HomePage", 100, HorizontalAlignment.Center)
                .Columns.Add("Contato", 100, HorizontalAlignment.Center)
                .Columns.Add("Email", 300, HorizontalAlignment.Left)
                .Columns.Add("DDD", 30, HorizontalAlignment.Center)
                .Columns.Add("Celular", 100, HorizontalAlignment.Center)
                .Columns.Add("Data Cadastro", 150, HorizontalAlignment.Left)
                .Columns.Add("Ativo", 95, HorizontalAlignment.Center)
                .Font = New System.Drawing.Font("Times New Roman", 8, System.Drawing.FontStyle.Bold)
            End With
        End If

    End Sub

    Private Sub CarregarListView()
        Dim clsObjclnFuncoesGerais As New clnFuncoesGerais
        Dim objClsFornecedor As New clnFornecedor
        Dim ds As Data.DataSet = objClsFornecedor.Lista((Regex.Replace(Me.txtPNome.Text, "[\\\?\*-./]", "")))
        Dim dtable As DataTable = ds.Tables(0)

        lsvReduzida.Items.Clear()

        For i As Integer = 0 To dtable.Rows.Count - 1
            Dim drow As DataRow = dtable.Rows(i)
            If mModoForm = clnFuncoesGerais.ModoForm.ModoCadastro Then
                If drow.RowState <> DataRowState.Deleted Then
                    Dim lvi As New ListViewItem(drow("cdForne").ToString())
                    lvi.SubItems.Add(drow("RazaoSocial").ToString())
                    lvi.Font = New System.Drawing.Font("calibri", 8, System.Drawing.FontStyle.Regular)
                    lsvReduzida.Items.Add(lvi)
                End If

            ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa Then
                If drow.RowState <> DataRowState.Deleted Then
                    Dim lvi As New ListViewItem(drow("cdForne").ToString())
                    lvi.SubItems.Add(drow("RazaoSocial").ToString())
                    lvi.SubItems.Add(drow("CNPJ").ToString())
                    lvi.SubItems.Add(drow("DDD").ToString())
                    lvi.SubItems.Add(drow("Telefone").ToString())
                    lvi.SubItems.Add(drow("HomePage").ToString())
                    lvi.SubItems.Add(drow("Contato").ToString())
                    lvi.SubItems.Add(drow("Email").ToString())
                    lvi.SubItems.Add(drow("DDDCel").ToString())
                    lvi.SubItems.Add(drow("Celular").ToString())
                    lvi.SubItems.Add(drow("DtCad").ToString())
                    lvi.SubItems.Add(drow("Ativo").ToString())
                    lvi.Font = New System.Drawing.Font("calibri", 8, System.Drawing.FontStyle.Regular)
                    lsvReduzida.Items.Add(lvi)
                End If
            End If
        Next
        ObjSistema.pZebra(lsvReduzida, Color.SlateGray, Color.PaleGreen)
    End Sub

    Private Sub CarregaPesquisa()
        Dim objClsFornecedor As New clnFornecedor
        Dim drDados As System.Data.SqlClient.SqlDataReader

        drDados = objClsFornecedor.ListarFORNECEDOR(codigo)

        If drDados.Read Then
            Me.txtRzSocial.Text = drDados("RazaoSocial").ToString.Trim
            Me.txtnmFantasia.Text = drDados("NmFantasia").ToString.Trim
            Me.txtCNPJ.Text = drDados("CNPJ").ToString.Trim
            Me.txtCep.Text = drDados("CEP").ToString.Trim
            BuscaCep()
            Me.txtNrLog.Text = drDados("noLog").ToString.Trim
            Me.txtComplemento.Text = drDados("Complemento").ToString.Trim
            Me.txtDDD.Text = drDados("DDD").ToString.Trim
            Me.txtTel.Text = drDados("Telefone").ToString.Trim
            Me.txtHP.Text = drDados("HomePage").ToString.Trim
            Me.txtnmContato.Text = drDados("Contato").ToString.Trim
            Me.txtEmailCont.Text = drDados("Email").ToString.Trim
            Me.txtDDDCel.Text = drDados("DDDCel").ToString.Trim
            Me.txtCelCont.Text = drDados("Celular").ToString.Trim
            Ativo = CBool(drDados("Ativo"))
            If Ativo = False Then
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
            With Me.btnDesativar
                .Visible = True
                .Enabled = False
            End With
        End If

    End Sub

    Private Sub lsvReduzida_DoubleClick(sender As Object, e As System.EventArgs) Handles lsvReduzida.DoubleClick
        If Not Me.lsvReduzida.SelectedItems.Count = 0 Then

            With Me.lsvReduzida.SelectedItems.Item(0)
                codigo = .SubItems(0).Text
            End With

            CarregaPesquisa()

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
                .Enabled = True
            End With
            Me.btnNovo.Enabled = False
            Me.btnSalvar.Visible = True
            Me.btnDesativar.Visible = True

            If mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa Then
                ModoCadastro()
            End If
        End If
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        Me.pnInfo.Enabled = True
        Me.pnLatEsq.Enabled = False
        Me.txtRzSocial.Focus()
        Me.btnCancelar.Enabled = True
        Me.btnEditar.Enabled = False
        Me.btnSalvar.Enabled = True
        Me.btnNovo.Enabled = False
        Me.txtPNome.Text = Nothing
        Me.pbNext.Visible = False
        For Each LC As Control In Me.TabPage1.Controls
            If TypeOf LC Is TextBox Then
                LC.CausesValidation = True
            End If
        Next

        For Each LC As Control In Me.TabPage2.Controls
            If TypeOf LC Is TextBox Then
                LC.CausesValidation = True
            End If
        Next
        InicializarListView()
        Ativo = True
        CampoObrigatorio()
        txtRzSocial.Text = RzPesquisado
        txtnmFantasia.Text = nmFantasia
        txtCNPJ.Text = CNPJPesquisado
        RzPesquisado = Nothing
        CNPJPesquisado = Nothing
        nmFantasia = Nothing
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao
        Me.pnInfo.Enabled = True
        Me.btnSalvar.Enabled = True
        Me.btnDesativar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEditar.Enabled = False
        Me.pbNext.Visible = False
        Me.btnNovo.Enabled = False
        Me.txtCNPJ.Focus()

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        Dim objClsFornecedor As New clnFornecedor

        With objClsFornecedor
            .RazaoSocial = txtRzSocial.Text.ToString.ToUpper.Trim
            .NmFantasia = txtnmFantasia.Text.ToString.ToUpper.Trim
            .CNPJ = Regex.Replace(Me.txtCNPJ.Text, "[\\\?\*-./]", "").ToString.Trim
            .CEP = Regex.Replace(Me.txtCep.Text, "[\\\?\*-/.]", "").ToString.Trim
            .NoLog = txtNrLog.Text.ToString.Trim
            .Complemento = txtComplemento.Text.ToString.ToUpper.Trim
            .DDD = txtDDD.Text.ToString.Trim
            .Telefone = Regex.Replace(Me.txtTel.Text, "[\\\?\*-./]", "").ToString.Trim
            .HomePage = txtHP.Text.ToString.Trim
            .Contato = txtnmContato.Text.ToString.ToUpper.Trim
            .Email = txtEmailCont.Text.ToString.ToLower.Trim
            .DDDCel = txtDDDCel.Text.ToString.Trim
            .Celular = Regex.Replace(Me.txtCelCont.Text, "[\\\?\*-./]", "").ToString.Trim
            .DtCad = DateTime.Now
            .Ativo = Ativo

            If mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao Then
                objClsFornecedor.Gravar()

                Dim drDados As System.Data.SqlClient.SqlDataReader

                drDados = objClsFornecedor.CarregaCod(Regex.Replace(Me.txtCNPJ.Text, "[\\\?\*-./]", "").ToString.Trim)
                If drDados.Read Then
                    codigo = CInt(drDados("cdForne"))
                End If
                MessageBox.Show("Registro Número " & codigo & ", gravado com sucesso", Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information)
            ElseIf mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao Then
                objClsFornecedor.Codigo = CInt(codigo)
                objClsFornecedor.Alterar()
                MessageBox.Show("Registro Número " & codigo & ", alterado com sucesso", Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information)
            End If
        End With
        Limpar()
    End Sub

    Private Sub btnDesativar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesativar.Click

        If Me.btnDesativar.Text = "&Desativar" Then
            Ativo = False
            With Me.btnDesativar
                .Text = "&Ativar"
                .Image = My.Resources.green_button
            End With
            mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao

        ElseIf Me.btnDesativar.Text = "&Ativar" Then
            Ativo = True
            With Me.btnDesativar
                .Text = "&Desativar"
                .Image = My.Resources.remove
            End With
            mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao

        End If
    End Sub

    Private Sub pbNext_Click(sender As System.Object, e As System.EventArgs) Handles pbNext.Click
        If Me.pbNext.Name = "pbNext" Then
            ModoPesquisa()
            Me.btnCancelar.Visible = False
            Me.btnEditar.Visible = False
            Me.btnSalvar.Visible = False
            Me.btnNovo.Visible = False
            Me.btnDesativar.Visible = False
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

    Private Sub btnPesquisar_Click(sender As System.Object, e As System.EventArgs) Handles btnPesquisar.Click
        InicializarListView()
        CarregarListView()
    End Sub

    Private Sub txtHP_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHP.KeyPress
        If Char.IsUpper(e.KeyChar) Then
            'Converte em maiúsculo, e coloca na posição correta na TextBox.
            txtHP.SelectedText = Char.ToLower(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtComplemento_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtComplemento.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Converte em maiúsculo, e coloca na posição correta na TextBox.
            txtComplemento.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmailCont.KeyPress
        If Char.IsUpper(e.KeyChar) Then
            'Converte em minusculo, e coloca na posição correta na TextBox.
            txtEmailCont.SelectedText = Char.ToLower(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmail_Validated(sender As Object, e As System.EventArgs) Handles txtEmailCont.Validated
        Erro.SetError(Me.txtEmailCont, "")
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmailCont.Validating
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False
            Erro.SetError(Me.txtEmailCont, "")
            Exit Sub
        ElseIf Not ObjClnFuncoesGerais.validaEmail(txtEmailCont.Text) Then
            e.Cancel = True
            Me.txtEmailCont.Select(0, Me.txtEmailCont.Text.Length)
            Erro.SetError(Me.txtEmailCont, "E-mail Inválido ")

        End If

    End Sub

   

    Private Sub txtRzSocial_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRzSocial.TextChanged

    End Sub

    Private Sub txtRzSocial_Validated(sender As Object, e As System.EventArgs) Handles txtRzSocial.Validated
        Erro.SetError(Me.txtRzSocial, "")
        If Me.txtRzSocial.Text <> Nothing Then
            Me.lblRazaoSocial.ForeColor = Color.Black
        End If

    End Sub

    Private Sub txtRzSocial_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtRzSocial.Validating
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False
        ElseIf Me.txtRzSocial.Text = Nothing Then
            e.Cancel = True
            Me.txtRzSocial.Select(0, Me.txtRzSocial.Text.Length)
            Erro.SetError(Me.txtRzSocial, "Campo obrigatório")
        End If
    End Sub

    Private Sub btnPOnline_Click_1(sender As System.Object, e As System.EventArgs) Handles btnPOnline.Click
        frmPCNPJ.ShowDialog()
    End Sub

  

    Private Sub txtCelCont_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCelCont.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Me.txtCelCont.Text.Length > 0 Then
                    vf = True
                    Me.txtCelCont.Text = Mid(Me.txtCelCont.Text, 1, Val(Len(Me.txtCelCont.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtCelCont_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCelCont.TextChanged
        If vf = False Then
            If Me.txtCelCont.Text.Length = 4 Then
                Me.txtCelCont.Text = Me.txtCelCont.Text & "-"
                Me.txtCelCont.SelectionStart = Me.txtCelCont.Text.Length + 1
            End If
        End If
    End Sub

   
    Private Sub btnCadCep_Click(sender As System.Object, e As System.EventArgs) Handles btnCadCep.Click
        frmCadCep.ShowDialog()
    End Sub
End Class

