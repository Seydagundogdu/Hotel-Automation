
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // sql veri tabanı kütüphanesi

namespace otelOtomasyonu
{
    class MusteriKayit
    {
        public string adi_soyadi { get; set; }
        DataBase db = new DataBase();
        /*müşteri bilgilerinin odalar isimli tabloya ve ilgili oda sayısınına aktarabilmek için oluşturduğum metot*/
        public static void odaGuncelle(string oda, string adSoyad)   
        { 
            DataBase db = new DataBase();
            if(db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                /*odalardaki müşteri bilgilerini günceller*/
                SqlCommand guncelle = new SqlCommand("update odalar set musteriAdi=@alanKisi, durumu=@durum where odaNo=@odaNo ", db.baglanti);
                guncelle.Parameters.AddWithValue("@alanKisi",adSoyad);
                guncelle.Parameters.AddWithValue("@durum", "Dolu");
                guncelle.Parameters.AddWithValue("@odaNo", oda);
                guncelle.ExecuteNonQuery(); //mesaj verdirmeden güncelleme sağlanır
                guncelle.Dispose();
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); } //burada bir hatayla karşılaştığım için bu bloğu yazdım
            finally
            {
                db.baglanti.Close();
            }
        }
        public void kayitAl(string adi, string soyadi, string cinsiyet, string telNo, string mail, string tckn, string odaNo, string ucret, DateTime giris, DateTime cikis)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand kayit_Al = new SqlCommand("insert into musteriBilgileri values(@adi, @soyadi, @cinsiyet, @telefon, @mail, @tc, @oda, @ucret, @giris, @cikis)", db.baglanti);
                kayit_Al.Parameters.AddWithValue("@adi",adi); // textboxlara alacağım değerlerin veri tabanında hangi tabloya kaydedileceğini gösteriyorum
                kayit_Al.Parameters.AddWithValue("@soyadi",soyadi);
                kayit_Al.Parameters.AddWithValue("@cinsiyet",cinsiyet);
                kayit_Al.Parameters.AddWithValue("@telefon",telNo);
                kayit_Al.Parameters.AddWithValue("@mail",mail);
                kayit_Al.Parameters.AddWithValue("@tc",tckn);
                kayit_Al.Parameters.AddWithValue("@oda",odaNo);
                kayit_Al.Parameters.AddWithValue("@ucret",ucret);
                kayit_Al.Parameters.AddWithValue("@giris",giris);
                kayit_Al.Parameters.AddWithValue("@cikis",cikis);
                kayit_Al.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Müşteri kaydı yapıldı.","", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                kayit_Al.Dispose();
                ////////////////////////////////////////////////////////////////////////////////////////////
                adi_soyadi = adi + " " + soyadi;
                odaGuncelle(odaNo, adi_soyadi);
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
            finally
            {
                db.baglanti.Close();
            }

        }
    }
}
