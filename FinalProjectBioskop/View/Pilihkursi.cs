using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectBioskop.Model.Repository;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using FinalProjectBioskop.Controller;
using FinalProjectBioskop.Model.Entity;

namespace FinalProjectBioskop
{

    public partial class Pilihkursi : Form
    {
        private readonly BioskopController _controller;
        private Bioskop bioskopent;

        public Pilihkursi(Bioskop bioskop)
        {
            InitializeComponent();
            bioskopent = bioskop;
            _controller = new BioskopController();
            Getfilm();
            Information();
            buttonclicked();
            LoadButtonStatus();  
        }

        private void Information()
        {          
            (string id, string nama) = _controller.GetInformationAndId(bioskopent.Identity);
            bioskopent.Cusname = nama;
            txtnama.Text = nama;
            txtnomember.Text = id;
            lblname.Text = "Hi " +nama+ " pilih kursi anda";
        }
        private void Getfilm()
        {        
            (string namafilm, string durasi, string harga, string genre, string thnrilis,string jamtayang) = _controller.GetFilm(bioskopent.FilmID);
            bioskopent.Filmname = namafilm;
            bioskopent.Harga = harga;
            bioskopent.Duration = durasi;
            bioskopent.Genre = genre;       
            txtfilm.Text = namafilm;
            txtharga.Text = harga;
            txtdurasi.Text = durasi;
            lblnamafilm.Text = namafilm;
            txtgenre.Text = genre;
            SetImageBasedOnFilmName(namafilm);
        }

        private void SetImageBasedOnFilmName(string namafilm)
        {
            switch (namafilm)
            {
                case "The Marvel":
                    picturebox.Image = Properties.Resources.OIP;
                    break;
                case "Sehabis Magrib":
                    picturebox.Image = Properties.Resources._63bc2f7f9dcf3;
                    break;
                case "Trolls":
                    picturebox.Image = Properties.Resources.Trolls;
                    break;
                case "Sijjin":
                    picturebox.Image = Properties.Resources.SIJJIN;
                    break;
                case "172 Days":
                    picturebox.Image = Properties.Resources._172Days;
                    break;
                case "Gampang Cuan":
                    picturebox.Image = Properties.Resources.GampangCuan;
                    break;
                case "Saranjana":
                    picturebox.Image = Properties.Resources.Saranjana;
                    break;
            }
        }

            // Meload Data Seat Dari Database
            private void LoadButtonStatus()
        {
            List<(string seatNumber, int status)> seatList = _controller.LoadSeat(bioskopent.Time);

            foreach ((string seatNumber, int status) in seatList)
            {
                SetButtonColor(seatNumber, status);
            }    
        }
        // Mengset Button setelah Dibaca dari Database
        private void SetButtonColor(string seatNumber, int status)
        {
            Button button = Controls.Find(seatNumber, true).FirstOrDefault() as Button;
            if (button != null)
            {
                button.BackColor = (status == 1) ? Color.Lime : Color.Red;
            }
        }
        // Update Database saat tombol ditekan
        private void UpdateDataSeat(Button button, int status)
        {           
            string seatNumber = button.Text;
            int Status = status;         
            _controller.UpdateSeat(bioskopent.Time, seatNumber, status);
        }
        //Menrecord button yang ditekan
        private void buttonclicked()
        {
            char[] rows = { 'A', 'B', 'C', 'D', 'E' };
            int columns = 6;

            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 1; j <= columns; j++)
                {
                    Button button = Controls.Find($"{rows[i]}{j}", true).FirstOrDefault() as Button;
                    if (button != null)
                    {
                        button.Click += Button_Click;
                    }
                }
            }
        }
        private bool IsRed(Button button)
        {
            return button.BackColor == Color.Red;
        }

        // Menyimpan Status Seat Pada Database
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (IsRed(clickedButton))
            {
                clickedButton.BackColor = Color.Lime;
                UpdateDataSeat(clickedButton, 1);
                txtnokursi.Text = "";
            }
            else
            {
                clickedButton.BackColor = Color.Red;
                UpdateDataSeat(clickedButton, 0);
                txtnokursi.Text = clickedButton.Text;
                bioskopent.SeatNumber = clickedButton.Text;
            } 
        }            
        //Form Payment
        private void btnorder_Click(object sender, EventArgs e)
        {       
            Payment payment = new Payment(bioskopent);
            payment.Show();
            this.Hide();
            
        }
    }
}