using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FinalProjectBioskop.View
{
    public partial class connectiontest : Form
    {
        private Timer delayTimer;
        private Timer refreshTimer;
        private int refreshCountdown;
        private bool isConnected; 

        public connectiontest()
        {
            InitializeComponent();
            this.Load += ConnectionTestForm_Load;
        }

        private void ConnectionTestForm_Load(object sender, EventArgs e)
        {
            this.Show();
            delayTimer = new Timer();
            delayTimer.Interval = 500;
            delayTimer.Tick += DelayTimer_Tick;
            delayTimer.Start();

            refreshTimer = new Timer();
            refreshTimer.Interval = 1000; 
            refreshTimer.Tick += RefreshTimer_Tick;
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            delayTimer.Stop();
            CheckConnection();
            StartRefreshCountdown();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            if (refreshCountdown > 0)
            {
                lblRefreshinfo.Text = "Menghubungkan ulang dalam " + refreshCountdown + " detik...";
                refreshCountdown--;
            }
            else
            {
                lblRefreshinfo.Text = "Reconnect...";
                CheckConnection();
                StartRefreshCountdown();
            }
        }

        private void StartRefreshCountdown()
        {
            refreshCountdown = 10;
            refreshTimer.Start();
        }

        private MySqlConnection GetOpenConnection()
        {
            return DatabaseConnection.GetOpenConnection();
        }

        private void CheckConnection()
        {
            if (isConnected) return;

            try
            {
                using (MySqlConnection connection = GetOpenConnection())
                {
                    UpdateConnectionStatus(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isConnected)
            {
                refreshTimer.Stop();
            }
        }

        private void UpdateConnectionStatus(MySqlConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                lblinfo.Text = "Connected";
                lblinfo.BackColor = Color.Green;
                isConnected = true;
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                lblinfo.Text = "Disconnected";
                lblinfo.BackColor = Color.Red;
            }
        }
    }
}