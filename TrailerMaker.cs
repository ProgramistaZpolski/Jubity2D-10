using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Threading;

namespace Jubity2D_10__Engine
{
    public partial class TrailerMaker : Form
    {
        public string gameName;
        public TrailerMaker()
        {
            InitializeComponent();
        }

        private void TrailerMaker_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Editor2D editor2D = new Editor2D();
            gameName = editor2D.textBox1.Text;
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            axWindowsMediaPlayer1.URL = "sampleSplash.mp4";
            string tempbox = richTextBox1.Text;
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                synthesizer.Speak(gameName);
                synthesizer.Speak(tempbox);
            }).Start();
        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }
    }
}
