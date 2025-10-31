using System;
using System.Windows.Forms;

namespace ödev1
{
    public partial class Form1 : Form
    {
        Random denek = new Random();
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int sayı = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void yesil_Click(object sender, EventArgs e)
        {
        }

        private void basla_Click(object sender, EventArgs e)
        {
            for (; ; )
            {
                a = denek.Next(0, 10);
                b = denek.Next(0, 10);
                c = denek.Next(0, 10);
                d = denek.Next(0, 10);
                if (a != b && a != c && a != d && b != c && b != d && c != d)
                    break;
            }

            sayı = a * 1000 + b * 100 + c * 10 + d;
            hak.Text = "10";
            textBox1.Text = "";
            yesil.Text = "0";
            mavi.Text = "0";
            kırmızı.Text = "0";
        }

        private void Dene_Click(object sender, EventArgs e)
        {
            int hakv1 = Convert.ToInt32(hak.Text);
            hakv1--;
            hak.Text = Convert.ToString(hakv1);
            int yesilv1 = 0;
            int maviv1 = 0;
            int kırmızıv1 = 0;
            string tahmin = textBox1.Text;

            int tahminv1 = Convert.ToInt32(tahmin);

            int binler = tahminv1 / 1000;
            tahminv1 = tahminv1 - binler * 1000;
            int yüzler = tahminv1 / 100;
            tahminv1 = tahminv1 - yüzler * 100;
            int onlar = tahminv1 / 10;
            tahminv1 = tahminv1 - onlar * 10;
            int birler = tahminv1;

            if (binler == a)
            {
                yesilv1++;
            }
            else if (binler == b || binler == c || binler == d)
            {


                maviv1++;
            }
            else
            {


                kırmızıv1++;
            }

            if (yüzler == b)
            {
                yesilv1++;
            }
            else if (yüzler == a || yüzler == c || yüzler == d)
            {


            
                maviv1++;

            }



            else
            {
                kırmızıv1++;
            }

            if (onlar == c)
            {
                yesilv1++;
            }
            else if (onlar == a || onlar == b || onlar == d)
            {
                maviv1++;
            }
            else
            {
                kırmızıv1++;
            }

            if (birler == d)
            {
                yesilv1++;
            }
            else if (birler == a || birler == b || birler == c)
            {
                maviv1++;
            }
            else
            {
                kırmızıv1++;
            }

            yesil.Text = Convert.ToString(yesilv1);
            mavi.Text = Convert.ToString(maviv1);
            kırmızı.Text = Convert.ToString(kırmızıv1);

            if (yesilv1 == 4)
            {
                MessageBox.Show("KAZANDINIZ");
            }
            if (hakv1 == 0)
            {
                MessageBox.Show("BİLEMEDİNİZ");
            }
            textBox1.Text = "";
        }

        private void DEBUG_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sayı.ToString());
        }

        private void kırmızı_Click(object sender, EventArgs e)
        {
        }

        private void mavi_Click(object sender, EventArgs e)
        {
        }
    }
}