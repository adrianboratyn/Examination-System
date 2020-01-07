using ExaminationSystemLibrary;
using ExaminationSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystemUI
{
    public partial class StudentPageForm : Form
    {
        public StudentPageForm()
        {
            InitializeComponent();
        }
        public StudentPageForm(string name)
        {
            InitializeComponent();
            studentNameLabel.Text = name;
        }

        private void studentLogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPageForm form = new LoginPageForm();
            form.Show();
        }

        private void StudentPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //code for editing profile
        private bool ValidateStudentEditProfile()
        {
            bool output = true;

            if (studentEditFirstNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (studentEditLastNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (studentEditUsernameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (studentEditPasswordTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (studentEditAgeTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (studentEditSchoolTextBox.Text.Length == 0)
            {
                output = false;
            }
            if (studentEditDegreeCourseTextBox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void studentEditAccountButton_Click(object sender, EventArgs e)
        {
            if (ValidateStudentEditProfile() == true)
            {
                StudentModel model = new StudentModel();
                model.FirstName = studentEditFirstNameTextBox.Text;
                model.LastName = studentEditLastNameTextBox.Text;
                model.UserName = studentEditUsernameTextBox.Text;
                model.Password = studentEditPasswordTextBox.Text;
                model.Age = int.Parse(studentEditAgeTextBox.Text);
                model.School = studentEditSchoolTextBox.Text;
                model.DegreeCourse = studentEditDegreeCourseTextBox.Text;


                if (GlobalConfig.Connection.EditStudentAccount(model, studentNameLabel.Text) == true)
                {
                    MessageBox.Show("Update Successful");
                    studentNameLabel.Text = model.UserName;
                }
                else
                {
                    MessageBox.Show("User with this username already exist");
                }
            }
        }
    }
}
