using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KutuphaneSistemi.DAO
{
    public class DbBaglanti
    {
        private static string connectionString =
        "Server=172.21.54.253; Database=26_132430039; User=26_132430039; Password=İnif123.";

        public static MySqlConnection BaglantiGetir()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

