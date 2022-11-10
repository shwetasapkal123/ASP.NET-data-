using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class TestException
    {
        public static void TestArgumentNullException(string name)
        {
            try
            {
                if (name == null)
                {
                    Console.WriteLine(name.Length);
                    //throw new ArgumentNullException("name");
                }
            }
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    //throw new NullReferenceException();
            //}
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public static void TestArgumentOutOfRange(string name)
        {
            //string name = "Shweta";
            try
            {
                string res = name.Substring( 2);
                Console.WriteLine(res);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
