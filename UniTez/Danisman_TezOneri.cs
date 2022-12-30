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
    public partial class Danisman_TezOneri : Form
    {
        public Danisman_TezOneri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Danisman_TezOneri_Load(object sender, EventArgs e)
        {
            gridoldur();
            birimgetir();
            tezdilgetir();
            tezturugetir();
            ogrenci();
        }
        private void dataoneri_SelectionChanged(object sender, EventArgs e)
        {
            if (dataoneri.SelectedRows.Count > 0)
            {
                int secilensatir = dataoneri.CurrentRow.Index;
                int id = Convert.ToInt32(dataoneri.Rows[secilensatir].Cells[0].Value.ToString());
                tezid.Text = id.ToString();
                Txttezadi.Text = dataoneri.Rows[secilensatir].Cells[1].Value.ToString();
                txtozet.Text = dataoneri.Rows[secilensatir].Cells[2].Value.ToString();
                txtanahtar.Text = dataoneri.Rows[secilensatir].Cells[3].Value.ToString();
                cbbirim.Text = dataoneri.Rows[secilensatir].Cells[4].Value.ToString();
                cbprogram.Text = dataoneri.Rows[secilensatir].Cells[5].Value.ToString();
                cmbolum.Text = dataoneri.Rows[secilensatir].Cells[6].Value.ToString();
                cbogr1.Text = dataoneri.Rows[secilensatir].Cells[7].Value.ToString();
                int danismanid = Convert.ToInt32(dataoneri.Rows[secilensatir].Cells[8].Value.ToString());
                labeldanismanid.Text = danismanid.ToString();
                cbdil.Text = dataoneri.Rows[secilensatir].Cells[9].Value.ToString();
                cmtur.Text = dataoneri.Rows[secilensatir].Cells[10].Value.ToString();
            }
        }
        private void BtnOnay_Click(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string[] Param = {  "@TezAdi", "@Ozet", "@AnahtarKelime" ,"@OlusturmaTarihi","@Tbirimid", "@Tprogramid", "@Tbolumid",   "@ogrenci1", "@ogrenci2","@danismanid", "@Dil", "@tezturu", "@tezdurum" };
            string[] Deger = { Txttezadi.Text, txtozet.Text,txtanahtar.Text,today,cbbirim.SelectedValue.ToString(), cbprogram.SelectedValue.ToString(), cmbolum.SelectedValue.ToString(), cbogr1.SelectedValue.ToString(),cbogr1.SelectedValue.ToString(),labeldanismanid.Text,cbdil.SelectedValue.ToString(), cmtur.SelectedValue.ToString(),"2" };
            bool mesaj = Yardimci.EklemeIslemi("spTezOneriOnay", Param, Deger);
            if (mesaj)
            {
                MessageBox.Show("Seçili Öneri Onaylandı...");
            }
            else
            {
                MessageBox.Show("İşlem başarısız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //baglanti.Open();
            //string sil = "delete TezOneri where Id=" +dataoneri.CurrentRow.Cells[0].Value.ToString();
            //SqlCommand komut = new SqlCommand(sil, baglanti);
            //komut.ExecuteNonQuery();
            //baglanti.Close();
        }
        private void Btnguncelle_Click(object sender, EventArgs e)
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
            string sorgu = "SELECT TezOneri.Id,TezOneri.TezAdi, TezOneri.Ozet, TezOneri.AnahtarKelime,AkademikBirim.BirimAdi,AkademikProgram.ProgramAdi,AkademikBolum.BolumAdi, Kullanici.Mail,TezOneri.danismanid,TezDili.DilAdi, TezTuru.TurAdi FROM AkademikBirim INNER JOIN TezOneri ON AkademikBirim.Id=TezOneri.birimid INNER JOIN AkademikProgram on AkademikProgram.Id=TezOneri.programid INNER JOIN AkademikBolum on AkademikBolum.Id=TezOneri.bolumid Inner join Kullanici on Kullanici.Id=TezOneri.ogrenci INNER JOIN TezTuru ON TezTuru.Id=TezOneri.tur inner join TezDili ON TezDili.Id=TezOneri.dil where danismanid=" + labeldanismanid.Text;
            DataTable datagetir = Yardimci.VeriOku(sorgu);
            dataoneri.DataSource = datagetir;
        }
        public void birimgetir()
        {
            string birimgetir = "Select Id, BirimAdi  FROM  AkademikBirim";
            DataTable birimtablosu = Yardimci.VeriOku(birimgetir);
            cbbirim.ValueMember = "Id";
            cbbirim.DisplayMember = "BirimAdi";
            cbbirim.DataSource = birimtablosu;
            cbbirim.SelectedIndex = -1;
            cbbirim.Text = "Seçiniz...";
        }
        private void tezdilgetir()
        {
            string dilgetir = "Select * FROM  TezDili";
            Yardimci.ComboboxDoldur(cbdil, dilgetir, "Id", "DilAdi");
        }
        private void tezturugetir()
        {
            string turgetir = "Select * FROM  TezTuru";
            Yardimci.ComboboxDoldur(cmtur, turgetir, "Id", "TurAdi");
        }
        private void cbbirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbirim.SelectedIndex != -1)
            {
                string programgetir = "Select * FROM  AkademikProgram where birimid =" + cbbirim.SelectedValue;
                DataTable programtablosu = Yardimci.VeriOku(programgetir);
                cbprogram.ValueMember = "Id";
                cbprogram.DisplayMember = "ProgramAdi";
                cbprogram.DataSource = programtablosu;
                cbprogram.SelectedIndex = -1;
                cbprogram.Text = "Seçiniz...";
            }
        }
        private void cbprogram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbprogram.SelectedIndex != -1)
            {
                string bolumgetir = "Select * FROM  AkademikBolum  where programid =" + cbprogram.SelectedValue;
                DataTable bolumtablosu = Yardimci.VeriOku(bolumgetir);
                cmbolum.ValueMember = "Id";
                cmbolum.DisplayMember = "BolumAdi";
                cmbolum.DataSource = bolumtablosu;
                cmbolum.Text = "Seçiniz...";
            }
        }
        private void ogrenci()
        {

            string dgetir = "Select * FROM  Kullanici where rolid=2" ;
            DataTable dtablo = Yardimci.VeriOku(dgetir);
            cbogr1.ValueMember = "Id";
            cbogr1.DisplayMember = "Mail";
            cbogr1.DataSource = dtablo;
            cbogr1.SelectedIndex = -1;
        }  
    }
}
