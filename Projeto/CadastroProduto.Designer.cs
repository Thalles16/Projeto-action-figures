namespace Projeto
{
    partial class CadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            lblNome = new Label();
            txtNome = new TextBox();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblPreco = new Label();
            txtPreco = new TextBox();
            lblEstoque = new Label();
            txtEstoque = new TextBox();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            dgvProdutos = new DataGridView();
            lblImagem = new Label();
            pictureBoxProduto = new PictureBox();
            txtImagemUrl = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduto).BeginInit();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            lblNome.Location = new Point(39, 313);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(58, 18);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(138, 313);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(288, 23);
            txtNome.TabIndex = 1;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            lblDescricao.Location = new Point(39, 349);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(88, 18);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(138, 349);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(288, 23);
            txtDescricao.TabIndex = 3;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            lblPreco.Location = new Point(40, 391);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(57, 18);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(138, 386);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(288, 23);
            txtPreco.TabIndex = 5;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            lblEstoque.Location = new Point(39, 427);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(76, 18);
            lblEstoque.TabIndex = 6;
            lblEstoque.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(138, 427);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(288, 23);
            txtEstoque.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 14.25F);
            btnSalvar.Location = new Point(206, 477);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 34);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 14.25F);
            btnEditar.Location = new Point(90, 477);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 34);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 14.25F);
            btnExcluir.Location = new Point(326, 477);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(111, 34);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(476, 39);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.Size = new Size(527, 411);
            dgvProdutos.TabIndex = 11;
            dgvProdutos.CellContentClick += dgvProdutos_CellClick;
            // 
            // lblImagem
            // 
            lblImagem.AutoSize = true;
            lblImagem.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic);
            lblImagem.Location = new Point(38, 279);
            lblImagem.Name = "lblImagem";
            lblImagem.Size = new Size(73, 18);
            lblImagem.TabIndex = 12;
            lblImagem.Text = "Imagem:";
            // 
            // pictureBoxProduto
            // 
            pictureBoxProduto.Location = new Point(155, 39);
            pictureBoxProduto.Name = "pictureBoxProduto";
            pictureBoxProduto.Size = new Size(249, 197);
            pictureBoxProduto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProduto.TabIndex = 13;
            pictureBoxProduto.TabStop = false;
            // 
            // txtImagemUrl
            // 
            txtImagemUrl.Location = new Point(138, 274);
            txtImagemUrl.Name = "txtImagemUrl";
            txtImagemUrl.Size = new Size(288, 23);
            txtImagemUrl.TabIndex = 14;
            txtImagemUrl.TextChanged += txtImagemUrl_TextChanged;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 524);
            Controls.Add(txtImagemUrl);
            Controls.Add(pictureBoxProduto);
            Controls.Add(lblImagem);
            Controls.Add(dgvProdutos);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(txtEstoque);
            Controls.Add(lblEstoque);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroProduto";
            Load += CadastroProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblPreco;
        private TextBox txtPreco;
        private Label lblEstoque;
        private TextBox txtEstoque;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private DataGridView dgvProdutos;
        private Label lblImagem;
        private PictureBox pictureBoxProduto;
        private TextBox txtImagemUrl;
    }
}