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
    public partial class VisitorRegistry : MaterialForm
    {
        public VisitorRegistry()
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

        public void temiz()
        {

            ziyaretci_ad_soyad.Clear();
            ziyaret_edilen.Clear();
            giris_saati.Clear();
            cikis_saati.Clear();
            gorevli_personel.Clear();

        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Visitor visitor = new Visitor();
            visitor.Show();
        }

        #region Form Ekle-Güncelle-Sil-Kayıt Ara-Temizle

        private void ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ziyaretci_ad_soyad.Text) || string.IsNullOrEmpty(ziyaret_edilen.Text) || string.IsNullOrEmpty(giris_saati.Text))
            {
                MessageBox.Show("Kayıt için lütfen ziyaretçi ad soyadını, ziyaret edilen ad soyadını ve giriş tarih/saat kısımlarını doldurunuz.", "Kayıt İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                {
                    string ekleme = "INSERT into ziyaretci ([ad_soyad],[ziyaret_edilen],[giris_tarih],[giris_saat],[cikis_tarih],[cikis_saat],[gorevli_personel])  Values ('" + ziyaretci_ad_soyad.Text + "','" + ziyaret_edilen.Text + "','" + giris_tarihi.Text + "','" + giris_saati.Text + "','" + cikis_tarihi.Text + "','" + cikis_saati.Text + "','" + gorevli_personel.Text + "')";
                    OleDbCommand kaydet = new OleDbCommand(ekleme, baglanti);
                    if (kaydet.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Kayıt işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        temiz();
                    }
                }
                baglanti.Close();
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ziyaretci_ad_soyad.Text) || string.IsNullOrEmpty(ziyaret_edilen.Text) || string.IsNullOrEmpty(giris_tarihi.Text) || string.IsNullOrEmpty(giris_saati.Text) || string.IsNullOrEmpty(gorevli_personel.Text))
            {
                MessageBox.Show("Güncelleme işlemi için önce ziyaretçi aratınız ya da gerekli alanları boş bırakmayınız.", "Güncelleme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                try
                {

                    string sql = "UPDATE ziyaretci SET ad_soyad='" + ziyaretci_ad_soyad.Text + "',ziyaret_edilen='" + ziyaret_edilen.Text + "',giris_tarih='" + giris_tarihi.Text + "',giris_saat='" + giris_saati.Text + "',cikis_tarih='" + cikis_tarihi.Text + "',cikis_saat='" + cikis_saati.Text + "',gorevli_personel='" + gorevli_personel.Text + "' where ad_soyad='" + ziyaretci_ad_soyad.Text + "'";
                    OleDbCommand komut = new OleDbCommand(sql, baglanti);
                    if (komut.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        temiz();
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
                baglanti.Close();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ziyaretci_ad_soyad.Text) || string.IsNullOrEmpty(ziyaret_edilen.Text) || string.IsNullOrEmpty(giris_saati.Text) || string.IsNullOrEmpty(gorevli_personel.Text))
            {
                MessageBox.Show("Silme işlemi için önce ziyaretçi kaydı aratınız.", "Silme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (MessageBox.Show("Ziyaretçi kaydını silmek istediğinize emin misiniz?", "Ziyaretçiyi Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(ziyaretci_ad_soyad.Text))
                {
                    MessageBox.Show("Silme işlemi için önce ziyaretçi kaydı aratınız.", "Silme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string silme = "DELETE From ziyaretci Where [ad_soyad]='" + ziyaretci_ad_soyad.Text + "'";
                    baglanti.Open();
                    OleDbCommand sil_komut = new OleDbCommand(silme, baglanti);
                    if (sil_komut.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Silme işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinirken bir hata meydana geldi.", "Silme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    baglanti.Close();
                }
                temiz();
            }
        }

        private void kayit_ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string text = "select * from ziyaretci where ad_soyad='" + ziyaretci_ad_soyad.Text + "'";
            OleDbCommand arama = new OleDbCommand(text, baglanti);
            OleDbDataReader oku = arama.ExecuteReader();

            if (oku.Read())
            {
                ziyaret_edilen.Text = oku["ziyaret_edilen"].ToString();
                giris_tarihi.Text = oku["giris_tarih"].ToString();
                giris_saati.Text = oku["giris_saat"].ToString();
                cikis_tarihi.Text = oku["cikis_tarih"].ToString();
                cikis_saati.Text = oku["cikis_saat"].ToString();
                gorevli_personel.Text = oku["gorevli_personel"].ToString();
            }
            else
            {
                MessageBox.Show("Aradığınız isme ait bir ziyaretçi bulunmamaktadır.", "Arama İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            ziyaretci_ad_soyad.Clear();
            ziyaret_edilen.Clear();
            giris_saati.Clear();
            cikis_saati.Clear();
            gorevli_personel.Clear();

        }

        #endregion

        #region Form İçeriklerini Kontrol Etme

        private void ziyaretci_ad_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bu alanda rakam bulunamaz,lütfen düzgün doldurulduğundan emin olunuz.");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void ziyaret_edilen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bu alanda rakam bulunamaz,lütfen düzgün doldurulduğundan emin olunuz.");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void giris_saati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayı giriniz.");
            }
            else
            {
                e.Handled = false;
            }

            if (giris_saati.TextLength == 5)
            {
                e.Handled = true;
                MessageBox.Show("Saat xx:xx formatındadır.Alanın doğru girildiğinden emin olunuz.");
                giris_saati.Clear();
            }
        }

        private void cikis_saati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sayı giriniz.");
            }
            else
            {
                e.Handled = false;
            }

            if (cikis_saati.TextLength == 5)
            {
                e.Handled = true;
                MessageBox.Show("Saat xx:xx formatındadır.Alanın doğru girildiğinden emin olunuz.");
                cikis_saati.Clear();
            }
        }

        private void gorevli_personel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bu alanda rakam bulunamaz,lütfen düzgün doldurulduğundan emin olunuz.");
            }
            else
            {
                e.Handled = false;
            }
        }

        #endregion


    }
}