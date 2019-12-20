using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystemLibrary.Models
{
    /// <summary>
    /// Represents general model of user.
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// User's first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// User's last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Username.
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// User's password.
        /// </summary>
        public string Password { get; set; }
    }
}
