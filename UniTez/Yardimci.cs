using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace UniTez
{
    class Yardimci
    {
       public static SqlConnection Baglanti()
       {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3FC9AN5;Initial Catalog=UniTez;Integrated Security=True");
            return baglanti;
       }
       public static bool EklemeIslemi(string sorgu, string[] Parametreler, string[] Degerler)
        {
            bool sonuc = false;
            SqlConnection baglanti = Baglanti();
            SqlCommand Komut = new SqlCommand();
            Komut.Connection = baglanti;
            Komut.CommandType = CommandType.StoredProcedure;
            Komut.CommandText = sorgu;

            for (int i = 0; i < Parametreler.Length; i++)
            {
                Komut.Parameters.AddWithValue(Parametreler[i].ToString(), Degerler[i].ToString());
            }
            try
            {
                baglanti.Open();
                Komut.ExecuteNonQuery();
                baglanti.Close();
                sonuc = true;
            }
            catch (Exception)
            {
                sonuc = false;
            }
            return sonuc;
        }

       public static DataTable VeriOku(string sorgu)
       {
            DataTable dt = new DataTable();
            SqlConnection baglanti = Baglanti();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            try
            {
                baglanti.Open();
                sda.Fill(dt);
                baglanti.Close();
            }
            catch (Exception)
            {
                dt = null;
            }
            return dt;
       }

        public class KullaniciBilgisi
        {
            public static string Mail { get; set; }
        }
        internal static void ComboboxDoldur(ComboBox cbdolacak, string sorgu, string valuemember, string displaymember)
        {
            // 1- Bağlantı sağla
            SqlConnection baglanti = Baglanti();
            // 2- Gelecek sorguyu çalıştıracak Sql command olustur 
            SqlCommand komut = new SqlCommand(sorgu);
            // 3- Command ile Connection ilişkilendir
            komut.Connection = baglanti;
            // 4- Sql e komutu tanıtacak DataAdaptor Olustur
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            // 5- DataTable Oluştur
            DataTable dt = new DataTable();
            // 6- Sql den gelen verileri tabloya yaz
            adap.Fill(dt);
            // 7- Tabloya Veri Gelmiş ise ...
            if (dt.Rows.Count > 0)
            {
                // 7a - Metoda gelen combobox için
                // veri kaynağı göster
                cbdolacak.DataSource = dt;
                // 7b - cb için Seçilen değeri belirle
                cbdolacak.ValueMember = valuemember;
                // 7c - cb için gösterilecek veriyi belirle
                cbdolacak.DisplayMember = displaymember;
                cbdolacak.SelectedIndex = -1;
                cbdolacak.Text = "Seçiniz...";
               

            }
        }
    }
}
