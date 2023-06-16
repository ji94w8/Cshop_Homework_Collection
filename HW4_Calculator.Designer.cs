namespace Cshop_Homework_Collection
{
    partial class HW4_Calculator
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDevidedBy = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.labNumber1 = new System.Windows.Forms.Label();
            this.labNumber2 = new System.Windows.Forms.Label();
            this.labAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.Location = new System.Drawing.Point(299, 32);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(67, 34);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.Location = new System.Drawing.Point(299, 72);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(67, 34);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDevidedBy
            // 
            this.btnDevidedBy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDevidedBy.Location = new System.Drawing.Point(299, 152);
            this.btnDevidedBy.Name = "btnDevidedBy";
            this.btnDevidedBy.Size = new System.Drawing.Size(67, 34);
            this.btnDevidedBy.TabIndex = 3;
            this.btnDevidedBy.Text = "/";
            this.btnDevidedBy.UseVisualStyleBackColor = true;
            this.btnDevidedBy.Click += new System.EventHandler(this.btnDevidedBy_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTimes.Location = new System.Drawing.Point(299, 112);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(67, 34);
            this.btnTimes.TabIndex = 2;
            this.btnTimes.Text = "*";
            this.btnTimes.UseVisualStyleBackColor = true;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // labNumber1
            // 
            this.labNumber1.AutoSize = true;
            this.labNumber1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumber1.Location = new System.Drawing.Point(68, 66);
            this.labNumber1.Name = "labNumber1";
            this.labNumber1.Size = new System.Drawing.Size(59, 19);
            this.labNumber1.TabIndex = 4;
            this.labNumber1.Text = "Num 1: ";
            // 
            // labNumber2
            // 
            this.labNumber2.AutoSize = true;
            this.labNumber2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumber2.Location = new System.Drawing.Point(68, 102);
            this.labNumber2.Name = "labNumber2";
            this.labNumber2.Size = new System.Drawing.Size(59, 19);
            this.labNumber2.TabIndex = 5;
            this.labNumber2.Text = "Num 2: ";
            // 
            // labAnswer
            // 
            this.labAnswer.AutoSize = true;
            this.labAnswer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAnswer.Location = new System.Drawing.Point(67, 152);
            this.labAnswer.Name = "labAnswer";
            this.labAnswer.Size = new System.Drawing.Size(60, 19);
            this.labAnswer.TabIndex = 6;
            this.labAnswer.Text = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "===================================";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber1.Location = new System.Drawing.Point(145, 63);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 27);
            this.txtNumber1.TabIndex = 8;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber2.Location = new System.Drawing.Point(145, 99);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 27);
            this.txtNumber2.TabIndex = 9;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(145, 149);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 27);
            this.txtAnswer.TabIndex = 10;
            // 
            // HW4_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 217);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labAnswer);
            this.Controls.Add(this.labNumber2);
            this.Controls.Add(this.labNumber1);
            this.Controls.Add(this.btnDevidedBy);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Name = "HW4_Calculator";
            this.Text = "HW4_Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDevidedBy;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Label labNumber1;
        private System.Windows.Forms.Label labNumber2;
        private System.Windows.Forms.Label labAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtAnswer;
    }
}