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
    public partial class Login : MaterialForm
    {
        public Login()
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

        #region Form İşlemleri
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand giris_yap = new OleDbCommand();
            giris_yap.Connection = baglanti;
            giris_yap.CommandText = "select * from personel where kullanici_adi='" + kullanici_adi.Text + "' and sifre='" + sifre.Text + "'";

            OleDbDataReader reader = giris_yap.ExecuteReader();
            int count = 0;

            while (reader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                this.Hide();
                MainPage form1 = new MainPage();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre doğru değil.", "Kullanıcı Girişi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            baglanti.Close();
        }

        private void yeni_kullanici_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup kullanici = new Signup();
            kullanici.ShowDialog();
        }

        private void sifre_Click(object sender, EventArgs e)
        {
            sifre.UseSystemPasswordChar = true;
        }
        #endregion
    }
}
