using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace otelOtomasyonu
{
    class csMutfak
    {
        public string mutfakmi = "";
        public string odami = "";
        public ArrayList kategoriler = new ArrayList();
        DataBase db = new DataBase();
        public void urunEkle(string durum, string urunAdi, string kategori, string adet, string fiyat, string firma, DateTime gelisTarihi)
        {
            if(db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                if (durum == "Mutfak")
                {
                    SqlCommand ekle = new SqlCommand("insert into mutfak values(@urunAdi, @kategori, @adet, @fiyat, @firma, @gelisTarihi)", db.baglanti);
                    ekle.Parameters.AddWithValue("@urunAdi", urunAdi);
                    ekle.Parameters.AddWithValue("@kategori", kategori);
                    ekle.Parameters.AddWithValue("@adet", adet);
                    ekle.Parameters.AddWithValue("@fiyat", fiyat);
                    ekle.Parameters.AddWithValue("@firma", firma);
                    ekle.Parameters.AddWithValue("@gelisTarihi", gelisTarihi);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Ürün ekleme işlemi başarılı.", "Bilgi", System.Windows.Forms.MessageBoxButtons.OK);
                }
                if (durum == "Oda")
                {
                    SqlCommand ekle = new SqlCommand("insert into oda values(@urunAdi, @kategori, @adet, @fiyat, @firma, @gelisTarihi)", db.baglanti);
                    ekle.Parameters.AddWithValue("@urunAdi", urunAdi);
                    ekle.Parameters.AddWithValue("@kategori", kategori);
                    ekle.Parameters.AddWithValue("@adet", adet);
                    ekle.Parameters.AddWithValue("@fiyat", fiyat);
                    ekle.Parameters.AddWithValue("@firma", firma);
                    ekle.Parameters.AddWithValue("@gelisTarihi", gelisTarihi);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("Ürün ekleme işlemi başarılı.", "Bilgi", System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }

        }
        public DataTable mutfakUrunlari_Listele()
        {
            if(db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand mutfakAl = new SqlCommand("select * from mutfak", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(mutfakAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable odaUrunlari_Listele()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand odaAl = new SqlCommand("select * from oda", db.baglanti);
                SqlDataAdapter adaptor = new SqlDataAdapter(odaAl);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
        /*btablodaki ürünleri güncelleyen metot*/
        public void urunGuncelle(string durum, int id,string urunAdi, string kategori, string adet, string fiyat, string firma, DateTime gelisTarihi)
        {
            if ( db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                if (durum == "Mutfak")
                {
                    SqlCommand guncelle = new SqlCommand("update mutfak set urunAdi=@adi, kategori=@kategori, adet=@adet, fiyat=@fiyat, firma=@firma, gelisTarihi=@tarih where id=@id", db.baglanti);
                    guncelle.Parameters.AddWithValue("@adi", urunAdi);
                    guncelle.Parameters.AddWithValue("@kategori", kategori);
                    guncelle.Parameters.AddWithValue("@adet",adet);
                    guncelle.Parameters.AddWithValue("@fiyat",fiyat);
                    guncelle.Parameters.AddWithValue("@firma",firma);
                    guncelle.Parameters.AddWithValue("@tarih",gelisTarihi);
                    guncelle.Parameters.AddWithValue("@id",id);
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Mutfak ürünü güncelleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK);
                    guncelle.Dispose();
                }
                if(durum == "Oda")
                {
                    SqlCommand guncelle = new SqlCommand("update oda set urunAdi=@adi, kategori=@kategori, adet=@adet, fiyat=@fiyat, firma=@firma, gelisTarihi=@tarih where id=@id", db.baglanti);
                    guncelle.Parameters.AddWithValue("@adi", urunAdi);
                    guncelle.Parameters.AddWithValue("@kategori", kategori);
                    guncelle.Parameters.AddWithValue("@adet", adet);
                    guncelle.Parameters.AddWithValue("@fiyat", fiyat);
                    guncelle.Parameters.AddWithValue("@firma", firma);
                    guncelle.Parameters.AddWithValue("@tarih", gelisTarihi);
                    guncelle.Parameters.AddWithValue("@id", id);
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Oda ürünü güncelleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK);
                    guncelle.Dispose();
                }
                
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        public void urunSil(string durum, int id)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                if (durum == "Mutfak")
                {
                    SqlCommand guncelle = new SqlCommand("delete mutfak where id=@id", db.baglanti);
                  
                    guncelle.Parameters.AddWithValue("@id", id);
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Mutfak ürünü silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK);
                    guncelle.Dispose();
                }
                if (durum == "Oda")
                {
                    SqlCommand guncelle = new SqlCommand("delete oda where id=@id", db.baglanti);
                    
                    guncelle.Parameters.AddWithValue("@id", id);
                    guncelle.ExecuteNonQuery();
                    MessageBox.Show("Oda ürünü silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK);
                    guncelle.Dispose();
                }

            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        public void kategoriAl()
        {
            if(db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                if(mutfakmi == "Mutfak")
                {
                    kategoriler.Clear();
                    SqlCommand mutfakKategori = new SqlCommand("select * from mutfakKategoriler",db.baglanti);
                    SqlDataReader oku = mutfakKategori.ExecuteReader();
                    while(oku.Read())
                    {
                        string kategori = oku["kategoriAdi"].ToString();
                        kategoriler.Add(kategori);
                    }
                    oku.Close();
                    mutfakKategori.Dispose();
                }
                if (odami == "Oda")
                {
                    kategoriler.Clear();
                    SqlCommand mutfakKategori = new SqlCommand("select * from odaKategoriler", db.baglanti);
                    SqlDataReader oku = mutfakKategori.ExecuteReader();
                    while (oku.Read())
                    {
                        string kategori = oku["kategoriAdi"].ToString();
                        kategoriler.Add(kategori);
                    }
                    oku.Close();
                    mutfakKategori.Dispose();
                }
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable veriGetirMutfak(string urunAdi)
        {
            if(db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from mutfak where urunAdi LIKE '%'+@adi+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@adi", urunAdi);
                SqlDataAdapter adaptor = new SqlDataAdapter(getir);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
        public DataTable veriGetirOda(string urunAdi)
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand getir = new SqlCommand("select * from oda where urunAdi  LIKE '%'+@adi+'%'", db.baglanti);
                getir.Parameters.AddWithValue("@adi", urunAdi);
                SqlDataAdapter adaptor = new SqlDataAdapter(getir);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
            catch { return null; }
            finally
            {
                db.baglanti.Close();
            }
        }
    
    }
}
