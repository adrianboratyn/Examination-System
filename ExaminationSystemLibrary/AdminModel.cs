using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary
{
    /// <summary>
    /// Represents model of admin.
    /// </summary>
    public class AdminModel : UserModel
    {
        /// <summary>
        /// Admin's id.
        /// </summary>
        public string AdminId { get; set; }
        /// <summary>
        /// List of all exams created in this application.
        /// </summary>
        public List<ExamModel> ExamList { get; set; } = new List<ExamModel>();
        /// <summary>
        /// List of exams created by this admin.
        /// </summary>
        public List<ExamModel> CreatedExams { get; set; } = new List<ExamModel>();
    }
}
