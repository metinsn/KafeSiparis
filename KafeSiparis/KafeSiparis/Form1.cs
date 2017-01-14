using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Masa[] masalar = new Masa[15];

        private void Form1_Load(object sender, EventArgs e)
        {
            lstBoxSiparisler.Items.Add("Ürün Adı \t\t\t Adet \t Fiyat\t");

            int no = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button buton = new Button();
                    buton.BackColor = Color.DarkSalmon;
                    buton.Width = 50;
                    buton.Height = 50;
                    no++;
                    buton.Text = Convert.ToString(no);
                    buton.Left = 20 + (buton.Width) * (j);
                    buton.Top = 10 + (buton.Height) * (i);
                    buton.Click += buton_click;
                    groupBox1.Controls.Add(buton);
                }
            }
        }
        private void buton_click(object sender, EventArgs e)
        {
            Button secbuton = sender as Button;
            secbuton.BackColor = Color.Aqua;
            groupBox2.Enabled = true;
            lblMasaNo.Text = secbuton.Text;

        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            Masa m = new Masa();
            m.masaNo = int.Parse(lblMasaNo.Text);


            Siparis sp = new Siparis();
            if (cmBoxYemek.SelectedItem != null)
            {
                sp.isim = cmBoxYemek.SelectedItem.ToString();
                sp.adet = Convert.ToInt32(numYemekMiktar.Value);
                m.siparisler.Add(sp);
            }

            sp = new Siparis();
            if (cmBoxIcecek.SelectedItem != null)
            {
                sp.isim = cmBoxIcecek.SelectedItem.ToString();
                sp.adet = Convert.ToInt32(numIcecekMiktar.Value);
                m.siparisler.Add(sp);
            }

            masalar[m.masaNo - 1] = m;

            foreach (var item in m.siparisler)
            {
                lstBoxSiparisler.Items.Add(item);
            }
           


        }
    }
}

