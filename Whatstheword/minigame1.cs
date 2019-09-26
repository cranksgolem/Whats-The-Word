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
    public partial class minigame1 : Form
    {
        Form1 main = new Form1();
        int time = 25;
        int score = 0;
        StreamReader sr;
        Random ran = new Random();

        public static bool mgpass = false;
        public minigame1()
        {
            InitializeComponent();
        }

        private void minigame1_Load(object sender, EventArgs e)
        {
            /* For click the verb game */
            if (Form1.gametype == 1)
            {
                DialogResult a = MessageBox.Show("Click on the verb as fast as you can!\nThe words will change every three seconds.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (a == DialogResult.OK)
                {
                    timer3.Enabled = true;
                }

                label6.Text = "CLICK ON THE VERB AS FAST AS YOU CAN!";
                bool exist;
                int num = 0;
                int[] type = new int[3];

                for (int x = 0; x < 3; x++)
                {
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 4);

                        for (int y = 0; y < 3; y++)
                        {
                            if (num == type[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    type[x] = num;
                }

                if (type[0] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[0] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }
                if (type[0] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[1] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[1] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }
                if (type[1] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[2] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }

                if (type[2] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
                if (type[2] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
            }

            //For click the Noun game
            if (Form1.gametype == 2)
            {
                label6.Text = "CLICK ON THE NOUN AS FAST AS YOU CAN!";

                DialogResult a = MessageBox.Show("Click on the noun as fast as you can!\nThe words will change every three seconds.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (a == DialogResult.OK)
                {
                    timer3.Enabled = true;
                }
                bool exist;
                int num = 0;
                int[] type = new int[3];

                for (int x = 0; x < 3; x++)
                {
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 4);

                        for (int y = 0; y < 3; y++)
                        {
                            if (num == type[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    type[x] = num;
                }

                if (type[0] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[0] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }
                if (type[0] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[1] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[1] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }
                if (type[1] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[2] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }

                if (type[2] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
                if (type[2] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
            }

            // For click the Adjective game
            if (Form1.gametype == 3)
            {
                label6.Text = "CLICK ON THE ADJECTIVE AS FAST AS YOU CAN!";
                DialogResult a = MessageBox.Show("Click on the adjective as fast as you can!\nThe words will change every three seconds.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (a == DialogResult.OK)
                {
                    timer3.Enabled = true;
                }
                bool exist;
                int num = 0;
                int[] type = new int[3];

                for (int x = 0; x < 3; x++)
                {
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 4);

                        for (int y = 0; y < 3; y++)
                        {
                            if (num == type[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    type[x] = num;
                }

                if (type[0] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[0] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }
                if (type[0] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[1] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[1] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }
                if (type[1] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[2] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }

                if (type[2] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
                if (type[2] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
            }

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString(score) + "/30";
            label5.Text = Convert.ToString(time);

            if (score == 30)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                mgpass = true;
                MessageBox.Show("Minigame completed! A part of the picture is revealed!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            if (time == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                MessageBox.Show("Minigame failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* For click the verb game */
            if (Form1.gametype == 1)
            {
                sr = new StreamReader(@"Verb.txt");
                bool exist = false;

                for (int x = 1; x <= 100; x++)
                {
                    string word = sr.ReadLine();
                    if (button2.Text == word)
                    {
                        exist = true;
                    }
                }

                if (exist == true)
                {
                    score += 1;
                }
                sr.Close();
            }

            // For click the Noun game
            if (Form1.gametype == 2)
            {
                sr = new StreamReader(@"Noun.txt");
                bool exist = false;

                for (int x = 1; x <= 100; x++)
                {
                    string word = sr.ReadLine();
                    if (button2.Text == word)
                    {
                        exist = true;
                    }
                }

                if (exist == true)
                {
                    score += 1;
                }
                sr.Close();
            }

            // For click the Adjective game
            if (Form1.gametype == 3)
            {
                sr = new StreamReader(@"Adjective.txt");
                bool exist = false;

                for (int x = 1; x <= 100; x++)
                {
                    string word = sr.ReadLine();
                    if (button2.Text == word)
                    {
                        exist = true;
                    }
                }

                if (exist == true)
                {
                    score += 1;
                }
                sr.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* For click the verb game */
            if (Form1.gametype == 1)
            {
                sr = new StreamReader(@"Verb.txt");
                bool exist = false;

                for (int x = 1; x <= 100; x++)
                {
                    string word = sr.ReadLine();
                    if (button1.Text == word)
                    {
                        exist = true;
                    }
                }

                if (exist == true)
                {
                    score += 1;
                }
                sr.Close();
            }
          
            // For click the Noun game
            if (Form1.gametype == 2)
            {
                sr = new StreamReader(@"Noun.txt");
                bool exist = false;

                for (int x = 1; x <= 100; x++)
                {
                    string word = sr.ReadLine();
                    if (button1.Text == word)
                    {
                        exist = true;
                    }
                }

                if (exist == true)
                {
                    score += 1;
                }
                sr.Close();
            }

            // For click the Adjective game
            if (Form1.gametype == 3)
            {
                sr = new StreamReader(@"Adjective.txt");
                bool exist = false;

                for (int x = 1; x <= 100; x++)
                {
                    string word = sr.ReadLine();
                    if (button1.Text == word)
                    {
                        exist = true;
                    }
                }

                if (exist == true)
                {
                    score += 1;
                }
                sr.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* For click the verb game */
            if (Form1.gametype == 1)
            {
                sr = new StreamReader(@"Verb.txt");
                bool exist = false;

                for (int x = 1; x <= 100; x++)
                {
                    string word = sr.ReadLine();
                    if (button3.Text == word)
                    {
                        exist = true;
                    }
                }

                if (exist == true)
                {
                    score += 1;
                }
                sr.Close();
            }

            // For click the Noun game
            if (Form1.gametype == 2)
            {
                sr = new StreamReader(@"Noun.txt");
                bool exist = false;

                for (int x = 1; x <= 100; x++)
                {
                    string word = sr.ReadLine();
                    if (button3.Text == word)
                    {
                        exist = true;
                    }
                }

                if (exist == true)
                {
                    score += 1;
                }
                sr.Close();
            }

            // For click the Adjective game
            if (Form1.gametype == 3)
            {
                sr = new StreamReader(@"Adjective.txt");
                bool exist = false;

                for (int x = 1; x <= 100; x++)
                {
                    string word = sr.ReadLine();
                    if (button3.Text == word)
                    {
                        exist = true;
                    }
                }

                if (exist == true)
                {
                    score += 1;
                }
                sr.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Form1.gametype == 1)
            {
                label6.Text = "CLICK ON THE VERB AS FAST AS YOU CAN!";
                bool exist;
                int num = 0;
                int[] type = new int[3];

                for (int x = 0; x < 3; x++)
                {
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 4);

                        for (int y = 0; y < 3; y++)
                        {
                            if (num == type[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    type[x] = num;
                }

                if (type[0] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[0] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }
                if (type[0] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[1] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[1] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }
                if (type[1] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[2] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }

                if (type[2] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
                if (type[2] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
            }

            if (Form1.gametype == 2)
            {
                label6.Text = "CLICK ON THE NOUN AS FAST AS YOU CAN!";
                bool exist;
                int num = 0;
                int[] type = new int[3];

                for (int x = 0; x < 3; x++)
                {
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 4);

                        for (int y = 0; y < 3; y++)
                        {
                            if (num == type[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    type[x] = num;
                }

                if (type[0] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[0] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }
                if (type[0] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[1] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[1] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }
                if (type[1] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[2] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }

                if (type[2] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
                if (type[2] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
            }

            if (Form1.gametype == 3)
            {
                label6.Text = "CLICK ON THE ADJECTIVE AS FAST AS YOU CAN!";
                bool exist;
                int num = 0;
                int[] type = new int[3];

                for (int x = 0; x < 3; x++)
                {
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 4);

                        for (int y = 0; y < 3; y++)
                        {
                            if (num == type[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    type[x] = num;
                }

                if (type[0] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[0] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }
                if (type[0] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button1.Text = word;
                    sr.Close();
                }

                if (type[1] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[1] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }
                if (type[1] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button2.Text = word;
                    sr.Close();
                }

                if (type[2] == 1)
                {
                    sr = new StreamReader(@"Adjective.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }

                if (type[2] == 2)
                {
                    sr = new StreamReader(@"Noun.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
                if (type[2] == 3)
                {
                    sr = new StreamReader(@"Verb.txt");
                    int index = ran.Next(1, 101);
                    string word = "";

                    for (int x = 1; x <= index; x++)
                    {
                        word = sr.ReadLine();
                    }

                    button3.Text = word;
                    sr.Close();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time -= 1;
        }

    }
}

