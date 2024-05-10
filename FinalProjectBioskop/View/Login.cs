using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectBioskop.Model.Repository;
using MySql.Data.MySqlClient;
using FinalProjectBioskop.Controller;
using FinalProjectBioskop.Model.Entity;


namespace FinalProjectBioskop
{
    public partial class Login : Form
    {

        private readonly BioskopController _controller;
        Bioskop bioskopent = new Bioskop();
       
        public Login()
        {
            InitializeComponent();
            _controller = new BioskopController();
        }

        private static string Encrypt(string encryptString)
        {         
            string EncryptionKey = "NjFaM2022"; 
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }
       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtidlogin.Text) || string.IsNullOrEmpty(txtnamalogin.Text))
            {
                MessageBox.Show("Username dan Password harus diisi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {        
                var plainpass = txtidlogin.Text;
                var nama = txtnamalogin.Text; 
                var encryp = Encrypt(plainpass);
                lblinfo.Text = "Menghubungkan ke Database, Mohon tunggu";
                var identity = _controller.Login(encryp, nama);
                bioskopent.Identity = identity;

                if (identity != null)
                {
                    HomePage homepage = new HomePage(bioskopent);
                    homepage.Show();
                    this.Hide();
                    
                }
            }        
        }
        private void btndaftar_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtpasswordusername.Text) || string.IsNullOrEmpty(txtusernameregister.Text))
            {
                MessageBox.Show("Username dan Password harus diisi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var plainpass = txtpasswordusername.Text;
                var nama = txtusernameregister.Text;
                var encryp = Encrypt(plainpass);
                _controller.Daftar(encryp, nama);
            }
        }
    }
}
