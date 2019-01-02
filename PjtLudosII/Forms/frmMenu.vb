Public Class frmMenu
    Private TamanhoBtnIniciar = New Size(197.3, 81)
    Private TamanhoPBtnIniciar = New Size(181, 81)
    Private _operacao As clnFuncoesGerais.MenuIniciar
    Private _operacao2 As clnFuncoesGerais.MenuPrincipal
    Private Fonte12 As New Font("Lucida Sans Unicode", 9.75, FontStyle.Underline Or FontStyle.Bold)
    Private Fonte8 As New Font("Lucida Sans Unicode", 8.25, FontStyle.Underline)
    Private FonteN12 As New Font("Lucida Sans Unicode", 9.75, FontStyle.Regular Or FontStyle.Bold)
    Private FonteN8 As New Font("Lucida Sans Unicode", 8.25, FontStyle.Regular)

    Private Sub frmMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Width = Screen.PrimaryScreen.Bounds.Width
        'Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.lblUser.Text = nomeUsuario
        With Me.pnPrincipal
            .Size = New Size(1014, 635)
            .Location = New Point(0, 65)
        End With

        _operacao = clnFuncoesGerais.MenuIniciar.MenuCadastros
    End Sub
    Private Sub MenuIniciarUser()

        If _operacao = clnFuncoesGerais.MenuIniciar.MenuCadastros Then
            With btn1
                .Font = New Font("Calibri", 15.75)
                .Text = "     Cliente"
                .Image = My.Resources.Resources.clienteIN
                .Visible = True
            End With
            With btn2
                .Text = "      Fornecedor"
                .Image = My.Resources.Resources.fornecedorIN
                .Visible = False
            End With
            With btn3
                .Text = "   Funcionario"
                .Image = My.Resources.Resources.business_user
                .Visible = False
            End With
            LineShape1.Visible = False
            With btn4
                .Location = New Point(0, 236)
                .Text = "  Produto"
                .Image = My.Resources.Resources.produtoIN
                .Visible = False
            End With
            With btn5
                .Location = New Point(0, 318)
                .Text = "   Transportadora"
                .Image = My.Resources.Resources.truck
                .Visible = False
            End With
            With Me.btnInCad
                .Size = TamanhoBtnIniciar
                .FlatAppearance.BorderColor = Color.PaleGreen
                .BackColor = Color.PaleGreen
            End With
            With Me.btnInVenda
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInEst
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInRpt
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInSistema
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With


        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuVendas Then

            With btn1
                .Font = New Font("Calibri", 14.25)
                .Text = "  Novo Orçamento"
                .Image = My.Resources.Resources.note
                .Visible = True
            End With
            With btn2
                .Text = "     Novo Pedido"
                .Image = My.Resources.Resources.pdvin
                .Visible = True
            End With
            With btn3
                .Text = "  Lista de Pedidos"
                .Image = My.Resources.Resources.shopping_cart
                .Visible = True
            End With
            LineShape1.Visible = True
            With btn4
                .Location = New Point(0, 253)
                .Text = "   Novo Cliente"
                .Image = My.Resources.Resources.male_female_users
                .Visible = True
            End With
            With btn5
                .Location = New Point(0, 339)
                .Text = "   Lista Clientes"
                .Image = My.Resources.Resources.book_search
                .Visible = True
            End With
            With Me.btnInCad
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInEst
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInRpt
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInSistema
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInVenda
                .Size = TamanhoBtnIniciar
                .FlatAppearance.BorderColor = Color.PaleGreen
                .BackColor = Color.PaleGreen
            End With

        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuEstoque Then

            With btn1
                .Text = "  Lista de Produtos"
                .Image = My.Resources.accept_page
                .Visible = True
            End With
            With btn2
                .Text = "  Estoque Atual"
                .Image = My.Resources.package_accept
                .Visible = True
            End With
            With btn3
                .Text = "  Entrada NF"
                .Image = My.Resources.edit_page
                .Visible = False
            End With
            With btn4
                .Location = New Point(0, 236)
                .Text = "  Ajuste de Estoque"
                .Image = My.Resources.package_download
                .Visible = False
            End With
            With btn5
                .Text = "  Pedido de Compra"
                .Image = My.Resources.shopping_basket_accept
                .Visible = False
            End With
            With Me.btnInCad
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInVenda
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInRpt
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInSistema
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInEst
                .Size = TamanhoBtnIniciar
                .FlatAppearance.BorderColor = Color.PaleGreen
                .BackColor = Color.PaleGreen
            End With

        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuRelatorios Then

            With btn1
                .Text = "  Lista de Produtos"
                .Image = My.Resources.estoquein
                .Visible = True
            End With
            With btn2
                .Visible = False
            End With
            With btn3
                .Visible = False
            End With
            With btn4
                .Visible = False
            End With
            With btn5
                .Visible = False
            End With
            With Me.btnInCad
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInVenda
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInEst
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInSistema
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInRpt
                .Size = TamanhoBtnIniciar
                .FlatAppearance.BorderColor = Color.PaleGreen
                .BackColor = Color.PaleGreen
            End With
        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuSistema Then

            With btn1
                .Text = "  Cadastro de Usuários"
                .Image = My.Resources.estoquein
                .Visible = False
            End With
            With btn2
                .Visible = False
            End With
            With btn3
                .Visible = False
            End With
            With btn4
                .Visible = False
            End With
            With btn5
                .Visible = False
            End With
            With Me.btnInCad
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInVenda
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInEst
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInRpt
                .Size = TamanhoBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInSistema
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.PaleGreen
                .BackColor = Color.PaleGreen
            End With
        End If
    End Sub

    Private Sub MenuIniciar()

        If _operacao = clnFuncoesGerais.MenuIniciar.MenuCadastros Then
            With btn1
                .Font = New Font("Calibri", 15.75)
                .Text = "     Cliente"
                .Image = My.Resources.Resources.clienteIN
            End With
            With btn2
                .Text = "      Fornecedor"
                .Image = My.Resources.Resources.fornecedorIN
                .Visible = True
            End With
            With btn3
                .Text = "   Funcionario"
                .Image = My.Resources.Resources.business_user
                .Visible = True
            End With
            LineShape1.Visible = False
            With btn4
                .Location = New Point(0, 236)
                .Text = "  Produto"
                .Image = My.Resources.Resources.produtoIN
                .Visible = True
            End With
            With btn5
                .Location = New Point(0, 318)
                .Text = "   Transportadora"
                .Image = My.Resources.Resources.truck
                .Visible = True
            End With
            With Me.btnInCad
                .Size = TamanhoBtnIniciar
                .FlatAppearance.BorderColor = Color.PaleGreen
                .BackColor = Color.PaleGreen
            End With
            With Me.btnInVenda
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInEst
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInRpt
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInSistema
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With


        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuVendas Then

            With btn1
                .Font = New Font("Calibri", 14.25)
                .Text = "  Novo Orçamento"
                .Image = My.Resources.Resources.note
            End With
            With btn2
                .Text = "     Novo Pedido"
                .Image = My.Resources.Resources.pdvin
                .Visible = True
            End With
            With btn3
                .Text = "  Lista de Pedidos"
                .Image = My.Resources.Resources.shopping_cart
                .Visible = True
            End With
            LineShape1.Visible = True
            With btn4
                .Location = New Point(0, 253)
                .Text = "   Novo Cliente"
                .Image = My.Resources.Resources.male_female_users
                .Visible = True
            End With
            With btn5
                .Location = New Point(0, 339)
                .Text = "   Lista Clientes"
                .Image = My.Resources.Resources.book_search
                .Visible = True
            End With
            With Me.btnInCad
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInEst
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInRpt
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInSistema
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInVenda
                .Size = TamanhoBtnIniciar
                .FlatAppearance.BorderColor = Color.PaleGreen
                .BackColor = Color.PaleGreen
            End With

        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuEstoque Then

            With btn1
                .Text = "  Lista de Produtos"
                .Image = My.Resources.accept_page
                .Visible = True
            End With
            With btn2
                .Text = "  Estoque Atual"
                .Image = My.Resources.package_accept
                .Visible = True
            End With
            With btn3
                .Text = "  Entrada NF"
                .Image = My.Resources.edit_page
                .Visible = True
            End With
            With btn4
                .Location = New Point(0, 236)
                .Text = "  Ajuste de Estoque"
                .Image = My.Resources.package_download
                .Visible = True
            End With
            With btn5
                .Text = "  Pedido de Compra"
                .Image = My.Resources.shopping_basket_accept
                .Visible = True
            End With
            With Me.btnInCad
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInVenda
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInRpt
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInSistema
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInEst
                .Size = TamanhoBtnIniciar
                .FlatAppearance.BorderColor = Color.PaleGreen
                .BackColor = Color.PaleGreen
            End With

        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuRelatorios Then

            With btn1
                .Text = "  Lista de Produtos"
                .Image = My.Resources.estoquein
            End With
            With btn2
                .Visible = False
            End With
            With btn3
                .Visible = False
            End With
            With btn4
                .Visible = False
            End With
            With btn5
                .Visible = False
            End With
            With Me.btnInCad
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInVenda
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInEst
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInSistema
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInRpt
                .Size = TamanhoBtnIniciar
                .FlatAppearance.BorderColor = Color.PaleGreen
                .BackColor = Color.PaleGreen
            End With
        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuSistema Then

            With btn1
                .Text = "  Cadastro de Usuários"
                .Image = My.Resources.estoquein
            End With
            With btn2
                .Visible = False
            End With
            With btn3
                .Visible = False
            End With
            With btn4
                .Visible = False
            End With
            With btn5
                .Visible = False
            End With
            With Me.btnInCad
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInVenda
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInEst
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInRpt
                .Size = TamanhoBtnIniciar
                .FlatAppearance.BorderColor = Color.WhiteSmoke
                .BackColor = Color.WhiteSmoke
            End With
            With Me.btnInSistema
                .Size = TamanhoPBtnIniciar
                .FlatAppearance.BorderColor = Color.PaleGreen
                .BackColor = Color.PaleGreen
            End With
        End If
    End Sub

    Private Sub btnInCad_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnInCad.MouseHover
        _operacao = clnFuncoesGerais.MenuIniciar.MenuCadastros

        If perfilUsuario = "Admin" Then
            MenuIniciar()
        Else
            MenuIniciarUser()
        End If


    End Sub

    Private Sub btnInVenda_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnInVenda.MouseHover
        _operacao = clnFuncoesGerais.MenuIniciar.MenuVendas
        If perfilUsuario = "Admin" Then
            MenuIniciar()
        Else
            MenuIniciarUser()
        End If
    End Sub

    Private Sub btnInEst_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnInEst.MouseHover
        _operacao = clnFuncoesGerais.MenuIniciar.MenuEstoque
        If perfilUsuario = "Admin" Then
            MenuIniciar()
        Else
            MenuIniciarUser()
        End If
    End Sub

    Private Sub btnInRpt_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnInRpt.MouseHover
        _operacao = clnFuncoesGerais.MenuIniciar.MenuRelatorios
        If perfilUsuario = "Admin" Then
            MenuIniciar()
        Else
            MenuIniciarUser()
        End If
    End Sub

    Private Sub btnInSistema_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnInSistema.MouseHover
        _operacao = clnFuncoesGerais.MenuIniciar.MenuSistema
        If perfilUsuario = "Admin" Then
            MenuIniciar()
        Else
            MenuIniciarUser()
        End If
    End Sub

    Private Sub MenuPrincipal()
        If _operacao2 = clnFuncoesGerais.MenuPrincipal.MPrincCliente Then

            With pnPDVP
                .Visible = False
            End With
            With pnEstoqueP
                .Visible = False
            End With
            With pnProdutoP
                .Visible = False
            End With
            With pnClienteP
                .Visible = True
            End With

        ElseIf _operacao2 = clnFuncoesGerais.MenuPrincipal.MPrincPDV Then

            With pnEstoqueP
                .Visible = False
            End With
            With pnProdutoP
                .Visible = False
            End With
            With pnClienteP
                .Visible = False
            End With
            With pnPDVP
                .Visible = True
            End With

        ElseIf _operacao2 = clnFuncoesGerais.MenuPrincipal.MPrincEstoque Then

            With pnProdutoP
                .Visible = False
            End With
            With pnClienteP
                .Visible = False
            End With
            With pnPDVP
                .Visible = False
            End With
            With pnEstoqueP
                .Visible = True
            End With


        ElseIf _operacao2 = clnFuncoesGerais.MenuPrincipal.MPrincProduto Then

            With pnClienteP
                .Visible = False
            End With
            With pnPDVP
                .Visible = False
            End With
            With pnEstoqueP
                .Visible = False
            End With
            With pnProdutoP
                .Visible = True
            End With
        End If

    End Sub

    Private Sub pbCmbClienteP_MouseHover(sender As Object, e As System.EventArgs) Handles pbCmbClienteP.MouseHover, lblCmbClienteP.MouseHover
        _operacao2 = clnFuncoesGerais.MenuPrincipal.MPrincCliente
        MenuPrincipal()
    End Sub

    Private Sub pbCmbPDVP_MouseHover(sender As Object, e As System.EventArgs) Handles pbCmbPDVP.MouseHover, lblCmbPDVP.MouseHover
        _operacao2 = clnFuncoesGerais.MenuPrincipal.MPrincPDV
        MenuPrincipal()
    End Sub

    Private Sub pbCmbEstoqueP_MouseHover(sender As Object, e As System.EventArgs) Handles pbCmbEstoqueP.MouseHover, lblCmbEstoqueP.MouseHover
        _operacao2 = clnFuncoesGerais.MenuPrincipal.MPrincEstoque
        MenuPrincipal()
    End Sub

    Private Sub pbCmbProdutoP_MouseHover(sender As Object, e As System.EventArgs) Handles pbCmbProdutoP.MouseHover, lblCmbProdutoP.MouseHover
        _operacao2 = clnFuncoesGerais.MenuPrincipal.MPrincProduto
        MenuPrincipal()
    End Sub

    Private Sub Iniciar()
        If Me.pnMenuIN.Visible = True Then
            Me.pnMenuIN.Visible = False
            Me.btnIniciarP.BackgroundImage = My.Resources.btnIniciar
            Me.pnMenuIN.Visible = False

        Else
            Me.btnIniciarP.BackgroundImage = My.Resources.btnIniciar2
            With Me.pnMenuIN
                .Size = New Size(505, 469)
                .Visible = True
                .Location = New Point(0, 66)
            End With
            If perfilUsuario = "Admin" Then
                MenuIniciar()
            Else
                MenuIniciarUser()
            End If
        End If

    End Sub

    Private Sub FechaMDIParent()
        For Each Frm As Form In Me.MdiChildren 'Sub para Fechar todos os MDi parents aberto MDI Menu
            Frm.Close()
        Next Frm
    End Sub

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        FechaMDIParent()
        If _operacao = clnFuncoesGerais.MenuIniciar.MenuCadastros Then
            pnPrincipal.Visible = False
            Dim ObjFrmCliente As New frmCliente
            With ObjFrmCliente
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()

        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuSistema Then
            pnPrincipal.Visible = False
            Dim ObjFrmCadUser As New frmCadUser
            With ObjFrmCadUser
                .MdiParent = Me
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()
        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuEstoque Then
            pnPrincipal.Visible = False
            Dim ObjFrmProduto As New frmProduto
            If perfilUsuario = "Admin" Then
                With ObjFrmProduto
                    .MdiParent = Me
                    .ModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
                    .Location = New Point(0, 65)
                    .Show()
                End With
                Iniciar()
            Else
                With ObjFrmProduto
                    .MdiParent = Me
                    .ModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
                    .ModoListar = clnFuncoesGerais.ModoListar.ModoListarProdutos
                    .Location = New Point(0, 65)
                    .pbNext.Visible = False
                    .Show()
                End With
                Iniciar()
            End If

        End If

    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        FechaMDIParent()
        If _operacao = clnFuncoesGerais.MenuIniciar.MenuCadastros Then
            pnPrincipal.Visible = False
            Dim ObjFrmFornecedor As New frmFornecedor
            With ObjFrmFornecedor
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()
        End If

        If _operacao = clnFuncoesGerais.MenuIniciar.MenuVendas Then
            pnPrincipal.Visible = False
            Dim ObjFrmPedido As New frmPedido
            With ObjFrmPedido
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
                .TpVenda = clnFuncoesGerais.TPVENDA.Telefone
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()

        ElseIf _operacao = clnFuncoesGerais.MenuIniciar.MenuEstoque Then
            pnPrincipal.Visible = False
            Dim ObjFrmProduto As New frmProduto
            With ObjFrmProduto
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
                .ModoListar = clnFuncoesGerais.ModoListar.ModoListarEstoque
                .Location = New Point(0, 65)
                .pbNext.Visible = False
                .Show()
            End With
                Iniciar()
            End If


    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click

        FechaMDIParent()
        If _operacao = clnFuncoesGerais.MenuIniciar.MenuCadastros Then
            pnPrincipal.Visible = False
            Dim ObjFrmFuncionario As New frmFuncionario
            With ObjFrmFuncionario
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.MOdoCadastro
                .operacao = clnFuncoesGerais.IncluirAlterar.Inclusao
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()
        End If

        If _operacao = clnFuncoesGerais.MenuIniciar.MenuEstoque Then
            pnPrincipal.Visible = False
            Dim ObjFrmPedidoCompra As New frmPedidoCompra
            With ObjFrmPedidoCompra
                .ModoForm = clnFuncoesGerais.ModoForm.ModoNF
                .MdiParent = Me
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()
        End If

    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click

        FechaMDIParent()
        If _operacao = clnFuncoesGerais.MenuIniciar.MenuCadastros Then
            pnPrincipal.Visible = False
            Dim ObjFrmProduto As New frmProduto
            With ObjFrmProduto
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.MOdoCadastro
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()
        End If

        If _operacao = clnFuncoesGerais.MenuIniciar.MenuVendas Then
            pnPrincipal.Visible = False
            Dim ObjFrmCliente As New frmCliente
            With ObjFrmCliente
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()
        End If

        If _operacao = clnFuncoesGerais.MenuIniciar.MenuEstoque Then
            pnPrincipal.Visible = False
            Dim ObjFrmEstoque As New frmEstoque
            With ObjFrmEstoque
                .MdiParent = Me
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()
        End If

    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        FechaMDIParent()
        If _operacao = clnFuncoesGerais.MenuIniciar.MenuCadastros Then
            pnPrincipal.Visible = False
            Dim ObjFrmTransportadora As New frmTransportadora
            With ObjFrmTransportadora
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.MOdoCadastro
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()
        End If

        If _operacao = clnFuncoesGerais.MenuIniciar.MenuVendas Then
            pnPrincipal.Visible = False
            Dim ObjFrmCliente As New frmCliente
            With ObjFrmCliente
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()
        End If

        If _operacao = clnFuncoesGerais.MenuIniciar.MenuEstoque Then
            pnPrincipal.Visible = False
            Dim ObjFrmPedidoCompra As New frmPedidoCompra
            With ObjFrmPedidoCompra
                .ModoForm = clnFuncoesGerais.ModoForm.ModoPDC
                .MdiParent = Me
                .Location = New Point(0, 65)
                .Show()
            End With
            Iniciar()
        End If


    End Sub

    Private Sub lblBtnNProduto_MouseHover(sender As Object, e As System.EventArgs) Handles lblBtnNProduto.MouseHover, lblDsNProduto.MouseHover
        Me.lblBtnNProduto.Font = Fonte12
        Me.lblDsNProduto.Font = Fonte8
    End Sub

    Private Sub lblBtnNProduto_MouseLeave(sender As Object, e As System.EventArgs) Handles lblBtnNProduto.MouseLeave, lblDsNProduto.MouseLeave
        Me.lblBtnNProduto.Font = FonteN12
        Me.lblDsNProduto.Font = FonteN8
    End Sub

    Private Sub lblBtnLProduto_MouseHover(sender As Object, e As System.EventArgs) Handles lblBtnLProduto.MouseHover, lblDsLProduto.MouseHover
        Me.lblBtnLProduto.Font = Fonte12
        Me.lblDsLProduto.Font = Fonte8
    End Sub

    Private Sub lblBtnLProduto_MouseLeave(sender As Object, e As System.EventArgs) Handles lblBtnLProduto.MouseLeave, lblDsLProduto.MouseLeave
        Me.lblBtnLProduto.Font = FonteN12
        Me.lblDsLProduto.Font = FonteN8
    End Sub

    Private Sub pbCmbProdutoP_Click(sender As System.Object, e As System.EventArgs) Handles pbCmbProdutoP.Click, lblCmbProdutoP.Click, lblBtnNProduto.Click, lblDsNProduto.Click
        pnPrincipal.Visible = False
        Dim ObjFrmProduto As New frmProduto
        With ObjFrmProduto
            .MdiParent = Me
            .ModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
            .Location = New Point(0, 65)
            .Show()
        End With
    End Sub

    Private Sub pbCmbPDVP_Click(sender As System.Object, e As System.EventArgs) Handles pbCmbPDVP.Click

        frmPedido.MdiParent = Me
        pnPrincipal.Visible = False

        With frmPedido
            .TpVenda = clnFuncoesGerais.TPVENDA.Telefone
            .ModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
            .Show()
            .Location = New Point(0, 65)
        End With

    End Sub

    Private Sub pbCmbClienteP_Click(sender As System.Object, e As System.EventArgs) Handles lblCmbClienteP.Click, pbCmbClienteP.Click

        pnPrincipal.Visible = False

        Dim ObjFrmCliente As New frmCliente
        With ObjFrmCliente
            .MdiParent = Me
            .ModoForm = clnFuncoesGerais.ModoForm.MOdoCadastro
            .Location = New Point(0, 65)
            .Show()
        End With

    End Sub

    Private Sub btnVendaBalcao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendaBalcao.Click, lblVendaBalcao.Click
        frmPedido.MdiParent = Me
        pnPrincipal.Visible = False
        With frmPedido
            .TpVenda = clnFuncoesGerais.TPVENDA.Balcao
            .ModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
            .Show()
            .Location = New Point(0, 65)
        End With
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        FechaMDIParent()
        Me.pnPrincipal.Visible = True
        pnMenuIN.Visible = False
        Me.lblInfoTela.Text = "Menu"
    End Sub

    Private Sub btnIniciarP_Click(sender As Object, e As System.EventArgs) Handles btnIniciarP.Click
        Iniciar()
    End Sub

    Private Sub btnIniciarP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnIniciarP.Leave
        pnMenuIN.Visible = False
    End Sub


    Private Sub lblBtnListaCliente_Click(sender As System.Object, e As System.EventArgs) Handles lblBtnListaCliente.Click, lblDsListaCliente.Click
        pnPrincipal.Visible = False
        Dim ObjFrmCliente As New frmCliente

        With ObjFrmCliente
            .MdiParent = Me
            .ModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
            .Location = New Point(0, 65)
            .Show()
        End With
    End Sub

    Private Sub lblBtnListaCliente_MouseHover(sender As Object, e As System.EventArgs) Handles lblBtnListaCliente.MouseHover, lblDsListaCliente.MouseHover
        Me.lblBtnListaCliente.Font = Fonte12
        Me.lblDsListaCliente.Font = Fonte8
    End Sub

    Private Sub lblBtnListaCliente_MouseLeave(sender As Object, e As System.EventArgs) Handles lblBtnListaCliente.MouseLeave, lblDsListaCliente.MouseLeave
        Me.lblBtnListaCliente.Font = FonteN12
        Me.lblDsListaCliente.Font = FonteN8
    End Sub


    Private Sub lblBtnLProduto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBtnLProduto.Click, lblDsLProduto.Click
        pnPrincipal.Visible = False
        Dim ObjFrmProduto As New frmProduto
        If perfilUsuario = "Admin" Then
            With ObjFrmProduto
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
                .ModoListar = clnFuncoesGerais.ModoListar.ModoListarProdutos
                .Location = New Point(0, 65)
                .Show()
            End With
        Else
            With ObjFrmProduto
                .MdiParent = Me
                .ModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
                .ModoListar = clnFuncoesGerais.ModoListar.ModoLProdutoUser
                .Location = New Point(0, 65)
                .pbNext.Visible = False
                .Show()
            End With
        End If
    End Sub

    Private Sub pbBtnSair_Click(sender As System.Object, e As System.EventArgs) Handles pbBtnSair.Click
        If (MessageBox.Show("Deseja sair do programa ?", Me.Text, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
            Application.Exit()
        Else
            MessageBox.Show("OPERAÇÃO CANCELADA", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        frmLogin.Show()
        Me.Close()
        
    End Sub

    Private Sub lblBtnEstAtual_Click(sender As System.Object, e As System.EventArgs) Handles lblBtnEstAtual.Click, lblDsEstAtual.Click, pbCmbEstoqueP.Click
        pnPrincipal.Visible = False
        Dim ObjFrmProduto As New frmProduto
        With ObjFrmProduto
            .MdiParent = Me
            .ModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
            .ModoListar = clnFuncoesGerais.ModoListar.ModoListarEstoque
            .Location = New Point(0, 65)
            .pbNext.Visible = False
            .Show()
        End With
    End Sub

   
    Private Sub lblBtnAjustaEst_MouseHover(sender As Object, e As System.EventArgs) Handles lblBtnAjustaEst.MouseHover, lblDsAjustaEst.MouseHover
        Me.lblBtnAjustaEst.Font = Fonte12
        Me.lblDsAjustaEst.Font = Fonte8
    End Sub

    Private Sub lblBtnAjustaEst_MouseLeave(sender As Object, e As System.EventArgs) Handles lblBtnAjustaEst.MouseLeave, lblDsAjustaEst.MouseLeave
        Me.lblBtnAjustaEst.Font = FonteN12
        Me.lblDsAjustaEst.Font = FonteN8
    End Sub

    Private Sub lblBtnEstAtual_MouseHover(sender As Object, e As System.EventArgs) Handles lblBtnEstAtual.MouseHover, lblDsEstAtual.MouseHover
        Me.lblBtnEstAtual.Font = Fonte12
        Me.lblDsEstAtual.Font = Fonte8
    End Sub

    Private Sub lblBtnEstAtual_MouseLeave(sender As Object, e As System.EventArgs) Handles lblBtnEstAtual.MouseLeave, lblDsEstAtual.MouseLeave
        Me.lblBtnEstAtual.Font = FonteN12
        Me.lblDsEstAtual.Font = FonteN8
    End Sub

    
    Private Sub lblBtnNPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBtnNPedido.Click, lblDsNPedido.Click
        frmPedido.MdiParent = Me
        pnPrincipal.Visible = False

        With frmPedido
            .TpVenda = clnFuncoesGerais.TPVENDA.Telefone
            .ModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
            .Show()
            .Location = New Point(0, 65)
        End With

    End Sub

    Private Sub lblBtnNPedido_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBtnNPedido.MouseHover, lblDsNPedido.MouseHover
        Me.lblBtnNPedido.Font = Fonte12
        Me.lblDsNPedido.Font = Fonte8
    End Sub

    Private Sub lblBtnNPedido_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBtnNPedido.MouseLeave, lblDsNPedido.MouseLeave
        Me.lblBtnNPedido.Font = FonteN12
        Me.lblDsNPedido.Font = FonteN8
    End Sub

    Private Sub lblBtnNCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBtnNCliente.Click, lblDsNCliente.Click
        pnPrincipal.Visible = False

        Dim ObjFrmCliente As New frmCliente
        With ObjFrmCliente
            .MdiParent = Me
            .ModoForm = clnFuncoesGerais.ModoForm.ModoCadastro
            .Location = New Point(0, 65)
            .Show()
        End With

    End Sub

    Private Sub lblBtnNCliente_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBtnNCliente.MouseHover, lblDsNCliente.MouseHover
        Me.lblBtnNCliente.Font = Fonte12
        Me.lblDsNCliente.Font = Fonte8
    End Sub

    Private Sub lblBtnNCliente_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBtnNCliente.MouseLeave, lblDsNCliente.MouseLeave
        Me.lblBtnNCliente.Font = FonteN12
        Me.lblDsNCliente.Font = FonteN8
    End Sub

    Private Sub lblBtnAjustaEst_Click(sender As System.Object, e As System.EventArgs) Handles lblBtnAjustaEst.Click, lblDsAjustaEst.Click
        pnPrincipal.Visible = False

        Dim ObjFrmEstoque As New frmEstoque
        With ObjFrmEstoque
            .MdiParent = Me
            .Location = New Point(0, 65)
            .Show()
        End With
    End Sub


    Private Sub pnPrincipal_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnPrincipal.Paint

    End Sub

    Private Sub lblBtnListaPDV_Click(sender As System.Object, e As System.EventArgs) Handles lblBtnListaPDV.Click
        frmPedido.MdiParent = Me
        pnPrincipal.Visible = False

        With frmPedido
            .TpVenda = clnFuncoesGerais.TPVENDA.Telefone
            .ModoForm = clnFuncoesGerais.ModoForm.ModoPesquisa
            .Show()
            .Location = New Point(0, 65)
        End With
    End Sub
End Class