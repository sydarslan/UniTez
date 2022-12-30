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
    public partial class DanismanAnaSayfa : Form
    {
        public DanismanAnaSayfa()
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
        private void DanismanAnaSayfa_Load(object sender, EventArgs e)
        {
            BilgiGetir();
            tezsayisi();
            dtezsayisi();
        }
        private void BilgiGetir()
        {
            baglanti.Open();
            string danismanbilgi = "select Kullanici.KullaniciAdi,Kullanici.KullaniciSoyadi, AkademikBolum.BolumAdi from AkademikBolum INNER JOIN Kullanici ON AkademikBolum.Id=Kullanici.bolumid  WHERE Mail=@mail";
            SqlCommand komut = new SqlCommand(danismanbilgi, baglanti);
            komut.Parameters.AddWithValue("@mail", Yardimci.KullaniciBilgisi.Mail);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                labeldanismanad.Text = dr["KullaniciAdi"].ToString();  //güzel olmadi...
                labeldanismansoyad.Text = dr["KullaniciSoyadi"].ToString();
                labeldanismanbolum.Text = dr["BolumAdi"].ToString();
                dr.Close();
            }
            else
            {
                MessageBox.Show("bilgilere ulaşılamadı");
                baglanti.Close();
            }
            baglanti.Close();
        }
        //tez sayisi ve devam eden tez sayısı için temiz kod yaz....
        private void tezsayisi()
        {
            baglanti.Open();
            string getir = "select  Tez.Id FROM  Kullanici INNER JOIN Tez ON  Kullanici.Id = Tez.danismanid where Kullanici.Mail=@mail";
            SqlCommand komut = new SqlCommand(getir, baglanti);
            komut.Parameters.AddWithValue("@mail", Yardimci.KullaniciBilgisi.Mail);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            labeltezsayisi.Text = ds.Tables[0].Rows.Count.ToString();
            baglanti.Close();
        }
        private void dtezsayisi()
        {
            baglanti.Open();
            string getir = "select  Tez.Id FROM  Kullanici INNER JOIN Tez ON  Kullanici.Id = Tez.danismanid where Kullanici.Mail=@mail and tezdurum=2";
            SqlCommand komut = new SqlCommand(getir, baglanti);
            komut.Parameters.AddWithValue("@mail", Yardimci.KullaniciBilgisi.Mail);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            labeldevamtezsayisi.Text = ds.Tables[0].Rows.Count.ToString();
            baglanti.Close();
        }
        //
        private void BtnTezOlustur_Click(object sender, EventArgs e)
        {
            openChilForm(new Danisman_TezOlustur());
        }

        private void BtnOlusmusTez_Click(object sender, EventArgs e)
        {
            openChilForm(new Danisman_OlusmusTezler());
        }

        private void BtnDevamEdenTezler_Click(object sender, EventArgs e)
        {
            openChilForm(new Danisman_DevamEdenTezler());
        }

        private void BtnTezBasvurulari_Click(object sender, EventArgs e)
        {
            openChilForm(new Danisman_TezBasvuru());
        }

        private void BtnTezOnerileri_Click(object sender, EventArgs e)
        {
            openChilForm(new Danisman_TezOneri());
        }  
        private void BtnBilgilerim_Click(object sender, EventArgs e)
        {
            openChilForm(new Danisman_Bilgilerim());
        }
    }
}
