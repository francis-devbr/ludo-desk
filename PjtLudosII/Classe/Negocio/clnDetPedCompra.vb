Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class clnDetPedCompra
    Private mCdDetPedCompra, mCdPedCompra, mCdProduto, mQTDE, mCdEntNF As Integer
    Private mCustoUnit As String
    Private mEntregue As Boolean
    Private mAtivo As Boolean

    Public Property CdDetPedCompra As Integer
        Get
            Return mCdDetPedCompra
        End Get
        Set(ByVal value As Integer)
            mCdDetPedCompra = value
        End Set
    End Property


    Public Property CdEntNF As Integer
        Get
            Return mCdEntNF
        End Get
        Set(ByVal value As Integer)
            mCdEntNF = value
        End Set
    End Property

    Public Property CdPedCompra As Integer
        Get
            Return mCdPedCompra
        End Get
        Set(ByVal value As Integer)
            mCdPedCompra = value
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

    Public Property CustoUnit As String
        Get
            Return mCustoUnit
        End Get
        Set(ByVal value As String)
            mCustoUnit = value
        End Set
    End Property

    Public Property Entregue As Boolean
        Get
            Return mEntregue
        End Get
        Set(value As Boolean)
            mEntregue = value
        End Set
    End Property
    Public Property Ativo As Boolean
        Get
            Return mAtivo
        End Get
        Set(value As Boolean)
            mAtivo = value
        End Set
    End Property

    Public Sub GravarDETPDC()
        Dim strQuery As New StringBuilder
        strQuery.Append(" INSERT INTO DET_PEDCOMPRA ")
        strQuery.Append(" ( ")
        strQuery.Append(" cdPedCompra ")
        strQuery.Append(", cdProduto")
        strQuery.Append(", QTDE")
        strQuery.Append(", CustoUnit")
        strQuery.Append(", Entregue")
        strQuery.Append(", Ativo ")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & mCdPedCompra & "' ")
        strQuery.Append(", '" & mCdProduto & "' ")
        strQuery.Append(", '" & mQTDE & "' ")
        strQuery.Append(", '" & mCustoUnit & "' ")
        strQuery.Append(", '" & mEntregue & "' ")
        strQuery.Append(", '" & mAtivo & "' ")
        strQuery.Append(" ); ")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub

    Public Sub GravarDETENNF()
        Dim strQuery As New StringBuilder
        strQuery.Append(" INSERT INTO DET_ENTNF ")
        strQuery.Append(" ( ")
        strQuery.Append(" cdEntNF ")
        strQuery.Append(", cdProduto")
        strQuery.Append(", QTDE")
        strQuery.Append(", CustoUnit")
        strQuery.Append(" ) ")
        strQuery.Append(" VALUES ( ")
        strQuery.Append(" '" & mCdEntNF & "' ")
        strQuery.Append(", '" & mCdProduto & "' ")
        strQuery.Append(", '" & mQTDE & "' ")
        strQuery.Append(", '" & mCustoUnit & "' ")
        strQuery.Append(" ); ")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub


    Public Sub Excluir(ByVal codigo As Integer)
        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM DET_PEDCOMPRA ")
        strQuery.Append(" WHERE cdPedCompra= '" & codigo & "'")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)


    End Sub

    Public Sub EntradaNF_Alterar()

        Dim strQuery As New StringBuilder

        strQuery.Append(" UPDATE DET_PEDCOMPRA ")
        strQuery.Append(" SET ")
        strQuery.Append(" QTDE = '" & mQTDE & "' ")
        strQuery.Append(", CustoUnit = '" & mCustoUnit & "' ")
        strQuery.Append(", Entregue = '" & mEntregue & "' ")
        strQuery.Append(", Ativo = '" & mAtivo & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdPedCompra = '" & mCdPedCompra & "' and cdProduto ='" & mCdProduto & "'")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub

    Public Sub N_ENTREGUE_NF_Alterar()

        Dim strQuery As New StringBuilder

        strQuery.Append(" UPDATE DET_PEDCOMPRA ")
        strQuery.Append(" SET ")
        strQuery.Append(" Entregue = '" & mEntregue & "' ")
        strQuery.Append(", Ativo = '" & mAtivo & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdPedCompra = '" & mCdPedCompra & "' and cdProduto ='" & mCdProduto & "'")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub

End Class
