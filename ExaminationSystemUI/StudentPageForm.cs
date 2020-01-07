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
    }
}
