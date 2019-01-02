Imports System.Data.SqlClient
Imports System
Imports System.Data

Public Class frmPesquisa
    ' constantes para os nomes das tabelas
    Private TABELA_ORDERS As [String] = "tblFornecedor"
    ' constantes para os nomes dos campos usados
    Private CAMPO_COD As [String] = "cdForne"
    Private CAMPO_RZSOCIAL As [String] = "nmRSocial"

    Private Sub frmPesquisa(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim strSql As String = "select distinct cdForne, nmRSocial, noCNPJ from tblFornecedor"

        Dim strConexao As String = " Public StringConexao As String = Server=Rosiane-PC\SQLServer;Database=PjtoLudoII;UID=sa;PWD=123456;"

        Dim da As New SqlDataAdapter(strSql, strConexao)
        Dim dt As New DataTable("tblFornecedor")
        'preenche a tabela Orders 
        da.Fill(dt)
        da.FillSchema(dt, SchemaType.Source)

        ' vincula a tabela ao datagrid
        DGV.DataSource = dt.DefaultView
        DGV.Hide()
        'Label2.Text = "Registro(s)." & DGV.RowCount - 1
        DGV.Columns(0).Width = 250
        DGV.Columns(1).Width = 150

    End Sub

    Private Sub txtPesquisar_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPesquisar.TextChanged
        'obtem a tabela vinculada ao datagrid
        Dim dt As DataTable = CType(DGV.DataSource, DataView).Table

        ' constroi o filtro usando o conteudo do combobox
        Dim filtro As [String] = CAMPO_RZSOCIAL & " like '%" & txtPesquisar.Text & "%'"
        DGV.RowHeadersVisible = True
        ' localiza os registros usando o método select do datatable
        Dim drc As DataRow() = dt.Select(filtro)
        'Label2.Text = drc.Length & " Registros(s)." & Environment.NewLine
        ' localiza os registros usando a propriedade RowFilter do DataView
        Dim dv As New DataView(dt)

        'executa o filtro no dataview
        dv.RowFilter = filtro

        'vincula o resultado ao dtagrid
        DGV.DataSource = dv
        'Label2.Text = "Registro(s)." & DGV.RowCount - 1
        DGV.Visible = True
        '--------------------------------------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        'Passa o código atual do cadastro
        Dim frmFornecedorAlt As New frmFornecedor
        'frmCadastraAgendaAlt.txtNome.Text = CStr(Me.dgv.CurrentRow.Cells(1).Value) 'Pesquisa pelo nome
        frmFornecedorAlt.txtCodForn.Text = CStr(Me.DGV.CurrentRow.Cells(0).Value)
        frmFornecedorAlt.Text = ">> A l t e r a r D a d o s <<" 'Alterar nome do formulário
        frmFornecedorAlt.txtCodForn.Enabled = False 'Desativa o campo Código
        frmFornecedorAlt.btnGravar.Text = "&Alterar" 'Alterar o nome botão
        With frmFornecedorAlt
            .operacao = clnFuncoesGerais.IncluirAlterar.Alteracao 'Registra Alteração
            .Show()
        End With
        Me.Close()
    End Sub

    Private Sub frmPesquisa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmPesquisa_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmPesquisa_Load_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmPesquisa_Load_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class


