<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFormDemo
    Inherits PROJETOBASE.RJMainForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFormDemo))
        Me.pbSideMenuLogo = New System.Windows.Forms.PictureBox()
        Me.btnDashboard = New PROJETOBASE.RJMenuButton()
        Me.dmCustomControls = New PROJETOBASE.RJDropdownMenu(Me.components)
        Me.CommonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContainersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComponentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnInventario = New PROJETOBASE.RJMenuButton()
        Me.BtnConfiguracoes = New PROJETOBASE.RJMenuButton()
        Me.dmSalesOrder = New PROJETOBASE.RJDropdownMenu(Me.components)
        Me.NewSaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingDeliveriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HightPriorityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MediumPriorityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LowPriorityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DropDalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenewSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSincronizar = New PROJETOBASE.RJMenuButton()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.dmUserOptions = New PROJETOBASE.RJDropdownMenu(Me.components)
        Me.MyProfileToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.AdminToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.TrocaAdmMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.NovaAdmMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.SettingsToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.TermsAndCondToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.HelpToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.LogoutToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.ExitToolStripMenuItem = New FontAwesome.Sharp.IconMenuItem()
        Me.biFormOptions = New PROJETOBASE.RJMenuIcon()
        Me.biNotifications = New PROJETOBASE.RJMenuIcon()
        Me.biUserOptions = New PROJETOBASE.RJMenuIcon()
        Me.lblUserName = New PROJETOBASE.RJLabel()
        Me.dmCustomForms = New PROJETOBASE.RJDropdownMenu(Me.components)
        Me.BaseFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChildFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCadastros = New PROJETOBASE.RJMenuButton()
        Me.dpdMenuCadastros = New PROJETOBASE.RJDropdownMenu(Me.components)
        Me.CadastroItemBensMoveis = New FontAwesome.Sharp.IconMenuItem()
        Me.CadastroItemIgrejas = New FontAwesome.Sharp.IconMenuItem()
        Me.CadastroItemDependencias = New FontAwesome.Sharp.IconMenuItem()
        Me.CadastroItemSetores = New FontAwesome.Sharp.IconMenuItem()
        Me.CadastroItemStatus = New FontAwesome.Sharp.IconMenuItem()
        Me.LblTitulo = New PROJETOBASE.RJLabel()
        Me.LblSubTitulo = New PROJETOBASE.RJLabel()
        Me.LblVersao = New PROJETOBASE.RJLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabelMensagem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabelDesenvolvedor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabelDataHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnInfo = New PROJETOBASE.RJButton()
        Me.BtnRelatorios = New PROJETOBASE.RJMenuButton()
        Me.pnlSideMenu.SuspendLayout()
        Me.pnlSideMenuHeader.SuspendLayout()
        Me.pnlTitleBar.SuspendLayout()
        Me.pnlDesktop.SuspendLayout()
        CType(Me.pbSideMenuLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dmCustomControls.SuspendLayout()
        Me.dmSalesOrder.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dmUserOptions.SuspendLayout()
        CType(Me.biFormOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.biNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.biUserOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dmCustomForms.SuspendLayout()
        Me.dpdMenuCadastros.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSideMenu
        '
        Me.pnlSideMenu.Controls.Add(Me.BtnRelatorios)
        Me.pnlSideMenu.Controls.Add(Me.BtnInfo)
        Me.pnlSideMenu.Controls.Add(Me.btnSincronizar)
        Me.pnlSideMenu.Controls.Add(Me.BtnConfiguracoes)
        Me.pnlSideMenu.Controls.Add(Me.btnCadastros)
        Me.pnlSideMenu.Controls.Add(Me.BtnInventario)
        Me.pnlSideMenu.Controls.Add(Me.btnDashboard)
        Me.pnlSideMenu.Size = New System.Drawing.Size(220, 548)
        Me.pnlSideMenu.Controls.SetChildIndex(Me.btnDashboard, 0)
        Me.pnlSideMenu.Controls.SetChildIndex(Me.BtnInventario, 0)
        Me.pnlSideMenu.Controls.SetChildIndex(Me.btnCadastros, 0)
        Me.pnlSideMenu.Controls.SetChildIndex(Me.BtnConfiguracoes, 0)
        Me.pnlSideMenu.Controls.SetChildIndex(Me.btnSincronizar, 0)
        Me.pnlSideMenu.Controls.SetChildIndex(Me.BtnInfo, 0)
        Me.pnlSideMenu.Controls.SetChildIndex(Me.BtnRelatorios, 0)
        '
        'pnlSideMenuHeader
        '
        Me.pnlSideMenuHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.pnlSideMenuHeader.Controls.Add(Me.pbSideMenuLogo)
        Me.pnlSideMenuHeader.Controls.SetChildIndex(Me.pbSideMenuLogo, 0)
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.Controls.Add(Me.LblSubTitulo)
        Me.pnlTitleBar.Controls.Add(Me.lblUserName)
        Me.pnlTitleBar.Controls.Add(Me.LblTitulo)
        Me.pnlTitleBar.Controls.Add(Me.biUserOptions)
        Me.pnlTitleBar.Controls.Add(Me.biNotifications)
        Me.pnlTitleBar.Controls.Add(Me.biFormOptions)
        Me.pnlTitleBar.Location = New System.Drawing.Point(221, 1)
        Me.pnlTitleBar.Size = New System.Drawing.Size(958, 60)
        Me.pnlTitleBar.Controls.SetChildIndex(Me.biFormOptions, 0)
        Me.pnlTitleBar.Controls.SetChildIndex(Me.biNotifications, 0)
        Me.pnlTitleBar.Controls.SetChildIndex(Me.biUserOptions, 0)
        Me.pnlTitleBar.Controls.SetChildIndex(Me.LblTitulo, 0)
        Me.pnlTitleBar.Controls.SetChildIndex(Me.lblUserName, 0)
        Me.pnlTitleBar.Controls.SetChildIndex(Me.LblSubTitulo, 0)
        '
        'pnlDesktop
        '
        Me.pnlDesktop.BackColor = System.Drawing.Color.GhostWhite
        Me.pnlDesktop.Controls.Add(Me.RjLabel2)
        Me.pnlDesktop.Controls.Add(Me.RjLabel1)
        Me.pnlDesktop.Controls.Add(Me.StatusStrip1)
        Me.pnlDesktop.Controls.Add(Me.LblVersao)
        Me.pnlDesktop.Controls.Add(Me.pictureBox2)
        Me.pnlDesktop.Location = New System.Drawing.Point(221, 86)
        Me.pnlDesktop.Size = New System.Drawing.Size(958, 523)
        '
        'pnlDesktopHeader
        '
        Me.pnlDesktopHeader.BackColor = System.Drawing.Color.White
        Me.pnlDesktopHeader.Location = New System.Drawing.Point(221, 61)
        Me.pnlDesktopHeader.Size = New System.Drawing.Size(958, 25)
        '
        'pbSideMenuLogo
        '
        Me.pbSideMenuLogo.BackColor = System.Drawing.Color.White
        Me.pbSideMenuLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbSideMenuLogo.Image = CType(resources.GetObject("pbSideMenuLogo.Image"), System.Drawing.Image)
        Me.pbSideMenuLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbSideMenuLogo.Name = "pbSideMenuLogo"
        Me.pbSideMenuLogo.Size = New System.Drawing.Size(220, 60)
        Me.pbSideMenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSideMenuLogo.TabIndex = 2
        Me.pbSideMenuLogo.TabStop = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.DropdownMenu = Nothing
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerAltFast
        Me.btnDashboard.IconColor = System.Drawing.Color.White
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 28
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 65)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(220, 55)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "   DASHBOARD"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'dmCustomControls
        '
        Me.dmCustomControls.ActiveMenuItem = False
        Me.dmCustomControls.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dmCustomControls.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommonToolStripMenuItem, Me.MenusToolStripMenuItem, Me.ContainersToolStripMenuItem, Me.DataToolStripMenuItem, Me.ComponentsToolStripMenuItem, Me.SpecialsToolStripMenuItem})
        Me.dmCustomControls.Name = "dmCustomControls"
        Me.dmCustomControls.OwnerIsMenuButton = False
        Me.dmCustomControls.Size = New System.Drawing.Size(156, 136)
        '
        'CommonToolStripMenuItem
        '
        Me.CommonToolStripMenuItem.Name = "CommonToolStripMenuItem"
        Me.CommonToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CommonToolStripMenuItem.Text = "Common"
        '
        'MenusToolStripMenuItem
        '
        Me.MenusToolStripMenuItem.Name = "MenusToolStripMenuItem"
        Me.MenusToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.MenusToolStripMenuItem.Text = "Menus"
        '
        'ContainersToolStripMenuItem
        '
        Me.ContainersToolStripMenuItem.Name = "ContainersToolStripMenuItem"
        Me.ContainersToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ContainersToolStripMenuItem.Text = "Containers"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'ComponentsToolStripMenuItem
        '
        Me.ComponentsToolStripMenuItem.Name = "ComponentsToolStripMenuItem"
        Me.ComponentsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ComponentsToolStripMenuItem.Text = "Components"
        '
        'SpecialsToolStripMenuItem
        '
        Me.SpecialsToolStripMenuItem.Name = "SpecialsToolStripMenuItem"
        Me.SpecialsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SpecialsToolStripMenuItem.Text = "Specials"
        '
        'BtnInventario
        '
        Me.BtnInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInventario.DropdownMenu = Nothing
        Me.BtnInventario.FlatAppearance.BorderSize = 0
        Me.BtnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInventario.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.ForeColor = System.Drawing.Color.White
        Me.BtnInventario.IconChar = FontAwesome.Sharp.IconChar.Barcode
        Me.BtnInventario.IconColor = System.Drawing.Color.White
        Me.BtnInventario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnInventario.IconSize = 28
        Me.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInventario.Location = New System.Drawing.Point(0, 120)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.BtnInventario.Size = New System.Drawing.Size(220, 55)
        Me.BtnInventario.TabIndex = 2
        Me.BtnInventario.Text = "   INVENTÁRIO"
        Me.BtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnInventario.UseVisualStyleBackColor = False
        '
        'BtnConfiguracoes
        '
        Me.BtnConfiguracoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnConfiguracoes.DropdownMenu = Nothing
        Me.BtnConfiguracoes.FlatAppearance.BorderSize = 0
        Me.BtnConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BtnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfiguracoes.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfiguracoes.ForeColor = System.Drawing.Color.White
        Me.BtnConfiguracoes.IconChar = FontAwesome.Sharp.IconChar.Gears
        Me.BtnConfiguracoes.IconColor = System.Drawing.Color.White
        Me.BtnConfiguracoes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnConfiguracoes.IconSize = 28
        Me.BtnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfiguracoes.Location = New System.Drawing.Point(0, 230)
        Me.BtnConfiguracoes.Name = "BtnConfiguracoes"
        Me.BtnConfiguracoes.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.BtnConfiguracoes.Size = New System.Drawing.Size(220, 55)
        Me.BtnConfiguracoes.TabIndex = 3
        Me.BtnConfiguracoes.Text = "   CONFIGURAÇÕES"
        Me.BtnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnConfiguracoes.UseVisualStyleBackColor = False
        '
        'dmSalesOrder
        '
        Me.dmSalesOrder.ActiveMenuItem = False
        Me.dmSalesOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dmSalesOrder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSaleToolStripMenuItem, Me.SalesListToolStripMenuItem, Me.PendingDeliveriesToolStripMenuItem, Me.DropDalesToolStripMenuItem, Me.RenewSalesToolStripMenuItem})
        Me.dmSalesOrder.Name = "dmSalesOrder"
        Me.dmSalesOrder.OwnerIsMenuButton = False
        Me.dmSalesOrder.Size = New System.Drawing.Size(195, 114)
        '
        'NewSaleToolStripMenuItem
        '
        Me.NewSaleToolStripMenuItem.Name = "NewSaleToolStripMenuItem"
        Me.NewSaleToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.NewSaleToolStripMenuItem.Text = "New Sale"
        '
        'SalesListToolStripMenuItem
        '
        Me.SalesListToolStripMenuItem.Name = "SalesListToolStripMenuItem"
        Me.SalesListToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.SalesListToolStripMenuItem.Text = "Sales List"
        '
        'PendingDeliveriesToolStripMenuItem
        '
        Me.PendingDeliveriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HightPriorityToolStripMenuItem, Me.MediumPriorityToolStripMenuItem, Me.LowPriorityToolStripMenuItem})
        Me.PendingDeliveriesToolStripMenuItem.Name = "PendingDeliveriesToolStripMenuItem"
        Me.PendingDeliveriesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.PendingDeliveriesToolStripMenuItem.Text = "Pending Deliveries"
        '
        'HightPriorityToolStripMenuItem
        '
        Me.HightPriorityToolStripMenuItem.Name = "HightPriorityToolStripMenuItem"
        Me.HightPriorityToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.HightPriorityToolStripMenuItem.Text = "Hight Priority"
        '
        'MediumPriorityToolStripMenuItem
        '
        Me.MediumPriorityToolStripMenuItem.Name = "MediumPriorityToolStripMenuItem"
        Me.MediumPriorityToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.MediumPriorityToolStripMenuItem.Text = "Medium Priority"
        '
        'LowPriorityToolStripMenuItem
        '
        Me.LowPriorityToolStripMenuItem.Name = "LowPriorityToolStripMenuItem"
        Me.LowPriorityToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LowPriorityToolStripMenuItem.Text = "Low Priority"
        '
        'DropDalesToolStripMenuItem
        '
        Me.DropDalesToolStripMenuItem.Name = "DropDalesToolStripMenuItem"
        Me.DropDalesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.DropDalesToolStripMenuItem.Text = "Drop Dales"
        '
        'RenewSalesToolStripMenuItem
        '
        Me.RenewSalesToolStripMenuItem.Name = "RenewSalesToolStripMenuItem"
        Me.RenewSalesToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.RenewSalesToolStripMenuItem.Text = "Renew Sales"
        '
        'btnSincronizar
        '
        Me.btnSincronizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSincronizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSincronizar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSincronizar.DropdownMenu = Nothing
        Me.btnSincronizar.FlatAppearance.BorderSize = 0
        Me.btnSincronizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSincronizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSincronizar.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSincronizar.ForeColor = System.Drawing.Color.White
        Me.btnSincronizar.IconChar = FontAwesome.Sharp.IconChar.RotateBackward
        Me.btnSincronizar.IconColor = System.Drawing.Color.White
        Me.btnSincronizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSincronizar.IconSize = 28
        Me.btnSincronizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSincronizar.Location = New System.Drawing.Point(0, 285)
        Me.btnSincronizar.Name = "btnSincronizar"
        Me.btnSincronizar.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnSincronizar.Size = New System.Drawing.Size(220, 55)
        Me.btnSincronizar.TabIndex = 5
        Me.btnSincronizar.Text = "   SINCRONIZAR"
        Me.btnSincronizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSincronizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSincronizar.UseVisualStyleBackColor = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(275, 158)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(409, 139)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox2.TabIndex = 1
        Me.pictureBox2.TabStop = False
        '
        'RjLabel1
        '
        Me.RjLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(263, 102)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(433, 30)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Custom
        Me.RjLabel1.TabIndex = 2
        Me.RjLabel1.Text = "CONGREGAÇÃO CRISTÃ NO BRASIL"
        '
        'RjLabel2
        '
        Me.RjLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(324, 139)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(312, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 3
        Me.RjLabel2.Text = "Administração - Patrimônio - Ativo Imobilizado"
        '
        'dmUserOptions
        '
        Me.dmUserOptions.ActiveMenuItem = False
        Me.dmUserOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dmUserOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyProfileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.TermsAndCondToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.dmUserOptions.Name = "dmUserOptions"
        Me.dmUserOptions.OwnerIsMenuButton = False
        Me.dmUserOptions.Size = New System.Drawing.Size(182, 158)
        '
        'MyProfileToolStripMenuItem
        '
        Me.MyProfileToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.MyProfileToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.MyProfileToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.MyProfileToolStripMenuItem.IconSize = 21
        Me.MyProfileToolStripMenuItem.Name = "MyProfileToolStripMenuItem"
        Me.MyProfileToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MyProfileToolStripMenuItem.Text = "Perfil"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrocaAdmMenuItem, Me.NovaAdmMenuItem})
        Me.AdminToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Gears
        Me.AdminToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.AdminToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AdminToolStripMenuItem.Text = "Administração"
        '
        'TrocaAdmMenuItem
        '
        Me.TrocaAdmMenuItem.IconChar = FontAwesome.Sharp.IconChar.Repeat
        Me.TrocaAdmMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TrocaAdmMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.TrocaAdmMenuItem.Name = "TrocaAdmMenuItem"
        Me.TrocaAdmMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.TrocaAdmMenuItem.Text = "Trocar Administração"
        '
        'NovaAdmMenuItem
        '
        Me.NovaAdmMenuItem.IconChar = FontAwesome.Sharp.IconChar.Info
        Me.NovaAdmMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.NovaAdmMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.NovaAdmMenuItem.Name = "NovaAdmMenuItem"
        Me.NovaAdmMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.NovaAdmMenuItem.Text = "Nova Administração"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench
        Me.SettingsToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.SettingsToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SettingsToolStripMenuItem.IconSize = 21
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SettingsToolStripMenuItem.Text = "Preferências"
        '
        'TermsAndCondToolStripMenuItem
        '
        Me.TermsAndCondToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt
        Me.TermsAndCondToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TermsAndCondToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.TermsAndCondToolStripMenuItem.IconSize = 21
        Me.TermsAndCondToolStripMenuItem.Name = "TermsAndCondToolStripMenuItem"
        Me.TermsAndCondToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.TermsAndCondToolStripMenuItem.Text = "Terms and Cond"
        Me.TermsAndCondToolStripMenuItem.Visible = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.CircleQuestion
        Me.HelpToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.HelpToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.HelpToolStripMenuItem.IconSize = 21
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HelpToolStripMenuItem.Text = "Ajuda"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket
        Me.LogoutToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.LogoutToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.LogoutToolStripMenuItem.IconSize = 21
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.LogoutToolStripMenuItem.Text = "Login"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.ExitToolStripMenuItem.IconColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(118, Byte), Integer))
        Me.ExitToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ExitToolStripMenuItem.IconSize = 21
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExitToolStripMenuItem.Text = "Sair"
        '
        'biFormOptions
        '
        Me.biFormOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.biFormOptions.BackColor = System.Drawing.Color.Transparent
        Me.biFormOptions.BackIcon = False
        Me.biFormOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.biFormOptions.Customizable = False
        Me.biFormOptions.DropdownMenu = Nothing
        Me.biFormOptions.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.biFormOptions.IconChar = FontAwesome.Sharp.IconChar.Windows
        Me.biFormOptions.IconColor = System.Drawing.Color.WhiteSmoke
        Me.biFormOptions.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.biFormOptions.IconSize = 25
        Me.biFormOptions.Location = New System.Drawing.Point(764, 20)
        Me.biFormOptions.Name = "biFormOptions"
        Me.biFormOptions.Size = New System.Drawing.Size(25, 25)
        Me.biFormOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.biFormOptions.TabIndex = 5
        Me.biFormOptions.TabStop = False
        '
        'biNotifications
        '
        Me.biNotifications.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.biNotifications.BackColor = System.Drawing.Color.Transparent
        Me.biNotifications.BackIcon = False
        Me.biNotifications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.biNotifications.Customizable = False
        Me.biNotifications.DropdownMenu = Nothing
        Me.biNotifications.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.biNotifications.IconChar = FontAwesome.Sharp.IconChar.Bell
        Me.biNotifications.IconColor = System.Drawing.Color.WhiteSmoke
        Me.biNotifications.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.biNotifications.IconSize = 25
        Me.biNotifications.Location = New System.Drawing.Point(795, 20)
        Me.biNotifications.Name = "biNotifications"
        Me.biNotifications.Size = New System.Drawing.Size(25, 25)
        Me.biNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.biNotifications.TabIndex = 6
        Me.biNotifications.TabStop = False
        '
        'biUserOptions
        '
        Me.biUserOptions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.biUserOptions.BackColor = System.Drawing.Color.Transparent
        Me.biUserOptions.BackIcon = False
        Me.biUserOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.biUserOptions.Customizable = False
        Me.biUserOptions.DropdownMenu = Me.dmUserOptions
        Me.biUserOptions.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.biUserOptions.IconChar = FontAwesome.Sharp.IconChar.EllipsisVertical
        Me.biUserOptions.IconColor = System.Drawing.Color.WhiteSmoke
        Me.biUserOptions.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.biUserOptions.IconSize = 25
        Me.biUserOptions.Location = New System.Drawing.Point(925, 23)
        Me.biUserOptions.Name = "biUserOptions"
        Me.biUserOptions.Size = New System.Drawing.Size(25, 25)
        Me.biUserOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.biUserOptions.TabIndex = 7
        Me.biUserOptions.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblUserName.LinkLabel = False
        Me.lblUserName.Location = New System.Drawing.Point(826, 24)
        Me.lblUserName.MaximumSize = New System.Drawing.Size(95, 20)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(70, 16)
        Me.lblUserName.Style = PROJETOBASE.LabelStyle.BarText
        Me.lblUserName.TabIndex = 9
        Me.lblUserName.Text = "Username"
        '
        'dmCustomForms
        '
        Me.dmCustomForms.ActiveMenuItem = False
        Me.dmCustomForms.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dmCustomForms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaseFormToolStripMenuItem, Me.MainFormToolStripMenuItem, Me.ChildFormToolStripMenuItem})
        Me.dmCustomForms.Name = "dmCustomForms"
        Me.dmCustomForms.OwnerIsMenuButton = False
        Me.dmCustomForms.Size = New System.Drawing.Size(145, 70)
        '
        'BaseFormToolStripMenuItem
        '
        Me.BaseFormToolStripMenuItem.Name = "BaseFormToolStripMenuItem"
        Me.BaseFormToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.BaseFormToolStripMenuItem.Text = "Base Form"
        '
        'MainFormToolStripMenuItem
        '
        Me.MainFormToolStripMenuItem.Name = "MainFormToolStripMenuItem"
        Me.MainFormToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.MainFormToolStripMenuItem.Text = "Main Form"
        '
        'ChildFormToolStripMenuItem
        '
        Me.ChildFormToolStripMenuItem.Name = "ChildFormToolStripMenuItem"
        Me.ChildFormToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ChildFormToolStripMenuItem.Text = "Child Form"
        '
        'btnCadastros
        '
        Me.btnCadastros.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCadastros.BackgroundImage = CType(resources.GetObject("btnCadastros.BackgroundImage"), System.Drawing.Image)
        Me.btnCadastros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCadastros.DropdownMenu = Me.dpdMenuCadastros
        Me.btnCadastros.FlatAppearance.BorderSize = 0
        Me.btnCadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastros.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastros.ForeColor = System.Drawing.Color.White
        Me.btnCadastros.IconChar = FontAwesome.Sharp.IconChar.Table
        Me.btnCadastros.IconColor = System.Drawing.Color.White
        Me.btnCadastros.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCadastros.IconSize = 28
        Me.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastros.Location = New System.Drawing.Point(0, 175)
        Me.btnCadastros.Name = "btnCadastros"
        Me.btnCadastros.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btnCadastros.Size = New System.Drawing.Size(220, 55)
        Me.btnCadastros.TabIndex = 7
        Me.btnCadastros.Text = "   CADASTROS"
        Me.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCadastros.UseVisualStyleBackColor = False
        '
        'dpdMenuCadastros
        '
        Me.dpdMenuCadastros.ActiveMenuItem = False
        Me.dpdMenuCadastros.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.dpdMenuCadastros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpdMenuCadastros.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroItemBensMoveis, Me.CadastroItemIgrejas, Me.CadastroItemDependencias, Me.CadastroItemSetores, Me.CadastroItemStatus})
        Me.dpdMenuCadastros.Name = "dpdMenuCadastros"
        Me.dpdMenuCadastros.OwnerIsMenuButton = False
        Me.dpdMenuCadastros.Size = New System.Drawing.Size(183, 114)
        Me.dpdMenuCadastros.Text = "CADASTROS"
        '
        'CadastroItemBensMoveis
        '
        Me.CadastroItemBensMoveis.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.CadastroItemBensMoveis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CadastroItemBensMoveis.IconChar = FontAwesome.Sharp.IconChar.Chair
        Me.CadastroItemBensMoveis.IconColor = System.Drawing.Color.White
        Me.CadastroItemBensMoveis.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CadastroItemBensMoveis.Name = "CadastroItemBensMoveis"
        Me.CadastroItemBensMoveis.Size = New System.Drawing.Size(182, 22)
        Me.CadastroItemBensMoveis.Text = "BENS MÓVEIS"
        '
        'CadastroItemIgrejas
        '
        Me.CadastroItemIgrejas.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.CadastroItemIgrejas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CadastroItemIgrejas.IconChar = FontAwesome.Sharp.IconChar.Church
        Me.CadastroItemIgrejas.IconColor = System.Drawing.Color.White
        Me.CadastroItemIgrejas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CadastroItemIgrejas.Name = "CadastroItemIgrejas"
        Me.CadastroItemIgrejas.Size = New System.Drawing.Size(182, 22)
        Me.CadastroItemIgrejas.Text = "IGREJAS"
        '
        'CadastroItemDependencias
        '
        Me.CadastroItemDependencias.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.CadastroItemDependencias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CadastroItemDependencias.IconChar = FontAwesome.Sharp.IconChar.Building
        Me.CadastroItemDependencias.IconColor = System.Drawing.Color.White
        Me.CadastroItemDependencias.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CadastroItemDependencias.Name = "CadastroItemDependencias"
        Me.CadastroItemDependencias.Size = New System.Drawing.Size(182, 22)
        Me.CadastroItemDependencias.Text = "DEPENDÊNCIAS"
        '
        'CadastroItemSetores
        '
        Me.CadastroItemSetores.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.CadastroItemSetores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CadastroItemSetores.IconChar = FontAwesome.Sharp.IconChar.Sliders
        Me.CadastroItemSetores.IconColor = System.Drawing.Color.White
        Me.CadastroItemSetores.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CadastroItemSetores.Name = "CadastroItemSetores"
        Me.CadastroItemSetores.Size = New System.Drawing.Size(182, 22)
        Me.CadastroItemSetores.Text = "SETORES"
        '
        'CadastroItemStatus
        '
        Me.CadastroItemStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.CadastroItemStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CadastroItemStatus.IconChar = FontAwesome.Sharp.IconChar.PlusMinus
        Me.CadastroItemStatus.IconColor = System.Drawing.Color.White
        Me.CadastroItemStatus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CadastroItemStatus.Name = "CadastroItemStatus"
        Me.CadastroItemStatus.Size = New System.Drawing.Size(182, 22)
        Me.CadastroItemStatus.Text = "STATUS"
        '
        'LblTitulo
        '
        Me.LblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblTitulo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblTitulo.Font = New System.Drawing.Font("Cooper Black", 16.0!)
        Me.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblTitulo.LinkLabel = False
        Me.LblTitulo.Location = New System.Drawing.Point(204, 4)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(551, 31)
        Me.LblTitulo.Style = PROJETOBASE.LabelStyle.Title
        Me.LblTitulo.TabIndex = 4
        Me.LblTitulo.Text = "CONGREGAÇÃO CRISTÃ NO BRASIL"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSubTitulo
        '
        Me.LblSubTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblSubTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTitulo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblSubTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTitulo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblSubTitulo.LinkLabel = False
        Me.LblSubTitulo.Location = New System.Drawing.Point(204, 34)
        Me.LblSubTitulo.Name = "LblSubTitulo"
        Me.LblSubTitulo.Size = New System.Drawing.Size(551, 20)
        Me.LblSubTitulo.Style = PROJETOBASE.LabelStyle.BarText
        Me.LblSubTitulo.TabIndex = 4
        Me.LblSubTitulo.Text = "Regional / Administração"
        Me.LblSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVersao
        '
        Me.LblVersao.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblVersao.BackColor = System.Drawing.Color.Transparent
        Me.LblVersao.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblVersao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblVersao.LinkLabel = False
        Me.LblVersao.Location = New System.Drawing.Point(314, 276)
        Me.LblVersao.Name = "LblVersao"
        Me.LblVersao.Size = New System.Drawing.Size(314, 21)
        Me.LblVersao.Style = PROJETOBASE.LabelStyle.Custom
        Me.LblVersao.TabIndex = 4
        Me.LblVersao.Text = "Versão"
        Me.LblVersao.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabelMensagem, Me.StatusLabelDesenvolvedor, Me.StatusLabelDataHora})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 501)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(958, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabelMensagem
        '
        Me.StatusLabelMensagem.ForeColor = System.Drawing.Color.White
        Me.StatusLabelMensagem.Name = "StatusLabelMensagem"
        Me.StatusLabelMensagem.Size = New System.Drawing.Size(0, 17)
        '
        'StatusLabelDesenvolvedor
        '
        Me.StatusLabelDesenvolvedor.ForeColor = System.Drawing.Color.White
        Me.StatusLabelDesenvolvedor.Name = "StatusLabelDesenvolvedor"
        Me.StatusLabelDesenvolvedor.Size = New System.Drawing.Size(810, 17)
        Me.StatusLabelDesenvolvedor.Spring = True
        Me.StatusLabelDesenvolvedor.Text = "Desenvolvido por Rodrigo Lima© - 2020/2024 - Todos os direitos reservados"
        '
        'StatusLabelDataHora
        '
        Me.StatusLabelDataHora.ForeColor = System.Drawing.Color.White
        Me.StatusLabelDataHora.Image = CType(resources.GetObject("StatusLabelDataHora.Image"), System.Drawing.Image)
        Me.StatusLabelDataHora.Name = "StatusLabelDataHora"
        Me.StatusLabelDataHora.Size = New System.Drawing.Size(133, 17)
        Me.StatusLabelDataHora.Text = "StatusLabelDataHora"
        Me.StatusLabelDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnInfo
        '
        Me.BtnInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnInfo.AutoSize = True
        Me.BtnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnInfo.BorderRadius = 18
        Me.BtnInfo.BorderSize = 2
        Me.BtnInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInfo.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnInfo.FlatAppearance.BorderSize = 0
        Me.BtnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInfo.ForeColor = System.Drawing.Color.White
        Me.BtnInfo.IconChar = FontAwesome.Sharp.IconChar.Info
        Me.BtnInfo.IconColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnInfo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnInfo.IconSize = 24
        Me.BtnInfo.Location = New System.Drawing.Point(87, 448)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(41, 36)
        Me.BtnInfo.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnInfo.Style = PROJETOBASE.ControlStyle.Solid
        Me.BtnInfo.TabIndex = 6
        Me.BtnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInfo.UseVisualStyleBackColor = False
        '
        'BtnRelatorios
        '
        Me.BtnRelatorios.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRelatorios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRelatorios.DropdownMenu = Nothing
        Me.BtnRelatorios.FlatAppearance.BorderSize = 0
        Me.BtnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BtnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRelatorios.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRelatorios.ForeColor = System.Drawing.Color.White
        Me.BtnRelatorios.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.BtnRelatorios.IconColor = System.Drawing.Color.White
        Me.BtnRelatorios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnRelatorios.IconSize = 28
        Me.BtnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRelatorios.Location = New System.Drawing.Point(0, 340)
        Me.BtnRelatorios.Name = "BtnRelatorios"
        Me.BtnRelatorios.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.BtnRelatorios.Size = New System.Drawing.Size(220, 55)
        Me.BtnRelatorios.TabIndex = 8
        Me.BtnRelatorios.Text = "   RELATÓRIOS"
        Me.BtnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRelatorios.UseVisualStyleBackColor = False
        '
        'MainFormDemo
        '
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BorderSize = 1
        Me.ClientSize = New System.Drawing.Size(1180, 610)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainFormDemo"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainFormTest"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.pnlTitleBar, 0)
        Me.Controls.SetChildIndex(Me.pnlDesktopHeader, 0)
        Me.Controls.SetChildIndex(Me.pnlDesktop, 0)
        Me.pnlSideMenu.ResumeLayout(False)
        Me.pnlSideMenu.PerformLayout()
        Me.pnlSideMenuHeader.ResumeLayout(False)
        Me.pnlSideMenuHeader.PerformLayout()
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlTitleBar.PerformLayout()
        Me.pnlDesktop.ResumeLayout(False)
        Me.pnlDesktop.PerformLayout()
        CType(Me.pbSideMenuLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dmCustomControls.ResumeLayout(False)
        Me.dmSalesOrder.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dmUserOptions.ResumeLayout(False)
        CType(Me.biFormOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.biNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.biUserOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dmCustomForms.ResumeLayout(False)
        Me.dpdMenuCadastros.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSincronizar As PROJETOBASE.RJMenuButton
    Friend WithEvents BtnConfiguracoes As PROJETOBASE.RJMenuButton
    Friend WithEvents BtnInventario As PROJETOBASE.RJMenuButton
    Friend WithEvents btnDashboard As PROJETOBASE.RJMenuButton
    Private WithEvents pbSideMenuLogo As System.Windows.Forms.PictureBox
    Friend WithEvents RjLabel2 As PROJETOBASE.RJLabel
    Friend WithEvents RjLabel1 As PROJETOBASE.RJLabel
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dmUserOptions As PROJETOBASE.RJDropdownMenu
    Friend WithEvents MyProfileToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents SettingsToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents TermsAndCondToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents HelpToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents LogoutToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents ExitToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents dmSalesOrder As PROJETOBASE.RJDropdownMenu
    Friend WithEvents NewSaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PendingDeliveriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HightPriorityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediumPriorityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LowPriorityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DropDalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenewSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dmCustomControls As PROJETOBASE.RJDropdownMenu
    Friend WithEvents CommonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContainersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComponentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpecialsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUserName As PROJETOBASE.RJLabel
    Friend WithEvents biUserOptions As PROJETOBASE.RJMenuIcon
    Friend WithEvents biNotifications As PROJETOBASE.RJMenuIcon
    Friend WithEvents biFormOptions As PROJETOBASE.RJMenuIcon
    Friend WithEvents btnCadastros As PROJETOBASE.RJMenuButton
    Friend WithEvents dmCustomForms As PROJETOBASE.RJDropdownMenu
    Friend WithEvents BaseFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChildFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dpdMenuCadastros As RJDropdownMenu
    Friend WithEvents CadastroItemBensMoveis As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents CadastroItemIgrejas As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents CadastroItemDependencias As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents CadastroItemSetores As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents CadastroItemStatus As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents LblSubTitulo As RJLabel
    Friend WithEvents LblTitulo As RJLabel
    Friend WithEvents AdminToolStripMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents TrocaAdmMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents NovaAdmMenuItem As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents LblVersao As RJLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabelDesenvolvedor As ToolStripStatusLabel
    Friend WithEvents StatusLabelDataHora As ToolStripStatusLabel
    Friend WithEvents StatusLabelMensagem As ToolStripStatusLabel
    Friend WithEvents BtnInfo As RJButton
    Friend WithEvents BtnRelatorios As RJMenuButton
End Class
