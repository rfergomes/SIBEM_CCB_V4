Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports FirebirdSql.Data.FirebirdClient
Imports MySql.Data.MySqlClient
Imports Npgsql
Imports Oracle.ManagedDataAccess.Client

Public Enum DatabaseType
    Access
    Excel
    Firebird
    MySQL
    MySQL_SYS
    Oracle
    PostgreSQL
    SQLite
    SQLServer
    Unknow
End Enum

Public Class ConnectionFactory
    Private ReadOnly connectionString As String

    Public Sub New()
        connectionString = GetConnectionString(DatabaseType.SQLite)
    End Sub

    Public Sub New(BancoTipo As DatabaseType)
        connectionString = GetConnectionString(BancoTipo)
    End Sub

    Public Function GetConnection() As IDbConnection
        Dim connection As IDbConnection = Nothing
        Dim connectionStringBuilder As New OleDbConnectionStringBuilder(connectionString)
        connectionStringBuilder.Remove("DBServer")
        Select Case GetDatabaseTypeFromConnectionString()
            Case DatabaseType.Access
                connection = New OleDbConnection(connectionStringBuilder.ConnectionString)
            Case DatabaseType.Excel
                connection = New OleDbConnection(connectionStringBuilder.ConnectionString)
            Case DatabaseType.Firebird
                connection = New FbConnection(connectionStringBuilder.ConnectionString)
            Case DatabaseType.MySQL
                connection = New MySqlConnection(connectionStringBuilder.ConnectionString)
            Case DatabaseType.MySQL_SYS
                connection = New MySqlConnection(connectionStringBuilder.ConnectionString)
            Case DatabaseType.Oracle
                connection = New OracleConnection(connectionStringBuilder.ConnectionString)
            Case DatabaseType.PostgreSQL
                connection = New NpgsqlConnection(connectionStringBuilder.ConnectionString)
            Case DatabaseType.SQLite
                connection = New SQLiteConnection(connectionStringBuilder.ConnectionString)
            Case DatabaseType.SQLServer
                connection = New SqlConnection(connectionStringBuilder.ConnectionString)
        End Select
        Return connection
    End Function

    Private Function GetConnectionString(databaseType As DatabaseType) As String
        Dim connectionStringName As String = ""
        Select Case databaseType
            Case DatabaseType.Access
                connectionStringName = "Access"
            Case DatabaseType.Excel
                connectionStringName = "Excel"
            Case DatabaseType.Firebird
                connectionStringName = "Firebird"
            Case DatabaseType.MySQL
                connectionStringName = "MySQL"
            Case DatabaseType.MySQL_SYS
                connectionStringName = "MySQL_SYS"
            Case DatabaseType.Oracle
                connectionStringName = "Oracle"
            Case DatabaseType.PostgreSQL
                connectionStringName = "PostgreSQL"
            Case DatabaseType.SQLite
                connectionStringName = "SQLite"
            Case DatabaseType.SQLServer
                connectionStringName = "SQLServer"
            Case Else
                Throw New ArgumentOutOfRangeException(NameOf(databaseType), "Banco de Dados Inválido")
        End Select
        Return ConfigurationManager.ConnectionStrings(connectionStringName).ConnectionString
    End Function

    Public Function GetDatabaseTypeFromConnectionString() As DatabaseType
        Dim connectionStringBuilder As New OleDbConnectionStringBuilder(connectionString)
        If connectionStringBuilder.ContainsKey("DBServer") Then
            Select Case connectionStringBuilder("DBServer").ToString()
                Case "Access"
                    Return DatabaseType.Access
                Case "Excel"
                    Return DatabaseType.Excel
                Case "Firebird"
                    Return DatabaseType.Firebird
                Case "MySQL"
                    Return DatabaseType.MySQL
                Case "MySQL_SYS"
                    Return DatabaseType.MySQL_SYS
                Case "Oracle"
                    Return DatabaseType.Oracle
                Case "PostgreSQL"
                    Return DatabaseType.PostgreSQL
                Case "SQLite"
                    Return DatabaseType.SQLite
                Case "SQLServer"
                    Return DatabaseType.SQLServer
            End Select
        End If
        Return Nothing
    End Function


End Class

