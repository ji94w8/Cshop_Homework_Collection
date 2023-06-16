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
    public partial class HW5_ScreenServer : Form
    {

        int moveright = 15;
        int movedown = 3;

        private Point initialMousePosition;
        private int minimumMouseMoveDistance = 10;

        public HW5_ScreenServer()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureQun.Left + moveright;
            int y = pictureQun.Top + movedown;
            Rectangle rect = Screen.PrimaryScreen.Bounds;

            if (x + pictureQun.Width > rect.Width || x < 0)
            {
                moveright = -moveright;
            }
            if (y + pictureQun.Height > rect.Height || y < 0)
            {
                movedown = -movedown;
            }
            else
            {
                pictureQun.Location = new Point(x, y);
            }
            

        }

        private void HW5_ScreenServer_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //滑鼠初始位置
            initialMousePosition = Control.MousePosition;
        }


        private void HW5_ScreenServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }

        private void HW5_ScreenServer_MouseMove(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void HW5_ScreenServer_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HW5_ScreenServer_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }


        private void HW5_ScreenServer_MouseMove_1(object sender, MouseEventArgs e)
        {
            // 計算滑鼠移動的距離
            int deltaX = Math.Abs(Control.MousePosition.X - initialMousePosition.X);
            int deltaY = Math.Abs(Control.MousePosition.Y - initialMousePosition.Y);

            // 如果滑鼠移動距離超過指定的最小距離，則關閉表單
            if (deltaX >= minimumMouseMoveDistance || deltaY >= minimumMouseMoveDistance)
            {
                this.Close();
            }
        }
    }
}
