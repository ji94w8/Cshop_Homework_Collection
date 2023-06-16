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
    public partial class HW6_PictureViewer : Form
    {
        public HW6_PictureViewer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.HomePage_Right2;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.C__HW1;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.giphy;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.HomePage_Left;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.TOP_F;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.HW3_1_Resize_Image;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.HW3_2_Resize_Image;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.HW3_3;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.HW3_4_Resize_Image;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.Ping;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.Screen_Server;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.Fighting;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.cats;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.images;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Image image = Properties.Resources.TOP;    // 取得圖片資源

            // 建立一個新的 Form 來顯示圖片
            Form imageForm = new Form();
            imageForm.Size = new Size(360, 360);

            // 在 Form 上加入一個 PictureBox 並設定圖片
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageForm.Controls.Add(pictureBox);

            // 顯示圖片的 Form
            imageForm.ShowDialog();
        }
    }
}
