using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary
{
    /// <summary>
    /// Represents model of teacher.
    /// </summary>
    public class TeacherModel : UserModel
    {
        /// <summary>
        /// Teacher's id.
        /// </summary>
        public string TeacherId { get; set; }
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
    }
}
