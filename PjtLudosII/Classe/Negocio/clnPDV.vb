Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class clnPDV
    Private mDestinatario, mNoCEP, mNoLog, mComplemento, mObs As String
    Private mDtPedido, mDtEnvio As Date
    Private mCodigo, mCdFunc, mCdCli, mCdTrans, mCdSitPDV, mCdTPvenda, mCdFormaPgto As Integer
    Private mTxEnvio As Decimal
    Private mAtivo As Boolean

    Public Property Codigo As Integer
        Get
            Return mCodigo
        End Get
        Set(ByVal value As Integer)
            mCodigo = value
        End Set
    End Property

    Public Property CdFunc As Integer
        Get
            Return mCdFunc
        End Get
        Set(ByVal value As Integer)
            mCdFunc = value
        End Set
    End Property

    Public Property CdCli As Integer
        Get
            Return mCdCli
        End Get
        Set(ByVal value As Integer)
            mCdCli = value
        End Set
    End Property

    Public Property CdTrans As Integer
        Get
            Return mCdTrans
        End Get
        Set(ByVal value As Integer)
            mCdTrans = value
        End Set
    End Property

    Public Property CdSitPDV As Integer
        Get
            Return mCdSitPDV
        End Get
        Set(ByVal value As Integer)
            mCdSitPDV = value
        End Set
    End Property

    Public Property CdTPvenda As Integer
        Get
            Return mCdTPvenda
        End Get
        Set(ByVal value As Integer)
            mCdTPvenda = value
        End Set
    End Property

    Public Property CdFormaPgto As Integer
        Get
            Return mCdFormaPgto
        End Get
        Set(ByVal value As Integer)
            mCdFormaPgto = value
        End Set
    End Property

    Public Property DtPedido As Date
        Get
            Return mDtPedido
        End Get
        Set(ByVal value As Date)
            mDtPedido = value
        End Set
    End Property

    Public Property DtEnvio As Date
        Get
            Return mDtEnvio
        End Get
        Set(ByVal value As Date)
            mDtEnvio = value
        End Set
    End Property

    Public Property Destinatario As String
        Get
            Return mDestinatario
        End Get
        Set(ByVal value As String)
            mDestinatario = value
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

    Public Property Obs As String
        Get
            Return mObs
        End Get
        Set(ByVal value As String)
            mObs = value
        End Set
    End Property

    Public Property TxEnvio As Decimal
        Get
            Return mTxEnvio
        End Get
        Set(ByVal value As Decimal)
            mTxEnvio = value
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

    Public Sub GravarPDVBalcaoCli()


        Dim strQuery As New StringBuilder
        strQuery.Append("INSERT INTO ")
        strQuery.Append("PDV ")
        strQuery.Append(" ( ")
        strQuery.Append(" cdFunc,")
        strQuery.Append(" cdCli,")
        strQuery.Append(" dtPedido,")
        strQuery.Append(" cdSit,")
        strQuery.Append(" cdTPvenda,")
        strQuery.Append(" Ativo")
        strQuery.Append(" ) ")
        strQuery.Append("VALUES ")
        strQuery.Append("(")
        strQuery.Append(" '" & mCdFunc & "' ")
        strQuery.Append(", '" & mCdCli & "' ")
        strQuery.Append(", '" & mDtPedido & "' ")
        strQuery.Append(", '" & mCdSitPDV & "' ")
        strQuery.Append(", '" & mCdTPvenda & "' ")
        strQuery.Append(", '" & mAtivo & "' ")
        strQuery.Append(" );")


        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub

    Public Sub GravarPDVBalcao()


        Dim strQuery As New StringBuilder
        strQuery.Append("INSERT INTO ")
        strQuery.Append("PDV ")
        strQuery.Append(" ( ")
        strQuery.Append(" cdFunc,")
        strQuery.Append(" dtPedido,")
        strQuery.Append(" cdSit,")
        strQuery.Append(" cdTPvenda,")
        strQuery.Append(" Ativo")
        strQuery.Append(" ) ")
        strQuery.Append("VALUES ")
        strQuery.Append("(")
        strQuery.Append(" '" & mCdFunc & "' ")
        strQuery.Append(", '" & mDtPedido & "' ")
        strQuery.Append(", '" & mCdSitPDV & "' ")
        strQuery.Append(", '" & mCdTPvenda & "' ")
        strQuery.Append(", '" & mAtivo & "' ")
        strQuery.Append(" );")

      
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub


    Public Sub Gravar()

        Dim strQuery As New StringBuilder
        strQuery.Append("INSERT INTO PDV")
        strQuery.Append(" VALUES ")
        strQuery.Append("(")
        strQuery.Append(" '" & mCdFunc & "' ")
        strQuery.Append(", '" & mCdCli & "' ")
        strQuery.Append(", '" & mDtPedido & "' ")
        strQuery.Append(", '" & mDtEnvio & "' ")
        strQuery.Append(", '" & mCdTrans & "' ")
        strQuery.Append(", '" & mDestinatario & "' ")
        strQuery.Append(", '" & mNoCEP & "' ")
        strQuery.Append(", '" & mNoLog & "' ")
        strQuery.Append(", '" & mComplemento & "' ")
        strQuery.Append(", '" & mTxEnvio & "' ")
        strQuery.Append(", '" & mObs & "' ")
        strQuery.Append(", '" & mCdSitPDV & "' ")
        strQuery.Append(", '" & mCdTPvenda & "' ")
        strQuery.Append(", '" & mCdFormaPgto & "' ")
        strQuery.Append(", '" & mAtivo & "' ")
        strQuery.Append(" ); ")

        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub

    Public Sub AlterarSPDV()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE PDV ")
        strQuery.Append(" SET ")
        strQuery.Append(" cdSit = '" & mCdSitPDV & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdPDV = '" & mCodigo & "' ")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub PedidoFaturado()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE PDV ")
        strQuery.Append(" SET ")
        strQuery.Append(" dtEnvio = '" & mDtEnvio & "' ")
        strQuery.Append(" cdTransp = '" & mCdTrans & "' ")
        strQuery.Append(" Destinatario = '" & mDestinatario & "' ")
        strQuery.Append(" noCEP = '" & mNoCEP & "' ")
        strQuery.Append(" noLog = '" & mNoLog & "' ")
        strQuery.Append(" Complemento = '" & mComplemento & "' ")
        strQuery.Append(" txEnvio = '" & mTxEnvio & "' ")
        strQuery.Append(" obs = '" & mObs & "' ")
        strQuery.Append(" cdSit = '" & mCdSitPDV & "' ")
        strQuery.Append(" ,cdFormaPgto = '" & mCdFormaPgto & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdPDV = '" & mCodigo & "' ")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub AtivarDesativar()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE PDV ")
        strQuery.Append(" SET ")
        strQuery.Append(" Ativo = '" & mAtivo & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdPDV = '" & mCodigo & "' ")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function CarregaCod(ByVal cdF As String, ByVal DtP As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT cdPDV FROM PDV WHERE cdFunc ='" & cdF & "' and dtPedido ='" & DtP & "'"
        Dim objCldBD As New cldBD
        Return objCldBD.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CarregaCliente() As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cdCli, Nome ")
        strQuery.Append(" FROM CLIENTE ")
        strQuery.Append(" ORDER BY Nome ")

        Dim objCldBancoDados As New cldBD
        Return objCldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function

    Public Function CarregaFuncionario() As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cdCli, Nome ")
        strQuery.Append(" FROM CLIENTE ")
        strQuery.Append(" ORDER BY Nome ")

        Dim objCldBancoDados As New cldBD
        Return objCldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function
    Public Sub Excluir(ByVal codigo As Integer)

        Dim objCldBD As New cldBD
        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM PDV ")
        strQuery.Append(" WHERE cdPDV= '" & codigo & "'")
        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub
   
End Class
