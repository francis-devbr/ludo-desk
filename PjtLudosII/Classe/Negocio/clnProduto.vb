Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class clnProduto
    Private objCldBD As New cldBD

    Private mIDe As Integer
    Public Property ID As Integer
        Get
            Return mIDe
        End Get
        Set(value As Integer)
            mIDe = value
        End Set
    End Property
    Private mNome As String
    Public Property Nome As String
        Get
            Return mNome
        End Get
        Set(value As String)
            mNome = value
        End Set
    End Property
    Private mIcone As String
    Public Property Icone As String
        Get
            Return mIcone
        End Get
        Set(value As String)
            mIcone = value
        End Set
    End Property
    Private mAtivo As Boolean
    Public Property Ativo As Boolean
        Get
            Return mAtivo
        End Get
        Set(value As Boolean)
            mAtivo = value
        End Set
    End Property
    Private mNomeRzd As String
    Public Property NomeRzd As String
        Get
            Return mNomeRzd
        End Get
        Set(value As String)
            mNomeRzd = value
        End Set
    End Property
    Private mDesc As String
    Public Property Desc As String
        Get
            Return mDesc
        End Get
        Set(value As String)
            mDesc = value
        End Set
    End Property
    Private mDesc2 As String
    Public Property Desc2 As String
        Get
            Return mDesc2
        End Get
        Set(value As String)
            mDesc2 = value
        End Set
    End Property
    Private mURLVideo As String
    Public Property URLVideo As String
        Get
            Return mURLVideo
        End Get
        Set(value As String)
            mURLVideo = value
        End Set
    End Property
    Private mIdDesenvolvedor As Integer
    Public Property IdDesenvolvedor As Integer
        Get
            Return mIdDesenvolvedor
        End Get
        Set(value As Integer)
            mIdDesenvolvedor = value
        End Set
    End Property
    Private mIdPublicador As Integer
    Public Property IdPublicador As Integer
        Get
            Return mIdPublicador
        End Get
        Set(value As Integer)
            mIdPublicador = value
        End Set
    End Property
    Private mIdPlataforma As Integer
    Public Property IdPlataforma As Integer
        Get
            Return mIdPlataforma
        End Get
        Set(value As Integer)
            mIdPlataforma = value
        End Set
    End Property
    Private mDtLancamento As Date
    Public Property DtLancamento As Date
        Get
            Return mDtLancamento
        End Get
        Set(value As Date)
            mDtLancamento = value
        End Set
    End Property
    Private mIdESRB As Integer
    Public Property idESRB As Integer
        Get
            Return mIdESRB
        End Get
        Set(value As Integer)
            mIdESRB = value
        End Set
    End Property
    Private mIdMidia As Integer
    Public Property IdMidia As Integer
        Get
            Return mIdMidia
        End Get
        Set(value As Integer)
            mIdMidia = value
        End Set
    End Property
    Private mIdTpProduto As Integer
    Public Property IdTpProduto As Integer
        Get
            Return mIdTpProduto
        End Get
        Set(value As Integer)
            mIdTpProduto = value
        End Set
    End Property
    Private mNoPlayers As Integer
    Public Property NoPlayers As Integer
        Get
            Return mNoPlayers
        End Get
        Set(value As Integer)
            mNoPlayers = value
        End Set
    End Property
    Private mCoop As Boolean
    Public Property Coop As Boolean
        Get
            Return mCoop
        End Get
        Set(value As Boolean)
            mCoop = value
        End Set
    End Property
    Private mGarantia As String
    Public Property Garantia As String
        Get
            Return mGarantia
        End Get
        Set(value As String)
            mGarantia = value
        End Set
    End Property
    Private mNoEstMin As Integer
    Public Property NoEstMin As Integer
        Get
            Return mNoEstMin
        End Get
        Set(value As Integer)
            mNoEstMin = value
        End Set
    End Property
    Private mNoEstMax As Integer
    Public Property NoEstMax As Integer
        Get
            Return mNoEstMax
        End Get
        Set(value As Integer)
            mNoEstMax = value
        End Set
    End Property
    Private mNoEstAlvo As Integer
    Public Property NoEstAlvo As Integer
        Get
            Return mNoEstAlvo
        End Get
        Set(value As Integer)
            mNoEstAlvo = value
        End Set
    End Property
    Private mSitProduto As Integer
    Public Property SitProduto As Integer
        Get
            Return mSitProduto
        End Get
        Set(value As Integer)
            mSitProduto = value
        End Set
    End Property
    Private mDtCadastro As Date
    Public Property DtCadastro As Date
        Get
            Return mDtCadastro
        End Get
        Set(value As Date)
            mDtCadastro = value
        End Set
    End Property
    Private mMargem As String
    Public Property Margem As String
        Get
            Return mMargem
        End Get
        Set(value As String)
            mMargem = value
        End Set
    End Property
    Private mIdItemIncluso As Integer
    Public Property IdItemIncluso As Integer
        Get
            Return mIdItemIncluso
        End Get
        Set(value As Integer)
            mIdItemIncluso = value
        End Set
    End Property
    Private mIdGenero As Integer
    Public Property IdGenero As Integer
        Get
            Return mIdGenero
        End Get
        Set(value As Integer)
            mIdGenero = value
        End Set
    End Property
    Private mIdCategoria As Integer
    Public Property IdCategoria As Integer
        Get
            Return mIdCategoria
        End Get
        Set(value As Integer)
            mIdCategoria = value
        End Set
    End Property
    Private mVlCusto As String
    Public Property VlCusto As String
        Get
            Return mVlCusto
        End Get
        Set(value As String)
            mVlCusto = value
        End Set
    End Property
    Private mVlVendaLoja As String
    Public Property VlVendaLoja As String
        Get
            Return mVlVendaLoja
        End Get
        Set(value As String)
            mVlVendaLoja = value
        End Set
    End Property
    Private mVlVendaNet As String
    Public Property VlVendaNet As String
        Get
            Return mVlVendaNet
        End Get
        Set(value As String)
            mVlVendaNet = value
        End Set
    End Property
    Private mIdFornecedor As Integer
    Public Property IdFornecedor As Integer
        Get
            Return mIdFornecedor
        End Get
        Set(value As Integer)
            mIdFornecedor = value
        End Set
    End Property
    Private mCNPJ As String
    Public Property CNPJ As String
        Get
            Return mCNPJ
        End Get
        Set(value As String)
            mCNPJ = value
        End Set
    End Property
    Private mNmFantasia As String
    Public Property NmFantasia As String
        Get
            Return mNmFantasia
        End Get
        Set(value As String)
            mNmFantasia = value
        End Set
    End Property
    Private mNoCEP As String
    Public Property NoCEP As String
        Get
            Return mNoCEP
        End Get
        Set(value As String)
            mNoCEP = value
        End Set
    End Property
    Private mNoLog As String
    Public Property NoLog As String
        Get
            Return mNoLog
        End Get
        Set(value As String)
            mNoLog = value
        End Set
    End Property
    Private mDsComplemento As String
    Public Property DsComplemento As String
        Get
            Return mDsComplemento
        End Get
        Set(value As String)
            mDsComplemento = value
        End Set
    End Property
    Private mNoDDD As String
    Public Property NoDDD As String
        Get
            Return mNoDDD
        End Get
        Set(value As String)
            mNoDDD = value
        End Set
    End Property
    Private mNoTelefone As String
    Public Property NoTelefone As String
        Get
            Return mNoTelefone
        End Get
        Set(value As String)
            mNoTelefone = value
        End Set
    End Property
    Private mNmHomePage As String
    Public Property NmHomePage As String
        Get
            Return mNmHomePage
        End Get
        Set(value As String)
            mNmHomePage = value
        End Set
    End Property
    Private mNmContato As String
    Public Property NmContato As String
        Get
            Return mNmContato
        End Get
        Set(value As String)
            mNmContato = value
        End Set
    End Property
    Private mEmail As String
    Public Property Email As String
        Get
            Return mEmail
        End Get
        Set(value As String)
            mEmail = value
        End Set
    End Property
    Private mNoDDDCel As String
    Public Property NoDDDCel As String
        Get
            Return mNoDDDCel
        End Get
        Set(value As String)
            mNoDDDCel = value
        End Set
    End Property
    Private mNoCelular As String
    Public Property NoCelular As String
        Get
            Return mNoCelular
        End Get
        Set(value As String)
            mNoCelular = value
        End Set
    End Property

    Public Sub Grava(ByVal tabela As String)
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append(tabela)
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mNome & "' ")
        str.Append(", '" & mIcone & "' ")
        str.Append(", '" & mAtivo & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaDesenvolvedor()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("Desenvolvedor ")
        str.Append("set ")
        str.Append("nmDesenvolvedor = '" & mNome & "' ")
        str.Append(", iconeDesenvolvedor = '" & mIcone & "' ")
        str.Append(", Ativo = '" & mAtivo & "' ")
        str.Append(" WHERE ")
        str.Append(" idDesenvolvedor = '" & mIdDesenvolvedor & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaPublicador()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("Publicador ")
        str.Append("set ")
        str.Append("nmPublicador = '" & mNome & "' ")
        str.Append(", iconePublicador = '" & mIcone & "' ")
        str.Append(", Ativo = '" & mAtivo & "' ")
        str.Append(" WHERE ")
        str.Append(" idPublicador = '" & mIdPublicador & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaPlataforma()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("Plataforma ")
        str.Append("set ")
        str.Append("nmPlataforma = '" & mNome & "' ")
        str.Append(", iconePlataforma = '" & mIcone & "' ")
        str.Append(", Ativo = '" & mAtivo & "' ")
        str.Append(" WHERE ")
        str.Append(" idPlataforma = '" & mIdPlataforma & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaGenero()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("Genero ")
        str.Append("set ")
        str.Append("nmGenero = '" & mNome & "' ")
        str.Append(", iconeGenero = '" & mIcone & "' ")
        str.Append(", Ativo = '" & mAtivo & "' ")
        str.Append(" WHERE ")
        str.Append(" idGenero = '" & mIdGenero & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaESRB()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("ESRB ")
        str.Append("set ")
        str.Append("nmESRB = '" & mNome & "' ")
        str.Append(", iconeESRB = '" & mIcone & "' ")
        str.Append(", Ativo = '" & mAtivo & "' ")
        str.Append(" WHERE ")
        str.Append(" idESRB = '" & mIdESRB & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaMIDIA()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("MIDIA ")
        str.Append("set ")
        str.Append("nmMIDIA = '" & mNome & "' ")
        str.Append(", iconeMIDIA = '" & mIcone & "' ")
        str.Append(", Ativo = '" & mAtivo & "' ")
        str.Append(" WHERE ")
        str.Append(" idMIDIA = '" & mIdMidia & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaCATEGORIA()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("CATEGORIA ")
        str.Append("set ")
        str.Append("nmCATEGORIA = '" & mNome & "' ")
        str.Append(", iconeCATEGORIA = '" & mIcone & "' ")
        str.Append(", Ativo = '" & mAtivo & "' ")
        str.Append(" WHERE ")
        str.Append(" idCATEGORIA = '" & mIdCategoria & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaTPPRODUTO()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("TPPRODUTO ")
        str.Append("set ")
        str.Append("nmTpProduto = '" & mNome & "' ")
        str.Append(", iconeTpProduto = '" & mIcone & "' ")
        str.Append(", Ativo = '" & mAtivo & "' ")
        str.Append(" WHERE ")
        str.Append(" idTpProduto = '" & mIdTpProduto & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub GravaProduto()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("PRODUTO")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mNome & "' ")
        str.Append(", '" & mNomeRzd & "' ")
        str.Append(", '" & mDesc & "' ")
        str.Append(", '" & mDesc2 & "' ")
        str.Append(", '" & mIcone & "' ")
        str.Append(", '" & mIdDesenvolvedor & "' ")
        str.Append(", '" & mIdPublicador & "' ")
        str.Append(", '" & mIdPlataforma & "' ")
        str.Append(", '" & mDtLancamento & "' ")
        str.Append(", '" & mIdESRB & "' ")
        str.Append(", '" & mIdMidia & "' ")
        str.Append(", '" & mIdTpProduto & "' ")
        str.Append(", '" & mNoPlayers & "' ")
        str.Append(", '" & mGarantia & "' ")
        str.Append(", '" & mNoEstMin & "' ")
        str.Append(", '" & mNoEstMax & "' ")
        str.Append(", '" & mNoEstAlvo & "' ")
        str.Append(", '" & mAtivo & "' ")
        str.Append(", '" & mDtCadastro & "' ")
        str.Append(", '" & mMargem & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaProduto()
        Dim str As New StringBuilder
        str.Append("UPDATE ")
        str.Append("PRODUTO")
        str.Append(" SET ")
        str.Append("nmCompleto = '" & mNome & "' ")
        str.Append(", iconeTpProduto = '" & mIcone & "' ")
        str.Append(", nmReduzido = '" & mNomeRzd & "' ")
        str.Append(", descrProduto = '" & mDesc & "' ")
        str.Append(", descrProduto2 = '" & mDesc2 & "' ")
        str.Append(", ftCapa = '" & mIcone & "' ")
        str.Append(", nmVideo = '" & mURLVideo & "' ")
        str.Append(", idDesenvolvedor = '" & mIdDesenvolvedor & "' ")
        str.Append(", idPublicador = '" & mIdPublicador & "' ")
        str.Append(", idPlataforma = '" & mIdPlataforma & "' ")
        str.Append(", dtLancamento = '" & mDtLancamento & "' ")
        str.Append(", idESRB = '" & mIdESRB & "' ")
        str.Append(", idMidia = '" & mIdMidia & "' ")
        str.Append(", idTpProduto = '" & mIdTpProduto & "' ")
        str.Append(", noPlayers = '" & mNoPlayers & "' ")
        str.Append(", Coop = '" & mCoop & "' ")
        str.Append(", Garantia = '" & mGarantia & "' ")
        str.Append(", noEstMin = '" & mNoEstMin & "' ")
        str.Append(", noEstMax = '" & mNoEstMax & "' ")
        str.Append(", noEstAlvo = '" & mNoEstAlvo & "' ")
        str.Append(", sitProduto = '" & mSitProduto & "' ")
        str.Append(", Margem = '" & mMargem & "' ")
        str.Append(" WHERE ")
        str.Append(" idProduto = '" & mIDe & "' ")

        objCldBD.ExecutaComando(str.ToString)
    End Sub
    Public Sub GravaSCREENSHOT()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("SCREENSHOT")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mNome & "' ")
        str.Append(", '" & mIDe & "' ")
        str.Append(", '" & NomeRzd & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub
    Public Sub AtualizaSCREENSHOT()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("SCREENSHOT ")
        str.Append("set ")
        str.Append("nmScreen = '" & mNome & "' ")
        str.Append(" WHERE ")
        str.Append(" idProduto = '" & mIDe & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub GravaEAN()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("EAN")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mNome & "' ")
        str.Append(", '" & mIDe & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaEAN()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("EAN ")
        str.Append("set ")
        str.Append("noEAN = '" & mNome & "' ")
        str.Append(" WHERE ")
        str.Append(" idProduto = '" & mIDe & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub GravaITEMINCLUSO()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("ITEMINCLUSO")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mIDe & "' ")
        str.Append(", '" & mNome & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaITEMINCLUSO()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("ITEMINCLUSO ")
        str.Append("set ")
        str.Append("nmItem = '" & mNome & "' ")
        str.Append("idProduto = '" & mIDe & "' ")
        str.Append(" WHERE ")
        str.Append(" idItemIncluso = '" & mIdItemIncluso & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub GravaPRODUTO_GENERO()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("PRODUTO_GENERO")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mIDe & "' ")
        str.Append(", '" & mIdGenero & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaPRODUTO_GENERO()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("PRODUTO_GENERO ")
        str.Append("set ")
        str.Append("idProduto = '" & mIDe & "' ")
        str.Append("idGenero = '" & mIdGenero & "' ")
        str.Append(" WHERE ")
        str.Append(" idProduto = '" & mIDe & "' and idGenero= '" & mIdGenero & "'")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub GravaPRODUTO_CATEGORIA()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("PRODUTO_CATEGORIA")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mIDe & "' ")
        str.Append(", '" & mIdCategoria & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaPRODUTO_CATEGORIA()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("PRODUTO_CATEGORIA ")
        str.Append("set ")
        str.Append("idProduto = '" & mIDe & "' ")
        str.Append("idCategoria = '" & mIdCategoria & "' ")
        str.Append(" WHERE ")
        str.Append(" idProduto = '" & mIDe & "' and idCategoria= '" & mIdCategoria & "'")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub GravaPRECO_PRODUTO()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("PRECO_PRODUTO")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mIDe & "' ")
        str.Append(", '" & mVlCusto & "' ")
        str.Append(", '" & mVlVendaLoja & "' ")
        str.Append(", '" & mVlVendaNet & "' ")
        str.Append(", '" & mDtCadastro & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub GravaFornecedor()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("FORNECEDOR")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mCNPJ & "' ")
        str.Append("'" & mNome & "' ")
        str.Append(", '" & mNmFantasia & "' ")
        str.Append(", '" & mNoCEP & "' ")
        str.Append(", '" & mNoLog & "' ")
        str.Append(", '" & mDsComplemento & "' ")
        str.Append(", '" & mNoDDD & "' ")
        str.Append(", '" & mNoTelefone & "' ")
        str.Append(", '" & mNmHomePage & "' ")
        str.Append(", '" & mNmContato & "' ")
        str.Append(", '" & mEmail & "' ")
        str.Append(", '" & mNoDDDCel & "' ")
        str.Append(", '" & mNoCelular & "' ")
        str.Append(", '" & mDtCadastro & "' ")
        str.Append(", '" & mAtivo & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaFornecedor()
        Dim str As New StringBuilder
        str.Append("UPDATE ")
        str.Append("FORNECEDOR")
        str.Append(" SET ")
        str.Append("CNPJ = '" & mCNPJ & "' ")
        str.Append("RazaoSocial = '" & mNome & "' ")
        str.Append(", NmFantasia = '" & mNmFantasia & "' ")
        str.Append(", noCEP = '" & mNoCEP & "' ")
        str.Append(", noLog = '" & mNoLog & "' ")
        str.Append(", dsComplemento = '" & mDsComplemento & "' ")
        str.Append(", noDDD = '" & mNoDDD & "' ")
        str.Append(", noTelefone = '" & mNoTelefone & "' ")
        str.Append(", nmHomePage = '" & mNmHomePage & "' ")
        str.Append(", nmContato = '" & mNmContato & "' ")
        str.Append(", Email = '" & mEmail & "' ")
        str.Append(", noDDDCel = '" & mNoDDDCel & "' ")
        str.Append(", noCelular = '" & mNoCelular & "' ")
        str.Append(", Ativo = '" & mAtivo & "' ")
        str.Append(" WHERE ")
        str.Append(" idFornecedor = '" & mIdFornecedor & "' ")

        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub GravaPROD_FORNE()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("PROD_FORNE")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mIDe & "' ")
        str.Append(", '" & mIdFornecedor & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaPROD_FORNE()
        Dim str As New StringBuilder
        str.Append("Update ")
        str.Append("PROD_FORNE ")
        str.Append("set ")
        str.Append("idProduto = '" & mIDe & "' ")
        str.Append("idFornecedor = '" & mIdFornecedor & "' ")
        str.Append(" WHERE ")
        str.Append(" idProduto = '" & mIDe & "' and idFornecedor= '" & mIdFornecedor & "'")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Enum MenuCategoria As Integer
        Jogo = 1
        Console = 2
        Acessorio = 3
    End Enum

    Public Function ListaTabela(ByVal tabela As String) As DataSet
        Dim str As New StringBuilder
        str.Append(" SELECT * ")
        str.Append("FROM " & tabela & "")
        Dim objCldBancoDados As New cldBD
        Return objCldBancoDados.RetornaDataSet(str.ToString)

    End Function


    Public Function RetornaCod(ByVal tabela As String, ByVal campo As String, ByVal valor As String) As SqlDataReader
        Dim str As String
        str = " SELECT * from" & tabela & " where" & campo & "=" & valor & ""
        Return objCldBD.RetornaDataReader(str)

    End Function

    Public Function RetornaUltimoCod(ByVal tabela As String, ByVal campo As String) As SqlDataReader
        Dim str As String
        str = "Select max(" & tabela & ") as ID from " & campo & ""
        Return objCldBD.RetornaDataReader(str)

    End Function

 



    Public Function ListaProdutos(ByVal strDescricao As String) As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT")
        strQuery.Append(" PRODUTO.EAN,")
        strQuery.Append(" CATEGORIA.nmCategoria,")
        strQuery.Append(" PRODUTO.Nome,")
        strQuery.Append(" PLATAFORMA.nmPlataforma,")
        strQuery.Append(" FABRICANTE.nmFabricante,")
        strQuery.Append(" PRODUTO.vlVenda")
        strQuery.Append(" FROM PRODUTO")
        strQuery.Append(" INNER JOIN  CATEGORIA ON PRODUTO.cdCategoria = CATEGORIA.cdCategoria")
        strQuery.Append(" INNER JOIN  PLATAFORMA ON PRODUTO.cdPlataforma = PLATAFORMA.cdPlataforma")
        strQuery.Append(" INNER JOIN  FABRICANTE ON PRODUTO.cdFabricante = FABRICANTE.cdFabricante")
        strQuery.Append(" WHERE Nome like '%" & strDescricao & "%'  or EAN like '%" & strDescricao & "%'")
        strQuery.Append(" GROUP BY")
        strQuery.Append(" PRODUTO.EAN,")
        strQuery.Append(" CATEGORIA.nmCategoria,")
        strQuery.Append(" PRODUTO.Nome,")
        strQuery.Append(" PLATAFORMA.nmPlataforma,")
        strQuery.Append(" FABRICANTE.nmFabricante,")
        strQuery.Append(" PRODUTO.vlVenda")

        Dim objcldBancoDados As New cldBD()
        Return objcldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function

    Public Function ListaEstoque(ByVal strDescricao As String) As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT * ")
        strQuery.Append(" FROM V_ESTOQUE")
        strQuery.Append(" WHERE Nome like '%" & strDescricao & "%'  or EAN like '%" & strDescricao & "%' or noItem like '%" & strDescricao & "%'")
        Dim objcldBancoDados As New cldBD()
        Return objcldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function

    Public Function CarregarProduto(ByVal cod As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT PRODUTO.EAN , PRODUTO.Nome ,PRODUTO.noMinEst, PRODUTO.noMaxEst, PRODUTO.EstAlvo, PRODUTO.Descricao, PRODUTO.Foto,PRODUTO.cdFabricante, PRODUTO.cdPlataforma, PRODUTO.cdMidia, PRODUTO.cdGenero, PRODUTO.Ativo"
        strQuery = strQuery & " FROM PRODUTO WHERE EAN='" & cod & "'"
        strQuery = strQuery & " GROUP BY PRODUTO.EAN , PRODUTO.Nome ,PRODUTO.noMinEst, PRODUTO.noMaxEst, PRODUTO.EstAlvo, PRODUTO.Descricao, PRODUTO.Foto,PRODUTO.cdFabricante, PRODUTO.cdPlataforma, PRODUTO.cdMidia, PRODUTO.cdGenero, PRODUTO.Ativo"
        Dim objCldBD As New cldBD
        Return objCldBD.RetornaDataReader(strQuery)
    End Function

    

End Class
