<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSincronizar
    Inherits RJChildForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSincronizar))
        Me.RjPanel1 = New PROJETOBASE.RJPanel()
        Me.RjPanelEstatistica = New PROJETOBASE.RJPanel()
        Me.LblinventariosLocal = New PROJETOBASE.RJLabel()
        Me.LblinventariosRemoto = New PROJETOBASE.RJLabel()
        Me.LblDependenciasRemoto = New PROJETOBASE.RJLabel()
        Me.LblDependenciasLocal = New PROJETOBASE.RJLabel()
        Me.LblSetoresRemoto = New PROJETOBASE.RJLabel()
        Me.LblSetoresLocal = New PROJETOBASE.RJLabel()
        Me.LblIgrejasRemoto = New PROJETOBASE.RJLabel()
        Me.LblIgrejasLocal = New PROJETOBASE.RJLabel()
        Me.BtnSincronizar = New PROJETOBASE.RJButton()
        Me.BtnChecar = New PROJETOBASE.RJButton()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.RjProgressBar1 = New PROJETOBASE.RJProgressBar()
        Me.RjPanel3 = New PROJETOBASE.RJPanel()
        Me.RjPanel2 = New PROJETOBASE.RJPanel()
        Me.RjPanel4 = New PROJETOBASE.RJPanel()
        Me.RjProgressBar2 = New PROJETOBASE.RJProgressBar()
        Me.LblMsgTitulo = New PROJETOBASE.RJLabel()
        Me.LblMsgDescricao = New PROJETOBASE.RJLabel()
        Me.ImgSinc = New PROJETOBASE.RJPictureBox()
        Me.LblProgress = New PROJETOBASE.RJLabel()
        Me._pnlClientArea.SuspendLayout()
        Me.RjPanel1.SuspendLayout()
        Me.RjPanelEstatistica.SuspendLayout()
        Me.RjPanel3.SuspendLayout()
        Me.RjPanel2.SuspendLayout()
        Me.RjPanel4.SuspendLayout()
        CType(Me.ImgSinc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.RjPanel3)
        Me._pnlClientArea.Controls.Add(Me.RjPanel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(958, 408)
        '
        'RjPanel1
        '
        Me.RjPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel1.BorderRadius = 0
        Me.RjPanel1.Controls.Add(Me.LblProgress)
        Me.RjPanel1.Controls.Add(Me.BtnSincronizar)
        Me.RjPanel1.Controls.Add(Me.BtnChecar)
        Me.RjPanel1.Controls.Add(Me.RjLabel1)
        Me.RjPanel1.Controls.Add(Me.RjPanelEstatistica)
        Me.RjPanel1.Customizable = False
        Me.RjPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RjPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RjPanel1.Name = "RjPanel1"
        Me.RjPanel1.Size = New System.Drawing.Size(435, 408)
        Me.RjPanel1.TabIndex = 0
        '
        'RjPanelEstatistica
        '
        Me.RjPanelEstatistica.BackColor = System.Drawing.Color.FloralWhite
        Me.RjPanelEstatistica.BackgroundImage = CType(resources.GetObject("RjPanelEstatistica.BackgroundImage"), System.Drawing.Image)
        Me.RjPanelEstatistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RjPanelEstatistica.BorderRadius = 8
        Me.RjPanelEstatistica.Controls.Add(Me.LblinventariosLocal)
        Me.RjPanelEstatistica.Controls.Add(Me.LblinventariosRemoto)
        Me.RjPanelEstatistica.Controls.Add(Me.LblDependenciasRemoto)
        Me.RjPanelEstatistica.Controls.Add(Me.LblDependenciasLocal)
        Me.RjPanelEstatistica.Controls.Add(Me.LblSetoresRemoto)
        Me.RjPanelEstatistica.Controls.Add(Me.LblSetoresLocal)
        Me.RjPanelEstatistica.Controls.Add(Me.LblIgrejasRemoto)
        Me.RjPanelEstatistica.Controls.Add(Me.LblIgrejasLocal)
        Me.RjPanelEstatistica.Customizable = True
        Me.RjPanelEstatistica.Location = New System.Drawing.Point(15, 152)
        Me.RjPanelEstatistica.Name = "RjPanelEstatistica"
        Me.RjPanelEstatistica.Size = New System.Drawing.Size(405, 242)
        Me.RjPanelEstatistica.TabIndex = 2
        Me.RjPanelEstatistica.Visible = False
        '
        'LblinventariosLocal
        '
        Me.LblinventariosLocal.AutoSize = True
        Me.LblinventariosLocal.BackColor = System.Drawing.Color.Transparent
        Me.LblinventariosLocal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblinventariosLocal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblinventariosLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblinventariosLocal.LinkLabel = False
        Me.LblinventariosLocal.Location = New System.Drawing.Point(209, 168)
        Me.LblinventariosLocal.Name = "LblinventariosLocal"
        Me.LblinventariosLocal.Size = New System.Drawing.Size(19, 18)
        Me.LblinventariosLocal.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblinventariosLocal.TabIndex = 0
        Me.LblinventariosLocal.Text = "0"
        '
        'LblinventariosRemoto
        '
        Me.LblinventariosRemoto.AutoSize = True
        Me.LblinventariosRemoto.BackColor = System.Drawing.Color.Transparent
        Me.LblinventariosRemoto.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblinventariosRemoto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblinventariosRemoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblinventariosRemoto.LinkLabel = False
        Me.LblinventariosRemoto.Location = New System.Drawing.Point(329, 168)
        Me.LblinventariosRemoto.Name = "LblinventariosRemoto"
        Me.LblinventariosRemoto.Size = New System.Drawing.Size(19, 18)
        Me.LblinventariosRemoto.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblinventariosRemoto.TabIndex = 0
        Me.LblinventariosRemoto.Text = "0"
        '
        'LblDependenciasRemoto
        '
        Me.LblDependenciasRemoto.AutoSize = True
        Me.LblDependenciasRemoto.BackColor = System.Drawing.Color.Transparent
        Me.LblDependenciasRemoto.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblDependenciasRemoto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblDependenciasRemoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblDependenciasRemoto.LinkLabel = False
        Me.LblDependenciasRemoto.Location = New System.Drawing.Point(329, 84)
        Me.LblDependenciasRemoto.Name = "LblDependenciasRemoto"
        Me.LblDependenciasRemoto.Size = New System.Drawing.Size(19, 18)
        Me.LblDependenciasRemoto.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblDependenciasRemoto.TabIndex = 0
        Me.LblDependenciasRemoto.Text = "0"
        '
        'LblDependenciasLocal
        '
        Me.LblDependenciasLocal.AutoSize = True
        Me.LblDependenciasLocal.BackColor = System.Drawing.Color.Transparent
        Me.LblDependenciasLocal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblDependenciasLocal.Enabled = False
        Me.LblDependenciasLocal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblDependenciasLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblDependenciasLocal.LinkLabel = False
        Me.LblDependenciasLocal.Location = New System.Drawing.Point(209, 84)
        Me.LblDependenciasLocal.Name = "LblDependenciasLocal"
        Me.LblDependenciasLocal.Size = New System.Drawing.Size(19, 18)
        Me.LblDependenciasLocal.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblDependenciasLocal.TabIndex = 0
        Me.LblDependenciasLocal.Text = "0"
        '
        'LblSetoresRemoto
        '
        Me.LblSetoresRemoto.AutoSize = True
        Me.LblSetoresRemoto.BackColor = System.Drawing.Color.Transparent
        Me.LblSetoresRemoto.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblSetoresRemoto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblSetoresRemoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblSetoresRemoto.LinkLabel = False
        Me.LblSetoresRemoto.Location = New System.Drawing.Point(329, 210)
        Me.LblSetoresRemoto.Name = "LblSetoresRemoto"
        Me.LblSetoresRemoto.Size = New System.Drawing.Size(19, 18)
        Me.LblSetoresRemoto.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblSetoresRemoto.TabIndex = 0
        Me.LblSetoresRemoto.Text = "0"
        '
        'LblSetoresLocal
        '
        Me.LblSetoresLocal.AutoSize = True
        Me.LblSetoresLocal.BackColor = System.Drawing.Color.Transparent
        Me.LblSetoresLocal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblSetoresLocal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblSetoresLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblSetoresLocal.LinkLabel = False
        Me.LblSetoresLocal.Location = New System.Drawing.Point(209, 210)
        Me.LblSetoresLocal.Name = "LblSetoresLocal"
        Me.LblSetoresLocal.Size = New System.Drawing.Size(19, 18)
        Me.LblSetoresLocal.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblSetoresLocal.TabIndex = 0
        Me.LblSetoresLocal.Text = "0"
        '
        'LblIgrejasRemoto
        '
        Me.LblIgrejasRemoto.AutoSize = True
        Me.LblIgrejasRemoto.BackColor = System.Drawing.Color.Transparent
        Me.LblIgrejasRemoto.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblIgrejasRemoto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblIgrejasRemoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblIgrejasRemoto.LinkLabel = False
        Me.LblIgrejasRemoto.Location = New System.Drawing.Point(329, 126)
        Me.LblIgrejasRemoto.Name = "LblIgrejasRemoto"
        Me.LblIgrejasRemoto.Size = New System.Drawing.Size(19, 18)
        Me.LblIgrejasRemoto.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblIgrejasRemoto.TabIndex = 0
        Me.LblIgrejasRemoto.Text = "0"
        '
        'LblIgrejasLocal
        '
        Me.LblIgrejasLocal.AutoSize = True
        Me.LblIgrejasLocal.BackColor = System.Drawing.Color.Transparent
        Me.LblIgrejasLocal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblIgrejasLocal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblIgrejasLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblIgrejasLocal.LinkLabel = False
        Me.LblIgrejasLocal.Location = New System.Drawing.Point(209, 126)
        Me.LblIgrejasLocal.Name = "LblIgrejasLocal"
        Me.LblIgrejasLocal.Size = New System.Drawing.Size(19, 18)
        Me.LblIgrejasLocal.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblIgrejasLocal.TabIndex = 0
        Me.LblIgrejasLocal.Text = "0"
        '
        'BtnSincronizar
        '
        Me.BtnSincronizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnSincronizar.BorderRadius = 5
        Me.BtnSincronizar.BorderSize = 1
        Me.BtnSincronizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSincronizar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnSincronizar.Enabled = False
        Me.BtnSincronizar.FlatAppearance.BorderSize = 0
        Me.BtnSincronizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnSincronizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnSincronizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSincronizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSincronizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSincronizar.IconChar = FontAwesome.Sharp.IconChar.Retweet
        Me.BtnSincronizar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSincronizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSincronizar.IconSize = 42
        Me.BtnSincronizar.Location = New System.Drawing.Point(227, 43)
        Me.BtnSincronizar.Name = "BtnSincronizar"
        Me.BtnSincronizar.Size = New System.Drawing.Size(197, 93)
        Me.BtnSincronizar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSincronizar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnSincronizar.TabIndex = 5
        Me.BtnSincronizar.Text = "SINCRONIZAR"
        Me.BtnSincronizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSincronizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnSincronizar.UseVisualStyleBackColor = False
        '
        'BtnChecar
        '
        Me.BtnChecar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnChecar.BorderRadius = 5
        Me.BtnChecar.BorderSize = 1
        Me.BtnChecar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChecar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnChecar.FlatAppearance.BorderSize = 0
        Me.BtnChecar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnChecar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnChecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChecar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChecar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnChecar.IconChar = FontAwesome.Sharp.IconChar.Repeat
        Me.BtnChecar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnChecar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnChecar.IconSize = 42
        Me.BtnChecar.Location = New System.Drawing.Point(15, 43)
        Me.BtnChecar.Name = "BtnChecar"
        Me.BtnChecar.Size = New System.Drawing.Size(197, 93)
        Me.BtnChecar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnChecar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnChecar.TabIndex = 1
        Me.BtnChecar.Text = "VERIFICAR"
        Me.BtnChecar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnChecar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnChecar.UseVisualStyleBackColor = False
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(73, 13)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(289, 23)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Title2
        Me.RjLabel1.TabIndex = 0
        Me.RjLabel1.Text = "Verificar Dados à Sincronizar"
        '
        'RjProgressBar1
        '
        Me.RjProgressBar1.ChannelColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RjProgressBar1.ChannelHeight = 10
        Me.RjProgressBar1.Customizable = True
        Me.RjProgressBar1.ForeBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjProgressBar1.ForeColor = System.Drawing.Color.White
        Me.RjProgressBar1.Location = New System.Drawing.Point(6, 3)
        Me.RjProgressBar1.Name = "RjProgressBar1"
        Me.RjProgressBar1.ShowMaximun = False
        Me.RjProgressBar1.ShowValue = PROJETOBASE.TextPosition.Center
        Me.RjProgressBar1.Size = New System.Drawing.Size(435, 28)
        Me.RjProgressBar1.SliderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjProgressBar1.SliderHeight = 10
        Me.RjProgressBar1.SymbolAfter = "%"
        Me.RjProgressBar1.SymbolBefore = ""
        Me.RjProgressBar1.TabIndex = 11
        Me.RjProgressBar1.Visible = False
        '
        'RjPanel3
        '
        Me.RjPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel3.BorderRadius = 0
        Me.RjPanel3.Controls.Add(Me.RjPanel2)
        Me.RjPanel3.Customizable = False
        Me.RjPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RjPanel3.Location = New System.Drawing.Point(435, 0)
        Me.RjPanel3.Name = "RjPanel3"
        Me.RjPanel3.Size = New System.Drawing.Size(523, 408)
        Me.RjPanel3.TabIndex = 1
        Me.RjPanel3.Visible = False
        '
        'RjPanel2
        '
        Me.RjPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RjPanel2.BorderRadius = 12
        Me.RjPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RjPanel2.Controls.Add(Me.RjPanel4)
        Me.RjPanel2.Controls.Add(Me.ImgSinc)
        Me.RjPanel2.Customizable = True
        Me.RjPanel2.Location = New System.Drawing.Point(28, 13)
        Me.RjPanel2.Name = "RjPanel2"
        Me.RjPanel2.Size = New System.Drawing.Size(475, 381)
        Me.RjPanel2.TabIndex = 14
        '
        'RjPanel4
        '
        Me.RjPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel4.BorderRadius = 12
        Me.RjPanel4.Controls.Add(Me.RjProgressBar1)
        Me.RjPanel4.Controls.Add(Me.RjProgressBar2)
        Me.RjPanel4.Controls.Add(Me.LblMsgTitulo)
        Me.RjPanel4.Controls.Add(Me.LblMsgDescricao)
        Me.RjPanel4.Customizable = False
        Me.RjPanel4.Location = New System.Drawing.Point(14, 210)
        Me.RjPanel4.Name = "RjPanel4"
        Me.RjPanel4.Size = New System.Drawing.Size(444, 156)
        Me.RjPanel4.TabIndex = 15
        '
        'RjProgressBar2
        '
        Me.RjProgressBar2.ChannelColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RjProgressBar2.ChannelHeight = 10
        Me.RjProgressBar2.Customizable = True
        Me.RjProgressBar2.ForeBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjProgressBar2.ForeColor = System.Drawing.Color.White
        Me.RjProgressBar2.Location = New System.Drawing.Point(3, 86)
        Me.RjProgressBar2.Name = "RjProgressBar2"
        Me.RjProgressBar2.ShowMaximun = False
        Me.RjProgressBar2.ShowValue = PROJETOBASE.TextPosition.Sliding
        Me.RjProgressBar2.Size = New System.Drawing.Size(438, 28)
        Me.RjProgressBar2.SliderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjProgressBar2.SliderHeight = 10
        Me.RjProgressBar2.SymbolAfter = "%"
        Me.RjProgressBar2.SymbolBefore = ""
        Me.RjProgressBar2.TabIndex = 11
        Me.RjProgressBar2.Visible = False
        '
        'LblMsgTitulo
        '
        Me.LblMsgTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LblMsgTitulo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblMsgTitulo.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.LblMsgTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.LblMsgTitulo.LinkLabel = False
        Me.LblMsgTitulo.Location = New System.Drawing.Point(3, 30)
        Me.LblMsgTitulo.Name = "LblMsgTitulo"
        Me.LblMsgTitulo.Size = New System.Drawing.Size(438, 72)
        Me.LblMsgTitulo.Style = PROJETOBASE.LabelStyle.Title2
        Me.LblMsgTitulo.TabIndex = 9
        Me.LblMsgTitulo.Text = "Aguardando..."
        Me.LblMsgTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMsgDescricao
        '
        Me.LblMsgDescricao.BackColor = System.Drawing.Color.Transparent
        Me.LblMsgDescricao.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblMsgDescricao.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LblMsgDescricao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.LblMsgDescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblMsgDescricao.LinkLabel = False
        Me.LblMsgDescricao.Location = New System.Drawing.Point(3, 105)
        Me.LblMsgDescricao.Name = "LblMsgDescricao"
        Me.LblMsgDescricao.Size = New System.Drawing.Size(438, 51)
        Me.LblMsgDescricao.Style = PROJETOBASE.LabelStyle.Description
        Me.LblMsgDescricao.TabIndex = 13
        Me.LblMsgDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImgSinc
        '
        Me.ImgSinc.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ImgSinc.BorderColor = System.Drawing.Color.RoyalBlue
        Me.ImgSinc.BorderRadius = 12
        Me.ImgSinc.BorderSize = 0
        Me.ImgSinc.Customizable = True
        Me.ImgSinc.Location = New System.Drawing.Point(104, 3)
        Me.ImgSinc.Name = "ImgSinc"
        Me.ImgSinc.Size = New System.Drawing.Size(263, 201)
        Me.ImgSinc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgSinc.TabIndex = 14
        Me.ImgSinc.TabStop = False
        '
        'LblProgress
        '
        Me.LblProgress.BackColor = System.Drawing.Color.White
        Me.LblProgress.Font = New System.Drawing.Font("Verdana", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProgress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.LblProgress.Image = CType(resources.GetObject("LblProgress.Image"), System.Drawing.Image)
        Me.LblProgress.LinkLabel = False
        Me.LblProgress.Location = New System.Drawing.Point(12, 153)
        Me.LblProgress.Name = "LblProgress"
        Me.LblProgress.Size = New System.Drawing.Size(412, 23)
        Me.LblProgress.Style = PROJETOBASE.LabelStyle.Normal
        Me.LblProgress.TabIndex = 8
        Me.LblProgress.Visible = False
        '
        'FormSincronizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Sincronizar Dados"
        Me.ClientSize = New System.Drawing.Size(960, 450)
        Me.FormIcon = FontAwesome.Sharp.IconChar.RotateBackward
        Me.Name = "FormSincronizar"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Sincronizar Dados"
        Me._pnlClientArea.ResumeLayout(False)
        Me.RjPanel1.ResumeLayout(False)
        Me.RjPanel1.PerformLayout()
        Me.RjPanelEstatistica.ResumeLayout(False)
        Me.RjPanelEstatistica.PerformLayout()
        Me.RjPanel3.ResumeLayout(False)
        Me.RjPanel2.ResumeLayout(False)
        Me.RjPanel4.ResumeLayout(False)
        CType(Me.ImgSinc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RjPanel1 As RJPanel
    Friend WithEvents RjPanelEstatistica As RJPanel
    Friend WithEvents BtnChecar As RJButton
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents RjPanel3 As RJPanel
    Friend WithEvents LblDependenciasRemoto As RJLabel
    Friend WithEvents LblDependenciasLocal As RJLabel
    Friend WithEvents LblSetoresRemoto As RJLabel
    Friend WithEvents LblSetoresLocal As RJLabel
    Friend WithEvents LblIgrejasRemoto As RJLabel
    Friend WithEvents LblIgrejasLocal As RJLabel
    Friend WithEvents LblinventariosRemoto As RJLabel
    Friend WithEvents LblinventariosLocal As RJLabel
    Friend WithEvents BtnSincronizar As RJButton
    Friend WithEvents LblMsgTitulo As RJLabel
    Friend WithEvents RjProgressBar1 As RJProgressBar
    Friend WithEvents LblMsgDescricao As RJLabel
    Friend WithEvents RjPanel2 As RJPanel
    Friend WithEvents ImgSinc As RJPictureBox
    Friend WithEvents RjPanel4 As RJPanel
    Friend WithEvents RjProgressBar2 As RJProgressBar
    Friend WithEvents LblProgress As RJLabel
End Class
