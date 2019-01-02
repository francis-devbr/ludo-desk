<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecSenhaUser
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
        Me.txtConNovaSenha = New System.Windows.Forms.TextBox()
        Me.txtNovaSenha = New System.Windows.Forms.TextBox()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblInfoTela = New System.Windows.Forms.Label()
        Me.lblCmbClienteP = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtConNovaSenha
        '
        Me.txtConNovaSenha.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtConNovaSenha.Location = New System.Drawing.Point(27, 157)
        Me.txtConNovaSenha.MaxLength = 8
        Me.txtConNovaSenha.Name = "txtConNovaSenha"
        Me.txtConNovaSenha.Size = New System.Drawing.Size(179, 31)
        Me.txtConNovaSenha.TabIndex = 3
        '
        'txtNovaSenha
        '
        Me.txtNovaSenha.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtNovaSenha.Location = New System.Drawing.Point(27, 97)
        Me.txtNovaSenha.MaxLength = 8
        Me.txtNovaSenha.Name = "txtNovaSenha"
        Me.txtNovaSenha.Size = New System.Drawing.Size(179, 31)
        Me.txtNovaSenha.TabIndex = 2
        '
        'txtCPF
        '
        Me.txtCPF.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.txtCPF.Location = New System.Drawing.Point(27, 37)
        Me.txtCPF.MaxLength = 14
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(179, 31)
        Me.txtCPF.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(23, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Confirmar Nova Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nova Senha"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.lblCPF.Location = New System.Drawing.Point(23, 11)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(39, 23)
        Me.lblCPF.TabIndex = 20
        Me.lblCPF.Text = "CPF"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtConNovaSenha)
        Me.Panel1.Controls.Add(Me.txtNovaSenha)
        Me.Panel1.Controls.Add(Me.txtCPF)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblCPF)
        Me.Panel1.Location = New System.Drawing.Point(12, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 204)
        Me.Panel1.TabIndex = 0
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.DarkRed
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 322)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(500, 25)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(500, 348)
        Me.ShapeContainer1.TabIndex = 141
        Me.ShapeContainer1.TabStop = False
        '
        'lblInfoTela
        '
        Me.lblInfoTela.AutoSize = True
        Me.lblInfoTela.BackColor = System.Drawing.Color.DarkRed
        Me.lblInfoTela.ForeColor = System.Drawing.Color.White
        Me.lblInfoTela.Location = New System.Drawing.Point(9, 329)
        Me.lblInfoTela.Name = "lblInfoTela"
        Me.lblInfoTela.Size = New System.Drawing.Size(111, 13)
        Me.lblInfoTela.TabIndex = 142
        Me.lblInfoTela.Text = "Recuperar sua Senha"
        '
        'lblCmbClienteP
        '
        Me.lblCmbClienteP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCmbClienteP.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmbClienteP.ForeColor = System.Drawing.Color.DimGray
        Me.lblCmbClienteP.Location = New System.Drawing.Point(86, 9)
        Me.lblCmbClienteP.Name = "lblCmbClienteP"
        Me.lblCmbClienteP.Size = New System.Drawing.Size(240, 50)
        Me.lblCmbClienteP.TabIndex = 144
        Me.lblCmbClienteP.Text = "Recuperar Senha"
        Me.lblCmbClienteP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.PjtLudosII.My.Resources.Resources.unlock
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(15, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 52)
        Me.PictureBox1.TabIndex = 143
        Me.PictureBox1.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = Global.PjtLudosII.My.Resources.Resources.block
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(380, 272)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 38)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.AutoSize = True
        Me.btnSalvar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnSalvar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Image = Global.PjtLudosII.My.Resources.Resources.accept_business_user
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(274, 272)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(100, 38)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = "OK"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'frmRecSenhaUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(500, 348)
        Me.Controls.Add(Me.lblCmbClienteP)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblInfoTela)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRecSenhaUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar Senha"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtConNovaSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtNovaSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtCPF As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCPF As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblInfoTela As System.Windows.Forms.Label
    Friend WithEvents lblCmbClienteP As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
