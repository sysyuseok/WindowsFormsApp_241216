using System;
using System.Windows.Forms;

namespace WindowsFormsApp_241216
{
    public partial class Form2 : Form
    {
        int MyScore = 0, ComScore = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void PrintRockScissorsPaper(int my, int com)
        {
            string m, y;
            if (my == 0)
                m = "ROCK";
            else if (my == 1)
                m = "SCISSORS";
            else m="PAPER";
            if (com == 0)
                y = "ROCK";
            else if (com == 1)
                y = "SCISSORS";
            else y="PAPER";
            textBox_print.Text = ($"ME: {m}  COM: {y}\r\n");
        }

        private void GamePlayPrintResult(int n)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            PrintRockScissorsPaper(n, randomNumber);

            if (n == randomNumber)
            {
                textBox_print.Text += "Draw";
            }
            else if ((n + 1) % 3 == randomNumber)
            {
                textBox_print.Text += "WIN";
                MyScore++;
            }
            else
            {
                textBox_print.Text += "LOSE";
                ComScore++;
            }

            textBox_print.Text += ($"\r\nYour Score: {MyScore}  Computer Score: {ComScore}\r\n");

            CheckGameOver();
        }

        private void CheckGameOver()
        {
            if (MyScore == 3 || ComScore == 3)
            {
                string result = MyScore == 3 ? "\r\nYou Win!!!" : "\r\nComputer Wins...";
                textBox_print.Text += result;

                // Disable buttons to prevent further input
                button_rock.Enabled = false;
                button_scissor.Enabled = false;
                button_paper.Enabled = false;
            }
        }

        private void button_rock_Click(object sender, EventArgs e)
        {
            GamePlayPrintResult(0);
        }

        private void button_scissor_Click(object sender, EventArgs e)
        {
            GamePlayPrintResult(1);
        }

        private void button_paper_Click(object sender, EventArgs e)
        {
            GamePlayPrintResult(2);
        }
    }
}
