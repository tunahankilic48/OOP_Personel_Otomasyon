namespace _01_OOP_Uygulama_Personel_Otomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.nudPersonelId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.dtpIsGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mtbTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.lblIseGirisTarihi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblPersonelId = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lsvPersonelListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.grpPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonelId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPersonelBilgileri
            // 
            this.grpPersonelBilgileri.Controls.Add(this.nudPersonelId);
            this.grpPersonelBilgileri.Controls.Add(this.label3);
            this.grpPersonelBilgileri.Controls.Add(this.label5);
            this.grpPersonelBilgileri.Controls.Add(this.label4);
            this.grpPersonelBilgileri.Controls.Add(this.label2);
            this.grpPersonelBilgileri.Controls.Add(this.label1);
            this.grpPersonelBilgileri.Controls.Add(this.btnSil);
            this.grpPersonelBilgileri.Controls.Add(this.btnGuncelle);
            this.grpPersonelBilgileri.Controls.Add(this.btnKaydet);
            this.grpPersonelBilgileri.Controls.Add(this.btnResimSec);
            this.grpPersonelBilgileri.Controls.Add(this.pictureBox1);
            this.grpPersonelBilgileri.Controls.Add(this.cmbUnvan);
            this.grpPersonelBilgileri.Controls.Add(this.dtpIsGirisTarihi);
            this.grpPersonelBilgileri.Controls.Add(this.dateTimePicker1);
            this.grpPersonelBilgileri.Controls.Add(this.txtSoyad);
            this.grpPersonelBilgileri.Controls.Add(this.txtEmail);
            this.grpPersonelBilgileri.Controls.Add(this.txtAdres);
            this.grpPersonelBilgileri.Controls.Add(this.txtAd);
            this.grpPersonelBilgileri.Controls.Add(this.mtbTelefonNo);
            this.grpPersonelBilgileri.Controls.Add(this.lblUnvan);
            this.grpPersonelBilgileri.Controls.Add(this.lblIseGirisTarihi);
            this.grpPersonelBilgileri.Controls.Add(this.lblAdres);
            this.grpPersonelBilgileri.Controls.Add(this.lblEmail);
            this.grpPersonelBilgileri.Controls.Add(this.lblTelefonNo);
            this.grpPersonelBilgileri.Controls.Add(this.lblDogumTarihi);
            this.grpPersonelBilgileri.Controls.Add(this.lblSoyad);
            this.grpPersonelBilgileri.Controls.Add(this.lblAd);
            this.grpPersonelBilgileri.Controls.Add(this.lblPersonelId);
            this.grpPersonelBilgileri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpPersonelBilgileri.Location = new System.Drawing.Point(9, 8);
            this.grpPersonelBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPersonelBilgileri.Name = "grpPersonelBilgileri";
            this.grpPersonelBilgileri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPersonelBilgileri.Size = new System.Drawing.Size(725, 233);
            this.grpPersonelBilgileri.TabIndex = 0;
            this.grpPersonelBilgileri.TabStop = false;
            this.grpPersonelBilgileri.Text = "PERSONEL BİLGİLERİ";
            // 
            // nudPersonelId
            // 
            this.nudPersonelId.Enabled = false;
            this.nudPersonelId.Location = new System.Drawing.Point(104, 34);
            this.nudPersonelId.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPersonelId.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPersonelId.Name = "nudPersonelId";
            this.nudPersonelId.Size = new System.Drawing.Size(205, 27);
            this.nudPersonelId.TabIndex = 1;
            this.nudPersonelId.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(315, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(315, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(315, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(315, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(315, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "*";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(505, 190);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 33);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(614, 190);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 33);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(614, 137);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 33);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(505, 137);
            this.btnResimSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(105, 33);
            this.btnResimSec.TabIndex = 10;
            this.btnResimSec.Text = "RESİM SEÇ";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(374, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(505, 105);
            this.cmbUnvan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(214, 28);
            this.cmbUnvan.TabIndex = 9;
            // 
            // dtpIsGirisTarihi
            // 
            this.dtpIsGirisTarihi.Location = new System.Drawing.Point(505, 68);
            this.dtpIsGirisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpIsGirisTarihi.Name = "dtpIsGirisTarihi";
            this.dtpIsGirisTarihi.Size = new System.Drawing.Size(214, 27);
            this.dtpIsGirisTarihi.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 131);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(104, 100);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(205, 27);
            this.txtSoyad.TabIndex = 3;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(104, 203);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(505, 20);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(214, 27);
            this.txtAdres.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(104, 66);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(205, 27);
            this.txtAd.TabIndex = 2;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // mtbTelefonNo
            // 
            this.mtbTelefonNo.Location = new System.Drawing.Point(104, 164);
            this.mtbTelefonNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTelefonNo.Mask = "(999) 000-0000";
            this.mtbTelefonNo.Name = "mtbTelefonNo";
            this.mtbTelefonNo.Size = new System.Drawing.Size(205, 27);
            this.mtbTelefonNo.TabIndex = 5;
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(374, 105);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(62, 20);
            this.lblUnvan.TabIndex = 8;
            this.lblUnvan.Text = "UNVAN:";
            // 
            // lblIseGirisTarihi
            // 
            this.lblIseGirisTarihi.AutoSize = true;
            this.lblIseGirisTarihi.Location = new System.Drawing.Point(374, 72);
            this.lblIseGirisTarihi.Name = "lblIseGirisTarihi";
            this.lblIseGirisTarihi.Size = new System.Drawing.Size(120, 20);
            this.lblIseGirisTarihi.TabIndex = 7;
            this.lblIseGirisTarihi.Text = "İŞE GİRİŞ TARİHİ:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(374, 36);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(58, 20);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "ADRES:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(4, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-MAİL:";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Location = new System.Drawing.Point(4, 168);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(98, 20);
            this.lblTelefonNo.TabIndex = 4;
            this.lblTelefonNo.Text = "TELEFON NO:";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(4, 137);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(116, 20);
            this.lblDogumTarihi.TabIndex = 3;
            this.lblDogumTarihi.Text = "DOĞUM TARİHİ:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(4, 105);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(59, 20);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "SOYAD:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(4, 70);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(33, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "AD:";
            // 
            // lblPersonelId
            // 
            this.lblPersonelId.AutoSize = true;
            this.lblPersonelId.Location = new System.Drawing.Point(4, 36);
            this.lblPersonelId.Name = "lblPersonelId";
            this.lblPersonelId.Size = new System.Drawing.Size(101, 20);
            this.lblPersonelId.TabIndex = 0;
            this.lblPersonelId.Text = "PERSONEL ID:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lsvPersonelListesi
            // 
            this.lsvPersonelListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvPersonelListesi.FullRowSelect = true;
            this.lsvPersonelListesi.GridLines = true;
            this.lsvPersonelListesi.Location = new System.Drawing.Point(7, 246);
            this.lsvPersonelListesi.MultiSelect = false;
            this.lsvPersonelListesi.Name = "lsvPersonelListesi";
            this.lsvPersonelListesi.Size = new System.Drawing.Size(735, 220);
            this.lsvPersonelListesi.TabIndex = 1;
            this.lsvPersonelListesi.UseCompatibleStateImageBehavior = false;
            this.lsvPersonelListesi.View = System.Windows.Forms.View.Details;
            this.lsvPersonelListesi.Click += new System.EventHandler(this.lsvPersonelListesi_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Personel ID";
            this.columnHeader1.Width = 143;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 147;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşe Giriş Tarihi";
            this.columnHeader4.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mail Adresi";
            this.columnHeader5.Width = 147;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 474);
            this.Controls.Add(this.lsvPersonelListesi);
            this.Controls.Add(this.grpPersonelBilgileri);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPersonelBilgileri.ResumeLayout(false);
            this.grpPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersonelId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpPersonelBilgileri;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnKaydet;
        private Button btnResimSec;
        private PictureBox pictureBox1;
        private ComboBox cmbUnvan;
        private DateTimePicker dtpIsGirisTarihi;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSoyad;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private TextBox txtAd;
        private MaskedTextBox mtbTelefonNo;
        private Label lblUnvan;
        private Label lblIseGirisTarihi;
        private Label lblAdres;
        private Label lblEmail;
        private Label lblTelefonNo;
        private Label lblDogumTarihi;
        private Label lblSoyad;
        private Label lblAd;
        private Label lblPersonelId;
        private OpenFileDialog openFileDialog1;
        private ListView lsvPersonelListesi;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private NumericUpDown nudPersonelId;
    }
}