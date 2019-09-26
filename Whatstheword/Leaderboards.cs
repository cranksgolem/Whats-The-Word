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
    public partial class Leaderboards : Form
    {
        StreamReader sr;
        StreamWriter sw;
        public Leaderboards()
        {
            InitializeComponent();
        }

        private void Leaderboards_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;

            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;

            string path = Directory.GetCurrentDirectory();

            if (File.Exists(path + "\\Scores.txt") != true)
            {
                sw = new StreamWriter(path + "\\Scores.txt");
                sw.Close();
            }
            sr = new StreamReader(path + "\\Scores.txt");
            // get array length
            int length = 0;

            while (true)
            {
                string word = sr.ReadLine();
                if (word == null)
                {
                    break;
                }

                else
                {
                    length++;
                }
            }

            sr.Close();
            string[] name = new string[length / 2];
            int[] score = new int[length / 2];

            // put names in array
            sr = new StreamReader(path + "\\Scores.txt");

            for (int x = 0; x < (length / 2); x++)
            {
                name[x] = sr.ReadLine();
                sr.ReadLine();
            }

            sr.Close();

            // put scores in array

            sr = new StreamReader(path + "\\Scores.txt");
            for (int x = 0; x < (length / 2); x++)
            {
                sr.ReadLine();
                score[x] = int.Parse(sr.ReadLine());
            }

            for (int x = 0; x < (length / 2); x++)
            {
                for (int y = 0; y < (length / 2) - 1; y++)
                {
                    if (score[y] < score[y + 1])
                    {
                        int holdnum;
                        string holdname;

                        holdnum = score[y + 1];
                        score[y + 1] = score[y];
                        score[y] = holdnum;

                        holdname = name[y + 1];
                        name[y + 1] = name[y];
                        name[y] = holdname;
                    }
                }
            }

            listBox1.Items.Add("Name\t\tScore");
            listBox1.Items.Add("");

            for (int x = 0; x < (length / 2); x++)
            {
                string add = name[x] + "\t\t" + score[x];
                listBox1.Items.Add(add);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Startup su = new Startup();
            su.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Startup su = new Startup();
            su.Show();
            this.Close();
        }
    }
}
