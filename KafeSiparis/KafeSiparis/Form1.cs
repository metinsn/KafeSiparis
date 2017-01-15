using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

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
            XmlDocument xmlgeir = new XmlDocument();
            xmlgeir.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            DateTime Tarih = Convert.ToDateTime(xmlgeir.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            lblTarih.Text = Tarih.ToString("dd/MM/yyyy");
            lblDolar.Text = xmlgeir.SelectSingleNode("//Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml.Replace(".", ",");
            lblEuro.Text = xmlgeir.SelectSingleNode("//Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml.Replace(".", ",");


            lstBoxSiparisler.Items.Add("ÜRÜN ADI\t\t ADET \t FİYAT(TL)\t");

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
                    buton.Top = 15 + (buton.Height) * (i);
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
            groupBox1.Enabled = false;

        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            Masa m = new Masa();
            m.masaNo = int.Parse(lblMasaNo.Text);
            lblMasaNo.Text = "";


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
            groupBox1.Enabled = true;



        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            Siparis sip = (Siparis)lstBoxSiparisler.SelectedItem;
            if (lstBoxSiparisler.SelectedIndex != -1 && lstBoxSiparisler.SelectedIndex != 0)
            {
                
                //int secindex = lstBoxSiparisler.SelectedIndex;
                //Masa ms = (Masa)lstBoxSiparisler.SelectedItem;                

                if (rbtnEuro.Checked == true)
                {
                    DialogResult sonuc = MessageBox.Show("Ödeme yapmak istermisiniz ?\n\n" + "Tutar : " +
                    Math.Round(sip.tutar / Convert.ToDouble(lblEuro.Text), 2) + " EURO", "Ödeme Bilgi", MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        lstBoxSiparisler.Items.Remove(lstBoxSiparisler.SelectedItem);
                        //ms.siparisler[secindex].tutar=0;
                    }
                }
                else if (rbtnUSD.Checked == true)
                {
                    DialogResult sonuc = MessageBox.Show("Ödeme yapmak istermisiniz ?\n\n " + "Tutar : " +
                    Math.Round(sip.tutar / Convert.ToDouble(lblDolar.Text), 2) + " USD", "Ödeme Bilgi", MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        lstBoxSiparisler.Items.Remove(lstBoxSiparisler.SelectedItem);
                    }
                }
                else
                {
                    DialogResult sonuc = MessageBox.Show("Ödeme yapmak istermisiniz ?\n\n " + "Tutar : "+ sip.tutar +" TL", "Ödeme Bilgi", MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        lstBoxSiparisler.Items.Remove(lstBoxSiparisler.SelectedItem);
                    }
                }


            }
        }
    }
}

