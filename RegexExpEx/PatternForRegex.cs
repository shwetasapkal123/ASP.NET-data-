using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExpEx
{
    public class PatternForRegex
    {
        public static void ValidFirstName()
        {
            Console.WriteLine("Enter your name");
            string firstName=Console.ReadLine();

            string pattern = "^[A-Za-z]{8}$";

            if(Regex.IsMatch(firstName,pattern))
            {
                Console.WriteLine("Vlid first name");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
