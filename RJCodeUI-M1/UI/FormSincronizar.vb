'Última Atualização:    25/11/2024
'Data:                  24/03/2025
'Autor:                 Rodrigo Fernando Gomes Lima

Imports System.Windows.Forms.DataVisualization.Charting
Imports ZstdSharp.Unsafe

Public Class FormSincronizar
    Private SQLite As New ConnectionFactory
    Private MySQL As New ConnectionFactory
    Private MySQL_ADM As New ConnectionFactory
    Private SincBLL As SincronizarBLL
    Private DependBLL As DependenciasBLL
    Private DependOnBLL As DependenciasOnBLL
    Private IgrejasBLL As IgrejasBLL
    Private IgrejasOnBLL As IgrejasOnBLL
    Private InventBLL As InventariosBLL
    Private InventOnBLL As InventariosOnBLL
    Private InventDetalhesBLL As InventarioDetalhesBLL
    Private InventDetalhesOnBLL As InventarioDetalhesOnBLL
    Private BensMoveisBLL As BensBLL
    Private BensMoveisOnBLL As BensOnBLL
    Private SetoresBLL As SetoresBLL
    Private SetoresOnBLL As SetoresOnBLL
    Private Log As New Logger
    Private Retorno As Integer?
    'Private SetoresOn As SetoresOnBLL

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        SQLite = New ConnectionFactory()
        MySQL = New ConnectionFactory(DatabaseType.MySQL)
        MySQL_ADM = New ConnectionFactory(DatabaseType.MySQL_SYS)
        SincBLL = New SincronizarBLL(SQLite)
        DependBLL = New DependenciasBLL(SQLite)
        DependOnBLL = New DependenciasOnBLL(MySQL_ADM)
        IgrejasBLL = New IgrejasBLL(SQLite)
        IgrejasOnBLL = New IgrejasOnBLL(MySQL_ADM)
        InventBLL = New InventariosBLL(SQLite)
        InventOnBLL = New InventariosOnBLL(MySQL)
        InventDetalhesBLL = New InventarioDetalhesBLL(SQLite)
        InventDetalhesOnBLL = New InventarioDetalhesOnBLL(MySQL)
        BensMoveisBLL = New BensBLL(SQLite)
        BensMoveisOnBLL = New BensOnBLL(MySQL)
        SetoresBLL = New SetoresBLL(SQLite)
        SetoresOnBLL = New SetoresOnBLL(MySQL_ADM)
    End Sub

    Private Async Sub BtnChecar_Click(sender As Object, e As EventArgs) Handles BtnChecar.Click
        BtnSincronizar.Enabled = False
        RjPanelEstatistica.Visible = False
        LblProgress.Visible = True ' Exibe o GIF de carregamento

        ' Executa apenas `ChecarDadosRemotos()` na thread separada
        Dim sync As Boolean = Await Task.Run(Function()
                                                 ChecarDadosRemotos()
                                                 Return True
                                             End Function)

        ' Agora, atualiza os Labels na UI Thread
        Invoke(Sub()
                   Dim resultado = AtualizarLabels()
                   BtnSincronizar.Enabled = resultado
                   RjPanel3.Visible = False
                   RjPanelEstatistica.Visible = True
                   LblProgress.Visible = False ' Oculta o GIF após o término do processo
               End Sub)
    End Sub




    Private Sub BtnSincronizar_Click(sender As Object, e As EventArgs) Handles BtnSincronizar.Click
        RjPanel3.Visible = True
        Try
            EnviarDados()
        Catch ex As Exception
            RJMessageBox.Show($"Falha ao Enviar Dados {vbNewLine}{ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            ReceberDados()
        Catch ex As Exception
            RJMessageBox.Show($"Falha ao Receber Dados {vbNewLine}{ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ChecarDados() As Boolean
        Try
            ChecarDadosRemotos()
            Return AtualizarLabels()
        Catch ex As Exception
            RJMessageBox.Show("Ocorreu um erro: " & ex.Message)
        End Try
        Return False
    End Function

    Private Function AtualizarLabels() As Boolean
        Dim Status As Boolean = True
        ' Mapeamento das tabelas para os pares de Labels correspondentes
        Dim labelMap As New Dictionary(Of String, (Label, Label)) From {
            {"DEPENDENCIAS", (LblDependenciasLocal, LblDependenciasRemoto)},
            {"IGREJAS", (LblIgrejasLocal, LblIgrejasRemoto)},
            {"INVENTARIOS", (LblinventariosLocal, LblinventariosRemoto)},
            {"SETORES", (LblSetoresLocal, LblSetoresRemoto)}
        }

        Dim sincronizacaoData As List(Of List(Of String)) = SincBLL.BuscarResumoSincronizar($"id_admlc={VarGlob.SistemaAtivo.Id_Admlc}")
        If sincronizacaoData IsNot Nothing AndAlso sincronizacaoData.Count > 0 Then
            ' Atualizar as Labels com os dados reais da sincronização
            For Each item In sincronizacaoData
                Dim tabela = item(0).ToUpper()
                If labelMap.ContainsKey(tabela) Then
                    labelMap(tabela).Item1.Text = item(1) ' Atualizar "LOCAL ENVIAR"
                    labelMap(tabela).Item2.Text = item(2) ' Atualizar "REMOTO RECEBER"
                Else
                    labelMap(tabela).Item1.Text = 0 ' Atualizar "LOCAL ENVIAR"
                    labelMap(tabela).Item2.Text = 0 ' Atualizar "REMOTO RECEBER"
                    Status = False
                End If
                Refresh()
            Next
        Else
            ' Inicializar todas as Labels com "0"
            For Each labelPair In labelMap.Values
                labelPair.Item1.Text = "0" ' Label de "LOCAL ENVIAR"
                labelPair.Item2.Text = "0" ' Label de "REMOTO RECEBER"
            Next
            Status = False
        End If
        Return Status
    End Function

#Region " ENVIAR DADOS "
    Public Sub EnviarDados()
        Dim ContA As Long = 0
        Dim Dados As List(Of SincronizarDTO) = SincBLL.BuscarTodos($"acao='Enviar' AND status=0 AND id_admlc='{VarGlob.SistemaAtivo.Id_Admlc}'")
        If Dados IsNot Nothing AndAlso Dados.Count > 0 Then
            Dim InventSincLista As List(Of SincronizarDTO) = Dados.Where(Function(item) item.Tabela.ToUpper() = "INVENTARIOS").ToList()
            With RjProgressBar1
                .Visible = True
                .Value = 0
            End With
            ImgSinc.Image = My.Resources.Enviar
            ' INVENTÁRIOS - DETALHES - BENS MÓVEIS
            If InventSincLista IsNot Nothing Then
                For Each Item As SincronizarDTO In InventSincLista
                    RjProgressBar1.Value = CInt((ContA / InventSincLista.Count) * 100)
                    Application.DoEvents()
                    Dim Inventario As InventariosDTO = InventBLL.BuscarPorId(Item.Id_Tabela)
                    If Inventario IsNot Nothing Then
                        VarGlob.Id_Inventario_Ativo = Inventario.Id
                        LblMsgTitulo.Text = $"{Inventario.Id} - {Inventario.Igreja}"
                        Application.DoEvents()
                        Dim InventOn As InventariosOnDTO = InventOnBLL.BuscarPorId(Inventario.Id)
                        Dim Invent As New InventariosOnDTO With {
                            .Id = Inventario.Id,
                            .Id_Igreja = Inventario.Id_Igreja,
                            .Data = Inventario.Data,
                            .Responsaveis = Inventario.Responsaveis,
                            .Inventariantes = Inventario.Inventariantes,
                            .Inicio = Inventario.Inicio,
                            .Termino = Inventario.Termino,
                            .Duracao = Inventario.Duracao,
                            .Situacao = Inventario.Situacao,
                            .Bens_Inicial = Inventario.Bens_Inicial,
                            .Bens_Lidos = Inventario.Bens_Lidos,
                            .Bens_Pendentes = Inventario.Bens_Pendentes,
                            .Bens_Novos = Inventario.Bens_Novos,
                            .Bens_Final = Inventario.Bens_Final,
                            .Bens_Importado = Inventario.Bens_Importado,
                            .Inventario_Teste = Inventario.Inventario_Teste,
                            .Id_Admlc = VarGlob.SistemaAtivo.Id_Admlc
                        }

                        ' ENVIAR INVENTÁRIO


                        If InventOn IsNot Nothing AndAlso InventOn.Id <> "" Then
                            Retorno = InventOnBLL.Atualizar(Invent)
                            If (Retorno = 0) Then Log.WriteLog($"Falha: Enviar Dados - Inventário {InventOn.Id} - Atualizar")
                        Else
                            Retorno = InventOnBLL.Inserir(Invent)
                            If (Retorno = 0) Then Log.WriteLog($"Falha: Enviar Dados - Inventário {InventOn.Id} - Inserir")
                        End If

                        Dim Detalhes As List(Of InventarioDetalhesDTO) = InventDetalhesBLL.BuscarTodos()
                        If Detalhes IsNot Nothing Then
                            With RjProgressBar2
                                .Visible = True
                                .Value = 0
                            End With
                            Dim ContB As Long = 0
                            For Each Detalhe As InventarioDetalhesDTO In Detalhes
                                LblMsgDescricao.Text = $"{Detalhe.Id_Bem} - {Detalhe.Bem}"
                                RjProgressBar2.Value = CInt((ContB / Detalhes.Count) * 100)
                                Application.DoEvents()

                                ' ENVIAR INVENTÁRIO_DETALHES
                                Dim IDetalhe As New InventarioDetalhesOnDTO With {
                                    .Id = Detalhe.Id,
                                    .Id_inventario = Detalhe.Id_inventario,
                                    .Id_Bem = Detalhe.Id_Bem,
                                    .Estado = Detalhe.Estado,
                                    .Acao = Detalhe.Acao,
                                    .Bem = Detalhe.Bem,
                                    .Id_dependencia = Detalhe.Id_dependencia,
                                    .Observacao = Detalhe.Observacao,
                                    .Contagem = Detalhe.Contagem
                                }
                                Dim InventDetalheOn As InventarioDetalhesOnDTO = InventDetalhesOnBLL.BuscarPorId(Detalhe.Id_Bem)
                                If InventDetalheOn IsNot Nothing AndAlso InventDetalheOn.Id_Bem <> "" Then
                                    Retorno = InventDetalhesOnBLL.Atualizar(IDetalhe)
                                    If (Retorno = 0) Then Log.WriteLog($"Falha: Enviar Dados - Inventário Detalhes {IDetalhe.Id} - Atualizar")
                                Else
                                    Retorno = InventDetalhesOnBLL.Inserir(IDetalhe)
                                    If (Retorno = 0) Then Log.WriteLog($"Falha: Enviar Dados - Inventário Detalhes {IDetalhe.Id} - Inserir")
                                End If

                                ' ENVIAR BENS MÓVEIS
                                Dim BemMovelOn As BensOnDTO
                                Dim BemMovel As BensDTO = BensMoveisBLL.BuscarPorId(IDetalhe.Id_Bem)
                                If BemMovel IsNot Nothing Then
                                    Dim BemExiste As BensOnDTO = BensMoveisOnBLL.BuscarPorId(IDetalhe.Id_Bem)
                                    If BemExiste IsNot Nothing Then
                                        BemMovelOn = New BensOnDTO With {
                                            .Id = BemMovel.Id,
                                            .Descricao = BemMovel.Descricao,
                                            .Id_igreja = BemMovel.Id_igreja,
                                            .Id_Dependencia = BemMovel.Id_Dependencia,
                                            .Id_Status = BemMovel.Id_Status
                                        }
                                        Retorno = BensMoveisOnBLL.Atualizar(BemMovelOn)
                                        If (Retorno = 0) Then Log.WriteLog($"Falha: Enviar Dados - Bens Móveis {BemMovelOn.Id} - Atualizar")
                                    Else
                                        BemMovelOn = New BensOnDTO With {
                                            .Id = BemMovel.Id,
                                            .Descricao = BemMovel.Descricao,
                                            .Id_igreja = BemMovel.Id_igreja,
                                            .Id_Dependencia = BemMovel.Id_Dependencia,
                                            .Id_Status = BemMovel.Id_Status
                                        }
                                        Retorno = BensMoveisOnBLL.Inserir(BemMovelOn)
                                        If (Retorno = 0) Then Log.WriteLog($"Falha: Enviar Dados - Bens Móveis {BemMovelOn.Id} - Inserir")
                                    End If
                                End If
                                ContB += 1
                            Next
                            RjProgressBar2.Visible = False
                        End If
                    End If
                    ContA += 1
                    LblMsgTitulo.Text = "CONCLUÍDO!"
                    LblMsgDescricao.ResetText()
                    Item.Status = -1
                    SincBLL.Atualizar(Item)
                    AtualizarLabels()
                    Application.DoEvents()
                Next
                RjProgressBar1.Visible = False

            End If

            ' ENVIAR IGREJAS
            Dim IgrejasSincLista As List(Of SincronizarDTO) = Dados.Where(Function(item) item.Tabela.ToUpper() = "IGREJAS").ToList()
            With RjProgressBar1
                .Visible = True
                .Value = 0
            End With
            If IgrejasSincLista IsNot Nothing Then
                ContA = 0
                For Each IgrejaSinc As SincronizarDTO In IgrejasSincLista
                    RjProgressBar1.Value = CInt((ContA / IgrejasSincLista.Count) * 100)
                    Application.DoEvents()
                    Dim IgrejaOn As IgrejasOnDTO
                    Dim Igreja As IgrejasDTO = IgrejasBLL.BuscarPorId(IgrejaSinc.Id_Tabela)
                    If Igreja IsNot Nothing Then
                        LblMsgTitulo.Text = $"{Igreja.Cod_Siga} - {Igreja.Igreja}"
                        Application.DoEvents()
                        Dim IgrejaExiste As IgrejasOnDTO = IgrejasOnBLL.BuscarPorId(IgrejaSinc.Id_Tabela)
                        IgrejaOn = New IgrejasOnDTO With {
                                .Id = Igreja.Id,
                                .Igreja = Igreja.Igreja,
                                .Cod_Siga = Igreja.Cod_Siga,
                                .Razao_Social = Igreja.Razao_Social,
                                .CNPJ = Igreja.CNPJ,
                                .Logradouro = Igreja.Logradouro,
                                .Numero = Igreja.Numero,
                                .Bairro = Igreja.Bairro,
                                .Cidade = Igreja.Cidade,
                                .UF = Igreja.UF,
                                .Id_Tipo = Igreja.Id_Tipo,
                                .Id_Status = Igreja.Id_Status,
                                .Cod_Setor = Igreja.Cod_Setor,
                                .Id_AdmLc = Igreja.Id_AdmLc,
                                .Observacao = Igreja.observacao
                            }

                        If IgrejaExiste IsNot Nothing Then
                            Retorno = IgrejasOnBLL.Atualizar(IgrejaOn)
                            If (Retorno = 0) Then Log.WriteLog($"Falha: Enviar Dados - Igreja {IgrejaOn.Id} - Atualizar")
                        Else
                            Retorno = IgrejasOnBLL.Inserir(IgrejaOn)
                            If (Retorno = 0) Then Log.WriteLog($"Falha: Enviar Dados - Igreja {IgrejaOn.Id} - Inserir")
                        End If
                    End If
                    ContA += 1
                    IgrejaSinc.Status = -1
                    SincBLL.Atualizar(IgrejaSinc)
                    AtualizarLabels()
                    Application.DoEvents()
                Next
                LblMsgTitulo.Text = "CONCLUÍDO!"
                LblMsgDescricao.ResetText()
                With RjProgressBar1
                    .Visible = False
                    .Value = 0
                End With
            End If


            ' ENVIAR SETORES
            Dim SetoresSincLista As List(Of SincronizarDTO) = Dados.Where(Function(item) item.Tabela.ToUpper() = "SETORES").ToList()
            With RjProgressBar1
                .Visible = True
                .Value = 0
            End With
            If SetoresSincLista IsNot Nothing Then
                ContA = 0
                For Each SetoresSinc As SincronizarDTO In SetoresSincLista
                    RjProgressBar1.Value = CInt((ContA / SetoresSincLista.Count) * 100)
                    Application.DoEvents()
                    Dim SetoresOn As SetoresOnDTO
                    Dim Setor As SetoresDTO = SetoresBLL.BuscarPorId(SetoresSinc.Id_Tabela)
                    If Setor IsNot Nothing Then
                        LblMsgTitulo.Text = $"Setor {Setor.Cod_Setor} - {Setor.Descricao}"
                        Application.DoEvents()
                        Dim SetorExiste As SetoresOnDTO = SetoresOnBLL.BuscarPorId(SetoresSinc.Id_Tabela)
                        SetoresOn = New SetoresOnDTO With {
                                .Cod_Setor = Setor.Cod_Setor,
                                .Descricao = Setor.Descricao,
                                .Id_Admlc = Setor.Id_Admlc
                            }

                        If SetorExiste IsNot Nothing Then
                            Retorno = SetoresOnBLL.Atualizar(SetoresOn)
                            If (Retorno = 0) Then Log.WriteLog($"Falha: Enviar Dados - Setor {SetoresOn.Id} - Atualizar")
                        Else
                            Retorno = SetoresOnBLL.Inserir(SetoresOn)
                            If (Retorno = 0) Then Log.WriteLog($"Falha: Enviar Dados - Setor {SetoresOn.Id} - Inserir")
                        End If
                        ReplicarDados(SyncOrigem.Receber, "setores", Setor.Cod_Setor, "")
                    End If
                    ContA += 1
                    SetoresSinc.Status = -1
                    SincBLL.Atualizar(SetoresSinc)
                    AtualizarLabels()
                    Application.DoEvents()
                Next
                LblMsgTitulo.Text = "CONCLUÍDO!"
                LblMsgDescricao.ResetText()
                With RjProgressBar1
                    .Visible = False
                    .Value = 0
                End With
            End If
        End If
        AtualizarLabels()
    End Sub
#End Region ' ENVIAR DADOS

#Region "RECEBER DADOS"
    Private Sub ReceberDados()
        Dim ContA As Long = 0
        Try
            Dim Dados As List(Of SincronizarDTO) = SincBLL.BuscarTodos($"acao='Receber' AND status=0 AND id_admlc='{VarGlob.SistemaAtivo.Id_Admlc}'")
            If Dados IsNot Nothing AndAlso Dados.Count > 0 Then
                Dim InventSincLista As List(Of SincronizarDTO) = Dados.Where(Function(item) item.Tabela.ToUpper() = "INVENTARIOS").ToList()
                With RjProgressBar1
                    .Visible = True
                    .Value = 0
                End With
                LblMsgDescricao.Text = String.Empty
                ImgSinc.Image = My.Resources.Receber

#Region "RECEBER SETORES"
                ' RECEBER SETORES
                Dim SetoresSincLista As List(Of SincronizarDTO) = Dados.Where(Function(item) item.Tabela.ToUpper() = "SETORES").ToList()
                With RjProgressBar1
                    .Visible = True
                    .Value = 0
                End With
                If SetoresSincLista IsNot Nothing Then
                    ContA = 0
                    For Each SetoresSinc As SincronizarDTO In SetoresSincLista
                        RjProgressBar1.Value = CInt((ContA / SetoresSincLista.Count) * 100)
                        Application.DoEvents()
                        Dim Setor As SetoresDTO
                        Dim SetorOn As SetoresOnDTO = SetoresOnBLL.BuscarPorId(SetoresSinc.Id_Tabela)
                        If SetorOn IsNot Nothing Then
                            LblMsgTitulo.Text = $"{SetorOn.Cod_Setor} - {SetorOn.Descricao}"
                            Application.DoEvents()
                            Dim SetorExiste As SetoresDTO = SetoresBLL.BuscarPorId(SetoresSinc.Id_Tabela)
                            Setor = New SetoresDTO With {
                                .Id = SetorOn.Id,
                                .Cod_Setor = SetorOn.Cod_Setor,
                                .Descricao = SetorOn.Descricao,
                                .Id_Admlc = SetorOn.Id_Admlc
                            }

                            If SetorExiste IsNot Nothing Then
                                Retorno = SetoresBLL.Atualizar(Setor)
                                If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Setor {Setor.Id} - Atualizar")
                            Else
                                Retorno = SetoresBLL.Inserir(Setor)
                                If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Setor {Setor.Id} - Inserir")
                            End If

                            SetoresSinc.Status = -1
                            SincBLL.Atualizar(SetoresSinc)
                            AtualizarLabels()
                            Application.DoEvents()
                        End If
                        ContA += 1
                    Next
                    LblMsgTitulo.Text = ""
                    LblMsgDescricao.ResetText()
                    With RjProgressBar1
                        .Visible = False
                        .Value = 0
                    End With
                End If
#End Region

#Region "RECEBER DEPENDENCIAS"
                ' RECEBER DEPENDENCIAS
                Dim DependSYncLista As List(Of SincronizarDTO) = Dados.Where(Function(item) item.Tabela.ToUpper() = "DEPENDENCIAS").ToList()
                With RjProgressBar1
                    .Visible = True
                    .Value = 0
                End With
                If DependSYncLista IsNot Nothing Then
                    ContA = 0
                    For Each DependSinc As SincronizarDTO In DependSYncLista
                        RjProgressBar1.Value = CInt((ContA / DependSYncLista.Count) * 100)
                        Application.DoEvents()
                        Dim Depend As DependenciasDTO
                        Dim DependOn As DependenciasOnDTO = DependOnBLL.BuscarPorId(DependSinc.Id_Tabela)
                        If DependOn IsNot Nothing Then
                            LblMsgTitulo.Text = $"{DependOn.Id} - {DependOn.Descricao}"
                            Application.DoEvents()
                            Dim DependExiste As DependenciasDTO = DependBLL.BuscarPorId(DependSinc.Id_Tabela)
                            Depend = New DependenciasDTO With {
                                .Id = DependOn.Id,
                                .Descricao = DependOn.Descricao
                            }

                            If DependExiste IsNot Nothing Then
                                Retorno = DependBLL.Atualizar(Depend)
                                If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Dependência {Depend.Id} - Atualizar")
                            Else
                                Retorno = DependBLL.Inserir(Depend)
                                If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Dependência {Depend.Id} - Inserir")
                            End If
                            DependSinc.Status = -1
                            SincBLL.Atualizar(DependSinc)
                            AtualizarLabels()
                            Application.DoEvents()
                        End If
                        ContA += 1
                    Next
                    LblMsgTitulo.Text = ""
                    LblMsgDescricao.ResetText()
                    With RjProgressBar1
                        .Visible = False
                        .Value = 0
                    End With
                End If
#End Region

#Region "RECEBER IGREJAS"
                ' RECEBER IGREJAS
                Dim IgrejasSincLista As List(Of SincronizarDTO) = Dados.Where(Function(item) item.Tabela.ToUpper() = "IGREJAS").ToList()
                With RjProgressBar1
                    .Visible = True
                    .Value = 0
                End With
                If IgrejasSincLista IsNot Nothing Then
                    ContA = 0
                    For Each IgrejaSinc As SincronizarDTO In IgrejasSincLista
                        RjProgressBar1.Value = CInt((ContA / IgrejasSincLista.Count) * 100)
                        Application.DoEvents()
                        Dim Igreja As IgrejasDTO
                        Dim IgrejaOn As IgrejasOnDTO = IgrejasOnBLL.BuscarPorId(IgrejaSinc.Id_Tabela)
                        If IgrejaOn IsNot Nothing Then
                            LblMsgTitulo.Text = $"{IgrejaOn.Cod_Siga} - {IgrejaOn.Igreja}"
                            Application.DoEvents()
                            Dim IgrejaExiste As IgrejasOnDTO = IgrejasOnBLL.BuscarPorId(IgrejaSinc.Id_Tabela)
                            Igreja = New IgrejasDTO With {
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

                            If IgrejaExiste IsNot Nothing Then
                                Retorno = IgrejasBLL.Atualizar(Igreja)
                                If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Igreja {Igreja.Id} - Atualizar")
                            Else
                                Retorno = IgrejasBLL.Inserir(Igreja)
                                If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Igreja {Igreja.Id} - Inserir")
                            End If
                        End If

                        ContA += 1
                        IgrejaSinc.Status = -1
                        SincBLL.Atualizar(IgrejaSinc)
                        AtualizarLabels()
                        Application.DoEvents()
                    Next
                    LblMsgTitulo.Text = ""
                    LblMsgDescricao.ResetText()
                    With RjProgressBar1
                        .Visible = False
                        .Value = 0
                    End With
                End If
#End Region

#Region "INVENTÁRIOS - DETALHES - BENS MÓVEIS"
                ' INVENTÁRIOS - DETALHES - BENS MÓVEIS
                If InventSincLista IsNot Nothing Then
                    For Each Item As SincronizarDTO In InventSincLista
                        RjProgressBar1.Value = CInt((ContA / InventSincLista.Count) * 100)
                        Application.DoEvents()
                        Dim Inventario As InventariosOnDTO = InventOnBLL.BuscarPorId(Item.Id_Tabela)
                        If Inventario IsNot Nothing Then
                            VarGlob.Id_Inventario_Ativo = Inventario.Id
                            LblMsgTitulo.Text = $"Inventario: {Inventario.Id}"
                            Application.DoEvents()
                            Dim Invent As InventariosDTO = InventBLL.BuscarPorId(Inventario.Id)
                            Dim InventSync As New InventariosDTO With {
                                .Id = Inventario.Id,
                                .Id_Igreja = Inventario.Id_Igreja,
                                .Data = Inventario.Data,
                                .Responsaveis = Inventario.Responsaveis,
                                .Inventariantes = Inventario.Inventariantes,
                                .Inicio = Inventario.Inicio,
                                .Termino = Inventario.Termino,
                                .Duracao = Inventario.Duracao,
                                .Situacao = Inventario.Situacao,
                                .Bens_Inicial = Inventario.Bens_Inicial,
                                .Bens_Lidos = Inventario.Bens_Lidos,
                                .Bens_Pendentes = Inventario.Bens_Pendentes,
                                .Bens_Novos = Inventario.Bens_Novos,
                                .Bens_Final = Inventario.Bens_Final,
                                .Bens_Importado = Inventario.Bens_Importado,
                                .Inventario_Teste = Inventario.Inventario_Teste,
                                .Id_AdmLc = Inventario.Id_Admlc
                            }

                            ' RECEBER INVENTÁRIO
                            If Invent IsNot Nothing AndAlso Invent.Id <> "" Then
                                Retorno = InventBLL.Atualizar(InventSync)
                                If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Inventário {InventSync.Id} - Atualizar")
                            Else
                                Retorno = InventBLL.Inserir(InventSync)
                                If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Inventário {InventSync.Id} - Inserir")
                            End If

                            Dim Detalhes As List(Of InventarioDetalhesOnDTO) = InventDetalhesOnBLL.BuscarTodos()
                            If Detalhes IsNot Nothing Then
                                With RjProgressBar2
                                    .Visible = True
                                    .Value = 0
                                End With
                                Dim ContB As Long = 0
                                For Each Detalhe As InventarioDetalhesOnDTO In Detalhes
                                    LblMsgDescricao.Text = $"Bem Inventariado: {Detalhe.Id_Bem}"
                                    RjProgressBar2.Value = CInt((ContB / Detalhes.Count) * 100)
                                    Application.DoEvents()

                                    ' RECEBER INVENTÁRIO_DETALHES
                                    Dim IDetalhe As New InventarioDetalhesDTO With {
                                            .Id = Detalhe.Id,
                                            .Id_inventario = Detalhe.Id_inventario,
                                            .Id_Bem = Detalhe.Id_Bem,
                                            .Estado = Detalhe.Estado,
                                            .Acao = Detalhe.Acao,
                                            .Bem = Detalhe.Bem,
                                            .Id_dependencia = Detalhe.Id_dependencia,
                                            .Observacao = Detalhe.Observacao,
                                            .Contagem = Detalhe.Contagem
                                        }
                                    Dim InventDetalhe As InventarioDetalhesDTO = InventDetalhesBLL.BuscarPorId(Detalhe.Id_Bem)
                                    If InventDetalhe IsNot Nothing AndAlso InventDetalhe.Id_Bem <> "" Then
                                        Retorno = InventDetalhesBLL.Atualizar(IDetalhe)
                                        If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Inventário Detalhes {IDetalhe.Id} - Inserir")
                                    Else
                                        Retorno = InventDetalhesBLL.Inserir(IDetalhe)
                                        If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Inventário Detalhes {IDetalhe.Id} - Inserir")
                                    End If

                                    ' RECEBER BENS MÓVEIS
                                    Dim BemMovelLista As BensOnDTO = BensMoveisOnBLL.BuscarPorId(IDetalhe.Id_Bem)
                                    If BemMovelLista IsNot Nothing Then
                                        Dim Bem As New BensDTO With {
                                                    .Id = BemMovelLista.Id,
                                                    .Descricao = BemMovelLista.Descricao,
                                                    .Id_igreja = BemMovelLista.Id_igreja,
                                                    .Id_Dependencia = BemMovelLista.Id_Dependencia,
                                                    .Id_Status = BemMovelLista.Id_Status
                                                }


                                        Dim BemExiste As BensDTO = BensMoveisBLL.BuscarPorId(IDetalhe.Id_Bem)
                                        If BemExiste IsNot Nothing Then
                                            Retorno = BensMoveisBLL.Atualizar(Bem)
                                            If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Bem Móvel {Bem.Id} - Inserir")
                                        Else
                                            Retorno = BensMoveisBLL.Inserir(Bem)
                                            If (Retorno = 0) Then Log.WriteLog($"Falha: Receber Dados - Bem Móvel {Bem.Id} - Inserir")
                                        End If
                                    End If
                                    ContB += 1
                                Next
                                RjProgressBar2.Visible = False
                            End If
                            Application.DoEvents()
                            Item.Status = -1
                            SincBLL.Atualizar(Item)
                            AtualizarLabels()
                        End If

                        ContA += 1
                        LblMsgTitulo.Text = ""
                        LblMsgDescricao.ResetText()
                        AtualizarLabels()
                        Application.DoEvents()
                    Next
                    RjProgressBar1.Visible = False
                End If
#End Region

            End If
        Catch ex As Exception
            RJMessageBox.Show(ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log.WriteLog($"SINCRONIZAR | Receber Dados | {ex.Message}")
        Finally
            LblMsgTitulo.Text = "DADOS SINCRONIZADOS!"
            LblMsgDescricao.ResetText()
            RjProgressBar1.Visible = False
            RjProgressBar2.Visible = False
        End Try

        AtualizarLabels()
    End Sub
#End Region ' RECEBER DADOS

End Class