using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary
{
    /// <summary>
    /// Represents model of student.
    /// </summary>
    public class StudentModel : UserModel
    {
        /// <summary>
        /// Student's id.
        /// </summary>
        public string StudentId { get; set; }
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
    }
}
