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

namespace Truong_Nguyen_Sec002_COMP123_Lap04
{
    public partial class Form1 : Form
    {
        const string DELIMITER = ",";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //create object student
            Students student = new Students();
            //assign the value through student's class properties
            student.UserName = int.Parse(txtUserName.Text);
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Email = txtEmail.Text;
            student.Grade = double.Parse(txtGrade.Text);
            //invoke the method Save (write file)
            SaveStudents(student);
            MessageBox.Show("Successfully Saved!");
            //Clear input for new ones
            txtUserName.Text= "";
            txtFirstName.Text= "";
            txtLastName.Text= "";
            txtEmail.Text= "";
            txtGrade.Text= "";

            txtUserName.Focus();

        }
        private void SaveStudents(Students students)
        {
            //creat a stream
            FileStream inFile = new FileStream("StudentList.Txt", FileMode.Append, FileAccess.Write);
            //creat a Writer
            StreamWriter writer = new StreamWriter(inFile);
            //write the student infor
            writer.WriteLine(students.UserName + DELIMITER + students.FirstName + DELIMITER
            + students.LastName + DELIMITER + students.Email + DELIMITER + students.Grade);
            writer.Close();
            inFile.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //create a reading file stream
            FileStream outFile = new FileStream("StudentList.Txt", FileMode.Open, FileAccess.Read);
            // create a stream reader
            StreamReader reader = new StreamReader(outFile);
            //variable to hold the value of stream reader;
            string record = "";
            lstStudents.Items.Clear();
            //read the first record of the file
            record = reader.ReadLine();
            //loop through all lines
            while (record != null)
            {
                /*
                lstStudents.Items.Add(record);  //add records to list regularly
                */
                //Breaking down the records values to fields array for searching later
                string[] fields = record.Split(',');
                //New Students Object to hold value;
                Students students = new Students();
                students.UserName = int.Parse(fields[0]);
                students.FirstName = fields[1];
                students.LastName = fields[2];
                students.Email = fields[3];
                students.Grade = double.Parse(fields[4]);
                //Prints out Records Values into List
                lstStudents.Items.Add(students.UserName + " - "
                    + students.FirstName + " "
                    + students.LastName + " - "
                    + students.Email + " - "
                    + "Grade: " + students.Grade);

                record = reader.ReadLine();

            }
            reader.Close();
            outFile.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FileStream outFile = new FileStream("StudentList.Txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(outFile);
            int searchingVar = int.Parse(txtSearch.Text);
            bool searchingStatus = true;
            string record = "";
            lblFirstName.Text = "(none)";
            lblLastName.Text = "(none)";
            lblEmail.Text = "(none)";
            lblGrade.Text = "(none)";
            record = reader.ReadLine();
            while (record != null)
            {
                string[] fields = record.Split(',');
                Students students = new Students();
                students.UserName = int.Parse(fields[0]);
                students.FirstName = fields[1];
                students.LastName = fields[2];
                students.Email = fields[3];
                students.Grade = double.Parse(fields[4]);
                if (searchingVar == students.UserName)
                {
                    lblFirstName.Text = students.FirstName;
                    lblLastName.Text = students.LastName;
                    lblEmail.Text = students.Email;
                    lblGrade.Text = students.Grade.ToString();
                    searchingStatus = false;
                    break;
                }
                record = reader.ReadLine();

            }
            reader.Close();
            outFile.Close();
            if (searchingStatus)
            {
                MessageBox.Show("The student was not found!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
