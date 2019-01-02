Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class clnDetPDV

    Private mCodigo, mCdPDV, mCdProduto, mQTDE As Integer
    Private mSubTotal As Decimal

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

    Public Property SubTotal As Decimal
        Get
            Return mSubTotal
        End Get
        Set(ByVal value As Decimal)
            mSubTotal = value
        End Set
    End Property

    Public Sub Gravar()
        Dim strQuery As New StringBuilder
        strQuery.Append(" INSERT INTO DET_PDV ")
        strQuery.Append(" ( ")
        strQuery.Append(" cdPDV ")
        strQuery.Append(", cdProduto")
        strQuery.Append(", QTDE")
        strQuery.Append(", SubTotal")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & mCdPDV & "' ")
        strQuery.Append(", '" & mCdProduto & "' ")
        strQuery.Append(", '" & mQTDE & "' ")
        strQuery.Append(", '" & mSubTotal & "' ")
        strQuery.Append(" ); ")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub AtivarDesativar()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE DET_PDV ")
        strQuery.Append(" SET ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdDetPDV = '" & mCodigo & "' ")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub


End Class
