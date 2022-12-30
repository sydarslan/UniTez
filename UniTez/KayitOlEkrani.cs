using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace UniTez
{
    public partial class KayitOlEkrani : Form
    {
        public KayitOlEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");

        public object Session { get; private set; }

        private void KayitOlEkrani_Load(object sender, EventArgs e)
        {
            BolumGetir();
        }
        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kullanici WHERE Mail='" + TxtKayitMail.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read()) //Girilen mais ve şifre dahiline gelen kayıt var ise:
            {
                MessageBox.Show("Bu kullanıcı mail adresi zaten kayıtlı... Giriş Yap Ekranına Gidiniz...");
                GirisEkrani girisyap = new GirisEkrani();
                girisyap.Show();
                this.Hide();
            }
            else
            {
                oku.Close();
                bool SayiMi(string text)
                {
                    foreach (char chr in text)
                    {
                        if (!Char.IsNumber(chr)) return false;
                    }
                    return true;
                }
                if (SayiMi(TxtKayitMail.Text) == true)
                {
                    string[] Param = { "@KullaniciAdi", "@KullaniciSoyadi", "@Mail", "@Telefon","@bolumid","@Sifre","@rolid","@AktiflikDurumu" };
                    string[] Deger = { TxtKayitAd.Text, TxtKayitSoyad.Text, TxtKayitMail.Text, TxtKayitTelefon.Text, CmbKayitBolum.SelectedValue.ToString(), TxtKayitSifre.Text,"2","1" };
                    bool mesaj = Yardimci.EklemeIslemi("spKullaniciEkle", Param, Deger);
                    if (mesaj)
                    {
                        
                            MessageBox.Show("Öğrenci Kayıt İşlemi Başarılı...");
                            GirisEkrani girisyap = new GirisEkrani();
                            girisyap.Show();
                            this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız");
                        
                    }
                }
                else
                {
                    string[] Param = { "@KullaniciAdi", "@KullaniciSoyadi", "@Mail", "@Telefon","@bolumid","@Sifre","@rolid","@AktiflikDurumu" };
                    string[] Deger = { TxtKayitAd.Text, TxtKayitSoyad.Text, TxtKayitMail.Text, TxtKayitTelefon.Text, CmbKayitBolum.SelectedValue.ToString(), TxtKayitSifre.Text, "1","1"};
                    bool mesaj = Yardimci.EklemeIslemi("spKullaniciEkle", Param, Deger);
                   
                    if (mesaj)
                    {
                        MessageBox.Show("Danışman Kayıt İşlemi Başarılı...");
                        GirisEkrani girisyap = new GirisEkrani();
                        girisyap.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("İşlem başarısız");
                    }
                }
            }
            baglanti.Close();
        }  //Kullanıcı kaydı yapılır
        private void CmbKayitBolum_SelectedIndexChanged(object sender, EventArgs e) //Combobox otomatik doldurur
        {
            CmbKayitBolum.AutoCompleteSource = (AutoCompleteSource)CmbKayitBolum.SelectedItem;
        }
        private void TxtKayitAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                bool BosMu = Kontrol(TxtKayitAd, TxtKayitSoyad);
                if (BosMu)
                {
                    MessageBox.Show("Ad Alanını Doldurunuz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtKayitAd.Focus();
                    TxtKayitAd.BackColor = Color.LavenderBlush;
                }
                else
                {
                    TxtKayitSoyad.Focus();
                }
            }
        }
        private void TxtKayitSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                bool BosMu = Kontrol(TxtKayitSoyad, TxtKayitMail);
                if (BosMu)
                {
                    MessageBox.Show("Soyad Alanını Doldurunuz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtKayitSoyad.Focus();
                    TxtKayitSoyad.BackColor = Color.LavenderBlush;
                }
                else
                {
                    TxtKayitMail.Focus();
                }
            }
        }
        private void TxtKayitMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                bool BosMu = Kontrol(TxtKayitMail, TxtKayitTelefon);
                if (BosMu)
                {
                    MessageBox.Show("Mail Alanını Doldurunuz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtKayitMail.Focus();
                    TxtKayitMail.BackColor = Color.LavenderBlush;
                }
                else
                {
                    TxtKayitSifre.Focus();
                }
            }
        }
        private void TxtKayitTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                bool BosMu = Kontrol(TxtKayitTelefon, TxtKayitSifre);
                if (BosMu)
                {
                    MessageBox.Show("Telefon Alanını Doldurunuz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtKayitTelefon.Focus();
                    TxtKayitTelefon.BackColor = Color.LavenderBlush;
                }
                else
                {
                    TxtKayitSifre.Focus();
                }
            }
        }
        private void TxtKayitSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                if (TxtKayitSifre.Text != "")
                {

                    CmbKayitBolum.Focus();
                }
                else
                {
                    MessageBox.Show("Şifrenizi Giriniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtKayitSifre.BackColor = Color.LavenderBlush;
                    TxtKayitSifre.Focus();
                }
            }
        }
        public bool Kontrol(TextBox GelenVeri, TextBox SonrakiVeri)
        {
            bool BosMu = true;
            if (GelenVeri.Text != "")
            {
                BosMu = false;
                SonrakiVeri.Focus();
            }
            return BosMu;
        }
        private void linkGirisYapEkrani_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisEkrani giris = new GirisEkrani();
            giris.Show();
            this.Hide();
        }
        private void BolumGetir() //combobox içine akademik bölümleri getirir
        {
            string bolumgetir = "Select * From AkademikBolum";
            DataTable akademikbolum = Yardimci.VeriOku(bolumgetir);
            CmbKayitBolum.DataSource = akademikbolum;
            CmbKayitBolum.ValueMember = "Id";
            CmbKayitBolum.DisplayMember = "BolumAdi";
            CmbKayitBolum.SelectedIndex = -1;
            CmbKayitBolum.Text = "Seçiniz...";
        }
    }
}
