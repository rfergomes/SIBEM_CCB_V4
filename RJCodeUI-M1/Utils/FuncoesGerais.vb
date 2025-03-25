'Última Atualização:    19/11/2024
'Data:                  18/10/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Imports Vip.Notification
Imports System.Text.RegularExpressions
Imports System.Configuration

Friend Module FuncoesGerais
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)

    Enum TipoArquivo
        CSV
        Word
        Excel
        PDF
        Imagens
        Texto
        Todos
    End Enum

    Public Function GetArquivo(Optional Tipo As TipoArquivo = TipoArquivo.Todos) As String
        Dim Filtro As String = TipoArquivoParaFiltro(Tipo)

        Using Ofd As New OpenFileDialog() With {
            .Filter = Filtro,
            .Title = "Selecionar Arquivo " & Tipo.ToString(),
            .Multiselect = False
        }
            If Ofd.ShowDialog() = DialogResult.OK Then
                Return Ofd.FileName
            End If
        End Using

        Return String.Empty
    End Function

    ' Função auxiliar para melhorar a legibilidade e evitar o uso repetido do Select Case
    Private Function TipoArquivoParaFiltro(Tipo As TipoArquivo) As String
        Select Case Tipo
            Case TipoArquivo.CSV
                Return "Arquivo CSV|*.csv"
            Case TipoArquivo.Word
                Return "Arquivo Word|*.doc;*.docx"
            Case TipoArquivo.Excel
                Return "Arquivo Excel|*.xls;*.xlsx;*.xlsm"
            Case TipoArquivo.PDF
                Return "Arquivo PDF|*.pdf"
            Case TipoArquivo.Imagens
                Return "Arquivo Imagens|*.png;*.jpg"
            Case TipoArquivo.Texto
                Return "Arquivo Texto|*.txt"
            Case Else
                Return "Todos|*.*"
        End Select
    End Function

    ' A propriedade pode ser mantida inalterada
    Public ReadOnly Property DataAgora As DateTime
        Get
            Return Date.Now.ToLocalTime()
        End Get
    End Property

    Public Function SanitizeString(inputString As String, Optional Maiuscula As Boolean = True) As String
        ' Lista de caracteres e palavras a serem removidos ou substituídos
        Dim charactersToRemove As String = "'=*%<>|\"
        Dim wordsToRemove As String() = {"where", "delete", "update", "select", "insert", "drop", "truncate", "union", "join"}

        ' Remover caracteres especiais
        Dim regex As New Regex("[" & Regex.Escape(charactersToRemove) & "]")
        inputString = regex.Replace(inputString, "")

        ' Remover palavras-chave
        For Each word In wordsToRemove
            inputString = inputString.Replace(word, "").Replace(word.ToUpper, "")
        Next

        ' Substituir espaços em branco por um único espaço
        inputString = Regex.Replace(inputString, "\s+", " ")

        ' Remover espaços no início e no final da string
        inputString = inputString.Trim()

        If Maiuscula Then inputString.ToUpper()

        Return inputString
    End Function

    Public Function ValidarControle(controle As Object, ErrorProvider As ErrorProvider) As Boolean
        Dim validacao As Boolean = False
        Select Case (TypeName(controle))
            Case "TextBox", "RJTextBox", "ComboBox", "RJComboBox"
                If String.IsNullOrEmpty(controle.text) OrElse controle.text = "NÃO DEFINIDO" AndAlso controle.tag <> "" Then
                    Alert.ShowWarning("O campo " & controle.Tag.ToString() & " é obrigatório.", 5000)
                    With ErrorProvider
                        .SetIconAlignment(controle, ErrorIconAlignment.BottomRight)
                        .SetIconPadding(controle, -17)
                        .SetError(controle, "O campo " & controle.Tag.ToString() & " é obrigatório.")
                    End With
                    controle.Focus()
                    validacao = False
                Else
                    ErrorProvider.SetError(controle, String.Empty)
                    validacao = True
                End If


            Case "DataGridView", "RJDataGridView", "RJLabel"

                If Not controle.SelectedRows.count > 0 AndAlso controle.tag <> "" Then
                    Alert.ShowWarning("O campo " & controle.Tag.ToString() & " é obrigatório.", 5000)
                    With ErrorProvider
                        .SetIconAlignment(controle, ErrorIconAlignment.BottomRight)
                        .SetIconPadding(controle, -17)
                        .SetError(controle, "O campo " & controle.Tag.ToString() & " é obrigatório.")
                    End With
                    controle.Focus()
                    validacao = False
                Else
                    ErrorProvider.SetError(controle, String.Empty)
                    validacao = True
                End If

        End Select

        Return validacao
    End Function

    Public Function IsValidEmail(controle As Object, ErrorProvider As Object) As Boolean
        Dim Validacao As Boolean
        ' Expressão regular para validar o formato de um e-mail
        Dim regex As New Regex("^[\w!#$%&'*+\-/=?^_`{|}~]+(\.[\w!#$%&'*+\-/=?^_`{|}~]+)*" +
                               "@((([\w-]+\.)+[a-zA-Z]{2,7})|(([a-zA-Z]{2,7})))$")

        If Not regex.IsMatch(controle.text) Then
            Alert.ShowWarning("O E-mail informado não parece ser um endereço de E-mail válido.", 5000)
            With ErrorProvider
                .SetIconAlignment(controle, ErrorIconAlignment.BottomRight)
                .SetIconPadding(controle, -17)
                .SetError(controle, "O E-mail informado não parece ser um endereço de E-mail válido.")
            End With
            controle.Focus()
            Validacao = False
        Else
            ErrorProvider.SetError(controle, String.Empty)
            Validacao = True
        End If
        Return Validacao
    End Function

    Public Sub AtualizaAppConfig(nome As String, connectionString As String)
        ' Abre o arquivo app.config da aplicação
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

        ' Recupera a seção connectionStrings
        Dim connectionStringsSection As ConnectionStringsSection = config.ConnectionStrings

        ' Adiciona ou atualiza a string de conexão
        If connectionStringsSection.ConnectionStrings(nome) IsNot Nothing Then
            ' Atualiza se já existir
            connectionStringsSection.ConnectionStrings(nome).ConnectionString = connectionString
        Else
            ' Adiciona uma nova string de conexão
            connectionStringsSection.ConnectionStrings.Add(New ConnectionStringSettings(nome, connectionString))
        End If

        ' Salva as alterações no arquivo app.config
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")
    End Sub

    Public Function ObterPrimeiroNomeEInicial(ByVal nome As String) As String
        ' Lista de palavras a serem ignoradas
        Dim palavrasIgnorar As String() = {"da", "de", "do", "das", "dos"}

        ' Divide o nome completo em partes
        Dim partes As String() = nome.Split(" "c)

        ' Filtra as partes, ignorando as palavras especificadas
        Dim nomesFiltrados As List(Of String) = partes.Where(Function(p) Not palavrasIgnorar.Contains(p.ToLower())).ToList()

        ' Verifica se há nomes suficientes
        If nomesFiltrados.Count < 2 Then
            Return nome ' Retorna o nome completo caso não haja nomes suficientes
        End If

        ' Obtém o primeiro nome
        Dim primeiroNome As String = nomesFiltrados(0)

        ' Obtém a inicial do segundo nome válido (após filtrar as palavras ignoradas)
        Dim inicialSegundoNome As String = nomesFiltrados(1).Substring(0, 1).ToUpper() & "."

        ' Retorna o nome formatado
        Return $"{primeiroNome} {inicialSegundoNome}"
    End Function

    Public Function ConvertToDataTable(Of T)(ByVal data As List(Of T)) As DataTable
        Dim dt As New DataTable()

        ' Se a lista estiver vazia, retorna um DataTable vazio
        If data Is Nothing OrElse data.Count = 0 Then Return dt

        ' Criar colunas baseado nas propriedades do objeto
        Dim props = GetType(T).GetProperties()
        For Each prop In props
            dt.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
        Next

        ' Preencher as linhas com os valores dos objetos
        For Each item In data
            Dim row = dt.NewRow()
            For Each prop In props
                row(prop.Name) = If(prop.GetValue(item, Nothing), DBNull.Value)
            Next
            dt.Rows.Add(row)
        Next

        Return dt
    End Function


End Module
