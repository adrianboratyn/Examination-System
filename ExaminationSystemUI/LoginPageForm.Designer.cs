namespace ExaminationSystemUI
{
    partial class LoginPageForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.passwordLoginLabel = new System.Windows.Forms.Label();
            this.usernameLoginLabel = new System.Windows.Forms.Label();
            this.iAmLabel = new System.Windows.Forms.Label();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.teacherRadioButton = new System.Windows.Forms.RadioButton();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameLoginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLoginTextBox = new System.Windows.Forms.TextBox();
            this.createAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(19, 68);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(338, 45);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Examination System";
            // 
            // passwordLoginLabel
            // 
            this.passwordLoginLabel.AutoSize = true;
            this.passwordLoginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordLoginLabel.Location = new System.Drawing.Point(21, 278);
            this.passwordLoginLabel.Name = "passwordLoginLabel";
            this.passwordLoginLabel.Size = new System.Drawing.Size(116, 32);
            this.passwordLoginLabel.TabIndex = 1;
            this.passwordLoginLabel.Text = "Password";
            // 
            // usernameLoginLabel
            // 
            this.usernameLoginLabel.AutoSize = true;
            this.usernameLoginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameLoginLabel.Location = new System.Drawing.Point(21, 171);
            this.usernameLoginLabel.Name = "usernameLoginLabel";
            this.usernameLoginLabel.Size = new System.Drawing.Size(125, 32);
            this.usernameLoginLabel.TabIndex = 2;
            this.usernameLoginLabel.Text = "Username";
            // 
            // iAmLabel
            // 
            this.iAmLabel.AutoSize = true;
            this.iAmLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iAmLabel.ForeColor = System.Drawing.Color.Red;
            this.iAmLabel.Location = new System.Drawing.Point(230, 171);
            this.iAmLabel.Name = "iAmLabel";
            this.iAmLabel.Size = new System.Drawing.Size(69, 32);
            this.iAmLabel.TabIndex = 3;
            this.iAmLabel.Text = "I am:";
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentRadioButton.ForeColor = System.Drawing.Color.Red;
            this.studentRadioButton.Location = new System.Drawing.Point(236, 206);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(93, 29);
            this.studentRadioButton.TabIndex = 4;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // teacherRadioButton
            // 
            this.teacherRadioButton.AutoSize = true;
            this.teacherRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teacherRadioButton.ForeColor = System.Drawing.Color.Red;
            this.teacherRadioButton.Location = new System.Drawing.Point(236, 241);
            this.teacherRadioButton.Name = "teacherRadioButton";
            this.teacherRadioButton.Size = new System.Drawing.Size(94, 29);
            this.teacherRadioButton.TabIndex = 5;
            this.teacherRadioButton.TabStop = true;
            this.teacherRadioButton.Text = "Teacher";
            this.teacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminRadioButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminRadioButton.ForeColor = System.Drawing.Color.Red;
            this.adminRadioButton.Location = new System.Drawing.Point(236, 276);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(84, 29);
            this.adminRadioButton.TabIndex = 6;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.ForeColor = System.Drawing.Color.Red;
            this.loginButton.Location = new System.Drawing.Point(236, 313);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 33);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // usernameLoginTextBox
            // 
            this.usernameLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameLoginTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLoginTextBox.ForeColor = System.Drawing.Color.Red;
            this.usernameLoginTextBox.Location = new System.Drawing.Point(27, 206);
            this.usernameLoginTextBox.Name = "usernameLoginTextBox";
            this.usernameLoginTextBox.Size = new System.Drawing.Size(100, 26);
            this.usernameLoginTextBox.TabIndex = 8;
            this.usernameLoginTextBox.Text = "Username";
            // 
            // passwordLoginTextBox
            // 
            this.passwordLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLoginTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLoginTextBox.ForeColor = System.Drawing.Color.Red;
            this.passwordLoginTextBox.Location = new System.Drawing.Point(27, 313);
            this.passwordLoginTextBox.Name = "passwordLoginTextBox";
            this.passwordLoginTextBox.Size = new System.Drawing.Size(100, 26);
            this.passwordLoginTextBox.TabIndex = 9;
            this.passwordLoginTextBox.Text = "Password";
            // 
            // createAccountLinkLabel
            // 
            this.createAccountLinkLabel.AutoSize = true;
            this.createAccountLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.createAccountLinkLabel.Location = new System.Drawing.Point(232, 366);
            this.createAccountLinkLabel.Name = "createAccountLinkLabel";
            this.createAccountLinkLabel.Size = new System.Drawing.Size(149, 21);
            this.createAccountLinkLabel.TabIndex = 10;
            this.createAccountLinkLabel.TabStop = true;
            this.createAccountLinkLabel.Text = "I don\'t have account";
            // 
            // LoginPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 444);
            this.Controls.Add(this.createAccountLinkLabel);
            this.Controls.Add(this.passwordLoginTextBox);
            this.Controls.Add(this.usernameLoginTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.adminRadioButton);
            this.Controls.Add(this.teacherRadioButton);
            this.Controls.Add(this.studentRadioButton);
            this.Controls.Add(this.iAmLabel);
            this.Controls.Add(this.usernameLoginLabel);
            this.Controls.Add(this.passwordLoginLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(410, 483);
            this.MinimumSize = new System.Drawing.Size(410, 483);
            this.Name = "LoginPageForm";
            this.Text = "Examination system";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label passwordLoginLabel;
        private System.Windows.Forms.Label usernameLoginLabel;
        private System.Windows.Forms.Label iAmLabel;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton teacherRadioButton;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox usernameLoginTextBox;
        private System.Windows.Forms.TextBox passwordLoginTextBox;
        private System.Windows.Forms.LinkLabel createAccountLinkLabel;
    }
}

