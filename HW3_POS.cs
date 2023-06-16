using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshop_Homework_Collection
{
    public partial class HW3_POS : Form
    {
        public HW3_POS()
        {
            InitializeComponent();
        }

        int clickTimesPikachu = 0;
        int clickTimesWinnie = 0;
        int clickTimesSponge = 0;
        int clickTimesGudetama = 0;

        int pricePikachu = 200;
        int priceWinnie = 120;
        int priceSponge = 150;
        int priceGudetama = 180;

        string recordPikachu = "";
        string recordWinnie = "";
        string recordSponge = "";
        string recordGudetama = "";

        int TotalPrice = 0;


        private void brnPikachu_Click(object sender, EventArgs e)
        {
            lablist.Text = "";
            clickTimesPikachu++;
            recordPikachu = $"皮卡丘 x{clickTimesPikachu}, 共{clickTimesPikachu * pricePikachu:C0}元\n";
            lablist.Text += recordPikachu + recordWinnie + recordSponge + recordGudetama;
            TotalPrice = clickTimesPikachu * pricePikachu + clickTimesWinnie * priceWinnie + clickTimesSponge * priceSponge + clickTimesGudetama * priceGudetama;
            labTotalPrice.Text = $"{TotalPrice:C0}";

        }

        private void btnWinnie_Click(object sender, EventArgs e)
        {
            lablist.Text = "";
            clickTimesWinnie++;
            recordWinnie = $"小熊維尼 x{clickTimesWinnie}, 共{clickTimesWinnie * priceWinnie:C0}元\n";
            lablist.Text += recordPikachu + recordWinnie + recordSponge  + recordGudetama;
            TotalPrice = clickTimesPikachu * pricePikachu + clickTimesWinnie * priceWinnie + clickTimesSponge * priceSponge + clickTimesGudetama * priceGudetama;
            labTotalPrice.Text = $"{TotalPrice:C0}";
        }

        private void btnSponge_Click(object sender, EventArgs e)
        {
            lablist.Text = "";
            clickTimesSponge++;
            recordSponge = $"海綿寶寶 x{clickTimesSponge}, 共{clickTimesSponge * priceSponge:C0}元\n";
            lablist.Text += recordPikachu + recordWinnie + recordSponge + recordGudetama;
            TotalPrice = clickTimesPikachu * pricePikachu + clickTimesWinnie * priceWinnie + clickTimesSponge * priceSponge + clickTimesGudetama * priceGudetama;
            labTotalPrice.Text = $"{TotalPrice:C0}";
        }

        private void btnGudetama_Click(object sender, EventArgs e)
        {
            lablist.Text = "";
            clickTimesGudetama++;
            recordGudetama = $"蛋黃哥 x{clickTimesGudetama}, 共{clickTimesGudetama * priceGudetama:C0}元\n";
            lablist.Text += recordPikachu + recordWinnie + recordSponge + recordGudetama;
            TotalPrice = clickTimesPikachu * pricePikachu + clickTimesWinnie * priceWinnie + clickTimesSponge * priceSponge + clickTimesGudetama * priceGudetama;
            labTotalPrice.Text = $"{TotalPrice:C0}";
        }

        private void HW3_POS_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lablist.Text = "";
            clickTimesGudetama = 0;
            clickTimesPikachu = 0;
            clickTimesSponge = 0;
            clickTimesWinnie = 0;
            labTotalPrice.Text = "NT$ 0";
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額: {TotalPrice:C0}\n折扣後金額: {TotalPrice*0.9:C0}");
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"總金額: {TotalPrice:C0}");
        }
    }
}
