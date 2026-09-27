namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Button> koltukListesi = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            char[] satirlar = { 'A', 'B', 'C', 'D', 'E' };
            for (int d = 0; d < 5; d++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    Button btnKoltuk = new Button();
                    btnKoltuk.Text = satirlar[d] + y.ToString();
                    btnKoltuk.Width = 50;
                    btnKoltuk.Height = 50;
                    btnKoltuk.Left = ((y - 1) * 55) + 12;
                    btnKoltuk.Top = (d * 55) + 12;
                    btnKoltuk.BackColor = Color.Gray;
                    btnKoltuk.Click += Koltuk_Tiklandi;
                    this.Controls.Add(btnKoltuk);
                    koltukListesi.Add(btnKoltuk);
                }


            }
        }
        private void Koltuk_Tiklandi(object sender, EventArgs e)
        {
            Button basilanKoltuk = (Button)sender;
            if (basilanKoltuk.BackColor == Color.Gray)
                basilanKoltuk.BackColor = Color.Pink;
            else if (basilanKoltuk.BackColor == Color.Pink)
                basilanKoltuk.BackColor = Color.Gray;
            else if (basilanKoltuk.BackColor == Color.Red)
                basilanKoltuk.BackColor = Color.Orange;
            else if (basilanKoltuk.BackColor == Color.Orange)
                basilanKoltuk.BackColor = Color.Red;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            int secilenSayisi = 0;
            for (int i=0;i<koltukListesi.Count;i++)
            {
                Button koltuk = koltukListesi[i];

                if(koltuk.BackColor==Color.Pink)
                {
                    koltuk.BackColor = Color.Red;
                    secilenSayisi++;
                }
            }
            if (secilenSayisi > 0)
                MessageBox.Show($"{secilenSayisi} adet bilet onaylandı!");
            else
                MessageBox.Show("Lütfen önce koltuk seçin.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int iptalSayisi = 0;

            for(int i=0; i<koltukListesi.Count; i++)
            {
                Button koltuk = koltukListesi[i];

                if (koltuk.BackColor == Color.Orange)
                {
                    koltuk.BackColor = Color.Gray;
                    iptalSayisi++;
                }
            }
            if (iptalSayisi > 0)
                MessageBox.Show($"{iptalSayisi} adet bilet iptal edildi.");
            else
                MessageBox.Show("Lütfen önce iptal edilecek koltuk seçin.");
        }
    }

}
