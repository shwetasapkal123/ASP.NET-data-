using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class AnagramProgram
    {
        public static void Anagrametection()
        {
            string str1 = "heart";
            string str2 = "Eartha";

            char[] ch1=str1.ToLower().ToCharArray();
            char[] ch2=str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            String val1 = new String(ch1);
            String val2 = new String(ch2);

            Console.WriteLine(val1+"  "+val2);

            if(val1==val2)
                Console.WriteLine("anagram");
            else
                Console.WriteLine("Not anagram");

        }
    }
}
