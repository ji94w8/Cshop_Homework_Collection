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
    public partial class HW2_LoanReport : Form
    {

        private HW2_Loan LoanForm;
        private decimal LoanAmount;
        private decimal YearNo;
        private decimal Rate;
        private decimal MonthPay;
        private decimal TotalPay;

        public HW2_LoanReport(HW2_Loan form, decimal loanamount, decimal yearno, decimal rate, decimal monthpay, decimal totalpay)
        {
            InitializeComponent();
            LoanForm = form;
            LoanAmount = loanamount;
            YearNo = yearno;
            Rate = rate;
            MonthPay = monthpay;
            TotalPay = totalpay;
            
        }

        private void HW1_City_Click(object sender, EventArgs e)
        {
            
        }

        private void HW1_Sex_Click(object sender, EventArgs e)
        {

        }

        private void HW1_Sign_Click(object sender, EventArgs e)
        {

        }

        private void HW1_Name_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void HW2_LoanReport_Load(object sender, EventArgs e)
        {
            LoanForm.LoanCaculate();

            labAmount.Text = LoanAmount.ToString();
            labYearNo.Text = YearNo.ToString();
            labRate.Text = Rate.ToString();
            labMonthPay.Text = MonthPay.ToString();
            labTotalPay.Text = TotalPay.ToString();



        }

       
    }
}
