using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
    public class TestException
    {
        public static void TestArgumentException(string name)
        {
            try
            {
                //"shweta"
                string res = name.Substring(name.Length+2);
                Console.WriteLine(res);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
