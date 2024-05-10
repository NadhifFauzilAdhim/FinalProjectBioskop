using FinalProjectBioskop.Controller;
using FinalProjectBioskop.Model.Entity;
using FinalProjectBioskop.Model.Repository;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectBioskop
{
    public partial class Payment : Form
    {
        private readonly BioskopController _controller;
        private Bioskop bioskopent;

        public Payment(Bioskop bioskop)
        {
            bioskopent = bioskop;
            _controller = new BioskopController();
            InitializeComponent();
            Loadbalance();
            Loadpayment();            
        }

        private string Loadbalance()
        {       
            bioskopent.Balance = _controller.GetBalance(bioskopent.Identity);
            lblsaldo.Text = "Rp."+bioskopent.Balance;
            return bioskopent.Balance;
        }

        private void Loadpayment()
        {
            txtiduser.Text = bioskopent.Identity;
            txtnamafilm.Text = bioskopent.Filmname;
            txtdurasi.Text = bioskopent.Duration;
            txtgenre.Text = bioskopent.Genre;
            txtjamtayang.Text = bioskopent.Time;
            txtharga.Text = "Rp."+bioskopent.Harga;
            txtnama.Text = bioskopent.Cusname;
            lblheader.Text = "Hi " + bioskopent.Cusname + " Selesaikan Pembayaran Anda";
           
            switch (bioskopent.Filmname)
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
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            barcodeimage.Image = qrcode.Draw(bioskopent.Identity + bioskopent.Cusname + bioskopent.Filmname + bioskopent.Duration + bioskopent.Genre +bioskopent.Time + bioskopent.Harga + bioskopent.Cusname, 70);
        }
        
        private void BtnConfirm_Click(object sender, EventArgs e)
        {           
            int balance = Convert.ToInt32(bioskopent.Balance);
            int price = Convert.ToInt32(bioskopent.Harga);
          
            if (balance >= price)
            {
                int balanceafterpayment = balance - price;
                _controller.UpdateBalance(balanceafterpayment.ToString(), bioskopent.Identity);
                //Console.WriteLine(balanceafterpayment);
                int IdPayment = _controller.AddPayment(bioskopent.Identity, bioskopent.Cusname, bioskopent.Filmname, bioskopent.Harga, bioskopent.SeatNumber, bioskopent.FilmID);
                lblinfo.Text = "Pembayaran Behasil IDPayment : "+IdPayment.ToString();
                lblticketinfo.Text = "Tiket Hanya Berlaku 3 Jam";
                Loadbalance();
                BtnConfirm.Hide();
               
            }
            else
            {               
                MessageBox.Show("Saldo tidak mencukupi untuk pembayaran ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblinfo.Text = "Pembayaran Gagal";
            }
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

      
    }
}
