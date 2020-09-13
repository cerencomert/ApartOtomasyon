namespace AtamanApart
{
    partial class kullanici_kayit
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tc_no = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tc_no_label = new System.Windows.Forms.Label();
            this.kullanici_ekle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.sifre_tekrar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.kullanici_adi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sifre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tc_no);
            this.groupBox2.Controls.Add(this.tc_no_label);
            this.groupBox2.Controls.Add(this.kullanici_ekle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.sifre_tekrar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.kullanici_adi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sifre);
            this.groupBox2.Location = new System.Drawing.Point(250, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 500);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AtamanApart.Properties.Resources.Screenshot_1;
            this.pictureBox1.Location = new System.Drawing.Point(31, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(166, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 111);
            this.label1.TabIndex = 19;
            this.label1.Text = "ATAMAN REZİDANS APART\r\n\r\nPERSONEL KAYIT\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tc_no
            // 
            this.tc_no.Depth = 0;
            this.tc_no.Hint = "TC Kimlik Numaranızı giriniz";
            this.tc_no.Location = new System.Drawing.Point(187, 247);
            this.tc_no.MaxLength = 32767;
            this.tc_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.tc_no.Name = "tc_no";
            this.tc_no.PasswordChar = '\0';
            this.tc_no.SelectedText = "";
            this.tc_no.SelectionLength = 0;
            this.tc_no.SelectionStart = 0;
            this.tc_no.Size = new System.Drawing.Size(341, 23);
            this.tc_no.TabIndex = 17;
            this.tc_no.TabStop = false;
            this.tc_no.UseSystemPasswordChar = false;
            this.tc_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_no_KeyPress);
            // 
            // tc_no_label
            // 
            this.tc_no_label.AutoSize = true;
            this.tc_no_label.Font = new System.Drawing.Font("Minion Pro Med", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_no_label.ForeColor = System.Drawing.Color.Olive;
            this.tc_no_label.Location = new System.Drawing.Point(26, 244);
            this.tc_no_label.Name = "tc_no_label";
            this.tc_no_label.Size = new System.Drawing.Size(136, 26);
            this.tc_no_label.TabIndex = 18;
            this.tc_no_label.Text = "T.C. KimlikNo:";
            // 
            // kullanici_ekle
            // 
            this.kullanici_ekle.AutoSize = true;
            this.kullanici_ekle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kullanici_ekle.Depth = 0;
            this.kullanici_ekle.Icon = null;
            this.kullanici_ekle.Location = new System.Drawing.Point(404, 413);
            this.kullanici_ekle.MouseState = MaterialSkin.MouseState.HOVER;
            this.kullanici_ekle.Name = "kullanici_ekle";
            this.kullanici_ekle.Primary = true;
            this.kullanici_ekle.Size = new System.Drawing.Size(124, 36);
            this.kullanici_ekle.TabIndex = 16;
            this.kullanici_ekle.Text = "Kullanıcı Ekle";
            this.kullanici_ekle.UseVisualStyleBackColor = true;
            this.kullanici_ekle.Click += new System.EventHandler(this.kullanici_ekle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro Med", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(26, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Şifre Tekrar:";
            // 
            // sifre_tekrar
            // 
            this.sifre_tekrar.Depth = 0;
            this.sifre_tekrar.Hint = "Şifrenizi tekrar giriniz";
            this.sifre_tekrar.Location = new System.Drawing.Point(187, 339);
            this.sifre_tekrar.MaxLength = 32767;
            this.sifre_tekrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.sifre_tekrar.Name = "sifre_tekrar";
            this.sifre_tekrar.PasswordChar = '\0';
            this.sifre_tekrar.SelectedText = "";
            this.sifre_tekrar.SelectionLength = 0;
            this.sifre_tekrar.SelectionStart = 0;
            this.sifre_tekrar.Size = new System.Drawing.Size(341, 23);
            this.sifre_tekrar.TabIndex = 15;
            this.sifre_tekrar.TabStop = false;
            this.sifre_tekrar.UseSystemPasswordChar = false;
            this.sifre_tekrar.Click += new System.EventHandler(this.sifre_tekrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(58, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "+  Yeni Kullanıcı Ekle";
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.Depth = 0;
            this.kullanici_adi.ForeColor = System.Drawing.Color.DarkGray;
            this.kullanici_adi.Hint = "Lütfen bir kullanıcı adı belirleyiniz";
            this.kullanici_adi.Location = new System.Drawing.Point(187, 201);
            this.kullanici_adi.MaxLength = 32767;
            this.kullanici_adi.MouseState = MaterialSkin.MouseState.HOVER;
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.PasswordChar = '\0';
            this.kullanici_adi.SelectedText = "";
            this.kullanici_adi.SelectionLength = 0;
            this.kullanici_adi.SelectionStart = 0;
            this.kullanici_adi.Size = new System.Drawing.Size(341, 23);
            this.kullanici_adi.TabIndex = 1;
            this.kullanici_adi.TabStop = false;
            this.kullanici_adi.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro Med", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(26, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro Med", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(26, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifre:";
            // 
            // sifre
            // 
            this.sifre.Depth = 0;
            this.sifre.Hint = "Şifre belirleyiniz";
            this.sifre.Location = new System.Drawing.Point(187, 293);
            this.sifre.MaxLength = 32767;
            this.sifre.MouseState = MaterialSkin.MouseState.HOVER;
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '\0';
            this.sifre.SelectedText = "";
            this.sifre.SelectionLength = 0;
            this.sifre.SelectionStart = 0;
            this.sifre.Size = new System.Drawing.Size(341, 23);
            this.sifre.TabIndex = 6;
            this.sifre.TabStop = false;
            this.sifre.UseSystemPasswordChar = false;
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            // 
            // kullanici_kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.groupBox2);
            this.Name = "kullanici_kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField tc_no;
        private System.Windows.Forms.Label tc_no_label;
        private MaterialSkin.Controls.MaterialRaisedButton kullanici_ekle;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField sifre_tekrar;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField kullanici_adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField sifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}