/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:2 (Proje)
** ÖĞRENCİ ADI............:Şeyda Gündoğdu
** ÖĞRENCİ NUMARASI.......:B181200376
** DERSİN ALINDIĞI GRUP...:A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otelOtomasyonu
{
    class Giris
    {
        DataBase db = new DataBase(); //DataBase sınıfından db isimli nesne oluştururuz
        public string kullaniciAdi_Tut { get; set; }
        public string kullaniciSifre_Tut { get; set; }
        public string girisDurumu { get; set;}
       
        public void girisYap(string kullaniciAdi, string kullaniciSifre, DateTime tarih)
        {
            if (db.baglanti.State==System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try //programın hata vermemesi için yazılan try-catch blokları
            {
                db.baglanti.Open();
                SqlCommand login = new SqlCommand("select kullaniciAdi from kullaniciBilgileri where kullaniciAdi = @kulAdi", db.baglanti );
                login.Parameters.AddWithValue("@kulAdi", kullaniciAdi); //kullanıcı adını parametre olarak aldırdım
                SqlDataReader kulAdi_Oku = login.ExecuteReader();
                if(kulAdi_Oku.Read())
                {
                    kullaniciAdi_Tut = kulAdi_Oku["kullaniciAdi"].ToString();
                    SqlCommand loginPw = new SqlCommand("select kullaniciSifre from kullaniciBilgileri where kullaniciSifre = @sifre", db.baglanti);
                    loginPw.Parameters.AddWithValue("@sifre", kullaniciSifre); //kullanıcı şifresini parametre olarak aldırıdım
                    SqlDataReader loginPw_Oku = loginPw.ExecuteReader();
                    if(loginPw_Oku.Read())
                    {
                        kullaniciSifre_Tut = loginPw_Oku["kullaniciSifre"].ToString();
                        girisDurumu = kullaniciAdi_Tut + " " + kullaniciSifre_Tut;
                        SqlCommand dateUpdate = new SqlCommand("update kullaniciBilgileri set girisTarihi=@tarih where kullaniciAdi = @kulAdi AND kullaniciSifre = @sifre", db.baglanti); //giriş tarihini sürekli güncellemesi için
                        dateUpdate.Parameters.AddWithValue("@tarih", tarih);
                        dateUpdate.Parameters.AddWithValue("@kulAdi", kullaniciAdi_Tut);
                        dateUpdate.Parameters.AddWithValue("@sifre", kullaniciSifre_Tut);
                        dateUpdate.ExecuteNonQuery();
                        dateUpdate.Dispose(); //ramden kaldırıyoruz
                    }
                    else
                    {
                        MessageBox.Show("Şifreyi yanlış girdiniz.", "HATA | Diana Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    loginPw.Dispose();//ramden kaldırıyoruz
                    loginPw_Oku.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını yanlış girdiniz.", "HATA | Diana Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                login.Dispose();//ramden kaldırıyoruz
                kulAdi_Oku.Close();
                db.baglanti.Close();
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }

        }
    }
}
