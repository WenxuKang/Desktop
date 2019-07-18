using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        private const double BASE_PRICE = 10.00;
        private const double TOPPING_PRICE_Veg = 1.00;
        private const double TOPPING_PRICE_NonVeg = 2.00;        
        private double price = BASE_PRICE;
        public Form1()
        {
            InitializeComponent();
        }

        private void OnionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnionCheckBox.Checked)
                price += TOPPING_PRICE_Veg;
            else
                price -= TOPPING_PRICE_Veg;
            lblOutput.Text = "Total Price is " + price.ToString("C");
        }

        private void GreenpeperCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenpeperCheckBox.Checked)
                price += TOPPING_PRICE_Veg;
            else
                price -= TOPPING_PRICE_Veg;
            lblOutput.Text = "Total Price is " + price.ToString("C");
        }

        private void PepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PepperoniCheckBox.Checked)
                price += TOPPING_PRICE_NonVeg;
            else
                price -= TOPPING_PRICE_NonVeg;
            lblOutput.Text = "Total Price is " + price.ToString("C");
        }

        private void SausageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SausageCheckBox.Checked)
                price += TOPPING_PRICE_NonVeg;
            else
                price -= TOPPING_PRICE_NonVeg;
            lblOutput.Text = "Total Price is " + price.ToString("C");
        }

        private void MushroomsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MushroomsCheckBox.Checked)
                price += TOPPING_PRICE_Veg;
            else
                price -= TOPPING_PRICE_Veg;
            lblOutput.Text = "Total Price is " + price.ToString("C");
        }

        private void TomatoesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TomatoesCheckBox.Checked)
                price += TOPPING_PRICE_Veg;
            else
                price -= TOPPING_PRICE_Veg;
            lblOutput.Text = "Total Price is " + price.ToString("C");
        }

        private void DeliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            const double DELIVERY_CHARGE = 5.00;
            if (DeliveryRadioButton.Checked)
                price += DELIVERY_CHARGE;
            else
                price -= DELIVERY_CHARGE;
            lblOutput.Text = "Total Price is " + price.ToString("C");
        }

        private void ExpressRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            const double EXPRESS_DELIVERY_CHARGE = 10.00;
            if (ExpressRadioButton.Checked)
                price += EXPRESS_DELIVERY_CHARGE;
            else
                price -= EXPRESS_DELIVERY_CHARGE;
            lblOutput.Text = "Total Price is " + price.ToString("C");
        }
    }
}
