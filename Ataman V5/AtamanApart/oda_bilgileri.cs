using MaterialSkin;
using MaterialSkin.Controls;
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

namespace AtamanApart
{
    public partial class oda_bilgileri : MaterialForm
    {
        int doluluk_miktarı = 0;
        int kapasite_miktar = 0;

        public oda_bilgileri()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime700, Primary.Lime700, Primary.Lime700, Accent.Orange400, TextShade.WHITE);

            if (doluluk_miktarı == kapasite_miktar)
            {
                oda_1.BackColor = Color.Red;
            }
            else if (doluluk_miktarı < kapasite_miktar)
            {
                oda_1.BackColor = Color.Green;
            }
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\\GÜNCEL\\Ataman V5\\AtamanApart\\AtamanApart2.accdb");
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();



        private void oda_1_Click(object sender, EventArgs e)
        {
            kat1.Visible = false;
            kat2.Visible = false;
            kat3.Visible = false;
            kat4.Visible = false;
            kat5.Visible = false;
            zemin_kat.Visible = false;
            materialDivider1.Visible = false;
            materialDivider2.Visible = false;
            materialDivider3.Visible = false;
            materialDivider4.Visible = false;
            materialDivider5.Visible = false;
            groupBox1.Visible = true;

            oda_numarası.Text = oda_1.Text;

            baglanti.Open();

            string text = "SELECT ogrenci_ad,ogrenci_soyad FROM ogrenci WHERE oda IN(SELECT oda FROM oda_bilgileri WHERE oda LIKE '%1%')";
            string text2 = "SELECT kapasite, ucret FROM oda_bilgileri WHERE oda IN(SELECT oda FROM ogrenci WHERE oda LIKE '%1%')";

            OleDbCommand arama1 = new OleDbCommand(text, baglanti);
            OleDbCommand arama2 = new OleDbCommand(text2, baglanti);
            OleDbDataReader oku = arama1.ExecuteReader();
            OleDbDataReader oku2 = arama2.ExecuteReader();

            int ogrenci_say = 0;
            while (oku.Read())
            {
                ogrenci_say++;
                ogrenciler.Text = oku["ogrenci_ad"].ToString() + " " + oku["ogrenci_soyad"].ToString();
            }
            doluluk.Text = Convert.ToString(ogrenci_say);

            if (oku2.Read())
            {
                kapasite.Text = oku2["kapasite"].ToString();
                oda_ucret.Text = oku2["ucret"].ToString();
            }

            doluluk_miktarı = Convert.ToInt32(doluluk.Text);
            kapasite_miktar = Convert.ToInt32(kapasite.Text);

            baglanti.Close();
        }
    }
}
