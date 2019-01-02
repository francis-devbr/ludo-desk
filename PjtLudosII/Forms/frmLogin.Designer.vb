<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Me.txtSenha = New System.Windows.Forms.MaskedTextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblCmbProdutoP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbNext = New System.Windows.Forms.PictureBox()
        Me.btnEsqSenha = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSenha
        '
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(33, 147)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(273, 26)
        Me.txtSenha.TabIndex = 1
        '
        'txtLogin
        '
        Me.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(33, 90)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(273, 26)
        Me.txtLogin.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(340, 281)
        Me.ShapeContainer1.TabIndex = 17
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.DarkRed
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(-1, 255)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(340, 25)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.DimGray
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Location = New System.Drawing.Point(-1, -1)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(342, 45)
        '
        'lblCmbProdutoP
        '
        Me.lblCmbProdutoP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCmbProdutoP.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmbProdutoP.ForeColor = System.Drawing.Color.DimGray
        Me.lblCmbProdutoP.Location = New System.Drawing.Point(31, 64)
        Me.lblCmbProdutoP.Name = "lblCmbProdutoP"
        Me.lblCmbProdutoP.Size = New System.Drawing.Size(133, 23)
        Me.lblCmbProdutoP.TabIndex = 18
        Me.lblCmbProdutoP.Text = "Usuário"
        Me.lblCmbProdutoP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(31, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Senha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbNext
        '
        Me.pbNext.BackColor = System.Drawing.Color.DimGray
        Me.pbNext.BackgroundImage = Global.PjtLudosII.My.Resources.Resources.login_icon
        Me.pbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNext.Location = New System.Drawing.Point(3, 3)
        Me.pbNext.Name = "pbNext"
        Me.pbNext.Size = New System.Drawing.Size(52, 39)
        Me.pbNext.TabIndex = 144
        Me.pbNext.TabStop = False
        '
        'btnEsqSenha
        '
        Me.btnEsqSenha.AutoSize = True
        Me.btnEsqSenha.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEsqSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEsqSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEsqSenha.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnEsqSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnEsqSenha.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEsqSenha.ForeColor = System.Drawing.Color.Black
        Me.btnEsqSenha.Image = Global.PjtLudosII.My.Resources.Resources.help
        Me.btnEsqSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEsqSenha.Location = New System.Drawing.Point(264, 198)
        Me.btnEsqSenha.Name = "btnEsqSenha"
        Me.btnEsqSenha.Size = New System.Drawing.Size(42, 38)
        Me.btnEsqSenha.TabIndex = 143
        Me.btnEsqSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEsqSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip.SetToolTip(Me.btnEsqSenha, "Reset de Senha")
        Me.btnEsqSenha.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.AutoSize = True
        Me.btnSair.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnSair.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Black
        Me.btnSair.Image = Global.PjtLudosII.My.Resources.Resources.shut
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(143, 198)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(108, 38)
        Me.btnSair.TabIndex = 142
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.AutoSize = True
        Me.btnOk.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnOk.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.Black
        Me.btnOk.Image = Global.PjtLudosII.My.Resources.Resources.user_accept
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(32, 197)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(102, 38)
        Me.btnOk.TabIndex = 141
        Me.btnOk.Text = "Acessar"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(340, 281)
        Me.Controls.Add(Me.pbNext)
        Me.Controls.Add(Me.btnEsqSenha)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCmbProdutoP)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sistema"
        CType(Me.pbNext, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSenha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblCmbProdutoP As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnEsqSenha As System.Windows.Forms.Button
    Friend WithEvents pbNext As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip

End Class
