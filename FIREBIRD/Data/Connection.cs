using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using System.Diagnostics;
using System.Configuration;

namespace Data
{
    public class Connection
    {
        private static Connection instance;
        private FbConnection connection;

        private Connection()
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"..\..\data\LOCADORA.FDB");

            connection = new FbConnection("User ID=sysdba;Password=masterkey;" +
                   "Database=" + path + "; " +
                   "DataSource=localhost;Charset=NONE;");
        }

        public static Connection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Connection();
                }
                return instance;
            }
        }

        public FbConnection GetConnection()
        {
            if (connection == null)
            {
                Debug.WriteLine("criando de novo");

                string path = Path.Combine(Environment.CurrentDirectory, @"..\..\data\LOCADORA.FDB");

                return new FbConnection("User ID=sysdba;Password=masterkey;" +
                   "Database=" + path + "; " +
                   "DataSource=localhost;Charset=NONE;");
            }

            return connection;
        }



        public FbTransaction GetTransaction(int loadedConfiguration)
        {
            //int loadedConfiguration = int.Parse(ConfigurationManager.AppSettings["TransactionConfig"]);

            FbTransactionOptions configTran = new FbTransactionOptions();

            switch (loadedConfiguration)
            {
                case (int)ConfigTransacao.Consistency:
                    configTran.TransactionBehavior = FbTransactionBehavior.Consistency;
                    break;
                case (int)ConfigTransacao.Concurrency_NOWAIT:
                    configTran.TransactionBehavior = FbTransactionBehavior.Concurrency | FbTransactionBehavior.NoWait;
                    break;
                case (int)ConfigTransacao.Concurrency_WAIT:
                    configTran.TransactionBehavior = FbTransactionBehavior.Concurrency | FbTransactionBehavior.Wait;
                    break;
                case (int)ConfigTransacao.ReadCommitted_NOWAIT:
                    configTran.TransactionBehavior = FbTransactionBehavior.ReadCommitted | FbTransactionBehavior.NoWait;
                    break;
                case (int)ConfigTransacao.ReadCommitted_WAIT:
                    configTran.TransactionBehavior = FbTransactionBehavior.ReadCommitted | FbTransactionBehavior.Wait;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            return connection.BeginTransaction(configTran);

        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public FbConnection OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            return connection;
        }

        public enum ConfigTransacao
        {
            Consistency = 1,
            Concurrency_WAIT = 2,
            Concurrency_NOWAIT = 3,
            ReadCommitted_WAIT = 4,
            ReadCommitted_NOWAIT = 5
        };
    }
}
