using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace _01_OOP_Uygulama_Personel_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Personel> personelList = new List<Personel>();
        string filePath;
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            UnvanDoldur();
        }
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filePath = openFileDialog1.FileName;
            if (filePath != "" && filePath != "openFileDialog1")
                pictureBox1.Image = Image.FromFile(filePath);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DateTime dogumTarihi = dateTimePicker1.Value;
            int yas = 0;
            if (DateTime.Now.Month < dogumTarihi.Month)
            {
                yas = (DateTime.Now.Year - dogumTarihi.Year) - 1;
            }
            else
            {
                yas = DateTime.Now.Year - dogumTarihi.Year;
            }

            if (yas >= 18)
            {
                if (!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text))
                {

                    Personel personel = new Personel((int)(nudPersonelId.Value), PascalCase(txtAd.Text), PascalCase(txtSoyad.Text), dateTimePicker1.Value, dtpIsGirisTarihi.Value, mtbTelefonNo.Text, txtEmail.Text, txtAdres.Text, (Unvan)(cmbUnvan.SelectedIndex), filePath);

                    personelList.Add(personel);

                    ListeyeEkle(personel);

                    FormClear();

                    nudPersonelId.Value += 1;
                    sayac = (int)(nudPersonelId.Value);
                }
                else
                {
                    MessageBox.Show("K�rm�z� y�ld�zl� (*) alanlar�n doldurulmas� zorunludur!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("18 ya��ndan b�y�k olman�z gerekmektedir!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lsvPersonelListesi.SelectedItems.Count != 0)
            {
                foreach (Personel personel in personelList)
                {
                    if (personel.PersonelId == Convert.ToDecimal(lsvPersonelListesi.SelectedItems[0].SubItems[0].Text))
                    {
                        personelList.Remove(personel);
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Silme ��lemi i�in bir personel se�melisiniz.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ListViewBastanYaz();

            FormClear();
            PersonelIdDefault();
            btnKaydet.Enabled = true;

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            foreach (Personel personel in personelList)
            {
                if (personel.PersonelId == (int)(nudPersonelId.Value))
                {
                    personel.PersonelId = (int)(nudPersonelId.Value);
                    personel.Ad = txtAd.Text;
                    personel.Soyad = txtSoyad.Text;
                    personel.DogumTarihi = dateTimePicker1.Value;
                    personel.IseGirisTarihi = dtpIsGirisTarihi.Value;
                    personel.TelefonNo = (mtbTelefonNo.Text);
                    personel.Email = txtEmail.Text;
                    personel.Adres = txtAdres.Text;
                    personel.Unvan = (Unvan)(cmbUnvan.SelectedIndex);
                    personel.Fotograf = filePath;
                }
            }
            ListViewBastanYaz();

            FormClear();
            PersonelIdDefault();
            btnKaydet.Enabled = true;
        }

        private void lsvPersonelListesi_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
            FormClear();
            foreach (Personel personel in personelList)
            {

                if (personel.PersonelId == Convert.ToDecimal(lsvPersonelListesi.SelectedItems[0].SubItems[0].Text))
                {
                    nudPersonelId.Value = personel.PersonelId;
                    txtAd.Text = personel.Ad;
                    txtSoyad.Text = personel.Soyad;
                    dateTimePicker1.Value = personel.DogumTarihi;
                    mtbTelefonNo.Text = personel.TelefonNo;
                    txtAdres.Text = personel.Adres;
                    cmbUnvan.SelectedIndex = (int)(personel.Unvan);
                    if (!string.IsNullOrEmpty(personel.Fotograf) && personel.Fotograf != "openFileDialog1")
                        pictureBox1.Image = Image.FromFile(personel.Fotograf);
                }
            }
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            MailOlustur();
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            MailOlustur();
        }
        void ListeyeEkle(Personel personel)
        {
            ListViewItem item = new ListViewItem(personel.PersonelId.ToString());
            item.SubItems.Add(personel.Ad);
            item.SubItems.Add(personel.Soyad);
            item.SubItems.Add(personel.IseGirisTarihi.ToString());
            item.SubItems.Add(personel.Email);
            lsvPersonelListesi.Items.Add(item);
        }
        void ListeyiTemizle()
        {
            lsvPersonelListesi.Items.Clear();
        }
        public void FormClear()
        {
            foreach (Control control in grpPersonelBilgileri.Controls)
            {

                if (control is TextBox)
                    ((TextBox)(control)).Clear();
                else if (control is MaskedTextBox)
                    ((MaskedTextBox)control).Clear();
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
                else if (control is DateTimePicker)
                    ((DateTimePicker)control).Value = DateTime.Now;
                else if (control is PictureBox)
                    ((PictureBox)control).Image = null;
            }
            filePath = "";
        }
        /// <summary>
        /// Ad ve soyad aras�na '.' getirerek ki�iye �zel mail adresi olu�turulmas�n� sa�lar ve Email textbox'�na yazd�r�r. Daha �nce ayn� isim ve soyisimli bir E-mail varsa sonuna ID numaras�n�n sonunu ekleyerek olu�turur.
        /// </summary>
        public void MailOlustur()
        {
            txtEmail.Text = CleanWriting(txtAd.Text) + "." + CleanWriting(txtSoyad.Text) + "@bilgeadam.com";
            if (btnKaydet.Enabled)
            {
                foreach (Personel personel in personelList)
                {
                    if (personel.Email == txtEmail.Text)
                    {
                        txtEmail.Text = CleanWriting(txtAd.Text) + "." + CleanWriting(txtSoyad.Text) + nudPersonelId.Value % 1000 + "@bilgeadam.com";
                    }
                }
            }
        }
        void ListViewBastanYaz()
        {
            ListeyiTemizle();
            foreach (Personel personel in personelList)
            {
                ListeyeEkle(personel);
            }
        }
        /// <summary>
        /// yap�lan i�lemler sonucunda Personel ID'sinin kald��� yerden devam etmesini sa�lar
        /// </summary>
        void PersonelIdDefault()
        {
            nudPersonelId.Value = sayac;
        }
        /// <summary>
        /// Unvan combobox'�n�n, Unvan enum'�n� kullanarak dolmas�n� sa�lar.
        /// </summary>
        void UnvanDoldur()
        {
            cmbUnvan.DataSource = Enum.GetValues(typeof(Unvan));
            cmbUnvan.SelectedIndex = -1;
        }
        /// <summary>
        /// Bo�luklar� siler, Harfleri k���lt�r ve T�rk�e karakterleri ingilizce karakterlere d�n��t�r�r.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public string CleanWriting(string param)
        {
            param = param.Trim().ToLower().Replace('�', 'i').Replace('�', 'g').Replace('�', 'u').Replace('�', 's').Replace('�', 'o').Replace('�', 'c');
            return param;
        }
        /// <summary>
        /// Bo�luklar�n silinerek sadece ilk harfin b�y�k olmas�n� sa�lar.
        /// </summary>
        /// <param name="metin"></param>
        /// <returns></returns>
        string PascalCase(string metin)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(metin.Trim().ToLower());
        }


    }
}