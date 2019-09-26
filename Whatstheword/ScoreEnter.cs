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

namespace Whatstheword
{
    public partial class ScoreEnter : Form
    {
        public static string name;
        StreamWriter sw;
        public ScoreEnter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            sw = File.AppendText(path + "\\Scores.txt");
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(Form1.score);
            sw.Close();
            Leaderboards lb = new Leaderboards();
            lb.Show();
            this.Close();          
        }

        private void ScoreEnter_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;

            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;

            button1.Parent = pictureBox1;
            button1.BackColor = Color.Transparent;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
