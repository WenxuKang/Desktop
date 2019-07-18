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

namespace Exercise1
{
    public partial class FormExercise1 : Form
    {
        public bool valid;
        public FormExercise1()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            valid = ValidateData();
            if (valid) { SaveData(); }
            ClearTxtBoxes();
        }

        public bool ValidateData()
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

        public void SaveData()
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
        }

        public void ClearTxtBoxes()
        {
            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtGrade.Text = "";
        }

        private void FormExercise1_Activated(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
