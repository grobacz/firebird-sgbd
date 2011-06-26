using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.IO;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string path = Path.Combine(Environment.CurrentDirectory, @"..\..\data\SGBD.FDB");

                Console.WriteLine(path);
                Console.WriteLine(File.Exists(Path.Combine(Environment.CurrentDirectory, @"..\..\data\SGBD.FDB")));

                FbConnection con = new FbConnection("User ID=sysdba;Password=290389;" +
                   "Database=" + path + "; " +
                   "DataSource=localhost;Charset=NONE;");
                con.Open();

                // create table
                //FbTransaction t = con.BeginTransaction();

                //string sqlCommand = "CREATE TABLE test(id INTEGER, nome VARCHAR(64), salario DECIMAL(10, 2));";
                //FbCommand command = new FbCommand(sqlCommand, con, t);

                //command.ExecuteNonQuery();
                //t.Commit();

                // insert
                //FbCommand insertCommand = new FbCommand("INSERT INTO test (id, nome, salario) VALUES (1, 'André', 10000.25);", con);
                //insertCommand.ExecuteNonQuery();

                // select

                FbTransactionOptions op = new FbTransactionOptions();
                op.TransactionBehavior = FbTransactionBehavior.ReadCommitted;

                FbTransaction transaction; 
                //transaction = con.BeginTransaction(op);
                transaction = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                FbCommand selectCommand = new FbCommand("SELECT * FROM test;", con, transaction);
                FbDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    // acessando via nome da coluna
                    Console.WriteLine(reader["id"]);
                    Console.WriteLine(reader["nome"]);
                    Console.WriteLine(reader["salario"]);

                    // acessando via índice de coluna com método "GetType"
                    Console.WriteLine(reader.GetInt32(0));
                    Console.WriteLine(reader.GetString(1));
                    Console.WriteLine(reader.GetDecimal(2));
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
