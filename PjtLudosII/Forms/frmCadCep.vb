Public Class frmCadCep

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    
    Private Sub frmCadCep_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim objClsFGeral As New clnFuncoesGerais
        Me.cboUF.DataSource = objClsFGeral.CarregaUF.Tables(0)
        Me.cboUF.DisplayMember = "sgUF"
        Me.cboUF.ValueMember = "cdUF"
        Me.cboUF.SelectedValue = -1

    End Sub
End Class