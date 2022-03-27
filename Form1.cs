using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace X_O_Game
{
    public partial class X_O : Form
    {
        public X_O()
        {
            InitializeComponent();
        }
        
        Label result = new Label();
        Label label1 = new Label();
        Label label2 = new Label();

        private void Form1_Load(object sender, EventArgs e)
        {
            string player1, player2;
            Label game = new Label();
            this.Controls.Add(game);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(result);

            game.Location = new Point(38, 10);
            game.Text = "X/O Game";
            game.Size = new Size(200, 80);
            game.Font = new Font("Times New Roman",25.0f,FontStyle.Bold);

            label1.Location = new Point(30, 265);
            label1.Size = new Size(120, 30);
            label1.Font = new Font("Arial", 12.0f, FontStyle.Italic);
            player1 = Interaction.InputBox("Input PLAYER1 name: ");
            label1.Text = player1;

            result.BorderStyle = BorderStyle.FixedSingle;

            label2.Location = new Point(30, 300);
            label2.Size = new Size(120, 30);
            label2.Font = new Font("Arial", 12.0f, FontStyle.Italic);
            player2 = Interaction.InputBox("Input PLAYER2 name: ");
            label2.Text = player2;

            result.Location = new Point(30, 340);
            result.Size = new Size(180, 30);
            result.BackColor = Color.White;
            result.ForeColor = Color.Black;
            result.Font = new Font("Times New Roman", 14.0f, FontStyle.Bold);
            result.Text = "WIN";
        }

        int i = 0,p1=0,p2=0;
        bool[] t = new bool[9];
        int[,] r = new int[3, 3];

        private void btn1_Click(object sender, EventArgs e)
        {
            if(t[0]==false)
            {
                i++;
                if(i%2==0)
                {
                    r[0, 0] = 2;
                    btn1.Text = "O";
                    btn1.ForeColor = Color.Red;
                }
                else
                {
                    r[0, 0] = 1;
                    btn1.Text = "X";
                    btn1.ForeColor = Color.Blue;
                }
            }
            t[0] = true;
            if (yoxla(ref r) == 1)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p1++;
                result.Text = label1.Text.ToString() + " is Win";
                txtP1.Text = p1.ToString();
            }
            if (yoxla(ref r) == 2)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p2++;
                result.Text = label2.Text.ToString() + " is Win";
                txtP2.Text = p2.ToString();
            }
            if (yoxla(ref r) == 0 && i == 9)
            {
                result.Text = "DRAW";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (t[1] == false)
            {
                i++;
                if (i % 2 == 0)
                {
                    r[0, 1] = 2;
                    btn2.Text = "O";
                    btn2.ForeColor = Color.Red;
                }
                else
                {
                    r[0, 1] = 1;
                    btn2.Text = "X";
                    btn2.ForeColor = Color.Blue;
                }
            }
            t[1] = true;
            if (yoxla(ref r) == 1)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p1++;
                result.Text = label1.Text.ToString() + " is Win";
                txtP1.Text = p1.ToString();
            }
            if (yoxla(ref r) == 2)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p2++;
                result.Text = label2.Text.ToString() + " is Win";
                txtP2.Text = p2.ToString();
            }
            if (yoxla(ref r) == 0 && i == 9)
            {
                result.Text = "DRAW";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (t[2] == false)
            {
                i++;
                if (i % 2 == 0)
                {
                    r[0, 2] = 2;
                    btn3.Text = "O";
                    btn3.ForeColor = Color.Red;
                }
                else
                {
                    r[0, 2] = 1;
                    btn3.Text = "X";
                    btn3.ForeColor = Color.Blue;
                }
            }
            t[2] = true;
            if (yoxla(ref r) == 1)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p1++;
                result.Text = label1.Text.ToString() + " is Win";
                txtP1.Text = p1.ToString();
            }
            if (yoxla(ref r) == 2)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p2++;
                result.Text = label2.Text.ToString() + " is Win";
                txtP2.Text = p2.ToString();
            }
            if (yoxla(ref r) == 0 && i == 9)
            {
                result.Text = "DRAW";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (t[3] == false)
            {
                i++;
                if (i % 2 == 0)
                {
                    r[1, 0] = 2;
                    btn4.Text = "O";
                    btn4.ForeColor = Color.Red;
                }
                else
                {
                    r[1, 0] = 1;
                    btn4.Text = "X";
                    btn4.ForeColor = Color.Blue;
                }
            }
            t[3] = true;
            if (yoxla(ref r) == 1)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p1++;
                result.Text = label1.Text.ToString() + " is Win";
                txtP1.Text = p1.ToString();
            }
            if (yoxla(ref r) == 2)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p2++;
                result.Text = label2.Text.ToString() + " is Win";
                txtP2.Text = p2.ToString();
            }
            if (yoxla(ref r) == 0 && i == 9)
            {
                result.Text = "DRAW";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (t[4] == false)
            {
                i++;
                if (i % 2 == 0)
                {
                    r[1, 1] = 2;
                    btn5.Text = "O";
                    btn5.ForeColor = Color.Red;
                }
                else
                {
                    r[1, 1] = 1;
                    btn5.Text = "X";
                    btn5.ForeColor = Color.Blue;
                }
            }
            t[4] = true;
            if (yoxla(ref r) == 1)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p1++;
                result.Text = label1.Text.ToString() + " is Win";
                txtP1.Text = p1.ToString();
            }
            if (yoxla(ref r) == 2)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p2++;
                result.Text = label2.Text.ToString() + " is Win";
                txtP2.Text = p2.ToString();
            }
            if (yoxla(ref r) == 0 && i == 9)
            {
                result.Text = "DRAW";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (t[5] == false)
            {
                i++;
                if (i % 2 == 0)
                {
                    r[1, 2] = 2;
                    btn6.Text = "O";
                    btn6.ForeColor = Color.Red;
                }
                else
                {
                    r[1, 2] = 1;
                    btn6.Text = "X";
                    btn6.ForeColor = Color.Blue;
                }
            }
            t[5] = true;
            if (yoxla(ref r) == 1)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p1++;
                result.Text = label1.Text.ToString() + " is Win";
                txtP1.Text = p1.ToString();
            }
            if (yoxla(ref r) == 2)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p2++;
                result.Text = label2.Text.ToString() + " is Win";
                txtP2.Text = p2.ToString();
            }
            if (yoxla(ref r) == 0 && i == 9)
            {
                result.Text = "DRAW";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (t[6] == false)
            {
                i++;
                if (i % 2 == 0)
                {
                    r[2, 0] = 2;
                    btn7.Text = "O";
                    btn7.ForeColor = Color.Red;
                }
                else
                {
                    r[2, 0] = 1;
                    btn7.Text = "X";
                    btn7.ForeColor = Color.Blue;
                }
            }
            t[6] = true;
            if (yoxla(ref r) == 1)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p1++;
                result.Text = label1.Text.ToString() + " is Win";
                txtP1.Text = p1.ToString();
            }
            if (yoxla(ref r) == 2)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p2++;
                result.Text = label2.Text.ToString() + " is Win";
                txtP2.Text = p2.ToString();
            }
            if (yoxla(ref r) == 0 && i == 9)
            {
                result.Text = "DRAW";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (t[7] == false)
            {
                i++;
                if (i % 2 == 0)
                {
                    r[2, 1] = 2;
                    btn8.Text = "O";
                    btn8.ForeColor = Color.Red;
                }
                else
                {
                    r[2, 1] = 1;
                    btn8.Text = "X";
                    btn8.ForeColor = Color.Blue;
                }
            }
            t[7] = true;
            if (yoxla(ref r) == 1)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p1++;
                result.Text = label1.Text.ToString() + " is Win";
                txtP1.Text = p1.ToString();
            }
            if (yoxla(ref r) == 2)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p2++;
                result.Text = label2.Text.ToString() + " is Win";
                txtP2.Text = p2.ToString();
            }
            if(yoxla(ref r)== 0 && i==9)
            {
                result.Text = "DRAW";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (t[8] == false)
            {
                i++;
                if (i % 2 == 0)
                {
                    r[2, 2] = 2;
                    btn9.Text = "O";
                    btn9.ForeColor = Color.Red;
                }
                else
                {
                    r[2, 2] = 1;
                    btn9.Text = "X";
                    btn9.ForeColor = Color.Blue;
                }
            }
            t[8] = true;
            if (yoxla(ref r) == 1)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p1++;
                result.Text = label1.Text.ToString() + " is Win";
                txtP1.Text = p1.ToString();
            }
            if (yoxla(ref r) == 2)
            {
                for (int j = 0; j < 9; j++)
                    t[j] = true;
                p2++;
                result.Text = label2.Text.ToString() + " is Win";
                txtP2.Text = p2.ToString();
            }
            if (yoxla(ref r) == 0 && i == 9)
            {
                result.Text = "DRAW";
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            i = 0;
            for (int j = 0; j < 9; j++)
                t[j] = false;
            for(int j=0;j<3;j++)
            {
                for (int k = 0; k < 3; k++)
                    r[j, k] = 0;
            }
            btn1.Text = "";
            btn1.ForeColor = Color.Black;
            btn2.Text = "";
            btn2.ForeColor = Color.Black;
            btn3.Text = "";
            btn3.ForeColor = Color.Black;
            btn4.Text = "";
            btn4.ForeColor = Color.Black;
            btn5.Text = "";
            btn5.ForeColor = Color.Black;
            btn6.Text = "";
            btn6.ForeColor = Color.Black;
            btn7.Text = "";
            btn7.ForeColor = Color.Black;
            btn8.Text = "";
            btn8.ForeColor = Color.Black;
            btn9.Text = "";
            btn9.ForeColor = Color.Black;
            result.Text = "";
        }

        public static int yoxla(ref int[,] r)
        {
            if (((r[0, 0] == 1) && (r[0, 1] == 1) && (r[0, 2] == 1)) ||
                ((r[1, 0] == 1) && (r[1, 1] == 1) && (r[1, 2] == 1)) ||
                ((r[2, 0] == 1) && (r[2, 1] == 1) && (r[2, 2] == 1)) ||
                ((r[0, 0] == 1) && (r[1, 0] == 1) && (r[2, 0] == 1)) ||
                ((r[0, 1] == 1) && (r[1, 1] == 1) && (r[2, 1] == 1)) ||
                ((r[0, 2] == 1) && (r[1, 2] == 1) && (r[2, 2] == 1)) ||
                ((r[0, 2] == 1) && (r[1, 1] == 1) && (r[2, 0] == 1)) ||
                ((r[0, 0] == 1) && (r[1, 1] == 1) && (r[2, 2] == 1)))
                return 1;
            else if (((r[0, 0] == 2) && (r[0, 1] == 2) && (r[0, 2] == 2)) ||
                ((r[1, 0] == 2) && (r[1, 1] == 2) && (r[1, 2] == 2)) ||
                ((r[2, 0] == 2) && (r[2, 1] == 2) && (r[2, 2] == 2)) ||
                ((r[0, 0] == 2) && (r[1, 0] == 2) && (r[2, 0] == 2)) ||
                ((r[0, 1] == 2) && (r[1, 1] == 2) && (r[2, 1] == 2)) ||
                ((r[0, 2] == 2) && (r[1, 2] == 2) && (r[2, 2] == 2)) ||
                ((r[0, 2] == 2) && (r[1, 1] == 2) && (r[2, 0] == 2)) ||
                ((r[0, 0] == 2) && (r[1, 1] == 2) && (r[2, 2] == 2)))
                return 2;
            else
                return 0;
        }

        private void txtP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtP2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
