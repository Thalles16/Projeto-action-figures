using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Projeto
{
    public class ProdutoDAO
    {
        private ConexaoBD conexao = new ConexaoBD();

        public void Inserir(Produto p)
        {
            var conn = conexao.Conectar();
            string sql = "INSERT INTO produtos (nome, descricao, preco, estoque, imagem_url) VALUES (@nome, @descricao, @preco, @estoque, @imagem_url)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@descricao", p.Descricao);
            cmd.Parameters.AddWithValue("@preco", p.Preco);
            cmd.Parameters.AddWithValue("@estoque", p.Estoque);
            cmd.Parameters.AddWithValue("@imagem_url", p.ImagemUrl);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Produto> Listar()
        {
            var lista = new List<Produto>();
            var conn = conexao.Conectar();
            string sql = "SELECT * FROM produtos";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Produto p = new Produto();
                p.Id = Convert.ToInt32(reader["id"]);
                p.Nome = reader["nome"].ToString();
                p.Descricao = reader["descricao"].ToString();
                p.Preco = Convert.ToDecimal(reader["preco"]);
                p.Estoque = Convert.ToInt32(reader["estoque"]);
                p.ImagemUrl = reader["imagem_url"].ToString();

                lista.Add(p);
            }
            conn.Close();
            return lista;
        }

        public void Atualizar(Produto p)
        {
            var conn = conexao.Conectar();
            string sql = "UPDATE produtos SET nome=@nome, descricao=@descricao, preco=@preco, estoque=@estoque, imagem_url=@imagem_url WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", p.Nome);
            cmd.Parameters.AddWithValue("@descricao", p.Descricao);
            cmd.Parameters.AddWithValue("@preco", p.Preco);
            cmd.Parameters.AddWithValue("@estoque", p.Estoque);
            cmd.Parameters.AddWithValue("@id", p.Id);
            cmd.Parameters.AddWithValue("@imagem_url", p.ImagemUrl);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Excluir(int id)
        {
            var conn = conexao.Conectar();
            string sql = "DELETE FROM produtos WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
