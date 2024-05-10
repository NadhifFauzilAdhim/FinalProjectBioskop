namespace FinalProjectBioskop
{
    partial class FilmInformation
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtjamtayang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgenre = new System.Windows.Forms.TextBox();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdurasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnamafilm = new System.Windows.Forms.TextBox();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.lblfilmname = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtjamtayang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtharga);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtgenre);
            this.groupBox1.Controls.Add(this.BtnOrder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdurasi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtnamafilm);
            this.groupBox1.Controls.Add(this.picturebox);
            this.groupBox1.Location = new System.Drawing.Point(0, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(403, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Jam Tayang";
            // 
            // txtjamtayang
            // 
            this.txtjamtayang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtjamtayang.Location = new System.Drawing.Point(406, 255);
            this.txtjamtayang.Name = "txtjamtayang";
            this.txtjamtayang.ReadOnly = true;
            this.txtjamtayang.Size = new System.Drawing.Size(296, 31);
            this.txtjamtayang.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(403, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Harga Tiket / orang";
            // 
            // txtharga
            // 
            this.txtharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtharga.Location = new System.Drawing.Point(406, 337);
            this.txtharga.Name = "txtharga";
            this.txtharga.ReadOnly = true;
            this.txtharga.Size = new System.Drawing.Size(296, 31);
            this.txtharga.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(403, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Genre, Tahun Rilis";
            // 
            // txtgenre
            // 
            this.txtgenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtgenre.Location = new System.Drawing.Point(406, 185);
            this.txtgenre.Name = "txtgenre";
            this.txtgenre.ReadOnly = true;
            this.txtgenre.Size = new System.Drawing.Size(296, 31);
            this.txtgenre.TabIndex = 14;
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.Khaki;
            this.BtnOrder.Location = new System.Drawing.Point(406, 391);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(296, 29);
            this.BtnOrder.TabIndex = 13;
            this.BtnOrder.Text = "Pesan Tiket";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(403, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Durasi";
            // 
            // txtdurasi
            // 
            this.txtdurasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtdurasi.Location = new System.Drawing.Point(406, 116);
            this.txtdurasi.Name = "txtdurasi";
            this.txtdurasi.ReadOnly = true;
            this.txtdurasi.Size = new System.Drawing.Size(296, 31);
            this.txtdurasi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(403, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Film";
            // 
            // txtnamafilm
            // 
            this.txtnamafilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtnamafilm.Location = new System.Drawing.Point(406, 48);
            this.txtnamafilm.Name = "txtnamafilm";
            this.txtnamafilm.ReadOnly = true;
            this.txtnamafilm.Size = new System.Drawing.Size(296, 31);
            this.txtnamafilm.TabIndex = 3;
            // 
            // picturebox
            // 
            this.picturebox.InitialImage = null;
            this.picturebox.Location = new System.Drawing.Point(61, 28);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(291, 392);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // lblfilmname
            // 
            this.lblfilmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblfilmname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblfilmname.Location = new System.Drawing.Point(301, 25);
            this.lblfilmname.Name = "lblfilmname";
            this.lblfilmname.Size = new System.Drawing.Size(231, 28);
            this.lblfilmname.TabIndex = 1;
            this.lblfilmname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FinalProjectBioskop.Properties.Resources.ArabisStudioWhite;
            this.pictureBox2.Location = new System.Drawing.Point(6, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lblfilmname);
            this.groupBox2.Location = new System.Drawing.Point(0, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 74);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // FilmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FilmInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FILM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfilmname;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.TextBox txtdurasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnamafilm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.TextBox txtgenre;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtjamtayang;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}