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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelOtomasyonu
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m) //pencereyi mausela hareket ettirebilmek için yazılan kod bloğu
        {
            switch(m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if((int)m.Result == 0x1)
                    {
                        m.Result = (IntPtr)0x2;
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Diana_Load(object sender, EventArgs e)
        {
           
        }

        private void giris_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            AnaEkran anaEkran = new AnaEkran();
            if(txtKullanici.Text == string.Empty || txtSifre.Text == string.Empty)
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreyi giriniz.", "HATA | Diana Otel Otomasyonu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                grs.girisYap(txtKullanici.Text, txtSifre.Text, DateTime.Now);
                string bilgiTut = txtKullanici.Text + " " + txtSifre.Text.ToString();
                if(grs.girisDurumu == bilgiTut)
                {
                    anaEkran.Show();
                    this.Hide(); //FrmGiris kapanır
                    
                }

            }
        }

       
    }
}
