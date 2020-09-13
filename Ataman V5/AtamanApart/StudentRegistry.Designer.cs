namespace AtamanApart
{
    partial class StudentRegistry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistry));
            this.label13 = new System.Windows.Forms.Label();
            this.tc_no = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.saglik = new System.Windows.Forms.Label();
            this.sicil = new System.Windows.Forms.Label();
            this.ogrencibelge = new System.Windows.Forms.Label();
            this.kimlik = new System.Windows.Forms.Label();
            this.saglikraporyol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saglikraporu_ekle = new System.Windows.Forms.Button();
            this.sicilyol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sicilkaydi_ekle = new System.Windows.Forms.Button();
            this.ogrencibelgeyol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ogrencibelge_ekle = new System.Windows.Forms.Button();
            this.kimlikyol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.kimlik_ekle = new System.Windows.Forms.Button();
            this.saglikraporulabel = new System.Windows.Forms.Label();
            this.sicillabel = new System.Windows.Forms.Label();
            this.belgelabel = new System.Windows.Forms.Label();
            this.kimliklabel = new System.Windows.Forms.Label();
            this.oda_no = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label14 = new System.Windows.Forms.Label();
            this.durum_pasif = new MaterialSkin.Controls.MaterialRadioButton();
            this.durum_aktif = new MaterialSkin.Controls.MaterialRadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.kayit_ara = new MaterialSkin.Controls.MaterialRaisedButton();
            this.temizle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.yakin_tel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.baba_adsoyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.anne_adsoyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ikanetgah = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sehir = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tel_no = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.sinif = new System.Windows.Forms.ComboBox();
            this.okul = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.d_tarih = new System.Windows.Forms.DateTimePicker();
            this.bolum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.soyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ekle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kapat = new System.Windows.Forms.PictureBox();
            this.geri = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Olive;
            this.label13.Location = new System.Drawing.Point(12, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "T.C Kimlik Numarası:";
            // 
            // tc_no
            // 
            this.tc_no.Depth = 0;
            this.tc_no.Hint = "";
            this.tc_no.Location = new System.Drawing.Point(169, 26);
            this.tc_no.MaxLength = 32767;
            this.tc_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.tc_no.Name = "tc_no";
            this.tc_no.PasswordChar = '\0';
            this.tc_no.SelectedText = "";
            this.tc_no.SelectionLength = 0;
            this.tc_no.SelectionStart = 0;
            this.tc_no.Size = new System.Drawing.Size(263, 23);
            this.tc_no.TabIndex = 35;
            this.tc_no.TabStop = false;
            this.tc_no.UseSystemPasswordChar = false;
            this.tc_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_no_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.axAcroPDF1);
            this.groupBox3.Controls.Add(this.saglik);
            this.groupBox3.Controls.Add(this.sicil);
            this.groupBox3.Controls.Add(this.ogrencibelge);
            this.groupBox3.Controls.Add(this.kimlik);
            this.groupBox3.Controls.Add(this.saglikraporyol);
            this.groupBox3.Controls.Add(this.saglikraporu_ekle);
            this.groupBox3.Controls.Add(this.sicilyol);
            this.groupBox3.Controls.Add(this.sicilkaydi_ekle);
            this.groupBox3.Controls.Add(this.ogrencibelgeyol);
            this.groupBox3.Controls.Add(this.ogrencibelge_ekle);
            this.groupBox3.Controls.Add(this.kimlikyol);
            this.groupBox3.Controls.Add(this.kimlik_ekle);
            this.groupBox3.Controls.Add(this.saglikraporulabel);
            this.groupBox3.Controls.Add(this.sicillabel);
            this.groupBox3.Controls.Add(this.belgelabel);
            this.groupBox3.Controls.Add(this.kimliklabel);
            this.groupBox3.Controls.Add(this.oda_no);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.durum_pasif);
            this.groupBox3.Controls.Add(this.durum_aktif);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.kayit_ara);
            this.groupBox3.Controls.Add(this.temizle);
            this.groupBox3.Controls.Add(this.yakin_tel);
            this.groupBox3.Controls.Add(this.baba_adsoyad);
            this.groupBox3.Controls.Add(this.anne_adsoyad);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ikanetgah);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.sehir);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tel_no);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.sinif);
            this.groupBox3.Controls.Add(this.okul);
            this.groupBox3.Controls.Add(this.d_tarih);
            this.groupBox3.Controls.Add(this.bolum);
            this.groupBox3.Controls.Add(this.soyad);
            this.groupBox3.Controls.Add(this.ad);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tc_no);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox3.Location = new System.Drawing.Point(230, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 600);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Bilgileri";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(850, 600);
            this.axAcroPDF1.TabIndex = 90;
            this.axAcroPDF1.Visible = false;
            // 
            // saglik
            // 
            this.saglik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saglik.ForeColor = System.Drawing.Color.SaddleBrown;
            this.saglik.Location = new System.Drawing.Point(616, 514);
            this.saglik.Name = "saglik";
            this.saglik.Size = new System.Drawing.Size(127, 20);
            this.saglik.TabIndex = 89;
            this.saglik.DoubleClick += new System.EventHandler(this.saglik_DoubleClick);
            // 
            // sicil
            // 
            this.sicil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sicil.ForeColor = System.Drawing.Color.SaddleBrown;
            this.sicil.Location = new System.Drawing.Point(616, 473);
            this.sicil.Name = "sicil";
            this.sicil.Size = new System.Drawing.Size(127, 20);
            this.sicil.TabIndex = 88;
            this.sicil.DoubleClick += new System.EventHandler(this.sicil_DoubleClick);
            // 
            // ogrencibelge
            // 
            this.ogrencibelge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrencibelge.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ogrencibelge.Location = new System.Drawing.Point(616, 428);
            this.ogrencibelge.Name = "ogrencibelge";
            this.ogrencibelge.Size = new System.Drawing.Size(127, 20);
            this.ogrencibelge.TabIndex = 87;
            this.ogrencibelge.DoubleClick += new System.EventHandler(this.ogrencibelge_DoubleClick);
            // 
            // kimlik
            // 
            this.kimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kimlik.ForeColor = System.Drawing.Color.SaddleBrown;
            this.kimlik.Location = new System.Drawing.Point(616, 385);
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(127, 22);
            this.kimlik.TabIndex = 86;
            this.kimlik.DoubleClick += new System.EventHandler(this.kimlik_DoubleClick);
            // 
            // saglikraporyol
            // 
            this.saglikraporyol.Depth = 0;
            this.saglikraporyol.Hint = "";
            this.saglikraporyol.Location = new System.Drawing.Point(480, 539);
            this.saglikraporyol.MaxLength = 32767;
            this.saglikraporyol.MouseState = MaterialSkin.MouseState.HOVER;
            this.saglikraporyol.Name = "saglikraporyol";
            this.saglikraporyol.PasswordChar = '\0';
            this.saglikraporyol.SelectedText = "";
            this.saglikraporyol.SelectionLength = 0;
            this.saglikraporyol.SelectionStart = 0;
            this.saglikraporyol.Size = new System.Drawing.Size(116, 23);
            this.saglikraporyol.TabIndex = 85;
            this.saglikraporyol.TabStop = false;
            this.saglikraporyol.UseSystemPasswordChar = false;
            this.saglikraporyol.Visible = false;
            // 
            // saglikraporu_ekle
            // 
            this.saglikraporu_ekle.BackColor = System.Drawing.Color.Olive;
            this.saglikraporu_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saglikraporu_ekle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saglikraporu_ekle.ForeColor = System.Drawing.SystemColors.Window;
            this.saglikraporu_ekle.Location = new System.Drawing.Point(749, 510);
            this.saglikraporu_ekle.Name = "saglikraporu_ekle";
            this.saglikraporu_ekle.Size = new System.Drawing.Size(65, 30);
            this.saglikraporu_ekle.TabIndex = 81;
            this.saglikraporu_ekle.Text = "EKLE";
            this.saglikraporu_ekle.UseVisualStyleBackColor = false;
            this.saglikraporu_ekle.Click += new System.EventHandler(this.saglikraporu_ekle_Click);
            // 
            // sicilyol
            // 
            this.sicilyol.Depth = 0;
            this.sicilyol.Hint = "";
            this.sicilyol.Location = new System.Drawing.Point(480, 491);
            this.sicilyol.MaxLength = 32767;
            this.sicilyol.MouseState = MaterialSkin.MouseState.HOVER;
            this.sicilyol.Name = "sicilyol";
            this.sicilyol.PasswordChar = '\0';
            this.sicilyol.SelectedText = "";
            this.sicilyol.SelectionLength = 0;
            this.sicilyol.SelectionStart = 0;
            this.sicilyol.Size = new System.Drawing.Size(116, 23);
            this.sicilyol.TabIndex = 84;
            this.sicilyol.TabStop = false;
            this.sicilyol.UseSystemPasswordChar = false;
            this.sicilyol.Visible = false;
            // 
            // sicilkaydi_ekle
            // 
            this.sicilkaydi_ekle.BackColor = System.Drawing.Color.Olive;
            this.sicilkaydi_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sicilkaydi_ekle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sicilkaydi_ekle.ForeColor = System.Drawing.SystemColors.Window;
            this.sicilkaydi_ekle.Location = new System.Drawing.Point(749, 467);
            this.sicilkaydi_ekle.Name = "sicilkaydi_ekle";
            this.sicilkaydi_ekle.Size = new System.Drawing.Size(65, 30);
            this.sicilkaydi_ekle.TabIndex = 80;
            this.sicilkaydi_ekle.Text = "EKLE";
            this.sicilkaydi_ekle.UseVisualStyleBackColor = false;
            this.sicilkaydi_ekle.Click += new System.EventHandler(this.sicilkaydi_ekle_Click);
            // 
            // ogrencibelgeyol
            // 
            this.ogrencibelgeyol.Depth = 0;
            this.ogrencibelgeyol.Hint = "";
            this.ogrencibelgeyol.Location = new System.Drawing.Point(480, 448);
            this.ogrencibelgeyol.MaxLength = 32767;
            this.ogrencibelgeyol.MouseState = MaterialSkin.MouseState.HOVER;
            this.ogrencibelgeyol.Name = "ogrencibelgeyol";
            this.ogrencibelgeyol.PasswordChar = '\0';
            this.ogrencibelgeyol.SelectedText = "";
            this.ogrencibelgeyol.SelectionLength = 0;
            this.ogrencibelgeyol.SelectionStart = 0;
            this.ogrencibelgeyol.Size = new System.Drawing.Size(116, 23);
            this.ogrencibelgeyol.TabIndex = 83;
            this.ogrencibelgeyol.TabStop = false;
            this.ogrencibelgeyol.UseSystemPasswordChar = false;
            this.ogrencibelgeyol.Visible = false;
            // 
            // ogrencibelge_ekle
            // 
            this.ogrencibelge_ekle.BackColor = System.Drawing.Color.Olive;
            this.ogrencibelge_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrencibelge_ekle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencibelge_ekle.ForeColor = System.Drawing.SystemColors.Window;
            this.ogrencibelge_ekle.Location = new System.Drawing.Point(749, 424);
            this.ogrencibelge_ekle.Name = "ogrencibelge_ekle";
            this.ogrencibelge_ekle.Size = new System.Drawing.Size(65, 30);
            this.ogrencibelge_ekle.TabIndex = 79;
            this.ogrencibelge_ekle.Text = "EKLE";
            this.ogrencibelge_ekle.UseVisualStyleBackColor = false;
            this.ogrencibelge_ekle.Click += new System.EventHandler(this.ogrencibelge_ekle_Click);
            // 
            // kimlikyol
            // 
            this.kimlikyol.Depth = 0;
            this.kimlikyol.Hint = "";
            this.kimlikyol.Location = new System.Drawing.Point(480, 405);
            this.kimlikyol.MaxLength = 32767;
            this.kimlikyol.MouseState = MaterialSkin.MouseState.HOVER;
            this.kimlikyol.Name = "kimlikyol";
            this.kimlikyol.PasswordChar = '\0';
            this.kimlikyol.SelectedText = "";
            this.kimlikyol.SelectionLength = 0;
            this.kimlikyol.SelectionStart = 0;
            this.kimlikyol.Size = new System.Drawing.Size(116, 23);
            this.kimlikyol.TabIndex = 82;
            this.kimlikyol.TabStop = false;
            this.kimlikyol.UseSystemPasswordChar = false;
            this.kimlikyol.Visible = false;
            // 
            // kimlik_ekle
            // 
            this.kimlik_ekle.BackColor = System.Drawing.Color.Olive;
            this.kimlik_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kimlik_ekle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kimlik_ekle.ForeColor = System.Drawing.SystemColors.Window;
            this.kimlik_ekle.Location = new System.Drawing.Point(749, 381);
            this.kimlik_ekle.Name = "kimlik_ekle";
            this.kimlik_ekle.Size = new System.Drawing.Size(65, 30);
            this.kimlik_ekle.TabIndex = 11;
            this.kimlik_ekle.Text = "EKLE";
            this.kimlik_ekle.UseVisualStyleBackColor = false;
            this.kimlik_ekle.Click += new System.EventHandler(this.kimlik_ekle_Click);
            // 
            // saglikraporulabel
            // 
            this.saglikraporulabel.AutoSize = true;
            this.saglikraporulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saglikraporulabel.ForeColor = System.Drawing.Color.Olive;
            this.saglikraporulabel.Location = new System.Drawing.Point(476, 514);
            this.saglikraporulabel.Name = "saglikraporulabel";
            this.saglikraporulabel.Size = new System.Drawing.Size(127, 20);
            this.saglikraporulabel.TabIndex = 74;
            this.saglikraporulabel.Text = "Sağlık Raporu:";
            // 
            // sicillabel
            // 
            this.sicillabel.AutoSize = true;
            this.sicillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sicillabel.ForeColor = System.Drawing.Color.Olive;
            this.sicillabel.Location = new System.Drawing.Point(476, 471);
            this.sicillabel.Name = "sicillabel";
            this.sicillabel.Size = new System.Drawing.Size(130, 20);
            this.sicillabel.TabIndex = 72;
            this.sicillabel.Text = "Adli Sicil Kaydı:";
            // 
            // belgelabel
            // 
            this.belgelabel.AutoSize = true;
            this.belgelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belgelabel.ForeColor = System.Drawing.Color.Olive;
            this.belgelabel.Location = new System.Drawing.Point(476, 428);
            this.belgelabel.Name = "belgelabel";
            this.belgelabel.Size = new System.Drawing.Size(140, 20);
            this.belgelabel.TabIndex = 69;
            this.belgelabel.Text = "Öğrenci Belgesi:";
            // 
            // kimliklabel
            // 
            this.kimliklabel.AutoSize = true;
            this.kimliklabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kimliklabel.ForeColor = System.Drawing.Color.Olive;
            this.kimliklabel.Location = new System.Drawing.Point(476, 385);
            this.kimliklabel.Name = "kimliklabel";
            this.kimliklabel.Size = new System.Drawing.Size(148, 20);
            this.kimliklabel.TabIndex = 68;
            this.kimliklabel.Text = "Kimlik Fotokopisi:";
            // 
            // oda_no
            // 
            this.oda_no.Depth = 0;
            this.oda_no.Hint = "";
            this.oda_no.Location = new System.Drawing.Point(608, 212);
            this.oda_no.MaxLength = 32767;
            this.oda_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.oda_no.Name = "oda_no";
            this.oda_no.PasswordChar = '\0';
            this.oda_no.SelectedText = "";
            this.oda_no.SelectionLength = 0;
            this.oda_no.SelectionStart = 0;
            this.oda_no.Size = new System.Drawing.Size(206, 23);
            this.oda_no.TabIndex = 67;
            this.oda_no.TabStop = false;
            this.oda_no.UseSystemPasswordChar = false;
            this.oda_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oda_no_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Olive;
            this.label14.Location = new System.Drawing.Point(476, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 20);
            this.label14.TabIndex = 66;
            this.label14.Text = "Oda Numarası:";
            // 
            // durum_pasif
            // 
            this.durum_pasif.AutoSize = true;
            this.durum_pasif.Depth = 0;
            this.durum_pasif.Font = new System.Drawing.Font("Roboto", 10F);
            this.durum_pasif.Location = new System.Drawing.Point(333, 287);
            this.durum_pasif.Margin = new System.Windows.Forms.Padding(0);
            this.durum_pasif.MouseLocation = new System.Drawing.Point(-1, -1);
            this.durum_pasif.MouseState = MaterialSkin.MouseState.HOVER;
            this.durum_pasif.Name = "durum_pasif";
            this.durum_pasif.Ripple = true;
            this.durum_pasif.Size = new System.Drawing.Size(61, 30);
            this.durum_pasif.TabIndex = 65;
            this.durum_pasif.TabStop = true;
            this.durum_pasif.Text = "Pasif";
            this.durum_pasif.UseVisualStyleBackColor = true;
            // 
            // durum_aktif
            // 
            this.durum_aktif.AutoSize = true;
            this.durum_aktif.Depth = 0;
            this.durum_aktif.Font = new System.Drawing.Font("Roboto", 10F);
            this.durum_aktif.Location = new System.Drawing.Point(174, 287);
            this.durum_aktif.Margin = new System.Windows.Forms.Padding(0);
            this.durum_aktif.MouseLocation = new System.Drawing.Point(-1, -1);
            this.durum_aktif.MouseState = MaterialSkin.MouseState.HOVER;
            this.durum_aktif.Name = "durum_aktif";
            this.durum_aktif.Ripple = true;
            this.durum_aktif.Size = new System.Drawing.Size(58, 30);
            this.durum_aktif.TabIndex = 64;
            this.durum_aktif.TabStop = true;
            this.durum_aktif.Text = "Aktif";
            this.durum_aktif.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(12, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Durum:";
            // 
            // kayit_ara
            // 
            this.kayit_ara.AutoSize = true;
            this.kayit_ara.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kayit_ara.Depth = 0;
            this.kayit_ara.Icon = null;
            this.kayit_ara.Location = new System.Drawing.Point(342, 79);
            this.kayit_ara.MouseState = MaterialSkin.MouseState.HOVER;
            this.kayit_ara.Name = "kayit_ara";
            this.kayit_ara.Primary = true;
            this.kayit_ara.Size = new System.Drawing.Size(90, 36);
            this.kayit_ara.TabIndex = 11;
            this.kayit_ara.Text = "KAYIT ARA";
            this.kayit_ara.UseVisualStyleBackColor = true;
            this.kayit_ara.Click += new System.EventHandler(this.kayit_ara_Click);
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
            this.temizle.TabIndex = 62;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // yakin_tel
            // 
            this.yakin_tel.Depth = 0;
            this.yakin_tel.Hint = "";
            this.yakin_tel.Location = new System.Drawing.Point(660, 339);
            this.yakin_tel.MaxLength = 32767;
            this.yakin_tel.MouseState = MaterialSkin.MouseState.HOVER;
            this.yakin_tel.Name = "yakin_tel";
            this.yakin_tel.PasswordChar = '\0';
            this.yakin_tel.SelectedText = "";
            this.yakin_tel.SelectionLength = 0;
            this.yakin_tel.SelectionStart = 0;
            this.yakin_tel.Size = new System.Drawing.Size(154, 23);
            this.yakin_tel.TabIndex = 61;
            this.yakin_tel.TabStop = false;
            this.yakin_tel.UseSystemPasswordChar = false;
            this.yakin_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yakin_tel_KeyPress);
            // 
            // baba_adsoyad
            // 
            this.baba_adsoyad.Depth = 0;
            this.baba_adsoyad.Hint = "";
            this.baba_adsoyad.Location = new System.Drawing.Point(608, 294);
            this.baba_adsoyad.MaxLength = 32767;
            this.baba_adsoyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.baba_adsoyad.Name = "baba_adsoyad";
            this.baba_adsoyad.PasswordChar = '\0';
            this.baba_adsoyad.SelectedText = "";
            this.baba_adsoyad.SelectionLength = 0;
            this.baba_adsoyad.SelectionStart = 0;
            this.baba_adsoyad.Size = new System.Drawing.Size(206, 23);
            this.baba_adsoyad.TabIndex = 60;
            this.baba_adsoyad.TabStop = false;
            this.baba_adsoyad.UseSystemPasswordChar = false;
            this.baba_adsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baba_adsoyad_KeyPress);
            // 
            // anne_adsoyad
            // 
            this.anne_adsoyad.Depth = 0;
            this.anne_adsoyad.Hint = "";
            this.anne_adsoyad.Location = new System.Drawing.Point(608, 255);
            this.anne_adsoyad.MaxLength = 32767;
            this.anne_adsoyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.anne_adsoyad.Name = "anne_adsoyad";
            this.anne_adsoyad.PasswordChar = '\0';
            this.anne_adsoyad.SelectedText = "";
            this.anne_adsoyad.SelectionLength = 0;
            this.anne_adsoyad.SelectionStart = 0;
            this.anne_adsoyad.Size = new System.Drawing.Size(206, 23);
            this.anne_adsoyad.TabIndex = 59;
            this.anne_adsoyad.TabStop = false;
            this.anne_adsoyad.UseSystemPasswordChar = false;
            this.anne_adsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.anne_adsoyad_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Olive;
            this.label15.Location = new System.Drawing.Point(476, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(204, 20);
            this.label15.TabIndex = 58;
            this.label15.Text = "Yakın Telefon Numarası:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Olive;
            this.label12.Location = new System.Drawing.Point(476, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "Baba Adı Soyadı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Olive;
            this.label10.Location = new System.Drawing.Point(476, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "Anne Adı Soyadı:";
            // 
            // ikanetgah
            // 
            this.ikanetgah.BackColor = System.Drawing.SystemColors.Window;
            this.ikanetgah.Location = new System.Drawing.Point(608, 27);
            this.ikanetgah.Multiline = true;
            this.ikanetgah.Name = "ikanetgah";
            this.ikanetgah.Size = new System.Drawing.Size(206, 174);
            this.ikanetgah.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(476, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 52;
            this.label9.Text = "İkametgah:";
            // 
            // sehir
            // 
            this.sehir.FormattingEnabled = true;
            this.sehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Ağrı",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Iğdır",
            "K.Maraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Kırklareli",
            "Kırıkkale",
            "Kırşehir",
            "Malatya",
            "Manisa",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "İstanbul",
            "İzmir",
            "Şanlıurfa",
            "Şırnak"});
            this.sehir.Location = new System.Drawing.Point(169, 546);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(263, 28);
            this.sehir.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Olive;
            this.label8.Location = new System.Drawing.Point(12, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Şehir:";
            // 
            // tel_no
            // 
            this.tel_no.Depth = 0;
            this.tel_no.Hint = "";
            this.tel_no.Location = new System.Drawing.Point(169, 501);
            this.tel_no.MaxLength = 32767;
            this.tel_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.tel_no.Name = "tel_no";
            this.tel_no.PasswordChar = '\0';
            this.tel_no.SelectedText = "";
            this.tel_no.SelectionLength = 0;
            this.tel_no.SelectionStart = 0;
            this.tel_no.Size = new System.Drawing.Size(263, 23);
            this.tel_no.TabIndex = 49;
            this.tel_no.TabStop = false;
            this.tel_no.UseSystemPasswordChar = false;
            this.tel_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_no_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(12, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Telefon Numarası:";
            // 
            // sinif
            // 
            this.sinif.FormattingEnabled = true;
            this.sinif.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.sinif.Location = new System.Drawing.Point(169, 440);
            this.sinif.Name = "sinif";
            this.sinif.Size = new System.Drawing.Size(263, 28);
            this.sinif.TabIndex = 47;
            // 
            // okul
            // 
            this.okul.Depth = 0;
            this.okul.Hint = "";
            this.okul.Location = new System.Drawing.Point(169, 339);
            this.okul.MaxLength = 32767;
            this.okul.MouseState = MaterialSkin.MouseState.HOVER;
            this.okul.Name = "okul";
            this.okul.PasswordChar = '\0';
            this.okul.SelectedText = "";
            this.okul.SelectionLength = 0;
            this.okul.SelectionStart = 0;
            this.okul.Size = new System.Drawing.Size(263, 23);
            this.okul.TabIndex = 46;
            this.okul.TabStop = false;
            this.okul.UseSystemPasswordChar = false;
            this.okul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.okul_KeyPress);
            // 
            // d_tarih
            // 
            this.d_tarih.CustomFormat = "";
            this.d_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.d_tarih.Location = new System.Drawing.Point(169, 234);
            this.d_tarih.Name = "d_tarih";
            this.d_tarih.Size = new System.Drawing.Size(263, 26);
            this.d_tarih.TabIndex = 45;
            // 
            // bolum
            // 
            this.bolum.Depth = 0;
            this.bolum.Hint = "";
            this.bolum.Location = new System.Drawing.Point(169, 392);
            this.bolum.MaxLength = 32767;
            this.bolum.MouseState = MaterialSkin.MouseState.HOVER;
            this.bolum.Name = "bolum";
            this.bolum.PasswordChar = '\0';
            this.bolum.SelectedText = "";
            this.bolum.SelectionLength = 0;
            this.bolum.SelectionStart = 0;
            this.bolum.Size = new System.Drawing.Size(263, 23);
            this.bolum.TabIndex = 44;
            this.bolum.TabStop = false;
            this.bolum.UseSystemPasswordChar = false;
            // 
            // soyad
            // 
            this.soyad.Depth = 0;
            this.soyad.Hint = "";
            this.soyad.Location = new System.Drawing.Point(169, 178);
            this.soyad.MaxLength = 32767;
            this.soyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.soyad.Name = "soyad";
            this.soyad.PasswordChar = '\0';
            this.soyad.SelectedText = "";
            this.soyad.SelectionLength = 0;
            this.soyad.SelectionStart = 0;
            this.soyad.Size = new System.Drawing.Size(263, 23);
            this.soyad.TabIndex = 43;
            this.soyad.TabStop = false;
            this.soyad.UseSystemPasswordChar = false;
            this.soyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyad_KeyPress);
            // 
            // ad
            // 
            this.ad.Depth = 0;
            this.ad.Hint = "";
            this.ad.Location = new System.Drawing.Point(169, 129);
            this.ad.MaxLength = 32767;
            this.ad.MouseState = MaterialSkin.MouseState.HOVER;
            this.ad.Name = "ad";
            this.ad.PasswordChar = '\0';
            this.ad.SelectedText = "";
            this.ad.SelectionLength = 0;
            this.ad.SelectionStart = 0;
            this.ad.Size = new System.Drawing.Size(263, 23);
            this.ad.TabIndex = 42;
            this.ad.TabStop = false;
            this.ad.UseSystemPasswordChar = false;
            this.ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(12, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Sınıf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(12, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Bölüm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(12, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Okul:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ad:";
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.Olive;
            this.ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekle.ForeColor = System.Drawing.SystemColors.Window;
            this.ekle.Location = new System.Drawing.Point(25, 250);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(190, 60);
            this.ekle.TabIndex = 8;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // guncelle
            // 
            this.guncelle.BackColor = System.Drawing.Color.Olive;
            this.guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.guncelle.Location = new System.Drawing.Point(25, 350);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(190, 60);
            this.guncelle.TabIndex = 9;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = false;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Olive;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.ForeColor = System.Drawing.SystemColors.Window;
            this.sil.Location = new System.Drawing.Point(25, 450);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(190, 60);
            this.sil.TabIndex = 10;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kapat
            // 
            this.kapat.Image = global::AtamanApart.Properties.Resources.closew;
            this.kapat.Location = new System.Drawing.Point(184, 80);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(40, 35);
            this.kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kapat.TabIndex = 11;
            this.kapat.TabStop = false;
            this.kapat.Visible = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click_1);
            // 
            // geri
            // 
            this.geri.Image = global::AtamanApart.Properties.Resources.backw;
            this.geri.Location = new System.Drawing.Point(0, 65);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(40, 35);
            this.geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geri.TabIndex = 12;
            this.geri.TabStop = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // StudentRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "StudentRegistry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialSingleLineTextField tc_no;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker d_tarih;
        private MaterialSkin.Controls.MaterialSingleLineTextField bolum;
        private MaterialSkin.Controls.MaterialSingleLineTextField soyad;
        private MaterialSkin.Controls.MaterialSingleLineTextField ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ikanetgah;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox sehir;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialSingleLineTextField tel_no;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sinif;
        private MaterialSkin.Controls.MaterialSingleLineTextField okul;
        private MaterialSkin.Controls.MaterialSingleLineTextField yakin_tel;
        private MaterialSkin.Controls.MaterialSingleLineTextField baba_adsoyad;
        private MaterialSkin.Controls.MaterialSingleLineTextField anne_adsoyad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialRaisedButton temizle;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private MaterialSkin.Controls.MaterialRadioButton durum_pasif;
        private MaterialSkin.Controls.MaterialRadioButton durum_aktif;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialRaisedButton kayit_ara;
        private MaterialSkin.Controls.MaterialSingleLineTextField oda_no;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label sicillabel;
        private System.Windows.Forms.Label belgelabel;
        private System.Windows.Forms.Label kimliklabel;
        private System.Windows.Forms.Label saglikraporulabel;
        private System.Windows.Forms.Button saglikraporu_ekle;
        private System.Windows.Forms.Button sicilkaydi_ekle;
        private System.Windows.Forms.Button ogrencibelge_ekle;
        private System.Windows.Forms.Button kimlik_ekle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialSingleLineTextField kimlikyol;
        private MaterialSkin.Controls.MaterialSingleLineTextField ogrencibelgeyol;
        private MaterialSkin.Controls.MaterialSingleLineTextField sicilyol;
        private MaterialSkin.Controls.MaterialSingleLineTextField saglikraporyol;
        private System.Windows.Forms.Label saglik;
        private System.Windows.Forms.Label sicil;
        private System.Windows.Forms.Label ogrencibelge;
        private System.Windows.Forms.Label kimlik;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.PictureBox kapat;
        private System.Windows.Forms.PictureBox geri;
    }
}