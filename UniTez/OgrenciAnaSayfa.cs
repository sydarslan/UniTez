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
    public partial class OgrenciAnaSayfa : Form
    {
        public OgrenciAnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");
        private Form activeForm = null;
        private void openChilForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       

        //bilgi getir için yardımcı için temiz kod yaz.... hem danışman hem öğrenci için kullan 

        private void BilgiGetir()
        {
            baglanti.Open();
            string danismanbilgi = "select Kullanici.Id,Kullanici.KullaniciAdi,Kullanici.KullaniciSoyadi, AkademikBolum.BolumAdi from AkademikBolum INNER JOIN Kullanici ON AkademikBolum.Id=Kullanici.bolumid  WHERE Mail=@mail";
            SqlCommand komut = new SqlCommand(danismanbilgi, baglanti);
            komut.Parameters.AddWithValue("@mail", Yardimci.KullaniciBilgisi.Mail);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                ograd.Text = dr["KullaniciAdi"].ToString();  //güzel olmadi...
                ogrsoyad.Text = dr["KullaniciSoyadi"].ToString();
                ogrbolum.Text = dr["BolumAdi"].ToString();
                labelogrid.Text = dr["Id"].ToString();
                dr.Close();
            }
            else
            {
                MessageBox.Show("bilgilere ulaşılamadı");
                baglanti.Close();
            }
            baglanti.Close();
        }

        private void TezBilgi()
        {
            baglanti.Open();
            string TezBilgi = "select TezAdi, BaslamaTarihi,BitisTarihi From Tez  WHERE ogrenci1=" + labelogrid.Text + "or ogrenci2="+labelogrid.Text;
            SqlCommand komut = new SqlCommand(TezBilgi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                labelTezAdi.Text = dr["TezAdi"].ToString();
                labelbaslamatarih.Text = dr["BaslamaTarihi"].ToString();
                labelBitisTarihi.Text = dr["BitisTarihi"].ToString();
                dr.Close();
            }
            else
            {
                MessageBox.Show("bilgilere ulaşılamadı");
                baglanti.Close();
            }
            baglanti.Close();
        }
        private void OgrenciAnaSayfa_Load(object sender, EventArgs e)
        {
            BilgiGetir();
            TezBilgi();
        }

        private void BtnTezBasvuru_Click(object sender, EventArgs e)
        {
            openChilForm(new Ogr_TezBasvur());
        }

        private void BtnTezOner_Click(object sender, EventArgs e)
        {
            openChilForm(new Ogr_TezOner());
        }

        private void BtnOneribasvuru_Click(object sender, EventArgs e)
        {
            openChilForm(new Ogr_TezBasOne());
        }

        private void BtnBitirmeTezi_Click(object sender, EventArgs e)
        {
            openChilForm(new Ogr_BitirmeTezim());
        }

        private void BtnBilgilerim_Click(object sender, EventArgs e)
        {
            openChilForm(new Ogr_Bilgilerim());
        }
    }
}
