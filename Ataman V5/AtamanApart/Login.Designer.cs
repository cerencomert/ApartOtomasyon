namespace AtamanApart
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullanici_adi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sifre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.giris_yap = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yeni_kullanici = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.Depth = 0;
            this.kullanici_adi.Hint = "Kullanıcı adını giriniz";
            this.kullanici_adi.Location = new System.Drawing.Point(172, 223);
            this.kullanici_adi.MaxLength = 32767;
            this.kullanici_adi.MouseState = MaterialSkin.MouseState.HOVER;
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.PasswordChar = '\0';
            this.kullanici_adi.SelectedText = "";
            this.kullanici_adi.SelectionLength = 0;
            this.kullanici_adi.SelectionStart = 0;
            this.kullanici_adi.Size = new System.Drawing.Size(355, 23);
            this.kullanici_adi.TabIndex = 1;
            this.kullanici_adi.TabStop = false;
            this.kullanici_adi.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(165, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 111);
            this.label1.TabIndex = 3;
            this.label1.Text = "ATAMAN REZİDANS APART\r\n\r\nPERSONEL GİRİŞİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro Med", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(27, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro Med", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(30, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // sifre
            // 
            this.sifre.Depth = 0;
            this.sifre.Hint = "Şifre giriniz";
            this.sifre.Location = new System.Drawing.Point(172, 284);
            this.sifre.MaxLength = 32767;
            this.sifre.MouseState = MaterialSkin.MouseState.HOVER;
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '\0';
            this.sifre.SelectedText = "";
            this.sifre.SelectionLength = 0;
            this.sifre.SelectionStart = 0;
            this.sifre.Size = new System.Drawing.Size(356, 23);
            this.sifre.TabIndex = 6;
            this.sifre.TabStop = false;
            this.sifre.UseSystemPasswordChar = false;
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            // 
            // giris_yap
            // 
            this.giris_yap.AutoSize = true;
            this.giris_yap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.giris_yap.Depth = 0;
            this.giris_yap.Icon = null;
            this.giris_yap.Location = new System.Drawing.Point(442, 350);
            this.giris_yap.MouseState = MaterialSkin.MouseState.HOVER;
            this.giris_yap.Name = "giris_yap";
            this.giris_yap.Primary = true;
            this.giris_yap.Size = new System.Drawing.Size(85, 36);
            this.giris_yap.TabIndex = 8;
            this.giris_yap.Text = "GİRİŞ YAP";
            this.giris_yap.UseVisualStyleBackColor = true;
            this.giris_yap.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yeni_kullanici);
            this.groupBox1.Controls.Add(this.materialDivider1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kullanici_adi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.giris_yap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sifre);
            this.groupBox1.Location = new System.Drawing.Point(250, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 500);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // yeni_kullanici
            // 
            this.yeni_kullanici.AutoSize = true;
            this.yeni_kullanici.Font = new System.Drawing.Font("Minion Pro Med", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeni_kullanici.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.yeni_kullanici.Location = new System.Drawing.Point(30, 445);
            this.yeni_kullanici.Name = "yeni_kullanici";
            this.yeni_kullanici.Size = new System.Drawing.Size(190, 26);
            this.yeni_kullanici.TabIndex = 13;
            this.yeni_kullanici.Text = "+  Yeni Kullanıcı Ekle";
            this.yeni_kullanici.Click += new System.EventHandler(this.yeni_kullanici_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(30, 415);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(497, 2);
            this.materialDivider1.TabIndex = 12;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AtamanApart.Properties.Resources.Screenshot_1;
            this.pictureBox1.Location = new System.Drawing.Point(30, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField kullanici_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField sifre;
        private MaterialSkin.Controls.MaterialRaisedButton giris_yap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label yeni_kullanici;

    }
}

