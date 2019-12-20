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
        StudentModel CreateStudentAccount(StudentModel model);
        TeacherModel CreateTeacherAccount(TeacherModel model);
        AdminModel CreateAdminAccount(AdminModel model);
        QuestionModel CreateQuestion(QuestionModel model);
        ExamModel CreateExam(ExamModel model);
    }
}
