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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMinKap_Click(object sender, EventArgs e)
        {
            minimumKapsayanAgac mka = new minimumKapsayanAgac();
            mka.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEnKisaYol_Click(object sender, EventArgs e)
        {
            enKisaYol eky = new enKisaYol();
            eky.Show();
            this.Hide();
        }

        private void btnCPM_Click(object sender, EventArgs e)
        {
            CPM cpm = new CPM();
            cpm.Show();
            this.Hide();
        }
    }
}
