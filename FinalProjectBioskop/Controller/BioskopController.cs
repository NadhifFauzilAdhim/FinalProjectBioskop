using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectBioskop.Model.Repository;
using FinalProjectBioskop.Model.Entity;


namespace FinalProjectBioskop.Controller
{
    public class BioskopController
    {
        private readonly MYSQLrepo _repository;
        Bioskop bioskopent = new Bioskop();

        public BioskopController()
        {
            _repository = new MYSQLrepo();
        }
      
        public string Login(string id, string nama)
        {
            return _repository.login(id, nama);
        }
     
        public void Daftar(string id, string nama)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nama))
            {
                MessageBox.Show("ID dan Nama harus diisi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _repository.Daftar(id, nama);
        }
   
        public string GetInformation(string id)
        {
            return _repository.GetInformarmation(id);
        }

        public (string Id, string Nama) GetInformationAndId(string id)
        {
            return _repository.GetInformationAndId(id);
        }

        public string GetBalance(string id)
        {
            return _repository.GetBalance(id);
        }

        public void UpdateBalance(string balance, string id)
        {
            _repository.UpdateBalance(balance, id);
        }
      
        public (string, string, string, string, string, string) GetFilm(string IDfilm)
        {
            return _repository.GetFilm(IDfilm);
        }
      
        public List<(string, int)> LoadSeat(string Time)
        {
            return _repository.LoadSeat(Time);
        }
        
        public void UpdateSeat(string Time, string seatnumber, int status)
        {
            _repository.UpdateSeat(Time, seatnumber, status);
        }
       
        public int AddPayment(string idcus, string namacus, string filmname, string harga, string seatnumber, string idfilm)
        {
          return _repository.AddPayment(idcus, namacus, filmname, harga, seatnumber, idfilm);
            
        }

        public List<(string Idpayment, string SeatNumber, string Filmname, string ticketvalid, string tanggalpesan)> Loadticket(string ID)
        {
            return _repository.Loadticket(ID);
        }


    }
}
