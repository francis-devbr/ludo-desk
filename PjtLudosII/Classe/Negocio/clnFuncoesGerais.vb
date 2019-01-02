Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions







Public Class clnFuncoesGerais


    Public Function ExpurgaApostrofe(texto)
        ExpurgaApostrofe = replace(texto, "'", "''")
    End Function



    Private dadosArray() As String = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44", _
                                     "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", _
                                     "999.999.999-99"}
    Private Const msgErro As String = "Dados Inválidos"


    Function validaEmail(ByVal email As String) As Boolean

        ' Pattern ou mascara de verificação
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"

        ' Verifica se o email corresponde a pattern/mascara
        Dim emailAddressMatch As Match = Regex.Match(email, pattern)

        ' Caso corresponda
        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function validaCPF(ByVal CPF As String) As Boolean
        Dim i, x, n1, n2 As Integer
        CPF = CPF.Trim
        For i = 0 To dadosArray.Length - 1
            If CPF.Length <> 14 Or dadosArray(i).Equals(CPF) Then
                Return False
            End If
        Next
        'remove a maskara
        CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)
        For x = 0 To 1
            n1 = 0
            For i = 0 To 8 + x
                n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
            Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If n2 = 10 Or n2 = 11 Then n2 = 0
            If n2 <> Val(CPF.Substring(9 + x, 1)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function ValidaCNPJ(ByVal CNPJ As String) As Boolean

        Dim i As Integer
        Dim valida As Boolean

        CNPJ = CNPJ.Trim

        For i = 0 To dadosArray.Length - 1
            If CNPJ.Length <> 18 Or dadosArray(i).Equals(CNPJ) Then
                Return False
            End If
        Next

        'remove a maskara
        CNPJ = CNPJ.Substring(0, 2) + CNPJ.Substring(3, 3) + CNPJ.Substring(7, 3) + CNPJ.Substring(11, 4) + CNPJ.Substring(16)
        valida = efetivaValidacao(CNPJ)

        If valida Then
            ValidaCNPJ = True
        Else
            ValidaCNPJ = False
        End If

    End Function

    Private Function efetivaValidacao(ByVal cnpj As String)
        Dim Numero(13) As Integer
        Dim soma As Integer
        Dim i As Integer
        Dim resultado1 As Integer
        Dim resultado2 As Integer

        For i = 0 To Numero.Length - 1
            Numero(i) = CInt(cnpj.Substring(i, 1))
        Next

        soma = Numero(0) * 5 + Numero(1) * 4 + Numero(2) * 3 + Numero(3) * 2 + Numero(4) * 9 + Numero(5) * 8 + Numero(6) * 7 + _
                   Numero(7) * 6 + Numero(8) * 5 + Numero(9) * 4 + Numero(10) * 3 + Numero(11) * 2

        soma = soma - (11 * (Int(soma / 11)))
        If soma = 0 Or soma = 1 Then
            resultado1 = 0
        Else
            resultado1 = 11 - soma
        End If

        If resultado1 = Numero(12) Then
            soma = Numero(0) * 6 + Numero(1) * 5 + Numero(2) * 4 + Numero(3) * 3 + Numero(4) * 2 + Numero(5) * 9 + Numero(6) * 8 + _
                         Numero(7) * 7 + Numero(8) * 6 + Numero(9) * 5 + Numero(10) * 4 + Numero(11) * 3 + Numero(12) * 2
            soma = soma - (11 * (Int(soma / 11)))
            If soma = 0 Or soma = 1 Then
                resultado2 = 0
            Else
                resultado2 = 11 - soma
            End If
            If resultado2 = Numero(13) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

    End Function

    Public Enum FPGTO As Integer
        Dinheiro = 1
        Cartao = 2
        Boleto = 3
    End Enum

    Public Enum SituacaoPDV As Integer
        Novo = 1
        Faturado = 2
        Enviado = 3
        Fechado = 4
        Cancelado = 5
    End Enum

    Public Enum TPVENDA As Integer
        Balcao = 1
        Telefone = 2
        Internet = 3
    End Enum

    Public Enum TPME As Integer
        Entrada = 1
        Saida = 2
        Reservado = 3
    End Enum

    Public Enum DETME As Integer
        NF = 1
        Venda = 2
        AcertoEstoque = 3
        Inventario = 3
    End Enum

    Public Enum MenuPrincipal
        PesquisaForn
        MPrincCliente
        MPrincPDV
        MPrincEstoque
        MPrincProduto
    End Enum

    Public Enum IncluirAlterar
        Inclusao
        Alteracao
    End Enum

    Public Enum MenuIniciar
        MenuCadastros
        MenuVendas
        MenuEstoque
        MenuRelatorios
        MenuSistema
    End Enum

    Public Enum ModoForm
        ModoPesquisa
        ModoCadastro
        ModoPDC
        ModoNF
    End Enum

    Public Enum ModoListar
        ModoListarProdutos
        ModoListarEstoque
        ModoLProdutoUser
        'ModoPDC
        'ModoNF
    End Enum

    Public Function ListaEAN(ByVal EAN) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT PRODUTO.cdProduto, PRODUTO.noItem, PRODUTO.ean, PRODUTO.noMaxEst, PRODUTO.EstAlvo, PRODUTO.noMinEst, PRODUTO.Foto, PRODUTO.Nome, CATEGORIA.nmCategoria, PLATAFORMA.nmPlataforma, FABRICANTE.nmFabricante, PRODUTO.vlVenda, V_ESTOQUE.Estoque_Fisico, V_ESTOQUE.Estoque_Virtual"
        strQuery = strQuery & " FROM PRODUTO INNER JOIN V_ESTOQUE ON PRODUTO.noItem = V_ESTOQUE.NoItem INNER JOIN CATEGORIA ON PRODUTO.cdCategoria = CATEGORIA.cdCategoria INNER JOIN  PLATAFORMA ON PRODUTO.cdPlataforma = PLATAFORMA.cdPlataforma INNER JOIN  FABRICANTE ON PRODUTO.cdFabricante = FABRICANTE.cdFabricante"
        strQuery = strQuery & " WHERE PRODUTO.ean='" & EAN & "' "
        strQuery = strQuery & " GROUP BY PRODUTO.cdProduto, PRODUTO.noItem, PRODUTO.ean, PRODUTO.noMaxEst, PRODUTO.EstAlvo, PRODUTO.noMinEst, PRODUTO.Foto, PRODUTO.Nome, CATEGORIA.nmCategoria, PLATAFORMA.nmPlataforma, FABRICANTE.nmFabricante, PRODUTO.vlVenda, V_ESTOQUE.Estoque_Fisico, V_ESTOQUE.Estoque_Virtual"

        Dim objCldBD As New cldBD
        Return objCldBD.RetornaDataReader(strQuery.ToString)
    End Function

    Public Function ListaEANPDC(ByVal EAN, ByVal cdforn) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT PRODUTO.cdProduto, PRODUTO.noItem, PRODUTO.ean, PRODUTO.noMaxEst, PRODUTO.EstAlvo, PRODUTO.noMinEst, PRODUTO.Foto, PRODUTO.Nome, CATEGORIA.nmCategoria, PLATAFORMA.nmPlataforma, FABRICANTE.nmFabricante, PRODUTO.vlVenda, V_ESTOQUE.Estoque_Fisico, V_ESTOQUE.Estoque_Virtual"
        strQuery = strQuery & " FROM PRODUTO INNER JOIN V_ESTOQUE ON PRODUTO.noItem = V_ESTOQUE.NoItem INNER JOIN CATEGORIA ON PRODUTO.cdCategoria = CATEGORIA.cdCategoria INNER JOIN  PLATAFORMA ON PRODUTO.cdPlataforma = PLATAFORMA.cdPlataforma INNER JOIN  FABRICANTE ON PRODUTO.cdFabricante = FABRICANTE.cdFabricante"
        strQuery = strQuery & " WHERE PRODUTO.ean='" & EAN & "' AND PRODUTO.cdForne='" & cdforn & "'"
        strQuery = strQuery & " GROUP BY PRODUTO.cdProduto, PRODUTO.noItem, PRODUTO.ean, PRODUTO.noMaxEst, PRODUTO.EstAlvo, PRODUTO.noMinEst, PRODUTO.Foto, PRODUTO.Nome, CATEGORIA.nmCategoria, PLATAFORMA.nmPlataforma, FABRICANTE.nmFabricante, PRODUTO.vlVenda, V_ESTOQUE.Estoque_Fisico, V_ESTOQUE.Estoque_Virtual"

        Dim objCldBD As New cldBD
        Return objCldBD.RetornaDataReader(strQuery.ToString)
    End Function


    

    Public Function BuscaCEP(ByVal CEP As String) As SqlDataReader 'Retornar um DataReader com a pesquisa pelo código
        Dim strQuery As String
        strQuery = " SELECT noCEP, nmLogradouro, nmBairro,nmCidade, sgUF FROM (UF INNER JOIN CIDADE ON UF.cdUF = CIDADE.cdUF)INNER JOIN BAIRRO ON (CIDADE.cdCidade=BAIRRO.cdCidade) INNER JOIN LOGRADOURO ON (BAIRRO.cdBairro = LOGRADOURO.cdBairro) WHERE noCEP='" & CEP & "'"

        Dim objCldBancoDados As New cldBD
        Return objCldBancoDados.RetornaDataReader(strQuery)

    End Function

    Public Function BuscaCPFCliente(ByVal CPF As String) As SqlDataReader 'Retornar um DataReader com a pesquisa pelo código
        Dim strQuery As String
        strQuery = " SELECT cdCli, noCEP, noLog, Complemento, Nome, DDD, dbo.formatarTel(Telefone) as Telefone, Ativo FROM CLIENTE WHERE noCPF='" & CPF & "'"
        Dim objCldBancoDados As New cldBD
        Return objCldBancoDados.RetornaDataReader(strQuery)
    End Function

    Public Function BuscaFuncionarioCod(ByVal CPF As String) As SqlDataReader 'Retornar um DataReader com a pesquisa pelo código
        Dim strQuery As String
        strQuery = " SELECT cdFunc, Nome FROM FUNCIONARIO WHERE cdFunc='" & CPF & "'"
        Dim objCldBancoDados As New cldBD
        Return objCldBancoDados.RetornaDataReader(strQuery)
    End Function


    Public Function CarregaUF() As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cdUF, sgUF ")
        strQuery.Append(" FROM UF ")
        strQuery.Append(" ORDER BY sgUF ")

        Dim objCldBancoDados As New cldBD
        Return objCldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function

    Public Function CarregaTransporte() As DataSet
        Dim strQuery As New StringBuilder
        strQuery.Append(" SELECT cdTransp, RazaoSocial ")
        strQuery.Append(" FROM TRANSPORTADORA ")
        strQuery.Append(" ORDER BY RazaoSocial ")

        Dim objCldBancoDados As New cldBD
        Return objCldBancoDados.RetornaDataSet(strQuery.ToString)

    End Function


   

    Public Function BuscaFornecedor(ByVal CNPJ As String) As SqlDataReader
        Dim strQuery As String
        strQuery = "SELECT CNPJ, NmFantasia, cdForne, RazaoSocial FROM FORNECEDOR WHERE CNPJ='" & CNPJ & "'"
        Dim objCldBD As New cldBD
        Return objCldBD.RetornaDataReader(strQuery)
    End Function

    Public Function Age(ByVal Birthdate As System.DateTime) As Long

        Try

            Dim CurrentDate As System.DateTime = System.DateTime.Today
            Select Case Month(Birthdate)
                Case Is < Month(System.DateTime.Today)
                    Age = DateDiff("YYYY", Birthdate, Now())
                Case Is = Month(CurrentDate)
                    Select Case Day(Birthdate)
                        Case Is < Day(CurrentDate)
                            Age = DateDiff("YYYY", Birthdate, Now())
                        Case Is = Day(CurrentDate)
                            Age = DateDiff("YYYY", Birthdate, Now())
                        Case Is > Day(CurrentDate)
                            Age = DateDiff("YYYY", Birthdate, Now()) - 1
                    End Select
                Case Is > Month(CurrentDate)
                    Age = DateDiff("YYYY", Birthdate, Now()) - 1
                Case Else
                    Age = 0
            End Select

        Catch ex As System.Exception
            'Error handling code does here
        End Try
    End Function

End Class




