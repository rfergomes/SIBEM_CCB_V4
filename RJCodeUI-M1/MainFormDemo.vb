Public Class MainFormDemo
    Inherits RJMainForm

    ''' <summary>
    ''' This class inherits from the <RJMainForm /> class
    ''' The PARTIAL class is who should inherit from RJMainForm (Found in MainFormDemo.Designer.vb):
    '''     Partial Class MainFormDemo
    '''             Inherits RJMainForm
    ''' It is optional that this class inherits from RJMainForm
    ''' </summary>
    ''' 

#Region "-> Fields"

    Private userConnected As UsuarioDTO 'Gets or sets the user who is logged in.
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private sistemaBLL As SistemaBLL

#End Region

#Region "-> Constructor"

    Public Sub New()
        InitializeComponent()
        InitializeItems()
        InitializeSystem()
        lblUserName.Text = "CCB"
        LblVersao.Text = $"V{SistemaVersao()}"
        StatusLabelDesenvolvedor.Text = $"SIBEM CCB© v{SistemaVersao()}  - 2020/{Year(Now())} - Todos os direitos reservados - by Rodrigo Lima"
        StatusLabelDataHora.Text = Today.ToLongDateString.ToString() & " " & Now.ToLongTimeString.ToString
    End Sub


    Public Sub New(user As UsuarioDTO)
        InitializeComponent()
        InitializeItems()
        InitializeSystem()
        userConnected = user
        lblUserName.Text = ObterPrimeiroNomeEInicial(user.Nome.ToUpper())
        LblVersao.Text = "V" & SistemaVersao()
        StatusLabelDesenvolvedor.Text = $"SIBEM CCB© v{SistemaVersao()}  - 2020/{Year(Now())} - Todos os direitos reservados - by Rodrigo Lima"
        StatusLabelDataHora.Text = Today.ToLongDateString.ToString() & " " & Now.ToLongTimeString.ToString
    End Sub

    Private Sub InitializeItems()
        biFormOptions.DropdownMenu = Me.dmFormOptions 'Establecer menú desplegable de opciones de formulario
        If UIAppearance.Style = UIStyle.Supernova Then 'Si es estilo es supernova, establecer el logo con color.
            pbSideMenuLogo.Image = My.Resources.SIBEM_Logo_Branco
        End If
    End Sub

    Private Sub InitializeSystem()
        Dim sistemaBLL = New SistemaBLL(SQLite)
        Dim Sistema As List(Of SistemaDTO) = sistemaBLL.BuscarTodos()

        '' Atribui o primeiro elemento da lista, caso ela não esteja vazia
        If Sistema.Count > 0 Then
            VarGlob.SistemaAtivo = Sistema.FirstOrDefault(Function(s) s.Ativo = -1)
            If VarGlob.SistemaAtivo IsNot Nothing Then
                With VarGlob.SistemaAtivo
                    LblSubTitulo.Text = $"{ .Adm_Regional} | { .Adm_Local}"
                End With
                '    Else
                '        Dim Form As Form = New FormToken
                '        Form.ShowDialog()
            End If

            'Else
            '    Dim Form As Form = New FormToken
            '    Form.ShowDialog()
        End If
        If VarGlob.UsuarioLogado IsNot Nothing Then
            If VarGlob.UsuarioLogado.Tipo = "admin" Then LogToolStripMenuItem.Visible = True
        End If
    End Sub
#End Region

#Region "-> Event methods"

    '- >>> How to use the OpenChildForm <childForm> (...) method

    'You can use the Func <TResult> delegate with anonymous methods or lambda expression,
    'for example, we can call this method as follows:
    'Me.OpenChildForm (Function () New MyForm (id))

#Region "- Open child form"
    '- >>> (User options drop-down menu)

    'Using the OpenChildForm (Of childForm As RJChildForm) (_ delegate As Func (Of childForm)) method
    Private Sub MyProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyProfileToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormUserProfile(userConnected))
        'Function (): Call the generic delegate
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Me.OpenChildForm(Function() New RJSettingsForm())
    End Sub

#End Region

#Region "- Open child form from a menu button (RJMenuButton)"
    '- >>> (Side menu)

    'Using the OpenChildForm (Of childForm As RJChildForm) (_ delegate As Func (Of childForm), senderMenuButton As Object) method
    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        OpenChildForm(Function() New FormInventarios(), sender)
        'Function (): Call the generic delegate
        'sender: btnUserControls (MenuButton)
    End Sub

    Private Sub btnSincronizar_Click(sender As Object, e As EventArgs) Handles btnSincronizar.Click
        'Me.OpenChildForm(Function() New FormProducts(), sender)
        OpenChildForm(Function() New FormSincronizar(), sender)
    End Sub

    Private Sub BtnConfiguracoes_Click(sender As Object, e As EventArgs) Handles BtnConfiguracoes.Click
        OpenChildForm(Function() New FormConfiguracoes(), sender)
    End Sub

    Private Sub BtnRelatorios_Click(sender As Object, e As EventArgs) Handles BtnRelatorios.Click
        OpenChildForm(Function() New FormRelatorios(), sender)
    End Sub

