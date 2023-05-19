using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tree_Shop
{
    internal class Connection
    {
        public static MySqlConnection connect = new MySqlConnection("server=127.0.0.1; port=3306; username=root; password=root;database=tree_db");
        public static MySqlDataAdapter adap = new MySqlDataAdapter();
        public static MySqlDataReader reader;
        public static string UserLogin = " ";
        public static string NickUser = " ";
        public static bool admin = false;
    }
}


