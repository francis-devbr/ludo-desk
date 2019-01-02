Imports System.Net
Imports System.Text
Imports System.IO
Imports Microsoft.VisualBasic

Public Class frmPCPF

    Private PackCookies As New CookieContainer()
    Dim Erro As New ErrorProvider


    Private Sub frmPCPF_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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

        CCPF = txtCPF.Text
        CCPF = CCPF.Replace(".", "")
        CCPF = CCPF.Replace(",", "")
        CCPF = CCPF.Replace("-", "")

        CCaptcha = CampoCaptcha.Text

        If CCPF = "" Then

            MessageBox.Show("Preencha o CPF!")

        ElseIf CCaptcha = "" Then

            MessageBox.Show("Preencha o Captcha!")

        Else

            Dim byteArray As Byte() = Encoding.UTF8.GetBytes("txtCPF=" & CCPF & "&idLetra=" & CCaptcha & "&Enviar=Consultar")
            Dim request As HttpWebRequest = HttpWebRequest.Create("http://www.receita.fazenda.gov.br/aplicacoes/atcta/cpf/ConsultaPublica.asp")

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
        Dim NNome, NStatus, FNome, FStatus As String
        Dim ANome, AStatus As Array

        Dim doc As HtmlDocument = webBrowserForPrinting.Document

        If doc.Body.InnerHtml.Contains("Comprovante emitido") Then


            NNome = doc.GetElementsByTagName("span").Item(5).InnerHtml
            ANome = NNome.Split(":")
            FNome = Trim(ANome(1))

            NStatus = doc.GetElementsByTagName("span").Item(6).InnerHtml
            AStatus = NStatus.Split(":")
            FStatus = Trim(AStatus(1))

            TxtNome.Text = FNome
            TxtStatus.Text = FStatus

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

    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click


        NomePesquisado = TxtNome.Text
        CPFPesquisado = txtCPF.Text

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

    Private Sub txtCPF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCPF.KeyDown
        Select Case e.KeyCode
            Case Keys.Back
                If Len(Me.txtCPF.Text) > 0 Then
                    vf = True
                    Me.txtCPF.Text = Mid(Me.txtCPF.Text, 1, Val(Len(Me.txtCPF.Text)) - 1)
                    SendKeys.Send("{END}")
                End If
        End Select
        vf = False
    End Sub

    Private Sub txtCPF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCPF.TextChanged
        If vf = False Then
            If Me.txtCPF.Text.Length = 3 Then
                Me.txtCPF.Text = Me.txtCPF.Text & "."
                Me.txtCPF.SelectionStart = Me.txtCPF.Text.Length + 1
            ElseIf Me.txtCPF.Text.Length = 7 Then
                Me.txtCPF.Text = Me.txtCPF.Text & "."
                Me.txtCPF.SelectionStart = Me.txtCPF.Text.Length + 1
            ElseIf Me.txtCPF.Text.Length = 11 Then
                Me.txtCPF.Text = Me.txtCPF.Text & "-"
                Me.txtCPF.SelectionStart = Me.txtCPF.Text.Length + 1
            End If
        End If
    End Sub

    Private Sub txtCPF_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCPF.Validating

        Dim ObjClnFuncoesGerais As New clnFuncoesGerais
        If Me.btnCancelar.Focused Then
            e.Cancel = False


        ElseIf Not (Me.txtCPF.Text Like "###.###.###-##") Then
            e.Cancel = True
            Me.txtCPF.Select(0, Me.txtCPF.Text.Length)
            Erro.SetError(Me.txtCPF, "CPF Inválido ")
        ElseIf Not ObjClnFuncoesGerais.validaCPF(txtCPF.Text) Then
            e.Cancel = True
            Me.txtCPF.Select(0, Me.txtCPF.Text.Length)
            Erro.SetError(Me.txtCPF, "Nº CPF Inválido ")
        End If
    End Sub

    Private Sub txtCPF_Validated(sender As Object, e As System.EventArgs) Handles txtCPF.Validated
        Erro.SetError(Me.txtCPF, "")

    End Sub
End Class
