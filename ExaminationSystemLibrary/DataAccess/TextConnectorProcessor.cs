using ExaminationSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.DataAccess.TextHelpers
{
    // class need to create extension method
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) // extension method -> fileName.FullFilePath()
        {
            return $"{ ConfigurationManager.AppSettings["filePath"]}\\{ fileName }";
            
        }

        public static List<string> LoadFile(this string file)
        {
            if(File.Exists(file) == false)
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        //Code for create StudentAccountFile
        public static List<StudentModel> ConvertToStudentModels(this List<String> lines)
        {
            List<StudentModel> output = new List<StudentModel>();

            foreach(string line in lines)
            {
                string[] columns = line.Split(',');

                StudentModel model = new StudentModel();
                model.FirstName = columns[0];
                model.LastName = columns[1];
                model.UserName = columns[2];
                model.Password = columns[3];
                model.Age = int.Parse(columns[4]);
                model.School = columns[5];
                model.DegreeCourse = columns[6];

                output.Add(model);
            }
            return output;
        }

        public static void SaveToStudentFile(this List<StudentModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach(StudentModel model in models)
            {
                lines.Add($"{ model.FirstName },{ model.LastName },{ model.UserName },{ model.Password },{ model.Age },{ model.School },{ model.DegreeCourse }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        //Code for create TeacherAccountFile
        public static List<TeacherModel> ConvertToTeacherModels(this List<String> lines)
        {
            List<TeacherModel> output = new List<TeacherModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                TeacherModel model = new TeacherModel();
                model.FirstName = columns[0];
                model.LastName = columns[1];
                model.UserName = columns[2];
                model.Password = columns[3];
                model.AcademicTitle = columns[4];
                model.School = columns[5];

                output.Add(model);
            }
            return output;
        }

        public static void SaveToTeacherFile(this List<TeacherModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TeacherModel model in models)
            {
                lines.Add($"{ model.FirstName },{ model.LastName },{ model.UserName },{ model.Password },{ model.AcademicTitle },{ model.School }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        //code for create AdminAccountFile
        public static List<AdminModel> ConvertToAdminModels(this List<String> lines)
        {
            List<AdminModel> output = new List<AdminModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                AdminModel model = new AdminModel();
                model.FirstName = columns[0];
                model.LastName = columns[1];
                model.UserName = columns[2];
                model.Password = columns[3];               

                output.Add(model);
            }
            return output;
        }

        public static void SaveToAdminFile(this List<AdminModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (AdminModel model in models)
            {
                lines.Add($"{ model.FirstName },{ model.LastName },{ model.UserName },{ model.Password }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        //code for create QuestionsListFile
        public static List<QuestionModel> ConvertToQuestionModels(this List<String> lines)
        {
            List<QuestionModel> output = new List<QuestionModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                QuestionModel model = new QuestionModel();
                model.ExamName = columns[0];
                model.Question = columns[1];
                model.QuestionNumber = int.Parse(columns[2]);
                model.AnswerA = columns[3];
                model.AnswerB = columns[4];
                model.AnswerC = columns[5];
                model.AnswerD = columns[6];
                model.CorrectAnswer = columns[7];


                output.Add(model);
            }
            return output;
        }

        public static void SaveToQuestionFile(this List<QuestionModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (QuestionModel model in models)
            {
                lines.Add($"{ model.ExamName },{ model.Question },{ model.QuestionNumber },{ model.AnswerA },{ model.AnswerB },{ model.AnswerC },{ model.AnswerD },{ model.CorrectAnswer }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        //code for create ExamsListFile
        public static List<ExamModel> ConvertToExamModels(this List<String> lines)
        {
            List<ExamModel> output = new List<ExamModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                ExamModel model = new ExamModel();
                model.AccessCode = int.Parse(columns[0]);
                model.Creator = columns[1];
                model.Name = columns[2];
                model.QuestionAmount = int.Parse(columns[3]);
               

                output.Add(model);
            }
            return output;
        }

        public static void SaveToExamFile(this List<ExamModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (ExamModel model in models)
            {
                lines.Add($"{ model.AccessCode },{ model.Creator },{ model.Name },{ model.QuestionAmount }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
