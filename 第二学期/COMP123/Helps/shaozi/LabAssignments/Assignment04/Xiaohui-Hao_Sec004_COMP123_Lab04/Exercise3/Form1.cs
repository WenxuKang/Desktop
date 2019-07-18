using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.Font = new Font("Courier New", 16);
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.Font = new Font("Courier New", 10);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.Font = new Font("Courier New", 14);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.ForeColor = Color.Blue;
            lblOutput.BackColor = Color.LightGray;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.ForeColor = Color.Green;
            lblOutput.BackColor = Color.LightGray;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.ForeColor = Color.Red;
            lblOutput.BackColor = Color.LightGray;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOutput.ForeColor = Color.Yellow;
            lblOutput.BackColor = Color.LightGray;
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(lblOutput.Font, FontStyle.Underline);
            lblOutput.Font = newFont;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font newFont = new Font(lblOutput.Font, FontStyle.Bold);
            lblOutput.Font = newFont;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text.Replace("Hello",
                            "This is demonstration of Font, Color and Style.");
        }
    }
}
