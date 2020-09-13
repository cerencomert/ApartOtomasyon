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
    public partial class Visitor : MaterialForm
    {
        public Visitor()
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

        private void ziyaretci_ekle_Click(object sender, EventArgs e)
        {
            this.Close();
            VisitorRegistry visitorRegistry = new VisitorRegistry();
            visitorRegistry.Show();
        }

        public void veri_getir()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *From ziyaretci", baglanti);
            adtr.Fill(dtst, "ziyaretci");
            dataGridView1.DataSource = dtst.Tables["ziyaretci"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "Ziyaretçi Adı Soyadı";
            dataGridView1.Columns[1].HeaderText = "Ziyaret Edilen Öğrenci";
            dataGridView1.Columns[2].HeaderText = "Giriş Tarihi";
            dataGridView1.Columns[3].HeaderText = "Giriş Saati";
            dataGridView1.Columns[4].HeaderText = "Çıkış Tarihi";
            dataGridView1.Columns[5].HeaderText = "Çıkış Saati";
            dataGridView1.Columns[6].HeaderText = "Görevli Personel";
           
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 200;
            #endregion
        }

        private void tum_kayit_Click(object sender, EventArgs e)
        {
                veri_getir();
                tum_kayit.Enabled = false;
        }

        private void ad_ara_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            adtr = new OleDbDataAdapter("Select *from ziyaretci where ad_soyad like'" + ad_ara.Text + "%'", baglanti);
            dtst = new DataSet();

            adtr.Fill(dtst, "ziyaretci");
            dataGridView1.DataSource = dtst.Tables["ziyaretci"];
            adtr.Dispose();
            baglanti.Close();

            #region data_grid_duzen
            dataGridView1.Columns[0].HeaderText = "Ziyaretçi Adı Soyadı";
            dataGridView1.Columns[1].HeaderText = "Ziyaret Edilen Öğrenci";
            dataGridView1.Columns[2].HeaderText = "Giriş Tarihi";
            dataGridView1.Columns[3].HeaderText = "Giriş Saati";
            dataGridView1.Columns[4].HeaderText = "Çıkış Tarihi";
            dataGridView1.Columns[5].HeaderText = "Çıkış Saati";
            dataGridView1.Columns[6].HeaderText = "Görevli Personel";

            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 200;
            #endregion
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}

