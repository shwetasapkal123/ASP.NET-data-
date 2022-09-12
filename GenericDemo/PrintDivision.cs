using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class PrintDivision
    {
        //dynamic 
        public int DivisionMethod<T>(T a, T b)
        {
            //var res = a * b;
            dynamic a1 = a;
            dynamic b1 = b;

            dynamic res = a1 / b1;

            Console.WriteLine("Division is "+res);
            return default;
        }
    }
}
