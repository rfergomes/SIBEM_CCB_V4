<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIgrejasCad
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtRazao_Social = New PROJETOBASE.RJTextBox()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.TxtIgreja = New PROJETOBASE.RJTextBox()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.TxtCod_Siga = New PROJETOBASE.RJTextBox()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.TxtCodigo = New PROJETOBASE.RJTextBox()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.lblTitulo = New PROJETOBASE.RJLabel()
        Me.RjLabel5 = New PROJETOBASE.RJLabel()
        Me.TxtCNPJ = New PROJETOBASE.RJTextBox()
        Me.RjLabel6 = New PROJETOBASE.RJLabel()
        Me.TxtLogradouro = New PROJETOBASE.RJTextBox()
        Me.RjLabel7 = New PROJETOBASE.RJLabel()
        Me.TxtNumero = New PROJETOBASE.RJTextBox()
        Me.RjLabel8 = New PROJETOBASE.RJLabel()
        Me.RjLabel9 = New PROJETOBASE.RJLabel()
        Me.TxtCidade = New PROJETOBASE.RJTextBox()
        Me.RjLabel10 = New PROJETOBASE.RJLabel()
        Me.TxtBairro = New PROJETOBASE.RJTextBox()
        Me.RjLabel11 = New PROJETOBASE.RJLabel()
        Me.RjLabel12 = New PROJETOBASE.RJLabel()
        Me.RjLabel13 = New PROJETOBASE.RJLabel()
        Me.BtnSalvar = New PROJETOBASE.RJButton()
        Me.RjLabel14 = New PROJETOBASE.RJLabel()
        Me.TxtObservacao = New PROJETOBASE.RJTextBox()
        Me.RjLabel15 = New PROJETOBASE.RJLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CboTipo = New PROJETOBASE.RJComboBox()
        Me.CboSetor = New PROJETOBASE.RJComboBox()
        Me.CboStatus = New PROJETOBASE.RJComboBox()
        Me.CboAdmlc = New PROJETOBASE.RJComboBox()
        Me.CboUF = New PROJETOBASE.RJComboBox()
        Me.BtnFechar = New PROJETOBASE.RJButton()
        Me._pnlClientArea.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.BtnFechar)
        Me._pnlClientArea.Controls.Add(Me.CboUF)
        Me._pnlClientArea.Controls.Add(Me.CboAdmlc)
        Me._pnlClientArea.Controls.Add(Me.CboStatus)
        Me._pnlClientArea.Controls.Add(Me.CboSetor)
        Me._pnlClientArea.Controls.Add(Me.CboTipo)
        Me._pnlClientArea.Controls.Add(Me.TxtObservacao)
        Me._pnlClientArea.Controls.Add(Me.RjLabel15)
        Me._pnlClientArea.Controls.Add(Me.BtnSalvar)
        Me._pnlClientArea.Controls.Add(Me.TxtLogradouro)
        Me._pnlClientArea.Controls.Add(Me.RjLabel13)
        Me._pnlClientArea.Controls.Add(Me.RjLabel6)
        Me._pnlClientArea.Controls.Add(Me.RjLabel12)
        Me._pnlClientArea.Controls.Add(Me.RjLabel14)
        Me._pnlClientArea.Controls.Add(Me.TxtBairro)
        Me._pnlClientArea.Controls.Add(Me.RjLabel11)
        Me._pnlClientArea.Controls.Add(Me.RjLabel10)
        Me._pnlClientArea.Controls.Add(Me.TxtCidade)
        Me._pnlClientArea.Controls.Add(Me.RjLabel9)
        Me._pnlClientArea.Controls.Add(Me.TxtRazao_Social)
        Me._pnlClientArea.Controls.Add(Me.RjLabel3)
        Me._pnlClientArea.Controls.Add(Me.TxtIgreja)
        Me._pnlClientArea.Controls.Add(Me.RjLabel4)
        Me._pnlClientArea.Controls.Add(Me.TxtCNPJ)
        Me._pnlClientArea.Controls.Add(Me.RjLabel5)
        Me._pnlClientArea.Controls.Add(Me.RjLabel8)
        Me._pnlClientArea.Controls.Add(Me.TxtNumero)
        Me._pnlClientArea.Controls.Add(Me.RjLabel7)
        Me._pnlClientArea.Controls.Add(Me.TxtCod_Siga)
        Me._pnlClientArea.Controls.Add(Me.RjLabel2)
        Me._pnlClientArea.Controls.Add(Me.TxtCodigo)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Controls.Add(Me.lblTitulo)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.MinimumSize = New System.Drawing.Size(261, 61)
        Me._pnlClientArea.Size = New System.Drawing.Size(671, 473)
        '
        'TxtRazao_Social
        '
        Me.TxtRazao_Social._Customizable = False
        Me.TxtRazao_Social.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtRazao_Social.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtRazao_Social.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtRazao_Social.BorderRadius = 10
        Me.TxtRazao_Social.BorderSize = 2
        Me.TxtRazao_Social.Enabled = False
        Me.TxtRazao_Social.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtRazao_Social.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtRazao_Social.Location = New System.Drawing.Point(27, 129)
        Me.TxtRazao_Social.MultiLine = False
        Me.TxtRazao_Social.Name = "TxtRazao_Social"
        Me.TxtRazao_Social.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtRazao_Social.PasswordChar = False
        Me.TxtRazao_Social.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtRazao_Social.PlaceHolderText = "CONGREGAÇÃO CRISTÃ NO BRASIL"
        Me.TxtRazao_Social.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtRazao_Social.Size = New System.Drawing.Size(424, 31)
        Me.TxtRazao_Social.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtRazao_Social.TabIndex = 4
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(30, 111)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(90, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 17
        Me.RjLabel3.Text = "Razão Social"
        '
        'TxtIgreja
        '
        Me.TxtIgreja._Customizable = False
        Me.TxtIgreja.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtIgreja.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtIgreja.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtIgreja.BorderRadius = 10
        Me.TxtIgreja.BorderSize = 2
        Me.TxtIgreja.Enabled = False
        Me.TxtIgreja.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtIgreja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ErrorProvider1.SetIconAlignment(Me.TxtIgreja, System.Windows.Forms.ErrorIconAlignment.BottomRight)
        Me.TxtIgreja.Location = New System.Drawing.Point(108, 70)
        Me.TxtIgreja.MultiLine = False
        Me.TxtIgreja.Name = "TxtIgreja"
        Me.TxtIgreja.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtIgreja.PasswordChar = False
        Me.TxtIgreja.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtIgreja.PlaceHolderText = Nothing
        Me.TxtIgreja.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtIgreja.Size = New System.Drawing.Size(418, 31)
        Me.TxtIgreja.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtIgreja.TabIndex = 2
        Me.TxtIgreja.Tag = "CASA DE ORAÇÃO"
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(111, 51)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(112, 16)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel4.TabIndex = 15
        Me.RjLabel4.Text = "Casa de Oração"
        '
        'TxtCod_Siga
        '
        Me.TxtCod_Siga._Customizable = False
        Me.TxtCod_Siga.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtCod_Siga.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCod_Siga.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtCod_Siga.BorderRadius = 10
        Me.TxtCod_Siga.BorderSize = 2
        Me.TxtCod_Siga.Enabled = False
        Me.TxtCod_Siga.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtCod_Siga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ErrorProvider1.SetIconAlignment(Me.TxtCod_Siga, System.Windows.Forms.ErrorIconAlignment.BottomRight)
        Me.TxtCod_Siga.Location = New System.Drawing.Point(532, 70)
        Me.TxtCod_Siga.MultiLine = False
        Me.TxtCod_Siga.Name = "TxtCod_Siga"
        Me.TxtCod_Siga.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtCod_Siga.PasswordChar = False
        Me.TxtCod_Siga.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtCod_Siga.PlaceHolderText = Nothing
        Me.TxtCod_Siga.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtCod_Siga.Size = New System.Drawing.Size(112, 31)
        Me.TxtCod_Siga.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtCod_Siga.TabIndex = 3
        Me.TxtCod_Siga.Tag = "CÓDIGO SIGA"
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(535, 51)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(88, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 13
        Me.RjLabel2.Text = "Código SIGA"
        '
        'TxtCodigo
        '
        Me.TxtCodigo._Customizable = False
        Me.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtCodigo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCodigo.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtCodigo.BorderRadius = 10
        Me.TxtCodigo.BorderSize = 2
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ErrorProvider1.SetIconAlignment(Me.TxtCodigo, System.Windows.Forms.ErrorIconAlignment.BottomRight)
        Me.TxtCodigo.Location = New System.Drawing.Point(27, 70)
        Me.TxtCodigo.MultiLine = False
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtCodigo.PasswordChar = False
        Me.TxtCodigo.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtCodigo.PlaceHolderText = Nothing
        Me.TxtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtCodigo.Size = New System.Drawing.Size(75, 31)
        Me.TxtCodigo.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtCodigo.TabIndex = 1
        Me.TxtCodigo.Tag = "CÓDIGO"
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(30, 51)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(51, 16)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel1.TabIndex = 11
        Me.RjLabel1.Text = "Código"
        '
        'lblTitulo
        '
        Me.lblTitulo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblTitulo.LinkLabel = False
        Me.lblTitulo.Location = New System.Drawing.Point(148, 3)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(374, 25)
        Me.lblTitulo.Style = PROJETOBASE.LabelStyle.Title
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RjLabel5
        '
        Me.RjLabel5.AutoSize = True
        Me.RjLabel5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel5.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel5.LinkLabel = False
        Me.RjLabel5.Location = New System.Drawing.Point(460, 111)
        Me.RjLabel5.Name = "RjLabel5"
        Me.RjLabel5.Size = New System.Drawing.Size(39, 16)
        Me.RjLabel5.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel5.TabIndex = 13
        Me.RjLabel5.Text = "CNPJ"
        '
        'TxtCNPJ
        '
        Me.TxtCNPJ._Customizable = False
        Me.TxtCNPJ.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtCNPJ.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCNPJ.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtCNPJ.BorderRadius = 10
        Me.TxtCNPJ.BorderSize = 2
        Me.TxtCNPJ.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtCNPJ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCNPJ.Location = New System.Drawing.Point(457, 129)
        Me.TxtCNPJ.MultiLine = False
        Me.TxtCNPJ.Name = "TxtCNPJ"
        Me.TxtCNPJ.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtCNPJ.PasswordChar = False
        Me.TxtCNPJ.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtCNPJ.PlaceHolderText = Nothing
        Me.TxtCNPJ.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtCNPJ.Size = New System.Drawing.Size(187, 31)
        Me.TxtCNPJ.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtCNPJ.TabIndex = 5
        '
        'RjLabel6
        '
        Me.RjLabel6.AutoSize = True
        Me.RjLabel6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel6.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel6.LinkLabel = False
        Me.RjLabel6.Location = New System.Drawing.Point(30, 169)
        Me.RjLabel6.Name = "RjLabel6"
        Me.RjLabel6.Size = New System.Drawing.Size(80, 16)
        Me.RjLabel6.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel6.TabIndex = 17
        Me.RjLabel6.Text = "Logradouro"
        '
        'TxtLogradouro
        '
        Me.TxtLogradouro._Customizable = False
        Me.TxtLogradouro.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtLogradouro.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtLogradouro.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtLogradouro.BorderRadius = 10
        Me.TxtLogradouro.BorderSize = 2
        Me.TxtLogradouro.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtLogradouro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtLogradouro.Location = New System.Drawing.Point(27, 188)
        Me.TxtLogradouro.MultiLine = False
        Me.TxtLogradouro.Name = "TxtLogradouro"
        Me.TxtLogradouro.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtLogradouro.PasswordChar = False
        Me.TxtLogradouro.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtLogradouro.PlaceHolderText = Nothing
        Me.TxtLogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtLogradouro.Size = New System.Drawing.Size(499, 31)
        Me.TxtLogradouro.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtLogradouro.TabIndex = 6
        '
        'RjLabel7
        '
        Me.RjLabel7.AutoSize = True
        Me.RjLabel7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel7.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel7.LinkLabel = False
        Me.RjLabel7.Location = New System.Drawing.Point(535, 169)
        Me.RjLabel7.Name = "RjLabel7"
        Me.RjLabel7.Size = New System.Drawing.Size(56, 16)
        Me.RjLabel7.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel7.TabIndex = 13
        Me.RjLabel7.Text = "Número"
        '
        'TxtNumero
        '
        Me.TxtNumero._Customizable = False
        Me.TxtNumero.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtNumero.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtNumero.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtNumero.BorderRadius = 10
        Me.TxtNumero.BorderSize = 2
        Me.TxtNumero.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtNumero.Location = New System.Drawing.Point(532, 188)
        Me.TxtNumero.MultiLine = False
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtNumero.PasswordChar = False
        Me.TxtNumero.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtNumero.PlaceHolderText = Nothing
        Me.TxtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtNumero.Size = New System.Drawing.Size(112, 31)
        Me.TxtNumero.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtNumero.TabIndex = 7
        '
        'RjLabel8
        '
        Me.RjLabel8.AutoSize = True
        Me.RjLabel8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel8.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel8.LinkLabel = False
        Me.RjLabel8.Location = New System.Drawing.Point(562, 228)
        Me.RjLabel8.Name = "RjLabel8"
        Me.RjLabel8.Size = New System.Drawing.Size(24, 16)
        Me.RjLabel8.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel8.TabIndex = 13
        Me.RjLabel8.Text = "UF"
        '
        'RjLabel9
        '
        Me.RjLabel9.AutoSize = True
        Me.RjLabel9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel9.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel9.LinkLabel = False
        Me.RjLabel9.Location = New System.Drawing.Point(313, 228)
        Me.RjLabel9.Name = "RjLabel9"
        Me.RjLabel9.Size = New System.Drawing.Size(51, 16)
        Me.RjLabel9.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel9.TabIndex = 17
        Me.RjLabel9.Text = "Cidade"
        '
        'TxtCidade
        '
        Me.TxtCidade._Customizable = False
        Me.TxtCidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtCidade.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCidade.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtCidade.BorderRadius = 10
        Me.TxtCidade.BorderSize = 2
        Me.TxtCidade.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCidade.Location = New System.Drawing.Point(310, 247)
        Me.TxtCidade.MultiLine = False
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtCidade.PasswordChar = False
        Me.TxtCidade.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtCidade.PlaceHolderText = Nothing
        Me.TxtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtCidade.Size = New System.Drawing.Size(241, 31)
        Me.TxtCidade.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtCidade.TabIndex = 9
        '
        'RjLabel10
        '
        Me.RjLabel10.AutoSize = True
        Me.RjLabel10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel10.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel10.LinkLabel = False
        Me.RjLabel10.Location = New System.Drawing.Point(30, 228)
        Me.RjLabel10.Name = "RjLabel10"
        Me.RjLabel10.Size = New System.Drawing.Size(44, 16)
        Me.RjLabel10.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel10.TabIndex = 17
        Me.RjLabel10.Text = "Bairro"
        '
        'TxtBairro
        '
        Me.TxtBairro._Customizable = False
        Me.TxtBairro.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtBairro.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtBairro.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtBairro.BorderRadius = 10
        Me.TxtBairro.BorderSize = 2
        Me.TxtBairro.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtBairro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtBairro.Location = New System.Drawing.Point(27, 247)
        Me.TxtBairro.MultiLine = False
        Me.TxtBairro.Name = "TxtBairro"
        Me.TxtBairro.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtBairro.PasswordChar = False
        Me.TxtBairro.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtBairro.PlaceHolderText = Nothing
        Me.TxtBairro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtBairro.Size = New System.Drawing.Size(277, 31)
        Me.TxtBairro.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtBairro.TabIndex = 8
        '
        'RjLabel11
        '
        Me.RjLabel11.AutoSize = True
        Me.RjLabel11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel11.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel11.LinkLabel = False
        Me.RjLabel11.Location = New System.Drawing.Point(30, 287)
        Me.RjLabel11.Name = "RjLabel11"
        Me.RjLabel11.Size = New System.Drawing.Size(35, 16)
        Me.RjLabel11.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel11.TabIndex = 17
        Me.RjLabel11.Text = "Tipo"
        '
        'RjLabel12
        '
        Me.RjLabel12.AutoSize = True
        Me.RjLabel12.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel12.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel12.LinkLabel = False
        Me.RjLabel12.Location = New System.Drawing.Point(37, 345)
        Me.RjLabel12.Name = "RjLabel12"
        Me.RjLabel12.Size = New System.Drawing.Size(99, 16)
        Me.RjLabel12.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel12.TabIndex = 17
        Me.RjLabel12.Text = "Administração"
        '
        'RjLabel13
        '
        Me.RjLabel13.AutoSize = True
        Me.RjLabel13.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel13.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel13.LinkLabel = False
        Me.RjLabel13.Location = New System.Drawing.Point(252, 287)
        Me.RjLabel13.Name = "RjLabel13"
        Me.RjLabel13.Size = New System.Drawing.Size(43, 16)
        Me.RjLabel13.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel13.TabIndex = 17
        Me.RjLabel13.Text = "Setor"
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnSalvar.BorderRadius = 5
        Me.BtnSalvar.BorderSize = 1
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Design = PROJETOBASE.ButtonDesign.Confirm
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        Me.BtnSalvar.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSalvar.IconSize = 24
        Me.BtnSalvar.Location = New System.Drawing.Point(448, 419)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(95, 30)
        Me.BtnSalvar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BtnSalvar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnSalvar.TabIndex = 16
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'RjLabel14
        '
        Me.RjLabel14.AutoSize = True
        Me.RjLabel14.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel14.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel14.LinkLabel = False
        Me.RjLabel14.Location = New System.Drawing.Point(475, 287)
        Me.RjLabel14.Name = "RjLabel14"
        Me.RjLabel14.Size = New System.Drawing.Size(51, 16)
        Me.RjLabel14.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel14.TabIndex = 17
        Me.RjLabel14.Text = "Status"
        '
        'TxtObservacao
        '
        Me.TxtObservacao._Customizable = False
        Me.TxtObservacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtObservacao.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtObservacao.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtObservacao.BorderRadius = 10
        Me.TxtObservacao.BorderSize = 2
        Me.TxtObservacao.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtObservacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtObservacao.Location = New System.Drawing.Point(332, 365)
        Me.TxtObservacao.MultiLine = False
        Me.TxtObservacao.Name = "TxtObservacao"
        Me.TxtObservacao.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtObservacao.PasswordChar = False
        Me.TxtObservacao.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtObservacao.PlaceHolderText = Nothing
        Me.TxtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtObservacao.Size = New System.Drawing.Size(312, 31)
        Me.TxtObservacao.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtObservacao.TabIndex = 15
        '
        'RjLabel15
        '
        Me.RjLabel15.AutoSize = True
        Me.RjLabel15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel15.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel15.LinkLabel = False
        Me.RjLabel15.Location = New System.Drawing.Point(340, 345)
        Me.RjLabel15.Name = "RjLabel15"
        Me.RjLabel15.Size = New System.Drawing.Size(85, 16)
        Me.RjLabel15.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel15.TabIndex = 23
        Me.RjLabel15.Text = "Observação"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'CboTipo
        '
        Me.CboTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CboTipo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboTipo.BorderRadius = 10
        Me.CboTipo.BorderSize = 2
        Me.CboTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboTipo.Customizable = False
        Me.CboTipo.DataSource = Nothing
        Me.CboTipo.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboTipo.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboTipo.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.CboTipo.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboTipo.Location = New System.Drawing.Point(27, 306)
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.Padding = New System.Windows.Forms.Padding(3)
        Me.CboTipo.SelectedIndex = -1
        Me.CboTipo.SelectedItem = Nothing
        Me.CboTipo.SelectedValue = Nothing
        Me.CboTipo.Size = New System.Drawing.Size(217, 32)
        Me.CboTipo.Style = PROJETOBASE.ControlStyle.Glass
        Me.CboTipo.TabIndex = 11
        Me.CboTipo.Tag = "TIPO"
        Me.CboTipo.Texts = ""
        '
        'CboSetor
        '
        Me.CboSetor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CboSetor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CboSetor.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CboSetor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboSetor.BorderRadius = 10
        Me.CboSetor.BorderSize = 2
        Me.CboSetor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboSetor.Customizable = False
        Me.CboSetor.DataSource = Nothing
        Me.CboSetor.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CboSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboSetor.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboSetor.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.CboSetor.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboSetor.Location = New System.Drawing.Point(250, 306)
        Me.CboSetor.Name = "CboSetor"
        Me.CboSetor.Padding = New System.Windows.Forms.Padding(3)
        Me.CboSetor.SelectedIndex = -1
        Me.CboSetor.SelectedItem = Nothing
        Me.CboSetor.SelectedValue = Nothing
        Me.CboSetor.Size = New System.Drawing.Size(217, 32)
        Me.CboSetor.Style = PROJETOBASE.ControlStyle.Glass
        Me.CboSetor.TabIndex = 12
        Me.CboSetor.Tag = "SETOR"
        Me.CboSetor.Texts = ""
        '
        'CboStatus
        '
        Me.CboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CboStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CboStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboStatus.BorderRadius = 10
        Me.CboStatus.BorderSize = 2
        Me.CboStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboStatus.Customizable = False
        Me.CboStatus.DataSource = Nothing
        Me.CboStatus.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboStatus.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboStatus.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.CboStatus.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboStatus.Location = New System.Drawing.Point(473, 306)
        Me.CboStatus.Name = "CboStatus"
        Me.CboStatus.Padding = New System.Windows.Forms.Padding(3)
        Me.CboStatus.SelectedIndex = -1
        Me.CboStatus.SelectedItem = Nothing
        Me.CboStatus.SelectedValue = Nothing
        Me.CboStatus.Size = New System.Drawing.Size(171, 32)
        Me.CboStatus.Style = PROJETOBASE.ControlStyle.Glass
        Me.CboStatus.TabIndex = 13
        Me.CboStatus.Tag = "STATUS"
        Me.CboStatus.Texts = ""
        '
        'CboAdmlc
        '
        Me.CboAdmlc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CboAdmlc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CboAdmlc.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CboAdmlc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboAdmlc.BorderRadius = 10
        Me.CboAdmlc.BorderSize = 2
        Me.CboAdmlc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboAdmlc.Customizable = False
        Me.CboAdmlc.DataSource = Nothing
        Me.CboAdmlc.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CboAdmlc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboAdmlc.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboAdmlc.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.CboAdmlc.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboAdmlc.Location = New System.Drawing.Point(27, 364)
        Me.CboAdmlc.Name = "CboAdmlc"
        Me.CboAdmlc.Padding = New System.Windows.Forms.Padding(3)
        Me.CboAdmlc.SelectedIndex = -1
        Me.CboAdmlc.SelectedItem = Nothing
        Me.CboAdmlc.SelectedValue = Nothing
        Me.CboAdmlc.Size = New System.Drawing.Size(299, 32)
        Me.CboAdmlc.Style = PROJETOBASE.ControlStyle.Glass
        Me.CboAdmlc.TabIndex = 14
        Me.CboAdmlc.Tag = "ADMINISTRAÇÃO"
        Me.CboAdmlc.Texts = ""
        '
        'CboUF
        '
        Me.CboUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.CboUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.CboUF.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CboUF.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboUF.BorderRadius = 10
        Me.CboUF.BorderSize = 2
        Me.CboUF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CboUF.Customizable = False
        Me.CboUF.DataSource = Nothing
        Me.CboUF.DropDownBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.CboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CboUF.DropDownTextColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboUF.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.CboUF.IconColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CboUF.Location = New System.Drawing.Point(557, 247)
        Me.CboUF.Name = "CboUF"
        Me.CboUF.Padding = New System.Windows.Forms.Padding(3)
        Me.CboUF.SelectedIndex = -1
        Me.CboUF.SelectedItem = Nothing
        Me.CboUF.SelectedValue = Nothing
        Me.CboUF.Size = New System.Drawing.Size(87, 32)
        Me.CboUF.Style = PROJETOBASE.ControlStyle.Glass
        Me.CboUF.TabIndex = 10
        Me.CboUF.Tag = "UF"
        Me.CboUF.Texts = ""
        '
        'BtnFechar
        '
        Me.BtnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BtnFechar.BorderRadius = 5
        Me.BtnFechar.BorderSize = 1
        Me.BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFechar.Design = PROJETOBASE.ButtonDesign.Confirm
        Me.BtnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnFechar.FlatAppearance.BorderSize = 0
        Me.BtnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFechar.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket
        Me.BtnFechar.IconColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFechar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnFechar.IconSize = 24
        Me.BtnFechar.Location = New System.Drawing.Point(549, 419)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(95, 30)
        Me.BtnFechar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnFechar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnFechar.TabIndex = 17
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFechar.UseVisualStyleBackColor = False
        '
        'FormIgrejasCad
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.CancelButton = Me.BtnFechar
        Me.Caption = "Cadastro ou Alteração"
        Me.ClientSize = New System.Drawing.Size(673, 515)
        Me.DisableFormOptions = True
        Me.DisplayMaximizeButton = False
        Me.DisplayMinimizeButton = False
        Me.FormIcon = FontAwesome.Sharp.IconChar.Edit
        Me.Name = "FormIgrejasCad"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Resizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cadastro ou Alteração"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtRazao_Social As RJTextBox
    Friend WithEvents RjLabel3 As RJLabel
    Friend WithEvents TxtIgreja As RJTextBox
    Friend WithEvents RjLabel4 As RJLabel
    Friend WithEvents TxtCod_Siga As RJTextBox
    Friend WithEvents RjLabel2 As RJLabel
    Friend WithEvents TxtCodigo As RJTextBox
    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents lblTitulo As RJLabel
    Friend WithEvents TxtLogradouro As RJTextBox
    Friend WithEvents RjLabel6 As RJLabel
    Friend WithEvents TxtCNPJ As RJTextBox
    Friend WithEvents RjLabel5 As RJLabel
    Friend WithEvents TxtNumero As RJTextBox
    Friend WithEvents RjLabel7 As RJLabel
    Friend WithEvents RjLabel13 As RJLabel
    Friend WithEvents RjLabel12 As RJLabel
    Friend WithEvents TxtBairro As RJTextBox
    Friend WithEvents RjLabel11 As RJLabel
    Friend WithEvents RjLabel10 As RJLabel
    Friend WithEvents TxtCidade As RJTextBox
    Friend WithEvents RjLabel9 As RJLabel
    Friend WithEvents RjLabel8 As RJLabel
    Friend WithEvents BtnSalvar As RJButton
    Friend WithEvents RjLabel14 As RJLabel
    Friend WithEvents TxtObservacao As RJTextBox
    Friend WithEvents RjLabel15 As RJLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents CboTipo As RJComboBox
    Friend WithEvents CboAdmlc As RJComboBox
    Friend WithEvents CboStatus As RJComboBox
    Friend WithEvents CboSetor As RJComboBox
    Friend WithEvents CboUF As RJComboBox
    Friend WithEvents BtnFechar As RJButton
End Class
