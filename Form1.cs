using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jubity2D_10__Engine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Editor2D eddit = new Editor2D();
            eddit.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLGSnzNTw_uf_bdUt8AxOBRLsK7dPy6NR-");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Updateer updejter = new Updateer();
            updejter.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Editor2D eddit = new Editor2D();
            eddit.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLGSnzNTw_uf_bdUt8AxOBRLsK7dPy6NR-");
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.programistazpolski.ct8.pl/assetstore/learn.zip");
        }
    }
}
