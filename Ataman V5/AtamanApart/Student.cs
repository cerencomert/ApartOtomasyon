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

namespace AtamanApart
{
    public partial class Student : MaterialForm
    {
        public Student()
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

        public void veri_getir()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *From ogrenci", baglanti);
            adtr.Fill(dtst, "ogrenci");
            dataGridView1.DataSource = dtst.Tables["ogrenci"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "TC No";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "D.Tarihi";
            dataGridView1.Columns[4].HeaderText = "Okul";
            dataGridView1.Columns[5].HeaderText = "Bölüm";
            dataGridView1.Columns[6].HeaderText = "Sınıf";
            dataGridView1.Columns[7].HeaderText = "Tel";
            dataGridView1.Columns[8].HeaderText = "Şehir";
            dataGridView1.Columns[9].HeaderText = "İkametgah";
            dataGridView1.Columns[10].HeaderText = "Anne Ad Soyad";
            dataGridView1.Columns[11].HeaderText = "Baba Ad Soyad";
            dataGridView1.Columns[12].HeaderText = "Yakın tel";
            dataGridView1.Columns[13].HeaderText = "Durum";
            dataGridView1.Columns[14].HeaderText = "Oda No";


            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 65;
            dataGridView1.Columns[2].Width = 65;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 130;
            dataGridView1.Columns[6].Width = 32;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 50;
            dataGridView1.Columns[9].Width = 150;
            dataGridView1.Columns[10].Width = 100;
            dataGridView1.Columns[11].Width = 100;
            dataGridView1.Columns[12].Width = 80;
            dataGridView1.Columns[13].Width = 30;
            dataGridView1.Columns[14].Width = 40;
            #endregion
        }

        private void kayit_islemleri_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentRegistry studentRegistry = new StudentRegistry();
            studentRegistry.Show();
        }

        private void tum_kayit_Click(object sender, EventArgs e)
        {
            veri_getir();
            tum_kayit.Enabled = false;
        }

        private void ad_ara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *from ogrenci where ogrenci_ad like'" + ad_ara.Text + "%'", baglanti);
            dtst = new DataSet();

            adtr.Fill(dtst, "ogrenci");
            dataGridView1.DataSource = dtst.Tables["ogrenci"];
            adtr.Dispose();
            baglanti.Close();
            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "TC No";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "D.Tarihi";
            dataGridView1.Columns[4].HeaderText = "Okul";
            dataGridView1.Columns[5].HeaderText = "Bölüm";
            dataGridView1.Columns[6].HeaderText = "Sınıf";
            dataGridView1.Columns[7].HeaderText = "Tel";
            dataGridView1.Columns[8].HeaderText = "Şehir";
            dataGridView1.Columns[9].HeaderText = "İkametgah";
            dataGridView1.Columns[10].HeaderText = "Anne Ad-Soyad";
            dataGridView1.Columns[11].HeaderText = "Baba Ad-Soyad";
            dataGridView1.Columns[12].HeaderText = "Yakın tel";
            dataGridView1.Columns[13].HeaderText = "Durum";
            dataGridView1.Columns[14].HeaderText = "Oda No";


            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 65;
            dataGridView1.Columns[2].Width = 65;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[5].Width = 130;
            dataGridView1.Columns[6].Width = 32;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 50;
            dataGridView1.Columns[9].Width = 150;
            dataGridView1.Columns[10].Width = 100;
            dataGridView1.Columns[11].Width = 100;
            dataGridView1.Columns[12].Width = 80;
            dataGridView1.Columns[13].Width = 30;
            dataGridView1.Columns[14].Width = 40;
            #endregion
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void oda_bilgileri_Click(object sender, EventArgs e)
        {
            this.Close();
            RoomInfo roominfo = new RoomInfo();
            roominfo.Show();
        }
    }
}
