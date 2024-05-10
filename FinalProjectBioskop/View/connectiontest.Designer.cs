namespace FinalProjectBioskop.View
{
    partial class connectiontest
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
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblRefreshinfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(78, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checking Connection to Database";
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblinfo.ForeColor = System.Drawing.Color.White;
            this.lblinfo.Location = new System.Drawing.Point(78, 88);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(222, 17);
            this.lblinfo.TabIndex = 1;
            this.lblinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRefreshinfo
            // 
            this.lblRefreshinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblRefreshinfo.Location = new System.Drawing.Point(24, 145);
            this.lblRefreshinfo.Name = "lblRefreshinfo";
            this.lblRefreshinfo.Size = new System.Drawing.Size(331, 17);
            this.lblRefreshinfo.TabIndex = 2;
            this.lblRefreshinfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProjectBioskop.Properties.Resources.ArabisStudio1;
            this.pictureBox1.Location = new System.Drawing.Point(135, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // connectiontest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 180);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRefreshinfo);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "connectiontest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "connectiontest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblRefreshinfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}