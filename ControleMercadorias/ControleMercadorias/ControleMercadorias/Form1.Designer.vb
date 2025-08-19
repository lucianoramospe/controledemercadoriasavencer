<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.dtValidade = New System.Windows.Forms.DateTimePicker()
        Me.numQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.btncadastrar = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.btnVencidos = New System.Windows.Forms.Button()
        Me.btnHoje = New System.Windows.Forms.Button()
        Me.btnAvence = New System.Windows.Forms.Button()
        Me.btnEmDia = New System.Windows.Forms.Button()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnMostrarExcluidos = New System.Windows.Forms.Button()
        CType(Me.numQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(990, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Validade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 37)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Categoria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(990, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 37)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Quantidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Playground", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(470, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(906, 79)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ALERTA DE VENCIMENTO"
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(227, 172)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(511, 44)
        Me.txtCodigo.TabIndex = 6
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(227, 253)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(511, 44)
        Me.txtNome.TabIndex = 7
        '
        'txtCategoria
        '
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Location = New System.Drawing.Point(267, 336)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(471, 44)
        Me.txtCategoria.TabIndex = 8
        '
        'dtValidade
        '
        Me.dtValidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtValidade.Location = New System.Drawing.Point(1235, 166)
        Me.dtValidade.Name = "dtValidade"
        Me.dtValidade.Size = New System.Drawing.Size(510, 44)
        Me.dtValidade.TabIndex = 10
        '
        'numQuantidade
        '
        Me.numQuantidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numQuantidade.Location = New System.Drawing.Point(1235, 240)
        Me.numQuantidade.Name = "numQuantidade"
        Me.numQuantidade.Size = New System.Drawing.Size(510, 44)
        Me.numQuantidade.TabIndex = 11
        '
        'btncadastrar
        '
        Me.btncadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncadastrar.Location = New System.Drawing.Point(604, 425)
        Me.btncadastrar.Name = "btncadastrar"
        Me.btncadastrar.Size = New System.Drawing.Size(198, 58)
        Me.btncadastrar.TabIndex = 12
        Me.btncadastrar.Text = "CADASTRAR"
        Me.btncadastrar.UseVisualStyleBackColor = False
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAtualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.Location = New System.Drawing.Point(867, 425)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(198, 58)
        Me.btnAtualizar.TabIndex = 13
        Me.btnAtualizar.Text = "ATUALIZAR"
        Me.btnAtualizar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Location = New System.Drawing.Point(1127, 425)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(198, 58)
        Me.btnExcluir.TabIndex = 14
        Me.btnExcluir.Text = "EXCLUIR"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'dgvProdutos
        '
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(335, 652)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.RowHeadersWidth = 62
        Me.dgvProdutos.RowTemplate.Height = 28
        Me.dgvProdutos.Size = New System.Drawing.Size(1265, 335)
        Me.dgvProdutos.TabIndex = 15
        '
        'btnVencidos
        '
        Me.btnVencidos.BackColor = System.Drawing.Color.Red
        Me.btnVencidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVencidos.Location = New System.Drawing.Point(336, 505)
        Me.btnVencidos.Name = "btnVencidos"
        Me.btnVencidos.Size = New System.Drawing.Size(237, 100)
        Me.btnVencidos.TabIndex = 17
        Me.btnVencidos.Text = "Produtos Vencidos"
        Me.btnVencidos.UseVisualStyleBackColor = False
        '
        'btnHoje
        '
        Me.btnHoje.BackColor = System.Drawing.Color.Yellow
        Me.btnHoje.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoje.Location = New System.Drawing.Point(593, 505)
        Me.btnHoje.Name = "btnHoje"
        Me.btnHoje.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.btnHoje.Size = New System.Drawing.Size(237, 100)
        Me.btnHoje.TabIndex = 18
        Me.btnHoje.Text = "Vencem Hoje"
        Me.btnHoje.UseVisualStyleBackColor = False
        '
        'btnAvence
        '
        Me.btnAvence.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAvence.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvence.Location = New System.Drawing.Point(849, 505)
        Me.btnAvence.Name = "btnAvence"
        Me.btnAvence.Size = New System.Drawing.Size(237, 100)
        Me.btnAvence.TabIndex = 19
        Me.btnAvence.Text = "À Vencer"
        Me.btnAvence.UseVisualStyleBackColor = False
        '
        'btnEmDia
        '
        Me.btnEmDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEmDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmDia.Location = New System.Drawing.Point(1111, 505)
        Me.btnEmDia.Name = "btnEmDia"
        Me.btnEmDia.Size = New System.Drawing.Size(237, 100)
        Me.btnEmDia.TabIndex = 20
        Me.btnEmDia.Text = "Em Dia"
        Me.btnEmDia.UseVisualStyleBackColor = False
        '
        'txtLote
        '
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(1235, 334)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(510, 39)
        Me.txtLote.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(997, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 32)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Lote"
        '
        'btnMostrarExcluidos
        '
        Me.btnMostrarExcluidos.BackColor = System.Drawing.Color.Magenta
        Me.btnMostrarExcluidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarExcluidos.Location = New System.Drawing.Point(1363, 505)
        Me.btnMostrarExcluidos.Name = "btnMostrarExcluidos"
        Me.btnMostrarExcluidos.Size = New System.Drawing.Size(237, 100)
        Me.btnMostrarExcluidos.TabIndex = 24
        Me.btnMostrarExcluidos.Text = "Mostrar Excluídos"
        Me.btnMostrarExcluidos.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1699, 771)
        Me.Controls.Add(Me.btnMostrarExcluidos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLote)
        Me.Controls.Add(Me.btnEmDia)
        Me.Controls.Add(Me.btnAvence)
        Me.Controls.Add(Me.btnHoje)
        Me.Controls.Add(Me.btnVencidos)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btncadastrar)
        Me.Controls.Add(Me.numQuantidade)
        Me.Controls.Add(Me.dtValidade)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Mercadinho Alves"
        CType(Me.numQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents dtValidade As DateTimePicker
    Friend WithEvents numQuantidade As NumericUpDown
    Friend WithEvents btncadastrar As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents dgvProdutos As DataGridView
    Friend WithEvents btnVencidos As Button
    Friend WithEvents btnHoje As Button
    Friend WithEvents btnAvence As Button
    Friend WithEvents btnEmDia As Button
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnMostrarExcluidos As Button
End Class
