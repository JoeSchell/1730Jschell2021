using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jschell1d1
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.73";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.014";
            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.0016";
            txtAmountEurope.Text = "0.00";
            txtRateEurope.Text = "0.85";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRateCostaRica_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
                   txtUSDAustralia.Text = (
                    Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
                    ).ToString("0.00");
        }

        private void txtAmountBhutan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountCostaRica_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountEurope_TextChanged(object sender, EventArgs e)
        {

        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                    Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtRateBhutan.Text)
                    ).ToString("0.00");
        }

        private void costaricaTextChanged(object sender, EventArgs e)
        {
            txtUSDCostaRica.Text = (
                    Convert.ToDecimal(txtAmountCostaRica.Text) * Convert.ToDecimal(txtRateCostaRica.Text)
                    ).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEurope.Text = (
                    Convert.ToDecimal(txtAmountEurope.Text) * Convert.ToDecimal(txtRateEurope.Text)
                    ).ToString("0.00");
        }

        private void USDTextChanged(object sender, EventArgs e)
        {
            txtUSDtotal.Text = (Convert.ToDecimal(txtUSDAustralia.Text) +
                Convert.ToDecimal(txtUSDCostaRica.Text) +  
                Convert.ToDecimal(txtUSDBhutan.Text) +
                Convert.ToDecimal(txtUSDEurope.Text)).ToString("0.00")
                ;
        }
    }
}
