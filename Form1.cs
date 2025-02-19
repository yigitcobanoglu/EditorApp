using System.Drawing.Drawing2D;
using System.Text.Json;

namespace EditorApp
{
    public partial class Form1 : Form
    {
        string dosyaAdi;//edit�rdeki dosyan�n ad�
        Ayarlar ayarlar = new Ayarlar();
        public Form1()
        {
            InitializeComponent();

            AyarlariYukle();

            YeniBelge();//uygulama ilk�al��t���nda yeni belge olu�tursun
        }
        void AyarlariYukle()
        {
            if (File.Exists("ayarlar.txt"))
            {
                string jsonMetni = File.ReadAllText("ayarlar.txt");
                //tam tersine serile�tirme yap
                //metni s�n�fa d�n��t�r 
                ayarlar = JsonSerializer.Deserialize<Ayarlar>(jsonMetni);
                Color yaziRengi = Color.FromArgb(ayarlar.YaziRengi);
                yaziRengi = Color.FromArgb(255, yaziRengi);

                Color arkaRengi = Color.FromArgb(ayarlar.ArkaplanRengi);
                arkaRengi = Color.FromArgb(255, arkaRengi);
                txtBelge.ForeColor = yaziRengi;
                txtBelge.BackColor = arkaRengi;

                toolStrip1.BackColor = txtBelge.BackColor;
                toolStrip1.ForeColor = txtBelge.ForeColor;
                menuStrip1.BackColor = txtBelge.BackColor;
                menuStrip1.ForeColor = txtBelge.ForeColor;
            }
        }
        void AyarlariKaydet()
        {
            //Serile�tirme s�n�f� verisini metne d�n��t�rme 
            //json serile�tirmeyi kullan 
            string jsonMetni = JsonSerializer.Serialize(ayarlar);

            File.WriteAllText("ayarlar.txt", jsonMetni);
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

        private void miYaziTipi_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            DialogResult cevap = dialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtBelge.Font = dialog.Font;
            }
        }

        private void miYaziRengi_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            DialogResult cevap = dialog.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                txtBelge.ForeColor = dialog.Color;
                ayarlar.YaziRengi = txtBelge.ForeColor.ToArgb();
                AyarlariKaydet();
            }
        }

        private void miKoyuTema_Click(object sender, EventArgs e)
        {
            txtBelge.BackColor = Color.Gray;
            txtBelge.ForeColor = Color.White;
            toolStrip1.BackColor = Color.Gray;
            toolStrip1.ForeColor = Color.White;
            menuStrip1.BackColor = Color.Gray;
            menuStrip1.ForeColor = Color.White;
            statusStrip1.BackColor = Color.Gray;
            statusStrip1.ForeColor = Color.White;
            ayarlar.ArkaplanRengi = Color.Black.ToArgb();
            ayarlar.YaziRengi = Color.Black.ToArgb();
            AyarlariKaydet();


        }

        private void miAcikTema_Click(object sender, EventArgs e)
        {
            txtBelge.BackColor = Color.LightGray;
            txtBelge.ForeColor = Color.Black;
            toolStrip1.BackColor = Color.SkyBlue;
            toolStrip1.ForeColor = Color.Black;
            menuStrip1.BackColor = Color.Azure;
            menuStrip1.ForeColor = Color.Black;
            statusStrip1.BackColor = Color.LightCyan;
            statusStrip1.ForeColor = Color.Gray;
            ayarlar.ArkaplanRengi = Color.White.ToArgb();
            ayarlar.YaziRengi = Color.Black.ToArgb();
            AyarlariKaydet();
        }

        private void tsbHakkimda_Click(object sender, EventArgs e)
        {
            FrmHakkimda form = new();
            form.ShowDialog();
            
        }
    }
}
