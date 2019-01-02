Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class clnMovEst
    Private mCodigo, mCdPDV, mCdProduto, mQTDE, mCdTPMe, mCdDetMe, mCdEntNF As Integer
    Private mAtivo As Boolean
    Private mDtME, mDtMod As Date
    Public Property CdEntNF As Integer
        Get
            Return mCdEntNF
        End Get
        Set(ByVal value As Integer)
            mCdEntNF = value
        End Set
    End Property
    Public Property Codigo As Integer
        Get
            Return mCodigo
        End Get
        Set(ByVal value As Integer)
            mCodigo = value
        End Set
    End Property

    Public Property CdPDV As Integer
        Get
            Return mCdPDV
        End Get
        Set(ByVal value As Integer)
            mCdPDV = value
        End Set
    End Property

    Public Property CdProduto As Integer
        Get
            Return mCdProduto
        End Get
        Set(ByVal value As Integer)
            mCdProduto = value
        End Set
    End Property

    Public Property QTDE As Integer
        Get
            Return mQTDE
        End Get
        Set(ByVal value As Integer)
            mQTDE = value
        End Set
    End Property

    Public Property CdTPMe As Integer
        Get
            Return mCdTPMe
        End Get
        Set(ByVal value As Integer)
            mCdTPMe = value
        End Set
    End Property

    Public Property CdDetMe As Integer
        Get
            Return mCdDetMe
        End Get
        Set(ByVal value As Integer)
            mCdDetMe = value
        End Set
    End Property

    Public Property DtME As Date
        Get
            Return mDtME
        End Get
        Set(ByVal value As Date)
            mDtME = (value)
        End Set
    End Property

    Public Property DtMod As Date
        Get
            Return mDtMod
        End Get
        Set(ByVal value As Date)
            mDtMod = (value)
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

    Public Sub Gravar()
        Dim strQuery As New StringBuilder
        strQuery.Append(" INSERT INTO MOV_EST ")
        strQuery.Append(" ( ")
        strQuery.Append(" cdProduto")
        strQuery.Append(", QTDE")
        strQuery.Append(", cdTPMe")
        strQuery.Append(", cdDetMe")
        strQuery.Append(", DtME")
        strQuery.Append(", DtMod")
        strQuery.Append(", cdPDV")
        strQuery.Append(", cdEntNF")
        strQuery.Append(", Ativo")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & mCdProduto & "' ")
        strQuery.Append(", '" & mQTDE & "' ")
        strQuery.Append(", '" & mCdTPMe & "' ")
        strQuery.Append(", '" & mCdDetMe & "' ")
        strQuery.Append(", '" & mDtME & "' ")
        strQuery.Append(", '" & mDtMod & "' ")
        strQuery.Append(", '" & mCdPDV & "' ")
        strQuery.Append(", '" & mCdEntNF & "' ")
        strQuery.Append(", '" & mAtivo & "' ")
        strQuery.Append(" ); ")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub Excluir(ByVal codigo As Integer)
        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM MOV_EST ")
        strQuery.Append(" WHERE cdPDV= '" & codigo & "'")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub AlterarTPME()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE MOV_EST ")
        strQuery.Append(" SET ")
        strQuery.Append(" cdTPMe = '" & mCdTPMe & "' ")
        strQuery.Append(", DtMod = '" & mDtMod & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdPDV = '" & mCdPDV & "'")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub AlterarMOVDETPDV()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE MOV_EST ")
        strQuery.Append(" SET ")
        strQuery.Append(" QTDE = '" & mQTDE & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdPDV = '" & mCdPDV & "' and  cdProduto = '" & CdProduto & "' ")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub
End Class
