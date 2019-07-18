using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assig4
{
    public partial class Form2 : Form
    {
        List<Customer> customers = new List<Customer>();
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = customers;
            //Address.StreetNumber=
            customers.Add(new Customer(txtFirst.Text,txtLast.Text,new Address(txtStreetNO.Text, txtAppt.Text,txtStreetNm.Text,txtCity.Text,txtProvi.Text,txtPost.Text,txtPhone.Text)));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            customers = Branch.GetCustomer();
            dataGridView1.DataSource = customers;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
