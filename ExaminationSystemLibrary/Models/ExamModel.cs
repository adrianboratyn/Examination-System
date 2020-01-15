using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    public class ExamModel
    {
        public string Creator { get; set; }
        public string Name { get; set; }
        public int QuestionAmount { get; set; }
        public int AccessCode { get; set; }
        public List<QuestionModel> QuestionList { get; set; } = new List<QuestionModel>();
        public string examName
        {
            get
            {
                return $"{Name}";
            }
        }
        public string examAndCreator
        {
            get
            {
                return $"{Name   } { "        Creator:  " } {   Creator}";
            }
        }
        public string examAndCode
        {
            get
            {
                return $"{Name } {"          Access Code:  "}{ AccessCode}";
            }
        }
    }
}
