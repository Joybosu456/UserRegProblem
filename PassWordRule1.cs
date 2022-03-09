using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegProblem
{
    public class PassWordRule1
    {/// <summary>
    /// UC5-PassWord Rule 1.
    /// </summary>
        public static string Regex_Pattern = "^[a-z]{8,}$";
        public bool validatePasswordRule1(string passwordrule1)
        {
            return Regex.IsMatch(passwordrule1, Regex_Pattern);
        }
    }
}
