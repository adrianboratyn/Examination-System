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
    public partial class AdminPageForm : Form
    {
        public AdminPageForm()
        {
            InitializeComponent();
        }

        public AdminPageForm(string name)
        {
            InitializeComponent();
            adminNameLabel.Text = name;
        }

        private void adminLogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPageForm form = new LoginPageForm();
            form.Show();
        }

        private void AdminPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //code for creating new exam
        private bool ValidateAdminAddQuestion()
        {
            bool output = true;

            //exam name validation
            if (examNameTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }
            //access code validation
            if (accessCodeTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }
            int accessCode = 0;
            bool accessCodeIsValid = int.TryParse(accessCodeTextBox.Text, out accessCode);

            if (accessCodeIsValid == false)
            {
                //error message
                output = false;
            }
            //question name validation
            if (questionNameTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }

            //answer a validation
            if (answerATextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }

            //answer b validation
            if (answerBTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }

            //answer c validation
            if (answerCTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }

            //answer d validation
            if (answerDTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }

            //correct answer validation
            if (correctAnswerTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }
            //correct answer validation
            if (correctAnswerTextBox.Text.Length > 1)
            {
                //error message
                output = false;
            }
            return output;
        }

        List<QuestionModel> addedQuestion = new List<QuestionModel>(); // lista potrzebna do listboxa, przycisk add exam -> addedQustion.Clear();
        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            if (ValidateAdminAddQuestion() == true)
            {

                QuestionModel model = new QuestionModel(
                     examNameTextBox.Text,
                     questionNameTextBox.Text,
                     1,
                     answerATextBox.Text,
                     answerBTextBox.Text,
                     answerCTextBox.Text,
                     answerDTextBox.Text,
                     correctAnswerTextBox.Text);

                addedQuestion.Add(model);
                model.QuestionNumber = addedQuestion.IndexOf(model) + 1;

                createdQuestionListBox.DataSource = null;
                createdQuestionListBox.DataSource = addedQuestion;
                createdQuestionListBox.DisplayMember = "FullName";


                questionNameTextBox.Text = "";
                answerATextBox.Text = "";
                answerBTextBox.Text = "";
                answerCTextBox.Text = "";
                answerDTextBox.Text = "";
                correctAnswerTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid information. Try again.");
            }
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            QuestionModel model = (QuestionModel)createdQuestionListBox.SelectedItem;

            if (model != null)
            {
                addedQuestion.Remove(model);
                foreach (QuestionModel item in addedQuestion)
                {
                    item.QuestionNumber = addedQuestion.IndexOf(item) + 1;

                }

                createdQuestionListBox.DataSource = null;
                createdQuestionListBox.DataSource = addedQuestion;
                createdQuestionListBox.DisplayMember = "FullName";
            }
        }

        private bool ValidateAdminAddExam()
        {
            bool output = true;

            //exam name validation
            if (examNameTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }
            //access code validation
            if (accessCodeTextBox.Text.Length == 0)
            {
                //error message
                output = false;
            }
            int accessCode = 0;
            bool accessCodeIsValid = int.TryParse(accessCodeTextBox.Text, out accessCode);

            if (accessCodeIsValid == false)
            {
                //error message
                output = false;
            }
            //question name validation
            if (questionNameTextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            //answer a validation
            if (answerATextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            //answer b validation
            if (answerBTextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            //answer c validation
            if (answerCTextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            //answer d validation
            if (answerDTextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            //correct answer validation
            if (correctAnswerTextBox.Text.Length != 0)
            {
                //error message
                output = false;
            }

            return output;
        }

        private void createExamButton_Click(object sender, EventArgs e)
        {
            if (ValidateAdminAddExam() == true)
            {
                foreach (QuestionModel item in addedQuestion)
                {
                    GlobalConfig.Connection.CreateQuestion(item);
                    allQuestionsList.Add(item);

                }
                ExamModel model = new ExamModel();
                model.AccessCode = int.Parse(accessCodeTextBox.Text);
                model.Creator = adminNameLabel.Text;
                model.Name = examNameTextBox.Text;
                model.QuestionAmount = addedQuestion.Count();

                GlobalConfig.Connection.CreateExam(model);

                addedQuestion.Clear();

                accessCodeTextBox.Text = "";
                examNameTextBox.Text = "";
                createdQuestionListBox.DataSource = null;
                createdQuestionListBox.DataSource = addedQuestion;

                allExamList.Add(model);

            }
        }

        //code for editing exam
        private List<ExamModel> allExamList = GlobalConfig.Connection.GetExams();
        private List<ExamModel> adminExams = new List<ExamModel>();

        private List<QuestionModel> allQuestionsList = GlobalConfig.Connection.GetQuestions();
        private List<QuestionModel> examQuestions = new List<QuestionModel>();

        private void selectExamEditComboBox_Click(object sender, EventArgs e)
        {
            adminExams.Clear();
            examQuestions.Clear();
            foreach (ExamModel item in allExamList)
            {
                if (item.Creator == adminNameLabel.Text)
                {
                    adminExams.Add(item);
                }
            }
            selectExamEditComboBox.DataSource = null;
            selectExamEditComboBox.DataSource = adminExams;
            selectExamEditComboBox.DisplayMember = "examName";
        }

        private ExamModel selectedExam = new ExamModel();

        private void editExamButton_Click(object sender, EventArgs e)
        {
            examQuestions.Clear();
            selectedExam = (ExamModel)selectExamEditComboBox.SelectedItem;
            editExamNameTextBox.Text = selectedExam.Name;
            editExamCodeTextBox.Text = selectedExam.AccessCode.ToString();

            foreach (QuestionModel item in allQuestionsList)
            {
                if (item.ExamName == selectedExam.Name)
                {
                    examQuestions.Add(item);
                    item.QuestionNumber = examQuestions.IndexOf(item) + 1;
                }
            }
            questionForEditListBox.DataSource = null;
            questionForEditListBox.DataSource = examQuestions;
            questionForEditListBox.DisplayMember = "FullName";
        }

        private QuestionModel selectedQuestion = new QuestionModel();

        private void questionForEditListBox_Click(object sender, EventArgs e)
        {
            selectedQuestion = (QuestionModel)questionForEditListBox.SelectedItem;

            editQuestionTextBox.Text = selectedQuestion.Question;
            editAnswerATextBox.Text = selectedQuestion.AnswerA;
            editAnswerBTextBox.Text = selectedQuestion.AnswerB;
            editAnswerCTextBox.Text = selectedQuestion.AnswerC;
            editAnswerDTextBox.Text = selectedQuestion.AnswerD;
            editCorrectAnswerTextBox.Text = selectedQuestion.CorrectAnswer;
        }

        private void deleteEditedButton_Click(object sender, EventArgs e)
        {
            QuestionModel model = (QuestionModel)questionForEditListBox.SelectedItem;

            if (model != null)
            {
                examQuestions.Remove(model);
                foreach (QuestionModel item in examQuestions)
                {
                    item.QuestionNumber = examQuestions.IndexOf(item) + 1;

                }

                questionForEditListBox.DataSource = null;
                questionForEditListBox.DataSource = examQuestions;
                questionForEditListBox.DisplayMember = "FullName";

                editQuestionTextBox.Text = "";
                editAnswerATextBox.Text = "";
                editAnswerBTextBox.Text = "";
                editAnswerCTextBox.Text = "";
                editAnswerDTextBox.Text = "";
                editCorrectAnswerTextBox.Text = "";
            }
        }

        private void editQuestionButton_Click(object sender, EventArgs e)
        {
            foreach (QuestionModel item in examQuestions)
            {
                if (item == (QuestionModel)questionForEditListBox.SelectedItem)
                {
                    item.Question = editQuestionTextBox.Text;
                    item.AnswerA = editAnswerATextBox.Text;
                    item.AnswerB = editAnswerBTextBox.Text;
                    item.AnswerC = editAnswerCTextBox.Text;
                    item.AnswerD = editAnswerDTextBox.Text;
                    item.CorrectAnswer = editCorrectAnswerTextBox.Text;
                }
            }
            questionForEditListBox.DataSource = null;
            questionForEditListBox.DataSource = examQuestions;
            questionForEditListBox.DisplayMember = "FullName";

            editQuestionTextBox.Text = "";
            editAnswerATextBox.Text = "";
            editAnswerBTextBox.Text = "";
            editAnswerCTextBox.Text = "";
            editAnswerDTextBox.Text = "";
            editCorrectAnswerTextBox.Text = "";

            selectedQuestion = null;
        }

        private void saveChangesExamButton_Click(object sender, EventArgs e)
        {
            ExamModel model = new ExamModel();
            model.AccessCode = int.Parse(editExamCodeTextBox.Text);
            model.Creator = adminNameLabel.Text;
            model.Name = editExamNameTextBox.Text;
            model.QuestionAmount = examQuestions.Count();

            GlobalConfig.Connection.UpdateExam(model, selectedExam);

            foreach (QuestionModel item in examQuestions)
            {
                item.ExamName = editExamNameTextBox.Text;
                GlobalConfig.Connection.UpdateQuestion(item, selectedExam);
            }

            examQuestions.Clear();
            allExamList = GlobalConfig.Connection.GetExams();

            editExamCodeTextBox.Text = "";
            editExamNameTextBox.Text = "";
            editQuestionTextBox.Text = "";
            editAnswerATextBox.Text = "";
            editAnswerBTextBox.Text = "";
            editAnswerCTextBox.Text = "";
            editAnswerDTextBox.Text = "";
            editCorrectAnswerTextBox.Text = "";

            questionForEditListBox.DataSource = null;
            questionForEditListBox.DataSource = examQuestions;

            selectedExam = null;
        }

        //code for editing profile

        private bool ValidateAdminEditProfile()
        {
            bool output = true;

            if (adminEditFirstNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (adminEditLastNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (adminEditUsernameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (adminEditPasswordTextBox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }
        private void adminEditAccountButton_Click(object sender, EventArgs e)
        {
            if(ValidateAdminEditProfile() == true)
            {
                AdminModel model = new AdminModel();
                model.FirstName = adminEditFirstNameTextBox.Text;
                model.LastName = adminEditLastNameTextBox.Text;
                model.UserName = adminEditUsernameTextBox.Text;
                model.Password = adminEditPasswordTextBox.Text;

                if(GlobalConfig.Connection.EditAdminAccount(model, adminNameLabel.Text) == true)
                {
                    MessageBox.Show("Update Successful");
                    adminNameLabel.Text = model.UserName;
                }
                else
                {
                    MessageBox.Show("User with this username already exist");
                }
            }
        }
    }
}
