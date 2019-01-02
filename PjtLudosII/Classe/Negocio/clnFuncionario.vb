Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class clnFuncionario

    Dim objCldBD As New cldBD
    Private mCodigo As Integer
    Private mNome, mNoCPF, mSexo, mNoCEP, mNoLog, mComplemento, mDDD, mTelefone, mFoto, mDtEntrada, mDtNasc As String
    Private mCdCargo As Integer
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

    Public Property Nome As String
        Get
            Return mNome
        End Get
        Set(ByVal value As String)
            mNome = value
        End Set
    End Property

    Public Property DtNasc As String
        Get
            Return mDtNasc
        End Get
        Set(ByVal value As String)
            mDtNasc = value
        End Set
    End Property

    Public Property NoCPF As String
        Get
            Return mNoCPF
        End Get
        Set(ByVal value As String)
            mNoCPF = (value)
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return mSexo
        End Get
        Set(ByVal value As String)
            mSexo = value
        End Set
    End Property

    Public Property NoCEP As String
        Get
            Return mNoCEP
        End Get
        Set(ByVal value As String)
            mNoCEP = value
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

    Public Property DtEntrada As String
        Get
            Return mDtEntrada
        End Get
        Set(ByVal value As String)
            mDtEntrada = value
        End Set
    End Property

    Public Property CdCargo As Integer
        Get
            Return mCdCargo
        End Get
        Set(ByVal value As Integer)
            mCdCargo = value
        End Set
    End Property

    Public Property Foto As String
        Get
            Return mFoto
        End Get
        Set(ByVal value As String)
            mFoto = value
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
        strQuery.Append(" SELECT FUNCIONARIO.cdFunc, FUNCIONARIO.Nome, dbo.formatarCPF(noCPF) as noCPF, FUNCIONARIO.Sexo, CARGO.nmCargo, FUNCIONARIO.DDD,  dbo.formatarTel(Telefone) as Telefone, FUNCIONARIO.DtEntrada, FUNCIONARIO.Ativo ")
        strQuery.Append(" FROM FUNCIONARIO INNER JOIN CARGO ON FUNCIONARIO.cdCargo = CARGO.cdCargo ")
        strQuery.Append(" WHERE Nome like '%" & strDescricao & "%' or noCPF like '%" & strDescricao & "%'")
        strQuery.Append(" ORDER BY Nome ")
        Dim objcldBancoDados As New cldBD()
        Return objcldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function

    Public Function ListarFunc(ByVal cod As String) As SqlDataReader 
        Dim strQuery As String
        strQuery = "SELECT FUNCIONARIO.Nome, FUNCIONARIO.DtNasc, dbo.formatarCPF(noCPF) as noCPF, FUNCIONARIO.Sexo, dbo.formatarCEP(noCEP) as noCEP, FUNCIONARIO.noLog, FUNCIONARIO.Complemento, FUNCIONARIO.DDD,  dbo.formatarTel(Telefone) as Telefone, FUNCIONARIO.DtEntrada, FUNCIONARIO.CdCargo, FUNCIONARIO.Foto, FUNCIONARIO.DtCad, FUNCIONARIO.Ativo "
        strQuery = strQuery & "FROM FUNCIONARIO WHERE FUNCIONARIO.cdFunc='" & cod & "'"
        Dim objCldBD As New cldBD
        Return objCldBD.RetornaDataReader(strQuery)
    End Function

    Public Sub Gravar()

        Dim strQuery As New StringBuilder
        strQuery.Append("INSERT INTO FUNCIONARIO")
        strQuery.Append(" VALUES ")
        strQuery.Append("(")
        strQuery.Append(" '" & mNome & "' ")
        strQuery.Append(", '" & mDtNasc & "' ")
        strQuery.Append(", '" & mNoCPF & "' ")
        strQuery.Append(", '" & mSexo & "' ")
        strQuery.Append(", '" & mNoCEP & "' ")
        strQuery.Append(", '" & mNoLog & "' ")
        strQuery.Append(", '" & mComplemento & "' ")
        strQuery.Append(", '" & mDDD & "' ")
        strQuery.Append(", '" & mTelefone & "' ")
        strQuery.Append(", '" & mDtEntrada & "' ")
        strQuery.Append(", '" & mCdCargo & "' ")
        strQuery.Append(", '" & mFoto & "' ")
        strQuery.Append(", '" & mDtCad & "' ")
        strQuery.Append(", '" & mAtivo & "' ")
        strQuery.Append(" ); ")

        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub

    Public Sub Alterar()

        Dim strQuery As New StringBuilder

        strQuery.Append(" UPDATE FUNCIONARIO ")
        strQuery.Append(" SET ")
        strQuery.Append("  Nome = '" & mNome & "' ")
        strQuery.Append(", DtNasc = '" & mDtNasc & "' ")
        strQuery.Append(", noCPF = '" & mNoCPF & "' ")
        strQuery.Append(", Sexo = '" & mSexo & "' ")
        strQuery.Append(", noCEP = '" & mNoCEP & "' ")
        strQuery.Append(", noLog = '" & mNoLog & "' ")
        strQuery.Append(", Complemento = '" & mComplemento & "' ")
        strQuery.Append(", DDD = '" & mDDD & "' ")
        strQuery.Append(", Telefone = '" & mTelefone & "' ")
        strQuery.Append(", DtEntrada = '" & mDtEntrada & "' ")
        strQuery.Append(", CdCargo = '" & mCdCargo & "' ")
        strQuery.Append(", Foto = '" & mFoto & "' ")
        strQuery.Append(", Ativo = '" & mAtivo & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdFunc = '" & mCodigo & "' ")

        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub

    Public Function CarregaCod(ByVal noCPF As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT cdFunc FROM FUNCIONARIO WHERE noCPF ='" & noCPF & "'"
        Return objCldBD.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CarregaCargo() As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cdCargo, nmCargo ")
        strQuery.Append(" FROM CARGO ")
        strQuery.Append(" ORDER BY nmCargo ")

        Dim objCldBancoDados As New cldBD
        Return objCldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function



End Class
