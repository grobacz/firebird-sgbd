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
        private FilmeDAO _filmeDao;
        private ClienteDAO _clienteDao;

        public LocacaoDAO()
        {
            _filmeDao = new FilmeDAO();
            _clienteDao = new ClienteDAO();
        }

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
            // TODO: Verificar se o filme está disponível (se for necessário realmente)

            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string insertSql = "INSERT INTO locacao (codigo, cpf_cliente, codigo_filme, status) VALUES (@codigo, @cpf, @codigoFilme, @status);";

            int codigoLocacao = ProximoCodigo(conexao, transacao);

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
            IList<Locacao> locacoes = new List<Locacao>();

            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "SELECT DISTINCT codigo FROM locacao;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            FbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int codigo = reader.GetInt32(0);
                locacoes.Add(Recuperar(codigo, conexao, transacao));
            }

            conexao.Close();

            return locacoes;
        }

        private Locacao Recuperar(int codigo, FbConnection conexao, FbTransaction transacao)
        {
            Locacao locacao = null;

            Cliente cliente;
            IList<Filme> filmes = new List<Filme>();
            string cpfCliente = "";
            int status = 0;
            IList<int> codigoFilmes = new List<int>();

            string sql = "SELECT DISTINCT cpf_cliente, status FROM locacao WHERE codigo = @codigo;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@codigo", codigo);

            FbDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                cpfCliente = reader.GetString(0);
                status = reader.GetInt32(1);
            }

            codigoFilmes = CodigoFilmes(codigo, conexao, transacao);

            foreach (int codigoFilme in codigoFilmes)
            {
                filmes.Add(_filmeDao.Recuperar(codigoFilme));
            }

            cliente = _clienteDao.Recuperar(cpfCliente);

            conexao.Close();

            locacao = new Locacao()
            {
                Cliente = cliente,
                Codigo = codigo,
                Filmes = filmes,
                Status = StatusUtil.ToStatus(status)
            };

            return locacao;
        }

        public Locacao Recuperar(int codigo)
        {
            Locacao locacao = null;

            Cliente cliente;
            IList<Filme> filmes = new List<Filme>();
            string cpfCliente = "";
            int status = 0;
            IList<int> codigoFilmes = new List<int>();

            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "SELECT DISTINCT cpf_cliente, status FROM locacao WHERE codigo = @codigo;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@codigo", codigo);

            FbDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                cpfCliente = reader.GetString(0);
                status = reader.GetInt32(1);
            }

            codigoFilmes = CodigoFilmes(codigo, conexao, transacao);

            foreach (int codigoFilme in codigoFilmes)
            {
                filmes.Add(_filmeDao.Recuperar(codigoFilme));
            }

            cliente = _clienteDao.Recuperar(cpfCliente);

            conexao.Close();

            locacao = new Locacao()
            {
                Cliente = cliente,
                Codigo = codigo,
                Filmes = filmes,
                Status = StatusUtil.ToStatus(status)
            };

            return locacao;
        }

        public void Remover(int codigo)
        {
            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "DELETE FROM locacao WHERE codigo = @codigo;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@codigo", codigo);

            comando.ExecuteNonQuery();

            transacao.Commit();

            conexao.Close();
        }

        #endregion

        private int ProximoCodigo(FbConnection conexao, FbTransaction transacao)
        {
            int retorno = 1;

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

        private IList<int> CodigoFilmes(int codigo, FbConnection conexao, FbTransaction transacao)
        {
            IList<int> retorno = new List<int>();

            string sql = "SELECT codigo_filme FROM locacao WHERE codigo = @codigo;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@codigo", codigo);

            FbDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                retorno.Add(reader.GetInt32(0));
            }

            return retorno;

        }

    }
}
