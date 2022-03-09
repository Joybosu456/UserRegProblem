using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegProblem
{
    public class Email
    {
        /// <summary>
        /// The regex email
        /// UC3-Joy.
        /// </summary>
        public static String Regex_Email = "^[a-z]{3,}[.]*[a-z]{0,}[@][a-z 1-9]{1,}[.][a-z]{2,}[.]*[a-z]{0,}";


        public bool validateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
    }
}
