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
    public partial class minigame2 : Form
    {
        public static bool mpass = false;
        int time = 7;
        StreamReader srnoun = new StreamReader(@"mgnoun.txt");
        StreamReader srverb = new StreamReader(@"mgverb.txt");
        StreamReader sradj = new StreamReader(@"mgadjective.txt");
        Random ran = new Random();
        string ans1 = "";
        string ans2 = "";
        bool correct = false;
        public minigame2()
        {
            InitializeComponent();
        }

        private void minigame2_Load(object sender, EventArgs e)
        {
            if (Form1.gametype == 5)
            {
                int question = ran.Next(1, 51);

                if (question == 1)
                {
                    label1.Text = srnoun.ReadLine();
                    label2.Text = srnoun.ReadLine();
                }

                else
                {
                    for (int x = 1; x <= (4 * (question - 1)); x++)
                    {
                        srnoun.ReadLine();
                    }

                    label1.Text = srnoun.ReadLine();
                    label2.Text = srnoun.ReadLine();
                }
            }

            if (Form1.gametype == 4)
            {
                int question = ran.Next(1, 51);

                if (question == 1)
                {
                    label1.Text = srverb.ReadLine();
                    label2.Text = srverb.ReadLine();
                }

                else
                {
                    for (int x = 1; x <= (4 * (question - 1)); x++)
                    {
                        srverb.ReadLine();
                    }

                    label1.Text = srverb.ReadLine();
                    label2.Text = srverb.ReadLine();
                }
            }

            if (Form1.gametype == 6)
            {
                int question = ran.Next(1, 51);

                if (question == 1)
                {
                    label1.Text = sradj.ReadLine();
                    label2.Text = sradj.ReadLine();
                }

                else
                {
                    for (int x = 1; x <= (4 * (question - 1)); x++)
                    {
                        sradj.ReadLine();
                    }

                    label1.Text = sradj.ReadLine();
                    label2.Text = sradj.ReadLine();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.gametype == 5)
            {
                ans1 = srnoun.ReadLine();
                ans2 = srnoun.ReadLine();
                srnoun.Close();
                if (ans2 == "")
                {
                    if (textBox1.Text == ans1)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        mpass = true;
                        MessageBox.Show("Correct answer! A part of the picture is revealed!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        MessageBox.Show("Wrong answer!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }

                else
                {
                    if (textBox1.Text == ans1 || textBox1.Text == ans2)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        mpass = true;
                        MessageBox.Show("Correct answer!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        MessageBox.Show("Wrong answer!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
            }

            if (Form1.gametype == 4)
            {
                ans1 = srverb.ReadLine();
                ans2 = srverb.ReadLine();

                srverb.Close();

                if (ans2 == "")
                {
                    if (textBox1.Text == ans1)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        mpass = true;
                        MessageBox.Show("Correct answer! A part of the picture is revealed!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        MessageBox.Show("Wrong answer!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }

                else
                {
                    if (textBox1.Text == ans1 || textBox1.Text == ans2)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        mpass = true;
                        MessageBox.Show("Correct answer! A part of the picture is revealed!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        MessageBox.Show("Wrong answer!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
            }

            if (Form1.gametype == 6)
            {
                ans1 = sradj.ReadLine();
                ans2 = sradj.ReadLine();

                sradj.Close();

                if (ans2 == "")
                {
                    if (textBox1.Text == ans1)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        mpass = true;
                        MessageBox.Show("Correct answer! A part of the picture is revealed!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        MessageBox.Show("Wrong answer!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }

                else
                {
                    if (textBox1.Text == ans1 || textBox1.Text == ans2)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        mpass = true;
                        MessageBox.Show("Correct answer! A part of the picture is revealed!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    else
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        MessageBox.Show("Wrong answer!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(time);
            
            if (time == 0)
            {
                if (Form1.gametype == 5)
                {
                    ans1 = srnoun.ReadLine();
                    ans2 = srnoun.ReadLine();
                    srnoun.Close();
                }

                if (Form1.gametype == 4)
                {
                    ans1 = srverb.ReadLine();
                    ans2 = srverb.ReadLine();
                    srverb.Close();
                }

                if (Form1.gametype == 6)
                {
                    ans1 = sradj.ReadLine();
                    ans2 = sradj.ReadLine();
                    sradj.Close();
                }

                if (ans2 == "")
                {
                    if (textBox1.Text == ans1)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        mpass = true;
                        correct = true;
                        MessageBox.Show("Correct answer! A part of the picture is revealed!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

                else
                {
                    if (textBox1.Text == ans1 || textBox1.Text == ans2)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        mpass = true;
                        correct = true;
                        MessageBox.Show("Correct answer! A part of the picture is revealed!", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

            if (time == 0 && correct == false)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                MessageBox.Show("Minigame failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time -= 1;
        }
    }
}
