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
        public bool CreateStudentAccount(StudentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                bool query = false;

                var p = new DynamicParameters();
                p.Add("FirstName", model.FirstName);
                p.Add("LastName", model.LastName);
                p.Add("UserName", model.UserName);
                p.Add("Password", model.Password);
                p.Add("Age", model.Age);
                p.Add("School", model.School);
                p.Add("DegreeCourse", model.DegreeCourse);
                p.Add("Role", model.Role);

                int rows = connection.Execute("SELECT * from dbo.Student WHERE UserName = @UserName", model);

                if (rows == 0)
                {
                    query = true;
                    connection.Execute("dbo.spStudent_Insert", p, commandType: CommandType.StoredProcedure);
                }
                

                return query;
            }
        }
        public bool CreateTeacherAccount(TeacherModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                bool query = false;

                var p = new DynamicParameters();
                p.Add("FirstName", model.FirstName);
                p.Add("LastName", model.LastName);
                p.Add("UserName", model.UserName);
                p.Add("Password", model.Password);
                p.Add("AcademicTitle", model.AcademicTitle);
                p.Add("School", model.School);
                p.Add("Role", model.Role);


                int rows = connection.Execute("SELECT * from dbo.Teacher WHERE UserName = @UserName", model);

                if (rows == 0)
                {
                    query = true;
                    connection.Execute("dbo.spTeacher_Insert", p, commandType: CommandType.StoredProcedure);
                }


                return query;
            }
        }
        public bool CreateAdminAccount(AdminModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                bool query = false;

                var p = new DynamicParameters();
                p.Add("FirstName", model.FirstName);
                p.Add("LastName", model.LastName);
                p.Add("UserName", model.UserName);
                p.Add("Password", model.Password);
                p.Add("Role", model.Role);

                int rows = connection.Execute("SELECT * from dbo.Admin WHERE UserName = @UserName", model);

                if (rows == 0)
                {
                    query = true;
                    connection.Execute("dbo.spAdmin_Insert", p, commandType: CommandType.StoredProcedure);
                }


                return query;
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

        public List<ExamModel> GetExams()
        {
            List<ExamModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                output = connection.Query<ExamModel>("dbo.spExam_Get").ToList();
            }
            return output;
        }

        public List<QuestionModel> GetQuestions()
        {
            List<QuestionModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                output = connection.Query<QuestionModel>("dbo.spQuestion_Get").ToList();
            }
            return output;
        }

        public ExamModel UpdateExam(ExamModel model1, ExamModel model2)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                var p = new DynamicParameters();
                p.Add("AccessCode", model1.AccessCode);
                p.Add("Creator", model1.Creator);
                p.Add("Name", model1.Name);
                p.Add("NumberOfQuestions", model1.QuestionAmount);
                p.Add("OldName", model2.Name);


                connection.Execute("dbo.spExam_Update", p, commandType: CommandType.StoredProcedure);

                return model1;
            }
        }

        public QuestionModel UpdateQuestion(QuestionModel model1, ExamModel model2)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                var p = new DynamicParameters();
                p.Add("ExamName", model1.ExamName);
                p.Add("Question", model1.Question);
                p.Add("Number", model1.QuestionNumber);
                p.Add("AnswerA", model1.AnswerA);
                p.Add("AnswerB", model1.AnswerB);
                p.Add("AnswerC", model1.AnswerC);
                p.Add("AnswerD", model1.AnswerD);
                p.Add("CorrectAnswer", model1.CorrectAnswer);
                p.Add("OldName", model2.Name);


                connection.Execute("dbo.spQuestion_Update", p, commandType: CommandType.StoredProcedure);
                return model1;
            }
        }
        
        
    }
}
