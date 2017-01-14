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

        Masa masa = new Masa();
        Button buton = new Button();
        private void Form1_Load(object sender, EventArgs e)
        {
            int no = 0;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Button buton = new Button();
                    buton.BackColor = Color.DarkSalmon;
                    buton.Width = 40;
                    buton.Height = 40;
                    no++;
                    buton.Text = Convert.ToString(no);
                    buton.Left = 10+(buton.Width) * (j);
                    buton.Top = 20+(buton.Height) * (i);
                    buton.Click += buton_click;
                    groupBox1.Controls.Add(buton);
                }
            }
        }
        private void buton_click(object sender, EventArgs e)
        {
            Button secbuton = sender as Button;
            secbuton.BackColor = Color.Aqua;
            masa.masaNo = Convert.ToInt32(secbuton.Text);
        }


    }
}

