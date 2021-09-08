using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jschell1c1
{
    public partial class Jschell1c1 : Form
    {
        public Jschell1c1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hamburgerstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            txtHotdogSubtotal.Text = (
                4.0m * Convert.ToDecimal(txtHotdogs.Text)
                ).ToString("0.00");
            
            txtHamburgersSubtotal.Text = (
               5.0m * Convert.ToDecimal(txtHamburgers.Text)
               ).ToString("0.00");

            txtPretax.Text = (
                              Convert.ToDecimal(txtHamburgersSubtotal.Text) 
                            + Convert.ToDecimal(txtHotdogSubtotal.Text))
                            .ToString("0.00");
           
            txtTax.Text =( .08675m
                * Convert.ToDecimal(txtPretax.Text))
                .ToString("0.00");
          
            txtTotal.Text =(Convert.ToDecimal(txtTax.Text) +
               Convert.ToDecimal(txtPretax.Text)).ToString("0.00")


                


                ;
            
            
            
            btnClear.Focus();
        }

        private void txtPretax_TextChanged(object sender, EventArgs e)
        {
           


                
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotdogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotdogSubtotal.Text="";
            txtHamburgersSubtotal.Text="";
            txtPretax.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtHotdogs.Focus();
        }
    }
}
