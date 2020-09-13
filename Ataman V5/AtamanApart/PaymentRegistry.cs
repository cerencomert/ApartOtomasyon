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
    public partial class PaymentRegistry : MaterialForm
    {
        public PaymentRegistry()
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

        #region aylar
        String odeme_eylul = "";
        String odeme_ekim = "";
        String odeme_kasim = "";
        String odeme_aralik = "";
        String odeme_ocak = "";
        String odeme_subat = "";
        String odeme_mart = "";
        String odeme_nisan = "";
        String odeme_mayis = "";
        String odeme_haziran = "";
        #endregion

        public void temiz()
        {
            if (eylül_odendi.Checked)
            {
                eylül_odendi.Checked = false;
            }
            else if (eylül_odenmedi.Checked)
            {
                eylül_odenmedi.Checked = false;
            }

            if (ekim_odendi.Checked)
            {
                ekim_odendi.Checked = false;
            }
            else if (ekim_odenmedi.Checked)
            {
                ekim_odenmedi.Checked = false;
            }

            if (kasim_odendi.Checked)
            {
                kasim_odendi.Checked = false;
            }
            else if (kasim_odenmedi.Checked)
            {
                kasim_odenmedi.Checked = false;
            }

            if (aralık_odendi.Checked)
            {
                aralık_odendi.Checked = false;
            }
            else if (aralık_odenmedi.Checked)
            {
                aralık_odenmedi.Checked = false;
            }

            if (ocak_odendi.Checked)
            {
                ocak_odendi.Checked = false;
            }
            else if (ocak_odenmedi.Checked)
            {
                ocak_odenmedi.Checked = false;
            }

            if (subat_odendi.Checked)
            {
                subat_odendi.Checked = false;
            }
            else if (subat_odenmedi.Checked)
            {
                subat_odenmedi.Checked = false;
            }

            if (mart_odendi.Checked)
            {
                mart_odendi.Checked = false;
            }
            else if (mart_odenmedi.Checked)
            {
                mart_odenmedi.Checked = false;
            }

            if (nisan_odendi.Checked)
            {
                nisan_odendi.Checked = false;
            }
            else if (nisan_odenmedi.Checked)
            {
                nisan_odenmedi.Checked = false;
            }

            if (mayis_odendi.Checked)
            {
                mayis_odendi.Checked = false;
            }
            else if (mayıs_odenmedi.Checked)
            {
                mayıs_odenmedi.Checked = false;
            }

            if (haziran_odendi.Checked)
            {
                haziran_odendi.Checked = false;
            }
            else if (haziran_odenmedi.Checked)
            {
                haziran_odenmedi.Checked = false;
            }

            tc_no.Clear();
            ad_soyad.Clear();
            oda_no.Clear();
            odenecek_tutar.Clear();
            //odeme_sekli.Clear();
            personel_gorev.Clear();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Close();
            Payment payment = new Payment();
            payment.Show();
        }

        #region Form Ekle-Güncelle-Temizle

        private void ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tc_no.Text) || string.IsNullOrEmpty(ad_soyad.Text) || string.IsNullOrEmpty(oda_no.Text) || string.IsNullOrEmpty(odenecek_tutar.Text) || string.IsNullOrEmpty(odeme_sekli.Text) || string.IsNullOrEmpty(personel_gorev.Text))
            {
                MessageBox.Show("Kayıt işlemi için geçerli tüm alanları eksiksiz doldurunuz.", "Kayıt İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();

                if (eylül_odendi.Checked == true)
                    odeme_eylul = eylül_odendi.Text;
                else
                    odeme_eylul = eylül_odenmedi.Text;

                if (ekim_odendi.Checked == true)
                    odeme_ekim = ekim_odendi.Text;
                else
                    odeme_ekim = ekim_odenmedi.Text;

                if (kasim_odendi.Checked == true)
                    odeme_kasim = kasim_odendi.Text;
                else
                    odeme_kasim = kasim_odenmedi.Text;

                if (aralık_odendi.Checked == true)
                    odeme_aralik = aralık_odendi.Text;
                else
                    odeme_aralik = aralık_odenmedi.Text;

                if (ocak_odendi.Checked == true)
                    odeme_ocak = ocak_odendi.Text;
                else
                    odeme_ocak = ocak_odenmedi.Text;

                if (subat_odendi.Checked == true)
                    odeme_subat = subat_odendi.Text;
                else
                    odeme_subat = subat_odenmedi.Text;

                if (mart_odendi.Checked == true)
                    odeme_mart = mart_odendi.Text;
                else
                    odeme_mart = mart_odenmedi.Text;

                if (nisan_odendi.Checked == true)
                    odeme_nisan = nisan_odendi.Text;
                else
                    odeme_nisan = nisan_odenmedi.Text;

                if (mayis_odendi.Checked == true)
                    odeme_mayis = mayis_odendi.Text;
                else
                    odeme_mayis = mayıs_odenmedi.Text;

                if (haziran_odendi.Checked == true)
                    odeme_haziran = haziran_odendi.Text;
                else
                    odeme_haziran = haziran_odenmedi.Text;

                string ekleme = "INSERT into odeme ([tc_no],[ad_soyad],[oda_no],[odenecek_tutar],[odeme_sekli],[eylul],[ekim],[kasim],[aralik],[ocak],[subat],[mart],[nisan],[mayis],[haziran],[personel])  Values ('" + tc_no.Text + "','" + ad_soyad.Text + "','" + oda_no.Text + "','" + odenecek_tutar.Text + "','" + odeme_sekli.Text + "','" + odeme_eylul + "','" + odeme_ekim + "','" + odeme_kasim + "','" + odeme_aralik + "','" + odeme_ocak + "','" + odeme_subat + "','" + odeme_mart + "','" + odeme_nisan + "','" + odeme_mayis + "','" + odeme_haziran + "','" + personel_gorev.Text + "')";
                OleDbCommand kaydet = new OleDbCommand(ekleme, baglanti);
                kaydet.ExecuteNonQuery();

                MessageBox.Show("Kayıt işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();

            }
            temiz();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tc_no.Text) || string.IsNullOrEmpty(ad_soyad.Text) || string.IsNullOrEmpty(oda_no.Text) || string.IsNullOrEmpty(odenecek_tutar.Text) || string.IsNullOrEmpty(odeme_sekli.Text) || string.IsNullOrEmpty(personel_gorev.Text) || string.IsNullOrEmpty(odeme_eylul) || string.IsNullOrEmpty(odeme_ekim) || string.IsNullOrEmpty(odeme_kasim) || string.IsNullOrEmpty(odeme_aralik) || string.IsNullOrEmpty(odeme_ocak) || string.IsNullOrEmpty(odeme_subat) || string.IsNullOrEmpty(odeme_mart) || string.IsNullOrEmpty(odeme_nisan) || string.IsNullOrEmpty(odeme_mayis) || string.IsNullOrEmpty(odeme_haziran))
            {
                MessageBox.Show("Güncelleme işlemi için önce öğrenci aratınız ya da gerekli alanları boş bırakmayınız.", "Güncelleme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                baglanti.Open();
                try
                {
                    if (eylül_odendi.Checked == true)
                        odeme_eylul = eylül_odendi.Text;
                    else
                        odeme_eylul = eylül_odenmedi.Text;

                    if (ekim_odendi.Checked == true)
                        odeme_ekim = ekim_odendi.Text;
                    else
                        odeme_ekim = ekim_odenmedi.Text;

                    if (kasim_odendi.Checked == true)
                        odeme_kasim = kasim_odendi.Text;
                    else
                        odeme_kasim = kasim_odenmedi.Text;

                    if (aralık_odendi.Checked == true)
                        odeme_aralik = aralık_odendi.Text;
                    else
                        odeme_aralik = aralık_odenmedi.Text;

                    if (ocak_odendi.Checked == true)
                        odeme_ocak = ocak_odendi.Text;
                    else
                        odeme_ocak = ocak_odenmedi.Text;

                    if (subat_odendi.Checked == true)
                        odeme_subat = subat_odendi.Text;
                    else
                        odeme_subat = subat_odenmedi.Text;

                    if (mart_odendi.Checked == true)
                        odeme_mart = mart_odendi.Text;
                    else
                        odeme_mart = mart_odenmedi.Text;

                    if (nisan_odendi.Checked == true)
                        odeme_nisan = nisan_odendi.Text;
                    else
                        odeme_nisan = nisan_odenmedi.Text;

                    if (mayis_odendi.Checked == true)
                        odeme_mayis = mayis_odendi.Text;
                    else
                        odeme_mayis = mayıs_odenmedi.Text;

                    if (haziran_odendi.Checked == true)
                        odeme_haziran = haziran_odendi.Text;
                    else
                        odeme_haziran = haziran_odenmedi.Text;

                    string sql = "UPDATE odeme SET tc_no='" + tc_no.Text + "',ad_soyad='" + ad_soyad.Text + "',oda_no='" + oda_no.Text + "',odenecek_tutar='" + odenecek_tutar.Text + "',odeme_sekli='" + odeme_sekli.Text + "',eylul='" + odeme_eylul + "',ekim='" + odeme_ekim + "',kasim='" + odeme_kasim + "',aralik='" + odeme_aralik + "',ocak='" + odeme_ocak + "',subat='" + odeme_subat + "',mart='" + odeme_mart + "',nisan='" + odeme_nisan + "',mayis='" + odeme_mayis + "',haziran='" + odeme_haziran + "',personel='" + personel_gorev.Text + "' where tc_no='" + tc_no.Text + "'";
                    OleDbCommand komut = new OleDbCommand(sql, baglanti);
                    if (komut.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirilmiştir.", "Başarılı Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message.ToString());
                }
                baglanti.Close();
            }
            temiz();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tc_no.Text) || string.IsNullOrEmpty(ad_soyad.Text) || string.IsNullOrEmpty(oda_no.Text) || string.IsNullOrEmpty(odenecek_tutar.Text) || string.IsNullOrEmpty(odeme_sekli.Text) || string.IsNullOrEmpty(personel_gorev.Text))
            {
                MessageBox.Show("Silme işlemi için önce öğrenci aratınız.", "Silme İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string silme = "DELETE From odeme Where [tc_no]='" + tc_no.Text + "'";
                baglanti.Open();
                if (MessageBox.Show(ad_soyad.Text + " adlı kişinin ödeme bilgileri silinecektir.\nEmin misiniz?", "Ödeme Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OleDbCommand sil_komut = new OleDbCommand(silme, baglanti);
                    sil_komut.ExecuteNonQuery();
                    MessageBox.Show(ad_soyad.Text + " adlı kişinin ödeme kayıtları silinmiştir.", "Başarılı Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            baglanti.Close();
            temiz();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            temiz();
        }

        #endregion

        #region Form İçeriği Kontrol Etme

        private void kayit_ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string text = "select * from odeme where tc_no='" + tc_no.Text + "'";
            OleDbCommand arama = new OleDbCommand(text, baglanti);
            OleDbDataReader oku = arama.ExecuteReader();

            if (oku.Read())
            {
                //MessageBox.Show("Kişi mevcut");
                ad_soyad.Text = oku["ad_soyad"].ToString();
                oda_no.Text = oku["oda_no"].ToString();
                odenecek_tutar.Text = oku["odenecek_tutar"].ToString();
                odeme_sekli.Text = oku["odeme_sekli"].ToString();
                personel_gorev.Text = oku["personel"].ToString();

                odeme_eylul = oku["eylul"].ToString();
                if (odeme_eylul == "Ödendi")
                {
                    eylül_odendi.Checked = true;
                }
                else
                {
                    eylül_odenmedi.Checked = true;
                }

                odeme_ekim = oku["ekim"].ToString();
                if (odeme_ekim == "Ödendi")
                {
                    ekim_odendi.Checked = true;
                }
                else
                {
                    ekim_odenmedi.Checked = true;
                }

                odeme_kasim = oku["kasim"].ToString();
                if (odeme_kasim == "Ödendi")
                {
                    kasim_odendi.Checked = true;
                }
                else
                {
                    kasim_odenmedi.Checked = true;
                }

                odeme_aralik = oku["aralik"].ToString();
                if (odeme_aralik == "Ödendi")
                {
                    aralık_odendi.Checked = true;
                }
                else
                {
                    aralık_odenmedi.Checked = true;
                }

                odeme_ocak = oku["ocak"].ToString();
                if (odeme_ocak == "Ödendi")
                {
                    ocak_odendi.Checked = true;
                }
                else
                {
                    ocak_odenmedi.Checked = true;
                }

                odeme_subat = oku["subat"].ToString();
                if (odeme_subat == "Ödendi")
                {
                    subat_odendi.Checked = true;
                }
                else
                {
                    subat_odenmedi.Checked = true;
                }

                odeme_mart = oku["mart"].ToString();
                if (odeme_mart == "Ödendi")
                {
                    mart_odendi.Checked = true;
                }
                else
                {
                    mart_odenmedi.Checked = true;
                }

                odeme_nisan = oku["nisan"].ToString();
                if (odeme_nisan == "Ödendi")
                {
                    nisan_odendi.Checked = true;
                }
                else
                {
                    nisan_odenmedi.Checked = true;
                }

                odeme_mayis = oku["mayis"].ToString();
                if (odeme_mayis == "Ödendi")
                {
                    mayis_odendi.Checked = true;
                }
                else
                {
                    mayıs_odenmedi.Checked = true;
                }

                odeme_haziran = oku["haziran"].ToString();
                if (odeme_haziran == "Ödendi")
                {
                    haziran_odendi.Checked = true;
                }
                else
                {
                    haziran_odenmedi.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Aradığınız T.C kimlik numarasına ait bir öğrenci bulunmamaktadır.", "Arama İşlemi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void tc_no_KeyPress(object sender, KeyPressEventArgs e)
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

            if (tc_no.TextLength == 11)
            {
                MessageBox.Show("TC kimlik numarası 11 karakterden oluşmaktadır.Lütfen doğru girildiğinden emin olunuz.");
                e.Handled = true;
                tc_no.Clear();
            }
        }

        private void ad_soyad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void oda_no_KeyPress(object sender, KeyPressEventArgs e)
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
            if (oda_no.TextLength > 2)
            {
                e.Handled = true;
            }
        }

        private void personel_gorev_KeyPress(object sender, KeyPressEventArgs e)
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
