using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SebekeProblemleri
{
    public partial class minimumKapsayanAgac : Form
    {
        public minimumKapsayanAgac()
        {
            InitializeComponent();
        }

        static int numara = 0;
        static List<int> X_eksen = new List<int>();
        static List<int> Y_eksen = new List<int>();
        static int[,] mesafeler;

        Graphics cizgi;
        Pen kalem;
        Point BaslangicNokta;
        Point BitisNokta;
        void cizimYap(int n1x, int n1y, int n2x, int n2y)
        {
            BaslangicNokta = new Point(n1x, n1y);
            BitisNokta = new Point(n2x, n2y);
            cizgi = panel1.CreateGraphics();
            cizgi.DrawLine(kalem, BaslangicNokta, BitisNokta);
            kalem.Dispose();
            cizgi.Dispose();
        }
        Label lbl;
        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(txt_nereden.Text);
            int bitis = Convert.ToInt32(txt_nereye.Text);
            kalem = new Pen(Color.Red, 2);
            cizimYap(X_eksen[baslangic - 1] + 20, Y_eksen[baslangic - 1] + 20, X_eksen[bitis - 1] + 20, Y_eksen[bitis - 1] + 20);
            int mesafe = Convert.ToInt32(txt_mesafe.Text);
            mesafeler[baslangic - 1, bitis - 1] = mesafe;
            mesafeler[bitis - 1, baslangic - 1] = mesafe;
            lbl = new Label();
            lbl.Name = "lbl" + baslangic.ToString() + bitis.ToString();
            lbl.Text = mesafe.ToString();
            lbl.Size = new Size(40, 20);
            lbl.Font = new Font("Tahoma", 12, FontStyle.Bold);
            lbl.Location = new Point((X_eksen[baslangic - 1] + X_eksen[bitis - 1]) / 2, (Y_eksen[baslangic - 1] + Y_eksen[bitis - 1]) / 2);
            panel1.Controls.Add(lbl);
        }
        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {

            numara++;
            X_eksen.Add(e.X);
            Y_eksen.Add(e.Y);
            Button btn = new Button();
            btn.Name = numara.ToString();
            btn.Text = numara.ToString();
            btn.Size = new Size(40, 40);
            btn.Location = new Point(e.X, e.Y);
            panel1.Controls.Add(btn);
            mesafeler = new int[numara, numara];
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<int> baglananlar = new List<int>();
            List<int> hedef = new List<int>();
            baglananlar.Add(0);
            int toplamMesafe = 0;
            for (int i = 1; i < numara; i++)
            {
                hedef.Add(i);
            }
            int cizgiSay = 0;
            int enKucukSatir = 0, enKucukSutun = 0;
            while (cizgiSay != numara - 1)
            {
                int enKucuk = 1000;
                for (int i = 0; i < baglananlar.Count; i++)
                {
                    for (int j = 0; j < hedef.Count; j++)
                    {
                        if (mesafeler[baglananlar[i], hedef[j]] != 0)
                        {
                            if (mesafeler[baglananlar[i], hedef[j]] < enKucuk)
                            {
                                enKucuk = mesafeler[baglananlar[i], hedef[j]];
                                enKucukSatir = baglananlar[i];
                                enKucukSutun = hedef[j];
                            }
                        }
                    }
                }
                cizgiSay++;
                toplamMesafe += enKucuk;
                hedef.Remove(enKucukSutun);
                baglananlar.Add(enKucukSutun);
                kalem = new Pen(Color.Green, 2);
                cizimYap(X_eksen[enKucukSatir] + 20, Y_eksen[enKucukSatir] + 20, X_eksen[enKucukSutun] + 20, Y_eksen[enKucukSutun] + 20);
            }
            lblEnKisaMesafe.Text += toplamMesafe.ToString();
        }

        private void minimumKapsayanAgac_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
