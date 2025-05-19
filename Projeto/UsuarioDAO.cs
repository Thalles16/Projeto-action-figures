using MySql.Data.MySqlClient;

namespace Projeto
{
    public class UsuarioDAO
    {
        private ConexaoBD conexao = new ConexaoBD();

        public bool Autenticar(string email, string senha)
        {
            var conn = conexao.Conectar();
            string sql = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            MySqlDataReader reader = cmd.ExecuteReader();

            bool autenticado = reader.HasRows;
            reader.Close();
            conexao.Desconectar();

            return autenticado;
        }

        public void Inserir(Usuario usuario)
        {
            var conn = conexao.Conectar();
            string sql = "INSERT INTO usuarios (email, senha) VALUES (@email, @senha)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();
        }
    }
}
