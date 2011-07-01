using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using Data.Classes;
using System.Windows.Forms;

namespace Data
{
    public class LocacaoDAO : ILocacaoDAO
    {
        private FilmeDAO _filmeDao;
        private ClienteDAO _clienteDao;
        private Connection connection;

        public LocacaoDAO()
        {
            _filmeDao = new FilmeDAO();
            _clienteDao = new ClienteDAO();
            connection = Connection.Instance;
        }

        #region ILocacaoDAO Members

        public void Atualizar(int codigo, int status)
        {
            try
            {
                FbConnection conexao = connection.OpenConnection();
                FbTransaction transacao = connection.GetTransaction(1);

                string sql = "UPDATE locacao SET status = @status WHERE codigo = @codigo;";

                FbCommand comando = new FbCommand(sql, conexao, transacao);
                comando.Parameters.AddWithValue("@status", status);
                comando.Parameters.AddWithValue("@codigo", codigo);

                comando.ExecuteNonQuery();
                transacao.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public void Inserir(string cpfCliente, IList<int> codigoFilmes)
        {
            // TODO: Verificar se o filme está disponível (se for necessário realmente). Colocar na camada de negócios!
            try
            {
                FbConnection conexao = connection.OpenConnection();
                FbTransaction transacao = connection.GetTransaction(1);

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
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public IList<Locacao> Listar()
        {
            IList<Locacao> locacoes = new List<Locacao>();

            try
            {
                FbConnection conexao = connection.OpenConnection();
                FbTransaction transacao = connection.GetTransaction(2);

                string sql = "SELECT DISTINCT codigo FROM locacao WITH LOCK;";

                FbCommand comando = new FbCommand(sql, conexao, transacao);
                FbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int codigo = reader.GetInt32(0);
                    locacoes.Add(Recuperar(codigo, conexao, transacao));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.CloseConnection();
            }

            return locacoes;
        }

        public void preencherDataGridView(DataGridView dgvLocacao)
        {
            try
            {
                FbConnection conexao = connection.OpenConnection();
                FbTransaction transacao = connection.GetTransaction(1);

                string sql = "SELECT DISTINCT codigo, cpf_cliente, status FROM locacao  ";


                FbCommand comando = new FbCommand(sql, conexao, transacao);
                FbDataReader dr = comando.ExecuteReader();

                int nColunas = dr.FieldCount;


                for (int i = 0; i < nColunas; i++)
                {
                    if (!dr.GetName(i).ToString().Equals("STATUS"))
                    {
                        dgvLocacao.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
                        dgvLocacao.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvLocacao.Columns[i].ReadOnly = true;
                    }
                }

                string[] linhaDados = new string[nColunas];

                DataGridViewComboBoxCell cellCombo = new DataGridViewComboBoxCell();
                cellCombo.Items.Add("Pendente");
                cellCombo.Items.Add("Disponível");
                DataGridViewColumn columnStatus = new DataGridViewColumn(cellCombo);
                dgvLocacao.Columns.Add(columnStatus);
                dgvLocacao.Columns[2].HeaderText = "STATUS";


                while (dr.Read())
                {
                    //percorre cada uma das colunas
                    for (int a = 0; a < nColunas; a++)
                    {
                        if (dr.GetFieldType(a).ToString() == "System.Int32")
                        {
                            if (dr.GetName(a).ToString().Equals("CODIGO"))
                            {
                                linhaDados[a] = dr.GetInt32(a).ToString();
                            }
                            else if (dr.GetName(a).ToString().Equals("STATUS"))
                            {
                                if (dr.GetInt32(a) == 1)
                                {
                                    linhaDados[a] = "Disponível";
                                }
                                else if (dr.GetInt32(a) == 2)
                                {
                                    linhaDados[a] = "Pendente";
                                }
                            }
                            else
                            {
                                linhaDados[a] = dr.GetInt32(a).ToString();
                            }
                        }
                        else if (dr.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = dr.GetString(a).ToString();
                        }
                        else if (dr.GetFieldType(a).ToString() == "System.Decimal")
                        {

                            linhaDados[a] = dr.GetString(a).ToString();
                        }
                    }

                    //atribui a linha ao datagridview
                    dgvLocacao.Rows.Add(linhaDados);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        private Locacao Recuperar(int codigo, FbConnection conexao, FbTransaction transacao)
        {
            Locacao locacao = null;

            Cliente cliente;
            IList<Filme> filmes = new List<Filme>();
            string cpfCliente = "";
            int status = 0;
            IList<int> codigoFilmes = new List<int>();

            string sql = "SELECT DISTINCT cpf_cliente, status FROM locacao WHERE codigo = @codigo  ;";

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
                filmes.Add(_filmeDao.Recuperar(codigoFilme, conexao, transacao));
            }

            cliente = _clienteDao.Recuperar(cpfCliente, conexao, transacao);

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

            try
            {
                FbConnection conexao = connection.OpenConnection();
                FbTransaction transacao = connection.GetTransaction(1);

                Cliente cliente;
                IList<Filme> filmes = new List<Filme>();
                string cpfCliente = "";
                int status = 0;
                IList<int> codigoFilmes = new List<int>();

                string sql = "SELECT DISTINCT cpf_cliente, status FROM locacao WHERE codigo = @codigo  ;";

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
                    filmes.Add(_filmeDao.Recuperar(codigoFilme, conexao, transacao));
                }

                cliente = _clienteDao.Recuperar(cpfCliente, conexao, transacao);

                conexao.Close();

                locacao = new Locacao()
                {
                    Cliente = cliente,
                    Codigo = codigo,
                    Filmes = filmes,
                    Status = StatusUtil.ToStatus(status)
                };

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.CloseConnection();
            }
            return locacao;
        }

        public void Remover(int codigo)
        {
            try
            {
                FbConnection conexao = connection.OpenConnection();
                FbTransaction transacao = connection.GetTransaction(4);

                string sql = "DELETE FROM locacao WHERE codigo = @codigo;";

                FbCommand comando = new FbCommand(sql, conexao, transacao);
                comando.Parameters.AddWithValue("@codigo", codigo);

                comando.ExecuteNonQuery();

                transacao.Commit();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.CloseConnection();
            }
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

            string sql = "SELECT codigo_filme FROM locacao WHERE codigo = @codigo  ;";

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
