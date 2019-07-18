using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selectedStu = new Student("", 0);
            selectedStu = (Student)listBox1.SelectedItem;
            lblOutput.Text = selectedStu.Name + "'s grade is " +
                selectedStu.Grade;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Student stu1 = new Student("Gordon", 90);
            Student stu2 = new Student("Nicolous",80 );
            Student stu3 = new Student("Anton", 70);
            listBox1.Items.AddRange(new Student[] { stu1, stu2, stu3 });
        }
        class Student
        {
            public string Name { get; set; }
            public double Grade { get; set; }
            public Student(string name, int grade)
            {
                Name = name;
                Grade = grade;
            }
            public override string ToString()
            {
                return Name;
            }
        }
    }
        
}
