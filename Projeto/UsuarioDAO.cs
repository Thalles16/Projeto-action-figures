using MySql.Data.MySqlClient;
using System;

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
            conn.Close();

            return autenticado;
        }
    }
} 