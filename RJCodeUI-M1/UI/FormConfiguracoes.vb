'Última Atualização:    18/11/2024
'Data:                  18/11/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FormConfiguracoes

    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private MySQL_SYS As New ConnectionFactory(DatabaseType.MySQL_SYS)
    Private rowIndex As Integer = 0
    Private Id_Solicitacao As String
    Private Log As New Logger

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        LoadDataGridViewServidores()
        If VarGlob.UsuarioLogado IsNot Nothing Then
            Pnl_Tokens.Visible = True
            LoadTokens()
        End If
    End Sub

    Private Sub FormConfiguracoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim servidorBLL As New ServidoresBLL(SQLite)
        Dim Servidores As List(Of ServidoresDTO) = servidorBLL.BuscarTodos()

        If Servidores IsNot Nothing Then
            Dim servidor As ServidoresDTO = Servidores.FirstOrDefault(Function(s) s.Ativo = -1)
            If servidor IsNot Nothing Then
                TxtServidor.Text = servidor.Servidor
                TxtBanco.Text = servidor.Banco
                TxtPorta.Text = servidor.Porta
                TxtUsuario.Text = servidor.Usuario
                TxtSenha.Text = servidor.Senha
                ChkAtivo.Checked = servidor.Ativo
            End If
        End If

    End Sub

    Private Sub BtnTeste_Click(sender As Object, e As EventArgs) Handles BtnTeste.Click
        If Not ValidarControle(TxtServidor, ErrorProvider1) Then Return
        If Not ValidarControle(TxtBanco, ErrorProvider1) Then Return
        If Not ValidarControle(TxtUsuario, ErrorProvider1) Then Return
        Dim connectionString As String = $"server={TxtServidor.Text};port={TxtPorta.Text};database={TxtBanco.Text};User ID={TxtUsuario.Text};Password={TxtSenha.Text};"
        Try
            If TestarConexaoMySQL(connectionString) Then
                BtnSalvar.Enabled = True
                RJMessageBox.Show("Conexão OK", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                BtnSalvar.Enabled = False
                RJMessageBox.Show("Falha na Conexão", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            RJMessageBox.Show("Falha ao conectar: " + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim servidorBLL As New ServidoresBLL(SQLite)
        Dim Servidores As List(Of ServidoresDTO) = servidorBLL.BuscarTodos()
        Dim Servidor As ServidoresDTO
        Dim StringConexao As String

        If Not ValidarControle(TxtServidor, ErrorProvider1) Then Return
        If Not ValidarControle(TxtBanco, ErrorProvider1) Then Return
        If Not ValidarControle(TxtUsuario, ErrorProvider1) Then Return

        Try
            Dim ServidorExiste As ServidoresDTO = Servidores.FirstOrDefault(Function(s) s.Servidor = TxtServidor.Text.Trim)
            Dim Mensagem As String = ""

            If ServidorExiste IsNot Nothing Then
                Servidor = New ServidoresDTO With {
                    .Id = ServidorExiste.Id,
                    .Id_Admlc = ServidorExiste.Id_Admlc,
                    .Servidor = SanitizeString(TxtServidor.Text, Maiuscula:=False),
                    .Porta = SanitizeString(TxtPorta.Text, Maiuscula:=False),
                    .Banco = SanitizeString(TxtBanco.Text, Maiuscula:=False),
                    .Usuario = SanitizeString(TxtUsuario.Text, Maiuscula:=False),
                    .Senha = SanitizeString(TxtSenha.Text, Maiuscula:=False),
                    .Ativo = -1
                }
                servidorBLL.Atualizar(Servidor)
                Mensagem = "Credenciais Atualizadas com sucesso"
            Else
                Servidor = New ServidoresDTO With {
                    .Id_Admlc = VarGlob.SistemaAtivo.Id_Admlc,
                    .Servidor = SanitizeString(TxtServidor.Text, Maiuscula:=False),
                    .Porta = SanitizeString(TxtPorta.Text, Maiuscula:=False),
                    .Banco = SanitizeString(TxtBanco.Text, Maiuscula:=False),
                    .Usuario = SanitizeString(TxtUsuario.Text, Maiuscula:=False),
                    .Senha = SanitizeString(TxtSenha.Text, Maiuscula:=False),
                    .Ativo = -1
                }
                servidorBLL.Inserir(Servidor)
                Mensagem = "Credenciais inseridas com sucesso!"
            End If

            ' Salvar no arquivo app.config
            If Servidor IsNot Nothing Then
                Dim Banco As String = "MySQL"
                StringConexao = $"Server={TxtServidor.Text};Port={TxtPorta.Text};Database={TxtBanco.Text};Uid={TxtUsuario.Text};Pwd={TxtSenha.Text};DBServer={Banco};"
                AtualizaAppConfig(Banco, StringConexao)
            End If

            RJMessageBox.Show(Mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadDataGridViewServidores()
            BloquearControles(False)
            LimparCampos()
        Catch ex As Exception
            RJMessageBox.Show($"Falha ao salvar dados de credencial{vbNewLine}{ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log.WriteLog($"CONFIGURAÇÕES | Botão Salvar | {ex.Message}")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimparCampos()
        BloquearControles(False)
    End Sub

    Private Sub DgvServidores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvServidores.CellClick
        If e.RowIndex >= 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvServidores.Rows(e.RowIndex)

            ' Popula os TextBoxs com os valores das células da linha selecionada
            TxtServidor.Text = row.Cells("Servidor").Value
            TxtBanco.Text = row.Cells("Banco").Value
            TxtPorta.Text = row.Cells("Porta").Value
            TxtUsuario.Text = row.Cells("Usuario").Value
            TxtSenha.Text = row.Cells("Senha").Value
            ChkAtivo.Checked = row.Cells("Ativo").Value
            ' Habilita Controles
            BloquearControles(False)
            BtnTeste.Enabled = True
            BtnCancelar.Enabled = True
        End If
    End Sub

    Private Sub DgvServidores_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvServidores.CellMouseUp
        If e.Button = MouseButtons.Right Then
            Try
                ' Verifica se a linha e a célula são válidas antes de selecionar
                If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                    DgvServidores.ClearSelection()
                    DgvServidores.Rows(e.RowIndex).Selected = True
                    rowIndex = e.RowIndex
                    Dim row As DataGridViewRow = DgvServidores.Rows(e.RowIndex)
                    ' Popula os TextBoxs com os valores das células da linha selecionada
                    TxtServidor.Text = row.Cells("Servidor").Value
                    TxtBanco.Text = row.Cells("Banco").Value
                    TxtPorta.Text = row.Cells("Porta").Value
                    TxtUsuario.Text = row.Cells("Usuario").Value
                    TxtSenha.Text = row.Cells("Senha").Value
                    ChkAtivo.Checked = row.Cells("Ativo").Value

                    ' Verifica se a célula é visível antes de defini-la como a célula atual
                    If DgvServidores.Rows(e.RowIndex).Cells(1).Visible Then
                        DgvServidores.CurrentCell = DgvServidores.Rows(e.RowIndex).Cells(6)
                        ' Exibe o menu de contexto no local do cursor
                        DgvServidores.Show()
                    End If
                    BloquearControles(False)
                End If
            Catch ex As Exception
                RJMessageBox.Show($"Sem opção de Menu para esta consulta. {vbNewLine & ex.Message}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Private Sub DgvServidores_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvServidores.CellFormatting
        If e.RowIndex >= 0 Then ' Verifica se é a coluna correta e a linha válida
            Dim linha = DgvServidores.Rows(e.RowIndex).Cells("Ativo").Value ' Converte o valor para string, pois pode ser null
            If linha > -1 Then
                DgvServidores.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            Else
                ' Limpa a cor de fundo se não for "4B"
                DgvServidores.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Empty
            End If
        End If
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        LimparCampos()
        BloquearControles()
        BtnSalvar.Enabled = False
        TxtServidor.Focus()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        BloquearControles()
        BtnSalvar.Enabled = False
        TxtServidor.Focus()
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        ExcluirRegistro()
    End Sub

    Private Function TestarConexaoMySQL(connectionString As String) As Boolean
        Try
            ' Cria uma nova conexão usando a string de conexão fornecida
            Using connection As New MySqlConnection(connectionString)
                ' Abre a conexão
                connection.Open()

                ' Se a conexão for aberta com sucesso, retorna True
                If connection.State = ConnectionState.Open Then
                    connection.Close() ' Fecha a conexão após o teste
                    Return True
                End If
            End Using
        Catch ex As MySqlException
            ' Exibe a mensagem de erro para fins de depuração (opcional)
            Throw New Exception($"Erro ao conectar: {ex.Message}")
        Catch ex As Exception
            ' Captura outros tipos de exceções
            Throw New Exception($"Erro inesperado: {ex.Message}")
        End Try

        ' Retorna False se a conexão falhar
        Return False
    End Function

    Private Sub LoadDataGridViewServidores()
        Dim servidorBLL As New ServidoresBLL(SQLite)
        Dim Servidores As List(Of ServidoresDTO) = servidorBLL.BuscarTodos()

        If Servidores IsNot Nothing Then
            With DgvServidores
                .DataSource = Nothing
                .DataSource = Servidores
                .Columns("Id").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns("Banco").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .Columns("Id_Admlc").Visible = False
                .Columns("Usuario").Visible = False
                .Columns("Porta").Visible = False
                .Columns("Senha").Visible = False
                .Columns("Ativo").Visible = False
            End With
        End If
    End Sub

    Private Sub LimparCampos()
        TxtServidor.Clear()
        TxtPorta.Clear()
        TxtBanco.Clear()
        TxtUsuario.Clear()
        TxtSenha.Clear()
        ChkAtivo.Checked = False
    End Sub

    Private Sub BloquearControles(Optional Bloquear As Boolean = True)
        TxtServidor.Enabled = Bloquear
        TxtPorta.Enabled = Bloquear
        TxtBanco.Enabled = Bloquear
        TxtUsuario.Enabled = Bloquear
        TxtSenha.Enabled = Bloquear
        BtnTeste.Enabled = Bloquear
        BtnSalvar.Enabled = Bloquear
        BtnCancelar.Enabled = Bloquear
        ChkAtivo.Enabled = Bloquear
    End Sub

    Private Sub ExcluirRegistro()
        Dim ServidoresBLL As New ServidoresBLL(SQLite)
        ' Verifica se há alguma linha selecionada
        If DgvServidores.SelectedRows.Count > 0 Then
            ' Obtém a linha selecionada
            Dim row As DataGridViewRow = DgvServidores.SelectedRows(0)

            ' Obtém o ID da linha selecionada (substitua "Id" pelo nome da sua coluna de ID)
            Dim IdServidor As Integer = Convert.ToInt32(row.Cells("Id").Value)

            ' Solicita confirmação do usuário antes de excluir
            Dim confirm = RJMessageBox.Show("Tem certeza que deseja excluir o registro?", "Confirmação de exclusão",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm = System.Windows.Forms.DialogResult.Yes Then
                Try
                    ' Chama o método de exclusão da camada de dados (DAL)
                    ServidoresBLL.Excluir(IdServidor)

                    ' Atualiza o DataGridView para refletir a exclusão
                    LoadDataGridViewServidores()

                    ' Mensagem de sucesso
                    RJMessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    ' Exibe erro caso a exclusão falhe
                    RJMessageBox.Show("Erro ao excluir registro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        Else
            ' Se nenhuma linha estiver selecionada
            RJMessageBox.Show("Selecione uma linha para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

#Region "Gerenciar Tokens"

    Private Sub ChkListarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ChkListarTodos.CheckedChanged
        LoadTokens()
    End Sub

    Private Sub TxtPesquisar_OnTextChange(sender As Object, e As EventArgs) Handles TxtPesquisar.OnTextChange
        LoadTokens()
    End Sub

    Private Sub LoadTokens()
        Dim TokenSolicitacaoOnBLL As New TokenSolicitacaoOnBLL(MySQL_SYS)
        Dim Dados As List(Of TokenSolicitacaoOnDTO) = TokenSolicitacaoOnBLL.BuscarTodos(TxtPesquisar.Text)

        Dim Tokens As List(Of TokenSolicitacaoOnDTO) = If(ChkListarTodos.Checked = False,
        Dados.Where(Function(x) x.Status = 0).ToList(),
        Dados)

        With DgvTokens
            .DataSource = Nothing
            .Columns.Clear()
            .AutoGenerateColumns = True
            .DataSource = Tokens
            ConfigurarColunasDataGridView()
            .AllowUserToOrderColumns = True
            .ClearSelection()
        End With
        lblNumberItems.Text = DgvTokens.Rows.Count
    End Sub

    Private Sub ConfigurarColunasDataGridView()
        ' Configuração das colunas do DataGridView
        With DgvTokens
            .Columns("id").Visible = False
            .Columns("email").Visible = False
            .Columns("telefone").Visible = False
            .Columns("setor").Visible = False
            .Columns("admlc").Visible = False
            .Columns("nome").HeaderText = "Solicitante"
            .Columns("Igreja").HeaderText = "Comum Congregação"
            .Columns("AdmLc").HeaderText = "Administração"
            .Columns("nome").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("status").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End With
    End Sub

    Private Sub DgvTokens_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvTokens.CellFormatting
        If e.RowIndex >= 0 Then ' Verifica se é a coluna correta e a linha válida
            Dim linha = DgvTokens.Rows(e.RowIndex).Cells("Status").Value ' Converte o valor para string, pois pode ser null
            If linha = 1 Then
                DgvTokens.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
            Else
                ' Limpa a cor de fundo se não for "4B"
                DgvTokens.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.DarkBlue
            End If
        End If
    End Sub

    Private Sub DgvTokens_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTokens.CellClick
        If DgvTokens.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DgvTokens.SelectedRows(0)
            Id_Solicitacao = row.Cells("Id").Value.ToString()
            BtnConsultar.Enabled = True
        Else
            BtnConsultar.Enabled = False
            Id_Solicitacao = String.Empty
        End If
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim Form As Form = New FormConfiguracoesSolicitacoes(Id_Solicitacao)
        Form.ShowDialog()
    End Sub

#End Region



End Class