using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectBioskop.View;

namespace FinalProjectBioskop
{
    public class DatabaseConnection
    {
        public static MySqlConnection GetOpenConnection()
        {
            MySqlConnection conn = null;
            try
            {

                //local Database BioskopDB
                string myConnectionString = "server=127.0.0.1;port=3306;database=bioskopdb;uid=root;pwd=;";
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return conn;
        }
    }
}
