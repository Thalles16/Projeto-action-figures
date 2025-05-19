using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            try
            {
                ConexaoBD conexaoBD = new ConexaoBD();
                MySqlConnection conexao = conexaoBD.Conectar();

                string query = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha); // Hash depois!

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login realizado com sucesso!");

                    // Abre a tela principal e fecha a de login
                    Form menu = new MenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos.");
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