#End Region

#Region "- Open child form from a drop-down menu item associated with a menu button (RJMenuButton-> RJDropdownMenu)"
    '- >>> (Side menu)

    'Using the method OpenChildForm (Of childForm As RJChildForm) (_ delegate As Func (Of childForm), senderMenuItem As Object, ownerMenuButton As RJMenuButton)
    Private Sub CommonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommonToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormCommonControls(), sender, btnDashboard)
        'Funtion (): Call the generic delegate
        'sender: commonToolStripMenuItem (dmCustomControls Menu Item)
        'btnCustomControls: Menu Button
    End Sub

    Private Sub MenusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenusToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormMenuControls(), sender, btnDashboard)
    End Sub

    Private Sub ContainersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContainersToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormContainerControls(), sender, btnDashboard)
    End Sub

    Private Sub DataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormDataControls(), sender, btnDashboard)
    End Sub

    Private Sub ComponentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComponentsToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormComponentControls(), sender, btnDashboard)
    End Sub

    Private Sub SpecialsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpecialsToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormSpecialControls(), sender, btnDashboard)
    End Sub

    Private Sub SalesListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesListToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormSalesOrder(), sender, btnDashboard)
    End Sub

    Private Sub BaseFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaseFormToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormRJBaseDoc(), sender, btnCadastros)
    End Sub

    Private Sub MainFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainFormToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormRJMainDoc(), sender, btnCadastros)
    End Sub

    Private Sub ChildFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChildFormToolStripMenuItem.Click
        Me.OpenChildForm(Function() New FormRJChildDoc(), sender, btnCadastros)
    End Sub
#End Region

#Region "- User options"
    '- >>> (User options drop-down menu)
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        My.Settings.Login = True
        My.Settings.Save()
        Application.Restart()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.CloseWindow()
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogToolStripMenuItem.Click
        Try
            Process.Start("Files\SIBEM_Log.txt")
        Catch ex As Exception
            RJMessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Try
            Process.Start("Files\SIBEM_Manual.pdf")
        Catch ex As Exception
            RJMessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDashboard_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click
        OpenChildForm(Function() New FormDashboard(), sender)
    End Sub

    Private Sub CadastroItemBensMoveis_Click(sender As Object, e As EventArgs) Handles CadastroItemBensMoveis.Click
        Me.OpenChildForm(Function() New FormBensMoveis())
    End Sub

    Private Sub CadastroItemIgrejas_Click(sender As Object, e As EventArgs) Handles CadastroItemIgrejas.Click
        Me.OpenChildForm(Function() New FormIgrejas())
    End Sub

    Private Sub CadastroItemDependencias_Click(sender As Object, e As EventArgs) Handles CadastroItemDependencias.Click
        Me.OpenChildForm(Function() New FormDependencias())
    End Sub

    Private Sub CadastroItemSetores_Click(sender As Object, e As EventArgs) Handles CadastroItemSetores.Click
        Me.OpenChildForm(Function() New FormSetores())
    End Sub

    Private Sub CadastroItemStatus_Click(sender As Object, e As EventArgs) Handles CadastroItemStatus.Click
        Me.OpenChildForm(Function() New FormStatus())
    End Sub

    Private Sub NovaAdmMenuItem_Click(sender As Object, e As EventArgs) Handles NovaAdmMenuItem.Click
        Dim Form As Form = New FormToken
        Form.ShowDialog()
    End Sub

    Private Sub TrocaAdmMenuItem_Click(sender As Object, e As EventArgs) Handles TrocaAdmMenuItem.Click
        Dim Form As Form = New FormAdministracao
        Form.ShowDialog()
    End Sub


#End Region

#Region "- Versão do Sistema"
    Private Function SistemaVersao() As String
        Dim Versao As String
        Try
            ' Verifica se o aplicativo foi implantado com ClickOnce
            If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
                Dim versaoPublicada As Version = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion
                Versao = versaoPublicada.ToString()
            Else
                ' Exibe a versão do assembly se não for uma versão publicada com ClickOnce
                Versao = Application.ProductVersion
            End If
        Catch ex As System.Deployment.Application.InvalidDeploymentException
            ' Trata o caso em que a função é chamada fora de um ambiente ClickOnce
            Versao = Application.ProductVersion
        End Try
        Return Versao
    End Function



    Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles BtnInfo.Click
        Dim Form As Form = New FormInfo
        Form.ShowDialog()
    End Sub

#End Region

#End Region

End Class