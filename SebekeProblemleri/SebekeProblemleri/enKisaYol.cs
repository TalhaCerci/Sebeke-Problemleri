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
    public partial class enKisaYol : Form
    {
        public enKisaYol()
        {
            InitializeComponent();
        }


        static int numara = 0;
        static List<int> X_eksen = new List<int>();
        static List<int> Y_eksen = new List<int>();
        static int[,] mesafeler;
        static int[,] yol;

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
            if (baslangic > numara || bitis > numara)
            {
                MessageBox.Show("Hatalı konum Giridinz");
                return;
            }
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

        int minDistance(int[] dist, bool[] sptSet)
        {
            int min = int.MaxValue;
            int min_index = -1;
            for (int i = 0; i < numara; i++)
            {
                if (sptSet[i] == false && dist[i] <= min)
                {
                    min = dist[i];
                    min_index = i;
                }
            }
            return min_index;
        }
        void printSolution(int[] dist, int n)
        {
            //Console.WriteLine("Düğümlerin ana kaynağa uzaklığı");
            //for (int i = 0; i < numara; i++)
            //{
            //    Console.WriteLine(i + "   " + dist[i]);
            //}
        }
        int dijkstra(int[,] graph, int src, int dest)
        {
            int[] dist = new int[numara];
            bool[] sptSet = new bool[numara];
            for (int i = 0; i < numara; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }
            dist[src] = 0;
            for (int i = 0; i < numara - 1; i++)
            {
                int u = minDistance(dist, sptSet);
                sptSet[u] = true;
                for (int j = 0; j < numara; j++)
                {
                    if (!sptSet[j] && graph[u, j] != int.MaxValue && dist[u] != int.MaxValue && dist[u] + graph[u, j] < dist[j])
                    {
                        dist[j] = dist[u] + graph[u, j];
                        yol[u, j] = u;
                    }
                }
            }
            printSolution(dist, numara);
            int sonuc = dist[dest];
            return sonuc;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            yol = new int[numara, numara];
            lblEnKisaMesafe.Text = "En Kısa Mesafe : ";
            for (int i = 0; i < numara; i++)
            {
                for (int j = 0; j < numara; j++)
                {
                    if (mesafeler[i, j] == 0 && i != j)
                        mesafeler[i, j] = int.MaxValue;
                    if (i == j)
                        mesafeler[i, j] = 0;
                }
            }
            int sonuc = dijkstra(mesafeler, Convert.ToInt32(txt_kaynak.Text) - 1, Convert.ToInt32(txt_hedef.Text) - 1);
            lblEnKisaMesafe.Text += sonuc.ToString();

        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
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

        private void enKisaYol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }


}

