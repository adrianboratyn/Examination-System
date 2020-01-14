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

        private List<ExamModel> allExamList = GlobalConfig.Connection.GetExams();
        private void studentMenuTabControl_Click(object sender, EventArgs e)
        {
            allExamListBox.DataSource = allExamList;
            allExamListBox.DisplayMember = "examAndCreator";
        }

        private List<ExamModel> signUpExamList = new List<ExamModel>();
        private void signUpButton_Click(object sender, EventArgs e)
        {
            ExamModel model = (ExamModel)allExamListBox.SelectedItem;
            
            signUpExamList.Add(model);
            selectedExamListBox.DataSource = null;
            selectedExamListBox.DataSource = signUpExamList;
            selectedExamListBox.DisplayMember = "examAndCode";
            
        }

        private void selectExamComboBox_Click(object sender, EventArgs e)
        {
            
            selectExamComboBox.DataSource = allExamList;
            selectExamComboBox.DisplayMember = "examName";
        }

        private List<QuestionModel> allQuestionsList = GlobalConfig.Connection.GetQuestions();
        private List<QuestionModel> examQuestions = new List<QuestionModel>();
        private ExamModel selectedExam = new ExamModel();
        private char[] answers;

        private void takeExamButton_Click(object sender, EventArgs e)
        {
            examQuestions.Clear();
            if (accessCodeTextBox.Text.Length == 0)
            {
                MessageBox.Show("Provide code");
            }
            selectedExam = (ExamModel)selectExamComboBox.SelectedItem;
            int accessCode = 0;
            bool accessCodeIsValid = int.TryParse(accessCodeTextBox.Text, out accessCode);
            if (accessCodeIsValid == false)
            {
                MessageBox.Show("Code must be a number");
            }
            if (selectedExam.AccessCode == accessCode)
            {
                foreach (QuestionModel item in allQuestionsList)
                {
                    if (item.ExamName == selectedExam.Name)
                    {
                        examQuestions.Add(item);
                        item.QuestionNumber = examQuestions.IndexOf(item) + 1;
                    }
                }
                answers = new char[examQuestions.Count()];
                for(int i=0; i< answers.Length; i++)
                {
                    answers[i] = 'f';
                }

                examQuestionListBox.DataSource = null;
                examQuestionListBox.DataSource = examQuestions;
                examQuestionListBox.DisplayMember = "FullName";
            }
        }

        private QuestionModel selectedQuestion = new QuestionModel();
        private void examQuestionListBox_Click(object sender, EventArgs e)
        {
            selectedQuestion = (QuestionModel)examQuestionListBox.SelectedItem;

            questionNameTextBox.Text = selectedQuestion.Question;
            answerATextBox.Text = selectedQuestion.AnswerA;
            answerBTextBox.Text = selectedQuestion.AnswerB;
            answerCTextBox.Text = selectedQuestion.AnswerC;
            answerDTextBox.Text = selectedQuestion.AnswerD;
        }
       
        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (answerARadioButton.Checked == true)
            {
                answers[examQuestions.IndexOf(selectedQuestion)] = 'a';
                answerARadioButton.Checked = false;
            }
            if (answerBRadioButton.Checked == true)
            {
                answers[examQuestions.IndexOf(selectedQuestion)] = 'b';
                answerBRadioButton.Checked = false;

            }
            if (answerCRadioButton.Checked == true)
            {
                answers[examQuestions.IndexOf(selectedQuestion)] = 'c';
                answerCRadioButton.Checked = false;

            }
            if (answerDRadioButton.Checked == true)
            {
                answers[examQuestions.IndexOf(selectedQuestion)] = 'd';
                answerDRadioButton.Checked = false;
            }

            questionNameTextBox.Text = "";
            answerATextBox.Text = "";
            answerBTextBox.Text = "";
            answerCTextBox.Text = "";
            answerDTextBox.Text = "";
        }
        private void finishExamButton_Click(object sender, EventArgs e)
        {
            int score = 0;
            bool allAnswers = true;
            foreach (QuestionModel model in examQuestions)
            {
                char answer = model.CorrectAnswer[0];
                if (answers[examQuestions.IndexOf(model)] == 'f')
                {
                    MessageBox.Show("You didn't answer all questions");
                    allAnswers = false;
                    
                }
                else if (answer == answers[examQuestions.IndexOf(model)])
                {
                    score++;
                }
            }
            if(allAnswers)
            {
                MessageBox.Show("Your score: " + score.ToString() + "/" + examQuestions.Count()) ;
            }

            ResultModel result = new ResultModel();
            result.ExamCreator = selectedExam.Creator;
            result.ExamName = selectedExam.Name;
            result.StudentUserName = studentNameLabel.Text;
            result.Score = score;
            GlobalConfig.Connection.CreateResult(result);
            
            examQuestions.Clear();
            allStudentCourses = GlobalConfig.Connection.GetStudentCourses();
            allResult = GlobalConfig.Connection.GetResults();
            questionNameTextBox.Text = "";
            answerATextBox.Text = "";
            answerBTextBox.Text = "";
            answerCTextBox.Text = "";
            answerDTextBox.Text = "";

            examQuestionListBox.DataSource = null;
            examQuestionListBox.DataSource = examQuestions;

            selectedExam = null;
            selectedQuestion = null;

        }

        private List<ResultModel> allResult = GlobalConfig.Connection.GetResults();
        private List<ResultModel> allStudentCourses = GlobalConfig.Connection.GetStudentCourses();
        private List<ResultModel> studentResult = new List<ResultModel>();
        private List<ResultModel> studentCourses = new List<ResultModel>();

        private void selectExamResultComboBox_Click(object sender, EventArgs e)
        {
            selectExamResultComboBox.DataSource = null;
            
            resultListBox.DataSource = null;
            studentResult.Clear();
            studentCourses.Clear();
            foreach (ResultModel item in allStudentCourses)
            {
                if (item.StudentUserName == studentNameLabel.Text)
                {
                    studentCourses.Add(item);
                }
            }
            selectExamResultComboBox.DataSource = null;
            selectExamResultComboBox.DataSource = studentCourses;
            selectExamResultComboBox.DisplayMember = "examName";
        }
        private ResultModel selectedResult = new ResultModel();
        private void showResultButton_Click(object sender, EventArgs e)
        {
            studentResult.Clear();
            selectedResult = (ResultModel)selectExamResultComboBox.SelectedItem;
            foreach (ResultModel model in allResult)
            {
                if (model.StudentUserName == selectedResult.StudentUserName && model.ExamName == selectedResult.ExamName)
                {
                    studentResult.Add(model);
                }
            }
            resultListBox.DataSource = null;
            resultListBox.DataSource = studentResult;
            resultListBox.DisplayMember = "resultForStudent";
        }

    }
}
