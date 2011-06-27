using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using Data.Classes;

namespace Data
{
    public class LocacaoDAO : ILocacaoDAO
    {
        #region ILocacaoDAO Members

        public void Atualizar(int codigo, int status)
        {
            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "UPDATE locacao SET status = @status WHERE codigo = @codigo;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@status", status);
            comando.Parameters.AddWithValue("@codigo", codigo);

            comando.ExecuteNonQuery();
            transacao.Commit();

            conexao.Close();
        }

        public void Inserir(string cpfCliente, IList<int> codigoFilmes)
        {
            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string insertSql = "INSERT INTO locacao (codigo, cpf_cliente, codigo_filme, status) VALUES (@codigo, @cpf, @codigoFilme, @status);";

            int codigoLocacao = ProximoCodigo(conexao);

            foreach (int codigo in codigoFilmes)
            {
                FbCommand comando = new FbCommand(insertSql, conexao, transacao);
                comando.Parameters.AddWithValue("@codigo", codigoLocacao);
                comando.Parameters.AddWithValue("@cpf", cpfCliente);
                comando.Parameters.AddWithValue("@codigoFilme", codigo);
                comando.Parameters.AddWithValue("@status", Status.Pendente);

                comando.ExecuteNonQuery();
            }

            transacao.Commit();

            conexao.Close();
        }

        public IList<Locacao> Listar()
        {
            //IList<Locacao> filmes = new List<Locacao>();

            //FbConnection conexao = Connection.Instance.GetConnection();
            //conexao.Open();

            //FbTransaction transacao = conexao.BeginTransaction();

            //string sql = "SELECT codigo, cpf_cliente, codigo_filme, genero, ano_lancamento, imagem FROM filme;";

            //FbCommand comando = new FbCommand(sql, conexao, transacao);
            //FbDataReader reader = comando.ExecuteReader();

            //while (reader.Read())
            //{
            //    Filme filme = new Filme()
            //    {
            //        Codigo = reader.GetInt32(0),
            //        Nome = reader.GetString(1),
            //        Preco = reader.GetDecimal(2),
            //        Genero = reader.GetString(3),
            //        Ano = reader.GetInt32(4),
            //    };

            //    if (!reader.IsDBNull(5))
            //    {
            //        filme.Imagem = (byte[])reader["imagem"];
            //    }

            //    filmes.Add(filme);

            //}

            //conexao.Close();

            return null;
        }

        public Locacao Recuperar(string codigo)
        {
            throw new NotImplementedException();
        }

        public void Remover(string codigo)
        {
            throw new NotImplementedException();
        }

        #endregion

        private int ProximoCodigo(FbConnection conexao)
        {
            int retorno = 1;

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "SELECT MAX(codigo) as codigo from LOCACAO;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);

            FbDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    retorno = reader.GetInt32(0) + 1;
                }
            }

            return retorno;
        }

        //private Cliente Cliente(int codigo, FbConnection conexao)
        //{

        //}
    }
}
