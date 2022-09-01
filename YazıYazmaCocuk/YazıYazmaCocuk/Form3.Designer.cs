
namespace YazıYazmaCocuk
{
    partial class Form3
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
            this.txtSure = new System.Windows.Forms.TextBox();
            this.lstKaydet = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.basla = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblKelime = new System.Windows.Forms.Label();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSure
            // 
            this.txtSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSure.Location = new System.Drawing.Point(13, 13);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(142, 26);
            this.txtSure.TabIndex = 0;
            this.txtSure.Text = "00:00:00";
            this.txtSure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstKaydet
            // 
            this.lstKaydet.FormattingEnabled = true;
            this.lstKaydet.ItemHeight = 16;
            this.lstKaydet.Location = new System.Drawing.Point(551, 58);
            this.lstKaydet.Name = "lstKaydet";
            this.lstKaydet.Size = new System.Drawing.Size(199, 276);
            this.lstKaydet.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(13, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 276);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // basla
            // 
            this.basla.Location = new System.Drawing.Point(12, 340);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(114, 37);
            this.basla.TabIndex = 3;
            this.basla.Text = "Basla";
            this.basla.UseVisualStyleBackColor = true;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(132, 340);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(114, 37);
            this.stop.TabIndex = 4;
            this.stop.Text = "Bitir";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kelime Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(551, 340);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(114, 37);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Verileri Sil";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelime.Location = new System.Drawing.Point(297, 9);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(0, 20);
            this.lblKelime.TabIndex = 7;
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(304, 16);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(174, 22);
            this.txtVeri.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YazıYazmaCocuk.Properties.Resources.stock_photo_woman_playing_toy_boat_blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVeri);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.basla);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstKaydet);
            this.Controls.Add(this.txtSure);
            this.Name = "Form3";
            this.Text = "7 Yaş Rastgele";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.ListBox lstKaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.TextBox txtVeri;
    }
}