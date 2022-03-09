using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegProblem
{
    public class LastName
    {
        /// <summary>
        /// The regex last name
        /// UC2-Joy
        /// </summary>
        public static String Regex_LastName = "^[A-Z]{1}[a-z]{3,}$";


        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
    }
}
