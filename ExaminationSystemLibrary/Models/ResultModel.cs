using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    /// <summary>
    /// Represents result of exam.
    /// </summary>
    public class ResultModel
    {
        public string Data { get; set; }
        public string ExamCreator { get; set; }
        /// <summary>
        /// A student who took the exam.
        /// </summary>
        public string StudentUserName { get; set; }
        /// <summary>
        /// An exam which was taken.
        /// </summary>
        public string ExamName { get; set; }
        /// <summary>
        /// Student's score (amount of points).
        /// </summary>
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
