using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }
        int produtoSelecionadoId = -1;

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtPreco.Text = "";
            txtEstoque.Text = "";
            txtImagemUrl.Text = "";
            pictureBoxProduto.Image = null;
        }
        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            ProdutoDAO dao = new ProdutoDAO();
            dgvProdutos.DataSource = dao.Listar();
        }



        private void txtImagemUrl_TextChanged(object sender, EventArgs e)
        {


            try
            {
                pictureBoxProduto.Load(txtImagemUrl.Text);
            }
            catch
            {
                pictureBoxProduto.Image = null; // Limpa se der erro
            }
        }
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProdutos.Rows[e.RowIndex];

                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtDescricao.Text = row.Cells["descricao"].Value.ToString();
                txtPreco.Text = row.Cells["preco"].Value.ToString();
                txtEstoque.Text = row.Cells["estoque"].Value.ToString();
                

                // Armazena o ID em uma variável global (crie no início da classe)
                produtoSelecionadoId = Convert.ToInt32(row.Cells["id"].Value);
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto
                {
                    Nome = txtNome.Text,
                    Descricao = txtDescricao.Text,
                    Preco = decimal.Parse(txtPreco.Text),
                    Estoque = int.Parse(txtEstoque.Text),
                    ImagemUrl = txtImagemUrl.Text
                };

                ProdutoDAO dao = new ProdutoDAO();
                dao.Inserir(produto);

                MessageBox.Show("Produto cadastrado com sucesso!");
                LimparCampos();
                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (produtoSelecionadoId == -1)
            {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }

            try
            {
                Produto produto = new Produto
                {
                    Id = produtoSelecionadoId,
                    Nome = txtNome.Text,
                    Descricao = txtDescricao.Text,
                    Preco = decimal.Parse(txtPreco.Text),
                    Estoque = int.Parse(txtEstoque.Text),
                    ImagemUrl = txtImagemUrl.Text
                };

                ProdutoDAO dao = new ProdutoDAO();
                dao.Atualizar(produto);

                MessageBox.Show("Produto atualizado com sucesso!");
                LimparCampos();
                CarregarProdutos();
                produtoSelecionadoId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (produtoSelecionadoId == -1)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    ProdutoDAO dao = new ProdutoDAO();
                    dao.Excluir(produtoSelecionadoId);

                    MessageBox.Show("Produto excluído com sucesso!");
                    LimparCampos();
                    CarregarProdutos();
                    produtoSelecionadoId = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }
    }
}

