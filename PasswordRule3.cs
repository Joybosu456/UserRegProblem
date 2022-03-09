using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegProblem
{
    public class PasswordRule3
    {
        /// <summary>
        /// The regex pattern
        /// UC7-Joy.
        /// </summary>
        public static string Regex_Pattern = "^[a-z A-Z 0-9]{8,}$";
        public bool validatePasswordRule3(string passwordrule3)
        {
            return Regex.IsMatch(passwordrule3, Regex_Pattern);
        }
    }
}
