Imports System.Net
Imports System.Text
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions

Public Class frmPCNPJ
    Dim Erro As New ErrorProvider
    Private PackCookies As New CookieContainer()


    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click


        RzPesquisado = TxtNome.Text
        CNPJPesquisado = txtCNPJ.Text
        nmFantasia = TxtStatus.Text
        For Each LC As Control In Me.GroupBox1.Controls
            If TypeOf LC Is TextBox Then
                LC.Text = ""
            End If
        Next

        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmPCNPJ_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If (e.KeyChar = ChrW(13)) Then
            SendKeys.Send("{TAB}")
            e.Handled = True 'Para remover aquele som...
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CarregarCaptcha()

    End Sub

    Private Sub CarregarCaptcha()

        TxtNome.Text = "-"
        TxtStatus.Text = "-"

        Dim request As HttpWebRequest = HttpWebRequest.Create("http://www.receita.fazenda.gov.br/scripts/srf/intercepta/captcha.aspx?opt=image")
        request.ContentType = "application/x-www-form-urlencoded"
        request.CookieContainer = New CookieContainer()

        Dim response As HttpWebResponse = request.GetResponse()

        For Each tempCookie As Net.Cookie In response.Cookies

            If tempCookie.Name = "cookieCaptcha" Then
                PackCookies.Add(tempCookie)
            End If

        Next

        Dim stream As IO.Stream = response.GetResponseStream()
        CampoPicture.Image = Image.FromStream(stream)

    End Sub

    Private Sub BtnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles BtnConsultar.Click

        Dim CCPF, CCaptcha As String

        CCPF = Regex.Replace(Me.txtCNPJ.Text, "[\\\?\*-./]", "").ToString.Trim
      
        CCaptcha = CampoCaptcha.Text

        If CCPF = "" Then

            MessageBox.Show("Preencha o CPF!")

        ElseIf CCaptcha = "" Then

            MessageBox.Show("Preencha o Captcha!")

        Else

            Dim byteArray As Byte() = Encoding.UTF8.GetBytes("origem = comprovante" & "&CNPJ=" & CCPF & "&idLetra=" & CCaptcha & "&Submit1=Consultar" & "&search_type = cnpj")
            Dim request As HttpWebRequest = HttpWebRequest.Create("http://www.receita.fazenda.gov.br/pessoajuridica/cnpj/cnpjreva/valida.asp")

            request.ContentType = "application/x-www-form-urlencoded"
            request.CookieContainer = PackCookies
            request.Method = "POST"
            request.ContentLength = byteArray.Length

            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()

            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim webBrowser As New WebBrowser()

            Dim myHTML As String = responseFromServer

            webBrowser.DocumentText = myHTML
            webBrowser.ScriptErrorsSuppressed = True

            AddHandler webBrowser.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf ManipulaRetornoRF)

            reader.Close()
            dataStream.Close()
            response.Close()

        End If

    End Sub

    Private Sub ManipulaRetornoRF(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs)

        Dim webBrowserForPrinting As WebBrowser = CType(sender, WebBrowser)
        Dim NNmRazaoS, NNmFantasia, Atividade As String


        Dim doc As HtmlDocument = webBrowserForPrinting.Document

        If doc.Body.InnerHtml.Contains("FEDERATIVA DO BRASIL") Then


            NNmRazaoS = doc.GetElementsByTagName("b").Item(8).InnerHtml

            NNmFantasia = doc.GetElementsByTagName("b").Item(9).InnerHtml

            Atividade = doc.GetElementsByTagName("b").Item(10).InnerHtml

            TxtNome.Text = NNmRazaoS
            TxtStatus.Text = NNmFantasia
            lblAtividade.Text = Atividade

        Else

            MessageBox.Show("Dados inválidos!")


            TxtNome.Focus()
            With CampoCaptcha
                .Clear()
                .Focus()
            End With
            CarregarCaptcha()


        End If

    End Sub


    Private Sub txtCNPJ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCNPJ.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Me.txtCNPJ.Text.Length > 0 Then
                    vf = True
                    Me.txtCNPJ.Text = Mid(Me.txtCNPJ.Text, 1, Val(Len(Me.txtCNPJ.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtCNPJ_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCNPJ.TextChanged
        If vf = False Then
            If Me.txtCNPJ.Text.Length = 2 Then
                txtCNPJ.Text = txtCNPJ.Text & "."
                txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1

            ElseIf Me.txtCNPJ.Text.Length = 6 Then
                txtCNPJ.Text = txtCNPJ.Text & "."
                txtCNPJ.SelectionStart = txtCNPJ.Text.Length + 1

            ElseIf Me.txtCNPJ.Text.Length = 10 Then
                txtCNPJ.Text = txtCNPJ.Text & "/"
                txtCNPJ.SelectionStart = Me.txtCNPJ.Text.Length + 1

            ElseIf Me.txtCNPJ.Text.Length = 15 Then
                txtCNPJ.Text = txtCNPJ.Text & "-"
                txtCNPJ.SelectionStart = Me.txtCNPJ.Text.Length + 1

            End If
        End If
    End Sub

    Private Sub txtCNPJ_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCNPJ.Validating
        Dim ObjClnFuncoesGerais As New clnFuncoesGerais

        If Me.btnCancelar.Focused Or frmMenu.pnMenuIN.Visible = True Then
            e.Cancel = False
            Exit Sub
        ElseIf Me.txtCNPJ.Text = Nothing Then
            e.Cancel = True
            Me.txtCNPJ.Select(0, Me.txtCNPJ.Text.Length)
            Erro.SetError(Me.txtCNPJ, "Campo obrigatório")

        ElseIf Not (Me.txtCNPJ.Text Like "##.###.###/####-##") Then
            e.Cancel = True
            Me.txtCNPJ.Select(0, Me.txtCNPJ.Text.Length)
            Erro.SetError(Me.txtCNPJ, "CNPJ Inválido")

        ElseIf Not ObjClnFuncoesGerais.ValidaCNPJ(txtCNPJ.Text) Then
            e.Cancel = True
            Me.txtCNPJ.Select(0, Me.txtCNPJ.Text.Length)
            Erro.SetError(Me.txtCNPJ, "Nº CNPJ Inválido ")
        End If



    End Sub

    Private Sub txtCNPJ_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCNPJ.Validated
        Erro.SetError(Me.txtCNPJ, "")
    End Sub
End Class
