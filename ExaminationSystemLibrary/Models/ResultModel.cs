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
    }
}
