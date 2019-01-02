Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions
Public Class frmLogin
    Dim tentativas As Byte
    Private ObjSistema As New cldSistema

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click

        If (MessageBox.Show("Deseja sair do programa ?", Me.Text, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        Else
            MessageBox.Show("OPERAÇÃO CANCELADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtLogin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLogin.TextChanged
        If vf = False Then
            If Me.txtLogin.Text.Length = 3 Then
                Me.txtLogin.Text = Me.txtLogin.Text & "."
                Me.txtLogin.SelectionStart = Me.txtLogin.Text.Length + 1
            ElseIf Me.txtLogin.Text.Length = 7 Then
                Me.txtLogin.Text = Me.txtLogin.Text & "."
                Me.txtLogin.SelectionStart = Me.txtLogin.Text.Length + 1
            ElseIf Me.txtLogin.Text.Length = 11 Then
                Me.txtLogin.Text = Me.txtLogin.Text & "-"
                Me.txtLogin.SelectionStart = Me.txtLogin.Text.Length + 1
            End If
        End If
    End Sub

    Private Sub txtLogin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLogin.KeyPress
        'If Char.IsNumber(e.KeyChar) Then
        '    e.Handled = True
        'End If
        '' ao pressionar a tecla ENTER ( Return) o foco vai para o proximo controle
        'If e.KeyChar = Convert.ToChar(Keys.Return) Then
        '    e.Handled = True
        '    txtSenha.Focus()
        'End If
        ''preesionou ESC sai
        'If e.KeyChar = Convert.ToChar(Keys.Escape) Then
        '    If (MessageBox.Show("Deseja sair do programa ?", Me.Text, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
        '        Application.Exit()
        '    Else
        '        MessageBox.Show("OPERAÇÃO CANCELADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    End If
        'End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Dim drDados As SqlDataReader

        drDados = ObjSistema.Logar(Regex.Replace(Me.txtLogin.Text, "[\\\?\*-./]", "").ToString.Trim, Me.txtSenha.Text.ToString.Trim)
        With drDados
            If .Read Then
                If drDados.Item("Ativo") = False Then
                    MessageBox.Show("O usuário precisa ser habilitado. Contate o Administrador", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    nomeUsuario = drDados.Item("PNome")
                    idUsuario = drDados.Item("idUsuario")
                    If drDados.Item("idPerfil") = 1 Then
                        perfilUsuario = "Admin"
                    ElseIf drDados.Item("idPerfil") = 2 Then

                        perfilUsuario = "User"
                    End If
                End If

                MessageBox.Show("Acesso permitido ! Bem Vindo """ & txtLogin.Text & """", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)

                frmMenu.Show()
                Me.Close()
            Else
                tentativas += 1
                If tentativas >= 3 Then
                    MessageBox.Show("Número de tentativas foi excedido !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Fecha aplicação
                    End
                Else
                    txtLogin.Clear()
                    txtSenha.Clear()
                    MessageBox.Show("Chave ou senha inválida !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            txtLogin.Focus()
        End With


    End Sub

    Private Sub frmLogin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub btnEsqSenha_Click(sender As System.Object, e As System.EventArgs) Handles btnEsqSenha.Click
        frmRecSenhaUser.ShowDialog()
    End Sub

    Private Sub frmInputBox_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

