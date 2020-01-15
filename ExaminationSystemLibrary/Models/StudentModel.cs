using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    public class StudentModel : UserModel
    {
        public string Role = "Student";
        public int Age { get; set; }
        public string School { get; set; }
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
