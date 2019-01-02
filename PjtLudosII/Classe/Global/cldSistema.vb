Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class cldSistema
    Private objCldBD As New cldBD
    Private mIdPerfil As Integer
    Public Property IdPerfil() As Integer
        Get
            Return mIdPerfil
        End Get
        Set(ByVal value As Integer)
            mIdPerfil = value
        End Set
    End Property
    Private mNmPerfil As String
    Public Property NmPerfil() As String
        Get
            Return mNmPerfil
        End Get
        Set(ByVal value As String)
            mNmPerfil = value.ToUpper
        End Set
    End Property
    Private mIdUsuario As Integer
    Public Property IdUsuario() As Integer
        Get
            Return mIdUsuario
        End Get
        Set(ByVal value As Integer)
            mIdUsuario = value
        End Set
    End Property
    Private mPNome As String
    Public Property PNome() As String
        Get
            Return mPNome
        End Get
        Set(ByVal value As String)
            mPNome = value
        End Set
    End Property
    Private mUNome As String
    Public Property UNome() As String
        Get
            Return mUNome
        End Get
        Set(ByVal value As String)
            mUNome = value
        End Set
    End Property
    Private mNoCPF As String
    Public Property NoCPF() As String
        Get
            Return mNoCPF
        End Get
        Set(ByVal value As String)
            mNoCPF = value
        End Set
    End Property
    Private mSenha As String
    Public Property Senha() As String
        Get
            Return mSenha
        End Get
        Set(ByVal value As String)
            mSenha = value
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
    Private mAtivo As Boolean
    Public Property Ativo As Boolean
        Get
            Return mAtivo
        End Get
        Set(value As Boolean)
            mAtivo = value
        End Set
    End Property

    Public Sub GravaPERFIL_ACESSO()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("PERFIL_ACESSO")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mNmPerfil & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub GravaUSUARIO()
        Dim str As New StringBuilder
        str.Append("Insert into ")
        str.Append("USUARIO")
        str.Append(" values ")
        str.Append(" ( ")
        str.Append("'" & mPNome & "' ")
        str.Append("'" & mUNome & "' ")
        str.Append("'" & mNoCPF & "' ")
        str.Append("'" & mSenha & "' ")
        str.Append("'" & mIdPerfil & "' ")
        str.Append("'" & mDtCadastro & "' ")
        str.Append("'" & Ativo & "' ")
        str.Append(" )")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Sub AtualizaUsuario()
        Dim strQuery As New StringBuilder
        strQuery.Append(" UPDATE USUARIO ")
        strQuery.Append(" SET ")
        strQuery.Append(" PNome = '" & mPNome & "' ")
        strQuery.Append(", UNome = '" & mUNome & "' ")
        strQuery.Append(", noCPF = '" & mNoCPF & "' ")
        strQuery.Append(", Senha = '" & mSenha & "' ")
        strQuery.Append(", Ativo = '" & mAtivo & "' ")
        strQuery.Append(" WHERE ")
        strQuery.Append(" noCPF = '" & mNoCPF & "' ")
        Dim objCldBD As New cldBD
        objCldBD.ExecutaComando(strQuery.ToString)
    End Sub

    Public Function CarregaUsuario() As DataSet
        Dim str As New StringBuilder
        str.Append(" SELECT * ")
        str.Append(" FROM USUARIO, PERFIL_ACESSO WHERE USUARIO.idPerfil= PERFIL_ACESSO.idPerfil AND Ativo = 1")
        str.Append(" ORDER BY USUARIO.PNome ")
        Return objCldBD.RetornaDataSet(str.ToString)

    End Function

    Public Function ListaUsuario(ByVal codigo As String) As SqlDataReader
        Dim strQuery As String
        strQuery = " SELECT idUsuario, PNome, UNome, Senha, Ativo, idPerfil, dbo.formatarCPF(noCPF) as noCPF  FROM USUARIO WHERE idUsuario='" & codigo & "'"
        Return objCldBD.RetornaDataReader(strQuery)
    End Function

    Public Function RecSenha(ByVal codigo As String) As SqlDataReader
        Dim str As String
        str = " SELECT * FROM USUARIO WHERE noCPF ='" & codigo & "'"
        Return objCldBD.RetornaDataReader(str)
    End Function

    Public Sub AtualizaSenha()
        Dim str As New StringBuilder
        str.Append(" UPDATE USUARIO ")
        str.Append(" SET ")
        str.Append(" Senha = '" & mSenha & "' ")
        str.Append(" WHERE ")
        str.Append(" noCPF = '" & mNoCPF & "' ")
        objCldBD.ExecutaComando(str.ToString)
    End Sub

    Public Function AlteraSenha(ByVal codigo As String) As SqlDataReader
        Dim strQuery As String
        strQuery = " SELECT * FROM USUARIO WHERE noCPF ='" & codigo & "'"
        Return objCldBD.RetornaDataReader(strQuery)
    End Function


    Public Function Logar(ByVal codigo As String, ByVal codigo2 As String) As SqlDataReader
        Dim strQuery As String
        strQuery = " SELECT * FROM USUARIO, PERFIL_ACESSO  WHERE USUARIO.idPerfil = PERFIL_ACESSO.idPerfil and noCPF ='" & codigo & "' and Senha ='" & codigo2 & "'"
        Return objCldBD.RetornaDataReader(strQuery)
    End Function


    Public Function CarregaPerfil() As DataSet
        Dim str As New StringBuilder
        str.Append(" SELECT * ")
        str.Append(" FROM PERFIL_ACESSO ")
        str.Append(" ORDER BY nmPerfil ")
        Return objCldBD.RetornaDataSet(str.ToString)
    End Function

    Public Function GerarHash(ByVal Valor As String) As String
        Dim Sha As New System.Security.Cryptography.SHA1Managed
        Sha.ComputeHash(System.Text.Encoding.Default.GetBytes(Valor))
        Return Convert.ToBase64String(Sha.Hash)
    End Function

    Public Sub LimpaForm(frm As Form)
        For Each LC As Control In frm.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
                LC.CausesValidation = False
            End If
        Next
    End Sub

    Public Sub AgruparListView(ByVal lstV As ListView, ByVal SubItemIndex As Int16)
        Dim flag As Boolean = True
        For Each objLVItem As ListViewItem In lstV.Items
            Dim NomedoGrupo As String = objLVItem.SubItems(SubItemIndex).Text
            For Each objLvg As ListViewGroup In lstV.Groups
                If objLvg.Name = NomedoGrupo Then
                    objLVItem.Group = objLvg
                    flag = False
                End If
            Next
            If flag = True Then
                Dim objLstGrp As New ListViewGroup(NomedoGrupo, NomedoGrupo)
                lstV.Groups.Add(objLstGrp)
                objLVItem.Group = objLstGrp
            End If
            flag = True
        Next
    End Sub

    Public Sub pZebra(ByVal lstV As ListView, ByVal color1 As Color, ByVal color2 As Color)
        'Rotina para colorir linhas (zebra)
        For i As Integer = 0 To lstV.Items.Count - 1
            If i Mod 2 = 0 Then 'Linhas pares
                lstV.Items(i).BackColor = Color.White
                lstV.Items(i).ForeColor = color1
            Else 'Linhas ímpares
                lstV.Items(i).BackColor = color2
                lstV.Items(i).ForeColor = color1
            End If
        Next

    End Sub

    Public Function SoTexto(ByVal KeyAscii As Integer) As Integer
        KeyAscii = Convert.ToByte(Convert.ToChar(KeyAscii))
        If String.Compare("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Convert.ToChar(KeyAscii)) = 0 Then
            SoTexto = 0
        Else
            SoTexto = KeyAscii
        End If

        Select Case KeyAscii
            Case 8
                SoTexto = KeyAscii
            Case 13
                SoTexto = KeyAscii
            Case 32
                SoTexto = KeyAscii
        End Select

    End Function

    Public Sub Manipular(ByVal controle As Control)

    End Sub

End Class