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
    public partial class HW2_Loan : Form
    {
        public HW2_Loan()
        {
            InitializeComponent();
        }
        decimal TotalPay;
        decimal MonthPay;


        public void LoanCaculate()
        {
            
            decimal avgRateMonth;
            decimal Amount = decimal.Parse(txt_HW2_Amount.Text);
            decimal YearNo = decimal.Parse(txt_HW2_YearNo.Text);
            decimal DownPay = decimal.Parse(txt_HW2_DownPayment.Text);
            decimal Rate = num_Rate.Value / 100;
            decimal MonthNo = YearNo * 12;
            decimal RateMonth = Rate / 12;

            // (1+月利率)^月數
            decimal RatePlus = (decimal)Math.Pow(1 + (double)RateMonth, (double)MonthNo);

            //每月本息平均攤還率
            avgRateMonth = (RatePlus * RateMonth) / (RatePlus - 1);

            //每月還款金額
            MonthPay = Math.Round((Amount - DownPay) * avgRateMonth);

            //總付款額
            TotalPay = Math.Round(MonthPay * MonthNo);
        }

        public void btn_TotalPay_Click(object sender, EventArgs e)
        {
            LoanCaculate();

            MessageBox.Show("總付款: " + TotalPay + " 元");
        }

        private void txt_HW2_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_HW2_YearNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_HW2_DownPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_PayByMonth_Click(object sender, EventArgs e)
        {
            LoanCaculate();

            MessageBox.Show("每月應付款: " +  MonthPay + " 元");
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            
            decimal LoanAmount = decimal.Parse(txt_HW2_Amount.Text)-decimal.Parse(txt_HW2_DownPayment.Text);
            decimal YearNo = decimal.Parse(txt_HW2_YearNo.Text);
            decimal Rate = num_Rate.Value;
            LoanCaculate();

            HW2_LoanReport form = new HW2_LoanReport(this, LoanAmount, YearNo, Rate, MonthPay, TotalPay);
            form.Show();
        }

        private void HW2_Loan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
