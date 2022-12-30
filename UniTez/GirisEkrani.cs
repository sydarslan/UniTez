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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");
        private void LinkUyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //linke tıklanır kayıt ol ekranına yönlendirilir
            KayitOlEkrani kayitol = new KayitOlEkrani();
            kayitol.Show();
            this.Hide();
        }
        public void BtnGirisYap_Click(object sender, EventArgs e)
        {

            if (TxtGirisMail.Text == "" && TxtGirisSifre.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız...");
            }
            else
            {
                baglanti.Open();
                string giris="Select * from Kullanici where Mail=@mail and Sifre=@sifre";
                SqlCommand komut = new SqlCommand(giris, baglanti);
                komut.Parameters.AddWithValue("@mail", TxtGirisMail.Text);
                komut.Parameters.AddWithValue("@sifre" , TxtGirisSifre.Text);
                Yardimci.KullaniciBilgisi.Mail = TxtGirisMail.Text;
                //SqlCommand komut = new SqlCommand("Select * from Kullanici where Mail='" + TxtGirisMail.Text + "' and Sifre='" + TxtGirisSifre.Text + "'", baglanti);  //sqlcommand ile sorgu cümlesi yazılır.
                SqlDataReader oku = komut.ExecuteReader();  //sqldatareader ile sql veritabanındaki dataları okur
                if (oku.HasRows) //Girilen mais ve şifre dahiline gelen kayıt var ise:
                {
                    while (oku.Read())
                    {
                        if (oku["rolid"].ToString() == "1") //kullanıcı danışman ise:
                        {
                            DanismanAnaSayfa danisman=new DanismanAnaSayfa();
                            danisman.Show();
                            this.Hide();
                        }
                        else
                        {
                            //öğrenci sayfasını göster
                            OgrenciAnaSayfa ogrenci = new OgrenciAnaSayfa();
                            ogrenci.Show();
                            this.Hide();   
                        }
                    } 
                }
                else
                {
                    //Reader SATIR döndüremiyorsa mail şifre Yanlış Demekdir
                    oku.Close();
                    MessageBox.Show("Geçersiz Mail veya Şifre...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtGirisMail.Text = "";
                    TxtGirisSifre.Text = "";
                    TxtGirisMail.Focus();
                }
                baglanti.Close();
            }
        }
        private void TxtGirisMail_Enter(object sender, EventArgs e)
        {
            //TxtGirisMail.BackColor = Color.LavenderBlush;
            //TxtGirisSifre.BackColor = Color.White;
        }

        private void TxtGirisSifre_Enter(object sender, EventArgs e)
        {
            //TxtGirisMail.BackColor = Color.White;
            //TxtGirisSifre.BackColor = Color.LavenderBlush;
        }

        private void TxtGirisMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                if (TxtGirisMail.Text != "")
                {

                    TxtGirisSifre.Focus();
                }
                else
                {
                    MessageBox.Show("Mail Adresinizi Giriniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtGirisMail.BackColor = Color.LavenderBlush;
                    TxtGirisMail.Focus();
                }
            }
        }

        private void TxtGirisSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 13)
            {
                if (TxtGirisSifre.Text != "")
                {
                    BtnGirisYap.Focus();
                }
                else
                {
                    MessageBox.Show("Şifre Alanını Doldurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtGirisSifre.BackColor = Color.LavenderBlush;
                    TxtGirisSifre.Focus();
                }
            }
        }
    }
}
