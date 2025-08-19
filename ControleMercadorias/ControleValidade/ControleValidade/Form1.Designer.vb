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
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.dtValidade = New System.Windows.Forms.DateTimePicker()
        Me.numQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        CType(Me.numQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(857, 93)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Controle de Validade"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(40, 190)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(265, 26)
        Me.txtCodigo.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(379, 190)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(248, 26)
        Me.txtNome.TabIndex = 2
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(699, 189)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(230, 26)
        Me.txtCategoria.TabIndex = 3
        '
        'dtValidade
        '
        Me.dtValidade.Location = New System.Drawing.Point(155, 267)
        Me.dtValidade.Name = "dtValidade"
        Me.dtValidade.Size = New System.Drawing.Size(265, 26)
        Me.dtValidade.TabIndex = 7
        '
        'numQuantidade
        '
        Me.numQuantidade.Location = New System.Drawing.Point(525, 267)
        Me.numQuantidade.Name = "numQuantidade"
        Me.numQuantidade.Size = New System.Drawing.Size(248, 26)
        Me.numQuantidade.TabIndex = 8
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(283, 321)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(137, 62)
        Me.btnSalvar.TabIndex = 9
        Me.btnSalvar.Text = "Salvar Produto"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(525, 321)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(133, 62)
        Me.btnVerificar.TabIndex = 10
        Me.btnVerificar.Text = "Verificar Vencimentos"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'dgvProdutos
        '
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Location = New System.Drawing.Point(69, 415)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.RowHeadersWidth = 62
        Me.dgvProdutos.RowTemplate.Height = 28
        Me.dgvProdutos.Size = New System.Drawing.Size(860, 89)
        Me.dgvProdutos.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 531)
        Me.Controls.Add(Me.dgvProdutos)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.numQuantidade)
        Me.Controls.Add(Me.dtValidade)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Mercadinho"
        CType(Me.numQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents dtValidade As DateTimePicker
    Friend WithEvents numQuantidade As NumericUpDown
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnVerificar As Button
    Friend WithEvents dgvProdutos As DataGridView
End Class
