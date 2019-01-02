Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class clnPedCompra
    Dim objCldBD As New cldBD
    Private mDtPedido, mDtRecebimento, mDtEmissao As Date
    Private mCdPedCompra, mCdForne, mCdComprador, mCdFunc, mCdSit As Integer
    Private mVlNF As String
    Private mNoNF As String
    Private mAtivo As Boolean



    Public Property CdPedCompra As Integer
        Get
            Return mcdPedCompra
        End Get
        Set(value As Integer)
            mcdPedCompra = value
        End Set
    End Property

    Public Property DtPedido As Date
        Get
            Return mDtPedido
        End Get
        Set(value As Date)
            mDtPedido = value
        End Set
    End Property

    Public Property DtRecebimento As Date
        Get
            Return mDtRecebimento
        End Get
        Set(value As Date)
            mDtRecebimento = value
        End Set
    End Property

    Public Property DtEmissao As Date
        Get
            Return mDtEmissao
        End Get
        Set(value As Date)
            mDtEmissao = value
        End Set
    End Property

    Public Property VlNF As String
        Get
            Return mVlNF
        End Get
        Set(value As String)
            mVlNF = value
        End Set
    End Property

    Public Property CdForne As Integer
        Get
            Return mCdForne
        End Get
        Set(value As Integer)
            mCdForne = value
        End Set
    End Property

    Public Property CdFunc As Integer
        Get
            Return mCdFunc
        End Get
        Set(value As Integer)
            mCdFunc = value
        End Set
    End Property

    Public Property CdComprador As Integer
        Get
            Return mCdComprador
        End Get
        Set(value As Integer)
            mCdComprador = value
        End Set
    End Property

    Public Property CdSit As Integer
        Get
            Return mCdSit
        End Get
        Set(value As Integer)
            mCdSit = value
        End Set
    End Property

    Public Property NoNF As String
        Get
            Return mNoNF
        End Get
        Set(value As String)
            mNoNF = value
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


    Public Sub GravarPDC()

        Dim strQuery As New StringBuilder
        strQuery.Append("INSERT INTO ")
        strQuery.Append("PEDCOMPRA ")
        strQuery.Append(" ( ")
        strQuery.Append(" cdForne,")
        strQuery.Append(" idUsuario,")
        strQuery.Append(" dtPedido,")
        strQuery.Append(" cdSit,")
        strQuery.Append(" Ativo")
        strQuery.Append(" ) ")
        strQuery.Append("VALUES ")
        strQuery.Append("(")
        strQuery.Append(" '" & mCdForne & "' ")
        strQuery.Append(", '" & mCdComprador & "' ")
        strQuery.Append(", '" & mDtPedido & "' ")
        strQuery.Append(", '" & mCdSit & "' ")
        strQuery.Append(", '" & mAtivo & "' ")
        strQuery.Append(" );")

        Dim cldBD As New cldBD
        cldBD.ExecutaComando(strQuery.ToString)


    End Sub

    Public Sub ConcluirPDC()

        Dim strQuery As New StringBuilder

        strQuery.Append(" UPDATE PEDCOMPRA")
        strQuery.Append(" SET ")
        strQuery.Append(" cdSit = '" & mCdSit & "'")
        strQuery.Append(", Ativo = '" & mAtivo & "'")
        strQuery.Append(" WHERE ")
        strQuery.Append(" cdPedCompra = '" & mCdPedCompra & "'")
        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub

    Public Sub GravarNF()

        Dim strQuery As New StringBuilder
        strQuery.Append("INSERT INTO ")
        strQuery.Append("ENTNF ")
        strQuery.Append(" ( ")
        strQuery.Append(" cdPedCompra,")
        strQuery.Append(" cdForne,")
        strQuery.Append(" dtRecebimento,")
        strQuery.Append(" noNF,")
        strQuery.Append(" vlNF,")
        strQuery.Append(" dtEmissao ,")
        strQuery.Append(" idUsuario")
        strQuery.Append(" ) ")
        strQuery.Append("VALUES ")
        strQuery.Append("(")
        strQuery.Append(" '" & mcdPedCompra & "' ")
        strQuery.Append(", '" & mCdForne & "' ")
        strQuery.Append(", '" & mDtRecebimento & "' ")
        strQuery.Append(", '" & mNoNF & "' ")
        strQuery.Append(", '" & mVlNF & "' ")
        strQuery.Append(", '" & mDtEmissao & "' ")
        strQuery.Append(", '" & mCdFunc & "' ")
        strQuery.Append(" );")

        Dim cldBD As New cldBD
        cldBD.ExecutaComando(strQuery.ToString)


    End Sub

    Public Sub Excluir(ByVal codigo As Integer)

        Dim strQuery As New StringBuilder
        strQuery.Append(" DELETE FROM PEDCOMPRA ")
        strQuery.Append(" WHERE cdPedCompra= '" & codigo & "'")
        objCldBD.ExecutaComando(strQuery.ToString)

    End Sub


    Public Function CarregaCodPDC(ByVal cdF As String, ByVal cdForn As String, ByVal DtP As Date) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT cdPedCompra FROM PEDCOMPRA WHERE idUsuario ='" & cdF & "' and cdForne ='" & cdForn & "' and dtPedido ='" & DtP & "'"
        Dim objCldBD As New cldBD
        Return objCldBD.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CarregaCodNF(ByVal noNF As String, ByVal cdForn As String, ByVal DtP As Date) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT cdEntNF FROM ENTNF WHERE noNF ='" & noNF & "' and cdForne ='" & cdForn & "' and dtRecebimento ='" & DtP & "'"
        Dim objCldBD As New cldBD
        Return objCldBD.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function CarregaPedido(ByVal cnpj As String, ByVal Pedido As Integer) As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT PRODUTO.cdProduto, PRODUTO.noItem, PRODUTO.EAN, PRODUTO.Nome, DET_PEDCOMPRA.QTDE, DET_PEDCOMPRA.CustoUnit, DET_PEDCOMPRA.Entregue")
        strQuery.Append(" FROM PEDCOMPRA INNER JOIN DET_PEDCOMPRA ON PEDCOMPRA.cdPedCompra = DET_PEDCOMPRA.cdPedCompra INNER JOIN PRODUTO ON DET_PEDCOMPRA.cdProduto = PRODUTO.cdProduto")
        strQuery.Append(" WHERE PEDCOMPRA.cdForne ='" & cnpj & "' and PEDCOMPRA.cdPedCompra ='" & Pedido & "' AND DET_PEDCOMPRA.Entregue = 0")
        strQuery.Append(" GROUP BY PRODUTO.cdProduto, PEDCOMPRA.Ativo, DET_PEDCOMPRA.cdProduto, DET_PEDCOMPRA.CustoUnit, DET_PEDCOMPRA.QTDE, PRODUTO.Nome, PRODUTO.EAN, PRODUTO.noItem, DET_PEDCOMPRA.Entregue")
        Dim objCldBancoDados As New cldBD
        Return objCldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function


    Public Function ListaPDC(ByVal strDescricao As String, ByVal PED As String) As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append("SELECT")
        strQuery.Append(" PEDCOMPRA.cdPedCompra,")
        strQuery.Append(" FORNECEDOR.RazaoSocial,")
        strQuery.Append(" FORNECEDOR.NmFantasia,")
        strQuery.Append(" PEDCOMPRA.dtPedido,")
        strQuery.Append(" SITUACAO.Situacao")
        strQuery.Append(" FROM PEDCOMPRA INNER JOIN FORNECEDOR ON PEDCOMPRA.cdForne=FORNECEDOR.cdForne LEFT JOIN DET_PEDCOMPRA ON PEDCOMPRA.cdPedCompra= DET_PEDCOMPRA.cdPedCompra INNER JOIN SITUACAO ON PEDCOMPRA.cdSit=SITUACAO.cdSit")
        strQuery.Append(" WHERE FORNECEDOR.CNPJ ='" & strDescricao & "' or PEDCOMPRA.cdPedCompra = '" & PED & "'")
        strQuery.Append(" GROUP BY PEDCOMPRA.cdPedCompra, FORNECEDOR.RazaoSocial, FORNECEDOR.NmFantasia, PEDCOMPRA.dtPedido, SITUACAO.Situacao")
        Dim objcldBancoDados As New cldBD()
        Return objcldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function
End Class
