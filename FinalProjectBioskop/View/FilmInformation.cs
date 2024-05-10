using FinalProjectBioskop.Model.Repository;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
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
using FinalProjectBioskop.Controller;
using FinalProjectBioskop.Model.Entity;

namespace FinalProjectBioskop
{
    public partial class FilmInformation : Form
    {
        private readonly BioskopController _controller;
        private  Bioskop bioskopent;
        public FilmInformation(Bioskop bioskop)
        {
            InitializeComponent();
            bioskopent = bioskop;
            _controller = new BioskopController();
            getfiminfo();
        }

        private void getfiminfo()
        {
            (string namafilm, string durasi, string harga, string genre, string thnrilis, string jamtayang) = _controller.GetFilm(bioskopent.FilmID);
            txtnamafilm.Text = namafilm;
            txtdurasi.Text = durasi;
            txtgenre.Text = genre + " " + thnrilis;
            txtharga.Text = harga;
            txtjamtayang.Text = jamtayang;
            bioskopent.Time = jamtayang.ToString();
            lblfilmname.Text = namafilm;
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

        private void BtnOrder_Click_1(object sender, EventArgs e)
        {
            Pilihkursi pilihkursi = new Pilihkursi(bioskopent);
            this.Hide();
            pilihkursi.Show();
        }

      
    }
}