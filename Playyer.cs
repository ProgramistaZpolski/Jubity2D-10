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
            timer2.Start();
            Editor2D editor2D = new Editor2D();
            editor2D.pictureBox1.ImageLocation = pictureBox1.ImageLocation;
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

        private void Timer2_Tick(object sender, EventArgs e)
        {
            //Collison system
            if (pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                //Decrale variables
                int x = pictureBox2.Location.X;
                
                //Set X to smaller value
                x -= speeeeeeeeed;

                //Move gameObject
                pictureBox2.Location = new Point(x, pictureBox2.Location.Y);
            }
        }
    }
}
