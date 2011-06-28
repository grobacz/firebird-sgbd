using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Classes;
using FirebirdSql.Data.FirebirdClient;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            FilmeDAO filmeDao = new FilmeDAO();
            LocacaoDAO locacaoDao = new LocacaoDAO();
            //filmeDao.Inserir("A volta dos que não foram", 1.23m, Genero.COMEDIA, 2009, null);
            //filmeDao.Inserir("Tempos complicados", 1.23m, Genero.COMEDIA, 2009, null);
            //filmeDao.Atualizar(1, "A bela caída", 12.87m, Genero.DOCUMENTARIO, 2010, null);

            //locacaoDao.Inserir("08299704448", new List<int> { 2, 3 });
            //locacaoDao.Atualizar(1, (int)Status.Disponivel);
            //Console.WriteLine(locacaoDao.Recuperar(2));

            FbConnection conexao = Connection.Instance.GetConnection();
            conexao.Open();
            FbTransaction transacao = conexao.BeginTransaction();
            string sql = "SELECT imagem, OCTET_LENGTH(imagem) as tamanho FROM filme WHERE codigo = 7;";
            FbCommand comando = new FbCommand(sql, conexao, transacao);

            FbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int tamanho = reader.GetInt32(1);

                byte[] bytes = new byte[tamanho];
                byte[] novoModelo = (byte[])reader["imagem"];

                long count = reader.GetBytes(0, 0, bytes, 0, tamanho);

            }

            conexao.Close();

        }
    }
}
