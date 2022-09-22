using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            TestException.TestArgumentException("Shweta");
            //try
            //{
            //    Console.WriteLine("Enter 1st number ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter 2nd number ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
                
            //    arr[0] = 1;
            //    arr[1] = 2;
            //    arr[2] = 3;
            //    int res = num1 / num2;
                
                
            //    Console.WriteLine(res);
            //}
            
           
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ////catch(DivideByZeroException e)
            ////{
            ////    Console.WriteLine(e.Message);
            ////}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}
           
            

            
        }
    }
}
