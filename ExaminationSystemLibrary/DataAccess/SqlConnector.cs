using ExaminationSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace ExaminationSystemLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public StudentModel CreateStudentAccount(StudentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                var p = new DynamicParameters();
                p.Add("FirstName", model.FirstName);
                p.Add("LastName", model.LastName);
                p.Add("UserName", model.UserName);
                p.Add("Password", model.Password);
                p.Add("Age", model.Age);
                p.Add("School", model.School);
                p.Add("DegreeCourse", model.DegreeCourse);
                p.Add("Role", model.Role);

                connection.Execute("dbo.spStudent_Insert", p, commandType:CommandType.StoredProcedure);

                return model;
            }
        }
        public TeacherModel CreateTeacherAccount(TeacherModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                var p = new DynamicParameters();
                p.Add("FirstName", model.FirstName);
                p.Add("LastName", model.LastName);
                p.Add("UserName", model.UserName);
                p.Add("Password", model.Password);
                p.Add("AcademicTitle", model.AcademicTitle);
                p.Add("School", model.School);
                p.Add("Role", model.Role);


                connection.Execute("dbo.spTeacher_Insert", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }
        public AdminModel CreateAdminAccount(AdminModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                var p = new DynamicParameters();
                p.Add("FirstName", model.FirstName);
                p.Add("LastName", model.LastName);
                p.Add("UserName", model.UserName);
                p.Add("Password", model.Password);
                p.Add("Role", model.Role);


                connection.Execute("dbo.spAdmin_Insert", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }
        public QuestionModel CreateQuestion(QuestionModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                var p = new DynamicParameters();
                p.Add("ExamName", model.ExamName);
                p.Add("Question", model.Question);
                p.Add("Number", model.QuestionNumber);
                p.Add("AnswerA", model.AnswerA);
                p.Add("AnswerB", model.AnswerB);
                p.Add("AnswerC", model.AnswerC);
                p.Add("AnswerD", model.AnswerD);
                p.Add("CorrectAnswer", model.CorrectAnswer);


                connection.Execute("dbo.spQuestion_Insert", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }
        public ExamModel CreateExam(ExamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                var p = new DynamicParameters();
                p.Add("AccessCode", model.AccessCode);
                p.Add("Creator", model.Creator);
                p.Add("Name", model.Name);
                p.Add("NumberOfQuestions", model.QuestionAmount);
               

                connection.Execute("dbo.spExam_Insert", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }
    }
}
