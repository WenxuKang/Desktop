using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomizeAForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxBGC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = (string)comboBoxBGC.SelectedItem;
            this.BackColor = System.Drawing.Color.FromName(color);
        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(numSize.Value);
            label2.Font =  new System.Drawing.Font(label2.Font.Name, size);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            this.Text = txtTitle.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataFile = @"C:\Users\Zyili\Documents\Winter2018\COMP123-004\Assignment\YiLin-Zhao_Sec004_COMP123_Lab05\CustomizeAForm\bin\Debug\FormData.txt";
            FileStream outFile = new FileStream(dataFile, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            writer.WriteLine("Back Ground Color: {0}", (string)comboBoxBGC.SelectedItem);
            writer.WriteLine("Font Size: {0}", numSize.Value);
            writer.WriteLine("Title: {0}", txtTitle.Text);
            writer.Close();
            outFile.Close();
            button1.Enabled = false;
            comboBoxBGC.Enabled = false;
            numSize.Enabled = false;
            txtTitle.Enabled = false;
        }
    }
}
