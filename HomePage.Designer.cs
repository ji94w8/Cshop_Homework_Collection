namespace Cshop_Homework_Collection
{
    partial class HomePage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnGuessNumber = new System.Windows.Forms.Button();
            this.btnPictureViewer = new System.Windows.Forms.Button();
            this.btnScreenServer = new System.Windows.Forms.Button();
            this.btnCalaulator = new System.Windows.Forms.Button();
            this.btnHW3POS = new System.Windows.Forms.Button();
            this.btnHW2Loan = new System.Windows.Forms.Button();
            this.btnHW1Hello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gold;
            this.splitContainer1.Panel1.BackgroundImage = global::Cshop_Homework_Collection.Properties.Resources.TOP_F;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 1041);
            this.splitContainer1.SplitterDistance = 154;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(0, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1904, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "張芷瑄 2023/06";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1904, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# Homeworks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.BackgroundImage = global::Cshop_Homework_Collection.Properties.Resources.HomePage_Left;
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.btnAlarm);
            this.splitContainer2.Panel1.Controls.Add(this.btnGuessNumber);
            this.splitContainer2.Panel1.Controls.Add(this.btnPictureViewer);
            this.splitContainer2.Panel1.Controls.Add(this.btnScreenServer);
            this.splitContainer2.Panel1.Controls.Add(this.btnCalaulator);
            this.splitContainer2.Panel1.Controls.Add(this.btnHW3POS);
            this.splitContainer2.Panel1.Controls.Add(this.btnHW2Loan);
            this.splitContainer2.Panel1.Controls.Add(this.btnHW1Hello);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = global::Cshop_Homework_Collection.Properties.Resources.HomePage_Right2;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1904, 880);
            this.splitContainer2.SplitterDistance = 428;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlarm.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnAlarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnAlarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarm.ForeColor = System.Drawing.Color.Wheat;
            this.btnAlarm.Location = new System.Drawing.Point(140, 564);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(141, 32);
            this.btnAlarm.TabIndex = 8;
            this.btnAlarm.Text = "Alarm";
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnGuessNumber
            // 
            this.btnGuessNumber.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnGuessNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuessNumber.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnGuessNumber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnGuessNumber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnGuessNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuessNumber.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessNumber.ForeColor = System.Drawing.Color.Wheat;
            this.btnGuessNumber.Location = new System.Drawing.Point(133, 655);
            this.btnGuessNumber.Name = "btnGuessNumber";
            this.btnGuessNumber.Size = new System.Drawing.Size(141, 32);
            this.btnGuessNumber.TabIndex = 7;
            this.btnGuessNumber.Text = "Guess Number";
            this.btnGuessNumber.UseVisualStyleBackColor = false;
            this.btnGuessNumber.Click += new System.EventHandler(this.btnGuessNumber_Click);
            // 
            // btnPictureViewer
            // 
            this.btnPictureViewer.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnPictureViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPictureViewer.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnPictureViewer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnPictureViewer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnPictureViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPictureViewer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictureViewer.ForeColor = System.Drawing.Color.Wheat;
            this.btnPictureViewer.Location = new System.Drawing.Point(143, 479);
            this.btnPictureViewer.Name = "btnPictureViewer";
            this.btnPictureViewer.Size = new System.Drawing.Size(141, 32);
            this.btnPictureViewer.TabIndex = 6;
            this.btnPictureViewer.Text = "Picture Viewer";
            this.btnPictureViewer.UseVisualStyleBackColor = false;
            this.btnPictureViewer.Click += new System.EventHandler(this.btnPictureViewer_Click);
            // 
            // btnScreenServer
            // 
            this.btnScreenServer.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnScreenServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScreenServer.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnScreenServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnScreenServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnScreenServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenServer.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenServer.ForeColor = System.Drawing.Color.Wheat;
            this.btnScreenServer.Location = new System.Drawing.Point(152, 382);
            this.btnScreenServer.Name = "btnScreenServer";
            this.btnScreenServer.Size = new System.Drawing.Size(141, 32);
            this.btnScreenServer.TabIndex = 4;
            this.btnScreenServer.Text = "Screen Server";
            this.btnScreenServer.UseVisualStyleBackColor = false;
            this.btnScreenServer.Click += new System.EventHandler(this.btnScreenServer_Click);
            // 
            // btnCalaulator
            // 
            this.btnCalaulator.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCalaulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalaulator.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnCalaulator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnCalaulator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnCalaulator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalaulator.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalaulator.ForeColor = System.Drawing.Color.Wheat;
            this.btnCalaulator.Location = new System.Drawing.Point(143, 282);
            this.btnCalaulator.Name = "btnCalaulator";
            this.btnCalaulator.Size = new System.Drawing.Size(141, 32);
            this.btnCalaulator.TabIndex = 3;
            this.btnCalaulator.Text = "Calaulator";
            this.btnCalaulator.UseVisualStyleBackColor = false;
            this.btnCalaulator.Click += new System.EventHandler(this.btnCalaulator_Click);
            // 
            // btnHW3POS
            // 
            this.btnHW3POS.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnHW3POS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHW3POS.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnHW3POS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnHW3POS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnHW3POS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHW3POS.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHW3POS.ForeColor = System.Drawing.Color.Wheat;
            this.btnHW3POS.Location = new System.Drawing.Point(134, 190);
            this.btnHW3POS.Name = "btnHW3POS";
            this.btnHW3POS.Size = new System.Drawing.Size(141, 32);
            this.btnHW3POS.TabIndex = 2;
            this.btnHW3POS.Text = "POS";
            this.btnHW3POS.UseVisualStyleBackColor = false;
            this.btnHW3POS.Click += new System.EventHandler(this.btnHW3POS_Click);
            // 
            // btnHW2Loan
            // 
            this.btnHW2Loan.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnHW2Loan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHW2Loan.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnHW2Loan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnHW2Loan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnHW2Loan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHW2Loan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHW2Loan.ForeColor = System.Drawing.Color.Wheat;
            this.btnHW2Loan.Location = new System.Drawing.Point(134, 113);
            this.btnHW2Loan.Name = "btnHW2Loan";
            this.btnHW2Loan.Size = new System.Drawing.Size(141, 32);
            this.btnHW2Loan.TabIndex = 1;
            this.btnHW2Loan.Text = "Loan";
            this.btnHW2Loan.UseVisualStyleBackColor = false;
            this.btnHW2Loan.Click += new System.EventHandler(this.btnHW2Loan_Click);
            // 
            // btnHW1Hello
            // 
            this.btnHW1Hello.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnHW1Hello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHW1Hello.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnHW1Hello.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnHW1Hello.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnHW1Hello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHW1Hello.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHW1Hello.ForeColor = System.Drawing.Color.Wheat;
            this.btnHW1Hello.Location = new System.Drawing.Point(140, 43);
            this.btnHW1Hello.Name = "btnHW1Hello";
            this.btnHW1Hello.Size = new System.Drawing.Size(141, 32);
            this.btnHW1Hello.TabIndex = 0;
            this.btnHW1Hello.Text = "Hello";
            this.btnHW1Hello.UseVisualStyleBackColor = false;
            this.btnHW1Hello.Click += new System.EventHandler(this.btnHW1Hello_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnHW1Hello;
        private System.Windows.Forms.Button btnHW2Loan;
        private System.Windows.Forms.Button btnHW3POS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPictureViewer;
        private System.Windows.Forms.Button btnScreenServer;
        private System.Windows.Forms.Button btnCalaulator;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnGuessNumber;
    }
}