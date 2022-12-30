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
    public partial class Danisman_DevamEdenTezler : Form
    {
        public Danisman_DevamEdenTezler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");
        private void Danisman_DevamEdenTezler_Load(object sender, EventArgs e)
        {
            gridoldur();
            ogr1getir();
            ogr2getir();
            dilgetir();
            tur();
            durum();
        }
        private void datadevamtez_SelectionChanged(object sender, EventArgs e)
        {
            if (datadevamtez.SelectedRows.Count > 0)
            {
                int secilensatir = datadevamtez.CurrentRow.Index;
                int id = Convert.ToInt32(datadevamtez.Rows[secilensatir].Cells[0].Value.ToString());
                labelid.Text = id.ToString();
                Txttezadi.Text = datadevamtez.Rows[secilensatir].Cells[1].Value.ToString();
                cbdil.Text = datadevamtez.Rows[secilensatir].Cells[2].Value.ToString();
                cmtur.Text = datadevamtez.Rows[secilensatir].Cells[3].Value.ToString();
                cbdurum.Text = datadevamtez.Rows[secilensatir].Cells[4].Value.ToString();
                datebaslangic.Text = datadevamtez.Rows[secilensatir].Cells[5].Value.ToString();
                dateBitis.Text = datadevamtez.Rows[secilensatir].Cells[6].Value.ToString();
                cbogr1.Text = datadevamtez.Rows[secilensatir].Cells[7].Value.ToString();
                cbogr2.Text = datadevamtez.Rows[secilensatir].Cells[8].Value.ToString();
                txtozet.Text = datadevamtez.Rows[secilensatir].Cells[9].Value.ToString();
                txtanahtar.Text = datadevamtez.Rows[secilensatir].Cells[10].Value.ToString();
            }
        }
        private void Btnguncelle_Click(object sender, EventArgs e) //sp oluşturulacak....
        {
            string[] Param = { "@Id", "@TezAdi", "@Dil", "@tezturu", "@tezdurum", "@BaslamaTarihi", "@BitisTarihi", "@ogrenci1", "@ogrenci2", "@Ozet", "@AnahtarKelime" };
            string[] Deger = { labelid.Text, Txttezadi.Text, cbdil.SelectedValue.ToString(), cmtur.SelectedValue.ToString(), cbdurum.SelectedValue.ToString(), datebaslangic.Value.Date.ToString("yyyy-MM-dd"), dateBitis.Value.Date.ToString("yyyy-MM-dd"), cbogr1.SelectedValue.ToString(), cbogr2.SelectedValue.ToString(), txtozet.Text, txtanahtar.Text };
            bool mesaj = Yardimci.EklemeIslemi("sp_TezBitir", Param, Deger);
            if (mesaj)
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı...");
            }
            else
            {
                MessageBox.Show("İşlem başarısız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridoldur()
        {
            baglanti.Open();
            string sorgu = "Select Id From Kullanici WHERE Mail=@mail";
            SqlCommand comand = new SqlCommand(sorgu, baglanti);
            comand.Parameters.AddWithValue("@mail", Yardimci.KullaniciBilgisi.Mail);
            SqlDataAdapter da = new SqlDataAdapter(comand);
            SqlDataReader dr = comand.ExecuteReader();
            if (dr.Read())
            {
                danismanid.Text = dr["Id"].ToString();
                dr.Close();
            }
            Danisman_OlusmusTezler dt = new Danisman_OlusmusTezler();
            string datalistele = "SELECT Tez.Id,Tez.TezAdi as [Tez Adı],TezDili.DilAdi as [Dili],TezTuru.TurAdi as [Türü],TezDurum.DurumAdi as [Durum], Tez.BaslamaTarihi as [Başlama Tarihi],Tez.BitisTarihi as [Bitiş Tarihi],Tez.ogrenci1 as [Öğrenci 1],Tez.ogrenci2 as [Öğrenci 2],Tez.Ozet as [Özet],Tez.AnahtarKelime as [Anahtar Kelime] from  Tez INNER JOIN TezDili ON TezDili.Id=Tez.Dil INNER JOIN TezTuru ON TezTuru.ID=Tez.tezturu INNER JOIN TezDurum ON TezDurum.ID=Tez.tezdurum where tezdurum=2  and danismanid=" + danismanid.Text;
            DataTable datagetir = Yardimci.VeriOku(datalistele);
            datadevamtez.DataSource = datagetir;
        }
        private void ogr1getir()
        {
            string ogr1getir = "Select Id, KullaniciAdi FROM  Kullanici Where rolid=2 ";
            Yardimci.ComboboxDoldur(cbogr1, ogr1getir, "Id", "KullaniciAdi");
            cbogr1.SelectedIndex = -1;
        }
        private void ogr2getir()
        {
            string ogr2getir = "Select Id, KullaniciAdi FROM  Kullanici Where rolid=2 ";
            Yardimci.ComboboxDoldur(cbogr2, ogr2getir, "Id", "KullaniciAdi");
            cbogr2.SelectedIndex = -1;
        }
        private void dilgetir()
        {
            string dilgetir = "Select Id, DilAdi FROM  TezDili ";
            Yardimci.ComboboxDoldur(cbdil, dilgetir, "Id", "DilAdi");

        }
        private void tur()
        {
            string turgetir = "Select * FROM  TezTuru";
            Yardimci.ComboboxDoldur(cmtur, turgetir, "Id", "TurAdi");
        }
        private void durum()
        {
            string durumgetir = "Select * FROM  TezDurum";
            Yardimci.ComboboxDoldur(cbdurum, durumgetir, "Id", "DurumAdi");
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
