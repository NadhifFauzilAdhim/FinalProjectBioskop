namespace FinalProjectBioskop
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtidlogin = new System.Windows.Forms.TextBox();
            this.txtnamalogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btndaftar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusernameregister = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpasswordusername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Silahkan Masukan ID dan Username";
            // 
            // txtidlogin
            // 
            this.txtidlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtidlogin.Location = new System.Drawing.Point(52, 220);
            this.txtidlogin.Name = "txtidlogin";
            this.txtidlogin.PasswordChar = '•';
            this.txtidlogin.Size = new System.Drawing.Size(259, 26);
            this.txtidlogin.TabIndex = 3;
            // 
            // txtnamalogin
            // 
            this.txtnamalogin.BackColor = System.Drawing.Color.White;
            this.txtnamalogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtnamalogin.Location = new System.Drawing.Point(52, 163);
            this.txtnamalogin.Name = "txtnamalogin";
            this.txtnamalogin.Size = new System.Drawing.Size(259, 26);
            this.txtnamalogin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(51, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Username";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(126, 265);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(87, 28);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(365, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 387);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnlogin);
            this.tabPage1.Controls.Add(this.txtnamalogin);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtidlogin);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(343, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btndaftar);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtusernameregister);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtpasswordusername);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Regsiter";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "REGISTER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndaftar
            // 
            this.btndaftar.Location = new System.Drawing.Point(133, 264);
            this.btndaftar.Name = "btndaftar";
            this.btndaftar.Size = new System.Drawing.Size(87, 28);
            this.btndaftar.TabIndex = 16;
            this.btndaftar.Text = "Daftar";
            this.btndaftar.UseVisualStyleBackColor = true;
            this.btndaftar.Click += new System.EventHandler(this.btndaftar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(47, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Silahkan Masukan ID dan Username";
            // 
            // txtusernameregister
            // 
            this.txtusernameregister.BackColor = System.Drawing.Color.White;
            this.txtusernameregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtusernameregister.Location = new System.Drawing.Point(51, 158);
            this.txtusernameregister.Name = "txtusernameregister";
            this.txtusernameregister.Size = new System.Drawing.Size(259, 26);
            this.txtusernameregister.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Username";
            // 
            // txtpasswordusername
            // 
            this.txtpasswordusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtpasswordusername.Location = new System.Drawing.Point(51, 215);
            this.txtpasswordusername.Name = "txtpasswordusername";
            this.txtpasswordusername.PasswordChar = '•';
            this.txtpasswordusername.Size = new System.Drawing.Size(259, 26);
            this.txtpasswordusername.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(50, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.BackColor = System.Drawing.Color.Transparent;
            this.lblinfo.Location = new System.Drawing.Point(12, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 13);
            this.lblinfo.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProjectBioskop.Properties.Resources.BackgroundLogin;
            this.ClientSize = new System.Drawing.Size(715, 385);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtidlogin;
        private System.Windows.Forms.TextBox txtnamalogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndaftar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtusernameregister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpasswordusername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblinfo;
    }
}