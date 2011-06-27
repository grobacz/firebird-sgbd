using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Classes;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace Data
{
    public class ClienteDAO : IClienteDAO
    {
        #region IClienteDAO Members

        public void Atualizar(string cpfAntigo, string cpfNovo, string nome, string endereco, string telefone, DateTime dataNascimento)
        {
            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "UPDATE cliente SET cpf = @cpfNovo, nome = @nome, endereco = @endereco, telefone = @telefone, data_nascimento = @data WHERE cpf = @cpfAntigo;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@cpfNovo", cpfNovo);
            comando.Parameters.AddWithValue("@cpfAntigo", cpfAntigo);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@endereco", endereco);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@data", dataNascimento);

            comando.ExecuteNonQuery();
            transacao.Commit();

            conexao.Close();
        }

        public void Inserir(string cpf, string nome, string endereco, string telefone, DateTime dataNascimento)
        {
            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string insertSql = "INSERT INTO cliente (cpf, nome, endereco, telefone, data_nascimento) VALUES (@cpf, @nome, @endereco, @telefone, @data);";

            FbCommand comando = new FbCommand(insertSql, conexao, transacao);
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@endereco", endereco);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@data", dataNascimento);

            comando.ExecuteNonQuery();
            transacao.Commit();

            conexao.Close();
        }

        public IList<Cliente> Listar()
        {
            IList<Cliente> clientes = new List<Cliente>();

            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "SELECT cpf, nome, endereco, telefone, data_nascimento FROM cliente;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            FbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cliente cliente = new Cliente()
                {
                    Cpf = reader.GetString(0),
                    Nome = reader.GetString(1),
                    Endereco = reader.GetString(2),
                    Telefone = reader.GetString(3),
                    DataNascimento = reader.GetDateTime(4)
                };

                clientes.Add(cliente);

            }

            conexao.Close();

            return clientes;
        }

        public Cliente Recuperar(string cpf)
        {
            Cliente cliente = null;

            FbConnection conexao = Connection.Instance.GetConnection();
            
            if (conexao.State != ConnectionState.Open)
                conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "SELECT cpf, nome, endereco, telefone, data_nascimento FROM cliente WHERE cpf = @cpf;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@cpf", cpf);

            FbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cliente = new Cliente()
                {
                    Cpf = reader.GetString(0),
                    Nome = reader.GetString(1),
                    Endereco = reader.GetString(2),
                    Telefone = reader.GetString(3),
                    DataNascimento = reader.GetDateTime(4)
                };

            }

            conexao.Close();

            return cliente;
        }

        public void Remover(string cpf)
        {
            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();

            FbTransaction transacao = conexao.BeginTransaction();

            string sql = "DELETE FROM cliente WHERE cpf = @cpf;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@cpf", cpf);

            comando.ExecuteNonQuery();
            transacao.Commit();

            conexao.Close();
        }

        #endregion

        public Cliente Recuperar(string cpf, FbConnection conexao, FbTransaction transacao)
        {
            Cliente cliente = null;

            string sql = "SELECT cpf, nome, endereco, telefone, data_nascimento FROM cliente WHERE cpf = @cpf;";

            FbCommand comando = new FbCommand(sql, conexao, transacao);
            comando.Parameters.AddWithValue("@cpf", cpf);

            FbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                cliente = new Cliente()
                {
                    Cpf = reader.GetString(0),
                    Nome = reader.GetString(1),
                    Endereco = reader.GetString(2),
                    Telefone = reader.GetString(3),
                    DataNascimento = reader.GetDateTime(4)
                };

            }

            return cliente;
        }
    }
}
