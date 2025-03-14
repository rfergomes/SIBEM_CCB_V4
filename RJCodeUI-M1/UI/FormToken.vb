'Última Atualização:    13/11/2024
'Data:                  08/11/2024
'Autor:                 Rodrigo Fernando Gomes Lima

Imports MySql.Data.MySqlClient

Public Class FormToken
    Private AdmLocalBLL As AdmlcBLL
    Private AdmLocalOnBLL As AdmlcBLL
    Private AdmRegionalBLL As AdmrgBLL
    Private AdmRegionalOnBLL As AdmrgBLL
    Private SistemaBLL As SistemaBLL
    Private SistemaNuvemBLL As TokenOnBLL
    Private IgrejasBll As IgrejasBLL
    Private IgrejasOnBLL As IgrejasOnBLL
    Private ServidoresBLL As ServidoresBLL
    Private ServidoresOnBLL As ServidoresOnBLL
    Private SetoresBLL As SetoresBLL
    Private SetoresOnBLL As SetoresBLL
    Private SolicitacaoOnBLL As TokenSolicitacaoOnBLL
    Private Sistema As List(Of SistemaDTO)
    Private SistemaNuvem As List(Of TokenOnDTO)
    Private Igrejas As List(Of IgrejasDTO)
    Private IgrejasOn As List(Of IgrejasOnDTO)
    Private SQLite As New ConnectionFactory()
    Private MySQL_SYS As New ConnectionFactory(DatabaseType.MySQL_SYS)
    Private Token As Boolean

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        AdmLocalBLL = New AdmlcBLL(SQLite)
        AdmLocalOnBLL = New AdmlcBLL(MySQL_SYS)
        AdmRegionalBLL = New AdmrgBLL(SQLite)
        AdmRegionalOnBLL = New AdmrgBLL(MySQL_SYS)
        SistemaBLL = New SistemaBLL(SQLite)
        SistemaNuvemBLL = New TokenOnBLL(MySQL_SYS)
        IgrejasBll = New IgrejasBLL(SQLite)
        IgrejasOnBLL = New IgrejasOnBLL(MySQL_SYS)
        SetoresBLL = New SetoresBLL(SQLite)
        SetoresOnBLL = New SetoresBLL(MySQL_SYS)
        ServidoresBLL = New ServidoresBLL(SQLite)
        ServidoresOnBLL = New ServidoresOnBLL(MySQL_SYS)
        SolicitacaoOnBLL = New TokenSolicitacaoOnBLL(MySQL_SYS)
    End Sub

    Private Sub FormToken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With TabControl1
            .Appearance = TabAppearance.FlatButtons
            .ItemSize = New Size(0, 1)
            .SizeMode = TabSizeMode.Fixed
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub TxtToken_OnTextChange(sender As Object, e As EventArgs) Handles TxtToken.OnTextChange
        If TxtToken.Text.Length >= 32 Then
            BtnValidar.Enabled = True
        Else
            BtnValidar.Enabled = False
        End If
    End Sub

    Private Sub TxtToken_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtToken.KeyPress
        ' Permite apenas letras e números
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Ignora o caractere
        End If
    End Sub

    Private Sub BtnValidar_Click(sender As Object, e As EventArgs) Handles BtnValidar.Click
        If Not ValidarControle(TxtToken, ErrorProvider1) Then Return
        If ValidarToken(TxtToken.Text) Then
            Token = True
            Sistema = SistemaBLL.BuscarTodos()
            Dim AdmAtiva As SistemaDTO = Sistema.FirstOrDefault(Function(s) s.Id_Status = 1)
            VarGlob.SistemaAtivo = AdmAtiva
            RJMessageBox.Show("O Sistema será reiniciado para que as alterações sejam carregadas", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Application.Restart()
            Environment.Exit(0)
        Else
            Token = False
        End If
    End Sub

    Private Sub BtnSolicitarToken_Click(sender As Object, e As EventArgs) Handles BtnSolicitarToken.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        If Token Then
            CloseWindow()
        Else
            Environment.Exit(0)
        End If
    End Sub

#Region "TOKEN"
    Private Function ValidarToken(Token As String) As Boolean
        ' Busca os dados locais e na nuvem
        Dim Sistema As List(Of SistemaDTO) = SistemaBLL.BuscarTodos()
        Dim SistemaNuvem As List(Of TokenOnDTO) = SistemaNuvemBLL.BuscarPorToken(Token)
        Dim LabelMensagem = LblMensagem.Text
        LblMensagem.Text = "V A L I D A N D O   T O K E N"
        LblMensagem.TextAlign = ContentAlignment.MiddleCenter
        Application.DoEvents()
        ' Verifica se o token foi encontrado na nuvem
        If SistemaNuvem Is Nothing OrElse SistemaNuvem.Count = 0 Then
            RJMessageBox.Show("Token não encontrado na base de dados da nuvem.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Dim sisNuvem As TokenOnDTO = SistemaNuvem.FirstOrDefault(Function(t) t.Token = Token)
        If sisNuvem Is Nothing Then
            RJMessageBox.Show("Token inválido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Try
            Dim admlc As String = sisNuvem.Id_Admlc
            Dim status As Integer = Convert.ToInt32(sisNuvem.status)

            ' Verifica se o status já é 1
            If status = 1 Then
                RJMessageBox.Show($"Token já validado anteriormente.{vbNewLine}Solicite um novo token.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            ' Baixando Administração Local
            Dim AdmLocalOn As AdmlcDTO = AdmLocalOnBLL.BuscarPorId(admlc)
            Dim AdmLocal As New AdmlcDTO With {
                .Id = AdmLocalOn.Id,
                .Adm_Local = AdmLocalOn.Adm_Local,
                .Razao_Social = AdmLocalOn.Razao_Social,
                .CNPJ = AdmLocalOn.CNPJ,
                .Cidade = AdmLocalOn.Cidade,
                .UF = AdmLocalOn.UF,
                .Id_Status = AdmLocalOn.Id_Status,
                .Id_Admrg = AdmLocalOn.Id_Admrg
            }

            Dim AdmLocalExiste As AdmlcDTO = AdmLocalBLL.BuscarPorId(AdmLocalOn.Id)
            If AdmLocalExiste IsNot Nothing Then
                AdmLocalBLL.Atualizar(AdmLocal)
            Else
                AdmLocalBLL.Inserir(AdmLocal)
            End If

            ' Baixando Administração Regional
            Dim AdmRegionalOn As AdmrgDTO = AdmRegionalOnBLL.BuscarPorId(AdmLocalOn.Id_Admrg)
            Dim AdmRegional As New AdmrgDTO With {
                .Id = AdmRegionalOn.Id,
                .Adm_Regional = AdmRegionalOn.Adm_Regional,
                .UF = AdmRegionalOn.UF
            }

            Dim AdmRegionalExiste As AdmrgDTO = AdmRegionalBLL.BuscarPorId(AdmRegionalOn.Id)
            If AdmRegionalExiste IsNot Nothing Then
                AdmRegionalBLL.Atualizar(AdmRegional)
            Else
                AdmRegionalBLL.Inserir(AdmRegional)
            End If

            ' Criação e atualização do objeto SistemaDTO
            If Sistema IsNot Nothing Then
                Dim sistemaExistente As SistemaDTO = Sistema.Find(Function(s) s.Token = Token)
                Dim sistem As New SistemaDTO() With {
                    .Id_Admlc = admlc,
                    .Setor_Definido = 0,
                    .Token = Token,
                    .Token_Validado = 1,
                    .Ativo = -1
                }

                If sistemaExistente IsNot Nothing Then
                    sistem.Id = sistemaExistente.Id
                    SistemaBLL.Atualizar(sistem)
                Else
                    SistemaBLL.Inserir(sistem)
                End If

                VarGlob.SistemaAtivo = sistem

                ' Baixar Setores
                Dim SetoresOn As List(Of SetoresDTO) = SetoresOnBLL.BuscarTodos()
                For Each SetorOn As SetoresDTO In SetoresOn
                    Dim Setores As New SetoresDTO With {
                        .Id = SetorOn.Id,
                        .Cod_Setor = SetorOn.Cod_Setor,
                        .Descricao = SetorOn.Descricao,
                        .Id_Admlc = SetorOn.Id_Admlc
                    }

                    Dim SetoresExiste As SetoresDTO = SetoresBLL.BuscarPorId(SetorOn.Id)
                    If SetoresExiste IsNot Nothing Then
                        SetoresBLL.Atualizar(Setores)
                    Else
                        SetoresBLL.Inserir(Setores)
                    End If
                Next

                ' Atualiza ou insere as igrejas com base nos dados remotos
                Dim Igrejas As List(Of IgrejasDTO) = IgrejasBll.BuscarPorAdministracao(admlc)
                Dim IgrejasOn As List(Of IgrejasOnDTO) = IgrejasOnBLL.BuscarPorAdministracao(admlc)
                With RjProgressBar1
                    .Visible = True
                    .Minimum = 0
                    .Maximum = 100
                    .Value = 0
                End With
                Dim cont = 0
                LblMensagem.Text = "C A R R E G A N D O   L I S T A   D E   I G R E J A S"
                For Each IgrejaOn As IgrejasOnDTO In IgrejasOn
                    RjProgressBar1.Value = CInt((cont / IgrejasOn.Count) * 100)
                    Application.DoEvents()
                    Dim IgrejaExistente As IgrejasDTO = Igrejas.FirstOrDefault(Function(i) i.Id = IgrejaOn.Id)
                    If IgrejaExistente Is Nothing Then
                        ' Insere uma nova igreja local com base nos dados remotos
                        Dim novaIgreja As New IgrejasDTO() With {
                            .Id = IgrejaOn.Id,
                            .Igreja = IgrejaOn.Igreja,
                            .Cod_Siga = IgrejaOn.Cod_Siga,
                            .Razao_Social = IgrejaOn.Razao_Social,
                            .CNPJ = IgrejaOn.CNPJ,
                            .Logradouro = IgrejaOn.Logradouro,
                            .Numero = IgrejaOn.Numero,
                            .Bairro = IgrejaOn.Bairro,
                            .Cidade = IgrejaOn.Cidade,
                            .UF = IgrejaOn.UF,
                            .Id_Tipo = IgrejaOn.Id_Tipo,
                            .Id_Status = IgrejaOn.Id_Status,
                            .Cod_Setor = IgrejaOn.Cod_Setor,
                            .Id_AdmLc = IgrejaOn.Id_AdmLc,
                            .observacao = IgrejaOn.Observacao
                        }
                        IgrejasBll.Inserir(novaIgreja)
                    End If
                    cont = cont + 1
                Next

                ' Atualiza Dados do servidor remoto
                Dim Servidores As List(Of ServidoresDTO) = ServidoresBLL.BuscarTodos()
                Dim ServidoresOn As List(Of ServidoresOnDTO) = ServidoresOnBLL.BuscarTodos()

                If Servidores Is Nothing OrElse Servidores.Count <= 0 Then
                    LblMensagem.Text = "C A R R E G A N D O   L I S T A   D E   S E R V I D O R E S"
                    Dim ServidorOn As ServidoresOnDTO = ServidoresOn.FirstOrDefault(Function(s) s.Id_Admlc = admlc)
                    Dim servidor As New ServidoresDTO With {
                        .Id_Admlc = ServidorOn.Id_Admlc,
                        .Servidor = ServidorOn.Servidor,
                        .Porta = ServidorOn.Porta,
                        .Banco = ServidorOn.Banco,
                        .Usuario = ServidorOn.Usuario,
                        .Senha = ServidorOn.Senha,
                        .Ativo = -1
                    }
                    ServidoresBLL.Inserir(servidor)

                    ' Atualizando App.config
                    Dim Banco As String = "MySQL"
                    Dim StringConexao As String = $"Server={servidor.Servidor};Port={servidor.Porta};Database={servidor.Banco};Uid={servidor.Usuario};Pwd={servidor.Senha};DBServer={Banco};"
                    AtualizaAppConfig(Banco, StringConexao)
                End If

                ' Atualiza o status do token na nuvem
                sisNuvem.status = 1
                SistemaNuvemBLL.Atualizar(sisNuvem)

                ' Atualiza o status do solicitante na nuvem
                Dim Solicitante As TokenSolicitacaoOnDTO = SolicitacaoOnBLL.BuscarPorId(sisNuvem.Id_solicitacao)
                Solicitante.Status = 1
                SolicitacaoOnBLL.Atualizar(Solicitante)

                ' Finalizando validação do token
                RjProgressBar1.Visible = False
                LblMensagem.TextAlign = ContentAlignment.MiddleLeft
                LblMensagem.Text = "Reiniciando..."
                Return True
            Else
                LblMensagem.TextAlign = ContentAlignment.MiddleLeft
                LblMensagem.Text = LabelMensagem
                RJMessageBox.Show("Falha ao atualizar o status do token.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As MySqlException
            ' Trata erros específicos de banco de dados
            RJMessageBox.Show($"Falha ao conectar ao Banco de Dados MySQL: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Trata outros tipos de exceções
            RJMessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub BtnSolicitar_Click(sender As Object, e As EventArgs) Handles BtnSolicitar.Click
        ' Validar controles
        If Not ValidarControle(TxtNome, ErrorProvider1) Then Return
        If Not ValidarControle(TxtTelefone, ErrorProvider1) Then Return
        If Not ValidarControle(TxtEmail, ErrorProvider1) Then Return
        If Not IsValidEmail(TxtEmail, ErrorProvider1) Then Return
        If Not ValidarControle(TxtComun, ErrorProvider1) Then Return
        If Not ValidarControle(TxtCidade, ErrorProvider1) Then Return
        ' Mensagem de envio
        Dim Mensagem As String = $"<h2>Nova Solicitação de Token SIBEM-v4</h2>" &
              "<p>A Paz de Deus!<br></p>" &
              $"<p>Esta é uma solicitação de token do irmão <b>{TxtNome.Text}</b> para acesso ao sistema de inventários CCB SIBEM.<br> Seguem dados para gerar token de ativação:</p>" &
              "<ul>" &
                  $"<li>Nome:                   {TxtNome.Text.ToUpper}</li>" &
                  $"<li>E-mail:                 {TxtEmail.Text.ToLower}</li>" &
                  $"<li>Telefone:               {TxtTelefone.Text.ToUpper}</li>" &
                  $"<li>Comum Congregação:      {TxtComun.Text.ToUpper}</li>" &
                  $"<li>Cidade:                 {TxtCidade.Text.ToUpper}</li>" &
                  $"<li>Setor:                  {TxtSetor.Text.ToUpper}</li>" &
              "</ul>" &
              $"<p>Irmão <b>{TxtNome.Text}</b>, em breve o administrador enviará seu token de acesso.</p>" &
              "<p>Att,</p><p>SIBEM - Sistema para Inventário de Bens Móveis"
        Try
            ' Enviar solicitação
            Dim Solicitacao As Boolean = EmailHelper.EnviarEmail("Solicitação de Token para acesso ao Sistema SIBEM-v4", Mensagem, "rfergomes@gmail.com", TxtEmail.Text.ToLower)
            ' Mensagem de retorno
            If Solicitacao Then
                Dim SolicitacaoOn As New TokenSolicitacaoOnDTO With {
                .Nome = TxtNome.Text.ToUpper,
                .Email = TxtEmail.Text,
                .Telefone = TxtTelefone.Text,
                .Igreja = TxtComun.Text.ToUpper,
                .Cidade = TxtCidade.Text.ToUpper,
                .Setor = TxtSetor.Text.ToUpper,
                .AdmLc = String.Empty,
                .Status = 0,
                .Data = Now().ToString("yyyy-mm-dd HH:ss:ff")
                }
                SolicitacaoOnBLL.Inserir(SolicitacaoOn)
                RJMessageBox.Show("Solcitação enviada com sucesso! Aguarde o contato do Administrador do Sistema", "Solicitação de Token", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TabControl1.SelectedIndex = 0
            Else
                RJMessageBox.Show("Não foi possível enviar sua solicitação.", "Solicitação de Token", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            RJMessageBox.Show(ex.Message, "Solicitação de Token", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region


End Class