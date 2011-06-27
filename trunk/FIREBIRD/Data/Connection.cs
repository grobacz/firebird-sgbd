using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.IO;

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
                string path = Path.Combine(Environment.CurrentDirectory, @"..\..\data\LOCADORA.FDB");

                return new FbConnection("User ID=sysdba;Password=masterkey;" +
                   "Database=" + path + "; " +
                   "DataSource=localhost;Charset=NONE;");
            }

            return connection;
        }

        

        public void TransactionParameter(configTransacao index)
        {
            FbTransactionOptions configTran = new FbTransactionOptions();

            switch(index)
            {
                case configTransacao.Consistency:
                    configTran.TransactionBehavior = FbTransactionBehavior.Consistency;
                    break;
                case configTransacao.Concurrency_NOWAIT:
                    configTran.TransactionBehavior = FbTransactionBehavior.Concurrency | FbTransactionBehavior.NoWait;
                    break;
                case configTransacao.Concurrency_WAIT:
                    configTran.TransactionBehavior = FbTransactionBehavior.Concurrency | FbTransactionBehavior.Wait;
                    break;
                case configTransacao.ReadCommitted_NOWAIT:
                    configTran.TransactionBehavior = FbTransactionBehavior.ReadCommitted | FbTransactionBehavior.NoWait;
                    break;
                case configTransacao.ReadCommitted_WAIT:
                    configTran.TransactionBehavior = FbTransactionBehavior.ReadCommitted | FbTransactionBehavior.Wait;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            connection.BeginTransaction(configTran);

          /*  connection.BeginTransaction(new FbTransactionOptions()
            {
                TransactionBehavior = FbTransactionBehavior.ReadCommitted,  // etc.
                LockTables = new Dictionary<string, FbTransactionBehavior>
                {
                    { "TABLE_1", FbTransactionBehavior.LockWrite | FbTransactionBehavior.Shared },
                    { "TABLE_2", FbTransactionBehavior.LockWrite | FbTransactionBehavior.Exclusive }
                }
            });
            */

        }

        public enum configTransacao
        {
            Consistency = 1,
            Concurrency_WAIT = 2,
            Concurrency_NOWAIT = 3,
            ReadCommitted_WAIT = 4,
            ReadCommitted_NOWAIT = 5


        };
    }
}
