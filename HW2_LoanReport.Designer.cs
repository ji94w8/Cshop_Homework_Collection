namespace Cshop_Homework_Collection
{
    partial class HW2_LoanReport
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
            this.HW1_Name = new System.Windows.Forms.Label();
            this.HW1_Sign = new System.Windows.Forms.Label();
            this.HW1_Sex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labAmount = new System.Windows.Forms.Label();
            this.labYearNo = new System.Windows.Forms.Label();
            this.labMonthPay = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labTotalPay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HW1_Name
            // 
            this.HW1_Name.AutoSize = true;
            this.HW1_Name.BackColor = System.Drawing.Color.Transparent;
            this.HW1_Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HW1_Name.Location = new System.Drawing.Point(30, 36);
            this.HW1_Name.Name = "HW1_Name";
            this.HW1_Name.Size = new System.Drawing.Size(96, 24);
            this.HW1_Name.TabIndex = 12;
            this.HW1_Name.Text = "貸款金額: ";
            this.HW1_Name.Click += new System.EventHandler(this.HW1_Name_Click);
            // 
            // HW1_Sign
            // 
            this.HW1_Sign.AutoSize = true;
            this.HW1_Sign.BackColor = System.Drawing.Color.Transparent;
            this.HW1_Sign.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HW1_Sign.Location = new System.Drawing.Point(30, 144);
            this.HW1_Sign.Name = "HW1_Sign";
            this.HW1_Sign.Size = new System.Drawing.Size(77, 24);
            this.HW1_Sign.TabIndex = 13;
            this.HW1_Sign.Text = "月付款: ";
            this.HW1_Sign.Click += new System.EventHandler(this.HW1_Sign_Click);
            // 
            // HW1_Sex
            // 
            this.HW1_Sex.AutoSize = true;
            this.HW1_Sex.BackColor = System.Drawing.Color.Transparent;
            this.HW1_Sex.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HW1_Sex.Location = new System.Drawing.Point(30, 108);
            this.HW1_Sex.Name = "HW1_Sex";
            this.HW1_Sex.Size = new System.Drawing.Size(89, 24);
            this.HW1_Sex.TabIndex = 14;
            this.HW1_Sex.Text = "利率(%): ";
            this.HW1_Sex.Click += new System.EventHandler(this.HW1_Sex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "期限(年): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(30, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "總付款: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labAmount.Location = new System.Drawing.Point(147, 36);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(2, 21);
            this.labAmount.TabIndex = 17;
            // 
            // labYearNo
            // 
            this.labYearNo.AutoSize = true;
            this.labYearNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labYearNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labYearNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labYearNo.Location = new System.Drawing.Point(147, 72);
            this.labYearNo.Name = "labYearNo";
            this.labYearNo.Size = new System.Drawing.Size(2, 21);
            this.labYearNo.TabIndex = 18;
            this.labYearNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labMonthPay
            // 
            this.labMonthPay.AutoSize = true;
            this.labMonthPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labMonthPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMonthPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labMonthPay.Location = new System.Drawing.Point(147, 144);
            this.labMonthPay.Name = "labMonthPay";
            this.labMonthPay.Size = new System.Drawing.Size(2, 21);
            this.labMonthPay.TabIndex = 20;
            this.labMonthPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labRate.Location = new System.Drawing.Point(147, 108);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(2, 21);
            this.labRate.TabIndex = 19;
            this.labRate.Click += new System.EventHandler(this.label6_Click);
            // 
            // labTotalPay
            // 
            this.labTotalPay.AutoSize = true;
            this.labTotalPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labTotalPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPay.Location = new System.Drawing.Point(147, 180);
            this.labTotalPay.Name = "labTotalPay";
            this.labTotalPay.Size = new System.Drawing.Size(2, 21);
            this.labTotalPay.TabIndex = 21;
            this.labTotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HW2_LoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 234);
            this.Controls.Add(this.labTotalPay);
            this.Controls.Add(this.labMonthPay);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labYearNo);
            this.Controls.Add(this.labAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HW1_Sex);
            this.Controls.Add(this.HW1_Sign);
            this.Controls.Add(this.HW1_Name);
            this.Name = "HW2_LoanReport";
            this.Text = "HW2_LoanReport";
            this.Load += new System.EventHandler(this.HW2_LoanReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HW1_Name;
        private System.Windows.Forms.Label HW1_Sign;
        private System.Windows.Forms.Label HW1_Sex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.Label labYearNo;
        private System.Windows.Forms.Label labMonthPay;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labTotalPay;
    }
}