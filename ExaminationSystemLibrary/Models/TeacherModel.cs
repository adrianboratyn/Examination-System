using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    public class TeacherModel : UserModel
    {
        public string Role = "Teacher";
        public string AcademicTitle { get; set; }
        public string School { get; set; }
        public List<ExamModel> CreatedExams { get; set; } = new List<ExamModel>();
        public TeacherModel()
        {

        }
        public TeacherModel(string fN, string lN, string uN, string p, string s, string aT)
        {
            FirstName = fN;
            LastName = lN;
            UserName = uN;
            Password = p;
            School = s;
            AcademicTitle = aT;
        }
    }
}
