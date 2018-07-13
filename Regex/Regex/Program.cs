using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexTestProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //\b \b - word;
            //^$ - line;
            // \d - decemical;
            // \w - letter;
            // \. - .;
            //+ - one or more;
            //* - zero or more;

            string[] values = { "222-21-2222", "111-11-1111", "333-33-3333","11-333-1111","5555-22-4444","-.22-7777" };
            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            ResultString result = new ResultString();
            result = RegexFuncForExample.Validation(values, pattern);

            Console.WriteLine(result.ToString());

            string value2 = "This is a a a farm that that that raises dairy cattle.";
            string pattern2 = @"\b(\w+)\W+(\1)\b";

            foreach(Match m in Regex.Matches(value2, pattern2))
            {
                Console.WriteLine($"Found match : {m.Groups[1].Value} in pos {m.Groups[2].Index} ");
            }

            string value3 = "Total Coast : 1111.444";
            string pattern3 = @"\b\d+\.\d{3}\b";
            string rep = "$$$&";
            Console.WriteLine("\n\n" + Regex.Replace(value3, pattern3, rep) + "\n\n");

            string value4 = "1. Aren 2. Bread 3. Rslan 4. Europia 5. Jack 6. Sempai";
            string pattern4 = @"\b\d{1,3}\.\s\b";

            Console.WriteLine("Split result : ");

            foreach(string splitRes in Regex.Split(value4, pattern4))
            {
                Console.WriteLine(splitRes);
            }

            Console.ReadKey();
        }
    }
}
