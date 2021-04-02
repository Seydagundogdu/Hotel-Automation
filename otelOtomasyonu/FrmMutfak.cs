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
    public partial class FrmMutfak : Form
    {
        public FrmMutfak()
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

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime tarih = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            csMutfak mutfak = new csMutfak();
            if(rdbMutfakUrun.Checked == true)
            {
                mutfak.urunEkle("Mutfak", txtUrun.Text, cmbKategori.Text, txtAdet.Text, txtFiyat.Text, txtFirma.Text, tarih);
                dgVeriler.DataSource = mutfak.mutfakUrunlari_Listele();
            }
            if(rdbOdaUrun.Checked == true)
            {
                mutfak.urunEkle("Oda", txtUrun.Text, cmbKategori.Text, txtAdet.Text, txtFiyat.Text, txtFirma.Text, tarih);
                dgVeriler.DataSource = mutfak.odaUrunlari_Listele();
            }

        }

        private void rdbOdaUrun_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbOdaUrun.Checked == true)
            {
                csMutfak mutfak = new csMutfak();
                dgVeriler.DataSource = mutfak.odaUrunlari_Listele();
                mutfak.mutfakmi = "";
                mutfak.odami = "Oda";
                cmbKategori.Items.Clear();
                mutfak.kategoriAl(); //combobox içerisine listeler
                for (int i = 0; i < mutfak.kategoriler.Count; i++)
                {
                    cmbKategori.Items.Add(mutfak.kategoriler[i].ToString());
                }
 
            }
        }

        private void rdbMutfakUrun_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMutfakUrun.Checked == true)
            {
                csMutfak mutfak = new csMutfak();
                dgVeriler.DataSource = mutfak.mutfakUrunlari_Listele();
                mutfak.mutfakmi = "Mutfak";
                mutfak.odami = "";
                cmbKategori.Items.Clear();
                mutfak.kategoriAl(); //combobox içerisine listeler
                for(int i=0; i<mutfak.kategoriler.Count; i++)
                {
                    cmbKategori.Items.Add(mutfak.kategoriler[i].ToString());
                }

            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            csMutfak mutfak = new csMutfak();
            if (rdbMutfakUrun.Checked == true)
            {
                dgVeriler.DataSource = mutfak.mutfakUrunlari_Listele();
            }
            if(rdbOdaUrun.Checked == true)
            {
                dgVeriler.DataSource = mutfak.odaUrunlari_Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DateTime tarih = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            int id = Convert.ToInt16(lblid.Text);
            csMutfak mutfak = new csMutfak();
            if(rdbMutfakUrun.Checked == true)
            {
                mutfak.urunGuncelle("Mutfak",id, txtUrun.Text, cmbKategori.Text, txtAdet.Text, txtFiyat.Text, txtFirma.Text, tarih);
                dgVeriler.DataSource = mutfak.mutfakUrunlari_Listele();
            }
            if(rdbOdaUrun.Checked == true)
            {
                mutfak.urunGuncelle("Oda", id, txtUrun.Text, cmbKategori.Text, txtAdet.Text, txtFiyat.Text, txtFirma.Text, tarih);
                dgVeriler.DataSource = mutfak.odaUrunlari_Listele();
            }
        }

        private void dgVeriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = dgVeriler.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtUrun.Text = dgVeriler.Rows[e.RowIndex].Cells["urunAdi"].Value.ToString();
            cmbKategori.Text = dgVeriler.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
            txtAdet.Text = dgVeriler.Rows[e.RowIndex].Cells["adet"].Value.ToString();
            txtFiyat.Text = dgVeriler.Rows[e.RowIndex].Cells["fiyat"].Value.ToString();
            txtFirma.Text = dgVeriler.Rows[e.RowIndex].Cells["firma"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgVeriler.Rows[e.RowIndex].Cells["gelisTarihi"].Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(lblid.Text);
            csMutfak mutfak = new csMutfak();
            if(rdbMutfakUrun.Checked == true)
            {
                mutfak.urunSil("Mutfak",id);
                dgVeriler.DataSource = mutfak.mutfakUrunlari_Listele();
            }
            if(rdbOdaUrun.Checked == true)
            {
                mutfak.urunSil("Oda", id);
                dgVeriler.DataSource = mutfak.odaUrunlari_Listele();
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrun.Text = "";
            cmbKategori.Text = "";
            txtAdet.Text = "";
            txtFiyat.Text = "";
            txtFirma.Text = "";
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            csMutfak mutfak = new csMutfak();
            if(rdbMutfakUrun.Checked == true)
            {
                dgVeriler.DataSource = mutfak.veriGetirMutfak(txtAra.Text);
            }
            if(rdbOdaUrun.Checked == true)
            {
                dgVeriler.DataSource = mutfak.veriGetirOda(txtAra.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
