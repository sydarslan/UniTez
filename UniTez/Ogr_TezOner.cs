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
    public partial class Ogr_TezOner : Form
    {
        public Ogr_TezOner()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");
        private void Ogr_TezOner_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select Id,bolumid From Kullanici WHERE Mail=@mail";
            SqlCommand comand = new SqlCommand(sorgu, baglanti);
            comand.Parameters.AddWithValue("@mail", Yardimci.KullaniciBilgisi.Mail);
            SqlDataAdapter da = new SqlDataAdapter(comand);
            SqlDataReader dr = comand.ExecuteReader();
            if (dr.Read())
            {
                labeloggrid.Text = dr["Id"].ToString();
                labelbolum.Text = dr["bolumid"].ToString();
                dr.Close();
            }
            baglanti.Close();

            birimgetir();
            tezdilgetir();
            tezturugetir();
            danismangetir();
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


            //DataTable diltablosu = Yardimci.VeriOku(dilgetir);
            //cbdil.ValueMember = "Id";
            //cbdil.DisplayMember = "DilAdi";
            //cbdil.DataSource = diltablosu;
            //cbdil.Text = "Seçiniz...";
        }
        private void tezturugetir()
        {
            string turgetir = "Select * FROM  TezTuru";
            Yardimci.ComboboxDoldur(cmtur, turgetir, "Id", "TurAdi");
        }
        private  void danismangetir()
        {
            string turgetir = "Select * FROM  Kullanici where rolid=1 and bolumid="+ labelbolum.Text;
            Yardimci.ComboboxDoldur(cbdanisman, turgetir, "Id", "Mail");
        }
        private void TextBos()
        {
            Txttezadi.Text = "";
            txtozet.Text = "";
            txtanahtar.Text = "";
            cbbirim.SelectedIndex = -1;
            cbprogram.SelectedIndex = -1;
            cmbolum.SelectedIndex = -1;
            cmtur.SelectedIndex = -1;
            cbdil.SelectedIndex = -1;
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

        private void BtnTezOner_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string today = DateTime.Now.ToString("yyyy/MM/dd");
            string[] Param = { "@TezAdi", "@Ozet", "@AnahtarKelime", "@OlusturulmaTarihi", "@birimid", "@programid", "@bolumid", "@ogrenci", "@danismanid", "@dil", "@tur", "@durum" };
            string[] Deger = { Txttezadi.Text, txtozet.Text, txtanahtar.Text, today, cbbirim.SelectedValue.ToString(), cbprogram.SelectedValue.ToString(), cmbolum.SelectedValue.ToString(), labeloggrid.Text,cbdanisman.SelectedValue.ToString(), cbdil.SelectedValue.ToString(), cmtur.SelectedValue.ToString(), "6" };
            SqlCommand komut = new SqlCommand("select * from TezOneri WHERE TezAdi='" + Txttezadi.Text + "' and bolumid='" + cmbolum.SelectedValue.ToString() + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Tekrarlı kayıt yapılmaz...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool mesaj = Yardimci.EklemeIslemi("spTezOner", Param, Deger);
                if (mesaj)
                {
                    MessageBox.Show("Tez Öneri Başarıyla Oluşturuldu...");
                    TextBos();
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
