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
        private readonly KonamiSequence sequence = new KonamiSequence();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
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

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Editor3D editor3D = new Editor3D();
            editor3D.Show();
        }
        

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (sequence.IsCompletedBy(e.KeyCode))
            {
                MessageBox.Show("01001001 01110100 00100111 01110011 00100000 01101101 01100101 01110011 01110011 01100001 01100111 01100101 00100000 01100110 01110010 01101111 01101101 00100000 01110100 01101000 01100101 00100000 01100100 01100001 01110010 01101011 01100101 01110011 01110100 00100000 01101111 01100110 00100000 01100100 01100001 01110010 01101011 01100101 01110011 01110100 00100000 01100011 01101111 01101101 01110000 01110101 01110100 01100101 01110010 00100000 01110000 01100001 01110010 01110100 01110011 00101110 00100000 01001001 00100000 01110111 01100001 01101110 01110100 01100101 01100100 00100000 01110100 01101111 00100000 01101100 01100101 01110100 00100000 01111001 01101111 01110101 00100000 01101011 01101110 01101111 01110111 00101100 00100000 01110100 01101000 01100001 01110100 00100000 01001001 00100000 01101000 01100001 01110110 01100101 00100000 01100111 01101111 01110100 00100000 01100001 00100000 01000011 01100001 01110100 00100000 01101110 01100001 01101101 01100101 01100100 00100000 01001111 01101111 01101011 01101100 01100001 ");
                MessageBox.Show("01000111 01101111 00100000 01100001 01101110 01100100 00100000 01101100 01101111 01101111 01101011 00100000 01101001 01110100 00100000 01101001 01101110 00100000 01110011 01110000 01100101 01100101 01100100 01110100 01100101 01110011 01110100 00100000 01100001 01110000 01110000 ");
            }
        }
        public class KonamiSequence
        {
            readonly List<Keys> Keys = new List<Keys>{System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Up,
                                       System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.Down,
                                       System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right,
                                       System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right,
                                       System.Windows.Forms.Keys.B, System.Windows.Forms.Keys.A};
            private int mPosition = -1;

            public int Position
            {
                get { return mPosition; }
                private set { mPosition = value; }
            }

            public bool IsCompletedBy(Keys key)
            {

                if (Keys[Position + 1] == key)
                {
                    // move to next
                    Position++;
                }
                else if (Position == 1 && key == System.Windows.Forms.Keys.Up)
                {
                    // stay where we are
                }
                else if (Keys[0] == key)
                {
                    // restart at 1st
                    Position = 0;
                }
                else
                {
                    // no match in sequence
                    Position = -1;
                }

                if (Position == Keys.Count - 1)
                {
                    Position = -1;
                    return true;
                }

                return false;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Editor2D eddit = new Editor2D();
            eddit.Show();
        }
    }
}
