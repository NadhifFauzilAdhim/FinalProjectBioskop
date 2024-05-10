using FinalProjectBioskop.Model.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectBioskop.Controller;
using FinalProjectBioskop.View;
using FinalProjectBioskop.Model.Entity;

namespace FinalProjectBioskop
{
    public partial class HomePage : Form
    {
        private readonly BioskopController _controller;
        private Bioskop bioskopent;
        public HomePage(Bioskop bioskop)
        {
            InitializeComponent();          
            _controller = new BioskopController();
            bioskopent = bioskop;
            Information();
            buttoncliked();
        }
        private void Information()
        {
            var name = _controller.GetInformation(bioskopent.Identity);
            var balance = _controller.GetBalance(bioskopent.Identity);
            lblsaldo.Text = "Rp ." + balance;
            lblname.Text = "Hi " + name;
            Notifikasi.BalloonTipText = "Hi " + name + " Selamat Datang";
            Notifikasi.BalloonTipTitle = "Arabis Studio";
            Notifikasi.Icon = SystemIcons.Information;
            Notifikasi.ShowBalloonTip(500);
        }

        private void buttoncliked()
        {
            for (int i = 1; i <= 7; i++)
            {
                string buttonName =  "BtnFilm" + i;
                Button currentButton = Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (currentButton != null)
                {
                    currentButton.Click += ButtonUpdate;
                }
            }
        }

        private void ButtonUpdate(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonname = clickedButton.Name;
            bioskopent.FilmID = buttonname;
            FilmInformation filminfo = new FilmInformation(bioskopent);
            
            filminfo.Show();
        }    

        private void ticketicon_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(bioskopent);
            ticket.Show();
        }

        private void logouticon_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Btnrefresh_Click(object sender, EventArgs e)
        {
            Information();
        }
    }
}