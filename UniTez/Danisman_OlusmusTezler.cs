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
    public partial class Danisman_OlusmusTezler : Form
    {
        public Danisman_OlusmusTezler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");
        private void Danisman_OlusmusTezler_Load(object sender, EventArgs e)
        {
            gridoldur();
            dilgetir();
            ogr1getir();
            ogr2getir();
            tur();
            durum();
            birim();
        }
        private void dataolusmustez_SelectionChanged(object sender, EventArgs e)
        {
            if (dataolusmustez.SelectedRows.Count > 0)
            {
                int secilensatir = dataolusmustez.CurrentRow.Index;
                int id = Convert.ToInt32(dataolusmustez.Rows[secilensatir].Cells[0].Value.ToString());
                labelid.Text = id.ToString();
                Txttezadi.Text = dataolusmustez.Rows[secilensatir].Cells[1].Value.ToString();
                cbbirim.Text = dataolusmustez.Rows[secilensatir].Cells[2].Value.ToString();
                cbprogram.Text = dataolusmustez.Rows[secilensatir].Cells[3].Value.ToString();
                cmbolum.Text = dataolusmustez.Rows[secilensatir].Cells[4].Value.ToString();
                cbdil.Text = dataolusmustez.Rows[secilensatir].Cells[5].Value.ToString();
                cmtur.Text = dataolusmustez.Rows[secilensatir].Cells[6].Value.ToString();
                cbdurum.Text = dataolusmustez.Rows[secilensatir].Cells[7].Value.ToString();
                datebaslangic.Text = dataolusmustez.Rows[secilensatir].Cells[8].Value.ToString();
                cbogr1.Text = dataolusmustez.Rows[secilensatir].Cells[9].Value.ToString();
                cbogr2.Text = dataolusmustez.Rows[secilensatir].Cells[10].Value.ToString();
                txtozet.Text = dataolusmustez.Rows[secilensatir].Cells[11].Value.ToString();
                txtanahtar.Text = dataolusmustez.Rows[secilensatir].Cells[12].Value.ToString();
            }
        }
        private void Btnguncelle_Click(object sender, EventArgs e) //sp çalışmıyor???....
        {
            string[] Param = { "@Id","@TezAdi", "@Tbirimid", "@Tprogramid", "@bolumid", "@Dil", "@tezturu", "@tezdurum", "@BaslamaTarihi", "@ogrenci1", "@ogrenci2", "@Ozet", "@AnahtarKelime"};
            string[] Deger = { labelid.Text,Txttezadi.Text, cbbirim.SelectedValue.ToString(), cbprogram.SelectedValue.ToString(), cmbolum.SelectedValue.ToString(), cbdil.SelectedValue.ToString(), cmtur.SelectedValue.ToString(), cbdurum.SelectedValue.ToString(), datebaslangic.Value.Date.ToString("yyyy-MM-dd"), cbogr1.SelectedValue.ToString(), cbogr2.SelectedValue.ToString(), txtozet.Text, txtanahtar.Text };
            bool mesaj = Yardimci.EklemeIslemi("sp_TezGuncelle", Param, Deger);
            if (mesaj)
            {
                MessageBox.Show("Tez Güncelleme İşlemi Başarılı...");
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
            string datalistele = "SELECT Tez.Id,Tez.TezAdi,AkademikBirim.BirimAdi,AkademikProgram.ProgramAdi,AkademikBolum.BolumAdi,TezDili.DilAdi,TezTuru.TurAdi,TezDurum.DurumAdi, Tez.BaslamaTarihi,Tez.ogrenci1,Tez.ogrenci2,Tez.Ozet,Tez.AnahtarKelime from  AkademikProgram INNER JOIN Tez ON AkademikProgram.Id = Tez.Tprogramid INNER JOIN AkademikBirim ON AkademikBirim.Id=Tez.Tbirimid INNER JOIN AkademikBolum ON AkademikBolum.Id=Tez.Tbolumid INNER JOIN TezDili ON TezDili.Id=Tez.Dil INNER JOIN TezTuru ON TezTuru.ID=Tez.tezturu INNER JOIN TezDurum ON TezDurum.ID=Tez.tezdurum where  tezdurum=1 and danismanid="+danismanid.Text ;

            DataTable datagetir = Yardimci.VeriOku(datalistele);
            dataolusmustez.DataSource = datagetir;
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
        private void birim()
        {
            string birimgetir = "Select Id, BirimAdi FROM  AkademikBirim ";
            Yardimci.ComboboxDoldur(cbbirim, birimgetir, "Id", "BirimAdi");
        }     
        private void cbbirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbirim.SelectedIndex != -1)
            {
                string programgetir = "Select * FROM  AkademikProgram where birimid=" + cbbirim.SelectedValue;
                
                DataTable program = Yardimci.VeriOku(programgetir);
                cbprogram.ValueMember = "Id";
                cbprogram.DisplayMember = "ProgramAdi";
                cbprogram.DataSource = program;
                cbprogram.Text = "Seçiniz...";
            }
        }
        private void cbprogram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbprogram.SelectedIndex != -1)
            {
                string bolumgetir = "Select * FROM  AkademikBolum where programid=" + cbprogram.SelectedValue;

                DataTable bolum = Yardimci.VeriOku(bolumgetir);
                cmbolum.ValueMember = "Id";
                cmbolum.DisplayMember = "BolumAdi";
                cmbolum.DataSource = bolum;
                cmbolum.Text = "Seçiniz...";
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
