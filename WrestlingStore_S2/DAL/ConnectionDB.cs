using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ConnectionDB
    {
        private MySqlConnection conn;


        public ConnectionDB()
        {
            string connInfo = "server=studmysql01.fhict.local;database=dbi463263;uid=dbi463263;pwd=userTry;SslMode=none";
            conn = new MySqlConnection(connInfo);
        }

        public MySqlConnection GetConnection()
        {
            return conn;
        }
    }
}
