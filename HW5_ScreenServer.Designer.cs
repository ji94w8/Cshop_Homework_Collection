namespace Cshop_Homework_Collection
{
    partial class HW5_ScreenServer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureQun = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureQun)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureQun
            // 
            this.pictureQun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureQun.Image = global::Cshop_Homework_Collection.Properties.Resources.Screen_Server;
            this.pictureQun.Location = new System.Drawing.Point(12, 12);
            this.pictureQun.Name = "pictureQun";
            this.pictureQun.Size = new System.Drawing.Size(323, 426);
            this.pictureQun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureQun.TabIndex = 0;
            this.pictureQun.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HW5_ScreenServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureQun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HW5_ScreenServer";
            this.Text = "HW5_ScreenServer";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HW5_ScreenServer_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HW5_ScreenServer_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HW5_ScreenServer_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HW5_ScreenServer_MouseMove_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureQun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureQun;
        private System.Windows.Forms.Timer timer1;
    }
}