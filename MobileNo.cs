using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegProblem
{
    public class MobileNo
    {
        public static String Regex_MobileNo = "^[+91]{3}[' ']*[7-9]{1}[0-9]{9}$";
        public bool validateMobileBNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, Regex_MobileNo);
        }
    }
}
