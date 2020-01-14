namespace ExaminationSystemUI
{
    partial class StudentPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminPagePanel = new System.Windows.Forms.Panel();
            this.studentLogoutButton = new System.Windows.Forms.Button();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pageNameLabel = new System.Windows.Forms.Label();
            this.studentMenuTabControl = new System.Windows.Forms.TabControl();
            this.studentDashboardPage = new System.Windows.Forms.TabPage();
            this.selectedExamListBox = new System.Windows.Forms.ListBox();
            this.studentMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.studentExamListPage = new System.Windows.Forms.TabPage();
            this.signUpButton = new System.Windows.Forms.Button();
            this.allExamListBox = new System.Windows.Forms.ListBox();
            this.studentTakeExamPage = new System.Windows.Forms.TabPage();
            this.finishExamButton = new System.Windows.Forms.Button();
            this.examQuestionListBox = new System.Windows.Forms.ListBox();
            this.takeExamGroupBox = new System.Windows.Forms.GroupBox();
            this.answerCRadioButton = new System.Windows.Forms.RadioButton();
            this.answerDRadioButton = new System.Windows.Forms.RadioButton();
            this.answerBRadioButton = new System.Windows.Forms.RadioButton();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.answerDTextBox = new System.Windows.Forms.TextBox();
            this.answerCTextBox = new System.Windows.Forms.TextBox();
            this.answerARadioButton = new System.Windows.Forms.RadioButton();
            this.answerBTextBox = new System.Windows.Forms.TextBox();
            this.answerATextBox = new System.Windows.Forms.TextBox();
            this.questionNameTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.selectExamComboBox = new System.Windows.Forms.ComboBox();
            this.takeExamButton = new System.Windows.Forms.Button();
            this.accessCodeTextBox = new System.Windows.Forms.TextBox();
            this.accessCodeLabel = new System.Windows.Forms.Label();
            this.selectExamLabel = new System.Windows.Forms.Label();
            this.studentMyResultsPage = new System.Windows.Forms.TabPage();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.selectExamResultComboBox = new System.Windows.Forms.ComboBox();
            this.selectExamResultLabel = new System.Windows.Forms.Label();
            this.studentEditProfilePage = new System.Windows.Forms.TabPage();
            this.studentEditAccountButton = new System.Windows.Forms.Button();
            this.studentEditPasswordTextBox = new System.Windows.Forms.TextBox();
            this.studentEditPasswordLabel = new System.Windows.Forms.Label();
            this.studentEditDegreeCourseTextBox = new System.Windows.Forms.TextBox();
            this.studentEditDegreeCourseLabel = new System.Windows.Forms.Label();
            this.studentEditSchoolTextBox = new System.Windows.Forms.TextBox();
            this.studentEditSchoolLabel = new System.Windows.Forms.Label();
            this.studentEditAgeTextBox = new System.Windows.Forms.TextBox();
            this.studentEditAgeLabel = new System.Windows.Forms.Label();
            this.studentEditUsernameTextBox = new System.Windows.Forms.TextBox();
            this.studentEditUsernameLabel = new System.Windows.Forms.Label();
            this.studentEditLastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentEditLastNameLabel = new System.Windows.Forms.Label();
            this.studentEditFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentEditFirstNameLabel = new System.Windows.Forms.Label();
            this.showResultButton = new System.Windows.Forms.Button();
            this.adminPagePanel.SuspendLayout();
            this.studentMenuTabControl.SuspendLayout();
            this.studentDashboardPage.SuspendLayout();
            this.studentExamListPage.SuspendLayout();
            this.studentTakeExamPage.SuspendLayout();
            this.takeExamGroupBox.SuspendLayout();
            this.studentMyResultsPage.SuspendLayout();
            this.studentEditProfilePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminPagePanel
            // 
            this.adminPagePanel.Controls.Add(this.studentLogoutButton);
            this.adminPagePanel.Controls.Add(this.studentNameLabel);
            this.adminPagePanel.Controls.Add(this.titleLabel);
            this.adminPagePanel.Controls.Add(this.pageNameLabel);
            this.adminPagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminPagePanel.Location = new System.Drawing.Point(0, 0);
            this.adminPagePanel.Name = "adminPagePanel";
            this.adminPagePanel.Size = new System.Drawing.Size(643, 103);
            this.adminPagePanel.TabIndex = 2;
            // 
            // studentLogoutButton
            // 
            this.studentLogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.studentLogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.studentLogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.studentLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentLogoutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentLogoutButton.ForeColor = System.Drawing.Color.Red;
            this.studentLogoutButton.Location = new System.Drawing.Point(559, 67);
            this.studentLogoutButton.Name = "studentLogoutButton";
            this.studentLogoutButton.Size = new System.Drawing.Size(80, 33);
            this.studentLogoutButton.TabIndex = 8;
            this.studentLogoutButton.Text = "Log out";
            this.studentLogoutButton.UseVisualStyleBackColor = true;
            this.studentLogoutButton.Click += new System.EventHandler(this.studentLogoutButton_Click);
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentNameLabel.Location = new System.Drawing.Point(3, 52);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(169, 30);
            this.studentNameLabel.TabIndex = 2;
            this.studentNameLabel.Text = "<student name>";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(223, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(338, 45);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Examination System";
            // 
            // pageNameLabel
            // 
            this.pageNameLabel.AutoSize = true;
            this.pageNameLabel.Location = new System.Drawing.Point(3, 9);
            this.pageNameLabel.Name = "pageNameLabel";
            this.pageNameLabel.Size = new System.Drawing.Size(162, 32);
            this.pageNameLabel.TabIndex = 0;
            this.pageNameLabel.Text = "Student Panel";
            // 
            // studentMenuTabControl
            // 
            this.studentMenuTabControl.Controls.Add(this.studentDashboardPage);
            this.studentMenuTabControl.Controls.Add(this.studentExamListPage);
            this.studentMenuTabControl.Controls.Add(this.studentTakeExamPage);
            this.studentMenuTabControl.Controls.Add(this.studentMyResultsPage);
            this.studentMenuTabControl.Controls.Add(this.studentEditProfilePage);
            this.studentMenuTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.studentMenuTabControl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentMenuTabControl.HotTrack = true;
            this.studentMenuTabControl.ItemSize = new System.Drawing.Size(128, 37);
            this.studentMenuTabControl.Location = new System.Drawing.Point(0, 100);
            this.studentMenuTabControl.Name = "studentMenuTabControl";
            this.studentMenuTabControl.SelectedIndex = 0;
            this.studentMenuTabControl.Size = new System.Drawing.Size(643, 601);
            this.studentMenuTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.studentMenuTabControl.TabIndex = 3;
            this.studentMenuTabControl.Click += new System.EventHandler(this.studentMenuTabControl_Click);
            // 
            // studentDashboardPage
            // 
            this.studentDashboardPage.Controls.Add(this.selectedExamListBox);
            this.studentDashboardPage.Controls.Add(this.studentMonthCalendar);
            this.studentDashboardPage.Location = new System.Drawing.Point(4, 41);
            this.studentDashboardPage.Name = "studentDashboardPage";
            this.studentDashboardPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentDashboardPage.Size = new System.Drawing.Size(635, 556);
            this.studentDashboardPage.TabIndex = 1;
            this.studentDashboardPage.Text = "Dashboard";
            this.studentDashboardPage.UseVisualStyleBackColor = true;
            // 
            // selectedExamListBox
            // 
            this.selectedExamListBox.FormattingEnabled = true;
            this.selectedExamListBox.ItemHeight = 25;
            this.selectedExamListBox.Location = new System.Drawing.Point(39, 228);
            this.selectedExamListBox.Name = "selectedExamListBox";
            this.selectedExamListBox.Size = new System.Drawing.Size(572, 279);
            this.selectedExamListBox.TabIndex = 1;
            // 
            // studentMonthCalendar
            // 
            this.studentMonthCalendar.Location = new System.Drawing.Point(159, 36);
            this.studentMonthCalendar.Name = "studentMonthCalendar";
            this.studentMonthCalendar.TabIndex = 0;
            // 
            // studentExamListPage
            // 
            this.studentExamListPage.Controls.Add(this.signUpButton);
            this.studentExamListPage.Controls.Add(this.allExamListBox);
            this.studentExamListPage.Location = new System.Drawing.Point(4, 41);
            this.studentExamListPage.Name = "studentExamListPage";
            this.studentExamListPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentExamListPage.Size = new System.Drawing.Size(635, 556);
            this.studentExamListPage.TabIndex = 2;
            this.studentExamListPage.Text = "Exam List";
            this.studentExamListPage.UseVisualStyleBackColor = true;
            // 
            // signUpButton
            // 
            this.signUpButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.signUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.signUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.signUpButton.ForeColor = System.Drawing.Color.Red;
            this.signUpButton.Location = new System.Drawing.Point(218, 515);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(131, 33);
            this.signUpButton.TabIndex = 30;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // allExamListBox
            // 
            this.allExamListBox.FormattingEnabled = true;
            this.allExamListBox.ItemHeight = 25;
            this.allExamListBox.Location = new System.Drawing.Point(8, 17);
            this.allExamListBox.Name = "allExamListBox";
            this.allExamListBox.Size = new System.Drawing.Size(619, 479);
            this.allExamListBox.TabIndex = 29;
            // 
            // studentTakeExamPage
            // 
            this.studentTakeExamPage.Controls.Add(this.finishExamButton);
            this.studentTakeExamPage.Controls.Add(this.examQuestionListBox);
            this.studentTakeExamPage.Controls.Add(this.takeExamGroupBox);
            this.studentTakeExamPage.Controls.Add(this.selectExamComboBox);
            this.studentTakeExamPage.Controls.Add(this.takeExamButton);
            this.studentTakeExamPage.Controls.Add(this.accessCodeTextBox);
            this.studentTakeExamPage.Controls.Add(this.accessCodeLabel);
            this.studentTakeExamPage.Controls.Add(this.selectExamLabel);
            this.studentTakeExamPage.Location = new System.Drawing.Point(4, 41);
            this.studentTakeExamPage.Name = "studentTakeExamPage";
            this.studentTakeExamPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentTakeExamPage.Size = new System.Drawing.Size(635, 556);
            this.studentTakeExamPage.TabIndex = 3;
            this.studentTakeExamPage.Text = "Take Exam";
            this.studentTakeExamPage.UseVisualStyleBackColor = true;
            // 
            // finishExamButton
            // 
            this.finishExamButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.finishExamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.finishExamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.finishExamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishExamButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.finishExamButton.ForeColor = System.Drawing.Color.Red;
            this.finishExamButton.Location = new System.Drawing.Point(426, 499);
            this.finishExamButton.Name = "finishExamButton";
            this.finishExamButton.Size = new System.Drawing.Size(131, 33);
            this.finishExamButton.TabIndex = 39;
            this.finishExamButton.Text = "Finish";
            this.finishExamButton.UseVisualStyleBackColor = true;
            this.finishExamButton.Click += new System.EventHandler(this.finishExamButton_Click);
            // 
            // examQuestionListBox
            // 
            this.examQuestionListBox.FormattingEnabled = true;
            this.examQuestionListBox.ItemHeight = 25;
            this.examQuestionListBox.Location = new System.Drawing.Point(361, 102);
            this.examQuestionListBox.Name = "examQuestionListBox";
            this.examQuestionListBox.Size = new System.Drawing.Size(248, 379);
            this.examQuestionListBox.TabIndex = 38;
            this.examQuestionListBox.Click += new System.EventHandler(this.examQuestionListBox_Click);
            // 
            // takeExamGroupBox
            // 
            this.takeExamGroupBox.Controls.Add(this.answerCRadioButton);
            this.takeExamGroupBox.Controls.Add(this.answerDRadioButton);
            this.takeExamGroupBox.Controls.Add(this.answerBRadioButton);
            this.takeExamGroupBox.Controls.Add(this.nextQuestionButton);
            this.takeExamGroupBox.Controls.Add(this.answerDTextBox);
            this.takeExamGroupBox.Controls.Add(this.answerCTextBox);
            this.takeExamGroupBox.Controls.Add(this.answerARadioButton);
            this.takeExamGroupBox.Controls.Add(this.answerBTextBox);
            this.takeExamGroupBox.Controls.Add(this.answerATextBox);
            this.takeExamGroupBox.Controls.Add(this.questionNameTextBox);
            this.takeExamGroupBox.Controls.Add(this.questionLabel);
            this.takeExamGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.takeExamGroupBox.Location = new System.Drawing.Point(13, 102);
            this.takeExamGroupBox.Name = "takeExamGroupBox";
            this.takeExamGroupBox.Size = new System.Drawing.Size(320, 436);
            this.takeExamGroupBox.TabIndex = 37;
            this.takeExamGroupBox.TabStop = false;
            this.takeExamGroupBox.Text = "<Exam Name>";
            // 
            // answerCRadioButton
            // 
            this.answerCRadioButton.AutoSize = true;
            this.answerCRadioButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerCRadioButton.Location = new System.Drawing.Point(6, 246);
            this.answerCRadioButton.Name = "answerCRadioButton";
            this.answerCRadioButton.Size = new System.Drawing.Size(34, 24);
            this.answerCRadioButton.TabIndex = 41;
            this.answerCRadioButton.TabStop = true;
            this.answerCRadioButton.Text = "c";
            this.answerCRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerDRadioButton
            // 
            this.answerDRadioButton.AutoSize = true;
            this.answerDRadioButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerDRadioButton.Location = new System.Drawing.Point(7, 319);
            this.answerDRadioButton.Name = "answerDRadioButton";
            this.answerDRadioButton.Size = new System.Drawing.Size(36, 24);
            this.answerDRadioButton.TabIndex = 40;
            this.answerDRadioButton.TabStop = true;
            this.answerDRadioButton.Text = "d";
            this.answerDRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerBRadioButton
            // 
            this.answerBRadioButton.AutoSize = true;
            this.answerBRadioButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerBRadioButton.Location = new System.Drawing.Point(6, 175);
            this.answerBRadioButton.Name = "answerBRadioButton";
            this.answerBRadioButton.Size = new System.Drawing.Size(36, 24);
            this.answerBRadioButton.TabIndex = 39;
            this.answerBRadioButton.TabStop = true;
            this.answerBRadioButton.Text = "b";
            this.answerBRadioButton.UseVisualStyleBackColor = true;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.nextQuestionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.nextQuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.nextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextQuestionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextQuestionButton.ForeColor = System.Drawing.Color.Red;
            this.nextQuestionButton.Location = new System.Drawing.Point(202, 397);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(112, 33);
            this.nextQuestionButton.TabIndex = 19;
            this.nextQuestionButton.Text = "Save Answer";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // answerDTextBox
            // 
            this.answerDTextBox.BackColor = System.Drawing.Color.White;
            this.answerDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerDTextBox.ForeColor = System.Drawing.Color.Red;
            this.answerDTextBox.Location = new System.Drawing.Point(6, 345);
            this.answerDTextBox.Multiline = true;
            this.answerDTextBox.Name = "answerDTextBox";
            this.answerDTextBox.ReadOnly = true;
            this.answerDTextBox.Size = new System.Drawing.Size(308, 46);
            this.answerDTextBox.TabIndex = 18;
            // 
            // answerCTextBox
            // 
            this.answerCTextBox.BackColor = System.Drawing.Color.White;
            this.answerCTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerCTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerCTextBox.ForeColor = System.Drawing.Color.Red;
            this.answerCTextBox.Location = new System.Drawing.Point(7, 272);
            this.answerCTextBox.Multiline = true;
            this.answerCTextBox.Name = "answerCTextBox";
            this.answerCTextBox.ReadOnly = true;
            this.answerCTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.answerCTextBox.Size = new System.Drawing.Size(308, 46);
            this.answerCTextBox.TabIndex = 17;
            // 
            // answerARadioButton
            // 
            this.answerARadioButton.AutoSize = true;
            this.answerARadioButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerARadioButton.Location = new System.Drawing.Point(6, 100);
            this.answerARadioButton.Name = "answerARadioButton";
            this.answerARadioButton.Size = new System.Drawing.Size(35, 24);
            this.answerARadioButton.TabIndex = 38;
            this.answerARadioButton.TabStop = true;
            this.answerARadioButton.Text = "a";
            this.answerARadioButton.UseVisualStyleBackColor = true;
            // 
            // answerBTextBox
            // 
            this.answerBTextBox.BackColor = System.Drawing.Color.White;
            this.answerBTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerBTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerBTextBox.ForeColor = System.Drawing.Color.Red;
            this.answerBTextBox.Location = new System.Drawing.Point(7, 199);
            this.answerBTextBox.Multiline = true;
            this.answerBTextBox.Name = "answerBTextBox";
            this.answerBTextBox.ReadOnly = true;
            this.answerBTextBox.Size = new System.Drawing.Size(308, 46);
            this.answerBTextBox.TabIndex = 16;
            // 
            // answerATextBox
            // 
            this.answerATextBox.BackColor = System.Drawing.Color.White;
            this.answerATextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerATextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerATextBox.ForeColor = System.Drawing.Color.Red;
            this.answerATextBox.Location = new System.Drawing.Point(7, 126);
            this.answerATextBox.Multiline = true;
            this.answerATextBox.Name = "answerATextBox";
            this.answerATextBox.ReadOnly = true;
            this.answerATextBox.Size = new System.Drawing.Size(308, 46);
            this.answerATextBox.TabIndex = 15;
            // 
            // questionNameTextBox
            // 
            this.questionNameTextBox.BackColor = System.Drawing.Color.White;
            this.questionNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionNameTextBox.ForeColor = System.Drawing.Color.Red;
            this.questionNameTextBox.Location = new System.Drawing.Point(6, 53);
            this.questionNameTextBox.Multiline = true;
            this.questionNameTextBox.Name = "questionNameTextBox";
            this.questionNameTextBox.ReadOnly = true;
            this.questionNameTextBox.Size = new System.Drawing.Size(308, 46);
            this.questionNameTextBox.TabIndex = 10;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionLabel.ForeColor = System.Drawing.Color.Red;
            this.questionLabel.Location = new System.Drawing.Point(2, 29);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(73, 21);
            this.questionLabel.TabIndex = 4;
            this.questionLabel.Text = "Question";
            // 
            // selectExamComboBox
            // 
            this.selectExamComboBox.FormattingEnabled = true;
            this.selectExamComboBox.Location = new System.Drawing.Point(129, 13);
            this.selectExamComboBox.Name = "selectExamComboBox";
            this.selectExamComboBox.Size = new System.Drawing.Size(263, 33);
            this.selectExamComboBox.TabIndex = 36;
            this.selectExamComboBox.Click += new System.EventHandler(this.selectExamComboBox_Click);
            // 
            // takeExamButton
            // 
            this.takeExamButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.takeExamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.takeExamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.takeExamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeExamButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.takeExamButton.ForeColor = System.Drawing.Color.Red;
            this.takeExamButton.Location = new System.Drawing.Point(483, 8);
            this.takeExamButton.Name = "takeExamButton";
            this.takeExamButton.Size = new System.Drawing.Size(112, 71);
            this.takeExamButton.TabIndex = 35;
            this.takeExamButton.Text = "Take Exam";
            this.takeExamButton.UseVisualStyleBackColor = true;
            this.takeExamButton.Click += new System.EventHandler(this.takeExamButton_Click);
            // 
            // accessCodeTextBox
            // 
            this.accessCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accessCodeTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Italic);
            this.accessCodeTextBox.ForeColor = System.Drawing.Color.Red;
            this.accessCodeTextBox.Location = new System.Drawing.Point(129, 52);
            this.accessCodeTextBox.Name = "accessCodeTextBox";
            this.accessCodeTextBox.Size = new System.Drawing.Size(100, 33);
            this.accessCodeTextBox.TabIndex = 34;
            // 
            // accessCodeLabel
            // 
            this.accessCodeLabel.AutoSize = true;
            this.accessCodeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.accessCodeLabel.ForeColor = System.Drawing.Color.Red;
            this.accessCodeLabel.Location = new System.Drawing.Point(8, 54);
            this.accessCodeLabel.Name = "accessCodeLabel";
            this.accessCodeLabel.Size = new System.Drawing.Size(115, 25);
            this.accessCodeLabel.TabIndex = 33;
            this.accessCodeLabel.Text = "Access code";
            // 
            // selectExamLabel
            // 
            this.selectExamLabel.AutoSize = true;
            this.selectExamLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectExamLabel.ForeColor = System.Drawing.Color.Red;
            this.selectExamLabel.Location = new System.Drawing.Point(8, 16);
            this.selectExamLabel.Name = "selectExamLabel";
            this.selectExamLabel.Size = new System.Drawing.Size(115, 25);
            this.selectExamLabel.TabIndex = 31;
            this.selectExamLabel.Text = "Select exam";
            // 
            // studentMyResultsPage
            // 
            this.studentMyResultsPage.Controls.Add(this.showResultButton);
            this.studentMyResultsPage.Controls.Add(this.resultListBox);
            this.studentMyResultsPage.Controls.Add(this.selectExamResultComboBox);
            this.studentMyResultsPage.Controls.Add(this.selectExamResultLabel);
            this.studentMyResultsPage.Location = new System.Drawing.Point(4, 41);
            this.studentMyResultsPage.Name = "studentMyResultsPage";
            this.studentMyResultsPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentMyResultsPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.studentMyResultsPage.Size = new System.Drawing.Size(635, 556);
            this.studentMyResultsPage.TabIndex = 4;
            this.studentMyResultsPage.Text = "My results";
            this.studentMyResultsPage.UseVisualStyleBackColor = true;
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 25;
            this.resultListBox.Location = new System.Drawing.Point(13, 80);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(614, 454);
            this.resultListBox.TabIndex = 37;
            // 
            // selectExamResultComboBox
            // 
            this.selectExamResultComboBox.FormattingEnabled = true;
            this.selectExamResultComboBox.Location = new System.Drawing.Point(129, 18);
            this.selectExamResultComboBox.Name = "selectExamResultComboBox";
            this.selectExamResultComboBox.Size = new System.Drawing.Size(263, 33);
            this.selectExamResultComboBox.TabIndex = 36;
            this.selectExamResultComboBox.Click += new System.EventHandler(this.selectExamResultComboBox_Click);
            // 
            // selectExamResultLabel
            // 
            this.selectExamResultLabel.AutoSize = true;
            this.selectExamResultLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectExamResultLabel.ForeColor = System.Drawing.Color.Red;
            this.selectExamResultLabel.Location = new System.Drawing.Point(8, 15);
            this.selectExamResultLabel.Name = "selectExamResultLabel";
            this.selectExamResultLabel.Size = new System.Drawing.Size(115, 25);
            this.selectExamResultLabel.TabIndex = 35;
            this.selectExamResultLabel.Text = "Select exam";
            // 
            // studentEditProfilePage
            // 
            this.studentEditProfilePage.Controls.Add(this.studentEditAccountButton);
            this.studentEditProfilePage.Controls.Add(this.studentEditPasswordTextBox);
            this.studentEditProfilePage.Controls.Add(this.studentEditPasswordLabel);
            this.studentEditProfilePage.Controls.Add(this.studentEditDegreeCourseTextBox);
            this.studentEditProfilePage.Controls.Add(this.studentEditDegreeCourseLabel);
            this.studentEditProfilePage.Controls.Add(this.studentEditSchoolTextBox);
            this.studentEditProfilePage.Controls.Add(this.studentEditSchoolLabel);
            this.studentEditProfilePage.Controls.Add(this.studentEditAgeTextBox);
            this.studentEditProfilePage.Controls.Add(this.studentEditAgeLabel);
            this.studentEditProfilePage.Controls.Add(this.studentEditUsernameTextBox);
            this.studentEditProfilePage.Controls.Add(this.studentEditUsernameLabel);
            this.studentEditProfilePage.Controls.Add(this.studentEditLastNameTextBox);
            this.studentEditProfilePage.Controls.Add(this.studentEditLastNameLabel);
            this.studentEditProfilePage.Controls.Add(this.studentEditFirstNameTextBox);
            this.studentEditProfilePage.Controls.Add(this.studentEditFirstNameLabel);
            this.studentEditProfilePage.Location = new System.Drawing.Point(4, 41);
            this.studentEditProfilePage.Name = "studentEditProfilePage";
            this.studentEditProfilePage.Padding = new System.Windows.Forms.Padding(3);
            this.studentEditProfilePage.Size = new System.Drawing.Size(635, 556);
            this.studentEditProfilePage.TabIndex = 5;
            this.studentEditProfilePage.Text = "Edit Profile";
            this.studentEditProfilePage.UseVisualStyleBackColor = true;
            // 
            // studentEditAccountButton
            // 
            this.studentEditAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.studentEditAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.studentEditAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.studentEditAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentEditAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditAccountButton.ForeColor = System.Drawing.Color.Red;
            this.studentEditAccountButton.Location = new System.Drawing.Point(28, 343);
            this.studentEditAccountButton.Name = "studentEditAccountButton";
            this.studentEditAccountButton.Size = new System.Drawing.Size(98, 61);
            this.studentEditAccountButton.TabIndex = 54;
            this.studentEditAccountButton.Text = "Edit";
            this.studentEditAccountButton.UseVisualStyleBackColor = true;
            this.studentEditAccountButton.Click += new System.EventHandler(this.studentEditAccountButton_Click);
            // 
            // studentEditPasswordTextBox
            // 
            this.studentEditPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentEditPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditPasswordTextBox.ForeColor = System.Drawing.Color.Red;
            this.studentEditPasswordTextBox.Location = new System.Drawing.Point(221, 155);
            this.studentEditPasswordTextBox.Name = "studentEditPasswordTextBox";
            this.studentEditPasswordTextBox.Size = new System.Drawing.Size(134, 33);
            this.studentEditPasswordTextBox.TabIndex = 53;
            // 
            // studentEditPasswordLabel
            // 
            this.studentEditPasswordLabel.AutoSize = true;
            this.studentEditPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditPasswordLabel.ForeColor = System.Drawing.Color.Red;
            this.studentEditPasswordLabel.Location = new System.Drawing.Point(23, 151);
            this.studentEditPasswordLabel.Name = "studentEditPasswordLabel";
            this.studentEditPasswordLabel.Size = new System.Drawing.Size(103, 30);
            this.studentEditPasswordLabel.TabIndex = 52;
            this.studentEditPasswordLabel.Text = "Password";
            // 
            // studentEditDegreeCourseTextBox
            // 
            this.studentEditDegreeCourseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentEditDegreeCourseTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditDegreeCourseTextBox.ForeColor = System.Drawing.Color.Red;
            this.studentEditDegreeCourseTextBox.Location = new System.Drawing.Point(221, 278);
            this.studentEditDegreeCourseTextBox.Name = "studentEditDegreeCourseTextBox";
            this.studentEditDegreeCourseTextBox.Size = new System.Drawing.Size(134, 33);
            this.studentEditDegreeCourseTextBox.TabIndex = 51;
            // 
            // studentEditDegreeCourseLabel
            // 
            this.studentEditDegreeCourseLabel.AutoSize = true;
            this.studentEditDegreeCourseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditDegreeCourseLabel.ForeColor = System.Drawing.Color.Red;
            this.studentEditDegreeCourseLabel.Location = new System.Drawing.Point(23, 274);
            this.studentEditDegreeCourseLabel.Name = "studentEditDegreeCourseLabel";
            this.studentEditDegreeCourseLabel.Size = new System.Drawing.Size(154, 30);
            this.studentEditDegreeCourseLabel.TabIndex = 50;
            this.studentEditDegreeCourseLabel.Text = "Degree Course";
            // 
            // studentEditSchoolTextBox
            // 
            this.studentEditSchoolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentEditSchoolTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditSchoolTextBox.ForeColor = System.Drawing.Color.Red;
            this.studentEditSchoolTextBox.Location = new System.Drawing.Point(221, 235);
            this.studentEditSchoolTextBox.Name = "studentEditSchoolTextBox";
            this.studentEditSchoolTextBox.Size = new System.Drawing.Size(134, 33);
            this.studentEditSchoolTextBox.TabIndex = 49;
            // 
            // studentEditSchoolLabel
            // 
            this.studentEditSchoolLabel.AutoSize = true;
            this.studentEditSchoolLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditSchoolLabel.ForeColor = System.Drawing.Color.Red;
            this.studentEditSchoolLabel.Location = new System.Drawing.Point(23, 235);
            this.studentEditSchoolLabel.Name = "studentEditSchoolLabel";
            this.studentEditSchoolLabel.Size = new System.Drawing.Size(77, 30);
            this.studentEditSchoolLabel.TabIndex = 48;
            this.studentEditSchoolLabel.Text = "School";
            // 
            // studentEditAgeTextBox
            // 
            this.studentEditAgeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentEditAgeTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditAgeTextBox.ForeColor = System.Drawing.Color.Red;
            this.studentEditAgeTextBox.Location = new System.Drawing.Point(221, 198);
            this.studentEditAgeTextBox.Name = "studentEditAgeTextBox";
            this.studentEditAgeTextBox.Size = new System.Drawing.Size(134, 33);
            this.studentEditAgeTextBox.TabIndex = 47;
            // 
            // studentEditAgeLabel
            // 
            this.studentEditAgeLabel.AutoSize = true;
            this.studentEditAgeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditAgeLabel.ForeColor = System.Drawing.Color.Red;
            this.studentEditAgeLabel.Location = new System.Drawing.Point(23, 194);
            this.studentEditAgeLabel.Name = "studentEditAgeLabel";
            this.studentEditAgeLabel.Size = new System.Drawing.Size(51, 30);
            this.studentEditAgeLabel.TabIndex = 46;
            this.studentEditAgeLabel.Text = "Age";
            // 
            // studentEditUsernameTextBox
            // 
            this.studentEditUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentEditUsernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditUsernameTextBox.ForeColor = System.Drawing.Color.Red;
            this.studentEditUsernameTextBox.Location = new System.Drawing.Point(221, 114);
            this.studentEditUsernameTextBox.Name = "studentEditUsernameTextBox";
            this.studentEditUsernameTextBox.Size = new System.Drawing.Size(134, 33);
            this.studentEditUsernameTextBox.TabIndex = 45;
            // 
            // studentEditUsernameLabel
            // 
            this.studentEditUsernameLabel.AutoSize = true;
            this.studentEditUsernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditUsernameLabel.ForeColor = System.Drawing.Color.Red;
            this.studentEditUsernameLabel.Location = new System.Drawing.Point(23, 110);
            this.studentEditUsernameLabel.Name = "studentEditUsernameLabel";
            this.studentEditUsernameLabel.Size = new System.Drawing.Size(109, 30);
            this.studentEditUsernameLabel.TabIndex = 44;
            this.studentEditUsernameLabel.Text = "Username";
            // 
            // studentEditLastNameTextBox
            // 
            this.studentEditLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentEditLastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditLastNameTextBox.ForeColor = System.Drawing.Color.Red;
            this.studentEditLastNameTextBox.Location = new System.Drawing.Point(221, 71);
            this.studentEditLastNameTextBox.Name = "studentEditLastNameTextBox";
            this.studentEditLastNameTextBox.Size = new System.Drawing.Size(134, 33);
            this.studentEditLastNameTextBox.TabIndex = 43;
            // 
            // studentEditLastNameLabel
            // 
            this.studentEditLastNameLabel.AutoSize = true;
            this.studentEditLastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditLastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.studentEditLastNameLabel.Location = new System.Drawing.Point(23, 71);
            this.studentEditLastNameLabel.Name = "studentEditLastNameLabel";
            this.studentEditLastNameLabel.Size = new System.Drawing.Size(114, 30);
            this.studentEditLastNameLabel.TabIndex = 42;
            this.studentEditLastNameLabel.Text = "Last Name";
            // 
            // studentEditFirstNameTextBox
            // 
            this.studentEditFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentEditFirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditFirstNameTextBox.ForeColor = System.Drawing.Color.Red;
            this.studentEditFirstNameTextBox.Location = new System.Drawing.Point(221, 34);
            this.studentEditFirstNameTextBox.Name = "studentEditFirstNameTextBox";
            this.studentEditFirstNameTextBox.Size = new System.Drawing.Size(134, 33);
            this.studentEditFirstNameTextBox.TabIndex = 41;
            // 
            // studentEditFirstNameLabel
            // 
            this.studentEditFirstNameLabel.AutoSize = true;
            this.studentEditFirstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentEditFirstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.studentEditFirstNameLabel.Location = new System.Drawing.Point(23, 30);
            this.studentEditFirstNameLabel.Name = "studentEditFirstNameLabel";
            this.studentEditFirstNameLabel.Size = new System.Drawing.Size(117, 30);
            this.studentEditFirstNameLabel.TabIndex = 40;
            this.studentEditFirstNameLabel.Text = "First Name";
            // 
            // showResultButton
            // 
            this.showResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showResultButton.Location = new System.Drawing.Point(413, 18);
            this.showResultButton.Name = "showResultButton";
            this.showResultButton.Size = new System.Drawing.Size(79, 33);
            this.showResultButton.TabIndex = 38;
            this.showResultButton.Text = "Show";
            this.showResultButton.UseVisualStyleBackColor = true;
            this.showResultButton.Click += new System.EventHandler(this.showResultButton_Click);
            // 
            // StudentPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 701);
            this.Controls.Add(this.studentMenuTabControl);
            this.Controls.Add(this.adminPagePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "StudentPageForm";
            this.Text = "Examination System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentPageForm_FormClosing);
            this.adminPagePanel.ResumeLayout(false);
            this.adminPagePanel.PerformLayout();
            this.studentMenuTabControl.ResumeLayout(false);
            this.studentDashboardPage.ResumeLayout(false);
            this.studentExamListPage.ResumeLayout(false);
            this.studentTakeExamPage.ResumeLayout(false);
            this.studentTakeExamPage.PerformLayout();
            this.takeExamGroupBox.ResumeLayout(false);
            this.takeExamGroupBox.PerformLayout();
            this.studentMyResultsPage.ResumeLayout(false);
            this.studentMyResultsPage.PerformLayout();
            this.studentEditProfilePage.ResumeLayout(false);
            this.studentEditProfilePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminPagePanel;
        private System.Windows.Forms.Button studentLogoutButton;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label pageNameLabel;
        private System.Windows.Forms.TabControl studentMenuTabControl;
        private System.Windows.Forms.TabPage studentDashboardPage;
        private System.Windows.Forms.TabPage studentExamListPage;
        private System.Windows.Forms.TabPage studentTakeExamPage;
        private System.Windows.Forms.TabPage studentMyResultsPage;
        private System.Windows.Forms.TabPage studentEditProfilePage;
        private System.Windows.Forms.Button studentEditAccountButton;
        private System.Windows.Forms.TextBox studentEditPasswordTextBox;
        private System.Windows.Forms.Label studentEditPasswordLabel;
        private System.Windows.Forms.TextBox studentEditDegreeCourseTextBox;
        private System.Windows.Forms.Label studentEditDegreeCourseLabel;
        private System.Windows.Forms.TextBox studentEditSchoolTextBox;
        private System.Windows.Forms.Label studentEditSchoolLabel;
        private System.Windows.Forms.TextBox studentEditAgeTextBox;
        private System.Windows.Forms.Label studentEditAgeLabel;
        private System.Windows.Forms.TextBox studentEditUsernameTextBox;
        private System.Windows.Forms.Label studentEditUsernameLabel;
        private System.Windows.Forms.TextBox studentEditLastNameTextBox;
        private System.Windows.Forms.Label studentEditLastNameLabel;
        private System.Windows.Forms.TextBox studentEditFirstNameTextBox;
        private System.Windows.Forms.Label studentEditFirstNameLabel;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.ComboBox selectExamResultComboBox;
        private System.Windows.Forms.Label selectExamResultLabel;
        private System.Windows.Forms.ListBox allExamListBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button takeExamButton;
        private System.Windows.Forms.TextBox accessCodeTextBox;
        private System.Windows.Forms.Label accessCodeLabel;
        private System.Windows.Forms.Label selectExamLabel;
        private System.Windows.Forms.ComboBox selectExamComboBox;
        private System.Windows.Forms.GroupBox takeExamGroupBox;
        private System.Windows.Forms.RadioButton answerCRadioButton;
        private System.Windows.Forms.RadioButton answerDRadioButton;
        private System.Windows.Forms.RadioButton answerBRadioButton;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.TextBox answerDTextBox;
        private System.Windows.Forms.TextBox answerCTextBox;
        private System.Windows.Forms.RadioButton answerARadioButton;
        private System.Windows.Forms.TextBox answerBTextBox;
        private System.Windows.Forms.TextBox answerATextBox;
        private System.Windows.Forms.TextBox questionNameTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.ListBox examQuestionListBox;
        private System.Windows.Forms.Button finishExamButton;
        private System.Windows.Forms.MonthCalendar studentMonthCalendar;
        private System.Windows.Forms.ListBox selectedExamListBox;
        private System.Windows.Forms.Button showResultButton;
    }
}