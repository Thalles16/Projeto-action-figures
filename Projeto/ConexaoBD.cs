using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto
{
    class ConexaoBD
    {
        // String de conexão com o banco de dados
        private string conexaoBanco = "Server=localhost; Database=loja_actionfigures; Uid=root; Pwd=;";

        // Método para abrir e retornar a conexão
        public MySqlConnection Conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);
            conexao.Open();
            return conexao;
        }
    }
}
