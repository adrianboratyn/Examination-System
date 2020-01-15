using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    public class AdminModel : UserModel
    {
        public string Role = "Admin";
        public List<ExamModel> ExamList { get; set; } = new List<ExamModel>();
        public List<ExamModel> CreatedExams { get; set; } = new List<ExamModel>();
        public AdminModel()
        {

        }
        public AdminModel(string fN, string lN, string uN, string p)
        {
            FirstName = fN;
            LastName = lN;
            UserName = uN;
            Password = p;
        }
    }
}
