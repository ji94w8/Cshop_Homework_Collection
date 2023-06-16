using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshop_Homework_Collection
{
    public partial class HW7_Alarm : Form
    {
        public HW7_Alarm()
        {
            InitializeComponent();
        }

        private void HW7_Alarm_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            labCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            bool TimesUp = false;

            int h, m, s;
            if (int.TryParse(txtHour.Text, out h) && int.TryParse(txtMinute.Text, out m) && int.TryParse(txtSeconds.Text, out s))
            {
                cbSetAlarm.Enabled = true;
                if (cbSetAlarm.Checked)
                {
                    if (h == DateTime.Now.Hour && m == DateTime.Now.Minute && s == DateTime.Now.Second)
                    {
                        TimesUp = true;
                        txtHour.Text = "";
                        txtMinute.Text = "";
                        txtSeconds.Text = "";
                        Alarm form = new Alarm();
                        form.Show();
                    }
                }
            }


        }

        private void cbSetAlarm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSeconds_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





