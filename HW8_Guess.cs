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
    public partial class HW8_Guess : Form
    {


        public int randomNumber { get; set; }
        private Guess guessForm;

        public HW8_Guess()
        {
            InitializeComponent();
        }


        public void btnGuess_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
            this.Enabled = false;

            guessForm = new Guess(this);
            guessForm.Show();

        }

        public void EnableGuessForm()
        {
            guessForm.Enabled = true;
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Anawer: {randomNumber}");
        }


    }
}
