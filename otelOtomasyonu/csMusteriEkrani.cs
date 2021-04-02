using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace otelOtomasyonu
{
    class csMusteriEkrani
    {
        DataBase db = new DataBase();
        public string durumGuncelle { get; set; }
        public string durumSil { get; set; }
        public DataTable tablola() // dataGrid için geriye değer döndürecek fonksiyon 
        {
            if(db.baglanti.State == ConnectionState.Open) //bağlantının açık kalmaması için tedbir olarak yazılan satırlar
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand veriAl = new SqlCommand("select * from musteriBilgileri", db.baglanti); //musterBilgileri tablosunun bütün verilerini bana ver
                SqlDataAdapter adaptor = new SqlDataAdapter(veriAl); // verileri adaptor nesnesi içinde saklar
                DataTable tablo = new DataTable(); // verileri eşleyerek (düzenli olarak) saklar
                adaptor.Fill(tablo); // verileri adaptorden al
                return tablo; // verileri geriye döndür
            }
            catch { return null; } // hata durumunda geriye döndürülecek değer null
            finally
            {
                db.baglanti.Close();
            }
        }
        /* id'ye göre bilgileri güncelleme işlemi*/
        public void MusteriGuncelle(int id, string adi, string soyadi, string cinsiyet, string telNo, string mail, string tckn, string odaNo, string ucret, DateTime giris, DateTime cikis)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update musteriBilgileri set adi=@adi, soyadi=@soyadi, cinsiyet=@cinsiyet, telefon=@telefon, mail=@mail, tckn=@tc, odaNo=@oda, ucret=@ucret, girisTarihi=@tarih1, cikisTarihi=@tarih2 where id=@id", db.baglanti);
                guncelle.Parameters.AddWithValue("@adi", adi);
                guncelle.Parameters.AddWithValue("@soyadi", soyadi);
                guncelle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                guncelle.Parameters.AddWithValue("@telefon", telNo);
                guncelle.Parameters.AddWithValue("@mail", mail);
                guncelle.Parameters.AddWithValue("@tc", tckn);
                guncelle.Parameters.AddWithValue("@oda", odaNo);
                guncelle.Parameters.AddWithValue("@ucret", ucret);
                guncelle.Parameters.AddWithValue("@tarih1", giris);
                guncelle.Parameters.AddWithValue("@tarih2", cikis);
                guncelle.Parameters.AddWithValue("@id", id);
                guncelle.ExecuteNonQuery(); //yukarıdaki sqlCommand içerisindeki cümleri işler
                durumGuncelle = adi + " " + soyadi + " isimli kişinin verileri güncellenmiştir.";
                
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        /* id'ye göre verileri silme işlemi*/
        public void MusteriSil(int id)
        {
            if(db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand sil = new SqlCommand("delete musteriBilgileri where id=@id", db.baglanti); // musteriBilgileri tablosundan belirtilen id ile gelen kişinin bilgilerini sil.
                sil.Parameters.AddWithValue("@id", id);
                sil.ExecuteNonQuery();
                durumSil = "Silme işlemi başarılı.";
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        /* texbox ile ada göre veri aramak işlemi*/
        public DataTable MusteriAra(string adi) // tabloda geriye veri döndürebilmesi için void değil DataTable olarak tanımladım
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand arama = new SqlCommand("select * from musteriBilgileri where adi LIKE '%'+@adi+'%' ", db.baglanti); //  tüm verileri musteriBilgileri tablosundan al; koşul, adı sütununda ki içerisindeki herhangi bir kelime
                arama.Parameters.AddWithValue("@adi", adi);
                SqlDataAdapter adaptor = new SqlDataAdapter(arama);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;// adaptor içerinde tabloyu oluştur ve geriye tabloyu gönder
                // like içerisinde '%'+@adi+'%' ifadesi geçen veri
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
    }
}
