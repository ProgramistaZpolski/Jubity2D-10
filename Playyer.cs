using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Jubity2D_10__Engine
{
    public partial class Playyer : Form
    {
        public byte speeeeeeeeed;
        public bool cinemachine;
        public bool isJumping;
        public Playyer()
        {
            InitializeComponent();
        }

        private void Playyer_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Editor2D editor2D = new Editor2D();
            editor2D.pictureBox1.ImageLocation = pictureBox1.ImageLocation;
            if (editor2D.checkBox1.Checked == true)
            {
                if (editor2D.checkBox2.Checked == false)
                {
                    pictureBox2.Visible = false;
                }

            }
            if (File.Exists(@"\dialogs.vbs"))
            {
                Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"\dialogs.vbs");
            }
            if (File.Exists("JubityFlow.exe"))
            {
                Process.Start("JubityFlow.exe");
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer1.Stop();
        }

        private void Playyer_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox2.Location.X;
            int y = pictureBox2.Location.Y;

            if (e.KeyCode == Keys.Right) x += speeeeeeeeed;
            else if (e.KeyCode == Keys.Left) x -= speeeeeeeeed;
            else if (e.KeyCode == Keys.Up) y -= speeeeeeeeed;
            else if (e.KeyCode == Keys.Down) y += speeeeeeeeed;

            pictureBox2.Location = new Point(x, y);
            
        }
        void Dialogix()
        {
            MessageBox.Show("I am dialog!","Game");
        }
    }
}
