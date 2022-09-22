using System;
using System.Collections.Generic;
using System.Text;

namespace MSTestingDemo
{
    public class Add
    {
        public int SumOfNumbers(int a, int b )
        {
            int sum = 0;
            if (a == 0)
                return b;
            else if (b == 0)
                return a;
            else
            {
                sum = a + b;
                return sum;
            }
            
        }
        
    }
}
