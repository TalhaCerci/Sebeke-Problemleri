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
    public partial class CPM : Form
    {
        public CPM()
        {
            InitializeComponent();
        }

        int sira = 0;
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            sira++;
            dataGridView1.Rows[sira - 1].Cells[0].Value = sira;
        }
        private bool varm(string kelime, string aranan)
        {
            bool varmi = false;
            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i] == Convert.ToChar(aranan))
                    varmi = true;
            }
            return varmi;
        }


        int[] EB;
        int[] GB;
        int[] ES;
        int[] GS;
        private void button1_Click(object sender, EventArgs e)
        {

            //List<int> liste = new List<int>();
            EB = new int[dataGridView1.Rows.Count - 1];
            GB = new int[dataGridView1.Rows.Count - 1];
            ES = new int[dataGridView1.Rows.Count - 1];
            GS = new int[dataGridView1.Rows.Count - 1];
            string oncelik = "";
            string[] oncelikDizi;
            int buyuk = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (i == 0)
                {
                    EB[i] = 0;
                    ES[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                else
                {
                    if (dataGridView1.Rows[i].Cells[3].Value != null)
                    {
                        oncelik = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Öncelik Kısmı Boş Geçilemez!!!");
                    }
                    oncelikDizi = oncelik.Split(',');
                    if (oncelikDizi.Length == 1)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (oncelikDizi[0] == dataGridView1.Rows[j].Cells[1].Value.ToString())
                            {
                                EB[i] = ES[j];
                                ES[i] = EB[i] + Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                                break;
                            }
                        }
                    }
                    else if (oncelikDizi.Length > 1)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            for (int k = 0; k < oncelikDizi.Length; k++)
                            {
                                if (dataGridView1.Rows[j].Cells[1].Value.ToString() == oncelikDizi[k])
                                {
                                    if (ES[j] > buyuk)
                                    {
                                        buyuk = ES[j];
                                    }
                                }
                            }
                        }
                        EB[i] = buyuk;
                        ES[i] = EB[i] + Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        buyuk = 0;
                    }
                    else
                    {
                        MessageBox.Show("Öncelik Kısmı Boş Geçilemez!!!");
                    }
                }
            }
            label2.Text = "İşlemlerin Tamamlanması İçin Minimum Zaman : " + ES[dataGridView1.Rows.Count - 2].ToString() + " Birim Süre ";





            int sayac = 0, syc1mi = 0, kucuk = 10000;
            bool varmi = false;
            for (int i = dataGridView1.Rows.Count - 2; i >= 0; i--)
            {
                if (i == dataGridView1.Rows.Count - 2)
                {
                    GS[i] = ES[i];
                    GB[i] = GS[i] - Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                else
                {
                    for (int j = dataGridView1.Rows.Count - 2; j > i; j--)
                    {
                        oncelik = dataGridView1.Rows[j].Cells[3].Value.ToString();
                        varmi = varm(oncelik, dataGridView1.Rows[i].Cells[1].Value.ToString());
                        if (varmi == true)
                        {
                            syc1mi = j;
                            sayac++;
                        }
                        varmi = false;
                    }
                    if (sayac == 1)
                    {
                        GS[i] = GB[syc1mi];
                        GB[i] = GS[i] - Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                    if (sayac > 1)
                    {
                        for (int j = dataGridView1.Rows.Count - 2; j > i; j--)
                        {
                            oncelik = dataGridView1.Rows[j].Cells[3].Value.ToString();
                            varmi = varm(oncelik, dataGridView1.Rows[i].Cells[1].Value.ToString());
                            if (varmi == true)
                            {
                                if (kucuk > GB[j])
                                {
                                    kucuk = GB[j];
                                }
                            }
                            varmi = false;
                        }
                        GS[i] = kucuk;
                        GB[i] = GS[i] - Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                    sayac = 0;
                    kucuk = 10000;
                }
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (ES[i] == GS[i] && EB[i] == GB[i])
                {
                    label1.Text += dataGridView1.Rows[i].Cells[1].Value.ToString() + "   ";
                }
            }

        }

        private void CPM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
