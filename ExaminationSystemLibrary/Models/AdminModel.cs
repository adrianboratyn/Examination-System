using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    /// <summary>
    /// Represents model of admin.
    /// </summary>
    public class AdminModel : UserModel
    {
        /// <summary>
        /// User's role.
        /// </summary>
        public string Role = "Admin";
        /// <summary>
        /// List of all exams created in this application.
        /// </summary>
        public List<ExamModel> ExamList { get; set; } = new List<ExamModel>();
        /// <summary>
        /// List of exams created by this admin.
        /// </summary>
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
