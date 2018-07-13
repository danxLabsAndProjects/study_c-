using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexTestProgram
{
    class RegexFuncForExample
    {
        public static ResultString Validation(string[] values, string pattern)
        {
            ResultString result = new ResultString(values);
            return Search(result, pattern);
        }

        public static ResultString Validation(string values, string pattern)
        {
            ResultString result = new ResultString(values);
            return Search(result , pattern);
        }

        private static ResultString Search(ResultString res, string pattern)
        {
            StringBuilder validString = new StringBuilder();
            StringBuilder inValidString = new StringBuilder();

            foreach(string s in res.Values)
            {
                if(Regex.IsMatch(s, pattern))
                {
                    validString.Append(s + ", ");
                }
                else
                {
                    inValidString.Append(s + ", ");
                }
            }
            res.ValidValue = validString.Remove(validString.Length - 2, 1).ToString();
            res.InValidValue = inValidString.Remove(inValidString.Length  - 2, 1).ToString();

            return res;
        }
    }
}
