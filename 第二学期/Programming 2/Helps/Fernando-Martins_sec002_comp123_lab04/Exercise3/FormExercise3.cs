using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class FormExercise3 : Form
    {
        public bool valid;//For control data validation
        public bool search = false;//For control if used by search button or not

        public FormExercise3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";//Initialize validation data message
            valid = ValidateData();//Validation test
            if (valid) { SaveData(); }//if true store the data
            ClearTxtBoxes();//clear textboxes
        }

        public bool ValidateData()//Validation the textboxes(student inforation)
        {
            if (txtUsername.Text != "")
            {
                int idUser;

                if (Int32.TryParse(txtUsername.Text, out idUser))
                {
                    if (txtFirstName.Text != "")
                    {
                        if (txtLastName.Text != "")
                        {
                            if (txtEmail.Text != "")
                            {
                                if (txtGrade.Text != "")
                                {
                                    double grade;

                                    if (double.TryParse(txtGrade.Text, out grade))
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        lblMessage.Text = "The grade is not double!";
                                    }
                                }
                                else
                                {
                                    lblMessage.Text = "Enter the grade!";
                                }
                            }
                            else
                            {
                                lblMessage.Text = "Enter the email!";

                            }
                        }
                        else
                        {
                            lblMessage.Text = "Enter the last name!";
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Enter the first name!";
                    }
                }
                else
                {
                    lblMessage.Text = "The username is not integer!";
                }
            }
            else
            {
                lblMessage.Text = "Enter the username!";
            }
            return false;
        }
        public void ClearTxtBoxes()//clear textboxes
        {
            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtGrade.Text = "";
        }

        public void SaveData()//Store entered data in class and file
        {
            Student studentData = new Student();
            studentData.idUsername = int.Parse(txtUsername.Text);
            studentData.firstName = txtFirstName.Text;
            studentData.lastName = txtLastName.Text;
            studentData.email = txtEmail.Text;
            studentData.grade = double.Parse(txtGrade.Text);
            string pathStudent = Directory.GetCurrentDirectory() + "\\StudentList.txt";
            if (!(File.Exists("StudentList.txt")))
            {
                FileStream opFile = new FileStream(pathStudent, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(opFile);
                writer.WriteLine(studentData.idUsername + "-" + studentData.firstName + "-" +
                                studentData.lastName + "-" + studentData.email + "-" + studentData.grade);
                writer.Close();
                opFile.Close();
            }
            else
            {
                FileStream opFile = new FileStream(pathStudent, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(opFile);
                writer.WriteLine(studentData.idUsername + "-" + studentData.firstName + "-" +
                                studentData.lastName + "-" + studentData.email + "-" + studentData.grade);
                writer.Close();
                opFile.Close();
            }
            btnLoad.PerformClick();            
        }

        private void btnLoad_Click(object sender, EventArgs e)//Load data in student list
        {
            if (File.Exists("StudentList.txt"))
            {
                FileStream liBox = new FileStream("StudentList.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(liBox);

                string record = "";

                lstStudents.Items.Clear();

                record = reader.ReadLine();

                while (record != null)
                {
                    string[] fields = record.Split(char.Parse("-"));

                    Student studentList = new Student();

                    studentList.idUsername = int.Parse(fields[0]);
                    studentList.firstName = fields[1];
                    studentList.lastName = fields[2];
                    studentList.email = fields[3];
                    studentList.grade = double.Parse(fields[4]);

                    lstStudents.Items.Add(studentList.idUsername + " - " +
                        studentList.firstName + " - " +
                        studentList.lastName + " - " +
                        studentList.email + " - " + studentList.grade);
                    if (search)//Used only when click on search button
                    {
                        if(txtSearchUser.Text == fields[0])
                        {
                            lblSearchFn.Text =    "First name: " + studentList.firstName;
                            lblSearchLn.Text =    "Last name:  " + studentList.lastName;
                            lblSearchEmail.Text = "Email:      " + studentList.email;
                            lblSearchGrade.Text = "Grade:      " + studentList.grade;
                            lblSearchMsg.Text = "";
                            search = false;
                        }
                        else
                        {
                            lblSearchFn.Text = "First name: ";
                            lblSearchLn.Text = "Last name: ";
                            lblSearchEmail.Text = "Email: ";
                            lblSearchGrade.Text = "Grade: ";
                            lblSearchMsg.Text = "The student was not found!";
                        }

                    }

                    record = reader.ReadLine();
                }

                reader.Close();
                liBox.Close();
            }
        }


        //Initialize message when start the program
        private void FormExercise3_Activated(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblSearchMsg.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)//Search button
        {
            search = true;
            btnLoad.PerformClick();
            search = false;
        }
    }
}
