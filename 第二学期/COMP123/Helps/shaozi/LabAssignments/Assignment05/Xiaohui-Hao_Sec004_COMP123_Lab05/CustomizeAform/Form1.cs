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

namespace CustomizeAform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoDarkSalmon_CheckedChanged(object sender, EventArgs e)
        {
           
            this.BackColor = Color.DarkSalmon;
        }

        private void rdoBeige_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBeige.Checked)
            this.BackColor = Color.Beige;
        }
        
        private void rdoCornflowerBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCornflowerBlue.Checked)
            this.BackColor = Color.CornflowerBlue;
        }

        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSmall.Checked)
            this.Size = new Size(600, 400);
        }

        private void rdoLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLarge.Checked)
            this.Size = new Size(900, 600);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            this.Text = txtTitle.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            const string FILENAME = @"C:\Lab05_Textfiles\customizForm.txt";
            FileStream outFile = new FileStream(FILENAME, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            if (rdoDarkSalmon.Checked)
                writer.WriteLine("Background of Form: {0}", rdoDarkSalmon.Text);
            if (rdoBeige.Checked)
                writer.WriteLine("Background of Form: {0}", rdoBeige.Text);
            if (rdoCornflowerBlue.Checked)
                writer.WriteLine("Background of Form: {0}", rdoCornflowerBlue.Text);
            if (rdoSmall.Checked)
                writer.WriteLine("Form size is: {0}", rdoSmall.Text);
            if (rdoLarge.Checked)
                writer.WriteLine("Form size is: {0}", rdoLarge.Text);
            writer.WriteLine("Form name is:{0}", txtTitle.Text);

            writer.Close();
            outFile.Close();


        }
    }
}
