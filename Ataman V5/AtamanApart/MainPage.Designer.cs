namespace AtamanApart
{
    partial class MainPage
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
            this.ziyaretci_islemleri = new System.Windows.Forms.Button();
            this.odeme_islemleri = new System.Windows.Forms.Button();
            this.personel_islemi = new System.Windows.Forms.Button();
            this.ogrenci_islemi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ziyaretci_islemleri);
            this.groupBox1.Controls.Add(this.odeme_islemleri);
            this.groupBox1.Controls.Add(this.personel_islemi);
            this.groupBox1.Controls.Add(this.ogrenci_islemi);
            this.groupBox1.Location = new System.Drawing.Point(250, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 500);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ziyaretci_islemleri
            // 
            this.ziyaretci_islemleri.BackColor = System.Drawing.Color.Olive;
            this.ziyaretci_islemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ziyaretci_islemleri.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ziyaretci_islemleri.ForeColor = System.Drawing.SystemColors.Window;
            this.ziyaretci_islemleri.Location = new System.Drawing.Point(340, 282);
            this.ziyaretci_islemleri.Name = "ziyaretci_islemleri";
            this.ziyaretci_islemleri.Size = new System.Drawing.Size(180, 160);
            this.ziyaretci_islemleri.TabIndex = 4;
            this.ziyaretci_islemleri.Text = "ZİYARETÇİ İŞLEMLERİ";
            this.ziyaretci_islemleri.UseVisualStyleBackColor = false;
            this.ziyaretci_islemleri.Click += new System.EventHandler(this.ziyaretci_islemleri_Click);
            // 
            // odeme_islemleri
            // 
            this.odeme_islemleri.BackColor = System.Drawing.Color.Olive;
            this.odeme_islemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odeme_islemleri.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odeme_islemleri.ForeColor = System.Drawing.SystemColors.Window;
            this.odeme_islemleri.Location = new System.Drawing.Point(70, 282);
            this.odeme_islemleri.Name = "odeme_islemleri";
            this.odeme_islemleri.Size = new System.Drawing.Size(180, 160);
            this.odeme_islemleri.TabIndex = 3;
            this.odeme_islemleri.Text = "ÖDEME İŞLEMLERİ";
            this.odeme_islemleri.UseVisualStyleBackColor = false;
            this.odeme_islemleri.Click += new System.EventHandler(this.odeme_islemleri_Click);
            // 
            // personel_islemi
            // 
            this.personel_islemi.BackColor = System.Drawing.Color.Olive;
            this.personel_islemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personel_islemi.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_islemi.ForeColor = System.Drawing.SystemColors.Window;
            this.personel_islemi.Location = new System.Drawing.Point(340, 55);
            this.personel_islemi.Name = "personel_islemi";
            this.personel_islemi.Size = new System.Drawing.Size(180, 160);
            this.personel_islemi.TabIndex = 2;
            this.personel_islemi.Text = "PERSONEL İŞLEMLERİ";
            this.personel_islemi.UseVisualStyleBackColor = false;
            this.personel_islemi.Click += new System.EventHandler(this.personel_islemi_Click);
            // 
            // ogrenci_islemi
            // 
            this.ogrenci_islemi.BackColor = System.Drawing.Color.Olive;
            this.ogrenci_islemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogrenci_islemi.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_islemi.ForeColor = System.Drawing.SystemColors.Window;
            this.ogrenci_islemi.Location = new System.Drawing.Point(70, 55);
            this.ogrenci_islemi.Name = "ogrenci_islemi";
            this.ogrenci_islemi.Size = new System.Drawing.Size(180, 160);
            this.ogrenci_islemi.TabIndex = 1;
            this.ogrenci_islemi.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.ogrenci_islemi.UseVisualStyleBackColor = false;
            this.ogrenci_islemi.Click += new System.EventHandler(this.ogrenci_islemi_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ziyaretci_islemleri;
        private System.Windows.Forms.Button odeme_islemleri;
        private System.Windows.Forms.Button personel_islemi;
        private System.Windows.Forms.Button ogrenci_islemi;
    }
}