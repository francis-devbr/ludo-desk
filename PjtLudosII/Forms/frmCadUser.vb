Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Public Class frmCadUser
    Dim mOperacao As clnFuncoesGerais.IncluirAlterar
    Dim Ativo As Boolean
    Dim Erro As New ErrorProvider
    Dim lvItem As ListViewItem
    Dim TemErro As Boolean
    Dim strsenha2 As String

    Private ObjSistema As New cldSistema
    Private Sub Limpar() Handles btnCancelar.Click
        TemErro = False
        ObjSistema.LimpaForm(Me)
        Me.cboPerfil.SelectedIndex = -1
        Me.btnCancelar.Enabled = False
        Me.btnSalvar.Enabled = False
        Me.btnNovo.Enabled = True
        Me.btnDesativar.Enabled = False
        Me.gb.Enabled = False
        Me.lsvReduzida.Enabled = True
        Me.lblSenha.Text = "Senha ( mínimo de 4 caracteres )"
        Me.lblCSenha.Text = "Repita a senha"


    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao
        Me.gb.Enabled = True
        Me.txtCPF.Focus()
        Me.btnCancelar.Enabled = True
        Me.btnSalvar.Enabled = True
        Me.btnNovo.Enabled = False
        Me.lsvReduzida.Enabled = False
        Me.btnDesativar.Visible = False
        Ativo = True
        For Each LC As Control In Me.gb.Controls
            If TypeOf LC Is TextBox Then
                LC.CausesValidation = True
            End If
        Next
    End Sub
  
    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click


        If mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao Then

            With ObjSistema
                .PNome = Me.txtPNome.Text.ToString.Trim
                .UNome = Me.txtUNome.Text.ToString.Trim
                .NoCPF = Regex.Replace(Me.txtCPF.Text, "[\\\?\*-./]", "").ToString.Trim
                .Senha = Me.txtSenha.Text.ToString.Trim
                .IdPerfil = Integer.Parse(Me.cboPerfil.SelectedValue)
                .DtCadastro = DateTime.Now
                .Ativo = Ativo
                .GravaUSUARIO()
            End With

            MessageBox.Show("Registro Gravado com sucesso", Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        ElseIf mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao Then

            With ObjSistema
                .PNome = Me.txtPNome.Text.ToString.Trim
                .UNome = Me.txtUNome.Text.ToString.Trim
                .NoCPF = Regex.Replace(Me.txtCPF.Text, "[\\\?\*-./]", "").ToString.Trim
                .Senha = Me.txtSenha.Text.ToString.Trim
                .IdPerfil = Integer.Parse(Me.cboPerfil.SelectedValue)
                .Ativo = Ativo
                .AtualizaUsuario()
            End With

            MessageBox.Show("Registro Alterado com sucesso", Me.Text, MessageBoxButtons.OK,
            MessageBoxIcon.Information)
        End If
        CarregarListView()
        Limpar()
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
            .Items.Clear()
            .Columns.Clear()
            .Columns.Add("Codigo", 60, HorizontalAlignment.Center)
            .Columns.Add("Nome", 125, HorizontalAlignment.Left)
            .Columns.Add("Sobrenome", 60, HorizontalAlignment.Left)
            .Font = New System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold)
        End With
    End Sub

    Private Sub CarregarListView()
        Dim ds As Data.DataSet = ObjSistema.CarregaUsuario
        Dim dtable As DataTable = ds.Tables(0)
        lsvReduzida.Items.Clear()
        For i As Integer = 0 To dtable.Rows.Count - 1
            Dim drow As DataRow = dtable.Rows(i)
            If drow.RowState <> DataRowState.Deleted Then
                Dim lvi As New ListViewItem(drow("idUsuario").ToString())
                lvi.SubItems.Add(drow("PNome").ToString())
                lvi.SubItems.Add(drow("UNome").ToString())
                lvi.SubItems.Add(drow("nmPerfil").ToString())
                lvi.Font = New System.Drawing.Font("calibri", 12, System.Drawing.FontStyle.Regular)
                lsvReduzida.Items.Add(lvi)
                ObjSistema.AgruparListView(lsvReduzida, 3)
            End If
        Next
        ObjSistema.pZebra(lsvReduzida, Color.SlateGray, Color.PaleGreen)

    End Sub

    Private Sub CarregaPesquisa(ByVal codigo As Integer)

        Dim drDados As System.Data.SqlClient.SqlDataReader
        drDados = ObjSistema.ListaUsuario(codigo)
        If drDados.Read Then
            Me.txtPNome.Text = drDados("PNome").ToString.Trim
            Me.txtUNome.Text = drDados("UNome").ToString.Trim
            Me.txtCPF.Text = drDados("noCPF").ToString.Trim
            Me.strsenha2 = drDados("Senha").ToString.Trim
            Me.cboPerfil.SelectedValue = CInt(drDados("idPerfil"))
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
        End If

    End Sub

    Private Sub lsvReduzida_DoubleClick(sender As Object, e As System.EventArgs) Handles lsvReduzida.DoubleClick
        Dim Codigo As Integer
        If Not lsvReduzida.SelectedItems.Count = 0 Then
            With lsvReduzida.SelectedItems.Item(0)
                Codigo = .SubItems(0).Text
            End With
            CarregaCombo()
            CarregaPesquisa(Codigo)
            Me.btnCancelar.Visible = True
            Me.btnNovo.Visible = True
            With Me.btnDesativar
                .Enabled = True
                .Visible = True
            End With
            Me.gb.Enabled = True
            Me.btnNovo.Enabled = False
            Me.btnCancelar.Enabled = True
            Me.lblSenha.Text = "Senha atual"
            Me.lblCSenha.Text = "Nova senha ( opcional )"
            mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao
            For Each LC As Control In Me.gb.Controls
                If TypeOf LC Is TextBox Then
                    LC.CausesValidation = True
                End If
            Next
        End If

    End Sub

    Private Sub CarregaCombo()
        Me.cboPerfil.DataSource = ObjSistema.CarregaPerfil.Tables(0)
        Me.cboPerfil.DisplayMember = "nmPerfil"
        Me.cboPerfil.ValueMember = "idPerfil"
        Me.cboPerfil.SelectedIndex = -1
    End Sub

    Private Sub frmCadUser_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
    End Sub

    Private Sub frmCadUser_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub frmCadUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CarregaCombo()
        InicializarListView()
        CarregarListView()
        TemErro = True
    End Sub


    Private Sub txtCPF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCPF.KeyDown, txtPNome.KeyDown
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

    Private Sub txtCPF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCPF.TextChanged, txtPNome.TextChanged
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

    Private Sub txtCPF_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCPF.Validating, txtPNome.Validating

        Dim ObjClnFuncoesGerais As New clnFuncoesGerais
        If Me.btnCancelar.Focused Or frmMenu.pnMenuIN.Visible = True Then
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

    Private Sub txtCPF_Validated(sender As Object, e As System.EventArgs) Handles txtCPF.Validated, txtPNome.Validated
        Erro.SetError(Me.txtCPF, "")
    End Sub

    Private Sub txtUser_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUNome.Validating
        If mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao Then
            If Me.btnCancelar.Focused Then
                e.Cancel = False
                Exit Sub
            ElseIf Me.txtUNome.Text = Nothing Then
                e.Cancel = True
                Me.txtUNome.Select(0, Me.txtUNome.Text.Length)
                Erro.SetError(Me.txtUNome, "Campo obrigatório")
            End If
            lvItem = lsvReduzida.FindItemWithText(txtUNome.Text, True, 0, False)
            If (lvItem IsNot Nothing) Then
                e.Cancel = True
                Erro.SetError(Me.txtUNome, "Usuário já registrado")
                Me.txtUNome.Focus()
                Exit Sub
            End If
        ElseIf mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao Then
            If Me.btnCancelar.Focused Then
                e.Cancel = False
                Exit Sub
            ElseIf Me.txtUNome.Text = Nothing Then
                e.Cancel = True
                Me.txtUNome.Select(0, Me.txtUNome.Text.Length)
                Erro.SetError(Me.txtUNome, "Campo obrigatório")
            End If
        End If
    End Sub

    Private Sub txtUser_Validated(sender As Object, e As System.EventArgs) Handles txtUNome.Validated
        Erro.SetError(Me.txtUNome, "")
    End Sub

    Private Sub cboPerfil_GotFocus(sender As Object, e As System.EventArgs) Handles cboPerfil.GotFocus
        SendKeys.Send("{F4}")
    End Sub
   
    Private Sub btnDesativar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesativar.Click

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

    Private Sub txtSenha_Validated(sender As Object, e As System.EventArgs) Handles txtSenha.Validated
        Erro.SetError(Me.txtSenha, "")
        If mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao Then
            Me.btnSalvar.Enabled = True
        End If
    End Sub

    Private Sub txtSenha_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSenha.Validating
        If mOperacao = clnFuncoesGerais.IncluirAlterar.Alteracao Then
            If Me.btnCancelar.Focused Then
                e.Cancel = False
                Exit Sub
            ElseIf Me.txtSenha.Text = Nothing Then
                e.Cancel = True
                Me.txtSenha.Select(0, Me.txtSenha.Text.Length)
                Erro.SetError(Me.txtSenha, "Entre com a senha do usuário para realizar alterações...")
                Me.txtSenha.Focus()
                Exit Sub
            ElseIf Me.txtSenha.Text <> strsenha2 Then
                e.Cancel = True
                Me.txtSenha.Select(0, Me.txtSenha.Text.Length)
                Erro.SetError(Me.txtSenha, "Senha incorreta...")
                Me.txtSenha.Focus()
                Exit Sub
            End If
        End If

        If mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao Then
            If Me.btnCancelar.Focused Then
                e.Cancel = False
                Exit Sub
            ElseIf Me.txtSenha.Text.Length & "" < 4 Then
                e.Cancel = True
                Me.txtSenha.Select(0, Me.txtSenha.Text.Length)
                Erro.SetError(Me.txtSenha, "Senha de acesso do usuário inferior a 4 caracteres ...")
                Me.txtSenha.Focus()
                Exit Sub
            End If
        End If

    End Sub

    Private Sub txtCSenha_Validated(sender As Object, e As System.EventArgs) Handles txtCSenha.Validated
        Erro.SetError(Me.txtCSenha, "")
        If mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao Then
            Me.btnSalvar.Enabled = True
        End If
    End Sub

    Private Sub txtCSenha_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCSenha.Validating
        If mOperacao = clnFuncoesGerais.IncluirAlterar.Inclusao Then
            If Me.btnCancelar.Focused Then
                e.Cancel = False
                Exit Sub
            ElseIf Me.txtSenha.Text <> Me.txtCSenha.Text Then
                e.Cancel = True
                Me.txtCSenha.Select(0, Me.txtCSenha.Text.Length)
                Erro.SetError(Me.txtCSenha, "Erro na comparação das senhas...")
                Me.txtCSenha.Clear()
                Me.txtCSenha.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cboPerfil_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboPerfil.Validating
        If Me.btnCancelar.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False

        ElseIf Me.cboPerfil.Text = Nothing Then
            e.Cancel = True
            Erro.SetError(Me.cboPerfil, "Campo obrigatório")
        End If

    End Sub

    Private Sub Limpar(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click

    End Sub
End Class