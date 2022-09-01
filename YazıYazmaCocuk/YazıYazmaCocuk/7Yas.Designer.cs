
namespace YazıYazmaCocuk
{
    partial class _7Yas
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
            this.KlmEkle = new System.Windows.Forms.Button();
            this.basla = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.lstKaydet = new System.Windows.Forms.ListBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.lblKelime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKelimeEkle = new System.Windows.Forms.TextBox();
            this.sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KlmEkle
            // 
            this.KlmEkle.Location = new System.Drawing.Point(12, 399);
            this.KlmEkle.Name = "KlmEkle";
            this.KlmEkle.Size = new System.Drawing.Size(137, 39);
            this.KlmEkle.TabIndex = 0;
            this.KlmEkle.Text = "Kelime Ekle";
            this.KlmEkle.UseVisualStyleBackColor = true;
            this.KlmEkle.Click += new System.EventHandler(this.KlmEkle_Click);
            // 
            // basla
            // 
            this.basla.Enabled = false;
            this.basla.Location = new System.Drawing.Point(155, 399);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(137, 39);
            this.basla.TabIndex = 1;
            this.basla.Text = "Başla";
            this.basla.UseVisualStyleBackColor = true;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(298, 399);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(137, 39);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Bitir";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // lstKaydet
            // 
            this.lstKaydet.FormattingEnabled = true;
            this.lstKaydet.ItemHeight = 16;
            this.lstKaydet.Location = new System.Drawing.Point(627, 46);
            this.lstKaydet.Name = "lstKaydet";
            this.lstKaydet.Size = new System.Drawing.Size(161, 180);
            this.lstKaydet.TabIndex = 3;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(627, 18);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(161, 22);
            this.txtSure.TabIndex = 4;
            this.txtSure.Text = "00:00:00";
            this.txtSure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelime.Location = new System.Drawing.Point(293, 9);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(0, 25);
            this.lblKelime.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(45, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 347);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // txtKelimeEkle
            // 
            this.txtKelimeEkle.Location = new System.Drawing.Point(15, 445);
            this.txtKelimeEkle.Name = "txtKelimeEkle";
            this.txtKelimeEkle.Size = new System.Drawing.Size(134, 22);
            this.txtKelimeEkle.TabIndex = 7;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(627, 232);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(137, 39);
            this.sil.TabIndex = 8;
            this.sil.Text = "Verileri Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // _7Yas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::YazıYazmaCocuk.Properties.Resources.stock_photo_woman_playing_toy_boat_blue;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.txtKelimeEkle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.lstKaydet);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.basla);
            this.Controls.Add(this.KlmEkle);
            this.Name = "_7Yas";
            this.Text = "_7Yas";
            this.Load += new System.EventHandler(this._7Yas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KlmEkle;
        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ListBox lstKaydet;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKelimeEkle;
        private System.Windows.Forms.Button sil;
    }
}