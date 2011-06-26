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
            Console.WriteLine(File.Exists(Path.Combine("data", "SGBD.FDB")));

            

            FbConnection con = new FbConnection("User ID=sysdba;Password=290389;" + 
               "Database=\\data\\SGBD.FDB; " + 
               "DataSource=localhost;Charset=NONE;");

            //con.Open();
        }
    }
}
