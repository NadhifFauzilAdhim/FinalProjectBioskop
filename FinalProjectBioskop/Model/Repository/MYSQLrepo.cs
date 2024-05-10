using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FinalProjectBioskop.Model.Entity;

namespace FinalProjectBioskop.Model.Repository
{
    public class MYSQLrepo
    {
        Bioskop bioskopent = new Bioskop();

        private MySqlConnection GetOpenConnection()
        {
            return DatabaseConnection.GetOpenConnection();
        }

        public string login(string id, string nama)
        {
            using (MySqlConnection conn = GetOpenConnection())
            {
                string sql = "SELECT id, nama, password FROM customer WHERE password = @password AND nama = @nama";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@password", id);
                cmd.Parameters.AddWithValue("@nama", nama);

                using (MySqlDataReader dtr = cmd.ExecuteReader())
                {
                    if (dtr.Read())
                    {
                        var Identity = dtr["id"].ToString();
                        return Identity;
                    }
                    else
                    {
                        MessageBox.Show("ID dan Nama tidak ditemukan!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return null;
                    }
                }
            }
        }

        public void Daftar(string id, string nama)
        {
            int result = 0;

            using (MySqlConnection conn = GetOpenConnection())
            {
                string sql = "INSERT INTO customer (nama, password, balance) VALUES (@nama, @password,@defbalance)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                try
                {
                    int defaultbalance = 0;
                    cmd.Parameters.AddWithValue("@password", id);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@defbalance",defaultbalance);
                    

                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cmd.Dispose();
                }

                if (result > 0)
                {
                    MessageBox.Show("Berhasil Terdaftar, Silahkan Login Kembali", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pendaftaran Gagal", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }          
        }

        public string GetInformarmation(string id)
        {
            using (MySqlConnection conn = GetOpenConnection())
            {
                string sql = "select id, nama from customer where id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    return dtr["nama"].ToString();
                }
                else
                    MessageBox.Show("Gagal Tekoneksi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
            }
        }
        
        public string GetBalance(string id)
        {
            using (MySqlConnection conn = GetOpenConnection())
            {
                string sql = "select balance from customer where id = @idcus";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@idcus", id);
                MySqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    return dtr["balance"].ToString();
                }
                else
                    MessageBox.Show("Gagal Tekoneksi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public void UpdateBalance(string balance,string id)
        {
            using (MySqlConnection conn = GetOpenConnection())
            {
                string sql = "UPDATE customer SET balance = @balance WHERE id = @idcus";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@balance", balance);
                    cmd.Parameters.AddWithValue("@idcus", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public (string Id, string Nama) GetInformationAndId(string id)
        {
            using (MySqlConnection conn = GetOpenConnection())
            {
                string sql = "select id, nama from customer where id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    var Id = dtr["id"].ToString();
                    var Nama = dtr["nama"].ToString();

                    return (Id, Nama);
                }
                else
                {
                    MessageBox.Show("Gagal Terkoneksi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return (null, null); 
                }
            }
        }

        public (string namafilm, string durasi, string harga, string genre, string thnrilis, string jamtayang) GetFilm(string IDfilm)
        {
            using (MySqlConnection conn = GetOpenConnection())
            {
                string sql = "select IdFilm, FilmName, Harga, Durasi, ThnRilis, Genre, Jam_tayang from film where IdFilm = @IdFilm";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdFilm", IDfilm);
                MySqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    var filmname = dtr["FilmName"].ToString();
                    var durasi = dtr["Durasi"].ToString();
                    var harga = dtr["Harga"].ToString();
                    var genre = dtr["Genre"].ToString();
                    var tahunrilis = dtr["ThnRilis"].ToString();
                    var jamtayang = dtr["Jam_tayang"].ToString();
    
                    return(filmname, durasi,harga, genre, tahunrilis,jamtayang);    
                }
                else
                    MessageBox.Show("Gagal Terkoneksi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return (null, null, null, null, null,null);
            }
        }

        public List<(string seatNumber, int status)> LoadSeat(string Time)
        {
            List<(string seatNumber, int status)> seatList = new List<(string seatNumber, int status)>();

            using (MySqlConnection conn = GetOpenConnection())
            {
                string columnName = Time;
                string sql = $"SELECT SeatNumber, `{columnName}` AS Status FROM seatstatus";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string seatNumber = reader["SeatNumber"].ToString();
                            int status = Convert.ToInt32(reader["Status"]);
                            seatList.Add((seatNumber, status));
                        }
                    }
                }
            }
            return seatList;
        }

        public void UpdateSeat(string Time, string seatnumber, int status)
        {
            using (MySqlConnection conn = GetOpenConnection())
            {
                string columnName = Time;
                string sql = $"INSERT INTO seatstatus (SeatNumber, `{columnName}`) VALUES (@seatNumber, @status) " +
                             $"ON DUPLICATE KEY UPDATE `{columnName}` = @status";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@seatNumber", seatnumber);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int AddPayment(string idcus,string namacus,string filmname,string harga,string seatnumber,string idfilm)
        {
            using (MySqlConnection conn = GetOpenConnection())
            {
                string sql = "INSERT INTO payment (Idcustomer, NamaCus, FilmName, Harga, SeatNumber, IdFilm, TglPesan) VALUES (@Idcustomer, @NamaCus, @FilmName, @Harga, @SeatNumber, @IdFilm, @TglPesan); SELECT LAST_INSERT_ID();";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Idcustomer", idcus);
                    cmd.Parameters.AddWithValue("@NamaCus", namacus);
                    cmd.Parameters.AddWithValue("@FilmName", filmname);
                    cmd.Parameters.AddWithValue("@Harga", harga);
                    cmd.Parameters.AddWithValue("@SeatNumber", seatnumber);
                    cmd.Parameters.AddWithValue("@IdFilm", idfilm);
                    cmd.Parameters.AddWithValue("@TglPesan", DateTime.Now);
                    //Mengambil ID payment
                     int idPayment = Convert.ToInt32(cmd.ExecuteScalar());

                    string updateSql = "UPDATE payment SET Ticket_valid = TglPesan + INTERVAL 3 HOUR WHERE idPayment = @IdPayment;";
                    using (MySqlCommand cmdUpdate = new MySqlCommand(updateSql, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@IdPayment", idPayment);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    return idPayment;
                }
            }
        }

        public List<(string Idpayment, string SeatNumber, string Filmname, string ticketvalid,string tanggalpesan)> Loadticket(string ID)
        {
            List<(string Idpayment, string SeatNumber, string Filmname, string ticketvalid,string tanggalpesan)> loadticket = new List<(string Idpayment, string SeatNumber, string Filmname, string ticketvalid,string tanggalpesan)>();

            using (MySqlConnection conn = GetOpenConnection())
            {
                string sql = "SELECT IdPayment, SeatNumber, FilmName, Ticket_valid, TglPesan FROM payment WHERE Idcustomer = @Id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", ID);

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var IDpayment = dtr["IdPayment"].ToString();      
                            var Seatnumber = dtr["SeatNumber"].ToString();
                            var Filmname = dtr["FilmName"].ToString();
                            var ticketvalid = dtr["Ticket_valid"].ToString();
                            var tanggalpesan = dtr["TglPesan"].ToString();


                            loadticket.Add((IDpayment, Seatnumber, Filmname, ticketvalid,tanggalpesan));
                        }
                    }
                }
            }

            return loadticket;
        }



    }
}
