Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class clnFornecedor
    Dim objCldBD As New cldBD
    Private mCodigo As Integer
    Private mRazaoSocial, mNmFantasia, mCNPJ, mCEP, mNoLog, mComplemento, mDDD, mTelefone, mHomePage, mContato, mEmail, mDDDCel, mCelular As String
    Private mAtivo As Boolean
    Private mDtCad As Date

    Public Property Codigo As Integer
        Get
            Return mCodigo
        End Get
        Set(ByVal value As Integer)
            mCodigo = value
        End Set
    End Property

    Public Property RazaoSocial As String
        Get
            Return mRazaoSocial
        End Get
        Set(ByVal value As String)
            mRazaoSocial = value
        End Set
    End Property

    Public Property NmFantasia As String
        Get
            Return mNmFantasia
        End Get
        Set(ByVal value As String)
            mNmFantasia = (value)
        End Set
    End Property

    Public Property CNPJ As String
        Get
            Return mCNPJ
        End Get
        Set(ByVal value As String)
            mCNPJ = value
        End Set
    End Property


    Public Property CEP As String
        Get
            Return mCEP
        End Get
        Set(ByVal value As String)
            mCEP = value
        End Set
    End Property

    Public Property NoLog As String
        Get
            Return mNoLog
        End Get
        Set(ByVal value As String)
            mNoLog = value
        End Set
    End Property

    Public Property Complemento As String
        Get
            Return mComplemento
        End Get
        Set(ByVal value As String)
            mComplemento = value
        End Set
    End Property

    Public Property DDD As String
        Get
            Return mDDD
        End Get
        Set(ByVal value As String)
            mDDD = value
        End Set
    End Property

    Public Property Telefone As String
        Get
            Return mTelefone
        End Get
        Set(ByVal value As String)
            mTelefone = value
        End Set
    End Property

    Public Property HomePage As String
        Get
            Return mHomePage
        End Get
        Set(ByVal value As String)
            mHomePage = value
        End Set
    End Property

    Public Property Contato As String
        Get
            Return mContato
        End Get
        Set(ByVal value As String)
            mContato = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return mEmail
        End Get
        Set(ByVal value As String)
            mEmail = value
        End Set
    End Property

    Public Property DDDCel As String
        Get
            Return mDDDCel
        End Get
        Set(ByVal value As String)
            mDDDCel = value
        End Set
    End Property

    Public Property Celular As String
        Get
            Return mCelular
        End Get
        Set(ByVal value As String)
            mCelular = value
        End Set
    End Property

    Public Property DtCad As Date
        Get
            Return mDtCad
        End Get
        Set(ByVal value As Date)
            mDtCad = value
        End Set
    End Property

    Public Property Ativo As Boolean
        Get
            Return mAtivo
        End Get
        Set(ByVal value As Boolean)
            mAtivo = value
        End Set
    End Property

    Public Function Lista(ByVal strDescricao As String) As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append("SELECT")
        strQuery.Append(" FORNECEDOR.cdForne,")
        strQuery.Append(" FORNECEDOR.RazaoSocial,")
        strQuery.Append(" FORNECEDOR.NmFantasia,")
        strQuery.Append(" dbo.formatarCNPJ(CNPJ) as CNPJ,")
        strQuery.Append(" dbo.formatarCEP(CEP) as CEP,")
        strQuery.Append(" FORNECEDOR.noLog,")
        strQuery.Append(" FORNECEDOR.Complemento,")
        strQuery.Append(" FORNECEDOR.DDD,")
        strQuery.Append(" dbo.formatarTel(Telefone) as Telefone,")
        strQuery.Append(" FORNECEDOR.HomePage,")
        strQuery.Append(" FORNECEDOR.Contato,")
        strQuery.Append(" FORNECEDOR.Email,")
        strQuery.Append(" FORNECEDOR.DDDCel,")
        strQuery.Append(" dbo.formatarTel(Celular) as Celular,")
        strQuery.Append(" FORNECEDOR.DtCad,")
        strQuery.Append(" FORNECEDOR.Ativo")
        strQuery.Append(" FROM FORNECEDOR")
        strQuery.Append(" WHERE RazaoSocial like '%" & strDescricao & "%'  or CNPJ like '%" & strDescricao & "%'")
        strQuery.Append(" ORDER BY NmFantasia ")
        Dim objcldBancoDados As New cldBD()
        Return objcldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function

    Public Function ListarFORNECEDOR(ByVal cod As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT FORNECEDOR.cdForne, FORNECEDOR.RazaoSocial, FORNECEDOR.NmFantasia, dbo.formatarCNPJ(CNPJ) as CNPJ, dbo.formatarCEP(CEP) as CEP, FORNECEDOR.noLog, FORNECEDOR.Complemento, FORNECEDOR.DDD,  dbo.formatarTel(Telefone) as Telefone, FORNECEDOR.HomePage, FORNECEDOR.Contato, FORNECEDOR.Email, FORNECEDOR.DDDCel, dbo.formatarTel(Celular) as Celular, FORNECEDOR.DtCad, FORNECEDOR.Ativo "
        strQuery = strQuery & "FROM FORNECEDOR WHERE FORNECEDOR.cdForne='" & cod & "'"
        Dim objCldBD As New cldBD
        Return objCldBD.RetornaDataReader(strQuery)
    End Function

    Public Sub Gravar()

        Dim strQuery As New StringBuilder
        strQuery.Append("INSERT INTO FORNECEDOR")
        strQuery.Append(" VALUES ")
        strQuery.Append("(")
        strQuery.Append(" '" & mRazaoSocial & "' ")
        strQuery.Append(", '" & mNmFantasia & "' ")
        strQuery.Append(", '" & mCNPJ & "' ")
        strQuery.Append(", '" & mCEP & "' ")
        strQuery.Append(", '" & mNoLog & "' ")
        strQuery.Append(", '" & mComplemento & "' ")
        strQuery.Append(", '" & mDDD & "' ")
        strQuery.Append(", '" & mTelefone & "' ")
        strQuery.Append(", '" & mHomePage & "' ")
        strQuery.Append(", '" & mContato & "' ")
        strQuery.Append(", '" & mEmail & "' ")
        strQuery.Append(", '" & mDDDCel & "' ")
        strQuery.Append(", '" & mCelular & "' ")
        strQuery.Append(", '" & mDtCad & "' ")
        strQuery.Append(", '" & mAtivo & "' ")
        strQuery.Append(" ); ")

        objCldBD.ExecutaComando(strQuery.ToString)


    End Sub

    Public Sub Alterar()

        Dim strQuery As New StringBuilder

        strQuery.Append(" UPDATE FORNECEDOR ")
        strQuery.Append(" SET ")
        strQuery.Append("  RazaoSocial = '" & mRazaoSocial & "' ")
        strQuery.Append(", NmFantasia = '" & mNmFantasia & "' ")
        strQuery.Append(", CNPJ = '" & mCNPJ & "' ")
        strQuery.Append(", CEP = '" & mCEP & "' ")
        strQuery.Append(", noLog = '" & mNoLog & "' ")
        strQuery.Append(", Complemento = '" & mComplemento & "' ")
        strQuery.Append(", DDD = '" & mDDD & "' ")
        strQuery.Append(", Telefone = '" & mTelefone & "' ")
        strQuery.Append(", HomePage = '" & mHomePage & "' ")
        strQuery.Append(", Contato = '" & mContato & "' ")
        strQuery.Append(", Email = '" & mEmail & "' ")
        strQuery.Append(", DDDCel = '" & mDDDCel & "' ")
        strQuery.Append(", Celular = '" & mCelular & "' ")
        strQuery.Append(", Ativo = '" & mAtivo & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdForne = '" & mCodigo & "' ")

        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub

    Public Function CarregaCod(ByVal CNPJ As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT cdForne FROM FORNECEDOR WHERE CNPJ ='" & CNPJ & "'"
        Return objCldBD.RetornaDataReader(strQuery.ToString)
    End Function


End Class
