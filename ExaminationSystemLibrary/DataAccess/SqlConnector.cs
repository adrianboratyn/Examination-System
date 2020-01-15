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

                var d = new DynamicParameters();
                d.Add("UserName", model.UserName);
                d.Add("@UpdatedCounter", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Execute("dbo.spUser_Check", d, commandType: CommandType.StoredProcedure);
                int rows = d.Get<int>("@UpdatedCounter");
                if (rows == 0)
                {
                    query = true;
                    connection.Execute("dbo.spStudent_Insert", p, commandType: CommandType.StoredProcedure);
                }
                return query;
            }
        }

        public bool StudentLogin(string userName, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                bool query = false;
                var d = new DynamicParameters();
                d.Add("UserName", userName);
                d.Add("Password", password);
                d.Add("@UpdatedCounter", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Execute("dbo.spStudent_Check", d, commandType: CommandType.StoredProcedure);
                int rows = d.Get<int>("@UpdatedCounter");
                if (rows == 1)
                {
                    query = true;
                }
                return query;
            }
        }
        public bool EditStudentAccount(StudentModel model, string oldUserName)
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
                p.Add("OldUserName", oldUserName);

                var b = new DynamicParameters();
                b.Add("UserName", model.UserName);
                b.Add("OldUserName", oldUserName);

                var d = new DynamicParameters();
                d.Add("UserName", model.UserName);
                d.Add("@UpdatedCounter", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Execute("dbo.spUser_Check", d, commandType: CommandType.StoredProcedure);
                int rows = d.Get<int>("@UpdatedCounter");
                if (rows == 0 || oldUserName == model.UserName)
                {
                    connection.Execute("dbo.spUser_Update", b, commandType: CommandType.StoredProcedure);
                    connection.Execute("dbo.spStudent_Update", p, commandType: CommandType.StoredProcedure);
                    query = true;
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

                var d = new DynamicParameters();
                d.Add("UserName", model.UserName);
                d.Add("@UpdatedCounter", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Execute("dbo.spUser_Check", d, commandType: CommandType.StoredProcedure);
                int rows = d.Get<int>("@UpdatedCounter");
                if (rows == 0)
                {
                    query = true;
                    connection.Execute("dbo.spTeacher_Insert", p, commandType: CommandType.StoredProcedure);
                }
                return query;
            }
        }

        public bool TeacherLogin(string userName, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                bool query = false;
                var d = new DynamicParameters();
                d.Add("UserName", userName);
                d.Add("Password", password);
                d.Add("@UpdatedCounter", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Execute("dbo.spTeacher_Check", d, commandType: CommandType.StoredProcedure);
                int rows = d.Get<int>("@UpdatedCounter");
                if (rows == 1)
                {
                    query = true;
                }
                return query;
            }
        }

        public bool EditTeacherAccount(TeacherModel model, string oldUserName)
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
                p.Add("OldUserName", oldUserName);

                var b = new DynamicParameters();
                b.Add("UserName", model.UserName);
                b.Add("OldUserName", oldUserName);

                var d = new DynamicParameters();
                d.Add("UserName", model.UserName);
                d.Add("@UpdatedCounter", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Execute("dbo.spUser_Check", d, commandType: CommandType.StoredProcedure);
                int rows = d.Get<int>("@UpdatedCounter");
                if (rows == 0 || oldUserName == model.UserName)
                {
                    connection.Execute("dbo.spUser_Update", b, commandType: CommandType.StoredProcedure);
                    connection.Execute("dbo.spTeacher_Update", p, commandType: CommandType.StoredProcedure);
                    query = true;
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

                var d = new DynamicParameters();
                d.Add("UserName", model.UserName);
                d.Add("@UpdatedCounter", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Execute("dbo.spUser_Check", d, commandType: CommandType.StoredProcedure);
                int rows = d.Get<int>("@UpdatedCounter");
                if (rows == 0)
                {
                    query = true;
                    connection.Execute("dbo.spAdmin_Insert", p, commandType: CommandType.StoredProcedure);
                }
                return query;
            }
        }

        public bool AdminLogin(string userName, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                bool query = false;
                var d = new DynamicParameters();
                d.Add("UserName", userName);
                d.Add("Password", password);
                d.Add("@UpdatedCounter", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Execute("dbo.spAdmin_Check", d, commandType: CommandType.StoredProcedure);
                int rows = d.Get<int>("@UpdatedCounter");
                if (rows == 1)
                {
                    query = true;
                }
                return query;
            }
        }

        public bool EditAdminAccount(AdminModel model, string oldUserName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                bool query = false;
                var p = new DynamicParameters();
                p.Add("FirstName", model.FirstName);
                p.Add("LastName", model.LastName);
                p.Add("UserName", model.UserName);
                p.Add("Password", model.Password);
                p.Add("OldUserName", oldUserName);

                var b = new DynamicParameters();
                b.Add("UserName", model.UserName);
                b.Add("OldUserName", oldUserName);

                var d = new DynamicParameters();
                d.Add("UserName", model.UserName);
                d.Add("@UpdatedCounter", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Execute("dbo.spUser_Check", d, commandType: CommandType.StoredProcedure);
                int rows = d.Get<int>("@UpdatedCounter");
                if (rows == 0 || oldUserName == model.UserName)
                {
                    connection.Execute("dbo.spUser_Update", b, commandType: CommandType.StoredProcedure);
                    connection.Execute("dbo.spAdmin_Update", p, commandType: CommandType.StoredProcedure);
                    query = true;
                }                
                return query;
            }
        }

        public void CreateQuestion(QuestionModel model)
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
            }
        }

        public void CreateExam(ExamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                var p = new DynamicParameters();
                p.Add("AccessCode", model.AccessCode);
                p.Add("Creator", model.Creator);
                p.Add("Name", model.Name);
                p.Add("NumberOfQuestions", model.QuestionAmount);
               
                connection.Execute("dbo.spExam_Insert", p, commandType: CommandType.StoredProcedure);                
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

        public void UpdateExam(ExamModel model1, ExamModel model2)
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
            }
        }

        public void UpdateQuestion(QuestionModel model1, ExamModel model2)
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
            }
        }
        public void CreateResult(ResultModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                var p = new DynamicParameters();
                p.Add("ExamName", model.ExamName);
                p.Add("StudentUserName", model.StudentUserName);
                p.Add("Score", model.Score);
                p.Add("ExamDate", model.Data);
                connection.Execute("dbo.spResult_Insert", p, commandType: CommandType.StoredProcedure);

                var d = new DynamicParameters();
                d.Add("ExamName", model.ExamName);
                d.Add("StudentUserName", model.StudentUserName);
                d.Add("@UpdatedCounter", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
                connection.Execute("dbo.spStudentCourses_Check", d, commandType: CommandType.StoredProcedure);
                int rows = d.Get<int>("@UpdatedCounter");

                var b = new DynamicParameters();
                b.Add("ExamName", model.ExamName);
                b.Add("ExamCreator", model.ExamCreator);
                b.Add("StudentUserName", model.StudentUserName);
                if (rows == 0)
                {
                    connection.Execute("dbo.spStudentCourses_Insert", b, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public List<ResultModel> GetResults()
        {
            List<ResultModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                output = connection.Query<ResultModel>("dbo.spResult_Get").ToList();
            }
            return output;
        }

        public List<ResultModel> GetStudentCourses()
        {
            List<ResultModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Examination System")))
            {
                output = connection.Query<ResultModel>("dbo.spStudentCourses_Get").ToList();
            }
            return output;
        }
    }
}
