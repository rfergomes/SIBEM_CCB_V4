Imports System.Data.Common

Public MustInherit Class GenericDAL(Of T As {Class, New})
    Protected connectionFactory As ConnectionFactory
    Private SQL As String

    Public Sub New(connectionFactory As ConnectionFactory)
        Me.connectionFactory = connectionFactory
    End Sub

    Protected Function Inserir(tableName As String, columns As Dictionary(Of String, Object)) As Integer
        SQL = $"INSERT INTO {tableName} ({String.Join(", ", columns.Keys)}) VALUES ({String.Join(", ", columns.Keys.Select(Function(col) "@" & col))})"
        Using connection As IDbConnection = connectionFactory.GetConnection()
            connection.Open()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = SQL
                For Each kvp As KeyValuePair(Of String, Object) In columns
                    Dim parameter As IDbDataParameter = command.CreateParameter()
                    parameter.ParameterName = kvp.Key
                    parameter.Value = kvp.Value
                    command.Parameters.Add(parameter)
                Next
                command.ExecuteNonQuery()

                ' Recupera o último ID inserido com base no tipo de banco de dados
                Return GetLastInsertedId(connection)

            End Using
        End Using
    End Function

    Protected Function Atualizar(tableName As String, columns As Dictionary(Of String, Object), Optional condition As String = "") As Integer
        SQL = $"UPDATE {tableName} SET {String.Join(", ", columns.Select(Function(col) $"{col.Key} = @{col.Key}"))} WHERE 1 {condition}"
        Using connection As IDbConnection = connectionFactory.GetConnection()
            connection.Open()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = SQL
                'For Each kvp As KeyValuePair(Of String, Object) In columns
                '    command.Parameters.Add(New SqlParameter("@" & kvp.Key, kvp.Value))
                'Next
                For Each kvp As KeyValuePair(Of String, Object) In columns
                    Dim parameter As IDbDataParameter = command.CreateParameter()
                    parameter.ParameterName = kvp.Key
                    parameter.Value = kvp.Value
                    command.Parameters.Add(parameter)
                Next
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Protected Function Excluir(tableName As String, Optional condition As String = "1") As Integer
        SQL = $"DELETE FROM {tableName} WHERE {condition} "
        Using connection As IDbConnection = connectionFactory.GetConnection()
            connection.Open()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = SQL
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Protected Function BuscarDataTable(tableName As String, columns As Dictionary(Of String, Object), Optional condition As String = "") As DataTable
        Dim Colunas As String = IIf(columns.Count > 0, String.Join(", ", columns.Select(Function(col) $"{col.Key}")), "*")
        SQL = $"SELECT {Colunas} FROM {tableName} WHERE 1 {condition}"

        Dim dataTable As New DataTable()

        Using connection As IDbConnection = connectionFactory.GetConnection()
            connection.Open()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = SQL
                Using reader As IDataReader = command.ExecuteReader()
                    dataTable.Load(reader)
                End Using
            End Using
        End Using

        Return dataTable
    End Function

    Protected Function BuscarLista(tableName As String, columns As Dictionary(Of String, Object), condition As String) As List(Of T)
        Dim Colunas As String = IIf(columns.Count > 0, String.Join(", ", columns.Select(Function(col) $"{col.Key}")), "*")

        SQL = $"SELECT {Colunas} FROM {tableName} WHERE 1=1 {condition}"
        Dim results As New List(Of T)()

        Using connection As IDbConnection = connectionFactory.GetConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = SQL

                connection.Open()
                Using reader As IDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim obj As Object = ConvertFromReader(reader)
                        results.Add(obj)
                    End While
                End Using
            End Using
        End Using

        Return results
    End Function

    Protected Function BuscarContagem(tableName As String, Optional condition As String = "") As Integer
        SQL = $"SELECT COUNT(*) FROM {tableName} WHERE 1=1 {condition}"
        Dim result As Integer = 0
        Using connection As IDbConnection = connectionFactory.GetConnection()
            connection.Open()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = SQL
                result = CInt(command.ExecuteScalar())
            End Using
        End Using
        Return result
    End Function

    Protected Function BuscarMaximo(tableName As String, columnName As String, Optional condition As String = "") As Object
        SQL = $"SELECT MAX({columnName}) FROM {tableName} WHERE 1=1 {condition}"
        Dim result As Object = Nothing
        Using connection As IDbConnection = connectionFactory.GetConnection()
            connection.Open()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = SQL
                result = command.ExecuteScalar()
            End Using
        End Using
        Return result
    End Function

    Protected Function BuscarMinimo(tableName As String, columnName As String, Optional condition As String = "") As Object
        SQL = $"SELECT MIN({columnName}) FROM {tableName} WHERE 1=1 {condition}"
        Dim result As Object = Nothing
        Using connection As IDbConnection = connectionFactory.GetConnection()
            connection.Open()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = SQL
                result = command.ExecuteScalar()
            End Using
        End Using
        Return result
    End Function

    Protected Function BuscarListaStrings(tableName As String, columns As Dictionary(Of String, Object), condition As String) As List(Of List(Of String))
        ' Seleção das colunas especificadas no dicionário
        Dim Colunas As String = If(columns.Count > 0, String.Join(", ", columns.Keys), "*")

        ' Construção segura do SQL com placeholders
        Dim SQL As String = $"SELECT {Colunas} FROM {tableName} WHERE 1=1"
        If Not String.IsNullOrWhiteSpace(condition) Then
            SQL += $" AND {condition}"
        End If

        ' Lista para armazenar os resultados (cada linha é uma lista de strings)
        Dim results As New List(Of List(Of String))()

        ' Uso de conexão e comandos de forma segura
        Using connection As IDbConnection = connectionFactory.GetConnection()
            Using command As IDbCommand = connection.CreateCommand()
                command.CommandText = SQL

                connection.Open()
                ' Leitura dos dados
                Using reader As IDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Lista temporária para armazenar os valores de cada coluna na linha atual
                        Dim row As New List(Of String)()
                        For i As Integer = 0 To reader.FieldCount - 1
                            row.Add(reader(i).ToString())
                        Next
                        ' Adiciona a linha completa à lista de resultados
                        results.Add(row)
                    End While
                End Using
            End Using
        End Using

        Return results
    End Function

    ' Função para recuperar o último ID inserido dependendo do banco de dados
    Private Function GetLastInsertedId(connection As IDbConnection) As Long
        Dim lastIdSQL As String = ""

        Select Case connectionFactory.GetDatabaseTypeFromConnectionString()
            Case DatabaseType.MySQL, DatabaseType.MySQL_SYS
                lastIdSQL = "SELECT LAST_INSERT_ID();"
            Case DatabaseType.SQLServer
                lastIdSQL = "SELECT SCOPE_IDENTITY();"
            Case DatabaseType.Access
                lastIdSQL = "SELECT @@IDENTITY;"
            Case DatabaseType.Oracle
                lastIdSQL = "SELECT my_sequence.CURRVAL FROM dual;" ' Use sua sequência no Oracle
            Case DatabaseType.PostgreSQL
                lastIdSQL = "SELECT LASTVAL();"
            Case DatabaseType.Firebird
                lastIdSQL = "SELECT GEN_ID(my_generator, 0) FROM RDB$DATABASE;" ' Use seu gerador de sequência no Firebird
            Case DatabaseType.SQLite
                lastIdSQL = "SELECT last_insert_rowid();"
            Case Else
                'Throw New NotSupportedException("Banco de dados não suportado para recuperar o último ID.")
        End Select

        Try
            Using lastIdCommand As IDbCommand = connection.CreateCommand()
                lastIdCommand.CommandText = lastIdSQL
                Return lastIdCommand.ExecuteScalar()
            End Using
        Catch ex As Exception
            Return 0
            Throw New Exception("Falha: " + ex.Message)
        End Try

    End Function

    Public MustOverride Function GetByPart(part As String) As T
    Public MustOverride Function GetAllDt(Optional condicao As String = "") As DataTable
    Public MustOverride Function GetAllList(Optional condicao As String = "") As List(Of T)
    Public MustOverride Function GetById(id As String) As T
    Public MustOverride Function GetByIdDt(id As Integer) As DataTable
    Public MustOverride Function GetByIdList(id As String) As List(Of T)
    Public MustOverride Function Insert(item As T) As Integer
    Public MustOverride Function Update(item As T) As Integer
    Public MustOverride Function Delete(id As String) As Integer
    Protected MustOverride Function ConvertFromReader(reader As DbDataReader) As T
End Class

