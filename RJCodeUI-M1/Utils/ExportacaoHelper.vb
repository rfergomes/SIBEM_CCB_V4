Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Module ExportacaoHelper

    ' Copia a célula selecionada para a área de transferência
    Public Sub CopiarCelulaParaClipboard(Dgv As DataGridView, Optional Indice As Integer = 0)
        If Dgv.SelectedCells.Count > 0 Then
            Dim valor As String = Dgv.SelectedCells(Indice).Value?.ToString()
            If Not String.IsNullOrEmpty(valor) Then
                Clipboard.SetText(valor)
                RJMessageBox.Show($"Valor [{valor}] copiado para a área de transferência!", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    ' Copia a linha inteira para a área de transferência
    Public Sub CopiarLinhaParaClipboard(Dgv As DataGridView)
        If Dgv.SelectedRows.Count > 0 Then
            Dim sb As New System.Text.StringBuilder()
            For Each celula As DataGridViewCell In Dgv.SelectedRows(0).Cells
                sb.Append(celula.Value?.ToString() & vbTab) ' Separa os valores por TAB
            Next
            Clipboard.SetText(sb.ToString().TrimEnd())
            RJMessageBox.Show("Linha copiada para a área de transferência!", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Copia todas as linhas do DataGridView
    Public Sub CopiarTudoParaClipboard(Dgv As DataGridView)
        If Dgv.Rows.Count > 0 Then
            Dim sb As New System.Text.StringBuilder()

            ' Copia os cabeçalhos
            For Each coluna As DataGridViewColumn In Dgv.Columns
                sb.Append(coluna.HeaderText & vbTab)
            Next
            sb.AppendLine()

            ' Copia os valores das células
            For Each linha As DataGridViewRow In Dgv.Rows
                For Each celula As DataGridViewCell In linha.Cells
                    sb.Append(celula.Value?.ToString() & vbTab)
                Next
                sb.AppendLine()
            Next

            Clipboard.SetText(sb.ToString().TrimEnd())
            RJMessageBox.Show("Todos os dados foram copiados!", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ''' <summary>
    ''' Exporta os dados do DataGridView para um arquivo Excel usando CreateObject.
    ''' </summary>
    ''' <param name="dgv">DataGridView com os dados.</param>
    Public Sub ExportarParaExcel(dgv As DataGridView)
        Try
            ' Criar aplicação Excel
            Dim xlApp As Object = CreateObject("Excel.Application")
            If xlApp Is Nothing Then
                RJMessageBox.Show("O Excel não está instalado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim xlWorkbook As Object = xlApp.Workbooks.Add
            Dim xlWorksheet As Object = xlWorkbook.Sheets(1)

            ' Adicionar cabeçalhos
            For i As Integer = 0 To dgv.Columns.Count - 1
                xlWorksheet.Cells(1, i + 1).Value = dgv.Columns(i).HeaderText
            Next

            ' Adicionar dados
            For i As Integer = 0 To dgv.Rows.Count - 1
                For j As Integer = 0 To dgv.Columns.Count - 1
                    xlWorksheet.Cells(i + 2, j + 1).Value = dgv.Rows(i).Cells(j).Value?.ToString()
                Next
            Next

            ' Autoajustar colunas
            xlWorksheet.Columns.AutoFit()

            ' Salvar arquivo
            Dim saveFileDialog As New SaveFileDialog With {
                .Filter = "Arquivos Excel (*.xlsx)|*.xlsx",
                .Title = "Salvar como"
            }
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                xlWorkbook.SaveAs(saveFileDialog.FileName)
                xlWorkbook.Close()
                xlApp.Quit()
                RJMessageBox.Show("Exportado para Excel com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Liberar objetos COM
            ReleaseObject(xlWorksheet)
            ReleaseObject(xlWorkbook)
            ReleaseObject(xlApp)

        Catch ex As Exception
            RJMessageBox.Show("Erro ao exportar para Excel: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Exporta os dados do DataGridView para um arquivo PDF.
    ''' </summary>
    ''' <param name="dgv">DataGridView com os dados.</param>
    Public Sub ExportarParaPDF(dgv As DataGridView)
        Try
            Dim saveFileDialog As New SaveFileDialog With {
                .Filter = "Arquivos PDF (*.pdf)|*.pdf",
                .Title = "Salvar como"
            }
            If saveFileDialog.ShowDialog() <> DialogResult.OK Then Exit Sub

            Dim doc As New Document(PageSize.A4.Rotate())
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName, FileMode.Create))
            doc.Open()

            ' Criar tabela com a mesma quantidade de colunas do DataGridView
            Dim pdfTable As New PdfPTable(dgv.Columns.Count)
            pdfTable.WidthPercentage = 100
            pdfTable.DefaultCell.Padding = 3
            pdfTable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT

            ' Adicionar cabeçalhos
            For Each coluna As DataGridViewColumn In dgv.Columns
                Dim cell As New PdfPCell(New Phrase(coluna.HeaderText))
                cell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdfTable.AddCell(cell)
            Next

            ' Adicionar dados
            For Each row As DataGridViewRow In dgv.Rows
                For Each cell As DataGridViewCell In row.Cells
                    pdfTable.AddCell(cell.Value?.ToString())
                Next
            Next

            doc.Add(pdfTable)
            doc.Close()
            writer.Close()

            RJMessageBox.Show("Exportado para PDF com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            RJMessageBox.Show("Erro ao exportar para PDF: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Exporta os dados do DataGridView para um arquivo TXT delimitado por ponto-e-vírgula.
    ''' </summary>
    ''' <param name="dgv">DataGridView com os dados.</param>
    Public Sub ExportarParaTXT(dgv As DataGridView)
        Try
            Dim saveFileDialog As New SaveFileDialog With {
                .Filter = "Arquivos TXT (*.txt)|*.txt",
                .Title = "Salvar como"
            }
            If saveFileDialog.ShowDialog() <> DialogResult.OK Then Exit Sub

            Using sw As New StreamWriter(saveFileDialog.FileName, False)
                ' Adicionar cabeçalhos
                Dim headers As String = String.Join(";", dgv.Columns.Cast(Of DataGridViewColumn).Select(Function(c) c.HeaderText))
                sw.WriteLine(headers)

                ' Adicionar dados
                For Each row As DataGridViewRow In dgv.Rows
                    Dim linha As String = String.Join(";", row.Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value?.ToString()))
                    sw.WriteLine(linha)
                Next
            End Using

            RJMessageBox.Show("Exportado para TXT com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            RJMessageBox.Show("Erro ao exportar para TXT: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Libera os objetos COM usados pelo Excel.
    ''' </summary>
    ''' <param name="obj">Objeto COM a ser liberado.</param>
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Module
