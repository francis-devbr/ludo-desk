Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Public Class InputBox


    Protected m_BlankValid As Boolean = True
    Protected m_ReturnText As String = ""

    Public Overloads Function ShowDialog( _
      ByVal TitleText As String, _
      ByVal PromptText As String, _
      ByVal DefaultText As String, _
      ByRef EnteredText As String, _
      ByVal BlankValid As Boolean) As System.Windows.Forms.DialogResult
        m_BlankValid = BlankValid
        Me.Lbl_Prompt.Text = PromptText
        Me.Text = TitleText
        Me.Txt_TextEntry.Text = DefaultText
        Me.ShowDialog()
        EnteredText = m_ReturnText
        Return Me.DialogResult
    End Function

    Private Sub Txt_TextEntry_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_TextEntry.KeyPress
       
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_TextEntry.TextChanged
        If Me.Txt_TextEntry.Text = "" Then
            Me.btnOk.Enabled = m_BlankValid
        Else
            Me.btnOk.Enabled = True
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        m_ReturnText = Me.Txt_TextEntry.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        m_ReturnText = ""
        Me.Close()
    End Sub


    Private Sub frmInput_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

  

End Class

