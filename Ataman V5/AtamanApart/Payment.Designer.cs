namespace AtamanApart
{
    partial class Payment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.odeme_islemi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tum_kayit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ad_ara = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.geri = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1011, 530);
            this.dataGridView1.TabIndex = 15;
            // 
            // odeme_islemi
            // 
            this.odeme_islemi.AutoSize = true;
            this.odeme_islemi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.odeme_islemi.Depth = 0;
            this.odeme_islemi.Icon = null;
            this.odeme_islemi.Location = new System.Drawing.Point(914, 97);
            this.odeme_islemi.MouseState = MaterialSkin.MouseState.HOVER;
            this.odeme_islemi.Name = "odeme_islemi";
            this.odeme_islemi.Primary = true;
            this.odeme_islemi.Size = new System.Drawing.Size(137, 36);
            this.odeme_islemi.TabIndex = 14;
            this.odeme_islemi.Text = "ÖDEME İŞLEMLERİ";
            this.odeme_islemi.UseVisualStyleBackColor = true;
            this.odeme_islemi.Click += new System.EventHandler(this.odeme_islemi_Click);
            // 
            // tum_kayit
            // 
            this.tum_kayit.AutoSize = true;
            this.tum_kayit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tum_kayit.Depth = 0;
            this.tum_kayit.Icon = null;
            this.tum_kayit.Location = new System.Drawing.Point(392, 97);
            this.tum_kayit.MouseState = MaterialSkin.MouseState.HOVER;
            this.tum_kayit.Name = "tum_kayit";
            this.tum_kayit.Primary = true;
            this.tum_kayit.Size = new System.Drawing.Size(176, 36);
            this.tum_kayit.TabIndex = 13;
            this.tum_kayit.Text = "TÜM KAYITLARI GÖSTER";
            this.tum_kayit.UseVisualStyleBackColor = true;
            this.tum_kayit.Click += new System.EventHandler(this.tum_kayit_Click);
            // 
            // ad_ara
            // 
            this.ad_ara.Depth = 0;
            this.ad_ara.Hint = "Aranacak öğrenci adını giriniz";
            this.ad_ara.Location = new System.Drawing.Point(40, 104);
            this.ad_ara.MaxLength = 32767;
            this.ad_ara.MouseState = MaterialSkin.MouseState.HOVER;
            this.ad_ara.Name = "ad_ara";
            this.ad_ara.PasswordChar = '\0';
            this.ad_ara.SelectedText = "";
            this.ad_ara.SelectionLength = 0;
            this.ad_ara.SelectionStart = 0;
            this.ad_ara.Size = new System.Drawing.Size(323, 23);
            this.ad_ara.TabIndex = 12;
            this.ad_ara.TabStop = false;
            this.ad_ara.UseSystemPasswordChar = false;
            this.ad_ara.TextChanged += new System.EventHandler(this.ad_ara_TextChanged);
            // 
            // geri
            // 
            this.geri.Image = global::AtamanApart.Properties.Resources.backw;
            this.geri.Location = new System.Drawing.Point(0, 65);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(40, 35);
            this.geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geri.TabIndex = 16;
            this.geri.TabStop = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.odeme_islemi);
            this.Controls.Add(this.tum_kayit);
            this.Controls.Add(this.ad_ara);
            this.MaximizeBox = false;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton odeme_islemi;
        private MaterialSkin.Controls.MaterialRaisedButton tum_kayit;
        private MaterialSkin.Controls.MaterialSingleLineTextField ad_ara;
        private System.Windows.Forms.PictureBox geri;
    }
}