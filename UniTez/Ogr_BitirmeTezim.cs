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
    public partial class Ogr_BitirmeTezim : Form
    {
        public Ogr_BitirmeTezim()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");
        public void gridoldur()
        {

            baglanti.Open();
            string sorgu = "Select Id From Kullanici WHERE Mail=@mail";
            SqlCommand comand = new SqlCommand(sorgu, baglanti);
            comand.Parameters.AddWithValue("@mail", Yardimci.KullaniciBilgisi.Mail);
            SqlDataAdapter da = new SqlDataAdapter(comand);
            SqlDataReader dr = comand.ExecuteReader();
            if (dr.Read())
            {
                labelogr.Text = dr["Id"].ToString();
                dr.Close();
            }
            baglanti.Close();

            string datagetir = "SELECT Tez.TezAdi,Kullanici.Mail as [Danışman Mail],TezDili.DilAdi,TezTuru.TurAdi,Tez.Ozet,Tez.AnahtarKelime from Kullanici INNER JOIN  Tez ON Kullanici.Id = Tez.danismanid  INNER JOIN TezDili ON TezDili.Id=Tez.Dil INNER JOIN TezTuru ON TezTuru.ID=Tez.tezturu where Tez.ogrenci1 = " + labelogr.Text + "or Tez.ogrenci2 = " + labelogr.Text;
            //where Tez.ogrenci1 = "+labelogr.Text + "or Tez.ogrenci2 = "+labelogr.Text
            DataTable teztablo = Yardimci.VeriOku(datagetir);
            datatezim.DataSource = teztablo;
        }

        private void Ogr_BitirmeTezim_Load(object sender, EventArgs e)
        {
            gridoldur();
        }
    }
}
