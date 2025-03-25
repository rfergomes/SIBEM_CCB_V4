Public Class FormAdministracao

    Private SistemaBLL As SistemaBLL
    Private Sistema As List(Of SistemaDTO)
    Private ServidoresBLL As New ServidoresBLL
    Private SQLite As New ConnectionFactory()
    Private MySQL As New ConnectionFactory(DatabaseType.MySQL)
    Private Log As New Logger

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        SistemaBLL = New SistemaBLL(SQLite)
        ServidoresBLL = New ServidoresBLL(SQLite)
        LoadComboAdm()
    End Sub

    Private Sub FormAdministracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        CloseWindow()
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Try
            Sistema = SistemaBLL.BuscarTodos()
            Dim AdmAtiva As SistemaDTO = Sistema.FirstOrDefault(Function(s) s.Id_Admlc = CboAdm.SelectedValue)
            AdmAtiva.Ativo = -1
            SistemaBLL.Atualizar(AdmAtiva)
            VarGlob.SistemaAtivo = AdmAtiva


            ' Atualiza Dados do servidor remoto
            Dim Servidores As List(Of ServidoresDTO) = ServidoresBLL.BuscarTodos()
            Dim Servidor As ServidoresDTO = Servidores.FirstOrDefault(Function(s) s.Id_Admlc = AdmAtiva.Id_Admlc)

            If Servidores IsNot Nothing OrElse Servidores.Count > 0 Then
                ' Atualizando App.config
                Dim Banco As String = "MySQL"
                Dim StringConexao As String = $"Server={Servidor.Servidor};Port={Servidor.Porta};Database={Servidor.Banco};Uid={Servidor.Usuario};Pwd={Servidor.Senha};DBServer={Banco};"
                AtualizaAppConfig(Banco, StringConexao)
            End If

            'Mostrar mensagem de reinicialização
            RJMessageBox.Show("O Sistema será reiniciado para que as alterações sejam carregadas", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Application.Restart()
            Environment.Exit(0)
        Catch ex As Exception
            RJMessageBox.Show($"Não foi possível trocar administração.{vbNewLine & ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log.WriteLog($"Inventário | Botão Salvar | {ex.Message}")
        End Try
    End Sub

    Private Sub LoadComboAdm()
        Sistema = SistemaBLL.BuscarTodos()
        Dim AdmAtiva = Sistema.FirstOrDefault(Function(s) s.Id_Admlc = VarGlob.SistemaAtivo.Id_Admlc)
        With CboAdm
            .DataSource = Nothing
            .Items.Clear()
            .DataSource = Sistema
            .DisplayMember = "adm_local"
            .ValueMember = "id_admlc"
            If AdmAtiva IsNot Nothing Then
                ' Seleciona o item baseado no valor
                .Text = AdmAtiva.Adm_Local
                .SelectedValue = AdmAtiva.Id_Admlc
            Else
                .Text = ""
            End If
        End With
    End Sub
End Class