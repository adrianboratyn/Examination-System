using ExaminationSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.DataAccess
{
    public interface IDataConnection
    {
        bool CreateStudentAccount(StudentModel model);
        bool StudentLogin(string userName, string password);
        bool CreateTeacherAccount(TeacherModel model);
        bool TeacherLogin(string userName, string password);
        bool CreateAdminAccount(AdminModel model);
        bool AdminLogin(string userName, string password);
        QuestionModel CreateQuestion(QuestionModel model);
        ExamModel CreateExam(ExamModel model);
        List<ExamModel> GetExams();
        //List <ExamModel> GetExam_All();
        List<QuestionModel> GetQuestions();
        ExamModel UpdateExam(ExamModel model1, ExamModel model2);
        QuestionModel UpdateQuestion(QuestionModel model1, ExamModel model2);
    }
}
