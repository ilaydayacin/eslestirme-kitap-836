using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eşleştirme_kitap_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string secim;
            bool cevap1, cevap2;
            secim = lbUzanti.SelectedItem.ToString();
            cevap2 = rbResim.Checked;
            cevap1 = rbVideo.Checked;
            if (cevap1 == true && (secim == "MP4" || secim == "MOV"))
            {
                MessageBox.Show("CEVABINIZ DOĞRU");
            }
            if (cevap1 == false && (secim == "MP4" || secim == "MOV"))
            {
                MessageBox.Show("CEVABINIZ YANLIŞ");
            }
            if (cevap2 == false && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("CEVABINIZ YANLIŞ");
            }
            if (cevap2 == true && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("CEVABINIZ DOĞRU");
            }
        }
    }
}
