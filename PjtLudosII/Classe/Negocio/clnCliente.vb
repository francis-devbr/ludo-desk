Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class clnCliente
    Dim objCldBD As New cldBD
    Private mCodigo As Integer
    Private mNome, mNoCPF, mSexo, mNoCEP, mNoLog, mComplemento, mDDD, mTelefone, mEmail, mDtNasc As String
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

    Public Property Email As String
        Get
            Return mEmail
        End Get
        Set(ByVal value As String)
            mEmail = value
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
        strQuery.Append(" CLIENTE.cdCli,")
        strQuery.Append(" CLIENTE.Nome,")
        strQuery.Append(" dbo.formatarCPF(noCPF) as noCPF,")
        strQuery.Append(" CLIENTE.DDD,")
        strQuery.Append(" dbo.formatarTel(Telefone) as Telefone,")
        strQuery.Append(" CLIENTE.Email,")
        strQuery.Append(" CLIENTE.DtCad,")
        strQuery.Append(" CLIENTE.Ativo")
        strQuery.Append(" FROM CLIENTE")
        strQuery.Append(" WHERE Nome like '%" & strDescricao & "%'  or noCPF like '%" & strDescricao & "%'")
        strQuery.Append(" ORDER BY Nome ")
        Dim objcldBancoDados As New cldBD()
        Return objcldBancoDados.RetornaDataSet(strQuery.ToString)
    End Function

    Public Function ListarCliente(ByVal cod As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT CLIENTE.Nome, CLIENTE.DtNasc, dbo.formatarCPF(noCPF) as noCPF, CLIENTE.Sexo, dbo.formatarCEP(noCEP) as noCEP, CLIENTE.noLog, CLIENTE.Complemento, CLIENTE.DDD,  dbo.formatarTel(Telefone) as Telefone, CLIENTE.Email, CLIENTE.DtCad,CLIENTE.Ativo "
        strQuery = strQuery & "FROM CLIENTE WHERE CLIENTE.cdCli='" & cod & "'"
        Dim objCldBD As New cldBD
        Return objCldBD.RetornaDataReader(strQuery)
    End Function

    Public Sub Gravar()

        Dim strQuery As New StringBuilder
        strQuery.Append("INSERT INTO CLIENTE")
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
        strQuery.Append(", '" & mEmail & "' ")
        strQuery.Append(", '" & mDtCad & "' ")
        strQuery.Append(", '" & mAtivo & "' ")
        strQuery.Append(" ); ")

        objCldBD.ExecutaComando(strQuery.ToString)


    End Sub

    Public Sub Alterar()

        Dim strQuery As New StringBuilder

        strQuery.Append("UPDATE CLIENTE")
        strQuery.Append(" SET ")
        strQuery.Append("Nome = '" & mNome & "'")
        strQuery.Append(", DtNasc = '" & mDtNasc & "'")
        strQuery.Append(", noCPF = '" & mNoCPF & "'")
        strQuery.Append(", Sexo = '" & mSexo & "'")
        strQuery.Append(", noCEP = '" & mNoCEP & "'")
        strQuery.Append(", noLog = '" & mNoLog & "'")
        strQuery.Append(", Complemento = '" & mComplemento & "'")
        strQuery.Append(", DDD = '" & mDDD & "'")
        strQuery.Append(", Telefone = '" & mTelefone & "'")
        strQuery.Append(", Email = '" & mEmail & "'")
        strQuery.Append(", Ativo = '" & mAtivo & "' ")
        strQuery.Append("WHERE ")
        strQuery.Append("cdCli = '" & mCodigo & "'")

        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub

    Public Function CarregaCod(ByVal CPF As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT cdCli FROM CLIENTE WHERE noCPF ='" & CPF & "'"
        Return objCldBD.RetornaDataReader(strQuery.ToString)
    End Function



End Class
