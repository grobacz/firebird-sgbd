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

        private Connection() { }

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


    }
}
