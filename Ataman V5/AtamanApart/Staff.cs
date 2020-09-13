using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace AtamanApart
{
    public partial class Staff : MaterialForm
    {
        public Staff()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime700, Primary.Lime700, Primary.Lime700, Accent.Orange400, TextShade.WHITE);
        }

        #region OleDb
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = AtamanApart2.accdb");
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        #endregion
        

        private void geri_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        #region Pozisyon ve İşlem Butonları


        private void guvenlik_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *from calisan where gorev= 'Güvenlik'", baglanti);
            dtst = new DataSet();

            adtr.Fill(dtst, "calisan");
            dataGridView1.DataSource = dtst.Tables["calisan"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "Ad Soyad";
            dataGridView1.Columns[1].HeaderText = "Adres";
            dataGridView1.Columns[2].HeaderText = "Telefon No";
            dataGridView1.Columns[3].HeaderText = "Pozisyon";
            dataGridView1.Columns[4].HeaderText = "T.C. Kimlik Numarası";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 112;
            dataGridView1.Columns[4].Width = 120;
            #endregion
        }

        private void temizlik_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *from calisan where gorev= 'Temizlik'", baglanti);
            dtst = new DataSet();

            adtr.Fill(dtst, "calisan");
            dataGridView1.DataSource = dtst.Tables["calisan"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "Ad Soyad";
            dataGridView1.Columns[1].HeaderText = "Adres";
            dataGridView1.Columns[2].HeaderText = "Telefon No";
            dataGridView1.Columns[3].HeaderText = "Pozisyon";
            dataGridView1.Columns[4].HeaderText = "T.C. Kimlik Numarası";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 112;
            dataGridView1.Columns[4].Width = 120;

            #endregion
        }

        private void yonetim_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *from calisan where gorev='Yönetim'", baglanti);
            dtst = new DataSet();

            adtr.Fill(dtst, "calisan");
            dataGridView1.DataSource = dtst.Tables["calisan"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "Ad Soyad";
            dataGridView1.Columns[1].HeaderText = "Adres";
            dataGridView1.Columns[2].HeaderText = "Telefon No";
            dataGridView1.Columns[3].HeaderText = "Pozisyon";
            dataGridView1.Columns[4].HeaderText = "T.C. Kimlik Numarası";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 112;
            dataGridView1.Columns[4].Width = 120;

            #endregion
        }

        private void personel_islem_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffRegistry staffRegistry = new StaffRegistry();
            staffRegistry.Show();
        }
        #endregion

        #region Çizelge ve Yönetmelik

        private void calisma_cizelgesi_Click(object sender, EventArgs e)
        {

            string path = cizelgeyol.Text;
            string ConStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + path + ";Extended Properties= 'Excel 12.0; HDR=yes'";
            OleDbConnection con = new OleDbConnection(ConStr);
            OleDbCommand cmd = new OleDbCommand("select * from  [calisma$]", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
        }

        private void cizelge_ekle_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Excel Files|*.xlsx";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file1 = openFileDialog1.FileName;


                string[] f = file1.Split('\\');
                string fn1 = f[(f.Length) - 1];
                string dest1 = @"F:\AybukeKumas_BaharKuzu_CerenComert_EzgiBasegmez\programdosyalari\Ataman V5\AtamanApart\Resources\Belgeler\" + fn1;

                File.Copy(file1, dest1, true);


                cizelgeyol.Text = dest1;
            }
        }

        private void yonetmelik_Click(object sender, EventArgs e)
        {
            if (yonetmelik.Text == "Yönetmeliği Göster")
            {
                yonetmelik.Text = "Yönetmeliği Kapat";
                dataGridView1.Visible = false;
                axAcroPDF1.Visible = true;
                axAcroPDF1.src = "F:\\AybukeKumas_BaharKuzu_CerenComert_EzgiBasegmez\\programdosyalari\\Ataman V5\\AtamanApart\\Resources\\Belgeler\\yurt_yonetmeligi.pdf";
            }
            else
            {
                yonetmelik.Text = "Yönetmeliği Göster";
                dataGridView1.Visible = true;
                axAcroPDF1.Visible = false;
            }

        }
        #endregion

    }
}
