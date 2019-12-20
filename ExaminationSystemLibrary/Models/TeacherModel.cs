using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    /// <summary>
    /// Represents model of teacher.
    /// </summary>
    public class TeacherModel : UserModel
    {
        /// <summary>
        /// User's role.
        /// </summary>
        public string Role = "Teacher";
        /// <summary>
        /// Teacher's academic title.
        /// </summary>
        public string AcademicTitle { get; set; }
        /// <summary>
        /// Name of school in which teacher works.
        /// </summary>
        public string School { get; set; }
        /// <summary>
        /// A list of exams created by this teacher.
        /// </summary>
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
