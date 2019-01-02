<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPesquisa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPesquisar = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.lblPesquisa = New System.Windows.Forms.Label()
        Me.btnAlterar = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPesquisar
        '
        Me.txtPesquisar.Location = New System.Drawing.Point(65, 66)
        Me.txtPesquisar.Name = "txtPesquisar"
        Me.txtPesquisar.Size = New System.Drawing.Size(391, 20)
        Me.txtPesquisar.TabIndex = 0
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(66, 116)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(390, 215)
        Me.DGV.TabIndex = 1
        '
        'lblPesquisa
        '
        Me.lblPesquisa.AutoSize = True
        Me.lblPesquisa.Location = New System.Drawing.Point(63, 50)
        Me.lblPesquisa.Name = "lblPesquisa"
        Me.lblPesquisa.Size = New System.Drawing.Size(92, 13)
        Me.lblPesquisa.TabIndex = 2
        Me.lblPesquisa.Text = "Nome Fornecedor"
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(61, 347)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(93, 32)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'frmPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 388)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.lblPesquisa)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.txtPesquisar)
        Me.Name = "frmPesquisa"
        Me.Text = "frmPesquisa"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPesquisar As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents lblPesquisa As System.Windows.Forms.Label
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
End Class
