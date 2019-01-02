Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic

Public Class frmFuncionario
    Private ObjSistema As New cldSistema
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        e.Cancel = False
    End Sub
    Private codigo As String
    Dim mOperacao As clnFuncoesGerais.IncluirAlterar 'Guarda a operação
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
            .Text = "Pesquisa de Funcionários"
            .Visible = True
        End With
        InicializarListView()

        Me.btnCancelar.Visible = False
        Me.btnEditar.Visible = False
        Me.btnSalvar.Visible = False
        Me.btnNovo.Visible = False
        Me.btnDesativar.Visible = False
        Me.btnCadCep.Visible = False
        Me.lblPOnline.Visible = False
        Me.lblCadCep.Visible = False
        Me.btnPOnline.Visible = False
        InicializarListView()

    End Sub

    Private Sub ModoCadastro()
        mModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
        If My.Computer.Network.IsAvailable = True Then
            btnPOnline.Visible = True
            Me.lblPOnline.Visible = True
        Else
            btnPOnline.Visible = False
            Me.lblPOnline.Visible = False
        End If

        Me.pnLatEsq.Size = New Size(251, 633)
        Me.lsvReduzida.Size = New Size(231, 363)
        With Me.pbNext
            .Name = "pbNext"
            .BackgroundImage = My.Resources._next
            .Location = New Point(213, 15)
        End With
        With frmMenu.lblInfoTela
            .Text = "Cadastro de Funcionários"
            .Visible = True
        End With
        InicializarListView()

        Me.btnCancelar.Visible = True
        Me.btnEditar.Visible = True
        Me.btnSalvar.Visible = True
        Me.btnNovo.Visible = True
        Me.btnDesativar.Visible = True
        Me.btnCadCep.Visible = True
        Me.lblCadCep.Visible = True

    End Sub

    Private Sub CarregarCombo()
        Dim objClsFuncionario As New clnFuncionario
        With Me.cboCargo
            .DataSource = objClsFuncionario.CarregaCargo.Tables(0)
            .DisplayMember = "nmCargo"
            .ValueMember = "cdCargo"
            .SelectedValue = -1
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

    Private Sub Limpar() Handles btnCancelar.Click
        For Each LC As Control In Me.pnInfo.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
            End If
        Next
        Me.pnLatEsq.Enabled = True '
        Me.pnInfo.Enabled = False
        Me.btnCancelar.Enabled = False
        Me.btnSalvar.Enabled = False
        Me.btnNovo.Enabled = True
        Me.btnDesativar.Enabled = False
        Me.btnEditar.Enabled = False
        Me.pbNext.Visible = True
        Me.txtPNome.Clear()
        Me.cboCargo.Text = Nothing
        InicializarListView()

    End Sub

    Private Sub CampoObrigatorio()
        lblNome.ForeColor = Color.Red
        lblSexo.ForeColor = Color.Red
        lblDtNasc.ForeColor = Color.Red
        lblCPF.ForeColor = Color.Red
        lblCEP.ForeColor = Color.Red
        lblNo.ForeColor = Color.Red
        lblTel.ForeColor = Color.Red
        lblCargo.ForeColor = Color.Red
        lblDtAdm.ForeColor = Color.Red
    End Sub

    Private Sub SoTexto(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNome.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "." And Not e.KeyChar = "," And Not e.KeyChar = Convert.ToChar(Keys.Space) Then
            e.Handled = True
        End If

        If Char.IsLower(e.KeyChar) Then
            'Converte em maiúsculo, e coloca na posição correta na TextBox.
            txtNome.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If
    End Sub

    Private Sub SoNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCep.KeyPress, txtCPF.KeyPress, txtDDD.KeyPress, txtDtAdmissao.KeyPress, txtDTNasc.KeyPress, txtNr.KeyPress, txtTel.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmFuncionario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub frmFuncionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub txtNome_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNome.Validating
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False
        ElseIf Me.txtNome.Text = Nothing Then
            e.Cancel = True
            Me.txtNome.Select(0, Me.txtNome.Text.Length)
            Erro.SetError(Me.txtNome, "Campo obrigatório")
        End If

    End Sub

    Private Sub txtNome_Validated(sender As Object, e As System.EventArgs) Handles txtNome.Validated
        Erro.SetError(Me.txtNome, "")
        Me.lblNome.ForeColor = Color.Black
    End Sub

    Private Sub GroupBox1_Leave(sender As Object, e As System.EventArgs) Handles GroupBox1.Leave
        If Me.rbF.Checked = True Or Me.rbM.Checked = True Then
            lblSexo.ForeColor = Color.Black
        Else
            Me.rbM.Checked = True
            Me.lblSexo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtDTNasc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDTNasc.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Len(Me.txtDTNasc.Text) > 0 Then
                    vf = True
                    Me.txtDTNasc.Text = Mid(Me.txtDTNasc.Text, 1, Val(Len(Me.txtDTNasc.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtDTNasc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDTNasc.TextChanged
        If vf = False Then
            If Len(Me.txtDTNasc.Text) = 2 Then
                Me.txtDTNasc.Text = Me.txtDTNasc.Text & "/"
                Me.txtDTNasc.SelectionStart = Len(Me.txtDTNasc.Text) + 1
            ElseIf Len(Me.txtDTNasc.Text) = 5 Then
                Me.txtDTNasc.Text = Me.txtDTNasc.Text & "/"
                Me.txtDTNasc.SelectionStart = Len(Me.txtDTNasc.Text) + 1
            End If
        End If
    End Sub

    Private Sub txtDTNasc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDTNasc.Validating
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False

        ElseIf Me.txtDTNasc.Text = Nothing Then
            e.Cancel = True
            Me.txtDTNasc.Select(0, Me.txtDTNasc.Text.Length)
            Erro.SetError(Me.txtDTNasc, "Campo obrigatório")

        ElseIf IsDate(Me.txtDTNasc.Text) = False Then
            e.Cancel = True
            Me.txtDTNasc.Select(0, Me.txtDTNasc.Text.Length)
            Erro.SetError(Me.txtDTNasc, "Data Inválida")

        ElseIf Not (Me.txtDTNasc.Text Like "##/##/####") Then
            e.Cancel = True
            Me.txtDTNasc.Select(0, Me.txtDTNasc.Text.Length)
            Erro.SetError(Me.txtDTNasc, "Formato Inválido")

        ElseIf ObjClnFuncoesGerais.Age(txtDTNasc.Text) < 18 Then
            e.Cancel = True
            Me.txtDTNasc.Select(0, Me.txtDTNasc.Text.Length)
            Erro.SetError(Me.txtDTNasc, "Proibido Cadastro de menores de 18 anos")

        ElseIf ObjClnFuncoesGerais.Age(txtDTNasc.Text) > 120 Then
            e.Cancel = True
            Me.txtDTNasc.Select(0, Me.txtDTNasc.Text.Length)
            Erro.SetError(Me.txtDTNasc, "Verifique o Ano de Nascimento")

        ElseIf ObjClnFuncoesGerais.Age(txtDTNasc.Text) <= 0 Then
            e.Cancel = True
            Me.txtDTNasc.Select(0, Me.txtDTNasc.Text.Length)
            Erro.SetError(Me.txtDTNasc, "Você ainda não nasceu")
        End If
    End Sub

    Private Sub txtDTNasc_Validated(sender As Object, e As System.EventArgs) Handles txtDTNasc.Validated
        Erro.SetError(Me.txtDTNasc, "")
        Me.lblDtNasc.ForeColor = Color.Black
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
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
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
        Me.txtNr.Focus()
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
        Me.lblCEP.ForeColor = Color.Black
    End Sub


    Private Sub txtNr_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNr.Validating
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False
        ElseIf Me.txtNr.Text = Nothing Then
            e.Cancel = True
            Me.txtNr.Select(0, Me.txtNr.Text.Length)
            Erro.SetError(Me.txtNr, "Campo Obrigatório")
        End If
    End Sub

    Private Sub txtNr_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNr.Validated
        Erro.SetError(Me.txtNr, "")
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
        Me.lblTel.ForeColor = Color.Black
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
                If Len(Me.txtPNome.Text) = 3 Then
                    Me.txtPNome.Text = Me.txtPNome.Text & "."
                    Me.txtPNome.SelectionStart = Len(Me.txtPNome.Text) + 1
                ElseIf Len(Me.txtPNome.Text) = 7 Then
                    Me.txtPNome.Text = txtPNome.Text & "."
                    Me.txtPNome.SelectionStart = Len(Me.txtPNome.Text) + 1
                ElseIf Len(Me.txtPNome.Text) = 11 Then
                    Me.txtPNome.Text = Me.txtPNome.Text & "-"
                    Me.txtPNome.SelectionStart = Len(Me.txtPNome.Text) + 1
                End If
            End If
        End If
    End Sub

    Private Sub txtDtAdmissao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDtAdmissao.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Me.txtDtAdmissao.Text.Length > 0 Then
                    vf = True
                    Me.txtDtAdmissao.Text = Mid(Me.txtDtAdmissao.Text, 1, Val(Len(Me.txtDtAdmissao.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtDtAdmissao_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDtAdmissao.TextChanged
        If vf = False Then
            If Me.txtDtAdmissao.Text.Length = 2 Then
                txtDtAdmissao.Text = txtDtAdmissao.Text & "/"
                txtDtAdmissao.SelectionStart = Me.txtDtAdmissao.Text.Length + 1
            ElseIf Me.txtDtAdmissao.Text.Length = 5 Then
                txtDtAdmissao.Text = txtDtAdmissao.Text & "/"
                txtDtAdmissao.SelectionStart = Me.txtDtAdmissao.Text.Length + 1
            End If
        End If
    End Sub

    Private Sub txtDtAdmissao_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDtAdmissao.Validating
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False
        ElseIf Not (txtDtAdmissao.Text Like "##/##/####") Or IsDate(txtDtAdmissao.Text) = False Then
            e.Cancel = True
            txtDtAdmissao.Select(0, txtDtAdmissao.Text.Length)
            Erro.SetError(txtDtAdmissao, "Formato Inválido ")
        ElseIf DateDiff("yyyy", txtDTNasc.Text, txtDtAdmissao.Text) < 16 Then
            e.Cancel = True
            txtDtAdmissao.Select(0, txtDtAdmissao.Text.Length)
            Erro.SetError(txtDtAdmissao, "Proibido Cadastro de menores de 16 anos")

        ElseIf DateDiff("yyyy", txtDtAdmissao.Text, Date.Now) > 100 Then
            e.Cancel = True
            txtDtAdmissao.Select(0, txtDtAdmissao.Text.Length)
            Erro.SetError(txtDtAdmissao, "Verifique o Ano de Nascimento")
        ElseIf txtDtAdmissao.Text > Date.Now Then
            e.Cancel = True
            txtDtAdmissao.Select(0, txtDtAdmissao.Text.Length)
            Erro.SetError(txtDtAdmissao, "Data Inválida")
        End If


    End Sub

    Private Sub txtDtAdmissao_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDtAdmissao.Validated
        Erro.SetError(txtDtAdmissao, "")
        lblDtAdm.ForeColor = Color.Black
    End Sub

    Private Sub InicializarListView() 'Preparar ListView

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
                .Columns.Add("Nome", 165, HorizontalAlignment.Left)
                .Font = New System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold)
            End With

        ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa Then
            With lsvReduzida
                .Items.Clear()
                .Columns.Clear() 'Limpar ListView antes de novas colunas
                .Columns.Add("Codigo", 70, HorizontalAlignment.Center) 'Nome dos campos
                .Columns.Add("Nome", 350, HorizontalAlignment.Left)
                .Columns.Add("CPF", 200, HorizontalAlignment.Center)
                .Columns.Add("DDD", 70, HorizontalAlignment.Center)
                .Columns.Add("Telefone", 150, HorizontalAlignment.Center)
                .Columns.Add("Ativo", 95, HorizontalAlignment.Center)
                .Font = New System.Drawing.Font("Times New Roman", 12, System.Drawing.FontStyle.Bold)
            End With
        End If

    End Sub

    Private Sub CarregarListView() 'Carregar ListView
        Dim clsObjclnFuncoesGerais As New clnFuncoesGerais
        'Criar table a partir de DataSet
        Dim objClsFuncionario As New clnFuncionario
        Dim ds As Data.DataSet = objClsFuncionario.Lista((Regex.Replace(Me.txtPNome.Text, "[\\\?\*-./]", "")))
        Dim dtable As DataTable = ds.Tables(0)

        lsvReduzida.Items.Clear() 'Limpar ListView

        For i As Integer = 0 To dtable.Rows.Count - 1
            Dim drow As DataRow = dtable.Rows(i)
            If mModoForm = clnFuncoesGerais.ModoForm.ModoCadastro Then
                If drow.RowState <> DataRowState.Deleted Then
                    Dim lvi As New ListViewItem(drow("cdFunc").ToString())
                    lvi.SubItems.Add(drow("Nome").ToString())
                    lvi.Font = New System.Drawing.Font("calibri", 12, System.Drawing.FontStyle.Regular)
                    lvi.Font = New System.Drawing.Font("calibri", 10, System.Drawing.FontStyle.Regular)
                    lsvReduzida.Items.Add(lvi)
                End If

            ElseIf mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa Then
                If drow.RowState <> DataRowState.Deleted Then
                    Dim lvi As New ListViewItem(drow("cdFunc").ToString())
                    lvi.SubItems.Add(drow("Nome").ToString())
                    lvi.SubItems.Add(drow("noCPF").ToString())
                    lvi.SubItems.Add(drow("DDD").ToString())
                    lvi.SubItems.Add(drow("Telefone").ToString())
                    lvi.SubItems.Add(drow("Ativo").ToString())
                    lvi.SubItems.Add(drow("nmCargo").ToString())
                    lvi.Font = New System.Drawing.Font("calibri", 12, System.Drawing.FontStyle.Regular)
                    lsvReduzida.Items.Add(lvi)

                End If
            End If
        Next
        ObjSistema.pZebra(lsvReduzida, Color.SlateGray, Color.PaleGreen)

    End Sub

    Private Sub CarregaPesquisa()
        Dim objClsFuncionario As New clnFuncionario
        Dim drDados As System.Data.SqlClient.SqlDataReader
        Dim sexo As String
        drDados = objClsFuncionario.ListarFunc(codigo)
        If drDados.Read Then
            Me.txtNome.Text = drDados("Nome").ToString.Trim
            Me.txtDTNasc.Text = CDate(drDados("DtNasc").ToString.Trim)
            sexo = drDados("Sexo").ToString.Trim
            If sexo = "F" Then
                Me.rbF.Checked = True
            Else
                Me.rbM.Checked = True
            End If
            Me.txtCPF.Text = drDados("noCPF").ToString.Trim
            Me.txtCep.Text = drDados("noCEP").ToString.Trim
            Me.txtNr.Text = drDados("noLog").ToString.Trim
            Me.txtComplemento.Text = drDados("Complemento").ToString.Trim
            Me.txtDDD.Text = drDados("DDD").ToString.Trim
            Me.txtTel.Text = drDados("Telefone").ToString.Trim
            Me.txtDtAdmissao.Text = CDate(drDados("DtEntrada").ToString.Trim)
            Me.cboCargo.SelectedValue = Integer.Parse(drDados("CdCargo"))
            Ativo = drDados("Ativo")
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
            BuscaCep()
        End If

    End Sub

    Private Sub lsvReduzida_DoubleClick(sender As Object, e As System.EventArgs) Handles lsvReduzida.DoubleClick
        If Not lsvReduzida.SelectedItems.Count = 0 Then
            With lsvReduzida.SelectedItems.Item(0)
                codigo = .SubItems(0).Text
            End With
            CarregarCombo()
            CarregaPesquisa()
            Me.btnCancelar.Visible = True
            Me.btnEditar.Visible = True
            Me.btnSalvar.Visible = True
            Me.btnNovo.Visible = True
            Me.btnDesativar.Visible = True
            Me.btnEditar.Enabled = True
            Me.btnNovo.Enabled = False
            Me.btnCancelar.Enabled = True
            Me.pnLatEsq.Enabled = False
            If mModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa Then
                ModoCadastro()
            End If
        End If
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao
        For Each LC As Control In Me.pnInfo.Controls
            If TypeOf LC Is TextBox Then
                LC.CausesValidation = True
            End If
        Next
        CampoObrigatorio()
        Me.pnInfo.Enabled = True
        Me.txtNome.Focus()
        Me.btnCancelar.Enabled = True
        Me.btnEditar.Enabled = False
        Me.btnSalvar.Enabled = True
        Me.btnNovo.Enabled = False
        Me.txtPNome.Text = Nothing
        Me.pbNext.Visible = False
        pnLatEsq.Enabled = False
        InicializarListView()
        Ativo = True
        CarregarCombo()

        txtNome.Text = NomePesquisado
        txtCPF.Text = CPFPesquisado
        NomePesquisado = Nothing
        CPFPesquisado = Nothing

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click

        For Each LC As Control In Me.pnInfo.Controls
            If TypeOf LC Is TextBox Then
                If LC.Name <> "txtComplemento" Then
                    If LC.Text = Nothing Then
                        LC.Focus()
                        Exit Sub
                    End If
                End If
            End If
        Next

        Dim objClsFuncionario As New clnFuncionario

        If Me.rbF.Checked = False And Me.rbM.Checked = False Then
            Me.rbM.Checked = True
        End If

        With objClsFuncionario
            .Nome = Me.txtNome.Text.ToString.ToUpper.Trim
            .DtNasc = Me.txtDTNasc.Text.ToString.Trim
            If rbF.Checked Then
                .Sexo = "F"
            Else
                .Sexo = "M"
            End If
            .NoCPF = Regex.Replace(Me.txtCPF.Text, "[\\\?\*-./]", "").ToString.Trim
            .NoCEP = Regex.Replace(Me.txtCep.Text, "[\\\?\*-./]", "").ToString.Trim
            .NoLog = Me.txtNr.Text.ToString.Trim
            .Complemento = Me.txtComplemento.Text.ToString.ToUpper.Trim
            .DDD = Me.txtDDD.Text.ToString.Trim
            .Telefone = Regex.Replace(Me.txtTel.Text, "[\\\?\*-./]", "").ToString.Trim
            .DtEntrada = CDate(Me.txtDtAdmissao.Text)
            .CdCargo = Integer.Parse(Me.cboCargo.SelectedValue)
            .Foto = ""
            .DtCad = DateTime.Now
            .Ativo = Ativo
        End With
        If mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao Then 'Inclusão
            objClsFuncionario.Gravar()
            Dim drDados As System.Data.SqlClient.SqlDataReader
            drDados = objClsFuncionario.CarregaCod(Regex.Replace(Me.txtCPF.Text, "[\\\?\*-./]", "").ToString.Trim)
            If drDados.Read Then
                codigo = CStr(drDados("cdFunc"))
            End If
            MessageBox.Show("Registro Número " & codigo & ", gravado com sucesso", Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        ElseIf mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao Then 'Alteração
            objClsFuncionario.Codigo = CInt(codigo)
            objClsFuncionario.Alterar()
            MessageBox.Show("Registro Número " & codigo & ", alterado com sucesso", Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information)
        End If
        Limpar()

    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click
        mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao
        Me.pnInfo.Enabled = True
        Me.btnSalvar.Enabled = True
        Me.btnDesativar.Enabled = True
        Me.btnCancelar.Enabled = True
        Me.btnEditar.Enabled = False
        Me.pbNext.Visible = False
        Me.txtNome.Focus()
    End Sub

    Private Sub btnDesativar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesativar.Click
        If Me.btnDesativar.Text = "&Desativar" Then
            Ativo = False
            With Me.btnDesativar
                .Text = "&Ativar"
                .Image = My.Resources.green_button
            End With
            mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao
            Me.btnSalvar.Enabled = True
        ElseIf Me.btnDesativar.Text = "&Ativar" Then
            Ativo = True
            With Me.btnDesativar
                .Text = "&Desativar"
                .Image = My.Resources.remove
            End With
            mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao
            Me.btnSalvar.Enabled = True
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

    Private Sub txtComplemento_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtComplemento.KeyPress
        If Char.IsLower(e.KeyChar) Then
            'Converte em maiúsculo, e coloca na posição correta na TextBox.
            txtComplemento.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If
    End Sub

    Private Sub cboCargo_GotFocus(sender As Object, e As System.EventArgs) Handles cboCargo.GotFocus
        SendKeys.Send("{F4}")
    End Sub

    Private Sub cboCargo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCargo.Validated
        Erro.SetError(Me.cboCargo, "")
        lblCargo.ForeColor = Color.Black
    End Sub


    Private Sub cboCargo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCargo.Validating
        If Me.btnCancelar.Focused Or Me.pbNext.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False

        ElseIf Me.cboCargo.Text = Nothing Then
            e.Cancel = True
            Erro.SetError(Me.cboCargo, "Campo obrigatório")
        End If

    End Sub


    Private Sub btnCadCep_Click(sender As System.Object, e As System.EventArgs) Handles btnCadCep.Click
        frmCadCep.ShowDialog()
    End Sub


    Private Sub btnPOnline_Click(sender As System.Object, e As System.EventArgs) Handles btnPOnline.Click
        frmPCPF.ShowDialog()
    End Sub

    Private Sub cboCargo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCargo.SelectedIndexChanged

    End Sub
End Class