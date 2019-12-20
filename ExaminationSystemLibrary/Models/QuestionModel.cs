using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
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
        public int QuestionNumber { get; set; }
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
        public string CorrectAnswer { get; set; }

        public string ExamName { get; set; }

        public QuestionModel()
        {

        }

        public QuestionModel(string eN, string q, int qN, string aA, string aB, string aC, string aD, string cA)
        {
            ExamName = eN;
            Question = q;
            QuestionNumber = qN;
            AnswerA = aA;
            AnswerB = aB;
            AnswerC = aC;
            AnswerD = aD;
            CorrectAnswer = cA;
        }

        public string FullName
        {
            get
            {
                return $"{QuestionNumber } { Question}";
            }
        }
    }
}
