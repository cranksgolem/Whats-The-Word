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
    public partial class Form1 : Form
    {
        int revealcount = 1;
        int scoretoadd = 0;
        public static int score = 0;
        int gamemode = 0;
        int gamecount = 0;
        int gamenum = 0;
        int chance = 3;
        int[] easygames = new int[20];
        int[] mediumgames = new int[20];
        int[] hardgames = new int[20];
        int[] picreveal = new int[9];
        Image[] ime = new Image[80];
        Image[] imm = new Image[120];
        Image[] imh = new Image[180];
        public static int gametype;
        StreamReader sr;
        Random ran = new Random();
        string word = "BANANA";
        int wordposition = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score = 0;
            gamemode = 0;
            gamecount = 0;
            gamenum = 0;
            revealcount = 1;
            scoretoadd = 0;
            Array.Clear(easygames, 0, easygames.Length);
            Array.Clear(mediumgames, 0, mediumgames.Length);
            Array.Clear(hardgames, 0, hardgames.Length);
            Array.Clear(picreveal, 0, picreveal.Length);
            label2.Hide();
            pictureBox22.Parent = pictureBox21;
            pictureBox22.BackColor = Color.Transparent;

            pictureBox20.Parent = pictureBox21;
            pictureBox20.BackColor = Color.Transparent;

            pictureBox24.Parent = pictureBox21;
            pictureBox24.BackColor = Color.Transparent;

            pictureBox25.Parent = pictureBox21;
            pictureBox25.BackColor = Color.Transparent;

            pictureBox26.Parent = pictureBox21;
            pictureBox26.BackColor = Color.Transparent;
            pictureBox26.Image = Image.FromFile(@"easy.gif");
            pictureBox26.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox23.Parent = pictureBox21;
            pictureBox23.BackColor = Color.Transparent;
            pictureBox23.Image = Image.FromFile(@"chance3.gif");

            linkLabel1.Parent = pictureBox21;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel2.Parent = pictureBox21;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel3.Parent = pictureBox21;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel4.Parent = pictureBox21;
            linkLabel4.BackColor = Color.Transparent;
            linkLabel5.Parent = pictureBox21;
            linkLabel5.BackColor = Color.Transparent;
            linkLabel6.Parent = pictureBox21;
            linkLabel6.BackColor = Color.Transparent;
            linkLabel7.Parent = pictureBox21;
            linkLabel7.BackColor = Color.Transparent;
            linkLabel8.Parent = pictureBox21;
            linkLabel8.BackColor = Color.Transparent;

            label6.Parent = pictureBox21;
            label6.BackColor = Color.Transparent;

            button11.Parent = pictureBox21;
            button11.BackColor = Color.Transparent;

            button1.Parent = pictureBox21;
            button1.BackColor = Color.Transparent;
            button2.Parent = pictureBox21;
            button2.BackColor = Color.Transparent;
            button3.Parent = pictureBox21;
            button3.BackColor = Color.Transparent;
            button4.Parent = pictureBox21;
            button4.BackColor = Color.Transparent;
            button5.Parent = pictureBox21;
            button5.BackColor = Color.Transparent;
            button6.Parent = pictureBox21;
            button6.BackColor = Color.Transparent;
            button7.Parent = pictureBox21;
            button7.BackColor = Color.Transparent;
            button8.Parent = pictureBox21;
            button8.BackColor = Color.Transparent;
            button9.Parent = pictureBox21;
            button9.BackColor = Color.Transparent;
            button10.Parent = pictureBox21;
            button10.BackColor = Color.Transparent;
            button12.Parent = pictureBox21;
            button12.BackColor = Color.Transparent;
            button13.Parent = pictureBox21;
            button13.BackColor = Color.Transparent;
            button14.Parent = pictureBox21;
            button14.BackColor = Color.Transparent;
            button15.Parent = pictureBox21;
            button15.BackColor = Color.Transparent;
            button16.Parent = pictureBox21;
            button16.BackColor = Color.Transparent;

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            scoretoadd = 5;

            // Fixes the UI
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;
            linkLabel8.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;

            // Selects which picturebox to display first (randomly)
            int initialreveal = ran.Next(1, 5);

            if (initialreveal == 1)
            {
                pictureBox1.Visible = true;
                picreveal[0] = initialreveal;
            }

            else if (initialreveal == 2)
            {
                pictureBox2.Visible = true;
                picreveal[0] = initialreveal;
            }

            else if (initialreveal == 3)
            {
                pictureBox3.Visible = true;
                picreveal[0] = initialreveal;
            }

            else
            {
                pictureBox4.Visible = true;
                picreveal[0] = initialreveal;
            }


            // Stores easy pics in the array
            ime[0] = Image.FromFile(@"APPLE\1.jpg");
            ime[1] = Image.FromFile(@"APPLE\2.jpg");
            ime[2] = Image.FromFile(@"APPLE\3.jpg");
            ime[3] = Image.FromFile(@"APPLE\4.jpg");
            ime[4] = Image.FromFile(@"BANANA\1.jpg");
            ime[5] = Image.FromFile(@"BANANA\2.jpg");
            ime[6] = Image.FromFile(@"BANANA\3.jpg");
            ime[7] = Image.FromFile(@"BANANA\4.jpg");
            ime[8] = Image.FromFile(@"BOTTLE\1.jpg");
            ime[9] = Image.FromFile(@"BOTTLE\2.jpg");
            ime[10] = Image.FromFile(@"BOTTLE\3.jpg");
            ime[11] = Image.FromFile(@"BOTTLE\4.jpg");
            ime[12] = Image.FromFile(@"CAMERA\1.jpg");
            ime[13] = Image.FromFile(@"CAMERA\2.jpg");
            ime[14] = Image.FromFile(@"CAMERA\3.jpg");
            ime[15] = Image.FromFile(@"CAMERA\4.jpg");
            ime[16] = Image.FromFile(@"CANDY\1.jpg");
            ime[17] = Image.FromFile(@"CANDY\2.jpg");
            ime[18] = Image.FromFile(@"CANDY\3.jpg");
            ime[19] = Image.FromFile(@"CANDY\4.jpg");
            ime[20] = Image.FromFile(@"CHICKEN\1.jpg");
            ime[21] = Image.FromFile(@"CHICKEN\2.jpg");
            ime[22] = Image.FromFile(@"CHICKEN\3.jpg");
            ime[23] = Image.FromFile(@"CHICKEN\4.jpg");
            ime[24] = Image.FromFile(@"CLOCK\1.jpg");
            ime[25] = Image.FromFile(@"CLOCK\2.jpg");
            ime[26] = Image.FromFile(@"CLOCK\3.jpg");
            ime[27] = Image.FromFile(@"CLOCK\4.jpg");
            ime[28] = Image.FromFile(@"DOOR\1.jpg");
            ime[29] = Image.FromFile(@"DOOR\2.jpg");
            ime[30] = Image.FromFile(@"DOOR\3.jpg");
            ime[31] = Image.FromFile(@"DOOR\4.jpg");
            ime[32] = Image.FromFile(@"EYE\1.jpg");
            ime[33] = Image.FromFile(@"EYE\2.jpg");
            ime[34] = Image.FromFile(@"EYE\3.jpg");
            ime[35] = Image.FromFile(@"EYE\4.jpg");
            ime[36] = Image.FromFile(@"FIRE\1.jpg");
            ime[37] = Image.FromFile(@"FIRE\2.jpg");
            ime[38] = Image.FromFile(@"FIRE\3.jpg");
            ime[39] = Image.FromFile(@"FIRE\4.jpg");
            ime[40] = Image.FromFile(@"FLOWER\1.jpg");
            ime[41] = Image.FromFile(@"FLOWER\2.jpg");
            ime[42] = Image.FromFile(@"FLOWER\3.jpg");
            ime[43] = Image.FromFile(@"FLOWER\4.jpg");
            ime[44] = Image.FromFile(@"GUITAR\1.jpg");
            ime[45] = Image.FromFile(@"GUITAR\2.jpg");
            ime[46] = Image.FromFile(@"GUITAR\3.jpg");
            ime[47] = Image.FromFile(@"GUITAR\4.jpg");
            ime[48] = Image.FromFile(@"HOUSE\1.jpg");
            ime[49] = Image.FromFile(@"HOUSE\2.jpg");
            ime[50] = Image.FromFile(@"HOUSE\3.jpg");
            ime[51] = Image.FromFile(@"HOUSE\4.jpg");
            ime[52] = Image.FromFile(@"MALL\1.jpg");
            ime[53] = Image.FromFile(@"MALL\2.jpg");
            ime[54] = Image.FromFile(@"MALL\3.jpg");
            ime[55] = Image.FromFile(@"MALL\4.jpg");
            ime[56] = Image.FromFile(@"ORANGE\1.jpg");
            ime[57] = Image.FromFile(@"ORANGE\2.jpg");
            ime[58] = Image.FromFile(@"ORANGE\3.jpg");
            ime[59] = Image.FromFile(@"ORANGE\4.jpg");
            ime[60] = Image.FromFile(@"PIZZA\1.jpg");
            ime[61] = Image.FromFile(@"PIZZA\2.jpg");
            ime[62] = Image.FromFile(@"PIZZA\3.jpg");
            ime[63] = Image.FromFile(@"PIZZA\4.jpg");
            ime[64] = Image.FromFile(@"POTATO\1.jpg");
            ime[65] = Image.FromFile(@"POTATO\2.jpg");
            ime[66] = Image.FromFile(@"POTATO\3.jpg");
            ime[67] = Image.FromFile(@"POTATO\4.jpg");
            ime[68] = Image.FromFile(@"RIVER\1.jpg");
            ime[69] = Image.FromFile(@"RIVER\2.jpg");
            ime[70] = Image.FromFile(@"RIVER\3.jpg");
            ime[71] = Image.FromFile(@"RIVER\4.jpg");
            ime[72] = Image.FromFile(@"TONGUE\1.jpg");
            ime[73] = Image.FromFile(@"TONGUE\2.jpg");
            ime[74] = Image.FromFile(@"TONGUE\3.jpg");
            ime[75] = Image.FromFile(@"TONGUE\4.jpg");
            ime[76] = Image.FromFile(@"WATER\1.jpg");
            ime[77] = Image.FromFile(@"WATER\2.jpg");
            ime[78] = Image.FromFile(@"WATER\3.jpg");
            ime[79] = Image.FromFile(@"WATER\4.jpg");

            //Generates the number of the picture
            int n = 0;
            bool exist = false;
            do
            {
                exist = false;

                n = ran.Next(1, 21);

                for (int y = 0; y < 20; y++)
                {
                    if (n == easygames[y])
                    {
                        exist = true;
                    }
                }
            }
            while (exist == true);

            easygames[gamecount] = n;
            gamecount++;
            gamenum++;

            int i = (n - 1) * 4;
            pictureBox1.Image = ime[i];
            pictureBox2.Image = ime[i + 1];
            pictureBox3.Image = ime[i + 2];
            pictureBox4.Image = ime[i + 3];



            /*Generates the random word*/
            sr = new StreamReader(@"easy.txt");

            for (int x = 1; x <= n; x++)
            {
                word = sr.ReadLine();
                word = word.ToUpper();
            }


            /* Generates the number of underscores displayed*/
            label1.Text = "";
            for (int x = 0; x < word.Length * 2; x++)
            {
                if (x % 2 == 0)
                {
                    label1.Text += "_";
                }

                else
                {
                    label1.Text += " ";
                }
            }

            /* Generates the choice letters*/

            int[] letbox = new int[15];
            char[] wordd = new char[word.Length];
            wordd = word.ToCharArray(0, word.Length);
            char[] alpha = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int num = 0;
            exist = false;

            for (int x = 0; x < 15; x++)
            {
                do
                {
                    exist = false;

                    num = ran.Next(1, 16);

                    for (int y = 0; y < 15; y++)
                    {
                        if (num == letbox[y])
                        {
                            exist = true;
                        }
                    }
                }
                while (exist == true);

                if (num == 1)
                {
                    if (x < word.Length)
                    {
                        button1.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button1.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 2)
                {
                    if (x < word.Length)
                    {
                        button2.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button2.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 3)
                {
                    if (x < word.Length)
                    {
                        button3.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button3.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 4)
                {
                    if (x < word.Length)
                    {
                        button4.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button4.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 5)
                {
                    if (x < word.Length)
                    {
                        button5.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button5.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 6)
                {
                    if (x < word.Length)
                    {
                        button6.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button6.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 7)
                {
                    if (x < word.Length)
                    {
                        button7.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button7.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 8)
                {
                    if (x < word.Length)
                    {
                        button8.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button8.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 9)
                {
                    if (x < word.Length)
                    {
                        button9.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button9.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 10)
                {
                    if (x < word.Length)
                    {
                        button10.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button10.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 11)
                {
                    if (x < word.Length)
                    {
                        button12.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button12.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 12)
                {
                    if (x < word.Length)
                    {
                        button13.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button13.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 13)
                {
                    if (x < word.Length)
                    {
                        button14.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button14.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 14)
                {
                    if (x < word.Length)
                    {
                        button15.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button15.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }

                if (num == 15)
                {
                    if (x < word.Length)
                    {
                        button16.Text = Convert.ToString(wordd[x]);
                        letbox[x] = num;
                    }

                    else
                    {
                        int alph = ran.Next(0, 26);
                        button16.Text = Convert.ToString(alpha[alph]);
                        letbox[x] = num;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button1.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button1.Text + part2;
                wordposition += 2;
            }

            button1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button2.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button2.Text + part2;
                wordposition += 2;
            }

            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button3.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button3.Text + part2;
                wordposition += 2;
            }
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button4.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button4.Text + part2;
                wordposition += 2;
            }

            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button5.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button5.Text + part2;
                wordposition += 2;
            }

            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button6.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button6.Text + part2;
                wordposition += 2;
            }
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button7.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button7.Text + part2;
                wordposition += 2;
            }

            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button8.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button8.Text + part2;
                wordposition += 2;
            }

            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button9.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button9.Text + part2;
                wordposition += 2;
            }

            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button10.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button10.Text + part2;
                wordposition += 2;
            }

            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int x = 0; x < word.Length * 2; x++)
            {
                if (x % 2 == 0)
                {
                    label1.Text += "_";
                }

                else
                {
                    label1.Text += " ";
                }
            }

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            wordposition = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = Convert.ToString(score);
            int n = 0;
            bool exist;

            if (chance == 0)
            {
                timer1.Enabled = false;
                if (gamemode == 0)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                }

                if (gamemode == 1)
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = true;
                }

                if (gamemode == 2)
                {
                    pictureBox11.Visible = true;
                    pictureBox12.Visible = true;
                    pictureBox13.Visible = true;
                    pictureBox14.Visible = true;
                    pictureBox15.Visible = true;
                    pictureBox16.Visible = true;
                    pictureBox17.Visible = true;
                    pictureBox18.Visible = true;
                    pictureBox19.Visible = true;
                }

                label1.Hide();
                label2.Show();
                label2.Text = word;
                MessageBox.Show("You ran out of chances!\nGame over!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ScoreEnter se = new ScoreEnter();
                se.Show();
                this.Hide();
            }
            
            if (gamenum == 35)
            {
                timer1.Enabled = false;
                MessageBox.Show("Congratulations! You beat the game!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ScoreEnter se = new ScoreEnter();
                se.Show();
                this.Hide();
            }

            if (gamenum == 6)
            {
                timer1.Enabled = false;
                DialogResult an = MessageBox.Show("Would you like to skip to the next difficulty?\nPoints to be acquired in the next 5 pictures will be lost!", "Difficulty Skip", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (an == DialogResult.Yes)
                {
                    gamenum += 6;
                }

                if (an == DialogResult.No)
                {
                    gamenum += 1;
                }
                timer1.Enabled = true;
            }

            if (gamenum == 18)
            {
                timer1.Enabled = false;
                DialogResult an = MessageBox.Show("Would you like to skip to the next difficulty?\nPoints to be acquired in the next 5 pictures will be lost!", "Difficulty Skip", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (an == DialogResult.Yes)
                {
                    gamenum += 6;
                }

                if (an == DialogResult.No)
                {
                    gamenum += 1;
                }
                timer1.Enabled = true;
            }

            // Loads medium mode
            if (gamenum == 12)
            {
                timer1.Enabled = false;
                MessageBox.Show("Difficulty is now at Medium!", "Difficulty Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Enabled = true;
                gamemode++;
                gamecount = 0;
                chance = 3;
                timer2.Enabled = true;
                scoretoadd = 7;
                pictureBox26.Image = Image.FromFile(@"medium.gif");

                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
                linkLabel3.Visible = true;
                linkLabel4.Visible = true;
                linkLabel8.Visible = true;

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                // Selects which picturebox to display first (randomly)
                revealcount = 1;
                int initialreveal = ran.Next(5, 11);

                if (initialreveal == 5)
                {
                    pictureBox5.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 6)
                {
                    pictureBox6.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 7)
                {
                    pictureBox7.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 8)
                {
                    pictureBox8.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 9)
                {
                    pictureBox9.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 10)
                {
                    pictureBox10.Visible = true;
                    picreveal[0] = initialreveal;
                }

                imm[0] = Image.FromFile(@"AIRPORT\1.jpg");
                imm[1] = Image.FromFile(@"AIRPORT\2.jpg");
                imm[2] = Image.FromFile(@"AIRPORT\3.jpg");
                imm[3] = Image.FromFile(@"AIRPORT\4.jpg");
                imm[4] = Image.FromFile(@"AIRPORT\5.jpg");
                imm[5] = Image.FromFile(@"AIRPORT\6.jpg");
                imm[6] = Image.FromFile(@"BICYCLE\1.jpg");
                imm[7] = Image.FromFile(@"BICYCLE\2.jpg");
                imm[8] = Image.FromFile(@"BICYCLE\3.jpg");
                imm[9] = Image.FromFile(@"BICYCLE\4.jpg");
                imm[10] = Image.FromFile(@"BICYCLE\5.jpg");
                imm[11] = Image.FromFile(@"BICYCLE\6.jpg");
                imm[12] = Image.FromFile(@"CANDLE\1.jpg");
                imm[13] = Image.FromFile(@"CANDLE\2.jpg");
                imm[14] = Image.FromFile(@"CANDLE\3.jpg");
                imm[15] = Image.FromFile(@"CANDLE\4.jpg");
                imm[16] = Image.FromFile(@"CANDLE\5.jpg");
                imm[17] = Image.FromFile(@"CANDLE\6.jpg");
                imm[18] = Image.FromFile(@"CHOCOLATE\1.jpg");
                imm[19] = Image.FromFile(@"CHOCOLATE\2.jpg");
                imm[20] = Image.FromFile(@"CHOCOLATE\3.jpg");
                imm[21] = Image.FromFile(@"CHOCOLATE\4.jpg");
                imm[22] = Image.FromFile(@"CHOCOLATE\5.jpg");
                imm[23] = Image.FromFile(@"CHOCOLATE\6.jpg");
                imm[24] = Image.FromFile(@"CLOTHES\1.jpg");
                imm[25] = Image.FromFile(@"CLOTHES\2.jpg");
                imm[26] = Image.FromFile(@"CLOTHES\3.jpg");
                imm[27] = Image.FromFile(@"CLOTHES\4.jpg");
                imm[28] = Image.FromFile(@"CLOTHES\5.jpg");
                imm[29] = Image.FromFile(@"CLOTHES\6.jpg");
                imm[30] = Image.FromFile(@"CROCODILE\1.jpg");
                imm[31] = Image.FromFile(@"CROCODILE\2.jpg");
                imm[32] = Image.FromFile(@"CROCODILE\3.jpg");
                imm[33] = Image.FromFile(@"CROCODILE\4.jpg");
                imm[34] = Image.FromFile(@"CROCODILE\5.jpg");
                imm[35] = Image.FromFile(@"CROCODILE\6.jpg");
                imm[36] = Image.FromFile(@"DIAMOND\1.jpg");
                imm[37] = Image.FromFile(@"DIAMOND\2.jpg");
                imm[38] = Image.FromFile(@"DIAMOND\3.jpg");
                imm[39] = Image.FromFile(@"DIAMOND\4.jpg");
                imm[40] = Image.FromFile(@"DIAMOND\5.jpg");
                imm[41] = Image.FromFile(@"DIAMOND\6.jpg");
                imm[42] = Image.FromFile(@"DOCTOR\1.jpg");
                imm[43] = Image.FromFile(@"DOCTOR\2.jpg");
                imm[44] = Image.FromFile(@"DOCTOR\3.jpg");
                imm[45] = Image.FromFile(@"DOCTOR\4.jpg");
                imm[46] = Image.FromFile(@"DOCTOR\5.jpg");
                imm[47] = Image.FromFile(@"DOCTOR\6.jpg");
                imm[48] = Image.FromFile(@"EAGLE\1.jpg");
                imm[49] = Image.FromFile(@"EAGLE\2.jpg");
                imm[50] = Image.FromFile(@"EAGLE\3.jpg");
                imm[51] = Image.FromFile(@"EAGLE\4.jpg");
                imm[52] = Image.FromFile(@"EAGLE\5.jpg");
                imm[53] = Image.FromFile(@"EAGLE\6.jpg");
                imm[54] = Image.FromFile(@"GOLD\1.jpg");
                imm[55] = Image.FromFile(@"GOLD\2.jpg");
                imm[56] = Image.FromFile(@"GOLD\3.jpg");
                imm[57] = Image.FromFile(@"GOLD\4.jpg");
                imm[58] = Image.FromFile(@"GOLD\5.jpg");
                imm[59] = Image.FromFile(@"GOLD\6.jpg");
                imm[60] = Image.FromFile(@"ISLAND\1.jpg");
                imm[61] = Image.FromFile(@"ISLAND\2.jpg");
                imm[62] = Image.FromFile(@"ISLAND\3.jpg");
                imm[63] = Image.FromFile(@"ISLAND\4.jpg");
                imm[64] = Image.FromFile(@"ISLAND\5.jpg");
                imm[65] = Image.FromFile(@"ISLAND\6.jpg");
                imm[66] = Image.FromFile(@"MONEY\1.jpg");
                imm[67] = Image.FromFile(@"MONEY\2.jpg");
                imm[68] = Image.FromFile(@"MONEY\3.jpg");
                imm[69] = Image.FromFile(@"MONEY\4.jpg");
                imm[70] = Image.FromFile(@"MONEY\5.jpg");
                imm[71] = Image.FromFile(@"MONEY\6.jpg");
                imm[72] = Image.FromFile(@"MONKEY\1.jpg");
                imm[73] = Image.FromFile(@"MONKEY\2.jpg");
                imm[74] = Image.FromFile(@"MONKEY\3.jpg");
                imm[75] = Image.FromFile(@"MONKEY\4.jpg");
                imm[76] = Image.FromFile(@"MONKEY\5.jpg");
                imm[77] = Image.FromFile(@"MONKEY\6.jpg");
                imm[78] = Image.FromFile(@"MOON\1.jpg");
                imm[79] = Image.FromFile(@"MOON\2.jpg");
                imm[80] = Image.FromFile(@"MOON\3.jpg");
                imm[81] = Image.FromFile(@"MOON\4.jpg");
                imm[82] = Image.FromFile(@"MOON\5.jpg");
                imm[83] = Image.FromFile(@"MOON\6.jpg");
                imm[84] = Image.FromFile(@"NEWSPAPER\1.jpg");
                imm[85] = Image.FromFile(@"NEWSPAPER\2.jpg");
                imm[86] = Image.FromFile(@"NEWSPAPER\3.jpg");
                imm[87] = Image.FromFile(@"NEWSPAPER\4.jpg");
                imm[88] = Image.FromFile(@"NEWSPAPER\5.jpg");
                imm[89] = Image.FromFile(@"NEWSPAPER\6.jpg");
                imm[90] = Image.FromFile(@"PANDA\1.jpg");
                imm[91] = Image.FromFile(@"PANDA\2.jpg");
                imm[92] = Image.FromFile(@"PANDA\3.jpg");
                imm[93] = Image.FromFile(@"PANDA\4.jpg");
                imm[94] = Image.FromFile(@"PANDA\5.jpg");
                imm[95] = Image.FromFile(@"PANDA\6.jpg");
                imm[96] = Image.FromFile(@"PIANO\1.jpg");
                imm[97] = Image.FromFile(@"PIANO\2.jpg");
                imm[98] = Image.FromFile(@"PIANO\3.jpg");
                imm[99] = Image.FromFile(@"PIANO\4.jpg");
                imm[100] = Image.FromFile(@"PIANO\5.jpg");
                imm[101] = Image.FromFile(@"PIANO\6.jpg");
                imm[102] = Image.FromFile(@"SILVER\1.jpg");
                imm[103] = Image.FromFile(@"SILVER\2.jpg");
                imm[104] = Image.FromFile(@"SILVER\3.jpg");
                imm[105] = Image.FromFile(@"SILVER\4.jpg");
                imm[106] = Image.FromFile(@"SILVER\5.jpg");
                imm[107] = Image.FromFile(@"SILVER\6.jpg");
                imm[108] = Image.FromFile(@"TELEVISION\1.jpg");
                imm[109] = Image.FromFile(@"TELEVISION\2.jpg");
                imm[110] = Image.FromFile(@"TELEVISION\3.jpg");
                imm[111] = Image.FromFile(@"TELEVISION\4.jpg");
                imm[112] = Image.FromFile(@"TELEVISION\5.jpg");
                imm[113] = Image.FromFile(@"TELEVISION\6.jpg");
                imm[114] = Image.FromFile(@"VIOLIN\1.jpg");
                imm[115] = Image.FromFile(@"VIOLIN\2.jpg");
                imm[116] = Image.FromFile(@"VIOLIN\3.jpg");
                imm[117] = Image.FromFile(@"VIOLIN\4.jpg");
                imm[118] = Image.FromFile(@"VIOLIN\5.jpg");
                imm[119] = Image.FromFile(@"VIOLIN\6.jpg");


                n = 0;
                exist = false;
                do
                {
                    exist = false;

                    n = ran.Next(1, 21);

                    for (int y = 0; y < 20; y++)
                    {
                        if (n == mediumgames[y])
                        {
                            exist = true;
                        }
                    }
                }
                while (exist == true);

                mediumgames[gamecount] = n;
                gamecount++;
                gamenum++;

                int i = (n - 1) * 6;
                pictureBox5.Image = imm[i];
                pictureBox6.Image = imm[i + 1];
                pictureBox7.Image = imm[i + 2];
                pictureBox8.Image = imm[i + 3];
                pictureBox9.Image = imm[i + 4];
                pictureBox10.Image = imm[i + 5];

                // Generate new random word
                sr = new StreamReader(@"medium.txt");

                for (int x = 1; x <= n; x++)
                {
                    word = sr.ReadLine();
                    word = word.ToUpper();
                }


                // Generate underscores
                label1.Text = "";
                for (int x = 0; x < word.Length * 2; x++)
                {
                    if (x % 2 == 0)
                    {
                        label1.Text += "_";
                    }

                    else
                    {
                        label1.Text += " ";
                    }
                }

                // Generate choice letters
                int[] letbox = new int[15];
                char[] wordd = new char[word.Length];
                wordd = word.ToCharArray(0, word.Length);
                char[] alpha = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                int num = 0;
                exist = false;

                for (int x = 0; x < 15; x++)
                {
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 16);

                        for (int y = 0; y < 15; y++)
                        {
                            if (num == letbox[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    if (num == 1)
                    {
                        if (x < word.Length)
                        {
                            button1.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button1.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 2)
                    {
                        if (x < word.Length)
                        {
                            button2.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button2.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 3)
                    {
                        if (x < word.Length)
                        {
                            button3.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button3.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 4)
                    {
                        if (x < word.Length)
                        {
                            button4.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button4.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 5)
                    {
                        if (x < word.Length)
                        {
                            button5.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button5.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 6)
                    {
                        if (x < word.Length)
                        {
                            button6.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button6.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 7)
                    {
                        if (x < word.Length)
                        {
                            button7.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button7.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 8)
                    {
                        if (x < word.Length)
                        {
                            button8.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button8.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 9)
                    {
                        if (x < word.Length)
                        {
                            button9.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button9.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 10)
                    {
                        if (x < word.Length)
                        {
                            button10.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button10.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 11)
                    {
                        if (x < word.Length)
                        {
                            button12.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button12.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 12)
                    {
                        if (x < word.Length)
                        {
                            button13.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button13.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 13)
                    {
                        if (x < word.Length)
                        {
                            button14.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button14.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 14)
                    {
                        if (x < word.Length)
                        {
                            button15.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button15.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 15)
                    {
                        if (x < word.Length)
                        {
                            button16.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button16.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                }

                label1.Text = "";
                for (int x = 0; x < word.Length * 2; x++)
                {
                    if (x % 2 == 0)
                    {
                        label1.Text += "_";
                    }

                    else
                    {
                        label1.Text += " ";
                    }
                }

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
                wordposition = 0;
                timer1.Enabled = true;
            }


            // Loads hard mode
            if (gamenum == 24)
            {
                timer1.Enabled = false;
                MessageBox.Show("Difficulty is now at Hard!", "Difficulty Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer1.Enabled = true;
                gamemode++;
                gamecount = 0;
                scoretoadd = 10;
                chance = 3;
                timer2.Enabled = true;
                pictureBox26.Image = Image.FromFile(@"hard.gif");

                imh[0] = Image.FromFile(@"AFRO\1.jpg");
                imh[1] = Image.FromFile(@"AFRO\2.jpg");
                imh[2] = Image.FromFile(@"AFRO\3.jpg");
                imh[3] = Image.FromFile(@"AFRO\4.jpg");
                imh[4] = Image.FromFile(@"AFRO\5.jpg");
                imh[5] = Image.FromFile(@"AFRO\6.jpg");
                imh[6] = Image.FromFile(@"AFRO\7.jpg");
                imh[7] = Image.FromFile(@"AFRO\8.jpg");
                imh[8] = Image.FromFile(@"AFRO\9.jpg");
                imh[9] = Image.FromFile(@"BARTENDER\1.jpg");
                imh[10] = Image.FromFile(@"BARTENDER\2.jpg");
                imh[11] = Image.FromFile(@"BARTENDER\3.jpg");
                imh[12] = Image.FromFile(@"BARTENDER\4.jpg");
                imh[13] = Image.FromFile(@"BARTENDER\5.jpg");
                imh[14] = Image.FromFile(@"BARTENDER\6.jpg");
                imh[15] = Image.FromFile(@"BARTENDER\7.jpg");
                imh[16] = Image.FromFile(@"BARTENDER\8.jpg");
                imh[17] = Image.FromFile(@"BARTENDER\9.jpg");
                imh[18] = Image.FromFile(@"BASKETBALL\1.jpg");
                imh[19] = Image.FromFile(@"BASKETBALL\2.jpg");
                imh[20] = Image.FromFile(@"BASKETBALL\3.jpg");
                imh[21] = Image.FromFile(@"BASKETBALL\4.jpg");
                imh[22] = Image.FromFile(@"BASKETBALL\5.jpg");
                imh[23] = Image.FromFile(@"BASKETBALL\6.jpg");
                imh[24] = Image.FromFile(@"BASKETBALL\7.jpg");
                imh[25] = Image.FromFile(@"BASKETBALL\8.jpg");
                imh[26] = Image.FromFile(@"BASKETBALL\9.jpg");
                imh[27] = Image.FromFile(@"BLOWTORCH\1.jpg");
                imh[28] = Image.FromFile(@"BLOWTORCH\2.jpg");
                imh[29] = Image.FromFile(@"BLOWTORCH\3.jpg");
                imh[30] = Image.FromFile(@"BLOWTORCH\4.jpg");
                imh[31] = Image.FromFile(@"BLOWTORCH\5.jpg");
                imh[32] = Image.FromFile(@"BLOWTORCH\6.jpg");
                imh[33] = Image.FromFile(@"BLOWTORCH\7.jpg");
                imh[34] = Image.FromFile(@"BLOWTORCH\8.jpg");
                imh[35] = Image.FromFile(@"BLOWTORCH\9.jpg");
                imh[36] = Image.FromFile(@"CLASSROOM\1.jpg");
                imh[37] = Image.FromFile(@"CLASSROOM\2.jpg");
                imh[38] = Image.FromFile(@"CLASSROOM\3.jpg");
                imh[39] = Image.FromFile(@"CLASSROOM\4.jpg");
                imh[40] = Image.FromFile(@"CLASSROOM\5.jpg");
                imh[41] = Image.FromFile(@"CLASSROOM\6.jpg");
                imh[42] = Image.FromFile(@"CLASSROOM\7.jpg");
                imh[43] = Image.FromFile(@"CLASSROOM\8.jpg");
                imh[44] = Image.FromFile(@"CLASSROOM\9.jpg");
                imh[45] = Image.FromFile(@"CHRISTMAS\1.jpg");
                imh[46] = Image.FromFile(@"CHRISTMAS\2.jpg");
                imh[47] = Image.FromFile(@"CHRISTMAS\3.jpg");
                imh[48] = Image.FromFile(@"CHRISTMAS\4.jpg");
                imh[49] = Image.FromFile(@"CHRISTMAS\5.jpg");
                imh[50] = Image.FromFile(@"CHRISTMAS\6.jpg");
                imh[51] = Image.FromFile(@"CHRISTMAS\7.jpg");
                imh[52] = Image.FromFile(@"CHRISTMAS\8.jpg");
                imh[53] = Image.FromFile(@"CHRISTMAS\9.jpg");
                imh[54] = Image.FromFile(@"COMPUTER\1.jpg");
                imh[55] = Image.FromFile(@"COMPUTER\2.jpg");
                imh[56] = Image.FromFile(@"COMPUTER\3.jpg");
                imh[57] = Image.FromFile(@"COMPUTER\4.jpg");
                imh[58] = Image.FromFile(@"COMPUTER\5.jpg");
                imh[59] = Image.FromFile(@"COMPUTER\6.jpg");
                imh[60] = Image.FromFile(@"COMPUTER\7.jpg");
                imh[61] = Image.FromFile(@"COMPUTER\8.jpg");
                imh[62] = Image.FromFile(@"COMPUTER\9.jpg");
                imh[63] = Image.FromFile(@"FOOTBALL\1.jpg");
                imh[64] = Image.FromFile(@"FOOTBALL\2.jpg");
                imh[65] = Image.FromFile(@"FOOTBALL\3.jpg");
                imh[66] = Image.FromFile(@"FOOTBALL\4.jpg");
                imh[67] = Image.FromFile(@"FOOTBALL\5.jpg");
                imh[68] = Image.FromFile(@"FOOTBALL\6.jpg");
                imh[69] = Image.FromFile(@"FOOTBALL\7.jpg");
                imh[70] = Image.FromFile(@"FOOTBALL\8.jpg");
                imh[71] = Image.FromFile(@"FOOTBALL\9.jpg");
                imh[72] = Image.FromFile(@"HELICOPTER\1.jpg");
                imh[73] = Image.FromFile(@"HELICOPTER\2.jpg");
                imh[74] = Image.FromFile(@"HELICOPTER\3.jpg");
                imh[75] = Image.FromFile(@"HELICOPTER\4.jpg");
                imh[76] = Image.FromFile(@"HELICOPTER\5.jpg");
                imh[77] = Image.FromFile(@"HELICOPTER\6.jpg");
                imh[78] = Image.FromFile(@"HELICOPTER\7.jpg");
                imh[79] = Image.FromFile(@"HELICOPTER\8.jpg");
                imh[80] = Image.FromFile(@"HELICOPTER\9.jpg");
                imh[81] = Image.FromFile(@"JACKET\1.jpg");
                imh[82] = Image.FromFile(@"JACKET\2.jpg");
                imh[83] = Image.FromFile(@"JACKET\3.jpg");
                imh[84] = Image.FromFile(@"JACKET\4.jpg");
                imh[85] = Image.FromFile(@"JACKET\5.jpg");
                imh[86] = Image.FromFile(@"JACKET\6.jpg");
                imh[87] = Image.FromFile(@"JACKET\7.jpg");
                imh[88] = Image.FromFile(@"JACKET\8.jpg");
                imh[89] = Image.FromFile(@"JACKET\9.jpg");
                imh[90] = Image.FromFile(@"LUMBER\1.jpg");
                imh[91] = Image.FromFile(@"LUMBER\2.jpg");
                imh[92] = Image.FromFile(@"LUMBER\3.jpg");
                imh[93] = Image.FromFile(@"LUMBER\4.jpg");
                imh[94] = Image.FromFile(@"LUMBER\5.jpg");
                imh[95] = Image.FromFile(@"LUMBER\6.jpg");
                imh[96] = Image.FromFile(@"LUMBER\7.jpg");
                imh[97] = Image.FromFile(@"LUMBER\8.jpg");
                imh[98] = Image.FromFile(@"LUMBER\9.jpg");
                imh[99] = Image.FromFile(@"MATH\1.jpg");
                imh[100] = Image.FromFile(@"MATH\2.jpg");
                imh[101] = Image.FromFile(@"MATH\3.jpg");
                imh[102] = Image.FromFile(@"MATH\4.jpg");
                imh[103] = Image.FromFile(@"MATH\5.jpg");
                imh[104] = Image.FromFile(@"MATH\6.jpg");
                imh[105] = Image.FromFile(@"MATH\7.jpg");
                imh[106] = Image.FromFile(@"MATH\8.jpg");
                imh[107] = Image.FromFile(@"MATH\9.jpg");
                imh[108] = Image.FromFile(@"MILITARY\1.jpg");
                imh[109] = Image.FromFile(@"MILITARY\2.jpg");
                imh[110] = Image.FromFile(@"MILITARY\3.jpg");
                imh[111] = Image.FromFile(@"MILITARY\4.jpg");
                imh[112] = Image.FromFile(@"MILITARY\5.jpg");
                imh[113] = Image.FromFile(@"MILITARY\6.jpg");
                imh[114] = Image.FromFile(@"MILITARY\7.jpg");
                imh[115] = Image.FromFile(@"MILITARY\8.jpg");
                imh[116] = Image.FromFile(@"MILITARY\9.jpg");
                imh[117] = Image.FromFile(@"MOUNTAIN\1.jpg");
                imh[118] = Image.FromFile(@"MOUNTAIN\2.jpg");
                imh[119] = Image.FromFile(@"MOUNTAIN\3.jpg");
                imh[120] = Image.FromFile(@"MOUNTAIN\4.jpg");
                imh[121] = Image.FromFile(@"MOUNTAIN\5.jpg");
                imh[122] = Image.FromFile(@"MOUNTAIN\6.jpg");
                imh[123] = Image.FromFile(@"MOUNTAIN\7.jpg");
                imh[124] = Image.FromFile(@"MOUNTAIN\8.jpg");
                imh[125] = Image.FromFile(@"MOUNTAIN\9.jpg");
                imh[126] = Image.FromFile(@"NUMBER\1.jpg");
                imh[127] = Image.FromFile(@"NUMBER\2.jpg");
                imh[128] = Image.FromFile(@"NUMBER\3.jpg");
                imh[129] = Image.FromFile(@"NUMBER\4.jpg");
                imh[130] = Image.FromFile(@"NUMBER\5.jpg");
                imh[131] = Image.FromFile(@"NUMBER\6.jpg");
                imh[132] = Image.FromFile(@"NUMBER\7.jpg");
                imh[133] = Image.FromFile(@"NUMBER\8.jpg");
                imh[134] = Image.FromFile(@"NUMBER\9.jpg");
                imh[135] = Image.FromFile(@"PORCUPINE\1.jpg");
                imh[136] = Image.FromFile(@"PORCUPINE\2.jpg");
                imh[137] = Image.FromFile(@"PORCUPINE\3.jpg");
                imh[138] = Image.FromFile(@"PORCUPINE\4.jpg");
                imh[139] = Image.FromFile(@"PORCUPINE\5.jpg");
                imh[140] = Image.FromFile(@"PORCUPINE\6.jpg");
                imh[141] = Image.FromFile(@"PORCUPINE\7.jpg");
                imh[142] = Image.FromFile(@"PORCUPINE\8.jpg");
                imh[143] = Image.FromFile(@"PORCUPINE\9.jpg");
                imh[144] = Image.FromFile(@"SWORD\1.jpg");
                imh[145] = Image.FromFile(@"SWORD\2.jpg");
                imh[146] = Image.FromFile(@"SWORD\3.jpg");
                imh[147] = Image.FromFile(@"SWORD\4.jpg");
                imh[148] = Image.FromFile(@"SWORD\5.jpg");
                imh[149] = Image.FromFile(@"SWORD\6.jpg");
                imh[150] = Image.FromFile(@"SWORD\7.jpg");
                imh[151] = Image.FromFile(@"SWORD\8.jpg");
                imh[152] = Image.FromFile(@"SWORD\9.jpg");
                imh[153] = Image.FromFile(@"THEATER\1.jpg");
                imh[154] = Image.FromFile(@"THEATER\2.jpg");
                imh[155] = Image.FromFile(@"THEATER\3.jpg");
                imh[156] = Image.FromFile(@"THEATER\4.jpg");
                imh[157] = Image.FromFile(@"THEATER\5.jpg");
                imh[158] = Image.FromFile(@"THEATER\6.jpg");
                imh[159] = Image.FromFile(@"THEATER\7.jpg");
                imh[160] = Image.FromFile(@"THEATER\8.jpg");
                imh[161] = Image.FromFile(@"THEATER\9.jpg");
                imh[162] = Image.FromFile(@"VEGETABLE\1.jpg");
                imh[163] = Image.FromFile(@"VEGETABLE\2.jpg");
                imh[164] = Image.FromFile(@"VEGETABLE\3.jpg");
                imh[165] = Image.FromFile(@"VEGETABLE\4.jpg");
                imh[166] = Image.FromFile(@"VEGETABLE\5.jpg");
                imh[167] = Image.FromFile(@"VEGETABLE\6.jpg");
                imh[168] = Image.FromFile(@"VEGETABLE\7.jpg");
                imh[169] = Image.FromFile(@"VEGETABLE\8.jpg");
                imh[170] = Image.FromFile(@"VEGETABLE\9.jpg");
                imh[171] = Image.FromFile(@"WINDOW\1.jpg");
                imh[172] = Image.FromFile(@"WINDOW\2.jpg");
                imh[173] = Image.FromFile(@"WINDOW\3.jpg");
                imh[174] = Image.FromFile(@"WINDOW\4.jpg");
                imh[175] = Image.FromFile(@"WINDOW\5.jpg");
                imh[176] = Image.FromFile(@"WINDOW\6.jpg");
                imh[177] = Image.FromFile(@"WINDOW\7.jpg");
                imh[178] = Image.FromFile(@"WINDOW\8.jpg");
                imh[179] = Image.FromFile(@"WINDOW\9.jpg");

                linkLabel6.Visible = true;
                linkLabel7.Visible = true;
                linkLabel5.Visible = true;

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;

                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;

                // Selects which picturebox to display first (randomly)
                revealcount = 1;
                int initialreveal = ran.Next(11, 20);

                if (initialreveal == 11)
                {
                    pictureBox11.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 12)
                {
                    pictureBox12.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 13)
                {
                    pictureBox13.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 14)
                {
                    pictureBox14.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 15)
                {
                    pictureBox15.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 16)
                {
                    pictureBox16.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 17)
                {
                    pictureBox17.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 18)
                {
                    pictureBox18.Visible = true;
                    picreveal[0] = initialreveal;
                }

                else if (initialreveal == 19)
                {
                    pictureBox19.Visible = true;
                    picreveal[0] = initialreveal;
                }

                n = 0;
                exist = false;
                do
                {
                    exist = false;

                    n = ran.Next(1, 21);

                    for (int y = 0; y < 20; y++)
                    {
                        if (n == hardgames[y])
                        {
                            exist = true;
                        }
                    }
                }
                while (exist == true);

                hardgames[gamecount] = n;
                gamecount++;
                gamenum++;

                int i = (n - 1) * 9;
                pictureBox11.Image = imh[i];
                pictureBox12.Image = imh[i + 1];
                pictureBox13.Image = imh[i + 2];
                pictureBox14.Image = imh[i + 3];
                pictureBox15.Image = imh[i + 4];
                pictureBox16.Image = imh[i + 5];
                pictureBox17.Image = imh[i + 6];
                pictureBox18.Image = imh[i + 7];
                pictureBox19.Image = imh[i + 8];

                //Generate new word
                sr = new StreamReader(@"hard.txt");

                for (int x = 1; x <= n; x++)
                {
                    word = sr.ReadLine();
                    word = word.ToUpper();
                }

                // Generate underscores
                label1.Text = "";
                for (int x = 0; x < word.Length * 2; x++)
                {
                    if (x % 2 == 0)
                    {
                        label1.Text += "_";
                    }

                    else
                    {
                        label1.Text += " ";
                    }
                }

                // Generate choice letters
                int[] letbox = new int[15];
                char[] wordd = new char[word.Length];
                wordd = word.ToCharArray(0, word.Length);
                char[] alpha = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                int num = 0;
                exist = false;

                for (int x = 0; x < 15; x++)
                {
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 16);

                        for (int y = 0; y < 15; y++)
                        {
                            if (num == letbox[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    if (num == 1)
                    {
                        if (x < word.Length)
                        {
                            button1.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button1.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 2)
                    {
                        if (x < word.Length)
                        {
                            button2.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button2.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 3)
                    {
                        if (x < word.Length)
                        {
                            button3.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button3.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 4)
                    {
                        if (x < word.Length)
                        {
                            button4.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button4.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 5)
                    {
                        if (x < word.Length)
                        {
                            button5.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button5.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 6)
                    {
                        if (x < word.Length)
                        {
                            button6.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button6.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 7)
                    {
                        if (x < word.Length)
                        {
                            button7.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button7.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 8)
                    {
                        if (x < word.Length)
                        {
                            button8.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button8.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 9)
                    {
                        if (x < word.Length)
                        {
                            button9.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button9.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 10)
                    {
                        if (x < word.Length)
                        {
                            button10.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button10.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 11)
                    {
                        if (x < word.Length)
                        {
                            button12.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button12.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 12)
                    {
                        if (x < word.Length)
                        {
                            button13.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button13.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 13)
                    {
                        if (x < word.Length)
                        {
                            button14.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button14.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 14)
                    {
                        if (x < word.Length)
                        {
                            button15.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button15.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 15)
                    {
                        if (x < word.Length)
                        {
                            button16.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button16.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                }

                label1.Text = "";
                for (int x = 0; x < word.Length * 2; x++)
                {
                    if (x % 2 == 0)
                    {
                        label1.Text += "_";
                    }

                    else
                    {
                        label1.Text += " ";
                    }
                }

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
                wordposition = 0;
                timer1.Enabled = true;

            }

            // Checks if the answer is correct
            string ans = "";
            for (int x = 0; x < word.Length * 2; x++)
            {
                if (x % 2 == 0)
                {
                    if (label1.Text[x] != '_')
                        ans += label1.Text[x];
                }
            }

            if (ans.Length == word.Length && ans != word)
            {
                timer1.Enabled = false;
                MessageBox.Show("Wrong word!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                label1.Text = "";
                for (int x = 0; x < word.Length * 2; x++)
                {
                    if (x % 2 == 0)
                    {
                        label1.Text += "_";
                    }

                    else
                    {
                        label1.Text += " ";
                    }
                }
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
                wordposition = 0;
                chance -= 1;
                timer2.Enabled = true;
                timer1.Enabled = true;
            }

            if (ans == word)
            {
                score += scoretoadd;
                chance = 3;
                timer2.Enabled = true;
                if (gamemode == 0)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    timer1.Enabled = false;
                    MessageBox.Show("Correct!", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    scoretoadd = 5;
                    linkLabel1.Visible = true;
                    linkLabel2.Visible = true;
                    linkLabel3.Visible = true;

                    picreveal[0] = Convert.ToInt16(null);
                    picreveal[1] = Convert.ToInt16(null);
                    picreveal[2] = Convert.ToInt16(null);
                    picreveal[3] = Convert.ToInt16(null);

                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;

                    // Selects which picturebox to display first (randomly)
                    revealcount = 1;
                    int initialreveal = ran.Next(1, 5);

                    if (initialreveal == 1)
                    {
                        pictureBox1.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 2)
                    {
                        pictureBox2.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 3)
                    {
                        pictureBox3.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else
                    {
                        pictureBox4.Visible = true;
                        picreveal[0] = initialreveal;
                    }


                    exist = false;
                    do
                    {
                        exist = false;

                        n = ran.Next(1, 21);

                        for (int y = 0; y < 20; y++)
                        {
                            if (n == easygames[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    easygames[gamecount] = n;
                    gamecount++;
                    gamenum++;

                    int i = (n - 1) * 4;
                    pictureBox1.Image = ime[i];
                    pictureBox2.Image = ime[i + 1];
                    pictureBox3.Image = ime[i + 2];
                    pictureBox4.Image = ime[i + 3];
                }

                if (gamemode == 1)
                {
                    timer1.Enabled = false;
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox7.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox10.Visible = true;
                    MessageBox.Show("Correct!", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    scoretoadd = 7;

                    linkLabel1.Visible = true;
                    linkLabel2.Visible = true;
                    linkLabel3.Visible = true;
                    linkLabel4.Visible = true;
                    linkLabel8.Visible = true;

                    picreveal[0] = Convert.ToInt16(null);
                    picreveal[1] = Convert.ToInt16(null);
                    picreveal[2] = Convert.ToInt16(null);
                    picreveal[3] = Convert.ToInt16(null);
                    picreveal[4] = Convert.ToInt16(null);
                    picreveal[5] = Convert.ToInt16(null);

                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox10.Visible = false;

                    // Selects which picturebox to display first (randomly)
                    revealcount = 1;
                    int initialreveal = ran.Next(5, 11);

                    if (initialreveal == 5)
                    {
                        pictureBox5.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 6)
                    {
                        pictureBox6.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 7)
                    {
                        pictureBox7.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 8)
                    {
                        pictureBox8.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 9)
                    {
                        pictureBox9.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 10)
                    {
                        pictureBox10.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    n = 0;
                    exist = false;
                    do
                    {
                        exist = false;

                        n = ran.Next(1, 21);

                        for (int y = 0; y < 20; y++)
                        {
                            if (n == mediumgames[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    mediumgames[gamecount] = n;
                    gamecount++;
                    gamenum++;

                    int i = (n - 1) * 6;
                    pictureBox5.Image = imm[i];
                    pictureBox6.Image = imm[i + 1];
                    pictureBox7.Image = imm[i + 2];
                    pictureBox8.Image = imm[i + 3];
                    pictureBox9.Image = imm[i + 4];
                    pictureBox10.Image = imm[i + 5];
                }

                if (gamemode == 2)
                {
                    timer1.Enabled = false;
                    pictureBox11.Visible = true;
                    pictureBox12.Visible = true;
                    pictureBox13.Visible = true;
                    pictureBox14.Visible = true;
                    pictureBox15.Visible = true;
                    pictureBox16.Visible = true;
                    pictureBox17.Visible = true;
                    pictureBox18.Visible = true;
                    pictureBox19.Visible = true;
                    MessageBox.Show("Correct!", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    scoretoadd = 10;

                    linkLabel1.Visible = true;
                    linkLabel2.Visible = true;
                    linkLabel3.Visible = true;
                    linkLabel4.Visible = true;
                    linkLabel8.Visible = true;
                    linkLabel6.Visible = true;
                    linkLabel7.Visible = true;
                    linkLabel5.Visible = true;

                    picreveal[0] = Convert.ToInt16(null);
                    picreveal[1] = Convert.ToInt16(null);
                    picreveal[2] = Convert.ToInt16(null);
                    picreveal[3] = Convert.ToInt16(null);
                    picreveal[4] = Convert.ToInt16(null);
                    picreveal[5] = Convert.ToInt16(null);
                    picreveal[6] = Convert.ToInt16(null);
                    picreveal[7] = Convert.ToInt16(null);
                    picreveal[8] = Convert.ToInt16(null);

                    pictureBox11.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox19.Visible = false;

                    // Selects which picturebox to display first (randomly)
                    revealcount = 1;
                    int initialreveal = ran.Next(11, 20);

                    if (initialreveal == 11)
                    {
                        pictureBox11.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 12)
                    {
                        pictureBox12.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 13)
                    {
                        pictureBox13.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 14)
                    {
                        pictureBox14.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 15)
                    {
                        pictureBox15.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 16)
                    {
                        pictureBox16.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 17)
                    {
                        pictureBox17.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 18)
                    {
                        pictureBox18.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    else if (initialreveal == 19)
                    {
                        pictureBox19.Visible = true;
                        picreveal[0] = initialreveal;
                    }

                    n = 0;
                    exist = false;
                    do
                    {
                        exist = false;

                        n = ran.Next(1, 21);

                        for (int y = 0; y < 20; y++)
                        {
                            if (n == hardgames[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    hardgames[gamecount] = n;
                    gamenum++;
                    gamecount++;

                    int i = (n - 1) * 9;
                    pictureBox11.Image = imh[i];
                    pictureBox12.Image = imh[i + 1];
                    pictureBox13.Image = imh[i + 2];
                    pictureBox14.Image = imh[i + 3];
                    pictureBox15.Image = imh[i + 4];
                    pictureBox16.Image = imh[i + 5];
                    pictureBox17.Image = imh[i + 6];
                    pictureBox18.Image = imh[i + 7];
                    pictureBox19.Image = imh[i + 8];
                }


                /*Generates the random word*/
                if (gamemode == 0)
                {
                    sr = new StreamReader(@"easy.txt");

                    for (int x = 1; x <= n; x++)
                    {
                        word = sr.ReadLine();
                        word = word.ToUpper();
                    }
                }

                if (gamemode == 1)
                {
                    sr = new StreamReader(@"medium.txt");

                    for (int x = 1; x <= n; x++)
                    {
                        word = sr.ReadLine();
                        word = word.ToUpper();
                    }
                }

                if (gamemode == 2)
                {
                    sr = new StreamReader(@"hard.txt");

                    for (int x = 1; x <= n; x++)
                    {
                        word = sr.ReadLine();
                        word = word.ToUpper();
                    }
                }

                /* Generates the number of underscores displayed*/
                label1.Text = "";
                for (int x = 0; x < word.Length * 2; x++)
                {
                    if (x % 2 == 0)
                    {
                        label1.Text += "_";
                    }

                    else
                    {
                        label1.Text += " ";
                    }
                }

                /* Generates the choice letters*/

                int[] letbox = new int[15];
                char[] wordd = new char[word.Length];
                wordd = word.ToCharArray(0, word.Length);
                char[] alpha = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                int num = 0;
                exist = false;

                for (int x = 0; x < 15; x++)
                {
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 16);

                        for (int y = 0; y < 15; y++)
                        {
                            if (num == letbox[y])
                            {
                                exist = true;
                            }
                        }
                    }
                    while (exist == true);

                    if (num == 1)
                    {
                        if (x < word.Length)
                        {
                            button1.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button1.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 2)
                    {
                        if (x < word.Length)
                        {
                            button2.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button2.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 3)
                    {
                        if (x < word.Length)
                        {
                            button3.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button3.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 4)
                    {
                        if (x < word.Length)
                        {
                            button4.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button4.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 5)
                    {
                        if (x < word.Length)
                        {
                            button5.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button5.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 6)
                    {
                        if (x < word.Length)
                        {
                            button6.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button6.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 7)
                    {
                        if (x < word.Length)
                        {
                            button7.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button7.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 8)
                    {
                        if (x < word.Length)
                        {
                            button8.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button8.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 9)
                    {
                        if (x < word.Length)
                        {
                            button9.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button9.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 10)
                    {
                        if (x < word.Length)
                        {
                            button10.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button10.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 11)
                    {
                        if (x < word.Length)
                        {
                            button12.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button12.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 12)
                    {
                        if (x < word.Length)
                        {
                            button13.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button13.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 13)
                    {
                        if (x < word.Length)
                        {
                            button14.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button14.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 14)
                    {
                        if (x < word.Length)
                        {
                            button15.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button15.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }

                    if (num == 15)
                    {
                        if (x < word.Length)
                        {
                            button16.Text = Convert.ToString(wordd[x]);
                            letbox[x] = num;
                        }

                        else
                        {
                            int alph = ran.Next(0, 26);
                            button16.Text = Convert.ToString(alpha[alph]);
                            letbox[x] = num;
                        }
                    }
                }

                label1.Text = "";
                for (int x = 0; x < word.Length * 2; x++)
                {
                    if (x % 2 == 0)
                    {
                        label1.Text += "_";
                    }

                    else
                    {
                        label1.Text += " ";
                    }
                }

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
                wordposition = 0;
                timer1.Enabled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = false;
            gametype = ran.Next(1, 7);
            if (gametype == 1 || gametype == 2 || gametype == 3)
            {
                minigame1 mg1 = new minigame1();
                minigame1.mgpass = false;
                minigame2.mpass = false;
                mg1.Show();
                MinigameTimer.Enabled = true;
            }
            if (gametype == 4 || gametype == 5 || gametype == 6)
            {
                minigame2 mg2 = new minigame2();
                minigame2.mpass = false;
                minigame1.mgpass = false;
                mg2.Show();
                MinigameTimer.Enabled = true;
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.Visible = false;
            gametype = ran.Next(1, 7);
            if (gametype == 1 || gametype == 2 || gametype == 3)
            {
                minigame1 mg1 = new minigame1();
                minigame1.mgpass = false;
                minigame2.mpass = false;
                mg1.Show();
                MinigameTimer.Enabled = true;
            }
            if (gametype == 4 || gametype == 5 || gametype == 6)
            {
                minigame2 mg2 = new minigame2();
                minigame2.mpass = false;
                minigame1.mgpass = false;
                mg2.Show();
                MinigameTimer.Enabled = true;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.Visible = false;
            gametype = ran.Next(1, 7);
            if (gametype == 1 || gametype == 2 || gametype == 3)
            {
                minigame1 mg1 = new minigame1();
                minigame1.mgpass = false;
                minigame2.mpass = false;
                mg1.Show();
                MinigameTimer.Enabled = true;
            }
            if (gametype == 4 || gametype == 5 || gametype == 6)
            {
                minigame2 mg2 = new minigame2();
                minigame2.mpass = false;
                minigame1.mgpass = false;
                mg2.Show();
                MinigameTimer.Enabled = true;
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.Visible = false;
            gametype = ran.Next(1, 7);
            if (gametype == 1 || gametype == 2 || gametype == 3)
            {
                minigame1 mg1 = new minigame1();
                minigame1.mgpass = false;
                minigame2.mpass = false;
                mg1.Show();
                MinigameTimer.Enabled = true;
            }
            if (gametype == 4 || gametype == 5 || gametype == 6)
            {
                minigame2 mg2 = new minigame2();
                minigame2.mpass = false;
                minigame1.mgpass = false;
                mg2.Show();
                MinigameTimer.Enabled = true;
            }

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel8.Visible = false;
            gametype = ran.Next(1, 7);
            if (gametype == 1 || gametype == 2 || gametype == 3)
            {
                minigame1 mg1 = new minigame1();
                minigame1.mgpass = false;
                minigame2.mpass = false;
                mg1.Show();
                MinigameTimer.Enabled = true;
            }
            if (gametype == 4 || gametype == 5 || gametype == 6)
            {
                minigame2 mg2 = new minigame2();
                minigame2.mpass = false;
                minigame1.mgpass = false;
                mg2.Show();
                MinigameTimer.Enabled = true;
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel7.Visible = false;
            gametype = ran.Next(1, 7);
            if (gametype == 1 || gametype == 2 || gametype == 3)
            {
                minigame1 mg1 = new minigame1();
                minigame1.mgpass = false;
                minigame2.mpass = false;
                mg1.Show();
                MinigameTimer.Enabled = true;
            }
            if (gametype == 4 || gametype == 5 || gametype == 6)
            {
                minigame2 mg2 = new minigame2();
                minigame2.mpass = false;
                minigame1.mgpass = false;
                mg2.Show();
                MinigameTimer.Enabled = true;
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel6.Visible = false;
            gametype = ran.Next(1, 7);
            if (gametype == 1 || gametype == 2 || gametype == 3)
            {
                minigame1 mg1 = new minigame1();
                minigame1.mgpass = false;
                minigame2.mpass = false;
                mg1.Show();
                MinigameTimer.Enabled = true;
            }
            if (gametype == 4 || gametype == 5 || gametype == 6)
            {
                minigame2 mg2 = new minigame2();
                minigame2.mpass = false;
                minigame1.mgpass = false;
                mg2.Show();
                MinigameTimer.Enabled = true;
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel5.Visible = false;
            gametype = ran.Next(1, 7);
            if (gametype == 1 || gametype == 2 || gametype == 3)
            {
                minigame1 mg1 = new minigame1();
                minigame1.mgpass = false;
                minigame2.mpass = false;
                mg1.Show();
                MinigameTimer.Enabled = true;
            }
            if (gametype == 4 || gametype == 5 || gametype == 6)
            {
                minigame2 mg2 = new minigame2();
                minigame2.mpass = false;
                minigame1.mgpass = false;
                mg2.Show();
                MinigameTimer.Enabled = true;
            }
        }

        private void MinigameTimer_Tick(object sender, EventArgs e)
        {
            if (minigame1.mgpass == true)
            {
                MinigameTimer.Enabled = false;
                // Selects which picturebox to reveal (randomly)
                scoretoadd += 1;
                bool exist;
                int num = 0;

                if (gamemode == 0)
                {
                    num = 0;
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 5);

                        for (int y = 0; y < 4; y++)
                        {
                            if (num == picreveal[y])
                            {
                                exist = true;
                            }
                        }
                    }

                    while (exist == true);
                }

                if (gamemode == 1)
                {
                    num = 0;
                    do
                    {
                        exist = false;

                        num = ran.Next(5, 11);

                        for (int y = 0; y < 6; y++)
                        {
                            if (num == picreveal[y])
                            {
                                exist = true;
                            }
                        }
                    }

                    while (exist == true);
                }

                if (gamemode == 2)
                {
                    num = 0;
                    do
                    {
                        exist = false;

                        num = ran.Next(11, 20);

                        for (int y = 0; y < 9; y++)
                        {
                            if (num == picreveal[y])
                            {
                                exist = true;
                            }
                        }
                    }

                    while (exist == true);
                }

                if (num == 1)
                {
                    pictureBox1.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 2)
                {
                    pictureBox2.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 3)
                {
                    pictureBox3.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 4)
                {
                    pictureBox4.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 5)
                {
                    pictureBox5.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 6)
                {
                    pictureBox6.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 7)
                {
                    pictureBox7.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 8)
                {
                    pictureBox8.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 9)
                {
                    pictureBox9.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 10)
                {
                    pictureBox10.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 11)
                {
                    pictureBox11.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 12)
                {
                    pictureBox12.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 13)
                {
                    pictureBox13.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 14)
                {
                    pictureBox14.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 15)
                {
                    pictureBox15.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 16)
                {
                    pictureBox16.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 17)
                {
                    pictureBox17.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 18)
                {
                    pictureBox18.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 19)
                {
                    pictureBox19.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }
            }

            else if (minigame2.mpass == true)
            {
                MinigameTimer.Enabled = false;
                // Selects which picturebox to reveal (randomly)
                scoretoadd += 1;
                bool exist;
                int num = 0;

                if (gamemode == 0)
                {
                    num = 0;
                    do
                    {
                        exist = false;

                        num = ran.Next(1, 5);

                        for (int y = 0; y < 4; y++)
                        {
                            if (num == picreveal[y])
                            {
                                exist = true;
                            }
                        }
                    }

                    while (exist == true);
                }

                if (gamemode == 1)
                {
                    num = 0;
                    do
                    {
                        exist = false;

                        num = ran.Next(5, 11);

                        for (int y = 0; y < 6; y++)
                        {
                            if (num == picreveal[y])
                            {
                                exist = true;
                            }
                        }
                    }

                    while (exist == true);
                }

                if (gamemode == 2)
                {
                    num = 0;
                    do
                    {
                        exist = false;

                        num = ran.Next(11, 20);

                        for (int y = 0; y < 9; y++)
                        {
                            if (num == picreveal[y])
                            {
                                exist = true;
                            }
                        }
                    }

                    while (exist == true);
                }

                if (num == 1)
                {
                    pictureBox1.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 2)
                {
                    pictureBox2.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 3)
                {
                    pictureBox3.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 4)
                {
                    pictureBox4.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 5)
                {
                    pictureBox5.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 6)
                {
                    pictureBox6.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 7)
                {
                    pictureBox7.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 8)
                {
                    pictureBox8.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 9)
                {
                    pictureBox9.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 10)
                {
                    pictureBox10.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 11)
                {
                    pictureBox11.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 12)
                {
                    pictureBox12.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 13)
                {
                    pictureBox13.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 14)
                {
                    pictureBox14.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 15)
                {
                    pictureBox15.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 16)
                {
                    pictureBox16.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 17)
                {
                    pictureBox17.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 18)
                {
                    pictureBox18.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }

                if (num == 19)
                {
                    pictureBox19.Visible = true;
                    picreveal[revealcount] = num;
                    revealcount++;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (chance == 3)
            {
                timer2.Enabled = false;
                pictureBox23.Image = Image.FromFile(@"chance3.gif");
            }

            if (chance == 2)
            {
                timer2.Enabled = false;
                pictureBox23.Image = Image.FromFile(@"chance2.gif");
            }

            if (chance == 1)
            {
                timer2.Enabled = false;
                pictureBox23.Image = Image.FromFile(@"chance1.gif");
            }

            if (chance == 0)
            {
                timer2.Enabled = false;
                pictureBox23.Image = Image.FromFile(@"chance0.gif");
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button12.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button12.Text + part2;
                wordposition += 2;
            }

            button12.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button13.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button13.Text + part2;
                wordposition += 2;
            }

            button13.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button14.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button14.Text + part2;
                wordposition += 2;
            }

            button14.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button15.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button15.Text + part2;
                wordposition += 2;
            }

            button15.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (wordposition == 0)
            {
                label1.Text = button16.Text + label1.Text.Substring(1);
                wordposition += 2;
            }

            else
            {
                string part1 = label1.Text.Substring(0, wordposition);
                string part2 = label1.Text.Substring(wordposition + 1);
                label1.Text = part1 + button16.Text + part2;
                wordposition += 2;
            }

            button16.Visible = false;
        }
    }
}

