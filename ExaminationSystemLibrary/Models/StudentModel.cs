using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    /// <summary>
    /// Represents model of student.
    /// </summary>
    public class StudentModel : UserModel
    {
        /// <summary>
        /// User's role.
        /// </summary>
        public string Role = "Student";
        /// <summary>
        /// Student's age.
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// A school which student attends.
        /// </summary>
        public string School { get; set; }
        /// <summary>
        /// Student's degree course.
        /// </summary>
        public string DegreeCourse { get; set; }

        public StudentModel()
        {

        }

        public StudentModel(string fN, string lN, string uN, string p, string a, string s, string dC)
        {
            FirstName = fN;
            LastName = lN;
            UserName = uN;
            Password = p;

            int ageNumber = 0;
            int.TryParse(a, out ageNumber);
            Age = ageNumber;

            School = s;
            DegreeCourse = dC;
        }

    }
}
