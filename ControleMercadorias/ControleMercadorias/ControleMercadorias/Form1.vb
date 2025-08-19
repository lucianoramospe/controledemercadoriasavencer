Imports System.Data.OleDb

Public Class Form1
    Dim caminhoExcel As String = "C:\ControleMercadorias\Produtos.xlsx"
    Dim conexao As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & caminhoExcel & ";Extended Properties='Excel 12.0 Xml;HDR=YES'")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDados()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub CarregarDados()
        Dim adaptador As New OleDbDataAdapter("SELECT * FROM [Plan1$] WHERE Status IS NULL OR Status <> 'Excluído'", conexao)
        Dim tabela As New DataTable()
        adaptador.Fill(tabela)
        dgvProdutos.DataSource = tabela

    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btncadastrar.Click
        Try
            If String.IsNullOrWhiteSpace(txtCodigo.Text) OrElse
           String.IsNullOrWhiteSpace(txtNome.Text) OrElse
           String.IsNullOrWhiteSpace(txtCategoria.Text) OrElse
           String.IsNullOrWhiteSpace(txtLote.Text) Then

                MessageBox.Show("Preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If numQuantidade.Value <= 0 Then
                MessageBox.Show("A quantidade deve ser maior que zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim validade As Date = dtValidade.Value
            If validade < Date.Today Then
                Dim resposta = MessageBox.Show("A data de validade já passou. Deseja continuar?", "Validade vencida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resposta = DialogResult.No Then Exit Sub
            End If

            If ProdutoExiste(txtCodigo.Text) Then
                MessageBox.Show("Já existe um produto com esse código. Use o botão Atualizar.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim comando As New OleDbCommand("INSERT INTO [Plan1$] (Código, Nome, Categoria, Validade, Quantidade, Lote) VALUES (?, ?, ?, ?, ?, ?)", conexao)

            comando.Parameters.AddWithValue("?", txtCodigo.Text)
            comando.Parameters.AddWithValue("?", txtNome.Text)
            comando.Parameters.AddWithValue("?", txtCategoria.Text)
            comando.Parameters.AddWithValue("?", validade.ToShortDateString())
            comando.Parameters.AddWithValue("?", numQuantidade.Value.ToString())
            comando.Parameters.AddWithValue("?", txtLote.Text)

            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()

            MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CarregarDados()

        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conexao.State = ConnectionState.Open Then conexao.Close()
        End Try
    End Sub



    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Try
            ' Validação dos campos obrigatórios
            If String.IsNullOrWhiteSpace(txtCodigo.Text) OrElse
           String.IsNullOrWhiteSpace(txtNome.Text) OrElse
           String.IsNullOrWhiteSpace(txtCategoria.Text) OrElse
           String.IsNullOrWhiteSpace(txtLote.Text) Then

                MessageBox.Show("Preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Validação da quantidade
            If numQuantidade.Value <= 0 Then
                MessageBox.Show("A quantidade deve ser maior que zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Validação da data
            Dim validade As Date = dtValidade.Value
            If validade < Date.Today Then
                Dim resposta = MessageBox.Show("A data de validade já passou. Deseja continuar?", "Validade vencida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resposta = DialogResult.No Then Exit Sub
            End If

            ' Comando de atualização
            Dim comando As New OleDbCommand("UPDATE [Plan1$] SET Nome=?, Categoria=?, Validade=?, Quantidade=?, Lote=? WHERE Código=?", conexao)

            comando.Parameters.AddWithValue("?", txtNome.Text)
            comando.Parameters.AddWithValue("?", txtCategoria.Text)
            comando.Parameters.AddWithValue("?", validade.ToShortDateString())
            comando.Parameters.AddWithValue("?", numQuantidade.Value.ToString())
            comando.Parameters.AddWithValue("?", txtLote.Text)
            comando.Parameters.AddWithValue("?", txtCodigo.Text)

            conexao.Open()
            Dim linhasAfetadas As Integer = comando.ExecuteNonQuery()
            conexao.Close()

            If linhasAfetadas > 0 Then
                MessageBox.Show("Produto atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CarregarDados()
            Else
                MessageBox.Show("Produto não encontrado. Verifique o código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conexao.State = ConnectionState.Open Then conexao.Close()
        End Try
    End Sub




    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If String.IsNullOrWhiteSpace(txtCodigo.Text) Then
                MessageBox.Show("Informe o código do produto que deseja excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim comando As New OleDbCommand("UPDATE [Plan1$] SET Status=? WHERE Código=?", conexao)
            comando.Parameters.AddWithValue("?", "Excluído")
            comando.Parameters.AddWithValue("?", txtCodigo.Text)

            conexao.Open()
            Dim linhasAfetadas As Integer = comando.ExecuteNonQuery()
            conexao.Close()

            If linhasAfetadas > 0 Then
                MessageBox.Show("Produto marcado como excluído!", "Exclusão lógica", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CarregarDados()
            Else
                MessageBox.Show("Produto não encontrado. Verifique o código.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conexao.State = ConnectionState.Open Then conexao.Close()
        End Try
    End Sub




    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles numQuantidade.ValueChanged

    End Sub



    Private Sub dgvProdutos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProdutos.CellFormatting
        For Each linha As DataGridViewRow In dgvProdutos.Rows
            ' Verifica se a célula existe e não é nula
            If linha.Cells("Validade").Value IsNot Nothing AndAlso Not String.IsNullOrEmpty(linha.Cells("Validade").Value.ToString()) Then
                Dim validadeStr As String = linha.Cells("Validade").Value.ToString()
                Dim validade As Date

                If Date.TryParse(validadeStr, validade) Then
                    Dim diasRestantes As Integer = (validade - Date.Today).Days

                    If diasRestantes < 0 Then
                        ' 🔴 Vencido
                        linha.DefaultCellStyle.BackColor = Color.Red
                        linha.DefaultCellStyle.ForeColor = Color.Black
                    ElseIf diasRestantes = 0 Then
                        ' 🟡 Vence hoje
                        linha.DefaultCellStyle.BackColor = Color.Yellow
                        linha.DefaultCellStyle.ForeColor = Color.Black
                    ElseIf diasRestantes <= 10 Then
                        ' 🟠 A vencer em até 10 dias
                        linha.DefaultCellStyle.BackColor = Color.Orange
                        linha.DefaultCellStyle.ForeColor = Color.Black
                    Else
                        ' 🟢 Em dia
                        linha.DefaultCellStyle.BackColor = Color.LightGreen
                        linha.DefaultCellStyle.ForeColor = Color.Black
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub dgvProdutos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdutos.CellClick
        If e.RowIndex >= 0 Then
            Dim linha As DataGridViewRow = dgvProdutos.Rows(e.RowIndex)
            txtCodigo.Text = linha.Cells("Código").Value.ToString()
            txtNome.Text = linha.Cells("Nome").Value.ToString()
            txtCategoria.Text = linha.Cells("Categoria").Value.ToString()
            dtValidade.Value = Convert.ToDateTime(linha.Cells("Validade").Value)
            numQuantidade.Value = Convert.ToInt32(linha.Cells("Quantidade").Value)
            txtLote.Text = linha.Cells("Lote").Value.ToString()
        End If
    End Sub

    Private Sub btnVencidos_Click(sender As Object, e As EventArgs) Handles btnVencidos.Click
        FiltrarPorValidade(Function(v) v < Date.Today)
    End Sub

    Private Sub FiltrarPorValidade(condicao As Func(Of Date, Boolean))
        Try
            Dim adaptador As New OleDbDataAdapter("SELECT * FROM [Plan1$]", conexao)
            Dim tabela As New DataTable()
            adaptador.Fill(tabela)

            Dim filtrados As New DataTable()
            filtrados.Columns.Add("Código")
            filtrados.Columns.Add("Nome")
            filtrados.Columns.Add("Categoria")
            filtrados.Columns.Add("Validade")
            filtrados.Columns.Add("Quantidade")

            For Each linha As DataRow In tabela.Rows
                If Not IsDBNull(linha("Validade")) Then
                    Dim validade As Date
                    If Date.TryParse(linha("Validade").ToString(), validade) Then
                        If condicao(validade) Then
                            filtrados.Rows.Add(linha("Código"), linha("Nome"), linha("Categoria"), validade.ToShortDateString(), linha("Quantidade"))
                        End If
                    End If
                End If
            Next

            dgvProdutos.DataSource = filtrados
            Call dgvProdutos_CellFormatting(Nothing, Nothing)

            If filtrados.Rows.Count = 0 Then
                MessageBox.Show("Nenhum produto encontrado à vencer nos próximos 10 dias.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao filtrar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHoje_Click(sender As Object, e As EventArgs) Handles btnHoje.Click
        FiltrarPorValidade(Function(v) v = Date.Today)
    End Sub

    Private Sub btnAvence_Click(sender As Object, e As EventArgs) Handles btnAvence.Click
        FiltrarPorValidade(Function(v) v > Date.Today AndAlso v <= Date.Today.AddDays(10))
    End Sub

    Private Sub btnEmDia_Click(sender As Object, e As EventArgs) Handles btnEmDia.Click
        FiltrarPorValidade(Function(v) v > Date.Today.AddDays(10))
    End Sub

    Private Sub dgvProdutos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdutos.CellContentClick

    End Sub

    Private Sub btnMostrarExcluidos_Click(sender As Object, e As EventArgs) Handles btnMostrarExcluidos.Click
        Try
            Dim adaptador As New OleDbDataAdapter("SELECT * FROM [Plan1$] WHERE Status='Excluído'", conexao)
            Dim tabelaExcluidos As New DataTable()
            adaptador.Fill(tabelaExcluidos)

            dgvProdutos.DataSource = tabelaExcluidos
            Call dgvProdutos_CellFormatting(Nothing, Nothing)

            If tabelaExcluidos.Rows.Count = 0 Then
                MessageBox.Show("Nenhum produto excluído encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar produtos excluídos: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ProdutoExiste(codigo As String) As Boolean
        Try
            Dim comando As New OleDbCommand("SELECT COUNT(*) FROM [Plan1$] WHERE Código=?", conexao)
            comando.Parameters.AddWithValue("?", codigo)

            conexao.Open()
            Dim resultado As Integer = Convert.ToInt32(comando.ExecuteScalar())
            conexao.Close()

            Return resultado > 0
        Catch ex As Exception
            MessageBox.Show("Erro ao verificar produto: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If conexao.State = ConnectionState.Open Then conexao.Close()
            Return False
        End Try
    End Function

End Class


