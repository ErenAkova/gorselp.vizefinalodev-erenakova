namespace Görsel_P_hesaplama_vize_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double vize, final, ort;

                vize = Convert.ToDouble(numericUpDown1.Value);
                final = Convert.ToDouble(numericUpDown2.Value);
                ort = vize * 0.4 + final * 0.6;
                label6.Text = ort.ToString();

                if (ort < 50)
                {
                    label7.Text = "FF";
                    label8.Text = "KALDI";
                    label8.ForeColor = Color.Red;
                }
                else if (ort < 60)
                {
                    label7.Text = "DD";
                    label8.Text = "GEÇTİ";
                    label8.ForeColor = Color.Green;
                }
                else if (ort < 70)
                {
                    label7.Text = "CC";
                    label8.Text = "GEÇTİ";
                    label8.ForeColor = Color.Green;
                }
                else if (ort < 85)
                {
                    label7.Text = "BB";
                    label8.Text = "GEÇTİ";
                    label8.ForeColor = Color.Green;
                }
                else
                {
                    label7.Text = "AA";
                    label8.Text = "GEÇTİ";
                    label8.ForeColor = Color.Green;
                }


            }
            catch (Exception)
            {

                //HOCAM CİDDEN GÜNLERDİR SAATLER VERDİM YOK OLMUYOR. HATAYI ÇIKARAMADIM. UYARI VERMEDİ. CATCH'İN DIŞINDA İF ELSE YORDAMIYLA YAPAYIM DEDİM 
                //BU SEFER FORM ÇALIŞIR ÇALIŞMAZ HATALI NOT GİRİŞİ DİYOR TAMAM DİYORUM BİRDAHA AYNISINI VERİYOR KAPANMIYOR. NE YAPMAM GEREKİYOR ?
                if (numericUpDown1.Value >= 101 || numericUpDown2.Value >= 101)
                {
                    MessageBox.Show("Hatalı not girişi!");
                    //label6.Text = "";
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;
                }


            }
            


        }
    }
}









