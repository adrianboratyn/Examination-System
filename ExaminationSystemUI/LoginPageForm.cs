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
    public partial class LoginPageForm : Form
    {        
        public LoginPageForm()
        {
            InitializeComponent();
        }
        private bool ValidateLogin()
        {
            bool output = true;
            if (usernameLoginTextBox.Text == "" || passwordLoginTextBox.Text == "")
            {
                output = false;
            }
            return output;
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if(ValidateLogin() == true)
            {
                if(studentRadioButton.Checked == true)
                {
                    if(GlobalConfig.Connection.StudentLogin(usernameLoginTextBox.Text, passwordLoginTextBox.Text) == true)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        StudentPageForm form = new StudentPageForm(usernameLoginTextBox.Text);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                    }
                }
                else if (teacherRadioButton.Checked == true)
                {
                    if (GlobalConfig.Connection.TeacherLogin(usernameLoginTextBox.Text, passwordLoginTextBox.Text) == true)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        TeacherPageForm form = new TeacherPageForm(usernameLoginTextBox.Text);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                    }
                }
                else if (adminRadioButton.Checked == true)
                {
                    if (GlobalConfig.Connection.AdminLogin(usernameLoginTextBox.Text, passwordLoginTextBox.Text) == true)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        AdminPageForm form = new AdminPageForm(usernameLoginTextBox.Text);
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                    }
                }
                else
                {
                    MessageBox.Show("Please select your role");
                }
            }
            else
            {
                MessageBox.Show("Please provide UserName and Password");
            }
        }

        private void createAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccountForm form = new CreateAccountForm();
            form.Show();
        }

        private void LoginPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
