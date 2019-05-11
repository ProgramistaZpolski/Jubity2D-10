using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Jubity2D_10__Engine
{
    public partial class WaterSplash : Form
    {
        public WaterSplash()
        {
            InitializeComponent();
        }

        private void WaterSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Form1 poczatek = new Form1();
            poczatek.Show();
            Close();
        }
    }
}
