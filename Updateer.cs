using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jubity2D_10__Engine
{
    public partial class Updateer : Form
    {
        public int EditorVersion = 016;
        public Updateer()
        {
            InitializeComponent();
        }

        private void Updateer_Load(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("http://www.programistazpolski.ct8.pl/assetstore/version.txt", "version.txt");
                client.DownloadFile("http://www.programistazpolski.ct8.pl/assetstore/versionname.txt", "versionname.txt");
            }
            int wersja = Convert.ToInt32(File.ReadAllText("version.txt"));
            label2.Text = File.ReadAllText("versionname.txt");
            if (EditorVersion >= wersja)
            {
                Close();
            }
            else
            {
                Activate();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("http://www.programistazpolski.ct8.pl/assetstore/jubity.exe", "jubity.exe");
            }
        }
    }
}
