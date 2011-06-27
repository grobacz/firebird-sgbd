using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using Data.Classes;
using System.Windows.Forms;
using System.Data;

namespace Data
{
    public class FilmeDAO : IFilmeDAO
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

        public void preencherDataGridView(DataGridView dgvFilmes)
        {
            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "SELECT codigo, nome, preco, genero, ano_lancamento, imagem FROM filme;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            FbDataReader dr = comando.ExecuteReader();

            int nColunas = dr.FieldCount;

            for (int i = 0; i < nColunas; i++)
            {
                if (!dr.GetName(i).ToString().Equals("IMAGEM"))
                {
                    dgvFilmes.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
                    dgvFilmes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }

            string[] linhaDados = new string[nColunas];

            while (dr.Read())
            {
                //percorre cada uma das colunas
                for (int a = 0; a < nColunas; a++)
                {
                    if (dr.GetFieldType(a).ToString() == "System.Int32")
                    {
                        linhaDados[a] = dr.GetInt32(a).ToString();
                    }
                    if (dr.GetFieldType(a).ToString() == "System.String")
                    {
                        linhaDados[a] = dr.GetString(a).ToString();
                    }
                    if (dr.GetFieldType(a).ToString() == "System.Decimal")
                    {
                        linhaDados[a] = dr.GetString(a).ToString();
                    }
                }

                //atribui a linha ao datagridview
                dgvFilmes.Rows.Add(linhaDados);
            }

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

        public Filme Recuperar(int codigo)
        {
            Filme filme = null;

            FbConnection conexao = Connection.Instance.GetConnection();

            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "SELECT codigo, nome, preco, genero, ano_lancamento, imagem FROM filme WHERE codigo = @codigo;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@codigo", codigo);

            FbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                filme = new Filme()
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

            }

            conexao.Close();

            return filme;
        }

        public void Remover(int codigo)
        {
            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "DELETE FROM filme WHERE codigo = @codigo;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@codigo", codigo);

            comando.ExecuteNonQuery();
            transacao.Commit();

            conexao.Close();
        }


        public Filme Recuperar(int codigo, FbConnection conexao, FbTransaction transacao)
        {
            Filme filme = null;

            string sql = "SELECT codigo, nome, preco, genero, ano_lancamento, imagem FROM filme WHERE codigo = @codigo;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@codigo", codigo);

            FbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                filme = new Filme()
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

            }

            return filme;
        }
    }
}
