namespace otelOtomasyonu
{
    partial class FrmMutfak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.rdbOdaUrun = new System.Windows.Forms.RadioButton();
            this.rdbMutfakUrun = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dgVeriler = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::otelOtomasyonu.Properties.Resources._5c23f16a183bf559f1aa50f75a9d03f4;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(644, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(106, 73);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(142, 20);
            this.txtUrun.TabIndex = 8;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(106, 160);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(49, 20);
            this.txtAdet.TabIndex = 9;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(360, 70);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(49, 20);
            this.txtFiyat.TabIndex = 10;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(360, 113);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(150, 20);
            this.txtFirma.TabIndex = 11;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(106, 114);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(142, 21);
            this.cmbKategori.TabIndex = 12;
            // 
            // rdbOdaUrun
            // 
            this.rdbOdaUrun.AutoSize = true;
            this.rdbOdaUrun.BackColor = System.Drawing.Color.Transparent;
            this.rdbOdaUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbOdaUrun.Location = new System.Drawing.Point(19, 28);
            this.rdbOdaUrun.Name = "rdbOdaUrun";
            this.rdbOdaUrun.Size = new System.Drawing.Size(96, 17);
            this.rdbOdaUrun.TabIndex = 13;
            this.rdbOdaUrun.TabStop = true;
            this.rdbOdaUrun.Text = "Oda Ürünleri";
            this.rdbOdaUrun.UseVisualStyleBackColor = false;
            this.rdbOdaUrun.CheckedChanged += new System.EventHandler(this.rdbOdaUrun_CheckedChanged);
            // 
            // rdbMutfakUrun
            // 
            this.rdbMutfakUrun.AutoSize = true;
            this.rdbMutfakUrun.BackColor = System.Drawing.Color.Transparent;
            this.rdbMutfakUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbMutfakUrun.Location = new System.Drawing.Point(163, 28);
            this.rdbMutfakUrun.Name = "rdbMutfakUrun";
            this.rdbMutfakUrun.Size = new System.Drawing.Size(112, 17);
            this.rdbMutfakUrun.TabIndex = 14;
            this.rdbMutfakUrun.TabStop = true;
            this.rdbMutfakUrun.Text = "Mutfak Ürünleri";
            this.rdbMutfakUrun.UseVisualStyleBackColor = false;
            this.rdbMutfakUrun.CheckedChanged += new System.EventHandler(this.rdbMutfakUrun_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ürün Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kategori :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ürün Adet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(270, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ürün Fiyat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(270, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Firma Adı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(270, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Geliş Tarihi :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Khaki;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(528, 26);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 31);
            this.btnEkle.TabIndex = 23;
            this.btnEkle.Text = "Ürün Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.Khaki;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.Location = new System.Drawing.Point(528, 63);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(123, 31);
            this.btnGoster.TabIndex = 24;
            this.btnGoster.Text = "Ürünleri Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Khaki;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(528, 100);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 31);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Ürünü Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Khaki;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(528, 137);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(107, 31);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Ürünü Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Khaki;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(528, 174);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(107, 31);
            this.btnTemizle.TabIndex = 27;
            this.btnTemizle.Text = "Formu Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dgVeriler
            // 
            this.dgVeriler.AllowUserToAddRows = false;
            this.dgVeriler.AllowUserToDeleteRows = false;
            this.dgVeriler.AllowUserToResizeColumns = false;
            this.dgVeriler.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.dgVeriler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVeriler.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgVeriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgVeriler.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVeriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.urunAdi,
            this.kategori,
            this.adet,
            this.fiyat,
            this.firma,
            this.gelisTarihi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVeriler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgVeriler.Location = new System.Drawing.Point(34, 266);
            this.dgVeriler.MultiSelect = false;
            this.dgVeriler.Name = "dgVeriler";
            this.dgVeriler.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVeriler.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgVeriler.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.dgVeriler.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgVeriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVeriler.Size = new System.Drawing.Size(601, 185);
            this.dgVeriler.TabIndex = 28;
            this.dgVeriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVeriler_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // urunAdi
            // 
            this.urunAdi.DataPropertyName = "urunAdi";
            this.urunAdi.HeaderText = "ÜRÜN ADI";
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // kategori
            // 
            this.kategori.DataPropertyName = "kategori";
            this.kategori.HeaderText = "KATEGORİ";
            this.kategori.Name = "kategori";
            this.kategori.ReadOnly = true;
            // 
            // adet
            // 
            this.adet.DataPropertyName = "adet";
            this.adet.HeaderText = "ADET";
            this.adet.Name = "adet";
            this.adet.ReadOnly = true;
            // 
            // fiyat
            // 
            this.fiyat.DataPropertyName = "fiyat";
            this.fiyat.HeaderText = "FİYAT";
            this.fiyat.Name = "fiyat";
            this.fiyat.ReadOnly = true;
            // 
            // firma
            // 
            this.firma.DataPropertyName = "firma";
            this.firma.HeaderText = "FİRMA ADI";
            this.firma.Name = "firma";
            this.firma.ReadOnly = true;
            // 
            // gelisTarihi
            // 
            this.gelisTarihi.DataPropertyName = "gelisTarihi";
            this.gelisTarihi.HeaderText = "GELİŞ TARİHİ";
            this.gelisTarihi.Name = "gelisTarihi";
            this.gelisTarihi.ReadOnly = true;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(348, 231);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(162, 20);
            this.txtAra.TabIndex = 29;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Location = new System.Drawing.Point(22, 238);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 31;
            this.lblid.Text = "ID";
            this.lblid.Visible = false;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.Khaki;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(528, 220);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(107, 31);
            this.btnAra.TabIndex = 32;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FrmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::otelOtomasyonu.Properties.Resources.istockphoto_187102598_612x612;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgVeriler);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rdbMutfakUrun);
            this.Controls.Add(this.rdbOdaUrun);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMutfak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIANA OTEL - Mutfak";
            ((System.ComponentModel.ISupportInitialize)(this.dgVeriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.RadioButton rdbOdaUrun;
        private System.Windows.Forms.RadioButton rdbMutfakUrun;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dgVeriler;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelisTarihi;
    }
}