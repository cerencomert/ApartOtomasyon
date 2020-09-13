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
    public partial class StaffRegistry : MaterialForm
    {
        public StaffRegistry()
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
           
            tc_kimlikno.Clear();
            ad_soyadi.Clear();
            tel_no.Clear();
            adres.Clear();
            tel_no.Clear();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff staff = new Staff();
            staff.Show();
        }

        #region Form Ekle-Güncelle-Kayıt Ara-Sil-Temizle

        private void ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tc_kimlikno.Text))
            {
                MessageBox.Show("Kayıt işlemi için geçerli bir T.C. kimlik numarası giriniz.", "Kayıt İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                {
                    string ekleme = "INSERT into calisan ([tc_no],[ad_soyad],[telefon],[gorev],[adres])  Values ('" + tc_kimlikno.Text + "','" + ad_soyadi.Text + "','" + tel_no.Text + "','" + pozisyon.Text + "','" + adres.Text + "')";
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

        private void kayit_ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string text = "select * from calisan where tc_no='" + tc_kimlikno.Text + "'";
            OleDbCommand arama = new OleDbCommand(text, baglanti);
            OleDbDataReader oku = arama.ExecuteReader();

            if (oku.Read())
            {
                tc_kimlikno.Text = oku["tc_no"].ToString();
                ad_soyadi.Text = oku["ad_soyad"].ToString();
                tel_no.Text = oku["telefon"].ToString();
                pozisyon.Text = oku["gorev"].ToString();
                adres.Text = oku["adres"].ToString();
            }
            else
            {
                MessageBox.Show("Aradığınız T.C kimlik numarasına ait bir çalışan bulunmamaktadır.", "Arama İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();

        }

        private void guncelle_Click(object sender, EventArgs e)
        
        {

            if (string.IsNullOrEmpty(tc_kimlikno.Text) || string.IsNullOrEmpty(ad_soyadi.Text) || string.IsNullOrEmpty(tel_no.Text) || string.IsNullOrEmpty(pozisyon.Text) || string.IsNullOrEmpty(adres.Text))
            {
                MessageBox.Show("Güncelleme işlemi için önce personel aratınız ya da gerekli alanları boş bırakmayınız.", "Güncelleme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                try
                {
                    
                    string sql = "UPDATE calisan SET ad_soyad='" + ad_soyadi.Text + "',adres='" + adres.Text + "',telefon='" + tel_no.Text + "',gorev='" + pozisyon.Text + "',tc_no='" + tc_kimlikno.Text +"' where tc_no='" + tc_kimlikno.Text + "'";
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
            if (string.IsNullOrEmpty(tc_kimlikno.Text) || string.IsNullOrEmpty(ad_soyadi.Text) || string.IsNullOrEmpty(tel_no.Text) || string.IsNullOrEmpty(pozisyon.Text) || string.IsNullOrEmpty(adres.Text))
            {
                MessageBox.Show("Silme işlemi için önce personel aratınız.","Silme İşlemi Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else if (MessageBox.Show("Çalışan kaydını silmek istediğinize emin misiniz?", "Çalışanı Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(tc_kimlikno.Text))
                {
                    MessageBox.Show("Silme işlemi için önce personel aratınız.", "Silme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string silme = "DELETE From calisan Where [tc_no]='" + tc_kimlikno.Text + "'";
                    baglanti.Open();
                    OleDbCommand sil_komut = new OleDbCommand(silme, baglanti);
                    if (sil_komut.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Silme işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt silinirken bir hata meydana geldi.","Silme İşlemi Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    baglanti.Close();
                }
                temiz();
            }

        }

        private void temizle_Click(object sender, EventArgs e)
        {
            tc_kimlikno.Clear();
            ad_soyadi.Clear();
            tel_no.Clear();
            adres.Clear();
            tel_no.Clear();
        }

        #endregion

        #region Form İçerikleri Kontrol Etme
        private void tc_kimlikno_KeyPress(object sender, KeyPressEventArgs e)
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

            if (tc_kimlikno.TextLength == 11)
            {
                MessageBox.Show("TC kimlik numarası 11 karakterden oluşmaktadır. Doğru girildiğinden emin olunuz.");
                e.Handled = true;
                tc_kimlikno.Clear();
            }
        }

        private void ad_soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bu alanda rakam bulunamaz. Düzgün formatta doldurulduğundan emin olunuz.");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void tel_no_KeyPress(object sender, KeyPressEventArgs e)
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

            if (tel_no.TextLength == 10)
            {
                e.Handled = true;
                MessageBox.Show("Telefon numarası 10 karakterden oluşur. Doğru girildiğinden emin olunuz.");
                tel_no.Clear();
            }
        }
        #endregion

    }
}