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
                //Remote Database BioskopDB
                 string myConnectionString = "server=5ol.h.filess.io;port=3306;database=BioskopDb_pricebrief;uid=BioskopDb_pricebrief;pwd=238ff8673efadfa819958c065cfd692e63ab641a;";
                //local Database BioskopDB
                //string myConnectionString = "server=127.0.0.1;port=3306;database=bioskopdb;uid=root;pwd=;";
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
