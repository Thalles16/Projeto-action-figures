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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha a aplicação toda
        }

        private void menuCadastro_Click(object sender, EventArgs e)
        {
            // Aqui você pode abrir o formulário de cadastro de produtos
            CadastroProduto form = new CadastroProduto(); // será criado em breve
            form.Show();
        }

        private void consultaDeCEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCep consultaCep = new frmConsultaCep();
            consultaCep.ShowDialog();
        }
    }
}
