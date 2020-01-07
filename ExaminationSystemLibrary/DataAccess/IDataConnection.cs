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
        bool CreateTeacherAccount(TeacherModel model);
        bool CreateAdminAccount(AdminModel model);
        QuestionModel CreateQuestion(QuestionModel model);
        ExamModel CreateExam(ExamModel model);
        List<ExamModel> GetExams();
        //List <ExamModel> GetExam_All();
        List<QuestionModel> GetQuestions();
        ExamModel UpdateExam(ExamModel model1, ExamModel model2);
        QuestionModel UpdateQuestion(QuestionModel model1, ExamModel model2);
    }
}
