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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            UsuarioDAO dao = new UsuarioDAO();

            if (dao.Autenticar(email, senha))
            {
                MessageBox.Show("Login realizado com sucesso!");
                this.Hide();
                MenuPrincipal menu = new MenuPrincipal();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }
    }
}
