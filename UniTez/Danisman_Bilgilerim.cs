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
    public partial class Danisman_Bilgilerim : Form
    {
        public Danisman_Bilgilerim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");

        private void Danisman_Bilgilerim_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("SELECT Kullanici.KullaniciAdi, Kullanici.KullaniciSoyadi,Kullanici.Mail,Kullanici.Telefon,Kullanici.Sifre,AkademikBolum.BolumAdi From AkademikBolum INNER JOIN Kullanici ON AkademikBolum.Id=Kullanici.bolumid where Mail=@mail", baglanti);
            komut.Parameters.AddWithValue("@mail", Yardimci.KullaniciBilgisi.Mail);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                TxtAd.Text = read["KullaniciAdi"].ToString();
                TxtSoyad.Text = read["KullaniciSoyadi"].ToString();
                Txtmail.Text = read["Mail"].ToString();
                TxtTelefon.Text = read["Telefon"].ToString();
                TxtSifre.Text = read["Sifre"].ToString();
                cbbolum.Text= read["BolumAdi"].ToString();
            }
            baglanti.Close();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            //    baglanti.Open();
            //    SqlCommand guncelle = new SqlCommand("update  Uyeler set UyeAdi='" + TxtAdminAd.Text + "',UyeSoyadi='" + TxtAdminSoyad.Text + "',Telefon='" + TxtAdminTelefon.Text + "',Mail='" + TxtAdminMail.Text + "',Sifre='" + TxtAdminSifre.Text + "' where tipid=1", baglanti);
            //    guncelle.ExecuteNonQuery();
            //    baglanti.Close();
            //    MessageBox.Show("Danışman" +
            //        " Bilgileri Güncellendi");
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }


}
