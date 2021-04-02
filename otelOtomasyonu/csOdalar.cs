using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace otelOtomasyonu
{
    class csOdalar
    {
        public string alanKisi { get; set; }
        public string durum_oku { get; set; }
        public string butonAdi { get; set; }
        DataBase db = new DataBase();
        public void odaDegerleri(string odaNo, string durum)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand odaAl = new SqlCommand("select * from odalar where odaNo = @odaNo AND durumu = @durum", db.baglanti);
                odaAl.Parameters.AddWithValue("@odaNo", odaNo);
                odaAl.Parameters.AddWithValue("@durum", durum);
                SqlDataReader odaAl_Oku = odaAl.ExecuteReader();
                if(odaAl_Oku.Read())
                {
                    //System.Windows.Forms.MessageBox.Show("okudum");
                    alanKisi = odaAl_Oku["musteriAdi"].ToString();
                    durum_oku = odaAl_Oku["durumu"].ToString();
                    butonAdi = odaAl_Oku["butonAdi"].ToString();
                }
                odaAl.Dispose();
                odaAl_Oku.Close();
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
            finally 
            {
                db.baglanti.Close();

            }
        }
    }
}
