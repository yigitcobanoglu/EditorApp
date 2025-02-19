namespace EditorApp
{
    public partial class Form1 : Form
    {
        string dosyaAdi;//edit�rdeki dosyan�n ad�

        public Form1()
        {
            InitializeComponent();

            YeniBelge();//uygulama ilk�al��t���nda yeni belge olu�tursun
        }

        void YeniBelge()
        {
            //sleamasdasdasdasdas
            txtBelge.Text = "";//metin kutusunu temizler
            dosyaAdi = "";
            Text = "[Yeni Belge]";
        }
        void Kaydet()
        {
            //e�er dosya zaten kay�tl� ise diyalog g�sterme
            //
            if (!string.IsNullOrEmpty(dosyaAdi))//dosyaAdi!=""
            {
                File.WriteAllText(dosyaAdi, txtBelge.Text);
                return;
            }

            saveFileDialog1.Filter = "Metin Dosyalar�|*.txt|T�m Dosyalar|*.*";
            saveFileDialog1.DefaultExt = "*.txt";
            DialogResult cevap = saveFileDialog1.ShowDialog();

            if (cevap == DialogResult.OK)//kullan�c� tamam dediyse
            {
                string secilenDosya = saveFileDialog1.FileName;

                //File s�n�f� dosya i�lemleri i�in kullan�l�r
                File.WriteAllText(secilenDosya, txtBelge.Text);
                dosyaAdi = secilenDosya;
                Text = $"[{dosyaAdi}]";
            }
        }

        private void miYeni_Click(object sender, EventArgs e)
        {
            YeniBelge();
        }

        private void tsbYeni_Click(object sender, EventArgs e)
        {
            YeniBelge();
        }

        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void tsbAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.Filter = "Metin Dosyalar�|*.txt|T�m Dosyalar|*.*";
            dialog.DefaultExt = "*.txt";

            DialogResult cevap = dialog.ShowDialog();//g�ster ve bekle
            if (cevap == DialogResult.OK)//gelen cevap ne?
            {
                string secilenDosya = dialog.FileName;
                string icerik = File.ReadAllText(secilenDosya);
                txtBelge.Text = icerik;
                dosyaAdi = secilenDosya;
                Text = $"[{dosyaAdi}]";

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox diayalog penceresi
            //MessageBox.Show("Form kapan�yor.....");
            //MessageBox.Show("Form Kapan�yor....", "Dikkat");
            //MessageBox.Show("Form Kapan�yor....", "Dikkat", MessageBoxButtons.YesNoCancel);
            //MessageBox.Show("Form Kapan�yor....", "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            var cevap = MessageBox.Show("Kay�t edilmemi� de�i�iklikleri kay�t etmek ister misiniz?",
                "Dikkat", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Kaydet();
            }
            else if (cevap == DialogResult.Cancel)
            {
                e.Cancel = true;//kapatma i�lemini iptal et
            }
            //Hay�r se�ene�ini yazmaya gerek yok!!!!
        }

        private void miKes_Click(object sender, EventArgs e)
        {
            txtBelge.Cut();
        }

        private void miKopyala_Click(object sender, EventArgs e)
        {
            txtBelge.Copy();
        }

        private void miYapistir_Click(object sender, EventArgs e)
        {
            txtBelge.Paste();
        }

        private void tsbBul_Click(object sender, EventArgs e)
        {
            FrmBul form = new FrmBul(txtBelge);//Formun nesnesini olu�tur
            form.Show();//formu g�ster
            //form.ShowDialog();//formu diyalog olarak g�ster
        }
    }
}
