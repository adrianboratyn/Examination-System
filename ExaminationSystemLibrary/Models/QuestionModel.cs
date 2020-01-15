using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    public class QuestionModel
    {
        public string Question { get; set; }
        public int QuestionNumber { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
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
