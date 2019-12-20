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
        /// <summary>
        /// A day when exam was taken.
        /// </summary>
        public DateTime DayOfExam { get; set; }
        /// <summary>
        /// A student who took the exam.
        /// </summary>
        public StudentModel Student { get; set; }
        /// <summary>
        /// An exam which was taken.
        /// </summary>
        public ExamModel Exam { get; set; }
        /// <summary>
        /// Duration of exam.
        /// </summary>
        public DateTime Duration { get; set; }
        /// <summary>
        /// Student's score (amount of points).
        /// </summary>
        public int Score { get; set; }
    }
}
