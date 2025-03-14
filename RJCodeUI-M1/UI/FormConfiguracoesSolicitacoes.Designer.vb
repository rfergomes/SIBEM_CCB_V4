<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfiguracoesSolicitacoes
    Inherits RJChildForm

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RjLabel1 = New PROJETOBASE.RJLabel()
        Me.TxtNome = New PROJETOBASE.RJTextBox()
        Me.RjLabel4 = New PROJETOBASE.RJLabel()
        Me.TxtEmail = New PROJETOBASE.RJTextBox()
        Me.RjLabel2 = New PROJETOBASE.RJLabel()
        Me.TxtCodigo = New PROJETOBASE.RJTextBox()
        Me.RjLabel3 = New PROJETOBASE.RJLabel()
        Me.RjLabel5 = New PROJETOBASE.RJLabel()
        Me.TxtTelefone = New PROJETOBASE.RJTextBox()
        Me.TxtComum = New PROJETOBASE.RJTextBox()
        Me.RjLabel6 = New PROJETOBASE.RJLabel()
        Me.TxtCidade = New PROJETOBASE.RJTextBox()
        Me.RjLabel7 = New PROJETOBASE.RJLabel()
        Me.TxtSetor = New PROJETOBASE.RJTextBox()
        Me.RjLabel8 = New PROJETOBASE.RJLabel()
        Me.RjLabel9 = New PROJETOBASE.RJLabel()
        Me.TxtAdmlc = New PROJETOBASE.RJTextBox()
        Me.RjLabel10 = New PROJETOBASE.RJLabel()
        Me.TxtStatus = New PROJETOBASE.RJTextBox()
        Me.RjPanel1 = New PROJETOBASE.RJPanel()
        Me.DgvAdmlc = New PROJETOBASE.RJDataGridView()
        Me.RjPanel2 = New PROJETOBASE.RJPanel()
        Me.RjButton1 = New PROJETOBASE.RJButton()
        Me.TxtPesquisar = New PROJETOBASE.RJTextBox()
        Me.LblConsultarAdm = New PROJETOBASE.RJLabel()
        Me.BtnLiberar = New PROJETOBASE.RJButton()
        Me.BtnBloquear = New PROJETOBASE.RJButton()
        Me.RjPanel3 = New PROJETOBASE.RJPanel()
        Me.TxtToken = New PROJETOBASE.RJTextBox()
        Me.lblNumberItems = New PROJETOBASE.RJLabel()
        Me.BtnWhatsApp = New PROJETOBASE.RJButton()
        Me._pnlClientArea.SuspendLayout()
        Me.RjPanel1.SuspendLayout()
        CType(Me.DgvAdmlc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RjPanel2.SuspendLayout()
        Me.RjPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        '_pnlClientArea
        '
        Me._pnlClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me._pnlClientArea.Controls.Add(Me.BtnWhatsApp)
        Me._pnlClientArea.Controls.Add(Me.lblNumberItems)
        Me._pnlClientArea.Controls.Add(Me.RjPanel3)
        Me._pnlClientArea.Controls.Add(Me.BtnBloquear)
        Me._pnlClientArea.Controls.Add(Me.BtnLiberar)
        Me._pnlClientArea.Controls.Add(Me.LblConsultarAdm)
        Me._pnlClientArea.Controls.Add(Me.RjPanel2)
        Me._pnlClientArea.Controls.Add(Me.RjPanel1)
        Me._pnlClientArea.Controls.Add(Me.RjLabel1)
        Me._pnlClientArea.Location = New System.Drawing.Point(1, 41)
        Me._pnlClientArea.Size = New System.Drawing.Size(934, 453)
        '
        'RjLabel1
        '
        Me.RjLabel1.AutoSize = True
        Me.RjLabel1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.RjLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.RjLabel1.LinkLabel = False
        Me.RjLabel1.Location = New System.Drawing.Point(182, 16)
        Me.RjLabel1.Name = "RjLabel1"
        Me.RjLabel1.Size = New System.Drawing.Size(219, 18)
        Me.RjLabel1.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.RjLabel1.TabIndex = 0
        Me.RjLabel1.Text = "SOLICITAÇÃO DE ACESSO"
        '
        'TxtNome
        '
        Me.TxtNome._Customizable = False
        Me.TxtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtNome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtNome.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtNome.BorderRadius = 10
        Me.TxtNome.BorderSize = 2
        Me.TxtNome.Enabled = False
        Me.TxtNome.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtNome.Location = New System.Drawing.Point(94, 27)
        Me.TxtNome.MultiLine = False
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtNome.PasswordChar = False
        Me.TxtNome.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtNome.PlaceHolderText = Nothing
        Me.TxtNome.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtNome.Size = New System.Drawing.Size(418, 31)
        Me.TxtNome.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtNome.TabIndex = 22
        Me.TxtNome.Tag = ""
        '
        'RjLabel4
        '
        Me.RjLabel4.AutoSize = True
        Me.RjLabel4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel4.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel4.LinkLabel = False
        Me.RjLabel4.Location = New System.Drawing.Point(108, 8)
        Me.RjLabel4.Name = "RjLabel4"
        Me.RjLabel4.Size = New System.Drawing.Size(43, 16)
        Me.RjLabel4.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel4.TabIndex = 21
        Me.RjLabel4.Text = "Nome"
        '
        'TxtEmail
        '
        Me.TxtEmail._Customizable = False
        Me.TxtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtEmail.BorderRadius = 10
        Me.TxtEmail.BorderSize = 2
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtEmail.Location = New System.Drawing.Point(13, 88)
        Me.TxtEmail.MultiLine = False
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtEmail.PasswordChar = False
        Me.TxtEmail.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtEmail.PlaceHolderText = Nothing
        Me.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtEmail.Size = New System.Drawing.Size(353, 31)
        Me.TxtEmail.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtEmail.TabIndex = 20
        Me.TxtEmail.Tag = ""
        '
        'RjLabel2
        '
        Me.RjLabel2.AutoSize = True
        Me.RjLabel2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel2.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel2.LinkLabel = False
        Me.RjLabel2.Location = New System.Drawing.Point(16, 69)
        Me.RjLabel2.Name = "RjLabel2"
        Me.RjLabel2.Size = New System.Drawing.Size(40, 16)
        Me.RjLabel2.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel2.TabIndex = 19
        Me.RjLabel2.Text = "Email"
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
        Me.TxtCodigo.Location = New System.Drawing.Point(13, 27)
        Me.TxtCodigo.MultiLine = False
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtCodigo.PasswordChar = False
        Me.TxtCodigo.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtCodigo.PlaceHolderText = Nothing
        Me.TxtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtCodigo.Size = New System.Drawing.Size(75, 31)
        Me.TxtCodigo.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtCodigo.TabIndex = 18
        Me.TxtCodigo.Tag = "CÓDIGO"
        '
        'RjLabel3
        '
        Me.RjLabel3.AutoSize = True
        Me.RjLabel3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel3.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel3.LinkLabel = False
        Me.RjLabel3.Location = New System.Drawing.Point(16, 8)
        Me.RjLabel3.Name = "RjLabel3"
        Me.RjLabel3.Size = New System.Drawing.Size(51, 16)
        Me.RjLabel3.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel3.TabIndex = 17
        Me.RjLabel3.Text = "Código"
        '
        'RjLabel5
        '
        Me.RjLabel5.AutoSize = True
        Me.RjLabel5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel5.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel5.LinkLabel = False
        Me.RjLabel5.Location = New System.Drawing.Point(381, 69)
        Me.RjLabel5.Name = "RjLabel5"
        Me.RjLabel5.Size = New System.Drawing.Size(63, 16)
        Me.RjLabel5.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel5.TabIndex = 17
        Me.RjLabel5.Text = "Telefone"
        '
        'TxtTelefone
        '
        Me.TxtTelefone._Customizable = False
        Me.TxtTelefone.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtTelefone.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtTelefone.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtTelefone.BorderRadius = 10
        Me.TxtTelefone.BorderSize = 2
        Me.TxtTelefone.Enabled = False
        Me.TxtTelefone.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtTelefone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtTelefone.Location = New System.Drawing.Point(372, 88)
        Me.TxtTelefone.MultiLine = False
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtTelefone.PasswordChar = False
        Me.TxtTelefone.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtTelefone.PlaceHolderText = Nothing
        Me.TxtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtTelefone.Size = New System.Drawing.Size(140, 31)
        Me.TxtTelefone.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtTelefone.TabIndex = 18
        Me.TxtTelefone.Tag = ""
        '
        'TxtComum
        '
        Me.TxtComum._Customizable = False
        Me.TxtComum.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtComum.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtComum.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtComum.BorderRadius = 10
        Me.TxtComum.BorderSize = 2
        Me.TxtComum.Enabled = False
        Me.TxtComum.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtComum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtComum.Location = New System.Drawing.Point(13, 149)
        Me.TxtComum.MultiLine = False
        Me.TxtComum.Name = "TxtComum"
        Me.TxtComum.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtComum.PasswordChar = False
        Me.TxtComum.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtComum.PlaceHolderText = Nothing
        Me.TxtComum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtComum.Size = New System.Drawing.Size(301, 31)
        Me.TxtComum.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtComum.TabIndex = 24
        Me.TxtComum.Tag = ""
        '
        'RjLabel6
        '
        Me.RjLabel6.AutoSize = True
        Me.RjLabel6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel6.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel6.LinkLabel = False
        Me.RjLabel6.Location = New System.Drawing.Point(16, 130)
        Me.RjLabel6.Name = "RjLabel6"
        Me.RjLabel6.Size = New System.Drawing.Size(145, 16)
        Me.RjLabel6.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel6.TabIndex = 23
        Me.RjLabel6.Text = "Comum Congregação"
        '
        'TxtCidade
        '
        Me.TxtCidade._Customizable = False
        Me.TxtCidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtCidade.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCidade.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtCidade.BorderRadius = 10
        Me.TxtCidade.BorderSize = 2
        Me.TxtCidade.Enabled = False
        Me.TxtCidade.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtCidade.Location = New System.Drawing.Point(320, 149)
        Me.TxtCidade.MultiLine = False
        Me.TxtCidade.Name = "TxtCidade"
        Me.TxtCidade.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtCidade.PasswordChar = False
        Me.TxtCidade.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtCidade.PlaceHolderText = Nothing
        Me.TxtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtCidade.Size = New System.Drawing.Size(192, 31)
        Me.TxtCidade.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtCidade.TabIndex = 26
        Me.TxtCidade.Tag = ""
        '
        'RjLabel7
        '
        Me.RjLabel7.AutoSize = True
        Me.RjLabel7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel7.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel7.LinkLabel = False
        Me.RjLabel7.Location = New System.Drawing.Point(326, 130)
        Me.RjLabel7.Name = "RjLabel7"
        Me.RjLabel7.Size = New System.Drawing.Size(51, 16)
        Me.RjLabel7.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel7.TabIndex = 25
        Me.RjLabel7.Text = "Cidade"
        '
        'TxtSetor
        '
        Me.TxtSetor._Customizable = False
        Me.TxtSetor.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtSetor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtSetor.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtSetor.BorderRadius = 10
        Me.TxtSetor.BorderSize = 2
        Me.TxtSetor.Enabled = False
        Me.TxtSetor.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtSetor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtSetor.Location = New System.Drawing.Point(13, 210)
        Me.TxtSetor.MultiLine = False
        Me.TxtSetor.Name = "TxtSetor"
        Me.TxtSetor.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtSetor.PasswordChar = False
        Me.TxtSetor.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtSetor.PlaceHolderText = Nothing
        Me.TxtSetor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtSetor.Size = New System.Drawing.Size(127, 31)
        Me.TxtSetor.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtSetor.TabIndex = 28
        Me.TxtSetor.Tag = ""
        '
        'RjLabel8
        '
        Me.RjLabel8.AutoSize = True
        Me.RjLabel8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel8.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel8.LinkLabel = False
        Me.RjLabel8.Location = New System.Drawing.Point(16, 191)
        Me.RjLabel8.Name = "RjLabel8"
        Me.RjLabel8.Size = New System.Drawing.Size(43, 16)
        Me.RjLabel8.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel8.TabIndex = 27
        Me.RjLabel8.Text = "Setor"
        '
        'RjLabel9
        '
        Me.RjLabel9.AutoSize = True
        Me.RjLabel9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel9.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel9.LinkLabel = False
        Me.RjLabel9.Location = New System.Drawing.Point(206, 191)
        Me.RjLabel9.Name = "RjLabel9"
        Me.RjLabel9.Size = New System.Drawing.Size(99, 16)
        Me.RjLabel9.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel9.TabIndex = 27
        Me.RjLabel9.Text = "Administração"
        '
        'TxtAdmlc
        '
        Me.TxtAdmlc._Customizable = False
        Me.TxtAdmlc.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtAdmlc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtAdmlc.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtAdmlc.BorderRadius = 10
        Me.TxtAdmlc.BorderSize = 2
        Me.TxtAdmlc.Enabled = False
        Me.TxtAdmlc.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtAdmlc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtAdmlc.Location = New System.Drawing.Point(199, 210)
        Me.TxtAdmlc.MultiLine = False
        Me.TxtAdmlc.Name = "TxtAdmlc"
        Me.TxtAdmlc.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtAdmlc.PasswordChar = False
        Me.TxtAdmlc.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtAdmlc.PlaceHolderText = Nothing
        Me.TxtAdmlc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtAdmlc.Size = New System.Drawing.Size(127, 31)
        Me.TxtAdmlc.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtAdmlc.TabIndex = 28
        Me.TxtAdmlc.Tag = ""
        '
        'RjLabel10
        '
        Me.RjLabel10.AutoSize = True
        Me.RjLabel10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RjLabel10.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.RjLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjLabel10.LinkLabel = False
        Me.RjLabel10.Location = New System.Drawing.Point(393, 191)
        Me.RjLabel10.Name = "RjLabel10"
        Me.RjLabel10.Size = New System.Drawing.Size(51, 16)
        Me.RjLabel10.Style = PROJETOBASE.LabelStyle.Normal
        Me.RjLabel10.TabIndex = 27
        Me.RjLabel10.Text = "Status"
        '
        'TxtStatus
        '
        Me.TxtStatus._Customizable = False
        Me.TxtStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtStatus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtStatus.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtStatus.BorderRadius = 10
        Me.TxtStatus.BorderSize = 2
        Me.TxtStatus.Enabled = False
        Me.TxtStatus.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtStatus.Location = New System.Drawing.Point(385, 210)
        Me.TxtStatus.MultiLine = False
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtStatus.PasswordChar = False
        Me.TxtStatus.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtStatus.PlaceHolderText = Nothing
        Me.TxtStatus.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtStatus.Size = New System.Drawing.Size(127, 31)
        Me.TxtStatus.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtStatus.TabIndex = 28
        Me.TxtStatus.Tag = ""
        '
        'RjPanel1
        '
        Me.RjPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel1.BorderRadius = 0
        Me.RjPanel1.Controls.Add(Me.TxtStatus)
        Me.RjPanel1.Controls.Add(Me.RjLabel3)
        Me.RjPanel1.Controls.Add(Me.RjLabel10)
        Me.RjPanel1.Controls.Add(Me.TxtCodigo)
        Me.RjPanel1.Controls.Add(Me.TxtAdmlc)
        Me.RjPanel1.Controls.Add(Me.RjLabel5)
        Me.RjPanel1.Controls.Add(Me.RjLabel9)
        Me.RjPanel1.Controls.Add(Me.TxtTelefone)
        Me.RjPanel1.Controls.Add(Me.TxtSetor)
        Me.RjPanel1.Controls.Add(Me.RjLabel2)
        Me.RjPanel1.Controls.Add(Me.RjLabel8)
        Me.RjPanel1.Controls.Add(Me.TxtEmail)
        Me.RjPanel1.Controls.Add(Me.TxtCidade)
        Me.RjPanel1.Controls.Add(Me.RjLabel4)
        Me.RjPanel1.Controls.Add(Me.RjLabel7)
        Me.RjPanel1.Controls.Add(Me.TxtNome)
        Me.RjPanel1.Controls.Add(Me.TxtComum)
        Me.RjPanel1.Controls.Add(Me.RjLabel6)
        Me.RjPanel1.Customizable = False
        Me.RjPanel1.Location = New System.Drawing.Point(7, 47)
        Me.RjPanel1.Name = "RjPanel1"
        Me.RjPanel1.Size = New System.Drawing.Size(526, 258)
        Me.RjPanel1.TabIndex = 29
        '
        'DgvAdmlc
        '
        Me.DgvAdmlc.AllowUserToAddRows = False
        Me.DgvAdmlc.AllowUserToDeleteRows = False
        Me.DgvAdmlc.AllowUserToResizeRows = False
        Me.DgvAdmlc.AlternatingRowsColor = System.Drawing.Color.Empty
        Me.DgvAdmlc.AlternatingRowsColorApply = False
        Me.DgvAdmlc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvAdmlc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAdmlc.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DgvAdmlc.BorderRadius = 13
        Me.DgvAdmlc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvAdmlc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvAdmlc.ColumnHeaderColor = System.Drawing.Color.MediumPurple
        Me.DgvAdmlc.ColumnHeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgvAdmlc.ColumnHeaderHeight = 40
        Me.DgvAdmlc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.MediumPurple
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAdmlc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DgvAdmlc.ColumnHeadersHeight = 40
        Me.DgvAdmlc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvAdmlc.ColumnHeaderTextColor = System.Drawing.Color.White
        Me.DgvAdmlc.ColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAdmlc.Customizable = False
        Me.DgvAdmlc.DgvBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.DgvAdmlc.EnableHeadersVisualStyles = False
        Me.DgvAdmlc.GridColor = System.Drawing.Color.Gainsboro
        Me.DgvAdmlc.Location = New System.Drawing.Point(3, 40)
        Me.DgvAdmlc.Name = "DgvAdmlc"
        Me.DgvAdmlc.ReadOnly = True
        Me.DgvAdmlc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvAdmlc.RowHeaderColor = System.Drawing.Color.WhiteSmoke
        Me.DgvAdmlc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvAdmlc.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DgvAdmlc.RowHeadersVisible = False
        Me.DgvAdmlc.RowHeadersWidth = 25
        Me.DgvAdmlc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvAdmlc.RowHeight = 26
        Me.DgvAdmlc.RowsColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Gray
        Me.DgvAdmlc.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DgvAdmlc.RowsTextColor = System.Drawing.Color.Gray
        Me.DgvAdmlc.RowTemplate.Height = 26
        Me.DgvAdmlc.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DgvAdmlc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAdmlc.SelectionTextColor = System.Drawing.Color.Gray
        Me.DgvAdmlc.Size = New System.Drawing.Size(382, 288)
        Me.DgvAdmlc.TabIndex = 30
        '
        'RjPanel2
        '
        Me.RjPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel2.BorderRadius = 0
        Me.RjPanel2.Controls.Add(Me.RjButton1)
        Me.RjPanel2.Controls.Add(Me.TxtPesquisar)
        Me.RjPanel2.Controls.Add(Me.DgvAdmlc)
        Me.RjPanel2.Customizable = False
        Me.RjPanel2.Location = New System.Drawing.Point(539, 47)
        Me.RjPanel2.Name = "RjPanel2"
        Me.RjPanel2.Size = New System.Drawing.Size(388, 331)
        Me.RjPanel2.TabIndex = 31
        Me.RjPanel2.Visible = False
        '
        'RjButton1
        '
        Me.RjButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RjButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.BorderRadius = 0
        Me.RjButton1.BorderSize = 1
        Me.RjButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RjButton1.Design = PROJETOBASE.ButtonDesign.IconButton
        Me.RjButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RjButton1.FlatAppearance.BorderSize = 0
        Me.RjButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.RjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.RjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RjButton1.ForeColor = System.Drawing.Color.White
        Me.RjButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.RjButton1.IconColor = System.Drawing.Color.White
        Me.RjButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RjButton1.IconSize = 24
        Me.RjButton1.Location = New System.Drawing.Point(328, 3)
        Me.RjButton1.Name = "RjButton1"
        Me.RjButton1.Size = New System.Drawing.Size(57, 31)
        Me.RjButton1.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RjButton1.Style = PROJETOBASE.ControlStyle.Solid
        Me.RjButton1.TabIndex = 109
        Me.RjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RjButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RjButton1.UseVisualStyleBackColor = False
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar._Customizable = False
        Me.TxtPesquisar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPesquisar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtPesquisar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtPesquisar.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtPesquisar.BorderRadius = 0
        Me.TxtPesquisar.BorderSize = 1
        Me.TxtPesquisar.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.TxtPesquisar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtPesquisar.Location = New System.Drawing.Point(3, 3)
        Me.TxtPesquisar.MultiLine = False
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtPesquisar.PasswordChar = False
        Me.TxtPesquisar.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtPesquisar.PlaceHolderText = "Digite um termo para pesquisa"
        Me.TxtPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtPesquisar.Size = New System.Drawing.Size(330, 31)
        Me.TxtPesquisar.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtPesquisar.TabIndex = 108
        '
        'LblConsultarAdm
        '
        Me.LblConsultarAdm.AutoSize = True
        Me.LblConsultarAdm.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LblConsultarAdm.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.LblConsultarAdm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.LblConsultarAdm.LinkLabel = False
        Me.LblConsultarAdm.Location = New System.Drawing.Point(626, 16)
        Me.LblConsultarAdm.Name = "LblConsultarAdm"
        Me.LblConsultarAdm.Size = New System.Drawing.Size(250, 18)
        Me.LblConsultarAdm.Style = PROJETOBASE.LabelStyle.Subtitle
        Me.LblConsultarAdm.TabIndex = 32
        Me.LblConsultarAdm.Text = "CONSULTAR ADMINISTRAÇÃO"
        Me.LblConsultarAdm.Visible = False
        '
        'BtnLiberar
        '
        Me.BtnLiberar.AutoSize = True
        Me.BtnLiberar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnLiberar.BorderRadius = 0
        Me.BtnLiberar.BorderSize = 1
        Me.BtnLiberar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLiberar.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnLiberar.FlatAppearance.BorderSize = 0
        Me.BtnLiberar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnLiberar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnLiberar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLiberar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiberar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnLiberar.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.BtnLiberar.IconColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnLiberar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnLiberar.IconSize = 24
        Me.BtnLiberar.Location = New System.Drawing.Point(7, 404)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(132, 30)
        Me.BtnLiberar.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.BtnLiberar.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnLiberar.TabIndex = 33
        Me.BtnLiberar.Text = "Liberar Acesso"
        Me.BtnLiberar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLiberar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLiberar.UseVisualStyleBackColor = False
        '
        'BtnBloquear
        '
        Me.BtnBloquear.AutoSize = True
        Me.BtnBloquear.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnBloquear.BorderRadius = 0
        Me.BtnBloquear.BorderSize = 1
        Me.BtnBloquear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBloquear.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnBloquear.FlatAppearance.BorderSize = 0
        Me.BtnBloquear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnBloquear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBloquear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBloquear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBloquear.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.BtnBloquear.IconColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBloquear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnBloquear.IconSize = 24
        Me.BtnBloquear.Location = New System.Drawing.Point(145, 404)
        Me.BtnBloquear.Name = "BtnBloquear"
        Me.BtnBloquear.Size = New System.Drawing.Size(145, 30)
        Me.BtnBloquear.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBloquear.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnBloquear.TabIndex = 33
        Me.BtnBloquear.Text = "Bloquear Acesso"
        Me.BtnBloquear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBloquear.UseVisualStyleBackColor = False
        '
        'RjPanel3
        '
        Me.RjPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.RjPanel3.BorderRadius = 0
        Me.RjPanel3.Controls.Add(Me.TxtToken)
        Me.RjPanel3.Customizable = False
        Me.RjPanel3.Location = New System.Drawing.Point(7, 311)
        Me.RjPanel3.Name = "RjPanel3"
        Me.RjPanel3.Size = New System.Drawing.Size(526, 67)
        Me.RjPanel3.TabIndex = 34
        '
        'TxtToken
        '
        Me.TxtToken._Customizable = True
        Me.TxtToken.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.TxtToken.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TxtToken.BorderFocusColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.TxtToken.BorderRadius = 0
        Me.TxtToken.BorderSize = 0
        Me.TxtToken.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.TxtToken.ForeColor = System.Drawing.Color.Green
        Me.TxtToken.Location = New System.Drawing.Point(3, 11)
        Me.TxtToken.MultiLine = True
        Me.TxtToken.Name = "TxtToken"
        Me.TxtToken.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.TxtToken.PasswordChar = False
        Me.TxtToken.PlaceHolderColor = System.Drawing.Color.DarkGray
        Me.TxtToken.PlaceHolderText = "Gerar Token"
        Me.TxtToken.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TxtToken.Size = New System.Drawing.Size(520, 38)
        Me.TxtToken.Style = PROJETOBASE.TextBoxStyle.MatteBorder
        Me.TxtToken.TabIndex = 0
        '
        'lblNumberItems
        '
        Me.lblNumberItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumberItems.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblNumberItems.Font = New System.Drawing.Font("Verdana", 9.5!)
        Me.lblNumberItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblNumberItems.LinkLabel = False
        Me.lblNumberItems.Location = New System.Drawing.Point(753, 378)
        Me.lblNumberItems.Name = "lblNumberItems"
        Me.lblNumberItems.Size = New System.Drawing.Size(174, 23)
        Me.lblNumberItems.Style = PROJETOBASE.LabelStyle.Normal
        Me.lblNumberItems.TabIndex = 126
        Me.lblNumberItems.Text = "0"
        Me.lblNumberItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNumberItems.Visible = False
        '
        'BtnWhatsApp
        '
        Me.BtnWhatsApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnWhatsApp.BorderRadius = 0
        Me.BtnWhatsApp.BorderSize = 1
        Me.BtnWhatsApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWhatsApp.Design = PROJETOBASE.ButtonDesign.Custom
        Me.BtnWhatsApp.FlatAppearance.BorderSize = 0
        Me.BtnWhatsApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnWhatsApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.BtnWhatsApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWhatsApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnWhatsApp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnWhatsApp.IconChar = FontAwesome.Sharp.IconChar.Whatsapp
        Me.BtnWhatsApp.IconColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnWhatsApp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnWhatsApp.IconSize = 32
        Me.BtnWhatsApp.Location = New System.Drawing.Point(296, 404)
        Me.BtnWhatsApp.Name = "BtnWhatsApp"
        Me.BtnWhatsApp.Size = New System.Drawing.Size(37, 30)
        Me.BtnWhatsApp.SkinBorderColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.BtnWhatsApp.Style = PROJETOBASE.ControlStyle.Glass
        Me.BtnWhatsApp.TabIndex = 127
        Me.BtnWhatsApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnWhatsApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnWhatsApp.UseVisualStyleBackColor = False
        Me.BtnWhatsApp.Visible = False
        '
        'FormConfiguracoesSolicitacoes
        '
        Me._DesktopPanelSize = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BorderSize = 1
        Me.Caption = "Ficha Solicitacão de Acesso"
        Me.ClientSize = New System.Drawing.Size(936, 495)
        Me.Name = "FormConfiguracoesSolicitacoes"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Text = "Ficha Solicitacão de Acesso"
        Me._pnlClientArea.ResumeLayout(False)
        Me._pnlClientArea.PerformLayout()
        Me.RjPanel1.ResumeLayout(False)
        Me.RjPanel1.PerformLayout()
        CType(Me.DgvAdmlc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RjPanel2.ResumeLayout(False)
        Me.RjPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RjLabel1 As RJLabel
    Friend WithEvents TxtNome As RJTextBox
    Friend WithEvents RjLabel4 As RJLabel
    Friend WithEvents TxtEmail As RJTextBox
    Friend WithEvents RjLabel2 As RJLabel
    Friend WithEvents TxtCodigo As RJTextBox
    Friend WithEvents RjLabel3 As RJLabel
    Friend WithEvents TxtSetor As RJTextBox
    Friend WithEvents RjLabel8 As RJLabel
    Friend WithEvents TxtCidade As RJTextBox
    Friend WithEvents RjLabel7 As RJLabel
    Friend WithEvents TxtComum As RJTextBox
    Friend WithEvents RjLabel6 As RJLabel
    Friend WithEvents TxtTelefone As RJTextBox
    Friend WithEvents RjLabel5 As RJLabel
    Friend WithEvents TxtStatus As RJTextBox
    Friend WithEvents RjLabel10 As RJLabel
    Friend WithEvents TxtAdmlc As RJTextBox
    Friend WithEvents RjLabel9 As RJLabel
    Friend WithEvents RjPanel1 As RJPanel
    Friend WithEvents LblConsultarAdm As RJLabel
    Friend WithEvents RjPanel2 As RJPanel
    Friend WithEvents DgvAdmlc As RJDataGridView
    Friend WithEvents RjButton1 As RJButton
    Friend WithEvents TxtPesquisar As RJTextBox
    Friend WithEvents BtnLiberar As RJButton
    Friend WithEvents BtnBloquear As RJButton
    Friend WithEvents RjPanel3 As RJPanel
    Friend WithEvents lblNumberItems As RJLabel
    Friend WithEvents TxtToken As RJTextBox
    Friend WithEvents BtnWhatsApp As RJButton
End Class
