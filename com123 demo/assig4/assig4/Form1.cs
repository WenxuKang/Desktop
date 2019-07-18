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
    public partial class Form1 : Form
    {
       static List<Bank> branch = new List<Bank>();
        int selectRow;
        BindingList<Bank> bingBranch = new BindingList<Bank>(branch);
        public Form1()
        {
            InitializeComponent();
           
            //branch = Bank.GetBranches();
            //dataGridView1.DataSource = branch;
            dataGridView1.DataSource = bingBranch;
        }

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bingBranch;

         bingBranch.Add(new Bank(txtBranches.Text));
            
            //dataGridView1.DataSource = branch;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //bingBranch = Bank.GetBranches();
            branch = Bank.GetBranches();
          /*  BindingList<Bank> */bingBranch= new BindingList<Bank>(branch);
            dataGridView1.DataSource = bingBranch;
           
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //DataGridViewSelectedCellCollection rows = dataGridView1.SelectedRows;
            //dataGridView1.DataSource = null;
            dataGridView1.DataSource = bingBranch;
            int index = dataGridView1.CurrentRow.Index;
            bingBranch.RemoveAt(index);
            //selectRow = dataGridView1.CurrentCell.RowIndex;

            //dataGridView1.DataSource = new BindingList<Bank>(new List<Bank>());
            //dataGridView1.DataSource=branch;
            //dataGridView1.Rows.RemoveAt(selectRow);
            ////branch.Remove(new Bank());
            //dataGridView1.Rows.RemoveAt(selectRow);

            //selectRow = dataGridView1.CurrentCell.RowIndex;
            //int branchId = (int)dataGridView1.Rows[selectRow].Cells[0].Value;
            //var branches = branch.FirstOrDefault(b => b.Id == branchId);
            //if (branches != null)
            //    branch.Remove(branches);
            //DataGridViewRow row = dataGridView1.Rows[selectRow];
            //branch = Bank.DelBranches(row.Cells[0].Value.ToString());
            ////selectRow= dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(selectRow);
            ////Bank.branches();
            //string item = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            //if (item!=null)
            //{
            //    int _id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value);
            //    foreach(Bank b in branch)
            //    {
            //        if (b.name == _id)
            //            b.name = "";
            //    }
            //}
            //string item = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            //if (item!=null&&dataGridView1.CurrentCell.ColumnIndex!=0)
            //{
            //    string _name = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value;
            //    var branches_Temp = branch.Where(w => w.name = _name).ToList();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectRow];
            txtBranches.Text = row.Cells[0].Value.ToString();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[selectRow];
            newDataRow.Cells[0].Value = txtBranches.Text;
        }
    }
}
