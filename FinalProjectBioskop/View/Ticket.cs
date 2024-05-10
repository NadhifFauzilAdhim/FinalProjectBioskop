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
using Google.Protobuf.WellKnownTypes;
using Zen.Barcode;
using ZstdSharp.Unsafe;

namespace FinalProjectBioskop.View
{
    public partial class Ticket : Form
    {
        private readonly BioskopController _controller;
        private Bioskop bioskopent;
        

        public Ticket(Bioskop bioskop)
        {
           bioskopent = bioskop;
            _controller = new BioskopController();
            InitializeComponent();
            InisialisasiDataGridView();
            Loadticket();
            dgvTicket.SelectionChanged += DgvTicket_SelectionChanged;
        }

        private void InisialisasiDataGridView()
        {
            dgvTicket.AutoGenerateColumns = false;
            dgvTicket.ColumnCount = 6;

            dgvTicket.Columns[0].Name = "No";
            dgvTicket.Columns[0].HeaderText = "No";
            dgvTicket.Columns[0].Width = 30;

            dgvTicket.Columns[1].Name = "IDPayment";
            dgvTicket.Columns[1].HeaderText = "ID Payment";
            dgvTicket.Columns[1].Width = 80;

            dgvTicket.Columns[2].Name = "SeatNumber";
            dgvTicket.Columns[2].HeaderText = "Seat Number";
            dgvTicket.Columns[2].Width = 80;

            dgvTicket.Columns[3].Name = "FilmName";
            dgvTicket.Columns[3].HeaderText = "Film Name";
            dgvTicket.Columns[3].Width = 91;

            dgvTicket.Columns[4].Name = "TanggalPesan";
            dgvTicket.Columns[4].HeaderText = "Tanggal Pesan";
            dgvTicket.Columns[4].Width = 91;

            dgvTicket.Columns[5].Name = "TicketValid";
            dgvTicket.Columns[5].HeaderText = "Ticket Valid";
            dgvTicket.Columns[5].Width = 91;
        }

        private void DgvTicket_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTicket.SelectedRows.Count > 0)
            {
                var selectedDate = DateTime.Parse(dgvTicket.SelectedRows[0].Cells["TicketValid"].Value.ToString());
                var currentDate = DateTime.Now;

                txtdate.Text = dgvTicket.SelectedRows[0].Cells["TicketValid"].Value.ToString();

                if (selectedDate <= currentDate)
                {
                    txtstatus.BackColor = Color.Red;
                    txtstatus.Text = "Tidak berlaku";
                }
                else
                {
                    txtstatus.BackColor = Color.Green;
                    txtstatus.Text = "Berlaku";
                }

                var Idpayment = dgvTicket.SelectedRows[0].Cells["IDPayment"].Value.ToString();
                var SeatNumber = dgvTicket.SelectedRows[0].Cells["SeatNumber"].Value.ToString();
                var TanggalValid = dgvTicket.SelectedRows[0].Cells["TicketValid"].Value.ToString();
                var selectedFilmName = dgvTicket.SelectedRows[0].Cells["FilmName"].Value.ToString();
                SetImageBasedOnFilmName(selectedFilmName);
                CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
                barcodeimage.Image = qrcode.Draw(bioskopent.Identity + Idpayment + SeatNumber + selectedFilmName + TanggalValid, 70);
            }
        }

        private void Loadticket()
        {
            List<(string Idpayment, string SeatNumber, string Filmname, string ticketvalid, string tanggalpesan)> loadticket = _controller.Loadticket(bioskopent.Identity);
            foreach ((string Idpayment, string SeatNumber, string Filmname, string ticketvalid, string tanggalpesan) in loadticket)
            {
                var noUrut = dgvTicket.Rows.Count + 1;
                dgvTicket.Rows.Add(noUrut.ToString(), Idpayment, SeatNumber, Filmname, tanggalpesan, ticketvalid);
            }
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
    }
}