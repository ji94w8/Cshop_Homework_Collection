using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshop_Homework_Collection
{
    public partial class Guess : Form
    {
        HW8_Guess parentForm;

        int Max = 100;
        int Min = 0;
        public Guess(HW8_Guess parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.Enabled = true;
            this.Close();
        }


        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGuess.Text, out int guessNumber))
            {
                MessageBox.Show("請輸入有效的數字");
            }
            else if (guessNumber >= 1 && guessNumber <= 100)
            {
                if (guessNumber == parentForm.randomNumber)
                {
                    MessageBox.Show($"Congradulations!!! You got {guessNumber} !!!");
                }
                else if (guessNumber > parentForm.randomNumber)
                {
                    Max = guessNumber;
                    labTitle.Text = ($"Too Large!!!\nBetween {Min} and {Max}");
                }
                else if (guessNumber < parentForm. randomNumber)
                {
                    Min = guessNumber;
                    labTitle.Text = ($"Too Small!!!\nBetween {Min} and {Max}");
                }
            }
            else
            {
                MessageBox.Show("請輸入1~100的整數");
            }
        }

        private void Guess_Load(object sender, EventArgs e)
        {
            
        }

        private void Guess_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Enabled = true;

        }
    }

    
}
