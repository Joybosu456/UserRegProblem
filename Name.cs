using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegProblem
{
    public class Name
    {
        /// <summary>
        /// The regex First Name
        /// UC1-Joy
        /// </summary>
        public static String Regex_Name = "^[A-Z]{3}";

       
        public bool validateName(string Name)
        {
            return Regex.IsMatch(Name, Regex_Name);
        }
    }
}
