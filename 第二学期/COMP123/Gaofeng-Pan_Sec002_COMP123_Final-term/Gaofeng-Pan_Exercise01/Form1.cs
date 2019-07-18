using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaofeng_Pan_Exercise01
{
    public partial class Form1 : Form
    {
        double price1;
        double price2;
        double price3;
        double result;
        string purchaseType;
        string ctype;
        const double discount = 0.15;

        public Form1()
        {
            InitializeComponent();
        }

        private void comType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctype = (string)comType.SelectedItem;
        }

        private void cheMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (cheMouse.Checked)
                price1 = Convert.ToDouble(lbl30.Text);
            else
                price1 = 0;
        }

        private void cheKeyboard_CheckedChanged(object sender, EventArgs e)
        {

            if (cheKeyboard.Checked)
                price2 = Convert.ToDouble(lbl50.Text);
            else
                price2 = 0;
        }

        private void chePrinter_CheckedChanged(object sender, EventArgs e)
        {
            if (chePrinter.Checked)
                price3 = Convert.ToDouble(lbl80.Text);
            else
                price3 = 0;
        }

        private void lblOutputSub_Click(object sender, EventArgs e)
        {

            result = price1 + price2 + price3;

            lblOutputSub.Text = result.ToString();
        }

        private void lblOutputTax_Click(object sender, EventArgs e)
        {
            double tax;
            tax = result * 0.05;
            lblOutputTax.Text = tax.ToString();
        }

        private void lblOutputTotal_Click(object sender, EventArgs e)
        {
            double total;
            total = Convert.ToDouble(lblOutputSub.Text) - Convert.ToDouble(
                lblOutputDiscount.Text) + Convert.ToDouble(lblOutputTax.Text);
            lblOutputTotal.Text = total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }

        private void radEdu_CheckedChanged(object sender, EventArgs e)
        {

            if (radEdu.Checked)
                purchaseType = "Educational";
        }

        private void radBus_CheckedChanged(object sender, EventArgs e)
        {
            if (radBus.Checked)
                purchaseType = "Business";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtName.Text + "," + txtEmail.Text + "," + txtAddress.Text + ","
                + purchaseType + ctype + lblOutputTotal.Text;
        }

        private void lblOutputDiscount_Click(object sender, EventArgs e)
        {
            if (ctype == "Student")

                lblOutputDiscount.Text = discount.ToString();

            if (ctype == "Teacher")

                lblOutputDiscount.Text = discount.ToString();
        }
    }
}
