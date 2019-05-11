using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Jubity2D_10__Engine
{
    public partial class Editor2D : Form
    {
        public byte speeed;
        public short levelnum = 0;
        public bool cinemachine = false;
        public string splasher = "sampleSplash.mp4";
        public string musicname;
        public Regex keyWords = new Regex("abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|" +
"foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|" + "string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|volatile|void|while|");
        [DllImport("user32.dll")] // import lockwindow to remove flashing
public static extern bool LockWindowUpdate(IntPtr hWndLock);

        public Editor2D()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > 255)
            {
                MessageBox.Show("Errors Found!", "Jubity2D-10");
                richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "ERROR CRITICAL: MAXIMAL VALUE SPEED OF PLAYER IS 255 (MAXIMAL VALUE OF BYTE VARIABLE IS 255)";
            }
            else
            {
                speeed = Convert.ToByte(numericUpDown1.Value);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Playyer playyer = new Playyer();
            playyer.Show();
            playyer.pictureBox1.ImageLocation = pictureBox1.ImageLocation;
            playyer.pictureBox2.ImageLocation = pictureBox2.ImageLocation;
            playyer.speeeeeeeeed = speeed;
            playyer.cinemachine = cinemachine;
            playyer.axWindowsMediaPlayer1.URL = musicname;
            playyer.pictureBox3.ImageLocation = pictureBox3.ImageLocation;
            loaddd loaaderek = new loaddd();
            loaaderek.Show();
            loaaderek.label1.Text = textBox1.Text;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
            }
            else
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
            }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Editor2D_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (levelnum == 1)
            {
                File.WriteAllText(saveFileDialog1.FileName + @"\level1.j2d", pictureBox1.ImageLocation);
            }
            else if (levelnum == 0)
            {
                MessageBox.Show("Please save project to EMPTY folder", "Jubity2D-10");
                saveFileDialog1.ShowDialog();
                Directory.CreateDirectory(saveFileDialog1.FileName);
                File.WriteAllText(saveFileDialog1.FileName + @"\Main.j2d", textBox1.Text);
                File.WriteAllText(saveFileDialog1.FileName + @"\speed.j2d", Convert.ToString(numericUpDown1.Value));
                File.WriteAllText(saveFileDialog1.FileName + @"\level0.j2d", pictureBox1.ImageLocation);
                File.WriteAllText(saveFileDialog1.FileName + @"\sharedassets.j2d", pictureBox2.ImageLocation);
            }
            
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (levelnum == 0)
            {
                folderBrowserDialog1.ShowDialog();
                textBox1.Text = File.ReadAllText(folderBrowserDialog1.SelectedPath + @"\Main.j2d");
                numericUpDown1.Value = Convert.ToDecimal(File.ReadAllText(folderBrowserDialog1.SelectedPath + @"\speed.j2d"));
                pictureBox1.ImageLocation = File.ReadAllText(folderBrowserDialog1.SelectedPath + @"\level0.j2d");
                pictureBox2.ImageLocation = File.ReadAllText(folderBrowserDialog1.SelectedPath + @"\sharedassets.j2d");
            }
            else if (levelnum == 1)
            {
                pictureBox1.ImageLocation = File.ReadAllText(folderBrowserDialog1.SelectedPath + @"\level1.j2d");
            }
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }
        
        private void Button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Please save the current level before changing active level! Please select did you save current level", "Jubity2D-10", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                levelnum = 2;
                pictureBox1.ImageLocation = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                //nothing lol
            }
        }

        private void SaveLevel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void YourOwnImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Only .bmp files are currently supported", "Jubity2D-10 Themes");
            openFileDialog1.ShowDialog();
            Image myimage = new Bitmap(openFileDialog1.FileName);
            BackgroundImage = myimage;
        }

        private void WhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            tabPage1.BackColor = Color.White;
            tabPage3.BackColor = Color.White;
            tabPage4.BackColor = Color.White;
            tabPage5.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
        }

        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            tabPage1.BackColor = Color.Black;
            tabPage3.BackColor = Color.Black;
            tabPage4.BackColor = Color.Black;
            tabPage5.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void ExeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            holdon holdplease = new holdon();
            holdplease.Show();
            using (var client = new WebClient())
            {
                client.DownloadFile("http://www.programistazpolski.ct8.pl/JubityPlayer.exe", AppDomain.CurrentDomain.BaseDirectory + @"\JubityPlayer.exe");
            }
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Main.j2d", textBox1.Text);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\level0.j2d", "tlo.png");
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"speed.j2d", Convert.ToString(numericUpDown1.Value));
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\sharedassets.j2d", "player.png");
            if (splasher != "sampleSplash.mp4")
            {
                File.Copy(splasher, "splashScreen.mp4");
            }
            else
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile("http://www.programistazpolski.ct8.pl/assetstore/sampleSplash.mp4", AppDomain.CurrentDomain.BaseDirectory + @"\splashScreen.mp4");
                }
            }
            File.Copy(pictureBox1.ImageLocation, "tlo.png");
            File.Copy(pictureBox1.ImageLocation, "player.png");
            holdplease.Close();
        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void ApkonlyUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            holdon holdplease = new holdon();
            holdplease.Show();
            using (var client = new WebClient())
            {
                client.DownloadFile("http://www.programistazpolski.ct8.pl/app-debug.apk", AppDomain.CurrentDomain.BaseDirectory + @"\JubityPlayerAPK.apk");
            }
            holdplease.Close();
        }

        private void TabPage6_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {
            int selPos = richTextBox2.SelectionStart;
            //For each match from the regex, highlight the word.
            foreach (Match keyWordMatch in keyWords.Matches(richTextBox2.Text))
            {
                richTextBox2.Select(keyWordMatch.Index, keyWordMatch.Length);
                richTextBox2.SelectionColor = Color.Blue;
                richTextBox2.SelectionStart = selPos;
                richTextBox2.SelectionColor = Color.Black;
            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\dialogs.vbs", richTextBox3.Text);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://forms.gle/GYBCUGg8Yi6mPAXu5");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox3.ImageLocation = openFileDialog1.FileName;
        }

        private void UnityProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Working on!");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            CompileSCS();
            File.WriteAllText("JubityFlow.cs", richTextBox2.Text);
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Optional2.js", richTextBox4.Text);
        }

        private void JunkCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JunkCode junk = new JunkCode();
            junk.Show();
        }

        public void CompileSCS()
        {
            //Don't copy that compiler, What? Why? Don't copy that, What? Why?
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            string Output = "JubityFlow.exe";

            TemptextBox.Text = "";
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, richTextBox2.Text);

            if (results.Errors.Count > 0)
            {
                TemptextBox.ForeColor = Color.Red;
                foreach (CompilerError CompErr in results.Errors)
                {
                    TemptextBox.Text = TemptextBox.Text +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                }
            }
            else
            {
                //Successful Compile
                TemptextBox.ForeColor = Color.Blue;
                TemptextBox.Text = "Success!";
                
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (File.Exists("JubityFlow.exe"))
            {
                Process.Start("JubityFlow.cs");
            }
            else
            {
                MessageBox.Show("Please save file first!", "Jubity");
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                button14.Enabled = true;
            }
            else
            {
                button14.Enabled = false;
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            musicname = openFileDialog1.FileName;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            splasher = openFileDialog1.FileName;
        }
    }
}
