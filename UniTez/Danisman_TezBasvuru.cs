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
    public partial class Danisman_TezBasvuru : Form
    {
        public Danisman_TezBasvuru()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");
        private void Danisman_TezBasvuru_Load(object sender, EventArgs e) //düzenlenecek...
        {
            gridoldur();
        }
        private void gridoldur()
        {
            baglanti.Open();
            string idsorgu = "Select Id From Kullanici WHERE Mail=@mail";
            SqlCommand comand = new SqlCommand(idsorgu, baglanti);
            comand.Parameters.AddWithValue("@mail", Yardimci.KullaniciBilgisi.Mail);
            SqlDataAdapter da = new SqlDataAdapter(comand);
            SqlDataReader dr = comand.ExecuteReader();
            if (dr.Read())
            {
                labeldanismanid.Text = dr["Id"].ToString();
                dr.Close();
            }
            baglanti.Close();
            string sorgu = "SELECT Id,TezId,TezAdi,ogrenci,BasvuruTarihi From TezBasvuru where danismanid=" + labeldanismanid.Text;
            DataTable datagetir = Yardimci.VeriOku(sorgu);
            datagelenbasvurular.DataSource = datagetir;
        }
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void datagelenbasvurular_SelectionChanged(object sender, EventArgs e)
        {
            if (datagelenbasvurular.SelectedRows.Count > 0)
            {
                int secilensatir = datagelenbasvurular.CurrentRow.Index;
                int id = Convert.ToInt32(datagelenbasvurular.Rows[secilensatir].Cells[0].Value.ToString());
                labelid.Text = id.ToString();
                int tid = Convert.ToInt32(datagelenbasvurular.Rows[secilensatir].Cells[1].Value.ToString());
                tezid.Text = tid.ToString();
                txtTezAdi.Text = datagelenbasvurular.Rows[secilensatir].Cells[2].Value.ToString();
                int ogrenci = Convert.ToInt32(datagelenbasvurular.Rows[secilensatir].Cells[3].Value.ToString());
                labelogrenci.Text = ogrenci.ToString();
            }
        }
        private void BtnOnay_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string update = "Update Tez set tezdurum=@durum, ogrenci1=@ogr where Id=" + tezid.Text;
            SqlCommand cmd = new SqlCommand(update, baglanti);
            cmd.Parameters.AddWithValue("@durum", "2");
            cmd.Parameters.AddWithValue("@ogr", labelogrenci.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            BasvuruKaldir();
            bildirimgonder();

            //tezin id bilgisini al tez tablosunda  o tezin tez durumunu devam ediyor olarak güncelle -yapıldı
            //o tezid tezbasvuru tablosundan silinmeli --yapıldı
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {

            BasvuruKaldir();
        }
        private void BasvuruKaldir()
        {
            baglanti.Open();
            string sil = "Delete TezBasvuru where Id=" + labelid.Text;
            SqlCommand komut = new SqlCommand(sil, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            gridoldur();
            
        }
        private void bildirimgonder()
        {
            baglanti.Open();
            string bildirim = "insert into Bildirim(danismanid,ogrenci,durum,tezid) values(@p1,@p2,@p3,@p4)";
            SqlCommand komut = new SqlCommand(bildirim, baglanti);
            komut.Parameters.AddWithValue("@p1",labeldanismanid.Text);
            komut.Parameters.AddWithValue("@p2",labelogrenci.Text);
            komut.Parameters.AddWithValue("@p3",7);
            komut.Parameters.AddWithValue("@p4",labelid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
