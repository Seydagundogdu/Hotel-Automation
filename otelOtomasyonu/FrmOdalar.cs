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

namespace otelOtomasyonu
{
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
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
        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            string odaNo = "";
            string yeniDeger = "";
            //bool oldumu = false;
            for (int i = 0; i < this.Controls.Count + 1; i++)
            {
                odaNo = Convert.ToString(this.Controls.Find("oda" + i.ToString(), true).FirstOrDefault() as Button);
                yeniDeger = odaNo.Split(':').Last();
                odalar.Add(yeniDeger);
            }
                odalarinDurumu();
        }
            void odalarinDurumu()
            {
                string yeniOda = "";
                csOdalar oda = new csOdalar();
                try
                {
                    foreach (string odaninAdi in odalar)
                    {
                        oda.odaDegerleri(odaninAdi, "Dolu");
                        //MessageBox.Show("okudum3");
                        if (oda.durum_oku == "Dolu")
                        {
                            yeniOda = odaninAdi;
                            //MessageBox.Show("okudum2");
                            this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.Maroon;
                            this.Controls.Find(oda.butonAdi, true)[0].Text = yeniOda + "\n" + oda.alanKisi; // ODA 1 ŞEYDA GÜNDOĞDU
                            oda.durum_oku = "";
                        }
                        if (oda.durum_oku == "Boş")
                        {
                            this.Controls.Find(oda.butonAdi, true)[0].BackColor = Color.AntiqueWhite;
                            this.Controls.Find(oda.butonAdi, true)[0].Text = oda.alanKisi + "\n";
                        }
                    }
                }
                catch (Exception hata) { System.Windows.Forms.MessageBox.Show("" + hata); }


            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
