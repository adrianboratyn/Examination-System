using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary
{
    /// <summary>
    /// Represents model of single question.
    /// </summary>
    public class QuestionModel
    {
        /// <summary>
        /// The content of the question.
        /// </summary>
        public string Question { get; set; }
        /// <summary>
        /// Question's number.
        /// </summary>
        public string QuestionNumber { get; set; }
        /// <summary>
        /// First potential answer.
        /// </summary>
        public string AnswerA { get; set; }
        /// <summary>
        /// Second potential answer.
        /// </summary>
        public string AnswerB { get; set; }
        /// <summary>
        /// Third potential answer.
        /// </summary>
        public string AnswerC { get; set; }
        /// <summary>
        /// Fourth potential answer.
        /// </summary>
        public string AnswerD { get; set; }
        /// <summary>
        /// The character of correct answer.
        /// </summary>
        public char CorrectAnswer { get; set; }
    }
}
