namespace AtamanApart
{
    partial class VisitorRegistry
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gorevli_personel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.temizle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cikis_saati = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.cikis_tarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.giris_saati = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.giris_tarihi = new System.Windows.Forms.DateTimePicker();
            this.kayit_ara = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ziyaret_edilen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ziyaretci_ad_soyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gorevli_personel);
            this.groupBox3.Controls.Add(this.temizle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cikis_saati);
            this.groupBox3.Controls.Add(this.monthCalendar1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cikis_tarihi);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.giris_saati);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.giris_tarihi);
            this.groupBox3.Controls.Add(this.kayit_ara);
            this.groupBox3.Controls.Add(this.ziyaret_edilen);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ziyaretci_ad_soyad);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox3.Location = new System.Drawing.Point(230, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 600);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ziyaretçi Bilgileri";
            // 
            // gorevli_personel
            // 
            this.gorevli_personel.Depth = 0;
            this.gorevli_personel.Hint = "";
            this.gorevli_personel.Location = new System.Drawing.Point(217, 555);
            this.gorevli_personel.MaxLength = 32767;
            this.gorevli_personel.MouseState = MaterialSkin.MouseState.HOVER;
            this.gorevli_personel.Name = "gorevli_personel";
            this.gorevli_personel.PasswordChar = '\0';
            this.gorevli_personel.SelectedText = "";
            this.gorevli_personel.SelectionLength = 0;
            this.gorevli_personel.SelectionStart = 0;
            this.gorevli_personel.Size = new System.Drawing.Size(263, 23);
            this.gorevli_personel.TabIndex = 78;
            this.gorevli_personel.TabStop = false;
            this.gorevli_personel.UseSystemPasswordChar = false;
            this.gorevli_personel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gorevli_personel_KeyPress);
            // 
            // temizle
            // 
            this.temizle.AutoSize = true;
            this.temizle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.temizle.Depth = 0;
            this.temizle.Icon = null;
            this.temizle.Location = new System.Drawing.Point(760, 550);
            this.temizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.temizle.Name = "temizle";
            this.temizle.Primary = true;
            this.temizle.Size = new System.Drawing.Size(76, 36);
            this.temizle.TabIndex = 76;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(36, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 74;
            this.label7.Text = "Görevli Personel:";
            // 
            // cikis_saati
            // 
            this.cikis_saati.Depth = 0;
            this.cikis_saati.Hint = "";
            this.cikis_saati.Location = new System.Drawing.Point(217, 485);
            this.cikis_saati.MaxLength = 32767;
            this.cikis_saati.MouseState = MaterialSkin.MouseState.HOVER;
            this.cikis_saati.Name = "cikis_saati";
            this.cikis_saati.PasswordChar = '\0';
            this.cikis_saati.SelectedText = "";
            this.cikis_saati.SelectionLength = 0;
            this.cikis_saati.SelectionStart = 0;
            this.cikis_saati.Size = new System.Drawing.Size(263, 23);
            this.cikis_saati.TabIndex = 73;
            this.cikis_saati.TabStop = false;
            this.cikis_saati.UseSystemPasswordChar = false;
            this.cikis_saati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cikis_saati_KeyPress);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(572, 152);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(36, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 72;
            this.label5.Text = "Çıkış Saati:";
            // 
            // cikis_tarihi
            // 
            this.cikis_tarihi.CustomFormat = "dd-MM-yyyy";
            this.cikis_tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cikis_tarihi.Location = new System.Drawing.Point(217, 412);
            this.cikis_tarihi.Name = "cikis_tarihi";
            this.cikis_tarihi.Size = new System.Drawing.Size(263, 26);
            this.cikis_tarihi.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(36, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 70;
            this.label6.Text = "Çıkış Tarihi:";
            // 
            // giris_saati
            // 
            this.giris_saati.Depth = 0;
            this.giris_saati.Hint = "";
            this.giris_saati.Location = new System.Drawing.Point(217, 345);
            this.giris_saati.MaxLength = 32767;
            this.giris_saati.MouseState = MaterialSkin.MouseState.HOVER;
            this.giris_saati.Name = "giris_saati";
            this.giris_saati.PasswordChar = '\0';
            this.giris_saati.SelectedText = "";
            this.giris_saati.SelectionLength = 0;
            this.giris_saati.SelectionStart = 0;
            this.giris_saati.Size = new System.Drawing.Size(263, 23);
            this.giris_saati.TabIndex = 68;
            this.giris_saati.TabStop = false;
            this.giris_saati.UseSystemPasswordChar = false;
            this.giris_saati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giris_saati_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(36, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "Giriş Saati:";
            // 
            // giris_tarihi
            // 
            this.giris_tarihi.CustomFormat = "";
            this.giris_tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.giris_tarihi.Location = new System.Drawing.Point(217, 273);
            this.giris_tarihi.Name = "giris_tarihi";
            this.giris_tarihi.Size = new System.Drawing.Size(263, 26);
            this.giris_tarihi.TabIndex = 66;
            // 
            // kayit_ara
            // 
            this.kayit_ara.AutoSize = true;
            this.kayit_ara.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kayit_ara.Depth = 0;
            this.kayit_ara.Icon = null;
            this.kayit_ara.Location = new System.Drawing.Point(390, 108);
            this.kayit_ara.MouseState = MaterialSkin.MouseState.HOVER;
            this.kayit_ara.Name = "kayit_ara";
            this.kayit_ara.Primary = true;
            this.kayit_ara.Size = new System.Drawing.Size(90, 36);
            this.kayit_ara.TabIndex = 11;
            this.kayit_ara.Text = "KAYIT ARA";
            this.kayit_ara.UseVisualStyleBackColor = true;
            this.kayit_ara.Click += new System.EventHandler(this.kayit_ara_Click);
            // 
            // ziyaret_edilen
            // 
            this.ziyaret_edilen.Depth = 0;
            this.ziyaret_edilen.Hint = "";
            this.ziyaret_edilen.Location = new System.Drawing.Point(217, 191);
            this.ziyaret_edilen.MaxLength = 32767;
            this.ziyaret_edilen.MouseState = MaterialSkin.MouseState.HOVER;
            this.ziyaret_edilen.Name = "ziyaret_edilen";
            this.ziyaret_edilen.PasswordChar = '\0';
            this.ziyaret_edilen.SelectedText = "";
            this.ziyaret_edilen.SelectionLength = 0;
            this.ziyaret_edilen.SelectionStart = 0;
            this.ziyaret_edilen.Size = new System.Drawing.Size(263, 23);
            this.ziyaret_edilen.TabIndex = 46;
            this.ziyaret_edilen.TabStop = false;
            this.ziyaret_edilen.UseSystemPasswordChar = false;
            this.ziyaret_edilen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ziyaret_edilen_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(36, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(36, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 44);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ziyaret Edilen\r\nÖğrenci:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ad Soyad:";
            // 
            // ziyaretci_ad_soyad
            // 
            this.ziyaretci_ad_soyad.Depth = 0;
            this.ziyaretci_ad_soyad.Hint = "";
            this.ziyaretci_ad_soyad.Location = new System.Drawing.Point(217, 50);
            this.ziyaretci_ad_soyad.MaxLength = 32767;
            this.ziyaretci_ad_soyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.ziyaretci_ad_soyad.Name = "ziyaretci_ad_soyad";
            this.ziyaretci_ad_soyad.PasswordChar = '\0';
            this.ziyaretci_ad_soyad.SelectedText = "";
            this.ziyaretci_ad_soyad.SelectionLength = 0;
            this.ziyaretci_ad_soyad.SelectionStart = 0;
            this.ziyaretci_ad_soyad.Size = new System.Drawing.Size(263, 23);
            this.ziyaretci_ad_soyad.TabIndex = 35;
            this.ziyaretci_ad_soyad.TabStop = false;
            this.ziyaretci_ad_soyad.UseSystemPasswordChar = false;
            this.ziyaretci_ad_soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ziyaretci_ad_soyad_KeyPress);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Olive;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.ForeColor = System.Drawing.SystemColors.Window;
            this.sil.Location = new System.Drawing.Point(25, 450);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(190, 60);
            this.sil.TabIndex = 81;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.Olive;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.guncelle.Location = new System.Drawing.Point(25, 350);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(190, 60);
            this.guncelle.TabIndex = 80;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.Olive;
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ForeColor = System.Drawing.SystemColors.Window;
            this.ekle.Location = new System.Drawing.Point(25, 250);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(190, 60);
            this.ekle.TabIndex = 79;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // geri
            // 
            this.geri.Image = global::AtamanApart.Properties.Resources.backw;
            this.geri.Location = new System.Drawing.Point(0, 65);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(40, 35);
            this.geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geri.TabIndex = 82;
            this.geri.TabStop = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // VisitorRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ekle);
            this.MaximizeBox = false;
            this.Name = "VisitorRegistry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRaisedButton kayit_ara;
        private MaterialSkin.Controls.MaterialSingleLineTextField ziyaret_edilen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField ziyaretci_ad_soyad;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialSingleLineTextField giris_saati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker giris_tarihi;
        private MaterialSkin.Controls.MaterialSingleLineTextField cikis_saati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker cikis_tarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialRaisedButton temizle;
        private MaterialSkin.Controls.MaterialSingleLineTextField gorevli_personel;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.PictureBox geri;
    }
}