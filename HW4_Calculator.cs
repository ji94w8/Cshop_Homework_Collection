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
    public partial class HW4_Calculator : Form
    {
        public HW4_Calculator()
        {
            InitializeComponent();
        }
        decimal number1, number2;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNumber1.Text, out number1) && decimal.TryParse(txtNumber2.Text, out number2))
            {
                decimal answer = number1 + number2;
                txtAnswer.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show( "請輸入有效的數字");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNumber1.Text, out number1) && decimal.TryParse(txtNumber2.Text, out number2))
            {
                decimal answer = number1 - number2;
                txtAnswer.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNumber1.Text, out number1) && decimal.TryParse(txtNumber2.Text, out number2))
            {
                decimal answer = number1 * number2;
                txtAnswer.Text = answer.ToString();
            }
            else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }

        private void btnDevidedBy_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNumber1.Text, out number1) && decimal.TryParse(txtNumber2.Text, out number2))
            {
                if (number2 != 0)
                {
                    decimal answer = number1 / number2;
                    txtAnswer.Text = answer.ToString();
                }
                else
                {
                    MessageBox.Show("被除數不可為0");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }

    }
}
