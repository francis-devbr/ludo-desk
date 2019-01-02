Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic
Public Class frmRecSenhaUser

    Dim Erro As New ErrorProvider
    Dim tentativas As Byte
    Private ObjSistema As New cldSistema

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

        ElseIf Me.txtCPF.Text = Nothing Then
            e.Cancel = True
            Me.txtCPF.Select(0, Me.txtCPF.Text.Length)
            Erro.SetError(Me.txtCPF, "Campo obrigatório")

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
        Me.lblCPF.ForeColor = Color.Black
    End Sub


    Private Sub btnSalvar_Click(sender As System.Object, e As System.EventArgs) Handles btnSalvar.Click

        If Me.txtCPF.Text = Nothing Then
            MessageBox.Show("Digite um CPF", "Obrigatório")
            Me.txtCPF.Focus()
            Exit Sub
        End If



        Dim drDados As SqlDataReader
        drDados = ObjSistema.RecSenha(Regex.Replace(Me.txtCPF.Text, "[\\\?\*-./]", "").ToString.Trim)

        With drDados
            If .Read Then

                If drDados.Item("Ativo") = False Then
                    MessageBox.Show("O usuário precisa ser habilitado. Contate o Administrador")
                    Exit Sub
                End If

                With ObjSistema
                    .Senha = Me.txtNovaSenha.Text.ToString.Trim
                    .NoCPF = Regex.Replace(Me.txtCPF.Text, "[\\\?\*-./]", "").ToString.Trim
                    .AtualizaSenha()
                End With

                MessageBox.Show("Senha Alterada com sucesso ! """ & drDados.Item("PNome") & """", "Senha", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()


            Else
                tentativas += 1
                If tentativas >= 3 Then
                    MessageBox.Show("Número de tentativas foi excedido !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Fecha aplicação
                    End
                Else
                    txtCPF.Clear()
                    MessageBox.Show("Chave ou senha inválida !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            txtCPF.Focus()
        End With
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    
    Private Sub frmRecSenhaUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class