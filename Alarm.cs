﻿using System;
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
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }

        private void Alarm_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}
