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
    public partial class JunkCode : Form
    {
        public JunkCode()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int wybranarzecz = rnd.Next(1, 2);
            richTextBox2.Text = "using System;" + Environment.NewLine + "namespace iWannaDie" + Environment.NewLine + "{"
                + Environment.NewLine + "class iliketrains()" + Environment.NewLine + "{" + Environment.NewLine + "public byte WeAreNumberOne = 1;"
                + Environment.NewLine + "}" + Environment.NewLine + "}";
        }
    }
}
