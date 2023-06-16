namespace Cshop_Homework_Collection
{
    partial class HW2_Loan
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
            this.txt_HW2_DownPayment = new System.Windows.Forms.TextBox();
            this.txt_HW2_YearNo = new System.Windows.Forms.TextBox();
            this.txt_HW2_Amount = new System.Windows.Forms.TextBox();
            this.HW1_City = new System.Windows.Forms.Label();
            this.HW1_Sex = new System.Windows.Forms.Label();
            this.HW1_Sign = new System.Windows.Forms.Label();
            this.HW1_Name = new System.Windows.Forms.Label();
            this.btn_PayByMonth = new System.Windows.Forms.Button();
            this.btn_TotalPay = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.num_Rate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_Rate)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_HW2_DownPayment
            // 
            this.txt_HW2_DownPayment.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_HW2_DownPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_HW2_DownPayment.Location = new System.Drawing.Point(127, 120);
            this.txt_HW2_DownPayment.Name = "txt_HW2_DownPayment";
            this.txt_HW2_DownPayment.Size = new System.Drawing.Size(121, 29);
            this.txt_HW2_DownPayment.TabIndex = 15;
            this.txt_HW2_DownPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_HW2_DownPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HW2_DownPayment_KeyPress);
            // 
            // txt_HW2_YearNo
            // 
            this.txt_HW2_YearNo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_HW2_YearNo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_HW2_YearNo.Location = new System.Drawing.Point(127, 51);
            this.txt_HW2_YearNo.Name = "txt_HW2_YearNo";
            this.txt_HW2_YearNo.Size = new System.Drawing.Size(121, 29);
            this.txt_HW2_YearNo.TabIndex = 13;
            this.txt_HW2_YearNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_HW2_YearNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HW2_YearNo_KeyPress);
            // 
            // txt_HW2_Amount
            // 
            this.txt_HW2_Amount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_HW2_Amount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_HW2_Amount.Location = new System.Drawing.Point(127, 16);
            this.txt_HW2_Amount.Name = "txt_HW2_Amount";
            this.txt_HW2_Amount.Size = new System.Drawing.Size(121, 29);
            this.txt_HW2_Amount.TabIndex = 12;
            this.txt_HW2_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_HW2_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HW2_Amount_KeyPress);
            // 
            // HW1_City
            // 
            this.HW1_City.AutoSize = true;
            this.HW1_City.BackColor = System.Drawing.Color.Transparent;
            this.HW1_City.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HW1_City.Location = new System.Drawing.Point(25, 56);
            this.HW1_City.Name = "HW1_City";
            this.HW1_City.Size = new System.Drawing.Size(96, 24);
            this.HW1_City.TabIndex = 11;
            this.HW1_City.Text = "貸款年數: ";
            // 
            // HW1_Sex
            // 
            this.HW1_Sex.AutoSize = true;
            this.HW1_Sex.BackColor = System.Drawing.Color.Transparent;
            this.HW1_Sex.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HW1_Sex.Location = new System.Drawing.Point(25, 90);
            this.HW1_Sex.Name = "HW1_Sex";
            this.HW1_Sex.Size = new System.Drawing.Size(77, 24);
            this.HW1_Sex.TabIndex = 10;
            this.HW1_Sex.Text = "年利率: ";
            // 
            // HW1_Sign
            // 
            this.HW1_Sign.AutoSize = true;
            this.HW1_Sign.BackColor = System.Drawing.Color.Transparent;
            this.HW1_Sign.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HW1_Sign.Location = new System.Drawing.Point(25, 125);
            this.HW1_Sign.Name = "HW1_Sign";
            this.HW1_Sign.Size = new System.Drawing.Size(77, 24);
            this.HW1_Sign.TabIndex = 9;
            this.HW1_Sign.Text = "頭期款: ";
            // 
            // HW1_Name
            // 
            this.HW1_Name.AutoSize = true;
            this.HW1_Name.BackColor = System.Drawing.Color.Transparent;
            this.HW1_Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HW1_Name.Location = new System.Drawing.Point(25, 21);
            this.HW1_Name.Name = "HW1_Name";
            this.HW1_Name.Size = new System.Drawing.Size(96, 24);
            this.HW1_Name.TabIndex = 8;
            this.HW1_Name.Text = "貸款金額: ";
            // 
            // btn_PayByMonth
            // 
            this.btn_PayByMonth.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_PayByMonth.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PayByMonth.Location = new System.Drawing.Point(29, 165);
            this.btn_PayByMonth.Name = "btn_PayByMonth";
            this.btn_PayByMonth.Size = new System.Drawing.Size(100, 31);
            this.btn_PayByMonth.TabIndex = 16;
            this.btn_PayByMonth.Text = "PMT (月付)";
            this.btn_PayByMonth.UseVisualStyleBackColor = true;
            this.btn_PayByMonth.Click += new System.EventHandler(this.btn_PayByMonth_Click);
            // 
            // btn_TotalPay
            // 
            this.btn_TotalPay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_TotalPay.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TotalPay.Location = new System.Drawing.Point(148, 165);
            this.btn_TotalPay.Name = "btn_TotalPay";
            this.btn_TotalPay.Size = new System.Drawing.Size(100, 31);
            this.btn_TotalPay.TabIndex = 17;
            this.btn_TotalPay.Text = "總付款";
            this.btn_TotalPay.UseVisualStyleBackColor = true;
            this.btn_TotalPay.Click += new System.EventHandler(this.btn_TotalPay_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Report.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.Location = new System.Drawing.Point(29, 202);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(219, 31);
            this.btn_Report.TabIndex = 18;
            this.btn_Report.Text = "產生報表";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // num_Rate
            // 
            this.num_Rate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Rate.Location = new System.Drawing.Point(127, 87);
            this.num_Rate.Name = "num_Rate";
            this.num_Rate.Size = new System.Drawing.Size(121, 27);
            this.num_Rate.TabIndex = 19;
            this.num_Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HW2_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 258);
            this.Controls.Add(this.num_Rate);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_TotalPay);
            this.Controls.Add(this.btn_PayByMonth);
            this.Controls.Add(this.txt_HW2_DownPayment);
            this.Controls.Add(this.txt_HW2_YearNo);
            this.Controls.Add(this.txt_HW2_Amount);
            this.Controls.Add(this.HW1_City);
            this.Controls.Add(this.HW1_Sex);
            this.Controls.Add(this.HW1_Sign);
            this.Controls.Add(this.HW1_Name);
            this.Name = "HW2_Loan";
            this.Text = "貸款金額試算";
            this.Click += new System.EventHandler(this.HW2_Loan_Click);
            ((System.ComponentModel.ISupportInitialize)(this.num_Rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_HW2_DownPayment;
        private System.Windows.Forms.TextBox txt_HW2_YearNo;
        private System.Windows.Forms.TextBox txt_HW2_Amount;
        private System.Windows.Forms.Label HW1_City;
        private System.Windows.Forms.Label HW1_Sex;
        private System.Windows.Forms.Label HW1_Sign;
        private System.Windows.Forms.Label HW1_Name;
        private System.Windows.Forms.Button btn_PayByMonth;
        private System.Windows.Forms.Button btn_TotalPay;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.NumericUpDown num_Rate;
    }
}