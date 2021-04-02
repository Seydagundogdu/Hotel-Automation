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
    public partial class MusteriEkrani : Form
    {
        public MusteriEkrani()
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // tabloda bir nesneye click yapıldığınca yapılacak işlem
        {
            lblID.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value); //gelen id'yi labelın textine attık cellClick yaptığımızda id kolonundaki değeri döndürür
            txtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["adi"].Value.ToString();// seçilmiş satırın indeksini buraya yaz gelen verilerden adı kolonunun değerini al stringe çevir
            txtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells["soyadi"].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[e.RowIndex].Cells["cinsiyet"].Value.ToString();
            txtOdaNo.Text = dataGridView1.Rows[e.RowIndex].Cells["odaNo"].Value.ToString();
            txtTel.Text = dataGridView1.Rows[e.RowIndex].Cells["telefon"].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells["mail"].Value.ToString();
            txtTckn.Text = dataGridView1.Rows[e.RowIndex].Cells["tckn"].Value.ToString();
            txtUcret.Text = dataGridView1.Rows[e.RowIndex].Cells["ucret"].Value.ToString();
            dateTimeGiris.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["girisTarihi"].Value);
            dateTimeCikis.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["cikisTarihi"].Value);

        }

        private void MusteriEkrani_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.Add("Kadın");

            cmbCinsiyet.Items.Add("Erkek");

            csMusteriEkrani me = new csMusteriEkrani();
            dataGridView1.DataSource = me.tablola();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBilgi_Click(object sender, EventArgs e) //müşteri görüntüleme 
        {
            csMusteriEkrani me = new csMusteriEkrani(); // csMusteriEkrann sınıfından bi nesne oluşturup
            dataGridView1.DataSource = me.tablola(); // bu nesne ile tablola metoduna ulaştım
        }

        private void btnTemizle_Click(object sender, EventArgs e) // form temizleme
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            cmbCinsiyet.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            txtTckn.Text = "";
            txtOdaNo.Text = "";
            txtUcret.Text = "";
            dateTimeGiris.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString()); // şuanın tarihini verir
            dateTimeCikis.Value = Convert.ToDateTime(DateTime.Now.ToLongDateString());
        }
           
        private void btnGuncelle_Click(object sender, EventArgs e)
        { 
            DateTime girisTarihi = Convert.ToDateTime(dateTimeGiris.Value); //datetime değerlerini textboxlardan alıp datetime türüne çeviriyor
            DateTime cikisTarihi = Convert.ToDateTime(dateTimeCikis.Value);
            int id = Convert.ToInt16(lblID.Text);
            csMusteriEkrani me = new csMusteriEkrani();
            me.MusteriGuncelle(id, txtAdi.Text, txtSoyadi.Text, cmbCinsiyet.Text, txtTel.Text, txtMail.Text, txtTckn.Text, txtOdaNo.Text, txtUcret.Text, girisTarihi, cikisTarihi);
            dataGridView1.DataSource = me.tablola(); // işlemler tamamlanınca verileri tabloya işler
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(lblID.Text);
            csMusteriEkrani me = new csMusteriEkrani();
            me.MusteriSil(id);
            dataGridView1.DataSource = me.tablola();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            csMusteriEkrani me = new csMusteriEkrani();
            dataGridView1.DataSource = me.MusteriAra(txtAra.Text);
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
