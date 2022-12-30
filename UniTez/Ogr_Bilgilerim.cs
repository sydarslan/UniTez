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
    public partial class Ogr_Bilgilerim : Form
    {
        public Ogr_Bilgilerim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");

        private void Ogr_Bilgilerim_Load(object sender, EventArgs e)
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
                cbbolum.Text = read["BolumAdi"].ToString();
            }
            baglanti.Close();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            //bilgileri güncelle
        }
    }
}
