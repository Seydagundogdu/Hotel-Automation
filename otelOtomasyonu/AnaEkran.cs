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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m) //pencereyi mousela hareket ettirebilmek için yazılan kod bloğu (burada override ettiğimiz şey sanırım pencerenin sabit kalmasını sağlayan metot)
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

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            FrmMusteriKayıt kayitEkranı = new FrmMusteriKayıt();
            kayitEkranı.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOdalar odaDurumEkranı = new FrmOdalar();
            odaDurumEkranı.Show();
        }

        private void btnBilgiler_Click(object sender, EventArgs e)
        {
            MusteriEkrani bilgiler = new MusteriEkrani();
            bilgiler.Show();
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            FrmMutfak mutfak = new FrmMutfak();
            mutfak.Show();
        }
    }
}
