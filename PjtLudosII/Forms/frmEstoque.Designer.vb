<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstoque
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
        Me.pnInfo = New System.Windows.Forms.Panel()
        Me.lsvReduzida = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtEAN = New System.Windows.Forms.TextBox()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.lblQtde = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCodProd = New System.Windows.Forms.Label()
        Me.pbBtnSaida = New System.Windows.Forms.PictureBox()
        Me.pbBtnEntrada = New System.Windows.Forms.PictureBox()
        Me.lblSaida = New System.Windows.Forms.Label()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAjustar = New System.Windows.Forms.Button()
        Me.lblNm = New System.Windows.Forms.Label()
        Me.pnInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbBtnSaida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBtnEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnInfo
        '
        Me.pnInfo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pnInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnInfo.Controls.Add(Me.lsvReduzida)
        Me.pnInfo.Controls.Add(Me.GroupBox2)
        Me.pnInfo.Enabled = False
        Me.pnInfo.ForeColor = System.Drawing.Color.LightCyan
        Me.pnInfo.Location = New System.Drawing.Point(39, 76)
        Me.pnInfo.Name = "pnInfo"
        Me.pnInfo.Size = New System.Drawing.Size(744, 524)
        Me.pnInfo.TabIndex = 138
        '
        'lsvReduzida
        '
        Me.lsvReduzida.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvReduzida.Location = New System.Drawing.Point(13, 170)
        Me.lsvReduzida.Name = "lsvReduzida"
        Me.lsvReduzida.Size = New System.Drawing.Size(715, 331)
        Me.lsvReduzida.TabIndex = 18
        Me.lsvReduzida.TabStop = False
        Me.lsvReduzida.UseCompatibleStateImageBehavior = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEAN)
        Me.GroupBox2.Controls.Add(Me.txtQtd)
        Me.GroupBox2.Controls.Add(Me.lblQtde)
        Me.GroupBox2.Controls.Add(Me.lblNm)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblCodProd)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(715, 151)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'txtEAN
        '
        Me.txtEAN.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEAN.Location = New System.Drawing.Point(21, 44)
        Me.txtEAN.MaxLength = 15
        Me.txtEAN.Name = "txtEAN"
        Me.txtEAN.Size = New System.Drawing.Size(149, 27)
        Me.txtEAN.TabIndex = 6
        Me.txtEAN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtQtd
        '
        Me.txtQtd.Enabled = False
        Me.txtQtd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Location = New System.Drawing.Point(205, 44)
        Me.txtQtd.MaxLength = 5
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(81, 27)
        Me.txtQtd.TabIndex = 7
        Me.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblQtde
        '
        Me.lblQtde.AutoSize = True
        Me.lblQtde.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtde.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblQtde.Location = New System.Drawing.Point(201, 22)
        Me.lblQtde.Name = "lblQtde"
        Me.lblQtde.Size = New System.Drawing.Size(85, 19)
        Me.lblQtde.TabIndex = 3
        Me.lblQtde.Text = "Quantidade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(18, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nome do Produto"
        '
        'lblCodProd
        '
        Me.lblCodProd.AutoSize = True
        Me.lblCodProd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodProd.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCodProd.Location = New System.Drawing.Point(18, 22)
        Me.lblCodProd.Name = "lblCodProd"
        Me.lblCodProd.Size = New System.Drawing.Size(36, 19)
        Me.lblCodProd.TabIndex = 8
        Me.lblCodProd.Text = "EAN"
        '
        'pbBtnSaida
        '
        Me.pbBtnSaida.BackColor = System.Drawing.Color.Transparent
        Me.pbBtnSaida.BackgroundImage = Global.PjtLudosII.My.Resources.Resources.Pad_512
        Me.pbBtnSaida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBtnSaida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBtnSaida.Location = New System.Drawing.Point(836, 266)
        Me.pbBtnSaida.Name = "pbBtnSaida"
        Me.pbBtnSaida.Size = New System.Drawing.Size(120, 105)
        Me.pbBtnSaida.TabIndex = 141
        Me.pbBtnSaida.TabStop = False
        '
        'pbBtnEntrada
        '
        Me.pbBtnEntrada.BackColor = System.Drawing.Color.Transparent
        Me.pbBtnEntrada.BackgroundImage = Global.PjtLudosII.My.Resources.Resources.Console_512
        Me.pbBtnEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbBtnEntrada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBtnEntrada.Location = New System.Drawing.Point(836, 77)
        Me.pbBtnEntrada.Name = "pbBtnEntrada"
        Me.pbBtnEntrada.Size = New System.Drawing.Size(120, 105)
        Me.pbBtnEntrada.TabIndex = 142
        Me.pbBtnEntrada.TabStop = False
        '
        'lblSaida
        '
        Me.lblSaida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSaida.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaida.ForeColor = System.Drawing.Color.DimGray
        Me.lblSaida.Location = New System.Drawing.Point(836, 374)
        Me.lblSaida.Name = "lblSaida"
        Me.lblSaida.Size = New System.Drawing.Size(124, 40)
        Me.lblSaida.TabIndex = 139
        Me.lblSaida.Text = "Saída para Ajuste de Estoque"
        Me.lblSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEntrada
        '
        Me.lblEntrada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEntrada.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada.ForeColor = System.Drawing.Color.DimGray
        Me.lblEntrada.Location = New System.Drawing.Point(836, 185)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(120, 62)
        Me.lblEntrada.TabIndex = 140
        Me.lblEntrada.Text = "Entrada para Ajuste de Estoque"
        Me.lblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnCancelar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.Image = Global.PjtLudosII.My.Resources.Resources.block
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(146, 32)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(108, 38)
        Me.btnCancelar.TabIndex = 147
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAjustar
        '
        Me.btnAjustar.AutoSize = True
        Me.btnAjustar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAjustar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAjustar.Enabled = False
        Me.btnAjustar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnAjustar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btnAjustar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjustar.ForeColor = System.Drawing.Color.Black
        Me.btnAjustar.Image = Global.PjtLudosII.My.Resources.Resources.accept_business_user
        Me.btnAjustar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjustar.Location = New System.Drawing.Point(40, 32)
        Me.btnAjustar.Name = "btnAjustar"
        Me.btnAjustar.Size = New System.Drawing.Size(100, 38)
        Me.btnAjustar.TabIndex = 146
        Me.btnAjustar.Text = "Ajustar"
        Me.btnAjustar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjustar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAjustar.UseVisualStyleBackColor = False
        '
        'lblNm
        '
        Me.lblNm.AutoSize = True
        Me.lblNm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNm.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblNm.Location = New System.Drawing.Point(18, 117)
        Me.lblNm.Name = "lblNm"
        Me.lblNm.Size = New System.Drawing.Size(13, 19)
        Me.lblNm.TabIndex = 8
        Me.lblNm.Text = "."
        Me.lblNm.Visible = False
        '
        'frmEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 635)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAjustar)
        Me.Controls.Add(Me.pbBtnSaida)
        Me.Controls.Add(Me.pbBtnEntrada)
        Me.Controls.Add(Me.lblSaida)
        Me.Controls.Add(Me.lblEntrada)
        Me.Controls.Add(Me.pnInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmEstoque"
        Me.pnInfo.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbBtnSaida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBtnEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnInfo As System.Windows.Forms.Panel
    Friend WithEvents lsvReduzida As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtEAN As System.Windows.Forms.TextBox
    Friend WithEvents txtQtd As System.Windows.Forms.TextBox
    Friend WithEvents lblQtde As System.Windows.Forms.Label
    Friend WithEvents lblCodProd As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pbBtnSaida As System.Windows.Forms.PictureBox
    Friend WithEvents pbBtnEntrada As System.Windows.Forms.PictureBox
    Friend WithEvents lblSaida As System.Windows.Forms.Label
    Friend WithEvents lblEntrada As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAjustar As System.Windows.Forms.Button
    Friend WithEvents lblNm As System.Windows.Forms.Label
End Class
