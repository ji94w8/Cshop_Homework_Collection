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
    public partial class HW1_Hello : Form
    {
        public HW1_Hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_HW1_Hi_Click(object sender, EventArgs e)
        {
            string Hello = "Hi 大家好~\n";
            if (textBox_HW1_Name.Text != "")
                Hello += $"我的名字是 {textBox_HW1_Name.Text}\n";
            if (textBox_HW1_City.Text != "")
                Hello += $"我來自 {textBox_HW1_City.Text}\n";
            if (textBox_HW1_Sex.Text != "")
                Hello += $"我的性別是 {textBox_HW1_Sex.Text}\n";
            if (textBox_HW1_Sign.Text != "")
                Hello += $"我的星座是 {textBox_HW1_Sign.Text}\n";

            MessageBox.Show(Hello + "很高興認識大家!");
        }
        

        private void btn_HW1_Bye_Click(object sender, EventArgs e)
        {
            string Hello = "";
            if (textBox_HW1_Name.Text != "")
                Hello+= $"我的名字是 {textBox_HW1_Name.Text}\n";
            if (textBox_HW1_City.Text != "")
                Hello += $"我來自 {textBox_HW1_City.Text}\n";
            if (textBox_HW1_Sex.Text != "")
                Hello += $"我的性別是 {textBox_HW1_Sex.Text}\n";
            if (textBox_HW1_Sign.Text != "")
                Hello += $"我的星座是 {textBox_HW1_Sign.Text}\n";

            MessageBox.Show(Hello + "Bye Bye 下次再見!");
             
        }
    }
}
