namespace AtamanApart
{
    partial class StaffRegistry
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
            this.sil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pozisyon = new System.Windows.Forms.ComboBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.temizle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tel_no = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kayit_ara = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ad_soyadi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_kimlikno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.guncelle = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).BeginInit();
            this.SuspendLayout();
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
            this.sil.TabIndex = 85;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pozisyon);
            this.groupBox3.Controls.Add(this.adres);
            this.groupBox3.Controls.Add(this.temizle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tel_no);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.kayit_ara);
            this.groupBox3.Controls.Add(this.ad_soyadi);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tc_kimlikno);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox3.Location = new System.Drawing.Point(230, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 600);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Bilgileri";
            // 
            // pozisyon
            // 
            this.pozisyon.FormattingEnabled = true;
            this.pozisyon.Items.AddRange(new object[] {
            "Güvenlik",
            "Temizlik",
            "Yönetim"});
            this.pozisyon.Location = new System.Drawing.Point(236, 371);
            this.pozisyon.Name = "pozisyon";
            this.pozisyon.Size = new System.Drawing.Size(263, 28);
            this.pozisyon.TabIndex = 80;
            // 
            // adres
            // 
            this.adres.BackColor = System.Drawing.SystemColors.Window;
            this.adres.Location = new System.Drawing.Point(617, 52);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(206, 347);
            this.adres.TabIndex = 79;
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
            this.label7.Location = new System.Drawing.Point(33, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 22);
            this.label7.TabIndex = 74;
            this.label7.Text = "Pozisyon:";
            // 
            // tel_no
            // 
            this.tel_no.Depth = 0;
            this.tel_no.Hint = "";
            this.tel_no.Location = new System.Drawing.Point(236, 277);
            this.tel_no.MaxLength = 32767;
            this.tel_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.tel_no.Name = "tel_no";
            this.tel_no.PasswordChar = '\0';
            this.tel_no.SelectedText = "";
            this.tel_no.SelectionLength = 0;
            this.tel_no.SelectionStart = 0;
            this.tel_no.Size = new System.Drawing.Size(263, 23);
            this.tel_no.TabIndex = 73;
            this.tel_no.TabStop = false;
            this.tel_no.UseSystemPasswordChar = false;
            this.tel_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_no_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(33, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 72;
            this.label5.Text = "Telefon Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(512, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 67;
            this.label2.Text = "Adres:";
            // 
            // kayit_ara
            // 
            this.kayit_ara.AutoSize = true;
            this.kayit_ara.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kayit_ara.Depth = 0;
            this.kayit_ara.Icon = null;
            this.kayit_ara.Location = new System.Drawing.Point(409, 109);
            this.kayit_ara.MouseState = MaterialSkin.MouseState.HOVER;
            this.kayit_ara.Name = "kayit_ara";
            this.kayit_ara.Primary = true;
            this.kayit_ara.Size = new System.Drawing.Size(90, 36);
            this.kayit_ara.TabIndex = 11;
            this.kayit_ara.Text = "KAYIT ARA";
            this.kayit_ara.UseVisualStyleBackColor = true;
            this.kayit_ara.Click += new System.EventHandler(this.kayit_ara_Click);
            // 
            // ad_soyadi
            // 
            this.ad_soyadi.Depth = 0;
            this.ad_soyadi.Hint = "";
            this.ad_soyadi.Location = new System.Drawing.Point(236, 169);
            this.ad_soyadi.MaxLength = 32767;
            this.ad_soyadi.MouseState = MaterialSkin.MouseState.HOVER;
            this.ad_soyadi.Name = "ad_soyadi";
            this.ad_soyadi.PasswordChar = '\0';
            this.ad_soyadi.SelectedText = "";
            this.ad_soyadi.SelectionLength = 0;
            this.ad_soyadi.SelectionStart = 0;
            this.ad_soyadi.Size = new System.Drawing.Size(263, 23);
            this.ad_soyadi.TabIndex = 46;
            this.ad_soyadi.TabStop = false;
            this.ad_soyadi.UseSystemPasswordChar = false;
            this.ad_soyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_soyadi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(33, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ad Soyad:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro Med", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "T.C. Kimlik Numarası:";
            // 
            // tc_kimlikno
            // 
            this.tc_kimlikno.Depth = 0;
            this.tc_kimlikno.Hint = "";
            this.tc_kimlikno.Location = new System.Drawing.Point(236, 52);
            this.tc_kimlikno.MaxLength = 32767;
            this.tc_kimlikno.MouseState = MaterialSkin.MouseState.HOVER;
            this.tc_kimlikno.Name = "tc_kimlikno";
            this.tc_kimlikno.PasswordChar = '\0';
            this.tc_kimlikno.SelectedText = "";
            this.tc_kimlikno.SelectionLength = 0;
            this.tc_kimlikno.SelectionStart = 0;
            this.tc_kimlikno.Size = new System.Drawing.Size(263, 23);
            this.tc_kimlikno.TabIndex = 35;
            this.tc_kimlikno.TabStop = false;
            this.tc_kimlikno.UseSystemPasswordChar = false;
            this.tc_kimlikno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_kimlikno_KeyPress);
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
            this.guncelle.TabIndex = 84;
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
            this.ekle.TabIndex = 83;
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
            this.geri.TabIndex = 86;
            this.geri.TabStop = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // StaffRegistry
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
            this.Name = "StaffRegistry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRaisedButton temizle;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField tel_no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton kayit_ara;
        private MaterialSkin.Controls.MaterialSingleLineTextField ad_soyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tc_kimlikno;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.ComboBox pozisyon;
        private System.Windows.Forms.PictureBox geri;
    }
}