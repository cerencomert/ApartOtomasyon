namespace AtamanApart
{
    partial class Student
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
            this.ad_ara = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tum_kayit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.kayit_islemleri = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oda_bilgileri = new MaterialSkin.Controls.MaterialRaisedButton();
            this.geri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).BeginInit();
            this.SuspendLayout();
            // 
            // ad_ara
            // 
            this.ad_ara.Depth = 0;
            this.ad_ara.Hint = "Aranacak öğrenci adını giriniz";
            this.ad_ara.Location = new System.Drawing.Point(40, 110);
            this.ad_ara.MaxLength = 32767;
            this.ad_ara.MouseState = MaterialSkin.MouseState.HOVER;
            this.ad_ara.Name = "ad_ara";
            this.ad_ara.PasswordChar = '\0';
            this.ad_ara.SelectedText = "";
            this.ad_ara.SelectionLength = 0;
            this.ad_ara.SelectionStart = 0;
            this.ad_ara.Size = new System.Drawing.Size(323, 23);
            this.ad_ara.TabIndex = 6;
            this.ad_ara.TabStop = false;
            this.ad_ara.UseSystemPasswordChar = false;
            this.ad_ara.TextChanged += new System.EventHandler(this.ad_ara_TextChanged);
            // 
            // tum_kayit
            // 
            this.tum_kayit.AutoSize = true;
            this.tum_kayit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tum_kayit.Depth = 0;
            this.tum_kayit.Icon = null;
            this.tum_kayit.Location = new System.Drawing.Point(393, 103);
            this.tum_kayit.MouseState = MaterialSkin.MouseState.HOVER;
            this.tum_kayit.Name = "tum_kayit";
            this.tum_kayit.Primary = true;
            this.tum_kayit.Size = new System.Drawing.Size(176, 36);
            this.tum_kayit.TabIndex = 8;
            this.tum_kayit.Text = "TÜM KAYITLARI GÖSTER";
            this.tum_kayit.UseVisualStyleBackColor = true;
            this.tum_kayit.Click += new System.EventHandler(this.tum_kayit_Click);
            // 
            // kayit_islemleri
            // 
            this.kayit_islemleri.AutoSize = true;
            this.kayit_islemleri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kayit_islemleri.Depth = 0;
            this.kayit_islemleri.Icon = null;
            this.kayit_islemleri.Location = new System.Drawing.Point(920, 103);
            this.kayit_islemleri.MouseState = MaterialSkin.MouseState.HOVER;
            this.kayit_islemleri.Name = "kayit_islemleri";
            this.kayit_islemleri.Primary = true;
            this.kayit_islemleri.Size = new System.Drawing.Size(130, 36);
            this.kayit_islemleri.TabIndex = 9;
            this.kayit_islemleri.Text = "KAYIT İŞLEMLERİ";
            this.kayit_islemleri.UseVisualStyleBackColor = true;
            this.kayit_islemleri.Click += new System.EventHandler(this.kayit_islemleri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1010, 530);
            this.dataGridView1.TabIndex = 10;
            // 
            // oda_bilgileri
            // 
            this.oda_bilgileri.AutoSize = true;
            this.oda_bilgileri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oda_bilgileri.Depth = 0;
            this.oda_bilgileri.Icon = null;
            this.oda_bilgileri.Location = new System.Drawing.Point(790, 103);
            this.oda_bilgileri.MouseState = MaterialSkin.MouseState.HOVER;
            this.oda_bilgileri.Name = "oda_bilgileri";
            this.oda_bilgileri.Primary = true;
            this.oda_bilgileri.Size = new System.Drawing.Size(113, 36);
            this.oda_bilgileri.TabIndex = 11;
            this.oda_bilgileri.Text = "ODA BİLGİLERİ";
            this.oda_bilgileri.UseVisualStyleBackColor = true;
            this.oda_bilgileri.Click += new System.EventHandler(this.oda_bilgileri_Click);
            // 
            // geri
            // 
            this.geri.Image = global::AtamanApart.Properties.Resources.backw;
            this.geri.Location = new System.Drawing.Point(0, 65);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(40, 35);
            this.geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geri.TabIndex = 13;
            this.geri.TabStop = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.oda_bilgileri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kayit_islemleri);
            this.Controls.Add(this.tum_kayit);
            this.Controls.Add(this.ad_ara);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaximizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField ad_ara;
        private MaterialSkin.Controls.MaterialRaisedButton tum_kayit;
        private MaterialSkin.Controls.MaterialRaisedButton kayit_islemleri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton oda_bilgileri;
        private System.Windows.Forms.PictureBox geri;
    }
}