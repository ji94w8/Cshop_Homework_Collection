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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHW1Hello_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2.Controls.Count > 0)
            {
                // 關閉並釋放先前的表單
                Form previousForm = splitContainer2.Panel2.Controls[0] as Form;
                previousForm.Dispose();
            }
            HW1_Hello form = new HW1_Hello();
            Panel PlaceForm = splitContainer2.Panel2;
            form.TopLevel = false;

            PlaceForm.Controls.Add(form);

            form.Show();
        }

        private void btnHW2Loan_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2.Controls.Count > 0)
            {
                // 關閉並釋放先前的表單
                Form previousForm = splitContainer2.Panel2.Controls[0] as Form;
                previousForm.Dispose();
            }
            HW2_Loan form = new HW2_Loan();
                Panel PlaceForm = splitContainer2.Panel2;
                form.TopLevel = false;

                PlaceForm.Controls.Add(form);

                form.Show();
        }

        private void btnHW3POS_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2.Controls.Count > 0)
            {
                // 關閉並釋放先前的表單
                Form previousForm = splitContainer2.Panel2.Controls[0] as Form;
                previousForm.Dispose();
            }
            HW3_POS form = new HW3_POS();
            Panel PlaceForm = splitContainer2.Panel2;
            form.TopLevel = false;

            PlaceForm.Controls.Add(form);

            form.Show();
        }

        private void btnCalaulator_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2.Controls.Count > 0)
            {
                // 關閉並釋放先前的表單
                Form previousForm = splitContainer2.Panel2.Controls[0] as Form;
                previousForm.Dispose();
            }
            HW4_Calculator form = new HW4_Calculator();
            Panel PlaceForm = splitContainer2.Panel2;
            form.TopLevel = false;

            PlaceForm.Controls.Add(form);
            form.Show();
        }

        private void btnScreenServer_Click(object sender, EventArgs e)
        {

            HW5_ScreenServer form = new HW5_ScreenServer();

            form.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2.Controls.Count > 0)
            {
                // 關閉並釋放先前的表單
                Form previousForm = splitContainer2.Panel2.Controls[0] as Form;
                previousForm.Dispose();
            }
            HW6_PictureViewer form = new HW6_PictureViewer();
            Panel PlaceForm = splitContainer2.Panel2;
            form.TopLevel = false;

            PlaceForm.Controls.Add(form);
            form.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2.Controls.Count > 0)
            {
                // 關閉並釋放先前的表單
                Form previousForm = splitContainer2.Panel2.Controls[0] as Form;
                previousForm.Dispose();
            }
            HW7_Alarm form = new HW7_Alarm();
            Panel PlaceForm = splitContainer2.Panel2;
            form.TopLevel = false;

            PlaceForm.Controls.Add(form);
            form.Show();
        }

        private void btnGuessNumber_Click(object sender, EventArgs e)
        {
            if (splitContainer2.Panel2.Controls.Count > 0)
            {
                // 關閉並釋放先前的表單
                Form previousForm = splitContainer2.Panel2.Controls[0] as Form;
                previousForm.Dispose();
            }
            HW8_Guess form = new HW8_Guess();
            Panel PlaceForm = splitContainer2.Panel2;
            form.TopLevel = false;

            PlaceForm.Controls.Add(form);
            form.Show();
        }
    }
}
