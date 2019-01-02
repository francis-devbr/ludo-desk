<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputBox
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
        Me.Txt_TextEntry = New System.Windows.Forms.MaskedTextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Lbl_Prompt = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Txt_TextEntry
        '
        Me.Txt_TextEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_TextEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TextEntry.Location = New System.Drawing.Point(26, 84)
        Me.Txt_TextEntry.Name = "Txt_TextEntry"
        Me.Txt_TextEntry.Size = New System.Drawing.Size(249, 26)
        Me.Txt_TextEntry.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(343, 208)
        Me.ShapeContainer1.TabIndex = 17
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.DarkRed
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(-1, 183)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(345, 25)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.DimGray
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.Location = New System.Drawing.Point(-1, -1)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(350, 45)
        '
        'Lbl_Prompt
        '
        Me.Lbl_Prompt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Prompt.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Prompt.ForeColor = System.Drawing.Color.DimGray
        Me.Lbl_Prompt.Location = New System.Drawing.Point(22, 58)
        Me.Lbl_Prompt.Name = "Lbl_Prompt"
        Me.Lbl_Prompt.Size = New System.Drawing.Size(150, 23)
        Me.Lbl_Prompt.TabIndex = 18
        Me.Lbl_Prompt.Text = "Senha"
        Me.Lbl_Prompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnSair.Image = Global.PjtLudosII.My.Resources.Resources.block
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(167, 116)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(108, 38)
        Me.btnSair.TabIndex = 142
        Me.btnSair.Text = "Cancelar"
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
        Me.btnOk.Image = Global.PjtLudosII.My.Resources.Resources.accept
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(26, 116)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(108, 38)
        Me.btnOk.TabIndex = 141
        Me.btnOk.Text = "Alterar"
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'InputBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(343, 208)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Lbl_Prompt)
        Me.Controls.Add(Me.Txt_TextEntry)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InputBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar Pedido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_TextEntry As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Lbl_Prompt As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip

End Class
