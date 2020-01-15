using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaminationSystemLibrary.Models;
using ExaminationSystemLibrary.DataAccess;
using ExaminationSystemLibrary;


namespace ExaminationSystemUI
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        //code for student account
        private void studentRoleButton_Click(object sender, EventArgs e)
        {
            studentRoleButton.Visible = false;
            adminRoleButton.Visible = false;
            teacherRoleButton.Visible = false;
            chooseRoleLabel.Visible = false;
            studentAccountGroupBox.Visible = true;
        }

        private void studentReturnButton_Click(object sender, EventArgs e)
        {
            studentAccountGroupBox.Visible = false;
            adminRoleButton.Visible = true;
            teacherRoleButton.Visible = true;
            studentRoleButton.Visible = true;
            chooseRoleLabel.Visible = true;
        }

        private bool ValidateStudentAccount()
        {
            bool output = true;
            //first name validation
            if (studentFirstNameTextBox.Text.Length == 0)
            {
                output = false;
            }
            //last name validation
            if (studentLastNameTextBox.Text.Length == 0)
            {
                output = false;
            }
            //user name validation
            if (studentUsernameTextBox.Text.Length == 0)
            {
                output = false;
            }
            //password validation
            if (studentPasswordTextBox.Text.Length == 0)
            {
                output = false;
            }
            //age validation
            int ageNumber = 0;
            bool ageNumberIsValid = int.TryParse(studentAgeTextBox.Text, out ageNumber);
            if (ageNumberIsValid == false)
            {
                output = false;
            }
            if (ageNumber < 1)
            {
                MessageBox.Show("Provide valid age");
                output = false;
            }
            if (studentAgeTextBox.Text.Length == 0)
            {
                output = false;
            }
            //school validation
            if (studentSchoolTextBox.Text.Length == 0)
            {
                output = false;
            }
            //degree course validation
            if (studentDegreeCourseTextBox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void studentCreateAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateStudentAccount() == true)
            {
                StudentModel model = new StudentModel(
                    studentFirstNameTextBox.Text,
                    studentLastNameTextBox.Text,
                    studentUsernameTextBox.Text,
                    studentPasswordTextBox.Text,
                    studentAgeTextBox.Text,
                    studentSchoolTextBox.Text,
                    studentDegreeCourseTextBox.Text);
               
                bool query = GlobalConfig.Connection.CreateStudentAccount(model);
                MessageBox.Show("Success!");
                if (query == false)
                {
                    MessageBox.Show("User with this data already exist");
                }
                
                studentFirstNameTextBox.Text = "";
                studentLastNameTextBox.Text = "";
                studentUsernameTextBox.Text = "";
                studentPasswordTextBox.Text = "";
                studentAgeTextBox.Text = "0";
                studentSchoolTextBox.Text = "";
                studentDegreeCourseTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid information. Try again.");
            }
        }

        //code for teacher account
        private void teacherRoleButton_Click(object sender, EventArgs e)
        {
            studentRoleButton.Visible = false;
            adminRoleButton.Visible = false;
            teacherRoleButton.Visible = false;
            chooseRoleLabel.Visible = false;
            teacherAccountGroupBox.Visible = true;
        }

        private void teacherReturnButton_Click(object sender, EventArgs e)
        {
            teacherAccountGroupBox.Visible = false;
            adminRoleButton.Visible = true;
            teacherRoleButton.Visible = true;
            studentRoleButton.Visible = true;
            chooseRoleLabel.Visible = true;
        }

        private bool ValidateTeacherAccount()
        {
            bool output = true;
            //first name validation
            if (teacherFirstNameTextBox.Text.Length == 0)
            {
                output = false;
            }
            //last name validation
            if (teacherLastNameTextBox.Text.Length == 0)
            {
                output = false;
            }
            //user name validation
            if (teacherUsernameTextBox.Text.Length == 0)
            {
                output = false;
            }
            //password validation
            if (teacherPasswordTextBox.Text.Length == 0)
            {
                output = false;
            }
            //school validation
            if (teacherSchoolTextBox.Text.Length == 0)
            {
                output = false;
            }
            //academic title validation
            if (teacherAcademicTitleTextBox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void teacherCreateAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateTeacherAccount() == true)
            {
                TeacherModel model = new TeacherModel(
                    teacherFirstNameTextBox.Text,
                    teacherLastNameTextBox.Text,
                    teacherUsernameTextBox.Text,
                    teacherPasswordTextBox.Text,
                    teacherSchoolTextBox.Text,
                    teacherAcademicTitleTextBox.Text);

                bool query = GlobalConfig.Connection.CreateTeacherAccount(model);
                MessageBox.Show("Success!");
                if (query == false)
                {
                    MessageBox.Show("User with this data already exist");
                }

                teacherFirstNameTextBox.Text = "";
                teacherLastNameTextBox.Text = "";
                teacherUsernameTextBox.Text = "";
                teacherPasswordTextBox.Text = "";
                teacherSchoolTextBox.Text = "";
                teacherAcademicTitleTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid information. Try again.");
            }
        }

        //code for admin account
        private void adminRoleButton_Click(object sender, EventArgs e)
        {
            studentRoleButton.Visible = false;
            adminRoleButton.Visible = false;
            teacherRoleButton.Visible = false;
            chooseRoleLabel.Visible = false;
            adminAccountGroupBox.Visible = true;
        }

        private void adminReturnButton_Click(object sender, EventArgs e)
        {
            adminAccountGroupBox.Visible = false;
            adminRoleButton.Visible = true;
            teacherRoleButton.Visible = true;
            studentRoleButton.Visible = true;
            chooseRoleLabel.Visible = true;
        }
        private bool ValidateAdminAccount()
        {
            bool output = true;
            //first name validation
            if (adminFirstNameTextBox.Text.Length == 0)
            {
                output = false;
            }
            //last name validation
            if (adminLastNameTextBox.Text.Length == 0)
            {
                output = false;
            }
            //user name validation
            if (adminUsernameTextBox.Text.Length == 0)
            {
                output = false;
            }
            //password validation
            if (adminPasswordTextBox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void adminCreateAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateAdminAccount() == true)
            {
                AdminModel model = new AdminModel(
                    adminFirstNameTextBox.Text,
                    adminLastNameTextBox.Text,
                    adminUsernameTextBox.Text,
                    adminPasswordTextBox.Text);

                bool query = GlobalConfig.Connection.CreateAdminAccount(model);
                MessageBox.Show("Success!");
                if (query == false)
                {
                    MessageBox.Show("User with this data already exist");
                }

                adminFirstNameTextBox.Text = "";
                adminLastNameTextBox.Text = "";
                adminUsernameTextBox.Text = "";
                adminPasswordTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid information. Try again.");
            }
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPageForm form = new LoginPageForm();
            form.Show();
        }

        private void CreateAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
