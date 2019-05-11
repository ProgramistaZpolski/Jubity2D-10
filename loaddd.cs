using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jubity2D_10__Engine
{
    public partial class loaddd : Form
    {
        public loaddd()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"\Optional2.js"))
            {
                Process.Start(@"\Optional2.js");
            }
            Playyer playyer = new Playyer();
            playyer.Activate();
            Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Graphics Reinvented")
            {
                MessageBox.Show("Please make sure that your computer supports: nVidia PsychiX nVidia HairWorks", "Warning!");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
