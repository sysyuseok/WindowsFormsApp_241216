using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_241216
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button_rock_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            textBox_print.Text = randomNumber.ToString();
            if (randomNumber == 0)
            {
                textBox_print.Text += "Draw";
            }
            else
            {
                if (randomNumber == 1)
                {
                    textBox_print.Text += "Win";
                }
                else
                {
                    textBox_print.Text += "Lose";
                }
            }
        }

        private void button_scissor_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            textBox_print.Text = randomNumber.ToString();
            if (randomNumber == 1)
            {
                textBox_print.Text += "Draw";
            }
            else
            {
                if (randomNumber == 2)
                {
                    textBox_print.Text += "Win";
                }
                else
                {
                    textBox_print.Text += "Lose";
                }
            }
        }

        private void button_paper_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            textBox_print.Text = randomNumber.ToString();
            if (randomNumber == 2)
            {
                textBox_print.Text += "Draw";
            }
            else
            {
                if (randomNumber == 0)
                {
                    textBox_print.Text += "Win";
                }
                else
                {
                    textBox_print.Text += "Lose";
                }
            }
        }
    }
}
