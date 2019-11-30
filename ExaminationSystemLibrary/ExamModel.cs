using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary
{
    /// <summary>
    /// Represents model of exam.
    /// </summary>
    public class ExamModel
    {
        /// <summary>
        /// Exam's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Amount of question in the exam.
        /// </summary>
        public int QuestionAmount { get; set; }
        /// <summary>
        /// Exam's access code.
        /// </summary>
        public string AccessCode { get; set; }
        /// <summary>
        /// List of question in the exam.
        /// </summary>
        public List<QuestionModel> QuestionList { get; set } = new List<QuestionModel>();
    }
}
