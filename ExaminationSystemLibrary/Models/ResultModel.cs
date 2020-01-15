using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    public class ResultModel
    {
        public DateTime Data { get; set; }
        public string ExamCreator { get; set; }
        public string StudentUserName { get; set; }
        public string ExamName { get; set; }
        public int Score { get; set; }
        public string resultForStudent
        {
            get
            {
                return $"{Data } {" Exam: "} {ExamName} {" Score: "} {Score}";
            }
        }
        public string studentName
        {
            get
            {
                return $"{StudentUserName} ";
            }
        }
        public string resultForTeacher
        {
            get
            {
                return $"{Data } {"  Exam: "} {ExamName} {" Student: "} {StudentUserName} {" Score: "} {Score}";
            }
        }
        public string resultForAdmin
        {
            get
            {
                return $"{ExamName } {"  Creator: "} {ExamCreator} {"  Student: "} {StudentUserName} {"  Score: "} {Score}";
            }
        }
        public string studentResult
        {
            get
            {
                return $"{ExamName } {"  Student: "} {StudentUserName} {"  Score: "} {Score}";
            }
        }
    }
}
