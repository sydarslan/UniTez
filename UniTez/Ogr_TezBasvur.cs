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
    public partial class Ogr_TezBasvur : Form
    {
        public Ogr_TezBasvur()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");
        private void Ogr_TezBasvur_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select bolumid From Kullanici WHERE Mail=@mail";
            SqlCommand comand = new SqlCommand(sorgu, baglanti);
            comand.Parameters.AddWithValue("@mail", Yardimci.KullaniciBilgisi.Mail);
            SqlDataAdapter da = new SqlDataAdapter(comand);
            SqlDataReader dr = comand.ExecuteReader();
            if (dr.Read())
            {
                labelbolum.Text = dr["bolumid"].ToString();
                dr.Close();
            }
            baglanti.Close();

            string datalistele = "SELECT Tez.Id,Tez.TezAdi,AkademikBolum.BolumAdi,Kullanici.Mail as [Danışman Mail],TezDili.DilAdi,TezTuru.TurAdi,Tez.Ozet,Tez.AnahtarKelime from Kullanici INNER JOIN  Tez ON Kullanici.Id = Tez.danismanid INNER JOIN  AkademikProgram ON AkademikProgram.Id = Tez.Tprogramid INNER JOIN AkademikBirim ON AkademikBirim.Id=Tez.Tbirimid INNER JOIN AkademikBolum ON AkademikBolum.Id=Tez.Tbolumid INNER JOIN TezDili ON TezDili.Id=Tez.Dil INNER JOIN TezTuru ON TezTuru.ID=Tez.tezturu where Tez.tezdurum=1 and Tez.Tbolumid=" + labelbolum.Text ; //öğrencinin bölümünün tezleri gelmeli...
            DataTable datagetir = Yardimci.VeriOku(datalistele);
            datatezacik.DataSource = datagetir;

            string bolumgetir = "Select * FROM  AkademikBolum where Id=" + labelbolum.Text;
            DataTable bolumtablosu = Yardimci.VeriOku(bolumgetir);
            cbbolum.ValueMember = "Id";
            cbbolum.DisplayMember = "BolumAdi";   
            cbbolum.DataSource = bolumtablosu;
            cbbolum.SelectedIndex = -1;

            string dgetir = "Select * FROM  Kullanici where rolid=1 and bolumid=" + labelbolum.Text;
            DataTable dtablo= Yardimci.VeriOku(dgetir);
            cmdanisman.ValueMember = "Id";
            cmdanisman.DisplayMember = "Mail";
            cmdanisman.DataSource = dtablo;
            cmdanisman.SelectedIndex = -1;
        }
        private void datatezacik_SelectionChanged(object sender, EventArgs e)
        {
            if (datatezacik.SelectedRows.Count > 0)
            {
                int secilensatir = datatezacik.CurrentRow.Index;
                int id = Convert.ToInt32(datatezacik.Rows[secilensatir].Cells[0].Value.ToString());
                labelid.Text = id.ToString();
                TxtTezAdi.Text = datatezacik.Rows[secilensatir].Cells[1].Value.ToString();
                cbbolum.Text = datatezacik.Rows[secilensatir].Cells[2].Value.ToString();
                cmdanisman.Text = datatezacik.Rows[secilensatir].Cells[3].Value.ToString();
            }
        }
        private void BtnBasvur_Click(object sender, EventArgs e) //deger alanı düzenlenecek....
        {
            //Yardimci.bilgigetir(labelogr);
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
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            string[] Param = { "@TezId","@TezAdi", "@BasvuruTarihi", "@danismanid", "@ogrenci", "@bolumid","@durum" };
            string[] Deger = { labelid.Text,TxtTezAdi.Text, today, cmdanisman.SelectedValue.ToString(), labelogr.Text, cbbolum.SelectedValue.ToString(),"5"};

            SqlCommand komut = new SqlCommand("select * from TezBasvuru WHERE TezAdi='" + TxtTezAdi.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Aynı teze birden fazla başvuru yapılmaz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool mesaj = Yardimci.EklemeIslemi("spTezBasvur", Param, Deger);
                if (mesaj)
                {
                    MessageBox.Show("Başvuru Yapıldı...");
                }
                else
                {
                    MessageBox.Show("başarısız");
                }
            }
            baglanti.Close();
        }
    }
}
