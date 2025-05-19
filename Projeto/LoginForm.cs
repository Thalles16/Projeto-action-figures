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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            Usuario usuario = new Usuario();
            usuario.Email = email;
            usuario.Senha = senha;

            UsuarioDAO dao = new UsuarioDAO();
            dao.Inserir(usuario); // método que você deve ter no UsuarioDAO

            MessageBox.Show("Cadastro realizado com sucesso!");

            this.Hide(); // Fecha esta tela
            Form1 telaLogin = new Form1(); // Abre o Form1 (tela de login)
            telaLogin.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Sua lógica de login aqui
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            Usuario usuario = new Usuario();
            usuario.Email = email;
            usuario.Senha = senha;

            UsuarioDAO dao = new UsuarioDAO();
            dao.Inserir(usuario); // método que você deve ter no UsuarioDAO

            MessageBox.Show("Cadastro realizado com sucesso!");

            this.Hide(); // Fecha esta tela
            Form1 telaLogin = new Form1(); // Abre o Form1 (tela de login)
            telaLogin.Show();
        }
    }
}
    

