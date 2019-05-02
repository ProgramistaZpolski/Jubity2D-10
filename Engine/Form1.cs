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
            System.Diagnostics.Process.Start("https://youtu.be/zwN5N0MNlxA");
        }
    }
}
