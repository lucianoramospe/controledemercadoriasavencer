Imports System.Data.OleDb

Public Class Form1
    ' Variável de conexão declarada dentro da classe
    Dim caminhoExcel As String = "C:\ControleMercadorias\Produtos.xlsx"
    Dim conexao As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & caminhoExcel & ";Extended Properties='Excel 12.0 Xml;HDR=YES'")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexao.Open()
            MessageBox.Show("Conexão com Excel estabelecida com sucesso!")
            conexao.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao conectar: " & ex.Message)
        End Try
    End Sub



    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
    Try
            Dim comando As New OleDbCommand("INSERT INTO [Plan1$] ([Código], [Nome do Produto], [Categoria], [Data de Validade], [Quantidade]) VALUES (?, ?, ?, ?, ?)", conexao)
            comando.Parameters.AddWithValue("?", txtCodigo.Text)
        comando.Parameters.AddWithValue("?", txtNome.Text)
        comando.Parameters.AddWithValue("?", txtCategoria.Text)
        comando.Parameters.AddWithValue("?", dtValidade.Value.ToShortDateString())
        comando.Parameters.AddWithValue("?", numQuantidade.Value)

        conexao.Open()
        comando.ExecuteNonQuery()
        conexao.Close()

        MessageBox.Show("Produto salvo com sucesso!")
        CarregarProdutos()
    Catch ex As Exception
        MessageBox.Show("Erro ao salvar: " & ex.Message)
    End Try
End Sub

Private Sub CarregarProdutos()
        Try
            Dim adaptador As New OleDbDataAdapter("SELECT * FROM [Plan1$]", conexao)
            Dim tabela As New DataTable()
            adaptador.Fill(tabela)
            dgvProdutos.DataSource = tabela
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar produtos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim produtosVencendo As New DataTable()
        produtosVencendo.Columns.Add("Código")
        produtosVencendo.Columns.Add("Nome")
        produtosVencendo.Columns.Add("Validade")

        For Each linha As DataGridViewRow In dgvProdutos.Rows
            If Not linha.IsNewRow Then
                Dim validade As Date = Date.Parse(linha.Cells("Data de Validade").Value.ToString())
                If validade <= Date.Today.AddDays(7) Then
                    produtosVencendo.Rows.Add(linha.Cells("Código").Value, linha.Cells("Nome do Produto").Value, validade.ToShortDateString())
                End If
            End If
        Next

        dgvProdutos.DataSource = produtosVencendo
    End Sub

End Class
