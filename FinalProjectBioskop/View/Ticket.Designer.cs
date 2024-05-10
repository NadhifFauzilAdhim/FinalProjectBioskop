namespace FinalProjectBioskop.View
{
    partial class Ticket
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblheader = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.barcodeimage = new System.Windows.Forms.PictureBox();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.groupBox1.Controls.Add(this.lblheader);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblheader
            // 
            this.lblheader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.White;
            this.lblheader.Location = new System.Drawing.Point(253, 27);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(658, 25);
            this.lblheader.TabIndex = 32;
            this.lblheader.Text = "TICKET KAMU";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtdate.Location = new System.Drawing.Point(853, 363);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(246, 26);
            this.txtdate.TabIndex = 6;
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(934, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiket Valid Sampai";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(243, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(658, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "*Pilih pada list untuk melihat detail";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtstatus
            // 
            this.txtstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtstatus.ForeColor = System.Drawing.Color.White;
            this.txtstatus.Location = new System.Drawing.Point(917, 418);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(124, 26);
            this.txtstatus.TabIndex = 34;
            this.txtstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(949, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tiket Status";
            // 
            // dgvTicket
            // 
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Location = new System.Drawing.Point(30, 113);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.Size = new System.Drawing.Size(473, 351);
            this.dgvTicket.TabIndex = 36;
            // 
            // barcodeimage
            // 
            this.barcodeimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barcodeimage.InitialImage = null;
            this.barcodeimage.Location = new System.Drawing.Point(867, 113);
            this.barcodeimage.Name = "barcodeimage";
            this.barcodeimage.Size = new System.Drawing.Size(222, 222);
            this.barcodeimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.barcodeimage.TabIndex = 31;
            this.barcodeimage.TabStop = false;
            // 
            // picturebox
            // 
            this.picturebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturebox.InitialImage = null;
            this.picturebox.Location = new System.Drawing.Point(573, 113);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(261, 331);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 5;
            this.picturebox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FinalProjectBioskop.Properties.Resources.ArabisStudioWhite;
            this.pictureBox1.Location = new System.Drawing.Point(6, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 533);
            this.Controls.Add(this.dgvTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barcodeimage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox barcodeimage;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTicket;
    }
}