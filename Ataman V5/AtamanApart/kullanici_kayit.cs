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
    public partial class kullanici_kayit : MaterialForm
    {
        public kullanici_kayit()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime700, Primary.Lime700, Primary.Lime700, Accent.Orange400, TextShade.WHITE);
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\\ApartOtomasyon\\Ataman V5\\AtamanApart\\AtamanApart2.accdb");
        DataSet dtst = new DataSet();
        OleDbDataAdapter adtr = new OleDbDataAdapter();

        private void kullanici_ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kullanici_adi.Text))
            {
                MessageBox.Show("Kayıt işlemi için kullancı adı giriniz.", "Kayıt İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                if (sifre.Text == sifre_tekrar.Text)
                {
                    string ekleme = "INSERT into personel ([tc_no],[kullanici_adi],[sifre],[sifre_tekrar])  Values ('" + tc_no.Text + "','" + kullanici_adi.Text + "','" + sifre.Text + "','" + sifre_tekrar.Text + "')";
                    OleDbCommand kaydet = new OleDbCommand(ekleme, baglanti);
                    if (kaydet.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Kayıt işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Login login = new Login();
                        login.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil.\nŞifre kısımlarına aynı şifreyi giriniz", "Kayıt İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                baglanti.Close();
            }
        }

        private void sifre_Click(object sender, EventArgs e)
        {
            sifre.UseSystemPasswordChar = true;
        }

        private void sifre_tekrar_Click(object sender, EventArgs e)
        {
            sifre_tekrar.UseSystemPasswordChar = true;
        }

        private void tc_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Alanda sadece rakam kullanınız.", "Kayıt İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Handled = false;

            }
        }
    }
}
