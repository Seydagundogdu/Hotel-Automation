/*seyda*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace otelOtomasyonu
{
    public partial class FrmMusteriKayıt : Form
    {
        public FrmMusteriKayıt()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m) //pencereyi mousela hareket ettirebilmek için yazılan kod bloğu
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        ArrayList odalar = new ArrayList();
        void koltukYazdir() //seçili odanın textini odaNo texboxına yazdırır
        {
            string oda = "";
            for (int i = 0; i < odalar.Count; i++)
            {
                oda = oda + odalar[i].ToString() +",";
            }
            if (odalar.Count >= 1)
            {
                oda = oda.Remove(oda.Length - 1, 1);
            }
            txtOdaNo.Text = oda;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.Add("Kadın");

            cmbCinsiyet.Items.Add("Erkek");

            tmrKontrol.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void odaClick(object sender, EventArgs e)
        {
            if(((Button)sender).BackColor == Color.AntiqueWhite)
            {
                ((Button)sender).BackColor = Color.DarkKhaki;
                if(!odalar.Contains(((Button)sender).Text)) //tıklanan butonun texti odalar listesinin içerisinde yoksa
                {
                    odalar.Add(((Button)sender).Text);
                }
                koltukYazdir();
            }
            else if(((Button)sender).BackColor == Color.DarkKhaki)
            {
                ((Button)sender).BackColor = Color.AntiqueWhite;
                if (odalar.Contains(((Button)sender).Text))
                {
                    odalar.Remove(((Button)sender).Text);
                }
                koltukYazdir();
            }
        }
        public DateTime girisTarihi { get; set; }
        public DateTime cikisTarihi { get; set; }
        private void btnOdaVer_Click(object sender, EventArgs e)
        {
            girisTarihi = Convert.ToDateTime(dateTimeGiris.Value); //datetime değerlerini textboxlardan alıp datetime türüne çeviriyor
            cikisTarihi = Convert.ToDateTime(dateTimeCikis.Value);
            MusteriKayit kayit = new MusteriKayit();
            for (int i = 0; i < odalar.Count; i++)
            {
                string oda = odalar[i].ToString();
                kayit.kayitAl(txtAdi.Text, txtSoyadi.Text, cmbCinsiyet.Text, txtTel.Text, txtMail.Text, txtTckn.Text, oda, txtUcret.Text, girisTarihi, cikisTarihi);
            }
            tmrKontrol.Start();
        }

        private void tmrKontrol_Tick(object sender, EventArgs e) //odanın dolu veya boş olduğunu tmr ile kontrol ettiriyorum
        {
            DataBase db = new DataBase();
            if(db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand donustur = new SqlCommand("select * from odalar where durumu=@durum",db.baglanti);
                donustur.Parameters.AddWithValue("@durum", "Dolu");
                SqlDataReader donustur_oku = donustur.ExecuteReader();
                while(donustur_oku.Read())
                {
                    string butonAdi = donustur_oku["butonAdi"].ToString();
                    string durumu = donustur_oku["durumu"].ToString();
                    if(butonAdi =="oda1" && durumu == "Dolu")
                    {
                        oda1.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda2" && durumu == "Dolu")
                    {
                        oda2.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda3" && durumu == "Dolu")
                    {
                        oda3.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda4" && durumu == "Dolu")
                    {
                        oda4.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda5" && durumu == "Dolu")
                    {
                        oda5.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda6" && durumu == "Dolu")
                    {
                        oda6.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda7" && durumu == "Dolu")
                    {
                        oda7.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda8" && durumu == "Dolu")
                    {
                        oda8.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda9" && durumu == "Dolu")
                    {
                        oda9.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda10" && durumu == "Dolu")
                    {
                        oda10.BackColor = Color.Maroon;
                    }
                    if(butonAdi == "oda11" && durumu == "Dolu")
                    {
                        oda11.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda12" && durumu == "Dolu")
                    {
                        oda12.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda13" && durumu == "Dolu")
                    {
                        oda13.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda14" && durumu == "Dolu")
                    {
                        oda14.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda15" && durumu == "Dolu")
                    {
                        oda16.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda16" && durumu == "Dolu")
                    {
                        oda16.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda17" && durumu == "Dolu")
                    {
                        oda17.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda18" && durumu == "Dolu")
                    {
                        oda18.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda19" && durumu == "Dolu")
                    {
                        oda19.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda20" && durumu == "Dolu")
                    {
                        oda20.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda21" && durumu == "Dolu")
                    {
                        oda21.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "22" && durumu == "Dolu")
                    {
                        oda22.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda23" && durumu == "Dolu")
                    {
                        oda23.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda24" && durumu == "Dolu")
                    {
                        oda24.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda25" && durumu == "Dolu")
                    {
                        oda25.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda26" && durumu == "Dolu")
                    {
                        oda26.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda27" && durumu == "Dolu")
                    {
                        oda27.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda28" && durumu == "Dolu")
                    {
                        oda28.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda29" && durumu == "Dolu")
                    {
                        oda29.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda30" && durumu == "Dolu")
                    {
                        oda30.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda31" && durumu == "Dolu")
                    {
                        oda31.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda32" && durumu == "Dolu")
                    {
                        oda32.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda33" && durumu == "Dolu")
                    {
                        oda33.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda34" && durumu == "Dolu")
                    {
                        oda34.BackColor = Color.Maroon;
                    }
                    if (butonAdi == "oda35" && durumu == "Dolu")
                    {
                        oda35.BackColor = Color.Maroon;
                    }
                }
                donustur.Dispose();
                donustur_oku.Close();
                db.baglanti.Close();
                tmrKontrol.Stop();
            }
            catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }
            finally
            {
                db.baglanti.Close();
            }
        }

        private void oda4_Click(object sender, EventArgs e)
        {

        }

        private void oda14_Click(object sender, EventArgs e)
        {

        }

        private void oda10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
            
            
