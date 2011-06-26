using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using Data.Classes;

namespace Data
{
    public class FilmeDAO
    {
        public void Inserir(string nome, decimal preco, string genero, int ano, byte[] imagem)
        {
            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string insertSql = "INSERT INTO filme (nome, preco, genero, ano_lancamento, imagem) VALUES (@nome, @preco, @genero, @ano, @imagem);";

            FbCommand comando = new FbCommand(insertSql, conexao, transacao);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@preco", preco);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@ano", ano);
            comando.Parameters.AddWithValue("@imagem", imagem);

            comando.ExecuteNonQuery();
            transacao.Commit();

            conexao.Close();

        }

        public void Atualizar(int codigo, string nome, decimal preco, string genero, int ano, byte[] imagem)
        {
            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "UPDATE filme SET nome = @nome, preco = @preco, genero = @genero, ano_lancamento = @ano, imagem = @imagem WHERE codigo = @codigo;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@preco", preco);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@ano", ano);
            comando.Parameters.AddWithValue("@imagem", imagem);

            comando.ExecuteNonQuery();
            transacao.Commit();

            conexao.Close();
        }

        public IList<Filme> Listar()
        {
            IList<Filme> filmes = new List<Filme>();

            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "SELECT codigo, nome, preco, genero, ano_lancamento, imagem FROM filme;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            FbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Filme filme = new Filme()
                {
                    Codigo = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Preco = reader.GetDecimal(2),
                    Genero = reader.GetString(3),
                    Ano = reader.GetInt32(4),
                };

                if (!reader.IsDBNull(5))
                {
                    filme.Imagem = (byte[])reader["imagem"];
                }

                filmes.Add(filme);

            }

            conexao.Close();

            return filmes;
        }

    }
}
