using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatstheword
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instructions ins = new Instructions();
            ins.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Leaderboards lb = new Leaderboards();
            lb.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Parent = pictureBox2;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.Parent = pictureBox2;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.Parent = pictureBox2;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.Parent = pictureBox2;
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Instructions ins = new Instructions();
            ins.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Leaderboards lb = new Leaderboards();
            lb.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
