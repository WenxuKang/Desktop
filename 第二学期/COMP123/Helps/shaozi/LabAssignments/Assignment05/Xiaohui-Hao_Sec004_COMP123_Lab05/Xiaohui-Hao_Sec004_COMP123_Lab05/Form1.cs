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

namespace Xiaohui_Hao_Sec004_COMP123_Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = 0; 
            string[] fileName = { "\\LetterToIRS.txt", "\\NoteToDad.txt",
                                  "\\ShoppingList.txt", "\\ThingsToTakeCamping.txt"};
            string directoryName;

            //directoryName = Directory.GetCurrentDirectory();

            directoryName = @"C:\Lab05_TextFiles";

            for (i=0; i < checkedListBox1.Items.Count; i++)
            {

            
            if (checkedListBox1.GetItemChecked(i))
            {
                Name = String.Format("{0}{1}", directoryName, fileName[i]);
                lblOutput.Text = Name + " was created " + File.GetCreationTime(Name);
            }
            else
                checkedListBox1.SelectedItems.Clear();
            }

        }
    }
}
