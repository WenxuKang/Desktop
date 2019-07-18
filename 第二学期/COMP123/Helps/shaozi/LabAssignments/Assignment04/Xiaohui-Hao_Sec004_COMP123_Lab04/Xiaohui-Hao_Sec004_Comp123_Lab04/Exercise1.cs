using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xiaohui_Hao_Sec004_Comp123_Lab04
{
    public partial class Excercise1 : Form
    {
        public Excercise1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //local variables
            double num1, num2, result;

            //extracting the values from text boxes
            try
            {
                num1 = Convert.ToDouble(txtNum01.Text);
                num2 = Convert.ToDouble(txtNum02.Text);

                //calculating the result
                result = num1 + num2;

                //Assigning it to label
                lblOutput.Text = result.ToString();
            }//end try

            catch (Exception ex)
            {
                lblOutput.Text = "Error:" + ex.Message;
            }//end catch
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            try
            {
                num1 = Convert.ToDouble(txtNum01.Text);
                num2 = Convert.ToDouble(txtNum02.Text);
                result = num1 - num2;
                lblOutput.Text = result.ToString();
            }

            catch (Exception ex)
            {
                lblOutput.Text = "Error:" + ex.Message;
            }
            
        }

        private void btnMpy_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            try
            {
                num1 = Convert.ToDouble(txtNum01.Text);
                num2 = Convert.ToDouble(txtNum02.Text);
                result = num1 * num2;
                lblOutput.Text = result.ToString();
            }

            catch (Exception ex)
            {
                lblOutput.Text = "Error:" + ex.Message;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            try
            {
                num1 = Convert.ToDouble(txtNum01.Text);
                num2 = Convert.ToDouble(txtNum02.Text);
                result = num1 / num2;
                lblOutput.Text = result.ToString();
            }

            catch (Exception ex)
            {
                lblOutput.Text = "Error:" + ex.Message;
            }
        }
    }
}
